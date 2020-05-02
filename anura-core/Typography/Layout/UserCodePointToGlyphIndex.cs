using System;

namespace Anura.Typography.TextLayout {
    public struct UserCodePointToGlyphIndex {
        public ushort glyphIndexListOffset_plus1;

        public ushort len;

        internal int userCodePointIndex;

        internal void AppendData (ushort glyphIndexListOffset_plus1, ushort len) {
            if (this.glyphIndexListOffset_plus1 != 0) {
                if (this.glyphIndexListOffset_plus1 + 1 != glyphIndexListOffset_plus1) {
                    throw new NotSupportedException ();
                }
                if (len != 1) {
                    throw new NotSupportedException ();
                }
                this.len++;
            } else {
                this.glyphIndexListOffset_plus1 = glyphIndexListOffset_plus1;
                this.len = len;
            }
        }
    }
}