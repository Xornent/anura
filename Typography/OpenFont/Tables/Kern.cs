using System.Collections.Generic;
using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class Kern : TableEntry {
        private struct KerningPair {
            public readonly ushort left;

            public readonly ushort right;

            public readonly short value;

            public KerningPair (ushort left, ushort right, short value) {
                this.left = left;
                this.right = right;
                this.value = value;
            }
        }

        private struct KernCoverage {
            public readonly ushort coverage;

            public readonly bool horizontal;

            public readonly bool hasMinimum;

            public readonly bool crossStream;

            public readonly bool _override;

            public readonly byte format;

            public KernCoverage (ushort coverage) {
                this.coverage = coverage;
                horizontal = ((coverage & 1) == 1);
                hasMinimum = (((coverage >> 1) & 1) == 1);
                crossStream = (((coverage >> 2) & 1) == 1);
                _override = (((coverage >> 3) & 1) == 1);
                format = (byte) ((coverage >> 8) & 0xFF);
            }
        }

        private class KerningSubTable {
            private List<KerningPair> _kernPairs;

            private Dictionary<uint, short> _kernDic;

            public KerningSubTable (int capcity) {
                _kernPairs = new List<KerningPair> (capcity);
                _kernDic = new Dictionary<uint, short> (capcity);
            }

            public void AddKernPair (ushort left, ushort right, short value) {
                _kernPairs.Add (new KerningPair (left, right, value));
                uint key = (uint) ((left << 16) | right);
                _kernDic[key] = value;
            }

            public short GetKernDistance (ushort left, ushort right) {
                uint key = (uint) ((left << 16) | right);
                _kernDic.TryGetValue (key, out short value);
                return value;
            }
        }

        public const string _N = "kern";

        private List<KerningSubTable> _kernSubTables = new List<KerningSubTable> ();

        public override string Name => "kern";

        public short GetKerningDistance (ushort left, ushort right) {
            return _kernSubTables[0].GetKernDistance (left, right);
        }

        protected override void ReadContentFrom (BinaryReader reader) {
            reader.ReadUInt16 ();
            ushort num = reader.ReadUInt16 ();
            if (num > 1) {
                Utils.WarnUnimplemented ("Support for {0} kerning tables", num);
            }
            for (int i = 0; i < num; i++) {
                reader.ReadUInt16 ();
                ushort num2 = reader.ReadUInt16 ();
                KernCoverage kernCoverage = new KernCoverage (reader.ReadUInt16 ());
                switch (kernCoverage.format) {
                    case 0:
                        ReadSubTableFormat0 (reader, num2 - 6);
                        break;
                    default:
                        Utils.WarnUnimplemented ("Kerning Coverage Format {0}", kernCoverage.format);
                        break;
                }
            }
        }

        private void ReadSubTableFormat0 (BinaryReader reader, int remainingBytes) {
            ushort num = reader.ReadUInt16 ();
            reader.ReadUInt16 ();
            reader.ReadUInt16 ();
            reader.ReadUInt16 ();
            KerningSubTable kerningSubTable = new KerningSubTable (num);
            _kernSubTables.Add (kerningSubTable);
            while (num > 0) {
                kerningSubTable.AddKernPair (reader.ReadUInt16 (), reader.ReadUInt16 (), reader.ReadInt16 ());
                num = (ushort) (num - 1);
            }
        }
    }
}