using System.IO;
using Anura.Typography.OpenFont.MathGlyphs;

namespace Anura.Typography.OpenFont.Tables {
    internal static class MathValueRecordReaderHelper {
        public static MathValueRecord ReadMathValueRecord (this BinaryReader reader) {
            return new MathValueRecord (reader.ReadInt16 (), reader.ReadUInt16 ());
        }

        public static MathValueRecord[] ReadMathValueRecords (this BinaryReader reader, int count) {
            MathValueRecord[] array = new MathValueRecord[count];
            for (int i = 0; i < count; i++) {
                array[i] = reader.ReadMathValueRecord ();
            }
            return array;
        }
    }
}