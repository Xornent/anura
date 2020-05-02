using System.Collections.Generic;

namespace Anura.Typography.Triangulation {
    public class DTSweepContext : TriangulationContext {
        private const float ALPHA = 0.3f;

        internal AdvancingFront Front;

        internal AdvancingFrontNode BasinLeftNode;

        internal AdvancingFrontNode BasinBottomNode;

        internal AdvancingFrontNode BasinRightNode;

        internal double BasinWidth;

        internal bool BasinLeftHighest;

        internal DTSweepConstraint EdgeEventConstrainedEdge;

        internal bool EdgeEventRight;

        private TriangulationPoint Head {
            get;
            set;
        }

        private TriangulationPoint Tail {
            get;
            set;
        }

        public override TriangulationAlgorithm Algorithm => TriangulationAlgorithm.DTSweep;

        public void RemoveFromList (DelaunayTriangle triangle) {
            Triangles.Remove (triangle);
        }

        public void MeshClean (DelaunayTriangle triangle) {
            MeshCleanReq (triangle);
        }

        private void MeshCleanReq (DelaunayTriangle triangle) {
            if (triangle != null && !triangle.IsInterior) {
                triangle.IsInterior = true;
                base.Triangulatable.AddTriangle (triangle);
                if (!triangle.C0) {
                    MeshCleanReq (triangle.N0);
                }
                if (!triangle.C1) {
                    MeshCleanReq (triangle.N1);
                }
                if (!triangle.C2) {
                    MeshCleanReq (triangle.N2);
                }
            }
        }

        public override void Clear () {
            base.Clear ();
        }

        internal AdvancingFrontNode LocateNode (TriangulationPoint point) {
            return Front.LocateNode (point);
        }

        public void CreateAdvancingFront () {
            DelaunayTriangle delaunayTriangle = new DelaunayTriangle (Points[0], Tail, Head);
            Triangles.Add (delaunayTriangle);
            AdvancingFrontNode advancingFrontNode = new AdvancingFrontNode (delaunayTriangle.P1);
            advancingFrontNode.Triangle = delaunayTriangle;
            AdvancingFrontNode advancingFrontNode2 = new AdvancingFrontNode (delaunayTriangle.P0);
            advancingFrontNode2.Triangle = delaunayTriangle;
            AdvancingFrontNode tail = new AdvancingFrontNode (delaunayTriangle.P2);
            Front = new AdvancingFront (advancingFrontNode, tail);
            Front.Head.Next = advancingFrontNode2;
            advancingFrontNode2.Next = Front.Tail;
            advancingFrontNode2.Prev = Front.Head;
            Front.Tail.Prev = advancingFrontNode2;
        }

        public void MapTriangleToNodes (DelaunayTriangle t) {
            if (t.N0 == null) {
                AdvancingFrontNode advancingFrontNode = Front.LocatePoint (t.P2);
                if (advancingFrontNode != null) {
                    advancingFrontNode.Triangle = t;
                }
            }
            if (t.N1 == null) {
                AdvancingFrontNode advancingFrontNode2 = Front.LocatePoint (t.P0);
                if (advancingFrontNode2 != null) {
                    advancingFrontNode2.Triangle = t;
                }
            }
            if (t.N2 == null) {
                AdvancingFrontNode advancingFrontNode3 = Front.LocatePoint (t.P1);
                if (advancingFrontNode3 != null) {
                    advancingFrontNode3.Triangle = t;
                }
            }
        }

        public override void PrepareTriangulation (Triangulatable t) {
            base.PrepareTriangulation (t);
            double x;
            double num = x = Points[0].X;
            double y;
            double num2 = y = Points[0].Y;
            List<TriangulationPoint> points = Points;
            for (int num3 = points.Count - 1; num3 >= 0; num3--) {
                TriangulationPoint triangulationPoint = points[num3];
                if (triangulationPoint.X > num) {
                    num = triangulationPoint.X;
                }
                if (triangulationPoint.X < x) {
                    x = triangulationPoint.X;
                }
                if (triangulationPoint.Y > num2) {
                    num2 = triangulationPoint.Y;
                }
                if (triangulationPoint.Y < y) {
                    y = triangulationPoint.Y;
                }
            }
            double num4 = 0.30000001192092896 * (num - x);
            double num5 = 0.30000001192092896 * (num2 - y);
            TriangulationPoint head = new TriangulationPoint (num + num4, y - num5);
            TriangulationPoint tail = new TriangulationPoint (x - num4, y - num5);
            Head = head;
            Tail = tail;
            Points.Sort (Compare);
        }

        private static int Compare (TriangulationPoint p1, TriangulationPoint p2) {
            if (p1.Y < p2.Y) {
                return -1;
            }
            if (p1.Y > p2.Y) {
                return 1;
            }
            if (p1.X < p2.X) {
                return -1;
            }
            if (p1.X > p2.X) {
                return 1;
            }
            return 0;
        }

        public void FinalizeTriangulation () {
            base.Triangulatable.AddTriangles (Triangles);
            Triangles.Clear ();
        }

        public override void MakeNewConstraint (TriangulationPoint a, TriangulationPoint b) {
            DTSweepConstraintMaker.BuildConstraint (a, b);
        }
    }
}