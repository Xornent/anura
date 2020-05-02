using System;
using System.Collections.Generic;
using Anura.Typography.Triangulation;

namespace Anura.Typography.Contours {
    internal class GlyphIntermediateOutline {
        private List<GlyphContour> _contours;

        private List<CentroidLineHub> _lineHubs;

        private float _bounds_minX;

        private float _bounds_minY;

        private float _bounds_maxX;

        private float _bounds_maxY;

        public float MinX => _bounds_minX;

        public float MinY => _bounds_minY;

        public float MaxX => _bounds_maxX;

        public float MaxY => _bounds_maxY;

        public GlyphIntermediateOutline (List<GlyphContour> contours, Polygon polygon, Polygon[] subPolygons) {
            _contours = contours;
            CreateCentroidLineHubs (polygon, subPolygons);
            CreateBoneJoints ();
            CreateBones ();
            CreateGlyphEdges ();
        }

        private void CreateCentroidLineHubs (Polygon polygon, Polygon[] subPolygons) {
            List<GlyphTriangle> list = new List<GlyphTriangle> ();
            _lineHubs = new List<CentroidLineHub> ();
            CreateCentroidLineHubs (polygon, list, _lineHubs);
            if (subPolygons != null) {
                int num = subPolygons.Length;
                for (int i = 0; i < num; i++) {
                    list.Clear ();
                    CreateCentroidLineHubs (subPolygons[i], list, _lineHubs);
                }
            }
        }

        private static void CreateCentroidLineHubs (Polygon polygon, List<GlyphTriangle> triangles, List<CentroidLineHub> outputLineHubs) {
            foreach (DelaunayTriangle triangle in polygon.Triangles) {
                triangle.MarkAsActualTriangle ();
                triangles.Add (new GlyphTriangle (triangle));
            }
            Dictionary<GlyphTriangle, CentroidLineHub> dictionary = new Dictionary<GlyphTriangle, CentroidLineHub> ();
            CentroidLineHub centroidLineHub = null;
            List<GlyphTriangle> list = new List<GlyphTriangle> ();
            GlyphTriangle glyphTriangle = null;
            int count = triangles.Count;
            for (int i = 0; i < count; i++) {
                GlyphTriangle glyphTriangle2 = triangles[i];
                if (i == 0) {
                    centroidLineHub = (dictionary[glyphTriangle2] = new CentroidLineHub (glyphTriangle2));
                    list.Add (glyphTriangle = glyphTriangle2);
                    continue;
                }
                int num = FindLatestConnectedTri (list, glyphTriangle2);
                if (num < 0) {
                    throw new NotSupportedException ();
                }
                list.Add (glyphTriangle2);
                GlyphTriangle glyphTriangle3 = list[num];
                if (glyphTriangle3 != glyphTriangle) {
                    if (!dictionary.TryGetValue (glyphTriangle3, out CentroidLineHub value)) {
                        value = (dictionary[glyphTriangle3] = new CentroidLineHub (glyphTriangle3));
                    }
                    centroidLineHub = value;
                    value.SetCurrentCentroidLine (glyphTriangle2);
                    centroidLineHub.AddCentroidPair (new GlyphCentroidPair (glyphTriangle3, glyphTriangle2));
                } else {
                    if (centroidLineHub.LineCount == 0) {
                        centroidLineHub.SetCurrentCentroidLine (glyphTriangle2);
                    }
                    centroidLineHub.AddCentroidPair (new GlyphCentroidPair (glyphTriangle3, glyphTriangle2));
                }
                glyphTriangle = glyphTriangle2;
            }
            outputLineHubs.AddRange (dictionary.Values);
        }

        private void CreateBoneJoints () {
            int count = _lineHubs.Count;
            for (int i = 0; i < count; i++) {
                _lineHubs[i].CreateBoneJoints ();
            }
            for (int j = 0; j < count; j++) {
                LinkEachLineHubTogether (_lineHubs[j], _lineHubs);
            }
        }

        private void CreateBones () {
            List<GlyphBone> newlyCreatedBones = new List<GlyphBone> ();
            int count = _lineHubs.Count;
            for (int i = 0; i < count; i++) {
                _lineHubs[i].CreateBones (newlyCreatedBones);
            }
            for (int j = 0; j < count; j++) {
                _lineHubs[j].CreateBoneLinkBetweenCentroidLine (newlyCreatedBones);
            }
        }

        private void CreateGlyphEdges () {
            _bounds_minX = (_bounds_minY = float.MaxValue);
            _bounds_maxX = (_bounds_maxY = float.MinValue);
            List<GlyphContour> contours = _contours;
            int count = contours.Count;
            for (int i = 0; i < count; i++) {
                GlyphContour glyphContour = contours[i];
                glyphContour.CreateGlyphEdges ();
                glyphContour.FindBounds (ref _bounds_minX, ref _bounds_minY, ref _bounds_maxX, ref _bounds_maxY);
            }
        }

        private static void LinkEachLineHubTogether (CentroidLineHub analyzingHub, List<CentroidLineHub> hubs) {
            int count = hubs.Count;
            int num = 0;
            CentroidLineHub centroidLineHub;
            CentroidLine foundOnBranch;
            GlyphBoneJoint foundOnJoint;
            while (true) {
                if (num < count) {
                    centroidLineHub = hubs[num];
                    if (centroidLineHub != analyzingHub && centroidLineHub.FindBoneJoint (analyzingHub.StartTriangle, out foundOnBranch, out foundOnJoint)) {
                        break;
                    }
                    num++;
                    continue;
                }
                return;
            }
            centroidLineHub.AddLineHubConnection (analyzingHub);
            analyzingHub.SetHeadConnnection (foundOnBranch, foundOnJoint);
        }

        private static int FindLatestConnectedTri (List<GlyphTriangle> usedTriList, GlyphTriangle tri) {
            for (int num = usedTriList.Count - 1; num >= 0; num--) {
                if (usedTriList[num].IsConnectedTo (tri)) {
                    return num;
                }
            }
            return -1;
        }

        public List<CentroidLineHub> GetCentroidLineHubs () {
            return _lineHubs;
        }

        public List<GlyphContour> GetContours () {
            return _contours;
        }
    }
}