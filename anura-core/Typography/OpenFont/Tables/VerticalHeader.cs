using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class VerticalHeader : TableEntry {
        public const string _N = "vhea";

        public override string Name => "vhea";

        public byte VersionMajor {
            get;
            set;
        }

        public byte VersionMinor {
            get;
            set;
        }

        public short VertTypoAscender {
            get;
            set;
        }

        public short VertTypoDescender {
            get;
            set;
        }

        public short VertTypoLineGap {
            get;
            set;
        }

        public short AdvanceHeightMax {
            get;
            set;
        }

        public short MinTopSideBearing {
            get;
            set;
        }

        public short MinBottomSideBearing {
            get;
            set;
        }

        public short YMaxExtend {
            get;
            set;
        }

        public short CaretSlopeRise {
            get;
            set;
        }

        public short CaretSlopeRun {
            get;
            set;
        }

        public short CaretOffset {
            get;
            set;
        }

        public ushort NumOfLongVerMetrics {
            get;
            set;
        }

        protected override void ReadContentFrom (BinaryReader reader) {
            uint num = reader.ReadUInt32 ();
            VersionMajor = (byte) (num >> 16);
            VersionMinor = (byte) (num >> 8);
            VertTypoAscender = reader.ReadInt16 ();
            VertTypoDescender = reader.ReadInt16 ();
            VertTypoLineGap = reader.ReadInt16 ();
            AdvanceHeightMax = reader.ReadInt16 ();
            MinTopSideBearing = reader.ReadInt16 ();
            MinBottomSideBearing = reader.ReadInt16 ();
            YMaxExtend = reader.ReadInt16 ();
            CaretSlopeRise = reader.ReadInt16 ();
            CaretSlopeRun = reader.ReadInt16 ();
            CaretOffset = reader.ReadInt16 ();
            reader.BaseStream.Position += 10L;
            NumOfLongVerMetrics = reader.ReadUInt16 ();
        }
    }
}