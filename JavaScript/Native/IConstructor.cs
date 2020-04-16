using Anura.JavaScript.Native.Object;

namespace Anura.JavaScript.Native {
    public interface IConstructor {
        JsValue Call (JsValue thisObject, JsValue[] arguments);
        ObjectInstance Construct (JsValue[] arguments);
    }
}