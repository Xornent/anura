using System;
using System.Collections;
using System.Collections.Generic;

using Anura;
using Anura.Html;
using Anura.Developer;
using Anura.Styles;
using Anura.JavaScript;
using Anura.JavaScript.Native;

namespace Anura.Presentation.Structures {
    public partial struct Size {
        public Size(float w,float h){
            this.Width = w;
            this.Height = h;
        }

        public float Width { get; set; }
        public float Height { get; set; }
    }
}