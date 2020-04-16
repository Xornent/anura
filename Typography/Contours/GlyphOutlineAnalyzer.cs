using System;
using System.Collections.Generic;
using Anura.Typography.OpenFont;
using Anura.Typography.Triangulation;

namespace Anura.Typography.Contours {
    public class GlyphOutlineAnalyzer {
        private GlyphPartFlattener _glyphFlattener = new GlyphPartFlattener ();

        private GlyphContourBuilder _glyphToContour = new GlyphContourBuilder ();

        private List<Polygon> _waitingHoles = new List<Polygon> ();

        public GlyphDynamicOutline CreateDynamicOutline (GlyphPointF[] glyphPoints, ushort[] glyphContours) {
            _glyphToContour.Read (glyphPoints, glyphContours);
            List<GlyphContour> contours = _glyphToContour.GetContours ();
            int count = contours.Count;
            if (count > 0) {
                _glyphFlattener.NSteps = 2;
                for (int i = 0; i < count; i++) {
                    contours[i].Flatten (_glyphFlattener);
                }
                return CreateDynamicOutline (contours);
            }
            return GlyphDynamicOutline.CreateBlankDynamicOutline ();
        }

        private GlyphDynamicOutline CreateDynamicOutline (List<GlyphContour> flattenContours) {
            _waitingHoles.Clear ();
            int count = flattenContours.Count;
            Polygon polygon = null;
            List<Polygon> list = null;
            for (int i = 0; i < count; i++) {
                GlyphContour glyphContour = flattenContours[i];
                if (glyphContour.IsClockwise ()) {
                    if (polygon == null) {
                        polygon = CreatePolygon (glyphContour.flattenPoints);
                        if (_waitingHoles.Count > 0) {
                            int count2 = _waitingHoles.Count;
                            for (int j = 0; j < count2; j++) {
                                polygon.AddHole (_waitingHoles[j]);
                            }
                            _waitingHoles.Clear ();
                        }
                    } else {
                        Polygon item = CreatePolygon (glyphContour.flattenPoints);
                        if (list == null) {
                            list = new List<Polygon> ();
                        }
                        list.Add (item);
                    }
                } else {
                    Polygon polygon2 = CreatePolygon (glyphContour.flattenPoints);
                    if (polygon == null) {
                        _waitingHoles.Add (polygon2);
                    } else {
                        polygon.AddHole (polygon2);
                    }
                }
            }
            if (_waitingHoles.Count > 0) {
                throw new NotSupportedException ();
            }
            P2T.Triangulate (polygon);
            Polygon[] array = list?.ToArray ();
            if (array != null) {
                for (int num = array.Length - 1; num >= 0; num--) {
                    P2T.Triangulate (array[num]);
                }
            }
            return new GlyphDynamicOutline (new GlyphIntermediateOutline (flattenContours, polygon, array));
        }

        private static Polygon CreatePolygon (List<GlyphPoint> flattenPoints) {
            List<TriangulationPoint> list = new List<TriangulationPoint> ();
            double num = 0.0;
            double num2 = 0.0;
            int count = flattenPoints.Count;
            for (int i = 0; i < count; i++) {
                GlyphPoint glyphPoint = flattenPoints[i];
                double num3 = glyphPoint.OX;
                double num4 = glyphPoint.OY;
                if (num3 == num && num4 == num2) {
                    if (i > 0) {
                        throw new NotSupportedException ();
                    }
                } else {
                    TriangulationPoint item = new TriangulationPoint (num = num3, num2 = num4) {
                        userData = glyphPoint
                    };
                    list.Add (item);
                }
            }
            return new Polygon (list.ToArray ());
        }
    }
}