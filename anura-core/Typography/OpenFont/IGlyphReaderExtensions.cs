using System;
using System.Numerics;
using Anura.Typography.OpenFont.CFF;

namespace Anura.Typography.OpenFont {
    public static class IGlyphReaderExtensions {
        public static void Read (this IGlyphTranslator tx, GlyphPointF[] glyphPoints, ushort[] contourEndPoints, float scale = 1f) {
            int num = 0;
            int i = 0;
            int num2 = contourEndPoints.Length;
            tx.BeginRead (num2);
            float x = 0f;
            float y = 0f;
            int num3 = 0;
            while (num2 > 0) {
                num3 = 0;
                int num4 = contourEndPoints[num] + 1;
                bool flag = false;
                Vector2 vector = default (Vector2);
                Vector2 vector2 = default (Vector2);
                bool flag2 = false;
                bool flag3 = false;
                bool flag4 = false;
                int num5 = 0;
                for (; i < num4; i++) {
                    GlyphPointF glyphPointF = glyphPoints[i];
                    num5++;
                    float num6 = glyphPointF.X * scale;
                    float num7 = glyphPointF.Y * scale;
                    if (glyphPointF.onCurve) {
                        if (flag2) {
                            if (num3 != 1) {
                                throw new NotSupportedException ();
                            }
                            tx.Curve3 (vector2.X, vector2.Y, num6, num7);
                            num3 = 0;
                            flag2 = false;
                        } else if (!flag3) {
                            flag3 = true;
                            switch (num3) {
                                case 0:
                                    tx.MoveTo (x = num6, y = num7);
                                    break;
                                case 1:
                                    vector = vector2;
                                    flag = true;
                                    tx.MoveTo (x = num6, y = num7);
                                    num3--;
                                    break;
                                default:
                                    throw new NotSupportedException ();
                            }
                        } else {
                            tx.LineTo (num6, num7);
                        }
                        continue;
                    }
                    if (num5 == 1) {
                        flag4 = true;
                    }
                    switch (num3) {
                        case 0:
                            vector2 = new Vector2 (num6, num7);
                            if (flag3) {
                                flag2 = true;
                            }
                            break;
                        case 1:
                            {
                                if (!flag3) {
                                    Vector2 midPoint = GetMidPoint (vector2, num6, num7);
                                    vector = vector2;
                                    flag = true;
                                    tx.MoveTo (x = midPoint.X, y = midPoint.Y);
                                    flag2 = true;
                                    flag3 = true;
                                    vector2 = new Vector2 (num6, num7);
                                    continue;
                                }
                                Vector2 midPoint2 = GetMidPoint (vector2, num6, num7);
                                tx.Curve3 (vector2.X, vector2.Y, midPoint2.X, midPoint2.Y);
                                num3--;
                                vector2 = new Vector2 (num6, num7);
                                flag2 = true;
                                break;
                            }
                        default:
                            throw new NotSupportedException ();
                    }
                    num3++;
                }
                if (flag2) {
                    switch (num3) {
                        case 1:
                            if (flag) {
                                Vector2 midPoint3 = GetMidPoint (vector2, vector.X, vector.Y);
                                tx.Curve3 (vector2.X, vector2.Y, midPoint3.X, midPoint3.Y);
                                num3--;
                                tx.Curve3 (vector.X, vector.Y, x, y);
                            } else {
                                tx.Curve3 (vector2.X, vector2.Y, x, y);
                            }
                            break;
                        default:
                            throw new NotSupportedException ();
                        case 0:
                            break;
                    }
                } else if (flag4) {
                    tx.Curve3 (vector.X, vector.Y, x, y);
                }
                tx.CloseContour ();
                num++;
                num2--;
            }
            tx.EndRead ();
        }

        private static Vector2 GetMidPoint (Vector2 v0, float x1, float y1) {
            return new Vector2 ((v0.X + x1) / 2f, (v0.Y + y1) / 2f);
        }

        public static void Read (this IGlyphTranslator tx, Cff1Font cff1Font, Cff1GlyphData glyphData, float scale = 1f) {
            new CffEvaluationEngine ().Run (tx, cff1Font, glyphData.GlyphInstructions, scale);
        }
    }
}