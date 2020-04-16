using System.Collections.Generic;
using Anura.JavaScript.Ast;

namespace Anura.JavaScript {
    /// <summary>
    /// Used to safe references to all function delcarations in a specific scope.
    /// </summary>
    public interface IFunctionScope : IVariableScope {
        IList<FunctionDeclaration> FunctionDeclarations { get; set; }
    }

    public class FunctionScope : IFunctionScope {
        public FunctionScope () {
            FunctionDeclarations = new List<FunctionDeclaration> ();
        }

        public IList<FunctionDeclaration> FunctionDeclarations { get; set; }
        public IList<VariableDeclaration> VariableDeclarations { get; set; }
    }
}