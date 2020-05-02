using System.Collections.Generic;
using Anura.Typography.OpenFont.CFF;
using Anura.Typography.OpenFont.MathGlyphs;
using Anura.Typography.OpenFont.Tables;

namespace Anura.Typography.OpenFont {
    public class Typeface {
        private readonly Bounds _bounds;

        private readonly ushort _unitsPerEm;

        private readonly Glyph[] _glyphs;

        private readonly HorizontalMetrics _horizontalMetrics;

        private readonly NameEntry _nameEntry;

        private CFFTable _cffTable;

        private const int pointsPerInch = 72;

        internal bool _evalCffGlyphBounds;

        internal MathTable _mathTable;

        internal MathGlyphInfo[] _mathGlyphInfos;

        internal SvgTable _svgTable;

        internal int[] ControlValues {
            get;
            set;
        }

        internal byte[] PrepProgramBuffer {
            get;
            set;
        }

        internal byte[] FpgmProgramBuffer {
            get;
            set;
        }

        internal MaxProfile MaxProfile {
            get;
            set;
        }

        internal Cmap CmapTable {
            get;
            set;
        }

        internal Kern KernTable {
            get;
            set;
        }

        internal Gasp GaspTable {
            get;
            set;
        }

        internal HorizontalHeader HheaTable {
            get;
            set;
        }

        internal OS2Table OS2Table {
            get;
            set;
        }

        public bool HasPrepProgramBuffer => PrepProgramBuffer != null;

        internal CFFTable CffTable => _cffTable;

        public string Filename {
            get;
            set;
        }

        public short Ascender => OS2Table.sTypoAscender;

        public short Descender => OS2Table.sTypoDescender;

        public short LineGap => OS2Table.sTypoLineGap;

        public string Name => _nameEntry.FontName;

        public string FontSubFamily => _nameEntry.FontSubFamily;

        public int GlyphCount => _glyphs.Length;

        public Bounds Bounds => _bounds;

        public ushort UnitsPerEm => _unitsPerEm;

        public Glyph[] Glyphs => _glyphs;

        internal BASE BaseTable {
            get;
            set;
        }

        internal GDEF GDEFTable {
            get;
            set;
        }

        public COLR COLRTable {
            get;
            set;
        }

        public CPAL CPALTable {
            get;
            set;
        }

        public GPOS GPOSTable {
            get;
            set;
        }

        public GSUB GSUBTable {
            get;
            set;
        }

        internal PostTable PostTable {
            get;
            set;
        }

        internal bool IsCffFont => _cffTable != null;

        public MathConstants MathConsts {
            get {
                if (_mathTable == null) {
                    return null;
                }
                return _mathTable._mathConstTable;
            }
        }

        internal Typeface (NameEntry nameEntry, Bounds bounds, ushort unitsPerEm, Glyph[] glyphs, HorizontalMetrics horizontalMetrics, OS2Table os2Table) {
            _nameEntry = nameEntry;
            _bounds = bounds;
            _unitsPerEm = unitsPerEm;
            _glyphs = glyphs;
            _horizontalMetrics = horizontalMetrics;
            OS2Table = os2Table;
        }

        internal Typeface (NameEntry nameEntry, Bounds bounds, ushort unitsPerEm, CFFTable cffTable, HorizontalMetrics horizontalMetrics, OS2Table os2Table) {
            _nameEntry = nameEntry;
            _bounds = bounds;
            _unitsPerEm = unitsPerEm;
            _cffTable = cffTable;
            _horizontalMetrics = horizontalMetrics;
            OS2Table = os2Table;
            _glyphs = _cffTable.Cff1FontSet._fonts[0]._glyphs;
        }

        public ushort LookupIndex (int codepoint, int nextCodepoint = 0) {
            return CmapTable.LookupIndex (codepoint, nextCodepoint);
        }

        public Glyph Lookup (int codepoint) {
            return _glyphs[LookupIndex (codepoint)];
        }

        public Glyph GetGlyphByIndex (ushort glyphIndex) {
            return _glyphs[glyphIndex];
        }

        public Glyph GetGlyphByName (string glyphName) {
            if (_cffTable != null) {
                List<Cff1Font> fonts = _cffTable.Cff1FontSet._fonts;
                for (int i = 0; i < fonts.Count; i++) {
                    Glyph glyphByName = fonts[i].GetGlyphByName (glyphName);
                    if (glyphByName != null) {
                        return glyphByName;
                    }
                }
                return null;
            }
            if (PostTable != null) {
                return GetGlyphByIndex (GetGlyphIndexByName (glyphName));
            }
            return null;
        }

        public ushort GetGlyphIndexByName (string glyphName) {
            if (_cffTable != null) {
                return GetGlyphByName (glyphName)?.GlyphIndex ?? 0;
            }
            if (PostTable != null) {
                if (PostTable.Version == 2) {
                    return PostTable.GetGlyphIndex (glyphName);
                }
                return LookupIndex (AdobeGlyphList.GetUnicodeValueByGlyphName (glyphName));
            }
            return 0;
        }

        public ushort GetAdvanceWidth (int codepoint) {
            return _horizontalMetrics.GetAdvanceWidth (LookupIndex (codepoint));
        }

        public ushort GetHAdvanceWidthFromGlyphIndex (ushort glyphIndex) {
            return _horizontalMetrics.GetAdvanceWidth (glyphIndex);
        }

        public short GetHFrontSideBearingFromGlyphIndex (ushort glyphIndex) {
            return _horizontalMetrics.GetLeftSideBearing (glyphIndex);
        }

        public short GetKernDistance (ushort leftGlyphIndex, ushort rightGlyphIndex) {
            return KernTable.GetKerningDistance (leftGlyphIndex, rightGlyphIndex);
        }

        public static float ConvPointsToPixels (float targetPointSize, int resolution = 96) {
            return targetPointSize * (float) resolution / 72f;
        }

        public float CalculateScaleToPixel (float targetPixelSize) {
            return targetPixelSize / (float) (int) UnitsPerEm;
        }

        public float CalculateScaleToPixelFromPointSize (float targetPointSize, int resolution = 96) {
            return targetPointSize * (float) resolution / 72f / (float) (int) UnitsPerEm;
        }

        internal void LoadOpenFontLayoutInfo (GDEF gdefTable, GSUB gsubTable, GPOS gposTable, BASE baseTable, COLR colrTable, CPAL cpalTable) {
            GDEFTable = gdefTable;
            GSUBTable = gsubTable;
            GPOSTable = gposTable;
            BaseTable = baseTable;
            COLRTable = colrTable;
            CPALTable = cpalTable;
            gdefTable?.FillGlyphData (Glyphs);
        }

        internal Glyph[] GetRawGlyphList () {
            return _glyphs;
        }
    }
}