using Anura.JavaScript.Native.Object;
using Anura.JavaScript.Runtime;

namespace Anura.JavaScript.Native.Iterator
{
    public interface IIterator
    {
        bool TryIteratorStep(out ObjectInstance nextItem);
        void Close(CompletionType completion);
    }
}