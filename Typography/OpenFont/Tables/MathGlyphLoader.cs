using System.Runtime.InteropServices;
using Anura.Typography.OpenFont.MathGlyphs;

namespace Anura.Typography.OpenFont.Tables {
    [StructLayout (LayoutKind.Sequential, Size = 1)]
    internal struct MathGlyphLoader {
        private static MathGlyphInfo GetMathGlyphOrCreateNew (MathGlyphInfo[] mathGlyphInfos, ushort glyphIndex) {
            return mathGlyphInfos[glyphIndex] ?? (mathGlyphInfos[glyphIndex] = new MathGlyphInfo (glyphIndex));
        }

        public void LoadMathGlyph (Typeface typeface, MathTable mathTable) {
            typeface._mathTable = mathTable;
            Glyph[] rawGlyphList = typeface.GetRawGlyphList ();
            MathGlyphInfo[] array = typeface._mathGlyphInfos = new MathGlyphInfo[rawGlyphList.Length];
            int num = 0;
            MathItalicsCorrectonInfoTable mathItalicCorrectionInfo = mathTable._mathItalicCorrectionInfo;
            num = 0;
            if (mathItalicCorrectionInfo.CoverageTable != null) {
                foreach (ushort item in mathItalicCorrectionInfo.CoverageTable.GetExpandedValueIter ()) {
                    GetMathGlyphOrCreateNew (array, item).ItalicCorrection = mathItalicCorrectionInfo.ItalicCorrections[num];
                    num++;
                }
            }
            MathTopAccentAttachmentTable mathTopAccentAttachmentTable = mathTable._mathTopAccentAttachmentTable;
            num = 0;
            if (mathTopAccentAttachmentTable.CoverageTable != null) {
                foreach (ushort item2 in mathTopAccentAttachmentTable.CoverageTable.GetExpandedValueIter ()) {
                    GetMathGlyphOrCreateNew (array, item2).TopAccentAttachment = mathTopAccentAttachmentTable.TopAccentAttachment[num];
                    num++;
                }
            }
            num = 0;
            if (mathTable._extendedShapeCoverageTable != null) {
                foreach (ushort item3 in mathTable._extendedShapeCoverageTable.GetExpandedValueIter ()) {
                    GetMathGlyphOrCreateNew (array, item3).IsShapeExtensible = true;
                    num++;
                }
            }
            num = 0;
            if (mathTable._mathKernInfoCoverage != null) {
                MathKernInfoRecord[] mathKernInfoRecords = mathTable._mathKernInfoRecords;
                foreach (ushort item4 in mathTable._mathKernInfoCoverage.GetExpandedValueIter ()) {
                    GetMathGlyphOrCreateNew (array, item4).SetMathKerns (mathKernInfoRecords[num]);
                    num++;
                }
            }
            MathVariantsTable mathVariantsTable = mathTable._mathVariantsTable;
            num = 0;
            foreach (ushort item5 in mathVariantsTable.vertCoverage.GetExpandedValueIter ()) {
                GetMathGlyphOrCreateNew (array, item5).VertGlyphConstruction = mathVariantsTable.vertConstructionTables[num];
                num++;
            }
            num = 0;
            if (mathVariantsTable.horizCoverage != null) {
                foreach (ushort item6 in mathVariantsTable.horizCoverage.GetExpandedValueIter ()) {
                    GetMathGlyphOrCreateNew (array, item6).HoriGlyphConstruction = mathVariantsTable.horizConstructionTables[num];
                    num++;
                }
            }
            for (int num2 = rawGlyphList.Length - 1; num2 >= 0; num2--) {
                rawGlyphList[num2].MathGlyphInfo = array[num2];
            }
        }
    }
}