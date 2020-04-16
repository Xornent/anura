using System;

namespace Anura.Typography.Contours {
    public class GlyphPoint {
        private readonly float _ox;

        private readonly float _oy;

        private readonly PointKind _kind;

        private float _newX;

        private float _newY;

        private float _adjust_fit_y;

        private OutsideEdgeLine _e0;

        private OutsideEdgeLine _e1;

        public int SeqNo {
            get;
            internal set;
        }

        public PointKind PointKind => _kind;

        internal bool IsPartOfHorizontalEdge {
            get;
            set;
        }

        public float OX => _ox;

        public float OY => _oy;

        public float X => _newX;

        public float Y => _newY;

        public float FitAdjustY {
            get {
                return _adjust_fit_y;
            }
            internal set {
                _adjust_fit_y = value;
            }
        }

        internal OutsideEdgeLine E0 => _e0;

        internal OutsideEdgeLine E1 => _e1;

        public GlyphPoint (float x, float y, PointKind kind) {
            _ox = (_newX = x);
            _oy = (_newY = y);
            _kind = kind;
        }

        internal void ResetFitAdjustValues () {
            _adjust_fit_y = 0f;
        }

        internal void GetFitXY (float pxscale, out float x, out float y) {
            x = _newX * pxscale;
            y = _newY * pxscale + _adjust_fit_y;
        }

        internal void SetNewXY (float x, float y) {
            _newX = x;
            _newY = y;
        }

        internal void SetOutsideEdgeUnconfirmEdgeDirection (OutsideEdgeLine edge) {
            if (_e0 == null) {
                _e0 = edge;
                return;
            }
            if (_e1 == null) {
                _e1 = edge;
                return;
            }
            throw new NotSupportedException ();
        }

        internal static bool SameCoordAs (GlyphPoint a, GlyphPoint b) {
            if (a._ox == b._ox) {
                return a._oy == b._oy;
            }
            return false;
        }
    }
}