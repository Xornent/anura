// Copyright (c) 2020 Jonathan Wood (www.softcircuits.com)
// Licensed under the MIT license.
//

using System;

namespace Anura.JavaScript.Formatter {
    /// <summary>
    /// State flags for the current indent block.
    /// </summary>
    [Flags]
    internal enum IndentFlags {
        None = 0,
        NoBraces = 1,
        DoBlock = 2,
        CaseBlock = 4,
        BracketBlock = 8,
    }
}