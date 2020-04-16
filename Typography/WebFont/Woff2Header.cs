namespace Anura.Typography.WebFont {
    internal class Woff2Header {
        public uint flavor;

        public uint length;

        public uint numTables;

        public uint totalSfntSize;

        public uint totalCompressSize;

        public ushort majorVersion;

        public ushort minorVersion;

        public uint metaOffset;

        public uint metaLength;

        public uint metaOriginalLength;

        public uint privOffset;

        public uint privLength;
    }
}