using System.Collections.Generic;

namespace Anura.Typography.OpenFont.CFF {
    internal class CFFOperator {
        private readonly byte _b0;

        private readonly byte _b1;

        private readonly OperatorOperandKind _operatorOperandKind;

        private static Dictionary<int, CFFOperator> s_registered_Operators;

        public string Name {
            get;
            private set;
        }

        private CFFOperator (string name, byte b0, byte b1, OperatorOperandKind operatorOperandKind) {
            _b0 = b0;
            _b1 = b1;
            Name = name;
            _operatorOperandKind = operatorOperandKind;
        }

        public static CFFOperator GetOperatorByKey (byte b0, byte b1) {
            s_registered_Operators.TryGetValue ((b1 << 8) | b0, out CFFOperator value);
            return value;
        }

        private static void Register (byte b0, byte b1, string operatorName, OperatorOperandKind opopKind) {
            s_registered_Operators.Add ((b1 << 8) | b0, new CFFOperator (operatorName, b0, b1, opopKind));
        }

        private static void Register (byte b0, string operatorName, OperatorOperandKind opopKind) {
            s_registered_Operators.Add (b0, new CFFOperator (operatorName, b0, 0, opopKind));
        }

        static CFFOperator () {
            s_registered_Operators = new Dictionary<int, CFFOperator> ();
            Register (0, "version", OperatorOperandKind.SID);
            Register (1, "Notice", OperatorOperandKind.SID);
            Register (12, 0, "Copyright", OperatorOperandKind.SID);
            Register (2, "FullName", OperatorOperandKind.SID);
            Register (3, "FamilyName", OperatorOperandKind.SID);
            Register (4, "Weight", OperatorOperandKind.SID);
            Register (12, 1, "isFixedPitch", OperatorOperandKind.Boolean);
            Register (12, 2, "ItalicAngle", OperatorOperandKind.Number);
            Register (12, 3, "UnderlinePosition", OperatorOperandKind.Number);
            Register (12, 4, "UnderlineThickness", OperatorOperandKind.Number);
            Register (12, 5, "PaintType", OperatorOperandKind.Number);
            Register (12, 6, "CharstringType", OperatorOperandKind.Number);
            Register (12, 7, "FontMatrix", OperatorOperandKind.Array);
            Register (13, "UniqueID", OperatorOperandKind.Number);
            Register (5, "FontBBox", OperatorOperandKind.Array);
            Register (12, 8, "StrokeWidth", OperatorOperandKind.Number);
            Register (14, "XUID", OperatorOperandKind.Array);
            Register (15, "charset", OperatorOperandKind.Number);
            Register (16, "Encoding", OperatorOperandKind.Number);
            Register (17, "CharStrings", OperatorOperandKind.Number);
            Register (18, "Private", OperatorOperandKind.NumberNumber);
            Register (12, 20, "SyntheticBase", OperatorOperandKind.Number);
            Register (12, 21, "PostScript", OperatorOperandKind.SID);
            Register (12, 22, "BaseFontName", OperatorOperandKind.SID);
            Register (12, 23, "BaseFontBlend", OperatorOperandKind.SID);
            Register (12, 30, "ROS", OperatorOperandKind.SID_SID_Number);
            Register (12, 31, "CIDFontVersion", OperatorOperandKind.Number);
            Register (12, 32, "CIDFontRevision", OperatorOperandKind.Number);
            Register (12, 33, "CIDFontType", OperatorOperandKind.Number);
            Register (12, 34, "CIDCount", OperatorOperandKind.Number);
            Register (12, 35, "UIDBase", OperatorOperandKind.Number);
            Register (12, 36, "FDArray", OperatorOperandKind.Number);
            Register (12, 37, "FDSelect", OperatorOperandKind.Number);
            Register (12, 38, "FontName", OperatorOperandKind.SID);
            Register (6, "BlueValues", OperatorOperandKind.Delta);
            Register (7, "OtherBlues", OperatorOperandKind.Delta);
            Register (8, "FamilyBlues", OperatorOperandKind.Delta);
            Register (9, "FamilyOtherBlues", OperatorOperandKind.Delta);
            Register (12, 9, "BlueScale", OperatorOperandKind.Number);
            Register (12, 10, "BlueShift", OperatorOperandKind.Number);
            Register (12, 11, "BlueFuzz", OperatorOperandKind.Number);
            Register (10, "StdHW", OperatorOperandKind.Number);
            Register (11, "StdVW", OperatorOperandKind.Number);
            Register (12, 12, "StemSnapH", OperatorOperandKind.Delta);
            Register (12, 13, "StemSnapV", OperatorOperandKind.Delta);
            Register (12, 14, "ForceBold", OperatorOperandKind.Boolean);
            Register (12, 17, "LanguageGroup", OperatorOperandKind.Number);
            Register (12, 18, "ExpansionFactor", OperatorOperandKind.Number);
            Register (12, 19, "initialRandomSeed", OperatorOperandKind.Number);
            Register (19, "Subrs", OperatorOperandKind.Number);
            Register (20, "defaultWidthX", OperatorOperandKind.Number);
            Register (21, "nominalWidthX", OperatorOperandKind.Number);
        }
    }
}