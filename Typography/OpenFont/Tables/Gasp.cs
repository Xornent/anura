using System;
using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class Gasp : TableEntry {
        [Flags]
        private enum GaspRangeBehavior : ushort {
            Neither = 0x0,
            GASP_DOGRAY = 0x2,
            GASP_GRIDFIT = 0x1,
            GASP_DOGRAY_GASP_GRIDFIT = 0x3,
            GASP_SYMMETRIC_GRIDFIT = 0x4,
            GASP_SYMMETRIC_SMOOTHING = 0x8,
            GASP_SYMMETRIC_SMOOTHING_GASP_SYMMETRIC_GRIDFIT = 0xC
        }

        private struct GaspRangeRecord {
            public readonly ushort rangeMaxPPEM;

            public readonly GaspRangeBehavior rangeGaspBehavior;

            public GaspRangeRecord (ushort rangeMaxPPEM, GaspRangeBehavior rangeGaspBehavior) {
                this.rangeMaxPPEM = rangeMaxPPEM;
                this.rangeGaspBehavior = rangeGaspBehavior;
            }
        }

        public const string _N = "gasp";

        private GaspRangeRecord[] _rangeRecords;

        public override string Name => "gasp";

        protected override void ReadContentFrom (BinaryReader reader) {
            reader.ReadUInt16 ();
            ushort num = reader.ReadUInt16 ();
            _rangeRecords = new GaspRangeRecord[num];
            for (int i = 0; i < num; i++) {
                _rangeRecords[i] = new GaspRangeRecord (reader.ReadUInt16 (), (GaspRangeBehavior) reader.ReadUInt16 ());
            }
        }
    }
}