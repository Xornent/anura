using System.Collections.Generic;
using System.Numerics;

namespace Anura.Typography.Contours {
    internal class CentroidLine {
        private List<GlyphCentroidPair> _centroid_pairs = new List<GlyphCentroidPair> ();

        public List<GlyphBoneJoint> _joints = new List<GlyphBoneJoint> ();

        public List<GlyphBone> bones = new List<GlyphBone> ();

        internal CentroidLine () { }

        public void AddCentroidPair (GlyphCentroidPair pair) {
            _centroid_pairs.Add (pair);
        }

        public void AnalyzeEdgesAndCreateBoneJoints () {
            List<GlyphCentroidPair> centroid_pairs = _centroid_pairs;
            int count = centroid_pairs.Count;
            for (int i = 0; i < count; i++) {
                _joints.Add (centroid_pairs[i].AnalyzeEdgesAndCreateBoneJoint ());
            }
            _centroid_pairs.Clear ();
            _centroid_pairs = null;
        }

        public void ApplyGridBox (List<BoneGroup> boneGroups, int gridW, int gridH) {
            for (int num = _joints.Count - 1; num >= 0; num--) {
                _joints[num].AdjustFitXY (gridW, gridH);
            }
            for (int num2 = bones.Count - 1; num2 >= 0; num2--) {
                bones[num2].EvaluateSlope ();
            }
            int count = bones.Count;
            BoneGroup boneGroup = new BoneGroup (this);
            boneGroup.slopeKind = LineSlopeKind.Other;
            float num3 = 0f;
            float num4 = 0f;
            float num5 = 0f;
            for (int i = 0; i < count; i++) {
                GlyphBone glyphBone = bones[i];
                LineSlopeKind slopeKind = glyphBone.SlopeKind;
                Vector2 midPoint = glyphBone.GetMidPoint ();
                if (slopeKind != boneGroup.slopeKind) {
                    if (boneGroup.count > 0) {
                        boneGroup.approxLength = num3;
                        boneGroup.avg_x = num5 / (float) boneGroup.count;
                        boneGroup.avg_y = num4 / (float) boneGroup.count;
                        boneGroups.Add (boneGroup);
                    }
                    boneGroup = new BoneGroup (this);
                    boneGroup.startIndex = i;
                    boneGroup.slopeKind = slopeKind;
                    boneGroup.count++;
                    num3 = glyphBone.EvaluateFitLength ();
                    num5 = midPoint.X;
                    num4 = midPoint.Y;
                } else {
                    boneGroup.count++;
                    num3 += glyphBone.EvaluateFitLength ();
                    num5 += midPoint.X;
                    num4 += midPoint.Y;
                }
            }
            if (boneGroup.count > 0) {
                boneGroup.approxLength = num3;
                boneGroup.avg_x = num5 / (float) boneGroup.count;
                boneGroup.avg_y = num4 / (float) boneGroup.count;
                boneGroups.Add (boneGroup);
            }
        }

        public GlyphBoneJoint FindNearestJoint (GlyphTriangle tri) {
            for (int num = _joints.Count - 1; num >= 0; num--) {
                GlyphBoneJoint glyphBoneJoint = _joints[num];
                if (glyphBoneJoint.ComposeOf (tri)) {
                    return glyphBoneJoint;
                }
            }
            return null;
        }
    }
}