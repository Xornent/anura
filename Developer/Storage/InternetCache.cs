using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anura.Developer.Storage {
    public class InternetCache {
        public Network.ResponseDocument Document { get; set; }

        public DateTime InCache => Document.InCache;
        public DateTime? Expired => Document.Expired;
        public DateTime? LastModified => Document.LastModified;
        public int? Age => Document.Age;
        public string ETag => Document.ETag;
        public bool NoRequest => Document.NoRequest;

        public Uri Uri => Document.Location;
    }
}