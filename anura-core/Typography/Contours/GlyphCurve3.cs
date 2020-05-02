using System.Numerics;

namespace Anura.Typography.Contours {
    public class GlyphCurve3 : GlyphPart {
        public float x1;

        public float y1;

        public float x2;

        public float y2;

        public override GlyphPartKind Kind => GlyphPartKind.Curve3;

        public GlyphCurve3 (float x0, float y0, float x1, float y1, float x2, float y2) {
            base.FirstPoint = new Vector2 (x0, y0);
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public GlyphCurve3 (GlyphPart prevPart, float x1, float y1, float x2, float y2) {
            base.PrevPart = prevPart;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override Vector2 GetLastPoint () {
            return new Vector2 (x2, y2);
        }

        internal override void Flatten (GlyphPartFlattener flattener) {
            flattener.GeneratePointsFromCurve3 (flattener.NSteps, base.FirstPoint, new Vector2 (x2, y2), new Vector2 (x1, y1));
        }
    }
}