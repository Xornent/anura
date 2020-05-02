namespace Anura.Typography.Msdf {
    public class CubicSegment : EdgeSegment {
        private Vector2[] p;

        public CubicSegment (Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, EdgeColor edgeColor = EdgeColor.WHITE) : base (edgeColor) {
            p = new Vector2[4];
            p[0] = p0;
            p[1] = p1;
            p[2] = p2;
            p[3] = p3;
        }

        public override void findBounds (ref double left, ref double bottom, ref double right, ref double top) {
            Vector2.pointBounds (p[0], ref left, ref bottom, ref right, ref top);
            Vector2.pointBounds (p[3], ref left, ref bottom, ref right, ref top);
            Vector2 vector = p[1] - p[0];
            Vector2 vector2 = 2.0 * (p[2] - p[1] - vector);
            Vector2 vector3 = p[3] - 3.0 * p[2] + 3.0 * p[1] - p[0];
            double[] array = new double[2];
            int num = EquationSolver.SolveQuadratic (array, vector3.x, vector2.x, vector.x);
            for (int i = 0; i < num; i++) {
                if (array[i] > 0.0 && array[i] < 1.0) {
                    Vector2.pointBounds (point (array[i]), ref left, ref bottom, ref right, ref top);
                }
            }
            num = EquationSolver.SolveQuadratic (array, vector3.y, vector2.y, vector.y);
            for (int j = 0; j < num; j++) {
                if (array[j] > 0.0 && array[j] < 1.0) {
                    Vector2.pointBounds (point (array[j]), ref left, ref bottom, ref right, ref top);
                }
            }
        }

        public override void splitInThirds (out EdgeSegment part1, out EdgeSegment part2, out EdgeSegment part3) {
            part1 = new CubicSegment (p[0], Vector2.IsEq (p[0], p[1]) ? p[0] : EdgeSegment.mix (p[0], p[1], 0.33333333333333331), EdgeSegment.mix (EdgeSegment.mix (p[0], p[1], 0.33333333333333331), EdgeSegment.mix (p[1], p[2], 0.33333333333333331), 0.33333333333333331), point (0.33333333333333331), color);
            part2 = new CubicSegment (point (0.33333333333333331), EdgeSegment.mix (EdgeSegment.mix (EdgeSegment.mix (p[0], p[1], 0.33333333333333331), EdgeSegment.mix (p[1], p[2], 0.33333333333333331), 0.33333333333333331), EdgeSegment.mix (EdgeSegment.mix (p[1], p[2], 0.33333333333333331), EdgeSegment.mix (p[2], p[3], 0.33333333333333331), 0.33333333333333331), 2.0 / 3.0), EdgeSegment.mix (EdgeSegment.mix (EdgeSegment.mix (p[0], p[1], 2.0 / 3.0), EdgeSegment.mix (p[1], p[2], 2.0 / 3.0), 2.0 / 3.0), EdgeSegment.mix (EdgeSegment.mix (p[1], p[2], 2.0 / 3.0), EdgeSegment.mix (p[2], p[3], 2.0 / 3.0), 2.0 / 3.0), 0.33333333333333331), point (2.0 / 3.0), color);
            part3 = new CubicSegment (point (2.0 / 3.0), EdgeSegment.mix (EdgeSegment.mix (p[1], p[2], 2.0 / 3.0), EdgeSegment.mix (p[2], p[3], 2.0 / 3.0), 2.0 / 3.0), Vector2.IsEq (p[2], p[3]) ? p[3] : EdgeSegment.mix (p[2], p[3], 2.0 / 3.0), p[3], color);
        }

        public override Vector2 direction (double param) {
            Vector2 result = EdgeSegment.mix (EdgeSegment.mix (p[1] - p[0], p[2] - p[1], param), EdgeSegment.mix (p[2] - p[1], p[3] - p[2], param), param);
            if (!result.IsZero ()) {
                if (param == 0.0) {
                    return p[2] - p[0];
                }
                if (param == 1.0) {
                    return p[3] - p[1];
                }
            }
            return result;
        }

        public override Vector2 point (double param) {
            Vector2 vector = EdgeSegment.mix (p[1], p[2], param);
            return EdgeSegment.mix (EdgeSegment.mix (EdgeSegment.mix (p[0], p[1], param), vector, param), EdgeSegment.mix (vector, EdgeSegment.mix (p[2], p[3], param), param), param);
        }

        public override SignedDistance signedDistance (Vector2 origin, out double param) {
            Vector2 vector = p[0] - origin;
            Vector2 vector2 = p[1] - p[0];
            Vector2 vector3 = p[2] - p[1] - vector2;
            Vector2 a = p[3] - p[2] - (p[2] - p[1]) - vector3;
            Vector2 vector4 = direction (0.0);
            double num = (double) EdgeSegment.nonZeroSign (Vector2.crossProduct (vector4, vector)) * vector.Length ();
            param = (0.0 - Vector2.dotProduct (vector, vector4)) / Vector2.dotProduct (vector4, vector4);
            vector4 = direction (1.0);
            double num2 = (double) EdgeSegment.nonZeroSign (Vector2.crossProduct (vector4, p[3] - origin)) * (p[3] - origin).Length ();
            if (EquationSolver.fabs (num2) < EquationSolver.fabs (num)) {
                num = num2;
                param = Vector2.dotProduct (origin + vector4 - p[3], vector4) / Vector2.dotProduct (vector4, vector4);
            }
            for (int i = 0; i <= 4; i++) {
                double num3 = (double) i / 4.0;
                int num4 = 0;
                while (true) {
                    Vector2 vector5 = point (num3) - origin;
                    double num5 = (double) EdgeSegment.nonZeroSign (Vector2.crossProduct (direction (num3), vector5)) * vector5.Length ();
                    if (EquationSolver.fabs (num5) < EquationSolver.fabs (num)) {
                        num = num5;
                        param = num3;
                    }
                    if (num4 == 4) {
                        break;
                    }
                    Vector2 vector6 = 3.0 * a * num3 * num3 + 6.0 * vector3 * num3 + 3.0 * vector2;
                    Vector2 b = 6.0 * a * num3 + 6.0 * vector3;
                    num3 -= Vector2.dotProduct (vector5, vector6) / (Vector2.dotProduct (vector6, vector6) + Vector2.dotProduct (vector5, b));
                    if (num3 < 0.0 || num3 > 1.0) {
                        break;
                    }
                    num4++;
                }
            }
            if (param >= 0.0 && param <= 1.0) {
                return new SignedDistance (num, 0.0);
            }
            if (param < 0.5) {
                return new SignedDistance (num, EquationSolver.fabs (Vector2.dotProduct (direction (0.0), vector.normalize ())));
            }
            return new SignedDistance (num, EquationSolver.fabs (Vector2.dotProduct (direction (1.0).normalize (), (p[3] - origin).normalize ())));
        }
    }
}