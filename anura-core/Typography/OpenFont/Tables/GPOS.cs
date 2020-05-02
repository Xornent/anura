using System;
using System.Collections.Generic;
using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    public class GPOS : GlyphShapingTableEntry {
        public abstract class LookupSubTable {
            public GPOS OwnerGPos;

            public abstract void DoGlyphPosition (IGlyphPositions inputGlyphs, int startAt, int len);
        }

        public class UnImplementedLookupSubTable : LookupSubTable {
            private string _msg;

            public UnImplementedLookupSubTable (string message) {
                _msg = message;
                Utils.WarnUnimplemented (message);
            }

            public override string ToString () {
                return _msg;
            }

            public override void DoGlyphPosition (IGlyphPositions inputGlyphs, int startAt, int len) { }
        }

        public class LookupTable {
            private class LkSubTableType1 : LookupSubTable {
                private ValueRecord _singleValue;

                private ValueRecord[] _multiValues;

                public int Format {
                    get;
                    private set;
                }

                public CoverageTable CoverageTable {
                    get;
                    set;
                }

                public LkSubTableType1 (ValueRecord singleValue) {
                    Format = 1;
                    _singleValue = singleValue;
                }

                public LkSubTableType1 (ValueRecord[] valueRecords) {
                    Format = 2;
                    _multiValues = valueRecords;
                }

                public override void DoGlyphPosition (IGlyphPositions inputGlyphs, int startAt, int len) {
                    Utils.WarnUnimplemented ("GPOS Lookup Sub Table Type 1");
                }
            }

            private class LkSubTableType2Fmt1 : LookupSubTable {
                private PairSetTable[] _pairSetTables;

                public CoverageTable CoverageTable {
                    get;
                    set;
                }

                public LkSubTableType2Fmt1 (PairSetTable[] pairSetTables) {
                    _pairSetTables = pairSetTables;
                }

                public override void DoGlyphPosition (IGlyphPositions inputGlyphs, int startAt, int len) {
                    CoverageTable coverageTable = CoverageTable;
                    int num = inputGlyphs.Count - 1;
                    for (int i = 0; i < num; i++) {
                        ushort advW;
                        int num2 = coverageTable.FindPosition (inputGlyphs.GetGlyph (i, out advW));
                        if (num2 > -1) {
                            PairSetTable obj = _pairSetTables[num2];
                            ushort advW2;
                            ushort glyph = inputGlyphs.GetGlyph (i + 1, out advW2);
                            if (obj.FindPairSet (glyph, out PairSet foundPairSet)) {
                                ValueRecord value = foundPairSet.value1;
                                ValueRecord value2 = foundPairSet.value2;
                                inputGlyphs.AppendGlyphAdvance (i, value.XAdvance, 0);
                                inputGlyphs.AppendGlyphAdvance (i + 1, value2.XAdvance, 0);
                            }
                        }
                    }
                }
            }

            private class LkSubTableType4 : LookupSubTable {
                public CoverageTable MarkCoverageTable {
                    get;
                    set;
                }

                public CoverageTable BaseCoverageTable {
                    get;
                    set;
                }

                public BaseArrayTable BaseArrayTable {
                    get;
                    set;
                }

                public MarkArrayTable MarkArrayTable {
                    get;
                    set;
                }

                public override void DoGlyphPosition (IGlyphPositions inputGlyphs, int startAt, int len) {
                    int num = 0;
                    int count = inputGlyphs.Count;
                    for (int i = 1; i < count; i++) {
                        ushort advW;
                        int num2 = MarkCoverageTable.FindPosition (inputGlyphs.GetGlyph (i, out advW));
                        if (num2 > -1) {
                            ushort advW2;
                            int num3 = BaseCoverageTable.FindPosition (inputGlyphs.GetGlyph (i - 1, out advW2));
                            if (num3 > -1) {
                                ushort markClass = MarkArrayTable.GetMarkClass (num2);
                                AnchorPoint anchorPoint = MarkArrayTable.GetAnchorPoint (num2);
                                AnchorPoint anchorPoint2 = BaseArrayTable.GetBaseRecords (num3).anchors[markClass];
                                inputGlyphs.AppendGlyphOffset (i, (short) (-advW2 + anchorPoint2.xcoord - anchorPoint.xcoord), (short) (anchorPoint2.ycoord - anchorPoint.ycoord));
                            }
                        }
                        num += advW;
                    }
                }
            }

            private class LkSubTableType5 : LookupSubTable {
                public CoverageTable MarkCoverage {
                    get;
                    set;
                }

                public CoverageTable LigatureCoverage {
                    get;
                    set;
                }

                public MarkArrayTable MarkArrayTable {
                    get;
                    set;
                }

                public LigatureArrayTable LigatureArrayTable {
                    get;
                    set;
                }

                public override void DoGlyphPosition (IGlyphPositions inputGlyphs, int startAt, int len) {
                    Utils.WarnUnimplemented ("GPOS Lookup Sub Table Type 5");
                }
            }

            private class LkSubTableType6 : LookupSubTable {
                public CoverageTable MarkCoverage1 {
                    get;
                    set;
                }

                public CoverageTable MarkCoverage2 {
                    get;
                    set;
                }

                public MarkArrayTable Mark1ArrayTable {
                    get;
                    set;
                }

                public Mark2ArrayTable Mark2ArrayTable {
                    get;
                    set;
                }

                public override void DoGlyphPosition (IGlyphPositions inputGlyphs, int startAt, int len) {
                    startAt = Math.Max (startAt, 1);
                    int num = Math.Min (startAt + len, inputGlyphs.Count);
                    for (int i = startAt; i < num; i++) {
                        ushort advW;
                        int num2 = MarkCoverage1.FindPosition (inputGlyphs.GetGlyph (i, out advW));
                        if (num2 <= -1) {
                            continue;
                        }
                        ushort advW2;
                        int num3 = MarkCoverage2.FindPosition (inputGlyphs.GetGlyph (i - 1, out advW2));
                        if (num3 <= -1) {
                            continue;
                        }
                        int markClass = Mark1ArrayTable.GetMarkClass (num2);
                        AnchorPoint anchorPoint = Mark2ArrayTable.GetAnchorPoint (num3, markClass);
                        AnchorPoint anchorPoint2 = Mark1ArrayTable.GetAnchorPoint (num2);
                        if (anchorPoint2.ycoord < 0) {
                            inputGlyphs.AppendGlyphOffset (i - 1, 0, (short) (-anchorPoint2.ycoord));
                            int num4 = FindActualBaseGlyphBackward (inputGlyphs, i - 1);
                            if (num4 > -1) {
                                inputGlyphs.GetOffset (num4, out short offsetX, out short _);
                                inputGlyphs.AppendGlyphOffset (i, (short) (offsetX + anchorPoint.xcoord - anchorPoint2.xcoord), 0);
                            }
                        } else {
                            inputGlyphs.GetOffset (i - 1, out short offsetX2, out short offsetY2);
                            inputGlyphs.AppendGlyphOffset (i, (short) (offsetX2 + anchorPoint.xcoord - anchorPoint2.xcoord), (short) (offsetY2 + anchorPoint.ycoord - anchorPoint2.ycoord));
                        }
                    }
                }
            }

            private class LkSubTableType7Fmt1 : LookupSubTable {
                public CoverageTable CoverageTable {
                    get;
                    set;
                }

                public PosRuleSetTable[] PosRuleSetTables {
                    get;
                    set;
                }

                public override void DoGlyphPosition (IGlyphPositions inputGlyphs, int startAt, int len) {
                    Utils.WarnUnimplemented ("GPOS Lookup Sub Table Type 7 Format 1");
                }
            }

            private class LkSubTableType7Fmt2 : LookupSubTable {
                public ushort ClassDefOffset {
                    get;
                    set;
                }

                public CoverageTable CoverageTable {
                    get;
                    set;
                }

                public PosClassSetTable[] PosClassSetTables {
                    get;
                    set;
                }

                public override void DoGlyphPosition (IGlyphPositions inputGlyphs, int startAt, int len) {
                    Utils.WarnUnimplemented ("GPOS Lookup Sub Table Type 7 Format 2");
                }
            }

            private class LkSubTableType7Fmt3 : LookupSubTable {
                public CoverageTable[] CoverageTables {
                    get;
                    set;
                }

                public PosLookupRecord[] PosLookupRecords {
                    get;
                    set;
                }

                public override void DoGlyphPosition (IGlyphPositions inputGlyphs, int startAt, int len) {
                    Utils.WarnUnimplemented ("GPOS Lookup Sub Table Type 7 Format 3");
                }
            }

            private class LkSubTableType8Fmt1 : LookupSubTable {
                public CoverageTable CoverageTable {
                    get;
                    set;
                }

                public PosRuleSetTable[] PosRuleSetTables {
                    get;
                    set;
                }

                public override void DoGlyphPosition (IGlyphPositions inputGlyphs, int startAt, int len) {
                    Utils.WarnUnimplemented ("GPOS Lookup Sub Table Type 8 Format 1");
                }
            }

            private class LkSubTableType8Fmt2 : LookupSubTable {
                private ushort[] chainPosClassSetOffsetArray;

                public CoverageTable CoverageTable {
                    get;
                    set;
                }

                public PosClassSetTable[] PosClassSetTables {
                    get;
                    set;
                }

                public ushort BacktrackClassDefOffset {
                    get;
                    set;
                }

                public ushort InputClassDefOffset {
                    get;
                    set;
                }

                public ushort LookaheadClassDefOffset {
                    get;
                    set;
                }

                public LkSubTableType8Fmt2 (ushort[] chainPosClassSetOffsetArray) {
                    this.chainPosClassSetOffsetArray = chainPosClassSetOffsetArray;
                }

                public override void DoGlyphPosition (IGlyphPositions inputGlyphs, int startAt, int len) {
                    Utils.WarnUnimplemented ("GPOS Lookup Sub Table Type 8 Format 2");
                }
            }

            private class LkSubTableType8Fmt3 : LookupSubTable {
                public CoverageTable[] BacktrackCoverages {
                    get;
                    set;
                }

                public CoverageTable[] InputGlyphCoverages {
                    get;
                    set;
                }

                public CoverageTable[] LookaheadCoverages {
                    get;
                    set;
                }

                public PosLookupRecord[] PosLookupRecords {
                    get;
                    set;
                }

                public override void DoGlyphPosition (IGlyphPositions inputGlyphs, int startAt, int len) {
                    Utils.WarnUnimplemented ("GPOS Lookup Sub Table Type 8 Format 3");
                }
            }

            public readonly ushort lookupFlags;

            public readonly ushort markFilteringSet;

            private List<LookupSubTable> _subTables = new List<LookupSubTable> ();

            public ushort lookupType {
                get;
                private set;
            }

            public IList<LookupSubTable> SubTables => _subTables;

            public LookupTable (ushort lookupType, ushort lookupFlags, ushort markFilteringSet) {
                this.lookupType = lookupType;
                this.lookupFlags = lookupFlags;
                this.markFilteringSet = markFilteringSet;
            }

            public void DoGlyphPosition (IGlyphPositions inputGlyphs, int startAt, int len) {
                foreach (LookupSubTable subTable in SubTables) {
                    subTable.DoGlyphPosition (inputGlyphs, startAt, len);
                    len = inputGlyphs.Count;
                }
            }

            public LookupSubTable ReadSubTable (BinaryReader reader, long subTableStartAt) {
                switch (lookupType) {
                    case 1:
                        return ReadLookupType1 (reader, subTableStartAt);
                    case 2:
                        return ReadLookupType2 (reader, subTableStartAt);
                    case 3:
                        return ReadLookupType3 (reader, subTableStartAt);
                    case 4:
                        return ReadLookupType4 (reader, subTableStartAt);
                    case 5:
                        return ReadLookupType5 (reader, subTableStartAt);
                    case 6:
                        return ReadLookupType6 (reader, subTableStartAt);
                    case 7:
                        return ReadLookupType7 (reader, subTableStartAt);
                    case 8:
                        return ReadLookupType8 (reader, subTableStartAt);
                    case 9:
                        return ReadLookupType9 (reader, subTableStartAt);
                    default:
                        return new UnImplementedLookupSubTable ($"GPOS Lookup Type {lookupType}");
                }
            }

            private static LookupSubTable ReadLookupType1 (BinaryReader reader, long subTableStartAt) {
                reader.BaseStream.Seek (subTableStartAt, SeekOrigin.Begin);
                switch (reader.ReadUInt16 ()) {
                    default : throw new NotSupportedException ();
                    case 1:
                        {
                            ushort num3 = reader.ReadUInt16 ();
                            ushort valueFormat2 = reader.ReadUInt16 ();
                            return new LkSubTableType1 (ValueRecord.CreateFrom (reader, valueFormat2)) {
                                CoverageTable = CoverageTable.CreateFrom (reader, subTableStartAt + num3)
                            };
                        }
                    case 2:
                        {
                            ushort num = reader.ReadUInt16 ();
                            ushort valueFormat = reader.ReadUInt16 ();
                            ushort num2 = reader.ReadUInt16 ();
                            ValueRecord[] array = new ValueRecord[num2];
                            for (int i = 0; i < num2; i++) {
                                array[i] = ValueRecord.CreateFrom (reader, valueFormat);
                            }
                            return new LkSubTableType1 (array) {
                                CoverageTable = CoverageTable.CreateFrom (reader, subTableStartAt + num)
                            };
                        }
                }
            }

            private static LookupSubTable ReadLookupType2 (BinaryReader reader, long subTableStartAt) {
                reader.BaseStream.Seek (subTableStartAt, SeekOrigin.Begin);
                ushort num = reader.ReadUInt16 ();
                switch (num) {
                    default : return new UnImplementedLookupSubTable ($"GPOS Lookup Table Type 2 Format {num}");
                    case 1:
                        {
                            ushort num4 = reader.ReadUInt16 ();
                            ushort v1format = reader.ReadUInt16 ();
                            ushort v2format = reader.ReadUInt16 ();
                            ushort num5 = reader.ReadUInt16 ();
                            ushort[] array = Utils.ReadUInt16Array (reader, num5);
                            PairSetTable[] array2 = new PairSetTable[num5];
                            for (int k = 0; k < num5; k++) {
                                reader.BaseStream.Seek (subTableStartAt + array[k], SeekOrigin.Begin);
                                PairSetTable pairSetTable = new PairSetTable ();
                                pairSetTable.ReadFrom (reader, v1format, v2format);
                                array2[k] = pairSetTable;
                            }
                            return new LkSubTableType2Fmt1 (array2) {
                                CoverageTable = CoverageTable.CreateFrom (reader, subTableStartAt + num4)
                            };
                        }
                    case 2:
                        {
                            reader.ReadUInt16 ();
                            reader.ReadUInt16 ();
                            reader.ReadUInt16 ();
                            reader.ReadUInt16 ();
                            reader.ReadUInt16 ();
                            ushort num2 = reader.ReadUInt16 ();
                            ushort num3 = reader.ReadUInt16 ();
                            for (int i = 0; i < num2; i++) {
                                for (int j = 0; j < num3; j++) { }
                            }
                            return new UnImplementedLookupSubTable ("GPOS Lookup Table Type 2 Format 2");
                        }
                }
            }

            private static LookupSubTable ReadLookupType3 (BinaryReader reader, long subTableStartAt) {
                return new UnImplementedLookupSubTable ("GPOS Lookup Table Type 3");
            }

            private static LookupSubTable ReadLookupType4 (BinaryReader reader, long subTableStartAt) {
                reader.BaseStream.Seek (subTableStartAt, SeekOrigin.Begin);
                ushort num = reader.ReadUInt16 ();
                if (num != 1) {
                    return new UnImplementedLookupSubTable ($"GPOS Lookup Sub Table Type 4 Format {num}");
                }
                ushort num2 = reader.ReadUInt16 ();
                ushort num3 = reader.ReadUInt16 ();
                ushort classCount = reader.ReadUInt16 ();
                ushort num4 = reader.ReadUInt16 ();
                ushort num5 = reader.ReadUInt16 ();
                return new LkSubTableType4 {
                    MarkCoverageTable = CoverageTable.CreateFrom (reader, subTableStartAt + num2),
                        BaseCoverageTable = CoverageTable.CreateFrom (reader, subTableStartAt + num3),
                        MarkArrayTable = MarkArrayTable.CreateFrom (reader, subTableStartAt + num4),
                        BaseArrayTable = BaseArrayTable.CreateFrom (reader, subTableStartAt + num5, classCount)
                };
            }

            private static LookupSubTable ReadLookupType5 (BinaryReader reader, long subTableStartAt) {
                reader.BaseStream.Seek (subTableStartAt, SeekOrigin.Begin);
                ushort num = reader.ReadUInt16 ();
                if (num != 1) {
                    return new UnImplementedLookupSubTable ($"GPOS Lookup Sub Table Type 5 Format {num}");
                }
                ushort num2 = reader.ReadUInt16 ();
                ushort num3 = reader.ReadUInt16 ();
                ushort classCount = reader.ReadUInt16 ();
                ushort num4 = reader.ReadUInt16 ();
                ushort num5 = reader.ReadUInt16 ();
                LkSubTableType5 obj = new LkSubTableType5 {
                    MarkCoverage = CoverageTable.CreateFrom (reader, subTableStartAt + num2),
                    LigatureCoverage = CoverageTable.CreateFrom (reader, subTableStartAt + num3),
                    MarkArrayTable = MarkArrayTable.CreateFrom (reader, subTableStartAt + num4)
                };
                reader.BaseStream.Seek (subTableStartAt + num5, SeekOrigin.Begin);
                LigatureArrayTable ligatureArrayTable = new LigatureArrayTable ();
                ligatureArrayTable.ReadFrom (reader, classCount);
                obj.LigatureArrayTable = ligatureArrayTable;
                return obj;
            }

            private static int FindActualBaseGlyphBackward (IGlyphPositions inputGlyphs, int startAt) {
                for (int num = startAt; num >= 0; num--) {
                    if ((int) inputGlyphs.GetGlyphClassKind (num) <= 1) {
                        return num;
                    }
                }
                return -1;
            }

            private static LookupSubTable ReadLookupType6 (BinaryReader reader, long subTableStartAt) {
                reader.BaseStream.Seek (subTableStartAt, SeekOrigin.Begin);
                ushort num = reader.ReadUInt16 ();
                if (num != 1) {
                    return new UnImplementedLookupSubTable ($"GPOS Lookup Sub Table Type 6 Format {num}");
                }
                ushort num2 = reader.ReadUInt16 ();
                ushort num3 = reader.ReadUInt16 ();
                ushort classCount = reader.ReadUInt16 ();
                ushort num4 = reader.ReadUInt16 ();
                ushort num5 = reader.ReadUInt16 ();
                return new LkSubTableType6 {
                    MarkCoverage1 = CoverageTable.CreateFrom (reader, subTableStartAt + num2),
                        MarkCoverage2 = CoverageTable.CreateFrom (reader, subTableStartAt + num3),
                        Mark1ArrayTable = MarkArrayTable.CreateFrom (reader, subTableStartAt + num4),
                        Mark2ArrayTable = Mark2ArrayTable.CreateFrom (reader, subTableStartAt + num5, classCount)
                };
            }

            private static LookupSubTable ReadLookupType7 (BinaryReader reader, long subTableStartAt) {
                reader.BaseStream.Seek (subTableStartAt, SeekOrigin.Begin);
                ushort num = reader.ReadUInt16 ();
                switch (num) {
                    default : return new UnImplementedLookupSubTable ($"GPOS Lookup Sub Table Type 7 Format {num}");
                    case 1:
                        {
                            ushort num4 = reader.ReadUInt16 ();
                            ushort nRecords2 = reader.ReadUInt16 ();
                            ushort[] offsets2 = Utils.ReadUInt16Array (reader, nRecords2);
                            return new LkSubTableType7Fmt1 {
                                PosRuleSetTables = CreateMultiplePosRuleSetTables (subTableStartAt, offsets2, reader),
                                    CoverageTable = CoverageTable.CreateFrom (reader, subTableStartAt + num4)
                            };
                        }
                    case 2:
                        {
                            ushort num2 = reader.ReadUInt16 ();
                            ushort classDefOffset = reader.ReadUInt16 ();
                            ushort num3 = reader.ReadUInt16 ();
                            ushort[] array = Utils.ReadUInt16Array (reader, num3);
                            LkSubTableType7Fmt2 lkSubTableType7Fmt2 = new LkSubTableType7Fmt2 ();
                            lkSubTableType7Fmt2.ClassDefOffset = classDefOffset;
                            PosClassSetTable[] array3 = lkSubTableType7Fmt2.PosClassSetTables = new PosClassSetTable[num3];
                            for (int i = 0; i < num3; i++) {
                                array3[i] = PosClassSetTable.CreateFrom (reader, subTableStartAt + array[i]);
                            }
                            lkSubTableType7Fmt2.CoverageTable = CoverageTable.CreateFrom (reader, subTableStartAt + num2);
                            return lkSubTableType7Fmt2;
                        }
                    case 3:
                        {
                            LkSubTableType7Fmt3 lkSubTableType7Fmt = new LkSubTableType7Fmt3 ();
                            ushort nRecords = reader.ReadUInt16 ();
                            ushort count = reader.ReadUInt16 ();
                            ushort[] offsets = Utils.ReadUInt16Array (reader, nRecords);
                            lkSubTableType7Fmt.PosLookupRecords = CreateMultiplePosLookupRecords (reader, count);
                            lkSubTableType7Fmt.CoverageTables = CoverageTable.CreateMultipleCoverageTables (subTableStartAt, offsets, reader);
                            return lkSubTableType7Fmt;
                        }
                }
            }

            private LookupSubTable ReadLookupType8 (BinaryReader reader, long subTableStartAt) {
                reader.BaseStream.Seek (subTableStartAt, SeekOrigin.Begin);
                ushort num = reader.ReadUInt16 ();
                switch (num) {
                    default : return new UnImplementedLookupSubTable ($"GPOS Lookup Table Type 8 Format {num}");
                    case 1:
                        {
                            ushort num4 = reader.ReadUInt16 ();
                            ushort nRecords4 = reader.ReadUInt16 ();
                            ushort[] offsets4 = Utils.ReadUInt16Array (reader, nRecords4);
                            return new LkSubTableType8Fmt1 {
                                PosRuleSetTables = CreateMultiplePosRuleSetTables (subTableStartAt, offsets4, reader),
                                    CoverageTable = CoverageTable.CreateFrom (reader, subTableStartAt + num4)
                            };
                        }
                    case 2:
                        {
                            ushort num2 = reader.ReadUInt16 ();
                            ushort backtrackClassDefOffset = reader.ReadUInt16 ();
                            ushort inputClassDefOffset = reader.ReadUInt16 ();
                            ushort lookaheadClassDefOffset = reader.ReadUInt16 ();
                            ushort num3 = reader.ReadUInt16 ();
                            ushort[] array = Utils.ReadUInt16Array (reader, num3);
                            LkSubTableType8Fmt2 lkSubTableType8Fmt2 = new LkSubTableType8Fmt2 (array);
                            lkSubTableType8Fmt2.BacktrackClassDefOffset = backtrackClassDefOffset;
                            lkSubTableType8Fmt2.InputClassDefOffset = inputClassDefOffset;
                            lkSubTableType8Fmt2.LookaheadClassDefOffset = lookaheadClassDefOffset;
                            PosClassSetTable[] array2 = new PosClassSetTable[num3];
                            for (int i = 0; i < num3; i++) {
                                array2[i] = PosClassSetTable.CreateFrom (reader, subTableStartAt + array[i]);
                            }
                            lkSubTableType8Fmt2.PosClassSetTables = array2;
                            lkSubTableType8Fmt2.CoverageTable = CoverageTable.CreateFrom (reader, subTableStartAt + num2);
                            return lkSubTableType8Fmt2;
                        }
                    case 3:
                        {
                            LkSubTableType8Fmt3 lkSubTableType8Fmt = new LkSubTableType8Fmt3 ();
                            ushort nRecords = reader.ReadUInt16 ();
                            ushort[] offsets = Utils.ReadUInt16Array (reader, nRecords);
                            ushort nRecords2 = reader.ReadUInt16 ();
                            ushort[] offsets2 = Utils.ReadUInt16Array (reader, nRecords2);
                            ushort nRecords3 = reader.ReadUInt16 ();
                            ushort[] offsets3 = Utils.ReadUInt16Array (reader, nRecords3);
                            ushort count = reader.ReadUInt16 ();
                            lkSubTableType8Fmt.PosLookupRecords = CreateMultiplePosLookupRecords (reader, count);
                            lkSubTableType8Fmt.BacktrackCoverages = CoverageTable.CreateMultipleCoverageTables (subTableStartAt, offsets, reader);
                            lkSubTableType8Fmt.InputGlyphCoverages = CoverageTable.CreateMultipleCoverageTables (subTableStartAt, offsets2, reader);
                            lkSubTableType8Fmt.LookaheadCoverages = CoverageTable.CreateMultipleCoverageTables (subTableStartAt, offsets3, reader);
                            return lkSubTableType8Fmt;
                        }
                }
            }

            private LookupSubTable ReadLookupType9 (BinaryReader reader, long subTableStartAt) {
                reader.BaseStream.Seek (subTableStartAt, SeekOrigin.Begin);
                reader.ReadUInt16 ();
                ushort num = reader.ReadUInt16 ();
                uint num2 = reader.ReadUInt32 ();
                if (num == 9) {
                    throw new NotSupportedException ();
                }
                lookupType = num;
                LookupSubTable result = ReadSubTable (reader, subTableStartAt + num2);
                lookupType = 9;
                return result;
            }
        }

        private class PairSetTable {
            private PairSet[] _pairSets;

            public void ReadFrom (BinaryReader reader, ushort v1format, ushort v2format) {
                ushort num = reader.ReadUInt16 ();
                _pairSets = new PairSet[num];
                for (int i = 0; i < num; i++) {
                    ushort secondGlyph = reader.ReadUInt16 ();
                    ValueRecord v = ValueRecord.CreateFrom (reader, v1format);
                    ValueRecord v2 = ValueRecord.CreateFrom (reader, v2format);
                    _pairSets[i] = new PairSet (secondGlyph, v, v2);
                }
            }

            public bool FindPairSet (ushort secondGlyphIndex, out PairSet foundPairSet) {
                int num = _pairSets.Length;
                for (int i = 0; i < num; i++) {
                    if (_pairSets[i].secondGlyph == secondGlyphIndex) {
                        foundPairSet = _pairSets[i];
                        return true;
                    }
                }
                foundPairSet = default (PairSet);
                return false;
            }
        }

        private struct PairSet {
            public readonly ushort secondGlyph;

            public readonly ValueRecord value1;

            public readonly ValueRecord value2;

            public PairSet (ushort secondGlyph, ValueRecord v1, ValueRecord v2) {
                this.secondGlyph = secondGlyph;
                value1 = v1;
                value2 = v2;
            }
        }

        private class ValueRecord {
            public short XPlacement;

            public short YPlacement;

            public short XAdvance;

            public short YAdvance;

            public ushort XPlaDevice;

            public ushort YPlaDevice;

            public ushort XAdvDevice;

            public ushort YAdvDevice;

            public ushort valueFormat;

            private const int FMT_XPlacement = 1;

            private const int FMT_YPlacement = 2;

            private const int FMT_XAdvance = 4;

            private const int FMT_YAdvance = 8;

            private const int FMT_XPlaDevice = 16;

            private const int FMT_YPlaDevice = 32;

            private const int FMT_XAdvDevice = 64;

            private const int FMT_YAdvDevice = 128;

            public void ReadFrom (BinaryReader reader, ushort valueFormat) {
                this.valueFormat = valueFormat;
                if (HasFormat (valueFormat, 1)) {
                    XPlacement = reader.ReadInt16 ();
                }
                if (HasFormat (valueFormat, 2)) {
                    YPlacement = reader.ReadInt16 ();
                }
                if (HasFormat (valueFormat, 4)) {
                    XAdvance = reader.ReadInt16 ();
                }
                if (HasFormat (valueFormat, 8)) {
                    YAdvance = reader.ReadInt16 ();
                }
                if (HasFormat (valueFormat, 16)) {
                    XPlaDevice = reader.ReadUInt16 ();
                }
                if (HasFormat (valueFormat, 32)) {
                    YPlaDevice = reader.ReadUInt16 ();
                }
                if (HasFormat (valueFormat, 64)) {
                    XAdvDevice = reader.ReadUInt16 ();
                }
                if (HasFormat (valueFormat, 128)) {
                    YAdvDevice = reader.ReadUInt16 ();
                }
            }

            private static bool HasFormat (ushort value, int flags) {
                return (value & flags) == flags;
            }

            public static ValueRecord CreateFrom (BinaryReader reader, ushort valueFormat) {
                ValueRecord valueRecord = new ValueRecord ();
                valueRecord.ReadFrom (reader, valueFormat);
                return valueRecord;
            }
        }

        private class AnchorPoint {
            public ushort format;

            public short xcoord;

            public short ycoord;

            public ushort refGlyphContourPoint;

            public ushort xdeviceTableOffset;

            public ushort ydeviceTableOffset;

            public static AnchorPoint CreateFrom (BinaryReader reader, long beginAt) {
                AnchorPoint anchorPoint = new AnchorPoint ();
                reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
                switch (anchorPoint.format = reader.ReadUInt16 ()) {
                    default : throw new NotSupportedException ();
                    case 1:
                            anchorPoint.xcoord = reader.ReadInt16 ();
                        anchorPoint.ycoord = reader.ReadInt16 ();
                        break;
                    case 2:
                            anchorPoint.xcoord = reader.ReadInt16 ();
                        anchorPoint.ycoord = reader.ReadInt16 ();
                        anchorPoint.refGlyphContourPoint = reader.ReadUInt16 ();
                        break;
                    case 3:
                            anchorPoint.xcoord = reader.ReadInt16 ();
                        anchorPoint.ycoord = reader.ReadInt16 ();
                        anchorPoint.xdeviceTableOffset = reader.ReadUInt16 ();
                        anchorPoint.ydeviceTableOffset = reader.ReadUInt16 ();
                        break;
                }
                return anchorPoint;
            }
        }

        private class MarkArrayTable {
            private MarkRecord[] _records;

            private AnchorPoint[] _anchorPoints;

            public AnchorPoint GetAnchorPoint (int index) {
                return _anchorPoints[index];
            }

            public ushort GetMarkClass (int index) {
                return _records[index].markClass;
            }

            private void ReadFrom (BinaryReader reader) {
                long position = reader.BaseStream.Position;
                ushort num = reader.ReadUInt16 ();
                _records = new MarkRecord[num];
                for (int i = 0; i < num; i++) {
                    _records[i] = new MarkRecord (reader.ReadUInt16 (), reader.ReadUInt16 ());
                }
                _anchorPoints = new AnchorPoint[num];
                for (int j = 0; j < num; j++) {
                    MarkRecord markRecord = _records[j];
                    if (markRecord.offset >= 0) {
                        _anchorPoints[j] = AnchorPoint.CreateFrom (reader, position + markRecord.offset);
                    }
                }
            }

            public static MarkArrayTable CreateFrom (BinaryReader reader, long beginAt) {
                reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
                MarkArrayTable markArrayTable = new MarkArrayTable ();
                markArrayTable.ReadFrom (reader);
                return markArrayTable;
            }
        }

        private struct MarkRecord {
            public readonly ushort markClass;

            public readonly ushort offset;

            public MarkRecord (ushort markClass, ushort offset) {
                this.markClass = markClass;
                this.offset = offset;
            }
        }

        private class Mark2ArrayTable {
            private readonly ushort _classCount;

            private readonly AnchorPoint[] _anchorPoints;

            public static Mark2ArrayTable CreateFrom (BinaryReader reader, long beginAt, ushort classCount) {
                reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
                ushort num = reader.ReadUInt16 ();
                ushort[] array = Utils.ReadUInt16Array (reader, num * classCount);
                AnchorPoint[] array2 = new AnchorPoint[num * classCount];
                for (int i = 0; i < num * classCount; i++) {
                    array2[i] = AnchorPoint.CreateFrom (reader, beginAt + array[i]);
                }
                return new Mark2ArrayTable (classCount, array2);
            }

            public AnchorPoint GetAnchorPoint (int index, int markClassId) {
                return _anchorPoints[index * _classCount + markClassId];
            }

            private Mark2ArrayTable (ushort classCount, AnchorPoint[] anchorPoints) {
                _classCount = classCount;
                _anchorPoints = anchorPoints;
            }
        }

        private class BaseArrayTable {
            private BaseRecord[] _records;

            public BaseRecord GetBaseRecords (int index) {
                return _records[index];
            }

            public static BaseArrayTable CreateFrom (BinaryReader reader, long beginAt, ushort classCount) {
                reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
                BaseArrayTable baseArrayTable = new BaseArrayTable ();
                ushort num = reader.ReadUInt16 ();
                baseArrayTable._records = new BaseRecord[num];
                ushort[] array = Utils.ReadUInt16Array (reader, classCount * num);
                for (int i = 0; i < num; i++) {
                    BaseRecord baseRecord = new BaseRecord (classCount);
                    for (int j = 0; j < classCount; j++) {
                        ushort num2 = array[i * classCount + j];
                        if (num2 > 0) {
                            baseRecord.anchors[j] = AnchorPoint.CreateFrom (reader, beginAt + num2);
                        }
                    }
                    baseArrayTable._records[i] = baseRecord;
                }
                return baseArrayTable;
            }
        }

        private struct BaseRecord {
            public readonly AnchorPoint[] anchors;

            public BaseRecord (int classCount) {
                anchors = new AnchorPoint[classCount];
            }
        }

        private class LigatureArrayTable {
            private LigatureAttachTable[] _ligatures;

            public void ReadFrom (BinaryReader reader, ushort classCount) {
                long position = reader.BaseStream.Position;
                ushort num = reader.ReadUInt16 ();
                ushort[] array = Utils.ReadUInt16Array (reader, num);
                _ligatures = new LigatureAttachTable[num];
                for (int i = 0; i < num; i++) {
                    reader.BaseStream.Seek (position + array[i], SeekOrigin.Begin);
                    _ligatures[i] = LigatureAttachTable.ReadFrom (reader, classCount);
                }
            }
        }

        private class LigatureAttachTable {
            private ComponentRecord[] _records;

            public static LigatureAttachTable ReadFrom (BinaryReader reader, ushort classCount) {
                LigatureAttachTable ligatureAttachTable = new LigatureAttachTable ();
                ushort num = reader.ReadUInt16 ();
                ComponentRecord[] array = ligatureAttachTable._records = new ComponentRecord[num];
                for (int i = 0; i < num; i++) {
                    array[i] = new ComponentRecord (Utils.ReadUInt16Array (reader, classCount));
                }
                return ligatureAttachTable;
            }
        }

        private struct ComponentRecord {
            public ushort[] offsets;

            public ComponentRecord (ushort[] offsets) {
                this.offsets = offsets;
            }
        }

        private struct PosLookupRecord {
            public readonly ushort seqIndex;

            public readonly ushort lookupListIndex;

            public PosLookupRecord (ushort seqIndex, ushort lookupListIndex) {
                this.seqIndex = seqIndex;
                this.lookupListIndex = lookupListIndex;
            }

            public static PosLookupRecord CreateFrom (BinaryReader reader) {
                return new PosLookupRecord (reader.ReadUInt16 (), reader.ReadUInt16 ());
            }
        }

        private class PosRuleSetTable {
            private PosRuleTable[] _posRuleTables;

            private void ReadFrom (BinaryReader reader) {
                long position = reader.BaseStream.Position;
                ushort num = reader.ReadUInt16 ();
                ushort[] array = Utils.ReadUInt16Array (reader, num);
                int num2 = array.Length;
                _posRuleTables = new PosRuleTable[num];
                for (int i = 0; i < num2; i++) {
                    reader.BaseStream.Seek (position + array[i], SeekOrigin.Begin);
                    PosRuleTable posRuleTable = new PosRuleTable ();
                    posRuleTable.ReadFrom (reader);
                    _posRuleTables[i] = posRuleTable;
                }
            }

            public static PosRuleSetTable CreateFrom (BinaryReader reader, long beginAt) {
                reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
                PosRuleSetTable posRuleSetTable = new PosRuleSetTable ();
                posRuleSetTable.ReadFrom (reader);
                return posRuleSetTable;
            }
        }

        private class PosRuleTable {
            private PosLookupRecord[] _posLookupRecords;

            private ushort[] _inputGlyphIds;

            public void ReadFrom (BinaryReader reader) {
                ushort num = reader.ReadUInt16 ();
                ushort count = reader.ReadUInt16 ();
                _inputGlyphIds = Utils.ReadUInt16Array (reader, num - 1);
                _posLookupRecords = CreateMultiplePosLookupRecords (reader, count);
            }
        }

        private class PosClassSetTable {
            private PosClassRule[] _posClasses;

            private void ReadFrom (BinaryReader reader) {
                long position = reader.BaseStream.Position;
                ushort num = reader.ReadUInt16 ();
                ushort[] array = Utils.ReadUInt16Array (reader, num);
                int num2 = array.Length;
                _posClasses = new PosClassRule[num];
                for (int i = 0; i < num2; i++) {
                    _posClasses[i] = PosClassRule.CreateFrom (reader, position + array[i]);
                }
            }

            public static PosClassSetTable CreateFrom (BinaryReader reader, long beginAt) {
                reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
                PosClassSetTable posClassSetTable = new PosClassSetTable ();
                posClassSetTable.ReadFrom (reader);
                return posClassSetTable;
            }
        }

        private class PosClassRule {
            private PosLookupRecord[] _posLookupRecords;

            private ushort[] _inputGlyphIds;

            public static PosClassRule CreateFrom (BinaryReader reader, long beginAt) {
                reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
                PosClassRule posClassRule = new PosClassRule ();
                ushort num = reader.ReadUInt16 ();
                ushort count = reader.ReadUInt16 ();
                posClassRule._inputGlyphIds = Utils.ReadUInt16Array (reader, num - 1);
                posClassRule._posLookupRecords = CreateMultiplePosLookupRecords (reader, count);
                return posClassRule;
            }
        }

        public const string _N = "GPOS";

        private List<LookupTable> _lookupList = new List<LookupTable> ();

        public override string Name => "GPOS";

        public IList<LookupTable> LookupList => _lookupList;

        protected override void ReadLookupTable (BinaryReader reader, long lookupTablePos, ushort lookupType, ushort lookupFlags, ushort[] subTableOffsets, ushort markFilteringSet) {
            LookupTable lookupTable = new LookupTable (lookupType, lookupFlags, markFilteringSet);
            foreach (long num in subTableOffsets) {
                LookupSubTable lookupSubTable = lookupTable.ReadSubTable (reader, lookupTablePos + num);
                lookupSubTable.OwnerGPos = this;
                lookupTable.SubTables.Add (lookupSubTable);
            }
            LookupList.Add (lookupTable);
        }

        protected override void ReadFeatureVariations (BinaryReader reader, long featureVariationsBeginAt) {
            Utils.WarnUnimplemented ("GPOS feature variations");
        }

        private static PosRuleSetTable[] CreateMultiplePosRuleSetTables (long initPos, ushort[] offsets, BinaryReader reader) {
            int num = offsets.Length;
            PosRuleSetTable[] array = new PosRuleSetTable[num];
            for (int i = 0; i < num; i++) {
                array[i] = PosRuleSetTable.CreateFrom (reader, initPos + offsets[i]);
            }
            return array;
        }

        private static PosLookupRecord[] CreateMultiplePosLookupRecords (BinaryReader reader, int count) {
            PosLookupRecord[] array = new PosLookupRecord[count];
            for (int i = 0; i < count; i++) {
                array[i] = PosLookupRecord.CreateFrom (reader);
            }
            return array;
        }
    }
}