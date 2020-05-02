using System;
using System.Collections;
using System.Collections.Generic;
using Anura.Html;
using Anura.JavaScript;
using Anura.JavaScript.Collections;
using Anura.JavaScript.Native;
using Anura.JavaScript.Native.Function;
using Anura.JavaScript.Native.Object;
using Anura.JavaScript.Native.Symbol;
using Anura.JavaScript.Runtime;
using Anura.JavaScript.Runtime.Descriptors;
using Anura.JavaScript.Runtime.Descriptors.Specialized;
using Anura.JavaScript.Runtime.Interop;

namespace Anura.Objects.Extensions {
    public sealed class __Anura__Constructor : FunctionInstance, IConstructor, IPrototypeObjectModel {
        public __Anura__Constructor (Engine engine) : base (engine, new JsString ("__Anura__"), strict : false) { }

        public static __Anura__Constructor Create__Anura__Constructor (Engine engine) {
            var obj = new __Anura__Constructor (engine) {
                _prototype = engine.Function.PrototypeObject
            };

            // The value of the [[Prototype]] internal property of the RegExp constructor 
            // is the Function prototype object
            obj.PrototypeObject = __Anura__Prototype.CreatePrototypeObject (engine, obj);

            // TODO: 更改此处的 length 的值以规定构造方法的参数个数
            obj._length = new PropertyDescriptor (1, PropertyFlag.AllForbidden);

            // The initial value of RegExp.prototype is the RegExp prototype object
            obj._prototypeDescriptor = new PropertyDescriptor (obj.PrototypeObject, PropertyFlag.AllForbidden);

            return obj;
        }

        public void Configure () { }

        public override JsValue Call (JsValue thisObject, JsValue[] arguments) {
            return Construct (arguments, thisObject);
        }

        public ObjectInstance Construct (JsValue[] arguments, JsValue newTarget) {
            var obj = new __Anura__Instance (Engine);
            obj._prototype = this.PrototypeObject;

            // TODO: 在此处使用 obj.FastAddProperty 方法添加在 Instance 中规定的属性
            return obj;
        }

        public ObjectInstance PrototypeObject { get; set; }
    }

    public partial class __Anura__Instance : ObjectInstance {
        public __Anura__Instance (Engine engine) : base (engine) { }

        // TODO: 在此处增加所需要的 (C# 风格) 属性和方法
    }

    public sealed class __Anura__Prototype : __Anura__Instance, IPrototypeObjectModel {
        private __Anura__Prototype (Engine engine) : base (engine) { }

        private __Anura__Constructor _anuraConstructor;
        public static __Anura__Prototype CreatePrototypeObject (Engine engine, __Anura__Constructor constr) {
            var obj = new __Anura__Prototype (engine) {
                _prototype = engine.Object.PrototypeObject,
                _anuraConstructor = constr
            };

            return obj;
        }

        protected override void Initialize () {
            const PropertyFlag propertyFlags = PropertyFlag.Configurable | PropertyFlag.Writable;
            const PropertyFlag lengthFlags = PropertyFlag.Configurable;

            // TODO: 在此处规定 JavaScript 版接口
            var properties = new PropertyDictionary (3, checkExistingKeys : false) {
                ["constructor"] = new PropertyDescriptor (_anuraConstructor, propertyFlags), //
                ["toString"] = new PropertyDescriptor (new ClrFunctionInstance (Engine, "toString", ValueOf, 0, lengthFlags), propertyFlags), //
                ["connect"] = new PropertyDescriptor (new ClrFunctionInstance (Engine, "connect", Connect, 1, lengthFlags), propertyFlags) //
            };
            SetProperties (properties);
        }

        public void Configure () {
            Initialize ();
        }
        
        // TODO: 在此处用 JsValue Function(JsValue thisObj, JsValue[] para) 实现 JavaScript 风格功能
        // TODO: var obj = TypeConverter.ToObject(Engine, thisObj) as (...); 进行已知类型的转化

        private JsValue ValueOf (JsValue thisObj, JsValue[] para) {
            return "[Object __Anura__ at Objects.Extensions.__Anura__Prototype]";
        }

        private JsValue Connect (JsValue thisObj, JsValue[] para) {
            string conn = "Undefined";
            conn = para.At (0).ToString ();
            switch (para.At (0).Type) {
                case Types.Boolean:
                    break;
                case Types.None:
                    break;
                case Types.Null:
                    break;
                case Types.Number:
                    break;
                case Types.Object:
                    var obj = para.At (0).AsObject ();
                    while (!(obj.Prototype == null)) {
                        if (obj.Properties != null)
                            if (obj.Properties.Count > 0)
                                foreach (var item in obj.Properties) {
                                    conn = conn + "\n  " + item.Key + " => ";
                                    try {
                                        if (item.Value.Configurable)
                                            conn += ((bool) item.Value.Configurable) ? "(config)" : "";
                                        if (item.Value.Enumerable)
                                            conn += ((bool) item.Value.Enumerable) ? "(enum)" : "";
                                        if (item.Value.Writable)
                                            conn += ((bool) item.Value.Writable) ? "(write)" : "";
                                        conn += item.Value.Value.ToString ();
                                    } catch { conn += " <exception>"; }
                                }
                        conn += "\n----> Into Prototype " + obj.Prototype.Class;
                        obj = obj.Prototype;
                    }
                    break;
                case Types.String:
                    break;
                case Types.Undefined:
                    break;
            }
            return conn;
        }

        public ObjectInstance PrototypeObject { get; set; }
    }
}