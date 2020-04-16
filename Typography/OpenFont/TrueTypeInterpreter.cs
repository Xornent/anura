using Anura.Typography.OpenFont.Tables;

namespace Anura.Typography.OpenFont {
    public class TrueTypeInterpreter {
        private Typeface _currentTypeFace;

        private SharpFontInterpreter _interpreter;

        public bool UseVerticalHinting {
            get;
            set;
        }

        public void SetTypeFace (Typeface typeface) {
            _currentTypeFace = typeface;
            MaxProfile maxProfile = _currentTypeFace.MaxProfile;
            _interpreter = new SharpFontInterpreter (maxProfile.MaxStackElements, maxProfile.MaxStorage, maxProfile.MaxFunctionDefs, maxProfile.MaxInstructionDefs, maxProfile.MaxTwilightPoints);
            if (_currentTypeFace.FpgmProgramBuffer != null) {
                _interpreter.InitializeFunctionDefs (_currentTypeFace.FpgmProgramBuffer);
            }
        }

        public GlyphPointF[] HintGlyph (ushort glyphIndex, float glyphSizeInPixel) {
            Glyph glyphByIndex = _currentTypeFace.GetGlyphByIndex (glyphIndex);
            int hAdvanceWidthFromGlyphIndex = _currentTypeFace.GetHAdvanceWidthFromGlyphIndex (glyphIndex);
            int hFrontSideBearingFromGlyphIndex = _currentTypeFace.GetHFrontSideBearingFromGlyphIndex (glyphIndex);
            return HintGlyph (hAdvanceWidthFromGlyphIndex, hFrontSideBearingFromGlyphIndex, glyphByIndex.MinX, glyphByIndex.MaxY, glyphByIndex.GlyphPoints, glyphByIndex.EndPoints, glyphByIndex.GlyphInstructions, glyphSizeInPixel);
        }

        public GlyphPointF[] HintGlyph (int horizontalAdv, int hFrontSideBearing, int minX, int maxY, GlyphPointF[] glyphPoints, ushort[] contourEndPoints, byte[] instructions, float glyphSizeInPixel) {
            int num = 0;
            int num2 = 0;
            GlyphPointF glyphPointF = new GlyphPointF (minX - hFrontSideBearing, 0f, true);
            GlyphPointF glyphPointF2 = new GlyphPointF (glyphPointF.X + (float) horizontalAdv, 0f, true);
            GlyphPointF glyphPointF3 = new GlyphPointF (0f, maxY + num2, true);
            GlyphPointF glyphPointF4 = new GlyphPointF (0f, glyphPointF3.Y - (float) num, true);
            int num3 = glyphPoints.Length;
            GlyphPointF[] array = Utils.CloneArray (glyphPoints, 4);
            array[num3] = glyphPointF;
            array[num3 + 1] = glyphPointF2;
            array[num3 + 2] = glyphPointF3;
            array[num3 + 3] = glyphPointF4;
            float scale = _currentTypeFace.CalculateScaleToPixel (glyphSizeInPixel);
            for (int num4 = num3 + 3; num4 >= 0; num4--) {
                array[num4].ApplyScale (scale);
            }
            float num5 = 1000f;
            if (UseVerticalHinting) {
                ApplyScaleOnlyOnXAxis (array, num5);
            }
            _interpreter.SetControlValueTable (_currentTypeFace.ControlValues, scale, glyphSizeInPixel, _currentTypeFace.PrepProgramBuffer);
            _interpreter.HintGlyph (array, contourEndPoints, instructions);
            if (UseVerticalHinting) {
                ApplyScaleOnlyOnXAxis (array, 1f / num5);
            }
            return array;
        }

        private static void ApplyScaleOnlyOnXAxis (GlyphPointF[] glyphPoints, float xscale) {
            for (int num = glyphPoints.Length - 1; num >= 0; num--) {
                glyphPoints[num].ApplyScaleOnlyOnXAxis (xscale);
            }
        }
    }
}