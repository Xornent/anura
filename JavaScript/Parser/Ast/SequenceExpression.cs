using System.Collections.Generic;

namespace Anura.JavaScript.Ast {
    public class SequenceExpression : Expression {
        public IList<Expression> Expressions;
    }
}