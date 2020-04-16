using System.IO;
using Anura.Typography.OpenFont.MathGlyphs;

namespace Anura.Typography.OpenFont.Tables {
    internal class MathTable : TableEntry {
        public const string _N = "MATH";

        internal MathConstants _mathConstTable;

        internal MathItalicsCorrectonInfoTable _mathItalicCorrectionInfo;

        internal MathTopAccentAttachmentTable _mathTopAccentAttachmentTable;

        internal CoverageTable _extendedShapeCoverageTable;

        internal CoverageTable _mathKernInfoCoverage;

        internal MathKernInfoRecord[] _mathKernInfoRecords;

        internal MathVariantsTable _mathVariantsTable;

        public override string Name => "MATH";

        protected override void ReadContentFrom (BinaryReader reader) {
            long position = reader.BaseStream.Position;
            reader.ReadUInt16 ();
            reader.ReadUInt16 ();
            ushort num = reader.ReadUInt16 ();
            ushort num2 = reader.ReadUInt16 ();
            ushort num3 = reader.ReadUInt16 ();
            reader.BaseStream.Position = position + num;
            ReadMathConstantsTable (reader);
            reader.BaseStream.Position = position + num2;
            ReadMathGlyphInfoTable (reader);
            reader.BaseStream.Position = position + num3;
            ReadMathVariantsTable (reader);
            _mathConstTable.MinConnectorOverlap = _mathVariantsTable.MinConnectorOverlap;
        }

        private void ReadMathConstantsTable (BinaryReader reader) {
            MathConstants mathConstants = new MathConstants ();
            mathConstants.ScriptPercentScaleDown = reader.ReadInt16 ();
            mathConstants.ScriptScriptPercentScaleDown = reader.ReadInt16 ();
            mathConstants.DelimitedSubFormulaMinHeight = reader.ReadUInt16 ();
            mathConstants.DisplayOperatorMinHeight = reader.ReadUInt16 ();
            mathConstants.MathLeading = reader.ReadMathValueRecord ();
            mathConstants.AxisHeight = reader.ReadMathValueRecord ();
            mathConstants.AccentBaseHeight = reader.ReadMathValueRecord ();
            mathConstants.FlattenedAccentBaseHeight = reader.ReadMathValueRecord ();
            mathConstants.SubscriptShiftDown = reader.ReadMathValueRecord ();
            mathConstants.SubscriptTopMax = reader.ReadMathValueRecord ();
            mathConstants.SubscriptBaselineDropMin = reader.ReadMathValueRecord ();
            mathConstants.SuperscriptShiftUp = reader.ReadMathValueRecord ();
            mathConstants.SuperscriptShiftUpCramped = reader.ReadMathValueRecord ();
            mathConstants.SuperscriptBottomMin = reader.ReadMathValueRecord ();
            mathConstants.SuperscriptBaselineDropMax = reader.ReadMathValueRecord ();
            mathConstants.SubSuperscriptGapMin = reader.ReadMathValueRecord ();
            mathConstants.SuperscriptBottomMaxWithSubscript = reader.ReadMathValueRecord ();
            mathConstants.SpaceAfterScript = reader.ReadMathValueRecord ();
            mathConstants.UpperLimitGapMin = reader.ReadMathValueRecord ();
            mathConstants.UpperLimitBaselineRiseMin = reader.ReadMathValueRecord ();
            mathConstants.LowerLimitGapMin = reader.ReadMathValueRecord ();
            mathConstants.LowerLimitBaselineDropMin = reader.ReadMathValueRecord ();
            mathConstants.StackTopShiftUp = reader.ReadMathValueRecord ();
            mathConstants.StackTopDisplayStyleShiftUp = reader.ReadMathValueRecord ();
            mathConstants.StackBottomShiftDown = reader.ReadMathValueRecord ();
            mathConstants.StackBottomDisplayStyleShiftDown = reader.ReadMathValueRecord ();
            mathConstants.StackGapMin = reader.ReadMathValueRecord ();
            mathConstants.StackDisplayStyleGapMin = reader.ReadMathValueRecord ();
            mathConstants.StretchStackTopShiftUp = reader.ReadMathValueRecord ();
            mathConstants.StretchStackBottomShiftDown = reader.ReadMathValueRecord ();
            mathConstants.StretchStackGapAboveMin = reader.ReadMathValueRecord ();
            mathConstants.StretchStackGapBelowMin = reader.ReadMathValueRecord ();
            mathConstants.FractionNumeratorShiftUp = reader.ReadMathValueRecord ();
            mathConstants.FractionNumeratorDisplayStyleShiftUp = reader.ReadMathValueRecord ();
            mathConstants.FractionDenominatorShiftDown = reader.ReadMathValueRecord ();
            mathConstants.FractionDenominatorDisplayStyleShiftDown = reader.ReadMathValueRecord ();
            mathConstants.FractionNumeratorGapMin = reader.ReadMathValueRecord ();
            mathConstants.FractionNumDisplayStyleGapMin = reader.ReadMathValueRecord ();
            mathConstants.FractionRuleThickness = reader.ReadMathValueRecord ();
            mathConstants.FractionDenominatorGapMin = reader.ReadMathValueRecord ();
            mathConstants.FractionDenomDisplayStyleGapMin = reader.ReadMathValueRecord ();
            mathConstants.SkewedFractionHorizontalGap = reader.ReadMathValueRecord ();
            mathConstants.SkewedFractionVerticalGap = reader.ReadMathValueRecord ();
            mathConstants.OverbarVerticalGap = reader.ReadMathValueRecord ();
            mathConstants.OverbarRuleThickness = reader.ReadMathValueRecord ();
            mathConstants.OverbarExtraAscender = reader.ReadMathValueRecord ();
            mathConstants.UnderbarVerticalGap = reader.ReadMathValueRecord ();
            mathConstants.UnderbarRuleThickness = reader.ReadMathValueRecord ();
            mathConstants.UnderbarExtraDescender = reader.ReadMathValueRecord ();
            mathConstants.RadicalVerticalGap = reader.ReadMathValueRecord ();
            mathConstants.RadicalDisplayStyleVerticalGap = reader.ReadMathValueRecord ();
            mathConstants.RadicalRuleThickness = reader.ReadMathValueRecord ();
            mathConstants.RadicalExtraAscender = reader.ReadMathValueRecord ();
            mathConstants.RadicalKernBeforeDegree = reader.ReadMathValueRecord ();
            mathConstants.RadicalKernAfterDegree = reader.ReadMathValueRecord ();
            mathConstants.RadicalDegreeBottomRaisePercent = reader.ReadInt16 ();
            _mathConstTable = mathConstants;
        }

        private void ReadMathGlyphInfoTable (BinaryReader reader) {
            long position = reader.BaseStream.Position;
            ushort num = reader.ReadUInt16 ();
            ushort num2 = reader.ReadUInt16 ();
            ushort num3 = reader.ReadUInt16 ();
            ushort num4 = reader.ReadUInt16 ();
            reader.BaseStream.Position = position + num;
            ReadMathItalicCorrectionInfoTable (reader);
            reader.BaseStream.Position = position + num2;
            ReadMathTopAccentAttachment (reader);
            if (num3 > 0) {
                _extendedShapeCoverageTable = CoverageTable.CreateFrom (reader, position + num3);
            }
            if (num4 > 0) {
                reader.BaseStream.Position = position + num4;
                ReadMathKernInfoTable (reader);
            }
        }

        private void ReadMathItalicCorrectionInfoTable (BinaryReader reader) {
            long position = reader.BaseStream.Position;
            _mathItalicCorrectionInfo = new MathItalicsCorrectonInfoTable ();
            ushort num = reader.ReadUInt16 ();
            ushort count = reader.ReadUInt16 ();
            _mathItalicCorrectionInfo.ItalicCorrections = reader.ReadMathValueRecords (count);
            if (num > 0) {
                _mathItalicCorrectionInfo.CoverageTable = CoverageTable.CreateFrom (reader, position + num);
            }
        }

        private void ReadMathTopAccentAttachment (BinaryReader reader) {
            long position = reader.BaseStream.Position;
            _mathTopAccentAttachmentTable = new MathTopAccentAttachmentTable ();
            ushort num = reader.ReadUInt16 ();
            ushort count = reader.ReadUInt16 ();
            _mathTopAccentAttachmentTable.TopAccentAttachment = reader.ReadMathValueRecords (count);
            if (num > 0) {
                _mathTopAccentAttachmentTable.CoverageTable = CoverageTable.CreateFrom (reader, position + num);
            }
        }

        private void ReadMathKernInfoTable (BinaryReader reader) {
            long position = reader.BaseStream.Position;
            ushort num = reader.ReadUInt16 ();
            ushort num2 = reader.ReadUInt16 ();
            ushort[] array = Utils.ReadUInt16Array (reader, 4 * num2);
            _mathKernInfoRecords = new MathKernInfoRecord[num2];
            int num3 = 0;
            ushort num4 = 0;
            for (int i = 0; i < num2; i++) {
                num4 = array[num3];
                MathKern topRight = null;
                MathKern topLeft = null;
                MathKern bottomRight = null;
                MathKern bottomLeft = null;
                if (num4 > 0) {
                    reader.BaseStream.Position = position + num4;
                    topRight = ReadMathKernTable (reader);
                }
                num4 = array[num3 + 1];
                if (num4 > 0) {
                    reader.BaseStream.Position = position + num4;
                    topLeft = ReadMathKernTable (reader);
                }
                num4 = array[num3 + 2];
                if (num4 > 0) {
                    reader.BaseStream.Position = position + num4;
                    bottomRight = ReadMathKernTable (reader);
                }
                num4 = array[num3 + 3];
                if (num4 > 0) {
                    reader.BaseStream.Position = position + num4;
                    bottomLeft = ReadMathKernTable (reader);
                }
                _mathKernInfoRecords[i] = new MathKernInfoRecord (topRight, topLeft, bottomRight, bottomLeft);
                num3 += 4;
            }
            _mathKernInfoCoverage = CoverageTable.CreateFrom (reader, position + num);
        }

        private static MathKern ReadMathKernTable (BinaryReader reader) {
            ushort num = reader.ReadUInt16 ();
            return new MathKern (num, reader.ReadMathValueRecords (num), reader.ReadMathValueRecords (num + 1));
        }

        private void ReadMathVariantsTable (BinaryReader reader) {
            _mathVariantsTable = new MathVariantsTable ();
            long position = reader.BaseStream.Position;
            _mathVariantsTable.MinConnectorOverlap = reader.ReadUInt16 ();
            ushort num = reader.ReadUInt16 ();
            ushort num2 = reader.ReadUInt16 ();
            ushort num3 = reader.ReadUInt16 ();
            ushort num4 = reader.ReadUInt16 ();
            ushort[] array = Utils.ReadUInt16Array (reader, num3);
            ushort[] array2 = Utils.ReadUInt16Array (reader, num4);
            _mathVariantsTable.vertCoverage = CoverageTable.CreateFrom (reader, position + num);
            if (num2 > 0) {
                _mathVariantsTable.horizCoverage = CoverageTable.CreateFrom (reader, position + num2);
            }
            MathGlyphConstruction[] array3 = _mathVariantsTable.vertConstructionTables = new MathGlyphConstruction[num3];
            for (int i = 0; i < num3; i++) {
                reader.BaseStream.Position = position + array[i];
                array3[i] = ReadMathGlyphConstructionTable (reader);
            }
            MathGlyphConstruction[] array4 = _mathVariantsTable.horizConstructionTables = new MathGlyphConstruction[num4];
            for (int j = 0; j < num4; j++) {
                reader.BaseStream.Position = position + array2[j];
                array4[j] = ReadMathGlyphConstructionTable (reader);
            }
        }

        private MathGlyphConstruction ReadMathGlyphConstructionTable (BinaryReader reader) {
            long position = reader.BaseStream.Position;
            MathGlyphConstruction mathGlyphConstruction = new MathGlyphConstruction ();
            ushort num = reader.ReadUInt16 ();
            ushort num2 = reader.ReadUInt16 ();
            MathGlyphVariantRecord[] array = mathGlyphConstruction.glyphVariantRecords = new MathGlyphVariantRecord[num2];
            for (int i = 0; i < num2; i++) {
                array[i] = new MathGlyphVariantRecord (reader.ReadUInt16 (), reader.ReadUInt16 ());
            }
            if (num > 0) {
                reader.BaseStream.Position = position + num;
                FillGlyphAssemblyInfo (reader, mathGlyphConstruction);
            }
            return mathGlyphConstruction;
        }

        private static void FillGlyphAssemblyInfo (BinaryReader reader, MathGlyphConstruction glyphConstruction) {
            glyphConstruction.GlyphAsm_ItalicCorrection = reader.ReadMathValueRecord ();
            ushort num = reader.ReadUInt16 ();
            GlyphPartRecord[] array = glyphConstruction.GlyphAsm_GlyphPartRecords = new GlyphPartRecord[num];
            for (int i = 0; i < num; i++) {
                array[i] = new GlyphPartRecord (reader.ReadUInt16 (), reader.ReadUInt16 (), reader.ReadUInt16 (), reader.ReadUInt16 (), reader.ReadUInt16 ());
            }
        }
    }
}