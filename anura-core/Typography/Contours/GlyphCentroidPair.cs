using System;

namespace Anura.Typography.Contours {
    internal struct GlyphCentroidPair {
        internal readonly GlyphTriangle p;

        internal readonly GlyphTriangle q;

        internal GlyphCentroidPair (GlyphTriangle p, GlyphTriangle q) {
            this.p = p;
            this.q = q;
        }

        public GlyphBoneJoint AnalyzeEdgesAndCreateBoneJoint () {
            GlyphBoneJoint glyphBoneJoint = null;
            if (FindCommonInsideEdges (p, q, out InsideEdgeLine a_edge, out InsideEdgeLine b_edge)) {
                glyphBoneJoint = new GlyphBoneJoint (a_edge, b_edge);
                double cent_slopAngle = CalculateCentroidPairSlopeNoDirection (this);
                EdgeLine edgeLine = null;
                if ((edgeLine = CreateTipEdgeIfNeed (cent_slopAngle, p, a_edge)) != null) {
                    glyphBoneJoint.SetTipEdge_P (edgeLine);
                }
                if ((edgeLine = CreateTipEdgeIfNeed (cent_slopAngle, q, b_edge)) != null) {
                    glyphBoneJoint.SetTipEdge_Q (edgeLine);
                }
            }
            return glyphBoneJoint;
        }

        private static bool FindCommonInsideEdges (GlyphTriangle a, GlyphTriangle b, out InsideEdgeLine a_edge, out InsideEdgeLine b_edge) {
            EdgeLine e = b.e0;
            InsideEdgeLine insideEdgeLine = null;
            if ((insideEdgeLine = FindCommonInsideEdge (a, e)) != null) {
                a_edge = insideEdgeLine;
                b_edge = (InsideEdgeLine) e;
                return true;
            }
            e = b.e1;
            if ((insideEdgeLine = FindCommonInsideEdge (a, e)) != null) {
                a_edge = insideEdgeLine;
                b_edge = (InsideEdgeLine) e;
                return true;
            }
            e = b.e2;
            if ((insideEdgeLine = FindCommonInsideEdge (a, e)) != null) {
                a_edge = insideEdgeLine;
                b_edge = (InsideEdgeLine) e;
                return true;
            }
            a_edge = (b_edge = null);
            return false;
        }

        private static InsideEdgeLine FindCommonInsideEdge (GlyphTriangle a, EdgeLine b_edge) {
            if (b_edge.IsOutside) {
                return null;
            }
            if (IsMatchingEdge (a.e0, b_edge)) {
                return (InsideEdgeLine) a.e0;
            }
            if (IsMatchingEdge (a.e1, b_edge)) {
                return (InsideEdgeLine) a.e1;
            }
            if (IsMatchingEdge (a.e2, b_edge)) {
                return (InsideEdgeLine) a.e2;
            }
            return null;
        }

        private static void ClassifyTriangleEdges (GlyphTriangle triangle, EdgeLine knownInsideEdge, out EdgeLine anotherInsideEdge, out EdgeLine outside0, out EdgeLine outside1, out EdgeLine outside2, out int outsideCount) {
            outsideCount = 0;
            outside0 = (outside1 = (outside2 = (anotherInsideEdge = null)));
            if (triangle.e0.IsOutside) {
                switch (outsideCount) {
                    case 0:
                        outside0 = triangle.e0;
                        break;
                    case 1:
                        outside1 = triangle.e0;
                        break;
                    case 2:
                        outside2 = triangle.e0;
                        break;
                }
                outsideCount++;
            } else if (triangle.e0 != knownInsideEdge) {
                anotherInsideEdge = triangle.e0;
            }
            if (triangle.e1.IsOutside) {
                switch (outsideCount) {
                    case 0:
                        outside0 = triangle.e1;
                        break;
                    case 1:
                        outside1 = triangle.e1;
                        break;
                    case 2:
                        outside2 = triangle.e1;
                        break;
                }
                outsideCount++;
            } else if (triangle.e1 != knownInsideEdge) {
                anotherInsideEdge = triangle.e1;
            }
            if (triangle.e2.IsOutside) {
                switch (outsideCount) {
                    case 0:
                        outside0 = triangle.e2;
                        break;
                    case 1:
                        outside1 = triangle.e2;
                        break;
                    case 2:
                        outside2 = triangle.e2;
                        break;
                }
                outsideCount++;
            } else if (triangle.e2 != knownInsideEdge) {
                anotherInsideEdge = triangle.e2;
            }
        }

        private static double CalculateCentroidPairSlopeNoDirection (GlyphCentroidPair centroidPair) {
            centroidPair.p.CalculateCentroid (out float centroidX, out float centroidY);
            centroidPair.q.CalculateCentroid (out float centroidX2, out float centroidY2);
            return Math.Abs (Math.Atan2 (Math.Abs (centroidY2 - centroidY), Math.Abs (centroidX2 - centroidX)));
        }

        private static void SelectMostProperTipEdge (double slopeAngle, EdgeLine outside0, EdgeLine outside1, out EdgeLine tipEdge, out EdgeLine notTipEdge) {
            double num = Math.Abs (outside0.GetSlopeAngleNoDirection () - slopeAngle);
            double num2 = Math.Abs (outside1.GetSlopeAngleNoDirection () - slopeAngle);
            if (num > num2) {
                tipEdge = outside0;
                notTipEdge = outside1;
            } else {
                tipEdge = outside1;
                notTipEdge = outside0;
            }
        }

        private static EdgeLine CreateTipEdgeIfNeed (double cent_slopAngle, GlyphTriangle triangle, EdgeLine knownInsideEdge) {
            ClassifyTriangleEdges (triangle, knownInsideEdge, out EdgeLine _, out EdgeLine outside, out EdgeLine outside2, out EdgeLine _, out int outsideCount);
            switch (outsideCount) {
                default : throw new NotSupportedException ();
                case 3:
                        throw new NotImplementedException ();
                case 2:
                        SelectMostProperTipEdge (cent_slopAngle, outside, outside2, out EdgeLine tipEdge, out EdgeLine _);
                    return tipEdge;
                case 0:
                        case 1:
                        return null;
            }
        }

        private static bool IsMatchingEdge (EdgeLine a, EdgeLine b) {
            if (((a.PX == b.PX && a.QX == b.QX) || (a.PX == b.QX && a.QX == b.PX)) && ((a.PY == b.PY && a.QY == b.QY) || (a.PY == b.QY && a.QY == b.PY))) {
                return true;
            }
            return false;
        }

        public override string ToString () {
            return p + " -> " + q;
        }
    }
}