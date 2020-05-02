using System;

namespace Anura.Typography.Msdf {
    public class QuadraticSegment : EdgeSegment {
        private Vector2[] p;

        public QuadraticSegment (Vector2 p0, Vector2 p1, Vector2 p2, EdgeColor edgeColor = EdgeColor.WHITE) : base (edgeColor) {
            p = new Vector2[3];
            if (Vector2.IsEq (p1, p0) || Vector2.IsEq (p1, p2)) {
                p1 = 0.5 * (p0 + p2);
            }
            p[0] = p0;
            p[1] = p1;
            p[2] = p2;
        }

        public override void findBounds (ref double left, ref double bottom, ref double right, ref double top) {
            Vector2.pointBounds (p[0], ref left, ref bottom, ref right, ref top);
            Vector2.pointBounds (p[2], ref left, ref bottom, ref right, ref top);
            Vector2 vector = p[1] - p[0] - (p[2] - p[1]);
            if (vector.x != 0.0) {
                double num = (p[1].x - p[0].x) / vector.x;
                if (num > 0.0 && num < 1.0) {
                    Vector2.pointBounds (point (num), ref left, ref bottom, ref right, ref top);
                }
            }
            if (vector.y != 0.0) {
                double num2 = (p[1].y - p[0].y) / vector.y;
                if (num2 > 0.0 && num2 < 1.0) {
                    Vector2.pointBounds (point (num2), ref left, ref bottom, ref right, ref top);
                }
            }
        }

        public override void splitInThirds (out EdgeSegment part1, out EdgeSegment part2, out EdgeSegment part3) {
            part1 = new QuadraticSegment (p[0], EdgeSegment.mix (p[0], p[1], 0.33333333333333331), point (0.33333333333333331), color);
            part2 = new QuadraticSegment (point (0.33333333333333331), EdgeSegment.mix (EdgeSegment.mix (p[0], p[1], 5.0 / 9.0), EdgeSegment.mix (p[1], p[2], 4.0 / 9.0), 0.5), point (2.0 / 3.0), color);
            part3 = new QuadraticSegment (point (2.0 / 3.0), EdgeSegment.mix (p[1], p[2], 2.0 / 3.0), p[2], color);
        }

        public override Vector2 direction (double param) {
            return EdgeSegment.mix (p[1] - p[0], p[2] - p[1], param);
        }

        public override Vector2 point (double param) {
            return EdgeSegment.mix (EdgeSegment.mix (p[0], p[1], param), EdgeSegment.mix (p[1], p[2], param), param);
        }

        public override SignedDistance signedDistance (Vector2 origin, out double param) {
            Vector2 vector = p[0] - origin;
            Vector2 vector2 = p[1] - p[0];
            Vector2 vector3 = p[0] + p[2] - p[1] - p[1];
            double a = Vector2.dotProduct (vector3, vector3);
            double b = 3.0 * Vector2.dotProduct (vector2, vector3);
            double c = 2.0 * Vector2.dotProduct (vector2, vector2) + Vector2.dotProduct (vector, vector3);
            double d = Vector2.dotProduct (vector, vector2);
            double[] array = new double[3];
            int num = EquationSolver.SolveCubic (array, a, b, c, d);
            double num2 = (double) EdgeSegment.nonZeroSign (Vector2.crossProduct (vector2, vector)) * vector.Length ();
            param = (0.0 - Vector2.dotProduct (vector, vector2)) / Vector2.dotProduct (vector2, vector2);
            double num3 = (double) EdgeSegment.nonZeroSign (Vector2.crossProduct (p[2] - p[1], p[2] - origin)) * (p[2] - origin).Length ();
            if (Math.Abs (num3) < Math.Abs (num2)) {
                num2 = num3;
                param = Vector2.dotProduct (origin - p[1], p[2] - p[1]) / Vector2.dotProduct (p[2] - p[1], p[2] - p[1]);
            }
            for (int i = 0; i < num; i++) {
                if (array[i] > 0.0 && array[i] < 1.0) {
                    Vector2 a2 = p[0] + 2.0 * array[i] * vector2 + array[i] * array[i] * vector3;
                    double num4 = (double) EdgeSegment.nonZeroSign (Vector2.crossProduct (p[2] - p[0], a2 - origin)) * (a2 - origin).Length ();
                    if (Math.Abs (num4) <= Math.Abs (num2)) {
                        num2 = num4;
                        param = array[i];
                    }
                }
            }
            if (param >= 0.0 && param <= 1.0) {
                return new SignedDistance (num2, 0.0);
            }
            if (param < 0.5) {
                return new SignedDistance (num2, Math.Abs (Vector2.dotProduct (vector2.normalize (), vector.normalize ())));
            }
            return new SignedDistance (num2, Math.Abs (Vector2.dotProduct ((p[2] - p[1]).normalize (), (p[2] - origin).normalize ())));
        }
    }
}