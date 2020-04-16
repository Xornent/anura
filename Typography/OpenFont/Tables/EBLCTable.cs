using System;
using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class EBLCTable : TableEntry {
        private struct BitmapSizeTable {
            public uint SubTableOffset;

            public uint SubTableSize;

            public uint SubTableCount;

            public ushort startGlyph;

            public ushort endGlyph;

            public byte PpemX;

            public byte PpemY;

            public byte BitDepth;

            public BitmapSizeFlags Flags;
        }

        private struct IndexSubTable {
            public ushort FirstGlyph;

            public ushort LastGlyph;

            public uint Offset;
        }

        [Flags]
        private enum BitmapSizeFlags {
            None = 0x0,
            Horizontal = 0x1,
            Vertical = 0x2
        }

        public const string _N = "EBLC";

        private const int MAX_BITMAP_STRIKES = 1024;

        public override string Name => "EBLC";

        protected override void ReadContentFrom (BinaryReader reader) {
            int num = (int) reader.BaseStream.Position;
            reader.ReadUInt16 ();
            reader.ReadUInt16 ();
            uint num2 = reader.ReadUInt32 ();
            if (num2 > 1024) {
                throw new Exception ("Too many bitmap strikes in font.");
            }
            BitmapSizeTable[] array = new BitmapSizeTable[num2];
            for (int i = 0; i < num2; i++) {
                BitmapSizeTable bitmapSizeTable = default (BitmapSizeTable);
                bitmapSizeTable.SubTableOffset = reader.ReadUInt32 ();
                bitmapSizeTable.SubTableSize = reader.ReadUInt32 ();
                bitmapSizeTable.SubTableCount = reader.ReadUInt32 ();
                reader.ReadUInt32 ();
                reader.BaseStream.Position += 24L;
                bitmapSizeTable.startGlyph = reader.ReadUInt16 ();
                bitmapSizeTable.endGlyph = reader.ReadUInt16 ();
                bitmapSizeTable.PpemX = reader.ReadByte ();
                bitmapSizeTable.PpemY = reader.ReadByte ();
                bitmapSizeTable.BitDepth = reader.ReadByte ();
                bitmapSizeTable.Flags = (BitmapSizeFlags) reader.ReadByte ();
                array[i] = bitmapSizeTable;
            }
            IndexSubTable[] array2 = new IndexSubTable[num2];
            for (int j = 0; j < num2; j++) {
                reader.BaseStream.Seek (num + array[j].SubTableOffset, SeekOrigin.Begin);
                array2[j] = new IndexSubTable {
                    FirstGlyph = reader.ReadUInt16 (),
                    LastGlyph = reader.ReadUInt16 (),
                    Offset = reader.ReadUInt32 ()
                };
            }
            for (int k = 0; k < num2; k++) {
                reader.BaseStream.Seek (num + array[k].SubTableOffset + array2[k].Offset, SeekOrigin.Begin);
                reader.ReadUInt16 ();
                reader.ReadUInt16 ();
                reader.ReadUInt32 ();
            }
        }
    }
}