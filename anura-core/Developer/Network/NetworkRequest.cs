using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Anura.Developer.Network {
    public class NetworkRequest {
        public NetworkRequest (NetworkConfiguration config, Uri uri, RequestTrigger trigger, NetworkStorage storage, Uri referer) {
            System.Diagnostics.Stopwatch Watch = new System.Diagnostics.Stopwatch ();

            Watch.Reset ();
            Watch.Start ();
            if (uri.Scheme.Contains ("file"))
                uri = new Uri (uri.ToString ().Replace ("file:///", "https://").Replace ("file://", "https://"));
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create (uri);
            if (!config.DefaultProxy)
                req.Proxy = config.Proxy;

            string accepted = "";
            switch (trigger) {
                case RequestTrigger.Document:
                    accepted = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                    break;
                case RequestTrigger.SubDocument:
                    accepted = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                    break;
                case RequestTrigger.Fetch:
                    accepted = "*/*";
                    break;
                case RequestTrigger.XHR:
                    accepted = "*/*";
                    break;
                case RequestTrigger.Script:
                    accepted = "*/*";
                    break;
                case RequestTrigger.Stylesheet:
                    accepted = "text/css,*/*;q=0.1";
                    break;
                case RequestTrigger.Font:
                    accepted = "application/font-woff2;q=1.0,application/font-woff;q=0.9,*/*;q=0.8";
                    break;
                case RequestTrigger.Image:
                    accepted = "image/webp,*/*";
                    break;
                case RequestTrigger.ImageSet:
                    accepted = "image/webp,*/*";
                    break;
                case RequestTrigger.Beacon:
                    accepted = "*/*";
                    break;
                default:
                    break;
            }
            req.Accept = accepted;
            Accepted = accepted;

            req.Headers.Add (HttpRequestHeader.AcceptEncoding, AcceptEncoding);
            if (config.ForcedRenew)
                req.Headers.Add (HttpRequestHeader.CacheControl, CacheControl);
            req.KeepAlive = true;
            req.Headers.Add (HttpRequestHeader.AcceptLanguage, AcceptLanguage);
            req.Host = uri.Host;
            if (trigger != RequestTrigger.Document)
                if (referer != null)
                    req.Referer = referer.ToString ();

            req.UserAgent = UserAgent.Anura
                .Replace ("{SYS_VER_PLAT}", "Windows NT 10.0; Win64; x64");

            // 校验 Internet Cache 缓存
            Anura.Developer.Storage.InternetCache cache = null;
            // 根据当前的 Uri 查找缓存库中是否存在当前资源
            bool exist = storage.Cache.TryGetKey (uri, out cache);
            if (exist) {
                // 该资源已缓存
                // 检查（是否有）是否过期
                var present = DateTime.Now.ToUniversalTime ();

                // 是否永久强制保存
                if (cache.NoRequest)
                    this.SendRequest = false;

                // 是否在 Max-Age 内强制保存
                if (cache.Age != null) {
                    if ((present - cache.InCache).TotalSeconds < cache.Age)
                        this.SendRequest = false;
                } else if (cache.Expired > present) {

                } else {
                    // If-Modified-Since 标签检测
                    if (cache.LastModified != null)
                        req.IfModifiedSince = (DateTime) cache.LastModified?.ToUniversalTime ();
                    // ETag 检测器
                    if (cache.ETag != "")
                        req.Headers.Add ("If-None-Match", cache.ETag);
                    this.SendRequest = true;
                }
            } else {
                // 该资源未缓存，向服务器发起请求
                this.SendRequest = true;
            }

            Request = req;
            Watch.Stop ();
            this.BuildingRequest = Watch.ElapsedMilliseconds;
            Storage = storage;
        }

        public NetworkConfiguration Configuration { get; private set; }
        public NetworkStorage Storage { get; private set; }

        public string Accepted { get; private set; }
        public string AcceptEncoding = "gzip, deflate";
        public string AcceptLanguage = "zh-CN,zh;q=0.8,zh-TW;q=0.7,zh-HK;q=0.5,en-US;q=0.3,en;q=0.2";
        public string CacheControl = "max-age=0";
        public string Connection = "keep-alive";

        public long BuildingRequest { get; private set; } = 0;

        public System.Net.HttpWebRequest Request { get; private set; } = null;
        public bool SendRequest { get; private set; } = true;

        public Uri Uri => Request.RequestUri;
        public string Host => Request.RequestUri.Host;
        public string File {
            get {
                if (Request.RequestUri.PathAndQuery.Contains ("/"))
                    return Request.RequestUri.PathAndQuery.Split ('/').Last ().Trim ();
                else
                    return Request.RequestUri.PathAndQuery;
            }
        }

        public static class UserAgent {
            public static string Anura =
                "";

            public static string Opera =
                "Mozilla/5.0 ({SYS_VER_PLAT}) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.95 Safari/537.36 OPR/26.0.1656.60";
            public static string Firefox =
                "Mozilla/5.0 ({SYS_VER_PLAT}; rv:34.0) Gecko/20100101 Firefox/34.0";
            public static string Safari =
                "Mozilla/5.0 ({SYS_VER_PLAT}) AppleWebKit/534.57.2 (KHTML, like Gecko) Version/5.1.7 Safari/534.57.2";
            public static string Chrome =
                "Mozilla/5.0 ({SYS_VER_PLAT}) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.71 Safari/537.36";

            public static string Chromium360 =
                "Mozilla/5.0 ({SYS_VER_PLAT}) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/30.0.1599.101 Safari/537.36";
            public static string Trident360 =
                "Mozilla/5.0 ({SYS_VER_PLAT}; Trident/7.0; rv:11.0) like Gecko";
            public static string 淘宝浏览器 =
                "Mozilla/5.0 ({SYS_VER_PLAT}) AppleWebKit/536.11 (KHTML, like Gecko) Chrome/20.0.1132.11 TaoBrowser/2.0 Safari/536.11";
            public static string Chromium猎豹浏览器 =
                "Mozilla/5.0 ({SYS_VER_PLAT}) AppleWebKit/537.1 (KHTML, like Gecko) Chrome/21.0.1180.71 Safari/537.1 LBBROWSER";
            public static string Trident6猎豹浏览器 =
                "Mozilla/5.0 (compatible; MSIE 9.0; {SYS_VER_PLAT}; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E; LBBROWSER)";
            public static string Trident4猎豹浏览器 =
                "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; QQDownload 732; .NET4.0C; .NET4.0E; LBBROWSER)";
            public static string QQ浏览器 =
                "Mozilla/5.0 (compatible; MSIE 9.0; {SYS_VER_PLAT}; Trident/5.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET4.0C; .NET4.0E; QQBrowser/7.0.3698.400)";
            public static string 搜狗浏览器 =
                "Mozilla/5.0 ({SYS_VER_PLAT}) AppleWebKit/535.11 (KHTML, like Gecko) Chrome/17.0.963.84 Safari/535.11 SE 2.X MetaSr 1.0";
        }
    }
}