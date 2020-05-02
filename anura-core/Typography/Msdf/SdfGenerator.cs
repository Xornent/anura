using System;
using System.Collections.Generic;

namespace Anura.Typography.Msdf {
    public static class SdfGenerator {
        public static void GenerateSdf (FloatBmp output, Shape shape, double range, Vector2 scale, Vector2 translate) {
            List<Contour> contours = shape.contours;
            int count = contours.Count;
            int width = output.Width;
            int height = output.Height;
            List<int> list = new List<int> (count);
            for (int i = 0; i < count; i++) {
                list.Add (contours[i].winding ());
            }
            double[] array = new double[count];
            for (int j = 0; j < height; j++) {
                int y = shape.InverseYAxis ? (height - j - 1) : j;
                for (int k = 0; k < width; k++) {
                    double param = 0.0;
                    Vector2 origin = new Vector2 ((double) k + 0.5, (double) j + 0.5) / scale - translate;
                    double num = 0.0 - SignedDistance.INFINITE.distance;
                    double distance = SignedDistance.INFINITE.distance;
                    int num2 = 0;
                    for (int l = 0; l < count; l++) {
                        Contour contour = contours[l];
                        SignedDistance signedDistance = SignedDistance.INFINITE;
                        List<EdgeHolder> edges = contour.edges;
                        int count2 = edges.Count;
                        for (int m = 0; m < count2; m++) {
                            SignedDistance signedDistance2 = edges[m].edgeSegment.signedDistance (origin, out param);
                            if (signedDistance2 < signedDistance) {
                                signedDistance = signedDistance2;
                            }
                        }
                        array[l] = signedDistance.distance;
                        if (list[l] > 0 && signedDistance.distance >= 0.0 && Math.Abs (signedDistance.distance) < Math.Abs (distance)) {
                            distance = signedDistance.distance;
                        }
                        if (list[l] < 0 && signedDistance.distance <= 0.0 && Math.Abs (signedDistance.distance) < Math.Abs (num)) {
                            num = signedDistance.distance;
                        }
                    }
                    double num3 = SignedDistance.INFINITE.distance;
                    if (distance >= 0.0 && Math.Abs (distance) <= Math.Abs (num)) {
                        num3 = distance;
                        num2 = 1;
                        for (int n = 0; n < count; n++) {
                            if (list[n] > 0 && array[n] > num3 && Math.Abs (array[n]) < Math.Abs (num)) {
                                num3 = array[n];
                            }
                        }
                    } else if (num <= 0.0 && Math.Abs (num) <= Math.Abs (distance)) {
                        num3 = num;
                        num2 = -1;
                        for (int num4 = 0; num4 < count; num4++) {
                            if (list[num4] < 0 && array[num4] < num3 && Math.Abs (array[num4]) < Math.Abs (distance)) {
                                num3 = array[num4];
                            }
                        }
                    }
                    for (int num5 = 0; num5 < count; num5++) {
                        if (list[num5] != num2 && Math.Abs (array[num5]) < Math.Abs (num3)) {
                            num3 = array[num5];
                        }
                    }
                    output.SetPixel (k, y, (float) (num3 / range + 0.5));
                }
            }
        }

        public static void GenerateSdf_legacy (FloatBmp output, Shape shape, double range, Vector2 scale, Vector2 translate) {
            int width = output.Width;
            int height = output.Height;
            for (int i = 0; i < height; i++) {
                int y = shape.InverseYAxis ? (height - i - 1) : i;
                for (int j = 0; j < width; j++) {
                    double param = 0.0;
                    Vector2 origin = new Vector2 ((float) j + 0.5f, (double) i + 0.5) * scale - translate;
                    SignedDistance signedDistance = SignedDistance.INFINITE;
                    List<Contour> contours = shape.contours;
                    int count = contours.Count;
                    for (int k = 0; k < count; k++) {
                        List<EdgeHolder> edges = contours[k].edges;
                        int count2 = edges.Count;
                        for (int l = 0; l < count2; l++) {
                            SignedDistance signedDistance2 = edges[l].edgeSegment.signedDistance (origin, out param);
                            if (signedDistance2 < signedDistance) {
                                signedDistance = signedDistance2;
                            }
                        }
                    }
                    output.SetPixel (j, y, (float) (signedDistance.distance / (range + 0.5)));
                }
            }
        }
    }
}