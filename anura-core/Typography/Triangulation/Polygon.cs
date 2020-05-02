using System;
using System.Collections.Generic;

namespace Anura.Typography.Triangulation {
    public sealed class Polygon : Triangulatable {
        private TriangulationPoint[] _points;

        private Polygon[] _holes;

        private List<DelaunayTriangle> _triangles;

        public TriangulationMode TriangulationMode => TriangulationMode.Polygon;

        public IList<TriangulationPoint> Points => _points;

        public IList<DelaunayTriangle> Triangles => _triangles;

        public IList<Polygon> Holes => _holes;

        public Polygon (TriangulationPoint[] points) {
            _points = points;
            if (points.Length < 3) {
                throw new ArgumentException ("List has fewer than 3 points", "points");
            }
            if (points[0].Equals (points[points.Length - 1])) {
                TriangulationPoint[] array = new TriangulationPoint[points.Length - 1];
                Array.Copy (_points, 0, array, 0, points.Length - 1);
                _points = array;
            }
        }

        private Polygon () { }

        public void AddHole (Polygon poly) {
            if (_holes == null) {
                _holes = new Polygon[1] {
                poly
                };
                return;
            }
            int num = _holes.Length;
            Polygon[] array = new Polygon[num + 1];
            Array.Copy (_holes, 0, array, 0, num);
            array[num] = poly;
            _holes = array;
        }

        public void AddTriangle (DelaunayTriangle t) {
            _triangles.Add (t);
        }

        public void AddTriangles (IEnumerable<DelaunayTriangle> list) {
            _triangles.AddRange (list);
        }

        public void ClearTriangles () {
            if (_triangles != null) {
                _triangles.Clear ();
            }
        }

        public void Prepare (TriangulationContext tcx) {
            if (_triangles == null) {
                _triangles = new List<DelaunayTriangle> (_points.Length);
            } else {
                _triangles.Clear ();
            }
            int num = _points.Length;
            for (int i = 0; i < num - 1; i++) {
                tcx.MakeNewConstraint (_points[i], _points[i + 1]);
            }
            tcx.MakeNewConstraint (_points[0], _points[num - 1]);
            tcx.Points.AddRange (_points);
            if (_holes == null) {
                return;
            }
            Polygon[] holes = _holes;
            foreach (Polygon polygon in holes) {
                int num2 = polygon._points.Length - 1;
                for (int k = 0; k < num2; k++) {
                    tcx.MakeNewConstraint (polygon._points[k], polygon._points[k + 1]);
                }
                tcx.MakeNewConstraint (polygon._points[0], polygon._points[num2]);
                tcx.Points.AddRange (polygon._points);
            }
        }
    }
}