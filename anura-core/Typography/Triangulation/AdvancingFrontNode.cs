namespace Anura.Typography.Triangulation {
    internal class AdvancingFrontNode {
        public readonly TriangulationPoint Point;

        public readonly double XValue;

        public AdvancingFrontNode Next;

        public AdvancingFrontNode Prev;

        public DelaunayTriangle Triangle;

        public bool HasNext => Next != null;

        public bool HasPrev => Prev != null;

        public AdvancingFrontNode (TriangulationPoint point) {
            Point = point;
            XValue = point.X;
        }
    }
}