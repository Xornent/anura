using System.Collections.Generic;

namespace Anura.JavaScript.Ast {
    public class TryStatement : Statement {
        public Statement Block;
        public IEnumerable<Statement> GuardedHandlers;
        public IEnumerable<CatchClause> Handlers;
        public Statement Finalizer;
    }
}