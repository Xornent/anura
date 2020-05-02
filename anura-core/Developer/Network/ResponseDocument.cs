using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anura.Developer.Network {
    public class ResponseDocument {
        public Uri Location { get; set; }
        public String Content { get; set; }
        public Network.NetworkResponse Response { get; set; }

        public bool Cache { get; set; }

        public DateTime InCache { get; set; }
        public DateTime? Expired { get; set; } = null;
        public DateTime? LastModified { get; set; } = null;
        public int? Age { get; set; } = null;
        public string ETag { get; set; } = "";
        public bool NoRequest { get; set; } = false;

        public bool ClientDirty { get; set; }
    }
}