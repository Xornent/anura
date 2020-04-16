using System.Numerics;

namespace Anura.Typography.Contours {
    internal struct BezierCurveCubic {
        public Vector2 StartAnchor;

        public Vector2 EndAnchor;

        public Vector2 FirstControlPoint;

        public Vector2 SecondControlPoint;

        public float Parallel;

        public BezierCurveCubic (Vector2 startAnchor, Vector2 endAnchor, Vector2 firstControlPoint, Vector2 secondControlPoint) {
            StartAnchor = startAnchor;
            EndAnchor = endAnchor;
            FirstControlPoint = firstControlPoint;
            SecondControlPoint = secondControlPoint;
            Parallel = 0f;
        }

        public BezierCurveCubic (float parallel, Vector2 startAnchor, Vector2 endAnchor, Vector2 firstControlPoint, Vector2 secondControlPoint) {
            Parallel = parallel;
            StartAnchor = startAnchor;
            EndAnchor = endAnchor;
            FirstControlPoint = firstControlPoint;
            SecondControlPoint = secondControlPoint;
        }

        public Vector2 CalculatePoint (float t) {
            Vector2 vector = default (Vector2);
            float num = 1f - t;
            vector.X = StartAnchor.X * num * num * num + FirstControlPoint.X * 3f * t * num * num + SecondControlPoint.X * 3f * t * t * num + EndAnchor.X * t * t * t;
            vector.Y = StartAnchor.Y * num * num * num + FirstControlPoint.Y * 3f * t * num * num + SecondControlPoint.Y * 3f * t * t * num + EndAnchor.Y * t * t * t;
            if (Parallel == 0f) {
                return vector;
            }
            Vector2 vector2 = default (Vector2);
            vector2 = ((t != 0f) ? (vector - CalculatePointOfDerivative (t)) : (FirstControlPoint - StartAnchor));
            return vector + Vector2.Normalize (vector2).GetPerpendicularRight () * Parallel;
        }

        private Vector2 CalculatePointOfDerivative (float t) {
            Vector2 result = default (Vector2);
            float num = 1f - t;
            result.X = num * num * StartAnchor.X + 2f * t * num * FirstControlPoint.X + t * t * SecondControlPoint.X;
            result.Y = num * num * StartAnchor.Y + 2f * t * num * FirstControlPoint.Y + t * t * SecondControlPoint.Y;
            return result;
        }
    }
}