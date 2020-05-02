using System;
using System.IO;
using Anura.Typography.OpenFont.Tables;

namespace Anura.Typography.WebFont {
    internal class TransformedLoca : UnreadTableEntry {
        public Woff2TableDirectory TableDir {
            get;
        }

        public TransformedLoca (TableHeader header, Woff2TableDirectory tableDir) : base (header) {
            base.HasCustomContentReader = true;
            TableDir = tableDir;
        }

        public override T CreateTableEntry<T> (BinaryReader reader, T expectedResult) {
            if (!(expectedResult is GlyphLocations)) {
                throw new NotSupportedException ();
            }
            return expectedResult;
        }
    }
}