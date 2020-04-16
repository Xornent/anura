using System.IO;
using System.Text;

namespace Anura.Typography.OpenFont.Tables {
    internal class NameEntry : TableEntry {
        private struct TT_NAME_RECORD {
            public ushort uPlatformID;

            public ushort uEncodingID;

            public ushort uLanguageID;

            public ushort uNameID;

            public ushort uStringLength;

            public ushort uStringOffset;
        }

        private enum NameIdKind {
            CopyRightNotice,
            FontFamilyName,
            FontSubfamilyName,
            UniqueFontIden,
            FullFontName,
            VersionString,
            PostScriptName,
            Trademark,
            ManufacturerName,
            Designer,
            Description,
            UrlVendor,
            UrlDesigner,
            LicenseDescription,
            LicenseInfoUrl,
            Reserved,
            TypographicFamilyName,
            TypographyicSubfamilyName,
            CompatibleFull,
            SampleText,
            PostScriptCID_FindfontName,
            WWSFamilyName,
            WWSSubfamilyName,
            LightBackgroundPalette,
            DarkBackgroundPalette,
            VariationsPostScriptNamePrefix
        }

        public const string _N = "name";

        public override string Name => "name";

        public string FontName {
            get;
            private set;
        }

        public string FontSubFamily {
            get;
            private set;
        }

        public string UniqueFontIden {
            get;
            private set;
        }

        public string FullFontName {
            get;
            set;
        }

        public string VersionString {
            get;
            set;
        }

        public string PostScriptName {
            get;
            set;
        }

        public string PostScriptCID_FindfontName {
            get;
            set;
        }

        public string TypographicFamilyName {
            get;
            set;
        }

        public string TypographyicSubfamilyName {
            get;
            set;
        }

        protected override void ReadContentFrom (BinaryReader reader) {
            reader.ReadUInt16 ();
            ushort num = reader.ReadUInt16 ();
            ushort num2 = reader.ReadUInt16 ();
            uint offset = base.Header.Offset;
            for (int i = 0; i <= num; i++) {
                TT_NAME_RECORD tT_NAME_RECORD = default (TT_NAME_RECORD);
                tT_NAME_RECORD.uPlatformID = reader.ReadUInt16 ();
                tT_NAME_RECORD.uEncodingID = reader.ReadUInt16 ();
                tT_NAME_RECORD.uLanguageID = reader.ReadUInt16 ();
                tT_NAME_RECORD.uNameID = reader.ReadUInt16 ();
                tT_NAME_RECORD.uStringLength = reader.ReadUInt16 ();
                tT_NAME_RECORD.uStringOffset = reader.ReadUInt16 ();
                TT_NAME_RECORD tT_NAME_RECORD2 = tT_NAME_RECORD;
                long position = reader.BaseStream.Position;
                reader.BaseStream.Seek (offset + tT_NAME_RECORD2.uStringOffset + num2, SeekOrigin.Begin);
                byte[] array = reader.ReadBytes (tT_NAME_RECORD2.uStringLength);
                Encoding encoding = (tT_NAME_RECORD2.uEncodingID != 3 && tT_NAME_RECORD2.uEncodingID != 1) ? Encoding.UTF8 : Encoding.BigEndianUnicode;
                string @string = encoding.GetString (array, 0, array.Length);
                switch (tT_NAME_RECORD2.uNameID) {
                    case 5:
                        VersionString = @string;
                        break;
                    case 1:
                        FontName = @string;
                        break;
                    case 2:
                        FontSubFamily = @string;
                        break;
                    case 3:
                        UniqueFontIden = @string;
                        break;
                    case 4:
                        FullFontName = @string;
                        break;
                    case 6:
                        PostScriptName = @string;
                        break;
                    case 20:
                        PostScriptCID_FindfontName = @string;
                        break;
                    case 16:
                        TypographicFamilyName = @string;
                        break;
                    case 17:
                        TypographyicSubfamilyName = @string;
                        break;
                }
                reader.BaseStream.Seek (position, SeekOrigin.Begin);
            }
        }
    }
}