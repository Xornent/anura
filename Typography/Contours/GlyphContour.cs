using System;
using System.Collections.Generic;
using System.Numerics;

namespace Anura.Typography.Contours {
    public class GlyphContour {
        public List<GlyphPart> parts = new List<GlyphPart> ();

        internal List<GlyphPoint> flattenPoints;

        private List<OutsideEdgeLine> _edges;

        private bool _analyzed;

        private bool _analyzedClockDirection;

        private bool _isClockwise;

        public void AddPart (GlyphPart part) {
            parts.Add (part);
        }

        internal void Flatten (GlyphPartFlattener flattener) {
            if (!_analyzed) {
                int count = parts.Count;
                List<GlyphPoint> result = flattener.Result;
                List<GlyphPoint> list2 = flattener.Result = new List<GlyphPoint> ();
                List<GlyphPoint> list3 = flattenPoints = list2;
                for (int i = 0; i < count; i++) {
                    parts[i].Flatten (flattener);
                }
                int num = list3.Count;
                if (GlyphPoint.SameCoordAs (list3[num - 1], list3[0])) {
                    list3.RemoveAt (num - 1);
                    num--;
                }
                for (int j = 0; j < num; j++) {
                    list3[j].SeqNo = j;
                }
                flattener.Result = result;
                _analyzed = true;
            }
        }

        public bool IsClockwise () {
            if (_analyzedClockDirection) {
                return _isClockwise;
            }
            List<GlyphPoint> list = flattenPoints;
            if (list == null) {
                throw new NotSupportedException ();
            }
            _analyzedClockDirection = true;
            int count = flattenPoints.Count;
            double num = 0.0;
            for (int i = 1; i < count; i++) {
                GlyphPoint glyphPoint = list[i - 1];
                GlyphPoint glyphPoint2 = list[i];
                num += (double) ((glyphPoint2.OX - glyphPoint.OX) * (glyphPoint2.OY + glyphPoint.OY));
            }
            GlyphPoint glyphPoint3 = list[count - 1];
            GlyphPoint glyphPoint4 = list[0];
            num += (double) ((glyphPoint4.OX - glyphPoint3.OX) * (glyphPoint4.OY + glyphPoint3.OY));
            _isClockwise = (num >= 0.0);
            return _isClockwise;
        }

        internal void CreateGlyphEdges () {
            int num = flattenPoints.Count - 1;
            GlyphPoint glyphPoint = null;
            OutsideEdgeLine outsideEdgeLine = null;
            _edges = new List<OutsideEdgeLine> ();
            for (int i = 0; i < num; i++) {
                GlyphPoint p = flattenPoints[i];
                glyphPoint = flattenPoints[i + 1];
                if ((outsideEdgeLine = EdgeLine.FindCommonOutsideEdge (p, glyphPoint)) != null) {
                    _edges.Add (outsideEdgeLine);
                }
            }
            GlyphPoint p2 = flattenPoints[num];
            glyphPoint = flattenPoints[0];
            if ((outsideEdgeLine = EdgeLine.FindCommonOutsideEdge (p2, glyphPoint)) != null) {
                _edges.Add (outsideEdgeLine);
            }
        }

        internal void ApplyNewEdgeOffsetFromMasterOutline (float newEdgeOffsetFromMasterOutline) {
            int count = _edges.Count;
            for (int i = 0; i < count; i++) {
                _edges[i].SetDynamicEdgeOffsetFromMasterOutline (newEdgeOffsetFromMasterOutline);
            }
            for (int num = flattenPoints.Count - 1; num >= 0; num--) {
                UpdateNewEdgeCut (flattenPoints[num]);
            }
        }

        internal void FindBounds (ref float minX, ref float minY, ref float maxX, ref float maxY) {
            for (int num = flattenPoints.Count - 1; num >= 0; num--) {
                GlyphPoint glyphPoint = flattenPoints[num];
                MyMath.FindMinMax (ref minX, ref maxX, glyphPoint.X);
                MyMath.FindMinMax (ref minY, ref maxY, glyphPoint.Y);
            }
        }

        private static void UpdateNewEdgeCut (GlyphPoint p) {
            OutsideEdgeLine e = p.E0;
            OutsideEdgeLine e2 = p.E1;
            Vector2 p2 = e._newDynamicMidPoint + e.GetOriginalEdgeVector ();
            Vector2 p3 = e2._newDynamicMidPoint - e2.GetOriginalEdgeVector ();
            if (MyMath.FindCutPoint (e._newDynamicMidPoint, p2, e2._newDynamicMidPoint, p3, out Vector2 result)) {
                p.SetNewXY (result.X, result.Y);
            }
        }
    }
}