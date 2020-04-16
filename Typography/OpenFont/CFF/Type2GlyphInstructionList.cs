using System;
using System.Collections.Generic;

namespace Anura.Typography.OpenFont.CFF {
    internal class Type2GlyphInstructionList {
        private List<Type2Instruction> _insts;

        public List<Type2Instruction> Insts => _insts;

        public Type2GlyphInstructionListKind Kind {
            get;
            set;
        }

        public Type2GlyphInstructionList () {
            _insts = new List<Type2Instruction> ();
        }

        public void AddInt (int intValue) {
            _insts.Add (new Type2Instruction (OperatorName.LoadInt, intValue));
        }

        public void AddOp (OperatorName opName) {
            _insts.Add (new Type2Instruction (opName));
        }

        public void AddOp (OperatorName opName, int value) {
            _insts.Add (new Type2Instruction (opName, value));
        }

        internal void ChangeFirstInstToGlyphWidthValue () {
            Type2Instruction type2Instruction = _insts[0];
            if (type2Instruction.Op != OperatorName.LoadInt) {
                throw new NotSupportedException ();
            }
            _insts[0] = new Type2Instruction (OperatorName.GlyphWidth, type2Instruction.Value);
        }
    }
}