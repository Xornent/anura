using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class BASE : TableEntry {
        public const string _N = "BASE";

        public override string Name => "BASE";

        protected override void ReadContentFrom (BinaryReader reader) { }
    }
}