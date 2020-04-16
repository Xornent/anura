using Anura.Typography.OpenFont;

namespace Anura.Typography.TextLayout {
    internal struct GlyphLayoutPlanKey {
        public Typeface t;

        public int scriptInternameName;

        public GlyphLayoutPlanKey (Typeface t, int scriptInternameName) {
            this.t = t;
            this.scriptInternameName = scriptInternameName;
        }
    }
}