using System.Collections.Generic;
using Anura.Typography.OpenFont;

namespace Anura.Typography.Contours {
    public class GlyphDynamicOutline {
        private struct FitDiffCollector {
            private float _negative_diff;

            private float _positive_diff;

            private float _weighted_sum_negativeDiff;

            private float _weighted_sum_positiveDiff;

            public void Collect (float diff, float groupLen) {
                if (diff < 0f) {
                    _negative_diff += diff * groupLen;
                    _weighted_sum_negativeDiff += groupLen;
                } else {
                    _positive_diff += diff * groupLen;
                    _weighted_sum_positiveDiff += groupLen;
                }
            }

            public float CalculateProperDiff () {
                if (_weighted_sum_positiveDiff != 0f && _weighted_sum_negativeDiff != 0f) {
                    if (_positive_diff > 0f - _negative_diff) {
                        return (0f - (_positive_diff - _negative_diff)) / (_weighted_sum_positiveDiff + _weighted_sum_negativeDiff);
                    }
                    return (_positive_diff - _negative_diff) / (_weighted_sum_positiveDiff + _weighted_sum_negativeDiff);
                }
                if (_weighted_sum_positiveDiff != 0f) {
                    return _positive_diff / _weighted_sum_positiveDiff;
                }
                if (_weighted_sum_negativeDiff != 0f) {
                    return _negative_diff / _weighted_sum_negativeDiff;
                }
                return 0f;
            }
        }

        internal List<GlyphContour> _contours;

        private List<CentroidLine> _allCentroidLines;

        private float _offsetFromMasterOutline;

        private float _pxScale;

        private bool _needRefreshBoneGroup;

        private bool _needAdjustGridFitValues;

        private float _avg_x_fitOffset;

        private BoneGroupingHelper _groupingHelper;

        public bool EnableGridFit {
            get;
            set;
        }

        public int GridBoxWidth {
            get;
            private set;
        }

        public int GridBoxHeight {
            get;
            private set;
        }

        public Bounds OriginalGlyphControlBounds {
            get;
            set;
        }

        public int OriginalAdvanceWidth {
            get;
            set;
        }

        public float AvgXFitOffset => _avg_x_fitOffset;

        internal GlyphDynamicOutline (GlyphIntermediateOutline intermediateOutline) {
            _needRefreshBoneGroup = true;
            _needAdjustGridFitValues = true;
            GridBoxWidth = 32;
            GridBoxHeight = 50;
            _groupingHelper = BoneGroupingHelper.CreateBoneGroupingHelper ();
            _contours = intermediateOutline.GetContours ();
            CollectAllCentroidLines (intermediateOutline.GetCentroidLineHubs ());
        }

        private GlyphDynamicOutline () { }

        internal static GlyphDynamicOutline CreateBlankDynamicOutline () {
            return new GlyphDynamicOutline ();
        }

        internal List<GlyphContour> GetContours () {
            return _contours;
        }

        internal void AnalyzeBoneGroups (int gridBoxW, int gridBoxH) {
            GridBoxHeight = gridBoxH;
            GridBoxWidth = gridBoxW;
            _groupingHelper.Reset (gridBoxW, gridBoxH);
            for (int num = _allCentroidLines.Count - 1; num >= 0; num--) {
                _groupingHelper.CollectBoneGroups (_allCentroidLines[num]);
            }
            _groupingHelper.AnalyzeHorizontalBoneGroups ();
            _groupingHelper.AnalyzeVerticalBoneGroups ();
        }

        public void SetDynamicEdgeOffsetFromMasterOutline (float offsetFromMasterOutline) {
            if (_contours == null) {
                return;
            }
            if ((_offsetFromMasterOutline = offsetFromMasterOutline) != 0f) {
                List<GlyphContour> contours = _contours;
                for (int num = contours.Count - 1; num >= 0; num--) {
                    contours[num].ApplyNewEdgeOffsetFromMasterOutline (offsetFromMasterOutline);
                }
            }
            _needRefreshBoneGroup = true;
        }

        public void GenerateOutput (IGlyphTranslator tx, float pxScale) {
            if (_contours == null) {
                return;
            }
            if (_pxScale != pxScale) {
                _needAdjustGridFitValues = true;
            }
            _pxScale = pxScale;
            if (EnableGridFit) {
                if (_needRefreshBoneGroup) {
                    AnalyzeBoneGroups (GridBoxWidth, GridBoxHeight);
                    _needRefreshBoneGroup = false;
                }
                if (_needAdjustGridFitValues) {
                    ReCalculateFittingValues ();
                    _needAdjustGridFitValues = false;
                }
            }
            if (tx != null) {
                List<GlyphContour> contours = _contours;
                int count = contours.Count;
                tx.BeginRead (count);
                for (int i = 0; i < count; i++) {
                    GenerateContourOutput (tx, contours[i]);
                }
                tx.EndRead ();
            }
        }

        private void ReCalculateFittingValues () {
            for (int num = _contours.Count - 1; num >= 0; num--) {
                List<GlyphPoint> flattenPoints = _contours[num].flattenPoints;
                for (int num2 = flattenPoints.Count - 1; num2 >= 0; num2--) {
                    flattenPoints[num2].ResetFitAdjustValues ();
                }
            }
            List<BoneGroup> selectedHorizontalBoneGroups = _groupingHelper.SelectedHorizontalBoneGroups;
            for (int num3 = selectedHorizontalBoneGroups.Count - 1; num3 >= 0; num3--) {
                BoneGroup boneGroup = selectedHorizontalBoneGroups[num3];
                if (boneGroup._lengKind != BoneGroupSumLengthKind.Short) {
                    EdgeLine[] edges = boneGroup.edges;
                    if (edges != null) {
                        int num4 = edges.Length;
                        FitDiffCollector fitDiffCollector = default (FitDiffCollector);
                        float approxLength = boneGroup.approxLength;
                        for (int num5 = num4 - 1; num5 >= 0; num5--) {
                            EdgeLine edgeLine = edges[num5];
                            fitDiffCollector.Collect (MyMath.CalculateDiffToFit (edgeLine.P.Y * _pxScale), approxLength);
                            fitDiffCollector.Collect (MyMath.CalculateDiffToFit (edgeLine.Q.Y * _pxScale), approxLength);
                        }
                        float fitAdjustY = fitDiffCollector.CalculateProperDiff ();
                        for (int num6 = num4 - 1; num6 >= 0; num6--) {
                            EdgeLine obj = edges[num6];
                            obj.P.FitAdjustY = fitAdjustY;
                            obj.Q.FitAdjustY = fitAdjustY;
                        }
                    }
                }
            }
            List<BoneGroup> selectedVerticalBoneGroups = _groupingHelper.SelectedVerticalBoneGroups;
            FitDiffCollector fitDiffCollector2 = default (FitDiffCollector);
            int count = selectedVerticalBoneGroups.Count;
            for (int i = 0; i < count; i++) {
                BoneGroup boneGroup2 = selectedVerticalBoneGroups[i];
                if (boneGroup2._lengKind != BoneGroupSumLengthKind.Long) {
                    continue;
                }
                EdgeLine[] edges2 = boneGroup2.edges;
                if (edges2 != null) {
                    int num7 = edges2.Length;
                    float approxLength2 = boneGroup2.approxLength;
                    for (int j = 0; j < num7; j++) {
                        EdgeLine edgeLine2 = edges2[j];
                        fitDiffCollector2.Collect (MyMath.CalculateDiffToFit (edgeLine2.P.X * _pxScale), approxLength2);
                        fitDiffCollector2.Collect (MyMath.CalculateDiffToFit (edgeLine2.Q.X * _pxScale), approxLength2);
                    }
                    break;
                }
            }
            _avg_x_fitOffset = fitDiffCollector2.CalculateProperDiff ();
        }

        private void CollectAllCentroidLines (List<CentroidLineHub> lineHubs) {
            _allCentroidLines = new List<CentroidLine> ();
            int count = lineHubs.Count;
            for (int i = 0; i < count; i++) {
                _allCentroidLines.AddRange (lineHubs[i].GetAllCentroidLines ().Values);
            }
        }

        private void GenerateContourOutput (IGlyphTranslator tx, GlyphContour contour) {
            List<GlyphPoint> flattenPoints = contour.flattenPoints;
            int count = flattenPoints.Count;
            if (count != 0) {
                Bounds originalGlyphControlBound = OriginalGlyphControlBounds;
                float pxScale = _pxScale;
                flattenPoints[0].GetFitXY (pxScale, out float x, out float y);
                tx.MoveTo (x, y);
                for (int i = 1; i < count; i++) {
                    flattenPoints[i].GetFitXY (pxScale, out x, out y);
                    tx.LineTo (x, y);
                }
                tx.CloseContour ();
            }
        }
    }
}