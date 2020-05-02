using System.Collections.Generic;

namespace Anura.Typography.Triangulation {
    public abstract class TriangulationContext {
        public readonly List<DelaunayTriangle> Triangles = new List<DelaunayTriangle> ();

        public readonly List<TriangulationPoint> Points = new List<TriangulationPoint> (200);

        public TriangulationMode TriangulationMode {
            get;
            protected set;
        }

        public Triangulatable Triangulatable {
            get;
            private set;
        }

        public abstract TriangulationAlgorithm Algorithm {
            get;
        }

        public bool IsDebugEnabled {
            get;
            private set;
        }

        public TriangulationDebugContext DebugContext {
            get;
            protected set;
        }

        internal TriangulationContext () { }

        public virtual void PrepareTriangulation (Triangulatable t) {
            Triangulatable = t;
            TriangulationMode = t.TriangulationMode;
            t.Prepare (this);
        }

        public abstract void MakeNewConstraint (TriangulationPoint a, TriangulationPoint b);

        public void Update (string message) { }

        public virtual void Clear () {
            Points.Clear ();
            Triangles.Clear ();
            if (DebugContext != null) {
                DebugContext.Clear ();
            }
        }

        protected void SetDebugMode (bool enable) {
            IsDebugEnabled = enable;
        }
    }
}