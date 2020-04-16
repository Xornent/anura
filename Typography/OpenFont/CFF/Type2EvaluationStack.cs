using System;

namespace Anura.Typography.OpenFont.CFF {
    internal class Type2EvaluationStack {
        internal double _currentX;

        internal double _currentY;

        private double[] _argStack = new double[50];

        private int _currentIndex;

        private IGlyphTranslator _glyphTranslator;

        public IGlyphTranslator GlyphTranslator {
            get {
                return _glyphTranslator;
            }
            set {
                _glyphTranslator = value;
            }
        }

        public void Reset () {
            _currentIndex = 0;
            _currentX = (_currentY = 0.0);
            _glyphTranslator = null;
        }

        public void Push (double value) {
            _argStack[_currentIndex] = value;
            _currentIndex++;
        }

        public void Push (int value) {
            _argStack[_currentIndex] = value;
            _currentIndex++;
        }

        public void R_MoveTo () {
            int i = 0;
            if (_currentIndex % 2 != 0) {
                i = 1;
            }
            for (; i < _currentIndex; i += 2) {
                _currentX += _argStack[i];
                _currentY += _argStack[i + 1];
            }
            _glyphTranslator.MoveTo ((float) _currentX, (float) _currentY);
            _currentIndex = 0;
        }

        public void H_MoveTo () {
            double num = 0.0;
            int num2 = 0;
            for (int num3 = _currentIndex; num3 >= 1; num3--) {
                num += _argStack[num2];
                num2++;
            }
            _glyphTranslator.MoveTo ((float) (_currentX += num), (float) _currentY);
            _currentIndex = 0;
        }

        public void V_MoveTo () {
            double num = 0.0;
            int num2 = 0;
            for (int num3 = _currentIndex; num3 >= 1; num3--) {
                num += _argStack[num2];
                num2++;
            }
            _glyphTranslator.MoveTo ((float) _currentX, (float) (_currentY += num));
            _currentIndex = 0;
        }

        public void R_LineTo () {
            for (int i = 0; i < _currentIndex; i += 2) {
                _glyphTranslator.LineTo ((float) (_currentX += _argStack[i]), (float) (_currentY += _argStack[i + 1]));
            }
            _currentIndex = 0;
        }

        public void H_LineTo () {
            int i = 0;
            if (_currentIndex % 2 != 0) {
                _glyphTranslator.LineTo ((float) (_currentX += _argStack[i]), (float) _currentY);
                for (i++; i < _currentIndex; i += 2) {
                    _glyphTranslator.LineTo ((float) _currentX, (float) (_currentY += _argStack[i]));
                    _glyphTranslator.LineTo ((float) (_currentX += _argStack[i + 1]), (float) _currentY);
                }
            } else {
                for (; i < _currentIndex; i += 2) {
                    _glyphTranslator.LineTo ((float) (_currentX += _argStack[i]), (float) _currentY);
                    _glyphTranslator.LineTo ((float) _currentX, (float) (_currentY += _argStack[i + 1]));
                }
            }
            _currentIndex = 0;
        }

        public void V_LineTo () {
            int i = 0;
            if (_currentIndex % 2 != 0) {
                _glyphTranslator.LineTo ((float) _currentX, (float) (_currentY += _argStack[i]));
                for (i++; i < _currentIndex; i += 2) {
                    _glyphTranslator.LineTo ((float) (_currentX += _argStack[i]), (float) _currentY);
                    _glyphTranslator.LineTo ((float) _currentX, (float) (_currentY += _argStack[i + 1]));
                }
            } else {
                for (; i < _currentIndex; i += 2) {
                    _glyphTranslator.LineTo ((float) _currentX, (float) (_currentY += _argStack[i]));
                    _glyphTranslator.LineTo ((float) (_currentX += _argStack[i + 1]), (float) _currentY);
                }
            }
            _currentIndex = 0;
        }

        public void RR_CurveTo () {
            int i = 0;
            double num = _currentX;
            double num2 = _currentY;
            for (; i < _currentIndex; i += 6) {
                _glyphTranslator.Curve4 ((float) (num += _argStack[i]), (float) (num2 += _argStack[i + 1]), (float) (num += _argStack[i + 2]), (float) (num2 += _argStack[i + 3]), (float) (num += _argStack[i + 4]), (float) (num2 += _argStack[i + 5]));
            }
            _currentX = num;
            _currentY = num2;
            _currentIndex = 0;
        }

        public void HH_CurveTo () {
            int i = 0;
            if (_currentIndex % 2 != 0) {
                _glyphTranslator.LineTo ((float) _currentX, (float) (_currentY += _argStack[i]));
                i++;
            }
            double num = _currentX;
            double num2 = _currentY;
            for (; i < _currentIndex; i += 4) {
                _glyphTranslator.Curve4 ((float) (num += _argStack[i]), (float) num2, (float) (num += _argStack[i + 1]), (float) (num2 += _argStack[i + 2]), (float) (num += _argStack[i + 3]), (float) num2);
            }
            _currentX = num;
            _currentY = num2;
            _currentIndex = 0;
        }

        public void HV_CurveTo () {
            int i = 0;
            int num = 0;
            switch (num = _currentIndex % 8) {
                default : throw new NotSupportedException ();
                case 0:
                        case 1:
                    {
                        double num3 = _currentX;
                        double num4 = _currentY;
                        for (int num5 = _currentIndex - num; i < num5; i += 8) {
                            _glyphTranslator.Curve4 ((float) (num3 += _argStack[i]), (float) num4, (float) (num3 += _argStack[i + 1]), (float) (num4 += _argStack[i + 2]), (float) num3, (float) (num4 += _argStack[i + 3]));
                            _glyphTranslator.Curve4 ((float) num3, (float) (num4 += _argStack[i + 4]), (float) (num3 += _argStack[i + 5]), (float) (num4 += _argStack[i + 6]), (float) (num3 += _argStack[i + 7]), (float) num4);
                        }
                        _currentX = num3;
                        _currentY = num4;
                        if (num == 1) {
                            _glyphTranslator.LineTo ((float) _currentX, (float) (_currentY += _argStack[i]));
                        }
                        break;
                    }
                case 4:
                        case 5:
                    {
                        double currentX = _currentX;
                        double currentY = _currentY;
                        _glyphTranslator.Curve4 ((float) (currentX += _argStack[i]), (float) currentY, (float) (currentX += _argStack[i + 1]), (float) (currentY += _argStack[i + 2]), (float) currentX, (float) (currentY += _argStack[i + 3]));
                        i += 4;
                        for (int num2 = _currentIndex - num; i < num2; i += 8) {
                            _glyphTranslator.Curve4 ((float) currentX, (float) (currentY += _argStack[i]), (float) (currentX += _argStack[i + 1]), (float) (currentY += _argStack[i + 2]), (float) (currentX += _argStack[i + 3]), (float) currentY);
                            _glyphTranslator.Curve4 ((float) (currentX += _argStack[i + 4]), (float) currentY, (float) (currentX += _argStack[i + 5]), (float) (currentY += _argStack[i + 6]), (float) currentX, (float) (currentY += _argStack[i + 7]));
                        }
                        _currentX = currentX;
                        _currentY = currentY;
                        if (num == 5) {
                            _glyphTranslator.LineTo ((float) (_currentX += _argStack[i]), (float) _currentY);
                        }
                        break;
                    }
            }
            _currentIndex = 0;
        }

        public void R_CurveLine () {
            _currentIndex = 0;
        }

        public void R_LineCurve () {
            _currentIndex = 0;
        }

        public void VH_CurveTo () {
            int i = 0;
            int num = 0;
            switch (num = _currentIndex % 8) {
                default : throw new NotSupportedException ();
                case 0:
                        case 1:
                    {
                        double num3 = _currentX;
                        double num4 = _currentY;
                        for (int num5 = _currentIndex - num; i < num5; i += 8) {
                            _glyphTranslator.Curve4 ((float) num3, (float) (num4 += _argStack[i]), (float) (num3 += _argStack[i + 1]), (float) (num4 += _argStack[i + 2]), (float) (num3 += _argStack[i + 3]), (float) num4);
                            _glyphTranslator.Curve4 ((float) (num3 += _argStack[i + 4]), (float) num4, (float) (num3 += _argStack[i + 5]), (float) (num4 += _argStack[i + 6]), (float) num3, (float) (num4 += _argStack[i + 7]));
                        }
                        _currentX = num3;
                        _currentY = num4;
                        if (num == 1) {
                            _glyphTranslator.LineTo ((float) (_currentX += _argStack[i]), (float) _currentY);
                        }
                        break;
                    }
                case 4:
                        case 5:
                    {
                        double currentX = _currentX;
                        double currentY = _currentY;
                        _glyphTranslator.Curve4 ((float) currentX, (float) (currentY += _argStack[i]), (float) (currentX += _argStack[i + 1]), (float) (currentY += _argStack[i + 2]), (float) (currentX += _argStack[i + 3]), (float) currentY);
                        i += 4;
                        for (int num2 = _currentIndex - num; i < num2; i += 8) {
                            _glyphTranslator.Curve4 ((float) (currentX += _argStack[i]), (float) currentY, (float) (currentX += _argStack[i + 1]), (float) (currentY += _argStack[i + 2]), (float) currentX, (float) (currentY += _argStack[i + 3]));
                            _glyphTranslator.Curve4 ((float) currentX, (float) (currentY += _argStack[i + 4]), (float) (currentX += _argStack[i + 5]), (float) (currentY += _argStack[i + 6]), (float) (currentX += _argStack[i + 7]), (float) currentY);
                        }
                        _currentX = currentX;
                        _currentY = currentY;
                        if (num == 5) {
                            _glyphTranslator.LineTo ((float) _currentX, (float) (_currentY += _argStack[i]));
                        }
                        break;
                    }
            }
            _currentIndex = 0;
        }

        public void VV_CurveTo () {
            int i = 0;
            if (_currentIndex % 2 != 0) {
                _glyphTranslator.LineTo ((float) (_currentX += _argStack[i]), (float) _currentY);
                i++;
            }
            double num = _currentX;
            double num2 = _currentY;
            for (; i < _currentIndex; i += 4) {
                _glyphTranslator.Curve4 ((float) num, (float) (num2 += _argStack[i]), (float) (num += _argStack[i + 1]), (float) (num2 += _argStack[i + 2]), (float) num, (float) (num2 += _argStack[i + 3]));
            }
            _currentX = num;
            _currentY = num2;
            _currentIndex = 0;
        }

        public void EndChar () {
            _currentIndex = 0;
        }

        public void Flex () {
            _currentIndex = 0;
        }

        public void H_Flex () {
            _currentIndex = 0;
        }

        public void H_Flex1 () {
            _currentIndex = 0;
        }

        public void Flex1 () {
            _currentIndex = 0;
        }

        public void H_Stem () {
            _currentIndex = 0;
        }

        public void V_Stem () {
            _currentIndex = 0;
        }

        public void V_StemHM () {
            _currentIndex = 0;
        }

        public void H_StemHM () {
            _currentIndex = 0;
        }

        public void HintMask1 (int hintMaskValue) {
            _currentIndex = 0;
        }

        public void HintMask2 (int hintMaskValue) {
            _currentIndex = 0;
        }

        public void HintMask3 (int hintMaskValue) {
            _currentIndex = 0;
        }

        public void HintMask4 (int hintMaskValue) {
            _currentIndex = 0;
        }

        public void HintMaskBits (int bitCount) {
            _currentIndex = 0;
        }

        public void CounterSpaceMask1 (int cntMaskValue) {
            _currentIndex = 0;
        }

        public void CounterSpaceMask2 (int cntMaskValue) {
            _currentIndex = 0;
        }

        public void CounterSpaceMask3 (int cntMaskValue) {
            _currentIndex = 0;
        }

        public void CounterSpaceMask4 (int cntMaskValue) {
            _currentIndex = 0;
        }

        public void CounterSpaceMaskBits (int bitCount) {
            _currentIndex = 0;
        }

        public void Op_Abs () { }

        public void Op_Add () { }

        public void Op_Sub () { }

        public void Op_Div () { }

        public void Op_Neg () { }

        public void Op_Random () { }

        public void Op_Mul () { }

        public void Op_Sqrt () { }

        public void Op_Drop () { }

        public void Op_Exch () { }

        public void Op_Index () { }

        public void Op_Roll () { }

        public void Op_Dup () { }

        public void Put () { }

        public void Get () { }

        public void Op_And () { }

        public void Op_Or () { }

        public void Op_Not () { }

        public void Op_Eq () { }

        public void Op_IfElse () { }

        public double Pop () {
            return _argStack[--_currentIndex];
        }

        public void Ret () {
            _currentIndex = 0;
        }
    }
}