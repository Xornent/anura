using System.Collections.Generic;

namespace Anura.JavaScript.Ast {
    public class ArrayExpression : Expression {
        public IEnumerable<Expression> Elements;
    }
}