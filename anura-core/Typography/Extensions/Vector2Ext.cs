namespace System.Numerics {
    public static class Vector2Ext {
        public static Vector2 Rotate (this Vector2 v, int degree) {
            double num = (double) degree * Math.PI / 180.0;
            double num2 = Math.Sin (num);
            double num3 = Math.Cos (num);
            double num4 = (double) v.X * num3 - (double) v.Y * num2;
            double num5 = (double) v.X * num2 + (double) v.Y * num3;
            return new Vector2 ((float) num4, (float) num5);
        }

        public static Vector2 NewLength (this Vector2 v, double newLength) {
            double num = Math.Atan2 (v.Y, v.X);
            return new Vector2 ((float) (Math.Cos (num) * newLength), (float) (Math.Sin (num) * newLength));
        }
    }
}