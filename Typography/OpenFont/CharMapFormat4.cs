using System;

namespace Anura.Typography.OpenFont {
    internal class CharMapFormat4 : CharacterMap {
        private readonly ushort[] _startCode;

        private readonly ushort[] _endCode;

        private readonly ushort[] _idDelta;

        private readonly ushort[] _idRangeOffset;

        private readonly ushort[] _glyphIdArray;

        public override ushort Format => 4;

        public CharMapFormat4 (ushort[] startCode, ushort[] endCode, ushort[] idDelta, ushort[] idRangeOffset, ushort[] glyphIdArray) {
            _startCode = startCode;
            _endCode = endCode;
            _idDelta = idDelta;
            _idRangeOffset = idRangeOffset;
            _glyphIdArray = glyphIdArray;
        }

        protected override ushort RawCharacterToGlyphIndex (int codepoint) {
            if (codepoint > 65535) {
                return 0;
            }
            int num = Array.BinarySearch (_endCode, (ushort) codepoint);
            num = ((num < 0) ? (~num) : num);
            if (num >= _endCode.Length || _startCode[num] > codepoint) {
                return 0;
            }
            if (_idRangeOffset[num] == 0) {
                return (ushort) ((codepoint + _idDelta[num]) % 65536);
            }
            int num2 = (int) _idRangeOffset[num] / 2 + (codepoint - _startCode[num]);
            return _glyphIdArray[num2 - _idRangeOffset.Length + num];
        }
    }
}