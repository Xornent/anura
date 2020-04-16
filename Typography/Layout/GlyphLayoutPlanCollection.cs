using System.Collections.Generic;
using Anura.Typography.OpenFont;

namespace Anura.Typography.TextLayout {
    internal class GlyphLayoutPlanCollection {
        private Dictionary<GlyphLayoutPlanKey, GlyphLayoutPlanContext> _collection = new Dictionary<GlyphLayoutPlanKey, GlyphLayoutPlanContext> ();

        public GlyphLayoutPlanContext GetPlanOrCreate (Typeface typeface, ScriptLang scriptLang) {
            GlyphLayoutPlanKey glyphLayoutPlanKey = new GlyphLayoutPlanKey (typeface, scriptLang.internalName);
            if (!_collection.TryGetValue (glyphLayoutPlanKey, out GlyphLayoutPlanContext value)) {
                GlyphSubstitution glyphSub = (typeface.GSUBTable != null) ? new GlyphSubstitution (typeface, scriptLang.shortname) : null;
                GlyphSetPosition glyphPos = (typeface.GPOSTable != null) ? new GlyphSetPosition (typeface, scriptLang.shortname) : null;
                Dictionary<GlyphLayoutPlanKey, GlyphLayoutPlanContext> collection = _collection;
                GlyphLayoutPlanKey key = glyphLayoutPlanKey;
                value = new GlyphLayoutPlanContext (glyphSub, glyphPos);
                collection.Add (key, value);
            }
            return value;
        }
    }
}