namespace Anura.Typography.WebFont {
    internal class WoffTableDirectory {
        public uint tag;

        public uint offset;

        public uint compLength;

        public uint origLength;

        public uint origChecksum;

        public string Name {
            get;
            set;
        }

        public long ExpectedStartAt {
            get;
            set;
        }
    }
}