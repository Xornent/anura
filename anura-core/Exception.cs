using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anura {

    [Serializable]
    public class AnuraException : Exception {
        public AnuraException () { }
        public AnuraException (string message) : base (message) { }
        public AnuraException (string message, Exception inner) : base (message, inner) { }
        protected AnuraException (
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base (info, context) { }
    }
}