using System;

namespace Anura.Typography.OpenFont {
    [Flags]
    public enum ReadFlags {
        Full = 0x0,
        Name = 0x1,
        Matrix = 0x4,
        AdvancedLayout = 0x8,
        Variation = 0x10
    }
}