namespace Anura.Typography.TextLayout {
    public struct MeasuredStringBox {
        public readonly float width;

        private readonly float _pxscale;

        private readonly short _ascending;

        private readonly short _descending;

        private readonly short _lineGap;

        private readonly short _btbd;

        private ushort _stopAt;

        public float AscendingInPx => (float) _ascending * _pxscale;

        public float DescendingInPx => (float) _descending * _pxscale;

        public float LineGapInPx => (float) _lineGap * _pxscale;

        public float BtbdInPx => (float) _btbd * _pxscale;

        public ushort StopAt {
            get {
                return _stopAt;
            }
            internal set {
                _stopAt = value;
            }
        }

        public MeasuredStringBox (float width, short ascending, short descending, short lineGap, short btbd, float pxscale) {
            this.width = width;
            _stopAt = 0;
            _ascending = ascending;
            _descending = descending;
            _lineGap = lineGap;
            _btbd = btbd;
            _pxscale = pxscale;
        }

        public static MeasuredStringBox operator * (MeasuredStringBox box, float scale) {
            MeasuredStringBox result = new MeasuredStringBox (box.width * scale, box._ascending, box._descending, box._lineGap, box._btbd, box._pxscale * scale);
            result._stopAt = box._stopAt;
            return result;
        }
    }
}