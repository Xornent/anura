using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    public class CPAL : TableEntry {
        public const string _N = "CPAL";

        private byte[] _colorBGRABuffer;

        public override string Name => "CPAL";

        public ushort[] Palettes {
            get;
            private set;
        }

        public ushort ColorCount {
            get;
            private set;
        }

        protected override void ReadContentFrom (BinaryReader reader) {
            long position = reader.BaseStream.Position;
            reader.ReadUInt16 ();
            reader.ReadUInt16 ();
            ushort nRecords = reader.ReadUInt16 ();
            ColorCount = reader.ReadUInt16 ();
            uint num = reader.ReadUInt32 ();
            Palettes = Utils.ReadUInt16Array (reader, nRecords);
            reader.BaseStream.Seek (position + num, SeekOrigin.Begin);
            _colorBGRABuffer = reader.ReadBytes (4 * ColorCount);
        }

        public void GetColor (int colorIndex, out byte r, out byte g, out byte b, out byte a) {
            byte[] colorBGRABuffer = _colorBGRABuffer;
            int num = colorIndex * 4;
            b = colorBGRABuffer[num];
            g = colorBGRABuffer[num + 1];
            r = colorBGRABuffer[num + 2];
            a = colorBGRABuffer[num + 3];
        }
    }
}