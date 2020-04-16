using System;
using Anura.JavaScript.Native;
using Anura.JavaScript.Runtime.Interop;

namespace Anura.JavaScript.Runtime.Descriptors.Specialized {
    public sealed class ClrAccessDescriptor : PropertyDescriptor {
        public ClrAccessDescriptor (Engine engine, Func<JsValue, JsValue> get) : this (engine, get, null) { }

        public ClrAccessDescriptor (Engine engine, Func<JsValue, JsValue> get, Action<JsValue, JsValue> set) : base (
            get: new GetterFunctionInstance (engine, get),
            set : set == null ? Native.Undefined.Instance : new SetterFunctionInstance (engine, set)
        ) { }
    }
}