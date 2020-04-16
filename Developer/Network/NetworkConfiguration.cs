using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Anura.Developer.Network {
    public class NetworkConfiguration {
        public NetworkConfiguration () {
            Proxy = new System.Net.WebProxy ();
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback (CheckValidationResult);
        }

        public NetworkConfiguration (string address, string port) {
            this.DefaultProxy = false;
            this.Address = address;
            this.Port = port;
            this.UseAgent = true;
            Proxy = new System.Net.WebProxy (address + ":" + port);
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback (CheckValidationResult);
        }

        public NetworkConfiguration (string address, string port, string passport, string password) {
            this.DefaultProxy = false;
            this.Address = address;
            this.Port = port;
            this.Passport = passport;
            this.Password = password;
            this.UseAgent = true;
            this.UseAuthentication = true;
            Proxy = new System.Net.WebProxy (address + ";" + port);
            Proxy.Credentials = new NetworkCredential (passport, password);
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback (CheckValidationResult);
        }

        public bool CheckValidationResult (object sender,
            X509Certificate certificate, X509Chain chain, SslPolicyErrors errors) {
            if (IgnoreCertificate)
                return true;
            else {
                DateTime expire = DateTime.Parse (certificate.GetExpirationDateString ());
                if (expire > DateTime.Now)
                    return true;
                else return false;
            }
        }

        public void Bypass (bool onLocal, List<string> whiteList) {
            this.BypassLocal = onLocal;
            this.BypassWhiteList = whiteList;
            this.Proxy.BypassProxyOnLocal = onLocal;
            this.Proxy.BypassList = whiteList.ToArray ();
        }

        public System.Net.WebProxy Proxy;

        public string Address;
        public string Port;
        public string Passport;
        public string Password;

        public bool DefaultProxy = true;
        public bool IgnoreCertificate = false;
        public bool UseAgent = false;
        public bool UseAuthentication = false;
        public bool BypassLocal = true;
        public List<string> BypassWhiteList = new List<string> ();
        public bool ForcedRenew = false;
    }
}