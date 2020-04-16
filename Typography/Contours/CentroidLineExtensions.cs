using System.Collections.Generic;
using System.Numerics;

namespace Anura.Typography.Contours {
    internal static class CentroidLineExtensions {
        public static Vector2 GetHeadPosition (this CentroidLine line) {
            List<GlyphBone> bones = line.bones;
            if (bones.Count == 0) {
                return Vector2.Zero;
            }
            return bones[0].JointA.OriginalJointPos;
        }

        public static Vector2 CalculateAvgHeadPosition (this CentroidLineHub lineHub) {
            Dictionary<GlyphTriangle, CentroidLine> allCentroidLines = lineHub.GetAllCentroidLines ();
            int count = allCentroidLines.Count;
            if (count == 0) {
                return Vector2.Zero;
            }
            double num = 0.0;
            double num2 = 0.0;
            foreach (CentroidLine value in allCentroidLines.Values) {
                Vector2 headPosition = value.GetHeadPosition ();
                num += (double) headPosition.X;
                num2 += (double) headPosition.Y;
            }
            return new Vector2 ((float) (num / (double) count), (float) (num2 / (double) count));
        }
    }
}