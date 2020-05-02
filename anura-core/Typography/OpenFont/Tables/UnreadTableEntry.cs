using System;
using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class UnreadTableEntry : TableEntry {
        public override string Name => base.Header.Tag;

        public bool HasCustomContentReader {
            get;
            protected set;
        }

        public UnreadTableEntry (TableHeader header) {
            base.Header = header;
        }

        protected sealed override void ReadContentFrom (BinaryReader reader) {
            throw new NotImplementedException ();
        }

        public virtual T CreateTableEntry<T> (BinaryReader reader, T expectedResult) where T : TableEntry {
            throw new NotImplementedException ();
        }
    }
}