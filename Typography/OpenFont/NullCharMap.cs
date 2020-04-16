namespace Anura.Typography.OpenFont {
    internal class NullCharMap : CharacterMap {
        public override ushort Format => 0;

        protected override ushort RawCharacterToGlyphIndex (int character) {
            return 0;
        }
    }
}