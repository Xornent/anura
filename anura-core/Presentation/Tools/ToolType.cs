using System;
using System.Collections;
using System.Collections.Generic;

using Anura;
using Anura.Html;
using Anura.Developer;
using Anura.Styles;
using Anura.JavaScript;
using Anura.JavaScript.Native;

namespace Anura.Presentation.Tools {
    public enum ToolType {
        SolidBrush,
        LinearGradientBrush,
        RadialGradientBrush,
        TextureBrush,
        Pen,
        Bitmap,
        Effect,
        Path,
        Renderer,
        Unidentified
    }
}