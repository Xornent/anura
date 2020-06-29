using System;

namespace Anura
{
    /// <summary>
    /// <h>项目的版本信息</h>
    /// </summary>
    public static class Versioning
    {
        /// <summary>
        /// 特异版本号
        /// </summary>
        public static Version CoreVersion = new Version(1, 1, 0, 415);
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

#if windows && cli
    /// <summary>
    /// <h>Anura 命令行工具的总入口点。</h>
    /// 
    /// <para>在项目的属性中选择输出类库文件可以停止生成命令行类型工具。 此时，
    /// 初始化 Anura 需要调用 <see cref="Anura.Global.InitializeCore(string)"></see></para>
    /// <para><i>不要从程序的外部调用本类</i></para>
    /// </summary>
    internal class Program
    {
        [STAThread]
        internal static void Main(string[] args)
        {
            Anura.Global.InitializeCore();
            Console.WriteLine(Global.UserAgent);

            // 命令行逻辑

#if debug
            Tests test = Tests.Typography;
            switch (test)
            {
                case Tests.Typography:
                    string filename = Console.ReadLine();
                    Typography.OpenFont.OpenFontReader reader = new Typography.OpenFont.OpenFontReader();
                    using (System.IO.FileStream fstream = new System.IO.FileStream(filename, System.IO.FileMode.Open))
                    {
                        var types = reader.Read(fstream);
                        Console.WriteLine("Total " + types.Glyphs.Length + " Glyphs");
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("Glyph " + (i + 1));
                            var glyph = types.Glyphs[i];
                            Console.WriteLine("  Bounds: " + glyph.Bounds.ToString());
                            int c = 1;
                            foreach (var pts in glyph.GlyphPoints)
                            {
                                Console.WriteLine("    Point " + c + ": (" + pts.X + ", " + pts.Y + ")");
                                c++;
                            }
                        }
                    }
                    break;
            }
#endif

            Console.WriteLine("Press Any Key To Continue ...");
            Console.ReadLine();
        }

#if debug
        internal enum Tests
        {
            Typography
        }
#endif
    }
#endif
}