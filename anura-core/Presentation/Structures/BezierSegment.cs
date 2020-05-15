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
    public partial struct BezierSegment {
        public BezierSegment(Point cstart, Point cend, Point end) {
            this.ControlStart = cstart;
            this.ControlEnd = cend;
            this.End = end;
        }

        public Point ControlStart { get; set; }
        public Point ControlEnd { get; set; }
        public Point End { get; set; }
    }
}