using Anura.JavaScript.Native.Object;
using Anura.JavaScript.Runtime;

namespace Anura.JavaScript.Native.Boolean
{
    public class BooleanInstance : ObjectInstance, IPrimitiveInstance
    {
        public BooleanInstance(Engine engine)
            : base(engine, ObjectClass.Boolean)
        {
        }

        Types IPrimitiveInstance.Type => Types.Boolean;

        JsValue IPrimitiveInstance.PrimitiveValue => PrimitiveValue;

        public JsValue PrimitiveValue { get; set; }
    }
}