using System.Collections.Generic;

namespace Anura.JavaScript.Ast {
    public class VariableDeclaration : Statement {
        public IEnumerable<VariableDeclarator> Declarations;
        public string Kind;
    }
}