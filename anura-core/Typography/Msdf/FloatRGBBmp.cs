namespace Anura.Typography.Msdf {
    public class FloatRGBBmp {
        private FloatRGB[] buffer;

        public int Width {
            get;
            set;
        }

        public int Height {
            get;
            set;
        }

        public FloatRGBBmp (int w, int h) {
            Width = w;
            Height = h;
            buffer = new FloatRGB[w * h];
        }

        public void SetPixel (int x, int y, FloatRGB value) {
            buffer[x + y * Width] = value;
        }

        public FloatRGB GetPixel (int x, int y) {
            return buffer[x + y * Width];
        }
    }
}