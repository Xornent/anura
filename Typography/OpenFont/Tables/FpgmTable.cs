using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class FpgmTable : TableEntry {
        public const string _N = "fpgm";

        internal byte[] _programBuffer;

        public override string Name => "fpgm";

        protected override void ReadContentFrom (BinaryReader reader) {
            _programBuffer = reader.ReadBytes ((int) base.TableLength);
        }
    }
}