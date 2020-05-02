using System;
using Anura.JavaScript.Native;
using Anura.JavaScript.Native.Function;

namespace Anura.JavaScript.Runtime.Interop
{
    /// <summary>
    /// Represents a FunctionInstance wrapping a Clr getter.
    /// </summary>
    public sealed class GetterFunctionInstance: FunctionInstance
    {
        private readonly Func<JsValue, JsValue> _getter;

        public GetterFunctionInstance(Engine engine, Func<JsValue, JsValue> getter)
            : base(engine, "get", null, null, false)
        {
            _getter = getter;
        }

        public override JsValue Call(JsValue thisObject, JsValue[] arguments)
        {
            return _getter(thisObject);
        }
    }
}
