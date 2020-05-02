using System;

namespace Anura.Typography.OpenFont {
    [Flags]
    public enum IBMFontClassParametersKind {
        No_Classification = 0x0,
        Class1 = 0x100,
        OldStyle_Serifs = 0x100,
        Class1_No_Classification = 0x100,
        Class1_IBM_Rounded_Legibility = 0x101,
        Class1_Garalde = 0x102,
        Class1_Venetian = 0x103,
        Class1_Modified_Venetian = 0x104,
        Class1_Dutch_Modern = 0x105,
        Class1_Dutch_Traditional = 0x106,
        Class1_Comtemporary = 0x107,
        Class1_Calligraphic = 0x108,
        Class1_Miscellaneous = 0x10F,
        Class2 = 0x200,
        Class2_No_Classification = 0x200,
        Class2_Direct_Line = 0x201,
        Class2_Script = 0x202,
        Class2_Miscellaneous = 0x20F
    }
}