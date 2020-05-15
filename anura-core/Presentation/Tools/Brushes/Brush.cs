using System;
using System.Collections;
using System.Collections.Generic;

using Anura;
using Anura.Html;
using Anura.Developer;
using Anura.Styles;
using Anura.JavaScript;
using Anura.JavaScript.Native;

namespace Anura.Presentation.Tools.Brushes {
    public partial interface IBrush : ITool {
        
    }

    public abstract class Brush : IBrush {
        public abstract ToolType GetToolType();
        public abstract UInt32 GetId();
        public abstract void Dispose();
    }
}