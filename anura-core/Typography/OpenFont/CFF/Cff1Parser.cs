using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Anura.Typography.OpenFont.CFF {
    internal class Cff1Parser {
        private struct CffIndexOffset {
            public readonly int startOffset;

            public readonly int len;

            public CffIndexOffset (int startOffset, int len) {
                this.startOffset = startOffset;
                this.len = len;
            }
        }

        private BinaryReader _reader;

        private Cff1FontSet _cff1FontSet;

        private Cff1Font _currentCff1Font;

        private List<CffDataDicEntry> _topDic;

        private uint _cffStartAt;

        private int _charStringsOffset;

        private int _charsetOffset;

        private int _encodingOffset;

        private int _privateDICTSize;

        private int _privateDICTOffset;

        private string[] _uniqueStringTable;

        private readonly StringBuilder _sbForReadRealNumber = new StringBuilder ();

        public Cff1FontSet ResultCff1FontSet => _cff1FontSet;

        public void ParseAfterHeader (uint cffStartAt, BinaryReader reader) {
            _cffStartAt = cffStartAt;
            _cff1FontSet = new Cff1FontSet ();
            _reader = reader;
            ReadNameIndex ();
            ReadTopDICTIndex ();
            ReadStringIndex ();
            ReadGlobalSubrIndex ();
            ReadCharStringsIndex ();
            ReadCharsets ();
            ReadEncodings ();
            ReadPrivateDict ();
            ReadFDSelect ();
        }

        private void ReadNameIndex () {
            CffIndexOffset[] array = ReadIndexDataOffsets ();
            if (array != null) {
                int num = array.Length;
                List<string> list = new List<string> ();
                for (int i = 0; i < num; i++) {
                    CffIndexOffset cffIndexOffset = array[i];
                    list.Add (Encoding.UTF8.GetString (_reader.ReadBytes (cffIndexOffset.len), 0, cffIndexOffset.len));
                }
                _cff1FontSet._fontNames = list;
                if (num != 1) {
                    throw new NotSupportedException ();
                }
                _currentCff1Font = new Cff1Font ();
                _currentCff1Font.FontName = list[0];
                _cff1FontSet._fonts.Add (_currentCff1Font);
            }
        }

        private void ReadTopDICTIndex () {
            CffIndexOffset[] array = ReadIndexDataOffsets ();
            int num = array.Length;
            if (num > 1) {
                throw new NotSupportedException ();
            }
            for (int i = 0; i < num; i++) {
                CffIndexOffset cffIndexOffset = array[i];
                List<CffDataDicEntry> list = _topDic = ReadDICTData (cffIndexOffset.len);
            }
            foreach (CffDataDicEntry item in _topDic) {
                switch (item._operator.Name) {
                    case "CharStrings":
                        _charStringsOffset = (int) item.operands[0]._realNumValue;
                        break;
                    case "charset":
                        _charsetOffset = (int) item.operands[0]._realNumValue;
                        break;
                    case "Encoding":
                        _encodingOffset = (int) item.operands[0]._realNumValue;
                        break;
                    case "Private":
                        _privateDICTSize = (int) item.operands[0]._realNumValue;
                        _privateDICTOffset = (int) item.operands[1]._realNumValue;
                        break;
                }
            }
        }

        private void ReadStringIndex () {
            CffIndexOffset[] array = ReadIndexDataOffsets ();
            if (array != null) {
                int num = array.Length;
                _uniqueStringTable = new string[num];
                for (int i = 0; i < num; i++) {
                    CffIndexOffset cffIndexOffset = array[i];
                    _uniqueStringTable[i] = Encoding.UTF8.GetString (_reader.ReadBytes (cffIndexOffset.len), 0, cffIndexOffset.len);
                }
                _cff1FontSet._uniqueStringTable = _uniqueStringTable;
            }
        }

        private void ReadGlobalSubrIndex () {
            if (ReadIndexDataOffsets () == null) {
                return;
            }
            throw new NotImplementedException ();
        }

        private void ReadEncodings () {
            switch (_reader.ReadByte ()) {
                case 0:
                    ReadFormat0Encoding ();
                    break;
                case 1:
                    ReadFormat1Encoding ();
                    break;
            }
        }

        private void ReadCharsets () {
            _reader.BaseStream.Position = _cffStartAt + _charsetOffset;
            switch (_reader.ReadByte ()) {
                default : throw new NotSupportedException ();
                case 0:
                        ReadCharsetsFormat0 ();
                    break;
                case 1:
                        ReadCharsetsFormat1 ();
                    break;
                case 2:
                        throw new NotSupportedException ();
            }
        }

        private void ReadCharsetsFormat0 () {
            Glyph[] glyphs = _currentCff1Font._glyphs;
            int num = glyphs.Length;
            for (int i = 1; i < num; i++) {
                ushort num2 = _reader.ReadUInt16 ();
                if (num2 <= 390) {
                    glyphs[i]._cff1GlyphData.Name = Cff1FontSet.s_StdStrings[num2];
                } else {
                    glyphs[i]._cff1GlyphData.Name = _uniqueStringTable[num2 - 390 - 1];
                }
            }
        }

        private void ReadCharsetsFormat1 () {
            throw new NotSupportedException ();
        }

        private void ReadCharsetsFormat2 () { }

        private void ReadFDSelect () { }

        private void ReadCharStringsIndex () {
            _reader.BaseStream.Position = _cffStartAt + _charStringsOffset;
            CffIndexOffset[] array = ReadIndexDataOffsets ();
            int num = array.Length;
            Glyph[] array2 = new Glyph[num];
            _currentCff1Font._glyphs = array2;
            Type2CharStringParser type2CharStringParser = new Type2CharStringParser ();
            for (int i = 0; i < num; i++) {
                CffIndexOffset cffIndexOffset = array[i];
                byte[] buffer = _reader.ReadBytes (cffIndexOffset.len);
                Cff1GlyphData cff1GlyphData = new Cff1GlyphData ();
                cff1GlyphData.GlyphIndex = (ushort) i;
                Type2GlyphInstructionList type2GlyphInstructionList = type2CharStringParser.ParseType2CharString (buffer);
                if (type2GlyphInstructionList != null) {
                    type2GlyphInstructionList.Kind = Type2GlyphInstructionListKind.GlyphDescription;
                    cff1GlyphData.GlyphInstructions = type2GlyphInstructionList;
                }
                array2[i] = new Glyph (_currentCff1Font, cff1GlyphData);
            }
        }

        private void ReadFormat0Encoding () {
            int count = _reader.ReadByte ();
            _reader.ReadBytes (count);
        }

        private void ReadFormat1Encoding () {
            _reader.ReadByte ();
        }

        private void ReadPrivateDict () {
            _reader.BaseStream.Position = _cffStartAt + _privateDICTOffset;
            _currentCff1Font._privateDict = ReadDICTData (_privateDICTSize);
            foreach (CffDataDicEntry item in _currentCff1Font._privateDict) {
                switch (item._operator.Name) {
                    case "Subrs":
                        {
                            int num = (int) item.operands[0]._realNumValue;
                            _reader.BaseStream.Position = _cffStartAt + _privateDICTOffset + num;
                            ReadLocalSubrs ();
                            break;
                        }
                    case "defaultWidthX":
                        _currentCff1Font._defaultWidthX = (int) item.operands[0]._realNumValue;
                        break;
                    case "nominalWidthX":
                        _currentCff1Font._nominalWidthX = (int) item.operands[0]._realNumValue;
                        break;
                }
            }
        }

        private void ReadLocalSubrs () {
            CffIndexOffset[] array = ReadIndexDataOffsets ();
            Type2CharStringParser type2CharStringParser = new Type2CharStringParser ();
            int num = array.Length;
            List<Type2GlyphInstructionList> list = new List<Type2GlyphInstructionList> (num);
            _currentCff1Font._localSubrs = list;
            for (int i = 0; i < num; i++) {
                CffIndexOffset cffIndexOffset = array[i];
                byte[] buffer = _reader.ReadBytes (cffIndexOffset.len);
                Type2GlyphInstructionList type2GlyphInstructionList = type2CharStringParser.ParseType2CharString (buffer);
                if (type2GlyphInstructionList != null) {
                    type2GlyphInstructionList.Kind = Type2GlyphInstructionListKind.LocalSubroutine;
                    list.Add (type2GlyphInstructionList);
                } else {
                    list.Add (null);
                }
            }
        }

        private List<CffDataDicEntry> ReadDICTData (int len) {
            int num = (int) (_reader.BaseStream.Position + len);
            List<CffDataDicEntry> list = new List<CffDataDicEntry> ();
            while (_reader.BaseStream.Position < num) {
                CffDataDicEntry item = ReadEntry ();
                list.Add (item);
            }
            return list;
        }

        private CffDataDicEntry ReadEntry () {
            CffDataDicEntry cffDataDicEntry = new CffDataDicEntry ();
            List<CffOperand> list = new List<CffOperand> ();
            byte b;
            while (true) {
                b = _reader.ReadByte ();
                if (b >= 0 && b <= 21) {
                    cffDataDicEntry._operator = ReadOperator (b);
                    cffDataDicEntry.operands = list.ToArray ();
                    return cffDataDicEntry;
                }
                if (b == 28 || b == 29) {
                    int num = ReadIntegerNumber (b);
                    list.Add (new CffOperand (num, OperandKind.IntNumber));
                    continue;
                }
                if (b == 30) {
                    double number = ReadRealNumber ();
                    list.Add (new CffOperand (number, OperandKind.RealNumber));
                    continue;
                }
                if (b < 32 || b > 254) {
                    break;
                }
                int num2 = ReadIntegerNumber (b);
                list.Add (new CffOperand (num2, OperandKind.IntNumber));
            }
            throw new NotSupportedException ("invalid DICT data b0 byte: " + b);
        }

        private CFFOperator ReadOperator (byte b0) {
            byte b = 0;
            if (b0 == 12) {
                b = _reader.ReadByte ();
            }
            return CFFOperator.GetOperatorByKey (b0, b);
        }

        private double ReadRealNumber () {
            StringBuilder sbForReadRealNumber = _sbForReadRealNumber;
            sbForReadRealNumber.Length = 0;
            bool flag = false;
            bool flag2 = false;
            while (!flag) {
                byte num = _reader.ReadByte ();
                int num2 = (num >> 4) & 0xF;
                int num3 = num & 0xF;
                int num4 = 0;
                while (!flag && num4 < 2) {
                    int num5 = (num4 == 0) ? num2 : num3;
                    switch (num5) {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            sbForReadRealNumber.Append (num5);
                            flag2 = false;
                            break;
                        case 10:
                            sbForReadRealNumber.Append (".");
                            break;
                        case 11:
                            sbForReadRealNumber.Append ("E");
                            flag2 = true;
                            break;
                        case 12:
                            sbForReadRealNumber.Append ("E-");
                            flag2 = true;
                            break;
                        case 14:
                            sbForReadRealNumber.Append ("-");
                            break;
                        case 15:
                            flag = true;
                            break;
                        default:
                            throw new Exception ("IllegalArgumentException");
                        case 13:
                            break;
                    }
                    num4++;
                }
            }
            if (flag2) {
                sbForReadRealNumber.Append ("0");
            }
            if (sbForReadRealNumber.Length == 0) {
                return 0.0;
            }
            if (!double.TryParse (sbForReadRealNumber.ToString (), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out double result)) {
                throw new NotSupportedException ();
            }
            return result;
        }

        private int ReadIntegerNumber (byte b0) {
            if (b0 == 28) {
                return _reader.ReadInt16 ();
            }
            if (b0 == 29) {
                return _reader.ReadInt32 ();
            }
            if (b0 >= 32 && b0 < 246) {
                return b0 - 139;
            }
            if (b0 >= 247 && b0 <= 250) {
                int num = _reader.ReadByte ();
                return (b0 - 247) * 256 + num + 108;
            }
            if (b0 >= 251 && b0 <= 254) {
                int num2 = _reader.ReadByte ();
                return -(b0 - 251) * 256 - num2 - 108;
            }
            throw new Exception ();
        }

        private CffIndexOffset[] ReadIndexDataOffsets () {
            ushort num = _reader.ReadUInt16 ();
            if (num == 0) {
                return null;
            }
            int offsetSize = _reader.ReadByte ();
            int[] array = new int[num + 1];
            CffIndexOffset[] array2 = new CffIndexOffset[num];
            for (int i = 0; i <= num; i++) {
                array[i] = _reader.ReadOffset (offsetSize);
            }
            for (int j = 0; j < num; j++) {
                array2[j] = new CffIndexOffset (array[j], array[j + 1] - array[j]);
            }
            return array2;
        }
    }
}