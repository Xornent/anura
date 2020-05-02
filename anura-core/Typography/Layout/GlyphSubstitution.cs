using System.Collections.Generic;
using Anura.Typography.OpenFont;
using Anura.Typography.OpenFont.Tables;

namespace Anura.Typography.TextLayout {
    internal class GlyphSubstitution {
        private readonly string _language;

        private bool _enableLigation = true;

        private bool _enableComposition = true;

        private bool _mustRebuildTables = true;

        private Typeface _typeface;

        private List<GSUB.LookupTable> _lookupTables = new List<GSUB.LookupTable> ();

        public string Lang => _language;

        public bool EnableLigation {
            get {
                return _enableLigation;
            }
            set {
                if (value != _enableLigation) {
                    _mustRebuildTables = true;
                }
                _enableLigation = value;
            }
        }

        public bool EnableComposition {
            get {
                return _enableComposition;
            }
            set {
                if (value != _enableComposition) {
                    _mustRebuildTables = true;
                }
                _enableComposition = value;
            }
        }

        public GlyphSubstitution (Typeface typeface, string lang) {
            _language = lang;
            _typeface = typeface;
            _mustRebuildTables = true;
        }

        public void DoSubstitution (IGlyphIndexList codePoints) {
            if (_mustRebuildTables) {
                RebuildTables ();
                _mustRebuildTables = false;
            }
            foreach (GSUB.LookupTable lookupTable in _lookupTables) {
                for (int i = 0; i < codePoints.Count; i++) {
                    lookupTable.DoSubstitutionAt (codePoints, i, codePoints.Count - i);
                }
            }
        }

        private void RebuildTables () {
            _lookupTables.Clear ();
            GSUB gSUBTable = _typeface.GSUBTable;
            ScriptTable scriptTable = gSUBTable.ScriptList[_language];
            if (scriptTable == null) {
                return;
            }
            ScriptTable.LangSysTable langSysTable = null;
            langSysTable = ((scriptTable.langSysTables == null || scriptTable.langSysTables.Length == 0) ? scriptTable.defaultLang : scriptTable.langSysTables[0]);
            bool hasRequireFeature = langSysTable.HasRequireFeature;
            if (langSysTable.featureIndexList == null) {
                return;
            }
            ushort[] featureIndexList = langSysTable.featureIndexList;
            foreach (ushort num in featureIndexList) {
                FeatureList.FeatureTable featureTable = gSUBTable.FeatureList.featureTables[num];
                bool flag = false;
                switch (featureTable.TagName) {
                    case "ccmp":
                        flag = EnableComposition;
                        break;
                    case "liga":
                        flag = EnableLigation;
                        break;
                }
                if (flag) {
                    ushort[] lookupListIndices = featureTable.LookupListIndices;
                    foreach (ushort index in lookupListIndices) {
                        _lookupTables.Add (gSUBTable.LookupList[index]);
                    }
                }
            }
        }

        public void CollectAdditionalSubstitutionGlyphIndices (List<ushort> outputGlyphIndices) {
            if (_mustRebuildTables) {
                RebuildTables ();
                _mustRebuildTables = false;
            }
            foreach (GSUB.LookupTable lookupTable in _lookupTables) {
                lookupTable.CollectAssociatedSubstitutionGlyph (outputGlyphIndices);
            }
        }
    }
}