using System.Numerics;

namespace Anura.Typography.Contours {
    public struct BezierCurveQuadric {
        public Vector2 StartAnchor;

        public Vector2 EndAnchor;

        public Vector2 ControlPoint;

        public float Parallel;

        public BezierCurveQuadric (Vector2 startAnchor, Vector2 endAnchor, Vector2 controlPoint) {
            StartAnchor = startAnchor;
            EndAnchor = endAnchor;
            ControlPoint = controlPoint;
            Parallel = 0f;
        }

        public BezierCurveQuadric (float parallel, Vector2 startAnchor, Vector2 endAnchor, Vector2 controlPoint) {
            Parallel = parallel;
            StartAnchor = startAnchor;
            EndAnchor = endAnchor;
            ControlPoint = controlPoint;
        }

        public Vector2 CalculatePoint (float t) {
            Vector2 vector = default (Vector2);
            float num = 1f - t;
            vector.X = num * num * StartAnchor.X + 2f * t * num * ControlPoint.X + t * t * EndAnchor.X;
            vector.Y = num * num * StartAnchor.Y + 2f * t * num * ControlPoint.Y + t * t * EndAnchor.Y;
            if (Parallel == 0f) {
                return vector;
            }
            Vector2 vector2 = default (Vector2);
            vector2 = ((t != 0f) ? (vector - CalculatePointOfDerivative (t)) : (ControlPoint - StartAnchor));
            return vector + Vector2.Normalize (vector2).GetPerpendicularRight () * Parallel;
        }

        private Vector2 CalculatePointOfDerivative (float t) {
            Vector2 result = default (Vector2);
            result.X = (1f - t) * StartAnchor.X + t * ControlPoint.X;
            result.Y = (1f - t) * StartAnchor.Y + t * ControlPoint.Y;
            return result;
        }

        public float CalculateLength (float precision) {
            double num = 0.0;
            Vector2 right = CalculatePoint (0f);
            for (float num2 = precision; num2 < 1f + precision; num2 += precision) {
                Vector2 vector = CalculatePoint (num2);
                num += (double) (vector - right).Length ();
                right = vector;
            }
            return (float) num;
        }
    }
}