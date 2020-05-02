using System;
using System.Collections;
using System.Collections.Generic;
using Anura;
using Anura.Developer;
using Anura.Html;
using Anura.JavaScript;
using Anura.JavaScript.Native;
using Anura.Styles;

namespace Anura.Objects.Attributes {
    [System.AttributeUsage (System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class CapabilityObsoleteAttribute : System.Attribute {
        readonly string positionalString;

        public CapabilityObsoleteAttribute (string positionalString) {
            this.positionalString = positionalString;
        }

        public string PositionalString {
            get { return positionalString; }
        }
    }
}