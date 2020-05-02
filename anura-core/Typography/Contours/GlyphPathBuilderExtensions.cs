namespace Anura.Typography.Contours {
    public static class GlyphPathBuilderExtensions {
        public static void Build (this GlyphPathBuilderBase builder, char c, float sizeInPoints) {
            builder.BuildFromGlyphIndex (builder.Typeface.LookupIndex (c), sizeInPoints);
        }

        public static void SetHintTechnique (this GlyphPathBuilderBase builder, HintTechnique hintTech) {
            builder.UseTrueTypeInstructions = false;
            builder.UseVerticalHinting = false;
            switch (hintTech) {
                case HintTechnique.TrueTypeInstruction:
                    builder.UseTrueTypeInstructions = true;
                    break;
                case HintTechnique.TrueTypeInstruction_VerticalOnly:
                    builder.UseTrueTypeInstructions = true;
                    builder.UseVerticalHinting = true;
                    break;
                case HintTechnique.CustomAutoFit:
                    builder.UseVerticalHinting = true;
                    break;
            }
        }
    }
}