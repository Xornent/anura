using System;

namespace Anura.Typography.Triangulation {
    public class PointOnEdgeException : Exception {
        public readonly TriangulationPoint A;

        public readonly TriangulationPoint B;

        public readonly TriangulationPoint C;

        public PointOnEdgeException (string message, TriangulationPoint a, TriangulationPoint b, TriangulationPoint c) : base (message) {
            A = a;
            B = b;
            C = c;
        }
    }
}