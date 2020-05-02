using System.IO;
using Anura.Typography.OpenFont;
using Anura.Typography.OpenFont.IO;
using Anura.Typography.OpenFont.Tables;

namespace Anura.Typography.WebFont {
    internal class WoffReader {
        private WoffHeader _header;

        public ZlibDecompressStreamFunc DecompressHandler;

        public PreviewFontInfo ReadPreview (BinaryReader reader) {
            PreviewFontInfo result = null;
            _header = ReadWOFFHeader (reader);
            if (_header == null) {
                return null;
            }
            WoffTableDirectory[] array = ReadTableDirectories (reader);
            if (array == null) {
                return null;
            }
            if (DecompressHandler == null) {
                if (WoffDefaultZlibDecompressFunc.DecompressHandler == null) {
                    return null;
                }
                DecompressHandler = WoffDefaultZlibDecompressFunc.DecompressHandler;
            }
            TableEntryCollection tables = CreateTableEntryCollection (array);
            using (MemoryStream memoryStream = new MemoryStream ()) {
                if (Extract (reader, array, memoryStream)) {
                    using (ByteOrderSwappingBinaryReader input = new ByteOrderSwappingBinaryReader (memoryStream)) {
                        memoryStream.Position = 0L;
                        PreviewFontInfo previewFontInfo = new OpenFontReader ().ReadPreviewFontInfo (tables, input);
                        if (previewFontInfo != null) {
                            previewFontInfo.IsWebFont = true;
                        }
                        return previewFontInfo;
                    }
                }
                return result;
            }
        }

        internal Typeface Read (BinaryReader reader) {
            _header = ReadWOFFHeader (reader);
            if (_header == null) {
                return null;
            }
            WoffTableDirectory[] array = ReadTableDirectories (reader);
            if (array == null) {
                return null;
            }
            if (DecompressHandler == null) {
                if (WoffDefaultZlibDecompressFunc.DecompressHandler == null) {
                    return null;
                }
                DecompressHandler = WoffDefaultZlibDecompressFunc.DecompressHandler;
            }
            TableEntryCollection tables = CreateTableEntryCollection (array);
            using (MemoryStream memoryStream = new MemoryStream ()) {
                if (Extract (reader, array, memoryStream)) {
                    using (ByteOrderSwappingBinaryReader input = new ByteOrderSwappingBinaryReader (memoryStream)) {
                        memoryStream.Position = 0L;
                        return new OpenFontReader ().ReadTableEntryCollection (tables, input);
                    }
                }
            }
            return null;
        }

        public Typeface Read (Stream inputStream) {
            using (ByteOrderSwappingBinaryReader reader = new ByteOrderSwappingBinaryReader (inputStream)) {
                return Read (reader);
            }
        }

        private static TableEntryCollection CreateTableEntryCollection (WoffTableDirectory[] woffTableDirs) {
            TableEntryCollection tableEntryCollection = new TableEntryCollection ();
            foreach (WoffTableDirectory woffTableDirectory in woffTableDirs) {
                tableEntryCollection.AddEntry (new UnreadTableEntry (new TableHeader (woffTableDirectory.tag, woffTableDirectory.origChecksum, (uint) woffTableDirectory.ExpectedStartAt, woffTableDirectory.origLength)));
            }
            return tableEntryCollection;
        }

        private static WoffHeader ReadWOFFHeader (BinaryReader reader) {
            byte num = reader.ReadByte ();
            byte b = reader.ReadByte ();
            byte b2 = reader.ReadByte ();
            byte b3 = reader.ReadByte ();
            if (num != 119 || b != 79 || b2 != 70 || b3 != 70) {
                return null;
            }
            WoffHeader obj = new WoffHeader {
                flavor = reader.ReadUInt32 (),
                length = reader.ReadUInt32 (),
                numTables = reader.ReadUInt16 ()
            };
            reader.ReadUInt16 ();
            obj.totalSfntSize = reader.ReadUInt32 ();
            obj.majorVersion = reader.ReadUInt16 ();
            obj.minorVersion = reader.ReadUInt16 ();
            obj.metaOffset = reader.ReadUInt32 ();
            obj.metaLength = reader.ReadUInt32 ();
            obj.metaOriginalLength = reader.ReadUInt32 ();
            obj.privOffset = reader.ReadUInt32 ();
            obj.privLength = reader.ReadUInt32 ();
            return obj;
        }

        private WoffTableDirectory[] ReadTableDirectories (BinaryReader reader) {
            uint numTables = _header.numTables;
            long num = 0L;
            WoffTableDirectory[] array = new WoffTableDirectory[numTables];
            for (int i = 0; i < numTables; i++) {
                WoffTableDirectory woffTableDirectory = new WoffTableDirectory ();
                woffTableDirectory.tag = reader.ReadUInt32 ();
                woffTableDirectory.offset = reader.ReadUInt32 ();
                woffTableDirectory.compLength = reader.ReadUInt32 ();
                woffTableDirectory.origLength = reader.ReadUInt32 ();
                woffTableDirectory.origChecksum = reader.ReadUInt32 ();
                woffTableDirectory.ExpectedStartAt = num;
                woffTableDirectory.Name = Utils.TagToString (woffTableDirectory.tag);
                array[i] = woffTableDirectory;
                num += woffTableDirectory.origLength;
            }
            return array;
        }

        private bool Extract (BinaryReader reader, WoffTableDirectory[] tables, Stream newDecompressedStream) {
            foreach (WoffTableDirectory woffTableDirectory in tables) {
                reader.BaseStream.Seek (woffTableDirectory.offset, SeekOrigin.Begin);
                byte[] array = reader.ReadBytes ((int) woffTableDirectory.compLength);
                if (array.Length == woffTableDirectory.origLength) {
                    newDecompressedStream.Write (array, 0, array.Length);
                    continue;
                }
                byte[] array2 = new byte[woffTableDirectory.origLength];
                if (!DecompressHandler (array, array2)) {
                    array2 = null;
                } else {
                    newDecompressedStream.Write (array2, 0, array2.Length);
                }
            }
            newDecompressedStream.Flush ();
            return true;
        }
    }
}