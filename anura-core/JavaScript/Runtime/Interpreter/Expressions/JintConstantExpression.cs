using Anura.JavaScript.Native;
using Esprima.Ast;

namespace Anura.JavaScript.Runtime.Interpreter.Expressions
{
    /// <summary>
    /// Constant JsValue returning expression.
    /// </summary>
    internal sealed class JintConstantExpression : JintExpression
    {
        private readonly JsValue _value;

        public JintConstantExpression(Engine engine, INode expression, JsValue value) : base(engine, expression) {
            _value = value;
        }

        /// <summary>
        /// Resolves the underlying value for this expression.
        /// By default uses the Engine for resolving.
        /// </summary>
        /// <seealso cref="JintLiteralExpression"/>
        public override JsValue GetValue() {
            // need to notify correct node when taking shortcut
            _engine._lastSyntaxNode = _expression;

            return _value;
        }

        protected override object EvaluateInternal() {
            return _value;
        }
    }
}