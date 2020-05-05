<!DOCTYPE html>
<html lang=en>
 <head>
  <meta content="text/html;charset=utf-8" http-equiv=Content-Type>
  <title>CSS Fonts Module Level 3</title>

  <link href="https://www.w3.org/TR/2018/REC-css-fonts-3-20180920/" rel=canonical>
   <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

  <link href="default.css" rel=stylesheet type="text/css">

  <style type="text/css">

  body, th, td, h1, h2, h3, h4, h5, h6 {
    font-family: "myriad-pro", sans-serif !important;
  }

  p + p, p.mtb {
    margin-top: 0.8em;
    text-indent: 0px;
  }

  #bolderlighter {
    width: 40%;
  }

  #bolderlighter th {
    text-align: center;
  }

  #fontformats td, #eventhandlers td, #fontformats th, #eventhandlers th {
    padding-right: 2em;
    text-align: left;
  }

  dd {
    margin-bottom: 1em;
  }

  #fontstylematchingalg {
    list-style-type: lower-alpha;
  }

  #fontmatchingalg ul, #fontmatchingalg ol {
    margin-top: 0.8em;
  }

  #fontmatchingalg li + li {
    margin-top: 0.8em;
  }

  div.example {
    padding: 1em;
    margin-top: 1em;
  }

  div.example + div.example {
    margin-top: 2em;
  }

  div.figure {
    page-break-inside: avoid;
  }

  pre.prod { white-space: pre-wrap; margin: 1em 0 1em 2em }

  div.featex {
    width: 700px;
  }

  div.featex img {
    margin: auto;
    display: block;
  }

  span.tag {
    font-family: monospace;
    font-size: 120%;
  }

  ol ol {
    list-style-type: lower-alpha;
  }

  .idl-code {
    font-weight: bold;
    color: #c50;
  }

  #fonts ul.indexlist ul, #fonts ul.indexlist dl { font-size: inherit; }

  </style>

  <link rel="stylesheet" type="text/css" href="https://www.w3.org/StyleSheets/TR/2016/W3C-REC" />

  <script defer=defer
   src="https://test.csswg.org/harness/annotate.js#CSS3-FONTS_DEV"
   type="text/javascript"></script>


  <div class=head> <!--begin-logo-->
   <p><a href="https://www.w3.org/"><img alt=W3C height=48
    src="https://www.w3.org/StyleSheets/TR/2016/logos/W3C" width=72></a>
    <!--end-logo-->

   <h1>CSS Fonts Module Level 3</h1>

   <h2 class="no-num no-toc">W3C Recommendation 20 September 2018</h2>

   <dl id=authors>
    <dt>This version:

    <!-- <dd><a
     href="https://drafts.csswg.org/css-fonts/">https://drafts.csswg.org/css-fonts/</a> -->
     <dd><a href="https://www.w3.org/TR/2018/REC-css-fonts-3-20180920/">https://www.w3.org/TR/2018/REC-css-fonts-3-20180920/</a>

    <dt>Latest version:

    <dd><a
     href="https://www.w3.org/TR/css-fonts-3/">https://www.w3.org/TR/css-fonts-3/</a>

    <dt>Latest editor's draft:

    <dd><a
     href="https://drafts.csswg.org/css-fonts/">https://drafts.csswg.org/css-fonts/</a>

    <dt>Previous versions:

      <dd><a href="https://www.w3.org/TR/2018/PR-css-fonts-3-20180814/">https://www.w3.org/TR/2018/PR-css-fonts-3-20180814/</a>

      <dd><a href="https://www.w3.org/TR/2018/CR-css-fonts-3-20180626/">
        https://www.w3.org/TR/2018/CR-css-fonts-3-20180626/</a></dd>
    <dd><a
     href="https://www.w3.org/TR/2018/CR-css-fonts-3-20180315/">https://www.w3.org/TR/2018/CR-css-fonts-3-20180315/</a>

    <dd><a
     href="https://www.w3.org/TR/2013/CR-css-fonts-3-20131003/">https://www.w3.org/TR/2013/CR-css-fonts-3-20131003/</a>

    <dt>Issues List:

    <dd><a
     href="https://github.com/w3c/csswg-drafts/labels/css-fonts-3">css-fonts-3
     issues on GitHub</a>

    <dt>Discussion:

    <dd> <a href="https://github.com/w3c/csswg-drafts/labels/css-fonts-3">on
     GitHub</a> (preferred), or <a
     href="mailto:www-style@w3.org?subject=%5Bcss-fonts%5D%20feedback">www-style@w3.org</a>
     with subject line “<kbd>[css-fonts] <var>… message topic
     …</var></kbd>” (<a
     href="https://lists.w3.org/Archives/Public/www-style/"
     rel=discussion>archives</a>)

    <dt>Test Suite:

    <dd><a
     href="https://test.csswg.org/harness/results/css-fonts-3_dev/grouped/">https://test.csswg.org/harness/results/css-fonts-3_dev/grouped/</a>

    <dt>Editors:

    <dd><a href="https://twitter.com/nattokirai">John Daggett (Invited
     Expert)</a>

    <dd><a href="mailto:mmaxfield@apple.com">Myles C. Maxfield (Apple
     Inc.)</a>

    <dd><a href="http://svgees.us/">Chris Lilley (W3C)</a>
   </dl>

   <p>Please check the <a href="https://www.w3.org/Style/2018/REC-css-fonts-3-20180920-errata.html"><strong>errata</strong></a> for any errors or issues reported since publication.</p>

   <!--begin-copyright-->
   <p class=copyright><a
    href="http://www.w3.org/Consortium/Legal/ipr-notice#Copyright"
    rel=license>Copyright</a> © 2018 <a href="http://www.w3.org/"><abbr
    title="World Wide Web Consortium">W3C</abbr></a><sup>®</sup> (<a
    href="http://www.csail.mit.edu/"><abbr
    title="Massachusetts Institute of Technology">MIT</abbr></a>, <a
    href="http://www.ercim.eu/"><abbr
    title="European Research Consortium for Informatics and Mathematics">ERCIM</abbr></a>,
    <a href="http://www.keio.ac.jp/">Keio</a>, <a
    href="http://ev.buaa.edu.cn/">Beihang</a>). W3C <a
    href="http://www.w3.org/Consortium/Legal/ipr-notice#Legal_Disclaimer">liability</a>,
    <a
    href="http://www.w3.org/Consortium/Legal/ipr-notice#W3C_Trademarks">trademark</a>
    and <a
    href="http://www.w3.org/Consortium/Legal/copyright-documents">document
    use</a> rules apply.</p>
   <!--end-copyright-->
   <hr title="Separator for header">
  </div>

  <h2 class="no-num no-toc" id=abstract>Abstract</h2>

  <p>This CSS3 module describes how font properties are specified and how
   font resources are loaded dynamically. The contents of this specification
   are a consolidation of content previously divided into <a
   href="https://www.w3.org/TR/2002/WD-css3-fonts-20020802/">CSS3 Fonts</a>
   and <a href="https://www.w3.org/TR/2002/WD-css3-webfonts-20020802/">CSS3
   Web Fonts</a> modules. The description of font load events was moved into
   the <a href="https://drafts.csswg.org/css-font-loading-3/">CSS Font
   Loading</a> module.

  <h2 class="no-num no-toc" id=status>Status of this Document</h2>
  <!--begin-status-->

  <p><em>This section describes the status of this document at the time of its publication. Other documents may supersede this document. A list of current W3C publications and the latest revision of this technical report can be found in the <a href="https://www.w3.org/TR/">W3C technical reports index</a> at https://www.w3.org/TR/.</em></p>

  <p>This document has been reviewed by W3C Members, by software developers, and by other W3C groups and interested parties, and is endorsed by the Director as a W3C Recommendation. It is a stable document and may be used as reference material or cited from another document. W3C's role in making the Recommendation is to draw attention to the specification and to promote its widespread deployment. This enhances the functionality and interoperability of the Web.</p>

  <p>This document was produced by the <a
   href="http://www.w3.org/Style/CSS/members">CSS Working Group</a> as a <a
   href="http://www.w3.org/Consortium/Process/tr#RecsREC">W3C
   Recommendation.</a>.

   <p>This document was produced by a group operating under the <a href="https://www.w3.org/Consortium/Patent-Policy/">W3C Patent Policy</a>. W3C maintains a <a href="https://www.w3.org/2004/01/pp-impl/32061/status" rel="disclosure">public list of any patent disclosures</a> made in
    connection with the deliverables of the group; that page also includes
    instructions for disclosing a patent. An individual who has actual
    knowledge of a patent which the individual believes contains <a href="https://www.w3.org/Consortium/Patent-Policy/#def-essential">Essential
    Claim(s)</a> must disclose the information in accordance with <a href="https://www.w3.org/Consortium/Patent-Policy/#sec-Disclosure">section
    6 of the W3C Patent Policy</a>.</p>

   <p>This document is governed by the <a id="w3c_process_revision" href="https://www.w3.org/2018/Process-20180201/">1 February 2018 W3C Process Document</a>. </p>

  <!--end-status-->

  <p>A
   <a href="https://test.csswg.org/harness/suite/css-fonts-3_dev/">test suite</a> and
   <a
   href="https://test.csswg.org/harness/results/css-fonts-3_dev/grouped/">implementation report</a>
   are available.



  <nav id=toc>
  <h2 class="no-num no-toc" id=contents>Table of contents</h2>
  <!--begin-toc-->
  <ul class=toc>
   <li><a href="#introduction"><span class=secno>1. </span>Introduction</a>

   <li><a href="#typography-background"><span class=secno>2.
    </span>Typography Background</a>

   <li><a href="#basic-font-props"><span class=secno>3. </span>Basic Font
    Properties</a>
    <ul class=toc>
     <li><a href="#font-family-prop"><span class=secno>3.1. </span>Font
      family: the font-family property</a>
      <ul class=toc>
       <li><a href="#generic-font-families"><span class=secno>3.1.1.
        </span>Generic font families</a>
      </ul>

     <li><a href="#font-weight-prop"><span class=secno>3.2. </span>Font
      weight: the font-weight property</a>

     <li><a href="#font-stretch-prop"><span class=secno>3.3. </span>Font
      width: the font-stretch property</a>

     <li><a href="#font-style-prop"><span class=secno>3.4. </span>Font style:
      the font-style property</a>

     <li><a href="#font-size-prop"><span class=secno>3.5. </span>Font size:
      the font-size property</a>

     <li><a href="#font-size-adjust-prop"><span class=secno>3.6.
      </span>Relative sizing: the font-size-adjust property</a>

     <li><a href="#font-prop"><span class=secno>3.7. </span>Shorthand font
      property: the font property</a>

     <li><a href="#font-synthesis-prop"><span class=secno>3.8.
      </span>Controlling synthetic faces: the font-synthesis property</a>
    </ul>

   <li><a href="#font-resources"><span class=secno>4. </span>Font
    Resources</a>
    <ul class=toc>
     <li><a href="#font-face-rule"><span class=secno>4.1. </span>The
      <code>@font-face</code> rule</a>

     <li><a href="#font-family-desc"><span class=secno>4.2. </span>Font
      family: the font-family descriptor</a>

     <li><a href="#src-desc"><span class=secno>4.3. </span>Font reference:
      the src descriptor</a>

     <li><a href="#font-prop-desc"><span class=secno>4.4. </span>Font
      property descriptors: the font-style, font-weight, font-stretch
      descriptors</a>

     <li><a href="#unicode-range-desc"><span class=secno>4.5.
      </span>Character range: the unicode-range descriptor</a>

     <li><a href="#composite-fonts"><span class=secno>4.6. </span>Using
      character ranges to define composite fonts</a>

     <li><a href="#font-rend-desc"><span class=secno>4.7. </span>Font
      features: the font-feature-settings descriptor</a>

     <li><a href="#font-face-loading"><span class=secno>4.8. </span>Font
      loading guidelines</a>

     <li><a href="#font-fetching-requirements"><span class=secno>4.9.
      </span>Font fetching requirements</a>
    </ul>

   <li><a href="#font-matching-algorithm"><span class=secno>5. </span>Font
    Matching Algorithm</a>
    <ul class=toc>
     <li><a href="#font-family-casing"><span class=secno>5.1. </span>Case
      sensitivity of font family names</a>

     <li><a href="#font-style-matching"><span class=secno>5.2.
      </span>Matching font styles</a>

     <li><a href="#cluster-matching"><span class=secno>5.3. </span>Cluster
      matching</a>

     <li><a href="#char-handling-issues"><span class=secno>5.4.
      </span>Character handling issues</a>

     <li><a href="#font-matching-changes"><span class=secno>5.5. </span>Font
      matching changes since CSS 2.1</a>

     <li><a href="#font-matching-examples"><span class=secno>5.6. </span>Font
      matching examples</a>
    </ul>

   <li><a href="#font-rend-props"><span class=secno>6. </span>Font Feature
    Properties</a>
    <ul class=toc>
     <li><a href="#glyph-selection-positioning"><span class=secno>6.1.
      </span>Glyph selection and positioning</a>

     <li><a href="#language-specific-support"><span class=secno>6.2.
      </span>Language-specific display</a>

     <li><a href="#font-kerning-prop"><span class=secno>6.3. </span>Kerning:
      the font-kerning property</a>

     <li><a href="#font-variant-ligatures-prop"><span class=secno>6.4.
      </span>Ligatures: the font-variant-ligatures property</a>

     <li><a href="#font-variant-position-prop"><span class=secno>6.5.
      </span>Subscript and superscript forms: the font-variant-position
      property</a>

     <li><a href="#font-variant-caps-prop"><span class=secno>6.6.
      </span>Capitalization: the font-variant-caps property</a>

     <li><a href="#font-variant-numeric-prop"><span class=secno>6.7.
      </span>Numerical formatting: the font-variant-numeric property</a>

     <li><a href="#font-variant-east-asian-prop"><span class=secno>6.8.
      </span>East Asian text rendering: the font-variant-east-asian
      property</a>

     <li><a href="#font-variant-prop"><span class=secno>6.9. </span>Overall
      shorthand for font rendering: the font-variant property</a>

     <li><a href="#font-feature-settings-prop"><span class=secno>6.10.
      </span>Low-level font feature settings control: the
      font-feature-settings property</a>
    </ul>

   <li><a href="#font-feature-resolution"><span class=secno>7. </span>Font
    Feature Resolution </a>
    <ul class=toc>
     <li><a href="#default-features"><span class=secno>7.1. </span>Default
      features</a>

     <li><a href="#feature-precedence"><span class=secno>7.2. </span>Feature
      precedence</a>

     <li><a href="#feature-precedence-examples"><span class=secno>7.3.
      </span>Feature precedence examples</a>
    </ul>

   <li><a href="#object-model"><span class=secno>8. </span>Object Model</a>
    <ul class=toc>
     <li><a href="#om-fontface"><span class=secno>8.1. </span>The
      <code>CSSFontFaceRule</code> interface</a>
    </ul>

   <li class=no-num><a href="#platform-props-to-css">Appendix A: Mapping
    platform font properties to CSS properties</a>

   <li class=no-num><a href="#ch-ch-ch-changes">Changes</a>
    <ul class=toc>
        <li class=no-num><a href="#super-recent-changes"> Changes from the 14 August 2018 CSS Fonts 3 Proposed Recommendation</a>
     <li class=no-num><a href="#recent-changes"> Changes from the March 15
      2018 CSS Fonts 3 Candidate Recommendation</a>

     <li class=no-num><a href="#less-recent-changes"> Changes from the
      October 2013 CSS3 Fonts Candidate Recommendation</a>
    </ul>

   <li class=no-num><a href="#acknowledgments">Acknowledgments</a>

   <li class=no-num><a href="#conformance"> Conformance</a>
    <ul class=toc>
     <li class=no-num><a href="#conventions"> Document Conventions</a>

     <li class=no-num><a href="#conformance-classes"> Conformance Classes</a>

     <li class=no-num><a href="#partial"> Partial Implementations</a>

     <li class=no-num><a href="#experimental"> Experimental
      Implementations</a>

     <li class=no-num><a href="#testing"> Non-Experimental
      Implementations</a>

    </ul>

   <li class=no-num><a href="#references">References</a>
    <ul class=toc>
     <li class=no-num><a href="#normative-references">Normative
      References</a>

     <li class=no-num><a href="#other-references">Other References</a>
    </ul>

   <li class=no-num><a href="#index">Index</a>

   <li class=no-num><a href="#property-index">Property index</a>
  </ul>
  <!--end-toc--> </nav>
  <h2 id=introduction><span class=secno>1. </span>Introduction</h2>

  <p>A font provides a resource containing the visual representation of
   characters <a href="#ref-CHARMOD"
    >[CHARMOD]<!--{{CHARMOD}}--></a><a href="#ref-UNICODE"
    >[UNICODE]<!--{{UNICODE}}--></a>. At the simplest level it
   contains information that maps character codes to shapes (called glyphs)
   that represent these characters. Fonts sharing a common design style are
   commonly grouped into font families classified by a set of standard font
   properties. Within a family, the shape displayed for a given character can
   vary by stroke weight, slant or relative width, among others. An
   individual font face is described by a unique combination of these
   properties. For a given range of text, CSS font properties are used to
   select a font family and a specific font face within that family to be
   used when rendering that text. As a simple example, to use the bold form
   of Helvetica one could use:

  <pre>body {
    font-family: Helvetica;
    font-weight: bold;
}</pre>

  <p>Font resources may be installed locally on the system on which a user
   agent is running or downloadable. For local font resources descriptive
   information can be obtained directly from the font resource. For
   downloadable font resources (sometimes referred to as web fonts), the
   descriptive information is included with the reference to the font
   resource.

  <p>Families of fonts typically don't contain a single face for each
   possible variation of font properties. The CSS font selection mechanism
   describes how to match a given set of CSS font properties to a single font
   face.

  <h2 id=typography-background><span class=secno>2. </span>Typography
   Background</h2>

  <p><em>This section is non-normative.</em>

  <p> Typographic traditions vary across the globe, so there is no unique way
   to classify all fonts across languages and cultures. For even common Latin
   letters, wide variations are possible:

  <div class=figure><img alt="variations in glyphs for a single character"
   src=aaaaaa.png>
   <p class=caption>One character, many glyph variations
  </div>

  <p>Differences in the anatomy of letterforms is one way to distinguish
   fonts. For Latin fonts, flourishes at the ends of a character's main
   strokes, or serifs, can distinguish a font from those without. Similar
   comparisons exist in non-Latin fonts between fonts with tapered strokes
   and those using primarily uniform strokes:

  <div class=figure><img alt="serif vs. non-serifs" src=serifvssansserif.png>

   <p class=caption>Letterforms with and without serifs
  </div>

  <div class=figure><img alt="serif vs. non-serifs for japanese"
   src=minchovsgothic.png>
   <p class=caption>Similar groupings for Japanese typefaces
  </div>

  <p>Fonts contain letterforms and the data needed to map characters to these
   letterforms. Often this may be a simple one-to-one mapping, but more
   complex mappings are also possible. The use of combining diacritic marks
   creates many variations for an underlying letterform:

  <div class=figure><img alt="diacritic marks" src=aaaaaa-diacritics.png>
   <p class=caption>Variations with diacritic marks
  </div>

  <p>A sequence of characters can be represented by a single glyph known as a
   ligature:

  <div class=figure><img alt="example of a fi ligature"
   src=final-ligature.png>
   <p class=caption>Ligature example
  </div>

  <p>Visual transformations based on textual context are often stylistic
   option in European languages. They are required to correctly render
   languages like <a href="#ref-ARABIC-TYPO"
    >[ARABIC-TYPO]<!--{{ARABIC-TYPO}}--></a>, the lam and alef
   characters below <em>must</em> be combined when they exist in sequence:

  <div class=figure><img alt="lam alef ligature" src=lamaleflig.png>
   <p class=caption>Required Arabic ligature
  </div>

  <p>The relative complexity of these shaping transformations requires
   additional data within the font.

  <p>Sets of font faces with various stylistic variations are often grouped
   together into font families. In the simplest case a regular face is
   supplemented with bold and italic faces, but much more extensive groupings
   are possible. Variations in the thickness of letterform strokes, the <dfn
   id=weight>weight</dfn>, and the overall proportions of the letterform, the
   <dfn id=width>width</dfn>, are most common. In the example below, each
   letter uses a different font face within the Univers font family. The
   width used increases from top to bottom and the weight increases from left
   to right:

  <div class=figure><img
   alt="various width and weight variations within a single family"
   src=weightwidthvariations.png>
   <p class=caption>Weight and width variations within a single font family
  </div>

  <p>Creating fonts that support multiple scripts is a difficult task;
   designers need to understand the cultural traditions surrounding the use
   of type in different scripts and come up with letterforms that somehow
   share a common theme. Many languages often share a common script and each
   of these languages may have noticeable stylistic differences. For example,
   the Arabic script, when used for Persian and Urdu, exhibits significant
   and systematic differences in letterforms, as does Cyrillic when used with
   languages such as Serbian and Russian.

  <p>The <a href="#character-map"><em>character map</em></a> of a font
   defines the mapping of characters to glyphs for that font. If a document
   contains characters not supported by the <a href="#character-map"><em
   title="character map">character maps</em></a> of the fonts contained in a
   font family list, a user agent may use a <a
   href="#system-font-fallback"><em>system font fallback</em></a> procedure
   to locate an appropriate font that does. If no appropriate font can be
   found, some form of "missing glyph" character will be rendered by the user
   agent. System fallback can occur when the specified list of font families
   does not include a font that supports a given character.

  <p>Although the <a href="#character-map"><em>character map</em></a> of a
   font maps a given character to a glyph for that character, modern font
   technologies such as OpenType <a href="#ref-OPENTYPE"
    >[OPENTYPE]<!--{{OPENTYPE}}--></a> and AAT (Apple Advanced
   Typography) <a href="#ref-AAT-FEATURES"
    >[AAT-FEATURES]<!--{{AAT-FEATURES}}--></a> provide ways of
   mapping a character to different glyphs based upon feature settings. Fonts
   in these formats allow these features to be embedded in the font itself
   and controlled by applications. Common typographic features which can be
   specified this way include ligatures, swashes, contextual alternates,
   proportional and tabular figures, and automatic fractions, to list just a
   few. For a visual overview of OpenType features, see the <a
   href="#ref-OPENTYPE-FONT-GUIDE"
    >[OPENTYPE-FONT-GUIDE]<!--{{OPENTYPE-FONT-GUIDE}}--></a>.

  <h2 id=basic-font-props><span class=secno>3. </span>Basic Font Properties</h2>

  <p>The particular font face used to render a character is determined by the
   font family and other font properties that apply to a given element. This
   structure allows settings to be varied independent of each other.</p>
  <!-- prop: font-family -->

  <h3 id=font-family-prop><span class=secno>3.1. </span>Font family: the <a
   href="#propdef-font-family">font-family</a> property</h3>

  <table class=propdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=propdef-font-family
      title="font-family!!property">font-family</dfn>

    <tr>
     <td>Value:

     <td>[ <a href="#family-name-value"><var>&lt;family-name&gt;</var></a> |
      <a href="#generic-family-value"><var>&lt;generic-family&gt;</var></a> ]
      #

    <tr>
     <td>Initial:

     <td>depends on user agent

    <tr>
     <td>Applies to:

     <td>all elements

    <tr>
     <td>Inherited:

     <td>yes

    <tr>
     <td>Percentages:

     <td>N/A

    <tr>
     <td>Computed value:

     <td>as specified

    <tr>
     <td>Animatable:

     <td>no
  </table>

  <p>This property specifies a prioritized list of font family names or
   generic family names. A font family defines a set of faces that vary in
   weight, width or slope. CSS uses the combination of a family name with
   other style attributes to select an individual face. Using this selection
   mechanism, rather than selecting a face via the style name as is often
   done in design applications, allows some degree of regularity in textual
   display when fallback occurs.

  <p class=note>Designers should note that the CSS definition of font
   attributes used for selection are explicitly not intended to define a font
   taxonomy. A type designer's idea of a family may often extend to a set of
   faces that vary along axes other than just the standard axes of weight,
   width and slope. A family may extend to include both a set of serif faces
   and a set of sans-serif faces or vary along axes that are unique to that
   family. The CSS font selection mechanism merely provides a way to
   determine the “closest” substitute when substitution is necessary.

  <p>Unlike other CSS properties, component values are a comma-separated list
   indicating alternatives. A user agent iterates through the list of family
   names until it matches an available font that contains a glyph for the
   character to be rendered. This allows for differences in available fonts
   across platforms and for differences in the range of characters supported
   by individual fonts.

  <p>A font family name only specifies a name given to a set of font faces,
   it does not specify an individual face. For example, given the
   availability of the fonts below, Futura would match but Futura Medium
   would not:

  <div class=figure><img alt="family and face names"
   src=familyvsfacename.png>
   <p class=caption>Family and individual face names
  </div>

  <p>Consider the example below:

  <div class=example>
   <pre>body {
    font-family: Helvetica, Verdana, sans-serif;
}</pre>

   <p>If Helvetica is available it will be used when rendering. If neither
    Helvetica nor Verdana is present, then the user-agent-defined sans serif
    font will be used.
  </div>

  <p>There are two types of font family names:

  <dl>
   <dt><dfn id=family-name-value><var>&lt;family-name&gt;</var></dfn>

   <dd>The name of a font family of choice such as Helvetica or Verdana in
    the previous example.

   <dt><dfn id=generic-family-value><var>&lt;generic-family&gt;</var></dfn>

   <dd> The following generic family keywords are defined: ‘<a
    href="#serif"><code class=property>serif</code></a>’, ‘<a
    href="#sans-serif"><code class=property>sans-serif</code></a>’, ‘<a
    href="#cursive"><code class=property>cursive</code></a>’, ‘<a
    href="#fantasy"><code class=property>fantasy</code></a>’, and ‘<a
    href="#monospace"><code class=property>monospace</code></a>’. These
    keywords can be used as a general fallback mechanism when an author's
    desired font choices are not available. As keywords, they must not be
    quoted. Authors are encouraged to append a generic font family as a last
    alternative for improved robustness.
  </dl>

  <p>Font family names other than generic families must either be given
   quoted as <a
   href="https://www.w3.org/TR/CSS21/syndata.html#strings">strings,</a> or
   unquoted as a sequence of one or more <a
   href="https://www.w3.org/TR/CSS21/syndata.html#value-def-identifier">identifiers.</a>
   This means most punctuation characters and digits at the start of each
   token must be escaped in unquoted font family names.

  <p>To illustrate this, the following declarations are invalid:

  <pre>
font-family: Red/Black, sans-serif;
font-family: "Lucida" Grande, sans-serif;
font-family: Ahem!, sans-serif;
font-family: test@foo, sans-serif;
font-family: #POUND, sans-serif;
font-family: Hawaii 5-0, sans-serif;
</pre>

  <p>If a sequence of identifiers is given as a font family name, the
   computed value is the name converted to a string by joining all the
   identifiers in the sequence by single spaces.

  <p>To avoid mistakes in escaping, it is recommended to quote font family
   names that contain white space, digits, or punctuation characters other
   than hyphens:

  <pre>
body { font-family: "New Century Schoolbook", serif }

&lt;BODY STYLE="font-family: '21st Century', fantasy">
</pre>

  <p>Font family <em>names</em> that happen to be the same as keyword value
   (‘<code class=property>inherit</code>’, ‘<a href="#serif"><code
   class=property>serif</code></a>’, etc.) must be quoted to prevent
   confusion with the keywords with the same names. UAs must not consider
   these keywords as matching the <a
   href="#family-name-value"><var>&lt;family-name&gt;</var></a> type. This
   applies to any keyword across all of CSS.

  <p>The precise way a set of fonts are grouped into font families varies
   depending upon the platform font management API's. The Windows GDI API
   only allows four faces to be grouped into a family while the DirectWrite
   API and API's on OSX and other platforms support font families with a
   variety of weights, widths and slopes (see <a
   href="#platform-props-to-css">Appendix A</a> for more details).

  <p>Some font formats allow fonts to carry multiple localizations of the
   family name. User agents must recognize and correctly match all of these
   names independent of the underlying platform localization, system API used
   or document encoding:

  <div class=figure><img alt="examples of localized family names"
   src=localizedfamilynames.png>
   <p class=caption>Localized family names
  </div>

  <p>The details of localized font family name matching and the corresponding
   issues of case sensitivity are described below in the <a
   href="#font-family-casing">font matching</a> section.

  <h4 id=generic-font-families><span class=secno>3.1.1. </span>Generic font
   families</h4>

  <p>All five generic font families must always result in at least one
   matched font face, for all CSS implementations. However, the generics may
   be composite faces (with different typefaces based on such things as the
   Unicode range of the character, the language of the containing element,
   user preferences and system settings, among others). They are also not
   guaranteed to always be different from each other.

  <p>User agents should provide reasonable default choices for the generic
   font families, which express the characteristics of each family as well as
   possible, within the limits allowed by the underlying technology. User
   agents are encouraged to allow users to select alternative choices for the
   generic fonts.

  <h5 class="no-num no-toc"> <span class=index-def id=serif0
   title="serif, definition of"><a name=serif-def><dfn
   id=serif>serif</dfn></a></span></h5>

  <p>Serif fonts represent the formal text style for a script. This often
   means but is not limited to glyphs that have finishing strokes, flared or
   tapering ends, or have actual serifed endings (including slab serifs).
   Serif fonts are typically proportionately-spaced. They often display a
   greater variation between thick and thin strokes than fonts from the ‘<a
   href="#sans-serif"><code class=property>sans-serif</code></a>’ generic
   font family. CSS uses the term ‘<a href="#serif"><code
   class=property>serif</code></a>’ to apply to a font for any script,
   although other names may be more familiar for particular scripts, such as
   Mincho (Japanese), Sung or Song (Chinese), Batang (Korean). For Arabic,
   the Naskh style would correspond to ‘<a href="#serif"><code
   class=property>serif</code></a>’ more due to its typographic role rather
   than its actual design style. Any font that is so described may be used to
   represent the generic ‘<a href="#serif"><code
   class=property>serif</code></a>’ family.

  <div class=figure><img alt="sample serif fonts" src=serifexamples.png>
   <p class=caption>Sample serif fonts
  </div>

  <h5 class="no-num no-toc"> <span class=index-def id=sans-serif0
   title="sans-serif, definition of"> <a name=sans-serif-def><dfn
   id=sans-serif>sans-serif</dfn></a></span></h5>

  <p>Glyphs in sans-serif fonts, as the term is used in CSS, are generally
   low contrast (vertical and horizontal stems have the close to the same
   thickness) and have stroke endings that are plain — without any flaring,
   cross stroke, or other ornamentation. Sans-serif fonts are typically
   proportionately-spaced. They often have little variation between thick and
   thin strokes, compared to fonts from the ‘<a href="#serif"><code
   class=property>serif</code></a>’ family. CSS uses the term ‘<a
   href="#sans-serif"><code class=property>sans-serif</code></a>’ to apply
   to a font for any script, although other names may be more familiar for
   particular scripts, such as Gothic (Japanese), Hei (Chinese), or Gulim
   (Korean). Any font that is so described may be used to represent the
   generic ‘<a href="#sans-serif"><code
   class=property>sans-serif</code></a>’ family.

  <div class=figure><img alt="sample sans-serif fonts"
   src=sansserifexamples.png>
   <p class=caption>Sample sans-serif fonts
  </div>

  <h5 class="no-num no-toc"> <span class=index-def id=cursive0
   title="cursive, definition of"> <a name=cursive-def><dfn
   id=cursive>cursive</dfn></a></span></h5>

  <p>Glyphs in cursive fonts generally use a more informal script style, and
   the result looks more like handwritten pen or brush writing than printed
   letterwork. CSS uses the term ‘<a href="#cursive"><code
   class=property>cursive</code></a>’ to apply to a font for any script,
   although other names such as Chancery, Brush, Swing and Script are also
   used in font names.

  <div class=figure><img alt="sample cursive fonts" src=cursiveexamples.png>
   <p class=caption>Sample cursive fonts
  </div>

  <h5 class="no-num no-toc"> <span class=index-def id=fantasy0
   title="fantasy, definition of"> <a name=fantasy-def><dfn
   id=fantasy>fantasy</dfn></a></span></h5>

  <p>Fantasy fonts are primarily decorative or expressive fonts that contain
   decorative or expressive representations of characters. These do not
   include Pi or Picture fonts which do not represent actual characters.

  <div class=figure><img alt="sample fantasy fonts" src=fantasyexamples.png>
   <p class=caption>Sample fantasy fonts
  </div>

  <h5 class="no-num no-toc"> <span class=index-def id=monospace0
   title="monospace, definition of"> <a name=monospace-def><dfn
   id=monospace>monospace</dfn></a></span></h5>

  <p>The sole criterion of a monospace font is that all glyphs have the same
   fixed width. This is often used to render samples of computer code.

  <div class=figure><img alt="sample monospace fonts"
   src=monospaceexamples.png>
   <p class=caption>Sample monospace fonts
  </div>
  <!-- prop: font-weight -->

  <h3 id=font-weight-prop><span class=secno>3.2. </span>Font weight: the <a
   href="#propdef-font-weight">font-weight</a> property</h3>

  <table class=propdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=propdef-font-weight
      title="font-weight!!property">font-weight</dfn>

    <tr>
     <td>Value:

     <td><a href="#font-weight-normal-value"
      title="normal!!font-weight">normal</a> | <a href="#bold">bold</a> | <a
      href="#bolder">bolder</a> | <a href="#lighter">lighter</a> | <a
      href="#font-weight-numeric-values"
      title="100...900 weight values">100</a> | <a
      href="#font-weight-numeric-values"
      title="100...900 weight values">200</a> | <a
      href="#font-weight-numeric-values"
      title="100...900 weight values">300</a> | <a
      href="#font-weight-numeric-values"
      title="100...900 weight values">400</a> | <a
      href="#font-weight-numeric-values"
      title="100...900 weight values">500</a> | <a
      href="#font-weight-numeric-values"
      title="100...900 weight values">600</a> | <a
      href="#font-weight-numeric-values"
      title="100...900 weight values">700</a> | <a
      href="#font-weight-numeric-values"
      title="100...900 weight values">800</a> | <a
      href="#font-weight-numeric-values"
      title="100...900 weight values">900</a>

    <tr>
     <td>Initial:

     <td>normal

    <tr>
     <td>Applies to:

     <td>all elements

    <tr>
     <td>Inherited:

     <td>yes

    <tr>
     <td>Percentages:

     <td>N/A

    <tr>
     <td>Computed value:

     <td>numeric weight value (see description)

    <tr>
     <td>Animatable:

     <td>as <a
      href="https://drafts.csswg.org/css-transitions/#animtype-font-weight">font
      weight</a>
  </table>

  <p>The <a href="#propdef-font-weight"
   title="font-weight!!property">‘<code
   class=property>font-weight</code>’</a> property specifies the weight of
   glyphs in the font, their degree of blackness or stroke thickness.

  <p>Values have the following meanings:

  <dl>
   <dt><dfn id=font-weight-numeric-values title="100...900 weight values">100
    to 900</dfn>

   <dd>These values form an ordered sequence, where each number indicates a
    weight that is at least as dark as its predecessor. These roughly
    correspond to the commonly used weight names below:
  </dl>

  <ul>
   <li>100 - Thin

   <li>200 - Extra Light (Ultra Light)

   <li>300 - Light

   <li>400 - Normal

   <li>500 - Medium

   <li>600 - Semi Bold (Demi Bold)

   <li>700 - Bold

   <li>800 - Extra Bold (Ultra Bold)

   <li>900 - Black (Heavy)
  </ul>

  <dl>
   <dt><dfn id=font-weight-normal-value
    title="normal!!font-weight">normal</dfn>

   <dd>Same as ‘<code class=css>400</code>’.

   <dt><dfn id=bold>bold</dfn>

   <dd>Same as ‘<code class=css>700</code>’.

   <dt><dfn id=bolder>bolder</dfn>

   <dd>Specifies a bolder weight than the inherited value.

   <dt><dfn id=lighter>lighter</dfn>

   <dd>Specifies a lighter weight than the inherited value.
  </dl>

  <p>Font formats that use a scale other than a nine-step scale should map
   their scale onto the CSS scale so that 400 roughly corresponds with a face
   that would be labeled as Regular, Book, Roman and 700 roughly matches a
   face that would be labeled as Bold. Or weights may be inferred from the
   style names, ones that correspond roughly with the scale above. The scale
   is relative, so a face with a larger weight value must never appear
   lighter. If style names are used to infer weights, care should be taken to
   handle variations in style names across locales.

  <p>Quite often there are only a few weights available for a particular font
   family. When a weight is specified for which no face exists, a face with a
   nearby weight is used. In general, bold weights map to faces with heavier
   weights and light weights map to faces with lighter weights (see the <a
   href="#font-matching-algorithm">font matching section below</a> for a
   precise definition). The examples here illustrate which face is used for
   different weights, grey indicates a face for that weight does not exist so
   a face with a nearby weight is used:

  <div class=figure><img
   alt="weight mappings for a family with 400, 700 and 900 weights"
   src=optimaweights.png>
   <p class=caption>Weight mappings for a font family with 400, 700 and 900
    weight faces
  </div>

  <div class=figure><img
   alt="weight mappings for a family with 300, 600 weights"
   src=hiraginoweights.png>
   <p class=caption>Weight mappings for a font family with 300 and 600 weight
    faces
  </div>

  <p>Although the practice is not well-loved by typographers, bold faces are
   often synthesized by user agents for faces that lack actual bold faces.
   For the purposes of style matching, these faces must be treated as if they
   exist within the family. Authors can explicitly avoid this behavior by
   using the ‘<a href="#propdef-font-synthesis"><code
   class=property>font-synthesis</code></a>’ property.

  <p>Specified values of ‘<a href="#bolder"><code
   class=property>bolder</code></a>’ and ‘<a href="#lighter"><code
   class=property>lighter</code></a>’ indicate weights relative to the
   weight of the parent element. The computed weight is calculated based on
   the inherited <a href="#propdef-font-weight"
   title="font-weight!!property">‘<code
   class=property>font-weight</code>’</a> value using the chart below.

  <table class=data id=bolderlighter>
   <thead>
    <tr>
     <th>Inherited value

     <th>bolder

     <th>lighter

   <tbody>
    <tr>
     <th>100

     <td>400

     <td>100

    <tr>
     <th>200

     <td>400

     <td>100

    <tr>
     <th>300

     <td>400

     <td>100

    <tr>
     <th>400

     <td>700

     <td>100

    <tr>
     <th>500

     <td>700

     <td>100

    <tr>
     <th>600

     <td>900

     <td>400

    <tr>
     <th>700

     <td>900

     <td>400

    <tr>
     <th>800

     <td>900

     <td>700

    <tr>
     <th>900

     <td>900

     <td>700
  </table>

  <p>The table above is equivalent to selecting the next relative bolder or
   lighter face, given a font family containing normal and bold faces along
   with a thin and a heavy face. Authors who desire finer control over the
   exact weight values used for a given element may use numerical values
   instead of relative weights.</p>
  <!-- prop: font-stretch -->

  <h3 id=font-stretch-prop><span class=secno>3.3. </span>Font width: the <a
   href="#propdef-font-stretch">font-stretch</a> property</h3>

  <table class=propdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=propdef-font-stretch
      title="font-stretch!!property">font-stretch</dfn>

    <tr>
     <td>Value:

     <td> <a href="#font-stretch-normal-value"
      title="normal!!font-stretch">normal</a> | <a
      href="#ultra-condensed">ultra-condensed</a> | <a
      href="#extra-condensed">extra-condensed</a> | <a
      href="#condensed">condensed</a> | <a
      href="#semi-condensed-">semi-condensed</a> | <a
      href="#semi-expanded">semi-expanded</a> | <a
      href="#expanded">expanded</a> | <a
      href="#extra-expanded">extra-expanded</a> | <a
      href="#ultra-expanded">ultra-expanded</a>

    <tr>
     <td>Initial:

     <td>normal

    <tr>
     <td>Applies to:

     <td>all elements

    <tr>
     <td>Inherited:

     <td>yes

    <tr>
     <td>Percentages:

     <td>N/A

    <tr>
     <td>Computed value:

     <td>as specified

    <tr>
     <td>Animatable:

     <td>as <a href="#font-stretch-animation">font stretch</a>
  </table>

  <p>The <a href="#propdef-font-stretch"
   title="font-stretch!!property">‘<code
   class=property>font-stretch</code>’</a> property selects a normal,
   condensed, or expanded face from a font family. Absolute keyword values
   have the following ordering, from narrowest to widest:

  <ul>
   <li><dfn id=ultra-condensed>ultra-condensed</dfn>

   <li><dfn id=extra-condensed>extra-condensed</dfn>

   <li><dfn id=condensed>condensed</dfn>

   <li><dfn id=semi-condensed->semi-condensed </dfn>

   <li><dfn id=font-stretch-normal-value
    title="normal!!font-stretch">normal</dfn>

   <li><dfn id=semi-expanded>semi-expanded</dfn>

   <li><dfn id=expanded>expanded</dfn>

   <li><dfn id=extra-expanded>extra-expanded</dfn>

   <li><dfn id=ultra-expanded>ultra-expanded</dfn>
  </ul>

  <p>When a face does not exist for a given width, normal or condensed values
   map to a narrower face, otherwise a wider face. Conversely, expanded
   values map to a wider face, otherwise a narrower face. The figure below
   shows how the nine font-stretch property settings affect font selection
   for font family containing a variety of widths, grey indicates a width for
   which no face exists and a different width is substituted:

  <div class=figure><img
   alt="width mappings for a family with condensed, normal and expanded faces"
   src=universwidths.png>
   <p class=caption>Width mappings for a font family with condensed, normal
    and expanded width faces
  </div>

  <p id=font-stretch-animation>Animation of font stretch: Font stretch is
   interpolated in discrete steps. The interpolation happens as though the
   ordered values are equally spaced real numbers. The interpolation result
   is rounded to the nearest value, with values exactly halfway between two
   values rounded towards the later value in the list above.</p>
  <!-- prop: font-style -->

  <h3 id=font-style-prop><span class=secno>3.4. </span>Font style: the <a
   href="#propdef-font-style">font-style</a> property</h3>

  <table class=propdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=propdef-font-style
      title="font-style!!property">font-style</dfn>

    <tr>
     <td>Value:

     <td><a href="#font-style-normal-value"
      title="normal!!font-style">normal</a> | <a href="#italic">italic</a> |
      <a href="#oblique">oblique</a>

    <tr>
     <td>Initial:

     <td>normal

    <tr>
     <td>Applies to:

     <td>all elements

    <tr>
     <td>Inherited:

     <td>yes

    <tr>
     <td>Percentages:

     <td>N/A

    <tr>
     <td>Computed value:

     <td>as specified

    <tr>
     <td>Animatable:

     <td>no
  </table>

  <p>The <a href="#propdef-font-style" title="font-style!!property">‘<code
   class=property>font-style</code>’</a> property allows italic or oblique
   faces to be selected. Italic forms are generally cursive in nature while
   oblique faces are typically sloped versions of the regular face. Oblique
   faces can be simulated by artificially sloping the glyphs of the regular
   face. Compare the artificially sloped renderings of Palatino ‘<code
   class=property>a</code>’ and Baskerville ‘<code
   class=property>N</code>’ in grey with the actual italic versions:

  <div class=figure><img alt="artificial sloping vs. real italics"
   src=realvsfakeitalics.png>
   <p class=caption>Artificial sloping versus real italics
  </div>

  <p>Values have the following meanings:

  <dl>
   <dt><dfn id=font-style-normal-value
    title="normal!!font-style">normal</dfn>

   <dd>selects a face that is classified as a normal face, one that is
    neither italic or obliqued

   <dt><dfn id=italic>italic</dfn>

   <dd>selects a font that is labeled as an italic face, or an oblique face
    if one is not

   <dt><dfn id=oblique>oblique</dfn>

   <dd>selects a font that is labeled as an oblique face, or an italic face
    if one is not
  </dl>

  <p>If no italic or oblique face is available, oblique faces can be
   synthesized by rendering non-obliqued faces with an artificial obliquing
   operation. The use of these artificially obliqued faces can be disabled
   using the ‘<a href="#propdef-font-synthesis"><code
   class=property>font-synthesis</code></a>’ property. The details of the
   obliquing operation are not explicitly defined.

  <p class=note>Authors should also be aware that synthesized approaches may
   not be suitable for scripts like Cyrillic, where italic forms are very
   different in shape. It is always better to use an actual italic font
   rather than rely on a synthetic version.</p>
  <!-- resolution on the "undefined" nature of synthetics: https://www.w3.org/2013/06/06-css-minutes.html#item03 -->

  <p>Many scripts lack the tradition of mixing a cursive form within text
   rendered with a normal face. Chinese, Japanese and Korean fonts almost
   always lack italic or oblique faces. Fonts that support a mixture of
   scripts will sometimes omit specific scripts such as Arabic from the set
   of glyphs supported in the italic face. User agents should be careful
   about making <a href="#character-map"><em>character map</em></a>
   assumptions across faces when implementing support for <a
   href="#system-font-fallback"><em>system font fallback</em></a>.</p>
  <!-- prop: font-size -->

  <h3 id=font-size-prop><span class=secno>3.5. </span>Font size: the <a
   href="#propdef-font-size">font-size</a> property</h3>

  <table class=propdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=propdef-font-size>font-size</dfn>

    <tr>
     <td>Value:

     <td><a href="#absolute-size-value"><var>&lt;absolute-size&gt;</var></a>
      | <a href="#relative-size-value"><var>&lt;relative-size&gt;</var></a> |
      <var>&lt;length-percentage&gt;</var>

    <tr>
     <td>Initial:

     <td>medium

    <tr>
     <td>Applies to:

     <td>all elements

    <tr>
     <td>Inherited:

     <td>yes

    <tr>
     <td>Percentages:

     <td>refer to parent element's font size

    <tr>
     <td>Computed value:

     <td>absolute length

    <tr>
     <td>Animatable:

     <td>as <a
      href="https://drafts.csswg.org/css-transitions/#animtype-length">length</a>
  </table>

  <p>This property indicates the desired height of glyphs from the font. For
   scalable fonts, the font-size is a scale factor applied to the EM unit of
   the font. (Note that certain glyphs may bleed outside their EM box.) For
   non-scalable fonts, the font-size is converted into absolute units and
   matched against the declared ‘<a href="#propdef-font-size"><code
   class=property>font-size</code></a>’ of the font, using the same
   absolute coordinate space for both of the matched values. Values have the
   following meanings:

  <dl>
   <dt><dfn id=absolute-size-value><var>&lt;absolute-size&gt;</var></dfn>

   <dd> An <a
    href="#absolute-size-value"><var>&lt;absolute-size&gt;</var></a> keyword
    refers to an entry in a table of font sizes computed and kept by the user
    agent. Possible values are:
    <p><code> [ xx-small | x-small | small | medium | large | x-large |
     xx-large ]</code>

   <dt><dfn id=relative-size-value><var>&lt;relative-size&gt;</var></dfn>

   <dd> A <a href="#relative-size-value"><var>&lt;relative-size&gt;</var></a>
    keyword is interpreted relative to the table of font sizes and the
    computed ‘<a href="#propdef-font-size"><code
    class=property>font-size</code></a>’ of the parent element. Possible
    values are:
    <p><code> [ larger | smaller ]</code>

    <p> For example, if the parent element has a font size of ‘<code
     class=property>medium</code>’, a value of ‘<code
     class=property>larger</code>’ will make the font size of the current
     element be ‘<code class=property>large</code>’. If the parent
     element's size is not close to a table entry, the user agent is free to
     interpolate between table entries or round off to the closest one. The
     user agent may have to extrapolate table values if the numerical value
     goes beyond the keywords.

   <dt><a
    href="https://drafts.csswg.org/css-values-4/#typedef-length-percentage"
    id=length-percentage-size-value><var>&lt;length-percentage&gt;</var></a>

   <dd>
    <p>A length value <a href="#ref-CSS-VALUES"  >[CSS-VALUES]</a>
      specifies an absolute font size
     (independent of the user agent's font table). Negative lengths are
     invalid.

    <p>A percentage value specifies an absolute font size relative to the
     parent element's font size. Use of percentage values, or values in <a
     class=css data-link-type=maybe
     href="https://drafts.csswg.org/css-values-4/#em" id=ref-for-em>em</a>s,
     leads to more robust and cascadable style sheets. Negative percentages
     are invalid.
  </dl>

  <p>The following table provides user agent guidelines for the absolute-size
   scaling factor and their mapping to HTML heading and absolute font-sizes.
   The ‘<code class=property>medium</code>’ value is used as the
   reference middle value. The user agent may fine-tune these values for
   different fonts or different types of display devices.

  <table class=data>
   <thead>
    <tr>
     <th>CSS absolute-size values

     <th><code>xx-small</code>

     <th><code>x-small</code>

     <th><code>small</code>

     <th><code>medium</code>

     <th><code>large</code>

     <th><code>x-large</code>

     <th><code>xx-large</code>

     <th>

   <tbody>
    <tr>
     <th>scaling factor

     <td>3/5

     <td>3/4

     <td>8/9

     <td>1

     <td>6/5

     <td>3/2

     <td>2/1

     <td>3/1

    <tr>
     <th>HTML headings

     <td>h6

     <td>

     <td>h5

     <td>h4

     <td>h3

     <td>h2

     <td>h1

     <td>

    <tr>
     <th>HTML font sizes

     <td>1

     <td>

     <td>2

     <td>3

     <td>4

     <td>5

     <td>6

     <td>7
  </table>

  <p class=note><em><strong>Note 1.</strong> To preserve readability, an UA
   applying these guidelines should nevertheless avoid creating font-size
   resulting in less than 9 device pixels per EM unit on a computer
   display.</em>

  <p class=note><em><strong>Note 2.</strong> In CSS1, the suggested scaling
   factor between adjacent indexes was 1.5 which user experience proved to be
   too large. In CSS2, the suggested scaling factor for computer screen
   between adjacent indexes was 1.2 which still created issues for the small
   sizes. The new scaling factor varies between each index to provide a
   better readability.</em>

  <p>The actual value of this property may differ from the computed value due
   a numerical value on ‘<a href="#propdef-font-size-adjust"><code
   class=property>font-size-adjust</code></a>’ and the unavailability of
   certain font sizes.

  <p>Child elements inherit the computed <a class=noxref
   href="#font-size-prop"> <span class=property>‘<code
   class=property>font-size</code>’</span></a> value (otherwise, the effect
   of <a class=noxref href="#font-size-adjust-prop"><span
   class=property>‘<code
   class=property>font-size-adjust</code>’</span></a> would compound).

  <div class=example>
   <p style="display:none">Example(s):

   <pre>p { font-size: 12pt; }
blockquote { font-size: larger }
em { font-size: 150% }
em { font-size: 1.5em }
</pre>
  </div>
  <!-- prop: font-size-adjust -->

  <h3 id=font-size-adjust-prop><span class=secno>3.6. </span>Relative sizing:
   the <a href="#propdef-font-size-adjust">font-size-adjust</a> property</h3>

  <table class=propdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=propdef-font-size-adjust>font-size-adjust</dfn>

    <tr>
     <td>Value:

     <td><a href="#font-size-adjust-none-value"
      title="none!!font-size-adjust">none</a> | <a
      href="#aspect-ratio-value"><var>&lt;number&gt;</var></a>

    <tr>
     <td>Initial:

     <td>none

    <tr>
     <td>Applies to:

     <td>all elements

    <tr>
     <td>Inherited:

     <td>yes

    <tr>
     <td>Percentages:

     <td>N/A

    <tr>
     <td>Computed value:

     <td>as specified

    <tr>
     <td>Animatable:

     <td>as <a
      href="https://drafts.csswg.org/css-transitions/#animtype-number">number</a>
  </table>

  <p>For any given font size, the apparent size and legibility of text varies
   across fonts. For scripts such as Latin or Cyrillic that distinguish
   between upper and lowercase letters, the relative height of lowercase
   letters compared to their uppercase counterparts is a determining factor
   of legibility. This is commonly referred to as the <a class=index-def
   href="#aspect-value" id=aspect-value0 title="aspect value"><dfn
   id=aspect-value>aspect value</dfn></a>. Precisely defined, it is equal to
   the <code>x-height</code> of a font divided by the font size.

  <p>In situations where font fallback occurs, fallback fonts may not share
   the same aspect value as the desired font family and will thus appear less
   readable. The ‘<a href="#propdef-font-size-adjust"><code
   class=property>font-size-adjust</code></a>’ property is a way to
   preserve the readability of text when font fallback occurs. It does this
   by adjusting the font-size so that the x-height is the same regardless of
   the font used.

  <div class=example>
   <p>The style defined below defines Verdana as the desired font family, but
    if Verdana is not available Futura or Times will be used.

   <pre>p {
    font-family: Verdana, Futura, Times;
}

&lt;p>Lorem ipsum dolor sit amet, ...&lt;/p>
</pre>

   <p>Verdana has a relatively high aspect value, lowercase letters are
    relatively tall compared to uppercase letters, so at small sizes text
    appears legible. Times has a lower aspect value and so if fallback
    occurs, the text will be less legible at small sizes than Verdana.
  </div>

  <p>How text rendered in each of these fonts compares is shown below, the
   columns show text rendered in Verdana, Futura and Times. The same
   font-size value is used across cells within each row and red lines are
   included to show the differences in x-height. In the upper half each row
   is rendered in the same font-size value. The same is true for the lower
   half but in this half the ‘<a href="#propdef-font-size-adjust"><code
   class=property>font-size-adjust</code></a>’ property is also set so that
   the actual font size is adjusted to preserve the x-height across each row.
   Note how small text remains relatively legible across each row in the
   lower half.

  <div class=figure><img alt="text with and without 'font-size-adjust'"
   src=fontsizeadjust.png>
   <p class=caption>Text with and without the use of ‘<a
    href="#propdef-font-size-adjust"><code
    class=property>font-size-adjust</code></a>’
  </div>

  <p>This property allows authors to specify an <a
   href="#aspect-value"><i>aspect value</i></a> for an element that will
   effectively preserve the x-height of the first choice font, whether it is
   substituted or not. Values have the following meanings:

  <dl>
   <dt><dfn id=font-size-adjust-none-value
    title="none!!font-size-adjust">none</dfn>

   <dd>Do not preserve the font's x-height.

   <dt><dfn data-dfn-for=font-size-adjust data-dfn-type=value
    id=aspect-ratio-value><var>&lt;number&gt;</var></dfn>

   <dd>Specifies the <a href="#aspect-value"><i>aspect value</i></a> used in
    the calculation below to calculate the adjusted font size:
    <pre>c  =  ( a / a' ) s
</pre>

    <p>where:

    <pre>s  =  font-size value
a  =  <a
     href="#aspect-value"><i>aspect value</i></a> as specified by the 'font-size-adjust' property
a' =  <a
     href="#aspect-value"><i>aspect value</i></a> of actual font
c  =  adjusted font-size to use
</pre>

    <p>Negative values are invalid.

    <p>This value applies to any font that is selected but in typical usage
     it should be based on the <a href="#aspect-value"><i>aspect
     value</i></a> of the first font in the font-family list. If this is
     specified accurately, the  <span style="font-family: monospace">(a/a')</span> term in the formula above is
     effectively 1 for the first font and no adjustment occurs. If the value
     is specified inaccurately, text rendered using the first font in the
     family list will display differently in older user agents that don't
     support ‘<a href="#propdef-font-size-adjust"><code
     class=property>font-size-adjust</code></a>’.
  </dl>

  <p>The value of ‘<a href="#propdef-font-size-adjust"><code
   class=property>font-size-adjust</code></a>’ affects the used value of
   ‘<a href="#propdef-font-size"><code
   class=property>font-size</code></a>’ but does not affect the computed
   value. It affects the size of relative units that are based on font
   metrics of the <a href="#first-available-font"><i>first available
   font</i></a> such as <code>ex</code> and <code>ch</code> but does not
   affect the size of <code>em</code> units. Since numeric values of <a
   href="https://www.w3.org/TR/CSS2/visudet.html#propdef-line-height">‘<code
   class=property>line-height</code>’</a> refer to the computed size of
   ‘<a href="#propdef-font-size"><code
   class=property>font-size</code></a>’, ‘<a
   href="#propdef-font-size-adjust"><code
   class=property>font-size-adjust</code></a>’ does not affect the used
   value of <a
   href="https://www.w3.org/TR/CSS2/visudet.html#propdef-line-height">‘<code
   class=property>line-height</code>’</a>.

  <p class=note>In CSS, authors often specify <a
   href="https://www.w3.org/TR/CSS2/visudet.html#propdef-line-height">‘<code
   class=property>line-height</code>’</a> as a multiple of the ‘<a
   href="#propdef-font-size"><code class=property>font-size</code></a>’.
   Since the ‘<a href="#propdef-font-size-adjust"><code
   class=property>font-size-adjust</code></a>’ property affects the used
   value of ‘<a href="#propdef-font-size"><code
   class=property>font-size</code></a>’, authors should take care setting
   the line height when ‘<a href="#propdef-font-size-adjust"><code
   class=property>font-size-adjust</code></a>’ is used. Setting the line
   height too tightly can result in overlapping lines of text in this
   situation.

  <p>Authors can calculate the <a href="#aspect-value"><i>aspect
   value</i></a> for a given font by comparing spans with the same content
   but different ‘<a href="#propdef-font-size-adjust"><code
   class=property>font-size-adjust</code></a>’ properties. If the same
   font-size is used, the spans will match when the ‘<a
   href="#propdef-font-size-adjust"><code
   class=property>font-size-adjust</code></a>’ value is accurate for the
   given font.

  <div class=example>
   <p>Two spans with borders are used to determine the <a
    href="#aspect-value"><i>aspect value</i></a> of a font. The ‘<a
    href="#propdef-font-size"><code class=property>font-size</code></a>’ is
    the same for both spans but the ‘<a
    href="#propdef-font-size-adjust"><code
    class=property>font-size-adjust</code></a>’ property is specified only
    for the right span. Starting with a value of 0.5, the aspect value can be
    adjusted until the borders around the two letters line up.

   <pre>p {
    font-family: Futura;
    font-size: 500px;
}

span {
    border: solid 1px red;
}

.adjust {
    font-size-adjust: 0.5;
}

&lt;p>&lt;span>b&lt;/span>&lt;span class="adjust">b&lt;/span>&lt;/p>
</pre>

   <div class=figure><img
    alt="Futura with an &#60;i&#62;aspect value&#60;/i&#62; of 0.5"
    src=beforefontsizeadjust.png>
    <p class=caption>Futura with an <a href="#aspect-value"><i>aspect
     value</i></a> of 0.5
   </div>

   <p>The box on the right is a bit bigger than the one on the left, so the
    <a href="#aspect-value"><i>aspect value</i></a> of this font is something
    less than 0.5. Adjust the value until the boxes align.
  </div>
  <!-- prop: font -->

  <h3 id=font-prop><span class=secno>3.7. </span>Shorthand font property: the
   <a href="#propdef-font">font</a> property</h3>

  <table class=propdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=propdef-font>font</dfn>

    <tr>
     <td>Value:

     <td>[ [ <var>&lt;<a href="#propdef-font-style"
      title="font-style!!property">‘<code
      class=property>font-style</code>’</a>&gt;</var> || <a
      href="#font-variant-css21-values"><var>&lt;font-variant-css21&gt;</var></a>
      || <var>&lt;<a href="#propdef-font-weight"
      title="font-weight!!property">‘<code
      class=property>font-weight</code>’</a>&gt;</var> || <var>&lt;<a
      href="#propdef-font-stretch" title="font-stretch!!property">‘<code
      class=property>font-stretch</code>’</a>&gt;</var> ]? <var>&lt;‘<a
      href="#propdef-font-size"><code
      class=property>font-size</code></a>’&gt;</var> [ / <var>&lt;‘<code
      class=property>line-height</code>’&gt;</var> ]? <var>&lt;<a
      href="#propdef-font-family" title="font-family!!property">‘<code
      class=property>font-family</code>’</a>&gt;</var> ] | caption | icon |
      menu | message-box | small-caption | status-bar

    <tr>
     <td>Initial:

     <td>see individual properties

    <tr>
     <td>Applies to:

     <td>all elements

    <tr>
     <td>Inherited:

     <td>yes

    <tr>
     <td>Percentages:

     <td>see individual properties

    <tr>
     <td>Computed value:

     <td>see individual properties

    <tr>
     <td>Animatable:

     <td>see individual properties
  </table>

  <p>The <a class=property href="#propdef-font">‘<code
   class=property>font</code>’</a> property is, except as described below,
   a shorthand property for setting <a href="#propdef-font-style"
   title="font-style!!property">‘<code
   class=property>font-style</code>’</a>, <a href="#propdef-font-variant"
   title="font-variant!!property">‘<code
   class=property>font-variant</code>’</a>, <a href="#propdef-font-weight"
   title="font-weight!!property">‘<code
   class=property>font-weight</code>’</a>, <a href="#propdef-font-stretch"
   title="font-stretch!!property">‘<code
   class=property>font-stretch</code>’</a>, <a class=property
   href="#propdef-font-size">‘<code class=property>font-size</code>’</a>,
   <a class=property
   href="https://www.w3.org/TR/CSS2/visudet.html#propdef-line-height">‘<code
   class=property>line-height</code>’</a>, <a href="#propdef-font-family"
   title="font-family!!property">‘<code
   class=property>font-family</code>’</a> at the same place in the
   stylesheet. Values for the <a href="#propdef-font-variant"
   title="font-variant!!property">‘<code
   class=property>font-variant</code>’</a> property may also be included
   but only those supported in CSS 2.1, none of the <a
   href="#propdef-font-variant" title="font-variant!!property">‘<code
   class=property>font-variant</code>’</a> values added in this
   specification can be used in the <a class=property
   href="#propdef-font">‘<code class=property>font</code>’</a> shorthand:

  <pre class=prod><dfn
   id=font-variant-css21-values><var>&lt;font-variant-css21&gt;</var></dfn> = [normal | small-caps]</pre>

  <p>The syntax of this property is based on a traditional typographical
   shorthand notation to set multiple properties related to fonts.

  <p>All subproperties of the ‘<a href="#propdef-font"><code
   class=property>font</code></a>’ property are first reset to their
   initial values, including those listed above plus <a class=property
   href="#propdef-font-size-adjust">‘<code
   class=property>font-size-adjust</code>’</a>, <a class=property
   href="#propdef-font-kerning">‘<code
   class=property>font-kerning</code>’</a>, all subproperties of <a
   href="#propdef-font-variant" title="font-variant!!property">‘<code
   class=property>font-variant</code>’</a>, and <span
   class=property>‘<code
   class=property>font-feature-settings</code>’</span>, but <em>not</em> <a
   class=property href="#propdef-font-synthesis">‘<code
   class=property>font-synthesis</code>’</a>. Then, those properties that
   are given explicit values in the <a class=property
   href="#propdef-font">‘<code class=property>font</code>’</a> shorthand
   are set to those values. For a definition of allowed and initial values,
   see the previously defined properties. For reasons of backwards
   compatibility, it is not possible to set <a class=property
   href="#propdef-font-size-adjust">‘<code
   class=property>font-size-adjust</code>’</a> to anything other than its
   initial value using the <a class=property href="#propdef-font">‘<code
   class=property>font</code>’</a> shorthand property; instead, use the
   individual property.

  <div class=example>
   <p style="display:none">Example(s):

   <pre>p { font: 12pt/14pt sans-serif }
p { font: 80% sans-serif }
p { font: x-large/110% &quot;new century schoolbook&quot;, serif }
p { font: bold italic large Palatino, serif }
p { font: normal small-caps 120%/120% fantasy }
p { font: condensed oblique 12pt &quot;Helvetica Neue&quot;, serif; }
</pre>

   <p> In the second rule, the font size percentage value (‘<code
    class=css>80%</code>’) refers to the computed ‘<a
    href="#propdef-font-size"><code class=property>font-size</code></a>’ of
    the parent element. In the third rule, the line height percentage
    (‘<code class=css>110%</code>’) refers to the font size of the
    element itself.

   <p>The first three rules do not specify the <a
    href="#propdef-font-variant" title="font-variant!!property">‘<code
    class=property>font-variant</code>’</a> and <a
    href="#propdef-font-weight" title="font-weight!!property">‘<code
    class=property>font-weight</code>’</a> explicitly, so these properties
    receive their initial values (<span title="normal value">‘<code
    class=property>normal</code>’</span>). Notice that the font family name
    "new century schoolbook", which contains spaces, is enclosed in quotes.
    The fourth rule sets the <a href="#propdef-font-weight"
    title="font-weight!!property">‘<code
    class=property>font-weight</code>’</a> to ‘<a href="#bold"><code
    class=property>bold</code></a>’, the <a href="#propdef-font-style"
    title="font-style!!property">‘<code
    class=property>font-style</code>’</a> to ‘<a href="#italic"><code
    class=property>italic</code></a>’, and implicitly sets <a
    href="#propdef-font-variant" title="font-variant!!property">‘<code
    class=property>font-variant</code>’</a> to <a
    href="#font-variant-normal-value" title="normal!!font-variant">‘<code
    class=property>normal</code>’</a>.

   <p> The fifth rule sets the <a href="#propdef-font-variant"
    title="font-variant!!property">‘<code
    class=property>font-variant</code>’</a> (‘<a href="#small-caps"><code
    class=property>small-caps</code></a>’), the <a class=property
    href="#propdef-font-size">‘<code class=property>font-size</code>’</a>
    (120% of the parent's font size), the <a class=property
    href="https://www.w3.org/TR/CSS2/visudet.html#propdef-line-height">‘<code
    class=property>line-height</code>’</a> (120% of the font size) and the
    <a href="#propdef-font-family" title="font-family!!property">‘<code
    class=property>font-family</code>’</a> (‘<a href="#fantasy"><code
    class=property>fantasy</code></a>’). It follows that the keyword <span
    title="normal value">‘<code class=property>normal</code>’</span>
    applies to the two remaining properties: <a href="#propdef-font-style"
    title="font-style!!property">‘<code
    class=property>font-style</code>’</a> and <a
    href="#propdef-font-weight" title="font-weight!!property">‘<code
    class=property>font-weight</code>’</a>.

   <p>The sixth rule sets the <a href="#propdef-font-style"
    title="font-style!!property">‘<code
    class=property>font-style</code>’</a>, <a href="#propdef-font-stretch"
    title="font-stretch!!property">‘<code
    class=property>font-stretch</code>’</a>, <a class=property
    href="#propdef-font-size">‘<code
    class=property>font-size</code>’</a>, and <a
    href="#propdef-font-family" title="font-family!!property">‘<code
    class=property>font-family</code>’</a>, the other font properties being
    set to their initial values.
  </div>

  <p>Since the <a href="#propdef-font-stretch"
   title="font-stretch!!property">‘<code
   class=property>font-stretch</code>’</a> property was not defined in CSS
   2.1, when using <a href="#propdef-font-stretch"
   title="font-stretch!!property">‘<code
   class=property>font-stretch</code>’</a> values within ‘<a
   href="#propdef-font"><code class=property>font</code></a>’ rules,
   authors should include a extra version compatible with older user agents:

  <pre>p {
  font: 80% sans-serif;   /* for older user agents */
  font: condensed 80% sans-serif;
}</pre>

  <p>The following values refer to system fonts:

  <dl>
   <dt><strong>caption</strong>

   <dd>The font used for captioned controls (e.g., buttons, drop-downs,
    etc.).

   <dt><strong>icon</strong>

   <dd>The font used to label icons.

   <dt><strong>menu</strong>

   <dd>The font used in menus (e.g., dropdown menus and menu lists).

   <dt><strong>message-box</strong>

   <dd>The font used in dialog boxes.

   <dt><strong>small-caption</strong>

   <dd>The font used for labeling small controls.

   <dt><strong>status-bar</strong>

   <dd>The font used in window status bars.
  </dl>

  <p>System fonts may only be set as a whole; that is, the font family, size,
   weight, style, etc. are all set at the same time. These values may then be
   altered individually if desired. If no font with the indicated
   characteristics exists on a given platform, the user agent should either
   intelligently substitute (e.g., a smaller version of the ‘<code
   class=property>caption</code>’ font might be used for the ‘<code
   class=property>small-caption</code>’ font), or substitute a user agent
   default font. As for regular fonts, if, for a system font, any of the
   individual properties are not part of the operating system's available
   user preferences, those properties should be set to their initial values.

  <p>That is why this property is "almost" a shorthand property: system fonts
   can only be specified with this property, not with <a
   href="#propdef-font-family" title="font-family!!property">‘<code
   class=property>font-family</code>’</a> itself, so <a class=property
   href="#propdef-font">‘<code class=property>font</code>’</a> allows
   authors to do more than the sum of its subproperties. However, the
   individual properties such as <a href="#propdef-font-weight"
   title="font-weight!!property">‘<code
   class=property>font-weight</code>’</a> are still given values taken from
   the system font, which can be independently varied.

  <p>Note that the keywords used for the system fonts listed above are only
   treated as keywords when they occur in the initial position, in other
   positions the same string is treated as part of the font family name:

  <pre>  font: menu;        /* use the font settings for system menus */
  font: large menu;  /* use a font family named "menu" */</pre>

  <div class=example>
   <p style="display:none">Example(s):

   <pre>button { font: 300 italic 1.3em/1.7em &quot;FB Armada&quot;, sans-serif }
button p { font: menu }
button p em { font-weight: bolder }
</pre>

   <p>If the font used for dropdown menus on a particular system happened to
    be, for example, 9-point Charcoal, with a weight of 600, then P elements
    that were descendants of BUTTON would be displayed as if this rule were
    in effect:

   <pre>button p { font: 600 9pt Charcoal }
</pre>

   <p>Because the <a class=property href="#propdef-font">‘<code
    class=property>font</code>’</a> shorthand resets to its initial value
    any property not explicitly given a value, this has the same effect as
    this declaration:

   <pre>button p {
  font-style: normal;
  font-variant: normal;
  font-weight: 600;
  font-size: 9pt;
  line-height: normal;
  font-family: Charcoal
}
</pre>
  </div>
  <!-- prop: font-synthesis -->

  <h3 id=font-synthesis-prop><span class=secno>3.8. </span>Controlling
   synthetic faces: the <a href="#propdef-font-synthesis">font-synthesis</a>
   property</h3>

  <table class=propdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=propdef-font-synthesis>font-synthesis</dfn>

    <tr>
     <td>Value:

     <td>none | [ weight || style ]

    <tr>
     <td>Initial:

     <td>weight style

    <tr>
     <td>Applies to:

     <td>all elements

    <tr>
     <td>Inherited:

     <td>yes

    <tr>
     <td>Percentages:

     <td>N/A

    <tr>
     <td>Computed value:

     <td>as specified

    <tr>
     <td>Animatable:

     <td>no
  </table>

  <p>This property controls whether user agents are allowed to synthesize
   bold or oblique font faces when a font family lacks bold or italic faces.
   If ‘<a href="#weight"><code class=property>weight</code></a>’ is not
   specified, user agents must not synthesize bold faces and if ‘<code
   class=property>style</code>’ is not specified user agents must not
   synthesize italic faces. A value of ‘<code class=property>none</code>’
   disallows all synthetic faces.

  <div class=example>
   <p>The style rule below disables the use of synthetically obliqued Arabic:

   <pre>*:lang(ar) { font-synthesis: none; }
</pre>
  </div>

  <h2 id=font-resources><span class=secno>4. </span>Font Resources</h2>

  <h3 id=font-face-rule><span class=secno>4.1. </span>The <dfn
   id=at-font-face-rule
   style="font-weight: inherit; font-style: inherit"><code>@font-face</code></dfn>
   rule</h3>

  <p>The <a href="#at-font-face-rule"><code>@font-face</code></a> rule allows
   for linking to fonts that are automatically fetched and activated when
   needed. This allows authors to select a font that closely matches the
   design goals for a given page rather than limiting the font choice to a
   set of fonts available on a given platform. A set of font descriptors
   define the location of a font resource, either locally or externally,
   along with the style characteristics of an individual face. Multiple <a
   href="#at-font-face-rule"><code>@font-face</code></a> rules can be used to
   construct font families with a variety of faces. Using CSS font matching
   rules, a user agent can selectively download only those faces that are
   needed for a given piece of text.

  <p>The <a href="#at-font-face-rule"><code>@font-face</code></a> rule
   consists of the <a href="#at-font-face-rule"><code>@font-face</code></a>
   at-keyword followed by a block of descriptor declarations. In terms of the
   grammar, this specification defines the following productions:

  <pre><dfn id="font_face_rule">font_face_rule</dfn>
  : <a
   href="#font_face_sym"><i>FONT_FACE_SYM</i></a> <a
   href="https://www.w3.org/TR/CSS21/grammar.html#scanner"><i>S</i></a>* '{' <a
   href="https://www.w3.org/TR/CSS21/grammar.html#scanner"><i>S</i></a>* <a
   href="#descriptor_declaration"><i>descriptor_declaration</i></a>? [ ';' <a
   href="https://www.w3.org/TR/CSS21/grammar.html#scanner"><i>S</i></a>* <a
   href="#descriptor_declaration"><i>descriptor_declaration</i></a>? ]* '}' <a
   href="https://www.w3.org/TR/CSS21/grammar.html#scanner"><i>S</i></a>*
  ;

<dfn
   id="descriptor_declaration">descriptor_declaration</dfn>
  : <a
   href="https://www.w3.org/TR/CSS21/grammar.html#grammar"><i>property</i></a> ':' <a
   href="https://www.w3.org/TR/CSS21/grammar.html#scanner"><i>S</i></a>* <a
   href="https://www.w3.org/TR/CSS21/grammar.html#grammar"><i>expr</i></a>
  ;</pre>

  <p>The following new definitions are introduced:

  <pre>-    -|\\0{0,4}2d(\r\n|[ \t\r\n\f])?
F    f|\\0{0,4}(46|66)(\r\n|[ \t\r\n\f])?</pre>

  <p>The following new token is introduced:

  <pre>@{F}{O}{N}{T}{-}{F}{A}{C}{E} {return <dfn
   id="font_face_sym">FONT_FACE_SYM</dfn>;}</pre>

  <p>Each <a href="#at-font-face-rule"><code>@font-face</code></a> rule
   specifies a value for every font descriptor, either implicitly or
   explicitly. Those not given explicit values in the rule take the initial
   value listed with each descriptor in this specification. These descriptors
   apply solely within the context of the <a
   href="#at-font-face-rule"><code>@font-face</code></a> rule in which they
   are defined, and do not apply to document language elements. There is no
   notion of which elements the descriptors apply to or whether the values
   are inherited by child elements. When a given descriptor occurs multiple
   times in a given <a href="#at-font-face-rule"><code>@font-face</code></a>
   rule, only the last descriptor declaration is used and all prior
   declarations for that descriptor are ignored.

  <div class=example>
   <p>To use a downloadable font called Gentium:

   <pre>
@font-face {
  font-family: Gentium;
  src: url(http://example.com/fonts/Gentium.woff);
}

p { font-family: Gentium, serif; }
</pre>

   <p>The user agent will download Gentium and use it when rendering text
    within paragraph elements. If for some reason the site serving the font
    is unavailable, the default serif font will be used.
  </div>

  <p>A given set of <a href="#at-font-face-rule"><code>@font-face</code></a>
   rules define a set of fonts available for use within the documents that
   contain these rules. When font matching is done, fonts defined using these
   rules are considered before other available fonts on a system.

  <p>Downloaded fonts are only available to documents that reference them.
   The process of activating these fonts must not make them available to
   other applications or to documents that don't directly link to the same
   font. User agent implementers might consider it convenient to use
   downloaded fonts when rendering characters in other documents for which no
   other available font exists as part of the <a
   href="#system-font-fallback"><em>system font fallback</em></a> procedure.
   However, this would cause a security leak since the contents of one page
   would be able to affect other pages, something an attacker could use as an
   attack vector. These restrictions do not affect caching behavior, fonts
   are cached the same way other web resources are cached.

  <p>This at-rule follows the forward-compatible parsing rules of CSS. Like
   properties in a declaration block, declarations of any descriptors that
   are not supported by the user agent must be ignored. <a
   href="#at-font-face-rule"><code>@font-face</code></a> rules require a
   font-family and src descriptor; if either of these are missing, the <a
   href="#at-font-face-rule"><code>@font-face</code></a> rule must not be
   considered when performing the <a href="#font-matching-algorithm">font
   matching algorithm</a>.

  <p>In cases where user agents have limited platform resources or implement
   the ability to disable downloadable font resources, <a
   href="#at-font-face-rule"><code>@font-face</code></a> rules must simply be
   ignored; the behavior of individual descriptors as defined in this
   specification should not be altered.

  <h3 id=font-family-desc><span class=secno>4.2. </span>Font family: the <a
   href="#descdef-font-family">font-family</a> descriptor</h3>

  <table class=descdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=descdef-font-family
      title="font-family!!descriptor">font-family</dfn>

    <tr>
     <td>Value:

     <td><a href="#family-name-value"><var>&lt;family-name&gt;</var></a>

    <tr>
     <td><em>Initial:</em>

     <td>N/A
  </table>

  <p>This descriptor defines the font family name that will be used in all
   CSS font family name matching. It is required for the <a
   href="#at-font-face-rule"><code>@font-face</code></a> rule to be valid. It
   overrides the font family names contained in the underlying font data. If
   the font family name is the same as a font family available in a given
   user's environment, it effectively hides the underlying font for documents
   that use the stylesheet. This permits a web author to freely choose
   font-family names without worrying about conflicts with font family names
   present in a given user's environment. Likewise, platform substitutions
   for a given font family name must not be used.

  <h3 id=src-desc><span class=secno>4.3. </span>Font reference: the <a
   href="#descdef-src">src</a> descriptor</h3>

  <table class=descdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=descdef-src>src</dfn>

    <tr>
     <td>Value:

     <td>[ &lt;url> [format(&lt;string> #)]? | <a
      href="#font-face-name-value"><var>&lt;font-face-name&gt;</var></a> ] #

    <tr>
     <td><em>Initial:</em>

     <td>N/A
  </table>

  <p>This descriptor specifies the resource containing font data. It is
   required for the <a href="#at-font-face-rule"><code>@font-face</code></a>
   rule to be valid. Its value is a prioritized, comma-separated list of
   external references or locally-installed font face names. When a font is
   needed the user agent iterates over the set of references listed, using
   the first one it can successfully activate. Fonts containing invalid data
   or local font faces that are not found are ignored and the user agent
   loads the next font in the list.

  <p>As with other URLs in CSS, the URL may be relative, in which case it is
   resolved relative to the location of the style sheet containing the <a
   href="#at-font-face-rule"><code>@font-face</code></a> rule. In the case of
   SVG fonts, the URL points to an element within a document containing SVG
   font definitions. If the element reference is omitted, a reference to the
   first defined font is implied. Similarly, font container formats that can
   contain more than one font must load one and only one of the fonts for a
   given <a href="#at-font-face-rule"><code>@font-face</code></a> rule.
   Fragment identifiers are used to indicate which font to load; these use
   the PostScript name of the font as defined in <a href="#ref-RFC8081"
    >[RFC8081]</a>. Conformant
   user agents must skip downloading a font resource if the fragment
   identifier is unknown or unsupported. For example, older user agents which
   do not support OpenType collections will skip to the next url in the list.

  <pre>
src: url(fonts/simple.woff);       /* load simple.woff relative to stylesheet location */
src: url(/fonts/simple.woff);      /* load simple.woff from absolute location */
src: url(fonts/coll.otc#foo);      /* load font foo from collection coll.otc
src: url(fonts/coll.woff2#foo);    /* load font foo from woff2 collection coll.woff2
src: url(fonts.svg#simple);        /* load SVG font with id 'simple' */
</pre>

  <p>External references consist of a URL, followed by an optional hint
   describing the format of the font resource referenced by that URL. The
   format hint contains a comma-separated list of format strings that denote
   well-known font formats. Conformant user agents must skip downloading a
   font resource if the format hints indicate only unsupported or unknown
   font formats. If no format hints are supplied, the user agent should
   download the font resource.

  <pre>
/* load WOFF2 font if possible, otherwise WOFF, else use OpenType font */
@font-face {
  font-family: bodytext;
  src: url(ideal-sans-serif.woff2) format("woff2"),
       url(good-sans-serif.woff) format("woff"),
       url(basic-sans-serif.ttf) format("opentype");
}
</pre>

  <p>Format strings defined by this specification:

  <table class=data id=fontformats>
   <thead>
    <tr>
     <th>String

     <th>Font Format

     <th>Common extensions

   <tbody>
    <tr>
     <th><code>"woff"</code>

     <td><a href="https://www.w3.org/TR/WOFF/">WOFF 1.0 (Web Open Font
      Format)</a>

     <td>.woff

    <tr>
     <th><code>"woff2"</code>

     <td><a href="https://www.w3.org/TR/WOFF2/">WOFF 2.0 (Web Open Font
      Format)</a>

     <td>.woff2

    <tr>
     <th><code>"truetype"</code>

     <td><a
      href="https://docs.microsoft.com/en-us/typography/opentype/spec/">TrueType</a>

     <td>.ttf

    <tr>
     <th><code>"opentype"</code>

     <td><a
      href="https://docs.microsoft.com/en-us/typography/opentype/spec/">OpenType</a>

     <td>.ttf, .otf

    <tr>
     <th><code>"embedded-opentype"</code>

     <td><a
      href="https://www.w3.org/Submission/2008/SUBM-EOT-20080305/">Embedded
      OpenType</a>

     <td>.eot

    <tr>
     <th><code>"svg"</code>

     <td><a href="https://www.w3.org/TR/SVG11/fonts.html">SVG Font</a>

     <td>.svg, .svgz
  </table>

  <p>Given the overlap in common usage between TrueType and OpenType <a
   href="#ref-OPENTYPE"  >[OPENTYPE]<!--{{!OPENTYPE}}--></a>,
   the format hints <code>"truetype"</code> and <code>"opentype"</code> must
   be considered as synonymous; a format hint of <code>"opentype"</code> does
   not imply that the font contains Postscript CFF style glyph data or that
   it contains OpenType layout information (see <a
   href="#platform-props-to-css">Appendix A</a> for more background on this).

  <p>When authors would prefer to use a locally available copy of a given
   font and download it if it's not, <code>local()</code> can be used. The
   locally-installed <dfn
   id=font-face-name-value><var>&lt;font-face-name&gt;</var></dfn> argument
   to <code>local()</code> is a format-specific string that uniquely
   identifies a single font face within a larger family. The syntax for a <a
   href="#font-face-name-value"><var>&lt;font-face-name&gt;</var></a> is a
   unique font face name enclosed by <code>"local("</code> and
   <code>")"</code>. The name can optionally be enclosed in quotes. If
   unquoted, the unquoted font family name processing conventions apply; the
   name must be a sequence of identifiers separated by <a
   href="https://www.w3.org/TR/css3-syntax/#whitespace">whitespace</a> which
   is converted to a string by joining the identifiers together separated by
   a single space.

  <pre>
/* regular face of Gentium */
@font-face {
  font-family: MyGentium;
  src: local(Gentium),    /* use locally available Gentium */
       url(Gentium.woff); /* otherwise, download it */
}
</pre>

  <p>For OpenType and TrueType fonts, this string is used to match only the
   Postscript name or the full font name in the name table of locally
   available fonts. Which type of name is used varies by platform and font,
   so authors should include both of these names to assure proper matching
   across platforms. Platform substitutions for a given font name must not be
   used.

  <pre>
/* bold face of Gentium */
@font-face {
  font-family: MyGentium;
  src: local(Gentium Bold),    /* full font name */
       local(Gentium-Bold),    /* Postscript name */
       url(GentiumBold.woff);  /* otherwise, download it */
  font-weight: bold;
}
</pre>

  <p>Just as a <a href="#at-font-face-rule"><code>@font-face</code></a> rule
   specifies the characteristics of a single font within a family, the unique
   name used with <code>local()</code> specifies a single font, not an entire
   font family. Defined in terms of OpenType font data, the Postscript name
   is found in the font's <a
   href="https://docs.microsoft.com/en-us/typography/opentype/spec/name">name
   table</a>, in the name record with <code>nameID = 6</code> (see <a
   href="#ref-OPENTYPE"  >[OPENTYPE]<!--{{!OPENTYPE}}--></a>
   for more details). The Postscript name is the commonly used key for all
   fonts on OSX and for Postscript CFF fonts under Windows. The full font
   name (<code>nameID = 4</code>) is used as a unique key for fonts with
   TrueType glyphs on Windows.

  <p>For OpenType fonts with multiple localizations of the full font name,
   the US English version is used (<code>language ID = 0x409</code> for
   Windows and <code>language ID = 0</code> for Macintosh) or the first
   localization when a US English full font name is not available (the
   OpenType specification recommends that <a
   href="https://docs.microsoft.com/en-us/typography/opentype/spec/recom">all
   fonts minimally include US English names</a>). User agents that also match
   other full font names, e.g. matching the Dutch name when the current
   system locale is set to Dutch, are considered non-conformant. This is done
   not to prefer English but to avoid matching inconsistencies across font
   versions and OS localizations, since font style names (e.g. "Bold") are
   frequently localized into many languages and the set of localizations
   available varies widely across platform and font version. User agents that
   match a concatenation of family name (<code>nameID = 1</code>) with style
   name (<code>nameID = 2</code>) are considered non-conformant.

  <p>This also allows for referencing faces that belong to larger families
   that cannot otherwise be referenced.

  <div class=example>
   <p>Use a local font or reference an SVG font in another document:

   <pre>
@font-face {
  font-family: Headline;
  src: local(Futura-Medium),
       url(fonts.svg#MyGeometricModern) format("svg");
}
</pre>

   <p>Create an alias for local Japanese fonts on different platforms:

   <pre>
@font-face {
  font-family: jpgothic;
  src: local(HiraKakuPro-W3), local(Meiryo), local(IPAPGothic);
}
</pre>

   <p>Reference a font face that cannot be matched within a larger family:

   <pre>
@font-face {
  font-family: Hoefler Text Ornaments;
  /* has the same font properties as Hoefler Text Regular */
  src: local(HoeflerText-Ornaments);
}
</pre>

   <p>Since localized fullnames never match, a document with the header style
    rules below would always render using the default serif font, regardless
    whether a particular system locale parameter is set to Finnish or not:

   <pre>
@font-face {
  font-family: SectionHeader;
  src: local("Arial Lihavoitu");  /* Finnish fullname for Arial Bold, should fail */
  font-weight: bold;
}

h2 { font-family: SectionHeader, serif; }
</pre>

   <p>A conformant user agent would never load the font ‘<code
    class=css>gentium.eot</code>’ in the example below, since it is
    included in the first definition of the ‘<a href="#descdef-src"><code
    class=property>src</code></a>’ descriptor which is overridden by the
    second definition in the same <a
    href="#at-font-face-rule"><code>@font-face</code></a> rule:

   <pre>
@font-face {
  font-family: MainText;
  src: url(gentium.eot);                     /* for use with older user agents */
  src: local("Gentium"), url(gentium.woff);  /* Overrides src definition */
}
</pre>
  </div>

  <h3 id=font-prop-desc><span class=secno>4.4. </span>Font property
   descriptors: the <a href="#descdef-font-style">font-style</a>, <a
   href="#descdef-font-weight">font-weight</a>, <a
   href="#descdef-font-stretch">font-stretch</a> descriptors</h3>

  <table class=descdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=descdef-font-style
      title="font-style!!descriptor">font-style</dfn>

    <tr>
     <td>Value:

     <td>normal | italic | oblique

    <tr>
     <td><em>Initial:</em>

     <td>normal
  </table>

  <table class=descdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=descdef-font-weight
      title="font-weight!!descriptor">font-weight</dfn>

    <tr>
     <td>Value:

     <td>normal | bold | 100 | 200 | 300 | 400 | 500 | 600 | 700 | 800 | 900

    <tr>
     <td><em>Initial:</em>

     <td>normal
  </table>

  <table class=descdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=descdef-font-stretch
      title="font-stretch!!descriptor">font-stretch</dfn>

    <tr>
     <td>Value:

     <td>normal | ultra-condensed | extra-condensed | condensed |
      semi-condensed | semi-expanded | expanded | extra-expanded |
      ultra-expanded

    <tr>
     <td><em>Initial:</em>

     <td>normal
  </table>

  <p>These descriptors define the characteristics of a font face and are used
   in the process of matching styles to specific faces. For a font family
   defined with several <a
   href="#at-font-face-rule"><code>@font-face</code></a> rules, user agents
   can either download all faces in the family or use these descriptors to
   selectively download font faces that match actual styles used in document.
   The values for these descriptors are the same as those for the
   corresponding font properties except that relative keywords are not
   allowed, ‘<a href="#bolder"><code class=property>bolder</code></a>’
   and ‘<a href="#lighter"><code class=property>lighter</code></a>’. If
   these descriptors are omitted, initial values are assumed.

  <p>The value for these font face style attributes is used in place of the
   style implied by the underlying font data. This allows authors to combine
   faces in flexible combinations, even in situations where the original font
   data was arranged differently. User agents that implement synthetic
   bolding and obliquing must only apply synthetic styling in cases where the
   font descriptors imply this is needed, rather than based on the style
   attributes implied by the font data.

  <div class=example>
   <p>The font descriptors defined in this section are used for selecting a
    font from within the set of fonts defined by <a
    href="#at-font-face-rule"><code>@font-face</code></a> rules for a given
    family.

   <p>Consider a family containing a single, regular face:

   <pre>
@font-face {
  font-family: BaskervilleSimple;
  src: url(baskerville-regular.woff);
}
</pre>

   <p>Unstyled text would display using the regular face defined in the <a
    href="#at-font-face-rule"><code>@font-face</code></a> rule:

   <div class=figure><img alt="regular face display"
    src=fiddlesticks-regular.png width=373></div>

   <p>However, italic text would display in most user agents using
    synthetically obliqued glyphs from the regular face, since a separate
    italic face is not defined:

   <div class=figure><img alt="synthetic italics display"
    src=fiddlesticks-synitalics.png width=373></div>

   <p>Now consider a family for which an actual italic face is defined:

   <pre>
@font-face {
  font-family: BaskervilleFull;
  src: url(baskerville-regular.woff);
}

@font-face {
  font-family: BaskervilleFull;
  src: url(baskerville-italic.woff);
  font-style: italic;
}
</pre>

   <p>The second <a href="#at-font-face-rule"><code>@font-face</code></a>
    rule defines the font resource <code>baskerville-italic.woff</code> to
    have style attributes of normal weight, normal stretch and italic style.
    When displaying italic text, the user agent will use this font, since
    it's the closest match for italic text. Thus, the text will display using
    glyphs designed by a type designer rather than using synthetically
    obliqued glyphs from the regular face:

   <div class=figure><img alt="real italics display"
    src=fiddlesticks-italics.png width=373></div>

   <p>See the section on <a href="#font-style-matching">font matching</a> for
    more complete details of the process used to select a particular face
    within a font family.
  </div>

  <h3 id=unicode-range-desc><span class=secno>4.5. </span>Character range:
   the <a href="#descdef-unicode-range">unicode-range</a> descriptor</h3>

  <table class=descdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=descdef-unicode-range>unicode-range</dfn>

    <tr>
     <td>Value:

     <td><a href="#urange-value"><var>&lt;urange&gt;</var></a> #

    <tr>
     <td><em>Initial:</em>

     <td>U+0-10FFFF
  </table>

  <p>This descriptor defines the set of Unicode <a href="#ref-UNICODE"
    >[UNICODE]<!--{{!UNICODE}}--></a> codepoints that may be
   supported by the font face for which it is declared. The descriptor value
   is a comma-delimited list of Unicode range (<a
   href="#urange-value"><var>&lt;urange&gt;</var></a>) values. The union of
   these ranges defines the set of codepoints that serves as a hint for user
   agents when deciding whether or not to download a font resource for a
   given text run.

  <p>Each <dfn data-dfn-for=unicode-range data-dfn-type=value
   id=urange-value><var>&lt;urange&gt;</var></dfn> value is a <a
   href="https://www.w3.org/TR/CSS21/syndata.html#tokenization"><code
   title="UNICODE-RANGE token">UNICODE-RANGE</code></a> token made up of a
   "U+" or "u+" prefix followed by a codepoint range in one of the three
   forms listed below. Ranges that do not fit one of the these forms are
   invalid and cause the declaration to be ignored.

  <dl>
   <dt>single codepoint (e.g. U+416)

   <dd>a Unicode codepoint, represented as one to six hexadecimal digits

   <dt>interval range (e.g. U+400-4ff)

   <dd>represented as two hyphen-separated Unicode codepoints indicating the
    inclusive start and end codepoints of a range

   <dt>wildcard range (e.g. U+4??)

   <dd>defined by the set of codepoints implied when trailing ‘<code
    class=css>?</code>’ characters signify any hexadeximal digit
  </dl>

  <p>Individual codepoints are written using hexadecimal values that
   correspond to <a href="https://www.unicode.org/charts/">Unicode character
   codepoints</a> <a href="#ref-UNICODE"
    >[UNICODE]<!--{{!UNICODE}}--></a>. Unicode codepoint values
   must be between 0 and 10FFFF inclusive. Digit values of codepoints are
   ASCII case-insensitive. For interval ranges, the start and end codepoints
   must be within the range noted above and the end codepoint must be greater
   than or equal to the start codepoint.

  <p>Wildcard ranges specified with ‘?’ that lack an initial digit (e.g.
   "U+???") are valid and equivalent to a wildcard range with an initial zero
   digit (e.g. "U+0???" = "U+0000-0FFF"). Wildcard ranges that extend beyond
   the range of Unicode codepoints are invalid. Because of this, the maximum
   number of trailing ‘<code class=css>?</code>’ wildcard characters is
   five, even though the <a
   href="https://www.w3.org/TR/CSS21/syndata.html#tokenization"><code
   title="UNICODE-RANGE token">UNICODE-RANGE</code></a> token accepts six.

  <p>Within the comma-delimited list of Unicode ranges in a ‘<a
   href="#descdef-unicode-range"><code
   class=property>unicode-range</code></a>’ descriptor declaration, ranges
   may overlap. The union of these ranges defines the set of codepoints for
   which the corresponding font may be used. User agents must not download or
   use the font for codepoints outside this set. User agents may normalize
   the list of ranges into a list that is different but represents the same
   set of codepoints.

  <p>The associated font might not contain glyphs for the entire set of
   codepoints defined by the ‘<a href="#descdef-unicode-range"><code
   class=property>unicode-range</code></a>’ descriptor. When the font is
   used, the <dfn id=effective-character-map>effective character map</dfn> is
   the intersection of the codepoints defined by ‘<a
   href="#descdef-unicode-range"><code
   class=property>unicode-range</code></a>’ with the font's <a
   href="#character-map"><em>character map</em></a>. This allows authors to
   define supported ranges in terms of broad ranges without worrying about
   the precise codepoint ranges supported by the underlying font.

  <h3 id=composite-fonts><span class=secno>4.6. </span>Using character ranges
   to define composite fonts</h3>

  <p>Multiple <a href="#at-font-face-rule"><code>@font-face</code></a> rules
   with different unicode ranges for the same family and style descriptor
   values can be used to create composite fonts that mix the glyphs from
   different fonts for different scripts. This can be used to combine fonts
   that only contain glyphs for a single script (e.g. Latin, Greek, Cyrillic)
   or it can be used by authors as a way of segmenting a font into fonts for
   commonly used characters and less frequently used characters. Since the
   user agent will only pull down the fonts it needs this helps reduce page
   bandwidth.

  <p>If the unicode ranges overlap for a set of <a
   href="#at-font-face-rule"><code>@font-face</code></a> rules with the same
   family and style descriptor values, the rules are ordered in the reverse
   order they were defined; the last rule defined is the first to be checked
   for a given character.

  <p>Example ranges for specific languages or characters:

  <dl>
   <dt>unicode-range: U+A5;

   <dd>a single code point, the yen/yuan symbol

   <dt>unicode-range: U+0-7F;

   <dd>code range for basic ASCII characters

   <dt>unicode-range: U+590-5ff;

   <dd>code range for Hebrew characters

   <dt>unicode-range: U+A5, U+4E00-9FFF, U+30??, U+FF00-FF9F;

   <dd>code range for Japanese kanji, hiragana and katakana characters plus
    yen/yuan symbol
  </dl>

  <div class=example>
   <p>The BBC provides news services in a wide variety of languages, many
    that are not well supported across all platforms. Using an <a
    href="#at-font-face-rule"><code>@font-face</code></a> rule, the BBC could
    provide a font for any of these languages, as it already does via a
    manual font download.

   <pre>
@font-face {
  font-family: BBCBengali;
  src: url(fonts/BBCBengali.woff) format("woff");
  unicode-range: U+00-FF, U+980-9FF;
}
</pre>
  </div>

  <div class=example>
   <p>Technical documents often require a wide range of symbols. The STIX
    Fonts project is one project aimed at providing fonts to support a wide
    range of technical typesetting in a standardized way. The example below
    shows the use of a font that provides glyphs for many of the mathematical
    and technical symbol ranges within Unicode:

   <pre>
@font-face {
  font-family: STIXGeneral;
  src: local(STIXGeneral), url(/stixfonts/STIXGeneral.otf);
  unicode-range: U+000-49F, U+2000-27FF, U+2900-2BFF, U+1D400-1D7FF;
}
</pre>
  </div>

  <div class=example>
   <p>This example shows how an author can override the glyphs used for Latin
    characters in a Japanese font with glyphs from a different font. The
    first rule specifies no range so it defaults to the entire range. The
    range specified in the second rule overlaps but takes precedence because
    it is defined later.

   <pre>
@font-face {
  font-family: JapaneseWithGentium;
  src: local(MSMincho);
  /* no range specified, defaults to entire range */
}

@font-face {
  font-family: JapaneseWithGentium;
  src: url(../fonts/Gentium.woff);
  unicode-range: U+0-2FF;
}
</pre>
  </div>

  <div class=example>
   <p>Consider a family constructed to optimize bandwidth by separating out
    Latin, Japanese and other characters into different font files:

   <pre>
/* fallback font - size: 4.5MB */
@font-face {
  font-family: DroidSans;
  src: url(DroidSansFallback.woff);
  /* no range specified, defaults to entire range */
}

/* Japanese glyphs - size: 1.2MB */
@font-face {
  font-family: DroidSans;
  src: url(DroidSansJapanese.woff);
  unicode-range: U+3000-9FFF, U+ff??;
}

/* Latin, Greek, Cyrillic along with some
   punctuation and symbols - size: 190KB */
@font-face {
  font-family: DroidSans;
  src: url(DroidSans.woff);
  unicode-range: U+000-5FF, U+1e00-1fff, U+2000-2300;
}
</pre>

   <p>For simple Latin text, only the font for Latin characters is
    downloaded:

   <pre>
body { font-family: DroidSans; }

&lt;p>This is that&lt;/p>
</pre>

   <p>In this case the user agent first checks the unicode-range for the font
    containing Latin characters (DroidSans.woff). Since all the characters
    above are in the range U+0-5FF, the user agent downloads the font and
    renders the text with that font.

   <p>Next, consider text that makes use of an arrow character (⇨):

   <pre>
&lt;p>This &amp;#x21e8; that&lt;p>
</pre>

   <p>The user agent again first checks the unicode-range of the font
    containing Latin characters. Since U+2000-2300 includes the arrow code
    point (U+21E8), the user agent downloads the font. For this character
    however the Latin font does not have a matching glyph, so the effective
    unicode-range used for font matching excludes this code point. Next, the
    user agent evaluates the Japanese font. The unicode-range for the
    Japanese font, U+3000-9FFF and U+ff??, does not include U+21E8, so the
    user agent does not download the Japanese font. Next the fallback font is
    considered. The <a href="#at-font-face-rule"><code>@font-face</code></a>
    rule for the fallback font does not define unicode-range so its value
    defaults to the range of all Unicode code points. The fallback font is
    downloaded and used to render the arrow character.
  </div>

  <h3 id=font-rend-desc><span class=secno>4.7. </span>Font features: the <a
   href="#descdef-font-feature-settings">font-feature-settings</a> descriptor</h3>

  <table class=descdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=descdef-font-feature-settings
      title="font-feature-settings!!descriptor">font-feature-settings</dfn>

    <tr>
     <td>Value:

     <td><a href="#font-feature-settings-normal-value"
      title="normal!!font-feature-settings">normal</a> | <a
      href="#feature-tag-value"><var>&lt;feature-tag-value&gt;</var></a> #

    <tr>
     <td><em>Initial:</em>

     <td>normal
  </table>

  <p>This descriptor defines initial settings that apply when the font
   defined by an <a href="#at-font-face-rule"><code>@font-face</code></a>
   rule is rendered. It does not affect font selection. Values are identical
   to those defined for the corresponding <a
   href="#propdef-font-feature-settings"
   title="font-feature-settings!!property">‘<code
   class=property>font-feature-settings</code>’</a> property defined below
   except that the value ‘<code class=property>inherit</code>’ is
   omitted. When multiple font feature descriptors or properties are used,
   the cumulative effect on text rendering is detailed in the section <a
   href="#font-feature-resolution">Font Feature Resolution</a> below.

  <h3 id=font-face-loading><span class=secno>4.8. </span>Font loading
   guidelines</h3>

  <p>The <a href="#at-font-face-rule"><code>@font-face</code></a> rule is
   designed to allow lazy loading of font resources that are only downloaded
   when used within a document. A stylesheet can include <a
   href="#at-font-face-rule"><code>@font-face</code></a> rules for a library
   of fonts of which only a select set are used; user agents must only
   download those fonts that are referred to within the style rules
   applicable to a given page. User agents that download all fonts defined in
   <a href="#at-font-face-rule"><code>@font-face</code></a> rules without
   considering whether those fonts are in fact used within a page are
   considered non-conformant. In cases where a font might be downloaded in
   character fallback cases, user agents may download a font if it's
   contained within the computed value of <a href="#propdef-font-family"
   title="font-family!!property">‘<code
   class=property>font-family</code>’</a> for a given text run.

  <pre>
@font-face {
  font-family: GeometricModern;
  src: url(font.woff);
}

p {
  /* font will be downloaded for pages with p elements */
  font-family: GeometricModern, sans-serif;
}

h2 {
  /* font may be downloaded for pages with h2 elements, even if Futura is available locally */
  font-family: Futura, GeometricModern, sans-serif;
}
</pre>

  <p>In cases where textual content is loaded before downloadable fonts are
   available, user agents may render text as it would be rendered if
   downloadable font resources are not available or they may render text
   transparently with fallback fonts to avoid a flash of text using a
   fallback font. In cases where the font download fails user agents must
   display text, simply leaving transparent text is considered non-conformant
   behavior. Authors are advised to use fallback fonts in their font lists
   that closely match the metrics of the downloadable fonts to avoid large
   page reflows where possible.

  <p><a id=same-origin-restriction> </a><a
   id=allowing-cross-origin-font-loading> </a>

  <h3 id=font-fetching-requirements><span class=secno>4.9. </span>Font
   fetching requirements</h3>
  <!-- TPAC 2011 Resolution to require same-origin restriction for loading fonts:
  http://lists.w3.org/Archives/Public/www-style/2011Nov/0711.html
  http://www.w3.org/2011/10/31-webapps-minutes.html#item02
-->

  <p>For font loads, user agents must use the <a
   href="https://fetch.spec.whatwg.org/#http-cors-protocol"> potentially
   CORS-enabled fetch method</a> defined by the <a href="#ref-FETCH">[FETCH]</a> specification for
   URL's defined within @font-face rules. When fetching, user agents must use
   "Anonymous" mode, set the referrer source to the stylesheet's URL and set
   the origin to the URL of the containing document.

  <p class=note>The implications of this for authors are that fonts will
   typically not be loaded cross-origin unless authors specifically takes
   steps to permit cross-origin loads. Sites can explicitly allow cross-site
   loading of font data using the <code>Access-Control-Allow-Origin</code>
   HTTP header. For other schemes, no explicit mechanism to allow
   cross-origin loading, beyond what is permitted by the potentially
   CORS-enabled fetch method, is defined or required.

  <div class=example> For the examples given below, assume that a document is
   located at <code>https://example.com/page.html</code> and all URL's link
   to valid font resources supported by the user agent. Fonts defined with
   the ‘<a href="#descdef-src"><code class=property>src</code></a>’
   descriptor values below will be loaded:
   <pre>/* same origin (i.e. domain, scheme, port match document) */
src: url(fonts/simple.woff);

/* data url's with no redirects are treated as same origin */
src: url("data:application/font-woff;base64,...");

/* cross origin, different domain */
/* Access-Control-Allow-Origin response header set to '*' */
src: url(http://another.example.com/fonts/simple.woff);
</pre>
   Fonts defined with the ‘<a href="#descdef-src"><code
   class=property>src</code></a>’ descriptor values below will fail to
   load:
   <pre>/* cross origin, different scheme */
/* no Access-Control-xxx headers in response */
src: url(https://example.com/fonts/simple.woff);

/* cross origin, different domain */
/* no Access-Control-xxx headers in response */
src: url(http://another.example.com/fonts/simple.woff);
</pre>
  </div>

  <h2 id=font-matching-algorithm><span class=secno>5. </span>Font Matching
   Algorithm</h2>

  <p>The algorithm below describes how fonts are associated with individual
   runs of text. For each character in the run a font family is chosen and a
   particular font face is selected containing a glyph for that character.

  <h3 id=font-family-casing><span class=secno>5.1. </span>Case sensitivity of
   font family names</h3>

  <p>As part of the font matching algorithm outlined below, user agents must
   match font family names used in style rules with actual font family names
   contained in fonts available in a given environment or with font family
   names defined in <a href="#at-font-face-rule"><code>@font-face</code></a>
   rules. User agents must match these names case insensitively, using the
   "Default Caseless Matching" algorithm outlined in the Unicode
   specification <a href="#ref-UNICODE"
    >[UNICODE]<!--{{!UNICODE}}--></a>. This algorithm is
   detailed in section 3.13 entitled "Default Case Algorithms". Specifically,
   the algorithm must be applied without normalizing the strings involved and
   without applying any language-specific tailorings. The case folding method
   specified by this algorithm uses the case mappings with status field
   ‘<code class=property>C</code>’ or ‘<code class=property>F</code>’
   in the CaseFolding.txt file of the Unicode Character Database <a
   href="#ref-UNICODE"  >[UNICODE]<!--{{!UNICODE}}--></a>.

  <p class=note> For authors this means that font family names are matched
   case insensitively, whether those names exist in a platform font or in the
   <a href="#at-font-face-rule"><code>@font-face</code></a> rules contained
   in a stylesheet. Authors should take care to ensure that names use a
   character sequence consistent with the actual font family name,
   particularly when using combining characters such as diacritical marks.
   For example, a family name that contains a lowercase a (U+0061) followed
   by a combining ring (U+030A) will <strong>not</strong> match a name that
   looks identical but which uses the precomposed lowercase a-ring character
   (U+00E5) instead of the combining sequence.

  <p class=note> Implementors should take care to verify that a given
   caseless string comparison implementation uses this precise algorithm and
   not assume that a given platform string matching routine follows it, as
   many of these have locale-specific behavior or use some level of string
   normalization <a href="#ref-UAX15"
    >[UAX15]<!--{{!UAX15}}--></a>.

  <h3 id=font-style-matching><span class=secno>5.2. </span>Matching font
   styles</h3>

  <p>The procedure for choosing a font for a given character in a run of text
   consists of iterating over the font families named by the <a
   href="#propdef-font-family" title="font-family!!property">‘<code
   class=property>font-family</code>’</a> property, selecting a font face
   with the appropriate style based on other font properties and then
   determining whether a glyph exists for the given character. This is done
   using the <dfn id=character-map>character map</dfn> of the font, data
   which maps characters to the default glyph for that character. A font is
   considered to <dfn id=support>support</dfn> a given character if (1) the
   character is contained in the font's <a
   href="#character-map"><em>character map</em></a> and (2) if required by
   the containing script, shaping information is available for that
   character.

  <p>Some legacy fonts may include a given character in the <a
   href="#character-map"><em>character map</em></a> but lack the shaping
   information (e.g. <a
   href="https://www.microsoft.com/typography/otspec/ttochap1.htm">OpenType
   layout tables</a> or <a
   href="https://scripts.sil.org/cms/scripts/page.php?site_id=projects&amp;item_id=graphite_techAbout">Graphite
   tables</a>) necessary for correctly rendering text runs containing that
   character.

  <p>Codepoint sequences consisting of a base character followed by a
   sequence of combining characters are treated slightly differently, see the
   section on <a href="#cluster-matching">cluster matching</a> below.

  <p>For this procedure, the <dfn id=default-face>default face</dfn> for a
   given font family is defined to be the face that would be selected if all
   font style properties were set to their initial value.

  <ol id=fontmatchingalg>
   <li>Using the computed font property values for a given element, the user
    agent starts with the first family name specified by the <a
    href="#propdef-font-family" title="font-family!!property">‘<code
    class=property>font-family</code>’</a> property.

   <li>If the family name is a generic family keyword, the user agent looks
    up the appropriate font family name to be used. User agents may choose
    the generic font family to use based on the language of the containing
    element or the Unicode range of the character.

   <li>For other family names, the user agent attempts to find the family
    name among fonts defined via <a
    href="#at-font-face-rule"><code>@font-face</code></a> rules and then
    among available system fonts, matching names with a <a
    href="#font-family-casing">case-insensitive comparison</a> as outlined in
    the section above. On systems containing fonts with multiple localized
    font family names, user agents must match any of these names independent
    of the underlying system locale or platform API used. If the font
    resources defined for a given face in an <a
    href="#at-font-face-rule"><code>@font-face</code></a> rule are either not
    available or contain invalid font data, then the face should be treated
    as not present in the family. If no faces are present for a family
    defined via <a href="#at-font-face-rule"><code>@font-face</code></a>
    rules, the family should be treated as missing; matching a platform font
    with the same name must not occur in this case.

   <li>If a font family match occurs, the user agent assembles the set of
    font faces in that family and then narrows the set to a single face using
    other font properties in the order given below. A group of faces defined
    via <a href="#at-font-face-rule"><code>@font-face</code></a> rules with
    identical font descriptor values but differing ‘<a
    href="#descdef-unicode-range"><code
    class=property>unicode-range</code></a>’ values are considered to be a
    single <dfn id=composite-face>composite face</dfn> for this step:
    <ol id=fontstylematchingalg>
     <li><a href="#propdef-font-stretch"
      title="font-stretch!!property">‘<code
      class=property>font-stretch</code>’</a> is tried first. If the
      matching set contains faces with width values matching the <a
      href="#propdef-font-stretch" title="font-stretch!!property">‘<code
      class=property>font-stretch</code>’</a> value, faces with other width
      values are removed from the matching set. If there is no face that
      exactly matches the width value the nearest width is used instead. If
      the value of <a href="#propdef-font-stretch"
      title="font-stretch!!property">‘<code
      class=property>font-stretch</code>’</a> is <a
      href="#font-stretch-normal-value" title="normal!!font-stretch">‘<code
      class=property>normal</code>’</a> or one of the condensed values,
      narrower width values are checked first, then wider values. If the
      value of <a href="#propdef-font-stretch"
      title="font-stretch!!property">‘<code
      class=property>font-stretch</code>’</a> is one of the expanded
      values, wider values are checked first, followed by narrower values.
      Once the closest matching width has been determined by this process,
      faces with other widths are removed from the matching set.

     <li><a href="#propdef-font-style" title="font-style!!property">‘<code
      class=property>font-style</code>’</a> is tried next. If the value of
      <a href="#propdef-font-style" title="font-style!!property">‘<code
      class=property>font-style</code>’</a> is ‘<a href="#italic"><code
      class=property>italic</code></a>’, italic faces are checked first,
      then oblique, then normal faces. If the value is ‘<a
      href="#oblique"><code class=property>oblique</code></a>’, oblique
      faces are checked first, then italic faces and then normal faces. If
      the value is <a href="#font-style-normal-value"
      title="normal!!font-style">‘<code
      class=property>normal</code>’</a>, normal faces are checked first,
      then oblique faces, then italic faces. Faces with other style values
      are excluded from the matching set. User agents are permitted to
      distinguish between italic and oblique faces within platform font
      families but this is not required, so all italic or oblique faces may
      be treated as italic faces. However, within font families defined via
      <a href="#at-font-face-rule"><code>@font-face</code></a> rules, italic
      and oblique faces must be distinguished using the value of the <a
      href="#descdef-font-style" title="font-style!!descriptor">‘<code
      class=property>font-style</code>’</a> descriptor. For families that
      lack any italic or oblique faces, user agents may create artificial
      oblique faces, if this is permitted by the value of the ‘<a
      href="#propdef-font-synthesis"><code
      class=property>font-synthesis</code></a>’ property.

     <li><a href="#propdef-font-weight"
      title="font-weight!!property">‘<code
      class=property>font-weight</code>’</a> is matched next, so it will
      always reduce the matching set to a single font face. If bolder/lighter
      relative weights are used, the effective weight is calculated based on
      the inherited weight value, as described in the definition of the <a
      href="#propdef-font-weight" title="font-weight!!property">‘<code
      class=property>font-weight</code>’</a> property. Given the desired
      weight and the weights of faces in the matching set after the steps
      above, if the desired weight is available that face matches. Otherwise,
      a weight is chosen using the rules below:
      <ul>
       <li>If the desired weight is less than 400, weights below the desired
        weight are checked in descending order followed by weights above the
        desired weight in ascending order until a match is found.

       <li>If the desired weight is greater than 500, weights above the
        desired weight are checked in ascending order followed by weights
        below the desired weight in descending order until a match is found.

       <li>If the desired weight is 400, 500 is checked first and then the
        rule for desired weights less than 400 is used.

       <li>If the desired weight is 500, 400 is checked first and then the
        rule for desired weights less than 400 is used.
      </ul>

     <li><a class=property href="#propdef-font-size">‘<code
      class=property>font-size</code>’</a> must be matched within a
      UA-dependent margin of tolerance. (Typically, sizes for scalable fonts
      are rounded to the nearest whole pixel, while the tolerance for
      bitmapped fonts could be as large as 20%.) Further computations, e.g.,
      by ‘<code class=property>em</code>’ values in other properties, are
      based on the <a class=property href="#propdef-font-size">‘<code
      class=property>font-size</code>’</a> value that is used, not the one
      that is specified.
    </ol>

   <li>
    <p>If the matched face is defined via <a
     href="#at-font-face-rule"><code>@font-face</code></a> rules, user agents
     must use the procedure below to select a single font:

    <ol>
     <li>If the font resource has not been loaded and the range of characters
      defined by the ‘<a href="#descdef-unicode-range"><code
      class=property>unicode-range</code></a>’ descriptor value includes
      the character in question, load the font.

     <li>After downloading, if the <a
      href="#effective-character-map"><em>effective character map</em></a>
      supports the character in question, select that font.
    </ol>

    <p>When the matched face is a <a href="#composite-face"><em>composite
     face</em></a>, user agents must use the procedure above on each of the
     faces in the <a href="#composite-face"><em>composite face</em></a> in
     reverse order of <a
     href="#at-font-face-rule"><code>@font-face</code></a> rule definition.

    <p>While the download occurs, user agents may either wait until the font
     is downloaded or render once with substituted font metrics and render
     again once the font is downloaded.

   <li>
    <p>If no matching face exists or the matched face does not contain a
     glyph for the character to be rendered, the next family name is selected
     and the previous three steps repeated. Glyphs from other faces in the
     family are not considered. The only exception is that user agents may
     optionally substitute a synthetically obliqued version of the <a
     href="#default-face"><em>default face</em></a> if that face supports a
     given glyph and synthesis of these faces is permitted by the value of
     the ‘<a href="#propdef-font-synthesis"><code
     class=property>font-synthesis</code></a>’ property. For example, a
     synthetic italic version of the regular face may be used if the italic
     face doesn't support glyphs for Arabic.</p>
    <!-- resolution on the above: http://lists.w3.org/Archives/Public/www-style/2012Nov/0292.html -->

   <li>If there are no more font families to be evaluated and no matching
    face has been found, then the user agent performs a <dfn
    id=system-font-fallback>system font fallback</dfn> procedure to find the
    best match for the character to be rendered. The result of this procedure
    may vary across user agents.

   <li>If a particular character cannot be displayed using any font, the user
    agent should indicate by some means that a character is not being
    displayed, displaying either a symbolic representation of the missing
    glyph (e.g. using a <a
    href="https://en.wikipedia.org/wiki/Last_resort_font">Last Resort
    Font</a>) or using the missing character glyph from a default font.
  </ol>

  <p>Optimizations of this process are allowed provided that an
   implementation behaves as if the algorithm had been followed exactly.
   Matching occurs in a well-defined order to ensure that the results are as
   consistent as possible across user agents, given an identical set of
   available fonts and rendering technology.

  <p>The <dfn data-export=data-export id=first-available-font>first available
   font</dfn>, used for example in the definition of <a
   href="https://www.w3.org/TR/css3-values/#font-relative-lengths"><em>font-relative
   lengths</em></a> such as ‘<code class=property>ex</code>’ and ‘<code
   class=property>ch</code>’ or in the definition of the <a
   href="https://www.w3.org/TR/CSS2/visudet.html#propdef-line-height">‘<code
   class=property>line-height</code>’</a> property, is defined to be the
   first available font that would match the U+0020 (space) character given
   font families in the ‘<code class=property>font-family</code>’ list
   (or a user agent's default font if none are available).

  <h3 id=cluster-matching><span class=secno>5.3. </span>Cluster matching</h3>

  <p>When text contains characters such as combining marks, ideally the base
   character should be rendered using the same font as the mark, this assures
   proper placement of the mark. For this reason, the font matching algorithm
   for clusters is more specialized than the general case of matching a
   single character by itself. For sequences containing variation selectors,
   which indicate the precise glyph to be used for a given character, user
   agents always attempt <a href="#system-font-fallback"><em>system font
   fallback</em></a> to find the appropriate glyph before using the default
   glyph of the base character.

  <p>A sequence of codepoints containing combining mark or other modifiers is
   termed a grapheme cluster (see <a href="#ref-CSS-TEXT-3"
    >[CSS-TEXT-3]<!--{{CSS-TEXT-3}}--></a> and <a
   href="#ref-UAX29"  >[UAX29]<!--{{UAX29}}--></a> for a more
   complete description). For a given cluster containing a base character,
   <em>b</em> and a sequence of combining characters <em>c1, c2…</em>, the
   entire cluster is matched using these steps:

  <ol>
   <li>For each family in the font list, a face is chosen using the style
    selection rules defined in the previous section.
    <ol>
     <li>If all characters in the sequence <em>b + c1 + c2 …</em> are
      completely supported by the font, select this font for the sequence.

     <li>If a sequence of multiple codepoints is canonically equivalent to a
      single character and the font <a href="#support"><em
      title=support>supports</em></a> that character, select this font for
      the sequence and use the glyph associated with the canonically
      equiavlent character for the entire cluster.
    </ol>

   <li>If no font was found in the font list in step 1:
    <ol>
     <li>If <em>c1</em> is a variation selector, system fallback must be used
      to find a font that <a href="#support"><em
      title=support>supports</em></a> the full sequence of <em>b + c1</em>.
      If no font on the system <a href="#support"><em
      title=support>supports</em></a> the full sequence, match the single
      character <em>b</em> using the normal procedure for matching single
      characters and ignore the variation selector. Note: a sequence with
      more than one variation selector must be treated as an encoding error
      and the trailing selectors must be ignored. <a href="#ref-UNICODE"
       >[UNICODE]<!--{{!UNICODE}}--></a>

     <li>Otherwise, the user agent may optionally use system font fallback to
      match a font that <a href="#support"><em
      title=support>supports</em></a> the entire cluster.
    </ol>

   <li>If no font is found in step 2, use the matching sequence from step 1
    to determine the longest sequence that is completely <a
    href="#support"><em title=support>supported</em></a> by a font in the
    font list and attempt to match the remaining combining characters
    separately using the rules for single characters.
  </ol>

  <h3 id=char-handling-issues><span class=secno>5.4. </span>Character
   handling issues</h3>

  <p>CSS font matching is always performed on text runs containing Unicode
   characters <a href="#ref-UNICODE"
    >[UNICODE]<!--{{!UNICODE}}--></a>, so documents using
   legacy encodings are assumed to have been transcoded before matching
   fonts. For fonts containing <a href="#character-map"><em
   title="character map">character maps</em></a> for both legacy encodings
   and Unicode, the contents of the legacy encoding <a
   href="#character-map"><em>character map</em></a> must have no effect on
   the results of the font matching process.

  <p>The font matching process does not assume that text runs are in either
   normalized or denormalized form (see <a href="#ref-CHARMOD-NORM"
    >[CHARMOD-NORM]<!--{{CHARMOD-NORM}}--></a> for more
   details). Fonts may only support precomposed forms and not the decomposed
   sequence of base character plus combining marks. Authors should always
   tailor their choice of fonts to their content, including whether that
   content contains normalized or denormalized character streams.

  <p>If a given character is a Private-Use Area Unicode codepoint, user
   agents must only match font families named in the ‘<code
   class=property>font-family</code>’ list that are not generic families.
   If none of the families named in the ‘<code
   class=property>font-family</code>’ list contain a glyph for that
   codepoint, user agents must display some form of missing glyph symbol for
   that character rather than attempting <a
   href="#system-font-fallback"><em>system font fallback</em></a> for that
   codepoint. When matching the replacement character U+FFFD, user agents may
   skip the font matching process and immediately display some form of
   missing glyph symbol, they are not required to display the glyph from the
   font that would be selected by the font matching process.

  <p>In general, the fonts for a given family will all have the same or
   similar <a href="#character-map"><em title="character map">character
   maps</em></a>. The process outlined here is designed to handle even font
   families containing faces with widely variant <a href="#character-map"><em
   title="character map">character maps</em></a>. However, authors are
   cautioned that the use of such families can lead to unexpected results.

  <h3 id=font-matching-changes><span class=secno>5.5. </span>Font matching
   changes since CSS 2.1</h3>

  <p>The algorithm above is different from CSS 2.1 in a number of key places.
   These changes were made to better reflect actual font matching behavior
   across user agent implementations.

  <p>Differences compared to the font matching algorithm in CSS 2.1:

  <ul>
   <li>The algorithm includes font-stretch matching.

   <li>All possible font-style matching scenarios are delineated.

   <li>Small-caps fonts are not matched as part of the font matching process,
    they are now handled via font features.

   <li>Unicode variation selector matching is required.

   <li>Cluster sequences are matched as a unit.
  </ul>

  <h3 id=font-matching-examples><span class=secno>5.6. </span>Font matching
   examples</h3>

  <div class=example>
   <p>It's useful to note that the CSS selector syntax may be used to create
    language-sensitive typography. For example, some Chinese and Japanese
    characters are unified to have the same Unicode code point, although the
    abstract glyphs are not the same in the two languages.

   <pre>*:lang(ja) { font: 900 14pt/16pt &quot;Heisei Mincho W9&quot;, serif; }
*:lang(zh-Hant-TW) { font: 800 14pt/16.5pt &quot;Li Sung&quot;, serif; }
</pre>

   <p>This selects any element that has the given language — Japanese or
    Traditional Chinese as used in Taiwan — and uses the appropriate font.
  </div>

  <h2 id=font-rend-props><span class=secno>6. </span>Font Feature Properties</h2>

  <p>Modern font technologies support a variety of advanced typographic and
   language-specific font features. Using these features, a single font can
   provide glyphs for a wide range of ligatures, contextual and stylistic
   alternates, tabular and old-style figures, small capitals, automatic
   fractions, swashes, and alternates specific to a given language. To allow
   authors control over these font capabilities, the ‘<code
   class=property>font-variant</code>’ property has been expanded for CSS3.
   It now functions as a shorthand for a set of properties that provide
   control over stylistic font features.

  <h3 id=glyph-selection-positioning><span class=secno>6.1. </span>Glyph
   selection and positioning</h3>

  <p>This section is non-normative

  <p>Simple fonts used for displaying Latin text use a very basic processing
   model. Fonts contain a <a href="#character-map"><em>character map</em></a>
   which maps each character to a glyph for that character. Glyphs for
   subsequent characters are simply placed one after the other along a run of
   text. Modern font formats such as OpenType and AAT (Apple Advanced
   Typography) use a richer processing model. The glyph for a given character
   can be chosen and positioned not just based on the codepoint of the
   character itself, but also on adjacent characters as well as the language,
   script, and features enabled for the text. Font features may be required
   for specific scripts, or recommended as enabled by default or they might
   be stylistic features meant to be used under author control. The point at
   which font selection and positioning happens in the overall order of text
   processing operations (such as text transformation, text orientation and
   text alignment) is described in <a href="#ref-CSS-TEXT-3"
    >[CSS-TEXT-3]<!--{{CSS-TEXT-3}}--></a>, <a
   href="https://drafts.csswg.org/css-text-3/#order">§ Text Processing Order
   of Operations</a>.

  <p>For a good visual overview of these features, see the <a
   href="#ref-OPENTYPE-FONT-GUIDE"
    >[OPENTYPE-FONT-GUIDE]<!--{{OPENTYPE-FONT-GUIDE}}--></a>.
   For a detailed description of glyph processing for OpenType fonts, see <a
   href="#ref-WINDOWS-GLYPH-PROC"
    >[WINDOWS-GLYPH-PROC]<!--{{WINDOWS-GLYPH-PROC}}--></a>.

  <p>Stylistic font features can be classified into two broad categories:
   ones that affect the harmonization of glyph shapes with the surrounding
   context, such as kerning and ligature features, and ones such as the
   small-caps, subscript/superscript and alternate features that affect shape
   selection.

  <p>The subproperties of <a href="#propdef-font-variant"
   title="font-variant!!property">‘<code
   class=property>font-variant</code>’</a> listed below are used to control
   these stylistic font features. They do not control features that are
   required for displaying certain scripts, such as the OpenType features
   used when displaying Arabic or Indic language text. They affect glyph
   selection and positioning, but do not affect font selection as described
   in the font matching section (except in cases required for compatibility
   with CSS 2.1).

  <p>To assure consistent behavior across user agents, the equivalent
   OpenType property settings are listed for individual properties and are
   normative. When using other font formats these should be used as a
   guideline to map CSS font feature property values to specific font
   features.

  <h3 id=language-specific-support><span class=secno>6.2.
   </span>Language-specific display</h3>

  <p>OpenType also supports language-specific glyph selection and
   positioning, so that text can be displayed correctly in cases where the
   language dictates a specific display behavior. Many languages share a
   common script, but the shape of certain letters can vary across those
   languages. For example, certain Cyrillic letters have different shapes in
   Russian text than in Bulgarian. In Latin text, it's common to render "fi"
   with an explicit fi-ligature that lacks a dot on the "i". However, in
   languages such as Turkish which uses both a dotted-i and a dotless-i, it's
   important to not use this ligature or use a specialized version that
   contains a dot over the "i". The example below shows language-specific
   variations based on stylistic traditions found in Spanish, Italian and
   French orthography:

  <div class=featex><img alt="language specific forms, spanish"
   src=locl-1.png></div>

  <div class=featex><img alt="language specific forms, italian"
   src=locl-2.png></div>

  <div class=featex><img alt="language specific forms, french"
   src=locl-3.png></div>

  <p>If the content language of the element is known according to the rules
   of the <a
   href="https://www.w3.org/TR/CSS21/conform.html#doclanguage">document
   language</a>, user agents are required to infer the OpenType language
   system from the content language and use that when selecting and
   positioning glyphs using an OpenType font.</p>
  <!-- prop: font-kerning -->

  <h3 id=font-kerning-prop><span class=secno>6.3. </span>Kerning: the <a
   href="#propdef-font-kerning">font-kerning</a> property</h3>

  <table class=propdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=propdef-font-kerning>font-kerning</dfn>

    <tr>
     <td>Value:

     <td><a href="#font-kerning-auto-value"
      title="auto!!font-kerning">auto</a> | <a
      href="#font-kerning-normal-value"
      title="normal!!font-kerning">normal</a> | <a
      href="#font-kerning-none-value" title="none!!font-kerning">none</a>

    <tr>
     <td>Initial:

     <td>auto

    <tr>
     <td>Applies to:

     <td>all elements

    <tr>
     <td>Inherited:

     <td>yes

    <tr>
     <td>Percentages:

     <td>N/A

    <tr>
     <td>Computed value:

     <td>as specified

    <tr>
     <td>Animatable:

     <td>no
  </table>

  <p>Kerning is the contextual adjustment of inter-glyph spacing. This
   property controls metric kerning, kerning that utilizes adjustment data
   contained in the font.

  <dl>
   <dt><dfn id=font-kerning-auto-value title="auto!!font-kerning">auto</dfn>

   <dd>Specifies that kerning is applied at the discretion of the user agent

   <dt><dfn id=font-kerning-normal-value
    title="normal!!font-kerning">normal</dfn>

   <dd>Specifies that kerning is applied

   <dt><dfn id=font-kerning-none-value title="none!!font-kerning">none</dfn>

   <dd>Specifies that kerning is not applied
  </dl>

  <p>For fonts that do not include kerning data this property will have no
   visible effect. When rendering with OpenType fonts, the <a
   href="#ref-OPENTYPE"  >[OPENTYPE]<!--{{!OPENTYPE}}--></a>
   specification suggests that kerning be enabled by default. When kerning is
   enabled, the OpenType <span class=tag>kern</span> feature is enabled (for
   vertical text runs the <span class=tag>vkrn</span> feature is enabled
   instead). User agents must also support fonts that only support kerning
   via data contained in a <span class=tag>kern</span> font table, as
   detailed in the OpenType specification. If the ‘<code
   class=property>letter-spacing</code>’ property is defined, kerning
   adjustments are considered part of the default spacing and letter spacing
   adjustments are made after kerning has been applied.

  <p>When set to ‘<code class=property>auto</code>’, user agents can
   determine whether to apply kerning or not based on a number of factors:
   text size, script, or other factors that influence text processing speed.
   Authors who want proper kerning should use <a
   href="#font-kerning-normal-value" title="normal!!font-kerning">‘<code
   class=property>normal</code>’</a> to explicitly enable kerning.
   Likewise, some authors may prefer to disable kerning in situations where
   performance is more important than precise appearance. However, in
   well-designed modern implementations the use of kerning generally does not
   have a large impact on text rendering speed.</p>
  <!-- prop: font-variant-ligatures -->

  <h3 id=font-variant-ligatures-prop><span class=secno>6.4. </span>Ligatures:
   the <a href="#propdef-font-variant-ligatures">font-variant-ligatures</a>
   property</h3>

  <table class=propdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=propdef-font-variant-ligatures>font-variant-ligatures</dfn>

    <tr>
     <td>Value:

     <td><a href="#font-variant-ligatures-normal-value"
      title="normal!!font-variant-ligatures">normal</a> | <a
      href="#font-variant-ligatures-none-value"
      title="none!!font-variant-ligatures">none</a> | [ <a
      href="#common-lig-values"><var>&lt;common-lig-values&gt;</var></a> ||
      <a
      href="#discretionary-lig-values"><var>&lt;discretionary-lig-values&gt;</var></a>
      || <a
      href="#historical-lig-values"><var>&lt;historical-lig-values&gt;</var></a>
      || <a
      href="#contextual-alt-values"><var>&lt;contextual-alt-values&gt;</var></a>
      ]

    <tr>
     <td>Initial:

     <td>normal

    <tr>
     <td>Applies to:

     <td>all elements

    <tr>
     <td>Inherited:

     <td>yes

    <tr>
     <td>Percentages:

     <td>N/A

    <tr>
     <td>Computed value:

     <td>as specified

    <tr>
     <td>Animatable:

     <td>no
  </table>

  <p>Ligatures and contextual forms are ways of combining glyphs to produce
   more harmonized forms.

  <pre class=prod><dfn
   id=common-lig-values><var>&lt;common-lig-values&gt;</var></dfn>        = [ <a
   href="#common-ligatures">common-ligatures</a> | <a
   href="#no-common-ligatures">no-common-ligatures</a> ]</pre>

  <pre class=prod><dfn
   id=discretionary-lig-values><var>&lt;discretionary-lig-values&gt;</var></dfn> = [ <a
   href="#discretionary-ligatures">discretionary-ligatures</a> | <a
   href="#no-discretionary-ligatures">no-discretionary-ligatures</a> ]</pre>

  <pre class=prod><dfn
   id=historical-lig-values><var>&lt;historical-lig-values&gt;</var></dfn>    = [ <a
   href="#historical-ligatures">historical-ligatures</a> | <a
   href="#no-historical-ligatures">no-historical-ligatures</a> ]</pre>

  <pre class=prod><dfn
   id=contextual-alt-values><var>&lt;contextual-alt-values&gt;</var></dfn>    = [ <a
   href="#contextual">contextual</a> | <a
   href="#no-contextual">no-contextual</a> ]</pre>

  <p>Individual values have the following meanings:

  <dl>
   <dt><dfn id=font-variant-ligatures-normal-value
    title="normal!!font-variant-ligatures">normal</dfn>

   <dd>A value of <a href="#font-variant-ligatures-normal-value"
    title="normal!!font-variant-ligatures">‘<code
    class=property>normal</code>’</a> specifies that common default
    features are enabled, <a href="#font-feature-resolution">as described in
    detail in the next section</a>. For OpenType fonts, common ligatures and
    contextual forms are on by default, discretionary and historical
    ligatures are not.

   <dt><dfn id=font-variant-ligatures-none-value
    title="none!!font-variant-ligatures">none</dfn>

   <dd>Specifies that all types of ligatures and contextual forms covered by
    this property are explicitly disabled. In situations where ligatures are
    not considered necessary, this may improve the speed of text rendering.

   <dt><dfn id=common-ligatures>common-ligatures</dfn>

   <dd>Enables display of common ligatures (OpenType features: <span
    class=tag>liga, clig</span>). For OpenType fonts, common ligatures are
    enabled by default.
  </dl>

  <div class=featex><img alt="common ligature example" src=liga.png></div>

  <dl>
   <dt><dfn id=no-common-ligatures>no-common-ligatures</dfn>

   <dd>Disables display of common ligatures (OpenType features: <span
    class=tag>liga, clig</span>).

   <dt><dfn id=discretionary-ligatures>discretionary-ligatures</dfn>

   <dd>Enables display of discretionary ligatures (OpenType feature: <span
    class=tag>dlig</span>). Which ligatures are discretionary or optional is
    decided by the type designer, so authors will need to refer to the
    documentation of a given font to understand which ligatures are
    considered discretionary.
  </dl>

  <div class=featex><img alt="discretionary ligature example" src=dlig.png></div>

  <dl>
   <dt><dfn id=no-discretionary-ligatures>no-discretionary-ligatures</dfn>

   <dd>Disables display of discretionary ligatures (OpenType feature: <span
    class=tag>dlig</span>).

   <dt><dfn id=historical-ligatures>historical-ligatures</dfn>

   <dd>Enables display of historical ligatures (OpenType feature: <span
    class=tag>hlig</span>).
  </dl>

  <div class=featex><img alt="historical ligature example" src=hlig.png></div>

  <dl>
   <dt><dfn id=no-historical-ligatures>no-historical-ligatures</dfn>

   <dd>Disables display of historical ligatures (OpenType feature: <span
    class=tag>hlig</span>).

   <dt><dfn id=contextual>contextual</dfn>

   <dd>Enables display of contextual alternates (OpenType feature: <span
    class=tag>calt</span>). Although not strictly a ligature feature, like
    ligatures this feature is commonly used to harmonize the shapes of glyphs
    with the surrounding context. For OpenType fonts, this feature is on by
    default.
  </dl>

  <div class=featex><img alt="contextual alternate example" src=calt.png></div>

  <dl>
   <dt><dfn id=no-contextual>no-contextual</dfn>

   <dd>Disables display of contextual alternates (OpenType feature: <span
    class=tag>calt</span>).
  </dl>

  <p>Required ligatures, needed for correctly rendering complex scripts, are
   not affected by the settings above, including ‘<code
   class=property>none</code>’ (OpenType feature: <span
   class=tag>rlig</span>).</p>
  <!-- prop: font-variant-position -->

  <h3 id=font-variant-position-prop><span class=secno>6.5. </span>Subscript
   and superscript forms: the <a
   href="#propdef-font-variant-position">font-variant-position</a> property</h3>

  <table class=propdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=propdef-font-variant-position>font-variant-position</dfn>

    <tr>
     <td>Value:

     <td><a href="#font-variant-position-normal-value"
      title="normal!!font-variant-position">normal</a> | <a
      href="#sub">sub</a> | <a href="#super">super</a>

    <tr>
     <td>Initial:

     <td>normal

    <tr>
     <td>Applies to:

     <td>all elements

    <tr>
     <td>Inherited:

     <td>yes

    <tr>
     <td>Percentages:

     <td>N/A

    <tr>
     <td>Computed value:

     <td>as specified

    <tr>
     <td>Animatable:

     <td>no
  </table>

  <p>This property is used to enable typographic subscript and superscript
   glyphs. These are alternate glyphs designed within the same em-box as
   default glyphs and are intended to be laid out on the same baseline as the
   default glyphs, with no resizing or repositioning of the baseline. They
   are explicitly designed to match the surrounding text and to be more
   readable without affecting the line height.

  <div class=figure><img
   alt="comparison between real subscript glyphs and synthesized ones"
   src=realsubscripts.png>
   <p class=caption>Subscript glyphs (top) vs. typical synthesized subscripts
    (bottom)
  </div>

  <p>Individual values have the following meanings:

  <dl>
   <dt><dfn id=font-variant-position-normal-value
    title="normal!!font-variant-position">normal</dfn>

   <dd>None of the features listed below are enabled.

   <dt><dfn id=sub>sub</dfn>

   <dd>Enables display of subscript variants (OpenType feature: <a class=tag
    href="#sub">subs</a>).

   <dt><dfn id=super>super</dfn>

   <dd>Enables display of superscript variants (OpenType feature: <span
    class=tag>sups</span>).
  </dl>

  <p>Because of the semantic nature of subscripts and superscripts, when the
   value is either ‘<a href="#sub"><code class=property>sub</code></a>’
   or ‘<a href="#super"><code class=property>super</code></a>’ for a
   given contiguous run of text, if a variant glyph is not available for all
   the characters in the run, simulated glyphs <!-- must --> should be
   synthesized for all characters using reduced forms of the glyphs that
   would be used without this feature applied. This is done per run to avoid
   a mixture of variant glyphs and synthesized ones that would not align
   correctly. In the case of OpenType fonts that lack subscript or
   superscript glyphs for a given character, user agents <em>must</em>
   synthesize appropriate subscript and superscript glyphs.

  <div class=figure><img
   alt="alternate superscripts vs. glyphs synthesized using superscript metrics"
   src=superscript-alt-synth.png>
   <p class=caption>Superscript alternate glyph (left), synthesized
    superscript glyphs (middle), and incorrect mixture of the two (right)
  </div>
  <!--
  at-risk must downgraded to should
  see https://github.com/w3c/csswg-drafts/issues/2796#issuecomment-398565265
-->

  <p>In situations where text decorations are only applied to runs of text
   containing superscript or subscript glyphs, the synthesized glyphs may be
   used, to avoid problems with the placement of decorations.

  <p>In the past, user agents have used font-size and vertical-align to
   simulate subscripts and superscripts for the <code
   title="HTML sub element">sub</code> and <code
   title="HTML sup element">sup</code> elements. To allow a backwards
   compatible way of defining subscripts and superscripts, it is recommended
   that authors use conditional rules <a href="#ref-CSS3-CONDITIONAL"
    >[CSS3-CONDITIONAL]<!--{{CSS3-CONDITIONAL}}--></a> so that
   older user agents will still render subscripts and superscripts via the
   older mechanism.

  <p>Because <code>font-size: smaller</code> is often used for these
   elements, the effective scaling factor applied to subscript and
   superscript text varies depending upon the size. For larger text, the font
   size is often reduced by a third but for smaller text sizes, the reduction
   can be much less. This allows subscripts and superscripts to remain
   readable even within elements using small text sizes. User agents should
   consider this when deciding how to synthesize subscript and superscript
   glyphs.

  <p class=note>The OpenType font format defines subscript and superscript
   metrics in the <a
   href="https://docs.microsoft.com/en-us/typography/opentype/spec/os2">OS/2
   table</a> <a href="#ref-OPENTYPE"
    >[OPENTYPE]<!--{{!OPENTYPE}}--></a> but these are not
   always accurate in practice and so cannot be relied upon when synthesizing
   subscript and superscript glyphs.

  <p>Authors should note that fonts typically only provide subscript and
   superscript glyphs for a subset of all characters supported by the font.
   For example, while subscript and superscript glyphs are often available
   for Latin numbers, glyphs for punctuation and letter characters are less
   frequently provided. The synthetic fallback rules defined for this
   property assure that subscripts and superscripts will always appear but
   the appearance may not match author expectations if the font used does not
   provide the appropriate alternate glyph for all characters contained in a
   subscript or superscript.

  <p>This property is not cumulative. Applying it to elements within a
   subscript or superscript won't nest the placement of a subscript or
   superscript glyph. Images contained within text runs where the value of
   this property is ‘<a href="#sub"><code class=property>sub</code></a>’
   or ‘<a href="#super"><code class=property>super</code></a>’ will be
   drawn just as they would if the value was <a
   href="#font-variant-position-normal-value"
   title="normal!!font-variant-position">‘<code
   class=property>normal</code>’</a>.</p>
  <!-- due to lack of consensus, couldn't resolve on exact positioning of text decorations:
http://www.w3.org/2013/06/06-css-minutes.html#item03 -->

  <p>Because of these limitations, ‘<a
   href="#propdef-font-variant-position"><code
   class=property>font-variant-position</code></a>’ is not recommended for
   use in user agent stylesheets. Authors should use it in cases where
   subscripts or superscripts will only contain the narrow range of
   characters supported by the fonts specified.

  <p class=note>The variant glyphs use the same baseline as the default
   glyphs would use. There is no shift in the placement along the baseline,
   so the use of variant glyphs doesn't affect the height of the inline box
   or alter the height of the linebox. This makes superscript and subscript
   variants ideal for situations where it's important that leading remain
   constant, such as in multi-column layout.

  <div class=example>
   <p>A typical user agent default style for the <a class=tag
    href="#sub">sub</a> element:

   <pre>sub {
  vertical-align: sub;
  font-size: smaller;
  line-height: normal;
}
</pre>

   <p>Using ‘<a href="#propdef-font-variant-position"><code
    class=property>font-variant-position</code></a>’ to specify typographic
    subscripts in a way that will still show subscripts in older user agents:

   <pre>@supports ( font-variant-position: sub ) {

  sub {
    vertical-align: baseline;
    font-size: 100%;
    line-height: inherit;
    font-variant-position: sub;
  }

}
</pre>

   <p>User agents that support the ‘<a
    href="#propdef-font-variant-position"><code
    class=property>font-variant-position</code></a>’ property will select a
    subscript variant glyph and render this without adjusting the baseline or
    font-size. Older user agents will ignore the ‘<a
    href="#propdef-font-variant-position"><code
    class=property>font-variant-position</code></a>’ property definition
    and use the standard defaults for subscripts.
  </div>
  <!-- prop: font-variant-caps -->

  <h3 id=font-variant-caps-prop><span class=secno>6.6. </span>Capitalization:
   the <a href="#propdef-font-variant-caps">font-variant-caps</a> property</h3>

  <table class=propdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=propdef-font-variant-caps>font-variant-caps</dfn>

    <tr>
     <td>Value:

     <td><a href="#font-variant-caps-normal-value"
      title="normal!!font-variant-caps">normal</a> | <a
      href="#small-caps">small-caps</a> | <a
      href="#all-small-caps">all-small-caps</a> | <a
      href="#petite-caps">petite-caps</a> | <a
      href="#all-petite-caps">all-petite-caps</a> | <a
      href="#unicase">unicase</a> | <a href="#titling-caps">titling-caps</a>

    <tr>
     <td>Initial:

     <td>normal

    <tr>
     <td>Applies to:

     <td>all elements

    <tr>
     <td>Inherited:

     <td>yes

    <tr>
     <td>Percentages:

     <td>N/A

    <tr>
     <td>Computed value:

     <td>as specified

    <tr>
     <td>Animatable:

     <td>no
  </table>

  <p>This property allows the selection of alternate glyphs used for small or
   petite capitals or for titling. These glyphs are specifically designed to
   blend well with the surrounding normal glyphs, to maintain the weight and
   readability which suffers when text is simply resized to fit this purpose.

  <p>Individual values have the following meanings:

  <dl>
   <dt><dfn id=font-variant-caps-normal-value
    title="normal!!font-variant-caps">normal</dfn>

   <dd>None of the features listed below are enabled.

   <dt><dfn id=small-caps>small-caps</dfn>

   <dd>Enables display of small capitals (OpenType feature: <span
    class=tag>smcp</span>). Small-caps glyphs typically use the form of
    uppercase letters but are reduced to the size of lowercase letters.
  </dl>

  <div class=featex><img alt="small-caps example" src=smcp.png></div>

  <dl>
   <dt><dfn id=all-small-caps>all-small-caps</dfn>

   <dd>Enables display of small capitals for both upper and lowercase letters
    (OpenType features: <span class=tag>c2sc, smcp</span>).

   <dt><dfn id=petite-caps>petite-caps</dfn>

   <dd>Enables display of petite capitals (OpenType feature: <span
    class=tag>pcap</span>).

   <dt><dfn id=all-petite-caps>all-petite-caps</dfn>

   <dd>Enables display of petite capitals for both upper and lowercase
    letters (OpenType features: <span class=tag>c2pc, pcap</span>).

   <dt><dfn id=unicase>unicase</dfn>

   <dd>Enables display of mixture of small capitals for uppercase letters
    with normal lowercase letters (OpenType feature: <span
    class=tag>unic</span>).

   <dt><dfn id=titling-caps>titling-caps</dfn>

   <dd>Enables display of titling capitals (OpenType feature: <span
    class=tag>titl</span>). Uppercase letter glyphs are often designed for
    use with lowercase letters. When used in all uppercase titling sequences
    they can appear too strong. Titling capitals are designed specifically
    for this situation.
  </dl>

  <p>The availability of these glyphs is based on whether a given feature is
   defined or not in the feature list of the font. User agents can optionally
   decide this on a per-script basis but should explicitly not decide this on
   a per-character basis.

  <p>Some fonts may only support a subset or none of the features described
   for this property. For backwards compatibility with CSS 2.1, if ‘<a
   href="#small-caps"><code class=property>small-caps</code></a>’ or ‘<a
   href="#all-small-caps"><code class=property>all-small-caps</code></a>’
   is specified but small-caps glyphs are not available for a given font,
   user agents should simulate a small-caps font, for example by taking a
   normal font and replacing the glyphs for lowercase letters with scaled
   versions of the glyphs for uppercase characters (replacing the glyphs for
   both upper and lowercase letters in the case of ‘<a
   href="#all-small-caps"><code class=property>all-small-caps</code></a>’).

  <div class=figure style="padding: 0; margin: auto;"><img
   alt="synthetic vs. real small-caps" class=hires
   src=synthetic-vs-real-small-caps.png width=512>
   <p class=caption>Synthetic vs. real small-caps
  </div>

  <p>The ‘<code class=property>font-feature-settings</code>’ property
   does not affect the decision of whether or not to use a simulated
   small-caps font.

  <p> <!-- but it does in Fonts 4 -->

  <div class=example>
   <pre>#example1 { font-variant-caps: small-caps; }
#example2 { font-variant-caps: small-caps; font-feature-settings: 'smcp' 0; }</pre>
   For fonts which don't support small caps, both #example1 and #example2
   should be rendered with synthesized small caps. However, for fonts which
   do support small caps, #example1 should be rendered with native small
   caps, while #example2 should be rendered without any small-caps (native or
   synthesized).</div>

  <p>To match the surrounding text, a font may provide alternate glyphs for
   caseless characters when these features are enabled but when a user agent
   simulates small capitals, it must not attempt to simulate alternates for
   codepoints which are considered caseless.

  <div class=figure style="padding: 0; margin: auto;"><img
   alt="caseless characters with small-caps, all-small-caps enabled"
   class=hires src=small-capitals-variations.png width=418>
   <p class=caption>Caseless characters with small-caps, all-small-caps
    enabled
  </div>

  <p>If either ‘<a href="#petite-caps"><code
   class=property>petite-caps</code></a>’ or ‘<a
   href="#all-petite-caps"><code class=property>all-petite-caps</code></a>’
   is specified for a font that doesn't support these features, the property
   behaves as if ‘<a href="#small-caps"><code
   class=property>small-caps</code></a>’ or ‘<a
   href="#all-small-caps"><code class=property>all-small-caps</code></a>’,
   respectively, had been specified. If ‘<a href="#unicase"><code
   class=property>unicase</code></a>’ is specified for a font that doesn't
   support that feature, the property behaves as if ‘<a
   href="#small-caps"><code class=property>small-caps</code></a>’ was
   applied only to lowercased uppercase letters. If ‘<a
   href="#titling-caps"><code class=property>titling-caps</code></a>’ is
   specified with a font that does not support this feature, this property
   has no visible effect. When simulated small capital glyphs are used, for
   scripts that lack uppercase and lowercase letters, ‘<a
   href="#small-caps"><code class=property>small-caps</code></a>’, ‘<a
   href="#all-small-caps"><code class=property>all-small-caps</code></a>’,
   ‘<a href="#petite-caps"><code class=property>petite-caps</code></a>’,
   ‘<a href="#all-petite-caps"><code
   class=property>all-petite-caps</code></a>’ and ‘<a
   href="#unicase"><code class=property>unicase</code></a>’ have no visible
   effect.

  <p>When casing transforms are used to simulate small capitals, the casing
   transformations must match those used for the <span
   class=property>‘<code class=property>text-transform</code>’</span>
   property.

  <p>As a last resort, unscaled uppercase letter glyphs in a normal font may
   replace glyphs in a small-caps font so that the text appears in all
   uppercase letters.

  <div class=figure style="padding: 0; margin: auto;"><img
   alt="using all-small-caps in acronym-laden text" class=hires
   src=acronym-laden-text.png width=596>
   <p class=caption>Using small capitals to improve readability in
    acronym-laden text
  </div>

  <div class=example>
   <p>Quotes rendered italicised, with small-caps on the first line:

   <pre>blockquote            { font-style: italic; }
blockquote:first-line { font-variant: small-caps; }

&lt;blockquote><a
    href="https://lists.w3.org/Archives/Public/www-style/2009Dec/0036.html"
    style="text-decoration: none; border: none;">I'll be honor-bound to slap them like a haddock.</a>&lt;/blockquote>
</pre>
  </div>
  <!-- prop: font-variant-numeric -->

  <h3 id=font-variant-numeric-prop><span class=secno>6.7. </span>Numerical
   formatting: the <a
   href="#propdef-font-variant-numeric">font-variant-numeric</a> property</h3>

  <table class=propdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=propdef-font-variant-numeric>font-variant-numeric</dfn>

    <tr>
     <td>Value:

     <td><a href="#font-variant-numeric-normal-value"
      title="normal!!font-variant-numeric">normal</a> | [ <a
      href="#numeric-figure-values"><var>&lt;numeric-figure-values&gt;</var></a>
      || <a
      href="#numeric-spacing-values"><var>&lt;numeric-spacing-values&gt;</var></a>
      || <a
      href="#numeric-fraction-values"><var>&lt;numeric-fraction-values&gt;</var></a>
      || <a href="#ordinal">ordinal</a> || <a
      href="#slashed-zero">slashed-zero</a> ]

    <tr>
     <td>Initial:

     <td>normal

    <tr>
     <td>Applies to:

     <td>all elements

    <tr>
     <td>Inherited:

     <td>yes

    <tr>
     <td>Percentages:

     <td>N/A

    <tr>
     <td>Computed value:

     <td>as specified

    <tr>
     <td>Animatable:

     <td>no
  </table>

  <p>Specifies control over numerical forms. The example below shows how some
   of these values can be combined to influence the rendering of tabular data
   with fonts that support these features. Within normal paragraph text,
   proportional numbers are used while tabular numbers are used so that
   columns of numbers line up properly:

  <div class=figure style="padding: 0; margin: auto;"><img
   alt="combining number styles" src=numberstyles.png>
   <p class=caption>Using number styles
  </div>

  <p>Possible combinations:

  <pre class=prod><dfn
   id=numeric-figure-values><var>&lt;numeric-figure-values&gt;</var></dfn>   = [ <a
   href="#lining-nums">lining-nums</a> | <a
   href="#oldstyle-nums">oldstyle-nums</a> ]</pre>

  <pre class=prod><dfn
   id=numeric-spacing-values><var>&lt;numeric-spacing-values&gt;</var></dfn>  = [ <a
   href="#proportional-nums">proportional-nums</a> | <a
   href="#tabular-nums">tabular-nums</a> ]</pre>

  <pre class=prod><dfn
   id=numeric-fraction-values><var>&lt;numeric-fraction-values&gt;</var></dfn> = [ <a
   href="#diagonal-fractions">diagonal-fractions</a> | <a
   href="#stacked-fractions">stacked-fractions</a> ]</pre>

  <p>Individual values have the following meanings:

  <dl>
   <dt><dfn id=font-variant-numeric-normal-value
    title="normal!!font-variant-numeric">normal</dfn>

   <dd>None of the features listed below are enabled.

   <dt><dfn id=lining-nums>lining-nums</dfn>

   <dd>Enables display of lining numerals (OpenType feature: <span
    class=tag>lnum</span>).

   <dt><dfn id=oldstyle-nums>oldstyle-nums</dfn>

   <dd>Enables display of old-style numerals (OpenType feature: <span
    class=tag>onum</span>).

   <dt><dfn id=proportional-nums>proportional-nums</dfn>

   <dd>Enables display of proportional numerals (OpenType feature: <span
    class=tag>pnum</span>).

   <dt><dfn id=tabular-nums>tabular-nums</dfn>

   <dd>Enables display of tabular numerals (OpenType feature: <span
    class=tag>tnum</span>).

   <dt><dfn id=diagonal-fractions>diagonal-fractions</dfn>

   <dd>Enables display of lining diagonal fractions (OpenType feature: <span
    class=tag>frac</span>).
  </dl>

  <div class=featex><img alt="diagonal fraction example" src=frac.png></div>

  <dl>
   <dt><dfn id=stacked-fractions>stacked-fractions</dfn>

   <dd>Enables display of lining stacked fractions (OpenType feature: <span
    class=tag>afrc</span>).
  </dl>

  <div class=featex><img alt="stacked fraction example" src=afrc.png></div>

  <dl>
   <dt><dfn id=ordinal>ordinal</dfn>

   <dd>Enables display of letter forms used with ordinal numbers (OpenType
    feature: <span class=tag>ordn</span>).
  </dl>

  <div class=featex><img alt="ordinals example" src=ordinals.png></div>

  <dl>
   <dt><dfn id=slashed-zero>slashed-zero</dfn>

   <dd>Enables display of slashed zeros (OpenType feature: <span
    class=tag>zero</span>).
  </dl>

  <div class=featex><img alt="slashed zero example" src=zero.png></div>

  <div class=example id=ordinal-example>
   <p>In the case of ‘<a href="#ordinal"><code
    class=property>ordinal</code></a>’, although ordinal forms are often
    the same as superscript forms, they are marked up differently.

   <p>For superscripts, the variant property is only applied to the
    sub-element containing the superscript:

   <pre>
sup { font-variant-position: super; }
x&lt;sup&gt;2&lt;/sup&gt;
</pre>

   <p>For ordinals, the variant property is applied to the entire ordinal
    number rather than just to the suffix (or to the containing paragraph):

   <pre>
.ordinal { font-variant-numeric: ordinal; }
&lt;span class="ordinal"&gt;17th&lt;/span&gt;
</pre>

   <p>In this case only the "th" will appear in ordinal form, the digits will
    remain unchanged. Depending upon the typographic traditions used in a
    given language, ordinal forms may differ from superscript forms. In
    Italian, for example, ordinal forms sometimes include an underline in the
    ordinal design.
  </div>

  <div class=example id=steak-marinade>
   <p>A simple flank steak marinade recipe, rendered with automatic fractions
    and old-style numerals:

   <pre>.amount { font-variant-numeric: oldstyle-nums diagonal-fractions; }

&lt;h4>Steak marinade:&lt;/h4>
&lt;ul>
  &lt;li>&lt;span class="amount">2&lt;/span> tbsp olive oil&lt;/li>
  &lt;li>&lt;span class="amount">1&lt;/span> tbsp lemon juice&lt;/li>
  &lt;li>&lt;span class="amount">1&lt;/span> tbsp soy sauce&lt;/li>
  &lt;li>&lt;span class="amount">1 1/2&lt;/span> tbsp dry minced onion&lt;/li>
  &lt;li>&lt;span class="amount">2 1/2&lt;/span> tsp italian seasoning&lt;/li>
  &lt;li>Salt &amp;amp; pepper&lt;/li>
&lt;/ul>

&lt;p>Mix the meat with the marinade and let it sit covered in the refrigerator
for a few hours or overnight.&lt;/p>
</pre>

   <p>Note that the fraction feature is only applied to values not the entire
    paragraph. Fonts often implement this feature using contextual rules
    based on the use of the slash (‘<code class=css>/</code>’) character.
    As such, it's not suitable for use as a paragraph-level style.
  </div>
  <!-- prop: font-variant-alternates -->
  <!-- moved to Fonts 4 -->

  <h3 id=font-variant-east-asian-prop><span class=secno>6.8. </span>East
   Asian text rendering: the <a
   href="#propdef-font-variant-east-asian">font-variant-east-asian</a>
   property</h3>

  <table class=propdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn
      id=propdef-font-variant-east-asian>font-variant-east-asian</dfn>

    <tr>
     <td>Value:

     <td><a href="#font-variant-east-asian-normal-value"
      title="normal!!font-variant-east-asian">normal</a> | [ <a
      href="#east-asian-variant-values"><var>&lt;east-asian-variant-values&gt;</var></a>
      || <a
      href="#east-asian-width-values"><var>&lt;east-asian-width-values&gt;</var></a>
      || <a href="#ruby">ruby</a> ]

    <tr>
     <td>Initial:

     <td>normal

    <tr>
     <td>Applies to:

     <td>all elements

    <tr>
     <td>Inherited:

     <td>yes

    <tr>
     <td>Percentages:

     <td>N/A

    <tr>
     <td>Computed value:

     <td>as specified

    <tr>
     <td>Animatable:

     <td>no
  </table>

  <p>Allows control of glyph substitution and sizing in East Asian text.

  <pre class=prod><dfn
   id=east-asian-variant-values><var>&lt;east-asian-variant-values&gt;</var></dfn> = [ <a
   href="#jis78">jis78</a> | <a href="#jis83">jis83</a> | <a
   href="#jis90">jis90</a> | <a href="#jis04">jis04</a> | <a
   href="#simplified">simplified</a> | <a
   href="#traditional">traditional</a> ]</pre>

  <pre class=prod><dfn
   id=east-asian-width-values><var>&lt;east-asian-width-values&gt;</var></dfn>   = [ <a
   href="#full-width">full-width</a> | <a
   href="#proportional-width">proportional-width</a> ]</pre>

  <p>Individual values have the following meanings:

  <dl>
   <dt><dfn id=font-variant-east-asian-normal-value
    title="normal!!font-variant-east-asian">normal</dfn>

   <dd>None of the features listed below are enabled.

   <dt><dfn id=jis78>jis78</dfn>

   <dd>Enables rendering of JIS78 forms (OpenType feature: <span
    class=tag>jp78</span>).
  </dl>

  <div class=featex><img alt="JIS78 form example" src=jp78.png></div>

  <dl>
   <dt><dfn id=jis83>jis83</dfn>

   <dd>Enables rendering of JIS83 forms (OpenType feature: <span
    class=tag>jp83</span>).

   <dt><dfn id=jis90>jis90</dfn>

   <dd>Enables rendering of JIS90 forms (OpenType feature: <span
    class=tag>jp90</span>).

   <dt><dfn id=jis04>jis04</dfn>

   <dd>Enables rendering of JIS2004 forms (OpenType feature: <span
    class=tag>jp04</span>).
    <p>The various JIS variants reflect the glyph forms defined in different
     Japanese national standards. Fonts generally include glyphs defined by
     the most recent national standard but it's sometimes necessary to use
     older variants, to match signage for example.

   <dt><dfn id=simplified>simplified</dfn>

   <dd>Enables rendering of simplified forms (OpenType feature: <span
    class=tag>smpl</span>).

   <dt><dfn id=traditional>traditional</dfn>

   <dd>Enables rendering of traditional forms (OpenType feature: <span
    class=tag>trad</span>).
  </dl>

  <p>The ‘<a href="#simplified"><code
   class=property>simplified</code></a>’ and ‘<a
   href="#traditional"><code class=property>traditional</code></a>’ values
   allow control over the glyph forms for characters which have been
   simplified over time but for which the older, traditional form is still
   used in some contexts. The exact set of characters and glyph forms will
   vary to some degree by context for which a given font was designed.

  <div class=featex><img alt="tradtional form example" src=trad.png></div>

  <dl>
   <dt><dfn id=full-width>full-width</dfn>

   <dd>Enables rendering of full-width variants (OpenType feature: <span
    class=tag>fwid</span>).

   <dt><dfn id=proportional-width>proportional-width</dfn>

   <dd>Enables rendering of proportionally-spaced variants (OpenType feature:
    <span class=tag>pwid</span>).
  </dl>

  <div class=featex><img alt="proportionally spaced Japanese example"
   src=pwid.png></div>

  <dl>
   <dt><dfn id=ruby>ruby</dfn>

   <dd>Enables display of ruby variant glyphs (OpenType feature: <a class=tag
    href="#ruby">ruby</a>). Since ruby text is generally smaller than the
    associated body text, font designers can design special glyphs for use
    with ruby that are more readable than scaled down versions of the default
    glyphs. Only glyph selection is affected, there is no associated font
    scaling or other change that affects line layout. The red ruby text below
    is shown with default glyphs (top) and with ruby variant glyphs (bottom).
    Note the slight difference in stroke thickness.
  </dl>

  <div class=featex><img alt="ruby variant example" src=rubyshinkansen.png></div>

  <h3 id=font-variant-prop><span class=secno>6.9. </span>Overall shorthand
   for font rendering: the <a href="#propdef-font-variant">font-variant</a>
   property</h3>

  <table class=propdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=propdef-font-variant
      title="font-variant!!property">font-variant</dfn>

    <tr>
     <td>Value:

     <td><a href="#font-variant-normal-value"
      title="normal!!font-variant">normal</a> | <a
      href="#font-variant-none-value" title="none!!font-variant">none</a> | [
      <a href="#common-lig-values"><var>&lt;common-lig-values&gt;</var></a>
      || <a
      href="#discretionary-lig-values"><var>&lt;discretionary-lig-values&gt;</var></a>
      || <a
      href="#historical-lig-values"><var>&lt;historical-lig-values&gt;</var></a>
      || <a
      href="#contextual-alt-values"><var>&lt;contextual-alt-values&gt;</var></a>
      ||
      <!-- <var title="stylistic">stylistic(&lt;feature-value-name&gt;)</var> || <var>historical-forms</var> ||
        <var title="styleset">styleset(&lt;feature-value-name&gt; #)</var> ||
        <var title="character-variant">character-variant(&lt;feature-value-name&gt; #)</var> ||
        <var title="swash">swash(&lt;feature-value-name&gt;)</var> || <var title="ornaments">ornaments(&lt;feature-value-name&gt;)</var> ||
        <var title="annotation">annotation(&lt;feature-value-name&gt;)</var> || -->
      [ <a href="#small-caps"><i>small-caps</i></a> | <a
      href="#all-small-caps"><i>all-small-caps</i></a> | <a
      href="#petite-caps"><i>petite-caps</i></a> | <a
      href="#all-petite-caps"><i>all-petite-caps</i></a> | <a
      href="#unicase"><i>unicase</i></a> | <a
      href="#titling-caps"><i>titling-caps</i></a> ] || <a
      href="#numeric-figure-values"><var>&lt;numeric-figure-values&gt;</var></a>
      || <a
      href="#numeric-spacing-values"><var>&lt;numeric-spacing-values&gt;</var></a>
      || <a
      href="#numeric-fraction-values"><var>&lt;numeric-fraction-values&gt;</var></a>
      || <a href="#ordinal"><i>ordinal</i></a> || <a
      href="#slashed-zero"><i>slashed-zero</i></a> || <a
      href="#east-asian-variant-values"><var>&lt;east-asian-variant-values&gt;</var></a>
      || <a
      href="#east-asian-width-values"><var>&lt;east-asian-width-values&gt;</var></a>
      || <a href="#ruby"><i>ruby</i></a> || [ <a href="#sub"><i>sub</i></a> |
      <a href="#super"><i>super</i></a> ] ]

    <tr>
     <td>Initial:

     <td>normal

    <tr>
     <td>Applies to:

     <td>all elements

    <tr>
     <td>Inherited:

     <td>yes

    <tr>
     <td>Percentages:

     <td>see individual properties

    <tr>
     <td>Computed value:

     <td>see individual properties

    <tr>
     <td>Animatable:

     <td>see individual properties
  </table>

  <p>The <a href="#propdef-font-variant"
   title="font-variant!!property">‘<code
   class=property>font-variant</code>’</a> property is a shorthand for all
   font-variant subproperties. The value <dfn id=font-variant-normal-value
   title="normal!!font-variant">‘<code
   class=property>normal</code>’</dfn> resets all subproperties of <a
   href="#propdef-font-variant" title="font-variant!!property">‘<code
   class=property>font-variant</code>’</a> to their inital value. The <dfn
   id=font-variant-none-value title="none!!font-variant">‘<code
   class=property>none</code>’</dfn> value sets ‘<a
   href="#propdef-font-variant-ligatures"><code
   class=property>font-variant-ligatures</code></a>’ to ‘<code
   class=property>none</code>’ and resets all other font feature properties
   to their initial value. Like other shorthands, using <a
   href="#propdef-font-variant" title="font-variant!!property">‘<code
   class=property>font-variant</code>’</a> resets unspecified <a
   href="#propdef-font-variant" title="font-variant!!property">‘<code
   class=property>font-variant</code>’</a> subproperties to their initial
   values. It does not reset the values of
   <!-- either 'font-language-override' or --> <a
   href="#propdef-font-feature-settings"
   title="font-feature-settings!!property">‘<code
   class=property>font-feature-settings</code>’</a>.

  <h3 id=font-feature-settings-prop><span class=secno>6.10. </span>Low-level
   font feature settings control: the <a
   href="#propdef-font-feature-settings">font-feature-settings</a> property</h3>

  <table class=propdef>
   <tbody>
    <tr>
     <td>Name:

     <td><dfn id=propdef-font-feature-settings
      title="font-feature-settings!!property">font-feature-settings</dfn>

    <tr>
     <td>Value:

     <td><a href="#font-feature-settings-normal-value"
      title="normal!!font-feature-settings">normal</a> | <a
      href="#feature-tag-value"><var>&lt;feature-tag-value&gt;</var></a> #

    <tr>
     <td>Initial:

     <td>normal

    <tr>
     <td>Applies to:

     <td>all elements

    <tr>
     <td>Inherited:

     <td>yes

    <tr>
     <td>Percentages:

     <td>N/A

    <tr>
     <td>Computed value:

     <td>as specified

    <tr>
     <td>Animatable:

     <td>no
  </table>

  <p>This property provides low-level control over OpenType font features. It
   is intended as a way of providing access to font features that are not
   widely used but are needed for a particular use case.

  <p class=advisement>Authors should generally use <a
   href="#propdef-font-variant" title="font-variant!!property">‘<code
   class=property>font-variant</code>’</a> and its related subproperties
   whenever possible and only use this property for special cases where its
   use is the only way of accessing a particular infrequently used font
   feature.

  <pre>/* enable small caps and use second swash alternate */
font-feature-settings: "smcp", "swsh" 2;</pre>

  <p>A value of <dfn id=font-feature-settings-normal-value
   title="normal!!font-feature-settings">‘<code
   class=property>normal</code>’</dfn> means that no change in glyph
   selection or positioning occurs due to this property.

  <p>Feature tag values have the following syntax:

  <pre class=prod><dfn
   id=feature-tag-value><var>&lt;feature-tag-value&gt;</var></dfn> = &lt;string&gt; [ &lt;integer&gt; | on | off ]?</pre>

  <p>The &lt;string&gt; is a case-sensitive OpenType feature tag. As
   specified in the OpenType specification <a href="#ref-OPENTYPE"
    >[OPENTYPE]<!--{{!OPENTYPE}}--></a>, feature tags contain
   four ASCII characters. Tag strings longer or shorter than four characters,
   or containing characters outside the U+20–7E codepoint range are
   invalid. Feature tags need only match a feature tag defined in the font,
   so they are not limited to explicitly registered OpenType features. Fonts
   defining custom feature tags should follow the <a
   href="https://www.microsoft.com/typography/otspec/featuretags.htm">tag
   name rules</a> defined in the OpenType specification <a
   href="#ref-OPENTYPE-FEATURES"
    >[OPENTYPE-FEATURES]<!--{{!OPENTYPE-FEATURES}}--></a>.

  <p>Feature tags not present in the font are ignored; a user agent must not
   attempt to synthesize fallback behavior based on these feature tags. The
   one exception is that user agents may synthetically support the <span
   class=tag>kern</span> feature with fonts that contain kerning data in the
   form of a ‘<code class=property>kern</code>’ table but lack <span
   class=tag>kern</span> feature support in the ‘<code
   class=property>GPOS</code>’ table.

  <p class=note>In general, authors should use the ‘<a
   href="#propdef-font-kerning"><code
   class=property>font-kerning</code></a>’ property to explicitly enable or
   disable kerning since this property always affects fonts with either type
   of kerning data.

  <p>If present, a value indicates an index used for glyph selection. An
   &lt;integer&gt; value must be 0 or greater. A value of 0 indicates that
   the feature is disabled. For boolean features, a value of 1 enables the
   feature. For non-boolean features, a value of 1 or greater enables the
   feature and indicates the feature selection index. A value of ‘<code
   class=property>on</code>’ is synonymous with 1 and ‘<code
   class=property>off</code>’ is synonymous with 0. If the value is
   omitted, a value of 1 is assumed.

  <p id=ffs-map>The computed value of font-feature-settings is a map, so any
   duplicates in the specified value must not be preserved. If the same axis
   name appears more than once, the value associated with the last appearance
   supersedes any previous value for that axis.

  <pre>
font-feature-settings: "dlig" 1;       /* dlig=1 enable discretionary ligatures */
font-feature-settings: "smcp" on;      /* smcp=1 enable small caps */
font-feature-settings: 'c2sc';         /* c2sc=1 enable caps to small caps */
font-feature-settings: "liga" off;     /* liga=0 no common ligatures */
font-feature-settings: "tnum", 'hist'; /* tnum=1, hist=1 enable tabular numbers and historical forms */
font-feature-settings: "tnum" "hist";  /* invalid, need a comma-delimited list */
font-feature-settings: "silly" off;    /* invalid, tag too long */
font-feature-settings: "PKRN";         /* PKRN=1 enable custom feature */
font-feature-settings: dlig;           /* invalid, tag must be a string */
</pre>

  <p>When values greater than the range supported by the font are specified,
   the behavior is explicitly undefined. For boolean features, in general
   these will enable the feature. For non-boolean features, out of range
   values will in general be equivalent to a 0 value. However, in both cases
   the exact behavior will depend upon the way the font is designed
   (specifically, which type of lookup is used to define the feature).

  <p>Although specifically defined for OpenType feature tags, feature tags
   for other modern font formats that support font features may be added in
   the future. Where possible, features defined for other font formats should
   attempt to follow the pattern of registered OpenType tags.

  <div class=example>
   <p>The Japanese text below will be rendered with half-width kana
    characters:

   <pre lang=ja>
body { font-feature-settings: "hwid"; /* Half-width OpenType feature */ }

&lt;p>毎日<a
    href="https://example.com/?q=%E3%82%AB%E3%83%AC%E3%83%BC"
    style="text-decoration: none;">カレー</a>食べてるのに、飽きない&lt;/p>
</pre>
  </div>

  <p><a id=rendering-considerations></a>

  <h2 id=font-feature-resolution><span class=secno>7. </span>Font Feature
   Resolution</h2>

  <p>As described in the previous section, font features can be enabled in a
   variety of ways, either via the use of <a href="#propdef-font-variant"
   title="font-variant!!property">‘<code
   class=property>font-variant</code>’</a> or <a
   href="#propdef-font-feature-settings"
   title="font-feature-settings!!property">‘<code
   class=property>font-feature-settings</code>’</a> in a style rule or
   within an <a href="#at-font-face-rule"><code>@font-face</code></a> rule.
   The resolution order for the union of these settings is defined below.
   Features defined via CSS properties are applied on top of layout engine
   default features.

  <h3 id=default-features><span class=secno>7.1. </span>Default features</h3>

  <p>For OpenType fonts, user agents must enable the default features defined
   in the OpenType documentation for a given script and writing mode.
   Required ligatures, common ligatures and contextual forms must be enabled
   by default (OpenType features: <span class=tag>rlig, liga, clig,
   calt</span>), along with localized forms (OpenType feature: <span
   class=tag>locl</span>), and features required for proper display of
   composed characters and marks (OpenType features: <span class=tag>ccmp,
   mark, mkmk</span>). These features must always be enabled, even when the
   value of the <a href="#propdef-font-variant"
   title="font-variant!!property">‘<code
   class=property>font-variant</code>’</a> and <a
   href="#propdef-font-feature-settings"
   title="font-feature-settings!!property">‘<code
   class=property>font-feature-settings</code>’</a> properties is <span
   title="normal value">‘<code class=property>normal</code>’</span>.
   Individual features are only disabled when explicitly overridden by the
   author, as when ‘<a href="#propdef-font-variant-ligatures"><code
   class=property>font-variant-ligatures</code></a>’ is set to ‘<a
   href="#no-common-ligatures"><code
   class=property>no-common-ligatures</code></a>’. For handling complex
   scripts such as <a
   href="https://docs.microsoft.com/en-us/typography/script-development/arabic">Arabic</a>
   <a href="#ref-ARABIC-TYPO"
    >[ARABIC-TYPO]<!--{{ARABIC-TYPO}}--></a>, <a
   href="https://docs.microsoft.com/en-us/typography/script-development/khmer">Khmer</a>
   or <a
   href="https://docs.microsoft.com/en-us/typography/script-development/devanagari">Devanagari</a>
   additional features are required. For upright text within vertical text
   runs, vertical alternates (OpenType feature: <span class=tag>vert</span>)
   must be enabled.

  <h3 id=feature-precedence><span class=secno>7.2. </span>Feature precedence</h3>

  <p>General and <em>font specific</em> font feature property settings are
   resolved in the order below, in ascending order of precedence. This
   ordering is used to construct a combined list of font features that affect
   a given text run.

  <ol>
   <li>Font features enabled by default, including features required for a
    given script.

   <li>If the font is defined via an <a
    href="#at-font-face-rule"><code>@font-face</code></a> rule, the font
    features implied by the font-feature-settings descriptor in the <a
    href="#at-font-face-rule"><code>@font-face</code></a> rule.

   <li>Font features implied by the value of the <a
    href="#propdef-font-variant" title="font-variant!!property">‘<code
    class=property>font-variant</code>’</a> property, the related <a
    href="#propdef-font-variant" title="font-variant!!property">‘<code
    class=property>font-variant</code>’</a> subproperties and any other CSS
    property that uses OpenType features (e.g. the ‘<a
    href="#propdef-font-kerning"><code
    class=property>font-kerning</code></a>’ property).</li>
   <!-- other CSS props override 'font-variant' but not 'font-feature-settings' -->
   <!-- http://lists.w3.org/Archives/Public/www-style/2013Aug/0110.html -->

   <li>Feature settings determined by properties other than <a
    href="#propdef-font-variant" title="font-variant!!property">‘<code
    class=property>font-variant</code>’</a> or <a
    href="#propdef-font-feature-settings"
    title="font-feature-settings!!property">‘<code
    class=property>font-feature-settings</code>’</a>. For example, setting
    a non-default value for the ‘<code
    class=property>letter-spacing</code>’ property disables optional
    ligatures.

   <li>Font features implied by the value of <a
    href="#propdef-font-feature-settings"
    title="font-feature-settings!!property">‘<code
    class=property>font-feature-settings</code>’</a> property.
  </ol>

  <p>This ordering allows authors to set up a general set of defaults for
   fonts within their <a
   href="#at-font-face-rule"><code>@font-face</code></a> rules, then override
   them with property settings for specific elements. General property
   settings override the settings in <a
   href="#at-font-face-rule"><code>@font-face</code></a> rules and low-level
   font feature settings override <a href="#propdef-font-variant"
   title="font-variant!!property">‘<code
   class=property>font-variant</code>’</a> property settings.

  <p>For situations where the combined list of font feature settings contains
   more than one value for the same feature, the last value is used. When a
   font lacks support for a given underlying font feature, text is simply
   rendered as if that font feature was not enabled; font fallback does not
   occur and no attempt is made to synthesize the feature except where
   explicitly defined for specific properties.

  <h3 id=feature-precedence-examples><span class=secno>7.3. </span>Feature
   precedence examples</h3>

  <div class=example>
   <p>With the styles below, numbers are rendered proportionally when used
    within a paragraph but are shown in tabular form within tables of prices:

   <pre>body {
  font-variant-numeric: proportional-nums;
}

table.prices td {
  font-variant-numeric: tabular-nums;
}
</pre>
  </div>
  <!-- <div class="example">
<p>When the <span title="font-variant!!descriptor">font-variant</span> descriptor
is used within an <code>@font-face</code> rule, it only
applies to the font defined by that rule.</p>

<pre>@font-face {
  font-family: MainText;
  src: url(http://example.com/font.woff);
  font-variant: oldstyle-nums proportional-nums styleset(1,3);
}

body {
  font-family: MainText, Helvetica;
}

table.prices td {
  font-variant-numeric: tabular-nums;
}
</pre>

<p>In this case, old-style numerals will be used throughout but only
where the font "MainText" is used. Just as in the previous example,
tabular values will be used in price tables since 'tabular-nums'
appears in a general style rule and its use is mutually exclusive with
'proportional-nums'.  Stylistic alternate sets will only be used where
MainText is used.</p> </div>
-->
  <!-- <div class="example">
<p>The <code>@font-face</code> rule can also be used to access font features in locally available
fonts via the use of <code>local()</code> in the 'src' descriptor of the <code>@font-face</code> definition:</p>

<pre>@font-face {
  font-family: BodyText;
  src: local("HiraMaruPro-W4");
  font-variant: proportional-width;
  font-feature-settings: "ital"; /* Latin italics within CJK text feature */
}

body { font-family: BodyText, serif; }
</pre>

<p>If available, a Japanese font "Hiragino Maru Gothic" will be used.  When text
rendering occurs, Japanese kana will be proportionally spaced and Latin text will
be italicised.  Text rendered with the fallback serif font will use default
rendering properties.</p>
</div> -->
  <!-- <div class="example">
<p>In the example below, discretionary ligatures are enabled only for a downloadable font
but are disabled within spans of class "special":</p>

<pre>@font-face {
  font-family: main;
  src: url(fonts/ffmeta.woff) format("woff");
  font-variant: discretionary-ligatures;
}

body         { font-family: main, Helvetica; }
span.special { font-variant-ligatures: no-discretionary-ligatures; }
</pre>

<p>Suppose one adds a rule using 'font-feature-settings' to enable discretionary ligatures:</p>

<pre>body         { font-family: main, Helvetica; }
span         { font-feature-settings: "dlig"; }
span.special { font-variant-ligatures: no-discretionary-ligatures; }
</pre>

<p>In this case, discretionary ligatures <em>will</em> be rendered within spans of class "special".
This is because both the <span title="font-feature-settings!!property">'font-feature-settings'</span> and 'font-variant-ligatures' properties
apply to these spans.  Although the 'no-discretionary ligatures' setting of 'font-variant-ligatures'
effectively disables the OpenType <span class="tag">dlig</span> feature, because the <span title="font-feature-settings!!property">'font-feature-settings'</span>
is resolved after that, the 'dlig' value reenables discretionary ligatures.</p>
</div> -->

  <h2 id=object-model><span class=secno>8. </span>Object Model</h2>

  <p>The contents of <a href="#at-font-face-rule"><code>@font-face</code></a>
   rules can be accessed via the following extension to the CSS Object Model.

  <h3 id=om-fontface><span class=secno>8.1. </span>The <a
   href="#cssfontfacerule"><code>CSSFontFaceRule</code></a> interface</h3>

  <p>The <dfn id=cssfontfacerule>CSSFontFaceRule</dfn> interface represents a
   <a href="#at-font-face-rule"><code>@font-face</code></a> rule.

  <pre class=idl>
interface CSSFontFaceRule : CSSRule {
    readonly attribute CSSStyleDeclaration style;
};</pre>

  <h2 class=no-num id=platform-props-to-css>Appendix A: Mapping platform font
   properties to CSS properties</h2>

  <p><em>This appendix is included as background for some of the problems and
   situations that are described in other sections. It should be viewed as
   informative only.</em>

  <p>Font properties in CSS are designed to be independent of the underlying
   font formats used; they can be used to specify bitmap fonts, Type1 fonts,
   SVG fonts in addition to the common TrueType and OpenType fonts. But there
   are facets of the TrueType and OpenType formats that often cause confusion
   for authors and present challenges to implementers on different platforms.

  <p>Originally developed at Apple, TrueType [[TRUETYPE]] was designed as an
   outline font format for both screen and print. Microsoft joined Apple in
   developing the TrueType format and both platforms have supported TrueType
   fonts since then. Font data in the TrueType format consists of a set of
   tables distinguished with common four-letter tag names, each containing a
   specific type of data. For example, naming information, including
   copyright and license information, is stored in the ‘<code
   class=property>name</code>’ table. The <a
   href="#character-map"><em>character map</em></a> (‘<code
   class=property>cmap</code>’) table contains a mapping of character
   encodings to glyphs. Apple later added additional tables for supporting
   enhanced typographic functionality; these are now called Apple Advanced
   Typography, or AAT, fonts. Microsoft and Adobe developed a separate set of
   tables for advanced typography and called their format OpenType <a
   href="#ref-OPENTYPE"  >[OPENTYPE]<!--{{OPENTYPE}}--></a>.
   The OpenType specification is standardized at ISO as the Open Font Format
   <a href="#ref-OPEN-FONT-FORMAT"
    >[OPEN-FONT-FORMAT]<!--{{OPEN-FONT-FORMAT}}--></a>.

  <p>In many cases the font data used under Microsoft Windows or Linux is
   slightly different from the data used under Apple's Mac OS X because the
   TrueType format allowed for explicit variation across platforms. This
   includes font metrics, names and <a href="#character-map"><em>character
   map</em></a> data.

  <p>Specifically, font family name data is handled differently across
   platforms. For TrueType and OpenType fonts these names are contained in
   the ‘<code class=property>name</code>’ table, in name records with
   name ID 1. Multiple names can be stored for different locales, but
   Microsoft recommends fonts always include at least a US English version of
   the name. On Windows, Microsoft made the decision for backwards
   compatibility to limit this family name to a maximum of four faces; for
   larger groupings the "preferred family" (name ID 16) or "WWS family" (name
   ID 21) can be used. Other platforms such as OSX don't have this
   limitation, so the family name is used to define all possible groupings.

  <p>Other name table data provides names used to uniquely identify a
   specific face within a family. The full font name (name ID 4) and the
   Postscript name (name ID 6) describe a single face uniquely. For example,
   the bold face of the Gill Sans family has a fullname of "Gill Sans Bold"
   and a Postscript name of "GillSans-Bold". There can be multiple localized
   versions of the fullname for a given face, but the Postscript name is
   always a unique name made from a limited set of ASCII characters.

  <p>On various platforms, different names are used to search for a font. For
   example, with the Windows GDI CreateIndirectFont API, either a family or
   fullname can be used to lookup a face, while on Mac OS X the
   CTFontCreateWithName API call is used to lookup a given face using the
   fullname and Postscript name. Under Linux, the fontconfig API allows fonts
   to be searched using any of these names. In situations where platform
   API's automatically substitute other font choices, it may be necessary to
   verify a returned font matches a given name.

  <p>The weight of a given face can be determined via the usWeightClass field
   of the OS/2 table or inferred from the style name (name ID 2). Likewise,
   the width can be determined via the usWidthClass of the OS/2 table or
   inferred from the style name. For historical reasons related to synthetic
   bolding at weights 200 or lower with the Windows GDI API, font designers
   have sometimes skewed values in the OS/2 table to avoid these weights.

  <p>Rendering complex scripts that use contextual shaping such as Thai,
   Arabic and Devanagari requires features present only in OpenType or AAT
   fonts. Currently, complex script rendering is supported on Windows and
   Linux using OpenType font features while both OpenType and AAT font
   features are used under Mac OS X.

  <h2 class=no-num id=ch-ch-ch-changes>Changes</h2>

  <h3 class="no-num" id="super-recent-changes">Changes from the <a href="https://www.w3.org/TR/2018/PR-css-fonts-3-20180814/">14 August 2018 CSS Fonts 3 Proposed Recommendation</a></h3>

  <ul>
    <li>Features mentioned in the changelog as having been moved to CSS Fonts 4, now
      link to the corresponding section in that specification</li>
    <li>Date and boilerplate updates for W3C Recommendation</li>
    <li>Unicode reference updated to latest version</li>
    <li>Updated this changes section</li>

  </ul>

  <h3 class=no-num id=recent-changes> Changes from the <a
   href="https://www.w3.org/TR/2018/CR-css-fonts-3-20180315/">March 15 2018
   CSS Fonts 3 Candidate Recommendation</a></h3>

  <ul>
   <li>‘<code class=property>font-variant</code>’ descriptor moved to
    <a href="https://drafts.csswg.org/css-fonts-4/#font-rend-desc">CSS Fonts 4</a> due to lack of implementations

   <li>‘<code class=property>font-feature-values</code>’ at-rule moved to
    <a href="https://drafts.csswg.org/css-fonts-4/#font-display-font-feature-values">CSS Fonts 4</a> due to lack of implementations

   <li>clarified handling of unknown fragment identifiers

    <li>linked to CSS Values & Units for definition of length-percentage</li>
  </ul>

  <h3 class=no-num id=less-recent-changes> Changes from the <a
   href="https://www.w3.org/TR/2013/CR-css-fonts-3-20131003/">October 2013
   CSS3 Fonts Candidate Recommendation</a></h3>

  <ul>
   <li>‘<code class=property>font-language-override</code>’ property
    moved to <a href="https://drafts.csswg.org/css-fonts-4/#font-language-override-prop">CSS Fonts 4</a>

   <li>CSSFontFeatureValuesRule interface moved to <a href="https://drafts.csswg.org/css-fonts-4/#om-fontfeaturevalues">CSS Fonts 4</a>

   <li>CSSFontFaceRule interface reverted to the widely implemented one from
    DOM Level 2 style

   <li>clarified that generic font families may be composite faces

   <li>clarified that "first available font" is one that would match the
    U+0020 (space) character

   <li>clarified how small-caps synthesis interacts with ‘<code
    class=property>font-feature-settings</code>’

   <li>all CSS keywords marked as invalid font family names

   <li>clarified that ‘<a href="#propdef-font-synthesis"><code
    class=property>font-synthesis</code></a>’ is not reset by the ‘<a
    href="#propdef-font"><code class=property>font</code></a>’ shorthand.

   <li>use the phrase "installed fonts" rather than "system fonts"

   <li>clarified that malformed @font-face rules which lack font-family: or
    src: still show up in the DOM, but don't affect font selection

   <li>clarified conventional ratio range for the relative sizes when they're
    not modifying an absolute keyword size

   <li>clarified that for both font-variation-settings and
    font-feature-settings, the computed value is a map (and thus specified
    dupes are removed)

   <li>added omitted ‘<a href="#propdef-font-variant-position"><code
    class=property>font-variant-position</code></a>’ values to <a
    href="#propdef-font-variant" title="font-variant!!property">‘<code
    class=property>font-variant</code>’</a> shorthand

   <li>made negative values for font-size-adjust invalid, along with negative
    percentage font-size values

   <li>removed the requirement that user agents use OS/2 table
    subscript/superscript metrics

   <li>added informative link to CSS Text order of operations

   <li>added normative link to RFC 8081, the font top-level type

   <li>minor editorial cleanups
  </ul>

  <h2 class=no-num id=acknowledgments>Acknowledgments</h2>

  <p>We'd like to thank Tal Leming, Jonathan Kew, Ken Lunde and Christopher
   Slye for all their help and feedback. John Hudson was kind enough to take
   the time to explain the subtleties of OpenType language tags and provided
   the example of character variant usage for displaying text on Byzantine
   seals. Ken Lunde and Eric Muller provided valuable feedback on CJK
   OpenType features and Unicode variation selectors. The idea for supporting
   font features by using <a href="#propdef-font-variant"
   title="font-variant!!property">‘<code
   class=property>font-variant</code>’</a> subproperties originated with
   Håkon Wium Lie, Adam Twardoch and Tal Leming. Elika Etemad supplied some
   of the initial design ideas for the <code>@font-feature-values</code>
   rule. Thanks also to House Industries for allowing the use of Ed Interlock
   in the discretionary ligatures example.

  <p>A special thanks to Robert Bringhurst for the sublime mind expansion
   that is <em>The Elements of Typographic Style</em>.

  <h2 class=no-num id=conformance> Conformance</h2>

  <h3 class=no-num id=conventions> Document Conventions</h3>

  <p>Conformance requirements are expressed with a combination of descriptive
   assertions and RFC 2119 terminology. The key words “MUST”, “MUST
   NOT”, “REQUIRED”, “SHALL”, “SHALL NOT”, “SHOULD”,
   “SHOULD NOT”, “RECOMMENDED”, “MAY”, and “OPTIONAL” in the
   normative parts of this document are to be interpreted as described in RFC
   2119. However, for readability, these words do not appear in all uppercase
   letters in this specification.

  <p>All of the text of this specification is normative except sections
   explicitly marked as non-normative, examples, and notes. <a
   href="#ref-RFC2119"  >[RFC2119]<!--{{!RFC2119}}--></a>

  <p>Examples in this specification are introduced with the words “for
   example” or are set apart from the normative text with
   <code>class="example"</code>, like this:

  <div class=example>
   <p>This is an example of an informative example.
  </div>

  <p>Informative notes begin with the word “Note” and are set apart from
   the normative text with <code>class="note"</code>, like this:

  <p class=note>Note, this is an informative note.

  <h3 class=no-num id=conformance-classes> Conformance Classes</h3>

  <p>Conformance to CSS Fonts Level 3 Module is defined for three conformance
   classes:

  <dl>
   <dt><dfn id=style-sheet title="style sheet!!as conformance class">style
    sheet</dfn>

   <dd>A <a href="https://www.w3.org/TR/CSS21/conform.html#style-sheet">CSS
    style sheet</a>.

   <dt><dfn id=renderer>renderer</dfn>

   <dd>A <a href="https://www.w3.org/TR/CSS21/conform.html#user-agent">UA</a>
    that interprets the semantics of a style sheet and renders documents that
    use them.

   <dt><dfn id=authoring-tool>authoring tool</dfn>

   <dd>A <a href="https://www.w3.org/TR/CSS21/conform.html#user-agent">UA</a>
    that writes a style sheet.
  </dl>

  <p>A style sheet is conformant to CSS Fonts Level 3 Module if all of its
   declarations that use properties defined in this module have values that
   are valid according to the generic CSS grammar and the individual grammars
   of each property as given in this module.

  <p>A renderer is conformant to CSS Fonts Level 3 Module if, in addition to
   interpreting the style sheet as defined by the appropriate specifications,
   it supports all the features defined by CSS Fonts Level 3 Module by
   parsing them correctly and rendering the document accordingly. However,
   the inability of a UA to correctly render a document due to limitations of
   the device does not make the UA non-conformant. (For example, a UA is not
   required to render color on a monochrome monitor.)

  <p>An authoring tool is conformant to CSS Fonts Level 3 Module if it writes
   style sheets that are syntactically correct according to the generic CSS
   grammar and the individual grammars of each feature in this module, and
   meet all other conformance requirements of style sheets as described in
   this module.

  <h3 class=no-num id=partial> Partial Implementations</h3>

  <p>So that authors can exploit the forward-compatible parsing rules to
   assign fallback values, CSS renderers <strong>must</strong> treat as
   invalid (and <a
   href="https://www.w3.org/TR/CSS21/conform.html#ignore">ignore as
   appropriate</a>) any at-rules, properties, property values, keywords, and
   other syntactic constructs for which they have no usable level of support.
   In particular, user agents <strong>must not</strong> selectively ignore
   unsupported component values and honor supported values in a single
   multi-value property declaration: if any value is considered invalid (as
   unsupported values must be), CSS requires that the entire declaration be
   ignored.

  <h3 class=no-num id=experimental> Experimental Implementations</h3>

  <p>To avoid clashes with future CSS features, the CSS2.1 specification
   reserves a <a
   href="https://www.w3.org/TR/CSS21/syndata.html#vendor-keywords">prefixed
   syntax</a> for proprietary and experimental extensions to CSS.

  <p>Prior to a specification reaching the Candidate Recommendation stage in
   the W3C process, all implementations of a CSS feature are considered
   experimental. The CSS Working Group recommends that implementations use a
   vendor-prefixed syntax for such features, including those in W3C Working
   Drafts. This avoids incompatibilities with future changes in the draft.

  <h3 class=no-num id=testing> Non-Experimental Implementations</h3>

  <p>Once a specification reaches the Candidate Recommendation stage,
   non-experimental implementations are possible, and implementors should
   release an unprefixed implementation of any CR-level feature they can
   demonstrate to be correctly implemented according to spec.

  <p>To establish and maintain the interoperability of CSS across
   implementations, the CSS Working Group requests that non-experimental CSS
   renderers submit an implementation report (and, if necessary, the
   testcases used for that implementation report) to the W3C before releasing
   an unprefixed implementation of any CSS features. Testcases submitted to
   W3C are subject to review and correction by the CSS Working Group.

  <p>Further information on submitting testcases and implementation reports
   can be found from on the CSS Working Group's website at <a
   href="https://www.w3.org/Style/CSS/Test/">https://www.w3.org/Style/CSS/Test/</a>.
   Questions should be directed to the <a
   href="https://lists.w3.org/Archives/Public/public-css-testsuite">public-css-testsuite@w3.org</a>
   mailing list.


  <h2 class=no-num id=references>References</h2>

  <h3 class=no-num id=normative-references>Normative References</h3>
  <!--begin-normative-->
  <!-- Sorted by label -->

  <dl class=bibliography>

    <dt id="ref-CSS-VALUES">[CSS-VALUES]</dt>

    <dd><a href="https://www.w3.org/TR/css-values/">Tab Atkins Jr.; Elika Etemad.
      <cite>CSS Values and Units Module Level 3</cite></a>
      29 September 2016. CR. URL: <a href="https://www.w3.org/TR/css-values/">https://www.w3.org/TR/css-values/</a>
    </dd>

    <dt id="ref-FETCH">[FETCH]</dt>

    <dd><a href="https://fetch.spec.whatwg.org/"><cite>Fetch</cite></a>. WhatWG Living Standard.
        URL: <a href="https://fetch.spec.whatwg.org/">https://fetch.spec.whatwg.org/</a>
    </dd>

   <dt id=ref-OPENTYPE>[OPENTYPE]

   <dd><a
    href="http://www.microsoft.com/typography/otspec/default.htm"><cite>OpenType
    specification.</cite></a> Microsoft. URL: <a
    href="http://www.microsoft.com/typography/otspec/default.htm">http://www.microsoft.com/typography/otspec/default.htm</a>
   </dd>
   <!---->

   <dt id=ref-OPENTYPE-FEATURES>[OPENTYPE-FEATURES]

   <dd><a
    href="http://www.microsoft.com/typography/otspec/featurelist.htm"><cite>OpenType
    feature registry.</cite></a> Microsoft. URL: <a
    href="http://www.microsoft.com/typography/otspec/featurelist.htm">http://www.microsoft.com/typography/otspec/featurelist.htm</a>
   </dd>
   <!---->

   <dt id=ref-RFC2119>[RFC2119]

   <dd>S. Bradner. <a href="http://www.ietf.org/rfc/rfc2119.txt"><cite>Key
    words for use in RFCs to Indicate Requirement Levels.</cite></a> RFC
    2119. URL: <a
    href="http://www.ietf.org/rfc/rfc2119.txt">http://www.ietf.org/rfc/rfc2119.txt</a>
   </dd>
   <!---->

   <dt id="ref-RFC8081">[RFC8081]
    </dt><dd>C. Lilley. <a href="https://tools.ietf.org/html/rfc8081">The "font" Top-Level Media Type</a>. February 2017. Proposed Standard. URL: <a href="https://tools.ietf.org/html/rfc8081">https://tools.ietf.org/html/rfc8081</a>
    </dd>

   <dt id=ref-UAX15>[UAX15]

   <dd>Mark Davis; Ken Whistler. <a
    href="http://www.unicode.org/reports/tr15/"><cite>Unicode Normalization
    Forms.</cite></a> 31 August 2012. Unicode Standard Annex #15. URL: <a
    href="http://www.unicode.org/reports/tr15/">http://www.unicode.org/reports/tr15/</a>
   </dd>
   <!---->

   <dt id=ref-UNICODE>[UNICODE]

   <dd><a href="http://www.unicode.org/versions/latest/">The Unicode Standard</a>
    URL: <a href="http://www.unicode.org/versions/latest/">http://www.unicode.org/versions/latest</a>
   </dd>
   <!---->
  </dl>
  <!--end-normative-->

  <h3 class=no-num id=other-references>Other References</h3>
  <!--begin-informative-->
  <!-- Sorted by label -->

  <dl class=bibliography>

   <dt id=ref-AAT-FEATURES>[AAT-FEATURES]

   <dd><a href="https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html"><cite>Apple
    Advanced Typography font feature registry.</cite></a> Apple. URL: <a
    href="https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html">https://developer.apple.com/fonts/TrueType-Reference-Manual/RM09/AppendixF.html</a>
   </dd>
   <!---->

   <dt id=ref-ARABIC-TYPO>[ARABIC-TYPO]

   <dd>Huda Smitshuijzen AbiFares. <cite>Arabic Typography: A Comprehensive
    Sourcebook.</cite> Saqi Books. 2001. ISBN 0-86356-347-3.</dd>
   <!---->

   <dt id=ref-CHARMOD>[CHARMOD]

   <dd>Martin J. Dürst; et al. <a
    href="http://www.w3.org/TR/2005/REC-charmod-20050215/"><cite>Character
    Model for the World Wide Web 1.0: Fundamentals.</cite></a> 15 February
    2005. W3C Recommendation. URL: <a
    href="http://www.w3.org/TR/2005/REC-charmod-20050215/">http://www.w3.org/TR/2005/REC-charmod-20050215/</a>
   </dd>
   <!---->

   <dt id=ref-CHARMOD-NORM>[CHARMOD-NORM]

   <dd>Addison Phillips. <a
    href="https://www.w3.org/TR/2018/WD-charmod-norm-20180420/"><cite>Character
    Model for the World Wide Web: String Matching.</cite></a> 20 April 2018.
    W3C Working Draft. (Work in progress.) URL: <a
    href="https://www.w3.org/TR/2018/WD-charmod-norm-20180420/">https://www.w3.org/TR/2018/WD-charmod-norm-20180420/</a>
   </dd>
   <!---->

   <dt id=ref-CSS-TEXT-3>[CSS-TEXT-3]

   <dd>Elika J. Etemad / fantasai; Koji Ishii. <a
    href="https://www.w3.org/TR/2017/WD-css-text-3-20170822/"><cite>CSS Text
    Module Level 3.</cite></a> 22 August 2017. W3C Working Draft. (Work in
    progress.) URL: <a
    href="https://www.w3.org/TR/2017/WD-css-text-3-20170822/">https://www.w3.org/TR/2017/WD-css-text-3-20170822/</a>
   </dd>
   <!---->

   <dt id=ref-CSS3-CONDITIONAL>[CSS3-CONDITIONAL]

   <dd>L. David Baron. <a
    href="http://www.w3.org/TR/2013/CR-css3-conditional-20130404/"><cite>CSS
    Conditional Rules Module Level 3.</cite></a> 4 April 2013. W3C Candidate
    Recommendation. (Work in progress.) URL: <a
    href="http://www.w3.org/TR/2013/CR-css3-conditional-20130404/">http://www.w3.org/TR/2013/CR-css3-conditional-20130404/</a>
   </dd>
   <!---->

   <dt id=ref-OPEN-FONT-FORMAT>[OPEN-FONT-FORMAT]

   <dd><a
    href="http://standards.iso.org/ittf/PubliclyAvailableStandards/c052136_ISO_IEC_14496-22_2009%28E%29.zip"><cite>Information
    technology — Coding of audio-visual objects — Part 22: Open Font
    Format.</cite></a> International Organization for Standardization.
    ISO/IEC 14496-22:2009. URL: <a
    href="http://standards.iso.org/ittf/PubliclyAvailableStandards/c052136_ISO_IEC_14496-22_2009%28E%29.zip">http://standards.iso.org/ittf/PubliclyAvailableStandards/c052136_ISO_IEC_14496-22_2009%28E%29.zip</a>
   </dd>
   <!---->

   <dt id=ref-OPENTYPE-FONT-GUIDE>[OPENTYPE-FONT-GUIDE]

   <dd><a
    href="http://www.fontblog.de/wp-content/uploads/2015/11/FF_OTF_user_guide.pdf"><cite>OpenType
    User Guide.</cite></a> FontShop International. URL: <a
    href="http://www.fontblog.de/wp-content/uploads/2015/11/FF_OTF_user_guide.pdf">http://www.fontblog.de/wp-content/uploads/2015/11/FF_OTF_user_guide.pdf</a>
   </dd>
   <!---->

   <dt id="ref-TRUETYPE">[TRUETYPE]</dt>

   <dd><a href="https://developer.apple.com/fonts/TrueType-Reference-Manual/"><cite>TrueType™
     Reference Manual</cite></a>. Apple. URL: <a href="https://developer.apple.com/fonts/TrueType-Reference-Manual/">https://developer.apple.com/fonts/TrueType-Reference-Manual/</a> </dd>

   <dt id=ref-UAX29>[UAX29]

   <dd>Mark Davis. <a
    href="http://www.unicode.org/reports/tr29/"><cite>Unicode Text
    Segmentation.</cite></a> 12 September 2012. Unicode Standard Annex #29.
    URL: <a
    href="http://www.unicode.org/reports/tr29/">http://www.unicode.org/reports/tr29/</a>
   </dd>
   <!---->

   <dt id=ref-WINDOWS-GLYPH-PROC>[WINDOWS-GLYPH-PROC]

   <dd>John Hudson. <a
    href="http://www.microsoft.com/typography/developers/opentype/default.htm"><cite>Windows
    Glyph Processing.</cite></a> Microsoft Typogrraphy. URL: <a
    href="http://www.microsoft.com/typography/developers/opentype/default.htm">http://www.microsoft.com/typography/developers/opentype/default.htm</a>
   </dd>
   <!---->
  </dl>
  <!--end-informative-->

  <h2 class=no-num id=index>Index</h2>
  <!--begin-index-->

  <ul class=indexlist>
   <li>100...900 weight values, <a href="#font-weight-numeric-values"
    title="section 3.2."><strong>3.2.</strong></a>

   <li><var>&lt;absolute-size&gt;</var>, <a href="#absolute-size-value"
    title="section 3.5."><strong>3.5.</strong></a>

   <li>all-petite-caps, <a href="#all-petite-caps"
    title="section 6.6."><strong>6.6.</strong></a>

   <li>all-small-caps, <a href="#all-small-caps"
    title="section 6.6."><strong>6.6.</strong></a>

   <li>aspect value, <a href="#aspect-value0"
    title="section 3.6."><strong>3.6.</strong></a>

   <li>authoring tool, <a href="#authoring-tool"
    title="section ??"><strong>??</strong></a>

   <li>auto
    <ul>
     <li>font-kerning, <a href="#font-kerning-auto-value"
      title="section 6.3."><strong>6.3.</strong></a>
    </ul>

   <li>bold, <a href="#bold" title="section 3.2."><strong>3.2.</strong></a>

   <li>bolder, <a href="#bolder"
    title="section 3.2."><strong>3.2.</strong></a>

   <li>character map, <a href="#character-map"
    title="section 5.2."><strong>5.2.</strong></a>

   <li>common-ligatures, <a href="#common-ligatures"
    title="section 6.4."><strong>6.4.</strong></a>

   <li><var>&lt;common-lig-values&gt;</var>, <a href="#common-lig-values"
    title="section 6.4."><strong>6.4.</strong></a>

   <li>composite face, <a href="#composite-face"
    title="section 5.2."><strong>5.2.</strong></a>

   <li>condensed, <a href="#condensed"
    title="section 3.3."><strong>3.3.</strong></a>

   <li>contextual, <a href="#contextual"
    title="section 6.4."><strong>6.4.</strong></a>

   <li><var>&lt;contextual-alt-values&gt;</var>, <a
    href="#contextual-alt-values"
    title="section 6.4."><strong>6.4.</strong></a>

   <li>CSSFontFaceRule, <a href="#cssfontfacerule"
    title="section 8.1."><strong>8.1.</strong></a>

   <li>cursive, definition of, <a href="#cursive0"
    title="section ??"><strong>??</strong></a>

   <li>default face, <a href="#default-face"
    title="section 5.2."><strong>5.2.</strong></a>

   <li>descriptor_declaration, <a href="#descriptor_declaration"
    title="section 4.1."><strong>4.1.</strong></a>

   <li>diagonal-fractions, <a href="#diagonal-fractions"
    title="section 6.7."><strong>6.7.</strong></a>

   <li>discretionary-ligatures, <a href="#discretionary-ligatures"
    title="section 6.4."><strong>6.4.</strong></a>

   <li><var>&lt;discretionary-lig-values&gt;</var>, <a
    href="#discretionary-lig-values"
    title="section 6.4."><strong>6.4.</strong></a>

   <li><var>&lt;east-asian-variant-values&gt;</var>, <a
    href="#east-asian-variant-values"
    title="section 6.8."><strong>6.8.</strong></a>

   <li><var>&lt;east-asian-width-values&gt;</var>, <a
    href="#east-asian-width-values"
    title="section 6.8."><strong>6.8.</strong></a>

   <li>effective character map, <a href="#effective-character-map"
    title="section 4.5."><strong>4.5.</strong></a>

   <li>expanded, <a href="#expanded"
    title="section 3.3."><strong>3.3.</strong></a>

   <li>extra-condensed, <a href="#extra-condensed"
    title="section 3.3."><strong>3.3.</strong></a>

   <li>extra-expanded, <a href="#extra-expanded"
    title="section 3.3."><strong>3.3.</strong></a>

   <li><var>&lt;family-name&gt;</var>, <a href="#family-name-value"
    title="section 3.1."><strong>3.1.</strong></a>

   <li>fantasy, definition of, <a href="#fantasy0"
    title="section ??"><strong>??</strong></a>

   <li><var>&lt;feature-tag-value&gt;</var>, <a href="#feature-tag-value"
    title="section 6.10."><strong>6.10.</strong></a>

   <li>first available font, <a href="#first-available-font"
    title="section 5.2."><strong>5.2.</strong></a>

   <li>font, <a href="#propdef-font"
    title="section 3.7."><strong>3.7.</strong></a>

   <li><code>@font-face</code>, <a href="#at-font-face-rule"
    title="section 4.1."><strong>4.1.</strong></a>

   <li><var>&lt;font-face-name&gt;</var>, <a href="#font-face-name-value"
    title="section 4.3."><strong>4.3.</strong></a>

   <li>font_face_rule, <a href="#font_face_rule"
    title="section 4.1."><strong>4.1.</strong></a>

   <li>FONT_FACE_SYM, <a href="#font_face_sym"
    title="section 4.1."><strong>4.1.</strong></a>

   <li>font-family
    <ul>
     <li>descriptor, <a href="#descdef-font-family"
      title="section 4.2."><strong>4.2.</strong></a>

     <li>property, <a href="#propdef-font-family"
      title="section 3.1."><strong>3.1.</strong></a>
    </ul>

   <li>font-feature-settings
    <ul>
     <li>descriptor, <a href="#descdef-font-feature-settings"
      title="section 4.7."><strong>4.7.</strong></a>

     <li>property, <a href="#propdef-font-feature-settings"
      title="section 6.10."><strong>6.10.</strong></a>
    </ul>

   <li>font-kerning, <a href="#propdef-font-kerning"
    title="section 6.3."><strong>6.3.</strong></a>

   <li>font-size, <a href="#propdef-font-size"
    title="section 3.5."><strong>3.5.</strong></a>

   <li>font-size-adjust, <a href="#propdef-font-size-adjust"
    title="section 3.6."><strong>3.6.</strong></a>

   <li>font-stretch
    <ul>
     <li>descriptor, <a href="#descdef-font-stretch"
      title="section 4.4."><strong>4.4.</strong></a>

     <li>property, <a href="#propdef-font-stretch"
      title="section 3.3."><strong>3.3.</strong></a>
    </ul>

   <li>font-style
    <ul>
     <li>descriptor, <a href="#descdef-font-style"
      title="section 4.4."><strong>4.4.</strong></a>

     <li>property, <a href="#propdef-font-style"
      title="section 3.4."><strong>3.4.</strong></a>
    </ul>

   <li>font-synthesis, <a href="#propdef-font-synthesis"
    title="section 3.8."><strong>3.8.</strong></a>

   <li>font-variant
    <ul>
     <li>property, <a href="#propdef-font-variant"
      title="section 6.9."><strong>6.9.</strong></a>
    </ul>

   <li>font-variant-caps, <a href="#propdef-font-variant-caps"
    title="section 6.6."><strong>6.6.</strong></a>

   <li><var>&lt;font-variant-css21&gt;</var>, <a
    href="#font-variant-css21-values"
    title="section 3.7."><strong>3.7.</strong></a>

   <li>font-variant-east-asian, <a href="#propdef-font-variant-east-asian"
    title="section 6.8."><strong>6.8.</strong></a>

   <li>font-variant-ligatures, <a href="#propdef-font-variant-ligatures"
    title="section 6.4."><strong>6.4.</strong></a>

   <li>font-variant-numeric, <a href="#propdef-font-variant-numeric"
    title="section 6.7."><strong>6.7.</strong></a>

   <li>font-variant-position, <a href="#propdef-font-variant-position"
    title="section 6.5."><strong>6.5.</strong></a>

   <li>font-weight
    <ul>
     <li>descriptor, <a href="#descdef-font-weight"
      title="section 4.4."><strong>4.4.</strong></a>

     <li>property, <a href="#propdef-font-weight"
      title="section 3.2."><strong>3.2.</strong></a>
    </ul>

   <li>full-width, <a href="#full-width"
    title="section 6.8."><strong>6.8.</strong></a>

   <li><var>&lt;generic-family&gt;</var>, <a href="#generic-family-value"
    title="section 3.1."><strong>3.1.</strong></a>

   <li>historical-ligatures, <a href="#historical-ligatures"
    title="section 6.4."><strong>6.4.</strong></a>

   <li><var>&lt;historical-lig-values&gt;</var>, <a
    href="#historical-lig-values"
    title="section 6.4."><strong>6.4.</strong></a>

   <li>italic, <a href="#italic"
    title="section 3.4."><strong>3.4.</strong></a>

   <li>jis04, <a href="#jis04" title="section 6.8."><strong>6.8.</strong></a>

   <li>jis78, <a href="#jis78" title="section 6.8."><strong>6.8.</strong></a>

   <li>jis83, <a href="#jis83" title="section 6.8."><strong>6.8.</strong></a>

   <li>jis90, <a href="#jis90" title="section 6.8."><strong>6.8.</strong></a>

   <li>lighter, <a href="#lighter"
    title="section 3.2."><strong>3.2.</strong></a>

   <li>lining-nums, <a href="#lining-nums"
    title="section 6.7."><strong>6.7.</strong></a>

   <li>monospace, definition of, <a href="#monospace0"
    title="section ??"><strong>??</strong></a>

   <li>no-common-ligatures, <a href="#no-common-ligatures"
    title="section 6.4."><strong>6.4.</strong></a>

   <li>no-contextual, <a href="#no-contextual"
    title="section 6.4."><strong>6.4.</strong></a>

   <li>no-discretionary-ligatures, <a href="#no-discretionary-ligatures"
    title="section 6.4."><strong>6.4.</strong></a>

   <li>no-historical-ligatures, <a href="#no-historical-ligatures"
    title="section 6.4."><strong>6.4.</strong></a>

   <li>none
    <ul>
     <li>font-kerning, <a href="#font-kerning-none-value"
      title="section 6.3."><strong>6.3.</strong></a>

     <li>font-size-adjust, <a href="#font-size-adjust-none-value"
      title="section 3.6."><strong>3.6.</strong></a>

     <li>font-variant, <a href="#font-variant-none-value"
      title="section 6.9."><strong>6.9.</strong></a>

     <li>font-variant-ligatures, <a href="#font-variant-ligatures-none-value"
      title="section 6.4."><strong>6.4.</strong></a>
    </ul>

   <li>normal
    <ul>
     <li>font-feature-settings, <a href="#font-feature-settings-normal-value"
      title="section 6.10."><strong>6.10.</strong></a>

     <li>font-kerning, <a href="#font-kerning-normal-value"
      title="section 6.3."><strong>6.3.</strong></a>

     <li>font-stretch, <a href="#font-stretch-normal-value"
      title="section 3.3."><strong>3.3.</strong></a>

     <li>font-style, <a href="#font-style-normal-value"
      title="section 3.4."><strong>3.4.</strong></a>

     <li>font-variant, <a href="#font-variant-normal-value"
      title="section 6.9."><strong>6.9.</strong></a>

     <li>font-variant-caps, <a href="#font-variant-caps-normal-value"
      title="section 6.6."><strong>6.6.</strong></a>

     <li>font-variant-east-asian, <a
      href="#font-variant-east-asian-normal-value"
      title="section 6.8."><strong>6.8.</strong></a>

     <li>font-variant-ligatures, <a
      href="#font-variant-ligatures-normal-value"
      title="section 6.4."><strong>6.4.</strong></a>

     <li>font-variant-numeric, <a href="#font-variant-numeric-normal-value"
      title="section 6.7."><strong>6.7.</strong></a>

     <li>font-variant-position, <a href="#font-variant-position-normal-value"
      title="section 6.5."><strong>6.5.</strong></a>

     <li>font-weight, <a href="#font-weight-normal-value"
      title="section 3.2."><strong>3.2.</strong></a>
    </ul>

   <li><var>&lt;number&gt;</var>, <a href="#aspect-ratio-value"
    title="section 3.6."><strong>3.6.</strong></a>

   <li><var>&lt;numeric-figure-values&gt;</var>, <a
    href="#numeric-figure-values"
    title="section 6.7."><strong>6.7.</strong></a>

   <li><var>&lt;numeric-fraction-values&gt;</var>, <a
    href="#numeric-fraction-values"
    title="section 6.7."><strong>6.7.</strong></a>

   <li><var>&lt;numeric-spacing-values&gt;</var>, <a
    href="#numeric-spacing-values"
    title="section 6.7."><strong>6.7.</strong></a>

   <li>oblique, <a href="#oblique"
    title="section 3.4."><strong>3.4.</strong></a>

   <li>oldstyle-nums, <a href="#oldstyle-nums"
    title="section 6.7."><strong>6.7.</strong></a>

   <li>ordinal, <a href="#ordinal"
    title="section 6.7."><strong>6.7.</strong></a>

   <li>petite-caps, <a href="#petite-caps"
    title="section 6.6."><strong>6.6.</strong></a>

   <li>proportional-nums, <a href="#proportional-nums"
    title="section 6.7."><strong>6.7.</strong></a>

   <li>proportional-width, <a href="#proportional-width"
    title="section 6.8."><strong>6.8.</strong></a>

   <li><var>&lt;relative-size&gt;</var>, <a href="#relative-size-value"
    title="section 3.5."><strong>3.5.</strong></a>

   <li>renderer, <a href="#renderer"
    title="section ??"><strong>??</strong></a>

   <li>ruby, <a href="#ruby" title="section 6.8."><strong>6.8.</strong></a>

   <li>sans-serif, definition of, <a href="#sans-serif0"
    title="section ??"><strong>??</strong></a>

   <li>semi-condensed, <a href="#semi-condensed-"
    title="section 3.3."><strong>3.3.</strong></a>

   <li>semi-expanded, <a href="#semi-expanded"
    title="section 3.3."><strong>3.3.</strong></a>

   <li>serif, definition of, <a href="#serif0"
    title="section ??"><strong>??</strong></a>

   <li>simplified, <a href="#simplified"
    title="section 6.8."><strong>6.8.</strong></a>

   <li>slashed-zero, <a href="#slashed-zero"
    title="section 6.7."><strong>6.7.</strong></a>

   <li>small-caps, <a href="#small-caps"
    title="section 6.6."><strong>6.6.</strong></a>

   <li>src, <a href="#descdef-src"
    title="section 4.3."><strong>4.3.</strong></a>

   <li>stacked-fractions, <a href="#stacked-fractions"
    title="section 6.7."><strong>6.7.</strong></a>

   <li>style sheet
    <ul>
     <li>as conformance class, <a href="#style-sheet"
      title="section ??"><strong>??</strong></a>
    </ul>

   <li>sub, <a href="#sub" title="section 6.5."><strong>6.5.</strong></a>

   <li>super, <a href="#super" title="section 6.5."><strong>6.5.</strong></a>

   <li>support, <a href="#support"
    title="section 5.2."><strong>5.2.</strong></a>

   <li>system font fallback, <a href="#system-font-fallback"
    title="section 5.2."><strong>5.2.</strong></a>

   <li>tabular-nums, <a href="#tabular-nums"
    title="section 6.7."><strong>6.7.</strong></a>

   <li>titling-caps, <a href="#titling-caps"
    title="section 6.6."><strong>6.6.</strong></a>

   <li>traditional, <a href="#traditional"
    title="section 6.8."><strong>6.8.</strong></a>

   <li>ultra-condensed, <a href="#ultra-condensed"
    title="section 3.3."><strong>3.3.</strong></a>

   <li>ultra-expanded, <a href="#ultra-expanded"
    title="section 3.3."><strong>3.3.</strong></a>

   <li>unicase, <a href="#unicase"
    title="section 6.6."><strong>6.6.</strong></a>

   <li>unicode-range, <a href="#descdef-unicode-range"
    title="section 4.5."><strong>4.5.</strong></a>

   <li><var>&lt;urange&gt;</var>, <a href="#urange-value"
    title="section 4.5."><strong>4.5.</strong></a>

   <li>weight, <a href="#weight" title="section 2."><strong>2.</strong></a>

   <li>width, <a href="#width" title="section 2."><strong>2.</strong></a>
  </ul>
  <!--end-index-->

  <h2 class=no-num id=property-index>Property index</h2>
  <!--begin-properties-->

  <table class=proptable>
   <thead>
    <tr>
     <th>Property

     <th>Values

     <th>Initial

     <th>Applies to

     <th>Inh.

     <th>Percentages

     <th>Media

   <tbody>
    <tr>
     <th><a class=property href="#propdef-font">font</a>

     <td>[ [ &lt;‘font-style’&gt; || &lt;font-variant-css21&gt; ||
      &lt;‘font-weight’&gt; || &lt;‘font-stretch’&gt; ]?
      &lt;‘font-size’&gt; [ / &lt;‘line-height’&gt; ]?
      &lt;‘font-family’&gt; ] | caption | icon | menu | message-box |
      small-caption | status-bar

     <td>see individual properties

     <td>all elements

     <td>yes

     <td>see individual properties

     <td>visual

    <tr>
     <th><a class=property href="#propdef-font-family">font-family</a>

     <td>[ &lt;family-name&gt; | &lt;generic-family&gt; ] #

     <td>depends on user agent

     <td>all elements

     <td>yes

     <td>N/A

     <td>visual

    <tr>
     <th><a class=property
      href="#propdef-font-feature-settings">font-feature-settings</a>

     <td>normal | &lt;feature-tag-value&gt; #

     <td>normal

     <td>all elements

     <td>yes

     <td>N/A

     <td>visual

    <tr>
     <th><a class=property href="#propdef-font-kerning">font-kerning</a>

     <td>auto | normal | none

     <td>auto

     <td>all elements

     <td>yes

     <td>N/A

     <td>visual

    <tr>
     <th><a class=property href="#propdef-font-size">font-size</a>

     <td>&lt;absolute-size&gt; | &lt;relative-size&gt; |
      &lt;length-percentage&gt;

     <td>medium

     <td>all elements

     <td>yes

     <td>refer to parent element's font size

     <td>visual

    <tr>
     <th><a class=property
      href="#propdef-font-size-adjust">font-size-adjust</a>

     <td>none | &lt;number&gt;

     <td>none

     <td>all elements

     <td>yes

     <td>N/A

     <td>visual

    <tr>
     <th><a class=property href="#propdef-font-stretch">font-stretch</a>

     <td>normal | ultra-condensed | extra-condensed | condensed |
      semi-condensed | semi-expanded | expanded | extra-expanded |
      ultra-expanded

     <td>normal

     <td>all elements

     <td>yes

     <td>N/A

     <td>visual

    <tr>
     <th><a class=property href="#propdef-font-style">font-style</a>

     <td>normal | italic | oblique

     <td>normal

     <td>all elements

     <td>yes

     <td>N/A

     <td>visual

    <tr>
     <th><a class=property href="#propdef-font-synthesis">font-synthesis</a>

     <td>none | [ weight || style ]

     <td>weight style

     <td>all elements

     <td>yes

     <td>N/A

     <td>visual

    <tr>
     <th><a class=property href="#propdef-font-variant">font-variant</a>

     <td>normal | none | [ &lt;common-lig-values&gt; ||
      &lt;discretionary-lig-values&gt; || &lt;historical-lig-values&gt; ||
      &lt;contextual-alt-values&gt; || [ small-caps | all-small-caps |
      petite-caps | all-petite-caps | unicase | titling-caps ] ||
      &lt;numeric-figure-values&gt; || &lt;numeric-spacing-values&gt; ||
      &lt;numeric-fraction-values&gt; || ordinal || slashed-zero ||
      &lt;east-asian-variant-values&gt; || &lt;east-asian-width-values&gt; ||
      ruby || [ sub | super ] ]

     <td>normal

     <td>all elements

     <td>yes

     <td>see individual properties

     <td>visual

    <tr>
     <th><a class=property
      href="#propdef-font-variant-caps">font-variant-caps</a>

     <td>normal | small-caps | all-small-caps | petite-caps | all-petite-caps
      | unicase | titling-caps

     <td>normal

     <td>all elements

     <td>yes

     <td>N/A

     <td>visual

    <tr>
     <th><a class=property
      href="#propdef-font-variant-east-asian">font-variant-east-asian</a>

     <td>normal | [ &lt;east-asian-variant-values&gt; ||
      &lt;east-asian-width-values&gt; || ruby ]

     <td>normal

     <td>all elements

     <td>yes

     <td>N/A

     <td>visual

    <tr>
     <th><a class=property
      href="#propdef-font-variant-ligatures">font-variant-ligatures</a>

     <td>normal | none | [ &lt;common-lig-values&gt; ||
      &lt;discretionary-lig-values&gt; || &lt;historical-lig-values&gt; ||
      &lt;contextual-alt-values&gt; ]

     <td>normal

     <td>all elements

     <td>yes

     <td>N/A

     <td>visual

    <tr>
     <th><a class=property
      href="#propdef-font-variant-numeric">font-variant-numeric</a>

     <td>normal | [ &lt;numeric-figure-values&gt; ||
      &lt;numeric-spacing-values&gt; || &lt;numeric-fraction-values&gt; ||
      ordinal || slashed-zero ]

     <td>normal

     <td>all elements

     <td>yes

     <td>N/A

     <td>visual

    <tr>
     <th><a class=property
      href="#propdef-font-variant-position">font-variant-position</a>

     <td>normal | sub | super

     <td>normal

     <td>all elements

     <td>yes

     <td>N/A

     <td>visual

    <tr>
     <th><a class=property href="#propdef-font-weight">font-weight</a>

     <td>normal | bold | bolder | lighter | 100 | 200 | 300 | 400 | 500 | 600
      | 700 | 800 | 900

     <td>normal

     <td>all elements

     <td>yes

     <td>N/A

     <td>visual
  </table>
  <!--end-properties-->
  <!--begin-descriptors-->

  <table class=proptable>
   <thead>
    <tr>
     <th>Descriptor

     <th>Values

     <th>Initial

   <tbody>
    <tr>
     <th><a class=property href="#descdef-font-family">font-family</a>

     <td>&lt;family-name&gt;

     <td>N/A

    <tr>
     <th><a class=property
      href="#descdef-font-feature-settings">font-feature-settings</a>

     <td>normal | &lt;feature-tag-value&gt; #

     <td>normal

    <tr>
     <th><a class=property href="#descdef-font-stretch">font-stretch</a>

     <td>normal | ultra-condensed | extra-condensed | condensed |
      semi-condensed | semi-expanded | expanded | extra-expanded |
      ultra-expanded

     <td>normal

    <tr>
     <th><a class=property href="#descdef-font-style">font-style</a>

     <td>normal | italic | oblique

     <td>normal

    <tr>
     <th><a class=property href="#descdef-font-weight">font-weight</a>

     <td>normal | bold | 100 | 200 | 300 | 400 | 500 | 600 | 700 | 800 | 900

     <td>normal

    <tr>
     <th><a class=property href="#descdef-src">src</a>

     <td>[ &lt;url> [format(&lt;string> #)]? | &lt;font-face-name&gt; ] #

     <td>N/A

    <tr>
     <th><a class=property href="#descdef-unicode-range">unicode-range</a>

     <td>&lt;urange&gt; #

     <td>U+0-10FFFF
  </table>
  <!--end-descriptors-->

  <p role="navigation" id="back-to-top"><a href="#toc"><abbr title="Back to top">↑</abbr></a></p>

  <script type="text/javascript">
window.onload = function () {
  if (!("devicePixelRatio" in window && window.devicePixelRatio > 1)) return;
  var i, hiresElements = document.getElementsByClassName("hires");
  for (i = 0; i < hiresElements.length; i++) {
    var h = hiresElements[i];
    if (h.tagName != "IMG") continue;
    var src = h.getAttribute("src");
    var src2x = src.replace(/\.\w+$/, function(m) { return "@2x" + m; });
    h.src = src2x;
  }
}
</script>
  <script src="//www.w3.org/scripts/TR/2016/fixup.js"
   type="application/javascript"></script>

