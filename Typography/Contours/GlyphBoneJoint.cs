using System.Numerics;

namespace Anura.Typography.Contours {
    public class GlyphBoneJoint {
        internal readonly EdgeLine _p_contact_edge;

        internal readonly EdgeLine _q_contact_edge;

        private EdgeLine _tipEdge_p;

        private EdgeLine _tipEdge_q;

        private float _fitX;

        private float _fitY;

        public float FitX => _fitX;

        public float FitY => _fitY;

        internal GlyphTriangle P_Tri => _p_contact_edge.OwnerTriangle;

        internal GlyphTriangle Q_Tri => _q_contact_edge.OwnerTriangle;

        public Vector2 OriginalJointPos => _p_contact_edge.GetMidPoint ();

        public Vector2 DynamicFitPos => new Vector2 (_fitX, _fitY);

        public bool HasTipP => _tipEdge_p != null;

        public bool HasTipQ => _tipEdge_q != null;

        public Vector2 TipPointP => _tipEdge_p.GetMidPoint ();

        public EdgeLine TipEdgeP => _tipEdge_p;

        public Vector2 TipPointQ => _tipEdge_q.GetMidPoint ();

        public EdgeLine TipEdgeQ => _tipEdge_q;

        internal GlyphBoneJoint (InsideEdgeLine p_contact_edge, InsideEdgeLine q_contact_edge) {
            _p_contact_edge = p_contact_edge;
            _q_contact_edge = q_contact_edge;
            Vector2 midPoint = p_contact_edge.GetMidPoint ();
            _fitX = midPoint.X;
            _fitY = midPoint.Y;
            p_contact_edge.inside_joint = this;
            q_contact_edge.inside_joint = this;
        }

        internal void SetFitXY (float newx, float newy) {
            _fitX = newx;
            _fitY = newy;
        }

        public double CalculateSqrDistance (Vector2 v) {
            Vector2 originalJointPos = OriginalJointPos;
            float num = originalJointPos.X - v.X;
            float num2 = originalJointPos.Y - v.Y;
            return num * num + num2 * num2;
        }

        internal void SetTipEdge_P (EdgeLine e) {
            e.IsTip = true;
            _tipEdge_p = e;
        }

        internal void SetTipEdge_Q (EdgeLine e) {
            e.IsTip = true;
            _tipEdge_q = e;
        }

        internal bool ComposeOf (GlyphTriangle tri) {
            if (P_Tri != tri) {
                return Q_Tri == tri;
            }
            return true;
        }

        internal void AdjustFitXY (int gridW, int gridH) {
            Vector2 originalJointPos = OriginalJointPos;
            SetFitXY (MyMath.FitToHalfGrid (originalJointPos.X, gridW), MyMath.FitToHalfGrid (originalJointPos.Y, gridH));
        }
    }
}