using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    public class ScriptTable {
        public class LangSysTable {
            public readonly ushort offset;

            public uint langSysTagIden {
                get;
                private set;
            }

            public ushort[] featureIndexList {
                get;
                private set;
            }

            public ushort RequireFeatureIndex {
                get;
                private set;
            }

            public bool HasRequireFeature => RequireFeatureIndex != ushort.MaxValue;

            public LangSysTable (uint langSysTagIden, ushort offset) {
                this.offset = offset;
                this.langSysTagIden = langSysTagIden;
            }

            public void ReadFrom (BinaryReader reader) {
                reader.ReadUInt16 ();
                RequireFeatureIndex = reader.ReadUInt16 ();
                ushort nRecords = reader.ReadUInt16 ();
                featureIndexList = Utils.ReadUInt16Array (reader, nRecords);
            }
        }

        public LangSysTable defaultLang;

        public LangSysTable[] langSysTables;

        public uint scriptTag;

        public string ScriptTagName => Utils.TagToString (scriptTag);

        public static ScriptTable CreateFrom (BinaryReader reader, long beginAt) {
            reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
            ScriptTable scriptTable = new ScriptTable ();
            ushort num = reader.ReadUInt16 ();
            ushort num2 = reader.ReadUInt16 ();
            LangSysTable[] array = scriptTable.langSysTables = new LangSysTable[num2];
            for (int i = 0; i < num2; i++) {
                array[i] = new LangSysTable (reader.ReadUInt32 (), reader.ReadUInt16 ());
            }
            if (num > 0) {
                scriptTable.defaultLang = new LangSysTable (0u, num);
                reader.BaseStream.Seek (beginAt + num, SeekOrigin.Begin);
                scriptTable.defaultLang.ReadFrom (reader);
            }
            for (int j = 0; j < num2; j++) {
                LangSysTable langSysTable = array[j];
                reader.BaseStream.Seek (beginAt + langSysTable.offset, SeekOrigin.Begin);
                langSysTable.ReadFrom (reader);
            }
            return scriptTable;
        }
    }
}