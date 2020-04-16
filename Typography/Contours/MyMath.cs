using System;
using System.Numerics;

namespace Anura.Typography.Contours {
    public static class MyMath {
        internal static readonly double _85degreeToRad = DegreesToRadians (85.0);

        internal static readonly double _03degreeToRad = DegreesToRadians (3.0);

        internal static void FindMinMax (ref float currentMin, ref float currentMax, float value) {
            if (value < currentMin) {
                currentMin = value;
            }
            if (value > currentMax) {
                currentMax = value;
            }
        }

        internal static float CalculateDiffToFit (float value) {
            int num = (int) value;
            if (!(value - (float) num >= 0.5f)) {
                return (float) num - value;
            }
            return (float) (num + 1) - value;
        }

        internal static int FitToHalfGrid (float value, int gridSize) {
            int num = (int) (value / (float) gridSize) * gridSize;
            float num2 = value - (float) num;
            float num3 = (float) gridSize / 2f;
            if (num2 >= 2f / 3f * (float) gridSize) {
                return num + gridSize;
            }
            if (num2 >= 0.333333343f * (float) gridSize) {
                return (int) ((float) num + (float) gridSize * 0.5f);
            }
            return num;
        }

        public static double AngleBetween (Vector2 vector1, Vector2 vector2) {
            double num = Math.Atan2 (vector1.Y, vector1.X);
            double num2 = Math.Atan2 (vector2.Y, vector2.X);
            if (num < 0.0) {
                num = Math.PI + num;
            }
            if (num2 < 0.0) {
                num2 = Math.PI + num2;
            }
            return num - num2;
        }

        public static double DegreesToRadians (double degrees) {
            return degrees * (Math.PI / 180.0);
        }

        public static bool MinDistanceFirst (Vector2 baseVec, Vector2 compare0, Vector2 compare1) {
            if (!(SquareDistance (baseVec, compare0) < SquareDistance (baseVec, compare1))) {
                return false;
            }
            return true;
        }

        public static double SquareDistance (Vector2 v0, Vector2 v1) {
            double num = v1.X - v0.X;
            double num2 = v1.Y - v0.Y;
            return num * num + num2 * num2;
        }

        public unsafe static int Min (double v0, double v1, double v2) {
            double * ptr = stackalloc double[3];
            * ptr = v0;
            ptr[1] = v1;
            ptr[2] = v2;
            double num = double.MaxValue;
            int result = 0;
            for (int i = 0; i < 3; i++) {
                if (ptr[i] < num) {
                    result = i;
                    num = ptr[i];
                }
            }
            return result;
        }

        public static bool FindPerpendicularCutPoint (EdgeLine edge, Vector2 p2, out Vector2 cutResult) {
            cutResult = FindPerpendicularCutPoint (new Vector2 ((float) edge.PX, (float) edge.PY), new Vector2 ((float) edge.QX, (float) edge.QY), p2);
            GetMinMax (edge, out Vector2 min, out Vector2 max);
            if (cutResult.X >= min.X && cutResult.X <= max.X && cutResult.Y >= min.Y) {
                return cutResult.Y <= max.Y;
            }
            return false;
        }

        private static void GetMinMax (EdgeLine edge, out Vector2 min, out Vector2 max) {
            Vector2 value = new Vector2 ((float) edge.PX, (float) edge.PY);
            Vector2 value2 = new Vector2 ((float) edge.QX, (float) edge.QY);
            min = Vector2.Min (value, value2);
            max = Vector2.Max (value, value2);
        }

        private static void GetMinMax (Vector2 a_pos, Vector2 b_pos, out Vector2 min, out Vector2 max) {
            min = Vector2.Min (a_pos, b_pos);
            max = Vector2.Max (a_pos, b_pos);
        }

        public static int FindMin (Vector2 a, Vector2 b) {
            if (a.X < b.X) {
                return 0;
            }
            if (a.X > b.X) {
                return 1;
            }
            if (a.Y < b.Y) {
                return 0;
            }
            if (a.Y > b.Y) {
                return 1;
            }
            return -1;
        }

        private static void GetMinMax (GlyphBone bone, out Vector2 min, out Vector2 max) {
            if (bone.JointB != null) {
                Vector2 originalJointPos = bone.JointA.OriginalJointPos;
                Vector2 originalJointPos2 = bone.JointB.OriginalJointPos;
                min = Vector2.Min (originalJointPos, originalJointPos2);
                max = Vector2.Max (originalJointPos, originalJointPos2);
                return;
            }
            if (bone.TipEdge != null) {
                Vector2 originalJointPos3 = bone.JointA.OriginalJointPos;
                Vector2 midPoint = bone.TipEdge.GetMidPoint ();
                min = Vector2.Min (originalJointPos3, midPoint);
                max = Vector2.Max (originalJointPos3, midPoint);
                return;
            }
            throw new NotSupportedException ();
        }

        public static bool FindPerpendicularCutPoint (GlyphBone bone, Vector2 p, out Vector2 cutPoint) {
            if (bone.JointB != null) {
                cutPoint = FindPerpendicularCutPoint (bone.JointA.OriginalJointPos, bone.JointB.OriginalJointPos, p);
                GetMinMax (bone, out Vector2 min, out Vector2 max);
                if (cutPoint.X >= min.X && cutPoint.X <= max.X && cutPoint.Y >= min.Y) {
                    return cutPoint.Y <= max.Y;
                }
                return false;
            }
            if (bone.TipEdge != null) {
                cutPoint = FindPerpendicularCutPoint (bone.JointA.OriginalJointPos, bone.TipEdge.GetMidPoint (), p);
                GetMinMax (bone, out Vector2 min2, out Vector2 max2);
                if (cutPoint.X >= min2.X && cutPoint.X <= max2.X && cutPoint.Y >= min2.Y) {
                    return cutPoint.Y <= max2.Y;
                }
                return false;
            }
            throw new NotSupportedException ();
        }

        public static Vector2 FindPerpendicularCutPoint (Vector2 p0, Vector2 p1, Vector2 p2) {
            double num = p1.X - p0.X;
            double num2 = p1.Y - p0.Y;
            if (num == 0.0) {
                return new Vector2 (p1.X, p2.Y);
            }
            if (num2 == 0.0) {
                return new Vector2 (p2.X, p1.Y);
            }
            double num3 = num2 / num;
            double num4 = FindB (p0, p1);
            double num5 = -1.0 / num3;
            double num6 = (double) p2.Y - num5 * (double) p2.X;
            double num7 = (num6 - num4) / (num3 - num5);
            double num8 = num5 * num7 + num6;
            return new Vector2 ((float) num7, (float) num8);
        }

        private static void FindABC (Vector2 p0, Vector2 p1, out double a, out double b, out double c) {
            a = p1.Y - p0.Y;
            b = p0.X - p1.X;
            c = a * (double) p0.X + b * (double) p0.Y;
        }

        public static bool FindCutPoint (Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, out Vector2 result) {
            FindABC (p0, p1, out double a, out double b, out double c);
            FindABC (p2, p3, out double a2, out double b2, out double c2);
            double num = a * b2 - a2 * b;
            if (num == 0.0) {
                result = Vector2.Zero;
                return false;
            }
            double num2 = (b2 * c - b * c2) / num;
            double num3 = (a * c2 - a2 * c) / num;
            result = new Vector2 ((float) num2, (float) num3);
            return true;
        }

        private static Vector2 FindCutPoint_Algebra (Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) {
            double num = p1.Y - p0.Y;
            double num2 = p1.X - p0.X;
            double num3 = num / num2;
            double num4 = (double) p0.Y - num3 * (double) p0.X;
            double num5 = p3.Y - p2.Y;
            double num6 = p3.X - p2.X;
            if (num == 0.0) {
                float y = p0.Y;
                if (num6 == 0.0) {
                    return new Vector2 (p3.X, y);
                }
                double num7 = num5 / num6;
                double num8 = (double) p2.Y - num7 * (double) p2.X;
                return new Vector2 ((float) (((double) y - num8) / num7), y);
            }
            if (num2 == 0.0) {
                if (num5 == 0.0) {
                    return new Vector2 (p1.X, p2.Y);
                }
                double num9 = p1.X;
                double num10 = num5 / num6;
                double num11 = (double) p2.Y - num10 * (double) p2.X;
                double num12 = num9;
                double num13 = num10 * num12 + num11;
                return new Vector2 ((float) num12, (float) num13);
            }
            if (num6 == 0.0) {
                double num14 = p2.X;
                double num15 = num3 * num14 + num4;
                return new Vector2 ((float) num14, (float) num15);
            }
            if (num5 == 0.0) {
                double num16 = p2.Y;
                return new Vector2 ((float) ((num16 - num4) / num3), (float) num16);
            }
            double num17 = num5 / num6;
            double num18 = ((double) p2.Y - num17 * (double) p2.X - num4) / (num3 - num17);
            double num19 = num3 * num18 + num4;
            return new Vector2 ((float) num18, (float) num19);
        }

        private static Vector2 FindCutPoint (Vector2 p0, Vector2 p1, Vector2 p2, float cutAngle) {
            double num = p1.Y - p0.Y;
            double num2 = p1.X - p0.X;
            if (num2 == 0.0) {
                return new Vector2 (p1.X, p2.Y);
            }
            if (num == 0.0) {
                return new Vector2 (p2.X, p1.Y);
            }
            double num3 = num / num2;
            double num4 = (double) p0.Y - num3 * (double) p0.X;
            Math.Atan2 (num, num2);
            double num5 = (cutAngle == 90f) ? (-1.0 / num3) : Math.Tan (Math.Atan2 (num, num2) + DegreesToRadians (cutAngle));
            double num6 = ((double) p2.Y - num5 * (double) p2.X - num4) / (num3 - num5);
            double num7 = num3 * num6 + num4;
            return new Vector2 ((float) num6, (float) num7);
        }

        public static bool FindPerpendicularCutPoint2 (Vector2 p0, Vector2 p1, Vector2 p2, out Vector2 cutPoint) {
            double num = p1.X - p0.X;
            double num2 = p1.Y - p0.Y;
            if (num == 0.0) {
                cutPoint = new Vector2 (p1.X, p2.Y);
                GetMinMax (p0, p1, out Vector2 min, out Vector2 max);
                if (cutPoint.X >= min.X && cutPoint.X <= max.X && cutPoint.Y >= min.Y) {
                    return cutPoint.Y <= max.Y;
                }
                return false;
            }
            if (num2 == 0.0) {
                cutPoint = new Vector2 (p2.X, p1.Y);
                GetMinMax (p0, p1, out Vector2 min2, out Vector2 max2);
                if (cutPoint.X >= min2.X && cutPoint.X <= max2.X && cutPoint.Y >= min2.Y) {
                    return cutPoint.Y <= max2.Y;
                }
                return false;
            }
            double num3 = num2 / num;
            double num4 = FindB (p0, p1);
            double num5 = -1.0 / num3;
            double num6 = (double) p2.Y - num5 * (double) p2.X;
            double num7 = (num6 - num4) / (num3 - num5);
            double num8 = num5 * num7 + num6;
            cutPoint = new Vector2 ((float) num7, (float) num8);
            GetMinMax (p0, p1, out Vector2 min3, out Vector2 max3);
            if (cutPoint.X >= min3.X && cutPoint.X <= max3.X && cutPoint.Y >= min3.Y) {
                return cutPoint.Y <= max3.Y;
            }
            return false;
        }

        private static double FindB (Vector2 p0, Vector2 p1) {
            double num = (p1.Y - p0.Y) / (p1.X - p0.X);
            return (double) p0.Y - num * (double) p0.X;
        }

        private unsafe static int FindMinByIndex (double d0, double d1, double d2) {
            double * ptr = stackalloc double[3];
            * ptr = d0;
            ptr[1] = d1;
            ptr[2] = d2;
            int result = -1;
            double num = double.MaxValue;
            for (int i = 0; i < 3; i++) {
                double num2 = ptr[i];
                if (num2 < num) {
                    num = num2;
                    result = i;
                }
            }
            return result;
        }
    }
}