using Anura.JavaScript.Native;
using Esprima.Ast;

namespace Anura.JavaScript.Runtime
{
    public class CallStackElement
    {
        private readonly string _shortDescription;

        public CallStackElement(CallExpression callExpression, JsValue function, string shortDescription) {
            _shortDescription = shortDescription;
            CallExpression = callExpression;
            Function = function;
        }

        public CallExpression CallExpression { get; }

        public JsValue Function { get; }

        public override string ToString() {
            return _shortDescription;
        }
    }
}
