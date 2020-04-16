using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anura.Developer.Storage {
    public class CookieCollection : List<Cookie> {
        public bool TryGetKey (string key, out Cookie cookie) {
            foreach (var item in this) {
                if (item.Key == key) {
                    cookie = item;
                    return true;
                }
            }
            cookie = null;
            return false;
        }

        public bool CheckKey (string key) {
            foreach (var item in this) {
                if (item.Key == key)
                    return true;
            }
            return false;
        }

        public bool Delete (string key) {
            for (int c = 0; c < this.Count; c++) {
                if (this [c].Key == key) {
                    this.RemoveAt (c);
                    return true;
                }
            }
            return false;
        }
    }
}