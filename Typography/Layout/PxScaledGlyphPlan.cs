namespace Anura.Typography.TextLayout {
    public struct PxScaledGlyphPlan {
        public readonly ushort input_cp_offset;

        public readonly ushort glyphIndex;

        public float AdvanceX {
            get;
            private set;
        }

        public float OffsetX {
            get;
            private set;
        }

        public float OffsetY {
            get;
            private set;
        }

        public bool AdvanceMoveForward => AdvanceX > 0f;

        public PxScaledGlyphPlan (ushort input_cp_offset, ushort glyphIndex, float advanceW, float offsetX, float offsetY) {
            this.input_cp_offset = input_cp_offset;
            this.glyphIndex = glyphIndex;
            OffsetX = offsetX;
            OffsetY = offsetY;
            AdvanceX = advanceW;
        }
    }
}