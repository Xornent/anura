using Anura.JavaScript.Runtime;

namespace Anura.JavaScript.Native {
    public interface IPrimitiveInstance {
        Types Type { get; }
        JsValue PrimitiveValue { get; }
    }
}