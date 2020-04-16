using System;
using System.Collections.Generic;

namespace Anura.Typography.Triangulation {
    public static class DTSweep {
        private const double PI_div2 = Math.PI / 2.0;

        private const double PI_3div4 = Math.PI * 3.0 / 4.0;

        public static void Triangulate (DTSweepContext tcx) {
            tcx.CreateAdvancingFront ();
            Sweep (tcx);
            if (tcx.TriangulationMode == TriangulationMode.Polygon) {
                FinalizationPolygon (tcx);
            } else {
                FinalizationConvexHull (tcx);
            }
        }

        private static void Sweep (DTSweepContext tcx) {
            List<TriangulationPoint> points = tcx.Points;
            for (int i = 1; i < points.Count; i++) {
                TriangulationPoint triangulationPoint = points[i];
                AdvancingFrontNode node = PointEvent (tcx, triangulationPoint);
                List<DTSweepConstraint> internalEdgeList = triangulationPoint.GetInternalEdgeList ();
                if (internalEdgeList != null) {
                    int count = internalEdgeList.Count;
                    if (tcx.IsDebugEnabled) {
                        for (int j = 0; j < count; j++) {
                            DTSweepConstraint edge = internalEdgeList[j];
                            EdgeEvent (tcx, edge, node);
                        }
                    } else {
                        for (int k = 0; k < count; k++) {
                            EdgeEvent (tcx, internalEdgeList[k], node);
                        }
                    }
                }
                tcx.Update (null);
            }
        }

        private static void FinalizationConvexHull (DTSweepContext tcx) {
            AdvancingFrontNode next = tcx.Front.Head.Next;
            AdvancingFrontNode next2 = next.Next;
            AdvancingFrontNode next3 = next2.Next;
            TriangulationPoint point = next.Point;
            TurnAdvancingFrontConvex (tcx, next, next2);
            next = tcx.Front.Tail.Prev;
            DelaunayTriangle delaunayTriangle;
            if (next.Triangle.Contains (next.Next.Point) && next.Triangle.Contains (next.Prev.Point)) {
                delaunayTriangle = next.Triangle.NeighborAcrossFrom (next.Point);
                RotateTrianglePair (next.Triangle, next.Point, delaunayTriangle, delaunayTriangle.OppositePoint (next.Triangle, next.Point));
                tcx.MapTriangleToNodes (next.Triangle);
                tcx.MapTriangleToNodes (delaunayTriangle);
            }
            next = tcx.Front.Head.Next;
            if (next.Triangle.Contains (next.Prev.Point) && next.Triangle.Contains (next.Next.Point)) {
                delaunayTriangle = next.Triangle.NeighborAcrossFrom (next.Point);
                RotateTrianglePair (next.Triangle, next.Point, delaunayTriangle, delaunayTriangle.OppositePoint (next.Triangle, next.Point));
                tcx.MapTriangleToNodes (next.Triangle);
                tcx.MapTriangleToNodes (delaunayTriangle);
            }
            point = tcx.Front.Head.Point;
            next2 = tcx.Front.Tail.Prev;
            delaunayTriangle = next2.Triangle;
            TriangulationPoint triangulationPoint = next2.Point;
            while (true) {
                tcx.RemoveFromList (delaunayTriangle);
                triangulationPoint = delaunayTriangle.PointCCWFrom (triangulationPoint);
                if (triangulationPoint == point) {
                    break;
                }
                delaunayTriangle = delaunayTriangle.NeighborCCWFrom (triangulationPoint);
            }
            point = tcx.Front.Head.Next.Point;
            triangulationPoint = delaunayTriangle.PointCWFrom (tcx.Front.Head.Point);
            delaunayTriangle = delaunayTriangle.NeighborCWFrom (tcx.Front.Head.Point);
            do {
                tcx.RemoveFromList (delaunayTriangle);
                triangulationPoint = delaunayTriangle.PointCCWFrom (triangulationPoint);
                delaunayTriangle = delaunayTriangle.NeighborCCWFrom (triangulationPoint);
            }
            while (triangulationPoint != point);
            tcx.FinalizeTriangulation ();
        }

        private static void TurnAdvancingFrontConvex (DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c) {
            AdvancingFrontNode advancingFrontNode = b;
            while (c != tcx.Front.Tail) {
                if (TriangulationUtil.Orient2d (b.Point, c.Point, c.Next.Point) == Orientation.CCW) {
                    Fill (tcx, c);
                    c = c.Next;
                } else if (b != advancingFrontNode && TriangulationUtil.Orient2d (b.Prev.Point, b.Point, c.Point) == Orientation.CCW) {
                    Fill (tcx, b);
                    b = b.Prev;
                } else {
                    b = c;
                    c = c.Next;
                }
            }
        }

        private static void FinalizationPolygon (DTSweepContext tcx) {
            DelaunayTriangle delaunayTriangle = tcx.Front.Head.Next.Triangle;
            TriangulationPoint point = tcx.Front.Head.Next.Point;
            while (!delaunayTriangle.GetConstrainedEdgeCW (point)) {
                delaunayTriangle = delaunayTriangle.NeighborCCWFrom (point);
            }
            tcx.MeshClean (delaunayTriangle);
        }

        private static AdvancingFrontNode PointEvent (DTSweepContext tcx, TriangulationPoint point) {
            AdvancingFrontNode advancingFrontNode = tcx.LocateNode (point);
            AdvancingFrontNode advancingFrontNode2 = NewFrontTriangle (tcx, point, advancingFrontNode);
            if (point.X <= advancingFrontNode.Point.X + 1E-12) {
                Fill (tcx, advancingFrontNode);
            }
            FillAdvancingFront (tcx, advancingFrontNode2);
            return advancingFrontNode2;
        }

        private static AdvancingFrontNode NewFrontTriangle (DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node) {
            DelaunayTriangle delaunayTriangle = new DelaunayTriangle (point, node.Point, node.Next.Point);
            delaunayTriangle.MarkNeighbor (node.Triangle);
            tcx.Triangles.Add (delaunayTriangle);
            AdvancingFrontNode advancingFrontNode = new AdvancingFrontNode (point);
            advancingFrontNode.Next = node.Next;
            advancingFrontNode.Prev = node;
            node.Next.Prev = advancingFrontNode;
            node.Next = advancingFrontNode;
            if (!Legalize (tcx, delaunayTriangle)) {
                tcx.MapTriangleToNodes (delaunayTriangle);
            }
            return advancingFrontNode;
        }

        private static void EdgeEvent (DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) {
            try {
                tcx.EdgeEventConstrainedEdge = edge;
                tcx.EdgeEventRight = (edge.P.X > edge.Q.X);
                if (!MarkEdgeSideOfTriangle (node.Triangle, edge.P, edge.Q)) {
                    FillEdgeEvent (tcx, edge, node);
                    EdgeEvent (tcx, edge.P, edge.Q, node.Triangle, edge.Q);
                }
            } catch (PointOnEdgeException ex) {
                Console.WriteLine ($"Warning: Skipping Edge: {ex.Message}");
                throw;
            }
        }

        private static void FillEdgeEvent (DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) {
            if (tcx.EdgeEventRight) {
                FillRightAboveEdgeEvent (tcx, edge, node);
            } else {
                FillLeftAboveEdgeEvent (tcx, edge, node);
            }
        }

        private static void FillRightConcaveEdgeEvent (DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) {
            Fill (tcx, node.Next);
            if (node.Next.Point != edge.P && TriangulationUtil.Orient2d (edge.Q, node.Next.Point, edge.P) == Orientation.CCW && TriangulationUtil.Orient2d (node.Point, node.Next.Point, node.Next.Next.Point) == Orientation.CCW) {
                FillRightConcaveEdgeEvent (tcx, edge, node);
            }
        }

        private static void FillRightConvexEdgeEvent (DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) {
            if (TriangulationUtil.Orient2d (node.Next.Point, node.Next.Next.Point, node.Next.Next.Next.Point) == Orientation.CCW) {
                FillRightConcaveEdgeEvent (tcx, edge, node.Next);
            } else if (TriangulationUtil.Orient2d (edge.Q, node.Next.Next.Point, edge.P) == Orientation.CCW) {
                FillRightConvexEdgeEvent (tcx, edge, node.Next);
            }
        }

        private static void FillRightBelowEdgeEvent (DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) {
            if (node.Point.X < edge.P.X) {
                if (TriangulationUtil.Orient2d (node.Point, node.Next.Point, node.Next.Next.Point) == Orientation.CCW) {
                    FillRightConcaveEdgeEvent (tcx, edge, node);
                    return;
                }
                FillRightConvexEdgeEvent (tcx, edge, node);
                FillRightBelowEdgeEvent (tcx, edge, node);
            }
        }

        private static void FillRightAboveEdgeEvent (DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) {
            while (node.Next.Point.X < edge.P.X) {
                if (TriangulationUtil.Orient2d (edge.Q, node.Next.Point, edge.P) == Orientation.CCW) {
                    FillRightBelowEdgeEvent (tcx, edge, node);
                } else {
                    node = node.Next;
                }
            }
        }

        private static void FillLeftConvexEdgeEvent (DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) {
            if (TriangulationUtil.Orient2d (node.Prev.Point, node.Prev.Prev.Point, node.Prev.Prev.Prev.Point) == Orientation.CW) {
                FillLeftConcaveEdgeEvent (tcx, edge, node.Prev);
            } else if (TriangulationUtil.Orient2d (edge.Q, node.Prev.Prev.Point, edge.P) == Orientation.CW) {
                FillLeftConvexEdgeEvent (tcx, edge, node.Prev);
            }
        }

        private static void FillLeftConcaveEdgeEvent (DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) {
            Fill (tcx, node.Prev);
            if (node.Prev.Point != edge.P && TriangulationUtil.Orient2d (edge.Q, node.Prev.Point, edge.P) == Orientation.CW && TriangulationUtil.Orient2d (node.Point, node.Prev.Point, node.Prev.Prev.Point) == Orientation.CW) {
                FillLeftConcaveEdgeEvent (tcx, edge, node);
            }
        }

        private static void FillLeftBelowEdgeEvent (DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) {
            if (node.Point.X > edge.P.X) {
                if (TriangulationUtil.Orient2d (node.Point, node.Prev.Point, node.Prev.Prev.Point) == Orientation.CW) {
                    FillLeftConcaveEdgeEvent (tcx, edge, node);
                    return;
                }
                FillLeftConvexEdgeEvent (tcx, edge, node);
                FillLeftBelowEdgeEvent (tcx, edge, node);
            }
        }

        private static void FillLeftAboveEdgeEvent (DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) {
            while (node.Prev.Point.X > edge.P.X) {
                if (TriangulationUtil.Orient2d (edge.Q, node.Prev.Point, edge.P) == Orientation.CW) {
                    FillLeftBelowEdgeEvent (tcx, edge, node);
                } else {
                    node = node.Prev;
                }
            }
        }

        private static bool MarkEdgeSideOfTriangle (DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq) {
            switch (triangle.FindEdgeIndex (ep, eq)) {
                case 0:
                    triangle.C0 = true;
                    if ((triangle = triangle.N0) != null) {
                        triangle.SelectAndMarkConstrainedEdge (ep, eq);
                    }
                    return true;
                case 1:
                    triangle.C1 = true;
                    if ((triangle = triangle.N1) != null) {
                        triangle.SelectAndMarkConstrainedEdge (ep, eq);
                    }
                    return true;
                case 2:
                    triangle.C2 = true;
                    if ((triangle = triangle.N2) != null) {
                        triangle.SelectAndMarkConstrainedEdge (ep, eq);
                    }
                    return true;
                default:
                    return false;
            }
        }

        private static void EdgeEvent (DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point) {
            if (!MarkEdgeSideOfTriangle (triangle, ep, eq)) {
                TriangulationPoint triangulationPoint = triangle.PointCCWFrom (point);
                Orientation orientation = TriangulationUtil.Orient2d (eq, triangulationPoint, ep);
                if (orientation == Orientation.Collinear) {
                    throw new PointOnEdgeException ("EdgeEvent - Point on constrained edge not supported yet", eq, triangulationPoint, ep);
                }
                TriangulationPoint triangulationPoint2 = triangle.PointCWFrom (point);
                Orientation orientation2 = TriangulationUtil.Orient2d (eq, triangulationPoint2, ep);
                if (orientation2 == Orientation.Collinear) {
                    throw new PointOnEdgeException ("EdgeEvent - Point on constrained edge not supported yet", eq, triangulationPoint2, ep);
                }
                if (orientation == orientation2) {
                    triangle = ((orientation != 0) ? triangle.NeighborCWFrom (point) : triangle.NeighborCCWFrom (point));
                    EdgeEvent (tcx, ep, eq, triangle, point);
                } else {
                    FlipEdgeEvent (tcx, ep, eq, triangle, point);
                }
            }
        }

        private static void FlipEdgeEvent (DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p) {
            DelaunayTriangle delaunayTriangle = t.NeighborAcrossFrom (p);
            TriangulationPoint triangulationPoint = delaunayTriangle.OppositePoint (t, p);
            if (delaunayTriangle == null) {
                throw new InvalidOperationException ("[BUG:FIXME] FLIP failed due to missing triangle");
            }
            int index = t.IndexOf (p);
            if (TriangulationUtil.InScanArea (p, t.PointCCWFrom (index), t.PointCWFrom (index), triangulationPoint)) {
                RotateTrianglePair (t, p, delaunayTriangle, triangulationPoint);
                tcx.MapTriangleToNodes (t);
                tcx.MapTriangleToNodes (delaunayTriangle);
                if (p == eq && triangulationPoint == ep) {
                    if (eq == tcx.EdgeEventConstrainedEdge.Q && ep == tcx.EdgeEventConstrainedEdge.P) {
                        if (tcx.IsDebugEnabled) {
                            Console.WriteLine ("[FLIP] - constrained edge done");
                        }
                        t.SelectAndMarkConstrainedEdge (ep, eq);
                        delaunayTriangle.SelectAndMarkConstrainedEdge (ep, eq);
                        Legalize (tcx, t);
                        Legalize (tcx, delaunayTriangle);
                    } else if (tcx.IsDebugEnabled) {
                        Console.WriteLine ("[FLIP] - subedge done");
                    }
                } else {
                    if (tcx.IsDebugEnabled) {
                        Console.WriteLine ("[FLIP] - flipping and continuing with triangle still crossing edge");
                    }
                    Orientation o = TriangulationUtil.Orient2d (eq, triangulationPoint, ep);
                    t = NextFlipTriangle (tcx, o, t, delaunayTriangle, p, triangulationPoint);
                    FlipEdgeEvent (tcx, ep, eq, t, p);
                }
            } else {
                TriangulationPoint p2 = NextFlipPoint (ep, eq, delaunayTriangle, triangulationPoint);
                FlipScanEdgeEvent (tcx, ep, eq, t, delaunayTriangle, p2);
                EdgeEvent (tcx, ep, eq, t, p);
            }
        }

        private static TriangulationPoint NextFlipPoint (TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op) {
            switch (TriangulationUtil.Orient2d (eq, op, ep)) {
                case Orientation.CW:
                    return ot.PointCCWFrom (op);
                case Orientation.CCW:
                    return ot.PointCWFrom (op);
                case Orientation.Collinear:
                    throw new PointOnEdgeException ("Point on constrained edge not supported yet", eq, op, ep);
                default:
                    throw new NotImplementedException ("Orientation not handled");
            }
        }

        private static DelaunayTriangle NextFlipTriangle (DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op) {
            int index;
            if (o == Orientation.CCW) {
                index = ot.FindEdgeIndex (p, op);
                ot.MarkEdgeDelunay (index, true);
                Legalize (tcx, ot);
                ot.ClearAllEdgeDelaunayMarks ();
                return t;
            }
            index = t.FindEdgeIndex (p, op);
            t.MarkEdgeDelunay (index, true);
            Legalize (tcx, t);
            t.ClearAllEdgeDelaunayMarks ();
            return ot;
        }

        private static void FlipScanEdgeEvent (DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p) {
            DelaunayTriangle delaunayTriangle = t.NeighborAcrossFrom (p);
            TriangulationPoint triangulationPoint = delaunayTriangle.OppositePoint (t, p);
            if (delaunayTriangle == null) {
                throw new Exception ("[BUG:FIXME] FLIP failed due to missing triangle");
            }
            int index = flipTriangle.IndexOf (eq);
            if (TriangulationUtil.InScanArea (eq, flipTriangle.PointCCWFrom (index), flipTriangle.PointCWFrom (index), triangulationPoint)) {
                FlipEdgeEvent (tcx, eq, triangulationPoint, delaunayTriangle, triangulationPoint);
                return;
            }
            TriangulationPoint p2 = NextFlipPoint (ep, eq, delaunayTriangle, triangulationPoint);
            FlipScanEdgeEvent (tcx, ep, eq, flipTriangle, delaunayTriangle, p2);
        }

        private static void FillAdvancingFront (DTSweepContext tcx, AdvancingFrontNode n) {
            AdvancingFrontNode next = n.Next;
            while (next.HasNext) {
                double num = HoleAngle (next);
                if (num > Math.PI / 2.0 || num < -Math.PI / 2.0) {
                    break;
                }
                Fill (tcx, next);
                next = next.Next;
            }
            next = n.Prev;
            while (next.HasPrev) {
                double num = HoleAngle (next);
                if (num > Math.PI / 2.0 || num < -Math.PI / 2.0) {
                    break;
                }
                Fill (tcx, next);
                next = next.Prev;
            }
            if (n.HasNext && n.Next.HasNext) {
                double num = BasinAngle (n);
                if (num < Math.PI * 3.0 / 4.0) {
                    FillBasin (tcx, n);
                }
            }
        }

        private static void FillBasin (DTSweepContext tcx, AdvancingFrontNode node) {
            if (TriangulationUtil.Orient2d (node.Point, node.Next.Point, node.Next.Next.Point) == Orientation.CCW) {
                tcx.BasinLeftNode = node;
            } else {
                tcx.BasinLeftNode = node.Next;
            }
            tcx.BasinBottomNode = tcx.BasinLeftNode;
            while (tcx.BasinBottomNode.HasNext && tcx.BasinBottomNode.Point.Y >= tcx.BasinBottomNode.Next.Point.Y) {
                tcx.BasinBottomNode = tcx.BasinBottomNode.Next;
            }
            if (tcx.BasinBottomNode != tcx.BasinLeftNode) {
                tcx.BasinRightNode = tcx.BasinBottomNode;
                while (tcx.BasinRightNode.HasNext && tcx.BasinRightNode.Point.Y < tcx.BasinRightNode.Next.Point.Y) {
                    tcx.BasinRightNode = tcx.BasinRightNode.Next;
                }
                if (tcx.BasinRightNode != tcx.BasinBottomNode) {
                    tcx.BasinWidth = tcx.BasinRightNode.Point.X - tcx.BasinLeftNode.Point.X;
                    tcx.BasinLeftHighest = (tcx.BasinLeftNode.Point.Y > tcx.BasinRightNode.Point.Y);
                    FillBasinReq (tcx, tcx.BasinBottomNode);
                }
            }
        }

        private static void FillBasinReq (DTSweepContext tcx, AdvancingFrontNode node) {
            if (IsShallow (tcx, node)) {
                return;
            }
            Fill (tcx, node);
            if (node.Prev == tcx.BasinLeftNode && node.Next == tcx.BasinRightNode) {
                return;
            }
            if (node.Prev == tcx.BasinLeftNode) {
                if (TriangulationUtil.Orient2d (node.Point, node.Next.Point, node.Next.Next.Point) == Orientation.CW) {
                    return;
                }
                node = node.Next;
            } else if (node.Next != tcx.BasinRightNode) {
                node = ((!(node.Prev.Point.Y < node.Next.Point.Y)) ? node.Next : node.Prev);
            } else {
                if (TriangulationUtil.Orient2d (node.Point, node.Prev.Point, node.Prev.Prev.Point) == Orientation.CCW) {
                    return;
                }
                node = node.Prev;
            }
            FillBasinReq (tcx, node);
        }

        private static bool IsShallow (DTSweepContext tcx, AdvancingFrontNode node) {
            double num = (!tcx.BasinLeftHighest) ? (tcx.BasinRightNode.Point.Y - node.Point.Y) : (tcx.BasinLeftNode.Point.Y - node.Point.Y);
            if (tcx.BasinWidth > num) {
                return true;
            }
            return false;
        }

        private static double HoleAngle (AdvancingFrontNode node) {
            double x = node.Point.X;
            double y = node.Point.Y;
            double num = node.Next.Point.X - x;
            double num2 = node.Next.Point.Y - y;
            double num3 = node.Prev.Point.X - x;
            double num4 = node.Prev.Point.Y - y;
            return Math.Atan2 (num * num4 - num2 * num3, num * num3 + num2 * num4);
        }

        private static double BasinAngle (AdvancingFrontNode node) {
            double x = node.Point.X - node.Next.Next.Point.X;
            return Math.Atan2 (node.Point.Y - node.Next.Next.Point.Y, x);
        }

        private static void Fill (DTSweepContext tcx, AdvancingFrontNode node) {
            DelaunayTriangle delaunayTriangle = new DelaunayTriangle (node.Prev.Point, node.Point, node.Next.Point);
            delaunayTriangle.MarkNeighbor (node.Prev.Triangle);
            delaunayTriangle.MarkNeighbor (node.Triangle);
            tcx.Triangles.Add (delaunayTriangle);
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
            if (!Legalize (tcx, delaunayTriangle)) {
                tcx.MapTriangleToNodes (delaunayTriangle);
            }
        }

        private static bool Legalize (DTSweepContext tcx, DelaunayTriangle t) {
            for (int i = 0; i < 3; i++) {
                DelaunayTriangle delaunayTriangle = null;
                TriangulationPoint triangulationPoint = null;
                switch (i) {
                    default : if (t.D0) {
                        continue;
                    }
                    triangulationPoint = t.P0;
                    delaunayTriangle = t.N0;
                    break;
                    case 1:
                            if (t.D1) {
                            continue;
                        }
                        triangulationPoint = t.P1;
                        delaunayTriangle = t.N1;
                        break;
                    case 2:
                            if (t.D2) {
                            continue;
                        }
                        triangulationPoint = t.P2;
                        delaunayTriangle = t.N2;
                        break;
                }
                if (delaunayTriangle == null) {
                    continue;
                }
                int foundAtIndex;
                bool related_ec;
                bool related_ed;
                TriangulationPoint triangulationPoint2 = delaunayTriangle.OppositePoint (t, triangulationPoint, i, out foundAtIndex, out related_ec, out related_ed);
                if (related_ec | related_ed) {
                    t.MarkEdgeConstraint (i, related_ec);
                } else if (TriangulationUtil.SmartInCircle (triangulationPoint, t.PointCCWFrom (i), t.PointCWFrom (i), triangulationPoint2)) {
                    t.MarkEdgeDelunay (i, true);
                    delaunayTriangle.MarkEdgeDelunay (foundAtIndex, true);
                    RotateTrianglePair (t, triangulationPoint, delaunayTriangle, triangulationPoint2);
                    if (!Legalize (tcx, t)) {
                        tcx.MapTriangleToNodes (t);
                    }
                    if (!Legalize (tcx, delaunayTriangle)) {
                        tcx.MapTriangleToNodes (delaunayTriangle);
                    }
                    t.MarkEdgeDelunay (i, false);
                    delaunayTriangle.MarkEdgeDelunay (foundAtIndex, false);
                    return true;
                }
            }
            return false;
        }

        private static void RotateTrianglePair (DelaunayTriangle t, TriangulationPoint p, DelaunayTriangle ot, TriangulationPoint op) {
            t.GetNBs (p, out int foundAt, out DelaunayTriangle t_ccw, out DelaunayTriangle t_cw, out bool c_ccw, out bool c_cw, out bool d_ccw, out bool d_cw);
            ot.GetNBs (op, out int foundAt2, out DelaunayTriangle t_ccw2, out DelaunayTriangle t_cw2, out bool c_ccw2, out bool c_cw2, out bool d_ccw2, out bool d_cw2);
            t.Legalize (foundAt, p, op, out int newOPointIndex);
            ot.Legalize (foundAt2, op, p, out int newOPointIndex2);
            int index = ot.IndexOf (p);
            int index2 = newOPointIndex2;
            int index3 = newOPointIndex;
            int index4 = t.IndexOf (op);
            ot.SetNBCCW (index, c_ccw, d_ccw);
            ot.SetNBCW (index2, c_cw2, d_cw2);
            t.SetNBCW (index3, c_cw, d_cw);
            t.SetNBCCW (index4, c_ccw2, d_ccw2);
            t.ClearAllNBs ();
            ot.ClearAllNBs ();
            if (t_ccw != null) {
                ot.MarkNeighbor (t_ccw);
            }
            if (t_cw != null) {
                t.MarkNeighbor (t_cw);
            }
            if (t_ccw2 != null) {
                t.MarkNeighbor (t_ccw2);
            }
            if (t_cw2 != null) {
                ot.MarkNeighbor (t_cw2);
            }
            t.MarkNeighbor (ot);
        }
    }
}