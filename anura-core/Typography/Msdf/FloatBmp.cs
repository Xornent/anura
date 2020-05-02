namespace Anura.Typography.Msdf {
    public class FloatBmp {
        private float[] buffer;

        public int Width {
            get;
            set;
        }

        public int Height {
            get;
            set;
        }

        public FloatBmp (int w, int h) {
            Width = w;
            Height = h;
            buffer = new float[w * h];
        }

        public void SetPixel (int x, int y, float value) {
            buffer[x + y * Width] = value;
        }

        public float GetPixel (int x, int y) {
            return buffer[x + y * Width];
        }
    }
}