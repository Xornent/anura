using Anura.JavaScript.Native.Object;

namespace Anura.JavaScript.Native
{
    public interface IConstructor
    {
        ObjectInstance Construct(JsValue[] arguments, JsValue newTarget);
    }
}
