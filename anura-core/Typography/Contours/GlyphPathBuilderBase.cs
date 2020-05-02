using Anura.Typography.OpenFont;
using Anura.Typography.OpenFont.CFF;

namespace Anura.Typography.Contours {
    public abstract class GlyphPathBuilderBase {
        private readonly Typeface _typeface;

        private TrueTypeInterpreter _trueTypeInterpreter;

        protected GlyphPointF[] _outputGlyphPoints;

        protected ushort[] _outputContours;

        protected Cff1Font _ownerCff;

        protected Cff1GlyphData _cffGlyphData;

        private float _recentPixelScale;

        private bool _useInterpreter;

        private CffEvaluationEngine _cffEvalEngine = new CffEvaluationEngine ();

        public Typeface Typeface => _typeface;

        public bool UseVerticalHinting {
            get;
            set;
        }

        public bool UseTrueTypeInstructions {
            get {
                return _useInterpreter;
            }
            set {
                _useInterpreter = value;
            }
        }

        protected bool IsSizeChanged {
            get;
            set;
        }

        protected float RecentFontSizeInPixels {
            get;
            private set;
        }

        public GlyphPathBuilderBase (Typeface typeface) {
            _typeface = typeface;
            UseTrueTypeInstructions = true;
            _recentPixelScale = 1f;
        }

        public void BuildFromGlyphIndex (ushort glyphIndex, float sizeInPoints) {
            BuildFromGlyph (_typeface.GetGlyphByIndex (glyphIndex), sizeInPoints);
        }

        public void BuildFromGlyph (Glyph glyph, float sizeInPoints) {
            _outputGlyphPoints = glyph.GlyphPoints;
            _outputContours = glyph.EndPoints;
            if (glyph.IsCffGlyph) {
                _cffGlyphData = glyph.GetCff1GlyphData ();
                _ownerCff = glyph.GetOwnerCff ();
            }
            float num2 = RecentFontSizeInPixels = Typeface.ConvPointsToPixels (sizeInPoints);
            if (num2 < 0f) {
                _recentPixelScale = 1f;
            } else {
                _recentPixelScale = Typeface.CalculateScaleToPixel (RecentFontSizeInPixels);
                IsSizeChanged = true;
            }
            FitCurrentGlyph (glyph);
        }

        protected virtual void FitCurrentGlyph (Glyph glyph) {
            if (RecentFontSizeInPixels > 0f && UseTrueTypeInstructions && _typeface.HasPrepProgramBuffer && glyph.HasGlyphInstructions) {
                if (_trueTypeInterpreter == null) {
                    _trueTypeInterpreter = new TrueTypeInterpreter ();
                    _trueTypeInterpreter.SetTypeFace (_typeface);
                }
                _trueTypeInterpreter.UseVerticalHinting = UseVerticalHinting;
                _outputGlyphPoints = _trueTypeInterpreter.HintGlyph (glyph.GlyphIndex, RecentFontSizeInPixels);
                _recentPixelScale = 1f;
            }
        }

        public virtual void ReadShapes (IGlyphTranslator tx) {
            if (_cffGlyphData != null) {
                _cffEvalEngine.Run (tx, _ownerCff, _cffGlyphData, _recentPixelScale);
            } else {
                tx.Read (_outputGlyphPoints, _outputContours, _recentPixelScale);
            }
        }
    }
}