using System.Collections.Generic;
using Anura.Typography.OpenFont;

namespace Anura.Typography.Contours {
    public class GlyphMeshCollection<T> {
        private struct GlyphKey {
            public HintTechnique hintTech;

            public Typeface typeface;

            public float sizeInPts;
        }

        private Dictionary<ushort, T> _currentGlyphDic;

        private Dictionary<GlyphKey, Dictionary<ushort, T>> _registerGlyphCollection = new Dictionary<GlyphKey, Dictionary<ushort, T>> ();

        private List<GlyphKey> _tempKeys = new List<GlyphKey> ();

        public void SetCacheInfo (Typeface typeface, float sizeInPts, HintTechnique hintTech) {
            GlyphKey glyphKey = default (GlyphKey);
            glyphKey.hintTech = hintTech;
            glyphKey.sizeInPts = sizeInPts;
            glyphKey.typeface = typeface;
            GlyphKey key = glyphKey;
            if (!_registerGlyphCollection.TryGetValue (key, out _currentGlyphDic)) {
                _currentGlyphDic = new Dictionary<ushort, T> ();
                _registerGlyphCollection.Add (key, _currentGlyphDic);
            }
        }

        public bool TryGetCacheGlyph (ushort glyphIndex, out T vxs) {
            return _currentGlyphDic.TryGetValue (glyphIndex, out vxs);
        }

        public void RegisterCachedGlyph (ushort glyphIndex, T vxs) {
            _currentGlyphDic[glyphIndex] = vxs;
        }

        public void ClearAll () {
            _currentGlyphDic = null;
            _registerGlyphCollection.Clear ();
        }

        public void Clear (Typeface typeface) {
            _tempKeys.Clear ();
            foreach (GlyphKey key in _registerGlyphCollection.Keys) {
                if (key.typeface == typeface) {
                    _tempKeys.Add (key);
                }
            }
            for (int num = _tempKeys.Count - 1; num >= 0; num--) {
                _registerGlyphCollection.Remove (_tempKeys[num]);
            }
            _tempKeys.Clear ();
        }
    }
}