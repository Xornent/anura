using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class PrepTable : TableEntry {
        public const string _N = "prep";

        internal byte[] _programBuffer;

        public override string Name => "prep";

        protected override void ReadContentFrom (BinaryReader reader) {
            _programBuffer = reader.ReadBytes ((int) base.TableLength);
        }
    }
}