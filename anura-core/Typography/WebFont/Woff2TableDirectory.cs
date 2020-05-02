namespace Anura.Typography.WebFont {
    internal class Woff2TableDirectory {
        public uint origLength;

        public uint transformLength;

        public string Name {
            get;
            set;
        }

        public byte PreprocessingTransformation {
            get;
            set;
        }

        public long ExpectedStartAt {
            get;
            set;
        }
    }
}