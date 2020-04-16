namespace Anura.Typography.OpenFont.Tables {
    public interface IGlyphIndexList {
        int Count {
            get;
        }

        ushort this [int index] {
            get;
        }

        void Replace (int index, ushort newGlyphIndex);

        void Replace (int index, int removeLen, ushort newGlyphIndex);

        void Replace (int index, ushort[] newGlyphIndices);
    }
}