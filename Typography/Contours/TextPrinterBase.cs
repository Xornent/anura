using Anura.Typography.OpenFont;
using Anura.Typography.TextLayout;

namespace Anura.Typography.Contours {
    public abstract class TextPrinterBase {
        private HintTechnique _hintTech;

        private float _fontSizeInPoints;

        public abstract GlyphLayout GlyphLayoutMan {
            get;
        }

        public abstract Typeface Typeface {
            get;
            set;
        }

        public bool FillBackground {
            get;
            set;
        }

        public bool DrawOutline {
            get;
            set;
        }

        public float FontAscendingPx {
            get;
            set;
        }

        public float FontDescedingPx {
            get;
            set;
        }

        public float FontLineGapPx {
            get;
            set;
        }

        public float FontLineSpacingPx {
            get;
            set;
        }

        public bool SimulateSlant {
            get;
            set;
        }

        public HintTechnique HintTechnique {
            get {
                return _hintTech;
            }
            set {
                _hintTech = value;
            }
        }

        public float FontSizeInPoints {
            get {
                return _fontSizeInPoints;
            }
            set {
                if (_fontSizeInPoints != value) {
                    _fontSizeInPoints = value;
                    OnFontSizeChanged ();
                }
            }
        }

        public ScriptLang ScriptLang {
            get;
            set;
        }

        public PositionTechnique PositionTechnique {
            get;
            set;
        }

        public bool EnableLigature {
            get;
            set;
        }

        public TextPrinterBase () {
            FontSizeInPoints = 14f;
            ScriptLang = ScriptLangs.Latin;
        }

        public virtual void GenerateGlyphPlan (char[] textBuffer, int startAt, int len, IUnscaledGlyphPlanList unscaledGlyphPlan) {
            GlyphLayout glyphLayoutMan = GlyphLayoutMan;
            glyphLayoutMan.Layout (textBuffer, startAt, len);
            glyphLayoutMan.GenerateUnscaledGlyphPlans (unscaledGlyphPlan);
        }

        protected virtual void OnFontSizeChanged () { }

        public abstract void DrawString (char[] textBuffer, int startAt, int len, float left, float top);

        public abstract void DrawFromGlyphPlans (GlyphPlanSequence glyphPlanList, int startAt, int len, float left, float top);

        public abstract void DrawCaret (float x, float y);

        public void DrawString (char[] textBuffer, float left, float top) {
            DrawString (textBuffer, 0, textBuffer.Length, left, top);
        }

        public void DrawFromGlyphPlans (GlyphPlanSequence glyphPlanSeq, float left, float top) {
            DrawFromGlyphPlans (glyphPlanSeq, 0, glyphPlanSeq.Count, left, top);
        }
    }
}