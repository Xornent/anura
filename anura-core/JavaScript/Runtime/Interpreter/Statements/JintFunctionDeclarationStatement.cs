using Esprima.Ast;

namespace Anura.JavaScript.Runtime.Interpreter.Statements
{
    internal sealed class JintFunctionDeclarationStatement : JintStatement<FunctionDeclaration>
    {
        public JintFunctionDeclarationStatement(Engine engine, FunctionDeclaration statement) : base(engine, statement) {
        }

        protected override Completion ExecuteInternal() {
            return new Completion(CompletionType.Normal, null, null, Location);
        }
    }
}