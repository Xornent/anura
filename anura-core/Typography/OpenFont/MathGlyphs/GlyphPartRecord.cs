namespace Anura.Typography.OpenFont.MathGlyphs {
    public struct GlyphPartRecord {
        public readonly ushort GlyphId;

        public readonly ushort StartConnectorLength;

        public readonly ushort EndConnectorLength;

        public readonly ushort FullAdvance;

        public readonly ushort PartFlags;

        public bool IsExtender => (PartFlags & 1) != 0;

        public GlyphPartRecord (ushort glyphId, ushort startConnectorLength, ushort endConnectorLength, ushort fullAdvance, ushort partFlags) {
            GlyphId = glyphId;
            StartConnectorLength = startConnectorLength;
            EndConnectorLength = endConnectorLength;
            FullAdvance = fullAdvance;
            PartFlags = partFlags;
        }
    }
}