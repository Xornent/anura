using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class HorizontalHeader : TableEntry {
        public const string _N = "hhea";

        public override string Name => "hhea";

        public uint Version {
            get;
            private set;
        }

        public short Ascent {
            get;
            private set;
        }

        public short Descent {
            get;
            private set;
        }

        public short LineGap {
            get;
            private set;
        }

        public ushort AdvancedWidthMax {
            get;
            private set;
        }

        public short MinLeftSideBearing {
            get;
            private set;
        }

        public short MinRightSideBearing {
            get;
            private set;
        }

        public short MaxXExtent {
            get;
            private set;
        }

        public short CaretSlopRise {
            get;
            private set;
        }

        public short CaretSlopRun {
            get;
            private set;
        }

        public short MatricDataFormat {
            get;
            private set;
        }

        public ushort HorizontalMetricsCount {
            get;
            private set;
        }

        protected override void ReadContentFrom (BinaryReader input) {
            Version = input.ReadUInt32 ();
            Ascent = input.ReadInt16 ();
            Descent = input.ReadInt16 ();
            LineGap = input.ReadInt16 ();
            AdvancedWidthMax = input.ReadUInt16 ();
            MinLeftSideBearing = input.ReadInt16 ();
            MinRightSideBearing = input.ReadInt16 ();
            MaxXExtent = input.ReadInt16 ();
            CaretSlopRise = input.ReadInt16 ();
            CaretSlopRun = input.ReadInt16 ();
            Reserved (input.ReadInt16 ());
            Reserved (input.ReadInt16 ());
            Reserved (input.ReadInt16 ());
            Reserved (input.ReadInt16 ());
            Reserved (input.ReadInt16 ());
            MatricDataFormat = input.ReadInt16 ();
            HorizontalMetricsCount = input.ReadUInt16 ();
        }

        private void Reserved (short zero) { }
    }
}