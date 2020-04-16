using System.IO;

namespace Anura.Typography.OpenFont.Tables {
    internal class GDEF : TableEntry {
        public const string _N = "GDEF";

        private long _tableStartAt;

        public override string Name => "GDEF";

        public int MajorVersion {
            get;
            private set;
        }

        public int MinorVersion {
            get;
            private set;
        }

        public ClassDefTable GlyphClassDef {
            get;
            private set;
        }

        public AttachmentListTable AttachmentListTable {
            get;
            private set;
        }

        public LigCaretList LigCaretList {
            get;
            private set;
        }

        public ClassDefTable MarkAttachmentClassDef {
            get;
            private set;
        }

        public MarkGlyphSetsTable MarkGlyphSetsTable {
            get;
            private set;
        }

        protected override void ReadContentFrom (BinaryReader reader) {
            _tableStartAt = reader.BaseStream.Position;
            MajorVersion = reader.ReadUInt16 ();
            MinorVersion = reader.ReadUInt16 ();
            ushort num = reader.ReadUInt16 ();
            ushort num2 = reader.ReadUInt16 ();
            ushort num3 = reader.ReadUInt16 ();
            ushort num4 = reader.ReadUInt16 ();
            ushort num5 = 0;
            uint num6 = 0u;
            switch (MinorVersion) {
                default : Utils.WarnUnimplemented ("GDEF Minor Version {0}", MinorVersion);
                return;
                case 2:
                        num5 = reader.ReadUInt16 ();
                    break;
                case 3:
                        num5 = reader.ReadUInt16 ();
                    num6 = reader.ReadUInt32 ();
                    break;
                case 0:
                        break;
            }
            GlyphClassDef = ((num == 0) ? null : ClassDefTable.CreateFrom (reader, _tableStartAt + num));
            AttachmentListTable = ((num2 == 0) ? null : AttachmentListTable.CreateFrom (reader, _tableStartAt + num2));
            LigCaretList = ((num3 == 0) ? null : LigCaretList.CreateFrom (reader, _tableStartAt + num3));
            MarkAttachmentClassDef = ((num4 == 0) ? null : ClassDefTable.CreateFrom (reader, _tableStartAt + num4));
            MarkGlyphSetsTable = ((num5 == 0) ? null : MarkGlyphSetsTable.CreateFrom (reader, _tableStartAt + num5));
            if (num6 != 0) {
                Utils.WarnUnimplemented ("GDEF ItemVarStore");
                reader.BaseStream.Seek (base.Header.Offset + num6, SeekOrigin.Begin);
            }
        }

        public void FillGlyphData (Glyph[] inputGlyphs) {
            FillClassDefs (inputGlyphs);
            FillAttachPoints (inputGlyphs);
            FillLigatureCarets (inputGlyphs);
            FillMarkAttachmentClassDefs (inputGlyphs);
            FillMarkGlyphSets (inputGlyphs);
        }

        private void FillClassDefs (Glyph[] inputGlyphs) {
            ClassDefTable glyphClassDef = GlyphClassDef;
            if (glyphClassDef == null) {
                return;
            }
            switch (glyphClassDef.Format) {
                default : Utils.WarnUnimplemented ("GDEF GlyphClassDef Format {0}", glyphClassDef.Format);
                break;
                case 1:
                    {
                        ushort startGlyph = glyphClassDef.startGlyph;
                        ushort[] classValueArray = glyphClassDef.classValueArray;
                        int num2 = classValueArray.Length;
                        int num3 = startGlyph;
                        for (int k = 0; k < num2; k++) {
                            inputGlyphs[num3].GlyphClass = (GlyphClassKind) classValueArray[k];
                            num3++;
                        }
                        break;
                    }
                case 2:
                    {
                        ClassDefTable.ClassRangeRecord[] records = glyphClassDef.records;
                        int num = records.Length;
                        for (int i = 0; i < num; i++) {
                            ClassDefTable.ClassRangeRecord classRangeRecord = records[i];
                            GlyphClassKind glyphClass = (GlyphClassKind) classRangeRecord.classNo;
                            for (int j = classRangeRecord.startGlyphId; j <= classRangeRecord.endGlyphId; j++) {
                                inputGlyphs[j].GlyphClass = glyphClass;
                            }
                        }
                        break;
                    }
            }
        }

        private void FillAttachPoints (Glyph[] inputGlyphs) {
            if (AttachmentListTable != null) {
                Utils.WarnUnimplemented ("please implement GDEF.FillAttachPoints()");
            }
        }

        private void FillLigatureCarets (Glyph[] inputGlyphs) { }

        private void FillMarkAttachmentClassDefs (Glyph[] inputGlyphs) {
            ClassDefTable markAttachmentClassDef = MarkAttachmentClassDef;
            if (markAttachmentClassDef == null) {
                return;
            }
            switch (markAttachmentClassDef.Format) {
                default : Utils.WarnUnimplemented ("GDEF MarkAttachmentClassDef Table Format {0}", markAttachmentClassDef.Format);
                break;
                case 1:
                    {
                        ushort startGlyph = markAttachmentClassDef.startGlyph;
                        ushort[] classValueArray = markAttachmentClassDef.classValueArray;
                        int num2 = classValueArray.Length;
                        int num3 = startGlyph;
                        for (int k = 0; k < num2; k++) {
                            inputGlyphs[num3].MarkClassDef = classValueArray[k];
                            num3++;
                        }
                        break;
                    }
                case 2:
                    {
                        ClassDefTable.ClassRangeRecord[] records = markAttachmentClassDef.records;
                        int num = records.Length;
                        for (int i = 0; i < num; i++) {
                            ClassDefTable.ClassRangeRecord classRangeRecord = records[i];
                            for (int j = classRangeRecord.startGlyphId; j <= classRangeRecord.endGlyphId; j++) {
                                inputGlyphs[j].MarkClassDef = classRangeRecord.classNo;
                            }
                        }
                        break;
                    }
            }
        }

        private void FillMarkGlyphSets (Glyph[] inputGlyphs) {
            if (MarkGlyphSetsTable != null) {
                Utils.WarnUnimplemented ("please implement GDEF.FillMarkGlyphSets()");
            }
        }
    }
}