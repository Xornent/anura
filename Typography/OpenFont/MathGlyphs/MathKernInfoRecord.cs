namespace Anura.Typography.OpenFont.MathGlyphs {
    internal struct MathKernInfoRecord {
        public readonly MathKern TopRight;

        public readonly MathKern TopLeft;

        public readonly MathKern BottomRight;

        public readonly MathKern BottomLeft;

        public MathKernInfoRecord (MathKern topRight, MathKern topLeft, MathKern bottomRight, MathKern bottomLeft) {
            TopRight = topLeft;
            TopLeft = topLeft;
            BottomRight = bottomRight;
            BottomLeft = bottomLeft;
        }
    }
}