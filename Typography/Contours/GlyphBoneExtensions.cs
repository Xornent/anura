using System.Collections.Generic;
using System.Numerics;

namespace Anura.Typography.Contours {
    public static class GlyphBoneExtensions {
        public static Vector2 GetMidPoint (this GlyphBone bone) {
            if (bone.JointB != null) {
                return (bone.JointA.OriginalJointPos + bone.JointB.OriginalJointPos) / 2f;
            }
            if (bone.TipEdge != null) {
                return (bone.TipEdge.GetMidPoint () + bone.JointA.OriginalJointPos) / 2f;
            }
            return Vector2.Zero;
        }

        public static void CollectOutsideEdge (this GlyphBone bone, List<EdgeLine> outsideEdges) {
            if (bone.JointB != null) {
                GlyphTriangle glyphTriangle = FindCommonTriangle (bone.JointA, bone.JointB);
                if (glyphTriangle != null) {
                    if (glyphTriangle.e0.IsOutside) {
                        outsideEdges.Add (glyphTriangle.e0);
                    }
                    if (glyphTriangle.e1.IsOutside) {
                        outsideEdges.Add (glyphTriangle.e1);
                    }
                    if (glyphTriangle.e2.IsOutside) {
                        outsideEdges.Add (glyphTriangle.e2);
                    }
                }
            } else if (bone.TipEdge != null) {
                outsideEdges.Add (bone.TipEdge);
                EdgeLine item;
                if (ContainsEdge (bone.JointA.P_Tri, bone.TipEdge) && (item = FindAnotherOutsideEdge (bone.JointA.P_Tri, bone.TipEdge)) != null) {
                    outsideEdges.Add (item);
                } else if (ContainsEdge (bone.JointA.Q_Tri, bone.TipEdge) && (item = FindAnotherOutsideEdge (bone.JointA.Q_Tri, bone.TipEdge)) != null) {
                    outsideEdges.Add (item);
                }
            }
        }

        private static EdgeLine FindAnotherOutsideEdge (GlyphTriangle tri, EdgeLine knownOutsideEdge) {
            if (tri.e0.IsOutside && tri.e0 != knownOutsideEdge) {
                return tri.e0;
            }
            if (tri.e1.IsOutside && tri.e1 != knownOutsideEdge) {
                return tri.e1;
            }
            if (tri.e2.IsOutside && tri.e2 != knownOutsideEdge) {
                return tri.e2;
            }
            return null;
        }

        private static bool ContainsEdge (GlyphTriangle tri, EdgeLine edge) {
            if (tri.e0 != edge && tri.e1 != edge) {
                return tri.e2 == edge;
            }
            return true;
        }

        private static GlyphTriangle FindCommonTriangle (GlyphBoneJoint a, GlyphBoneJoint b) {
            if (a.P_Tri == b.P_Tri || a.P_Tri == b.Q_Tri) {
                return a.P_Tri;
            }
            if (a.Q_Tri == b.P_Tri || a.Q_Tri == b.Q_Tri) {
                return a.Q_Tri;
            }
            return null;
        }
    }
}