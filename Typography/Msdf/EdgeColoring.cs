using System;
using System.Collections.Generic;

namespace Anura.Typography.Msdf {
    public static class EdgeColoring {
        private static bool isCorner (Vector2 aDir, Vector2 bDir, double crossThreshold) {
            if (!(Vector2.dotProduct (aDir, bDir) <= 0.0)) {
                return Math.Abs (Vector2.crossProduct (aDir, bDir)) > crossThreshold;
            }
            return true;
        }

        public static void edgeColoringSimple (Shape shape, double angleThreshold) {
            double crossThreshold = Math.Sin (angleThreshold);
            List<int> list = new List<int> ();
            foreach (Contour contour in shape.contours) {
                list.Clear ();
                List<EdgeHolder> edges = contour.edges;
                int count = edges.Count;
                if (count != 0) {
                    Vector2 vector = edges[count - 1].Direction (1.0);
                    for (int i = 0; i < count; i++) {
                        EdgeHolder edgeHolder = edges[i];
                        if (isCorner (vector.normalize (), edgeHolder.Direction (0.0).normalize (), crossThreshold)) {
                            list.Add (i);
                        }
                        vector = edgeHolder.Direction (1.0);
                    }
                }
                if (list.Count == 0) {
                    for (int num = count - 1; num >= 0; num--) {
                        edges[num].color = EdgeColor.WHITE;
                    }
                } else if (list.Count == 1) {
                    EdgeColor[] array = new EdgeColor[3] {
                    EdgeColor.MAGENTA,
                    EdgeColor.WHITE,
                    EdgeColor.YELLOW
                    };
                    int num2 = list[0];
                    if (count >= 3) {
                        int num3 = count;
                        for (int j = 0; j < num3; j++) {
                            contour.edges[(num2 + j) % num3].color = array[(int) (3.0 + 2.875 * (double) j / (double) (num3 - 1) - 1.4375 + 0.5) - 3 + 1];
                        }
                    } else if (count >= 1) {
                        EdgeSegment[] array2 = new EdgeSegment[7];
                        edges[0].edgeSegment.splitInThirds (out array2[3 * num2], out array2[1 + 3 * num2], out array2[2 + 3 * num2]);
                        if (count >= 2) {
                            edges[1].edgeSegment.splitInThirds (out array2[3 - 3 * num2], out array2[4 - 3 * num2], out array2[5 - 3 * num2]);
                            array2[0].color = (array2[1].color = array[0]);
                            array2[2].color = (array2[3].color = array[1]);
                            array2[4].color = (array2[5].color = array[2]);
                        } else {
                            array2[0].color = array[0];
                            array2[1].color = array[1];
                            array2[2].color = array[2];
                        }
                        contour.edges.Clear ();
                        for (int k = 0; k < 7; k++) {
                            edges.Add (new EdgeHolder (array2[k]));
                        }
                    }
                } else {
                    int count2 = list.Count;
                    EdgeColor[] obj = new EdgeColor[4] {
                        EdgeColor.BLACK,
                        EdgeColor.CYAN,
                        EdgeColor.MAGENTA,
                        EdgeColor.YELLOW
                    };
                    obj[0] = ((count2 % 3 == 1) ? EdgeColor.YELLOW : EdgeColor.CYAN);
                    EdgeColor[] array3 = obj;
                    int num4 = 0;
                    int num5 = list[0];
                    int count3 = contour.edges.Count;
                    for (int l = 0; l < count3; l++) {
                        int num6 = (num5 + l) % count3;
                        if (count2 > num4 + 1 && list[num4 + 1] == num6) {
                            num4++;
                        }
                        int num7 = num4 % 3 - ((num4 == 0) ? 1 : 0);
                        edges[num6].color = array3[num7 + 1];
                    }
                }
            }
        }
    }
}