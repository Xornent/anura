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
    public partial struct Arc {
        public Arc(Point endPoint, float sweep, ArcSize size = ArcSize.Small, Clockwise orient = Clockwise.Clockwise) {
            this.EndPoint = endPoint;
            this.SweepAngle = sweep;
            this.Size = size;
            this.Orientation = orient;
        }

        public ArcSize Size { get; set; } 
        public Point EndPoint { get; set; }
        public Clockwise Orientation { get; set; }
        public float SweepAngle { get; set; }
    }

    public enum ArcSize {
        Large,
        Small
    }

    public enum Clockwise {
        Clockwise,
        CounterClockwise
    }
}