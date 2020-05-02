using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class CvtTable : TableEntry {
        public const string _N = "cvt ";

        internal int[] _controlValues;

        public override string Name => "cvt ";

        protected override void ReadContentFrom (BinaryReader reader) {
            int num = (int) (base.TableLength / 2u);
            int[] array = new int[num];
            for (int i = 0; i < num; i++) {
                array[i] = reader.ReadInt16 ();
            }
            _controlValues = array;
        }
    }
}