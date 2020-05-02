using System.Numerics;

namespace Anura.Typography.Contours {
    public class OutsideEdgeLine : EdgeLine {
        internal Vector2 _newDynamicMidPoint;

        private EdgeLine _ctrlEdge_P;

        private EdgeLine _ctrlEdge_Q;

        public override bool IsOutside => true;

        public EdgeLine ControlEdge_P => _ctrlEdge_P;

        public EdgeLine ControlEdge_Q => _ctrlEdge_Q;

        internal OutsideEdgeLine (GlyphTriangle ownerTriangle, GlyphPoint p, GlyphPoint q) : base (ownerTriangle, p, q) {
            p.SetOutsideEdgeUnconfirmEdgeDirection (this);
            q.SetOutsideEdgeUnconfirmEdgeDirection (this);
            _newDynamicMidPoint = new Vector2 ((p.OX + q.OX) / 2f, (p.OY + q.OY) / 2f);
        }

        internal void SetDynamicEdgeOffsetFromMasterOutline (float newEdgeOffsetFromMasterOutline) {
            Vector2 right = GetOriginalEdgeVector ().Rotate (90).NewLength (newEdgeOffsetFromMasterOutline);
            _newDynamicMidPoint = this.GetMidPoint () + right;
        }

        internal void SetControlEdge (EdgeLine controlEdge) {
            if (_glyphPoint_P == controlEdge._glyphPoint_P) {
                _ctrlEdge_P = controlEdge;
            } else if (_glyphPoint_P == controlEdge.Q) {
                _ctrlEdge_P = controlEdge;
            } else if (_glyphPoint_Q == controlEdge._glyphPoint_P) {
                _ctrlEdge_Q = controlEdge;
            } else if (_glyphPoint_Q == controlEdge.Q) {
                _ctrlEdge_Q = controlEdge;
            }
        }
    }
}