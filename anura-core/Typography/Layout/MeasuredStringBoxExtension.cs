namespace Anura.Typography.TextLayout {
    public static class MeasuredStringBoxExtension {
        public static float CalculateLineHeight (this MeasuredStringBox box, float scale = 1f) {
            return box.BtbdInPx;
        }
    }
}