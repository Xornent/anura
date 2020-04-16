namespace Anura.Typography.OpenFont {
    internal static class KnownFontFiles {
        public static bool IsTtcf (ushort u1, ushort u2) {
            if (((u1 >> 8) & 0xFF) == 116 && (u1 & 0xFF) == 116 && ((u2 >> 8) & 0xFF) == 99) {
                return (u2 & 0xFF) == 102;
            }
            return false;
        }

        public static bool IsWoff (ushort u1, ushort u2) {
            if (((u1 >> 8) & 0xFF) == 119 && (u1 & 0xFF) == 79 && ((u2 >> 8) & 0xFF) == 70) {
                return (u2 & 0xFF) == 70;
            }
            return false;
        }

        public static bool IsWoff2 (ushort u1, ushort u2) {
            if (((u1 >> 8) & 0xFF) == 119 && (u1 & 0xFF) == 79 && ((u2 >> 8) & 0xFF) == 70) {
                return (u2 & 0xFF) == 50;
            }
            return false;
        }
    }
}