using System;
using System.Collections.Generic;

namespace Anura.Typography.OpenFont {
    public static class ScriptLangs {
        private struct UnicodeRangeMapWithScriptLang {
            public readonly ScriptLang scLang;

            public readonly UnicodeLangBits unicodeRangeBits;

            public UnicodeRangeMapWithScriptLang (UnicodeLangBits unicodeRangeBits, ScriptLang scLang) {
                this.scLang = scLang;
                this.unicodeRangeBits = unicodeRangeBits;
            }

            public bool IsInRange (char c) {
                return unicodeRangeBits.ToUnicodeRangeInfo ().IsInRange (c);
            }
        }

        private static Dictionary<string, int> s_registerNames = new Dictionary<string, int> ();

        private static Dictionary<string, ScriptLang> s_registeredScriptTags = new Dictionary<string, ScriptLang> ();

        private static Dictionary<string, ScriptLang> s_registerScriptFromFullNames = new Dictionary<string, ScriptLang> ();

        private static SortedList<int, UnicodeRangeMapWithScriptLang> s_unicodeLangToScriptLang = new SortedList<int, UnicodeRangeMapWithScriptLang> ();

        private static Dictionary<string, UnicodeLangBits[]> s_registeredScriptTagsToUnicodeLangBits = new Dictionary<string, UnicodeLangBits[]> ();

        public static readonly ScriptLang Adlam = _ ("Adlam", "adlm");

        public static readonly ScriptLang Anatolian_Hieroglyphs = _ ("Anatolian Hieroglyphs", "hluw");

        public static readonly ScriptLang Arabic = _ ("Arabic", "arab", UnicodeLangBits.Arabic, UnicodeLangBits.ArabicSupplement, UnicodeLangBits.Arabic_Presentation_Forms_A, UnicodeLangBits.Arabic_Presentation_Forms_B);

        public static readonly ScriptLang Armenian = _ ("Armenian", "armn", UnicodeLangBits.Armenian);

        public static readonly ScriptLang Avestan = _ ("Avestan", "avst");

        public static readonly ScriptLang Balinese = _ ("Balinese", "bali", UnicodeLangBits.Balinese);

        public static readonly ScriptLang Bamum = _ ("Bamum", "bamu");

        public static readonly ScriptLang Bassa_Vah = _ ("Bassa Vah ", "bass");

        public static readonly ScriptLang Batak = _ ("Batak", "batk");

        public static readonly ScriptLang Bengali = _ ("Bengali", "beng", UnicodeLangBits.Bengali);

        public static readonly ScriptLang Bengali_v_2 = _ ("Bengali v.2", "bng2", UnicodeLangBits.Bengali);

        public static readonly ScriptLang Bhaiksuki = _ ("Bhaiksuki", "bhks");

        public static readonly ScriptLang Brahmi = _ ("Brahmi", "brah");

        public static readonly ScriptLang Braille = _ ("Braille", "brai", UnicodeLangBits.Braille_Patterns);

        public static readonly ScriptLang Buginese = _ ("Buginese", "bugi", UnicodeLangBits.Buginese);

        public static readonly ScriptLang Buhid = _ ("Buhid", "buhd", UnicodeLangBits.Buhid);

        public static readonly ScriptLang Byzantine_Music = _ ("Byzantine Music", "byzm", UnicodeLangBits.Byzantine_Musical_Symbols);

        public static readonly ScriptLang Canadian_Syllabics = _ ("Canadian Syllabics", "cans", UnicodeLangBits.Unified_Canadian_Aboriginal_Syllabics);

        public static readonly ScriptLang Carian = _ ("Carian", "cari", UnicodeLangBits.Carian);

        public static readonly ScriptLang Caucasian_Albanian = _ ("Caucasian Albanian", "aghb");

        public static readonly ScriptLang Chakma = _ ("Chakma", "cakm");

        public static readonly ScriptLang Cham = _ ("Cham", "cham", UnicodeLangBits.Cham);

        public static readonly ScriptLang Cherokee = _ ("Cherokee", "cher", UnicodeLangBits.Cherokee);

        public static readonly ScriptLang CJK_Ideographic = _ ("CJK Ideographic", "hani", UnicodeLangBits.CJK_Compatibility, UnicodeLangBits.CJK_Compatibility_Forms, UnicodeLangBits.CJK_Compatibility_Ideographs, UnicodeLangBits.CJK_Compatibility_Ideographs_Supplement, UnicodeLangBits.CJK_Radicals_Supplement);

        public static readonly ScriptLang Coptic = _ ("Coptic", "copt", UnicodeLangBits.Coptic);

        public static readonly ScriptLang Cypriot_Syllabary = _ ("Cypriot Syllabary", "cprt", UnicodeLangBits.Cypriot_Syllabary);

        public static readonly ScriptLang Cyrillic = _ ("Cyrillic", "cyrl", UnicodeLangBits.Cyrillic, UnicodeLangBits.CyrillicExtendedA, UnicodeLangBits.CyrillicExtendedB);

        public static readonly ScriptLang Default = _ ("Default", "DFLT");

        public static readonly ScriptLang Deseret = _ ("Deseret", "dsrt", UnicodeLangBits.Deseret);

        public static readonly ScriptLang Devanagari = _ ("Devanagari", "deva", UnicodeLangBits.Devanagari);

        public static readonly ScriptLang Devanagari_v_2 = _ ("Devanagari v.2", "dev2", UnicodeLangBits.Devanagari);

        public static readonly ScriptLang Duployan = _ ("Duployan", "dupl");

        public static readonly ScriptLang Egyptian_Hieroglyphs = _ ("Egyptian Hieroglyphs", "egyp");

        public static readonly ScriptLang Elbasan = _ ("Elbasan", "elba");

        public static readonly ScriptLang Ethiopic = _ ("Ethiopic", "ethi", UnicodeLangBits.Ethiopic, UnicodeLangBits.Ethiopic_Extended, UnicodeLangBits.Ethiopic_Supplement);

        public static readonly ScriptLang Georgian = _ ("Georgian", "geor", UnicodeLangBits.Georgian, UnicodeLangBits.GeorgianSupplement);

        public static readonly ScriptLang Glagolitic = _ ("Glagolitic", "glag", UnicodeLangBits.Glagolitic);

        public static readonly ScriptLang Gothic = _ ("Gothic", "goth", UnicodeLangBits.Gothic);

        public static readonly ScriptLang Grantha = _ ("Grantha", "gran");

        public static readonly ScriptLang Greek = _ ("Greek", "grek", UnicodeLangBits.GreekAndCoptic, UnicodeLangBits.GreekExtended);

        public static readonly ScriptLang Gujarati = _ ("Gujarati", "gujr", UnicodeLangBits.Gujarati);

        public static readonly ScriptLang Gujarati_v_2 = _ ("Gujarati v.2", "gjr2", UnicodeLangBits.Gujarati);

        public static readonly ScriptLang Gurmukhi = _ ("Gurmukhi", "guru", UnicodeLangBits.Gurmukhi);

        public static readonly ScriptLang Gurmukhi_v_2 = _ ("Gurmukhi v.2", "gur2", UnicodeLangBits.Gurmukhi);

        public static readonly ScriptLang Hangul = _ ("Hangul", "hang", UnicodeLangBits.Hangul_Syllables);

        public static readonly ScriptLang Hangul_Jamo = _ ("Hangul Jamo", "jamo", UnicodeLangBits.HangulJamo);

        public static readonly ScriptLang Hanunoo = _ ("Hanunoo", "hano", UnicodeLangBits.Hanunoo);

        public static readonly ScriptLang Hatran = _ ("Hatran", "hatr");

        public static readonly ScriptLang Hebrew = _ ("Hebrew", "hebr", UnicodeLangBits.Hebrew);

        public static readonly ScriptLang Hiragana = _ ("Hiragana", "kana", UnicodeLangBits.Hiragana);

        public static readonly ScriptLang Imperial_Aramaic = _ ("Imperial Aramaic", "armi");

        public static readonly ScriptLang Inscriptional_Pahlavi = _ ("Inscriptional Pahlavi", "phli");

        public static readonly ScriptLang Inscriptional_Parthian = _ ("Inscriptional Parthian", "prti");

        public static readonly ScriptLang Javanese = _ ("Javanese", "java");

        public static readonly ScriptLang Kaithi = _ ("Kaithi", "kthi");

        public static readonly ScriptLang Kannada = _ ("Kannada", "knda", UnicodeLangBits.Kannada);

        public static readonly ScriptLang Kannada_v_2 = _ ("Kannada v.2", "knd2", UnicodeLangBits.Kannada);

        public static readonly ScriptLang Katakana = _ ("Katakana", "kana", UnicodeLangBits.Katakana, UnicodeLangBits.Katakana_Phonetic_Extensions);

        public static readonly ScriptLang Kayah_Li = _ ("Kayah Li", "kali");

        public static readonly ScriptLang Kharosthi = _ ("Kharosthi", "khar", UnicodeLangBits.Kharoshthi);

        public static readonly ScriptLang Khmer = _ ("Khmer", "khmr", UnicodeLangBits.Khmer, UnicodeLangBits.Khmer_Symbols);

        public static readonly ScriptLang Khojki = _ ("Khojki", "khoj");

        public static readonly ScriptLang Khudawadi = _ ("Khudawadi", "sind");

        public static readonly ScriptLang Lao = _ ("Lao", "lao", UnicodeLangBits.Lao);

        public static readonly ScriptLang Latin = _ ("Latin", "latn", UnicodeLangBits.BasicLatin, UnicodeLangBits.Latin1Supplement, UnicodeLangBits.LatinExtendedA, UnicodeLangBits.LatinExtendedAdditional, UnicodeLangBits.LatinExtendedAdditionalC, UnicodeLangBits.LatinExtendedAdditionalD, UnicodeLangBits.LatinExtendedB);

        public static readonly ScriptLang Lepcha = _ ("Lepcha", "lepc", UnicodeLangBits.Lepcha);

        public static readonly ScriptLang Limbu = _ ("Limbu", "limb", UnicodeLangBits.Limbu);

        public static readonly ScriptLang Linear_A = _ ("Linear A", "lina");

        public static readonly ScriptLang Linear_B = _ ("Linear B", "linb", UnicodeLangBits.Linear_B_Ideograms, UnicodeLangBits.Linear_B_Syllabary);

        public static readonly ScriptLang Lisu = _ ("Lisu (Fraser)", "lisu");

        public static readonly ScriptLang Lycian = _ ("Lycian", "lyci", UnicodeLangBits.Lycian);

        public static readonly ScriptLang Lydian = _ ("Lydian", "lydi", UnicodeLangBits.Lydian);

        public static readonly ScriptLang Mahajani = _ ("Mahajani", "mahj");

        public static readonly ScriptLang Malayalam = _ ("Malayalam", "mlym", UnicodeLangBits.Malayalam);

        public static readonly ScriptLang Malayalam_v_2 = _ ("Malayalam v.2", "mlm2", UnicodeLangBits.Malayalam);

        public static readonly ScriptLang Mandaic = _ ("Mandaic, Mandaean", "mand");

        public static readonly ScriptLang Manichaean = _ ("Manichaean", "mani");

        public static readonly ScriptLang Marchen = _ ("Marchen", "marc");

        public static readonly ScriptLang Math = _ ("Mathematical Alphanumeric Symbols", "math", UnicodeLangBits.Mathematical_Alphanumeric_Symbols);

        public static readonly ScriptLang Meitei_Mayek = _ ("Meitei Mayek (Meithei, Meetei)", "mtei");

        public static readonly ScriptLang Mende_Kikakui = _ ("Mende Kikakui", "mend");

        public static readonly ScriptLang Meroitic_Cursive = _ ("Meroitic Cursive", "merc");

        public static readonly ScriptLang Meroitic_Hieroglyphs = _ ("Meroitic Hieroglyphs", "mero");

        public static readonly ScriptLang Miao = _ ("Miao", "plrd");

        public static readonly ScriptLang Modi = _ ("Modi", "modi");

        public static readonly ScriptLang Mongolian = _ ("Mongolian", "mong", UnicodeLangBits.Mongolian);

        public static readonly ScriptLang Mro = _ ("Mro", "mroo");

        public static readonly ScriptLang Multani = _ ("Multani", "mult");

        public static readonly ScriptLang Musical_Symbols = _ ("Musical Symbols", "musc", UnicodeLangBits.Musical_Symbols);

        public static readonly ScriptLang Myanmar = _ ("Myanmar", "mymr", UnicodeLangBits.Myanmar);

        public static readonly ScriptLang Myanmar_v_2 = _ ("Myanmar v.2", "mym2", UnicodeLangBits.Myanmar);

        public static readonly ScriptLang Nabataean = _ ("Nabataean", "nbat");

        public static readonly ScriptLang Newa = _ ("Newa", "newa");

        public static readonly ScriptLang New_Tai_Lue = _ ("New Tai Lue", "talu", UnicodeLangBits.New_Tai_Lue);

        public static readonly ScriptLang N_Ko = _ ("N'Ko", "nko", UnicodeLangBits.NKo);

        public static readonly ScriptLang Odia = _ ("Odia (formerly Oriya)", "orya");

        public static readonly ScriptLang Odia_V_2 = _ ("Odia v.2 (formerly Oriya v.2)", "ory2");

        public static readonly ScriptLang Ogham = _ ("Ogham", "ogam", UnicodeLangBits.Ogham);

        public static readonly ScriptLang Ol_Chiki = _ ("Ol Chiki", "olck", UnicodeLangBits.Ol_Chiki);

        public static readonly ScriptLang Old_Italic = _ ("Old Italic", "ital");

        public static readonly ScriptLang Old_Hungarian = _ ("Old Hungarian", "hung");

        public static readonly ScriptLang Old_North_Arabian = _ ("Old North Arabian", "narb");

        public static readonly ScriptLang Old_Permic = _ ("Old Permic", "perm");

        public static readonly ScriptLang Old_Persian_Cuneiform = _ ("Old Persian Cuneiform ", "xpeo");

        public static readonly ScriptLang Old_South_Arabian = _ ("Old South Arabian", "sarb");

        public static readonly ScriptLang Old_Turkic = _ ("Old Turkic, Orkhon Runic", "orkh");

        public static readonly ScriptLang Osage = _ ("Osage", "osge");

        public static readonly ScriptLang Osmanya = _ ("Osmanya", "osma", UnicodeLangBits.Osmanya);

        public static readonly ScriptLang Pahawh_Hmong = _ ("Pahawh Hmong", "hmng");

        public static readonly ScriptLang Palmyrene = _ ("Palmyrene", "palm");

        public static readonly ScriptLang Pau_Cin_Hau = _ ("Pau Cin Hau", "pauc");

        public static readonly ScriptLang Phags_pa = _ ("Phags-pa", "phag", UnicodeLangBits.Phags_pa);

        public static readonly ScriptLang Phoenician = _ ("Phoenician ", "phnx");

        public static readonly ScriptLang Psalter_Pahlavi = _ ("Psalter Pahlavi", "phlp");

        public static readonly ScriptLang Rejang = _ ("Rejang", "rjng", UnicodeLangBits.Rejang);

        public static readonly ScriptLang Runic = _ ("Runic", "runr", UnicodeLangBits.Runic);

        public static readonly ScriptLang Samaritan = _ ("Samaritan", "samr");

        public static readonly ScriptLang Saurashtra = _ ("Saurashtra", "saur", UnicodeLangBits.Saurashtra);

        public static readonly ScriptLang Sharada = _ ("Sharada", "shrd");

        public static readonly ScriptLang Shavian = _ ("Shavian", "shaw", UnicodeLangBits.Shavian);

        public static readonly ScriptLang Siddham = _ ("Siddham", "sidd");

        public static readonly ScriptLang Sign_Writing = _ ("Sign Writing", "sgnw");

        public static readonly ScriptLang Sinhala = _ ("Sinhala", "sinh", UnicodeLangBits.Sinhala);

        public static readonly ScriptLang Sora_Sompeng = _ ("Sora Sompeng", "sora");

        public static readonly ScriptLang Sumero_Akkadian_Cuneiform = _ ("Sumero-Akkadian Cuneiform", "xsux");

        public static readonly ScriptLang Sundanese = _ ("Sundanese", "sund", UnicodeLangBits.Sundanese);

        public static readonly ScriptLang Syloti_Nagri = _ ("Syloti Nagri", "sylo", UnicodeLangBits.Syloti_Nagri);

        public static readonly ScriptLang Syriac = _ ("Syriac", "syrc", UnicodeLangBits.Syriac);

        public static readonly ScriptLang Tagalog = _ ("Tagalog", "tglg");

        public static readonly ScriptLang Tagbanwa = _ ("Tagbanwa", "tagb", UnicodeLangBits.Tagbanwa);

        public static readonly ScriptLang Tai_Le = _ ("Tai Le", "tale", UnicodeLangBits.Tai_Le);

        public static readonly ScriptLang Tai_Tham = _ ("Tai Tham (Lanna)", "lana");

        public static readonly ScriptLang Tai_Viet = _ ("Tai Viet", "tavt");

        public static readonly ScriptLang Takri = _ ("Takri", "takr");

        public static readonly ScriptLang Tamil = _ ("Tamil", "taml", UnicodeLangBits.Tamil);

        public static readonly ScriptLang Tamil_v_2 = _ ("Tamil v.2", "tml2", UnicodeLangBits.Tamil);

        public static readonly ScriptLang Tangut = _ ("Tangut", "tang");

        public static readonly ScriptLang Telugu = _ ("Telugu", "telu", UnicodeLangBits.Telugu);

        public static readonly ScriptLang Telugu_v_2 = _ ("Telugu v.2", "tel2", UnicodeLangBits.Telugu);

        public static readonly ScriptLang Thaana = _ ("Thaana", "thaa", UnicodeLangBits.Thaana);

        public static readonly ScriptLang Thai = _ ("Thai", "thai", UnicodeLangBits.Thai);

        public static readonly ScriptLang Tibetan = _ ("Tibetan", "tibt", UnicodeLangBits.Tibetan);

        public static readonly ScriptLang Tifinagh = _ ("Tifinagh", "tfng", UnicodeLangBits.Tifinagh);

        public static readonly ScriptLang Tirhuta = _ ("Tirhuta", "tirh");

        public static readonly ScriptLang Ugaritic_Cuneiform = _ ("Ugaritic Cuneiform", "ugar");

        public static readonly ScriptLang Vai = _ ("Vai", "vai");

        public static readonly ScriptLang Warang_Citi = _ ("Warang Citi", "wara");

        public static readonly ScriptLang Yi = _ ("Yi", "yi", UnicodeLangBits.Yi_Syllables);

        private static ScriptLang _ (string fullname, string shortname, params UnicodeLangBits[] langBits) {
            if (s_registeredScriptTags.ContainsKey (shortname)) {
                if (shortname == "kana") {
                    return new ScriptLang (fullname, shortname, s_registerNames[shortname]);
                }
                throw new NotSupportedException ();
            }
            int count = s_registerNames.Count;
            s_registerNames[shortname] = count;
            ScriptLang scriptLang = new ScriptLang (fullname, shortname, count);
            s_registeredScriptTags.Add (shortname, scriptLang);
            s_registerScriptFromFullNames[fullname] = scriptLang;
            for (int num = langBits.Length - 1; num >= 0; num--) {
                UnicodeRangeInfo unicodeRangeInfo = langBits[num].ToUnicodeRangeInfo ();
                if (!s_unicodeLangToScriptLang.ContainsKey (unicodeRangeInfo.StartAt)) {
                    s_unicodeLangToScriptLang.Add (unicodeRangeInfo.StartAt, new UnicodeRangeMapWithScriptLang (langBits[num], scriptLang));
                }
            }
            if (langBits.Length != 0) {
                s_registeredScriptTagsToUnicodeLangBits.Add (shortname, langBits);
            }
            return scriptLang;
        }

        public static bool TryGenUnicodeLangBitsArray (string langShortName, out UnicodeLangBits[] unicodeLangBits) {
            return s_registeredScriptTagsToUnicodeLangBits.TryGetValue (langShortName, out unicodeLangBits);
        }

        public static bool TryGetScriptLang (char c, out ScriptLang scLang) {
            foreach (KeyValuePair<int, UnicodeRangeMapWithScriptLang> item in s_unicodeLangToScriptLang) {
                if (item.Key > c) {
                    scLang = null;
                    return false;
                }
                if (item.Value.IsInRange (c)) {
                    scLang = item.Value.scLang;
                    return true;
                }
            }
            scLang = null;
            return false;
        }

        public static ScriptLang GetRegisteredScriptLang (string shortname) {
            s_registeredScriptTags.TryGetValue (shortname, out ScriptLang value);
            return value;
        }

        public static ScriptLang GetRegisteredScriptLangFromLanguageName (string languageName) {
            s_registerScriptFromFullNames.TryGetValue (languageName, out ScriptLang value);
            return value;
        }

        public static IEnumerable<ScriptLang> GetRegiteredScriptLangIter () {
            foreach (ScriptLang value in s_registeredScriptTags.Values) {
                yield return value;
            }
        }
    }
}