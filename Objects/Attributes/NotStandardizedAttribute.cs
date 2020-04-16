using System;
using System.ComponentModel;

namespace Anura.Objects.Attributes {
    [System.AttributeUsage (System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class NotStandardizedAttribute : System.Attribute {
        public NotStandardizedAttribute () { }
    }
}