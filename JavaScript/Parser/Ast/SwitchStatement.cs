using System.Collections.Generic;

namespace Anura.JavaScript.Ast {
    public class SwitchStatement : Statement {
        public Expression Discriminant;
        public IEnumerable<SwitchCase> Cases;
    }
}