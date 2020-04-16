using System;

namespace Anura.Typography.OpenFont.Extensions {
    [Flags]
    public enum TranslatedOS2FontStyle : ushort {
        UNSET = 0x0,
        ITALIC = 0x1,
        BOLD = 0x2,
        REGULAR = 0x4,
        OBLIQUE = 0x8
    }
}