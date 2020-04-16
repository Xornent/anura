using System;
using Anura.Typography.OpenFont;
using Anura.Typography.OpenFont.Extensions;

namespace Anura.Typography.TextLayout {
    public static class PixelScaleLayoutExtensions {
        private static float MeasureGlyphPlans (this GlyphLayout glyphLayout, float pxscale, bool snapToGrid) {
            IGlyphPositions resultUnscaledGlyphPositions = glyphLayout.ResultUnscaledGlyphPositions;
            float num = 0f;
            if (snapToGrid) {
                int count = resultUnscaledGlyphPositions.Count;
                for (int i = 0; i < count; i++) {
                    resultUnscaledGlyphPositions.GetGlyph (i, out ushort _, out short _, out short _, out short advW);
                    num += (float) (short) Math.Round ((float) advW * pxscale);
                }
            } else {
                int count2 = resultUnscaledGlyphPositions.Count;
                for (int j = 0; j < count2; j++) {
                    resultUnscaledGlyphPositions.GetGlyph (j, out ushort _, out short _, out short _, out short advW2);
                    num += (float) advW2 * pxscale;
                }
            }
            return num;
        }

        private static float MeasureGlyphPlanWithLimitWidth (this GlyphLayout glyphLayout, float pxscale, float limitWidth, bool snapToGrid, out int stopAtGlyphIndex) {
            IGlyphPositions resultUnscaledGlyphPositions = glyphLayout.ResultUnscaledGlyphPositions;
            float num = 0f;
            stopAtGlyphIndex = 0;
            if (snapToGrid) {
                int count = resultUnscaledGlyphPositions.Count;
                for (int i = 0; i < count; i++) {
                    resultUnscaledGlyphPositions.GetGlyph (i, out ushort _, out short _, out short _, out short advW);
                    stopAtGlyphIndex = i;
                    short num2 = (short) Math.Round ((float) advW * pxscale);
                    if (num + (float) num2 > limitWidth) {
                        break;
                    }
                    num += (float) num2;
                }
            } else {
                int count2 = resultUnscaledGlyphPositions.Count;
                for (int j = 0; j < count2; j++) {
                    resultUnscaledGlyphPositions.GetGlyph (j, out ushort _, out short _, out short _, out short advW2);
                    stopAtGlyphIndex = j;
                    float num3 = (float) advW2 * pxscale;
                    if (num + num3 > limitWidth) {
                        break;
                    }
                    num += num3;
                }
            }
            return num;
        }

        public static MeasuredStringBox LayoutAndMeasureString (this GlyphLayout glyphLayout, char[] textBuffer, int startAt, int len, float fontSizeInPoints, float limitW = -1f, bool snapToGrid = true) {
            glyphLayout.Layout (textBuffer, startAt, len);
            Typeface typeface = glyphLayout.Typeface;
            float pxscale = typeface.CalculateScaleToPixelFromPointSize (fontSizeInPoints);
            if (limitW < 0f) {
                return new MeasuredStringBox (glyphLayout.MeasureGlyphPlans (pxscale, snapToGrid), typeface.Ascender, typeface.Descender, typeface.LineGap, (short) typeface.CalculateRecommendLineSpacing (), pxscale);
            }
            int stopAtGlyphIndex;
            if (limitW > 0f) {
                return new MeasuredStringBox (glyphLayout.MeasureGlyphPlanWithLimitWidth (pxscale, limitW, snapToGrid, out stopAtGlyphIndex), typeface.Ascender, typeface.Descender, typeface.LineGap, (short) typeface.CalculateRecommendLineSpacing (), pxscale);
            }
            return new MeasuredStringBox (0f, typeface.Ascender, typeface.Descender, typeface.LineGap, (short) typeface.CalculateRecommendLineSpacing (), pxscale);
        }
    }
}