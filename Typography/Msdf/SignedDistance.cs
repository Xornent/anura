namespace Anura.Typography.Msdf {
    public struct SignedDistance {
        public readonly double distance;

        public readonly double dot;

        public static readonly SignedDistance INFINITE = new SignedDistance (-1E+240, 1.0);

        public SignedDistance (double dist, double d) {
            distance = dist;
            dot = d;
        }

        public static bool operator < (SignedDistance a, SignedDistance b) {
            if (!(fabs (a.distance) < fabs (b.distance))) {
                if (fabs (a.distance) == fabs (b.distance)) {
                    return a.dot < b.dot;
                }
                return false;
            }
            return true;
        }

        public static bool operator > (SignedDistance a, SignedDistance b) {
            if (!(fabs (a.distance) > fabs (b.distance))) {
                if (fabs (a.distance) == fabs (b.distance)) {
                    return a.dot > b.dot;
                }
                return false;
            }
            return true;
        }

        public static bool operator <= (SignedDistance a, SignedDistance b) {
            if (!(fabs (a.distance) < fabs (b.distance))) {
                if (fabs (a.distance) == fabs (b.distance)) {
                    return a.dot <= b.dot;
                }
                return false;
            }
            return true;
        }

        public static bool operator >= (SignedDistance a, SignedDistance b) {
            if (!(fabs (a.distance) > fabs (b.distance))) {
                if (fabs (a.distance) == fabs (b.distance)) {
                    return a.dot >= b.dot;
                }
                return false;
            }
            return true;
        }

        private static double fabs (double d) {
            return EquationSolver.fabs (d);
        }
    }
}