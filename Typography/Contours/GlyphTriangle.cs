using System;
using System.Numerics;
using Anura.Typography.Triangulation;

namespace Anura.Typography.Contours {
    internal class GlyphTriangle {
        private DelaunayTriangle _tri;

        public readonly EdgeLine e0;

        public readonly EdgeLine e1;

        public readonly EdgeLine e2;

        public GlyphTriangle N0 => GetGlyphTriFromUserData (_tri.N0);

        public GlyphTriangle N1 => GetGlyphTriFromUserData (_tri.N1);

        public GlyphTriangle N2 => GetGlyphTriFromUserData (_tri.N2);

        public GlyphTriangle (DelaunayTriangle tri) {
            _tri = tri;
            TriangulationPoint p = _tri.P0;
            TriangulationPoint p2 = _tri.P1;
            TriangulationPoint p3 = _tri.P2;
            e0 = NewEdgeLine (p, p2, tri.EdgeIsConstrained (tri.FindEdgeIndex (p, p2)));
            e1 = NewEdgeLine (p2, p3, tri.EdgeIsConstrained (tri.FindEdgeIndex (p2, p3)));
            e2 = NewEdgeLine (p3, p, tri.EdgeIsConstrained (tri.FindEdgeIndex (p3, p)));
            tri.userData = this;
            AnalyzeInsideEdge (e0, e1, e2);
            AnalyzeInsideEdge (e1, e0, e2);
            AnalyzeInsideEdge (e2, e0, e1);
            CalculateCentroid (out float centroidX, out float centroidY);
            AnalyzeOutsideEdge (e0, centroidX, centroidY);
            AnalyzeOutsideEdge (e1, centroidX, centroidY);
            AnalyzeOutsideEdge (e2, centroidX, centroidY);
        }

        private void AnalyzeOutsideEdge (EdgeLine d, float centroidX, float centroidY) {
            if (d.IsOutside) {
                switch (d.SlopeKind) {
                    case LineSlopeKind.Horizontal:
                        d.IsUpper = (d.GetMidPoint ().Y > centroidY);
                        break;
                    case LineSlopeKind.Vertical:
                        d.IsLeftSide = (d.GetMidPoint ().X < centroidX);
                        break;
                }
            }
        }

        private void AnalyzeInsideEdge (EdgeLine d0, EdgeLine d1, EdgeLine d2) {
            if (d0._earlyInsideAnalysis || !d0.IsInside) {
                return;
            }
            if (d1.IsInside) {
                if (!d2.IsInside) {
                    FindPerpendicular (d2, d0);
                    FindPerpendicular (d2, d1);
                }
            } else if (d2.IsInside && !d1.IsInside) {
                FindPerpendicular (d1, d0);
                FindPerpendicular (d1, d2);
            }
        }

        private static void FindPerpendicular (EdgeLine outsideEdge, EdgeLine inside) {
            Vector2 midPoint = inside.GetMidPoint ();
            if (MyMath.FindPerpendicularCutPoint (outsideEdge, new Vector2 (midPoint.X, midPoint.Y), out Vector2 _)) {
                ((OutsideEdgeLine) outsideEdge).SetControlEdge (inside);
            }
            outsideEdge._earlyInsideAnalysis = (inside._earlyInsideAnalysis = true);
        }

        private EdgeLine NewEdgeLine (TriangulationPoint p, TriangulationPoint q, bool isOutside) {
            if (!isOutside) {
                return new InsideEdgeLine (this, p.userData as GlyphPoint, q.userData as GlyphPoint);
            }
            return new OutsideEdgeLine (this, p.userData as GlyphPoint, q.userData as GlyphPoint);
        }

        public void CalculateCentroid (out float centroidX, out float centroidY) {
            _tri.GetCentroid (out centroidX, out centroidY);
        }

        public bool IsConnectedTo (GlyphTriangle anotherTri) {
            DelaunayTriangle tri = anotherTri._tri;
            if (tri == _tri) {
                throw new NotSupportedException ();
            }
            if (_tri.N0 != tri && _tri.N1 != tri) {
                return _tri.N2 == tri;
            }
            return true;
        }

        private static GlyphTriangle GetGlyphTriFromUserData (DelaunayTriangle tri) {
            if (tri == null) {
                return null;
            }
            return tri.userData as GlyphTriangle;
        }
    }
}