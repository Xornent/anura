using System.Collections.Generic;

namespace Anura.Typography.Msdf {
    public class Contour {
        public List<EdgeHolder> edges = new List<EdgeHolder> ();

        public void AddEdge (EdgeSegment edge) {
            EdgeHolder item = new EdgeHolder (edge);
            edges.Add (item);
        }

        public void AddLine (double x0, double y0, double x1, double y1) {
            AddEdge (new LinearSegment (new Vector2 (x0, y0), new Vector2 (x1, y1)));
        }

        public void AddQuadraticSegment (double x0, double y0, double ctrl0X, double ctrl0Y, double x1, double y1) {
            AddEdge (new QuadraticSegment (new Vector2 (x0, y0), new Vector2 (ctrl0X, ctrl0Y), new Vector2 (x1, y1)));
        }

        public void AddCubicSegment (double x0, double y0, double ctrl0X, double ctrl0Y, double ctrl1X, double ctrl1Y, double x1, double y1) {
            AddEdge (new CubicSegment (new Vector2 (x0, y0), new Vector2 (ctrl0X, ctrl0Y), new Vector2 (ctrl1X, ctrl1Y), new Vector2 (x1, y1)));
        }

        public void findBounds (ref double left, ref double bottom, ref double right, ref double top) {
            int count = edges.Count;
            for (int i = 0; i < count; i++) {
                edges[i].edgeSegment.findBounds (ref left, ref bottom, ref right, ref top);
            }
        }

        public int winding () {
            int count = edges.Count;
            double num = 0.0;
            switch (count) {
                case 0:
                    return 0;
                case 1:
                    {
                        Vector2 vector6 = edges[0].point (0.0);
                        Vector2 vector7 = edges[0].point (0.33333333333333331);
                        Vector2 vector8 = edges[0].point (2.0 / 3.0);
                        num += Vector2.shoelace (vector6, vector7);
                        num += Vector2.shoelace (vector7, vector8);
                        num += Vector2.shoelace (vector8, vector6);
                        break;
                    }
                case 2:
                    {
                        Vector2 vector2 = edges[0].point (0.0);
                        Vector2 vector3 = edges[0].point (0.5);
                        Vector2 vector4 = edges[1].point (0.0);
                        Vector2 vector5 = edges[1].point (0.5);
                        num += Vector2.shoelace (vector2, vector3);
                        num += Vector2.shoelace (vector3, vector4);
                        num += Vector2.shoelace (vector4, vector5);
                        num += Vector2.shoelace (vector5, vector2);
                        break;
                    }
                default:
                    {
                        Vector2 a = edges[count - 1].point (0.0);
                        for (int i = 0; i < count; i++) {
                            Vector2 vector = edges[i].point (0.0);
                            num += Vector2.shoelace (a, vector);
                            a = vector;
                        }
                        break;
                    }
            }
            return Vector2.sign (num);
        }
    }
}