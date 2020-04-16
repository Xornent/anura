using System.Collections.Generic;

namespace Anura.Typography.OpenFont {
    public static class Features {
        private static Dictionary<string, FeatureInfo> s_features;

        public static readonly FeatureInfo aalt;

        public static readonly FeatureInfo abvf;

        public static readonly FeatureInfo abvm;

        public static readonly FeatureInfo abvs;

        public static readonly FeatureInfo afrc;

        public static readonly FeatureInfo akhn;

        public static readonly FeatureInfo blwf;

        public static readonly FeatureInfo blwm;

        public static readonly FeatureInfo blws;

        public static readonly FeatureInfo calt;

        public static readonly FeatureInfo case_;

        public static readonly FeatureInfo ccmp;

        public static readonly FeatureInfo cfar;

        public static readonly FeatureInfo cjct;

        public static readonly FeatureInfo clig;

        public static readonly FeatureInfo cpct;

        public static readonly FeatureInfo cpsp;

        public static readonly FeatureInfo cswh;

        public static readonly FeatureInfo curs;

        public static readonly FeatureInfo c2pc;

        public static readonly FeatureInfo c2sc;

        public static readonly FeatureInfo dist;

        public static readonly FeatureInfo dlig;

        public static readonly FeatureInfo dnom;

        public static readonly FeatureInfo dtls;

        public static readonly FeatureInfo expt;

        public static readonly FeatureInfo falt;

        public static readonly FeatureInfo fin2;

        public static readonly FeatureInfo fin3;

        public static readonly FeatureInfo fina;

        public static readonly FeatureInfo flac;

        public static readonly FeatureInfo frac;

        public static readonly FeatureInfo fwid;

        public static readonly FeatureInfo half;

        public static readonly FeatureInfo haln;

        public static readonly FeatureInfo halt;

        public static readonly FeatureInfo hist;

        public static readonly FeatureInfo hkna;

        public static readonly FeatureInfo hlig;

        public static readonly FeatureInfo hngl;

        public static readonly FeatureInfo hojo;

        public static readonly FeatureInfo hwid;

        public static readonly FeatureInfo init;

        public static readonly FeatureInfo isol;

        public static readonly FeatureInfo ital;

        public static readonly FeatureInfo jalt;

        public static readonly FeatureInfo jp78;

        public static readonly FeatureInfo jp83;

        public static readonly FeatureInfo jp90;

        public static readonly FeatureInfo jp04;

        public static readonly FeatureInfo kern;

        public static readonly FeatureInfo lfbd;

        public static readonly FeatureInfo liga;

        public static readonly FeatureInfo ljmo;

        public static readonly FeatureInfo lnum;

        public static readonly FeatureInfo locl;

        public static readonly FeatureInfo ltra;

        public static readonly FeatureInfo ltrm;

        public static readonly FeatureInfo mark;

        public static readonly FeatureInfo med2;

        public static readonly FeatureInfo medi;

        public static readonly FeatureInfo mgrk;

        public static readonly FeatureInfo mkmk;

        public static readonly FeatureInfo mset;

        public static readonly FeatureInfo nalt;

        public static readonly FeatureInfo nlck;

        public static readonly FeatureInfo nukt;

        public static readonly FeatureInfo numr;

        public static readonly FeatureInfo onum;

        public static readonly FeatureInfo opbd;

        public static readonly FeatureInfo ordn;

        public static readonly FeatureInfo ornm;

        public static readonly FeatureInfo palt;

        public static readonly FeatureInfo pcap;

        public static readonly FeatureInfo pkna;

        public static readonly FeatureInfo pnum;

        public static readonly FeatureInfo pref;

        public static readonly FeatureInfo pres;

        public static readonly FeatureInfo pstf;

        public static readonly FeatureInfo psts;

        public static readonly FeatureInfo pwid;

        public static readonly FeatureInfo qwid;

        public static readonly FeatureInfo rand;

        public static readonly FeatureInfo rclt;

        public static readonly FeatureInfo rkrf;

        public static readonly FeatureInfo rlig;

        public static readonly FeatureInfo rphf;

        public static readonly FeatureInfo rtbd;

        public static readonly FeatureInfo rtla;

        public static readonly FeatureInfo rtlm;

        public static readonly FeatureInfo ruby;

        public static readonly FeatureInfo rvrn;

        public static readonly FeatureInfo salt;

        public static readonly FeatureInfo sinf;

        public static readonly FeatureInfo size;

        public static readonly FeatureInfo smcp;

        public static readonly FeatureInfo smpl;

        public static readonly FeatureInfo ssty;

        public static readonly FeatureInfo stch;

        public static readonly FeatureInfo subs;

        public static readonly FeatureInfo sups;

        public static readonly FeatureInfo swsh;

        public static readonly FeatureInfo titl;

        public static readonly FeatureInfo tjmo;

        public static readonly FeatureInfo tnam;

        public static readonly FeatureInfo tnum;

        public static readonly FeatureInfo trad;

        public static readonly FeatureInfo twid;

        public static readonly FeatureInfo unic;

        public static readonly FeatureInfo valt;

        public static readonly FeatureInfo vatu;

        public static readonly FeatureInfo vert;

        public static readonly FeatureInfo vhal;

        public static readonly FeatureInfo vjmo;

        public static readonly FeatureInfo vkna;

        public static readonly FeatureInfo vkrn;

        public static readonly FeatureInfo vpal;

        public static readonly FeatureInfo vrt2;

        public static readonly FeatureInfo vrtr;

        static Features () {
            s_features = new Dictionary<string, FeatureInfo> ();
            aalt = _ ("aalt", "Access All Alternates");
            abvf = _ ("abvf", "Above-base Forms");
            abvm = _ ("abvm", "Above-base Mark Positioning");
            abvs = _ ("abvs", "Above-base Substitutions");
            afrc = _ ("afrc", "Alternative Fractions");
            akhn = _ ("akhn", "Akhands");
            blwf = _ ("blwf", "Below-base Forms");
            blwm = _ ("blwm", "Below-base Mark Positioning");
            blws = _ ("blws", "Below-base Substitutions");
            calt = _ ("calt", "Access All Alternates");
            case_ = _ ("case", "Above-base Forms");
            ccmp = _ ("ccmp", "Glyph Composition / Decomposition");
            cfar = _ ("cfar", "Conjunct Form After Ro");
            cjct = _ ("cjct", "Conjunct Forms");
            clig = _ ("clig", "Contextual Ligatures");
            cpct = _ ("cpct", "Centered CJK Punctuation");
            cpsp = _ ("cpsp", "Capital Spacing");
            cswh = _ ("cswh", "Contextual Swash");
            curs = _ ("curs", "Cursive Positioning");
            c2pc = _ ("c2pc", "Petite Capitals From Capitals");
            c2sc = _ ("c2sc", "Small Capitals From Capitals");
            dist = _ ("dist", "Distances");
            dlig = _ ("dlig", "Discretionary Ligatures");
            dnom = _ ("dnom", "Denominators");
            dtls = _ ("dtls", "Dotless Forms");
            expt = _ ("expt", "Expert Forms");
            falt = _ ("falt", "Final Glyph on Line Alternates");
            fin2 = _ ("fin2", "Terminal Forms #2");
            fin3 = _ ("fin3", "Terminal Forms #3");
            fina = _ ("fina", "Terminal Forms");
            flac = _ ("flac", "Flattened accent forms");
            frac = _ ("frac", "Fractions");
            fwid = _ ("fwid", "Full Widths");
            half = _ ("half", "Half Forms");
            haln = _ ("haln", "Halant Forms");
            halt = _ ("halt", "Alternate Half Widths");
            hist = _ ("hist", "Historical Forms");
            hkna = _ ("hkna", "Horizontal Kana Alternates");
            hlig = _ ("hlig", "Historical Ligatures");
            hngl = _ ("hngl", "Hangul");
            hojo = _ ("hojo", "Hojo Kanji Forms (JIS X 0212-1990 Kanji Forms)");
            hwid = _ ("hwid", "Half Widths");
            init = _ ("init", "Initial Forms");
            isol = _ ("isol", "Isolated Forms");
            ital = _ ("ital", "Italics");
            jalt = _ ("jalt", "Justification Alternates");
            jp78 = _ ("jp78", "JIS78 Forms");
            jp83 = _ ("jp83", "JIS83 Forms");
            jp90 = _ ("jp90", "JIS90 Forms");
            jp04 = _ ("jp04", "JIS2004 Forms");
            kern = _ ("kern", "Kerning");
            lfbd = _ ("lfbd", "Left Bounds");
            liga = _ ("liga", "Standard Ligatures");
            ljmo = _ ("ljmo", "Leading Jamo Forms");
            lnum = _ ("lnum", "Lining Figures");
            locl = _ ("locl", "Localized Forms");
            ltra = _ ("ltra", "Left-to-right alternates");
            ltrm = _ ("ltrm", "Left-to-right mirrored forms");
            mark = _ ("mark", "Mark Positioning");
            med2 = _ ("med2", "Medial Forms #2");
            medi = _ ("medi", "Medial Forms");
            mgrk = _ ("mgrk", "Mathematical Greek");
            mkmk = _ ("mkmk", "Mark to Mark Positioning");
            mset = _ ("mset", "Mark Positioning via Substitution");
            nalt = _ ("nalt", "Alternate Annotation Forms");
            nlck = _ ("nlck", "NLC Kanji Forms");
            nukt = _ ("nukt", "Nukta Forms");
            numr = _ ("numr", "Numerators");
            onum = _ ("onum", "Oldstyle Figures");
            opbd = _ ("opbd", "Optical Bounds");
            ordn = _ ("ordn", "Ordinals");
            ornm = _ ("ornm", "Ornaments");
            palt = _ ("palt", "Proportional Alternate Widths");
            pcap = _ ("pcap", "Petite Capitals");
            pkna = _ ("pkna", "Proportional Kana");
            pnum = _ ("pnum", "Proportional Figures");
            pref = _ ("pref", "Pre-Base Forms");
            pres = _ ("pres", "Pre-base Substitutions");
            pstf = _ ("pstf", "Post-base Forms");
            psts = _ ("psts", "Post-base Substitutions");
            pwid = _ ("pwid", "Proportional Widths");
            qwid = _ ("qwid", "Quarter Widths");
            rand = _ ("rand", "Randomize");
            rclt = _ ("rclt", "Required Contextual Alternates");
            rkrf = _ ("rkrf", "Rakar Forms");
            rlig = _ ("rlig", "Required Ligatures");
            rphf = _ ("rphf", "Reph Forms");
            rtbd = _ ("rtbd", "Right Bounds");
            rtla = _ ("rtla", "Right-to-left alternates");
            rtlm = _ ("rtlm", "Right-to-left mirrored forms");
            ruby = _ ("ruby", "Ruby Notation Forms");
            rvrn = _ ("rvrn", "Required Variation Alternates");
            salt = _ ("salt", "Stylistic Alternates");
            sinf = _ ("sinf", "Scientific Inferiors");
            size = _ ("size", "Optical size");
            smcp = _ ("smcp", "Small Capitals");
            smpl = _ ("smpl", "Simplified Forms");
            ssty = _ ("ssty", "Math script style alternates");
            stch = _ ("stch", "Stretching Glyph Decomposition");
            subs = _ ("subs", "Subscript");
            sups = _ ("sups", "Superscript");
            swsh = _ ("swsh", "Swash");
            titl = _ ("titl", "Titling");
            tjmo = _ ("tjmo", "Trailing Jamo Forms");
            tnam = _ ("tnam", "Traditional Name Forms");
            tnum = _ ("tnum", "Tabular Figures");
            trad = _ ("trad", "Traditional Forms");
            twid = _ ("twid", "Third Widths");
            unic = _ ("unic", "Unicase");
            valt = _ ("valt", "Alternate Vertical Metrics");
            vatu = _ ("vatu", "Vattu Variants");
            vert = _ ("vert", "Vertical Writing");
            vhal = _ ("vhal", "Alternate Vertical Half Metrics");
            vjmo = _ ("vjmo", "Vowel Jamo Forms");
            vkna = _ ("vkna", "Vertical Kana Alternates");
            vkrn = _ ("vkrn", "Vertical Kerning");
            vpal = _ ("vpal", "Proportional Alternate Vertical Metrics");
            vrt2 = _ ("vrt2", "Vertical Alternates and Rotation");
            vrtr = _ ("vrtr", "Vertical Alternates for Rotation");
            for (int i = 1; i < 9; i++) {
                _ ("cv0" + i, "Character Variants" + i);
            }
            for (int j = 10; j < 100; j++) {
                _ ("cv" + j, "Character Variants" + j);
            }
            for (int k = 1; k < 9; k++) {
                _ ("ss0" + k, "Stylistic Set " + k);
            }
            for (int l = 10; l < 21; l++) {
                _ ("ss" + l, "Stylistic Set " + l);
            }
        }

        private static FeatureInfo _ (string shortname, string fullname) {
            FeatureInfo featureInfo = new FeatureInfo (fullname, shortname);
            s_features.Add (shortname, featureInfo);
            return featureInfo;
        }
    }
}