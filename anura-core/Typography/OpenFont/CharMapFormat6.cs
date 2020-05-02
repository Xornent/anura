namespace Anura.Typography.OpenFont {
    internal class CharMapFormat6 : CharacterMap {
        private readonly ushort _startCode;

        private readonly ushort[] _glyphIdArray;

        public override ushort Format => 6;

        internal CharMapFormat6 (ushort startCode, ushort[] glyphIdArray) {
            _glyphIdArray = glyphIdArray;
            _startCode = startCode;
        }

        protected override ushort RawCharacterToGlyphIndex (int codepoint) {
            int num = codepoint - _startCode;
            if (num < 0 || num >= _glyphIdArray.Length) {
                return 0;
            }
            return _glyphIdArray[num];
        }
    }
}