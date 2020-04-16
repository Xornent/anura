using System;
using System.Collections;
using System.Collections.Generic;
using Anura.Html;
using Anura.JavaScript;
using Anura.JavaScript.Native;
using Anura.JavaScript.Native.Function;
using Anura.JavaScript.Native.Object;
using Anura.JavaScript.Runtime;
using Anura.JavaScript.Runtime.Descriptors;
using Anura.JavaScript.Runtime.Interop;

namespace Anura.Objects.Extensions {
    public sealed class __Anura__Constructor : FunctionInstance, IConstructor, IPrototypeObjectModel {
        public __Anura__Constructor (Engine engine) : base (engine, null, null, false) { }

        public static __Anura__Constructor Create__Anura__Constructor (Engine engine) {
            var obj = new __Anura__Constructor (engine);
            obj.Extensible = true;
            obj.Prototype = engine.Function.PrototypeObject;
            obj.PrototypeObject = __Anura__Prototype.CreatePrototypeObject (engine, obj);

            // TODO: 更改此处的 length 的值以规定构造方法的参数个数
            obj.FastAddProperty ("length", 0, false, false, false);
            obj.FastAddProperty ("prototype", obj.PrototypeObject, false, false, false);

            return obj;
        }

        public void Configure () { }

        public override JsValue Call (JsValue thisObject, JsValue[] arguments) {
            return Construct (arguments);
        }

        public ObjectInstance Construct (JsValue[] arguments) {
            var obj = new __Anura__Instance (Engine);
            obj.Prototype = this.PrototypeObject;

            // TODO: 在此处使用 obj.FastAddProperty 方法添加在 Instance 中规定的属性
            return obj;
        }

        public ObjectInstance PrototypeObject { get; set; }
    }

    public partial class __Anura__Instance : ObjectInstance {
        public __Anura__Instance (Engine engine) : base (engine) { }
        public override string Class { get { return "__Anura__"; } }

        // TODO: 在此处增加所需要的 (C# 风格) 属性和方法
    }

    public sealed class __Anura__Prototype : __Anura__Instance, IPrototypeObjectModel {
        private __Anura__Prototype (Engine engine) : base (engine) { }

        public static __Anura__Prototype CreatePrototypeObject (Engine engine, __Anura__Constructor etConstructor) {
            var obj = new __Anura__Prototype (engine);
            obj.Prototype = engine.Object.PrototypeObject;
            obj.Extensible = true;

            obj.FastAddProperty ("constructor", etConstructor, true, false, true);
            return obj;
        }

        public void Configure () {
            FastAddProperty ("connect", new ClrFunctionInstance (Engine, Connect, 1), true, false, true);

            // TODO: 在此处规定 JavaScript 版接口
        }

        // TODO: 在此处用 JsValue Function(JsValue thisObj, JsValue[] para) 实现 JavaScript 风格功能
        // TODO: var obj = TypeConverter.ToObject(Engine, thisObj) as (...); 进行已知类型的转化

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
                    while (!(obj is ObjectPrototype)) {
                        if (obj.Properties.Count > 0)
                            foreach (var item in obj.Properties) {
                                conn = conn + "\n  " + item.Key + " => ";
                                if (item.Value.Configurable.HasValue)
                                    conn += ((bool) item.Value.Configurable) ? "(config)" : "";
                                if (item.Value.Enumerable.HasValue)
                                    conn += ((bool) item.Value.Enumerable) ? "(enum)" : "";
                                if (item.Value.Writable.HasValue)
                                    conn += ((bool) item.Value.Writable) ? "(write)" : "";
                                conn += item.Value.Value.ToString ();
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