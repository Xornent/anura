using System;
using System.Collections.Generic;
using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    public class GSUB : GlyphShapingTableEntry {
        public abstract class LookupSubTable {
            public GSUB OwnerGSub;

            public abstract bool DoSubstitutionAt (IGlyphIndexList glyphIndices, int pos, int len);

            public abstract void CollectAssociatedSubtitutionGlyphs (List<ushort> outputAssocGlyphs);
        }

        public class UnImplementedLookupSubTable : LookupSubTable {
            private string _message;

            public UnImplementedLookupSubTable (string msg) {
                _message = msg;
                Utils.WarnUnimplemented (msg);
            }

            public override string ToString () {
                return _message;
            }

            public override bool DoSubstitutionAt (IGlyphIndexList glyphIndices, int pos, int len) {
                return false;
            }

            public override void CollectAssociatedSubtitutionGlyphs (List<ushort> outputAssocGlyphs) {
                Utils.WarnUnimplemented ("collect-assoc-sub-glyph: " + ToString ());
            }
        }

        public class LookupTable {
            private class LkSubTableT1Fmt1 : LookupSubTable {
                public short DeltaGlyph {
                    get;
                    private set;
                }

                public CoverageTable CoverageTable {
                    get;
                    private set;
                }

                public LkSubTableT1Fmt1 (CoverageTable coverageTable, short deltaGlyph) {
                    CoverageTable = coverageTable;
                    DeltaGlyph = deltaGlyph;
                }

                public override bool DoSubstitutionAt (IGlyphIndexList glyphIndices, int pos, int len) {
                    ushort num = glyphIndices[pos];
                    if (CoverageTable.FindPosition (num) > -1) {
                        glyphIndices.Replace (pos, (ushort) (num + DeltaGlyph));
                        return true;
                    }
                    return false;
                }

                public override void CollectAssociatedSubtitutionGlyphs (List<ushort> outputAssocGlyphs) {
                    foreach (ushort item in CoverageTable.GetExpandedValueIter ()) {
                        outputAssocGlyphs.Add ((ushort) (item + DeltaGlyph));
                    }
                }
            }

            private class LkSubTableT1Fmt2 : LookupSubTable {
                public ushort[] SubstituteGlyphs {
                    get;
                    private set;
                }

                public CoverageTable CoverageTable {
                    get;
                    private set;
                }

                public LkSubTableT1Fmt2 (CoverageTable coverageTable, ushort[] substituteGlyphs) {
                    CoverageTable = coverageTable;
                    SubstituteGlyphs = substituteGlyphs;
                }

                public override bool DoSubstitutionAt (IGlyphIndexList glyphIndices, int pos, int len) {
                    int num = CoverageTable.FindPosition (glyphIndices[pos]);
                    if (num > -1) {
                        glyphIndices.Replace (pos, SubstituteGlyphs[num]);
                        return true;
                    }
                    return false;
                }

                public override void CollectAssociatedSubtitutionGlyphs (List<ushort> outputAssocGlyphs) {
                    foreach (ushort item in CoverageTable.GetExpandedValueIter ()) {
                        int num = CoverageTable.FindPosition (item);
                        outputAssocGlyphs.Add (SubstituteGlyphs[num]);
                    }
                }
            }

            private class LkSubTableT2 : LookupSubTable {
                public CoverageTable CoverageTable {
                    get;
                    set;
                }

                public SequenceTable[] SeqTables {
                    get;
                    set;
                }

                public override bool DoSubstitutionAt (IGlyphIndexList glyphIndices, int pos, int len) {
                    int num = CoverageTable.FindPosition (glyphIndices[pos]);
                    if (num > -1) {
                        SequenceTable sequenceTable = SeqTables[num];
                        glyphIndices.Replace (pos, sequenceTable.substituteGlyphs);
                        return true;
                    }
                    return false;
                }

                public override void CollectAssociatedSubtitutionGlyphs (List<ushort> outputAssocGlyphs) {
                    foreach (ushort item in CoverageTable.GetExpandedValueIter ()) {
                        int num = CoverageTable.FindPosition (item);
                        outputAssocGlyphs.AddRange (SeqTables[num].substituteGlyphs);
                    }
                }
            }

            private struct SequenceTable {
                public ushort[] substituteGlyphs;

                public SequenceTable (ushort[] substituteGlyphs) {
                    this.substituteGlyphs = substituteGlyphs;
                }
            }

            private class LkSubTableT3 : LookupSubTable {
                public CoverageTable CoverageTable {
                    get;
                    set;
                }

                public AlternativeSetTable[] AlternativeSetTables {
                    get;
                    set;
                }

                public override bool DoSubstitutionAt (IGlyphIndexList glyphIndices, int pos, int len) {
                    CoverageTable.FindPosition (glyphIndices[pos]);
                    Utils.WarnUnimplemented ("Lookup Subtable Type 3");
                    return false;
                }

                public override void CollectAssociatedSubtitutionGlyphs (List<ushort> outputAssocGlyphs) {
                    Utils.WarnUnimplementedCollectAssocGlyphs (ToString ());
                }
            }

            private class AlternativeSetTable {
                public ushort[] alternativeGlyphIds;

                public static AlternativeSetTable CreateFrom (BinaryReader reader, long beginAt) {
                    reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
                    AlternativeSetTable alternativeSetTable = new AlternativeSetTable ();
                    ushort nRecords = reader.ReadUInt16 ();
                    alternativeSetTable.alternativeGlyphIds = Utils.ReadUInt16Array (reader, nRecords);
                    return alternativeSetTable;
                }
            }

            private class LkSubTableT4 : LookupSubTable {
                public CoverageTable CoverageTable {
                    get;
                    set;
                }

                public LigatureSetTable[] LigatureSetTables {
                    get;
                    set;
                }

                public override bool DoSubstitutionAt (IGlyphIndexList glyphIndices, int pos, int len) {
                    ushort glyphIndex = glyphIndices[pos];
                    int num = CoverageTable.FindPosition (glyphIndex);
                    if (num > -1) {
                        LigatureTable[] ligatures = LigatureSetTables[num].Ligatures;
                        for (int i = 0; i < ligatures.Length; i++) {
                            LigatureTable ligatureTable = ligatures[i];
                            int num2 = len - 1;
                            int num3 = ligatureTable.ComponentGlyphs.Length;
                            if (num3 > num2) {
                                continue;
                            }
                            bool flag = true;
                            int num4 = pos + 1;
                            for (int j = 0; j < num3; j++) {
                                if (glyphIndices[num4 + j] != ligatureTable.ComponentGlyphs[j]) {
                                    flag = false;
                                    break;
                                }
                            }
                            if (flag) {
                                glyphIndices.Replace (pos, num3 + 1, ligatureTable.GlyphId);
                                return true;
                            }
                        }
                    }
                    return false;
                }

                public override void CollectAssociatedSubtitutionGlyphs (List<ushort> outputAssocGlyphs) {
                    foreach (ushort item in CoverageTable.GetExpandedValueIter ()) {
                        int num = CoverageTable.FindPosition (item);
                        LigatureTable[] ligatures = LigatureSetTables[num].Ligatures;
                        for (int i = 0; i < ligatures.Length; i++) {
                            LigatureTable ligatureTable = ligatures[i];
                            outputAssocGlyphs.Add (ligatureTable.GlyphId);
                        }
                    }
                }
            }

            private class LigatureSetTable {
                public LigatureTable[] Ligatures {
                    get;
                    set;
                }

                public static LigatureSetTable CreateFrom (BinaryReader reader, long beginAt) {
                    LigatureSetTable ligatureSetTable = new LigatureSetTable ();
                    reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
                    ushort num = reader.ReadUInt16 ();
                    ushort[] array = Utils.ReadUInt16Array (reader, num);
                    LigatureTable[] array3 = ligatureSetTable.Ligatures = new LigatureTable[num];
                    LigatureTable[] array4 = array3;
                    for (int i = 0; i < num; i++) {
                        array4[i] = LigatureTable.CreateFrom (reader, beginAt + array[i]);
                    }
                    return ligatureSetTable;
                }
            }

            private struct LigatureTable {
                public ushort GlyphId {
                    get;
                    set;
                }

                public ushort[] ComponentGlyphs {
                    get;
                    set;
                }

                public static LigatureTable CreateFrom (BinaryReader reader, long beginAt) {
                    reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
                    LigatureTable result = default (LigatureTable);
                    result.GlyphId = reader.ReadUInt16 ();
                    ushort num = reader.ReadUInt16 ();
                    result.ComponentGlyphs = Utils.ReadUInt16Array (reader, num - 1);
                    return result;
                }
            }

            private class ChainSubRuleSetTable {
                private ChainSubRuleSubTable[] chainSubRuleSubTables;

                public static ChainSubRuleSetTable CreateFrom (BinaryReader reader, long beginAt) {
                    reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
                    ChainSubRuleSetTable chainSubRuleSetTable = new ChainSubRuleSetTable ();
                    ushort num = reader.ReadUInt16 ();
                    ushort[] array = Utils.ReadUInt16Array (reader, num);
                    ChainSubRuleSubTable[] array2 = chainSubRuleSetTable.chainSubRuleSubTables = new ChainSubRuleSubTable[num];
                    for (int i = 0; i < num; i++) {
                        array2[i] = ChainSubRuleSubTable.CreateFrom (reader, beginAt + array[i]);
                    }
                    return chainSubRuleSetTable;
                }
            }

            private struct SubstLookupRecord {
                public readonly ushort sequenceIndex;

                public readonly ushort lookupListIndex;

                public SubstLookupRecord (ushort seqIndex, ushort lookupListIndex) {
                    sequenceIndex = seqIndex;
                    this.lookupListIndex = lookupListIndex;
                }

                public static SubstLookupRecord[] CreateSubstLookupRecords (BinaryReader reader, ushort ncount) {
                    SubstLookupRecord[] array = new SubstLookupRecord[ncount];
                    for (int i = 0; i < ncount; i++) {
                        array[i] = new SubstLookupRecord (reader.ReadUInt16 (), reader.ReadUInt16 ());
                    }
                    return array;
                }
            }

            private class ChainSubRuleSubTable {
                private ushort[] backTrackingGlyphs;

                private ushort[] inputGlyphs;

                private ushort[] lookaheadGlyphs;

                private SubstLookupRecord[] substLookupRecords;

                public static ChainSubRuleSubTable CreateFrom (BinaryReader reader, long beginAt) {
                    reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
                    ChainSubRuleSubTable chainSubRuleSubTable = new ChainSubRuleSubTable ();
                    ushort nRecords = reader.ReadUInt16 ();
                    chainSubRuleSubTable.backTrackingGlyphs = Utils.ReadUInt16Array (reader, nRecords);
                    ushort num = reader.ReadUInt16 ();
                    chainSubRuleSubTable.inputGlyphs = Utils.ReadUInt16Array (reader, num - 1);
                    ushort nRecords2 = reader.ReadUInt16 ();
                    chainSubRuleSubTable.lookaheadGlyphs = Utils.ReadUInt16Array (reader, nRecords2);
                    ushort ncount = reader.ReadUInt16 ();
                    chainSubRuleSubTable.substLookupRecords = SubstLookupRecord.CreateSubstLookupRecords (reader, ncount);
                    return chainSubRuleSubTable;
                }
            }

            private class ChainSubClassSet {
                private ChainSubClassRuleTable[] subClassRuleTables;

                public static ChainSubClassSet CreateFrom (BinaryReader reader, long beginAt) {
                    reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
                    ChainSubClassSet chainSubClassSet = new ChainSubClassSet ();
                    ushort num = reader.ReadUInt16 ();
                    ushort[] array = Utils.ReadUInt16Array (reader, num);
                    ChainSubClassRuleTable[] array2 = chainSubClassSet.subClassRuleTables = new ChainSubClassRuleTable[num];
                    for (int i = 0; i < num; i++) {
                        array2[i] = ChainSubClassRuleTable.CreateFrom (reader, beginAt + array[i]);
                    }
                    return chainSubClassSet;
                }
            }

            private class ChainSubClassRuleTable {
                private ushort[] backtrakcingClassDefs;

                private ushort[] inputClassDefs;

                private ushort[] lookaheadClassDefs;

                private SubstLookupRecord[] subsLookupRecords;

                public static ChainSubClassRuleTable CreateFrom (BinaryReader reader, long beginAt) {
                    reader.BaseStream.Seek (beginAt, SeekOrigin.Begin);
                    ChainSubClassRuleTable chainSubClassRuleTable = new ChainSubClassRuleTable ();
                    ushort nRecords = reader.ReadUInt16 ();
                    chainSubClassRuleTable.backtrakcingClassDefs = Utils.ReadUInt16Array (reader, nRecords);
                    ushort num = reader.ReadUInt16 ();
                    chainSubClassRuleTable.inputClassDefs = Utils.ReadUInt16Array (reader, num - 1);
                    ushort nRecords2 = reader.ReadUInt16 ();
                    chainSubClassRuleTable.lookaheadClassDefs = Utils.ReadUInt16Array (reader, nRecords2);
                    ushort ncount = reader.ReadUInt16 ();
                    chainSubClassRuleTable.subsLookupRecords = SubstLookupRecord.CreateSubstLookupRecords (reader, ncount);
                    return chainSubClassRuleTable;
                }
            }

            private class LkSubTableT6Fmt1 : LookupSubTable {
                public CoverageTable CoverageTable {
                    get;
                    set;
                }

                public ChainSubRuleSetTable[] SubRuleSets {
                    get;
                    set;
                }

                public override bool DoSubstitutionAt (IGlyphIndexList glyphIndices, int pos, int len) {
                    Utils.WarnUnimplemented ("Lookup Subtable Type 6 Format 1");
                    return false;
                }

                public override void CollectAssociatedSubtitutionGlyphs (List<ushort> outputAssocGlyphs) {
                    Utils.WarnUnimplementedCollectAssocGlyphs (ToString ());
                }
            }

            private class LkSubTableT6Fmt2 : LookupSubTable {
                public CoverageTable CoverageTable {
                    get;
                    set;
                }

                public ClassDefTable BacktrackClassDef {
                    get;
                    set;
                }

                public ClassDefTable InputClassDef {
                    get;
                    set;
                }

                public ClassDefTable LookaheadClassDef {
                    get;
                    set;
                }

                public ChainSubClassSet[] ChainSubClassSets {
                    get;
                    set;
                }

                public override bool DoSubstitutionAt (IGlyphIndexList glyphIndices, int pos, int len) {
                    Utils.WarnUnimplemented ("Lookup Subtable Type 6 Format 2");
                    return false;
                }

                public override void CollectAssociatedSubtitutionGlyphs (List<ushort> outputAssocGlyphs) {
                    Utils.WarnUnimplementedCollectAssocGlyphs (ToString ());
                }
            }

            private class LkSubTableT6Fmt3 : LookupSubTable {
                public CoverageTable[] BacktrackingCoverages {
                    get;
                    set;
                }

                public CoverageTable[] InputCoverages {
                    get;
                    set;
                }

                public CoverageTable[] LookaheadCoverages {
                    get;
                    set;
                }

                public SubstLookupRecord[] SubstLookupRecords {
                    get;
                    set;
                }

                public override bool DoSubstitutionAt (IGlyphIndexList glyphIndices, int pos, int len) {
                    int num = InputCoverages.Length;
                    if (pos < BacktrackingCoverages.Length || num + LookaheadCoverages.Length > len) {
                        return false;
                    }
                    for (int i = 0; i < InputCoverages.Length; i++) {
                        if (InputCoverages[i].FindPosition (glyphIndices[pos + i]) < 0) {
                            return false;
                        }
                    }
                    for (int j = 0; j < BacktrackingCoverages.Length; j++) {
                        if (BacktrackingCoverages[j].FindPosition (glyphIndices[pos - 1 - j]) < 0) {
                            return false;
                        }
                    }
                    for (int k = 0; k < LookaheadCoverages.Length; k++) {
                        if (LookaheadCoverages[k].FindPosition (glyphIndices[pos + num + k]) < 0) {
                            return false;
                        }
                    }
                    bool result = false;
                    SubstLookupRecord[] substLookupRecords = SubstLookupRecords;
                    foreach (SubstLookupRecord substLookupRecord in substLookupRecords) {
                        ushort sequenceIndex = substLookupRecord.sequenceIndex;
                        ushort lookupListIndex = substLookupRecord.lookupListIndex;
                        if (OwnerGSub.LookupList[lookupListIndex].DoSubstitutionAt (glyphIndices, pos + sequenceIndex, len - sequenceIndex)) {
                            result = true;
                        }
                    }
                    return result;
                }

                public override void CollectAssociatedSubtitutionGlyphs (List<ushort> outputAssocGlyphs) {
                    SubstLookupRecord[] substLookupRecords = SubstLookupRecords;
                    for (int i = 0; i < substLookupRecords.Length; i++) {
                        ushort lookupListIndex = substLookupRecords[i].lookupListIndex;
                        OwnerGSub.LookupList[lookupListIndex].CollectAssociatedSubstitutionGlyph (outputAssocGlyphs);
                    }
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

            public bool DoSubstitutionAt (IGlyphIndexList inputGlyphs, int pos, int len) {
                foreach (LookupSubTable subTable in SubTables) {
                    if (subTable.DoSubstitutionAt (inputGlyphs, pos, len)) {
                        return true;
                    }
                }
                return false;
            }

            public void CollectAssociatedSubstitutionGlyph (List<ushort> outputAssocGlyphs) {
                foreach (LookupSubTable subTable in SubTables) {
                    subTable.CollectAssociatedSubtitutionGlyphs (outputAssocGlyphs);
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
                    default:
                        return new UnImplementedLookupSubTable ($"GSUB Lookup Type {lookupType}");
                }
            }

            private LookupSubTable ReadLookupType1 (BinaryReader reader, long subTableStartAt) {
                reader.BaseStream.Seek (subTableStartAt, SeekOrigin.Begin);
                ushort num = reader.ReadUInt16 ();
                ushort num2 = reader.ReadUInt16 ();
                switch (num) {
                    default : throw new NotSupportedException ();
                    case 1:
                        {
                            short deltaGlyph = reader.ReadInt16 ();
                            return new LkSubTableT1Fmt1 (CoverageTable.CreateFrom (reader, subTableStartAt + num2), deltaGlyph);
                        }
                    case 2:
                        {
                            ushort nRecords = reader.ReadUInt16 ();
                            ushort[] substituteGlyphs = Utils.ReadUInt16Array (reader, nRecords);
                            return new LkSubTableT1Fmt2 (CoverageTable.CreateFrom (reader, subTableStartAt + num2), substituteGlyphs);
                        }
                }
            }

            private LookupSubTable ReadLookupType2 (BinaryReader reader, long subTableStartAt) {
                reader.BaseStream.Seek (subTableStartAt, SeekOrigin.Begin);
                if (reader.ReadUInt16 () != 1) {
                    throw new NotSupportedException ();
                }
                ushort num = reader.ReadUInt16 ();
                ushort num2 = reader.ReadUInt16 ();
                ushort[] array = Utils.ReadUInt16Array (reader, num2);
                LkSubTableT2 lkSubTableT = new LkSubTableT2 ();
                lkSubTableT.SeqTables = new SequenceTable[num2];
                for (int i = 0; i < num2; i++) {
                    reader.BaseStream.Seek (subTableStartAt + array[i], SeekOrigin.Begin);
                    ushort nRecords = reader.ReadUInt16 ();
                    lkSubTableT.SeqTables[i] = new SequenceTable (Utils.ReadUInt16Array (reader, nRecords));
                }
                lkSubTableT.CoverageTable = CoverageTable.CreateFrom (reader, subTableStartAt + num);
                return lkSubTableT;
            }

            private LookupSubTable ReadLookupType3 (BinaryReader reader, long subTableStartAt) {
                reader.BaseStream.Seek (subTableStartAt, SeekOrigin.Begin);
                if (reader.ReadUInt16 () != 1) {
                    throw new NotSupportedException ();
                }
                ushort num = reader.ReadUInt16 ();
                ushort num2 = reader.ReadUInt16 ();
                ushort[] array = Utils.ReadUInt16Array (reader, num2);
                LkSubTableT3 lkSubTableT = new LkSubTableT3 ();
                AlternativeSetTable[] array3 = lkSubTableT.AlternativeSetTables = new AlternativeSetTable[num2];
                for (int i = 0; i < num2; i++) {
                    array3[i] = AlternativeSetTable.CreateFrom (reader, subTableStartAt + array[i]);
                }
                lkSubTableT.CoverageTable = CoverageTable.CreateFrom (reader, subTableStartAt + num);
                return lkSubTableT;
            }

            private LookupSubTable ReadLookupType4 (BinaryReader reader, long subTableStartAt) {
                reader.BaseStream.Seek (subTableStartAt, SeekOrigin.Begin);
                if (reader.ReadUInt16 () != 1) {
                    throw new NotSupportedException ();
                }
                ushort num = reader.ReadUInt16 ();
                ushort num2 = reader.ReadUInt16 ();
                ushort[] array = Utils.ReadUInt16Array (reader, num2);
                LkSubTableT4 lkSubTableT = new LkSubTableT4 ();
                LigatureSetTable[] array3 = lkSubTableT.LigatureSetTables = new LigatureSetTable[num2];
                LigatureSetTable[] array4 = array3;
                for (int i = 0; i < num2; i++) {
                    array4[i] = LigatureSetTable.CreateFrom (reader, subTableStartAt + array[i]);
                }
                lkSubTableT.CoverageTable = CoverageTable.CreateFrom (reader, subTableStartAt + num);
                return lkSubTableT;
            }

            private LookupSubTable ReadLookupType5 (BinaryReader reader, long subTableStartAt) {
                return new UnImplementedLookupSubTable ("Lookup Subtable Type 5");
            }

            private LookupSubTable ReadLookupType6 (BinaryReader reader, long subTableStartAt) {
                reader.BaseStream.Seek (subTableStartAt, SeekOrigin.Begin);
                switch (reader.ReadUInt16 ()) {
                    default : throw new NotSupportedException ();
                    case 1:
                        {
                            LkSubTableT6Fmt1 lkSubTableT6Fmt3 = new LkSubTableT6Fmt1 ();
                            ushort num6 = reader.ReadUInt16 ();
                            ushort num7 = reader.ReadUInt16 ();
                            ushort[] array5 = Utils.ReadUInt16Array (reader, num7);
                            ChainSubRuleSetTable[] array7 = lkSubTableT6Fmt3.SubRuleSets = new ChainSubRuleSetTable[num7];
                            ChainSubRuleSetTable[] array8 = array7;
                            for (int j = 0; j < num7; j++) {
                                array8[j] = ChainSubRuleSetTable.CreateFrom (reader, subTableStartAt + array5[j]);
                            }
                            lkSubTableT6Fmt3.CoverageTable = CoverageTable.CreateFrom (reader, subTableStartAt + num6);
                            return lkSubTableT6Fmt3;
                        }
                    case 2:
                        {
                            LkSubTableT6Fmt2 lkSubTableT6Fmt2 = new LkSubTableT6Fmt2 ();
                            ushort num = reader.ReadUInt16 ();
                            ushort num2 = reader.ReadUInt16 ();
                            ushort num3 = reader.ReadUInt16 ();
                            ushort num4 = reader.ReadUInt16 ();
                            ushort num5 = reader.ReadUInt16 ();
                            ushort[] array = Utils.ReadUInt16Array (reader, num5);
                            lkSubTableT6Fmt2.BacktrackClassDef = ClassDefTable.CreateFrom (reader, subTableStartAt + num2);
                            lkSubTableT6Fmt2.InputClassDef = ClassDefTable.CreateFrom (reader, subTableStartAt + num3);
                            lkSubTableT6Fmt2.LookaheadClassDef = ClassDefTable.CreateFrom (reader, subTableStartAt + num4);
                            if (num5 != 0) {
                                ChainSubClassSet[] array3 = lkSubTableT6Fmt2.ChainSubClassSets = new ChainSubClassSet[num5];
                                ChainSubClassSet[] array4 = array3;
                                for (int i = 0; i < num5; i++) {
                                    array4[i] = ChainSubClassSet.CreateFrom (reader, subTableStartAt + array[i]);
                                }
                            }
                            lkSubTableT6Fmt2.CoverageTable = CoverageTable.CreateFrom (reader, subTableStartAt + num);
                            return lkSubTableT6Fmt2;
                        }
                    case 3:
                        {
                            LkSubTableT6Fmt3 lkSubTableT6Fmt = new LkSubTableT6Fmt3 ();
                            ushort nRecords = reader.ReadUInt16 ();
                            ushort[] offsets = Utils.ReadUInt16Array (reader, nRecords);
                            ushort nRecords2 = reader.ReadUInt16 ();
                            ushort[] offsets2 = Utils.ReadUInt16Array (reader, nRecords2);
                            ushort nRecords3 = reader.ReadUInt16 ();
                            ushort[] offsets3 = Utils.ReadUInt16Array (reader, nRecords3);
                            ushort ncount = reader.ReadUInt16 ();
                            lkSubTableT6Fmt.SubstLookupRecords = SubstLookupRecord.CreateSubstLookupRecords (reader, ncount);
                            lkSubTableT6Fmt.BacktrackingCoverages = CoverageTable.CreateMultipleCoverageTables (subTableStartAt, offsets, reader);
                            lkSubTableT6Fmt.InputCoverages = CoverageTable.CreateMultipleCoverageTables (subTableStartAt, offsets2, reader);
                            lkSubTableT6Fmt.LookaheadCoverages = CoverageTable.CreateMultipleCoverageTables (subTableStartAt, offsets3, reader);
                            return lkSubTableT6Fmt;
                        }
                }
            }

            private LookupSubTable ReadLookupType7 (BinaryReader reader, long subTableStartAt) {
                reader.BaseStream.Seek (subTableStartAt, SeekOrigin.Begin);
                reader.ReadUInt16 ();
                ushort num = reader.ReadUInt16 ();
                uint num2 = reader.ReadUInt32 ();
                if (num == 7) {
                    throw new NotSupportedException ();
                }
                lookupType = num;
                LookupSubTable result = ReadSubTable (reader, subTableStartAt + num2);
                lookupType = 7;
                return result;
            }

            private LookupSubTable ReadLookupType8 (BinaryReader reader, long subTableStartAt) {
                throw new NotImplementedException ();
            }
        }

        public const string _N = "GSUB";

        private List<LookupTable> _lookupList = new List<LookupTable> ();

        public override string Name => "GSUB";

        public IList<LookupTable> LookupList => _lookupList;

        protected override void ReadLookupTable (BinaryReader reader, long lookupTablePos, ushort lookupType, ushort lookupFlags, ushort[] subTableOffsets, ushort markFilteringSet) {
            LookupTable lookupTable = new LookupTable (lookupType, lookupFlags, markFilteringSet);
            foreach (long num in subTableOffsets) {
                LookupSubTable lookupSubTable = lookupTable.ReadSubTable (reader, lookupTablePos + num);
                lookupSubTable.OwnerGSub = this;
                lookupTable.SubTables.Add (lookupSubTable);
            }
            LookupList.Add (lookupTable);
        }

        protected override void ReadFeatureVariations (BinaryReader reader, long featureVariationsBeginAt) {
            Utils.WarnUnimplemented ("GSUB feature variations");
        }
    }
}