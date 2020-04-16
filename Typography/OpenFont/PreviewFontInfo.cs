using Anura.Typography.OpenFont.Extensions;

namespace Anura.Typography.OpenFont {
    public class PreviewFontInfo {
        public readonly string Name;

        public readonly string SubFamilyName;

        public readonly TranslatedOS2FontStyle OS2TranslatedStyle;

        public readonly ushort Weight;

        private PreviewFontInfo[] _ttcfMembers;

        public int ActualStreamOffset {
            get;
            internal set;
        }

        public bool IsWebFont {
            get;
            internal set;
        }

        public bool IsFontCollection => _ttcfMembers != null;

        public int MemberCount => _ttcfMembers.Length;

        public PreviewFontInfo (string fontName, string fontSubFam, ushort weight, TranslatedOS2FontStyle os2TranslatedStyle = TranslatedOS2FontStyle.UNSET) {
            Name = fontName;
            SubFamilyName = fontSubFam;
            Weight = weight;
            OS2TranslatedStyle = os2TranslatedStyle;
        }

        public PreviewFontInfo (string fontName, PreviewFontInfo[] ttcfMembers) {
            Name = fontName;
            SubFamilyName = "";
            _ttcfMembers = ttcfMembers;
        }

        public PreviewFontInfo GetMember (int index) {
            return _ttcfMembers[index];
        }
    }
}