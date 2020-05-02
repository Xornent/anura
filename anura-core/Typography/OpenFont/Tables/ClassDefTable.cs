using System;
using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class ClassDefTable {
        internal struct ClassRangeRecord {
            public readonly ushort startGlyphId;

            public readonly ushort endGlyphId;

            public readonly ushort classNo;

            public ClassRangeRecord (ushort startGlyphId, ushort endGlyphId, ushort classNo) {
                this.startGlyphId = startGlyphId;
                this.endGlyphId = endGlyphId;
                this.classNo = classNo;
            }
        }

        public ushort startGlyph;

        public ushort[] classValueArray;

        public ClassRangeRecord[] records;

        public int Format {
            get;
            private set;
        }

        public static ClassDefTable CreateFrom (BinaryReader reader, long beginAt) {
            reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
            ClassDefTable classDefTable = new ClassDefTable ();
            switch (classDefTable.Format = reader.ReadUInt16 ()) {
                default : throw new NotSupportedException ();
                case 1:
                    {
                        classDefTable.startGlyph = reader.ReadUInt16 ();
                        ushort nRecords = reader.ReadUInt16 ();
                        classDefTable.classValueArray = Utils.ReadUInt16Array (reader, nRecords);
                        break;
                    }
                case 2:
                    {
                        ushort num2 = reader.ReadUInt16 ();
                        ClassRangeRecord[] array = new ClassRangeRecord[num2];
                        for (int i = 0; i < num2; i++) {
                            array[i] = new ClassRangeRecord (reader.ReadUInt16 (), reader.ReadUInt16 (), reader.ReadUInt16 ());
                        }
                        classDefTable.records = array;
                        break;
                    }
            }
            return classDefTable;
        }
    }
}