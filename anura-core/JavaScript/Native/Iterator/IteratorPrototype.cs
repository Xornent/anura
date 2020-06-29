using Anura.JavaScript.Collections;
using Anura.JavaScript.Native.Symbol;
using Anura.JavaScript.Runtime;
using Anura.JavaScript.Runtime.Descriptors;
using Anura.JavaScript.Runtime.Interop;

namespace Anura.JavaScript.Native.Iterator
{
    internal sealed class IteratorPrototype : IteratorInstance
    {
        private string _name;

        private IteratorPrototype(Engine engine) : base(engine) {
        }

        public static IteratorPrototype CreatePrototypeObject(Engine engine, string name, IteratorConstructor iteratorConstructor) {
            var obj = new IteratorPrototype(engine)
            {
                _prototype = engine.Object.PrototypeObject,
                _name = name
            };

            return obj;
        }

        protected override void Initialize() {
            var properties = new PropertyDictionary(2, checkExistingKeys: false)
            {
                ["name"] = new PropertyDescriptor("Map", PropertyFlag.Configurable),
                ["next"] = new PropertyDescriptor(new ClrFunctionInstance(Engine, "next", Next, 0, PropertyFlag.Configurable), true, false, true)
            };
            SetProperties(properties);

            if (_name != null) {
                var symbols = new SymbolDictionary(1)
                {
                    [GlobalSymbolRegistry.ToStringTag] = new PropertyDescriptor(_name, PropertyFlag.Configurable)
                };
                SetSymbols(symbols);
            }
        }

        private JsValue Next(JsValue thisObj, JsValue[] arguments) {
            if (!(thisObj is IteratorInstance iterator)) {
                return Anura.JavaScript.Runtime.ExceptionHelper.ThrowTypeError<JsValue>(_engine);
            }

            iterator.TryIteratorStep(out var result);
            return result;
        }
    }
}