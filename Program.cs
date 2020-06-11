using System;

namespace Anura
{
    /// <summary>
    /// <h>项目的版本信息</h>
    /// <para>项目的版本命名规则请参见 <see cref="Documentation.Guildlines.Version"/></para>
    /// </summary>
    public static class Versioning
    {
        /// <summary>
        /// 特异版本号 <br/>
        /// </summary>
        public static Version CoreVersion = new Version(0, 0, 4, 1038);
        public static VersionMode Mode = VersionMode.Insider;
        public static bool DebugMode = true;

        public enum VersionMode
        {
            Insider,
            Preview,
            Candidate,
            Stable
        }
    }

    /// <summary>
    /// <h>Anura 命令行工具的总入口点。</h>
    /// 
    /// <para>在项目的属性中选择输出类库文件可以停止生成命令行类型工具。 此时，
    /// 初始化 Anura 需要调用 <see cref="Anura.Global.InitializeCore(string)"></see></para>
    /// <para><i>不要从程序的外部调用本类</i></para>
    /// </summary>
    public class Program
    {
        [STAThread]
        internal static void Main(string[] args) {
            Anura.Global.InitializeCore();
        }
    }

    internal static class Documentation
    {
        /// <summary>
        /// 代码规范
        /// ---
        /// </summary>
        internal static class Guildlines
        {
            /// <summary>
            /// 版本命名规范
            /// </summary>
            internal static class Version { }
        }
    }
}