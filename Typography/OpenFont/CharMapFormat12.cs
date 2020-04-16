using System;

namespace Anura.Typography.OpenFont {
    internal class CharMapFormat12 : CharacterMap {
        private uint[] _startCharCodes;

        private uint[] _endCharCodes;

        private uint[] _startGlyphIds;

        public override ushort Format => 12;

        internal CharMapFormat12 (uint[] startCharCodes, uint[] endCharCodes, uint[] startGlyphIds) {
            _startCharCodes = startCharCodes;
            _endCharCodes = endCharCodes;
            _startGlyphIds = startGlyphIds;
        }

        protected override ushort RawCharacterToGlyphIndex (int codepoint) {
            int num = Array.BinarySearch (_startCharCodes, (uint) codepoint);
            num = ((num < 0) ? (~num - 1) : num);
            if (num >= 0 && codepoint <= _endCharCodes[num]) {
                return (ushort) (_startGlyphIds[num] + codepoint - _startCharCodes[num]);
            }
            return 0;
        }
    }
}