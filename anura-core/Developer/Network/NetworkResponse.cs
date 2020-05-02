using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Anura.Developer.Network {
    public class NetworkResponse {
        public NetworkResponse (NetworkRequest req) {
            Stopwatch ttl = new Stopwatch ();
            ttl.Start ();
            Request = req;
            req.Request.AllowAutoRedirect = true;
            req.Request.AuthenticationLevel = System.Net.Security.AuthenticationLevel.MutualAuthRequested;
            if (req.SendRequest) {

                Stopwatch swGreq = new Stopwatch ();
                swGreq.Start ();
                HttpWebResponse response = null;
                try {
                    response = (HttpWebResponse) req.Request.GetResponse ();
                    HasHeader = response.SupportsHeaders;
                    Raw = response;
                } catch (Exception ex) {
                    Logger.Log (req.File, "获得响应失败 " + ex.Message, ex.StackTrace + "\n  在 " + req.Uri.ToString (), Logger.LogStatus.Error);
                }
                swGreq.Stop ();
                this.GetRequestTimeout = swGreq.ElapsedMilliseconds;

                if (this.Raw != null && response != null) {
                    Stopwatch swCCache = new Stopwatch ();
                    swCCache.Start ();

                    // 返回 Not Modified(304), 直接使用缓存
                    if (this.Status == HttpStatusCode.NotModified) {
                        Anura.Developer.Storage.InternetCache cache = null;
                        bool success = Storage.Cache.TryGetKey (req.Request.RequestUri, out cache);
                        if (success) {
                            this.Document = cache.Document;
                            this.Document.Cache = true;
                        } else {
                            throw new AnuraException ("NetworkResponse::断言错误::发送的请求声称拥有缓存，但接受时未找到缓存。");
                        }
                    } else if (this.Status == HttpStatusCode.OK) {
                        // 缓存检测, 按优先级 pragma > cache-control > expires
                        ResponseDocument doc = new ResponseDocument ();

                        bool useCache = false;
                        // Pragma 检测
                        if (response.Headers.Get ("pragma") != "") {
                            if (response.Headers.Get ("pragma") == "no-cache")
                                useCache = false;
                            else useCache = true;
                        } else if (response.Headers.Get ("cache-control") != "") {
                            // Cache-Control 检测
                            var str = response.Headers.Get ("cache-control").ToLower ();
                            if (str.Contains ("no-store") || str.Contains ("no-cache"))
                                useCache = false;
                            else if (str.Contains ("must-revalidate") || str.Contains ("proxy-revalidate")) {
                                useCache = true;
                            } else {
                                useCache = true;
                            }
                        }

                        // Internet Cache 判据
                        if (useCache) {
                            // max-age 和 s-maxage 判据
                            var ccontrol = response.Headers.Get ("cache-control").ToLower ().Replace (" ", "");
                            if (ccontrol.Contains ("max-age") || ccontrol.Contains ("s-maxage"))
                                if (ccontrol.Contains (",")) {
                                    var sl = ccontrol.Split (',');
                                    foreach (var item in sl) {
                                        var age = item.Split ('=');
                                        if (age[0] == "max-age" || age[0] == "s-maxage")
                                            doc.Age = Convert.ToInt32 (age[1]);
                                    }
                                } else {
                                    doc.Age = Convert.ToInt32 (ccontrol.Split ('=') [1]);
                                }
                            // Last-Modified 判据
                            var lmod = response.Headers.Get ("last-modified");
                            if (lmod != null)
                                if (lmod != "")
                                    doc.LastModified = DateTime.Parse (lmod);
                            // ETag 判据
                            var etg = response.Headers.Get ("etag");
                            if (etg != "")
                                doc.ETag = etg;
                            // Expires 判据
                            var exp = response.Headers.Get ("expires");
                            if (exp != "" && exp != null)
                                doc.Expired = DateTime.Parse (exp);

                            doc.InCache = DateTime.Now.ToUniversalTime ();
                            // 将当前文档加入（覆盖）原有的储存
                            if (Storage.Cache.CheckKey (req.Request.Address)) {
                                Storage.Cache.Delete (req.Request.Address);
                                doc.Cache = true;
                                Storage.Cache.Add (new Developer.Storage.InternetCache () {
                                    Document = doc,
                                });
                            } else {
                                Storage.Cache.Add (new Developer.Storage.InternetCache () {
                                    Document = doc,
                                });
                            }
                        }

                        swCCache.Stop ();
                        CheckCacheTimeout = swCCache.ElapsedMilliseconds;

                        Stopwatch swGStr = new Stopwatch ();
                        swGStr.Start ();
                        doc.ClientDirty = true;
                        // Get the stream associated with the response.
                        Stream receiveStream = response.GetResponseStream ();
                        swGStr.Stop ();
                        DownloadStreamTimeout = swGStr.ElapsedMilliseconds;

                        Stopwatch swDecom = new Stopwatch ();
                        swDecom.Start ();
                        Stream decompress = null;
                        // Decompress the Stream.
                        switch (ContentEncoding) {
                            case "gzip":
                                decompress = new System.IO.Compression.GZipStream (receiveStream, System.IO.Compression.CompressionMode.Decompress);
                                break;
                            case "deflate":
                                decompress = new System.IO.Compression.DeflateStream (receiveStream, System.IO.Compression.CompressionMode.Decompress);
                                break;
                            default:
                                decompress = receiveStream;
                                break;
                        }

                        string content = this.ContentType.ToLower ().Replace (" ", "");
                        List<string> types = content.Split (';').ToList ();
                        string enc = "utf-8";
                        if (types.Count > 1) {
                            enc = types[1].ToLower ().Replace ("charset=", "").Trim ();
                        }

                        if (enc == "binary") {

                        } else {
                            // Pipes the stream to a higher level stream reader with the required encoding format. 
                            StreamReader readStream = new StreamReader (decompress, Encoding.GetEncoding (enc));
                            doc.Content = readStream.ReadToEnd ();
                            readStream.Close ();
                            receiveStream.Close ();
                        }
                        swDecom.Stop ();
                        DecompressionTimeout = swDecom.ElapsedMilliseconds;
                        Document = doc;

                    } else if (response.StatusCode == HttpStatusCode.GatewayTimeout) {
                        Document = null;
                    } else {
                        Document = null;
                    }
                }
            } else {
                Anura.Developer.Storage.InternetCache cache = null;
                bool success = Storage.Cache.TryGetKey (req.Request.RequestUri, out cache);
                if (success) {
                    this.Document = cache.Document;
                    this.Document.Cache = true;
                } else {
                    throw new AnuraException ("NetworkResponse::断言错误::发送的请求声称拥有缓存，但接受时未找到缓存。");
                }
            }
            if (this.Document != null)
                this.Document.Response = this;
            ttl.Stop ();
            TotalTimeout = ttl.ElapsedMilliseconds;
        }

        public NetworkRequest Request { get; private set; }
        public HttpWebResponse Raw { get; private set; }
        public bool HasHeader { get; private set; }
        public NetworkStorage Storage => Request?.Storage;

        public string CharacterSet => Raw?.CharacterSet;
        public string ContentEncoding => Raw?.ContentEncoding;
        public string ContentType => Raw?.ContentType;
        public long? ContentLength => Raw?.ContentLength;

        public bool? FromCache => Raw?.IsFromCache;
        public string Server => Raw?.Server;
        public Uri Uri => Raw?.ResponseUri;
        public string File => Request.File;
        public DateTime? LastModified => Raw?.LastModified;
        public string Method => Raw?.Method;
        public Version HttpProtocal => Raw?.ProtocolVersion;
        public HttpStatusCode? Status => Raw?.StatusCode;

        public ResponseDocument Document { get; private set; } = null;

        public long GetRequestTimeout = 0;
        public long CheckCacheTimeout = 0;
        public long DownloadStreamTimeout = 0;
        public long DecompressionTimeout = 0;
        public long TotalTimeout = 0;

        public long BuildRequestTimeout => Request.BuildingRequest;
    }
}