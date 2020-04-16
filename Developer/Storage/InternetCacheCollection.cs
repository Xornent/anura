using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anura.Developer.Storage {
    public class InternetCacheCollection : List<InternetCache> {
        public bool TryGetKey (Uri key, out InternetCache cache) {
            foreach (var item in this) {
                if (item.Uri == key) {
                    cache = item;
                    return true;
                }
            }
            cache = null;
            return false;
        }

        public bool CheckKey (Uri key) {
            foreach (var item in this) {
                if (item.Uri == key)
                    return true;
            }
            return false;
        }

        public bool Delete (Uri key) {
            for (int c = 0; c < this.Count; c++) {
                if (this [c].Uri == key) {
                    this.RemoveAt (c);
                    return true;
                }
            }
            return false;
        }
    }
}