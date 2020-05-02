namespace Anura.Typography.OpenFont.CFF {
    public class Cff1GlyphData {
        public string Name {
            get;
            set;
        }

        public ushort GlyphIndex {
            get;
            set;
        }

        internal Type2GlyphInstructionList GlyphInstructions {
            get;
            set;
        }
    }
}