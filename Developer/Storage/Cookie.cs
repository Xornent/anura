using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anura.Developer.Storage {
    public class Cookie {
        public Cookie (string key, string cont) {
            this.Key = key;
            this.Content = cont;
        }

        public string Key;
        public string Content;
    }
}