using Anura.JavaScript.Native.Object;
using Anura.JavaScript.Runtime;

namespace Anura.JavaScript.Native.Symbol
{
    public class SymbolInstance : ObjectInstance, IPrimitiveInstance
    {
        public SymbolInstance(Engine engine)
            : base(engine, ObjectClass.Symbol) {
        }

        Types IPrimitiveInstance.Type => Types.Symbol;

        JsValue IPrimitiveInstance.PrimitiveValue => SymbolData;

        public JsSymbol SymbolData { get; set; }
    }
}
