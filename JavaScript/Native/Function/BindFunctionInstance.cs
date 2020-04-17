using System.Linq;
using Anura.JavaScript.Native.Object;
using Anura.JavaScript.Runtime;

namespace Anura.JavaScript.Native.Function
{
    public sealed class BindFunctionInstance : FunctionInstance, IConstructor
    {
        public BindFunctionInstance(Engine engine)
            : base(engine, "bind", System.Array.Empty<string>(), null, false)
        {
        }

        public JsValue TargetFunction { get; set; }

        public JsValue BoundThis { get; set; }

        public JsValue[] BoundArgs { get; set; }

        public override JsValue Call(JsValue thisObject, JsValue[] arguments)
        {
            if (!(TargetFunction is FunctionInstance f))
            {
                return Anura.JavaScript.Runtime.ExceptionHelper.ThrowTypeError<ObjectInstance>(Engine);
            }

            return f.Call(BoundThis, CreateArguments(arguments));
        }

        public ObjectInstance Construct(JsValue[] arguments, JsValue newTarget)
        {
            if (!(TargetFunction is IConstructor target))
            {
                return Anura.JavaScript.Runtime.ExceptionHelper.ThrowTypeError<ObjectInstance>(Engine);
            }

            return target.Construct(CreateArguments(arguments), newTarget);
        }

        public override bool HasInstance(JsValue v)
        {
            var f = TargetFunction.TryCast<FunctionInstance>(x =>
            {
                Anura.JavaScript.Runtime.ExceptionHelper.ThrowTypeError(Engine);
            });

            return f.HasInstance(v);
        }

        private JsValue[] CreateArguments(JsValue[] arguments)
        {
            return Enumerable.Union(BoundArgs, arguments).ToArray();
        }

        internal override bool IsConstructor => TargetFunction is IConstructor;
    }
}
