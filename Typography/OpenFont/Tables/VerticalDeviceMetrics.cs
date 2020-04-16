using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class VerticalDeviceMetrics : TableEntry {
        private struct Ratio {
            public readonly byte charset;

            public readonly byte xRatio;

            public readonly byte yStartRatio;

            public readonly byte yEndRatio;

            public Ratio (byte charset, byte xRatio, byte yStartRatio, byte yEndRatio) {
                this.charset = charset;
                this.xRatio = xRatio;
                this.yStartRatio = yStartRatio;
                this.yEndRatio = yEndRatio;
            }
        }

        public const string _N = "VDMX";

        private Ratio[] _ratios;

        public override string Name => "VDMX";

        protected override void ReadContentFrom (BinaryReader reader) {
            reader.ReadUInt16 ();
            reader.ReadUInt16 ();
            ushort num = reader.ReadUInt16 ();
            _ratios = new Ratio[num];
            for (int i = 0; i < num; i++) {
                _ratios[i] = new Ratio (reader.ReadByte (), reader.ReadByte (), reader.ReadByte (), reader.ReadByte ());
            }
            Utils.ReadUInt16Array (reader, num);
        }
    }
}