// Copyright (c) 2020 Jonathan Wood (www.softcircuits.com)
// Licensed under the MIT license.
//

using System;

namespace Anura.JavaScript.Formatter {
    /// <summary>
    /// State flags for the current line.
    /// </summary>
    [Flags]
    internal enum LineFlags {
        None = 0,
        BlockKeyword = 1,
        DoKeyword = 2,
        EndDoBlock = 4,
        CaseKeyword = 8,
        JsonColon = 16,
        QuestionMark = 32,
    }
}