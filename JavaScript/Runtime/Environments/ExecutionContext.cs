using Anura.JavaScript.Native;

namespace Anura.JavaScript.Runtime.Environments {
    public sealed class ExecutionContext {
        public LexicalEnvironment LexicalEnvironment { get; set; }
        public LexicalEnvironment VariableEnvironment { get; set; }
        public JsValue ThisBinding { get; set; }

    }
}