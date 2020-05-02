using System.Collections.Generic;

namespace Anura.Typography.Contours {
    internal class BoneGroup {
        public LineSlopeKind slopeKind;

        public int startIndex;

        public int count;

        public float approxLength;

        public float avg_x;

        public float avg_y;

        public EdgeLine[] edges;

        public BoneGroupSumLengthKind _lengKind;

        internal readonly CentroidLine ownerCentroidLine;

        public BoneGroup (CentroidLine ownerCentroidLine) {
            this.ownerCentroidLine = ownerCentroidLine;
        }

        internal void CollectOutsideEdges (List<EdgeLine> tmpEdges) {
            tmpEdges.Clear ();
            int num = startIndex;
            for (int num2 = count - 1; num2 >= 0; num2--) {
                ownerCentroidLine.bones[num].CollectOutsideEdge (tmpEdges);
                num++;
            }
            if (tmpEdges.Count != 0) {
                edges = tmpEdges.ToArray ();
            }
        }

        public void CalculateBounds (ref float minX, ref float minY, ref float maxX, ref float maxY) {
            for (int num = edges.Length - 1; num >= 0; num--) {
                EdgeLine edgeLine = edges[num];
                MyMath.FindMinMax (ref minX, ref maxX, (float) edgeLine.PX);
                MyMath.FindMinMax (ref minX, ref maxX, (float) edgeLine.QX);
                MyMath.FindMinMax (ref minY, ref maxY, (float) edgeLine.PY);
                MyMath.FindMinMax (ref minY, ref maxY, (float) edgeLine.QY);
            }
        }
    }
}