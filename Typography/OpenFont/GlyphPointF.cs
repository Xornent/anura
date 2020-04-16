using System.Numerics;

namespace Anura.Typography.OpenFont {
    public struct GlyphPointF {
        internal Vector2 P;

        internal bool onCurve;

        public float X => P.X;

        public float Y => P.Y;

        public GlyphPointF (float x, float y, bool onCurve) {
            P = new Vector2 (x, y);
            this.onCurve = onCurve;
        }

        public GlyphPointF (Vector2 position, bool onCurve) {
            P = position;
            this.onCurve = onCurve;
        }

        public static GlyphPointF operator * (GlyphPointF p, float n) {
            return new GlyphPointF (p.P * n, p.onCurve);
        }

        internal GlyphPointF Offset (short dx, short dy) {
            return new GlyphPointF (new Vector2 (P.X + (float) dx, P.Y + (float) dy), onCurve);
        }

        internal void ApplyScale (float scale) {
            P *= scale;
        }

        internal void ApplyScaleOnlyOnXAxis (float scale) {
            P = new Vector2 (P.X * scale, P.Y);
        }

        internal void UpdateX (float x) {
            P.X = x;
        }

        internal void UpdateY (float y) {
            P.Y = y;
        }

        internal void OffsetY (float dy) {
            P.Y += dy;
        }

        internal void OffsetX (float dx) {
            P.X += dx;
        }
    }
}