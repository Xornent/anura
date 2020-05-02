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
    public partial class HtmlDocument : HtmlNode {
        public HtmlNode DocumentTypeNode = null;
        public HtmlNode HeadNode = null;
        public HtmlNode BodyNode = null;

        public Dictionary<string, HtmlNode> Registry = new Dictionary<string, HtmlNode>();
    }
}