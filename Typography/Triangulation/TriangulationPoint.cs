using System.Collections.Generic;

namespace Anura.Typography.Triangulation {
    public sealed class TriangulationPoint {
        public readonly double X;

        public readonly double Y;

        internal byte tempName;

        public object userData;

        private List<DTSweepConstraint> _myEdges = new List<DTSweepConstraint> (3);

        public float Xf => (float) X;

        public float Yf => (float) Y;

        public TriangulationPoint (double x, double y) {
            X = x;
            Y = y;
        }

        public override string ToString () {
            return "[" + X + "," + Y + "]";
        }

        public void AddEdge (DTSweepConstraint e) {
            _myEdges.Add (e);
        }

        internal List<DTSweepConstraint> GetInternalEdgeList () {
            return _myEdges;
        }
    }
}