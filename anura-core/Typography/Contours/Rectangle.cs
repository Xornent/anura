namespace Anura.Typography.Contours {
    public struct Rectangle {
        private int x;

        private int y;

        private int width;

        private int height;

        public static readonly Rectangle Empty;

        public int Bottom => y + height;

        public int Height {
            get {
                return height;
            }
            set {
                height = value;
            }
        }

        public bool IsEmpty {
            get {
                if (x == 0 && y == 0 && width == 0) {
                    return height == 0;
                }
                return false;
            }
        }

        public int Left => X;

        public int Right => X + Width;

        public int Top => y;

        public int Width {
            get {
                return width;
            }
            set {
                width = value;
            }
        }

        public int X {
            get {
                return x;
            }
            set {
                x = value;
            }
        }

        public int Y {
            get {
                return y;
            }
            set {
                y = value;
            }
        }

        public static Rectangle FromLTRB (int left, int top, int right, int bottom) {
            return new Rectangle (left, top, right - left, bottom - top);
        }

        public Rectangle (int x, int y, int width, int height) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public bool Contains (int x, int y) {
            if (x >= Left && x < Right && y >= Top) {
                return y < Bottom;
            }
            return false;
        }

        public bool IntersectsWith (Rectangle rect) {
            if (Left < rect.Right && Right > rect.Left && Top < rect.Bottom) {
                return Bottom > rect.Top;
            }
            return false;
        }

        public bool IntersectsWith (int left, int top, int right, int bottom) {
            if (((Left <= left && Right > left) || (Left >= left && Left < right)) && ((Top <= top && Bottom > top) || (Top >= top && Top < bottom))) {
                return true;
            }
            return false;
        }

        private bool IntersectsWithInclusive (Rectangle r) {
            if (Left <= r.Right && Right >= r.Left && Top <= r.Bottom) {
                return Bottom >= r.Top;
            }
            return false;
        }

        public void Offset (int x, int y) {
            this.x += x;
            this.y += y;
        }
    }
}