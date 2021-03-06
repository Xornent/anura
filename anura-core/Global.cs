using Anura;
using Anura.Styles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Anura {

    /// <summary>
    /// Anura 内核的静态实用程序和加载属性
    /// 
    /// 包含对内核的初始化和用户代理字符串的初始化，和用户环境语言等设置。
    /// 在非命令行调用时需要手动初始化程序，可以通过 `Global.InitializeCore()` 方法
    /// </summary>
    public static class Global {

        /// <summary>
        /// 用指定的客户端版本号初始化 Anura 内核。
        /// 客户端版本号会出现在用户代理字符串中，大致形如：
        /// ```
        /// Anura/[客户端版本号] (Windows NT 6.0; N; zh-cn) Core/1.0.0.0
        /// ```
        /// </summary>
        /// <param name="clientVersion">指定客户端版本号字符串</param>
        public static void InitializeCore(string clientVersion = "0.0.0.0") {
            InitializeUserAgent(clientVersion);
            InitializeGl();
        }

        private static void InitializeUserAgent(string clientVersion = "0.0.0.0") {
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

        private static void InitializeGl() {
            if(Environment.OSVersion.Platform == PlatformID.Win32NT) {
#if windows
                Anura.Graphics.Gl.Current.Instance = new Anura.Graphics.Windows.WindowsOpenGl();
                Graphics.Gl.Current.Implemented = true;
#endif
            }

            // 如果没有检测到系统适配的 OpenGl 对象，Anura Core 的图形绘制部分
            // 将无法运行。 抛出警告，并设定无法运行标识

            if (Graphics.Gl.Current.Instance == null) {
                throw new Exceptions.GraphicSystemIncompatibleException();
                Graphics.Gl.Current.Implemented = false;
            }
        }

        private static string Culture = "zh-cn";
        public static string UserAgent { get; private set; }
    }
}