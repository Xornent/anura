using System;

namespace Anura.Typography.Msdf {
    public static class EquationSolver {
        public const double MIN = 1E-14;

        public static int SolveQuadratic (double[] x, double a, double b, double c) {
            if (fabs (a) < 1E-14) {
                if (fabs (b) < 1E-14) {
                    if (c == 0.0) {
                        return -1;
                    }
                    return 0;
                }
                x[0] = (0.0 - c) / b;
                return 1;
            }
            double num = b * b - 4.0 * a * c;
            if (num > 0.0) {
                num = Math.Sqrt (num);
                x[0] = (0.0 - b + num) / (2.0 * a);
                x[1] = (0.0 - b - num) / (2.0 * a);
                return 2;
            }
            if (num == 0.0) {
                x[0] = (0.0 - b) / (2.0 * a);
                return 1;
            }
            return 0;
        }

        private static int SolveCubicNormed (double[] x, double a, double b, double c) {
            double num = a * a;
            double num2 = (num - 3.0 * b) / 9.0;
            double num3 = (a * (2.0 * num - 9.0 * b) + 27.0 * c) / 54.0;
            double num4 = num3 * num3;
            double num5 = num2 * num2 * num2;
            if (num4 < num5) {
                double num6 = num3 / Math.Sqrt (num5);
                if (num6 < -1.0) {
                    num6 = -1.0;
                }
                if (num6 > 1.0) {
                    num6 = 1.0;
                }
                num6 = Math.Acos (num6);
                a /= 3.0;
                num2 = -2.0 * Math.Sqrt (num2);
                x[0] = num2 * Math.Cos (num6 / 3.0) - a;
                x[1] = num2 * Math.Cos ((num6 + Math.PI * 2.0) / 3.0) - a;
                x[2] = num2 * Math.Cos ((num6 - Math.PI * 2.0) / 3.0) - a;
                return 3;
            }
            double num7 = 0.0 - Math.Pow (fabs (num3) + Math.Sqrt (num4 - num5), 0.33333333333333331);
            if (num3 < 0.0) {
                num7 = 0.0 - num7;
            }
            double num8 = (num7 == 0.0) ? 0.0 : (num2 / num7);
            a /= 3.0;
            x[0] = num7 + num8 - a;
            x[1] = -0.5 * (num7 + num8) - a;
            x[2] = 0.5 * Math.Sqrt (3.0) * (num7 - num8);
            if (fabs (x[2]) < 1E-14) {
                return 2;
            }
            return 1;
        }

        public static int SolveCubic (double[] x, double a, double b, double c, double d) {
            if (fabs (a) < 1E-14) {
                return SolveQuadratic (x, b, c, d);
            }
            return SolveCubicNormed (x, b / a, c / a, d / a);
        }

        public static double fabs (double m) {
            return Math.Abs (m);
        }
    }
}