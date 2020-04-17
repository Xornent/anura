using Anura.JavaScript.Native;
using Anura.JavaScript.Runtime.Descriptors;

namespace Anura.JavaScript.Collections
{
    internal sealed class SymbolDictionary : DictionarySlim<JsSymbol, PropertyDescriptor>
    {
        public SymbolDictionary()
        {
        }

        public SymbolDictionary(int capacity) : base(capacity)
        {
        }
    }
}