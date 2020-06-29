using Anura.JavaScript.Runtime.Descriptors;

namespace Anura.JavaScript.Collections
{
    public sealed class PropertyDictionary : HybridDictionary<PropertyDescriptor>
    {
        public PropertyDictionary() {
        }

        public PropertyDictionary(int capacity, bool checkExistingKeys) : base(capacity, checkExistingKeys) {
        }
    }
}