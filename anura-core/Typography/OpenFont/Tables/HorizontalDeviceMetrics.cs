using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class HorizontalDeviceMetrics : TableEntry {
        public const string _N = "hdmx";

        public override string Name => "hdmx";

        protected override void ReadContentFrom (BinaryReader reader) { }
    }
}