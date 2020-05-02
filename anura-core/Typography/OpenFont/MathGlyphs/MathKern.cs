namespace Anura.Typography.OpenFont.MathGlyphs {
    public class MathKern {
        public ushort HeightCount;

        public MathValueRecord[] CorrectionHeights;

        public MathValueRecord[] KernValues;

        public MathKern (ushort heightCount, MathValueRecord[] correctionHeights, MathValueRecord[] kernValues) {
            HeightCount = heightCount;
            CorrectionHeights = correctionHeights;
            KernValues = kernValues;
        }
    }
}