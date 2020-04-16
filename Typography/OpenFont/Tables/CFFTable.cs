using System;
using System.IO;
using Anura.Typography.OpenFont.CFF;

namespace Anura.Typography.OpenFont.Tables {
    internal class CFFTable : TableEntry {
        public const string _N = "CFF ";

        private Cff1FontSet _cff1FontSet;

        public override string Name => "CFF ";

        internal Cff1FontSet Cff1FontSet => _cff1FontSet;

        protected override void ReadContentFrom (BinaryReader reader) {
            uint offset = base.Header.Offset;
            byte[] array = reader.ReadBytes (4);
            byte b = array[0];
            byte b2 = array[1];
            byte b3 = array[2];
            byte b4 = array[3];
            switch (b) {
                default : throw new NotSupportedException ();
                case 1:
                    {
                        Cff1Parser cff1Parser = new Cff1Parser ();
                        cff1Parser.ParseAfterHeader (offset, reader);
                        _cff1FontSet = cff1Parser.ResultCff1FontSet;
                        break;
                    }
                case 2:
                        new Cff2Parser ().ParseAfterHeader (reader);
                    break;
            }
        }
    }
}