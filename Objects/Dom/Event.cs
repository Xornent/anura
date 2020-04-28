using System;
using System.Collections;
using System.Collections.Generic;

using Anura;
using Anura.Html;
using Anura.Developer;
using Anura.Styles;
using Anura.JavaScript;
using Anura.JavaScript.Native;

namespace Anura.Objects.Dom {
    public partial class Event {

        // 用来表示该事件是否在DOM中冒泡
        public bool Bubbles { get; set; } = true;

        // 用来表示这个事件是否可以取消
        public bool Cancelable { get; set; } = true;

        // 指示该事件是否可以从 Shadow DOM 传递到一般的 DOM
        public bool Composed { get; set; } = false;
        
        // 当前注册事件的对象的引用。这是一个这个事件目前需要传递到的对象
        // （译者：大概意思就是注册这个事件监听的对象）。这个值会在传递的途中进行改变
        public EventTarget Target{ get; set; }

        // 一个由事件流经过了的 DOM Node 组成的 Array
        public List<Node> DeepPath { get; set; } = new List<Node>();

        public bool DefaultPrevented { get; set; } = false;
    }
}