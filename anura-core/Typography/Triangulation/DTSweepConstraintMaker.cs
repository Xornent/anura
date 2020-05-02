namespace Anura.Typography.Triangulation {
    public static class DTSweepConstraintMaker {
        public static void BuildConstraint (TriangulationPoint p1, TriangulationPoint p2) {
            TriangulationPoint p3 = p1;
            TriangulationPoint triangulationPoint = p2;
            if (p1.Y > p2.Y) {
                triangulationPoint = p1;
                p3 = p2;
            } else if (p1.Y == p2.Y) {
                if (p1.X > p2.X) {
                    triangulationPoint = p1;
                    p3 = p2;
                } else {
                    double x = p1.X;
                    double x2 = p2.X;
                }
            }
            triangulationPoint.AddEdge (new DTSweepConstraint (p3, triangulationPoint));
        }
    }
}