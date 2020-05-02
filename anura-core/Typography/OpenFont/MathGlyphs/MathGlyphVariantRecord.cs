namespace Anura.Typography.OpenFont.MathGlyphs {
    public struct MathGlyphVariantRecord {
        public ushort VariantGlyph;

        public ushort AdvanceMeasurement;

        public MathGlyphVariantRecord (ushort variantGlyph, ushort advanceMeasurement) {
            VariantGlyph = variantGlyph;
            AdvanceMeasurement = advanceMeasurement;
        }
    }
}