using System.Collections.Generic;

namespace Anura.JavaScript.Ast {
    public class ObjectExpression : Expression {
        public IEnumerable<Property> Properties;
    }
}