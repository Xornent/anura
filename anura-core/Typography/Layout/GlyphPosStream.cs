using System.Collections.Generic;
using Anura.Typography.OpenFont;

namespace Anura.Typography.TextLayout {
    internal class GlyphPosStream : IGlyphPositions {
        private List<GlyphPos> _glyphPosList = new List<GlyphPos> ();

        private Typeface _typeface;

        public int Count => _glyphPosList.Count;

        public Typeface Typeface {
            get {
                return _typeface;
            }
            set {
                _typeface = value;
            }
        }

        public GlyphPos this [int index] {
            get {
                return _glyphPosList[index];
            }
        }

        public void Clear () {
            _typeface = null;
            _glyphPosList.Clear ();
        }

        public void AddGlyph (ushort o_offset, ushort glyphIndex, Glyph glyph) {
            if (!glyph.HasOriginalAdvancedWidth) {
                glyph.OriginalAdvanceWidth = _typeface.GetHAdvanceWidthFromGlyphIndex (glyphIndex);
            }
            _glyphPosList.Add (new GlyphPos (o_offset, glyphIndex, glyph.GlyphClass, glyph.OriginalAdvanceWidth));
        }

        public GlyphClassKind GetGlyphClassKind (int index) {
            return _glyphPosList[index].classKind;
        }

        public ushort GetGlyph (int index, out ushort advW) {
            GlyphPos glyphPos = _glyphPosList[index];
            advW = (ushort) glyphPos.advanceW;
            return glyphPos.glyphIndex;
        }

        public ushort GetGlyph (int index, out ushort inputOffset, out short offsetX, out short offsetY, out short advW) {
            GlyphPos glyphPos = _glyphPosList[index];
            offsetX = glyphPos.xoffset;
            offsetY = glyphPos.yoffset;
            advW = glyphPos.advanceW;
            inputOffset = glyphPos.o_offset;
            return glyphPos.glyphIndex;
        }

        public void GetOffset (int index, out short offsetX, out short offsetY) {
            GlyphPos glyphPos = _glyphPosList[index];
            offsetX = glyphPos.xoffset;
            offsetY = glyphPos.yoffset;
        }

        public void AppendGlyphOffset (int index, short appendOffsetX, short appendOffsetY) {
            GlyphPos value = _glyphPosList[index];
            value.xoffset += appendOffsetX;
            value.yoffset += appendOffsetY;
            _glyphPosList[index] = value;
        }

        public void AppendGlyphAdvance (int index, short appendAdvX, short appendAdvY) {
            GlyphPos value = _glyphPosList[index];
            value.advanceW += appendAdvX;
            _glyphPosList[index] = value;
        }
    }
}