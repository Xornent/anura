using System;

namespace Anura.JavaScript {
    public class ParserException : Exception {
        public int Column;
        public string Description;
        public int Index;
        public int LineNumber;

#if PORTABLE
        public string Source;
#endif

        public ParserException (string message) : base (message) { }
    }
}