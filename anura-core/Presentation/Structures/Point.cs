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
    public partial struct Point {
        public Point(float x, float y) {
            this.X = x;
            this.Y = y;
        }
        
        public float X { get; set; }
        public float Y { get; set; }
    }
}