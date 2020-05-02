namespace Anura.Typography.TextLayout {
    public struct GlyphPlanSequencePixelScaleLayout {
        private GlyphPlanSequence _seq;

        private float _pxscale;

        private float _accW;

        private int _index;

        private int _end;

        private float _exactX;

        private float _exactY;

        private ushort _currentGlyphIndex;

        public int CurrentIndex => _index;

        public PxScaledGlyphPlan GlyphPlan {
            get {
                UnscaledGlyphPlan unscaledGlyphPlan = _seq[_index];
                float advanceW = (float) unscaledGlyphPlan.AdvanceX * _pxscale;
                return new PxScaledGlyphPlan (unscaledGlyphPlan.input_cp_offset, unscaledGlyphPlan.glyphIndex, advanceW, (float) unscaledGlyphPlan.OffsetX * _pxscale, (float) unscaledGlyphPlan.OffsetY * _pxscale);
            }
        }

        public float AccumWidth => _accW;

        public float ExactX => _exactX;

        public float ExactY => _exactY;

        public ushort CurrentGlyphIndex => _currentGlyphIndex;

        public GlyphPlanSequencePixelScaleLayout (GlyphPlanSequence glyphPlans, float pxscale) {
            _seq = glyphPlans;
            _pxscale = pxscale;
            _accW = 0f;
            _index = glyphPlans.startAt;
            _end = glyphPlans.startAt + glyphPlans.len;
            _exactX = (_exactY = 0f);
            _currentGlyphIndex = 0;
        }

        public bool Read () {
            if (_index >= _end) {
                return false;
            }
            UnscaledGlyphPlan unscaledGlyphPlan = _seq[_index];
            float num = (float) unscaledGlyphPlan.AdvanceX * _pxscale;
            _exactX = _accW + (float) (unscaledGlyphPlan.AdvanceX + unscaledGlyphPlan.OffsetX) * _pxscale;
            _exactY = (float) unscaledGlyphPlan.OffsetY * _pxscale;
            _accW += num;
            _currentGlyphIndex = unscaledGlyphPlan.glyphIndex;
            _index++;
            return true;
        }
    }
}