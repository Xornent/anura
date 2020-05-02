namespace Anura.Typography.OpenFont.MathGlyphs {
    public struct MathValueRecord {
        public readonly short Value;

        public readonly ushort DeviceTable;

        public MathValueRecord (short value, ushort deviceTable) {
            Value = value;
            DeviceTable = deviceTable;
        }
    }
}