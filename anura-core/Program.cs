using Anura.Wasm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime;
using System.Runtime.CompilerServices;

[assembly: CLSCompliant(true)]
[assembly: InternalsVisibleTo("Windows")]

namespace Anura {

    /// <summary>
    /// 项目的版本信息
    /// </summary>
    public static class Versioning {

        /// <summary>
        /// 特异版本号
        /// 
        /// 版本号分为 4 个 `int32` 类型的子版本号，主版本，次版本，修补版本和编译版本。
        /// 主版本记录项目的里程碑，表示一个以完全实现的功能集；次版本表示实现的子功能；修补版本
        /// 表示对已有次版本的小幅度更改和安全更新；编译版本随每一次编译自增 1 。
        /// 
        /// 用户安装时，应该首选次版本为 0 的版本，因为其中只有以实现并且测试的功能，相对稳定，
        /// 尽量不要使用修补版本号，除非特定的安全和修复更新。
        /// </summary>
        public static Version CoreVersion = new Version (1, 3, 0, 431);

        /// <summary>
        /// 指示一个版本模式， 参见 [Anura.Versioning.VersionMode]
        /// </summary>
        public static VersionMode Mode = VersionMode.Insider;
        internal static bool DebugMode = true;

        /// <summary>
        /// 版本模式
        /// </summary>
        public enum VersionMode {

            /// <summary>
            /// 内部测试版本
            /// </summary>
            Insider,

            /// <summary>
            /// 发布预览版本
            /// </summary>
            Preview,

            /// <summary>
            /// 发布版本
            /// </summary>
            Stable
        }
    }

#if windows && cli
    internal class Program {
        [STAThread]
        internal static void Main (string[] args) {
            Anura.Global.InitializeCore ();
            Console.WriteLine (Global.UserAgent);

            // 命令行逻辑

            
            using(FileStream fs = new FileStream(@"g:\\n-wasm.wasm",FileMode.Open )) {
                Wasm.Reader reader = new Wasm.Reader();
                reader.Read(fs);
            }

            Console.WriteLine ("Press Any Key To Continue ...");
            Console.ReadLine ();
        }
    }
#endif
}