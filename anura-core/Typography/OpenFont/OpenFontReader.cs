using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Anura.Typography.OpenFont.Extensions;
using Anura.Typography.OpenFont.IO;
using Anura.Typography.OpenFont.Tables;
using Anura.Typography.WebFont;

namespace Anura.Typography.OpenFont {
    public class OpenFontReader {
        private class FontCollectionHeader {
            public ushort majorVersion;

            public ushort minorVersion;

            public uint numFonts;

            public int[] offsetTables;

            public uint dsigTag;

            public uint dsigLength;

            public uint dsigOffset;
        }

        private static string BuildTtcfName (PreviewFontInfo[] members) {
            StringBuilder stringBuilder = new StringBuilder ();
            stringBuilder.Append ("TTCF: " + members.Length);
            Dictionary<string, bool> dictionary = new Dictionary<string, bool> ();
            for (uint num = 0u; num < members.Length; num++) {
                PreviewFontInfo previewFontInfo = members[num];
                if (!dictionary.ContainsKey (previewFontInfo.Name)) {
                    dictionary.Add (previewFontInfo.Name, true);
                    stringBuilder.Append ("," + previewFontInfo.Name);
                }
            }
            return stringBuilder.ToString ();
        }

        public PreviewFontInfo ReadPreview (Stream stream) {
            using (ByteOrderSwappingBinaryReader byteOrderSwappingBinaryReader = new ByteOrderSwappingBinaryReader (stream)) {
                ushort u = byteOrderSwappingBinaryReader.ReadUInt16 ();
                ushort u2 = byteOrderSwappingBinaryReader.ReadUInt16 ();
                if (KnownFontFiles.IsTtcf (u, u2)) {
                    FontCollectionHeader fontCollectionHeader = ReadTTCHeader (byteOrderSwappingBinaryReader);
                    PreviewFontInfo[] array = new PreviewFontInfo[fontCollectionHeader.numFonts];
                    for (uint num = 0u; num < fontCollectionHeader.numFonts; num++) {
                        byteOrderSwappingBinaryReader.BaseStream.Seek (fontCollectionHeader.offsetTables[num], SeekOrigin.Begin);
                        (array[num] = ReadActualFontPreview (byteOrderSwappingBinaryReader, false)).ActualStreamOffset = fontCollectionHeader.offsetTables[num];
                    }
                    return new PreviewFontInfo (BuildTtcfName (array), array);
                }
                if (KnownFontFiles.IsWoff (u, u2)) {
                    WoffReader woffReader = new WoffReader ();
                    byteOrderSwappingBinaryReader.BaseStream.Position = 0L;
                    return woffReader.ReadPreview (byteOrderSwappingBinaryReader);
                }
                if (KnownFontFiles.IsWoff2 (u, u2)) {
                    Woff2Reader woff2Reader = new Woff2Reader ();
                    byteOrderSwappingBinaryReader.BaseStream.Position = 0L;
                    return woff2Reader.ReadPreview (byteOrderSwappingBinaryReader);
                }
                return ReadActualFontPreview (byteOrderSwappingBinaryReader, true);
            }
        }

        private FontCollectionHeader ReadTTCHeader (ByteOrderSwappingBinaryReader input) {
            FontCollectionHeader fontCollectionHeader = new FontCollectionHeader ();
            fontCollectionHeader.majorVersion = input.ReadUInt16 ();
            fontCollectionHeader.minorVersion = input.ReadUInt16 ();
            uint num = input.ReadUInt32 ();
            int[] array = new int[num];
            for (uint num2 = 0u; num2 < num; num2++) {
                array[num2] = input.ReadInt32 ();
            }
            fontCollectionHeader.numFonts = num;
            fontCollectionHeader.offsetTables = array;
            if (fontCollectionHeader.majorVersion == 2) {
                fontCollectionHeader.dsigTag = input.ReadUInt32 ();
                fontCollectionHeader.dsigLength = input.ReadUInt32 ();
                fontCollectionHeader.dsigOffset = input.ReadUInt32 ();
                uint dsigTag = fontCollectionHeader.dsigTag;
            }
            return fontCollectionHeader;
        }

        private PreviewFontInfo ReadActualFontPreview (ByteOrderSwappingBinaryReader input, bool skipVersionData) {
            if (!skipVersionData) {
                input.ReadUInt16 ();
                input.ReadUInt16 ();
            }
            ushort num = input.ReadUInt16 ();
            input.ReadUInt16 ();
            input.ReadUInt16 ();
            input.ReadUInt16 ();
            TableEntryCollection tableEntryCollection = new TableEntryCollection ();
            for (int i = 0; i < num; i++) {
                tableEntryCollection.AddEntry (new UnreadTableEntry (ReadTableHeader (input)));
            }
            return ReadPreviewFontInfo (tableEntryCollection, input);
        }

        public Typeface Read (Stream stream, int streamStartOffset = 0, ReadFlags readFlags = ReadFlags.Full) {
            if (streamStartOffset > 0) {
                stream.Seek (streamStartOffset, SeekOrigin.Begin);
            }
            using (ByteOrderSwappingBinaryReader byteOrderSwappingBinaryReader = new ByteOrderSwappingBinaryReader (stream)) {
                ushort u = byteOrderSwappingBinaryReader.ReadUInt16 ();
                ushort u2 = byteOrderSwappingBinaryReader.ReadUInt16 ();
                if (KnownFontFiles.IsTtcf (u, u2)) {
                    return null;
                }
                if (KnownFontFiles.IsWoff (u, u2)) {
                    WoffReader woffReader = new WoffReader ();
                    byteOrderSwappingBinaryReader.BaseStream.Position = 0L;
                    return woffReader.Read (byteOrderSwappingBinaryReader);
                }
                if (KnownFontFiles.IsWoff2 (u, u2)) {
                    Woff2Reader woff2Reader = new Woff2Reader ();
                    byteOrderSwappingBinaryReader.BaseStream.Position = 0L;
                    return woff2Reader.Read (byteOrderSwappingBinaryReader);
                }
                ushort num = byteOrderSwappingBinaryReader.ReadUInt16 ();
                byteOrderSwappingBinaryReader.ReadUInt16 ();
                byteOrderSwappingBinaryReader.ReadUInt16 ();
                byteOrderSwappingBinaryReader.ReadUInt16 ();
                TableEntryCollection tableEntryCollection = new TableEntryCollection ();
                for (int i = 0; i < num; i++) {
                    tableEntryCollection.AddEntry (new UnreadTableEntry (ReadTableHeader (byteOrderSwappingBinaryReader)));
                }
                return ReadTableEntryCollection (tableEntryCollection, byteOrderSwappingBinaryReader);
            }
        }

        internal PreviewFontInfo ReadPreviewFontInfo (TableEntryCollection tables, BinaryReader input) {
            NameEntry nameEntry = ReadTableIfExists (tables, input, new NameEntry ());
            OS2Table oS2Table = ReadTableIfExists (tables, input, new OS2Table ());
            return new PreviewFontInfo (nameEntry.FontName, nameEntry.FontSubFamily, oS2Table.usWeightClass, TypefaceExtensions.TranslatedOS2FontStyle (oS2Table));
        }

        internal Typeface ReadTableEntryCollection (TableEntryCollection tables, BinaryReader input) {
            OS2Table os2Table = ReadTableIfExists (tables, input, new OS2Table ());
            NameEntry nameEntry = ReadTableIfExists (tables, input, new NameEntry ());
            Head head = ReadTableIfExists (tables, input, new Head ());
            MaxProfile maxProfile = ReadTableIfExists (tables, input, new MaxProfile ());
            HorizontalHeader horizontalHeader = ReadTableIfExists (tables, input, new HorizontalHeader ());
            HorizontalMetrics horizontalMetrics = ReadTableIfExists (tables, input, new HorizontalMetrics (horizontalHeader.HorizontalMetricsCount, maxProfile.GlyphCount));
            PostTable postTable = ReadTableIfExists (tables, input, new PostTable ());
            CFFTable cFFTable = ReadTableIfExists (tables, input, new CFFTable ());
            Cmap cmapTable = ReadTableIfExists (tables, input, new Cmap ());
            GlyphLocations glyphLocations = ReadTableIfExists (tables, input, new GlyphLocations (maxProfile.GlyphCount, head.WideGlyphLocations));
            Glyf glyf = ReadTableIfExists (tables, input, new Glyf (glyphLocations));
            Gasp gaspTable = ReadTableIfExists (tables, input, new Gasp ());
            ReadTableIfExists (tables, input, new VerticalDeviceMetrics ());
            Kern kernTable = ReadTableIfExists (tables, input, new Kern ());
            GDEF gdefTable = ReadTableIfExists (tables, input, new GDEF ());
            GSUB gsubTable = ReadTableIfExists (tables, input, new GSUB ());
            GPOS gposTable = ReadTableIfExists (tables, input, new GPOS ());
            BASE baseTable = ReadTableIfExists (tables, input, new BASE ());
            COLR colrTable = ReadTableIfExists (tables, input, new COLR ());
            CPAL cpalTable = ReadTableIfExists (tables, input, new CPAL ());
            VerticalHeader verticalHeader = ReadTableIfExists (tables, input, new VerticalHeader ());
            if (verticalHeader != null) {
                ReadTableIfExists (tables, input, new VerticalMetrics (verticalHeader.NumOfLongVerMetrics));
            }
            MathTable mathTable = ReadTableIfExists (tables, input, new MathTable ());
            ReadTableIfExists (tables, input, new EBLCTable ());
            Typeface typeface = null;
            bool flag = false;
            if (glyf == null) {
                if (cFFTable == null) {
                    throw new NotSupportedException ();
                }
                flag = true;
                typeface = new Typeface (nameEntry, head.Bounds, head.UnitsPerEm, cFFTable, horizontalMetrics, os2Table);
            } else {
                typeface = new Typeface (nameEntry, head.Bounds, head.UnitsPerEm, glyf.Glyphs, horizontalMetrics, os2Table);
            }
            typeface.CmapTable = cmapTable;
            typeface.KernTable = kernTable;
            typeface.GaspTable = gaspTable;
            typeface.MaxProfile = maxProfile;
            typeface.HheaTable = horizontalHeader;
            if (!flag) {
                FpgmTable fpgmTable = ReadTableIfExists (tables, input, new FpgmTable ());
                CvtTable cvtTable = ReadTableIfExists (tables, input, new CvtTable ());
                if (cvtTable != null) {
                    typeface.ControlValues = cvtTable._controlValues;
                }
                if (fpgmTable != null) {
                    typeface.FpgmProgramBuffer = fpgmTable._programBuffer;
                }
                PrepTable prepTable = ReadTableIfExists (tables, input, new PrepTable ());
                if (prepTable != null) {
                    typeface.PrepProgramBuffer = prepTable._programBuffer;
                }
            }
            typeface.LoadOpenFontLayoutInfo (gdefTable, gsubTable, gposTable, baseTable, colrTable, cpalTable);
            SvgTable svgTable = ReadTableIfExists (tables, input, new SvgTable ());
            if (svgTable != null) {
                typeface._svgTable = svgTable;
            }
            typeface.PostTable = postTable;
            if (mathTable != null) {
                default (MathGlyphLoader).LoadMathGlyph (typeface, mathTable);
            }
            return typeface;
        }

        private static TableHeader ReadTableHeader (BinaryReader input) {
            return new TableHeader (input.ReadUInt32 (), input.ReadUInt32 (), input.ReadUInt32 (), input.ReadUInt32 ());
        }

        private static T ReadTableIfExists<T> (TableEntryCollection tables, BinaryReader reader, T resultTable) where T : TableEntry {
            if (tables.TryGetTable (resultTable.Name, out TableEntry entry)) {
                if (entry is UnreadTableEntry) {
                    UnreadTableEntry unreadTableEntry = entry as UnreadTableEntry;
                    resultTable.Header = entry.Header;
                    if (unreadTableEntry.HasCustomContentReader) {
                        resultTable = unreadTableEntry.CreateTableEntry (reader, resultTable);
                    } else {
                        resultTable.LoadDataFrom (reader);
                    }
                    tables.ReplaceTable (resultTable);
                    return resultTable;
                }
                throw new NotSupportedException ();
            }
            return null;
        }
    }
}