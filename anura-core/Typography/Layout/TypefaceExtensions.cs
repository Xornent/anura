using System;
using System.Collections.Generic;
using Anura.Typography.OpenFont;

namespace Anura.Typography.TextLayout {
    public static class TypefaceExtensions {
        private static UnicodeLangBits[] FilterOnlySelectedRange (UnicodeLangBits[] inputRanges, UnicodeLangBits[] userSpecificRanges) {
            List<UnicodeLangBits> list = new List<UnicodeLangBits> ();
            foreach (UnicodeLangBits unicodeLangBits in inputRanges) {
                if (Array.IndexOf (userSpecificRanges, unicodeLangBits) > 0) {
                    list.Add (unicodeLangBits);
                }
            }
            return list.ToArray ();
        }

        public static void CollectAllAssociateGlyphIndex (this Typeface typeface, List<ushort> outputGlyphIndexList, ScriptLang scLang, UnicodeLangBits[] selectedRangs = null) {
            if (ScriptLangs.TryGenUnicodeLangBitsArray (scLang.shortname, out UnicodeLangBits[] unicodeLangBits)) {
                if (selectedRangs != null) {
                    unicodeLangBits = FilterOnlySelectedRange (unicodeLangBits, selectedRangs);
                }
                UnicodeLangBits[] array = unicodeLangBits;
                for (int i = 0; i < array.Length; i++) {
                    UnicodeRangeInfo unicodeRangeInfo = array[i].ToUnicodeRangeInfo ();
                    int endAt = unicodeRangeInfo.EndAt;
                    for (int j = unicodeRangeInfo.StartAt; j <= endAt; j++) {
                        ushort num = typeface.LookupIndex (j);
                        if (num > 0) {
                            outputGlyphIndexList.Add (num);
                        }
                    }
                }
            }
            if (typeface.GSUBTable != null) {
                new GlyphSubstitution (typeface, scLang.shortname).CollectAdditionalSubstitutionGlyphIndices (outputGlyphIndexList);
            }
        }
    }
}