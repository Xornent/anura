namespace Anura.Typography.OpenFont.CFF {
    internal struct CffOperand {
        public readonly OperandKind _kind;

        public readonly double _realNumValue;

        public CffOperand (double number, OperandKind kind) {
            _kind = kind;
            _realNumValue = number;
        }
    }
}