namespace Anura.Typography.OpenFont {
    public struct Bounds {
        private readonly short _xmin;

        private readonly short _ymin;

        private readonly short _xmax;

        private readonly short _ymax;

        public static readonly Bounds Zero = new Bounds (0, 0, 0, 0);

        public short XMin => _xmin;

        public short YMin => _ymin;

        public short XMax => _xmax;

        public short YMax => _ymax;

        public Bounds (short xmin, short ymin, short xmax, short ymax) {
            _xmin = xmin;
            _ymin = ymin;
            _xmax = xmax;
            _ymax = ymax;
        }
    }
}