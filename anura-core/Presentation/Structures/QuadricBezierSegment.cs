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
    public partial struct QuadricBezierSegment {
        public QuadricBezierSegment(Point control, Point end) {
            this.Control = control;
            this.End = end;
        }
        
        public Point Control { get; set; }
        public Point End { get; set; }
    }
}