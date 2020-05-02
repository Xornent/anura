using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anura.Developer {
    public class NavigationExceptions {
        public bool IsError { get; set; }
        public string Exception { get; set; }
        public string StackTrace { get; set; } = "";
        public string File { get; set; } = "";

        public override string ToString () {
            string s = Exception;
            if (StackTrace != "")
                s = s + "\n" + StackTrace;
            return s;
        }
    }
}