using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anura.Developer.Storage;

namespace Anura.Developer.Network {
    public class NetworkStorage {
        public ApplicationCacheCollection ApplicationCache = new ApplicationCacheCollection ();
        public ApplicationManifest Manifest = null;

        public CookieCollection Cookies = new CookieCollection ();
        public SessionCollection Sessions = new SessionCollection ();
        public LocalCollection Locals = new LocalCollection ();
        public InternetCacheCollection Cache = new InternetCacheCollection ();

        public BackgroundServiceCollection Services = new BackgroundServiceCollection ();
        public IndexedDBCollection IndexedDb = new IndexedDBCollection ();
    }
}