namespace Anura.Typography.TextLayout {
    public struct UnscaledGlyphPlan {
        public readonly ushort input_cp_offset;

        public readonly ushort glyphIndex;

        public short AdvanceX {
            get;
            private set;
        }

        public short OffsetX {
            get;
            private set;
        }

        public short OffsetY {
            get;
            private set;
        }

        public bool AdvanceMoveForward => AdvanceX > 0;

        public UnscaledGlyphPlan (ushort input_cp_offset, ushort glyphIndex, short advanceW, short offsetX, short offsetY) {
            this.input_cp_offset = input_cp_offset;
            this.glyphIndex = glyphIndex;
            OffsetX = offsetX;
            OffsetY = offsetY;
            AdvanceX = advanceW;
        }
    }
}