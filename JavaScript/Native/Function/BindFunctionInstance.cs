using System.Linq;
using Anura.JavaScript.Native.Object;
using Anura.JavaScript.Runtime;

namespace Anura.JavaScript.Native.Function {
    public class BindFunctionInstance : FunctionInstance, IConstructor {
        public BindFunctionInstance (Engine engine) : base (engine, new string[0], null, false) { }

        public JsValue TargetFunction { get; set; }

        public JsValue BoundThis { get; set; }

        public JsValue[] BoundArgs { get; set; }

        public override JsValue Call (JsValue thisObject, JsValue[] arguments) {
            var f = TargetFunction.TryCast<FunctionInstance> (x => {
                throw new JavaScriptException (Engine.TypeError);
            });

            return f.Call (BoundThis, BoundArgs.Union (arguments).ToArray ());
        }

        public ObjectInstance Construct (JsValue[] arguments) {
            var target = TargetFunction.TryCast<IConstructor> (x => {
                throw new JavaScriptException (Engine.TypeError);
            });

            return target.Construct (BoundArgs.Union (arguments).ToArray ());
        }

        public override bool HasInstance (JsValue v) {
            var f = TargetFunction.TryCast<FunctionInstance> (x => {
                throw new JavaScriptException (Engine.TypeError);
            });

            return f.HasInstance (v);
        }
    }
}