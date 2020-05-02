using Anura.Typography.OpenFont;

namespace Anura.Typography.TextLayout {
    internal struct GlyphPos {
        public readonly ushort o_offset;

        public readonly ushort glyphIndex;

        public short xoffset;

        public short yoffset;

        public short advanceW;

        public readonly GlyphClassKind glyphClass;

        public GlyphClassKind classKind => glyphClass;

        public short OffsetX => xoffset;

        public short OffsetY => yoffset;

        public GlyphPos (ushort o_offset, ushort glyphIndex, GlyphClassKind glyphClass, ushort orgAdvanced) {
            this.o_offset = o_offset;
            this.glyphClass = glyphClass;
            this.glyphIndex = glyphIndex;
            advanceW = (short) orgAdvanced;
            xoffset = (yoffset = 0);
        }
    }
}