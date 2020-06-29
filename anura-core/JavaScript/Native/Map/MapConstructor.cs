using Anura.JavaScript.Collections;
using Anura.JavaScript.Native.Function;
using Anura.JavaScript.Native.Iterator;
using Anura.JavaScript.Native.Object;
using Anura.JavaScript.Native.Symbol;
using Anura.JavaScript.Runtime;
using Anura.JavaScript.Runtime.Descriptors;
using Anura.JavaScript.Runtime.Descriptors.Specialized;
using Anura.JavaScript.Runtime.Interop;

namespace Anura.JavaScript.Native.Map
{
    public sealed class MapConstructor : FunctionInstance, IConstructor
    {
        private static readonly JsString _functionName = new JsString("Map");

        private MapConstructor(Engine engine)
            : base(engine, _functionName, strict: false) {
        }

        public MapPrototype PrototypeObject { get; private set; }

        public static MapConstructor CreateMapConstructor(Engine engine) {
            var obj = new MapConstructor(engine)
            {
                _prototype = engine.Function.PrototypeObject
            };

            // The value of the [[Prototype]] internal property of the Map constructor is the Function prototype object
            obj.PrototypeObject = MapPrototype.CreatePrototypeObject(engine, obj);

            obj._length = new PropertyDescriptor(0, PropertyFlag.Configurable);

            // The initial value of Map.prototype is the Map prototype object
            obj._prototypeDescriptor = new PropertyDescriptor(obj.PrototypeObject, PropertyFlag.AllForbidden);

            return obj;
        }

        protected override void Initialize() {
            var symbols = new SymbolDictionary(1)
            {
                [GlobalSymbolRegistry.Species] = new GetSetPropertyDescriptor(get: new ClrFunctionInstance(_engine, "get [Symbol.species]", Species, 0, PropertyFlag.Configurable), set: Undefined, PropertyFlag.Configurable)
            };
            SetSymbols(symbols);
        }

        private static JsValue Species(JsValue thisObject, JsValue[] arguments) {
            return thisObject;
        }

        public override JsValue Call(JsValue thisObject, JsValue[] arguments) {
            if (thisObject.IsUndefined()) {
                Anura.JavaScript.Runtime.ExceptionHelper.ThrowTypeError(_engine, "Constructor Map requires 'new'");
            }

            return Construct(arguments, thisObject);
        }

        public ObjectInstance Construct(JsValue[] arguments, JsValue newTarget) {
            var map = new MapInstance(Engine)
            {
                _prototype = PrototypeObject
            };

            if (arguments.Length > 0 && !arguments[0].IsNullOrUndefined()) {
                var adder = map.Get("set");
                var iterator = arguments.At(0).GetIterator(_engine);

                IteratorProtocol.AddEntriesFromIterable(map, iterator, adder);
            }

            return map;
        }
    }
}