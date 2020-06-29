using Anura.JavaScript.Native;
using Anura.JavaScript.Native.Function;
using Anura.JavaScript.Runtime.Descriptors;
using System;

namespace Anura.JavaScript.Runtime.Interop
{
    /// <summary>
    /// Wraps a Clr method into a FunctionInstance
    /// </summary>
    public sealed class ClrFunctionInstance : FunctionInstance, IEquatable<ClrFunctionInstance>
    {
        internal readonly Func<JsValue, JsValue[], JsValue> _func;

        public ClrFunctionInstance(
            Engine engine,
            string name,
            Func<JsValue, JsValue[], JsValue> func,
            int length = 0,
            PropertyFlag lengthFlags = PropertyFlag.AllForbidden)
            : base(engine, !string.IsNullOrWhiteSpace(name) ? new JsString(name) : null, strict: false) {
            _func = func;

            _prototype = engine.Function.PrototypeObject;

            _length = lengthFlags == PropertyFlag.AllForbidden
                ? PropertyDescriptor.AllForbiddenDescriptor.ForNumber(length)
                : new PropertyDescriptor(JsNumber.Create(length), lengthFlags);
        }

        public override JsValue Call(JsValue thisObject, JsValue[] arguments) {
            return _func(thisObject, arguments);
        }

        public override bool Equals(JsValue obj) {
            if (ReferenceEquals(null, obj)) {
                return false;
            }

            if (!(obj is ClrFunctionInstance s)) {
                return false;
            }

            return Equals(s);
        }

        public bool Equals(ClrFunctionInstance other) {
            if (ReferenceEquals(null, other)) {
                return false;
            }

            if (ReferenceEquals(this, other)) {
                return true;
            }

            if (_func == other._func) {
                return true;
            }

            return false;
        }
    }
}
