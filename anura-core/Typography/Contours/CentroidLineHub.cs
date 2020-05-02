using System.Collections.Generic;

namespace Anura.Typography.Contours {
    internal class CentroidLineHub {
        private readonly GlyphTriangle startTriangle;

        private Dictionary<GlyphTriangle, CentroidLine> _lines = new Dictionary<GlyphTriangle, CentroidLine> ();

        private List<CentroidLineHub> otherConnectedLineHubs;

        private CentroidLine currentLine;

        private GlyphTriangle currentBranchTri;

        private CentroidLine anotherCentroidLine;

        private GlyphBoneJoint foundOnJoint;

        public GlyphTriangle StartTriangle => startTriangle;

        public int LineCount => _lines.Count;

        public CentroidLineHub (GlyphTriangle startTriangle) {
            this.startTriangle = startTriangle;
        }

        public void SetCurrentCentroidLine (GlyphTriangle triOfCentroidLineHead) {
            if (currentBranchTri != triOfCentroidLineHead) {
                if (!_lines.TryGetValue (triOfCentroidLineHead, out currentLine)) {
                    currentLine = new CentroidLine ();
                    _lines.Add (triOfCentroidLineHead, currentLine);
                }
                currentBranchTri = triOfCentroidLineHead;
            }
        }

        public void AddCentroidPair (GlyphCentroidPair pair) {
            currentLine.AddCentroidPair (pair);
        }

        public void CreateBoneJoints () {
            foreach (CentroidLine value in _lines.Values) {
                value.AnalyzeEdgesAndCreateBoneJoints ();
            }
        }

        public void CreateBones (List<GlyphBone> newlyCreatedBones) {
            foreach (CentroidLine value in _lines.Values) {
                List<GlyphBoneJoint> joints = value._joints;
                List<GlyphBone> bones = value.bones;
                int count = joints.Count;
                if (count != 0) {
                    GlyphBoneJoint glyphBoneJoint = joints[0];
                    GlyphTriangle p_Tri = glyphBoneJoint.P_Tri;
                    CreateTipBoneIfNeed (p_Tri.e0 as InsideEdgeLine, glyphBoneJoint, newlyCreatedBones, bones);
                    CreateTipBoneIfNeed (p_Tri.e1 as InsideEdgeLine, glyphBoneJoint, newlyCreatedBones, bones);
                    CreateTipBoneIfNeed (p_Tri.e2 as InsideEdgeLine, glyphBoneJoint, newlyCreatedBones, bones);
                    for (int i = 0; i < count; i++) {
                        glyphBoneJoint = joints[i];
                        if (glyphBoneJoint.TipEdgeP != null) {
                            GlyphBone item = new GlyphBone (glyphBoneJoint, glyphBoneJoint.TipEdgeP);
                            newlyCreatedBones.Add (item);
                            bones.Add (item);
                        }
                        if (i < count - 1) {
                            GlyphBoneJoint b = joints[i + 1];
                            GlyphBone item2 = new GlyphBone (glyphBoneJoint, b);
                            newlyCreatedBones.Add (item2);
                            bones.Add (item2);
                        }
                        if (glyphBoneJoint.TipEdgeQ != null) {
                            GlyphBone item3 = new GlyphBone (glyphBoneJoint, glyphBoneJoint.TipEdgeQ);
                            newlyCreatedBones.Add (item3);
                            bones.Add (item3);
                        }
                    }
                }
            }
        }

        private static void CreateTipBoneIfNeed (InsideEdgeLine insideEdge, GlyphBoneJoint joint, List<GlyphBone> newlyCreatedBones, List<GlyphBone> glyphBones) {
            if (insideEdge != null && insideEdge.inside_joint != null && insideEdge.inside_joint != joint) {
                GlyphBone item = new GlyphBone (insideEdge.inside_joint, joint);
                newlyCreatedBones.Add (item);
                glyphBones.Add (item);
            }
        }

        public void CreateBoneLinkBetweenCentroidLine (List<GlyphBone> newlyCreatedBones) {
            foreach (CentroidLine value in _lines.Values) {
                List<GlyphBone> bones = value.bones;
                GlyphBoneJoint glyphBoneJoint = value._joints[0];
                GlyphTriangle p_Tri = glyphBoneJoint.P_Tri;
                CreateBoneJointIfNeed (p_Tri.e0 as InsideEdgeLine, p_Tri, glyphBoneJoint, newlyCreatedBones, bones);
                CreateBoneJointIfNeed (p_Tri.e1 as InsideEdgeLine, p_Tri, glyphBoneJoint, newlyCreatedBones, bones);
                CreateBoneJointIfNeed (p_Tri.e2 as InsideEdgeLine, p_Tri, glyphBoneJoint, newlyCreatedBones, bones);
            }
        }

        private static void CreateBoneJointIfNeed (InsideEdgeLine insideEdge, GlyphTriangle first_p_tri, GlyphBoneJoint firstJoint, List<GlyphBone> newlyCreatedBones, List<GlyphBone> glyphBones) {
            if (insideEdge != null && insideEdge.inside_joint == null) {
                EdgeLine foundEdge = null;
                if ((FindSameCoordEdgeLine (first_p_tri.N0, insideEdge, out foundEdge) || FindSameCoordEdgeLine (first_p_tri.N1, insideEdge, out foundEdge) || FindSameCoordEdgeLine (first_p_tri.N2, insideEdge, out foundEdge)) && foundEdge.IsInside) {
                    new GlyphBoneJoint ((InsideEdgeLine) foundEdge, insideEdge);
                    GlyphBone item = new GlyphBone (insideEdge.inside_joint, firstJoint);
                    newlyCreatedBones.Add (item);
                    glyphBones.Add (item);
                }
            }
        }

        private static bool FindSameCoordEdgeLine (GlyphTriangle tri, EdgeLine edgeLine, out EdgeLine foundEdge) {
            foundEdge = null;
            if (tri == null) {
                return false;
            }
            if (SameCoord (foundEdge = tri.e0, edgeLine) || SameCoord (foundEdge = tri.e1, edgeLine) || SameCoord (foundEdge = tri.e2, edgeLine)) {
                return true;
            }
            foundEdge = null;
            return false;
        }

        private static bool SameCoord (EdgeLine a, EdgeLine b) {
            if (a.P == b.P || a.P == b.Q) {
                if (a.Q != b.P) {
                    return a.Q == b.Q;
                }
                return true;
            }
            return false;
        }

        public Dictionary<GlyphTriangle, CentroidLine> GetAllCentroidLines () {
            return _lines;
        }

        public bool FindBoneJoint (GlyphTriangle tri, out CentroidLine foundOnBranch, out GlyphBoneJoint foundOnJoint) {
            foreach (CentroidLine value in _lines.Values) {
                if ((foundOnJoint = value.FindNearestJoint (tri)) != null) {
                    foundOnBranch = value;
                    return true;
                }
            }
            foundOnBranch = null;
            foundOnJoint = null;
            return false;
        }

        public void AddLineHubConnection (CentroidLineHub anotherHub) {
            if (otherConnectedLineHubs == null) {
                otherConnectedLineHubs = new List<CentroidLineHub> ();
            }
            otherConnectedLineHubs.Add (anotherHub);
        }

        public void SetHeadConnnection (CentroidLine anotherCentroidLine, GlyphBoneJoint foundOnJoint) {
            this.anotherCentroidLine = anotherCentroidLine;
            this.foundOnJoint = foundOnJoint;
        }

        public GlyphBoneJoint GetHeadConnectedJoint () {
            return foundOnJoint;
        }

        public List<CentroidLineHub> GetConnectedLineHubs () {
            return otherConnectedLineHubs;
        }
    }
}