using System.Numerics;

namespace Anura.Typography.Contours {
    internal static class Vector2Extensions {
        public static Vector2 GetPerpendicularRight (this Vector2 v) {
            return new Vector2 (v.Y, 0f - v.X);
        }
    }
}