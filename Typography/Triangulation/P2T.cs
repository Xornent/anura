using System.Collections.Generic;

namespace Anura.Typography.Triangulation {
    public static class P2T {
        private static TriangulationAlgorithm _defaultAlgorithm = TriangulationAlgorithm.DTSweep;

        private static Stack<DTSweepContext> contextStacks = new Stack<DTSweepContext> ();

        public static void Triangulate (Polygon p) {
            Triangulate (_defaultAlgorithm, p);
        }

        public static void Triangulate (ConstrainedPointSet cps) {
            Triangulate (_defaultAlgorithm, cps);
        }

        public static void Triangulate (PointSet ps) {
            Triangulate (_defaultAlgorithm, ps);
        }

        private static TriangulationContext GetFreeTcxContext (TriangulationAlgorithm algorithm) {
            if (contextStacks.Count == 0) {
                return new DTSweepContext ();
            }
            return contextStacks.Pop ();
        }

        private static void ReleaseCtxContext (TriangulationContext sweepContext) {
            DTSweepContext dTSweepContext = sweepContext as DTSweepContext;
            if (dTSweepContext != null) {
                contextStacks.Push (dTSweepContext);
            }
        }

        public static void Triangulate (TriangulationAlgorithm algorithm, Triangulatable t) {
            TriangulationContext freeTcxContext = GetFreeTcxContext (algorithm);
            freeTcxContext.Clear ();
            freeTcxContext.PrepareTriangulation (t);
            Triangulate (freeTcxContext);
            ReleaseCtxContext (freeTcxContext);
        }

        public static void Triangulate (TriangulationContext tcx) {
            TriangulationAlgorithm algorithm = tcx.Algorithm;
            DTSweep.Triangulate ((DTSweepContext) tcx);
        }
    }
}