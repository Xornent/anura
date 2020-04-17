using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anura.JavaScript;

namespace Anura.Developer.Source {
    public class JavaScript : Network.ResponseDocument {
        public Esprima.Ast.Program AbstractTree;
        public bool Inline;
    }
}