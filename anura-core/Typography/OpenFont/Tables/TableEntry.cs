using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    public abstract class TableEntry {
        internal TableHeader Header {
            get;
            set;
        }

        public abstract string Name {
            get;
        }

        public uint TableLength => Header.Length;

        public TableEntry () { }

        protected abstract void ReadContentFrom (BinaryReader reader);

        internal void LoadDataFrom (BinaryReader reader) {
            reader.BaseStream.Seek (Header.Offset, SeekOrigin.Begin);
            ReadContentFrom (reader);
        }
    }
}