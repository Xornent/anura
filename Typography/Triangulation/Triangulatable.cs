using System.Collections.Generic;

namespace Anura.Typography.Triangulation {
    public interface Triangulatable {
        IList<TriangulationPoint> Points {
            get;
        }

        IList<DelaunayTriangle> Triangles {
            get;
        }

        TriangulationMode TriangulationMode {
            get;
        }

        void Prepare (TriangulationContext tcx);

        void AddTriangle (DelaunayTriangle t);

        void AddTriangles (IEnumerable<DelaunayTriangle> list);

        void ClearTriangles ();
    }
}