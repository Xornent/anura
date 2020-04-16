namespace Anura.Typography.OpenFont {
    public interface IGlyphPositions {
        int Count {
            get;
        }

        GlyphClassKind GetGlyphClassKind (int index);

        void AppendGlyphOffset (int index, short appendOffsetX, short appendOffsetY);

        void AppendGlyphAdvance (int index, short appendAdvX, short appendAdvY);

        ushort GetGlyph (int index, out ushort advW);

        ushort GetGlyph (int index, out ushort inputOffset, out short offsetX, out short offsetY, out short advW);

        void GetOffset (int index, out short offsetX, out short offsetY);
    }
}