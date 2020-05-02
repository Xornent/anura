using System;
using Anura.Typography.OpenFont.Tables;

namespace Anura.Typography.OpenFont.Extensions {
    public static class TypefaceExtensions {
        public static bool DoesSupportUnicode (this Typeface typeface, UnicodeLangBits unicodeLangBits) {
            if (typeface.OS2Table == null) {
                return false;
            }
            int num = (int) ((long) unicodeLangBits >> 32);
            if (num == 0) {
                return true;
            }
            if (num < 32) {
                return (typeface.OS2Table.ulUnicodeRange1 & (1 << num)) != 0;
            }
            if (num < 64) {
                return (typeface.OS2Table.ulUnicodeRange2 & (1 << num - 32)) != 0;
            }
            if (num < 96) {
                return (typeface.OS2Table.ulUnicodeRange3 & (1 << num - 64)) != 0;
            }
            if (num < 128) {
                return (typeface.OS2Table.ulUnicodeRange4 & (1 << num - 96)) != 0;
            }
            throw new NotSupportedException ();
        }

        public static bool RecommendToUseTypoMetricsForLineSpacing (this Typeface typeface) {
            return ((typeface.OS2Table.fsSelection >> 7) & 1) != 0;
        }

        public static TranslatedOS2FontStyle TranslatedOS2FontStyle (this Typeface typeface) {
            return TranslatedOS2FontStyle (typeface.OS2Table);
        }

        internal static TranslatedOS2FontStyle TranslatedOS2FontStyle (OS2Table os2Table) {
            ushort fsSelection = os2Table.fsSelection;
            TranslatedOS2FontStyle translatedOS2FontStyle = Anura.Typography.OpenFont.Extensions.TranslatedOS2FontStyle.UNSET;
            if ((fsSelection & 1) != 0) {
                translatedOS2FontStyle |= Anura.Typography.OpenFont.Extensions.TranslatedOS2FontStyle.ITALIC;
            }
            if (((fsSelection >> 5) & 1) != 0) {
                translatedOS2FontStyle |= Anura.Typography.OpenFont.Extensions.TranslatedOS2FontStyle.BOLD;
            }
            if (((fsSelection >> 6) & 1) != 0) {
                translatedOS2FontStyle |= Anura.Typography.OpenFont.Extensions.TranslatedOS2FontStyle.REGULAR;
            }
            if (((fsSelection >> 9) & 1) != 0) {
                translatedOS2FontStyle |= Anura.Typography.OpenFont.Extensions.TranslatedOS2FontStyle.OBLIQUE;
            }
            return translatedOS2FontStyle;
        }

        private static int Calculate_TypoMetricLineSpacing (Typeface typeface) {
            return typeface.Ascender - typeface.Descender + typeface.LineGap;
        }

        private static int Calculate_BTBD_Windows (Typeface typeface) {
            int usWinAscent = typeface.OS2Table.usWinAscent;
            int usWinDescent = typeface.OS2Table.usWinDescent;
            ushort unitsPerEm = typeface.UnitsPerEm;
            HorizontalHeader hheaTable = typeface.HheaTable;
            int num = Math.Max (0, hheaTable.LineGap - (usWinAscent + usWinDescent - (hheaTable.Ascent - hheaTable.Descent)));
            return usWinAscent + usWinDescent + num;
        }

        private static int CalculateBTBD_Mac (Typeface typeface) {
            HorizontalHeader hheaTable = typeface.HheaTable;
            return hheaTable.Ascent + hheaTable.Descent + hheaTable.LineGap;
        }

        public static int CalculateRecommendLineSpacing (this Typeface typeface, out LineSpacingChoice choice) {
            if (typeface.RecommendToUseTypoMetricsForLineSpacing ()) {
                choice = LineSpacingChoice.TypoMetric;
                return Calculate_TypoMetricLineSpacing (typeface);
            }
            if (CurrentEnv.CurrentOSName == CurrentOSName.Mac) {
                choice = LineSpacingChoice.Mac;
                return CalculateBTBD_Mac (typeface);
            }
            choice = LineSpacingChoice.Windows;
            return Calculate_BTBD_Windows (typeface);
        }

        public static int CalculateRecommendLineSpacing (this Typeface typeface) {
            LineSpacingChoice choice;
            return typeface.CalculateRecommendLineSpacing (out choice);
        }

        public static int CalculateLineSpacing (this Typeface typeface, LineSpacingChoice choice) {
            switch (choice) {
                default : return Calculate_BTBD_Windows (typeface);
                case LineSpacingChoice.Mac:
                        return CalculateBTBD_Mac (typeface);
                case LineSpacingChoice.TypoMetric:
                        return Calculate_TypoMetricLineSpacing (typeface);
            }
        }
    }
}