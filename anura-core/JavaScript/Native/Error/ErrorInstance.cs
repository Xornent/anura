﻿using Anura.JavaScript.Native.Object;
using Anura.JavaScript.Runtime;
using Anura.JavaScript.Runtime.Descriptors;

namespace Anura.JavaScript.Native.Error
{
    public class ErrorInstance : ObjectInstance
    {
        private readonly JsString _name;
        private PropertyDescriptor _descriptor;

        public ErrorInstance(Engine engine, JsString name)
            : base(engine, ObjectClass.Error) {
            _name = name;
        }

        public override PropertyDescriptor GetOwnProperty(JsValue property) {
            if (property == CommonProperties.Name) {
                return _descriptor ??= new PropertyDescriptor(_name, PropertyFlag.Configurable | PropertyFlag.Writable);
            };
            return base.GetOwnProperty(property);
        }

        public override string ToString() {
            return Engine.Error.PrototypeObject.ToString(this, Arguments.Empty).ToObject().ToString();
        }
    }
}
