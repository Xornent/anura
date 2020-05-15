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
    public partial struct Rectangle {
        public Rectangle(float left, float top, float width, float height) {
            this.Left = left;
            this.Top = top;
            this.Width = width;
            this.Height = height;
        }

        public Rectangle(float left, float top, Size size){
            this.Left = left;
            this.Top = top;
            this.Width = size.Width;
            this.Height = size.Height;
        }

        public Rectangle(Point location, Size size) {
            this.Left = location.X;
            this.Top = location.Y;
            this.Width = size.Width;
            this.Height = size.Height;
        }
            
        public float Left { get; set; }
        public float Top { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Right => Left + Width;
        public float Bottom => Top + Height;
    }
}