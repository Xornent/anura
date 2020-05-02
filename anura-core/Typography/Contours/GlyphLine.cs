using System.Numerics;

namespace Anura.Typography.Contours {
    public class GlyphLine : GlyphPart {
        public float x1;

        public float y1;

        public override GlyphPartKind Kind => GlyphPartKind.Line;

        public GlyphLine (float x0, float y0, float x1, float y1) {
            base.FirstPoint = new Vector2 (x0, y0);
            this.x1 = x1;
            this.y1 = y1;
        }

        public GlyphLine (GlyphPart prevPart, float x1, float y1) {
            base.PrevPart = prevPart;
            this.x1 = x1;
            this.y1 = y1;
        }

        public override Vector2 GetLastPoint () {
            return new Vector2 (x1, y1);
        }

        internal override void Flatten (GlyphPartFlattener flattener) {
            flattener.GeneratePointsFromLine (base.FirstPoint, new Vector2 (x1, y1));
        }
    }
}