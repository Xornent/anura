using System;
using System.Collections.Generic;

namespace Anura.Typography.Triangulation {
    public sealed class DelaunayTriangle {
        public TriangulationPoint P0;

        public TriangulationPoint P1;

        public TriangulationPoint P2;

        public DelaunayTriangle N0;

        public DelaunayTriangle N1;

        public DelaunayTriangle N2;

        internal bool D0;

        internal bool D1;

        internal bool D2;

        public bool C0;

        public bool C1;

        public bool C2;

        public bool isActualTriangle;

        public object userData;

        public bool IsInterior {
            get;
            set;
        }

        public DelaunayTriangle (TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3) {
            P0 = p1;
            P1 = p2;
            P2 = p3;
        }

        public void MarkAsActualTriangle () {
            isActualTriangle = true;
        }

        public int IndexOf (TriangulationPoint p) {
            if (P0 == p) {
                return 0;
            }
            if (P1 == p) {
                return 1;
            }
            if (P2 == p) {
                return 2;
            }
            throw new Exception ("Calling index with a point that doesn't exist in triangle");
        }

        public bool ContainsPoint (TriangulationPoint p) {
            if (P0 != p && P1 != p) {
                return P2 == p;
            }
            return true;
        }

        public bool EdgeIsDelaunay (int index) {
            switch (index) {
                case 0:
                    return D0;
                case 1:
                    return D1;
                default:
                    return D2;
            }
        }

        public void MarkEdgeDelunay (int index, bool value) {
            switch (index) {
                case 0:
                    D0 = value;
                    break;
                case 1:
                    D1 = value;
                    break;
                default:
                    D2 = value;
                    break;
            }
        }

        public bool EdgeIsConstrained (int index) {
            switch (index) {
                case 0:
                    return C0;
                case 1:
                    return C1;
                default:
                    return C2;
            }
        }

        public void MarkEdgeConstraint (int index, bool value) {
            switch (index) {
                case 0:
                    C0 = value;
                    break;
                case 1:
                    C1 = value;
                    break;
                case 2:
                    C2 = value;
                    break;
            }
        }

        public void ClearAllEdgeDelaunayMarks () {
            D0 = (D1 = (D2 = false));
        }

        public int IndexCWFrom (TriangulationPoint p) {
            return (IndexOf (p) + 2) % 3;
        }

        public int IndexCCWFrom (TriangulationPoint p) {
            return (IndexOf (p) + 1) % 3;
        }

        public bool Contains (TriangulationPoint p) {
            return ContainsPoint (p);
        }

        private void MarkNeighbor (TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t) {
            switch (FindEdgeIndex (p1, p2)) {
                case 0:
                    N0 = t;
                    break;
                case 1:
                    N1 = t;
                    break;
                case 2:
                    N2 = t;
                    break;
                default:
                    throw new Exception ("Error marking neighbors -- t doesn't contain edge p1-p2!");
            }
        }

        private void MarkNeighbor (int i_p1, int i_p2, DelaunayTriangle t) {
            switch (FindEdgeIndex (i_p1, i_p2)) {
                case 0:
                    N0 = t;
                    break;
                case 1:
                    N1 = t;
                    break;
                case 2:
                    N2 = t;
                    break;
                default:
                    throw new Exception ("Error marking neighbors -- t doesn't contain edge p1-p2!");
            }
        }

        public void ClearAllNBs () {
            N0 = (N1 = (N2 = null));
        }

        public void MarkNeighbor (DelaunayTriangle t) {
            P0.tempName = (P1.tempName = (P2.tempName = 3));
            t.P0.tempName = 0;
            t.P1.tempName = 1;
            t.P2.tempName = 2;
            bool flag = P0.tempName != 3;
            bool flag2 = P1.tempName != 3;
            bool flag3 = P2.tempName != 3;
            if (flag2 && flag3) {
                N0 = t;
                t.MarkNeighbor (P1.tempName, P2.tempName, this);
                return;
            }
            if (flag && flag3) {
                N1 = t;
                t.MarkNeighbor (P0.tempName, P2.tempName, this);
                return;
            }
            if (flag && flag2) {
                N2 = t;
                t.MarkNeighbor (P0.tempName, P1.tempName, this);
                return;
            }
            throw new Exception ("Failed to mark neighbor, doesn't share an edge!");
        }

        public TriangulationPoint OppositePoint (DelaunayTriangle t, TriangulationPoint p) {
            return PointCWFrom (t.PointCWFrom (p));
        }

        public TriangulationPoint OppositePoint (DelaunayTriangle t, TriangulationPoint p, int iPonT, out int foundAtIndex, out bool related_ec, out bool related_ed) {
            TriangulationPoint triangulationPoint = t.PointCWFrom (iPonT);
            P0.tempName = 0;
            P1.tempName = 1;
            P2.tempName = 2;
            switch (foundAtIndex = CalculateCWPoint (triangulationPoint.tempName)) {
                case 0:
                    related_ed = D0;
                    related_ec = C0;
                    return P0;
                case 1:
                    related_ed = D1;
                    related_ec = C1;
                    return P1;
                default:
                    related_ed = D2;
                    related_ec = C2;
                    return P2;
            }
        }

        public DelaunayTriangle NeighborCWFrom (TriangulationPoint point) {
            switch ((IndexOf (point) + 1) % 3) {
                case 0:
                    return N0;
                case 1:
                    return N1;
                default:
                    return N2;
            }
        }

        public DelaunayTriangle NeighborCCWFrom (TriangulationPoint point) {
            switch ((IndexOf (point) + 2) % 3) {
                case 0:
                    return N0;
                case 1:
                    return N1;
                default:
                    return N2;
            }
        }

        public void GetNBs (TriangulationPoint point, out int foundAt, out DelaunayTriangle t_ccw, out DelaunayTriangle t_cw, out bool c_ccw, out bool c_cw, out bool d_ccw, out bool d_cw) {
            switch (foundAt = IndexOf (point)) {
                case 0:
                    t_cw = N1;
                    t_ccw = N2;
                    c_cw = C1;
                    c_ccw = C2;
                    d_cw = D1;
                    d_ccw = D2;
                    break;
                case 1:
                    t_cw = N2;
                    t_ccw = N0;
                    c_cw = C2;
                    c_ccw = C0;
                    d_cw = D2;
                    d_ccw = D0;
                    break;
                default:
                    t_cw = N0;
                    t_ccw = N1;
                    c_cw = C0;
                    c_ccw = C1;
                    d_cw = D0;
                    d_ccw = D1;
                    break;
            }
        }

        public DelaunayTriangle NeighborAcrossFrom (TriangulationPoint point) {
            switch (IndexOf (point)) {
                case 0:
                    return N0;
                case 1:
                    return N1;
                default:
                    return N2;
            }
        }

        public TriangulationPoint PointCCWFrom (TriangulationPoint point) {
            switch ((IndexOf (point) + 1) % 3) {
                case 0:
                    return P0;
                case 1:
                    return P1;
                default:
                    return P2;
            }
        }

        public TriangulationPoint PointCCWFrom (int index) {
            switch ((index + 1) % 3) {
                case 0:
                    return P0;
                case 1:
                    return P1;
                default:
                    return P2;
            }
        }

        public TriangulationPoint PointCWFrom (TriangulationPoint point) {
            switch ((IndexOf (point) + 2) % 3) {
                case 0:
                    return P0;
                case 1:
                    return P1;
                default:
                    return P2;
            }
        }

        public TriangulationPoint PointCWFrom (int index) {
            switch ((index + 2) % 3) {
                case 0:
                    return P0;
                case 1:
                    return P1;
                default:
                    return P2;
            }
        }

        public static int CalculateCWPoint (int index) {
            return (index + 2) % 3;
        }

        public static int CalculateCCWPoint (int index) {
            return (index + 1) % 3;
        }

        public TriangulationPoint GetPoint (int index) {
            switch (index) {
                case 0:
                    return P0;
                case 1:
                    return P1;
                default:
                    return P2;
            }
        }

        internal void Legalize (int previousOPointIndex, TriangulationPoint oPoint, TriangulationPoint nPoint, out int newOPointIndex) {
            TriangulationPoint p = P2;
            P2 = P1;
            P1 = P0;
            P0 = p;
            switch (previousOPointIndex) {
                case 0:
                    newOPointIndex = 1;
                    P2 = nPoint;
                    break;
                case 1:
                    newOPointIndex = 2;
                    P0 = nPoint;
                    break;
                default:
                    newOPointIndex = 0;
                    P1 = nPoint;
                    break;
            }
        }

        public void MarkNeighborEdges () {
            if (C0 && N0 != null) {
                N0.SelectAndMarkConstrainedEdge (2, 1);
            }
            if (C1 && N1 != null) {
                N1.SelectAndMarkConstrainedEdge (1, 0);
            }
            if (C2 && N2 != null) {
                N2.SelectAndMarkConstrainedEdge (0, 1);
            }
        }

        public void MarkEdge (DelaunayTriangle triangle) {
            if (C0) {
                triangle.SelectAndMarkConstrainedEdge (2, 11);
            }
            if (C1) {
                triangle.SelectAndMarkConstrainedEdge (1, 0);
            }
            if (C2) {
                triangle.SelectAndMarkConstrainedEdge (0, 1);
            }
        }

        public void MarkEdge (List<DelaunayTriangle> tList) {
            foreach (DelaunayTriangle t in tList) {
                if (t.C0) {
                    SelectAndMarkConstrainedEdge (2, 1);
                }
                if (t.C1) {
                    SelectAndMarkConstrainedEdge (1, 0);
                }
                if (t.C2) {
                    SelectAndMarkConstrainedEdge (0, 1);
                }
            }
        }

        public void SelectAndMarkConstrainedEdge (TriangulationPoint p, TriangulationPoint q) {
            MarkEdgeConstraint (FindEdgeIndex (p, q), true);
        }

        public void SelectAndMarkConstrainedEdge (int i_p, int i_q) {
            MarkEdgeConstraint (FindEdgeIndex (i_p, i_q), true);
        }

        public double Area () {
            double num = P0.X - P1.X;
            double num2 = P2.Y - P1.Y;
            return Math.Abs (num * num2 * 0.5);
        }

        public void GetCentroid (out float cx, out float cy) {
            cx = (float) ((P0.X + P1.X + P2.X) / 3.0);
            cy = (float) ((P0.Y + P1.Y + P2.Y) / 3.0);
        }

        public int FindEdgeIndex (TriangulationPoint p1, TriangulationPoint p2) {
            p1.tempName = (p2.tempName = 3);
            P0.tempName = 0;
            P1.tempName = 1;
            P2.tempName = 2;
            return FindEdgeIndex (p1.tempName, p2.tempName);
        }

        public bool GetConstrainedEdgeCW (TriangulationPoint p) {
            return EdgeIsConstrained ((IndexOf (p) + 1) % 3);
        }

        public void SetNBCW (int index, bool c, bool d) {
            switch ((index + 1) % 3) {
                case 0:
                    C0 = c;
                    D0 = d;
                    break;
                case 1:
                    C1 = c;
                    D1 = d;
                    break;
                case 2:
                    C2 = c;
                    D2 = d;
                    break;
            }
        }

        public void SetNBCCW (int index, bool c, bool d) {
            switch ((index + 2) % 3) {
                case 0:
                    C0 = c;
                    D0 = d;
                    break;
                case 1:
                    C1 = c;
                    D1 = d;
                    break;
                case 2:
                    C2 = c;
                    D2 = d;
                    break;
            }
        }

        public static int FindEdgeIndexWithTempNameFlags (int totalFlags) {
            switch (totalFlags) {
                case 1:
                    return 2;
                case 2:
                    return 1;
                case 3:
                    return 0;
                default:
                    return -1;
            }
        }

        public static int FindEdgeIndex (int i1, int i2) {
            i1++;
            i2 = i2 + 1 << 2;
            switch (i1 | i2) {
                case 6:
                case 9:
                    return 2;
                case 7:
                case 13:
                    return 1;
                case 11:
                case 14:
                    return 0;
                default:
                    return -1;
            }
        }
    }
}