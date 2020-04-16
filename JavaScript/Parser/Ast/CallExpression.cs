using System.Collections.Generic;
using Anura.JavaScript.Native;

namespace Anura.JavaScript.Ast {
    public class CallExpression : Expression {
        public Expression Callee;
        public IList<Expression> Arguments;

        public bool Cached;
        public bool CanBeCached = true;
        public JsValue[] CachedArguments;
    }
}