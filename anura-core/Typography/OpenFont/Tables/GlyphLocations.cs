using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class GlyphLocations : TableEntry {
        public const string _N = "loca";

        private uint[] _offsets;

        public override string Name => "loca";

        public bool IsLongVersion {
            get;
            private set;
        }

        public uint[] Offsets => _offsets;

        public int GlyphCount => _offsets.Length - 1;

        public GlyphLocations (int glyphCount, bool isLongVersion) {
            _offsets = new uint[glyphCount + 1];
            IsLongVersion = isLongVersion;
        }

        protected override void ReadContentFrom (BinaryReader reader) {
            int num = GlyphCount + 1;
            _offsets = new uint[num];
            if (IsLongVersion) {
                for (int i = 0; i < num; i++) {
                    _offsets[i] = reader.ReadUInt32 ();
                }
            } else {
                for (int j = 0; j < num; j++) {
                    _offsets[j] = (uint) (reader.ReadUInt16 () << 1);
                }
            }
        }
    }
}