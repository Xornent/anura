namespace Anura.JavaScript.Runtime
{
    public class MemoryLimitExceededException : JintException
    {
        public MemoryLimitExceededException() : base()
        {
        }

        public MemoryLimitExceededException(string message) : base(message)
        {
        }
    }
}
