using System.Collections.Generic;

namespace Anura.Typography.Triangulation {
    public class ConstrainedPointSet : PointSet {
        public int[] EdgeIndex {
            get;
            private set;
        }

        public override TriangulationMode TriangulationMode => TriangulationMode.Constrained;

        public ConstrainedPointSet (List<TriangulationPoint> points, int[] index) : base (points) {
            EdgeIndex = index;
        }

        public override void Prepare (TriangulationContext tcx) {
            base.Prepare (tcx);
            for (int i = 0; i < EdgeIndex.Length; i += 2) {
                tcx.MakeNewConstraint (base.Points[EdgeIndex[i]], base.Points[EdgeIndex[i + 1]]);
            }
        }
    }
}