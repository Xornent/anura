using System;
using System.Collections.Generic;
using Anura.JavaScript.Ast;
using Anura.JavaScript.Native;
using Anura.JavaScript.Runtime.Environments;

namespace Anura.JavaScript.Runtime.Debugger {
    public class DebugInformation : EventArgs {
        public Stack<String> CallStack { get; set; }
        public Statement CurrentStatement { get; set; }
        public Dictionary<string, JsValue> Locals { get; set; }
        public Dictionary<string, JsValue> Globals { get; set; }
    }
}