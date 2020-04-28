using System;
using Anura.Html;

namespace Anura.Html {
    public struct HtmlParserError {
        public HtmlParserError (int ln, int col, GenericErrorType type) {
            this.Line = ln;
            this.Column = col;
            this.Type = type;
            switch (this.Type) {
                case GenericErrorType.UnstandardizedTagName:
                    this.Message = "本 Html 文档中的标签名称没有在 Anura 遵循的 HTML 或 W3C 和 WHATWAG 标准中被定义：这通常发生在网页作者的笔误，一些 Anura 内部界面，和 Anura 不鼓励用户使用的接口中发生。";
                    break;
                case GenericErrorType.IrregularBraceMatching:
                    this.Message = "错误的层叠结构，不好的编码习惯，和偶尔的笔误会导致标签在不应关闭时关闭.";
                    break;
                case GenericErrorType.SenselessEnbed:
                    this.Message = " 一些元素不能加在指定的元素中.";
                    break;
                default:
                    this.Message = "";
                    break;
            }
        }

        public HtmlParserError (int ln, int col, GenericErrorType type, string msg) {
            this.Line = ln;
            this.Column = col;
            this.Message = msg;
            this.Type = type;
        }

        public int Line;
        public int Column;
        public string Message;
        public GenericErrorType Type;
    }

    public enum GenericErrorType {
        
        // 本 Html 文档中的标签名称没有在 Anura 遵循的 HTML 或 W3C 和 WHATWAG 标准
        // 中被定义：这通常发生在网页作者的笔误，一些 Anura 内部界面，和 Anura 不鼓励
        // 用户使用的接口中发生。
        // 
        // 此异常不会抛出，甚至不会提示；自定义的标签将被归属于 Specified.UnidentifiedNode
        // 类型中，并同样支持 XPath 导航。
        UnstandardizedTagName,

        // 错误的层叠结构，不好的编码习惯，和偶尔的笔误会导致标签在不应关闭时关闭.
        // 下面是几个容易引发异常的例子：
        // + 在本该使用 <br> 时使用了 </br>
        // + 混乱的嵌套结构 <a><b></a></b>
        IrregularBraceMatching,

        // 一些元素不能加在指定的元素中. 例如：
        // + Head 元素中不能嵌套可视容器
        // + Table 元素不允许不在 TD 和 TR 中的其他子元素
        SenselessEnbed,

        Otherwise
    }
}