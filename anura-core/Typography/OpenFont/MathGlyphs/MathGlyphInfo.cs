namespace Anura.Typography.OpenFont.MathGlyphs {
    public class MathGlyphInfo {
        public readonly ushort GlyphIndex;

        private MathKernInfoRecord _mathKernRec;

        public MathGlyphConstruction VertGlyphConstruction;

        public MathGlyphConstruction HoriGlyphConstruction;

        public MathValueRecord? ItalicCorrection {
            get;
            internal set;
        }

        public MathValueRecord? TopAccentAttachment {
            get;
            internal set;
        }

        public bool IsShapeExtensible {
            get;
            internal set;
        }

        public MathKern TopLeftMathKern => _mathKernRec.TopLeft;

        public MathKern TopRightMathKern => _mathKernRec.TopRight;

        public MathKern BottomLeftMathKern => _mathKernRec.BottomLeft;

        public MathKern BottomRightMathKern => _mathKernRec.BottomRight;

        public bool HasSomeMathKern {
            get;
            private set;
        }

        public MathGlyphInfo (ushort glyphIndex) {
            GlyphIndex = glyphIndex;
        }

        internal void SetMathKerns (MathKernInfoRecord mathKernRec) {
            _mathKernRec = mathKernRec;
            HasSomeMathKern = true;
        }
    }
}