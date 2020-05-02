namespace Anura.Typography.Triangulation {
    public struct DTSweepConstraint {
        public readonly TriangulationPoint P;

        public readonly TriangulationPoint Q;

        public static readonly DTSweepConstraint Empty;

        public DTSweepConstraint (TriangulationPoint p1, TriangulationPoint p2) {
            P = p1;
            Q = p2;
        }
    }
}