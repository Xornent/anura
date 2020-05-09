using System;
using System.Collections;
using System.Collections.Generic;

using Anura;
using Anura.Html;
using Anura.Developer;
using Anura.Styles;
using Anura.JavaScript;
using Anura.JavaScript.Native;

namespace Anura.Objects.Attributes {
    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class ApiNameAttribute : System.Attribute
    {
        readonly string positionalString;
        
        public ApiNameAttribute(string positionalString)
        {
            this.positionalString = positionalString;
        }
        
        public string PositionalString
        {
            get { return positionalString; }
        }
    }
}