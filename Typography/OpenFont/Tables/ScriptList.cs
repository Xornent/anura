using System.Collections.Generic;
using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    public class ScriptList : Dictionary<string, ScriptTable> {
        public new ScriptTable this [string tagName] {
            get {
                if (!TryGetValue (tagName, out ScriptTable value)) {
                    return null;
                }
                return value;
            }
        }

        private ScriptList () { }

        public static ScriptList CreateFrom (BinaryReader reader, long beginAt) {
            reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
            ushort num = reader.ReadUInt16 ();
            ScriptList scriptList = new ScriptList ();
            uint[] array = new uint[num];
            ushort[] array2 = new ushort[num];
            for (int i = 0; i < num; i++) {
                array[i] = reader.ReadUInt32 ();
                array2[i] = reader.ReadUInt16 ();
            }
            for (int j = 0; j < num; j++) {
                ScriptTable scriptTable = ScriptTable.CreateFrom (reader, beginAt + array2[j]);
                scriptTable.scriptTag = array[j];
                scriptList.Add (Utils.TagToString (array[j]), scriptTable);
            }
            return scriptList;
        }
    }
}