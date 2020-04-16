using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class LigGlyph {
        private ushort[] _caretValueOffsets;

        public static LigGlyph CreateFrom (BinaryReader reader, long beginAt) {
            reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
            LigGlyph ligGlyph = new LigGlyph ();
            ushort nRecords = reader.ReadUInt16 ();
            ligGlyph._caretValueOffsets = Utils.ReadUInt16Array (reader, nRecords);
            return ligGlyph;
        }
    }
}