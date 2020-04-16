using System.Collections.Generic;
using Anura.Typography.OpenFont;

namespace Anura.Typography.TextLayout {
    public class GlyphLayout {
        private GlyphLayoutPlanCollection _layoutPlanCollection = new GlyphLayoutPlanCollection ();

        private Typeface _typeface;

        private ScriptLang _scriptLang;

        private GlyphSubstitution _gsub;

        private GlyphSetPosition _gpos;

        private bool _needPlanUpdate;

        private GlyphIndexList _inputGlyphs = new GlyphIndexList ();

        private GlyphPosStream _glyphPositions = new GlyphPosStream ();

        private List<int> _reusableUserCodePoints = new List<int> ();

        internal IGlyphPositions ResultUnscaledGlyphPositions => _glyphPositions;

        public PositionTechnique PositionTechnique {
            get;
            set;
        }

        public ScriptLang ScriptLang {
            get {
                return _scriptLang;
            }
            set {
                if (_scriptLang != value) {
                    _needPlanUpdate = true;
                }
                _scriptLang = value;
            }
        }

        public bool EnableLigature {
            get;
            set;
        }

        public bool EnableComposition {
            get;
            set;
        }

        public Typeface Typeface {
            get {
                return _typeface;
            }
            set {
                if (_typeface != value) {
                    _typeface = value;
                    _needPlanUpdate = true;
                }
            }
        }

        public GlyphLayout () {
            PositionTechnique = PositionTechnique.OpenFont;
            EnableLigature = true;
            EnableComposition = true;
            ScriptLang = ScriptLangs.Latin;
        }

        public void Layout (char[] str, int startAt, int len) {
            _reusableUserCodePoints.Clear ();
            for (int i = 0; i < len; i++) {
                char c = str[startAt + i];
                int item = c;
                if (c >= '\ud800' && c <= '\udbff' && i + 1 < len) {
                    char c2 = str[startAt + i + 1];
                    if (c2 >= '\udc00' && c2 <= '\udfff') {
                        i++;
                        item = char.ConvertToUtf32 (c, c2);
                    }
                }
                _reusableUserCodePoints.Add (item);
            }
            Layout (_reusableUserCodePoints);
        }

        public void Layout (IList<int> inputCodePoints) {
            Layout (inputCodePoints, 0, inputCodePoints.Count);
        }

        public void Layout (IList<int> inputCodePoints, int startAt, int len) {
            _inputGlyphs.Clear ();
            int num = startAt + len;
            for (int i = 0; i < num; i++) {
                ushort glyphIndex = _typeface.LookupIndex (inputCodePoints[i]);
                if (i + 1 < num) {
                    ushort num2 = _typeface.LookupIndex (inputCodePoints[i], inputCodePoints[i + 1]);
                    if (num2 > 0) {
                        glyphIndex = num2;
                        _inputGlyphs.AddGlyph (i, glyphIndex);
                        i++;
                        continue;
                    }
                }
                _inputGlyphs.AddGlyph (i, glyphIndex);
            }
            Layout (_inputGlyphs);
        }

        private void Layout (GlyphIndexList glyphs) {
            if (_needPlanUpdate) {
                UpdateLayoutPlan ();
            }
            if (_gsub != null && glyphs.Count > 0) {
                _gsub.EnableLigation = EnableLigature;
                _gsub.EnableComposition = EnableComposition;
                _gsub.DoSubstitution (glyphs);
            }
            int count = glyphs.Count;
            _glyphPositions.Clear ();
            _glyphPositions.Typeface = _typeface;
            for (int i = 0; i < count; i++) {
                glyphs.GetGlyphIndexAndMap (i, out ushort glyphIndex, out ushort input_codepointOffset, out ushort _);
                Glyph glyphByIndex = _typeface.GetGlyphByIndex (glyphIndex);
                _glyphPositions.AddGlyph (input_codepointOffset, glyphIndex, glyphByIndex);
            }
            PositionTechnique positionTechnique = PositionTechnique;
            if (_gpos != null && glyphs.Count > 1 && positionTechnique == PositionTechnique.OpenFont) {
                _gpos.DoGlyphPosition (_glyphPositions);
            }
        }

        public void CreateMapFromUserCharToGlyphIndices (List<UserCodePointToGlyphIndex> outputUserCharToGlyphIndexMapList) {
            _inputGlyphs.CreateMapFromUserCodePointToGlyphIndices (outputUserCharToGlyphIndexMapList);
        }

        private void UpdateLayoutPlan () {
            GlyphLayoutPlanContext planOrCreate = _layoutPlanCollection.GetPlanOrCreate (_typeface, _scriptLang);
            _gpos = planOrCreate._glyphPos;
            _gsub = planOrCreate._glyphSub;
            _needPlanUpdate = false;
        }

        public void GenerateUnscaledGlyphPlans (IUnscaledGlyphPlanList outputGlyphPlanList) {
            IGlyphPositions glyphPositions = _glyphPositions;
            int count = glyphPositions.Count;
            for (int i = 0; i < count; i++) {
                ushort inputOffset;
                short offsetX;
                short offsetY;
                short advW;
                ushort glyph = glyphPositions.GetGlyph (i, out inputOffset, out offsetX, out offsetY, out advW);
                outputGlyphPlanList.Append (new UnscaledGlyphPlan (inputOffset, glyph, advW, offsetX, offsetY));
            }
        }

        public IEnumerable<UnscaledGlyphPlan> GetUnscaledGlyphPlanIter () {
            IGlyphPositions glyphPositions = _glyphPositions;
            int finalGlyphCount = glyphPositions.Count;
            int num;
            for (int i = 0; i < finalGlyphCount; i = num) {
                ushort inputOffset;
                short offsetX;
                short offsetY;
                short advW;
                ushort glyph = glyphPositions.GetGlyph (i, out inputOffset, out offsetX, out offsetY, out advW);
                yield return new UnscaledGlyphPlan (inputOffset, glyph, advW, offsetX, offsetY);
                num = i + 1;
            }
        }
    }
}