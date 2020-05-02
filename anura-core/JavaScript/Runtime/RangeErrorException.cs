namespace Anura.JavaScript.Runtime
{
    /// <summary>
    /// Workaround for situation where engine is not easily accessible.
    /// </summary>
    internal sealed class RangeErrorException : JintException
    {
        public RangeErrorException(string message) : base(message)
        {
        }
    }
}