using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anura.Developer.Network;

namespace Anura.Developer.Source {
    public class Debug : Network.ResponseDocument {

    }

    public class DebugHandler : Application.IHandler {
        public ResponseDocument Load (ResponseDocument resp) {
            Debug dbg = new Debug () {
                Cache = resp.Cache,
                ClientDirty = false,
                ETag = resp.ETag,
                Content = resp.Content,
                LastModified = resp.LastModified,
                Location = resp.Location,
                Response = resp.Response,
                Age = resp.Age,
                Expired = resp.Expired,
                InCache = resp.InCache
            };
            resp = null;
            return dbg;
        }
    }
}