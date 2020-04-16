namespace Anura.Typography.TextLayout {
    internal struct GlyphLayoutPlanContext {
        public readonly GlyphSubstitution _glyphSub;

        public readonly GlyphSetPosition _glyphPos;

        public GlyphLayoutPlanContext (GlyphSubstitution glyphSub, GlyphSetPosition glyphPos) {
            _glyphSub = glyphSub;
            _glyphPos = glyphPos;
        }
    }
}