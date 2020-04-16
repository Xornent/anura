using System;
using System.Collections.Generic;
using System.Linq;
using Anura.JavaScript.Ast;
using Anura.JavaScript.Native;

namespace Anura.JavaScript.Runtime {
    using Anura.JavaScript.Runtime.CallStack;

    public class RecursionDepthOverflowException : Exception {
        public string CallChain { get; private set; }

        public string CallExpressionReference { get; private set; }

        public RecursionDepthOverflowException (JintCallStack currentStack, string currentExpressionReference) : base ("The recursion is forbidden by script host.") {
            CallExpressionReference = currentExpressionReference;

            CallChain = currentStack.ToString ();
        }
    }

}