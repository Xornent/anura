using Anura;
using Anura.JavaScript;
using Anura.JavaScript.Native;
using Anura.Styles;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Anura
{
    public static class Global
    {
        public static void InitializeCore(string clientVersion = "0.0.0.0") {
            InitializeUserAgent(clientVersion);
        }

        public static void InitializeUserAgent(string clientVersion = "0.0.0.0") {
            string uagent = "Anura/" + clientVersion;
            string system = "Unknown";
            if (Environment.OSVersion.Platform == System.PlatformID.Win32NT)
                system = "Windows NT " + Environment.OSVersion.Version.Major + "." + Environment.OSVersion.Version.Minor;
            string encrypt = "N";
            string culture = Culture;
            if (Environment.Is64BitProcess) system = system + "; x64";
            uagent = uagent + " (" + system + "; " + encrypt + "; " + culture + ") ";
            uagent = uagent + "Core/" + Versioning.CoreVersion.ToString();
            UserAgent = uagent;
        }

        public static string Culture = "zh-cn";
        public static string UserAgent = "";
    }
}