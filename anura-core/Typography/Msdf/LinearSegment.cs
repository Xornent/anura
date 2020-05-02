using System;

namespace Anura.Typography.Msdf {
    public class LinearSegment : EdgeSegment {
        private Vector2[] p;

        public LinearSegment (Vector2 p0, Vector2 p1, EdgeColor edgeColor = EdgeColor.WHITE) : base (edgeColor) {
            p = new Vector2[2];
            p[0] = p0;
            p[1] = p1;
        }

        public override void findBounds (ref double left, ref double bottom, ref double right, ref double top) {
            Vector2.pointBounds (p[0], ref left, ref bottom, ref right, ref top);
            Vector2.pointBounds (p[1], ref left, ref bottom, ref right, ref top);
        }

        public override void splitInThirds (out EdgeSegment part1, out EdgeSegment part2, out EdgeSegment part3) {
            part1 = new LinearSegment (p[0], point (0.33333333333333331), color);
            part2 = new LinearSegment (point (0.33333333333333331), point (2.0 / 3.0), color);
            part3 = new LinearSegment (point (2.0 / 3.0), p[1], color);
        }

        public override SignedDistance signedDistance (Vector2 origin, out double param) {
            Vector2 vector = origin - p[0];
            Vector2 vector2 = p[1] - p[0];
            param = Vector2.dotProduct (vector, vector2) / Vector2.dotProduct (vector2, vector2);
            Vector2 vector3 = p[(param > 0.5) ? 1 : 0] - origin;
            double num = vector3.Length ();
            if (param > 0.0 && param < 1.0) {
                double num2 = Vector2.dotProduct (vector2.getOrthoNormal (false), vector);
                if (Math.Abs (num2) < num) {
                    return new SignedDistance (num2, 0.0);
                }
            }
            return new SignedDistance ((double) EdgeSegment.nonZeroSign (Vector2.crossProduct (vector, vector2)) * num, Math.Abs (Vector2.dotProduct (vector2.normalize (), vector3.normalize ())));
        }

        public override Vector2 direction (double param) {
            return p[1] - p[0];
        }

        public override Vector2 point (double param) {
            return EdgeSegment.mix (p[0], p[1], param);
        }
    }
}