using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anura.JavaScript;
using Anura.JavaScript.Ast;

namespace Anura.Developer.Source {
    public class JavaScript : Network.ResponseDocument {
        public Anura.JavaScript.Ast.Program AbstractTree;
        public bool Inline;
    }
}