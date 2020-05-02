namespace Anura.Typography.Contours {
    public struct RectangleF {
        private float x;

        private float y;

        private float width;

        private float height;

        public static readonly RectangleF Empty;

        public float Bottom => Y + Height;

        public float Height {
            get {
                return height;
            }
            set {
                height = value;
            }
        }

        public bool IsEmpty {
            get {
                if (!(width <= 0f)) {
                    return height <= 0f;
                }
                return true;
            }
        }

        public float Left => X;

        public float Right => X + Width;

        public float Top => Y;

        public float Width {
            get {
                return width;
            }
            set {
                width = value;
            }
        }

        public float X {
            get {
                return x;
            }
            set {
                x = value;
            }
        }

        public float Y {
            get {
                return y;
            }
            set {
                y = value;
            }
        }

        public static RectangleF FromLTRB (float left, float top, float right, float bottom) {
            return new RectangleF (left, top, right - left, bottom - top);
        }

        public RectangleF (float x, float y, float width, float height) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public bool Contains (float x, float y) {
            if (x >= Left && x < Right && y >= Top) {
                return y < Bottom;
            }
            return false;
        }

        public bool Contains (RectangleF rect) {
            if (X <= rect.X && Right >= rect.Right && Y <= rect.Y) {
                return Bottom >= rect.Bottom;
            }
            return false;
        }
    }
}