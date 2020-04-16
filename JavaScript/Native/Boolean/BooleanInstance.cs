using Anura.JavaScript.Native.Object;
using Anura.JavaScript.Runtime;

namespace Anura.JavaScript.Native.Boolean {
    public class BooleanInstance : ObjectInstance, IPrimitiveInstance {
        public BooleanInstance (Engine engine) : base (engine) { }

        public override string Class {
            get {
                return "Boolean";
            }
        }

        Types IPrimitiveInstance.Type {
            get { return Types.Boolean; }
        }

        JsValue IPrimitiveInstance.PrimitiveValue {
            get { return PrimitiveValue; }
        }

        public JsValue PrimitiveValue { get; set; }
    }
}