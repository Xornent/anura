using System.Collections.Generic;
using Anura.Typography.OpenFont.Tables;

namespace Anura.Typography.TextLayout {
    internal class GlyphIndexList : IGlyphIndexList {
        private struct GlyphIndexToUserCodePoint {
            public readonly ushort o_codepoint_charOffset;

            public readonly ushort len;

            public GlyphIndexToUserCodePoint (ushort o_user_charOffset, ushort len) {
                this.len = len;
                o_codepoint_charOffset = o_user_charOffset;
            }
        }

        private List<ushort> _glyphIndices = new List<ushort> ();

        private List<int> _inputCodePointIndexList = new List<int> ();

        private ushort _originalCodePointOffset;

        private List<GlyphIndexToUserCodePoint> _mapGlyphIndexToUserCodePoint = new List<GlyphIndexToUserCodePoint> ();

        public int Count => _glyphIndices.Count;

        public ushort this [int index] {
            get {
                return _glyphIndices[index];
            }
        }

        public void Clear () {
            _glyphIndices.Clear ();
            _originalCodePointOffset = 0;
            _inputCodePointIndexList.Clear ();
            _mapGlyphIndexToUserCodePoint.Clear ();
        }

        public void AddGlyph (int codePointIndex, ushort glyphIndex) {
            _inputCodePointIndexList.Add (codePointIndex);
            _glyphIndices.Add (glyphIndex);
            GlyphIndexToUserCodePoint item = new GlyphIndexToUserCodePoint (_originalCodePointOffset, 1);
            _mapGlyphIndexToUserCodePoint.Add (item);
            _originalCodePointOffset++;
        }

        public void GetGlyphIndexAndMap (int index, out ushort glyphIndex, out ushort input_codepointOffset, out ushort input_mapLen) {
            glyphIndex = _glyphIndices[index];
            GlyphIndexToUserCodePoint glyphIndexToUserCodePoint = _mapGlyphIndexToUserCodePoint[index];
            input_codepointOffset = glyphIndexToUserCodePoint.o_codepoint_charOffset;
            input_mapLen = glyphIndexToUserCodePoint.len;
        }

        public void Replace (int index, ushort newGlyphIndex) {
            _glyphIndices[index] = newGlyphIndex;
        }

        public void Replace (int index, int removeLen, ushort newGlyphIndex) {
            _glyphIndices.RemoveRange (index, removeLen);
            _glyphIndices.Insert (index, newGlyphIndex);
            GlyphIndexToUserCodePoint glyphIndexToUserCodePoint = _mapGlyphIndexToUserCodePoint[index];
            GlyphIndexToUserCodePoint item = new GlyphIndexToUserCodePoint (glyphIndexToUserCodePoint.o_codepoint_charOffset, (ushort) removeLen);
            _mapGlyphIndexToUserCodePoint.RemoveRange (index, removeLen);
            _mapGlyphIndexToUserCodePoint.Insert (index, item);
        }

        public void Replace (int index, ushort[] newGlyphIndices) {
            _glyphIndices.RemoveAt (index);
            _glyphIndices.InsertRange (index, newGlyphIndices);
            GlyphIndexToUserCodePoint glyphIndexToUserCodePoint = _mapGlyphIndexToUserCodePoint[index];
            _mapGlyphIndexToUserCodePoint.RemoveAt (index);
            int num = newGlyphIndices.Length;
            for (int i = 0; i < num; i++) {
                GlyphIndexToUserCodePoint item = new GlyphIndexToUserCodePoint (glyphIndexToUserCodePoint.o_codepoint_charOffset, 1);
                _mapGlyphIndexToUserCodePoint.Insert (index, item);
            }
        }

        public void CreateMapFromUserCodePointToGlyphIndices (List<UserCodePointToGlyphIndex> mapUserCodePointToGlyphIndex) {
            int count = _inputCodePointIndexList.Count;
            for (int i = 0; i < count; i++) {
                UserCodePointToGlyphIndex item = default (UserCodePointToGlyphIndex);
                item.userCodePointIndex = _inputCodePointIndexList[i];
                mapUserCodePointToGlyphIndex.Add (item);
            }
            int count2 = _glyphIndices.Count;
            for (int j = 0; j < count2; j++) {
                GlyphIndexToUserCodePoint glyphIndexToUserCodePoint = _mapGlyphIndexToUserCodePoint[j];
                UserCodePointToGlyphIndex value = mapUserCodePointToGlyphIndex[glyphIndexToUserCodePoint.o_codepoint_charOffset];
                value.AppendData ((ushort) (j + 1), glyphIndexToUserCodePoint.len);
                mapUserCodePointToGlyphIndex[glyphIndexToUserCodePoint.o_codepoint_charOffset] = value;
            }
        }
    }
}