using System;
using System.Collections.Generic;
using Anura.Typography.OpenFont.CFF;

namespace Anura.Typography.OpenFont {
    public static class TypefaceExtension2 {
        private class CffBoundFinder : IGlyphTranslator {
            private float _minX;

            private float _maxX;

            private float _minY;

            private float _maxY;

            private float _curX;

            private float _curY;

            private float _latestMove_X;

            private float _latestMove_Y;

            private int nsteps = 3;

            private bool _contourOpen;

            private bool _first_eval = true;

            public void Reset () {
                _curX = (_curY = (_latestMove_X = (_latestMove_Y = 0f)));
                _minX = (_minY = float.MaxValue);
                _maxX = (_maxY = float.MinValue);
                _first_eval = true;
                _contourOpen = false;
            }

            public void BeginRead (int contourCount) { }

            public void EndRead () { }

            public void CloseContour () {
                _contourOpen = false;
                _curX = _latestMove_X;
                _curY = _latestMove_Y;
            }

            public void Curve3 (float x1, float y1, float x2, float y2) {
                float num = 1f / (float) nsteps;
                float num2 = num;
                for (int i = 1; i < nsteps; i++) {
                    float num3 = 1f - num2;
                    UpdateMinMax (num3 * num3 * _curX + 2f * num2 * num3 * x1 + num2 * num2 * x2, num3 * num3 * _curY + 2f * num2 * num3 * y1 + num2 * num2 * y2);
                    num2 += num;
                }
                UpdateMinMax (_curX = x2, _curY = y2);
                _contourOpen = true;
            }

            public void Curve4 (float x1, float y1, float x2, float y2, float x3, float y3) {
                float num = 1f / (float) nsteps;
                float num2 = num;
                for (int i = 1; i < nsteps; i++) {
                    float num3 = 1f - num2;
                    UpdateMinMax (_curX * num3 * num3 * num3 + x1 * 3f * num2 * num3 * num3 + x2 * 3f * num2 * num2 * num3 + x3 * num2 * num2 * num2, _curY * num3 * num3 * num3 + y1 * 3f * num2 * num3 * num3 + y2 * 3f * num2 * num2 * num3 + y3 * num2 * num2 * num2);
                    num2 += num;
                }
                UpdateMinMax (_curX = x3, _curY = y3);
                _contourOpen = true;
            }

            public void LineTo (float x1, float y1) {
                UpdateMinMax (_curX = x1, _curY = y1);
                _contourOpen = true;
            }

            public void MoveTo (float x0, float y0) {
                if (_contourOpen) {
                    CloseContour ();
                }
                UpdateMinMax (_curX = x0, _curY = y0);
            }

            private void UpdateMinMax (float x0, float y0) {
                if (_first_eval) {
                    if (x0 < _minX) {
                        _minX = x0;
                    }
                    if (x0 > _maxX) {
                        _maxX = x0;
                    }
                    if (y0 < _minY) {
                        _minY = y0;
                    }
                    if (y0 > _maxY) {
                        _maxY = y0;
                    }
                    _first_eval = false;
                } else {
                    if (x0 < _minX) {
                        _minX = x0;
                    } else if (x0 > _maxX) {
                        _maxX = x0;
                    }
                    if (y0 < _minY) {
                        _minY = y0;
                    } else if (y0 > _maxY) {
                        _maxY = y0;
                    }
                }
            }

            public Bounds GetResultBounds () {
                return new Bounds ((short) Math.Floor (_minX), (short) Math.Floor (_minY), (short) Math.Ceiling (_maxX), (short) Math.Ceiling (_maxY));
            }
        }

        public static IEnumerable<GlyphNameMap> GetGlyphNameIter (this Typeface typeface) {
            if (typeface.IsCffFont) {
                Cff1Font cff1Font = typeface.CffTable.Cff1FontSet._fonts[0];
                foreach (GlyphNameMap item in cff1Font.GetGlyphNameIter ()) {
                    yield return item;
                }
            } else if (typeface.PostTable.Version == 2) {
                foreach (KeyValuePair<ushort, string> glyphName in typeface.PostTable.GlyphNames) {
                    yield return new GlyphNameMap (glyphName.Key, glyphName.Value);
                }
            }
        }

        public static bool HasMathTable (this Typeface typeface) {
            return typeface.MathConsts != null;
        }

        public static bool HasSvgTable (this Typeface typeface) {
            return typeface._svgTable != null;
        }

        public static void UpdateAllCffGlyphBounds (this Typeface typeface) {
            if (typeface.IsCffFont && !typeface._evalCffGlyphBounds) {
                int glyphCount = typeface.GlyphCount;
                CffEvaluationEngine cffEvaluationEngine = new CffEvaluationEngine ();
                CffBoundFinder cffBoundFinder = new CffBoundFinder ();
                for (ushort num = 0; num < glyphCount; num = (ushort) (num + 1)) {
                    Glyph glyphByIndex = typeface.GetGlyphByIndex (num);
                    cffBoundFinder.Reset ();
                    cffEvaluationEngine.Run (cffBoundFinder, glyphByIndex._ownerCffFont, glyphByIndex._cff1GlyphData.GlyphInstructions);
                    glyphByIndex.Bounds = cffBoundFinder.GetResultBounds ();
                }
                typeface._evalCffGlyphBounds = true;
            }
        }
    }
}