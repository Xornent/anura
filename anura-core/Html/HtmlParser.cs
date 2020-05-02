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
        private ParserState State = ParserState.BeforeStart;

        public HtmlDocument Parse (string content) {
            List<HtmlNode> heritages = new List<HtmlNode> ();
            var doc = new HtmlDocument ();

            content = content.Trim ();
            for (int i = 0; i < content.Length; i++) {
                
            }
            
            return doc;
        }

        public event EventHandler OnStyleDownload;
        public event EventHandler OnStyleParse;
        public event EventHandler OnSyntaxErrorFix;
        public event EventHandler OnScriptDownload;
        public event EventHandler OnScriptExecute;
        public event EventHandler OnResourceDownload;
    }
}