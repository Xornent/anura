using System;

namespace Anura.Typography.TextLayout {
    public struct GlyphPlanSequence {
        public static GlyphPlanSequence Empty;

        private readonly IUnscaledGlyphPlanList _glyphBuffer;

        internal readonly int startAt;

        internal readonly ushort len;

        public UnscaledGlyphPlan this [int index] {
            get {
                if (index >= 0 && index < startAt + len) {
                    return _glyphBuffer[startAt + index];
                }
                throw new IndexOutOfRangeException ();
            }
        }

        public int Count {
            get {
                if (_glyphBuffer == null) {
                    return 0;
                }
                return len;
            }
        }

        public GlyphPlanSequence (IUnscaledGlyphPlanList glyphBuffer) {
            _glyphBuffer = glyphBuffer;
            startAt = 0;
            len = (ushort) glyphBuffer.Count;
        }

        public GlyphPlanSequence (IUnscaledGlyphPlanList glyphBuffer, int startAt, int len) {
            _glyphBuffer = glyphBuffer;
            this.startAt = startAt;
            this.len = (ushort) len;
        }

        public float CalculateWidth () {
            if (_glyphBuffer == null) {
                return 0f;
            }
            IUnscaledGlyphPlanList glyphBuffer = _glyphBuffer;
            int num = startAt + len;
            float num2 = 0f;
            for (int i = startAt; i < num; i++) {
                num2 += (float) glyphBuffer[i].AdvanceX;
            }
            return num2;
        }

        public bool IsEmpty () {
            return _glyphBuffer == null;
        }
    }
}