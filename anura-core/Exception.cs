using System;

namespace Anura
{
    [Serializable]
    public class AnuraException : Exception
    {
        public AnuraException() { }
        public AnuraException(bool isWarning)
        {
            Warning = isWarning;
        }

        public AnuraException(string message) : base(message) { }
        public AnuraException(string message, bool isWarning) : base(message)
        {
            Warning = isWarning;
        }

        public AnuraException(string message, Exception inner) : base(message, inner) { }
        public AnuraException(string message, Exception inner, bool isWarning) : base(message, inner)
        {
            Warning = isWarning;
        }
        
        protected AnuraException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public bool Warning { get; set; } = false;
    }

    [Serializable]
    public class AnuraWarning : AnuraException
    {
        public AnuraWarning() : base(true) { }
        public AnuraWarning(string message) : base(message, true) { }
        public AnuraWarning(string message, Exception inner) : base(message, inner, true) { }
        protected AnuraWarning(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    namespace Exceptions
    {
        [Serializable]
        public class AssertionException : AnuraException
        {
            public AssertionException() { }
            public AssertionException(string message) : base("¶ÏÑÔ´íÎó") { }
            public AssertionException(string message, Exception inner) : base(message, inner) { }
            protected AssertionException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
    }
}