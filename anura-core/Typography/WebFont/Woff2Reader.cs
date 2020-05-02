using System.IO;
using Anura.Typography.OpenFont;
using Anura.Typography.OpenFont.IO;
using Anura.Typography.OpenFont.Tables;

namespace Anura.Typography.WebFont {
    internal class Woff2Reader {
        private Woff2Header _header;

        public BrotliDecompressStreamFunc DecompressHandler;

        private static readonly string[] s_knownTableTags = new string[64] {
            "cmap",
            "head",
            "hhea",
            "hmtx",
            "maxp",
            "name",
            "OS/2",
            "post",
            "cvt ",
            "fpgm",
            "glyf",
            "loca",
            "prep",
            "CFF ",
            "VORG",
            "EBDT",
            "EBLC",
            "gasp",
            "hdmx",
            "kern",
            "LTSH",
            "PCLT",
            "VDMX",
            "vhea",
            "vmtx",
            "BASE",
            "GDEF",
            "GPOS",
            "GSUB",
            "EBSC",
            "JSTF",
            "MATH",
            "CBDT",
            "CBLC",
            "COLR",
            "CPAL",
            "SVG ",
            "sbix",
            "acnt",
            "avar",
            "bdat",
            "bloc",
            "bsln",
            "cvar",
            "fdsc",
            "feat",
            "fmtx",
            "fvar",
            "gvar",
            "hsty",
            "just",
            "lcar",
            "mort",
            "morx",
            "opbd",
            "prop",
            "trak",
            "Zapf",
            "Silf",
            "Glat",
            "Gloc",
            "Feat",
            "Sill",
            "...."
        };

        public PreviewFontInfo ReadPreview (BinaryReader reader) {
            _header = ReadHeader (reader);
            if (_header == null) {
                return null;
            }
            Woff2TableDirectory[] woffTableDirs = ReadTableDirectories (reader);
            if (DecompressHandler == null) {
                if (Woff2DefaultBrotliDecompressFunc.DecompressHandler == null) {
                    return null;
                }
                DecompressHandler = Woff2DefaultBrotliDecompressFunc.DecompressHandler;
            }
            byte[] array = reader.ReadBytes ((int) _header.totalCompressSize);
            if (array.Length != _header.totalCompressSize) {
                return null;
            }
            using (MemoryStream memoryStream = new MemoryStream ()) {
                if (DecompressHandler (array, memoryStream)) {
                    memoryStream.Position = 0L;
                    using (ByteOrderSwappingBinaryReader input = new ByteOrderSwappingBinaryReader (memoryStream)) {
                        TableEntryCollection tables = CreateTableEntryCollection (woffTableDirs);
                        return new OpenFontReader ().ReadPreviewFontInfo (tables, input);
                    }
                }
                return null;
            }
        }

        internal Typeface Read (BinaryReader reader) {
            _header = ReadHeader (reader);
            if (_header == null) {
                return null;
            }
            Woff2TableDirectory[] woffTableDirs = ReadTableDirectories (reader);
            if (DecompressHandler == null) {
                if (Woff2DefaultBrotliDecompressFunc.DecompressHandler == null) {
                    return null;
                }
                DecompressHandler = Woff2DefaultBrotliDecompressFunc.DecompressHandler;
            }
            byte[] array = reader.ReadBytes ((int) _header.totalCompressSize);
            if (array.Length != _header.totalCompressSize) {
                return null;
            }
            using (MemoryStream memoryStream = new MemoryStream ()) {
                if (DecompressHandler (array, memoryStream)) {
                    memoryStream.Position = 0L;
                    using (ByteOrderSwappingBinaryReader input = new ByteOrderSwappingBinaryReader (memoryStream)) {
                        TableEntryCollection tables = CreateTableEntryCollection (woffTableDirs);
                        return new OpenFontReader ().ReadTableEntryCollection (tables, input);
                    }
                }
                return null;
            }
        }

        public Typeface Read (Stream inputstream) {
            using (ByteOrderSwappingBinaryReader reader = new ByteOrderSwappingBinaryReader (inputstream)) {
                return Read (reader);
            }
        }

        private Woff2Header ReadHeader (BinaryReader reader) {
            Woff2Header woff2Header = new Woff2Header ();
            byte num = reader.ReadByte ();
            byte b = reader.ReadByte ();
            byte b2 = reader.ReadByte ();
            byte b3 = reader.ReadByte ();
            if (num != 119 || b != 79 || b2 != 70 || b3 != 50) {
                return null;
            }
            woff2Header.flavor = reader.ReadUInt32 ();
            Utils.TagToString (woff2Header.flavor);
            woff2Header.length = reader.ReadUInt32 ();
            woff2Header.numTables = reader.ReadUInt16 ();
            reader.ReadUInt16 ();
            woff2Header.totalSfntSize = reader.ReadUInt32 ();
            woff2Header.totalCompressSize = reader.ReadUInt32 ();
            woff2Header.majorVersion = reader.ReadUInt16 ();
            woff2Header.minorVersion = reader.ReadUInt16 ();
            woff2Header.metaOffset = reader.ReadUInt32 ();
            woff2Header.metaLength = reader.ReadUInt32 ();
            woff2Header.metaOriginalLength = reader.ReadUInt32 ();
            woff2Header.privOffset = reader.ReadUInt32 ();
            woff2Header.privLength = reader.ReadUInt32 ();
            return woff2Header;
        }

        private Woff2TableDirectory[] ReadTableDirectories (BinaryReader reader) {
            uint numTables = _header.numTables;
            Woff2TableDirectory[] array = new Woff2TableDirectory[numTables];
            long num = 0L;
            for (int i = 0; i < numTables; i++) {
                Woff2TableDirectory woff2TableDirectory = new Woff2TableDirectory ();
                byte b = reader.ReadByte ();
                int num2 = b & 0x1F;
                string text = null;
                text = (woff2TableDirectory.Name = ((num2 >= 63) ? Utils.TagToString (reader.ReadUInt32 ()) : s_knownTableTags[num2]));
                woff2TableDirectory.PreprocessingTransformation = (byte) ((b >> 5) & 3);
                woff2TableDirectory.ExpectedStartAt = num;
                ReadUIntBase128 (reader, out woff2TableDirectory.origLength);
                switch (woff2TableDirectory.PreprocessingTransformation) {
                    case 0:
                        if (woff2TableDirectory.Name == "glyf") {
                            ReadUIntBase128 (reader, out woff2TableDirectory.transformLength);
                            num += woff2TableDirectory.transformLength;
                        } else if (woff2TableDirectory.Name == "loca") {
                            ReadUIntBase128 (reader, out woff2TableDirectory.transformLength);
                            num += woff2TableDirectory.transformLength;
                        } else {
                            num += woff2TableDirectory.origLength;
                        }
                        break;
                    case 1:
                        num += woff2TableDirectory.origLength;
                        break;
                    case 2:
                        num += woff2TableDirectory.origLength;
                        break;
                    case 3:
                        num += woff2TableDirectory.origLength;
                        break;
                }
                array[i] = woff2TableDirectory;
            }
            return array;
        }

        private static TableEntryCollection CreateTableEntryCollection (Woff2TableDirectory[] woffTableDirs) {
            TableEntryCollection tableEntryCollection = new TableEntryCollection ();
            foreach (Woff2TableDirectory woff2TableDirectory in woffTableDirs) {
                UnreadTableEntry unreadTableEntry = null;
                unreadTableEntry = ((woff2TableDirectory.Name == "glyf" && woff2TableDirectory.PreprocessingTransformation == 0) ? new TransformedGlyf (new TableHeader (woff2TableDirectory.Name, 0u, (uint) woff2TableDirectory.ExpectedStartAt, woff2TableDirectory.transformLength), woff2TableDirectory) : ((!(woff2TableDirectory.Name == "loca") || woff2TableDirectory.PreprocessingTransformation != 0) ? new UnreadTableEntry (new TableHeader (woff2TableDirectory.Name, 0u, (uint) woff2TableDirectory.ExpectedStartAt, woff2TableDirectory.origLength)) : new TransformedLoca (new TableHeader (woff2TableDirectory.Name, 0u, (uint) woff2TableDirectory.ExpectedStartAt, woff2TableDirectory.transformLength), woff2TableDirectory)));
                tableEntryCollection.AddEntry (unreadTableEntry);
            }
            return tableEntryCollection;
        }

        private static bool ReadUIntBase128 (BinaryReader reader, out uint result) {
            uint num = 0u;
            result = 0u;
            for (int i = 0; i < 5; i++) {
                byte b = reader.ReadByte ();
                if (i == 0 && b == 128) {
                    return false;
                }
                if (((int) num & -33554432) != 0) {
                    return false;
                }
                num = (uint) ((int) (num << 7) | (b & 0x7F));
                if ((b & 0x80) == 0) {
                    result = num;
                    return true;
                }
            }
            return false;
        }
    }
}