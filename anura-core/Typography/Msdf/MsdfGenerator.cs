using System;
using System.Collections.Generic;

namespace Anura.Typography.Msdf {
    public static class MsdfGenerator {
        private struct EdgePoint {
            public SignedDistance minDistance;

            public EdgeHolder nearEdge;

            public double nearParam;
        }

        private static float median (float a, float b, float c) {
            return Math.Max (Math.Min (a, b), Math.Min (Math.Max (a, b), c));
        }

        private static double median (double a, double b, double c) {
            return Math.Max (Math.Min (a, b), Math.Min (Math.Max (a, b), c));
        }

        private static bool pixelClash (FloatRGB a, FloatRGB b, double threshold) {
            bool num = ((a.r > 0.5f) ? 1 : 0) + ((a.g > 0.5f) ? 1 : 0) + ((a.b > 0.5f) ? 1 : 0) >= 2;
            bool flag = ((b.r > 0.5f) ? 1 : 0) + ((b.g > 0.5f) ? 1 : 0) + ((b.b > 0.5f) ? 1 : 0) >= 2;
            if (num != flag) {
                return false;
            }
            if ((a.r > 0.5f && a.g > 0.5f && a.b > 0.5f) || (a.r < 0.5f && a.g < 0.5f && a.b < 0.5f) || (b.r > 0.5f && b.g > 0.5f && b.b > 0.5f) || (b.r < 0.5f && b.g < 0.5f && b.b < 0.5f)) {
                return false;
            }
            float num2;
            float num3;
            float num4;
            float num5;
            float num6;
            float num7;
            if (a.r > 0.5f != b.r > 0.5f && a.r < 0.5f != b.r < 0.5f) {
                num2 = a.r;
                num3 = b.r;
                if (a.g > 0.5f != b.g > 0.5f && a.g < 0.5f != b.g < 0.5f) {
                    num4 = a.g;
                    num5 = b.g;
                    num6 = a.b;
                    num7 = b.b;
                } else {
                    if (a.b > 0.5f == b.b > 0.5f || a.b < 0.5f == b.b < 0.5f) {
                        return false;
                    }
                    num4 = a.b;
                    num5 = b.b;
                    num6 = a.g;
                    num7 = b.g;
                }
            } else {
                if (a.g > 0.5f == b.g > 0.5f || a.g < 0.5f == b.g < 0.5f || a.b > 0.5f == b.b > 0.5f || a.b < 0.5f == b.b < 0.5f) {
                    return false;
                }
                num2 = a.g;
                num3 = b.g;
                num4 = a.b;
                num5 = b.b;
                num6 = a.r;
                num7 = b.r;
            }
            if ((double) Math.Abs (num2 - num3) >= threshold && (double) Math.Abs (num4 - num5) >= threshold) {
                return Math.Abs (num6 - 0.5f) >= Math.Abs (num7 - 0.5f);
            }
            return false;
        }

        private static void msdfErrorCorrection (FloatRGBBmp output, Vector2 threshold) {
            List<Pair<int, int>> list = new List<Pair<int, int>> ();
            int width = output.Width;
            int height = output.Height;
            for (int i = 0; i < height; i++) {
                for (int j = 0; j < width; j++) {
                    if ((j > 0 && pixelClash (output.GetPixel (j, i), output.GetPixel (j - 1, i), threshold.x)) || (j < width - 1 && pixelClash (output.GetPixel (j, i), output.GetPixel (j + 1, i), threshold.x)) || (i > 0 && pixelClash (output.GetPixel (j, i), output.GetPixel (j, i - 1), threshold.y)) || (i < height - 1 && pixelClash (output.GetPixel (j, i), output.GetPixel (j, i + 1), threshold.y))) {
                        list.Add (new Pair<int, int> (j, i));
                    }
                }
            }
            int count = list.Count;
            for (int k = 0; k < count; k++) {
                Pair<int, int> pair = list[k];
                FloatRGB pixel = output.GetPixel (pair.first, pair.second);
                pixel.b = (pixel.g = (pixel.r = median (pixel.r, pixel.g, pixel.b)));
            }
        }

        public static int[] ConvertToIntBmp (FloatRGBBmp input) {
            int height = input.Height;
            int width = input.Width;
            int[] array = new int[input.Width * input.Height];
            for (int num = height - 1; num >= 0; num--) {
                for (int i = 0; i < width; i++) {
                    FloatRGB pixel = input.GetPixel (i, num);
                    int num2 = array[num * width + i] = (-16777216 | (Vector2.Clamp ((int) (pixel.r * 256f), 255) << 16) | (Vector2.Clamp ((int) (pixel.g * 256f), 255) << 8) | Vector2.Clamp ((int) (pixel.b * 256f), 255));
                }
            }
            return array;
        }

        public static void generateMSDF (FloatRGBBmp output, Shape shape, double range, Vector2 scale, Vector2 translate, double edgeThreshold) {
            List<Contour> contours = shape.contours;
            int count = contours.Count;
            int width = output.Width;
            int height = output.Height;
            List<int> list = new List<int> (count);
            for (int i = 0; i < count; i++) {
                list.Add (contours[i].winding ());
            }
            MultiDistance[] array = new MultiDistance[count];
            for (int j = 0; j < height; j++) {
                int y = shape.InverseYAxis ? (height - j - 1) : j;
                for (int k = 0; k < width; k++) {
                    Vector2 origin = new Vector2 ((double) k + 0.5, (double) j + 0.5) / scale - translate;
                    EdgePoint edgePoint = default (EdgePoint);
                    edgePoint.minDistance = SignedDistance.INFINITE;
                    EdgePoint edgePoint2 = edgePoint;
                    edgePoint = default (EdgePoint);
                    edgePoint.minDistance = SignedDistance.INFINITE;
                    EdgePoint edgePoint3 = edgePoint;
                    edgePoint = default (EdgePoint);
                    edgePoint.minDistance = SignedDistance.INFINITE;
                    EdgePoint edgePoint4 = edgePoint;
                    double num = Math.Abs (SignedDistance.INFINITE.distance);
                    double num2 = 0.0 - Math.Abs (SignedDistance.INFINITE.distance);
                    double num3 = Math.Abs (SignedDistance.INFINITE.distance);
                    int num4 = 0;
                    for (int l = 0; l < count; l++) {
                        List<EdgeHolder> edges = contours[l].edges;
                        int count2 = edges.Count;
                        edgePoint = default (EdgePoint);
                        edgePoint.minDistance = SignedDistance.INFINITE;
                        EdgePoint edgePoint5 = edgePoint;
                        edgePoint = default (EdgePoint);
                        edgePoint.minDistance = SignedDistance.INFINITE;
                        EdgePoint edgePoint6 = edgePoint;
                        edgePoint = default (EdgePoint);
                        edgePoint.minDistance = SignedDistance.INFINITE;
                        EdgePoint edgePoint7 = edgePoint;
                        for (int m = 0; m < count2; m++) {
                            EdgeHolder edgeHolder = edges[m];
                            double param;
                            SignedDistance signedDistance = edgeHolder.edgeSegment.signedDistance (origin, out param);
                            if (edgeHolder.HasComponent (EdgeColor.RED) && signedDistance < edgePoint5.minDistance) {
                                edgePoint5.minDistance = signedDistance;
                                edgePoint5.nearEdge = edgeHolder;
                                edgePoint5.nearParam = param;
                            }
                            if (edgeHolder.HasComponent (EdgeColor.GREEN) && signedDistance < edgePoint6.minDistance) {
                                edgePoint6.minDistance = signedDistance;
                                edgePoint6.nearEdge = edgeHolder;
                                edgePoint6.nearParam = param;
                            }
                            if (edgeHolder.HasComponent (EdgeColor.BLUE) && signedDistance < edgePoint7.minDistance) {
                                edgePoint7.minDistance = signedDistance;
                                edgePoint7.nearEdge = edgeHolder;
                                edgePoint7.nearParam = param;
                            }
                        }
                        if (edgePoint5.minDistance < edgePoint2.minDistance) {
                            edgePoint2 = edgePoint5;
                        }
                        if (edgePoint6.minDistance < edgePoint3.minDistance) {
                            edgePoint3 = edgePoint6;
                        }
                        if (edgePoint7.minDistance < edgePoint4.minDistance) {
                            edgePoint4 = edgePoint7;
                        }
                        double num5 = Math.Abs (median (edgePoint5.minDistance.distance, edgePoint6.minDistance.distance, edgePoint7.minDistance.distance));
                        if (num5 < num) {
                            num = num5;
                            num4 = -list[l];
                        }
                        if (edgePoint5.nearEdge != null) {
                            edgePoint5.nearEdge.edgeSegment.distanceToPseudoDistance (ref edgePoint5.minDistance, origin, edgePoint5.nearParam);
                        }
                        if (edgePoint6.nearEdge != null) {
                            edgePoint6.nearEdge.edgeSegment.distanceToPseudoDistance (ref edgePoint6.minDistance, origin, edgePoint6.nearParam);
                        }
                        if (edgePoint7.nearEdge != null) {
                            edgePoint7.nearEdge.edgeSegment.distanceToPseudoDistance (ref edgePoint7.minDistance, origin, edgePoint7.nearParam);
                        }
                        num5 = median (edgePoint5.minDistance.distance, edgePoint6.minDistance.distance, edgePoint7.minDistance.distance);
                        array[l].r = edgePoint5.minDistance.distance;
                        array[l].g = edgePoint6.minDistance.distance;
                        array[l].b = edgePoint7.minDistance.distance;
                        array[l].med = num5;
                        if (list[l] > 0 && num5 >= 0.0 && Math.Abs (num5) < Math.Abs (num3)) {
                            num3 = num5;
                        }
                        if (list[l] < 0 && num5 <= 0.0 && Math.Abs (num5) < Math.Abs (num2)) {
                            num2 = num5;
                        }
                    }
                    if (edgePoint2.nearEdge != null) {
                        edgePoint2.nearEdge.edgeSegment.distanceToPseudoDistance (ref edgePoint2.minDistance, origin, edgePoint2.nearParam);
                    }
                    if (edgePoint3.nearEdge != null) {
                        edgePoint3.nearEdge.edgeSegment.distanceToPseudoDistance (ref edgePoint3.minDistance, origin, edgePoint3.nearParam);
                    }
                    if (edgePoint4.nearEdge != null) {
                        edgePoint4.nearEdge.edgeSegment.distanceToPseudoDistance (ref edgePoint4.minDistance, origin, edgePoint4.nearParam);
                    }
                    MultiDistance multiDistance = default (MultiDistance);
                    multiDistance.r = (multiDistance.g = (multiDistance.b = (multiDistance.med = SignedDistance.INFINITE.distance)));
                    if (num3 >= 0.0 && Math.Abs (num3) <= Math.Abs (num2)) {
                        multiDistance.med = SignedDistance.INFINITE.distance;
                        num4 = 1;
                        for (int n = 0; n < count; n++) {
                            if (list[n] > 0 && array[n].med > multiDistance.med && Math.Abs (array[n].med) < Math.Abs (num2)) {
                                multiDistance = array[n];
                            }
                        }
                    } else if (num2 <= 0.0 && Math.Abs (num2) <= Math.Abs (num3)) {
                        multiDistance.med = 0.0 - SignedDistance.INFINITE.distance;
                        num4 = -1;
                        for (int num6 = 0; num6 < count; num6++) {
                            if (list[num6] < 0 && array[num6].med < multiDistance.med && Math.Abs (array[num6].med) < Math.Abs (num3)) {
                                multiDistance = array[num6];
                            }
                        }
                    }
                    for (int num7 = 0; num7 < count; num7++) {
                        if (list[num7] != num4 && Math.Abs (array[num7].med) < Math.Abs (multiDistance.med)) {
                            multiDistance = array[num7];
                        }
                    }
                    if (median (edgePoint2.minDistance.distance, edgePoint3.minDistance.distance, edgePoint4.minDistance.distance) == multiDistance.med) {
                        multiDistance.r = edgePoint2.minDistance.distance;
                        multiDistance.g = edgePoint3.minDistance.distance;
                        multiDistance.b = edgePoint4.minDistance.distance;
                    }
                    output.SetPixel (k, y, new FloatRGB ((float) (multiDistance.r / range + 0.5), (float) (multiDistance.g / range + 0.5), (float) (multiDistance.b / range + 0.5)));
                }
            }
            if (edgeThreshold > 0.0) {
                msdfErrorCorrection (output, edgeThreshold / (scale * range));
            }
        }

        public static void generateMSDF_legacy (FloatRGBBmp output, Shape shape, double range, Vector2 scale, Vector2 translate, double edgeThreshold) {
            int width = output.Width;
            int height = output.Height;
            for (int i = 0; i < height; i++) {
                int y = shape.InverseYAxis ? (height - i - 1) : i;
                for (int j = 0; j < width; j++) {
                    Vector2 origin = new Vector2 ((double) j + 0.5, (double) i + 0.5) / scale - translate;
                    EdgePoint edgePoint = default (EdgePoint);
                    edgePoint.minDistance = SignedDistance.INFINITE;
                    EdgePoint edgePoint2 = edgePoint;
                    edgePoint = default (EdgePoint);
                    edgePoint.minDistance = SignedDistance.INFINITE;
                    EdgePoint edgePoint3 = edgePoint;
                    edgePoint = default (EdgePoint);
                    edgePoint.minDistance = SignedDistance.INFINITE;
                    EdgePoint edgePoint4 = edgePoint;
                    List<Contour> contours = shape.contours;
                    int count = contours.Count;
                    for (int k = 0; k < count; k++) {
                        List<EdgeHolder> edges = contours[k].edges;
                        int count2 = edges.Count;
                        for (int l = 0; l < count2; l++) {
                            EdgeHolder edgeHolder = edges[l];
                            double param;
                            SignedDistance signedDistance = edgeHolder.edgeSegment.signedDistance (origin, out param);
                            if (edgeHolder.HasComponent (EdgeColor.RED) && signedDistance < edgePoint2.minDistance) {
                                edgePoint2.minDistance = signedDistance;
                                edgePoint2.nearEdge = edgeHolder;
                                edgePoint2.nearParam = param;
                            }
                            if (edgeHolder.HasComponent (EdgeColor.GREEN) && signedDistance < edgePoint3.minDistance) {
                                edgePoint3.minDistance = signedDistance;
                                edgePoint3.nearEdge = edgeHolder;
                                edgePoint3.nearParam = param;
                            }
                            if (edgeHolder.HasComponent (EdgeColor.BLUE) && signedDistance < edgePoint4.minDistance) {
                                edgePoint4.minDistance = signedDistance;
                                edgePoint4.nearEdge = edgeHolder;
                                edgePoint4.nearParam = param;
                            }
                        }
                        if (edgePoint2.nearEdge != null) {
                            edgePoint2.nearEdge.edgeSegment.distanceToPseudoDistance (ref edgePoint2.minDistance, origin, edgePoint2.nearParam);
                        }
                        if (edgePoint3.nearEdge != null) {
                            edgePoint3.nearEdge.edgeSegment.distanceToPseudoDistance (ref edgePoint3.minDistance, origin, edgePoint3.nearParam);
                        }
                        if (edgePoint4.nearEdge != null) {
                            edgePoint4.nearEdge.edgeSegment.distanceToPseudoDistance (ref edgePoint4.minDistance, origin, edgePoint4.nearParam);
                        }
                        output.SetPixel (j, y, new FloatRGB ((float) (edgePoint2.minDistance.distance / range + 0.5), (float) (edgePoint3.minDistance.distance / range + 0.5), (float) (edgePoint4.minDistance.distance / range + 0.5)));
                    }
                }
            }
            if (edgeThreshold > 0.0) {
                msdfErrorCorrection (output, edgeThreshold / (scale * range));
            }
        }
    }
}