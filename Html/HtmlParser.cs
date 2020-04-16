using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using Anura;
using Anura.Developer;
using Anura.Html;
using Anura.JavaScript;
using Anura.JavaScript.Native;
using Anura.Styles;

namespace Anura.Html {
    public partial class HtmlParser {
        private ParserState State = ParserState.Default;

        public HtmlDocument Parse (string content) {
            var doc = new HtmlDocument ();
            return doc;
        }
    }
}