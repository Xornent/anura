namespace Anura.Typography.OpenFont {
    internal abstract class CharacterMap {
        public abstract ushort Format {
            get;
        }

        public ushort PlatformId {
            get;
            set;
        }

        public ushort EncodingId {
            get;
            set;
        }

        public ushort CharacterToGlyphIndex (int codepoint) {
            return RawCharacterToGlyphIndex (codepoint);
        }

        protected abstract ushort RawCharacterToGlyphIndex (int codepoint);
    }
}