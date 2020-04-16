using System.Collections.Generic;

namespace Anura.JavaScript.Ast {
    public class NewExpression : Expression {
        public Expression Callee;
        public IEnumerable<Expression> Arguments;
    }
}