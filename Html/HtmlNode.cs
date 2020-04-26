using System;
using System.Collections;
using System.Collections.Generic;
using Anura;
using Anura.Developer;
using Anura.Html;
using Anura.JavaScript;
using Anura.JavaScript.Native;
using Anura.Styles;

namespace Anura.Html {
    public partial class HtmlNode {
        public string BaseUri = "";
        public List<HtmlNode> Children = new List<HtmlNode>();
        
        public HtmlNode First {
            get{
                if(this.Children.Count>0)
                    return this.Children[0];
                else return null;
            }
        }

        public HtmlNode Last {
            get{
                if(this.Children.Count>0)
                    return this.Children[this.Children.Count - 1];
                else return null;
            }
        }

        public bool Connected = false;
        public string Name = "";
        public byte Type = 0;
        public HtmlDocument Document = null;
        public HtmlNode Parent = null;
        public HtmlNode ParentElement = null;
        public string Inner = "";
        public string Outer = "";

        public HtmlNode NextSibling {
            get {
                if(this.Parent == null) return null;
                int id = this.Parent.Children.IndexOf(this);
                if(id == this.Parent.Children.Count -1) return null;
                else return this.Parent.Children[id + 1];
            }
        }

        public HtmlNode LastSibling {
            get {
                if(this.Parent == null) return null;
                int id = this.Parent.Children.IndexOf(this);
                if(id == 0) return null;
                else return this.Parent.Children[id - 1];
            }
        }
    }
}