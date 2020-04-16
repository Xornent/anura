namespace Anura.Typography.Msdf {
    public class EdgeHolder {
        public EdgeSegment edgeSegment;

        public EdgeColor color {
            get {
                return edgeSegment.color;
            }
            set {
                edgeSegment.color = value;
            }
        }

        public EdgeHolder (EdgeSegment segment) {
            edgeSegment = segment;
        }

        public bool HasComponent (EdgeColor c) {
            return (color & c) != EdgeColor.BLACK;
        }

        public Vector2 Direction (double param) {
            if (edgeSegment != null) {
                return edgeSegment.direction (param);
            }
            return default (Vector2);
        }

        public Vector2 point (double param) {
            return edgeSegment.point (param);
        }
    }
}