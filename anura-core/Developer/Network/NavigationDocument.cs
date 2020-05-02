using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anura.Developer.Network {
    public class NavigationDocument {
        public NavigationDocument (string uri) {
            this.Configuration = new NetworkConfiguration ();
            Uri = uri;
            this.MainPageWorker.DoWork += MainPageWorker_DoWork;
            this.MainPageWorker.RunWorkerCompleted += MainPageWorker_RunWorkerCompleted;
            this.MainPageWorker.RunWorkerAsync ();
        }

        public NavigationDocument (NetworkConfiguration config, string uri) {
            this.Configuration = config;
            Uri = uri;
            this.MainPageWorker.DoWork += MainPageWorker_DoWork;
            this.MainPageWorker.RunWorkerCompleted += MainPageWorker_RunWorkerCompleted;
            this.MainPageWorker.RunWorkerAsync ();
        }

        private void MainPageWorker_RunWorkerCompleted (object sender, RunWorkerCompletedEventArgs e) {
            this.ResourceWorker.DoWork += ResourceWorker_DoWork;
            this.ResourceWorker.RunWorkerCompleted += ResourceWorker_RunWorkerCompleted;
            this.ResourceWorker.RunWorkerAsync ();
            this.SpecificationWorker.DoWork += SpecificationWorker_DoWork;
            this.SpecificationWorker.RunWorkerCompleted += SpecificationWorker_RunWorkerCompleted;
            this.SpecificationWorker.RunWorkerAsync ();
        }

        private void SpecificationWorker_RunWorkerCompleted (object sender, RunWorkerCompletedEventArgs e) {
            SpecificationWorker.RunWorkerAsync ();
        }

        private void SpecificationWorker_DoWork (object sender, DoWorkEventArgs e) {
            System.Threading.Thread.Sleep (100);
        }

        private void ResourceWorker_RunWorkerCompleted (object sender, RunWorkerCompletedEventArgs e) {
            ResourceWorker.RunWorkerAsync ();
        }

        private void ResourceWorker_DoWork (object sender, DoWorkEventArgs e) {
            if (Documents.Count > 0)
                foreach (var item in Documents) {
                    if (item != null)
                        if (item.ClientDirty) {
                            Logger.Log (item.Response.File, "调用了文件的更新：这是一个无意义的填充",
                                "  建立请求耗时： " + item.Response.BuildRequestTimeout + " ms\n" +
                                "  获取响应耗时： " + item.Response.GetRequestTimeout + " ms\n" +
                                "  校验储存网络缓存耗时： " + item.Response.CheckCacheTimeout + " ms\n" +
                                "  下载网络流耗时： " + item.Response.DownloadStreamTimeout + " ms\n" +
                                "  解压缩耗时： " + item.Response.DecompressionTimeout + " ms\n" +
                                "  总计耗时： " + item.Response.TotalTimeout + " ms", Logger.LogStatus.Message);
                            item.ClientDirty = false;
                        }
                }

            if (this.ProcessUris.Count > 0) {
                if (ProcessUris[0].Item1.ToString ().Contains ("``404")) { } else {
                    if (ProcessUris[0].Item1 == null) { } else {
                        var item = this.ProcessUris[0];
                        if (Processed.Contains (item.ToString ())) {
                            Logger.Log (" ", "跳过了重复的文件 " + item.ToString (), "", Logger.LogStatus.OK);
                        } else {
                            Processed.Add (item.ToString ());
                            NetworkRequest req = new NetworkRequest (Configuration, item.Item1,
                                item.Item2, Storage, Referer);
                            NetworkResponse rsp = new NetworkResponse (req);
                            if (rsp.Document != null)
                                Documents.Add (rsp.Document);
                        }
                    }
                }
                this.ProcessUris.RemoveAt (0);
            } else
                System.Threading.Thread.Sleep (100);
        }

        private void MainPageWorker_DoWork (object sender, DoWorkEventArgs e) {
            NetworkRequest req = new NetworkRequest (Configuration, new System.Uri (Uri),
                RequestTrigger.Document, Storage, null);
            NetworkResponse rsp = new NetworkResponse (req);
            string content = rsp.ContentType.ToLower ().Replace (" ", "");
            List<string> types = content.Split (';').ToList ();
            Logger.Log (this.Uri, types[0] + " << " + content, "", Logger.LogStatus.Message);
            switch (types[0]) {
                case "text/html":
                    Referer = new Uri (Uri);
                    /*
                    Html.HtmlDocument doc = new Html.HtmlDocument ();
                    doc.LoadHtml (rsp.Document.Content);
                    LookupDocument (doc.DocumentNode);
                    */
                    break;
                default:
                    break;
            }
        }
        /*
        private void LookupDocument (Html.HtmlNode node) {
            switch (node.Name.ToLower ()) {
                case "link":
                    if (node.GetAttributeValue ("rel", "``404") == "stylesheet")
                        ProcessUris.Add ((CompositeUri (node.GetAttributeValue ("href", "``404")), RequestTrigger.Stylesheet));
                    break;
                case "img":
                    ProcessUris.Add ((CompositeUri (node.GetAttributeValue ("src", "``404")), RequestTrigger.Image));
                    break;
                case "script":
                    ProcessUris.Add ((CompositeUri (node.GetAttributeValue ("src", "``404")), RequestTrigger.Script));
                    break;
                default:
                    break;
            }
            if (node.HasChildNodes)
                foreach (var item in node.ChildNodes) {
                    LookupDocument (item);
                }
        }
        */

        private Uri CompositeUri (string uri) {
            System.Uri urio = null;
            bool tNorm = System.Uri.TryCreate (uri, UriKind.Absolute, out urio);
            if (tNorm == false) {
                bool t = System.Uri.TryCreate (Referer, uri, out urio);
                if (t == false) {
                    Logger.Log (Uri, "文件的 URI 引用根据已知的参照系是无效的. ", "源： " + uri, Logger.LogStatus.Warning);
                    return null;
                }
            }
            return urio;
        }

        BackgroundWorker MainPageWorker = new BackgroundWorker ();
        BackgroundWorker ResourceWorker = new BackgroundWorker ();
        BackgroundWorker SpecificationWorker = new BackgroundWorker ();

        public NetworkConfiguration Configuration { get; private set; }
        public string Uri { get; private set; }
        public Uri Referer { get; private set; }

        public static NetworkStorage GlobalStorage = new NetworkStorage ();
        public NetworkStorage Storage => GlobalStorage;
        private List<string> Processed = new List<string> ();
        private List < (Uri, RequestTrigger) > ProcessUris = new List < (Uri, RequestTrigger) > ();
        private List<ResponseDocument> Documents = new List<ResponseDocument> ();
    }
}