using System.Collections.Generic;

namespace Anura.Typography.OpenFont {
    public static class StringUtils {
        public static void FillWithCodepoints (List<int> codepoints, char[] str, int startAt = 0, int len = -1) {
            if (len == -1) {
                len = str.Length;
            }
            for (int i = 0; i < len; i++) {
                char c = str[startAt + i];
                int item = c;
                if (char.IsHighSurrogate (c) && i + 1 < len) {
                    char c2 = str[startAt + i + 1];
                    if (char.IsLowSurrogate (c2)) {
                        i++;
                        item = char.ConvertToUtf32 (c, c2);
                    }
                }
                codepoints.Add (item);
            }
        }

        public static IEnumerable<int> GetCodepoints (char[] str, int startAt = 0, int len = -1) {
            if (len == -1) {
                len = str.Length;
            }
            int num2;
            for (int i = 0; i < len; i = num2) {
                char c = str[startAt + i];
                int num = c;
                if (char.IsHighSurrogate (c) && i + 1 < len) {
                    char c2 = str[startAt + i + 1];
                    if (char.IsLowSurrogate (c2)) {
                        num2 = i + 1;
                        i = num2;
                        num = char.ConvertToUtf32 (c, c2);
                    }
                }
                yield return num;
                num2 = i + 1;
            }
        }
    }
}