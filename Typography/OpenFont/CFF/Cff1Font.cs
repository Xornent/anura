using System.Collections.Generic;

namespace Anura.Typography.OpenFont.CFF {
    public class Cff1Font {
        internal Glyph[] _glyphs;

        internal List<CffDataDicEntry> _privateDict;

        internal List<Type2GlyphInstructionList> _localSubrs;

        internal int _defaultWidthX;

        internal int _nominalWidthX;

        private Dictionary<string, Glyph> _cachedGlyphDicByName;

        internal string FontName {
            get;
            set;
        }

        public Glyph GetGlyphByName (string name) {
            if (_cachedGlyphDicByName == null) {
                _cachedGlyphDicByName = new Dictionary<string, Glyph> ();
                int num = _glyphs.Length;
                for (int i = 1; i < num; i++) {
                    Glyph glyph = _glyphs[i];
                    _cachedGlyphDicByName.Add (glyph._cff1GlyphData.Name, glyph);
                }
            }
            _cachedGlyphDicByName.TryGetValue (name, out Glyph value);
            return value;
        }

        internal IEnumerable<GlyphNameMap> GetGlyphNameIter () {
            int j = _glyphs.Length;
            int num;
            for (int i = 1; i < j; i = num) {
                Glyph glyph = _glyphs[i];
                yield return new GlyphNameMap ((ushort) i, glyph._cff1GlyphData.Name);
                num = i + 1;
            }
        }
    }
}