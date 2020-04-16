using System;
using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class OS2Table : TableEntry {
        public const string _N = "OS/2";

        public ushort version;

        public short xAvgCharWidth;

        public ushort usWeightClass;

        public ushort usWidthClass;

        public ushort fsType;

        public short ySubscriptXSize;

        public short ySubscriptYSize;

        public short ySubscriptXOffset;

        public short ySubscriptYOffset;

        public short ySuperscriptXSize;

        public short ySuperscriptYSize;

        public short ySuperscriptXOffset;

        public short ySuperscriptYOffset;

        public short yStrikeoutSize;

        public short yStrikeoutPosition;

        public short sFamilyClass;

        public byte[] panose;

        public uint ulUnicodeRange1;

        public uint ulUnicodeRange2;

        public uint ulUnicodeRange3;

        public uint ulUnicodeRange4;

        public uint achVendID;

        public ushort fsSelection;

        public ushort usFirstCharIndex;

        public ushort usLastCharIndex;

        public short sTypoAscender;

        public short sTypoDescender;

        public short sTypoLineGap;

        public ushort usWinAscent;

        public ushort usWinDescent;

        public uint ulCodePageRange1;

        public uint ulCodePageRange2;

        public short sxHeight;

        public short sCapHeight;

        public ushort usDefaultChar;

        public ushort usBreakChar;

        public ushort usMaxContext;

        public ushort usLowerOpticalPointSize;

        public ushort usUpperOpticalPointSize;

        public override string Name => "OS/2";

        protected override void ReadContentFrom (BinaryReader reader) {
            switch (version = reader.ReadUInt16 ()) {
                default : throw new NotSupportedException ();
                case 0:
                        ReadVersion0 (reader);
                    break;
                case 1:
                        ReadVersion1 (reader);
                    break;
                case 2:
                        ReadVersion2 (reader);
                    break;
                case 3:
                        ReadVersion3 (reader);
                    break;
                case 4:
                        ReadVersion4 (reader);
                    break;
                case 5:
                        ReadVersion5 (reader);
                    break;
            }
        }

        private void ReadVersion0 (BinaryReader reader) {
            xAvgCharWidth = reader.ReadInt16 ();
            usWeightClass = reader.ReadUInt16 ();
            usWidthClass = reader.ReadUInt16 ();
            fsType = reader.ReadUInt16 ();
            ySubscriptXSize = reader.ReadInt16 ();
            ySubscriptYSize = reader.ReadInt16 ();
            ySubscriptXOffset = reader.ReadInt16 ();
            ySubscriptYOffset = reader.ReadInt16 ();
            ySuperscriptXSize = reader.ReadInt16 ();
            ySuperscriptYSize = reader.ReadInt16 ();
            ySuperscriptXOffset = reader.ReadInt16 ();
            ySuperscriptYOffset = reader.ReadInt16 ();
            yStrikeoutSize = reader.ReadInt16 ();
            yStrikeoutPosition = reader.ReadInt16 ();
            sFamilyClass = reader.ReadInt16 ();
            panose = reader.ReadBytes (10);
            ulUnicodeRange1 = reader.ReadUInt32 ();
            achVendID = reader.ReadUInt32 ();
            fsSelection = reader.ReadUInt16 ();
            usFirstCharIndex = reader.ReadUInt16 ();
            usLastCharIndex = reader.ReadUInt16 ();
            sTypoAscender = reader.ReadInt16 ();
            sTypoDescender = reader.ReadInt16 ();
            sTypoLineGap = reader.ReadInt16 ();
            usWinAscent = reader.ReadUInt16 ();
            usWinDescent = reader.ReadUInt16 ();
        }

        private void ReadVersion1 (BinaryReader reader) {
            xAvgCharWidth = reader.ReadInt16 ();
            usWeightClass = reader.ReadUInt16 ();
            usWidthClass = reader.ReadUInt16 ();
            fsType = reader.ReadUInt16 ();
            ySubscriptXSize = reader.ReadInt16 ();
            ySubscriptYSize = reader.ReadInt16 ();
            ySubscriptXOffset = reader.ReadInt16 ();
            ySubscriptYOffset = reader.ReadInt16 ();
            ySuperscriptXSize = reader.ReadInt16 ();
            ySuperscriptYSize = reader.ReadInt16 ();
            ySuperscriptXOffset = reader.ReadInt16 ();
            ySuperscriptYOffset = reader.ReadInt16 ();
            yStrikeoutSize = reader.ReadInt16 ();
            yStrikeoutPosition = reader.ReadInt16 ();
            sFamilyClass = reader.ReadInt16 ();
            panose = reader.ReadBytes (10);
            ulUnicodeRange1 = reader.ReadUInt32 ();
            ulUnicodeRange2 = reader.ReadUInt32 ();
            ulUnicodeRange3 = reader.ReadUInt32 ();
            ulUnicodeRange4 = reader.ReadUInt32 ();
            achVendID = reader.ReadUInt32 ();
            fsSelection = reader.ReadUInt16 ();
            usFirstCharIndex = reader.ReadUInt16 ();
            usLastCharIndex = reader.ReadUInt16 ();
            sTypoAscender = reader.ReadInt16 ();
            sTypoDescender = reader.ReadInt16 ();
            sTypoLineGap = reader.ReadInt16 ();
            usWinAscent = reader.ReadUInt16 ();
            usWinDescent = reader.ReadUInt16 ();
            ulCodePageRange1 = reader.ReadUInt32 ();
            ulCodePageRange2 = reader.ReadUInt32 ();
        }

        private void ReadVersion2 (BinaryReader reader) {
            xAvgCharWidth = reader.ReadInt16 ();
            usWeightClass = reader.ReadUInt16 ();
            usWidthClass = reader.ReadUInt16 ();
            fsType = reader.ReadUInt16 ();
            ySubscriptXSize = reader.ReadInt16 ();
            ySubscriptYSize = reader.ReadInt16 ();
            ySubscriptXOffset = reader.ReadInt16 ();
            ySubscriptYOffset = reader.ReadInt16 ();
            ySuperscriptXSize = reader.ReadInt16 ();
            ySuperscriptYSize = reader.ReadInt16 ();
            ySuperscriptXOffset = reader.ReadInt16 ();
            ySuperscriptYOffset = reader.ReadInt16 ();
            yStrikeoutSize = reader.ReadInt16 ();
            yStrikeoutPosition = reader.ReadInt16 ();
            sFamilyClass = reader.ReadInt16 ();
            panose = reader.ReadBytes (10);
            ulUnicodeRange1 = reader.ReadUInt32 ();
            ulUnicodeRange2 = reader.ReadUInt32 ();
            ulUnicodeRange3 = reader.ReadUInt32 ();
            ulUnicodeRange4 = reader.ReadUInt32 ();
            achVendID = reader.ReadUInt32 ();
            fsSelection = reader.ReadUInt16 ();
            usFirstCharIndex = reader.ReadUInt16 ();
            usLastCharIndex = reader.ReadUInt16 ();
            sTypoAscender = reader.ReadInt16 ();
            sTypoDescender = reader.ReadInt16 ();
            sTypoLineGap = reader.ReadInt16 ();
            usWinAscent = reader.ReadUInt16 ();
            usWinDescent = reader.ReadUInt16 ();
            ulCodePageRange1 = reader.ReadUInt32 ();
            ulCodePageRange2 = reader.ReadUInt32 ();
            sxHeight = reader.ReadInt16 ();
            sCapHeight = reader.ReadInt16 ();
            usDefaultChar = reader.ReadUInt16 ();
            usBreakChar = reader.ReadUInt16 ();
            usMaxContext = reader.ReadUInt16 ();
        }

        private void ReadVersion3 (BinaryReader reader) {
            xAvgCharWidth = reader.ReadInt16 ();
            usWeightClass = reader.ReadUInt16 ();
            usWidthClass = reader.ReadUInt16 ();
            fsType = reader.ReadUInt16 ();
            ySubscriptXSize = reader.ReadInt16 ();
            ySubscriptYSize = reader.ReadInt16 ();
            ySubscriptXOffset = reader.ReadInt16 ();
            ySubscriptYOffset = reader.ReadInt16 ();
            ySuperscriptXSize = reader.ReadInt16 ();
            ySuperscriptYSize = reader.ReadInt16 ();
            ySuperscriptXOffset = reader.ReadInt16 ();
            ySuperscriptYOffset = reader.ReadInt16 ();
            yStrikeoutSize = reader.ReadInt16 ();
            yStrikeoutPosition = reader.ReadInt16 ();
            sFamilyClass = reader.ReadInt16 ();
            panose = reader.ReadBytes (10);
            ulUnicodeRange1 = reader.ReadUInt32 ();
            ulUnicodeRange2 = reader.ReadUInt32 ();
            ulUnicodeRange3 = reader.ReadUInt32 ();
            ulUnicodeRange4 = reader.ReadUInt32 ();
            achVendID = reader.ReadUInt32 ();
            fsSelection = reader.ReadUInt16 ();
            usFirstCharIndex = reader.ReadUInt16 ();
            usLastCharIndex = reader.ReadUInt16 ();
            sTypoAscender = reader.ReadInt16 ();
            sTypoDescender = reader.ReadInt16 ();
            sTypoLineGap = reader.ReadInt16 ();
            usWinAscent = reader.ReadUInt16 ();
            usWinDescent = reader.ReadUInt16 ();
            ulCodePageRange1 = reader.ReadUInt32 ();
            ulCodePageRange2 = reader.ReadUInt32 ();
            sxHeight = reader.ReadInt16 ();
            sCapHeight = reader.ReadInt16 ();
            usDefaultChar = reader.ReadUInt16 ();
            usBreakChar = reader.ReadUInt16 ();
            usMaxContext = reader.ReadUInt16 ();
        }

        private void ReadVersion4 (BinaryReader reader) {
            xAvgCharWidth = reader.ReadInt16 ();
            usWeightClass = reader.ReadUInt16 ();
            usWidthClass = reader.ReadUInt16 ();
            fsType = reader.ReadUInt16 ();
            ySubscriptXSize = reader.ReadInt16 ();
            ySubscriptYSize = reader.ReadInt16 ();
            ySubscriptXOffset = reader.ReadInt16 ();
            ySubscriptYOffset = reader.ReadInt16 ();
            ySuperscriptXSize = reader.ReadInt16 ();
            ySuperscriptYSize = reader.ReadInt16 ();
            ySuperscriptXOffset = reader.ReadInt16 ();
            ySuperscriptYOffset = reader.ReadInt16 ();
            yStrikeoutSize = reader.ReadInt16 ();
            yStrikeoutPosition = reader.ReadInt16 ();
            sFamilyClass = reader.ReadInt16 ();
            panose = reader.ReadBytes (10);
            ulUnicodeRange1 = reader.ReadUInt32 ();
            ulUnicodeRange2 = reader.ReadUInt32 ();
            ulUnicodeRange3 = reader.ReadUInt32 ();
            ulUnicodeRange4 = reader.ReadUInt32 ();
            achVendID = reader.ReadUInt32 ();
            fsSelection = reader.ReadUInt16 ();
            usFirstCharIndex = reader.ReadUInt16 ();
            usLastCharIndex = reader.ReadUInt16 ();
            sTypoAscender = reader.ReadInt16 ();
            sTypoDescender = reader.ReadInt16 ();
            sTypoLineGap = reader.ReadInt16 ();
            usWinAscent = reader.ReadUInt16 ();
            usWinDescent = reader.ReadUInt16 ();
            ulCodePageRange1 = reader.ReadUInt32 ();
            ulCodePageRange2 = reader.ReadUInt32 ();
            sxHeight = reader.ReadInt16 ();
            sCapHeight = reader.ReadInt16 ();
            usDefaultChar = reader.ReadUInt16 ();
            usBreakChar = reader.ReadUInt16 ();
            usMaxContext = reader.ReadUInt16 ();
        }

        private void ReadVersion5 (BinaryReader reader) {
            xAvgCharWidth = reader.ReadInt16 ();
            usWeightClass = reader.ReadUInt16 ();
            usWidthClass = reader.ReadUInt16 ();
            fsType = reader.ReadUInt16 ();
            ySubscriptXSize = reader.ReadInt16 ();
            ySubscriptYSize = reader.ReadInt16 ();
            ySubscriptXOffset = reader.ReadInt16 ();
            ySubscriptYOffset = reader.ReadInt16 ();
            ySuperscriptXSize = reader.ReadInt16 ();
            ySuperscriptYSize = reader.ReadInt16 ();
            ySuperscriptXOffset = reader.ReadInt16 ();
            ySuperscriptYOffset = reader.ReadInt16 ();
            yStrikeoutSize = reader.ReadInt16 ();
            yStrikeoutPosition = reader.ReadInt16 ();
            sFamilyClass = reader.ReadInt16 ();
            panose = reader.ReadBytes (10);
            ulUnicodeRange1 = reader.ReadUInt32 ();
            ulUnicodeRange2 = reader.ReadUInt32 ();
            ulUnicodeRange3 = reader.ReadUInt32 ();
            ulUnicodeRange4 = reader.ReadUInt32 ();
            achVendID = reader.ReadUInt32 ();
            fsSelection = reader.ReadUInt16 ();
            usFirstCharIndex = reader.ReadUInt16 ();
            usLastCharIndex = reader.ReadUInt16 ();
            sTypoAscender = reader.ReadInt16 ();
            sTypoDescender = reader.ReadInt16 ();
            sTypoLineGap = reader.ReadInt16 ();
            usWinAscent = reader.ReadUInt16 ();
            usWinDescent = reader.ReadUInt16 ();
            ulCodePageRange1 = reader.ReadUInt32 ();
            ulCodePageRange2 = reader.ReadUInt32 ();
            sxHeight = reader.ReadInt16 ();
            sCapHeight = reader.ReadInt16 ();
            usDefaultChar = reader.ReadUInt16 ();
            usBreakChar = reader.ReadUInt16 ();
            usMaxContext = reader.ReadUInt16 ();
            usLowerOpticalPointSize = reader.ReadUInt16 ();
            usUpperOpticalPointSize = reader.ReadUInt16 ();
        }
    }
}