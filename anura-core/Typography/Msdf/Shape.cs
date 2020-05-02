using System.Collections.Generic;

namespace Anura.Typography.Msdf {
    public class Shape {
        public List<Contour> contours = new List<Contour> ();

        public bool InverseYAxis {
            get;
            set;
        }

        public void normalized () {
            int count = contours.Count;
            for (int i = 0; i < count; i++) {
                List<EdgeHolder> edges = contours[i].edges;
                if (edges.Count == 1) {
                    edges[0].edgeSegment.splitInThirds (out EdgeSegment part, out EdgeSegment part2, out EdgeSegment part3);
                    edges.Clear ();
                    edges.Add (new EdgeHolder (part));
                    edges.Add (new EdgeHolder (part2));
                    edges.Add (new EdgeHolder (part3));
                }
            }
        }

        public void findBounds (out double left, out double bottom, out double right, out double top) {
            left = (top = (right = (bottom = 0.0)));
            int count = contours.Count;
            for (int i = 0; i < count; i++) {
                contours[i].findBounds (ref left, ref bottom, ref right, ref top);
            }
        }
    }
}