namespace Anura.Typography.WebFont {
    internal class WoffHeader {
        public uint flavor;

        public uint length;

        public uint numTables;

        public uint totalSfntSize;

        public ushort majorVersion;

        public ushort minorVersion;

        public uint metaOffset;

        public uint metaLength;

        public uint metaOriginalLength;

        public uint privOffset;

        public uint privLength;
    }
}