using System;
using System.Collections;
using System.Collections.Generic;

using Anura;
using Anura.Html;
using Anura.Developer;
using Anura.Styles;
using Anura.JavaScript;
using Anura.JavaScript.Native;
using Anura.Objects.Attributes;

namespace Anura.Objects.Dom {
    public partial class Event {

        /// <summary>
        /// 用来表示该事件是否在DOM中冒泡
        /// </summary>
        public bool Bubbles { get; set; } = true;

        /// <summary>
        /// 用来表示这个事件是否可以取消
        /// </summary>
        public bool Cancelable { get; set; } = true;

        /// <summary>
        /// 指示该事件是否可以从 Shadow DOM 传递到一般的 DOM
        /// </summary>
        public bool Composed { get; set; } = false;
        
        /// <summary>
        /// 当前注册事件的对象的引用。这是一个这个事件目前需要传递到的对象
        /// （译者：大概意思就是注册这个事件监听的对象）。这个值会在传递的途中进行改变
        /// </summary>
        public EventTarget Target{ get; set; }

        /// <summary>
        /// 一个由事件流经过了的 DOM Node 组成的 Array
        /// </summary>
        public List<Node> DeepPath { get; set; } = new List<Node>();

        public bool DefaultPrevented { get; set; } = false;

        public EventPhase Phase { get; set; } = EventPhase.None;

        [CapabilityObsolete("Internet Explorer")]
        public bool ReturnValue => DefaultPrevented;

        [CapabilityObsolete("Internet Explorer")]
        public EventTarget SourceElement => Target;
        
        /// <summary>
        /// 事件创建时的时间戳，毫秒级别。按照规定，这个时间戳是距离某个特定时刻的差值，
        /// 但实际上在浏览器中此处的事件戳的定义有所不同。另外，正在开展工作将其改为 DOMHighResTimeStamp
        /// </summary>
        public DomTimeStamp TimeStamp { get; set; } = null;
        
        /// <summary>
        /// 事件类型，不区分大小写
        /// </summary>
        public string Type { get; set; } = "undefined";
        
        /// <summary>
        /// 指明事件是否是由浏览器（当用户点击实例后）或者由脚本（使用事件的创建方法，例如event.initEvent）启动
        /// </summary>
        public bool IsTrusted { get; set; } = false;

        private bool? PropagationFlag { get; set; } = null;
        
        [CapabilityObsolete("Dom Standard II")]
        public void InitializeEvent (string type = "undefined", bool bubble = true, bool cancelable = true){
            this.Type = type;
            this.Bubbles = bubble;
            this.Cancelable = cancelable;
        }
    }

    public enum EventPhase {
        None = 0,
        Capturing = 1,
        AtTarget = 2,
        Bubbling = 3
    }
}