using System;
using System.Collections.Generic;

namespace Anura.Typography.OpenFont.CFF {
    public class CffEvaluationEngine {
        private class PxScaleGlyphTx : IGlyphTranslator {
            private float _scale;

            private IGlyphTranslator _tx;

            private bool _is_contour_opened;

            public bool IsContourOpened => _is_contour_opened;

            public PxScaleGlyphTx (float scale, IGlyphTranslator tx) {
                _scale = scale;
                _tx = tx;
            }

            public void BeginRead (int contourCount) {
                _tx.BeginRead (contourCount);
            }

            public void CloseContour () {
                _is_contour_opened = false;
                _tx.CloseContour ();
            }

            public void Curve3 (float x1, float y1, float x2, float y2) {
                _is_contour_opened = true;
                _tx.Curve3 (x1 * _scale, y1 * _scale, x2 * _scale, y2 * _scale);
            }

            public void Curve4 (float x1, float y1, float x2, float y2, float x3, float y3) {
                _is_contour_opened = true;
                _tx.Curve4 (x1 * _scale, y1 * _scale, x2 * _scale, y2 * _scale, x3 * _scale, y3 * _scale);
            }

            public void EndRead () {
                _tx.EndRead ();
            }

            public void LineTo (float x1, float y1) {
                _is_contour_opened = true;
                _tx.LineTo (x1 * _scale, y1 * _scale);
            }

            public void MoveTo (float x0, float y0) {
                _tx.MoveTo (x0 * _scale, y0 * _scale);
            }
        }

        private Cff1Font _cff1Font;

        private int _cffBias;

        private float _scale = 1f;

        private Stack<Type2EvaluationStack> _evalStackPool = new Stack<Type2EvaluationStack> ();

        public void Run (IGlyphTranslator tx, Cff1Font cff1Font, Cff1GlyphData glyphData, float scale = 1f) {
            Run (tx, cff1Font, glyphData.GlyphInstructions, scale);
        }

        internal void Run (IGlyphTranslator tx, Cff1Font cff1Font, Type2GlyphInstructionList instructionList, float scale = 1f) {
            _cff1Font = cff1Font;
            _scale = scale;
            int count = cff1Font._localSubrs.Count;
            _cffBias = ((count < 1240) ? 107 : ((count < 33900) ? 1131 : 32769));
            double currentX = 0.0;
            double currentY = 0.0;
            PxScaleGlyphTx pxScaleGlyphTx = new PxScaleGlyphTx (scale, tx);
            pxScaleGlyphTx.BeginRead (0);
            Run (pxScaleGlyphTx, instructionList, ref currentX, ref currentY);
            if (pxScaleGlyphTx.IsContourOpened) {
                pxScaleGlyphTx.CloseContour ();
            }
            pxScaleGlyphTx.EndRead ();
        }

        private void Run (IGlyphTranslator tx, Type2GlyphInstructionList instructionList, ref double currentX, ref double currentY) {
            Type2EvaluationStack freeEvalStack = GetFreeEvalStack ();
            freeEvalStack._currentX = currentX;
            freeEvalStack._currentY = currentY;
            List<Type2Instruction> insts = instructionList.Insts;
            freeEvalStack.GlyphTranslator = tx;
            int count = insts.Count;
            for (int i = 0; i < count; i++) {
                Type2Instruction type2Instruction = insts[i];
                switch (type2Instruction.Op) {
                    default : throw new NotSupportedException ();
                    case OperatorName.LoadInt:
                            freeEvalStack.Push (type2Instruction.Value);
                        break;
                    case OperatorName.endchar:
                            freeEvalStack.EndChar ();
                        break;
                    case OperatorName.flex:
                            freeEvalStack.Flex ();
                        break;
                    case OperatorName.hflex:
                            freeEvalStack.H_Flex ();
                        break;
                    case OperatorName.hflex1:
                            freeEvalStack.H_Flex1 ();
                        break;
                    case OperatorName.flex1:
                            freeEvalStack.Flex1 ();
                        break;
                    case OperatorName.abs:
                            freeEvalStack.Op_Abs ();
                        break;
                    case OperatorName.add:
                            freeEvalStack.Op_Add ();
                        break;
                    case OperatorName.sub:
                            freeEvalStack.Op_Sub ();
                        break;
                    case OperatorName.div:
                            freeEvalStack.Op_Div ();
                        break;
                    case OperatorName.neg:
                            freeEvalStack.Op_Neg ();
                        break;
                    case OperatorName.random:
                            freeEvalStack.Op_Random ();
                        break;
                    case OperatorName.mul:
                            freeEvalStack.Op_Mul ();
                        break;
                    case OperatorName.sqrt:
                            freeEvalStack.Op_Sqrt ();
                        break;
                    case OperatorName.drop:
                            freeEvalStack.Op_Drop ();
                        break;
                    case OperatorName.exch:
                            freeEvalStack.Op_Exch ();
                        break;
                    case OperatorName.index:
                            freeEvalStack.Op_Index ();
                        break;
                    case OperatorName.roll:
                            freeEvalStack.Op_Roll ();
                        break;
                    case OperatorName.dup:
                            freeEvalStack.Op_Dup ();
                        break;
                    case OperatorName.put:
                            freeEvalStack.Put ();
                        break;
                    case OperatorName.get:
                            freeEvalStack.Get ();
                        break;
                    case OperatorName.and:
                            freeEvalStack.Op_And ();
                        break;
                    case OperatorName.or:
                            freeEvalStack.Op_Or ();
                        break;
                    case OperatorName.not:
                            freeEvalStack.Op_Not ();
                        break;
                    case OperatorName.eq:
                            freeEvalStack.Op_Eq ();
                        break;
                    case OperatorName.ifelse:
                            freeEvalStack.Op_IfElse ();
                        break;
                    case OperatorName.rlineto:
                            freeEvalStack.R_LineTo ();
                        break;
                    case OperatorName.hlineto:
                            freeEvalStack.H_LineTo ();
                        break;
                    case OperatorName.vlineto:
                            freeEvalStack.V_LineTo ();
                        break;
                    case OperatorName.rrcurveto:
                            freeEvalStack.RR_CurveTo ();
                        break;
                    case OperatorName.hhcurveto:
                            freeEvalStack.HH_CurveTo ();
                        break;
                    case OperatorName.hvcurveto:
                            freeEvalStack.HV_CurveTo ();
                        break;
                    case OperatorName.rcurveline:
                            freeEvalStack.R_CurveLine ();
                        break;
                    case OperatorName.rlinecurve:
                            freeEvalStack.R_LineCurve ();
                        break;
                    case OperatorName.vhcurveto:
                            freeEvalStack.VH_CurveTo ();
                        break;
                    case OperatorName.vvcurveto:
                            freeEvalStack.VV_CurveTo ();
                        break;
                    case OperatorName.rmoveto:
                            freeEvalStack.R_MoveTo ();
                        break;
                    case OperatorName.hmoveto:
                            freeEvalStack.H_MoveTo ();
                        break;
                    case OperatorName.vmoveto:
                            freeEvalStack.V_MoveTo ();
                        break;
                    case OperatorName.hstem:
                            freeEvalStack.H_Stem ();
                        break;
                    case OperatorName.vstem:
                            freeEvalStack.V_Stem ();
                        break;
                    case OperatorName.vstemhm:
                            freeEvalStack.V_StemHM ();
                        break;
                    case OperatorName.hstemhm:
                            freeEvalStack.H_StemHM ();
                        break;
                    case OperatorName.hintmask1:
                            freeEvalStack.HintMask1 (type2Instruction.Value);
                        break;
                    case OperatorName.hintmask2:
                            freeEvalStack.HintMask2 (type2Instruction.Value);
                        break;
                    case OperatorName.hintmask3:
                            freeEvalStack.HintMask3 (type2Instruction.Value);
                        break;
                    case OperatorName.hintmask4:
                            freeEvalStack.HintMask4 (type2Instruction.Value);
                        break;
                    case OperatorName.hintmask_bits:
                            freeEvalStack.HintMaskBits (type2Instruction.Value);
                        break;
                    case OperatorName.cntrmask1:
                            freeEvalStack.CounterSpaceMask1 (type2Instruction.Value);
                        break;
                    case OperatorName.cntrmask2:
                            freeEvalStack.CounterSpaceMask2 (type2Instruction.Value);
                        break;
                    case OperatorName.cntrmask3:
                            freeEvalStack.CounterSpaceMask3 (type2Instruction.Value);
                        break;
                    case OperatorName.cntrmask4:
                            freeEvalStack.CounterSpaceMask4 (type2Instruction.Value);
                        break;
                    case OperatorName.cntrmask_bits:
                            freeEvalStack.CounterSpaceMaskBits (type2Instruction.Value);
                        break;
                    case OperatorName._return:
                            currentX = freeEvalStack._currentX;
                        currentY = freeEvalStack._currentY;
                        freeEvalStack.Ret ();
                        break;
                    case OperatorName.callsubr:
                        {
                            int num = (int) freeEvalStack.Pop ();
                            Type2GlyphInstructionList instructionList2 = _cff1Font._localSubrs[num + _cffBias];
                            Run (tx, instructionList2, ref freeEvalStack._currentX, ref freeEvalStack._currentY);
                            break;
                        }
                    case OperatorName.callgsubr:
                            throw new NotSupportedException ();
                    case OperatorName.GlyphWidth:
                            break;
                }
            }
            ReleaseEvalStack (freeEvalStack);
        }

        private Type2EvaluationStack GetFreeEvalStack () {
            if (_evalStackPool.Count > 0) {
                return _evalStackPool.Pop ();
            }
            return new Type2EvaluationStack ();
        }

        private void ReleaseEvalStack (Type2EvaluationStack evalStack) {
            evalStack.Reset ();
            _evalStackPool.Push (evalStack);
        }
    }
}