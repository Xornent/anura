﻿using Anura.JavaScript.Native;
using Anura.JavaScript.Native.Global;
using Anura.JavaScript.Native.Object;
using Anura.JavaScript.Runtime.Descriptors;
using System.Linq;

namespace Anura.JavaScript.Runtime.Environments
{
    /// <summary>
    /// Optimized for GlobalObject, which we know of and can skip some virtual calls.
    /// http://www.ecma-international.org/ecma-262/6.0/#sec-global-environment-records
    /// </summary>
    internal sealed class GlobalEnvironmentRecord : EnvironmentRecord
    {
        private readonly GlobalObject _global;

        public GlobalEnvironmentRecord(Engine engine, GlobalObject global) : base(engine) {
            _global = global;
        }

        public override bool HasBinding(string name) {
            return _global.Properties.ContainsKey(name);
        }

        internal override bool TryGetBinding(
            in Key name,
            bool strict,
            out Binding binding,
            out JsValue value) {
            // we unwrap by name
            binding = default;

            Key key = name;
            if (!_global.Properties.TryGetValue(key, out var desc)) {
                value = default;
                return false;
            }

            value = ObjectInstance.UnwrapJsValue(desc, _global);
            return true;
        }

        /// <summary>
        /// http://www.ecma-international.org/ecma-262/5.1/#sec-10.2.1.2.2
        /// </summary>
        public override void CreateMutableBinding(string name, JsValue value, bool configurable = false) {
            var propertyDescriptor = configurable
                ? new PropertyDescriptor(value, PropertyFlag.ConfigurableEnumerableWritable | PropertyFlag.MutableBinding)
                : new PropertyDescriptor(value, PropertyFlag.NonConfigurable | PropertyFlag.MutableBinding);

            _global.DefinePropertyOrThrow(name, propertyDescriptor);
        }

        public override void SetMutableBinding(string name, JsValue value, bool strict) {
            if (!_global.Set(name, value) && strict) {
                Anura.JavaScript.Runtime.ExceptionHelper.ThrowTypeError(_engine);
            }
        }

        public override JsValue GetBindingValue(string name, bool strict) {
            var desc = _global.GetProperty(name);
            if (strict && desc == PropertyDescriptor.Undefined) {
                Anura.JavaScript.Runtime.ExceptionHelper.ThrowReferenceError(_engine, name.ToString());
            }

            return ObjectInstance.UnwrapJsValue(desc, this);
        }

        public override bool DeleteBinding(string name) {
            return _global.Delete(name);
        }

        public override JsValue ImplicitThisValue() {
            return Undefined;
        }

        internal override string[] GetAllBindingNames() {
            return _global.GetOwnProperties().Select(x => x.Key.ToString()).ToArray();
        }

        public override bool Equals(JsValue other) {
            return ReferenceEquals(_global, other);
        }
    }
}
