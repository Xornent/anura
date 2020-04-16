using System;
using System.Globalization;
using System.IO;

namespace Anura.Typography.OpenFont {
    internal static class MacPostFormat1 {
        private static string[] s_stdMacGlyphNames;

        private const string orgGlyphNames = "\n0 \t.notdef\n1 \t.null\n2 \tnonmarkingreturn\n3 \tspace\n4 \texclam\n5 \tquotedbl\n6 \tnumbersign\n7 \tdollar\n8 \tpercent\n9 \tampersand\n10 \tquotesingle\n11 \tparenleft\n12 \tparenright\n13 \tasterisk\n14 \tplus\n15 \tcomma\n16 \thyphen\n17 \tperiod\n18 \tslash\n19 \tzero\n20 \tone\n21 \ttwo\n22 \tthree\n23 \tfour\n24 \tfive\n25 \tsix\n26 \tseven\n27 \teight\n28 \tnine\n29 \tcolon\n30 \tsemicolon\n31 \tless\n32 \tequal\n33 \tgreater\n34 \tquestion\n35 \tat\n36 \tA\n37 \tB\n38 \tC\n39 \tD\n40 \tE\n41 \tF\n42 \tG\n43 \tH\n44 \tI\n45 \tJ\n46 \tK\n47 \tL\n48 \tM\n49 \tN\n50 \tO\n51 \tP\n52 \tQ\n53 \tR\n54 \tS\n55 \tT\n56 \tU\n57 \tV\n58 \tW\n59 \tX\n60 \tY\n61 \tZ\n62 \tbracketleft\n63 \tbackslash\n64 \tbracketright\n65 \tasciicircum\n66 \tunderscore\n67 \tgrave\n68 \ta\n69 \tb\n70 \tc\n71 \td\n72 \te\n73 \tf\n74 \tg\n75 \th\n76 \ti\n77 \tj\n78 \tk\n79 \tl\n80 \tm\n81 \tn\n82 \to\n83 \tp\n84 \tq\n85 \tr\n86 \ts\n87 \tt\n88 \tu\n89 \tv\n90 \tw\n91 \tx\n92 \ty\n93 \tz\n94 \tbraceleft\n95 \tbar\n96 \tbraceright\n97 \tasciitilde\n98 \tAdieresis\n99 \tAring\n100 \tCcedilla\n101 \tEacute\n102 \tNtilde\n103 \tOdieresis\n104 \tUdieresis\n105 \taacute\n106 \tagrave\n107 \tacircumflex\n108 \tadieresis\n109 \tatilde\n110 \taring\n111 \tccedilla\n112 \teacute\n113 \tegrave\n114 \tecircumflex\n115 \tedieresis\n116 \tiacute\n117 \tigrave\n118 \ticircumflex\n119 \tidieresis\n120 \tntilde\n121 \toacute\n122 \tograve\n123 \tocircumflex\n124 \todieresis\n125 \totilde\n126 \tuacute\n127 \tugrave\n128 \tucircumflex\n129 \tudieresis\n130 \tdagger\n131 \tdegree\n132 \tcent\n133 \tsterling\n134 \tsection\n135 \tbullet\n136 \tparagraph\n137 \tgermandbls\n138 \tregistered\n139 \tcopyright\n140 \ttrademark\n141 \tacute\n142 \tdieresis\n143 \tnotequal\n144 \tAE\n145 \tOslash\n146 \tinfinity\n147 \tplusminus\n148 \tlessequal\n149 \tgreaterequal\n150 \tyen\n151 \tmu\n152 \tpartialdiff\n153 \tsummation\n154 \tproduct\n155 \tpi\n156 \tintegral\n157 \tordfeminine\n158 \tordmasculine\n159 \tOmega\n160 \tae\n161 \toslash\n162 \tquestiondown\n163 \texclamdown\n164 \tlogicalnot\n165 \tradical\n166 \tflorin\n167 \tapproxequal\n168 \tDelta\n169 \tguillemotleft\n170 \tguillemotright\n171 \tellipsis\n172 \tnonbreakingspace\n173 \tAgrave\n174 \tAtilde\n175 \tOtilde\n176 \tOE\n177 \toe\n178 \tendash\n179 \temdash\n180 \tquotedblleft\n181 \tquotedblright\n182 \tquoteleft\n183 \tquoteright\n184 \tdivide\n185 \tlozenge\n186 \tydieresis\n187 \tYdieresis\n188 \tfraction\n189 \tcurrency\n190 \tguilsinglleft\n191 \tguilsinglright\n192 \tfi\n193 \tfl\n194 \tdaggerdbl\n195 \tperiodcentered\n196 \tquotesinglbase\n197 \tquotedblbase\n198 \tperthousand\n199 \tAcircumflex\n200 \tEcircumflex\n201 \tAacute\n202 \tEdieresis\n203 \tEgrave\n204 \tIacute\n205 \tIcircumflex\n206 \tIdieresis\n207 \tIgrave\n208 \tOacute\n209 \tOcircumflex\n210 \tapple\n211 \tOgrave\n212 \tUacute\n213 \tUcircumflex\n214 \tUgrave\n215 \tdotlessi\n216 \tcircumflex\n217 \ttilde\n218 \tmacron\n219 \tbreve\n220 \tdotaccent\n221 \tring\n222 \tcedilla\n223 \thungarumlaut\n224 \togonek\n225 \tcaron\n226 \tLslash\n227 \tlslash\n228 \tScaron\n229 \tscaron\n230 \tZcaron\n231 \tzcaron\n232 \tbrokenbar\n233 \tEth\n234 \teth\n235 \tYacute\n236 \tyacute\n237 \tThorn\n238 \tthorn\n239 \tminus\n240 \tmultiply\n241 \tonesuperior\n242 \ttwosuperior\n243 \tthreesuperior\n244 \tonehalf\n245 \tonequarter\n246 \tthreequarters\n247 \tfranc\n248 \tGbreve\n249 \tgbreve\n250 \tIdotaccent\n251 \tScedilla\n252 \tscedilla\n253 \tCacute\n254 \tcacute\n255 \tCcaron\n256 \tccaron\n257 \tdcroat";

        public static string[] GetStdMacGlyphNames () {
            if (s_stdMacGlyphNames == null) {
                s_stdMacGlyphNames = new string[260];
                using (StringReader stringReader = new StringReader ("\n0 \t.notdef\n1 \t.null\n2 \tnonmarkingreturn\n3 \tspace\n4 \texclam\n5 \tquotedbl\n6 \tnumbersign\n7 \tdollar\n8 \tpercent\n9 \tampersand\n10 \tquotesingle\n11 \tparenleft\n12 \tparenright\n13 \tasterisk\n14 \tplus\n15 \tcomma\n16 \thyphen\n17 \tperiod\n18 \tslash\n19 \tzero\n20 \tone\n21 \ttwo\n22 \tthree\n23 \tfour\n24 \tfive\n25 \tsix\n26 \tseven\n27 \teight\n28 \tnine\n29 \tcolon\n30 \tsemicolon\n31 \tless\n32 \tequal\n33 \tgreater\n34 \tquestion\n35 \tat\n36 \tA\n37 \tB\n38 \tC\n39 \tD\n40 \tE\n41 \tF\n42 \tG\n43 \tH\n44 \tI\n45 \tJ\n46 \tK\n47 \tL\n48 \tM\n49 \tN\n50 \tO\n51 \tP\n52 \tQ\n53 \tR\n54 \tS\n55 \tT\n56 \tU\n57 \tV\n58 \tW\n59 \tX\n60 \tY\n61 \tZ\n62 \tbracketleft\n63 \tbackslash\n64 \tbracketright\n65 \tasciicircum\n66 \tunderscore\n67 \tgrave\n68 \ta\n69 \tb\n70 \tc\n71 \td\n72 \te\n73 \tf\n74 \tg\n75 \th\n76 \ti\n77 \tj\n78 \tk\n79 \tl\n80 \tm\n81 \tn\n82 \to\n83 \tp\n84 \tq\n85 \tr\n86 \ts\n87 \tt\n88 \tu\n89 \tv\n90 \tw\n91 \tx\n92 \ty\n93 \tz\n94 \tbraceleft\n95 \tbar\n96 \tbraceright\n97 \tasciitilde\n98 \tAdieresis\n99 \tAring\n100 \tCcedilla\n101 \tEacute\n102 \tNtilde\n103 \tOdieresis\n104 \tUdieresis\n105 \taacute\n106 \tagrave\n107 \tacircumflex\n108 \tadieresis\n109 \tatilde\n110 \taring\n111 \tccedilla\n112 \teacute\n113 \tegrave\n114 \tecircumflex\n115 \tedieresis\n116 \tiacute\n117 \tigrave\n118 \ticircumflex\n119 \tidieresis\n120 \tntilde\n121 \toacute\n122 \tograve\n123 \tocircumflex\n124 \todieresis\n125 \totilde\n126 \tuacute\n127 \tugrave\n128 \tucircumflex\n129 \tudieresis\n130 \tdagger\n131 \tdegree\n132 \tcent\n133 \tsterling\n134 \tsection\n135 \tbullet\n136 \tparagraph\n137 \tgermandbls\n138 \tregistered\n139 \tcopyright\n140 \ttrademark\n141 \tacute\n142 \tdieresis\n143 \tnotequal\n144 \tAE\n145 \tOslash\n146 \tinfinity\n147 \tplusminus\n148 \tlessequal\n149 \tgreaterequal\n150 \tyen\n151 \tmu\n152 \tpartialdiff\n153 \tsummation\n154 \tproduct\n155 \tpi\n156 \tintegral\n157 \tordfeminine\n158 \tordmasculine\n159 \tOmega\n160 \tae\n161 \toslash\n162 \tquestiondown\n163 \texclamdown\n164 \tlogicalnot\n165 \tradical\n166 \tflorin\n167 \tapproxequal\n168 \tDelta\n169 \tguillemotleft\n170 \tguillemotright\n171 \tellipsis\n172 \tnonbreakingspace\n173 \tAgrave\n174 \tAtilde\n175 \tOtilde\n176 \tOE\n177 \toe\n178 \tendash\n179 \temdash\n180 \tquotedblleft\n181 \tquotedblright\n182 \tquoteleft\n183 \tquoteright\n184 \tdivide\n185 \tlozenge\n186 \tydieresis\n187 \tYdieresis\n188 \tfraction\n189 \tcurrency\n190 \tguilsinglleft\n191 \tguilsinglright\n192 \tfi\n193 \tfl\n194 \tdaggerdbl\n195 \tperiodcentered\n196 \tquotesinglbase\n197 \tquotedblbase\n198 \tperthousand\n199 \tAcircumflex\n200 \tEcircumflex\n201 \tAacute\n202 \tEdieresis\n203 \tEgrave\n204 \tIacute\n205 \tIcircumflex\n206 \tIdieresis\n207 \tIgrave\n208 \tOacute\n209 \tOcircumflex\n210 \tapple\n211 \tOgrave\n212 \tUacute\n213 \tUcircumflex\n214 \tUgrave\n215 \tdotlessi\n216 \tcircumflex\n217 \ttilde\n218 \tmacron\n219 \tbreve\n220 \tdotaccent\n221 \tring\n222 \tcedilla\n223 \thungarumlaut\n224 \togonek\n225 \tcaron\n226 \tLslash\n227 \tlslash\n228 \tScaron\n229 \tscaron\n230 \tZcaron\n231 \tzcaron\n232 \tbrokenbar\n233 \tEth\n234 \teth\n235 \tYacute\n236 \tyacute\n237 \tThorn\n238 \tthorn\n239 \tminus\n240 \tmultiply\n241 \tonesuperior\n242 \ttwosuperior\n243 \tthreesuperior\n244 \tonehalf\n245 \tonequarter\n246 \tthreequarters\n247 \tfranc\n248 \tGbreve\n249 \tgbreve\n250 \tIdotaccent\n251 \tScedilla\n252 \tscedilla\n253 \tCacute\n254 \tcacute\n255 \tCcaron\n256 \tccaron\n257 \tdcroat")) {
                    string[] separator = new string[1] {
                    " "
                    };
                    for (string text = stringReader.ReadLine (); text != null; text = stringReader.ReadLine ()) {
                        text = text.Trim ();
                        if (text != "") {
                            string[] array = text.Split (separator, StringSplitOptions.RemoveEmptyEntries);
                            if (array.Length != 2) {
                                throw new NotSupportedException ();
                            }
                            if (!int.TryParse (array[0], NumberStyles.None, CultureInfo.InvariantCulture, out int result)) {
                                throw new NotSupportedException ();
                            }
                            s_stdMacGlyphNames[result] = array[1].Trim ();
                        }
                    }
                }
            }
            return s_stdMacGlyphNames;
        }
    }
}