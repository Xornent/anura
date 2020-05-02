using System.Collections.Generic;
using System.Numerics;

namespace Anura.Typography.Contours {
    internal class GlyphPartFlattener {
        private List<GlyphPoint> _points;

        public List<GlyphPoint> Result {
            get {
                return _points;
            }
            set {
                _points = value;
            }
        }

        public int NSteps {
            get;
            set;
        }

        public GlyphPartFlattener () {
            NSteps = 2;
        }

        private void AddPoint (float x, float y, PointKind kind) {
            GlyphPoint item = new GlyphPoint (x, y, kind);
            _points.Add (item);
        }

        public void GeneratePointsFromLine (Vector2 start, Vector2 end) {
            if (_points.Count == 0) {
                AddPoint (start.X, start.Y, PointKind.LineStart);
            }
            AddPoint (end.X, end.Y, PointKind.LineStop);
        }

        public void GeneratePointsFromCurve4 (int nsteps, Vector2 start, Vector2 end, Vector2 control1, Vector2 control2) {
            BezierCurveCubic bezierCurveCubic = new BezierCurveCubic (start, end, control1, control2);
            if (_points.Count == 0) {
                AddPoint (start.X, start.Y, PointKind.C4Start);
            }
            float num = 1f / (float) nsteps;
            float num2 = num;
            for (int i = 1; i < nsteps; i++) {
                Vector2 vector = bezierCurveCubic.CalculatePoint (num2);
                AddPoint (vector.X, vector.Y, PointKind.CurveInbetween);
                num2 += num;
            }
            AddPoint (end.X, end.Y, PointKind.C4End);
        }

        public void GeneratePointsFromCurve3 (int nsteps, Vector2 start, Vector2 end, Vector2 control1) {
            BezierCurveQuadric bezierCurveQuadric = new BezierCurveQuadric (start, end, control1);
            if (_points.Count == 0) {
                AddPoint (start.X, start.Y, PointKind.C3Start);
            }
            float num = 1f / (float) nsteps;
            float num2 = num;
            for (int i = 1; i < nsteps; i++) {
                Vector2 vector = bezierCurveQuadric.CalculatePoint (num2);
                AddPoint (vector.X, vector.Y, PointKind.CurveInbetween);
                num2 += num;
            }
            AddPoint (end.X, end.Y, PointKind.C3End);
        }
    }
}