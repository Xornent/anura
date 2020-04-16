using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    public class FeatureList {
        private struct FeatureRecord {
            public readonly uint featureTag;

            public readonly ushort offset;

            public string FeatureName => Utils.TagToString (featureTag);

            public FeatureRecord (uint featureTag, ushort offset) {
                this.featureTag = featureTag;
                this.offset = offset;
            }
        }

        public class FeatureTable {
            private ushort[] _lookupListIndices;

            public ushort[] LookupListIndices => _lookupListIndices;

            public uint FeatureTag {
                get;
                set;
            }

            public string TagName => Utils.TagToString (FeatureTag);

            public static FeatureTable CreateFrom (BinaryReader reader, long beginAt) {
                reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
                reader.ReadUInt16 ();
                ushort nRecords = reader.ReadUInt16 ();
                return new FeatureTable {
                    _lookupListIndices = Utils.ReadUInt16Array (reader, nRecords)
                };
            }
        }

        public FeatureTable[] featureTables;

        public static FeatureList CreateFrom (BinaryReader reader, long beginAt) {
            reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
            FeatureList featureList = new FeatureList ();
            ushort num = reader.ReadUInt16 ();
            FeatureRecord[] array = new FeatureRecord[num];
            for (int i = 0; i < num; i++) {
                array[i] = new FeatureRecord (reader.ReadUInt32 (), reader.ReadUInt16 ());
            }
            FeatureTable[] array2 = featureList.featureTables = new FeatureTable[num];
            for (int j = 0; j < num; j++) {
                FeatureRecord featureRecord = array[j];
                (array2[j] = FeatureTable.CreateFrom (reader, beginAt + featureRecord.offset)).FeatureTag = featureRecord.featureTag;
            }
            return featureList;
        }
    }
}