using System.Numerics;

namespace Anura.Typography.Contours {
    public class GlyphCurve4 : GlyphPart {
        public float x1;

        public float y1;

        public float x2;

        public float y2;

        public float x3;

        public float y3;

        public override GlyphPartKind Kind => GlyphPartKind.Curve4;

        public GlyphCurve4 (float x0, float y0, float x1, float y1, float x2, float y2, float x3, float y3) {
            base.FirstPoint = new Vector2 (x0, y0);
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        public GlyphCurve4 (GlyphPart prevPart, float x1, float y1, float x2, float y2, float x3, float y3) {
            base.PrevPart = prevPart;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        public override Vector2 GetLastPoint () {
            return new Vector2 (x3, y3);
        }

        internal override void Flatten (GlyphPartFlattener flattener) {
            flattener.GeneratePointsFromCurve4 (flattener.NSteps, base.FirstPoint, new Vector2 (x3, y3), new Vector2 (x1, y1), new Vector2 (x2, y2));
        }
    }
}