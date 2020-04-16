using Anura.Typography.OpenFont.MathGlyphs;

namespace Anura.Typography.OpenFont.Tables {
    internal class MathVariantsTable {
        public ushort MinConnectorOverlap;

        public CoverageTable vertCoverage;

        public CoverageTable horizCoverage;

        public MathGlyphConstruction[] vertConstructionTables;

        public MathGlyphConstruction[] horizConstructionTables;
    }
}