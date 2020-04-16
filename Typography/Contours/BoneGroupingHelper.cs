using System.Collections.Generic;

namespace Anura.Typography.Contours {
    internal struct BoneGroupingHelper {
        private List<BoneGroup> _selectedHorizontalBoneGroups;

        private List<BoneGroup> _selectedVerticalBoneGroups;

        private List<BoneGroup> _tmpBoneGroups;

        private List<EdgeLine> tmpEdges;

        private int gridBoxW;

        private int gridBoxH;

        public List<BoneGroup> SelectedHorizontalBoneGroups => _selectedHorizontalBoneGroups;

        public List<BoneGroup> SelectedVerticalBoneGroups => _selectedVerticalBoneGroups;

        public static BoneGroupingHelper CreateBoneGroupingHelper () {
            BoneGroupingHelper result = default (BoneGroupingHelper);
            result._selectedHorizontalBoneGroups = new List<BoneGroup> ();
            result._selectedVerticalBoneGroups = new List<BoneGroup> ();
            result._tmpBoneGroups = new List<BoneGroup> ();
            result.tmpEdges = new List<EdgeLine> ();
            return result;
        }

        public void Reset (int gridBoxW, int gridBoxH) {
            this.gridBoxW = gridBoxW;
            this.gridBoxH = gridBoxH;
            _selectedHorizontalBoneGroups.Clear ();
            _selectedVerticalBoneGroups.Clear ();
        }

        public void CollectBoneGroups (CentroidLine line) {
            _tmpBoneGroups.Clear ();
            line.ApplyGridBox (_tmpBoneGroups, gridBoxW, gridBoxH);
            for (int num = _tmpBoneGroups.Count - 1; num >= 0; num--) {
                BoneGroup boneGroup = _tmpBoneGroups[num];
                switch (boneGroup.slopeKind) {
                    case LineSlopeKind.Horizontal:
                        _selectedHorizontalBoneGroups.Add (boneGroup);
                        break;
                    case LineSlopeKind.Vertical:
                        _selectedVerticalBoneGroups.Add (boneGroup);
                        break;
                }
            }
            _tmpBoneGroups.Clear ();
        }

        public void AnalyzeHorizontalBoneGroups () {
            if (_selectedHorizontalBoneGroups.Count != 0) {
                Mark_ShortBones (_selectedHorizontalBoneGroups);
                _selectedHorizontalBoneGroups.Sort ((BoneGroup bg0, BoneGroup bg1) => bg0.avg_y.CompareTo (bg1.avg_y));
                for (int num = _selectedHorizontalBoneGroups.Count - 1; num >= 0; num--) {
                    _selectedHorizontalBoneGroups[num].CollectOutsideEdges (tmpEdges);
                }
            }
        }

        public void AnalyzeVerticalBoneGroups () {
            if (_selectedVerticalBoneGroups.Count != 0) {
                Mark_LongBones (_selectedVerticalBoneGroups);
                _selectedVerticalBoneGroups.Sort ((BoneGroup bg0, BoneGroup bg1) => bg0.avg_x.CompareTo (bg1.avg_x));
                for (int num = _selectedVerticalBoneGroups.Count - 1; num >= 0; num--) {
                    _selectedVerticalBoneGroups[num].CollectOutsideEdges (tmpEdges);
                }
            }
        }

        private static void Mark_LongBones (List<BoneGroup> boneGroups) {
            switch (boneGroups.Count) {
                case 0:
                    return;
                case 1:
                    boneGroups[0]._lengKind = BoneGroupSumLengthKind.Long;
                    return;
            }
            boneGroups.Sort ((BoneGroup bg0, BoneGroup bg1) => bg0.approxLength.CompareTo (bg1.approxLength));
            int count = boneGroups.Count;
            int num = count / 2;
            BoneGroup boneGroup = boneGroups[num];
            float num2 = boneGroup.approxLength * 2f;
            bool flag = false;
            for (int num3 = count - 1; num3 >= num; num3--) {
                boneGroup = boneGroups[num3];
                if (!(boneGroup.approxLength > num2)) {
                    break;
                }
                flag = true;
                boneGroup._lengKind = BoneGroupSumLengthKind.Long;
            }
            if (!flag) {
                for (int num4 = count - 1; num4 >= num; num4--) {
                    boneGroups[num4]._lengKind = BoneGroupSumLengthKind.Long;
                }
            }
        }

        private static void Mark_ShortBones (List<BoneGroup> boneGroups) {
            if (boneGroups.Count < 2) {
                return;
            }
            boneGroups.Sort ((BoneGroup bg0, BoneGroup bg1) => bg0.approxLength.CompareTo (bg1.approxLength));
            int num = boneGroups.Count / 2;
            BoneGroup boneGroup = boneGroups[num];
            float num2 = boneGroup.approxLength / 2f;
            for (int i = 0; i < num; i++) {
                boneGroup = boneGroups[i];
                if (boneGroup.approxLength < num2) {
                    boneGroup._lengKind = BoneGroupSumLengthKind.Short;
                    continue;
                }
                break;
            }
        }
    }
}