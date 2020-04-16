using System;

namespace Anura.Typography.OpenFont {
    internal class InvalidFontException : Exception {
        public InvalidFontException () { }

        public InvalidFontException (string message) : base (message) { }

        public InvalidFontException (string message, Exception innerException) : base (message, innerException) { }
    }
}