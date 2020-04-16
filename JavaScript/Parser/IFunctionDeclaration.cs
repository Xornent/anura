using System.Collections.Generic;
using Anura.JavaScript.Ast;

namespace Anura.JavaScript {
    public interface IFunctionDeclaration : IFunctionScope {
        Identifier Id { get; }
        IEnumerable<Identifier> Parameters { get; }
        Statement Body { get; }
        bool Strict { get; }
    }
}