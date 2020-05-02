using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class LigCaretList {
        private LigGlyph[] _ligGlyphs;

        private CoverageTable _coverageTable;

        public static LigCaretList CreateFrom (BinaryReader reader, long beginAt) {
            reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
            LigCaretList ligCaretList = new LigCaretList ();
            ushort num = reader.ReadUInt16 ();
            ushort num2 = reader.ReadUInt16 ();
            ushort[] array = Utils.ReadUInt16Array (reader, num2);
            LigGlyph[] array2 = new LigGlyph[num2];
            for (int i = 0; i < num2; i++) {
                array2[i] = LigGlyph.CreateFrom (reader, beginAt + array[i]);
            }
            ligCaretList._ligGlyphs = array2;
            ligCaretList._coverageTable = CoverageTable.CreateFrom (reader, beginAt + num);
            return ligCaretList;
        }
    }
}