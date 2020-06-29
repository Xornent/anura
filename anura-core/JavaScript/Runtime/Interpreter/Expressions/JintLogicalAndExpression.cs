using Anura.JavaScript.Native;
using Esprima.Ast;

namespace Anura.JavaScript.Runtime.Interpreter.Expressions
{
    internal sealed class JintLogicalAndExpression : JintExpression
    {
        private readonly JintExpression _left;
        private readonly JintExpression _right;

        public JintLogicalAndExpression(Engine engine, BinaryExpression expression) : base(engine, expression) {
            _left = Build(engine, expression.Left);
            _right = Build(engine, expression.Right);
        }

        protected override object EvaluateInternal() {
            var left = _left.GetValue();

            if (left is JsBoolean b && !b._value) {
                return b;
            }

            if (!TypeConverter.ToBoolean(left)) {
                return left;
            }

            return _right.GetValue();
        }
    }
}