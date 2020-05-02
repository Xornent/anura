using System;
using System.IO;

namespace Anura.Typography.OpenFont.CFF {
    internal static class CFFBinaryReaderExtension {
        public static int ReadOffset (this BinaryReader reader, int offsetSize) {
            switch (offsetSize) {
                default : throw new NotSupportedException ();
                case 1:
                        return reader.ReadByte ();
                case 2:
                        return (reader.ReadByte () << 8) | reader.ReadByte ();
                case 3:
                        return (reader.ReadByte () << 16) | (reader.ReadByte () << 8) | reader.ReadByte ();
                case 4:
                        return (reader.ReadByte () << 24) | (reader.ReadByte () << 16) | (reader.ReadByte () << 8) | reader.ReadByte ();
            }
        }
    }
}