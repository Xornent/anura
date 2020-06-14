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
        public static Version CoreVersion = new Version(1,1,0,415);
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
    public class Program
    {
        [STAThread]
        internal static void Main(string[] args) {
            Anura.Global.InitializeCore();
            Console.WriteLine(Global.UserAgent);

            // 命令行逻辑

            Console.WriteLine("Press Any Key To Continue ...");
            Console.ReadLine();
        }
    }
#endif

    internal static class Documentation
    {
        /// <summary>
        /// [[0]] 代码规范
        /// </summary>
        internal static class Guildlines
        {
            /// <summary>
            /// [[0]] 版本命名规范
            /// </summary>
            internal static class Version { }

            /// <summary>
            /// <h>注释和文档注释规范</h>
            /// 
            /// <h2>注释规范</h2> 
            /// 
            /// <h3>在何处写注释</h3> 
            /// 
            /// <para>这里的注释是不生成公共 Api 文档的，仅用作在代码中说明某个代码段的作用和注意事项的说明性文字。
            /// 作为代码的开发者，我们非常需要这样的帮助文本来快速调节程序的工作途径，并且避免陷入困境。
            /// 下面，我们举出非常需要注释的例子。不过其他情况应该有写注释的人自己决定</para>
            /// <list type="number">
            /// <item>当参数可以传入 null 时，指明 null 的后果</item>
            /// <item>处理（解码）字符串时，大小写、是否带引号、单引号等注意事项</item>
            /// <item>大括号嵌套过多时（方法内超过4个），应在初始大括号前描述作用</item>
            /// <item>递归调用 ...</item>
            /// </list>
            /// 
            /// <h3>改写注释</h3> 
            /// 
            /// <list type="number">
            /// <item>如果项目的文档存在，也需要经常使用，请将引用的其他文字的注释改写成简体中文。
            ///      （当然，Url 等可以不改写语言。</item>
            /// <item>除非必须要求，不要用其他语言写注释，请使用简体中文。</item>
            /// </list>
            /// 
            /// <h3>格式</h3> 
            /// 
            /// <para>注释采用 稀疏空行 格式，即在注释（文档注释除外的所有注释）前后各空一行。一行不要超过 70 个
            /// 中文汉字（或 100 个英文字母） 当然，一个完整的 Url 超出字数不换行</para>
            /// <code>
            /// private int instance = 0;
            /// 
            /// // 我们习惯于将文档编写在代码文件中，而不是创建单独的 Markdown 文件。 因此，我们
            /// // 希望所有的公共类都有文档注释。
            /// 
            /// private class Comment { }
            /// </code>
            /// <para>因此，注释太过细碎会很难看，所以你可以在一个语句的开头将注释集合起来写。</para>
            /// <code>
            /// // 在以下代码段中，
            /// //   radius - 圆的半径
            /// //   ratio  - 角度转弧度常量；值等于 0.017453f (pi/180)
            /// 
            /// float s = pi * ( radius * radius ) * ( sweep * ratio / ( 2 * pi ) );
            /// </code>
            /// <para>而不是这样</para>
            /// <code>
            /// float s = pi * ( radius // 圆的半径
            /// * radius ) * ( sweep * ratio // 角度转弧度常量；值等于 0.017453f (pi/180)
            /// / ( 2 * pi ) );
            /// </code>
            /// <para>或者这样，用单行的多行注释格式显得非常误导人，什么是注释，什么是除号？</para>
            /// <code>
            /// float s = pi * ( radius /* 圆的半径 */ * radius ) * ( sweep * ratio /*角度转弧度常量；
            /// 值等于 0.017453f (pi/180)*/ / ( 2 * pi ) );
            /// </code>
            /// </summary>
            internal static class Comment { }

            /// <summary>
            /// [[0]] 语言规范
            /// </summary>
            internal static class Language { }
        }
    }
}