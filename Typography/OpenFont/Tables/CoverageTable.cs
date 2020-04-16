using System;
using System.Collections.Generic;
using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal abstract class CoverageTable {
        public class CoverageFmt1 : CoverageTable {
            private ushort[] _orderedGlyphIdList;

            public static CoverageFmt1 CreateFrom (BinaryReader reader) {
                ushort nRecords = reader.ReadUInt16 ();
                ushort[] orderedGlyphIdList = Utils.ReadUInt16Array (reader, nRecords);
                return new CoverageFmt1 {
                    _orderedGlyphIdList = orderedGlyphIdList
                };
            }

            public override int FindPosition (ushort glyphIndex) {
                int num = Array.BinarySearch (_orderedGlyphIdList, glyphIndex);
                if (num >= 0) {
                    return num;
                }
                return -1;
            }

            public override IEnumerable<ushort> GetExpandedValueIter () {
                return _orderedGlyphIdList;
            }
        }

        public class CoverageFmt2 : CoverageTable {
            private ushort[] _startIndices;

            private ushort[] _endIndices;

            private ushort[] _coverageIndices;

            private int RangeCount => _startIndices.Length;

            public override int FindPosition (ushort glyphIndex) {
                int num = Array.BinarySearch (_endIndices, glyphIndex);
                num = ((num < 0) ? (~num) : num);
                if (num >= RangeCount || glyphIndex < _startIndices[num]) {
                    return -1;
                }
                return _coverageIndices[num] + glyphIndex - _startIndices[num];
            }

            public override IEnumerable<ushort> GetExpandedValueIter () {
                int num2;
                for (int j = 0; j < RangeCount; j = num2) {
                    ushort num;
                    for (ushort i = _startIndices[j]; i <= _endIndices[j]; i = num) {
                        yield return i;
                        num = (ushort) (i + 1);
                    }
                    num2 = j + 1;
                }
            }

            public static CoverageFmt2 CreateFrom (BinaryReader reader) {
                ushort num = reader.ReadUInt16 ();
                ushort[] array = new ushort[num];
                ushort[] array2 = new ushort[num];
                ushort[] array3 = new ushort[num];
                for (int i = 0; i < num; i++) {
                    array[i] = reader.ReadUInt16 ();
                    array2[i] = reader.ReadUInt16 ();
                    array3[i] = reader.ReadUInt16 ();
                }
                return new CoverageFmt2 {
                    _startIndices = array,
                        _endIndices = array2,
                        _coverageIndices = array3
                };
            }
        }

        public abstract int FindPosition (ushort glyphIndex);

        public abstract IEnumerable<ushort> GetExpandedValueIter ();

        public static CoverageTable CreateFrom (BinaryReader reader, long beginAt) {
            reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
            switch (reader.ReadUInt16 ()) {
                default : throw new NotSupportedException ();
                case 1:
                        return CoverageFmt1.CreateFrom (reader);
                case 2:
                        return CoverageFmt2.CreateFrom (reader);
            }
        }

        public static CoverageTable[] CreateMultipleCoverageTables (long initPos, ushort[] offsets, BinaryReader reader) {
            List<CoverageTable> list = new List<CoverageTable> (offsets.Length);
            foreach (ushort num in offsets) {
                list.Add (CreateFrom (reader, initPos + num));
            }
            return list.ToArray ();
        }
    }
}