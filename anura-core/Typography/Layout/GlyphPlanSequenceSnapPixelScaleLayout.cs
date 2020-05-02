using System;

namespace Anura.Typography.TextLayout {
    public struct GlyphPlanSequenceSnapPixelScaleLayout {
        private GlyphPlanSequence _seq;

        private float _pxscale;

        private int _accW;

        private int _index;

        private int _end;

        private int _exactX;

        private int _exactY;

        private ushort _currentGlyphIndex;

        public ushort CurrentGlyphIndex => _currentGlyphIndex;

        public int CurrentIndex => _index;

        public int AccumWidth => _accW;

        public int ExactX => _exactX;

        public int ExactY => _exactY;

        public GlyphPlanSequenceSnapPixelScaleLayout (GlyphPlanSequence glyphPlans, float pxscale) {
            _seq = glyphPlans;
            _pxscale = pxscale;
            _accW = 0;
            _index = glyphPlans.startAt;
            _end = glyphPlans.startAt + glyphPlans.len;
            _exactX = (_exactY = 0);
            _currentGlyphIndex = 0;
        }

        public GlyphPlanSequenceSnapPixelScaleLayout (GlyphPlanSequence glyphPlans, int start, int len, float pxscale) {
            _seq = glyphPlans;
            _pxscale = pxscale;
            _accW = 0;
            _index = start;
            _end = start + len;
            _exactX = (_exactY = 0);
            _currentGlyphIndex = 0;
        }

        public bool Read () {
            if (_index >= _end) {
                return false;
            }
            UnscaledGlyphPlan unscaledGlyphPlan = _seq[_index];
            short num = (short) Math.Round ((float) unscaledGlyphPlan.AdvanceX * _pxscale);
            short num2 = (short) Math.Round ((float) unscaledGlyphPlan.OffsetX * _pxscale);
            short exactY = (short) Math.Round ((float) unscaledGlyphPlan.OffsetY * _pxscale);
            _exactX = _accW + num2;
            _exactY = exactY;
            _accW += num;
            _currentGlyphIndex = unscaledGlyphPlan.glyphIndex;
            _index++;
            return true;
        }
    }
}