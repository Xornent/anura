using System.Numerics;

namespace Anura.Typography.Contours {
    public abstract class GlyphPart {
        private float _x0;

        private float _y0;

        public Vector2 FirstPoint {
            get {
                if (PrevPart != null) {
                    return PrevPart.GetLastPoint ();
                }
                return new Vector2 (_x0, _y0);
            }
            protected set {
                _x0 = value.X;
                _y0 = value.Y;
            }
        }

        public abstract GlyphPartKind Kind {
            get;
        }

        public GlyphPart NextPart {
            get;
            set;
        }

        public GlyphPart PrevPart {
            get;
            set;
        }

        internal abstract void Flatten (GlyphPartFlattener flattener);

        public abstract Vector2 GetLastPoint ();
    }
}