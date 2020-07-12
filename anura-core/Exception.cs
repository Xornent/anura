using System;

namespace Anura {

    [Serializable]
    public class AnuraException : Exception {
        public AnuraException () { }
        public AnuraException (bool isWarning) {
            Warning = isWarning;
        }

        public AnuraException (string message) : base (message) { }
        public AnuraException (string message, bool isWarning) : base (message) {
            Warning = isWarning;
        }

        public AnuraException (string message, Exception inner) : base (message, inner) { }
        public AnuraException (string message, Exception inner, bool isWarning) : base (message, inner) {
            Warning = isWarning;
        }

        protected AnuraException (
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base (info, context) { }

        public bool Warning { get; set; } = false;
    }

    [Serializable]
    public class AnuraWarning : AnuraException {
        public AnuraWarning () : base (true) { }
        public AnuraWarning (string message) : base (message, true) { }
        public AnuraWarning (string message, Exception inner) : base (message, inner, true) { }
        protected AnuraWarning (
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base (info, context) { }
    }

    namespace Exceptions {
        
        [Serializable]
        public class AssertionException : AnuraException {
            public AssertionException () { }
            public AssertionException (string message) : base ("断言错误： " + message) { }
            public AssertionException (string message, Exception inner) : base (message, inner) { }
            protected AssertionException (
                System.Runtime.Serialization.SerializationInfo info,
                System.Runtime.Serialization.StreamingContext context) : base (info, context) { }
        }

        [Serializable]
        public class GraphicSystemIncompatibleException : Exception {
            public GraphicSystemIncompatibleException() { }
            public GraphicSystemIncompatibleException(string message) : base("没有找到与相应系统适配的图形系统实现： " + message) { }
            public GraphicSystemIncompatibleException(string message, Exception inner) : base(message, inner) { }
            protected GraphicSystemIncompatibleException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }

        [Serializable]
        public class NumericException : Exception {
            public NumericException() { }
            public NumericException(string message) : base("运算和编解码错误： "+message) { }
            public NumericException(string message, Exception inner) : base(message, inner) { }
            protected NumericException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }

        [Serializable]
        public class OverflowException : Exception {
            public OverflowException() { }
            public OverflowException(string message) : base(message) { }
            public OverflowException(string message, Exception inner) : base(message, inner) { }
            protected OverflowException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }

        [Serializable]
        public class UnderflowException : Exception {
            public UnderflowException() { }
            public UnderflowException(string message) : base(message) { }
            public UnderflowException(string message, Exception inner) : base(message, inner) { }
            protected UnderflowException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
    }
}