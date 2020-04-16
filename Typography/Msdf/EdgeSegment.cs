using System;

namespace Anura.Typography.Msdf {
    public abstract class EdgeSegment {
        public const int MSDFGEN_CUBIC_SEARCH_STARTS = 4;

        public const int MSDFGEN_CUBIC_SEARCH_STEPS = 4;

        public EdgeColor color;

        public EdgeSegment (EdgeColor edgeColor) {
            color = edgeColor;
        }

        public abstract void findBounds (ref double left, ref double bottom, ref double right, ref double top);

        public void distanceToPseudoDistance (ref SignedDistance distance, Vector2 origin, double param) {
            if (param < 0.0) {
                Vector2 b = direction (0.0).normalize ();
                Vector2 a = origin - point (0.0);
                if (Vector2.dotProduct (a, b) < 0.0) {
                    double num = Vector2.crossProduct (a, b);
                    if (Math.Abs (num) <= Math.Abs (distance.distance)) {
                        distance = new SignedDistance (num, 0.0);
                    }
                }
            } else {
                if (!(param > 1.0)) {
                    return;
                }
                Vector2 b2 = direction (1.0).normalize ();
                Vector2 a2 = origin - point (1.0);
                if (Vector2.dotProduct (a2, b2) > 0.0) {
                    double num2 = Vector2.crossProduct (a2, b2);
                    if (Math.Abs (num2) <= Math.Abs (distance.distance)) {
                        distance = new SignedDistance (num2, 0.0);
                    }
                }
            }
        }

        public abstract Vector2 direction (double param);

        public abstract Vector2 point (double param);

        public abstract SignedDistance signedDistance (Vector2 origin, out double param);

        public abstract void splitInThirds (out EdgeSegment part1, out EdgeSegment part2, out EdgeSegment part3);

        protected static int nonZeroSign (double n) {
            return 2 * ((n > 0.0) ? 1 : 0) - 1;
        }

        protected static Vector2 mix (Vector2 a, Vector2 b, double weight) {
            return new Vector2 ((1.0 - weight) * a.x + weight * b.x, (1.0 - weight) * a.y + weight * b.y);
        }
    }
}