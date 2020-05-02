using System.Numerics;

namespace Anura.Typography.Contours {
    public abstract class EdgeLine {
        internal readonly GlyphPoint _glyphPoint_P;

        internal readonly GlyphPoint _glyphPoint_Q;

        private GlyphTriangle _ownerTriangle;

        private static readonly double _85degreeToRad = MyMath.DegreesToRadians (85.0);

        private static readonly double _01degreeToRad = MyMath.DegreesToRadians (1.0);

        internal bool _earlyInsideAnalysis;

        public double PX => _glyphPoint_P.OX;

        public double PY => _glyphPoint_P.OY;

        public double QX => _glyphPoint_Q.OX;

        public double QY => _glyphPoint_Q.OY;

        public bool IsTip {
            get;
            internal set;
        }

        public GlyphPoint P => _glyphPoint_P;

        public GlyphPoint Q => _glyphPoint_Q;

        public LineSlopeKind SlopeKind {
            get;
            internal set;
        }

        internal GlyphTriangle OwnerTriangle => _ownerTriangle;

        public abstract bool IsOutside {
            get;
        }

        public bool IsInside => !IsOutside;

        public bool IsUpper {
            get;
            internal set;
        }

        public bool IsLeftSide {
            get;
            internal set;
        }

        internal double SlopeAngleNoDirection {
            get;
            private set;
        }

        internal EdgeLine (GlyphTriangle ownerTriangle, GlyphPoint p, GlyphPoint q) {
            _ownerTriangle = ownerTriangle;
            _glyphPoint_P = p;
            _glyphPoint_Q = q;
            SlopeAngleNoDirection = this.GetSlopeAngleNoDirection ();
            if (QX == PX) {
                SlopeKind = LineSlopeKind.Vertical;
            } else if (SlopeAngleNoDirection > _85degreeToRad) {
                SlopeKind = LineSlopeKind.Vertical;
            } else if (SlopeAngleNoDirection < _01degreeToRad) {
                SlopeKind = LineSlopeKind.Horizontal;
                bool isPartOfHorizontalEdge = q.IsPartOfHorizontalEdge = true;
                p.IsPartOfHorizontalEdge = isPartOfHorizontalEdge;
            } else {
                SlopeKind = LineSlopeKind.Other;
            }
        }

        internal Vector2 GetOriginalEdgeVector () {
            return new Vector2 (Q.OX - _glyphPoint_P.OX, Q.OY - _glyphPoint_P.OY);
        }

        public override string ToString () {
            return SlopeKind + ":" + PX + "," + PY + "," + QX + "," + QY;
        }

        internal bool ContainsGlyphPoint (GlyphPoint p) {
            if (_glyphPoint_P != p) {
                return _glyphPoint_Q == p;
            }
            return true;
        }

        internal static OutsideEdgeLine FindCommonOutsideEdge (GlyphPoint p, GlyphPoint q) {
            if (p.E0 == q.E0 || p.E0 == q.E1) {
                return p.E0;
            }
            if (p.E1 == q.E0 || p.E1 == q.E1) {
                return p.E1;
            }
            return null;
        }
    }
}