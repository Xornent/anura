using System.IO;

namespace Anura.Typography.WebFont {
    internal class Woff2Utils {
        private const byte ONE_MORE_BYTE_CODE1 = byte.MaxValue;

        private const byte ONE_MORE_BYTE_CODE2 = 254;

        private const byte WORD_CODE = 253;

        private const byte LOWEST_UCODE = 253;

        public static short[] ReadInt16Array (BinaryReader reader, int count) {
            short[] array = new short[count];
            for (int i = 0; i < count; i++) {
                array[i] = reader.ReadInt16 ();
            }
            return array;
        }

        public static ushort Read255UInt16 (BinaryReader reader) {
            byte b = reader.ReadByte ();
            switch (b) {
                case 253:
                    {
                        int num = (reader.ReadByte () << 8) & 0xFF00;
                        int num2 = reader.ReadByte ();
                        return (ushort) (num | (num2 & 0xFF));
                    }
                case byte.MaxValue:
                    return (ushort) (reader.ReadByte () + 253);
                case 254:
                    return (ushort) (reader.ReadByte () + 506);
                default:
                    return b;
            }
        }
    }
}