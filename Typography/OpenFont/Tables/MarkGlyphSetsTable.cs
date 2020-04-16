using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class MarkGlyphSetsTable {
        private ushort _format;

        private uint[] _coverageOffset;

        public static MarkGlyphSetsTable CreateFrom (BinaryReader reader, long beginAt) {
            reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
            MarkGlyphSetsTable markGlyphSetsTable = new MarkGlyphSetsTable ();
            markGlyphSetsTable._format = reader.ReadUInt16 ();
            ushort num = reader.ReadUInt16 ();
            uint[] array = markGlyphSetsTable._coverageOffset = new uint[num];
            for (int i = 0; i < num; i++) {
                array[i] = reader.ReadUInt32 ();
            }
            return markGlyphSetsTable;
        }
    }
}