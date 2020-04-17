using Anura.JavaScript.Runtime;
using Anura.JavaScript.Runtime.Descriptors;

namespace Anura.JavaScript.Native.Function
{
    public sealed class ThrowTypeError : FunctionInstance
    {
        private static readonly JsString _functionName = new JsString("throwTypeError");

        public ThrowTypeError(Engine engine)
            : base(engine, _functionName, System.Array.Empty<string>(), engine.GlobalEnvironment, false)
        {
            _length = PropertyDescriptor.AllForbiddenDescriptor.NumberZero;
            PreventExtensions();
        }

        public override JsValue Call(JsValue thisObject, JsValue[] arguments)
        {
            return Anura.JavaScript.Runtime.ExceptionHelper.ThrowTypeError<JsValue>(_engine);
        }
    }
}
