using System;

namespace Anura.Typography.Msdf {
    public struct Vector2 {
        public readonly double x;

        public readonly double y;

        public Vector2 (double x, double y) {
            this.x = x;
            this.y = y;
        }

        public static bool IsEq (Vector2 a, Vector2 b) {
            if (a.x == b.x) {
                return a.y == b.y;
            }
            return false;
        }

        public bool IsZero () {
            if (x == 0.0) {
                return y == 0.0;
            }
            return false;
        }

        public Vector2 getOrthoNormal (bool polarity = true, bool allowZero = false) {
            double num = Length ();
            if (num == 0.0) {
                if (!polarity) {
                    return new Vector2 (0.0, -((!allowZero) ? 1 : 0));
                }
                return new Vector2 (0.0, (!allowZero) ? 1 : 0);
            }
            if (!polarity) {
                return new Vector2 (y / num, (0.0 - x) / num);
            }
            return new Vector2 ((0.0 - y) / num, x / num);
        }

        public Vector2 getOrthogonal (bool polarity = true) {
            if (!polarity) {
                return new Vector2 (y, 0.0 - x);
            }
            return new Vector2 (0.0 - y, x);
        }

        public static double dotProduct (Vector2 a, Vector2 b) {
            return a.x * b.x + a.y * b.y;
        }

        public static double crossProduct (Vector2 a, Vector2 b) {
            return a.x * b.y - a.y * b.x;
        }

        public static Vector2 operator - (Vector2 a, Vector2 b) {
            return new Vector2 (a.x - b.x, a.y - b.y);
        }

        public static Vector2 operator + (Vector2 a, Vector2 b) {
            return new Vector2 (a.x + b.x, a.y + b.y);
        }

        public static Vector2 operator * (Vector2 a, Vector2 b) {
            return new Vector2 (a.x * b.x, a.y * b.y);
        }

        public static Vector2 operator / (Vector2 a, Vector2 b) {
            return new Vector2 (a.x / b.x, a.y / b.y);
        }

        public static Vector2 operator * (Vector2 a, double n) {
            return new Vector2 (a.x * n, a.y * n);
        }

        public static Vector2 operator / (Vector2 a, double n) {
            return new Vector2 (a.x / n, a.y / n);
        }

        public static Vector2 operator * (double n, Vector2 a) {
            return new Vector2 (a.x * n, a.y * n);
        }

        public static Vector2 operator / (double n, Vector2 a) {
            return new Vector2 (a.x / n, a.y / n);
        }

        public Vector2 normalize (bool allowZero = false) {
            double num = Length ();
            if (num == 0.0) {
                return new Vector2 (0.0, (!allowZero) ? 1 : 0);
            }
            return new Vector2 (x / num, y / num);
        }

        public double Length () {
            return Math.Sqrt (x * x + y * y);
        }

        public static int Clamp (int n, int b) {
            if (n > 0) {
                if (n > b) {
                    return b;
                }
                return n;
            }
            return 0;
        }

        public static int sign (double n) {
            if (n != 0.0) {
                if (!(n > 0.0)) {
                    return -1;
                }
                return 1;
            }
            return 0;
        }

        public static double shoelace (Vector2 a, Vector2 b) {
            return (b.x - a.x) * (a.y + b.y);
        }

        public override string ToString () {
            return x + "," + y;
        }

        public static void pointBounds (Vector2 p, ref double l, ref double b, ref double r, ref double t) {
            if (p.x < l) {
                l = p.x;
            }
            if (p.y < b) {
                b = p.y;
            }
            if (p.x > r) {
                r = p.x;
            }
            if (p.y > t) {
                t = p.y;
            }
        }
    }
}