using System;
using System.Collections;
using System.Collections.Generic;

using Anura;
using Anura.Html;
using Anura.Developer;
using Anura.Styles;
using Anura.JavaScript;
using Anura.JavaScript.Native;

namespace Anura.Presentation {
    /// <summary>
    /// This interface `Anura.Presentation.RawInfrastructure` is a public portal to implement
    /// different rendering engines into the standardize `Anura Rendering Infrastructure` type
    /// mapping in `namespace Anura.Presentation`.
    ///  
    /// Application inside `Anura.Core` should not directly call methods in this interface,
    /// and all registered rendering engine implementation will be loaded on startup
    /// `Anura.Global.InitializeCore()`
    /// </summary>
    public partial interface RawInfrastructure {

        // todo: Allocation

        void AllocateTool(Tools.ToolType type, UInt32 id);
        void DisposeTool(Tools.ToolType type, UInt32 id);
        void AllocateTool(Tools.ITool tool);
        void DisposeTool(Tools.ITool tool);
        Tools.ITool GetRegisteredTool(Tools.ToolType type, UInt32 id);
    }
}