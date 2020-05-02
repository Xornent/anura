using Anura.JavaScript.Runtime.Environments;

namespace Anura.JavaScript.Native.Function
{
    public sealed class FunctionShim : FunctionInstance
    {
        public FunctionShim(Engine engine, string[] parameters, LexicalEnvironment scope)
            : base(engine, "function", parameters, scope, false)
        {
        }

        public override JsValue Call(JsValue thisObject, JsValue[] arguments)
        {
            return Undefined;
        }
    }
}
