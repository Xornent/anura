using System;
using System.Collections;
using System.Collections.Generic;
using Anura;
using Anura.Developer;
using Anura.Html;
using Anura.JavaScript;
using Anura.JavaScript.Native;
using Anura.Styles;

namespace Anura {
    public static class Global {
        public static void InitializeCore () {
            InitializeUserAgent ();
        }

        public static void InitializeUserAgent () {
            string uagent = "Anura/" + Versioning.CoreVersion.ToString ();
            string system = "Unknown";
            if (Environment.OSVersion.Platform == System.PlatformID.Win32NT)
                system = "Windows NT " + Environment.OSVersion.Version.Major + "." + Environment.OSVersion.Version.Minor;
            string encrypt = "N";
            string culture = Culture;
            if (Environment.Is64BitProcess) system = system + "; x64";
            uagent = uagent + " (" + system + "; " + encrypt + "; " + culture + ") ";
            uagent = uagent + "JsInt/" + Versioning.JsIntepretorVersion.ToString () + " JsApi/" + Versioning.JsApiVersion.ToString ()
                + " Renderer/" + Versioning.RendererVersion.ToString ();
            Anura.Developer.Network.NetworkRequest.UserAgent.Anura = uagent;
        }

        public static string Culture = "zh-cn";
    }
}