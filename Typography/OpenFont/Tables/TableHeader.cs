namespace Anura.Typography.OpenFont.Tables {
    internal class TableHeader {
        private readonly uint _tag;

        private readonly uint _checkSum;

        private readonly uint _offset;

        private readonly uint _length;

        private string _tagName;

        public string Tag => _tagName;

        public uint Offset => _offset;

        public uint CheckSum => _checkSum;

        public uint Length => _length;

        public TableHeader (uint tag, uint checkSum, uint offset, uint len) {
            _tag = tag;
            _checkSum = checkSum;
            _offset = offset;
            _length = len;
            _tagName = Utils.TagToString (_tag);
        }

        public TableHeader (string tag, uint checkSum, uint offset, uint len) {
            _tag = 0u;
            _checkSum = checkSum;
            _offset = offset;
            _length = len;
            _tagName = tag;
        }

        public override string ToString () {
            return "{" + Tag + "}";
        }
    }
}