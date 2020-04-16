using System.Collections.Generic;
using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class Cmap : TableEntry {
        public const string _N = "cmap";

        private List<CharacterMap> _charMaps = new List<CharacterMap> ();

        private Dictionary<int, ushort> _codepointToGlyphs = new Dictionary<int, ushort> ();

        public override string Name => "cmap";

        public ushort LookupIndex (int codepoint, int nextCodepoint = 0) {
            ushort value = 0;
            if (!_codepointToGlyphs.TryGetValue (codepoint, out value)) {
                foreach (CharacterMap charMap in _charMaps) {
                    ushort num = charMap.CharacterToGlyphIndex (codepoint);
                    if (value == 0 || (num != 0 && charMap.PlatformId == 3 && charMap.EncodingId == 1)) {
                        value = num;
                    }
                }
                _codepointToGlyphs[codepoint] = value;
            }
            if (nextCodepoint > 0) {
                foreach (CharacterMap charMap2 in _charMaps) {
                    if (charMap2 is CharMapFormat14) {
                        ushort num2 = (charMap2 as CharMapFormat14).CharacterPairToGlyphIndex (codepoint, value, nextCodepoint);
                        if (num2 > 0) {
                            return num2;
                        }
                    }
                }
                return 0;
            }
            return value;
        }

        protected override void ReadContentFrom (BinaryReader input) {
            long position = input.BaseStream.Position;
            input.ReadUInt16 ();
            ushort num = input.ReadUInt16 ();
            ushort[] array = new ushort[num];
            ushort[] array2 = new ushort[num];
            uint[] array3 = new uint[num];
            for (int i = 0; i < num; i++) {
                array[i] = input.ReadUInt16 ();
                array2[i] = input.ReadUInt16 ();
                array3[i] = input.ReadUInt32 ();
            }
            for (int j = 0; j < num; j++) {
                input.BaseStream.Seek (position + array3[j], SeekOrigin.Begin);
                CharacterMap characterMap = ReadCharacterMap (input);
                characterMap.PlatformId = array[j];
                characterMap.EncodingId = array2[j];
                _charMaps.Add (characterMap);
            }
        }

        private static CharacterMap ReadFormat_0 (BinaryReader input) {
            input.ReadUInt16 ();
            input.ReadUInt16 ();
            byte[] array = input.ReadBytes (256);
            ushort[] array2 = new ushort[256];
            for (int num = 255; num >= 0; num--) {
                array2[num] = array[num];
            }
            ushort[] startCode = new ushort[2] {
                0,
                65535
            };
            ushort[] endCode = new ushort[2] {
                255,
                65535
            };
            ushort[] idDelta = new ushort[2] {
                0,
                1
            };
            ushort[] idRangeOffset = new ushort[2] {
                4,
                0
            };
            return new CharMapFormat4 (startCode, endCode, idDelta, idRangeOffset, array2);
        }

        private static CharacterMap ReadFormat_2 (BinaryReader input) {
            Utils.WarnUnimplemented ("cmap subtable format 2");
            return new NullCharMap ();
        }

        private static CharMapFormat4 ReadFormat_4 (BinaryReader input) {
            ushort num = input.ReadUInt16 ();
            long num2 = input.BaseStream.Position + num;
            input.ReadUInt16 ();
            ushort num3 = input.ReadUInt16 ();
            input.ReadUInt16 ();
            input.ReadUInt16 ();
            input.ReadUInt16 ();
            int nRecords = (int) num3 / 2;
            ushort[] endCode = Utils.ReadUInt16Array (input, nRecords);
            input.ReadUInt16 ();
            ushort[] startCode = Utils.ReadUInt16Array (input, nRecords);
            ushort[] idDelta = Utils.ReadUInt16Array (input, nRecords);
            ushort[] idRangeOffset = Utils.ReadUInt16Array (input, nRecords);
            int nRecords2 = (int) ((num2 - input.BaseStream.Position) / 2);
            ushort[] glyphIdArray = Utils.ReadUInt16Array (input, nRecords2);
            return new CharMapFormat4 (startCode, endCode, idDelta, idRangeOffset, glyphIdArray);
        }

        private static CharMapFormat6 ReadFormat_6 (BinaryReader input) {
            input.ReadUInt16 ();
            input.ReadUInt16 ();
            ushort startCode = input.ReadUInt16 ();
            ushort nRecords = input.ReadUInt16 ();
            ushort[] glyphIdArray = Utils.ReadUInt16Array (input, nRecords);
            return new CharMapFormat6 (startCode, glyphIdArray);
        }

        private static CharacterMap ReadFormat_12 (BinaryReader input) {
            input.ReadUInt16 ();
            input.ReadUInt32 ();
            input.ReadUInt32 ();
            uint num = input.ReadUInt32 ();
            uint[] array = new uint[num];
            uint[] array2 = new uint[num];
            uint[] array3 = new uint[num];
            for (uint num2 = 0u; num2 < num; num2++) {
                array[num2] = input.ReadUInt32 ();
                array2[num2] = input.ReadUInt32 ();
                array3[num2] = input.ReadUInt32 ();
            }
            return new CharMapFormat12 (array, array2, array3);
        }

        private static CharacterMap ReadCharacterMap (BinaryReader input) {
            ushort num = input.ReadUInt16 ();
            switch (num) {
                default : Utils.WarnUnimplemented ("cmap subtable format {0}", num);
                return new NullCharMap ();
                case 0:
                        return ReadFormat_0 (input);
                case 2:
                        return ReadFormat_2 (input);
                case 4:
                        return ReadFormat_4 (input);
                case 6:
                        return ReadFormat_6 (input);
                case 12:
                        return ReadFormat_12 (input);
                case 14:
                        return CharMapFormat14.Create (input);
            }
        }
    }
}