using System;
using System.Numerics;

namespace Anura.Typography.Contours {
    public static class EdgeLineExtensions {
        public static Vector2 GetMidPoint (this EdgeLine line) {
            return new Vector2 ((float) ((line.PX + line.QX) / 2.0), (float) ((line.PY + line.QY) / 2.0));
        }

        internal static double GetSlopeAngleNoDirection (this EdgeLine line) {
            return Math.Abs (Math.Atan2 (Math.Abs (line.QY - line.PY), Math.Abs (line.QX - line.PX)));
        }

        internal static bool ContainsTriangle (this EdgeLine edge, GlyphTriangle p) {
            if (p.e0 != edge && p.e1 != edge) {
                return p.e2 == edge;
            }
            return true;
        }
    }
}