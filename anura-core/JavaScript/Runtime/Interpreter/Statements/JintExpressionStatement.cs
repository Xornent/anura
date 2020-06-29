using Anura.JavaScript.Runtime.Interpreter.Expressions;
using Esprima.Ast;

namespace Anura.JavaScript.Runtime.Interpreter.Statements
{
    internal sealed class JintExpressionStatement : JintStatement<ExpressionStatement>
    {
        private readonly JintExpression _expression;

        public JintExpressionStatement(Engine engine, ExpressionStatement statement) : base(engine, statement) {
            _expression = JintExpression.Build(engine, statement.Expression);
        }

        protected override Completion ExecuteInternal() {
            var value = _expression.GetValue();
            return new Completion(CompletionType.Normal, value, null, Location);
        }
    }
}