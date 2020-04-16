using System.Collections.Generic;

namespace Anura.JavaScript.Ast {
    public class SwitchCase : SyntaxNode {
        public Expression Test;
        public IEnumerable<Statement> Consequent;
    }
}