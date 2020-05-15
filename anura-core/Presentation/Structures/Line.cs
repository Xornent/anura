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
    public partial struct Line {
        public Line(Point start, Point end) {
            this.Start = start;
            this.End = end;
        }

        public Point Start { get; set; }
        public Point End { get; set; }
    }
}