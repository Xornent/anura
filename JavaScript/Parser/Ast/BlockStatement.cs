using System.Collections.Generic;

namespace Anura.JavaScript.Ast {
    public class BlockStatement : Statement {
        public IEnumerable<Statement> Body;
    }
}