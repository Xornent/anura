using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    public abstract class GlyphShapingTableEntry : TableEntry {
        public ushort MajorVersion {
            get;
            private set;
        }

        public ushort MinorVersion {
            get;
            private set;
        }

        public ScriptList ScriptList {
            get;
            private set;
        }

        public FeatureList FeatureList {
            get;
            private set;
        }

        protected override void ReadContentFrom (BinaryReader reader) {
            long position = reader.BaseStream.Position;
            MajorVersion = reader.ReadUInt16 ();
            MinorVersion = reader.ReadUInt16 ();
            ushort num = reader.ReadUInt16 ();
            ushort num2 = reader.ReadUInt16 ();
            ushort num3 = reader.ReadUInt16 ();
            uint num4 = (MinorVersion == 1) ? reader.ReadUInt32 () : 0u;
            ScriptList = ScriptList.CreateFrom (reader, position + num);
            FeatureList = FeatureList.CreateFrom (reader, position + num2);
            ReadLookupListTable (reader, position + num3);
            if (num4 != 0) {
                ReadFeatureVariations (reader, position + num4);
            }
        }

        private void ReadLookupListTable (BinaryReader reader, long lookupListBeginAt) {
            reader.BaseStream.Seek (lookupListBeginAt, SeekOrigin.Begin);
            ushort nRecords = reader.ReadUInt16 ();
            ushort[] array = Utils.ReadUInt16Array (reader, nRecords);
            foreach (ushort num in array) {
                long num2 = lookupListBeginAt + num;
                reader.BaseStream.Seek (num2, SeekOrigin.Begin);
                ushort lookupType = reader.ReadUInt16 ();
                ushort num3 = reader.ReadUInt16 ();
                ushort nRecords2 = reader.ReadUInt16 ();
                ushort[] subTableOffsets = Utils.ReadUInt16Array (reader, nRecords2);
                ushort markFilteringSet = (ushort) (((num3 & 0x10) == 16) ? reader.ReadUInt16 () : 0);
                ReadLookupTable (reader, num2, lookupType, num3, subTableOffsets, markFilteringSet);
            }
        }

        protected abstract void ReadLookupTable (BinaryReader reader, long lookupTablePos, ushort lookupType, ushort lookupFlags, ushort[] subTableOffsets, ushort markFilteringSet);

        protected abstract void ReadFeatureVariations (BinaryReader reader, long featureVariationsBeginAt);
    }
}