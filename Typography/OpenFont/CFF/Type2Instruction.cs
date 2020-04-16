namespace Anura.Typography.OpenFont.CFF {
    internal struct Type2Instruction {
        public readonly int Value;

        public readonly OperatorName Op;

        public Type2Instruction (OperatorName op, int value) {
            Op = op;
            Value = value;
        }

        public Type2Instruction (OperatorName op) {
            Op = op;
            Value = 0;
        }
    }
}