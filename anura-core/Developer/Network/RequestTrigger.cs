using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anura.Developer.Network {
    public enum RequestTrigger {
        Document,
        SubDocument,
        Fetch,
        XHR,
        Script,
        Stylesheet,
        Font,
        Image,
        ImageSet,
        Beacon
    }
}