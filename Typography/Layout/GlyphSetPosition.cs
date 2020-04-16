using System.Collections.Generic;
using Anura.Typography.OpenFont;
using Anura.Typography.OpenFont.Tables;

namespace Anura.Typography.TextLayout {
    internal class GlyphSetPosition {
        private Typeface _typeface;

        private GPOS _gposTable;

        private List<GPOS.LookupTable> _lookupTables;

        public string Lang {
            get;
            private set;
        }

        public GlyphSetPosition (Typeface typeface, string lang) {
            Lang = lang;
            _typeface = typeface;
            _gposTable = typeface.GPOSTable;
            if (_gposTable == null) {
                return;
            }
            ScriptTable scriptTable = _gposTable.ScriptList[lang];
            if (scriptTable == null) {
                return;
            }
            ScriptTable.LangSysTable defaultLang = scriptTable.defaultLang;
            if (defaultLang == null) {
                return;
            }
            bool hasRequireFeature = defaultLang.HasRequireFeature;
            if (defaultLang.featureIndexList == null) {
                return;
            }
            List<FeatureList.FeatureTable> list = new List<FeatureList.FeatureTable> ();
            for (int i = 0; i < defaultLang.featureIndexList.Length; i++) {
                FeatureList.FeatureTable featureTable = _gposTable.FeatureList.featureTables[defaultLang.featureIndexList[i]];
                switch (featureTable.TagName) {
                    case "mark":
                    case "mkmk":
                        list.Add (featureTable);
                        break;
                    case "kern":
                        list.Add (featureTable);
                        break;
                }
            }
            _lookupTables = new List<GPOS.LookupTable> ();
            int count = list.Count;
            for (int j = 0; j < count; j++) {
                ushort[] lookupListIndices = list[j].LookupListIndices;
                foreach (ushort index in lookupListIndices) {
                    _lookupTables.Add (_gposTable.LookupList[index]);
                }
            }
        }

        public void DoGlyphPosition (IGlyphPositions glyphPositions) {
            if (_lookupTables != null) {
                int count = _lookupTables.Count;
                for (int i = 0; i < count; i++) {
                    _lookupTables[i].DoGlyphPosition (glyphPositions, 0, glyphPositions.Count);
                }
            }
        }
    }
}