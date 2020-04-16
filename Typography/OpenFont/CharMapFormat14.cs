using System.Collections.Generic;
using System.IO;

namespace Anura.Typography.OpenFont {
    internal class CharMapFormat14 : CharacterMap {
        private class VariationSelector {
            public List<int> DefaultStartCodes = new List<int> ();

            public List<int> DefaultEndCodes = new List<int> ();

            public Dictionary<int, ushort> UVSMappings = new Dictionary<int, ushort> ();
        }

        private Dictionary<int, VariationSelector> _variationSelectors;

        public override ushort Format => 14;

        protected override ushort RawCharacterToGlyphIndex (int character) {
            return 0;
        }

        public ushort CharacterPairToGlyphIndex (int codepoint, ushort defaultGlyphIndex, int nextCodepoint) {
            if (_variationSelectors.TryGetValue (nextCodepoint, out VariationSelector value)) {
                ushort value2 = 0;
                if (value.UVSMappings.TryGetValue (codepoint, out value2)) {
                    return value2;
                }
                for (int i = 0; i < value.DefaultStartCodes.Count; i++) {
                    if (codepoint >= value.DefaultStartCodes[i] && codepoint < value.DefaultEndCodes[i]) {
                        return defaultGlyphIndex;
                    }
                }
                return defaultGlyphIndex;
            }
            return 0;
        }

        public static CharMapFormat14 Create (BinaryReader reader) {
            long num = reader.BaseStream.Position - 2;
            reader.ReadUInt32 ();
            uint num2 = reader.ReadUInt32 ();
            Dictionary<int, VariationSelector> dictionary = new Dictionary<int, VariationSelector> ();
            int[] array = new int[num2];
            uint[] array2 = new uint[num2];
            uint[] array3 = new uint[num2];
            for (int i = 0; i < num2; i++) {
                array[i] = Utils.ReadUInt24 (reader);
                array2[i] = reader.ReadUInt32 ();
                array3[i] = reader.ReadUInt32 ();
            }
            for (int j = 0; j < num2; j++) {
                VariationSelector variationSelector = new VariationSelector ();
                if (array2[j] != 0) {
                    reader.BaseStream.Seek (num + array2[j], SeekOrigin.Begin);
                    uint num3 = reader.ReadUInt32 ();
                    for (int k = 0; k < num3; k++) {
                        int num4 = Utils.ReadUInt24 (reader);
                        variationSelector.DefaultStartCodes.Add (num4);
                        variationSelector.DefaultEndCodes.Add (num4 + reader.ReadByte ());
                    }
                }
                if (array3[j] != 0) {
                    reader.BaseStream.Seek (num + array3[j], SeekOrigin.Begin);
                    uint num5 = reader.ReadUInt32 ();
                    for (int l = 0; l < num5; l++) {
                        int key = Utils.ReadUInt24 (reader);
                        ushort value = reader.ReadUInt16 ();
                        variationSelector.UVSMappings.Add (key, value);
                    }
                }
                dictionary.Add (array[j], variationSelector);
            }
            return new CharMapFormat14 {
                _variationSelectors = dictionary
            };
        }
    }
}