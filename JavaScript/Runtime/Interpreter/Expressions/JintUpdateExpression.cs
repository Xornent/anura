using Esprima.Ast;
using Anura.JavaScript.Native;
using Anura.JavaScript.Runtime.References;

namespace Anura.JavaScript.Runtime.Interpreter.Expressions
{
    internal sealed class JintUpdateExpression : JintExpression
    {
        private readonly JintExpression _argument;
        private readonly int _change;
        private readonly bool _prefix;

        private readonly JintIdentifierExpression _leftIdentifier;
        private readonly bool _evalOrArguments;

        public JintUpdateExpression(Engine engine, UpdateExpression expression) : base(engine, expression)
        {
            _prefix = expression.Prefix;
            _argument = Build(engine, expression.Argument);
            if (expression.Operator == UnaryOperator.Increment)
            {
                _change = 1;
            }
            else if (expression.Operator == UnaryOperator.Decrement)
            {
                _change = - 1;
            }
            else
            {
                Anura.JavaScript.Runtime.ExceptionHelper.ThrowArgumentException();
            }

            _leftIdentifier = _argument as JintIdentifierExpression;
            _evalOrArguments = _leftIdentifier?.HasEvalOrArguments == true;
        }

        protected override object EvaluateInternal()
        {
            var fastResult = _leftIdentifier != null
                ? UpdateIdentifier()
                : null;

            return fastResult ?? UpdateNonIdentifier();
        }

        private object UpdateNonIdentifier()
        {
            if (!(_argument.Evaluate() is Reference reference))
            {
                return Anura.JavaScript.Runtime.ExceptionHelper.ThrowTypeError<object>(_engine, "Invalid left-hand side expression");
            }

            reference.AssertValid(_engine);

            var value = _engine.GetValue(reference, false);
            var isInteger = value._type == InternalTypes.Integer;
            var newValue = isInteger
                ? JsNumber.Create(value.AsInteger() + _change)
                : JsNumber.Create(TypeConverter.ToNumber(value) + _change);

            _engine.PutValue(reference, newValue);
            _engine._referencePool.Return(reference);

            return _prefix
                ? newValue
                : (isInteger ? value : JsNumber.Create(TypeConverter.ToNumber(value)));
        }

        private JsValue UpdateIdentifier()
        {
            var strict = StrictModeScope.IsStrictModeCode;
            var name = _leftIdentifier.ExpressionName;
            if (TryGetIdentifierEnvironmentWithBindingValue(
                name,
                out var environmentRecord,
                out var value))
            {
                if (strict && _evalOrArguments)
                {
                    Anura.JavaScript.Runtime.ExceptionHelper.ThrowSyntaxError(_engine);
                }

                var isInteger = value._type == InternalTypes.Integer;
                var newValue = isInteger
                    ? JsNumber.Create(value.AsInteger() + _change)
                    : JsNumber.Create(TypeConverter.ToNumber(value) + _change);

                environmentRecord.SetMutableBinding(name, newValue, strict);
                return _prefix
                    ? newValue
                    : (isInteger ? value : JsNumber.Create(TypeConverter.ToNumber(value)));
            }

            return null;
        }
    }
}