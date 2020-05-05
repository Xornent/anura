<!DOCTYPE html><html class=split lang=en-US-x-hixie><script src=/link-fixup.js defer=""></script><meta charset=utf-8><meta content="width=device-width, initial-scale=1, shrink-to-fit=no" name=viewport><title>HTML Standard</title><meta content=#3c790a name=theme-color><link rel=stylesheet href=https://resources.whatwg.org/spec.css crossorigin=""><link rel=stylesheet href=https://resources.whatwg.org/standard.css crossorigin=""><link rel=stylesheet href=https://resources.whatwg.org/standard-shared-with-dev.css crossorigin=""><link rel=icon href=https://resources.whatwg.org/logo.svg crossorigin=""><script>
   function toggleStatus(div) {
     div.parentNode.classList.toggle('wrapped');
   }
   function setLinkFragment(link) {
     link.hash = location.hash;
   }
  </script><style>
   .bad, .bad *:not(.X\58X) { color: gray; }

   .applies .yes, .yesno .yes { background: yellow; }
   .yesno .yes, .yesno .no { text-align: center; }

   .applies thead th > * { display: block; }
   .applies thead code { display: block; }
   .applies td { text-align: center; }

   .matrix, .matrix td { border: hidden; text-align: right; }
   .matrix, .equations { margin-left: 2em; }

   .vertical-summary-table tr > th[rowspan="2"]:first-child + th,
   .vertical-summary-table tr > td[rowspan="2"]:first-child + td { border-bottom: hidden; }

   .dice-example { border-collapse: collapse; border-style: hidden solid solid hidden; border-width: thin; margin-left: 3em; }
   .dice-example caption { width: 30em; font-size: smaller; font-style: italic; padding: 0.75em 0; text-align: left; }
   .dice-example td, .dice-example th { border: solid thin; width: 1.35em; height: 1.05em; text-align: center; padding: 0; }

   td.eg { border-width: thin; text-align: center; }

   #table-example-1 { border: solid thin; border-collapse: collapse; margin-left: 3em; }
   #table-example-1 caption { padding-bottom: 0.5em; }
   #table-example-1 thead, #table-example-1 tbody { border: none; }
   #table-example-1 th, #table-example-1 td { border: solid thin; }
   #table-example-1 th { font-weight: normal; }
   #table-example-1 td { border-style: none solid; vertical-align: top; }
   #table-example-1 th { padding: 0.5em; vertical-align: middle; text-align: center; }
   #table-example-1 tbody tr:first-child td { padding-top: 0.5em; }
   #table-example-1 tbody tr:last-child td { padding-bottom: 1.5em; }
   #table-example-1 tbody td:first-child { padding-left: 2.5em; padding-right: 0; width: 9em; }
   #table-example-1 tbody td:first-child::after { content: leader(". "); }
   #table-example-1 tbody td { padding-left: 2em; padding-right: 2em; }
   #table-example-1 tbody td:first-child + td { width: 10em; }
   #table-example-1 tbody td:first-child + td ~ td { width: 2.5em; }
   #table-example-1 tbody td:first-child + td + td + td ~ td { width: 1.25em; }

   .apple-table-examples { border: none; border-collapse: separate; border-spacing: 1.5em 0em; width: 40em; margin-left: 3em; }
   .apple-table-examples * { font-family: "Times", serif; }
   .apple-table-examples td, .apple-table-examples th { border: none; white-space: nowrap; padding-top: 0; padding-bottom: 0; }
   .apple-table-examples tbody th:first-child { border-left: none; width: 100%; }
   .apple-table-examples thead th:first-child ~ th { font-size: smaller; font-weight: bolder; border-bottom: solid 2px; text-align: center; }
   .apple-table-examples tbody th::after, .apple-table-examples tfoot th::after { content: leader(". ") }
   .apple-table-examples tbody th, .apple-table-examples tfoot th { font: inherit; text-align: left; }
   .apple-table-examples td { text-align: right; vertical-align: top; }
   .apple-table-examples.e1 tbody tr:last-child td { border-bottom: solid 1px; }
   .apple-table-examples.e1 tbody + tbody tr:last-child td { border-bottom: double 3px; }
   .apple-table-examples.e2 th[scope=row] { padding-left: 1em; }
   .apple-table-examples sup { line-height: 0; }

   .three-column-nowrap tr > td:first-child,
   .three-column-nowrap tr > td:first-child + td,
   .three-column-nowrap tr > td:first-child + td + td { white-space: nowrap; }

   .details-example img { vertical-align: top; }

   .parse-error-table td > p:first-child { margin-top: 0; }

   #named-character-references-table {
     white-space: nowrap;
     font-size: 0.6em;
     column-width: 30em;
     column-gap: 1em;
     -moz-column-width: 30em;
     -moz-column-gap: 1em;
     -webkit-column-width: 30em;
     -webkit-column-gap: 1em;
   }
   #named-character-references-table > table > tbody > tr > td:first-child + td,
   #named-character-references-table > table > tbody > tr > td:last-child { text-align: center; }
   #named-character-references-table > table > tbody > tr > td:last-child:hover > span { position: absolute; top: auto; left: auto; margin-left: 0.5em; line-height: 1.2; font-size: 5em; border: outset; padding: 0.25em 0.5em; background: white; width: 1.25em; height: auto; text-align: center; }
   #named-character-references-table > table > tbody > tr#entity-CounterClockwiseContourIntegral > td:first-child { font-size: 0.5em; }

   .glyph.control { color: red; }

   #table-example-1 * { font-family: "Essays1743", serif; line-height: 1.01em; }
   @font-face {
     font-family: 'Essays1743';
     src: url('/fonts/Essays1743.ttf');
   }
   @font-face {
     font-family: 'Essays1743';
     font-weight: bold;
     src: url('/fonts/Essays1743-Bold.ttf');
   }
   @font-face {
     font-family: 'Essays1743';
     font-style: italic;
     src: url('/fonts/Essays1743-Italic.ttf');
   }
   @font-face {
     font-family: 'Essays1743';
     font-style: italic;
     font-weight: bold;
     src: url('/fonts/Essays1743-BoldItalic.ttf');
   }

   @media (max-width: 767px) {
     #abstractimg { width: 100%; }
   }
   #abstractimg, #abstractimg text { font: inherit; }
   #abstractimg rect { fill: #424242; }
   #abstractimg text { fill: #ffffff; font-size: 18px }
   #abstractimg .top { word-spacing: 50px; text-anchor: middle; }
   #abstractimg .left, #abstractimg .bottom { word-spacing: 12px; }
   #abstractimg .right { font-size: 25px; }
  </style><body>
  
  <script async="" crossorigin="" src=/html-dfn.js></script>
  <script data-file-issue-url=https://github.com/whatwg/html/issues/new async="" crossorigin="" src=https://resources.whatwg.org/file-issue.js></script>
  
  <header id=head class="head with-buttons">
   <a href=https://whatwg.org/ class=logo><img width=100 alt=WHATWG crossorigin="" src=https://resources.whatwg.org/logo.svg height=100></a>
   <hgroup><h1 class=allcaps>HTML</h1><h2 id=living-standard class="no-num no-toc">Living Standard — Last Updated <span class=pubdate>9 April 2020</span></h2></hgroup>
   
   

   
  </header>

  

  

  

  
  

  
  

  

  <nav><a href=scripting.html>← 4.12 Scripting</a> — <a href=./>Table of Contents</a> — <a href=custom-elements.html>4.13 Custom elements →</a></nav><ol class=toc><li id=toc-semantics><ol><li><ol><li><a href=canvas.html#the-canvas-element><span class=secno>4.12.5</span> The <code>canvas</code> element</a><ol><li><a href=canvas.html#2dcontext><span class=secno>4.12.5.1</span> The 2D rendering context</a><ol><li><a href=canvas.html#implementation-notes><span class=secno>4.12.5.1.1</span> Implementation notes</a><li><a href=canvas.html#the-canvas-state><span class=secno>4.12.5.1.2</span> The canvas state</a><li><a href=canvas.html#line-styles><span class=secno>4.12.5.1.3</span> Line styles</a><li><a href=canvas.html#text-styles><span class=secno>4.12.5.1.4</span> Text styles</a><li><a href=canvas.html#building-paths><span class=secno>4.12.5.1.5</span> Building paths</a><li><a href=canvas.html#path2d-objects><span class=secno>4.12.5.1.6</span> <code>Path2D</code> objects</a><li><a href=canvas.html#transformations><span class=secno>4.12.5.1.7</span> Transformations</a><li><a href=canvas.html#image-sources-for-2d-rendering-contexts><span class=secno>4.12.5.1.8</span> Image sources for 2D rendering contexts</a><li><a href=canvas.html#fill-and-stroke-styles><span class=secno>4.12.5.1.9</span> Fill and stroke styles</a><li><a href=canvas.html#drawing-rectangles-to-the-bitmap><span class=secno>4.12.5.1.10</span> Drawing rectangles to the bitmap</a><li><a href=canvas.html#drawing-text-to-the-bitmap><span class=secno>4.12.5.1.11</span> Drawing text to the bitmap</a><li><a href=canvas.html#drawing-paths-to-the-canvas><span class=secno>4.12.5.1.12</span> Drawing paths to the canvas</a><li><a href=canvas.html#drawing-focus-rings-and-scrolling-paths-into-view><span class=secno>4.12.5.1.13</span> Drawing focus rings and scrolling paths into view</a><li><a href=canvas.html#drawing-images><span class=secno>4.12.5.1.14</span> Drawing images</a><li><a href=canvas.html#pixel-manipulation><span class=secno>4.12.5.1.15</span> Pixel manipulation</a><li><a href=canvas.html#compositing><span class=secno>4.12.5.1.16</span> Compositing</a><li><a href=canvas.html#image-smoothing><span class=secno>4.12.5.1.17</span> Image smoothing</a><li><a href=canvas.html#shadows><span class=secno>4.12.5.1.18</span> Shadows</a><li><a href=canvas.html#filters><span class=secno>4.12.5.1.19</span> Filters</a><li><a href=canvas.html#working-with-externally-defined-svg-filters><span class=secno>4.12.5.1.20</span> Working with externally-defined SVG filters</a><li><a href=canvas.html#drawing-model><span class=secno>4.12.5.1.21</span> Drawing model</a><li><a href=canvas.html#best-practices><span class=secno>4.12.5.1.22</span> Best practices</a><li><a href=canvas.html#examples><span class=secno>4.12.5.1.23</span> Examples</a></ol><li><a href=canvas.html#the-imagebitmap-rendering-context><span class=secno>4.12.5.2</span> The <code>ImageBitmap</code> rendering context</a><ol><li><a href=canvas.html#introduction-6><span class=secno>4.12.5.2.1</span> Introduction</a><li><a href=canvas.html#the-imagebitmaprenderingcontext-interface><span class=secno>4.12.5.2.2</span> The <code>ImageBitmapRenderingContext</code> interface</a></ol><li><a href=canvas.html#the-offscreencanvas-interface><span class=secno>4.12.5.3</span> The <code>OffscreenCanvas</code> interface</a><ol><li><a href=canvas.html#the-offscreen-2d-rendering-context><span class=secno>4.12.5.3.1</span> The offscreen 2D rendering context</a></ol><li><a href=canvas.html#colour-spaces-and-colour-correction><span class=secno>4.12.5.4</span> Color spaces and color correction</a><li><a href=canvas.html#serialising-bitmaps-to-a-file><span class=secno>4.12.5.5</span> Serializing bitmaps to a file</a><li><a href=canvas.html#security-with-canvas-elements><span class=secno>4.12.5.6</span> Security with <code>canvas</code> elements</a></ol></ol></ol></ol><h4 id=the-canvas-element><span class=secno>4.12.5</span> The <dfn id=canvas><code>canvas</code></dfn> element<a href=#the-canvas-element class=self-link></a></h4><div class=status><input onclick=toggleStatus(this) value=⋰ type=button><p class=support><strong>Support:</strong> canvas<span class="and_chr yes"><span>Chrome for Android</span> <span>80+</span></span><span class="chrome yes"><span>Chrome</span> <span>4+</span></span><span class="ios_saf yes"><span>iOS Safari</span> <span>3.2+</span></span><span class="firefox yes"><span>Firefox</span> <span>3.6+</span></span><span class="safari yes"><span>Safari</span> <span>4+</span></span><span class="samsung yes"><span>Samsung Internet</span> <span>4+</span></span><span class="and_uc yes"><span>UC Browser for Android</span> <span>12.12+</span></span><span class="edge yes"><span>Edge</span> <span>12+</span></span><span class="ie yes"><span>IE</span> <span>9+</span></span><span class="opera yes"><span>Opera</span> <span>9+</span></span><span class="op_mini partial"><span>Opera Mini (limited)</span> <span>all+</span></span><span class="android yes"><span>Android Browser</span> <span>3+</span></span><p class=caniuse>Source: <a href="https://caniuse.com/#feat=canvas">caniuse.com</a></div><aside class="mdn-anno wrapped"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/HTML/Element/canvas title="Use the HTML <canvas> element with either the canvas scripting API or the WebGL API to draw graphics and animations.">Element/canvas</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>2+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/HTMLCanvasElement title="The HTMLCanvasElement interface provides properties and methods for manipulating the layout and presentation of <canvas> elements. The HTMLCanvasElement interface also inherits the properties and methods of the HTMLElement interface.">HTMLCanvasElement</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>2+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside><dl class=element><dt><a href=dom.html#concept-element-categories id=the-canvas-element:concept-element-categories>Categories</a>:<dd><a id=the-canvas-element:flow-content-2 href=dom.html#flow-content-2>Flow content</a>.<dd><a id=the-canvas-element:phrasing-content-2 href=dom.html#phrasing-content-2>Phrasing content</a>.<dd><a id=the-canvas-element:embedded-content-category href=dom.html#embedded-content-category>Embedded content</a>.<dd><a id=the-canvas-element:palpable-content-2 href=dom.html#palpable-content-2>Palpable content</a>.<dt><a href=dom.html#concept-element-contexts id=the-canvas-element:concept-element-contexts>Contexts in which this element can be used</a>:<dd>Where <a id=the-canvas-element:embedded-content-category-2 href=dom.html#embedded-content-category>embedded content</a> is expected.<dt><a href=dom.html#concept-element-content-model id=the-canvas-element:concept-element-content-model>Content model</a>:<dd><a id=the-canvas-element:transparent href=dom.html#transparent>Transparent</a>, but with no <a id=the-canvas-element:interactive-content-2 href=dom.html#interactive-content-2>interactive content</a> descendants except
   for <code id=the-canvas-element:the-a-element><a href=text-level-semantics.html#the-a-element>a</a></code> elements, <code id=the-canvas-element:the-img-element><a href=embedded-content.html#the-img-element>img</a></code> elements with
   <code id=the-canvas-element:attr-hyperlink-usemap><a href=image-maps.html#attr-hyperlink-usemap>usemap</a></code> attributes, <code id=the-canvas-element:the-button-element><a href=form-elements.html#the-button-element>button</a></code> elements,
   <code id=the-canvas-element:the-input-element><a href=input.html#the-input-element>input</a></code> elements whose <code id=the-canvas-element:attr-input-type><a href=input.html#attr-input-type>type</a></code> attribute are in
   the <a href="input.html#checkbox-state-(type=checkbox)" id="the-canvas-element:checkbox-state-(type=checkbox)">Checkbox</a> or <a href="input.html#radio-button-state-(type=radio)" id="the-canvas-element:radio-button-state-(type=radio)">Radio Button</a> states, <code id=the-canvas-element:the-input-element-2><a href=input.html#the-input-element>input</a></code> elements that are
   <a href=forms.html#concept-button id=the-canvas-element:concept-button>buttons</a>, <code id=the-canvas-element:the-select-element><a href=form-elements.html#the-select-element>select</a></code> elements with a <code id=the-canvas-element:attr-select-multiple><a href=form-elements.html#attr-select-multiple>multiple</a></code> attribute or a <a href=form-elements.html#concept-select-size id=the-canvas-element:concept-select-size>display size</a> greater than 1, and elements that would not be
   <a id=the-canvas-element:interactive-content-2-2 href=dom.html#interactive-content-2>interactive content</a> except for having the <code id=the-canvas-element:attr-tabindex><a href=interaction.html#attr-tabindex>tabindex</a></code> attribute specified.<dt><a href=dom.html#concept-element-tag-omission id=the-canvas-element:concept-element-tag-omission>Tag omission in text/html</a>:<dd>Neither tag is omissible.<dt><a href=dom.html#concept-element-attributes id=the-canvas-element:concept-element-attributes>Content attributes</a>:<dd><a id=the-canvas-element:global-attributes href=dom.html#global-attributes>Global attributes</a><dd><code id=the-canvas-element:attr-canvas-width><a href=#attr-canvas-width>width</a></code> — Horizontal dimension<dd><code id=the-canvas-element:attr-canvas-height><a href=#attr-canvas-height>height</a></code> — Vertical dimension<dt><a href=dom.html#concept-element-accessibility-considerations id=the-canvas-element:concept-element-accessibility-considerations>Accessibility considerations</a>:<dd><a href=https://w3c.github.io/html-aria/#el-canvas>For authors</a>.<dd><a href=https://w3c.github.io/html-aam/#el-canvas>For implementers</a>.<dt><a href=dom.html#concept-element-dom id=the-canvas-element:concept-element-dom>DOM interface</a>:<dd>
    <pre><code class='idl'><c- b>typedef</c-> (<a href='#canvasrenderingcontext2d' id='the-canvas-element:canvasrenderingcontext2d'><c- n>CanvasRenderingContext2D</c-></a> <c- b>or</c-> <a href='#imagebitmaprenderingcontext' id='the-canvas-element:imagebitmaprenderingcontext'><c- n>ImageBitmapRenderingContext</c-></a> <c- b>or</c-> <a href='https://www.khronos.org/registry/webgl/specs/latest/1.0/#WebGLRenderingContext' data-x-internal='webglrenderingcontext' id='the-canvas-element:webglrenderingcontext'><c- n>WebGLRenderingContext</c-></a> <c- b>or</c-> <a href='https://www.khronos.org/registry/webgl/specs/latest/2.0/#WebGL2RenderingContext' data-x-internal='webgl2renderingcontext' id='the-canvas-element:webgl2renderingcontext'><c- n>WebGL2RenderingContext</c-></a>) <dfn id='renderingcontext'><c- g>RenderingContext</c-></dfn>;

[<c- g>Exposed</c->=<c- n>Window</c->]
<c- b>interface</c-> <dfn id='htmlcanvaselement'><c- g>HTMLCanvasElement</c-></dfn> : <a href='dom.html#htmlelement' id='the-canvas-element:htmlelement'><c- n>HTMLElement</c-></a> {
  [<a href='dom.html#htmlconstructor' id='the-canvas-element:htmlconstructor'><c- g>HTMLConstructor</c-></a>] <c- b>constructor</c->();

  [<a href='custom-elements.html#cereactions' id='the-canvas-element:cereactions'><c- g>CEReactions</c-></a>] <c- b>attribute</c-> <c- b>unsigned</c-> <c- b>long</c-> <a href='#dom-canvas-width' id='the-canvas-element:dom-canvas-width'><c- g>width</c-></a>;
  [<a href='custom-elements.html#cereactions' id='the-canvas-element:cereactions-2'><c- g>CEReactions</c-></a>] <c- b>attribute</c-> <c- b>unsigned</c-> <c- b>long</c-> <a href='#dom-canvas-height' id='the-canvas-element:dom-canvas-height'><c- g>height</c-></a>;

  <a href='#renderingcontext' id='the-canvas-element:renderingcontext'><c- n>RenderingContext</c-></a>? <a href='#dom-canvas-getcontext' id='the-canvas-element:dom-canvas-getcontext'><c- g>getContext</c-></a>(<c- b>DOMString</c-> <c- g>contextId</c->, <c- b>optional</c-> <c- b>any</c-> <c- g>options</c-> = <c- b>null</c->);

  <c- b>USVString</c-> <a href='#dom-canvas-todataurl' id='the-canvas-element:dom-canvas-todataurl'><c- g>toDataURL</c-></a>(<c- b>optional</c-> <c- b>DOMString</c-> <c- g>type</c-> = &quot;image/png&quot;, <c- b>optional</c-> <c- b>any</c-> <c- g>quality</c->);
  <c- b>void</c-> <a href='#dom-canvas-toblob' id='the-canvas-element:dom-canvas-toblob'><c- g>toBlob</c-></a>(<a href='#blobcallback' id='the-canvas-element:blobcallback'><c- n>BlobCallback</c-></a> <c- g>_callback</c->, <c- b>optional</c-> <c- b>DOMString</c-> <c- g>type</c-> = &quot;image/png&quot;, <c- b>optional</c-> <c- b>any</c-> <c- g>quality</c->);
  <a href='#offscreencanvas' id='the-canvas-element:offscreencanvas'><c- n>OffscreenCanvas</c-></a> <a href='#dom-canvas-transfercontroltooffscreen' id='the-canvas-element:dom-canvas-transfercontroltooffscreen'><c- g>transferControlToOffscreen</c-></a>();
};

<c- b>callback</c-> <dfn id='blobcallback'><c- g>BlobCallback</c-></dfn> = <c- b>void</c-> (<a href='https://w3c.github.io/FileAPI/#dfn-Blob' data-x-internal='blob' id='the-canvas-element:blob'><c- n>Blob</c-></a>? <c- g>blob</c->);</code></pre>
   </dl>

  <p>The <code id=the-canvas-element:the-canvas-element><a href=#the-canvas-element>canvas</a></code> element provides scripts with a resolution-dependent bitmap canvas,
  which can be used for rendering graphs, game graphics, art, or other visual images on the fly.</p>

  <p>Authors should not use the <code id=the-canvas-element:the-canvas-element-2><a href=#the-canvas-element>canvas</a></code> element in a document when a more suitable
  element is available. For example, it is inappropriate to use a <code id=the-canvas-element:the-canvas-element-3><a href=#the-canvas-element>canvas</a></code> element to
  render a page heading: if the desired presentation of the heading is graphically intense, it
  should be marked up using appropriate elements (typically <code id=the-canvas-element:the-h1,-h2,-h3,-h4,-h5,-and-h6-elements><a href=sections.html#the-h1,-h2,-h3,-h4,-h5,-and-h6-elements>h1</a></code>) and then styled using
  CSS and supporting technologies such as <a href=https://dom.spec.whatwg.org/#concept-shadow-tree id=the-canvas-element:shadow-tree data-x-internal=shadow-tree>shadow trees</a>.</p>

  <p>When authors use the <code id=the-canvas-element:the-canvas-element-4><a href=#the-canvas-element>canvas</a></code> element, they must also provide content that, when
  presented to the user, conveys essentially the same function or purpose as the
  <code id=the-canvas-element:the-canvas-element-5><a href=#the-canvas-element>canvas</a></code>'s bitmap. This content may be placed as content of the <code id=the-canvas-element:the-canvas-element-6><a href=#the-canvas-element>canvas</a></code>
  element. The contents of the <code id=the-canvas-element:the-canvas-element-7><a href=#the-canvas-element>canvas</a></code> element, if any, are the element's <a id=the-canvas-element:fallback-content href=dom.html#fallback-content>fallback
  content</a>.</p>

  <hr>

  <p>In interactive visual media, if <a href=webappapis.html#concept-n-script id=the-canvas-element:concept-n-script>scripting is enabled</a> for
  the <code id=the-canvas-element:the-canvas-element-8><a href=#the-canvas-element>canvas</a></code> element, and if support for <code id=the-canvas-element:the-canvas-element-9><a href=#the-canvas-element>canvas</a></code> elements has been enabled,
  then the <code id=the-canvas-element:the-canvas-element-10><a href=#the-canvas-element>canvas</a></code> element <a id=the-canvas-element:represents href=dom.html#represents>represents</a> <a id=the-canvas-element:embedded-content-category-3 href=dom.html#embedded-content-category>embedded content</a>
  consisting of a dynamically created image, the element's bitmap.</p>

  <p>In non-interactive, static, visual media, if the <code id=the-canvas-element:the-canvas-element-11><a href=#the-canvas-element>canvas</a></code> element has been
  previously associated with a rendering context (e.g. if the page was viewed in an interactive
  visual medium and is now being printed, or if some script that ran during the page layout process
  painted on the element), then the <code id=the-canvas-element:the-canvas-element-12><a href=#the-canvas-element>canvas</a></code> element <a id=the-canvas-element:represents-2 href=dom.html#represents>represents</a>
  <a id=the-canvas-element:embedded-content-category-4 href=dom.html#embedded-content-category>embedded content</a> with the element's current bitmap and size. Otherwise, the element
  represents its <a id=the-canvas-element:fallback-content-2 href=dom.html#fallback-content>fallback content</a> instead.</p>

  <p>In non-visual media, and in visual media if <a href=webappapis.html#concept-n-noscript id=the-canvas-element:concept-n-noscript>scripting is
  disabled</a> for the <code id=the-canvas-element:the-canvas-element-13><a href=#the-canvas-element>canvas</a></code> element or if support for <code id=the-canvas-element:the-canvas-element-14><a href=#the-canvas-element>canvas</a></code> elements
  has been disabled, the <code id=the-canvas-element:the-canvas-element-15><a href=#the-canvas-element>canvas</a></code> element <a id=the-canvas-element:represents-3 href=dom.html#represents>represents</a> its <a id=the-canvas-element:fallback-content-3 href=dom.html#fallback-content>fallback
  content</a> instead.</p>

  
  <p>When a <code id=the-canvas-element:the-canvas-element-16><a href=#the-canvas-element>canvas</a></code> element <a id=the-canvas-element:represents-4 href=dom.html#represents>represents</a> <a id=the-canvas-element:embedded-content-category-5 href=dom.html#embedded-content-category>embedded content</a>, the
  user can still focus descendants of the <code id=the-canvas-element:the-canvas-element-17><a href=#the-canvas-element>canvas</a></code> element (in the <a id=the-canvas-element:fallback-content-4 href=dom.html#fallback-content>fallback
  content</a>). When an element is <a id=the-canvas-element:focused href=interaction.html#focused>focused</a>, it is the target of keyboard interaction
  events (even though the element itself is not visible). This allows authors to make an interactive
  canvas keyboard-accessible: authors should have a one-to-one mapping of interactive regions to <i id=the-canvas-element:focusable-area><a href=interaction.html#focusable-area>focusable areas</a></i> in the <a id=the-canvas-element:fallback-content-5 href=dom.html#fallback-content>fallback content</a>. (Focus has no
  effect on mouse interaction events.) <a href=references.html#refsUIEVENTS>[UIEVENTS]</a></p> 

  <p>An element whose nearest <code id=the-canvas-element:the-canvas-element-18><a href=#the-canvas-element>canvas</a></code> element ancestor is <a id=the-canvas-element:being-rendered href=rendering.html#being-rendered>being rendered</a>
  and <a id=the-canvas-element:represents-5 href=dom.html#represents>represents</a> <a id=the-canvas-element:embedded-content-category-6 href=dom.html#embedded-content-category>embedded content</a> is an element that is <dfn id=being-used-as-relevant-canvas-fallback-content>being used as
  relevant canvas fallback content</dfn>.</p>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/HTMLCanvasElement/width title="The HTMLCanvasElement.width property is a positive integer reflecting the width HTML attribute of the <canvas> element interpreted in CSS pixels. When the attribute is not specified, or if it is set to an invalid value, like a negative, the default value of 300 is used.">HTMLCanvasElement/width</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/HTMLCanvasElement/height title="The HTMLCanvasElement.height property is a positive integer reflecting the height HTML attribute of the <canvas> element interpreted in CSS pixels. When the attribute is not specified, or if it is set to an invalid value, like a negative, the default value of 150 is used.">HTMLCanvasElement/height</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside><p>The <code id=the-canvas-element:the-canvas-element-19><a href=#the-canvas-element>canvas</a></code> element has two attributes to control the size of the element's bitmap:
  <dfn id=attr-canvas-width><code>width</code></dfn> and <dfn id=attr-canvas-height><code>height</code></dfn>. These attributes, when specified, must have
  values that are <a href=common-microsyntaxes.html#valid-non-negative-integer id=the-canvas-element:valid-non-negative-integer>valid non-negative integers</a>. The <a id=the-canvas-element:rules-for-parsing-non-negative-integers href=common-microsyntaxes.html#rules-for-parsing-non-negative-integers>rules for parsing non-negative integers</a> must be used to <dfn id=obtain-numeric-values>obtain their numeric values</dfn>. If an attribute is missing,
  or if parsing its value returns an error, then the default value must be used instead.
  The <code id=the-canvas-element:attr-canvas-width-2><a href=#attr-canvas-width>width</a></code> attribute defaults to 300, and the
  <code id=the-canvas-element:attr-canvas-height-2><a href=#attr-canvas-height>height</a></code> attribute defaults to 150.</p>

  <p>When setting the value of the <code id=the-canvas-element:attr-canvas-width-3><a href=#attr-canvas-width>width</a></code> or <code id=the-canvas-element:attr-canvas-height-3><a href=#attr-canvas-height>height</a></code> attribute, if the <a href=#concept-canvas-context-mode id=the-canvas-element:concept-canvas-context-mode>context mode</a> of the <code id=the-canvas-element:the-canvas-element-20><a href=#the-canvas-element>canvas</a></code>
  element is set to <a href=#concept-canvas-placeholder id=the-canvas-element:concept-canvas-placeholder>placeholder</a>, the
  user agent must throw an <a id=the-canvas-element:invalidstateerror href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=the-canvas-element:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>
  and leave the attribute's value unchanged.</p>

  <p>The <a id=the-canvas-element:intrinsic-dimensions href=https://drafts.csswg.org/css-images/#intrinsic-dimensions data-x-internal=intrinsic-dimensions>intrinsic dimensions</a> of the <code id=the-canvas-element:the-canvas-element-21><a href=#the-canvas-element>canvas</a></code> element when it
  <a id=the-canvas-element:represents-6 href=dom.html#represents>represents</a> <a id=the-canvas-element:embedded-content-category-7 href=dom.html#embedded-content-category>embedded content</a> are equal to the dimensions of the
  element's bitmap.</p>

  <p>The user agent must use a square pixel density consisting of one pixel of image data per
  coordinate space unit for the bitmaps of a <code id=the-canvas-element:the-canvas-element-22><a href=#the-canvas-element>canvas</a></code> and its rendering contexts.</p>

  <p class=note>A <code id=the-canvas-element:the-canvas-element-23><a href=#the-canvas-element>canvas</a></code> element can be sized arbitrarily by a style sheet, its
  bitmap is then subject to the <a id="the-canvas-element:'object-fit'" href=https://drafts.csswg.org/css-images/#the-object-fit data-x-internal="'object-fit'">'object-fit'</a> CSS property.</p>

  

  <hr>

  <p>The bitmaps of <code id=the-canvas-element:the-canvas-element-24><a href=#the-canvas-element>canvas</a></code> elements, the bitmaps of <code id=the-canvas-element:imagebitmap><a href=imagebitmap-and-animations.html#imagebitmap>ImageBitmap</a></code> objects,
  as well as some of the bitmaps of rendering contexts, such as those described in the sections on
  the <code id=the-canvas-element:canvasrenderingcontext2d-2><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code> and <code id=the-canvas-element:imagebitmaprenderingcontext-2><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingContext</a></code> objects
  below, have an <dfn id=concept-canvas-origin-clean>origin-clean</dfn> flag, which can be
  set to true or false. Initially, when the <code id=the-canvas-element:the-canvas-element-25><a href=#the-canvas-element>canvas</a></code> element or <code id=the-canvas-element:imagebitmap-2><a href=imagebitmap-and-animations.html#imagebitmap>ImageBitmap</a></code>
  object is created, its bitmap's <a href=#concept-canvas-origin-clean id=the-canvas-element:concept-canvas-origin-clean>origin-clean</a>
  flag must be set to true.</p>

  <p>A <code id=the-canvas-element:the-canvas-element-26><a href=#the-canvas-element>canvas</a></code> element can have a rendering context bound to it. Initially, it does not
  have a bound rendering context. To keep track of whether it has a rendering context or not, and
  what kind of rendering context it is, a <code id=the-canvas-element:the-canvas-element-27><a href=#the-canvas-element>canvas</a></code> also has a <dfn id=concept-canvas-context-mode>canvas context mode</dfn>, which is initially <dfn id=concept-canvas-none>none</dfn> but can be changed to either <dfn id=concept-canvas-placeholder>placeholder</dfn>, <dfn id=concept-canvas-2d>2d</dfn>, <dfn id=concept-canvas-bitmaprenderer>bitmaprenderer</dfn>, <dfn id=concept-canvas-webgl>webgl</dfn>, or <dfn id=concept-canvas-webgl2>webgl2</dfn> by algorithms defined in this specification.</p>

  <p>When its <a href=#concept-canvas-context-mode id=the-canvas-element:concept-canvas-context-mode-2>canvas context mode</a> is <a href=#concept-canvas-none id=the-canvas-element:concept-canvas-none>none</a>, a <code id=the-canvas-element:the-canvas-element-28><a href=#the-canvas-element>canvas</a></code> element has no rendering context,
  and its bitmap must be <a id=the-canvas-element:transparent-black href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a> with an <a id=the-canvas-element:intrinsic-width href=https://drafts.csswg.org/css-images/#intrinsic-width data-x-internal=intrinsic-width>intrinsic width</a> equal
  to <a href=#obtain-numeric-values id=the-canvas-element:obtain-numeric-values>the numeric value</a> of the element's <code id=the-canvas-element:attr-canvas-width-4><a href=#attr-canvas-width>width</a></code> attribute and an <a id=the-canvas-element:intrinsic-height href=https://drafts.csswg.org/css-images/#intrinsic-height data-x-internal=intrinsic-height>intrinsic height</a> equal to
  <a href=#obtain-numeric-values id=the-canvas-element:obtain-numeric-values-2>the numeric value</a> of the element's <code id=the-canvas-element:attr-canvas-height-4><a href=#attr-canvas-height>height</a></code> attribute, those values being interpreted in <a href=https://drafts.csswg.org/css-values/#px id="the-canvas-element:'px'" data-x-internal="'px'">CSS pixels</a>, and being updated as the attributes are set, changed, or
  removed.</p>

  <p>When its <a href=#concept-canvas-context-mode id=the-canvas-element:concept-canvas-context-mode-3>canvas context mode</a> is <a href=#concept-canvas-placeholder id=the-canvas-element:concept-canvas-placeholder-2>placeholder</a>, a <code id=the-canvas-element:the-canvas-element-29><a href=#the-canvas-element>canvas</a></code> element has no
  rendering context. It serves as a placeholder for an <code id=the-canvas-element:offscreencanvas-2><a href=#offscreencanvas>OffscreenCanvas</a></code> object, and
  the content of the <code id=the-canvas-element:the-canvas-element-30><a href=#the-canvas-element>canvas</a></code> element is updated by calling the <code id=the-canvas-element:offscreencontext-commit><a href=#offscreencontext-commit>commit()</a></code> method of the <code id=the-canvas-element:offscreencanvas-3><a href=#offscreencanvas>OffscreenCanvas</a></code>
  object's rendering context.</p>

  <p>When a <code id=the-canvas-element:the-canvas-element-31><a href=#the-canvas-element>canvas</a></code> element represents <a id=the-canvas-element:embedded-content-category-8 href=dom.html#embedded-content-category>embedded content</a>, it provides a
  <a id=the-canvas-element:paint-source href=https://drafts.csswg.org/css-images-4/#paint-source data-x-internal=paint-source>paint source</a> whose width is the element's <a id=the-canvas-element:intrinsic-width-2 href=https://drafts.csswg.org/css-images/#intrinsic-width data-x-internal=intrinsic-width>intrinsic width</a>, whose height
  is the element's <a id=the-canvas-element:intrinsic-height-2 href=https://drafts.csswg.org/css-images/#intrinsic-height data-x-internal=intrinsic-height>intrinsic height</a>, and whose appearance is the element's bitmap.</p>

  <p>Whenever the <code id=the-canvas-element:attr-canvas-width-5><a href=#attr-canvas-width>width</a></code> and <code id=the-canvas-element:attr-canvas-height-5><a href=#attr-canvas-height>height</a></code> content attributes are set, removed, changed, or
  redundantly set to the value they already have, then the user agent must perform the action
  from the row of the following table that corresponds to the <code id=the-canvas-element:the-canvas-element-32><a href=#the-canvas-element>canvas</a></code> element's <a href=#concept-canvas-context-mode id=the-canvas-element:concept-canvas-context-mode-4>context mode</a>.</p>

  <table><thead><tr><th>
      <p><a href=#concept-canvas-context-mode id=the-canvas-element:concept-canvas-context-mode-5>Context Mode</a></p>
     <th>
      <p>Action</p>

   <tbody><tr><th>
      <p><a href=#concept-canvas-2d id=the-canvas-element:concept-canvas-2d>2d</a></p>
     <td>
      <p>Follow the steps to <a href=#concept-canvas-set-bitmap-dimensions id=the-canvas-element:concept-canvas-set-bitmap-dimensions>set bitmap
      dimensions</a> to <a href=#obtain-numeric-values id=the-canvas-element:obtain-numeric-values-3>the numeric values</a>
      of the <code id=the-canvas-element:attr-canvas-width-6><a href=#attr-canvas-width>width</a></code> and <code id=the-canvas-element:attr-canvas-height-6><a href=#attr-canvas-height>height</a></code> content attributes.</p>

    <tr><th>
      <p><a href=#concept-canvas-webgl id=the-canvas-element:concept-canvas-webgl>webgl</a> or <a href=#concept-canvas-webgl2 id=the-canvas-element:concept-canvas-webgl2>webgl2</a></p>
     <td>
      <p>Follow the behavior defined in the WebGL specifications. <a href=references.html#refsWEBGL>[WEBGL]</a></p>

    <tr><th>
      <p><a href=#concept-canvas-bitmaprenderer id=the-canvas-element:concept-canvas-bitmaprenderer>bitmaprenderer</a></p>
     <td>
      <p>If the context's <a href=#concept-imagebitmaprenderingcontext-bitmap-mode id=the-canvas-element:concept-imagebitmaprenderingcontext-bitmap-mode>bitmap
      mode</a> is set to <a href=#concept-imagebitmaprenderingcontext-blank id=the-canvas-element:concept-imagebitmaprenderingcontext-blank>blank</a>,
      run the steps to <a href="#set-an-imagebitmaprenderingcontext's-output-bitmap" id="the-canvas-element:set-an-imagebitmaprenderingcontext's-output-bitmap">set an <code>ImageBitmapRenderingContext</code>'s output bitmap</a>,
      passing the <code id=the-canvas-element:the-canvas-element-33><a href=#the-canvas-element>canvas</a></code> element's rendering context.</p>

    <tr><th>
      <p><a href=#concept-canvas-placeholder id=the-canvas-element:concept-canvas-placeholder-3>placeholder</a></p>
     <td>
      <p>Do nothing.</p>

    <tr><th>
      <p><a href=#concept-canvas-none id=the-canvas-element:concept-canvas-none-2>none</a></p>
     <td>
      <p>Do nothing.</p>
  </table>

  <p>The <dfn id=dom-canvas-width><code>width</code></dfn> and <dfn id=dom-canvas-height><code>height</code></dfn> IDL attributes must <a id=the-canvas-element:reflect href=common-dom-interfaces.html#reflect>reflect</a> the
  respective content attributes of the same name, with the same defaults.</p>

  

  <hr>

  <dl class=domintro><dt><var>context</var> = <var>canvas</var> . <code id=dom-canvas-getcontext-dev><a href=#dom-canvas-getcontext>getContext</a></code>(<var>contextId</var> [, <var>options</var> ] )<dd>
    <p>Returns an object that exposes an API for drawing on the canvas. <var>contextId</var>
    specifies the desired API: "<code id=the-canvas-element:canvas-context-2d><a href=#canvas-context-2d>2d</a></code>", "<code id=the-canvas-element:canvas-context-bitmaprenderer><a href=#canvas-context-bitmaprenderer>bitmaprenderer</a></code>", "<code id=the-canvas-element:canvas-context-webgl><a href=#canvas-context-webgl>webgl</a></code>", or "<code id=the-canvas-element:canvas-context-webgl2><a href=#canvas-context-webgl2>webgl2</a></code>". <var>options</var> is handled by that API.</p>

    <p>This specification defines the "<code id=the-canvas-element:canvas-context-2d-2><a href=#canvas-context-2d>2d</a></code>" and "<code id=the-canvas-element:canvas-context-bitmaprenderer-2><a href=#canvas-context-bitmaprenderer>bitmaprenderer</a></code>" contexts below. The WebGL
    specifications define the "<code id=the-canvas-element:canvas-context-webgl-2><a href=#canvas-context-webgl>webgl</a></code>" and "<code id=the-canvas-element:canvas-context-webgl2-2><a href=#canvas-context-webgl2>webgl2</a></code>" contexts. <a href=references.html#refsWEBGL>[WEBGL]</a></p>

    <p>Returns null if <var>contextId</var> is not supported, or if the canvas has already been
    initialized with another context type (e.g., trying to get a "<code id=the-canvas-element:canvas-context-2d-3><a href=#canvas-context-2d>2d</a></code>" context after getting a "<code id=the-canvas-element:canvas-context-webgl-3><a href=#canvas-context-webgl>webgl</a></code>" context).</p>
   </dl>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/HTMLCanvasElement/getContext title="The HTMLCanvasElement.getContext() method returns a drawing context on the canvas, or null if the context identifier is not supported.">HTMLCanvasElement/getContext</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>2+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside><p>The <dfn id=dom-canvas-getcontext><code>getContext(<var>contextId</var>,
  <var>options</var>)</code></dfn> method of the <code id=the-canvas-element:the-canvas-element-34><a href=#the-canvas-element>canvas</a></code> element, when invoked, must run
  these steps:

  <ol><li><p>If <var>options</var> is not an <a href=https://heycam.github.io/webidl/#idl-object id=the-canvas-element:idl-object data-x-internal=idl-object>object</a>, then set
   <var>options</var> to null.<li><p>Set <var>options</var> to the result of <a href=https://heycam.github.io/webidl/#es-type-mapping id=the-canvas-element:concept-idl-convert data-x-internal=concept-idl-convert>converting</a> <var>options</var> to a JavaScript value.<li>
    <p>Run the steps in the cell of the following table whose column header matches this
    <code id=the-canvas-element:the-canvas-element-35><a href=#the-canvas-element>canvas</a></code> element's <a href=#concept-canvas-context-mode id=the-canvas-element:concept-canvas-context-mode-6>canvas context
    mode</a> and whose row header matches <var>contextId</var>:</p>

    <table><thead><tr><td>
       <th><a href=#concept-canvas-none id=the-canvas-element:concept-canvas-none-3>none</a>
       <th><a href=#concept-canvas-2d id=the-canvas-element:concept-canvas-2d-2>2d</a>
       <th><a href=#concept-canvas-bitmaprenderer id=the-canvas-element:concept-canvas-bitmaprenderer-2>bitmaprenderer</a>
       <th><a href=#concept-canvas-webgl id=the-canvas-element:concept-canvas-webgl-2>webgl</a> or <a href=#concept-canvas-webgl2 id=the-canvas-element:concept-canvas-webgl2-2>webgl2</a>
       <th><a href=#concept-canvas-placeholder id=the-canvas-element:concept-canvas-placeholder-4>placeholder</a>
     <tbody><tr><th>"<dfn id=canvas-context-2d><code>2d</code></dfn>"
       <td>
        Follow the <a href=#2d-context-creation-algorithm id=the-canvas-element:2d-context-creation-algorithm>2D context creation algorithm</a> defined in the section below, passing
        it this <code id=the-canvas-element:the-canvas-element-36><a href=#the-canvas-element>canvas</a></code> element and <var>options</var>, to obtain a
        <code id=the-canvas-element:canvasrenderingcontext2d-3><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code> object; if this does not throw an exception, then set
        this <code id=the-canvas-element:the-canvas-element-37><a href=#the-canvas-element>canvas</a></code> element's <a href=#concept-canvas-context-mode id=the-canvas-element:concept-canvas-context-mode-7>context
        mode</a> to <a href=#concept-canvas-2d id=the-canvas-element:concept-canvas-2d-3>2d</a>, and return the
        <code id=the-canvas-element:canvasrenderingcontext2d-4><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code> object.
       <td>
        Return the same object as was returned the last time the method was invoked with this same
        first argument.
       <td>
        Return null.
       <td>
        Return null.
       <td>
        Throw an <a id=the-canvas-element:invalidstateerror-2 href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=the-canvas-element:domexception-2><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.
      <tr><th>"<dfn id=canvas-context-bitmaprenderer><code>bitmaprenderer</code></dfn>"
       <td>
        Follow the <a href=#imagebitmaprenderingcontext-creation-algorithm id=the-canvas-element:imagebitmaprenderingcontext-creation-algorithm><code>ImageBitmapRenderingContext</code> creation algorithm</a> defined
        in the section below, passing it this <code id=the-canvas-element:the-canvas-element-38><a href=#the-canvas-element>canvas</a></code> element and <var>options</var>, to
        obtain an <code id=the-canvas-element:imagebitmaprenderingcontext-3><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingContext</a></code> object; then set this <code id=the-canvas-element:the-canvas-element-39><a href=#the-canvas-element>canvas</a></code>
        element's <a href=#concept-canvas-context-mode id=the-canvas-element:concept-canvas-context-mode-8>context mode</a> to <a href=#concept-canvas-bitmaprenderer id=the-canvas-element:concept-canvas-bitmaprenderer-3>bitmaprenderer</a>, and return the
        <code id=the-canvas-element:imagebitmaprenderingcontext-4><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingContext</a></code> object.
       <td>
        Return null.
       <td>
        Return the same object as was returned the last time the method was invoked with this same
        first argument.
       <td>
        Return null.
       <td>
        Throw an <a id=the-canvas-element:invalidstateerror-3 href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=the-canvas-element:domexception-3><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.
      <tr><th>"<dfn id=canvas-context-webgl><code>webgl</code></dfn>" or "<dfn id=canvas-context-webgl2><code>webgl2</code></dfn>", if the user agent supports the WebGL
       feature in its current configuration
       <td>
        Follow the instructions given in the WebGL specifications' <i>Context Creation</i> sections
        to obtain a <code id=the-canvas-element:webglrenderingcontext-2><a data-x-internal=webglrenderingcontext href=https://www.khronos.org/registry/webgl/specs/latest/1.0/#WebGLRenderingContext>WebGLRenderingContext</a></code>, <code id=the-canvas-element:webgl2renderingcontext-2><a data-x-internal=webgl2renderingcontext href=https://www.khronos.org/registry/webgl/specs/latest/2.0/#WebGL2RenderingContext>WebGL2RenderingContext</a></code>, or
        null; if the returned value is null, then return null; otherwise, set this
        <code id=the-canvas-element:the-canvas-element-40><a href=#the-canvas-element>canvas</a></code> element's <a href=#concept-canvas-context-mode id=the-canvas-element:concept-canvas-context-mode-9>context mode</a>
        to <a href=#concept-canvas-webgl id=the-canvas-element:concept-canvas-webgl-3>webgl</a> or <a href=#concept-canvas-webgl2 id=the-canvas-element:concept-canvas-webgl2-3>webgl2</a>, and return the
        <code id=the-canvas-element:webglrenderingcontext-3><a data-x-internal=webglrenderingcontext href=https://www.khronos.org/registry/webgl/specs/latest/1.0/#WebGLRenderingContext>WebGLRenderingContext</a></code> or <code id=the-canvas-element:webgl2renderingcontext-3><a data-x-internal=webgl2renderingcontext href=https://www.khronos.org/registry/webgl/specs/latest/2.0/#WebGL2RenderingContext>WebGL2RenderingContext</a></code> object. <a href=references.html#refsWEBGL>[WEBGL]</a>
       <td>
        Return null.
       <td>
        Return null.
       <td>
        Return the same object as was returned the last time the method was invoked with this same
        first argument.
       <td>
        Throw an <a id=the-canvas-element:invalidstateerror-4 href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=the-canvas-element:domexception-4><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.
      <tr><th>An unsupported value*
       <td>
        Return null.
       <td>
        Return null.
       <td>
        Return null.
       <td>
        Return null.
       <td>
        Throw an <a id=the-canvas-element:invalidstateerror-5 href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=the-canvas-element:domexception-5><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.
    </table>

    <p class=tablenote><small>* For example, the "<code id=the-canvas-element:canvas-context-webgl-4><a href=#canvas-context-webgl>webgl</a></code>" or "<code id=the-canvas-element:canvas-context-webgl2-3><a href=#canvas-context-webgl2>webgl2</a></code>" value in the case of a user agent having exhausted
    the graphics hardware's abilities and having no software fallback implementation.</small></p>
   </ol>

  <hr>

  

  <dl class=domintro><dt><var>url</var> = <var>canvas</var> . <code id=dom-canvas-todataurl-dev><a href=#dom-canvas-todataurl>toDataURL</a></code>( [ <var>type</var> [, <var>quality</var> ] ] )<dd>
    <p>Returns a <a href=https://tools.ietf.org/html/rfc2397#section-2 id=the-canvas-element:data-protocol data-x-internal=data-protocol><code>data:</code> URL</a> for the image in the
    canvas.</p>

    <p>The first argument, if provided, controls the type of the image to be returned (e.g. PNG or
    JPEG). The default is "<code id=the-canvas-element:image/png><a href=indices.html#image/png>image/png</a></code>"; that type is also used if the given type isn't
    supported. The second argument applies if the type is an image format that supports variable
    quality (such as "<code id=the-canvas-element:image/jpeg><a href=indices.html#image/jpeg>image/jpeg</a></code>"), and is a number in the range 0.0 to 1.0 inclusive
    indicating the desired quality level for the resulting image.</p>

    <p>When trying to use types other than "<code id=the-canvas-element:image/png-2><a href=indices.html#image/png>image/png</a></code>", authors can check if the image
    was really returned in the requested format by checking to see if the returned string starts
    with one of the exact strings "<code>data:image/png,</code>" or "<code>data:image/png;</code>". If it does, the image is PNG, and thus the requested type was
    not supported. (The one exception to this is if the canvas has either no height or no width, in
    which case the result might simply be "<code>data:,</code>".)</p>
   <dt><var>canvas</var> . <code id=dom-canvas-toblob-dev><a href=#dom-canvas-toblob>toBlob</a></code>(<var>callback</var> [, <var>type</var> [, quality ] ] )<dd>
    <p>Creates a <code id=the-canvas-element:blob-2><a data-x-internal=blob href=https://w3c.github.io/FileAPI/#dfn-Blob>Blob</a></code> object representing a file containing the image in the canvas,
    and invokes a callback with a handle to that object.</p>

    <p>The second argument, if provided, controls the type of the image to be returned (e.g. PNG or
    JPEG). The default is "<code id=the-canvas-element:image/png-3><a href=indices.html#image/png>image/png</a></code>"; that type is also used if the given type isn't
    supported. The third argument applies if the type is an image format that supports variable
    quality (such as "<code id=the-canvas-element:image/jpeg-2><a href=indices.html#image/jpeg>image/jpeg</a></code>"), and is a number in the range 0.0 to 1.0 inclusive
    indicating the desired quality level for the resulting image.</p>
   <dt><var>canvas</var> . <code id=dom-canvas-transfercontroltooffscreen-dev><a href=#dom-canvas-transfercontroltooffscreen>transferControlToOffscreen</a></code>()<dd>
    <p>Returns a newly created <code id=the-canvas-element:offscreencanvas-4><a href=#offscreencanvas>OffscreenCanvas</a></code> object that uses the
    <code id=the-canvas-element:the-canvas-element-41><a href=#the-canvas-element>canvas</a></code> element as a placeholder. Once the <code id=the-canvas-element:the-canvas-element-42><a href=#the-canvas-element>canvas</a></code> element has become a
    placeholder for an <code id=the-canvas-element:offscreencanvas-5><a href=#offscreencanvas>OffscreenCanvas</a></code> object, its intrinsic size can no longer be
    changed, and it cannot have a rendering context. The content of the placeholder canvas is
    updated by calling the <code id=the-canvas-element:offscreencontext-commit-2><a href=#offscreencontext-commit>commit()</a></code> method of the
    <code id=the-canvas-element:offscreencanvas-6><a href=#offscreencanvas>OffscreenCanvas</a></code> object's rendering context.
    </p>
   </dl>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/HTMLCanvasElement/toDataURL title="The HTMLCanvasElement.toDataURL() method returns a data URI containing a representation of the image in the format specified by the type parameter (defaults to PNG). The returned image is in a resolution of 96 dpi.">HTMLCanvasElement/toDataURL</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>2+</span></span><span class="safari yes"><span>Safari</span><span>4+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>3.2+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside><p>The <dfn id=dom-canvas-todataurl><code>toDataURL(<var>type</var>,
  <var>quality</var>)</code></dfn> method, when invoked, must run these steps:</p>

  <ol><li><p>If this <code id=the-canvas-element:the-canvas-element-43><a href=#the-canvas-element>canvas</a></code> element's bitmap's <a href=#concept-canvas-origin-clean id=the-canvas-element:concept-canvas-origin-clean-2>origin-clean</a> flag is set to false, then throw a
   <a id=the-canvas-element:securityerror href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-canvas-element:domexception-6><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.</p>


   <li><p>If this <code id=the-canvas-element:the-canvas-element-44><a href=#the-canvas-element>canvas</a></code> element's bitmap has no pixels (i.e. either its horizontal
   dimension or its vertical dimension is zero) then return the string "<code>data:,</code>". (This is the shortest <a href=https://tools.ietf.org/html/rfc2397#section-2 id=the-canvas-element:data-protocol-2 data-x-internal=data-protocol><code>data:</code> URL</a>; it represents the empty string in a <code>text/plain</code> resource.)<li><p>Let <var>file</var> be <a href=#a-serialisation-of-the-bitmap-as-a-file id=the-canvas-element:a-serialisation-of-the-bitmap-as-a-file>a
   serialization of this <code>canvas</code> element's bitmap as a file</a>, passing
   <var>type</var> and <var>quality</var> if given.<li><p>If <var>file</var> is null then return "<code>data:,</code>".<li><p>Return a <a href=https://tools.ietf.org/html/rfc2397#section-2 id=the-canvas-element:data-protocol-3 data-x-internal=data-protocol><code>data:</code> URL</a> representing
   <var>file</var>. <a href=references.html#refsRFC2397>[RFC2397]</a></p>

   
  </ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/HTMLCanvasElement/toBlob title="The HTMLCanvasElement.toBlob() method creates a Blob object representing the image contained in the canvas; this file may be cached on the disk or stored in memory at the discretion of the user agent. If type is not specified, the image type is image/png. The created image is in a resolution of 96dpi.">HTMLCanvasElement/toBlob</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>19+</span></span><span class="safari yes"><span>Safari</span><span>11+</span></span><span class="chrome yes"><span>Chrome</span><span>50+</span></span><hr><span class="opera yes"><span>Opera</span><span>37+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie yes"><span>Internet Explorer</span><span title="Requires a prefix or alternative name.">🔰 10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>11+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>50+</span></span><span class="webview_android yes"><span>WebView Android</span><span>50+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>37+</span></span></div></div></aside><p>The <dfn id=dom-canvas-toblob><code>toBlob(<var>callback</var>, <var>type</var>,
  <var>quality</var>)</code></dfn> method, when invoked, must run these steps:</p>

  <ol><li><p>If this <code id=the-canvas-element:the-canvas-element-45><a href=#the-canvas-element>canvas</a></code> element's bitmap's <a href=#concept-canvas-origin-clean id=the-canvas-element:concept-canvas-origin-clean-3>origin-clean</a> flag is set to false, then throw a
   <a id=the-canvas-element:securityerror-2 href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-canvas-element:domexception-7><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>result</var> be null.<li><p>If this <code id=the-canvas-element:the-canvas-element-46><a href=#the-canvas-element>canvas</a></code> element's bitmap has pixels (i.e., neither its horizontal
   dimension nor its vertical dimension is zero), then set <var>result</var> to a copy of this
   <code id=the-canvas-element:the-canvas-element-47><a href=#the-canvas-element>canvas</a></code> element's bitmap.

   <li>
    <p>Run these steps <a id=the-canvas-element:in-parallel href=infrastructure.html#in-parallel>in parallel</a>:</p>

    <ol><li><p>If <var>result</var> is non-null, then set <var>result</var> to <a href=#a-serialisation-of-the-bitmap-as-a-file id=the-canvas-element:a-serialisation-of-the-bitmap-as-a-file-2>a serialization of <var>result</var> as a file</a>
     with <var>type</var> and <var>quality</var> if given.<li>
      <p><a id=the-canvas-element:queue-an-element-task href=webappapis.html#queue-an-element-task>Queue an element task</a> on the
      <dfn id=canvas-blob-serialisation-task-source>canvas blob serialization task
      source</dfn> given the <code id=the-canvas-element:the-canvas-element-48><a href=#the-canvas-element>canvas</a></code> element to run these steps:</p>

      <ol><li><p>If <var>result</var> is non-null, then set <var>result</var> to a new
       <code id=the-canvas-element:blob-3><a data-x-internal=blob href=https://w3c.github.io/FileAPI/#dfn-Blob>Blob</a></code> object, created in the <a href=webappapis.html#concept-relevant-realm id=the-canvas-element:concept-relevant-realm>relevant
       Realm</a> of this <code id=the-canvas-element:the-canvas-element-49><a href=#the-canvas-element>canvas</a></code> element, representing <var>result</var>. <a href=references.html#refsFILEAPI>[FILEAPI]</a><li><p><a href=https://heycam.github.io/webidl/#invoke-a-callback-function id=the-canvas-element:es-invoking-callback-functions data-x-internal=es-invoking-callback-functions>Invoke</a> <var>callback</var> with
       « <var>result</var> ».</ol>
     </ol>
   </ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/HTMLCanvasElement/transferControlToOffscreen title="The HTMLCanvasElement.transferControlToOffscreen() method transfers control to an OffscreenCanvas object, either on the main thread or on a worker.">HTMLCanvasElement/transferControlToOffscreen</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span title="Requires setting a user preference or runtime flag.">🔰 44+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>69+</span></span><hr><span class="opera no"><span>Opera</span><span>No</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span title="Requires setting a user preference or runtime flag.">🔰 44+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>69+</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>10.0+</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><p>The <dfn id=dom-canvas-transfercontroltooffscreen><code>transferControlToOffscreen()</code></dfn> method,
  when invoked, must run these steps:</p>

  <ol><li><p>If this <code id=the-canvas-element:the-canvas-element-50><a href=#the-canvas-element>canvas</a></code> element's <a href=#concept-canvas-context-mode id=the-canvas-element:concept-canvas-context-mode-10>context
   mode</a> is not set to <a href=#concept-canvas-none id=the-canvas-element:concept-canvas-none-4>none</a>, throw an
   <a id=the-canvas-element:invalidstateerror-6 href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=the-canvas-element:domexception-8><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>offscreenCanvas</var> be a new <code id=the-canvas-element:offscreencanvas-7><a href=#offscreencanvas>OffscreenCanvas</a></code> object with its
   width and height equal to the values of the <code id=the-canvas-element:attr-canvas-width-7><a href=#attr-canvas-width>width</a></code>
   and <code id=the-canvas-element:attr-canvas-height-7><a href=#attr-canvas-height>height</a></code> content attributes of this
   <code id=the-canvas-element:the-canvas-element-51><a href=#the-canvas-element>canvas</a></code> element.<li><p>Set the <a href=#offscreencanvas-placeholder id=the-canvas-element:offscreencanvas-placeholder>placeholder <code>canvas</code>
   element</a> of <var>offscreenCanvas</var> to be a weak reference to this <code id=the-canvas-element:the-canvas-element-52><a href=#the-canvas-element>canvas</a></code>
   element.<li><p>Set this <code id=the-canvas-element:the-canvas-element-53><a href=#the-canvas-element>canvas</a></code> element's <a href=#concept-canvas-context-mode id=the-canvas-element:concept-canvas-context-mode-11>context
   mode</a> to <a href=#concept-canvas-placeholder id=the-canvas-element:concept-canvas-placeholder-5>placeholder</a>.<li><p>Return <var>offscreenCanvas</var>.</ol>

  

  

  <h5 id=2dcontext><span class=secno>4.12.5.1</span> The 2D rendering context<a href=#2dcontext class=self-link></a></h5><aside class="mdn-anno wrapped"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D title="The CanvasRenderingContext2D interface, part of the Canvas API, provides the 2D rendering context for the drawing surface of a <canvas> element. It is used for drawing shapes, text, images, and other objects.">CanvasRenderingContext2D</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>2+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="No support in current engines." class=less-than-two-engines-flag>⚠</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasImageSource title="CanvasImageSource provides a mechanism for other interfaces to be used as image sources for some methods of the CanvasDrawImage and CanvasFillStrokeStyles interfaces. It’s just an internal helper type to simplify the specification. It’s not an interface and there are no objects implementing it.">CanvasImageSource</a><p class=less-than-two-engines-text>No support in current engines.<p class=nosupportdata>No support data.</div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/imageSmoothingQuality title="The imageSmoothingQuality property of the CanvasRenderingContext2D interface, part of the Canvas API, lets you set the quality of image smoothing.">CanvasRenderingContext2D/imageSmoothingQuality</a><p class=""><div class=support><span class="firefox no"><span>Firefox</span><span>No</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>54+</span></span><hr><span class="opera yes"><span>Opera</span><span>41+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie unknown"><span>Internet Explorer</span><span>?</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>54+</span></span><span class="webview_android yes"><span>WebView Android</span><span>54+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>6.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>41+</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasGradient title="The CanvasGradient interface represents an opaque object describing a gradient. It is returned by the methods CanvasRenderingContext2D.createLinearGradient() or CanvasRenderingContext2D.createRadialGradient().">CanvasGradient</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.6+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>3.2+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasPattern title="The CanvasPattern interface represents an opaque object describing a pattern, based on an image, a canvas, or a video, created by the CanvasRenderingContext2D.createPattern() method.">CanvasPattern</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.6+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>3.2+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/TextMetrics title="The TextMetrics interface represents the dimensions of a piece of text in the canvas; a textMetrics() instance can be retrieved using the CanvasRenderingContext2D.measureText() method.">TextMetrics</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>31+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/ImageData title="The ImageData interface represents the underlying pixel data of an area of a <canvas> element. It is created using the ImageData() constructor or creator methods on the CanvasRenderingContext2D object associated with a canvas: createImageData() and getImageData(). It can also be used to set a part of the canvas by using putImageData().">ImageData</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>14+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>14+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>3.2+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside><pre><code class='idl'><c- b>typedef</c-> (<a href='embedded-content.html#htmlimageelement' id='2dcontext:htmlimageelement'><c- n>HTMLImageElement</c-></a> <c- b>or</c->
         <a href='https://svgwg.org/svg2-draft/embedded.html#InterfaceSVGImageElement' data-x-internal='svgimageelement' id='2dcontext:svgimageelement'><c- n>SVGImageElement</c-></a>) <dfn id='htmlorsvgimageelement'><c- g>HTMLOrSVGImageElement</c-></dfn>;

<c- b>typedef</c-> (<a href='#htmlorsvgimageelement' id='2dcontext:htmlorsvgimageelement'><c- n>HTMLOrSVGImageElement</c-></a> <c- b>or</c->
         <a href='media.html#htmlvideoelement' id='2dcontext:htmlvideoelement'><c- n>HTMLVideoElement</c-></a> <c- b>or</c->
         <a href='#htmlcanvaselement' id='2dcontext:htmlcanvaselement'><c- n>HTMLCanvasElement</c-></a> <c- b>or</c->
         <a href='imagebitmap-and-animations.html#imagebitmap' id='2dcontext:imagebitmap'><c- n>ImageBitmap</c-></a> <c- b>or</c->
         <a href='#offscreencanvas' id='2dcontext:offscreencanvas'><c- n>OffscreenCanvas</c-></a>) <dfn id='canvasimagesource'><c- g>CanvasImageSource</c-></dfn>;

<c- b>enum</c-> <dfn id='canvasfillrule'><c- g>CanvasFillRule</c-></dfn> { <c- s>&quot;</c-><a href='#dom-context-2d-fillrule-nonzero' id='2dcontext:dom-context-2d-fillrule-nonzero'><c- s>nonzero</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#dom-context-2d-fillrule-evenodd' id='2dcontext:dom-context-2d-fillrule-evenodd'><c- s>evenodd</c-></a><c- s>&quot;</c-> };

<c- b>dictionary</c-> <dfn id='canvasrenderingcontext2dsettings'><c- g>CanvasRenderingContext2DSettings</c-></dfn> {
  <c- b>boolean</c-> <a href='#dom-canvasrenderingcontext2dsettings-alpha' id='2dcontext:dom-canvasrenderingcontext2dsettings-alpha'><c- g>alpha</c-></a> = <c- b>true</c->;
  <c- b>boolean</c-> <a href='#dom-canvasrenderingcontext2dsettings-desynchronized' id='2dcontext:dom-canvasrenderingcontext2dsettings-desynchronized'><c- g>desynchronized</c-></a> = <c- b>false</c->;
};

<c- b>enum</c-> <dfn id='imagesmoothingquality'><c- g>ImageSmoothingQuality</c-></dfn> { <c- s>&quot;</c-><a href='#dom-context-2d-imagesmoothingquality-low' id='2dcontext:dom-context-2d-imagesmoothingquality-low'><c- s>low</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#dom-context-2d-imagesmoothingquality-medium' id='2dcontext:dom-context-2d-imagesmoothingquality-medium'><c- s>medium</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#dom-context-2d-imagesmoothingquality-high' id='2dcontext:dom-context-2d-imagesmoothingquality-high'><c- s>high</c-></a><c- s>&quot;</c-> };

[<c- g>Exposed</c->=<c- n>Window</c->]
<c- b>interface</c-> <dfn id='canvasrenderingcontext2d'><c- g>CanvasRenderingContext2D</c-></dfn> {
  // back-reference to the canvas
  <c- b>readonly</c-> <c- b>attribute</c-> <a href='#htmlcanvaselement' id='2dcontext:htmlcanvaselement-2'><c- n>HTMLCanvasElement</c-></a> <a href='#dom-context-2d-canvas' id='2dcontext:dom-context-2d-canvas'><c- g>canvas</c-></a>;

  <a href='#canvasrenderingcontext2dsettings' id='2dcontext:canvasrenderingcontext2dsettings'><c- n>CanvasRenderingContext2DSettings</c-></a> <a href='#dom-context-2d-canvas-getcontextattributes' id='2dcontext:dom-context-2d-canvas-getcontextattributes'><c- g>getContextAttributes</c-></a>();
};
<a href='#canvasrenderingcontext2d' id='2dcontext:canvasrenderingcontext2d'><c- n>CanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasstate' id='2dcontext:canvasstate'><c- n>CanvasState</c-></a>;
<a href='#canvasrenderingcontext2d' id='2dcontext:canvasrenderingcontext2d-2'><c- n>CanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvastransform' id='2dcontext:canvastransform'><c- n>CanvasTransform</c-></a>;
<a href='#canvasrenderingcontext2d' id='2dcontext:canvasrenderingcontext2d-3'><c- n>CanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvascompositing' id='2dcontext:canvascompositing'><c- n>CanvasCompositing</c-></a>;
<a href='#canvasrenderingcontext2d' id='2dcontext:canvasrenderingcontext2d-4'><c- n>CanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasimagesmoothing' id='2dcontext:canvasimagesmoothing'><c- n>CanvasImageSmoothing</c-></a>;
<a href='#canvasrenderingcontext2d' id='2dcontext:canvasrenderingcontext2d-5'><c- n>CanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasfillstrokestyles' id='2dcontext:canvasfillstrokestyles'><c- n>CanvasFillStrokeStyles</c-></a>;
<a href='#canvasrenderingcontext2d' id='2dcontext:canvasrenderingcontext2d-6'><c- n>CanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasshadowstyles' id='2dcontext:canvasshadowstyles'><c- n>CanvasShadowStyles</c-></a>;
<a href='#canvasrenderingcontext2d' id='2dcontext:canvasrenderingcontext2d-7'><c- n>CanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasfilters' id='2dcontext:canvasfilters'><c- n>CanvasFilters</c-></a>;
<a href='#canvasrenderingcontext2d' id='2dcontext:canvasrenderingcontext2d-8'><c- n>CanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasrect' id='2dcontext:canvasrect'><c- n>CanvasRect</c-></a>;
<a href='#canvasrenderingcontext2d' id='2dcontext:canvasrenderingcontext2d-9'><c- n>CanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasdrawpath' id='2dcontext:canvasdrawpath'><c- n>CanvasDrawPath</c-></a>;
<a href='#canvasrenderingcontext2d' id='2dcontext:canvasrenderingcontext2d-10'><c- n>CanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasuserinterface' id='2dcontext:canvasuserinterface'><c- n>CanvasUserInterface</c-></a>;
<a href='#canvasrenderingcontext2d' id='2dcontext:canvasrenderingcontext2d-11'><c- n>CanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvastext' id='2dcontext:canvastext'><c- n>CanvasText</c-></a>;
<a href='#canvasrenderingcontext2d' id='2dcontext:canvasrenderingcontext2d-12'><c- n>CanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasdrawimage' id='2dcontext:canvasdrawimage'><c- n>CanvasDrawImage</c-></a>;
<a href='#canvasrenderingcontext2d' id='2dcontext:canvasrenderingcontext2d-13'><c- n>CanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasimagedata' id='2dcontext:canvasimagedata'><c- n>CanvasImageData</c-></a>;
<a href='#canvasrenderingcontext2d' id='2dcontext:canvasrenderingcontext2d-14'><c- n>CanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvaspathdrawingstyles' id='2dcontext:canvaspathdrawingstyles'><c- n>CanvasPathDrawingStyles</c-></a>;
<a href='#canvasrenderingcontext2d' id='2dcontext:canvasrenderingcontext2d-15'><c- n>CanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvastextdrawingstyles' id='2dcontext:canvastextdrawingstyles'><c- n>CanvasTextDrawingStyles</c-></a>;
<a href='#canvasrenderingcontext2d' id='2dcontext:canvasrenderingcontext2d-16'><c- n>CanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvaspath' id='2dcontext:canvaspath'><c- n>CanvasPath</c-></a>;

<c- b>interface</c-> <c- b>mixin</c-> <dfn id='canvasstate'><c- g>CanvasState</c-></dfn> {
  // state
  <c- b>void</c-> <a href='#dom-context-2d-save' id='2dcontext:dom-context-2d-save'><c- g>save</c-></a>(); // push state on state stack
  <c- b>void</c-> <a href='#dom-context-2d-restore' id='2dcontext:dom-context-2d-restore'><c- g>restore</c-></a>(); // pop state stack and restore state
};

<c- b>interface</c-> <c- b>mixin</c-> <dfn id='canvastransform'><c- g>CanvasTransform</c-></dfn> {
  // transformations (default transform is the identity matrix)
  <c- b>void</c-> <a href='#dom-context-2d-scale' id='2dcontext:dom-context-2d-scale'><c- g>scale</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->);
  <c- b>void</c-> <a href='#dom-context-2d-rotate' id='2dcontext:dom-context-2d-rotate'><c- g>rotate</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>angle</c->);
  <c- b>void</c-> <a href='#dom-context-2d-translate' id='2dcontext:dom-context-2d-translate'><c- g>translate</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->);
  <c- b>void</c-> <a href='#dom-context-2d-transform' id='2dcontext:dom-context-2d-transform'><c- g>transform</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>a</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>b</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>c</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>d</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>e</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>f</c->);

  [<c- g>NewObject</c->] <a href='https://drafts.fxtf.org/geometry/#dommatrix' data-x-internal='dommatrix' id='2dcontext:dommatrix'><c- n>DOMMatrix</c-></a> <a href='#dom-context-2d-gettransform' id='2dcontext:dom-context-2d-gettransform'><c- g>getTransform</c-></a>();
  <c- b>void</c-> <a href='#dom-context-2d-settransform' id='2dcontext:dom-context-2d-settransform'><c- g>setTransform</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>a</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>b</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>c</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>d</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>e</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>f</c->);
  <c- b>void</c-> <a href='#dom-context-2d-settransform-matrix' id='2dcontext:dom-context-2d-settransform-matrix'><c- g>setTransform</c-></a>(<c- b>optional</c-> <a href='https://drafts.fxtf.org/geometry/#dictdef-dommatrix2dinit' data-x-internal='dommatrix2dinit' id='2dcontext:dommatrix2dinit'><c- n>DOMMatrix2DInit</c-></a> <c- g>transform</c-> = {});
  <c- b>void</c-> <a href='#dom-context-2d-resettransform' id='2dcontext:dom-context-2d-resettransform'><c- g>resetTransform</c-></a>();

};

<c- b>interface</c-> <c- b>mixin</c-> <dfn id='canvascompositing'><c- g>CanvasCompositing</c-></dfn> {
  // compositing
  <c- b>attribute</c-> <c- b>unrestricted</c-> <c- b>double</c-> <a href='#dom-context-2d-globalalpha' id='2dcontext:dom-context-2d-globalalpha'><c- g>globalAlpha</c-></a>; // (default 1.0)
  <c- b>attribute</c-> <c- b>DOMString</c-> <a href='#dom-context-2d-globalcompositeoperation' id='2dcontext:dom-context-2d-globalcompositeoperation'><c- g>globalCompositeOperation</c-></a>; // (default source-over)
};

<c- b>interface</c-> <c- b>mixin</c-> <dfn id='canvasimagesmoothing'><c- g>CanvasImageSmoothing</c-></dfn> {
  // image smoothing
  <c- b>attribute</c-> <c- b>boolean</c-> <a href='#dom-context-2d-imagesmoothingenabled' id='2dcontext:dom-context-2d-imagesmoothingenabled'><c- g>imageSmoothingEnabled</c-></a>; // (default true)
  <c- b>attribute</c-> <a href='#imagesmoothingquality' id='2dcontext:imagesmoothingquality'><c- n>ImageSmoothingQuality</c-></a> <a href='#dom-context-2d-imagesmoothingquality' id='2dcontext:dom-context-2d-imagesmoothingquality'><c- g>imageSmoothingQuality</c-></a>; // (default low)

};

<c- b>interface</c-> <c- b>mixin</c-> <dfn id='canvasfillstrokestyles'><c- g>CanvasFillStrokeStyles</c-></dfn> {
  // colors and styles (see also the <a href='#canvaspathdrawingstyles' id='2dcontext:canvaspathdrawingstyles-2'>CanvasPathDrawingStyles</a> and <a href='#canvastextdrawingstyles' id='2dcontext:canvastextdrawingstyles-2'>CanvasTextDrawingStyles</a> interfaces)
  <c- b>attribute</c-> (<c- b>DOMString</c-> <c- b>or</c-> <c- n>CanvasGradient</c-> <c- b>or</c-> <c- n>CanvasPattern</c->) <a href='#dom-context-2d-strokestyle' id='2dcontext:dom-context-2d-strokestyle'><c- g>strokeStyle</c-></a>; // (default black)
  <c- b>attribute</c-> (<c- b>DOMString</c-> <c- b>or</c-> <c- n>CanvasGradient</c-> <c- b>or</c-> <c- n>CanvasPattern</c->) <a href='#dom-context-2d-fillstyle' id='2dcontext:dom-context-2d-fillstyle'><c- g>fillStyle</c-></a>; // (default black)
  <a href='#canvasgradient' id='2dcontext:canvasgradient'><c- n>CanvasGradient</c-></a> <a href='#dom-context-2d-createlineargradient' id='2dcontext:dom-context-2d-createlineargradient'><c- g>createLinearGradient</c-></a>(<c- b>double</c-> <c- g>x0</c->, <c- b>double</c-> <c- g>y0</c->, <c- b>double</c-> <c- g>x1</c->, <c- b>double</c-> <c- g>y1</c->);
  <a href='#canvasgradient' id='2dcontext:canvasgradient-2'><c- n>CanvasGradient</c-></a> <a href='#dom-context-2d-createradialgradient' id='2dcontext:dom-context-2d-createradialgradient'><c- g>createRadialGradient</c-></a>(<c- b>double</c-> <c- g>x0</c->, <c- b>double</c-> <c- g>y0</c->, <c- b>double</c-> <c- g>r0</c->, <c- b>double</c-> <c- g>x1</c->, <c- b>double</c-> <c- g>y1</c->, <c- b>double</c-> <c- g>r1</c->);
  <a href='#canvaspattern' id='2dcontext:canvaspattern'><c- n>CanvasPattern</c-></a>? <a href='#dom-context-2d-createpattern' id='2dcontext:dom-context-2d-createpattern'><c- g>createPattern</c-></a>(<a href='#canvasimagesource' id='2dcontext:canvasimagesource'><c- n>CanvasImageSource</c-></a> <c- g>image</c->, [<c- g>TreatNullAs</c->=<c- n>EmptyString</c->] <c- b>DOMString</c-> <c- g>repetition</c->);

};

<c- b>interface</c-> <c- b>mixin</c-> <dfn id='canvasshadowstyles'><c- g>CanvasShadowStyles</c-></dfn> {
  // shadows
  <c- b>attribute</c-> <c- b>unrestricted</c-> <c- b>double</c-> <a href='#dom-context-2d-shadowoffsetx' id='2dcontext:dom-context-2d-shadowoffsetx'><c- g>shadowOffsetX</c-></a>; // (default 0)
  <c- b>attribute</c-> <c- b>unrestricted</c-> <c- b>double</c-> <a href='#dom-context-2d-shadowoffsety' id='2dcontext:dom-context-2d-shadowoffsety'><c- g>shadowOffsetY</c-></a>; // (default 0)
  <c- b>attribute</c-> <c- b>unrestricted</c-> <c- b>double</c-> <a href='#dom-context-2d-shadowblur' id='2dcontext:dom-context-2d-shadowblur'><c- g>shadowBlur</c-></a>; // (default 0)
  <c- b>attribute</c-> <c- b>DOMString</c-> <a href='#dom-context-2d-shadowcolor' id='2dcontext:dom-context-2d-shadowcolor'><c- g>shadowColor</c-></a>; // (default <a href='https://drafts.csswg.org/css-color/#transparent-black' data-x-internal='transparent-black' id='2dcontext:transparent-black'>transparent black</a>)
};

<c- b>interface</c-> <c- b>mixin</c-> <dfn id='canvasfilters'><c- g>CanvasFilters</c-></dfn> {
  // filters
  <c- b>attribute</c-> <c- b>DOMString</c-> <a href='#dom-context-2d-filter' id='2dcontext:dom-context-2d-filter'><c- g>filter</c-></a>; // (default &quot;none&quot;)
};

<c- b>interface</c-> <c- b>mixin</c-> <dfn id='canvasrect'><c- g>CanvasRect</c-></dfn> {
  // rects
  <c- b>void</c-> <a href='#dom-context-2d-clearrect' id='2dcontext:dom-context-2d-clearrect'><c- g>clearRect</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>w</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>h</c->);
  <c- b>void</c-> <a href='#dom-context-2d-fillrect' id='2dcontext:dom-context-2d-fillrect'><c- g>fillRect</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>w</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>h</c->);
  <c- b>void</c-> <a href='#dom-context-2d-strokerect' id='2dcontext:dom-context-2d-strokerect'><c- g>strokeRect</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>w</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>h</c->);
};

<c- b>interface</c-> <c- b>mixin</c-> <dfn id='canvasdrawpath'><c- g>CanvasDrawPath</c-></dfn> {
  // path API (see also <a href='#canvaspath' id='2dcontext:canvaspath-2'>CanvasPath</a>)
  <c- b>void</c-> <a href='#dom-context-2d-beginpath' id='2dcontext:dom-context-2d-beginpath'><c- g>beginPath</c-></a>();
  <c- b>void</c-> <a href='#dom-context-2d-fill' id='2dcontext:dom-context-2d-fill'><c- g>fill</c-></a>(<c- b>optional</c-> <a href='#canvasfillrule' id='2dcontext:canvasfillrule'><c- n>CanvasFillRule</c-></a> <c- g>fillRule</c-> = &quot;<a href='#dom-context-2d-fillrule-nonzero' id='2dcontext:dom-context-2d-fillrule-nonzero-2'>nonzero</a>&quot;);
  <c- b>void</c-> <a href='#dom-context-2d-fill' id='2dcontext:dom-context-2d-fill-2'><c- g>fill</c-></a>(<a href='#path2d' id='2dcontext:path2d'><c- n>Path2D</c-></a> <c- g>path</c->, <c- b>optional</c-> <a href='#canvasfillrule' id='2dcontext:canvasfillrule-2'><c- n>CanvasFillRule</c-></a> <c- g>fillRule</c-> = &quot;<a href='#dom-context-2d-fillrule-nonzero' id='2dcontext:dom-context-2d-fillrule-nonzero-3'>nonzero</a>&quot;);
  <c- b>void</c-> <a href='#dom-context-2d-stroke' id='2dcontext:dom-context-2d-stroke'><c- g>stroke</c-></a>();
  <c- b>void</c-> <a href='#dom-context-2d-stroke' id='2dcontext:dom-context-2d-stroke-2'><c- g>stroke</c-></a>(<a href='#path2d' id='2dcontext:path2d-2'><c- n>Path2D</c-></a> <c- g>path</c->);
  <c- b>void</c-> <a href='#dom-context-2d-clip' id='2dcontext:dom-context-2d-clip'><c- g>clip</c-></a>(<c- b>optional</c-> <a href='#canvasfillrule' id='2dcontext:canvasfillrule-3'><c- n>CanvasFillRule</c-></a> <c- g>fillRule</c-> = &quot;<a href='#dom-context-2d-fillrule-nonzero' id='2dcontext:dom-context-2d-fillrule-nonzero-4'>nonzero</a>&quot;);
  <c- b>void</c-> <a href='#dom-context-2d-clip' id='2dcontext:dom-context-2d-clip-2'><c- g>clip</c-></a>(<a href='#path2d' id='2dcontext:path2d-3'><c- n>Path2D</c-></a> <c- g>path</c->, <c- b>optional</c-> <a href='#canvasfillrule' id='2dcontext:canvasfillrule-4'><c- n>CanvasFillRule</c-></a> <c- g>fillRule</c-> = &quot;<a href='#dom-context-2d-fillrule-nonzero' id='2dcontext:dom-context-2d-fillrule-nonzero-5'>nonzero</a>&quot;);
  <c- b>boolean</c-> <a href='#dom-context-2d-ispointinpath' id='2dcontext:dom-context-2d-ispointinpath'><c- g>isPointInPath</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->, <c- b>optional</c-> <a href='#canvasfillrule' id='2dcontext:canvasfillrule-5'><c- n>CanvasFillRule</c-></a> <c- g>fillRule</c-> = &quot;<a href='#dom-context-2d-fillrule-nonzero' id='2dcontext:dom-context-2d-fillrule-nonzero-6'>nonzero</a>&quot;);
  <c- b>boolean</c-> <a href='#dom-context-2d-ispointinpath' id='2dcontext:dom-context-2d-ispointinpath-2'><c- g>isPointInPath</c-></a>(<a href='#path2d' id='2dcontext:path2d-4'><c- n>Path2D</c-></a> <c- g>path</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->, <c- b>optional</c-> <a href='#canvasfillrule' id='2dcontext:canvasfillrule-6'><c- n>CanvasFillRule</c-></a> <c- g>fillRule</c-> = &quot;<a href='#dom-context-2d-fillrule-nonzero' id='2dcontext:dom-context-2d-fillrule-nonzero-7'>nonzero</a>&quot;);
  <c- b>boolean</c-> <a href='#dom-context-2d-ispointinstroke' id='2dcontext:dom-context-2d-ispointinstroke'><c- g>isPointInStroke</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->);
  <c- b>boolean</c-> <a href='#dom-context-2d-ispointinstroke' id='2dcontext:dom-context-2d-ispointinstroke-2'><c- g>isPointInStroke</c-></a>(<a href='#path2d' id='2dcontext:path2d-5'><c- n>Path2D</c-></a> <c- g>path</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->);
};

<c- b>interface</c-> <c- b>mixin</c-> <dfn id='canvasuserinterface'><c- g>CanvasUserInterface</c-></dfn> {
  <c- b>void</c-> <a href='#dom-context-2d-drawfocusifneeded' id='2dcontext:dom-context-2d-drawfocusifneeded'><c- g>drawFocusIfNeeded</c-></a>(<a href='https://dom.spec.whatwg.org/#interface-element' data-x-internal='element' id='2dcontext:element'><c- n>Element</c-></a> <c- g>element</c->);
  <c- b>void</c-> <a href='#dom-context-2d-drawfocusifneeded' id='2dcontext:dom-context-2d-drawfocusifneeded-2'><c- g>drawFocusIfNeeded</c-></a>(<a href='#path2d' id='2dcontext:path2d-6'><c- n>Path2D</c-></a> <c- g>path</c->, <a href='https://dom.spec.whatwg.org/#interface-element' data-x-internal='element' id='2dcontext:element-2'><c- n>Element</c-></a> <c- g>element</c->);
  <c- b>void</c-> <a href='#dom-context-2d-scrollpathintoview' id='2dcontext:dom-context-2d-scrollpathintoview'><c- g>scrollPathIntoView</c-></a>();
  <c- b>void</c-> <a href='#dom-context-2d-scrollpathintoview' id='2dcontext:dom-context-2d-scrollpathintoview-2'><c- g>scrollPathIntoView</c-></a>(<a href='#path2d' id='2dcontext:path2d-7'><c- n>Path2D</c-></a> <c- g>path</c->);
};

<c- b>interface</c-> <c- b>mixin</c-> <dfn id='canvastext'><c- g>CanvasText</c-></dfn> {
  // text (see also the <a href='#canvaspathdrawingstyles' id='2dcontext:canvaspathdrawingstyles-3'>CanvasPathDrawingStyles</a> and <a href='#canvastextdrawingstyles' id='2dcontext:canvastextdrawingstyles-3'>CanvasTextDrawingStyles</a> interfaces)
  <c- b>void</c-> <a href='#dom-context-2d-filltext' id='2dcontext:dom-context-2d-filltext'><c- g>fillText</c-></a>(<c- b>DOMString</c-> <c- g>text</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->, <c- b>optional</c-> <c- b>unrestricted</c-> <c- b>double</c-> <c- g>maxWidth</c->);
  <c- b>void</c-> <a href='#dom-context-2d-stroketext' id='2dcontext:dom-context-2d-stroketext'><c- g>strokeText</c-></a>(<c- b>DOMString</c-> <c- g>text</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->, <c- b>optional</c-> <c- b>unrestricted</c-> <c- b>double</c-> <c- g>maxWidth</c->);
  <a href='#textmetrics' id='2dcontext:textmetrics'><c- n>TextMetrics</c-></a> <a href='#dom-context-2d-measuretext' id='2dcontext:dom-context-2d-measuretext'><c- g>measureText</c-></a>(<c- b>DOMString</c-> <c- g>text</c->);
};

<c- b>interface</c-> <c- b>mixin</c-> <dfn id='canvasdrawimage'><c- g>CanvasDrawImage</c-></dfn> {
  // drawing images
  <c- b>void</c-> <a href='#dom-context-2d-drawimage' id='2dcontext:dom-context-2d-drawimage'><c- g>drawImage</c-></a>(<a href='#canvasimagesource' id='2dcontext:canvasimagesource-2'><c- n>CanvasImageSource</c-></a> <c- g>image</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>dx</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>dy</c->);
  <c- b>void</c-> <a href='#dom-context-2d-drawimage' id='2dcontext:dom-context-2d-drawimage-2'><c- g>drawImage</c-></a>(<a href='#canvasimagesource' id='2dcontext:canvasimagesource-3'><c- n>CanvasImageSource</c-></a> <c- g>image</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>dx</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>dy</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>dw</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>dh</c->);
  <c- b>void</c-> <a href='#dom-context-2d-drawimage' id='2dcontext:dom-context-2d-drawimage-3'><c- g>drawImage</c-></a>(<a href='#canvasimagesource' id='2dcontext:canvasimagesource-4'><c- n>CanvasImageSource</c-></a> <c- g>image</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>sx</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>sy</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>sw</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>sh</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>dx</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>dy</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>dw</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>dh</c->);
};

<c- b>interface</c-> <c- b>mixin</c-> <dfn id='canvasimagedata'><c- g>CanvasImageData</c-></dfn> {
  // <a href='#pixel-manipulation' id='2dcontext:pixel-manipulation'>pixel manipulation</a>
  <a href='#imagedata' id='2dcontext:imagedata'><c- n>ImageData</c-></a> <a href='#dom-context-2d-createimagedata' id='2dcontext:dom-context-2d-createimagedata'><c- g>createImageData</c-></a>(<c- b>long</c-> <c- g>sw</c->, <c- b>long</c-> <c- g>sh</c->);
  <a href='#imagedata' id='2dcontext:imagedata-2'><c- n>ImageData</c-></a> <a href='#dom-context-2d-createimagedata' id='2dcontext:dom-context-2d-createimagedata-2'><c- g>createImageData</c-></a>(<a href='#imagedata' id='2dcontext:imagedata-3'><c- n>ImageData</c-></a> <c- g>imagedata</c->);
  <a href='#imagedata' id='2dcontext:imagedata-4'><c- n>ImageData</c-></a> <a href='#dom-context-2d-getimagedata' id='2dcontext:dom-context-2d-getimagedata'><c- g>getImageData</c-></a>(<c- b>long</c-> <c- g>sx</c->, <c- b>long</c-> <c- g>sy</c->, <c- b>long</c-> <c- g>sw</c->, <c- b>long</c-> <c- g>sh</c->);
  <c- b>void</c-> <a href='#dom-context-2d-putimagedata' id='2dcontext:dom-context-2d-putimagedata'><c- g>putImageData</c-></a>(<a href='#imagedata' id='2dcontext:imagedata-5'><c- n>ImageData</c-></a> <c- g>imagedata</c->, <c- b>long</c-> <c- g>dx</c->, <c- b>long</c-> <c- g>dy</c->);
  <c- b>void</c-> <a href='#dom-context-2d-putimagedata' id='2dcontext:dom-context-2d-putimagedata-2'><c- g>putImageData</c-></a>(<a href='#imagedata' id='2dcontext:imagedata-6'><c- n>ImageData</c-></a> <c- g>imagedata</c->, <c- b>long</c-> <c- g>dx</c->, <c- b>long</c-> <c- g>dy</c->, <c- b>long</c-> <c- g>dirtyX</c->, <c- b>long</c-> <c- g>dirtyY</c->, <c- b>long</c-> <c- g>dirtyWidth</c->, <c- b>long</c-> <c- g>dirtyHeight</c->);
};

<c- b>enum</c-> <dfn id='canvaslinecap'><c- g>CanvasLineCap</c-></dfn> { <c- s>&quot;butt&quot;</c->, <c- s>&quot;round&quot;</c->, <c- s>&quot;square&quot;</c-> };
<c- b>enum</c-> <dfn id='canvaslinejoin'><c- g>CanvasLineJoin</c-></dfn> { <c- s>&quot;round&quot;</c->, <c- s>&quot;bevel&quot;</c->, <c- s>&quot;miter&quot;</c-> };
<c- b>enum</c-> <dfn id='canvastextalign'><c- g>CanvasTextAlign</c-></dfn> { <c- s>&quot;</c-><a href='#dom-context-2d-textalign-start' id='2dcontext:dom-context-2d-textalign-start'><c- s>start</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#dom-context-2d-textalign-end' id='2dcontext:dom-context-2d-textalign-end'><c- s>end</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#dom-context-2d-textalign-left' id='2dcontext:dom-context-2d-textalign-left'><c- s>left</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#dom-context-2d-textalign-right' id='2dcontext:dom-context-2d-textalign-right'><c- s>right</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#dom-context-2d-textalign-center' id='2dcontext:dom-context-2d-textalign-center'><c- s>center</c-></a><c- s>&quot;</c-> };
<c- b>enum</c-> <dfn id='canvastextbaseline'><c- g>CanvasTextBaseline</c-></dfn> { <c- s>&quot;</c-><a href='#dom-context-2d-textbaseline-top' id='2dcontext:dom-context-2d-textbaseline-top'><c- s>top</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#dom-context-2d-textbaseline-hanging' id='2dcontext:dom-context-2d-textbaseline-hanging'><c- s>hanging</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#dom-context-2d-textbaseline-middle' id='2dcontext:dom-context-2d-textbaseline-middle'><c- s>middle</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#dom-context-2d-textbaseline-alphabetic' id='2dcontext:dom-context-2d-textbaseline-alphabetic'><c- s>alphabetic</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#dom-context-2d-textbaseline-ideographic' id='2dcontext:dom-context-2d-textbaseline-ideographic'><c- s>ideographic</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#dom-context-2d-textbaseline-bottom' id='2dcontext:dom-context-2d-textbaseline-bottom'><c- s>bottom</c-></a><c- s>&quot;</c-> };
<c- b>enum</c-> <dfn id='canvasdirection'><c- g>CanvasDirection</c-></dfn> { <c- s>&quot;</c-><a href='#dom-context-2d-direction-ltr' id='2dcontext:dom-context-2d-direction-ltr'><c- s>ltr</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#dom-context-2d-direction-rtl' id='2dcontext:dom-context-2d-direction-rtl'><c- s>rtl</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#dom-context-2d-direction-inherit' id='2dcontext:dom-context-2d-direction-inherit'><c- s>inherit</c-></a><c- s>&quot;</c-> };

<c- b>interface</c-> <c- b>mixin</c-> <dfn id='canvaspathdrawingstyles'><c- g>CanvasPathDrawingStyles</c-></dfn> {
  // line caps/joins
  <c- b>attribute</c-> <c- b>unrestricted</c-> <c- b>double</c-> <a href='#dom-context-2d-linewidth' id='2dcontext:dom-context-2d-linewidth'><c- g>lineWidth</c-></a>; // (default 1)
  <c- b>attribute</c-> <a href='#canvaslinecap' id='2dcontext:canvaslinecap'><c- n>CanvasLineCap</c-></a> <a href='#dom-context-2d-linecap' id='2dcontext:dom-context-2d-linecap'><c- g>lineCap</c-></a>; // (default &quot;butt&quot;)
  <c- b>attribute</c-> <a href='#canvaslinejoin' id='2dcontext:canvaslinejoin'><c- n>CanvasLineJoin</c-></a> <a href='#dom-context-2d-linejoin' id='2dcontext:dom-context-2d-linejoin'><c- g>lineJoin</c-></a>; // (default &quot;miter&quot;)
  <c- b>attribute</c-> <c- b>unrestricted</c-> <c- b>double</c-> <a href='#dom-context-2d-miterlimit' id='2dcontext:dom-context-2d-miterlimit'><c- g>miterLimit</c-></a>; // (default 10)

  // dashed lines
  <c- b>void</c-> <a href='#dom-context-2d-setlinedash' id='2dcontext:dom-context-2d-setlinedash'><c- g>setLineDash</c-></a>(<c- b>sequence</c->&lt;<c- b>unrestricted</c-> <c- b>double</c->&gt; <c- g>segments</c->); // default empty
  <c- b>sequence</c->&lt;<c- b>unrestricted</c-> <c- b>double</c->&gt; <a href='#dom-context-2d-getlinedash' id='2dcontext:dom-context-2d-getlinedash'><c- g>getLineDash</c-></a>();
  <c- b>attribute</c-> <c- b>unrestricted</c-> <c- b>double</c-> <a href='#dom-context-2d-linedashoffset' id='2dcontext:dom-context-2d-linedashoffset'><c- g>lineDashOffset</c-></a>;
};

<c- b>interface</c-> <c- b>mixin</c-> <dfn id='canvastextdrawingstyles'><c- g>CanvasTextDrawingStyles</c-></dfn> {
  // text
  <c- b>attribute</c-> <c- b>DOMString</c-> <a href='#dom-context-2d-font' id='2dcontext:dom-context-2d-font'><c- g>font</c-></a>; // (default 10px sans-serif)
  <c- b>attribute</c-> <a href='#canvastextalign' id='2dcontext:canvastextalign'><c- n>CanvasTextAlign</c-></a> <a href='#dom-context-2d-textalign' id='2dcontext:dom-context-2d-textalign'><c- g>textAlign</c-></a>; // (default: &quot;start&quot;)
  <c- b>attribute</c-> <a href='#canvastextbaseline' id='2dcontext:canvastextbaseline'><c- n>CanvasTextBaseline</c-></a> <a href='#dom-context-2d-textbaseline' id='2dcontext:dom-context-2d-textbaseline'><c- g>textBaseline</c-></a>; // (default: &quot;alphabetic&quot;)
  <c- b>attribute</c-> <a href='#canvasdirection' id='2dcontext:canvasdirection'><c- n>CanvasDirection</c-></a> <a href='#dom-context-2d-direction' id='2dcontext:dom-context-2d-direction'><c- g>direction</c-></a>; // (default: &quot;inherit&quot;)
};

<c- b>interface</c-> <c- b>mixin</c-> <dfn id='canvaspath'><c- g>CanvasPath</c-></dfn> {
  // shared path API methods
  <c- b>void</c-> <a href='#dom-context-2d-closepath' id='2dcontext:dom-context-2d-closepath'><c- g>closePath</c-></a>();
  <c- b>void</c-> <a href='#dom-context-2d-moveto' id='2dcontext:dom-context-2d-moveto'><c- g>moveTo</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->);
  <c- b>void</c-> <a href='#dom-context-2d-lineto' id='2dcontext:dom-context-2d-lineto'><c- g>lineTo</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->);
  <c- b>void</c-> <a href='#dom-context-2d-quadraticcurveto' id='2dcontext:dom-context-2d-quadraticcurveto'><c- g>quadraticCurveTo</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>cpx</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>cpy</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->);
  <c- b>void</c-> <a href='#dom-context-2d-beziercurveto' id='2dcontext:dom-context-2d-beziercurveto'><c- g>bezierCurveTo</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>cp1x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>cp1y</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>cp2x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>cp2y</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->);
  <c- b>void</c-> <a href='#dom-context-2d-arcto' id='2dcontext:dom-context-2d-arcto'><c- g>arcTo</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>x1</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y1</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>x2</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y2</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>radius</c->); 
  <c- b>void</c-> <a href='#dom-context-2d-rect' id='2dcontext:dom-context-2d-rect'><c- g>rect</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>w</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>h</c->);
  <c- b>void</c-> <a href='#dom-context-2d-arc' id='2dcontext:dom-context-2d-arc'><c- g>arc</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>radius</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>startAngle</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>endAngle</c->, <c- b>optional</c-> <c- b>boolean</c-> <c- g>anticlockwise</c-> = <c- b>false</c->); 
  <c- b>void</c-> <a href='#dom-context-2d-ellipse' id='2dcontext:dom-context-2d-ellipse'><c- g>ellipse</c-></a>(<c- b>unrestricted</c-> <c- b>double</c-> <c- g>x</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>y</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>radiusX</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>radiusY</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>rotation</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>startAngle</c->, <c- b>unrestricted</c-> <c- b>double</c-> <c- g>endAngle</c->, <c- b>optional</c-> <c- b>boolean</c-> <c- g>anticlockwise</c-> = <c- b>false</c->); 
};

[<c- g>Exposed</c->=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <dfn id='canvasgradient'><c- g>CanvasGradient</c-></dfn> {
  // opaque object
  <c- b>void</c-> <a href='#dom-canvasgradient-addcolorstop' id='2dcontext:dom-canvasgradient-addcolorstop'><c- g>addColorStop</c-></a>(<c- b>double</c-> <c- g>offset</c->, <c- b>DOMString</c-> <c- g>color</c->);
};

[<c- g>Exposed</c->=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <dfn id='canvaspattern'><c- g>CanvasPattern</c-></dfn> {
  // opaque object
  <c- b>void</c-> <a href='#dom-canvaspattern-settransform' id='2dcontext:dom-canvaspattern-settransform'><c- g>setTransform</c-></a>(<c- b>optional</c-> <a href='https://drafts.fxtf.org/geometry/#dictdef-dommatrix2dinit' data-x-internal='dommatrix2dinit' id='2dcontext:dommatrix2dinit-2'><c- n>DOMMatrix2DInit</c-></a> <c- g>transform</c-> = {});
};

[<c- g>Exposed</c->=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <dfn id='textmetrics'><c- g>TextMetrics</c-></dfn> {
  // x-direction
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>double</c-> <a href='#dom-textmetrics-width' id='2dcontext:dom-textmetrics-width'><c- g>width</c-></a>; // advance width
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>double</c-> <a href='#dom-textmetrics-actualboundingboxleft' id='2dcontext:dom-textmetrics-actualboundingboxleft'><c- g>actualBoundingBoxLeft</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>double</c-> <a href='#dom-textmetrics-actualboundingboxright' id='2dcontext:dom-textmetrics-actualboundingboxright'><c- g>actualBoundingBoxRight</c-></a>;

  // y-direction
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>double</c-> <a href='#dom-textmetrics-fontboundingboxascent' id='2dcontext:dom-textmetrics-fontboundingboxascent'><c- g>fontBoundingBoxAscent</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>double</c-> <a href='#dom-textmetrics-fontboundingboxdescent' id='2dcontext:dom-textmetrics-fontboundingboxdescent'><c- g>fontBoundingBoxDescent</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>double</c-> <a href='#dom-textmetrics-actualboundingboxascent' id='2dcontext:dom-textmetrics-actualboundingboxascent'><c- g>actualBoundingBoxAscent</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>double</c-> <a href='#dom-textmetrics-actualboundingboxdescent' id='2dcontext:dom-textmetrics-actualboundingboxdescent'><c- g>actualBoundingBoxDescent</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>double</c-> <a href='#dom-textmetrics-emheightascent' id='2dcontext:dom-textmetrics-emheightascent'><c- g>emHeightAscent</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>double</c-> <a href='#dom-textmetrics-emheightdescent' id='2dcontext:dom-textmetrics-emheightdescent'><c- g>emHeightDescent</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>double</c-> <a href='#dom-textmetrics-hangingbaseline' id='2dcontext:dom-textmetrics-hangingbaseline'><c- g>hangingBaseline</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>double</c-> <a href='#dom-textmetrics-alphabeticbaseline' id='2dcontext:dom-textmetrics-alphabeticbaseline'><c- g>alphabeticBaseline</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>double</c-> <a href='#dom-textmetrics-ideographicbaseline' id='2dcontext:dom-textmetrics-ideographicbaseline'><c- g>ideographicBaseline</c-></a>;
};

[<c- g>Exposed</c->=(<c- n>Window</c->,<c- n>Worker</c->),
 <a href='structured-data.html#serializable' id='2dcontext:serializable'><c- g>Serializable</c-></a>]
<c- b>interface</c-> <dfn id='imagedata'><c- g>ImageData</c-></dfn> {
  <a href='#dom-imagedata' id='2dcontext:dom-imagedata'><c- b>constructor</c-></a>(<c- b>unsigned</c-> <c- b>long</c-> <c- g>sw</c->, <c- b>unsigned</c-> <c- b>long</c-> <c- g>sh</c->);
  <a href='#dom-imagedata' id='2dcontext:dom-imagedata-2'><c- b>constructor</c-></a>(<a href='https://heycam.github.io/webidl/#idl-Uint8ClampedArray' data-x-internal='idl-uint8clampedarray' id='2dcontext:idl-uint8clampedarray'><c- b>Uint8ClampedArray</c-></a> <c- g>data</c->, <c- b>unsigned</c-> <c- b>long</c-> <c- g>sw</c->, <c- b>optional</c-> <c- b>unsigned</c-> <c- b>long</c-> <c- g>sh</c->);

  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>unsigned</c-> <c- b>long</c-> <a href='#dom-imagedata-width' id='2dcontext:dom-imagedata-width'><c- g>width</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>unsigned</c-> <c- b>long</c-> <a href='#dom-imagedata-height' id='2dcontext:dom-imagedata-height'><c- g>height</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a href='https://heycam.github.io/webidl/#idl-Uint8ClampedArray' data-x-internal='idl-uint8clampedarray' id='2dcontext:idl-uint8clampedarray-2'><c- b>Uint8ClampedArray</c-></a> <a href='#dom-imagedata-data' id='2dcontext:dom-imagedata-data'><c- g>data</c-></a>;
};

[<c- g>Exposed</c->=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <dfn id='path2d'><c- g>Path2D</c-></dfn> {
  <a href='#dom-path2d' id='2dcontext:dom-path2d'><c- b>constructor</c-></a>(<c- b>optional</c-> (<a href='#path2d' id='2dcontext:path2d-8'><c- n>Path2D</c-></a> <c- b>or</c-> <c- b>DOMString</c->) <c- g>path</c->);

  <c- b>void</c-> <a href='#dom-path2d-addpath' id='2dcontext:dom-path2d-addpath'><c- g>addPath</c-></a>(<a href='#path2d' id='2dcontext:path2d-9'><c- n>Path2D</c-></a> <c- g>path</c->, <c- b>optional</c-> <a href='https://drafts.fxtf.org/geometry/#dictdef-dommatrix2dinit' data-x-internal='dommatrix2dinit' id='2dcontext:dommatrix2dinit-3'><c- n>DOMMatrix2DInit</c-></a> <c- g>transform</c-> = {});
};
<a href='#path2d' id='2dcontext:path2d-10'><c- n>Path2D</c-></a> <c- b>includes</c-> <a href='#canvaspath' id='2dcontext:canvaspath-3'><c- n>CanvasPath</c-></a>;</code></pre>

 

  <p class=note>To maintain compatibility with existing Web content, user agents need to
  enumerate methods defined in <code id=2dcontext:canvasuserinterface-2><a href=#canvasuserinterface>CanvasUserInterface</a></code> immediately after the <code id=2dcontext:dom-context-2d-stroke-3><a href=#dom-context-2d-stroke>stroke()</a></code> method on <code id=2dcontext:canvasrenderingcontext2d-17><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code>
  objects.</p>

  <dl class=domintro><dt><var>context</var> = <var>canvas</var> . <code id=2dcontext:dom-canvas-getcontext><a href=#dom-canvas-getcontext>getContext</a></code>('2d' [, { [ <code id=2dcontext:dom-canvasrenderingcontext2dsettings-alpha-2><a href=#dom-canvasrenderingcontext2dsettings-alpha>alpha</a></code>: true ] [, <code id=2dcontext:dom-canvasrenderingcontext2dsettings-desynchronized-2><a href=#dom-canvasrenderingcontext2dsettings-desynchronized>desynchronized</a></code>: false ] } ] )<dd>
    <p>Returns a <code id=2dcontext:canvasrenderingcontext2d-18><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code> object that is permanently bound to a
    particular <code id=2dcontext:the-canvas-element><a href=#the-canvas-element>canvas</a></code> element.</p>

    <p>If the <code id=2dcontext:dom-canvasrenderingcontext2dsettings-alpha-3><a href=#dom-canvasrenderingcontext2dsettings-alpha>alpha</a></code> member is
    false, then the context is forced to always be opaque.</p>

    <p>If the <code id=2dcontext:dom-canvasrenderingcontext2dsettings-desynchronized-3><a href=#dom-canvasrenderingcontext2dsettings-desynchronized>desynchronized</a></code> member is
    true, then the context might be <a href=#concept-canvas-desynchronized id=2dcontext:concept-canvas-desynchronized>desynchronized</a>.</p>
   <dt><var>context</var> . <code id=dom-context-2d-canvas-dev><a href=#dom-context-2d-canvas>canvas</a></code><dd>
    <p>Returns the <code id=2dcontext:the-canvas-element-2><a href=#the-canvas-element>canvas</a></code> element.</p>
   <dt><var>attributes</var> = <var>canvas</var> . <code id=2dcontext:dom-context-2d-canvas-getcontextattributes-2><a href=#dom-context-2d-canvas-getcontextattributes>getContextAttributes</a></code>()<dd>
    <p>Returns an object whose:</p>

    <ul><li><code id=2dcontext:concept-canvas-alpha><a href=#concept-canvas-alpha>alpha</a></code> member is true if the context has an alpha
     channel, or false if it was forced to be opaque.<li><code id=2dcontext:dom-canvasrenderingcontext2dsettings-desynchronized-4><a href=#dom-canvasrenderingcontext2dsettings-desynchronized>desynchronized</a></code>
     member is true if the context can be <a href=#concept-canvas-desynchronized id=2dcontext:concept-canvas-desynchronized-2>desynchronized</a>.</ul>
   </dl>

  

  <p>A <code id=2dcontext:canvasrenderingcontext2d-19><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code> object has an <dfn id=output-bitmap>output bitmap</dfn> that
  is initialized when the object is created.</p>


  <p>The <a href=#output-bitmap id=2dcontext:output-bitmap>output bitmap</a> has an <a href=#concept-canvas-origin-clean id=2dcontext:concept-canvas-origin-clean>origin-clean</a> flag, which can be set to true or false.
  Initially, when one of these bitmaps is created, its <a href=#concept-canvas-origin-clean id=2dcontext:concept-canvas-origin-clean-2>origin-clean</a> flag must be set to true.</p>


  <p>The <code id=2dcontext:canvasrenderingcontext2d-20><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code> object also has an <dfn id=concept-canvas-alpha>alpha</dfn> boolean. When a
  <code id=2dcontext:canvasrenderingcontext2d-21><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code> object's <a href=#concept-canvas-alpha id=2dcontext:concept-canvas-alpha-2>alpha</a> is false, then its alpha channel must be fixed to 1.0
  (fully opaque) for all pixels, and attempts to change the alpha component of any pixel must be
  silently ignored.</p>

  <p class=note>Thus, the bitmap of such a context starts off as <a id=2dcontext:opaque-black href=https://drafts.csswg.org/css-color/#opaque-black data-x-internal=opaque-black>opaque black</a> instead
  of <a id=2dcontext:transparent-black-2 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a>; <code id=2dcontext:dom-context-2d-clearrect-2><a href=#dom-context-2d-clearrect>clearRect()</a></code>
  always results in <a id=2dcontext:opaque-black-2 href=https://drafts.csswg.org/css-color/#opaque-black data-x-internal=opaque-black>opaque black</a> pixels, every fourth byte from <code id=2dcontext:dom-context-2d-getimagedata-2><a href=#dom-context-2d-getimagedata>getImageData()</a></code> is always 255, the <code id=2dcontext:dom-context-2d-putimagedata-3><a href=#dom-context-2d-putimagedata>putImageData()</a></code> method effectively ignores every
  fourth byte in its input, and so on. However, the alpha component of styles and images drawn
  onto the canvas are still honoured up to the point where they would impact the <a href=#output-bitmap id=2dcontext:output-bitmap-2>output
  bitmap</a>'s alpha channel; for instance, drawing a 50% transparent white square on a freshly
  created <a href=#output-bitmap id=2dcontext:output-bitmap-3>output bitmap</a> with its <a href=#concept-canvas-alpha id=2dcontext:concept-canvas-alpha-3>alpha</a> set
  to false will result in a fully-opaque gray square.</p>

  <p>The <code id=2dcontext:canvasrenderingcontext2d-22><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code> object also has a <dfn id=concept-canvas-desynchronized>desynchronized</dfn> boolean. When a
  <code id=2dcontext:canvasrenderingcontext2d-23><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code> object's <a href=#concept-canvas-desynchronized id=2dcontext:concept-canvas-desynchronized-3>desynchronized</a> is true, then the user agent may
  optimize the rendering of the canvas to reduce the latency, as measured from input events to
  rasterization, by desynchronizing the canvas paint cycle from the event loop, bypassing the
  ordinary user agent rendering algorithm, or both. Insofar as this mode involves bypassing the
  usual paint mechanisms, rasterization, or both, it might introduce visible tearing artifacts.</p>

  <p class=note>The user agent usually renders on a buffer which is not being displayed, quickly
  swapping it and the one being scanned out for presentation; the former buffer is called
  back buffer and the latter <i>front buffer</i>. A popular technique for reducing latency is called
  front buffer rendering, also known as <i>single buffer</i> rendering, where rendering happens in
  parallel and racily with the scanning out process. This technique reduces the latency at the price
  of potentially introducing tearing artifacts and can be used to implement in total or part of the
  <a href=#concept-canvas-desynchronized id=2dcontext:concept-canvas-desynchronized-4>desynchronized</a> boolean. <a href=references.html#refsMULTIPLEBUFFERING>[MULTIPLEBUFFERING]</a></p>

  <p class=note>The <a href=#concept-canvas-desynchronized id=2dcontext:concept-canvas-desynchronized-5>desynchronized</a> boolean
  can be useful when implementing certain kinds of applications, such as drawing applications,
  where the latency between input and rasterization is critical.</p>

  <p>The <dfn id=dom-context-2d-canvas-getcontextattributes><code>getContextAttributes()</code></dfn> method,
  when invoked, must return a <code id=2dcontext:canvasrenderingcontext2dsettings-2><a href=#canvasrenderingcontext2dsettings>CanvasRenderingContext2DSettings</a></code> dictionary containing
  the following members:</p>

  <ul><li><p><code id=2dcontext:concept-canvas-alpha-4><a href=#concept-canvas-alpha>alpha</a></code>, set to this context's <a href=#concept-canvas-alpha id=2dcontext:concept-canvas-alpha-5>alpha</a>.<li><p><code id=2dcontext:concept-canvas-desynchronized-6><a href=#concept-canvas-desynchronized>desynchronized</a></code>, set to this context's
   <a href=#concept-canvas-desynchronized id=2dcontext:concept-canvas-desynchronized-7>desynchronized</a>.</ul>

  <hr>

  <p>The <code id=2dcontext:canvasrenderingcontext2d-24><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code> 2D rendering context represents a flat linear
  Cartesian surface whose origin (0,0) is at the top left corner, with the coordinate space having
  <var>x</var> values increasing when going right, and <var>y</var> values increasing when going
  down. The <var>x</var>-coordinate of the right-most edge is equal to the width of the rendering
  context's <a href=#output-bitmap id=2dcontext:output-bitmap-4>output bitmap</a> in <a href=https://drafts.csswg.org/css-values/#px id="2dcontext:'px'" data-x-internal="'px'">CSS pixels</a>; similarly, the
  <var>y</var>-coordinate of the bottom-most edge is equal to the height of the rendering context's
  <a href=#output-bitmap id=2dcontext:output-bitmap-5>output bitmap</a> in <a href=https://drafts.csswg.org/css-values/#px id="2dcontext:'px'-2" data-x-internal="'px'">CSS pixels</a>.</p>

  <p>The size of the coordinate space does not necessarily represent the size of the actual bitmaps
  that the user agent will use internally or during rendering. On high-definition displays, for
  instance, the user agent may internally use bitmaps with four device pixels per unit in the
  coordinate space, so that the rendering remains at high quality throughout. Anti-aliasing can
  similarly be implemented using oversampling with bitmaps of a higher resolution than the final
  image on the display.</p>

  <div class=example>
   <p>Using <a href=https://drafts.csswg.org/css-values/#px id="2dcontext:'px'-3" data-x-internal="'px'">CSS pixels</a> to describe the size of a rendering context's
   <a href=#output-bitmap id=2dcontext:output-bitmap-6>output bitmap</a> does not mean that when rendered the canvas will cover an equivalent
   area in <a href=https://drafts.csswg.org/css-values/#px id="2dcontext:'px'-4" data-x-internal="'px'">CSS pixels</a>. <a href=https://drafts.csswg.org/css-values/#px id="2dcontext:'px'-5" data-x-internal="'px'">CSS pixels</a> are reused
   for ease of integration with CSS features, such as text layout.</p>

   <p>In other words, the <code id=2dcontext:the-canvas-element-3><a href=#the-canvas-element>canvas</a></code> element below's rendering context has a 200x200
   <a href=#output-bitmap id=2dcontext:output-bitmap-7>output  bitmap</a> (which internally uses <a href=https://drafts.csswg.org/css-values/#px id="2dcontext:'px'-6" data-x-internal="'px'">CSS pixels</a> as a
   unit for ease of integration with CSS) and is rendered as 100x100 <a href=https://drafts.csswg.org/css-values/#px id="2dcontext:'px'-7" data-x-internal="'px'">CSS
   pixels</a>:

   <pre><code class='html'><c- p>&lt;</c-><c- f>canvas</c-> <c- e>width</c-><c- o>=</c-><c- s>200</c-> <c- e>height</c-><c- o>=</c-><c- s>200</c-> <c- e>style</c-><c- o>=</c-><c- s>width:100px;height:100px</c-><c- p>&gt;</c-></code></pre>
  </div>

  <hr>

  <p>The <dfn id=2d-context-creation-algorithm>2D context creation algorithm</dfn>, which is passed a <var>target</var> (a
  <code id=2dcontext:the-canvas-element-4><a href=#the-canvas-element>canvas</a></code> element) and <var>options</var>, consists of running these steps:</p>

  <ol><li><p>Let <var>settings</var> be the result of <a href=https://heycam.github.io/webidl/#es-type-mapping id=2dcontext:concept-idl-convert data-x-internal=concept-idl-convert>converting</a> <var>options</var> to the dictionary type
   <code id=2dcontext:canvasrenderingcontext2dsettings-3><a href=#canvasrenderingcontext2dsettings>CanvasRenderingContext2DSettings</a></code>. (This can throw an exception.).<li><p>Let <var>context</var> be a new <code id=2dcontext:canvasrenderingcontext2d-25><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code> object.<li><p>Initialize <var>context</var>'s <code id=2dcontext:dom-context-2d-canvas-2><a href=#dom-context-2d-canvas>canvas</a></code>
   attribute to point to <var>target</var>.<li><p>Set <var>context</var>'s <a href=#output-bitmap id=2dcontext:output-bitmap-8>output bitmap</a> to the same bitmap as
   <var>target</var>'s bitmap (so that they are shared).<li><p><a href=#concept-canvas-set-bitmap-dimensions id=2dcontext:concept-canvas-set-bitmap-dimensions>Set bitmap dimensions</a> to
   <a href=#obtain-numeric-values id=2dcontext:obtain-numeric-values>the numeric values</a> of <var>target</var>'s <code id=2dcontext:attr-canvas-width><a href=#attr-canvas-width>width</a></code> and <code id=2dcontext:attr-canvas-height><a href=#attr-canvas-height>height</a></code>
   content attributes.<li><p>Set <var>context</var>'s <a href=#concept-canvas-alpha id=2dcontext:concept-canvas-alpha-6>alpha</a> to
   <var>settings</var>'s <dfn id=dom-canvasrenderingcontext2dsettings-alpha><code>alpha</code></dfn>.<li><p>Set <var>context</var>'s <a href=#concept-canvas-desynchronized id=2dcontext:concept-canvas-desynchronized-8>desynchronized</a> to <var>settings</var>'s <dfn id=dom-canvasrenderingcontext2dsettings-desynchronized><code>desynchronized</code></dfn>.<li><p>Return <var>context</var>.</ol>

  <hr>

  <p>When the user agent is to <dfn id=concept-canvas-set-bitmap-dimensions>set bitmap
  dimensions</dfn> to <var>width</var> and <var>height</var>, it must run these steps:</p>

  <ol><li><p><a href=#reset-the-rendering-context-to-its-default-state id=2dcontext:reset-the-rendering-context-to-its-default-state>Reset the rendering context to its default state</a>.<li><p>Resize the <a href=#output-bitmap id=2dcontext:output-bitmap-9>output bitmap</a> to the new <var>width</var> and <var>height</var>
   and clear it to <a id=2dcontext:transparent-black-3 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a>.<li><p>Let <var>canvas</var> be the <code id=2dcontext:the-canvas-element-5><a href=#the-canvas-element>canvas</a></code> element to which the rendering
   context's <code id=2dcontext:dom-context-2d-canvas-3><a href=#dom-context-2d-canvas>canvas</a></code> attribute was initialized.<li><p>If <a href=#obtain-numeric-values id=2dcontext:obtain-numeric-values-2>the numeric value</a> of
   <var>canvas</var>'s <code id=2dcontext:attr-canvas-width-2><a href=#attr-canvas-width>width</a></code> content
   attribute differs from <var>width</var>, then set <var>canvas</var>'s <code id=2dcontext:attr-canvas-width-3><a href=#attr-canvas-width>width</a></code> content attribute to the shortest possible string
   representing <var>width</var> as a <a id=2dcontext:valid-non-negative-integer href=common-microsyntaxes.html#valid-non-negative-integer>valid non-negative integer</a>.<li><p>If <a href=#obtain-numeric-values id=2dcontext:obtain-numeric-values-3>the numeric value</a> of
   <var>canvas</var>'s <code id=2dcontext:attr-canvas-height-2><a href=#attr-canvas-height>height</a></code> content
   attribute differs from <var>height</var>, then set <var>canvas</var>'s <code id=2dcontext:attr-canvas-height-3><a href=#attr-canvas-height>height</a></code> content attribute to the shortest possible string
   representing <var>height</var> as a <a id=2dcontext:valid-non-negative-integer-2 href=common-microsyntaxes.html#valid-non-negative-integer>valid non-negative integer</a>.</ol>

  <div class=example>
   <p>Only one square appears to be drawn in the following example:</p>
   <pre><code class='js'><c- c1>// canvas is a reference to a &lt;canvas&gt; element</c->
<c- a>var</c-> context <c- o>=</c-> canvas<c- p>.</c->getContext<c- p>(</c-><c- t>&apos;2d&apos;</c-><c- p>);</c->
context<c- p>.</c->fillRect<c- p>(</c-><c- mi>0</c-><c- p>,</c-><c- mi>0</c-><c- p>,</c-><c- mi>50</c-><c- p>,</c-><c- mi>50</c-><c- p>);</c->
canvas<c- p>.</c->setAttribute<c- p>(</c-><c- t>&apos;width&apos;</c-><c- p>,</c-> <c- t>&apos;300&apos;</c-><c- p>);</c-> <c- c1>// clears the canvas</c->
context<c- p>.</c->fillRect<c- p>(</c-><c- mi>0</c-><c- p>,</c-><c- mi>100</c-><c- p>,</c-><c- mi>50</c-><c- p>,</c-><c- mi>50</c-><c- p>);</c->
canvas<c- p>.</c->width <c- o>=</c-> canvas<c- p>.</c->width<c- p>;</c-> <c- c1>// clears the canvas</c->
context<c- p>.</c->fillRect<c- p>(</c-><c- mi>100</c-><c- p>,</c-><c- mi>0</c-><c- p>,</c-><c- mi>50</c-><c- p>,</c-><c- mi>50</c-><c- p>);</c-> <c- c1>// only this square remains</c-></code></pre>
  </div>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/canvas title="The CanvasRenderingContext2D.canvas property, part of the Canvas API, is a read-only reference to the HTMLCanvasElement object that is associated with a given context. It might be null if there is no associated <canvas> element.">CanvasRenderingContext2D/canvas</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-canvas><code>canvas</code></dfn> attribute must return the
  value it was initialized to when the object was created.</p>

  

  <hr>

  <p>The <code id=2dcontext:canvasfillrule-7><a href=#canvasfillrule>CanvasFillRule</a></code> enumeration is used to select the <dfn id=fill-rule>fill rule</dfn>
  algorithm by which to determine if a point is inside or outside a path.</p>

  <p>The value "<dfn id=dom-context-2d-fillrule-nonzero><code>nonzero</code></dfn>" value
  indicates the nonzero winding rule, wherein

     a point is considered to be outside a shape if the number of times a half-infinite straight
     line drawn from that point crosses the shape's path going in one direction is equal to the
     number of times it crosses the path going in the other direction.

  </p>


  <p>The "<dfn id=dom-context-2d-fillrule-evenodd><code>evenodd</code></dfn>" value indicates
  the even-odd rule, wherein

     a point is considered to be outside a shape if the number of times a half-infinite straight
     line drawn from that point crosses the shape's path is even.

  </p>

  <p>If a point is not outside a shape, it is inside the shape.</p>


  <hr>

  <p>The <code id=2dcontext:imagesmoothingquality-2><a href=#imagesmoothingquality>ImageSmoothingQuality</a></code> enumeration is used to express a preference for the
  interpolation quality to use when smoothing images.</p>

  <p>The "<dfn id=dom-context-2d-imagesmoothingquality-low><code>low</code></dfn>" value
  indicates a preference for a low level of image interpolation quality. Low-quality image
  interpolation may be more computationally efficient than higher settings.</p>

  <p>The "<dfn id=dom-context-2d-imagesmoothingquality-medium><code>medium</code></dfn>" value
  indicates a preference for a medium level of image interpolation quality.</p>

  <p>The "<dfn id=dom-context-2d-imagesmoothingquality-high><code>high</code></dfn>" value
  indicates a preference for a high level of image interpolation quality. High-quality image
  interpolation may be more computationally expensive than lower settings.</p>

  <p class=note>Bilinear scaling is an example of a relatively fast, lower-quality image-smoothing
  algorithm. Bicubic or Lanczos scaling are examples of image-smoothing algorithms that produce
  higher-quality output. This specification does not mandate that specific interpolation algorithms
  be used.</p>


  <h6 id=implementation-notes><span class=secno>4.12.5.1.1</span> Implementation notes<a href=#implementation-notes class=self-link></a></h6>

  <p><i>This section is non-normative.</i></p>

  <p>The <a href=#output-bitmap id=implementation-notes:output-bitmap>output bitmap</a>, when it is not directly displayed by the user agent,
  implementations can, instead of updating this bitmap, merely remember the sequence of drawing
  operations that have been applied to it until such time as the bitmap's actual data is needed
  (for example because of a call to <code id=implementation-notes:dom-context-2d-drawimage><a href=#dom-context-2d-drawimage>drawImage()</a></code>, or
  the <code id=implementation-notes:dom-createimagebitmap><a href=imagebitmap-and-animations.html#dom-createimagebitmap>createImageBitmap()</a></code> factory method). In many
  cases, this will be more memory efficient.</p>

  <p>The bitmap of a <code id=implementation-notes:the-canvas-element><a href=#the-canvas-element>canvas</a></code> element is the one bitmap that's pretty much always going
  to be needed in practice. The <a href=#output-bitmap id=implementation-notes:output-bitmap-2>output bitmap</a> of a rendering context, when it has one,
  is always just an alias to a <code id=implementation-notes:the-canvas-element-2><a href=#the-canvas-element>canvas</a></code> element's bitmap.</p>

  <p>Additional bitmaps are sometimes needed, e.g. to enable fast drawing when the canvas is being
  painted at a different size than its <a href=https://drafts.csswg.org/css-images/#intrinsic-dimensions id=implementation-notes:intrinsic-dimensions data-x-internal=intrinsic-dimensions>intrinsic size</a>,
  or to enable double buffering so that graphics updates, like page scrolling for example, can be
  processed concurrently while canvas draw commands are being executed.</p>

  <h6 id=the-canvas-state><span class=secno>4.12.5.1.2</span> The canvas state<a href=#the-canvas-state class=self-link></a></h6>

  <p>Objects that implement the <code id=the-canvas-state:canvasstate><a href=#canvasstate>CanvasState</a></code> interface maintain a stack of drawing
  states. <dfn id=drawing-state>Drawing states</dfn> consist of:</p>

  <ul class=brief><li>The current <a href=#transformations id=the-canvas-state:transformations>transformation matrix</a>.<li>The current <a href=#clipping-region id=the-canvas-state:clipping-region>clipping region</a>.<li>The current values of the following attributes: <code id=the-canvas-state:dom-context-2d-strokestyle><a href=#dom-context-2d-strokestyle>strokeStyle</a></code>, <code id=the-canvas-state:dom-context-2d-fillstyle><a href=#dom-context-2d-fillstyle>fillStyle</a></code>, <code id=the-canvas-state:dom-context-2d-globalalpha><a href=#dom-context-2d-globalalpha>globalAlpha</a></code>, <code id=the-canvas-state:dom-context-2d-linewidth><a href=#dom-context-2d-linewidth>lineWidth</a></code>, <code id=the-canvas-state:dom-context-2d-linecap><a href=#dom-context-2d-linecap>lineCap</a></code>, <code id=the-canvas-state:dom-context-2d-linejoin><a href=#dom-context-2d-linejoin>lineJoin</a></code>, <code id=the-canvas-state:dom-context-2d-miterlimit><a href=#dom-context-2d-miterlimit>miterLimit</a></code>, <code id=the-canvas-state:dom-context-2d-linedashoffset><a href=#dom-context-2d-linedashoffset>lineDashOffset</a></code>, <code id=the-canvas-state:dom-context-2d-shadowoffsetx><a href=#dom-context-2d-shadowoffsetx>shadowOffsetX</a></code>, <code id=the-canvas-state:dom-context-2d-shadowoffsety><a href=#dom-context-2d-shadowoffsety>shadowOffsetY</a></code>, <code id=the-canvas-state:dom-context-2d-shadowblur><a href=#dom-context-2d-shadowblur>shadowBlur</a></code>, <code id=the-canvas-state:dom-context-2d-shadowcolor><a href=#dom-context-2d-shadowcolor>shadowColor</a></code>, <code id=the-canvas-state:dom-context-2d-filter><a href=#dom-context-2d-filter>filter</a></code>, <code id=the-canvas-state:dom-context-2d-globalcompositeoperation><a href=#dom-context-2d-globalcompositeoperation>globalCompositeOperation</a></code>, <code id=the-canvas-state:dom-context-2d-font><a href=#dom-context-2d-font>font</a></code>, <code id=the-canvas-state:dom-context-2d-textalign><a href=#dom-context-2d-textalign>textAlign</a></code>, <code id=the-canvas-state:dom-context-2d-textbaseline><a href=#dom-context-2d-textbaseline>textBaseline</a></code>, <code id=the-canvas-state:dom-context-2d-direction><a href=#dom-context-2d-direction>direction</a></code>, <code id=the-canvas-state:dom-context-2d-imagesmoothingenabled><a href=#dom-context-2d-imagesmoothingenabled>imageSmoothingEnabled</a></code>, <code id=the-canvas-state:dom-context-2d-imagesmoothingquality><a href=#dom-context-2d-imagesmoothingquality>imageSmoothingQuality</a></code>.<li>The current <a href=#dash-list id=the-canvas-state:dash-list>dash list</a>.</ul>

  <p class=note>The <a href=#current-default-path id=the-canvas-state:current-default-path>current default path</a> and the rendering context's bitmaps are not
  part of the drawing state. The <a href=#current-default-path id=the-canvas-state:current-default-path-2>current default path</a> is persistent, and can only be
  reset using the <code id=the-canvas-state:dom-context-2d-beginpath><a href=#dom-context-2d-beginpath>beginPath()</a></code> method. The bitmaps
  depend on whether and how the rendering context is bound to a <code id=the-canvas-state:the-canvas-element><a href=#the-canvas-element>canvas</a></code> element.</p>

  <dl class=domintro><dt><var>context</var> . <code id=dom-context-2d-save-dev><a href=#dom-context-2d-save>save</a></code>()<dd>
    <p>Pushes the current state onto the stack.</p>
   <dt><var>context</var> . <code id=dom-context-2d-restore-dev><a href=#dom-context-2d-restore>restore</a></code>()<dd>
    <p>Pops the top state on the stack, restoring the context to that state.</p>
   </dl>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/save title="The CanvasRenderingContext2D.save() method of the Canvas 2D API saves the entire state of the canvas by pushing the current state onto a stack.">CanvasRenderingContext2D/save</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-save><code>save()</code></dfn> method, when invoked, must push
  a copy of the current drawing state onto the drawing state stack.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/restore title="The CanvasRenderingContext2D.restore() method of the Canvas 2D API restores the most recently saved canvas state by popping the top entry in the drawing state stack. If there is no saved state, this method does nothing.">CanvasRenderingContext2D/restore</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-restore><code>restore()</code></dfn> method, when invoked,
  must pop the top entry in the drawing state stack, and reset the drawing state it describes. If
  there is no saved state, then the method must do nothing.</p>

  <p>When the user agent is to <dfn id=reset-the-rendering-context-to-its-default-state>reset the rendering context to its default state</dfn>, it must
  clear the drawing state stack and everything that <a href=#drawing-state id=the-canvas-state:drawing-state>drawing state</a> consists of to
  initial values.</p>

  

  


  <h6 id=line-styles><span class=secno>4.12.5.1.3</span> Line styles<a href=#line-styles class=self-link></a></h6>

  <dl class=domintro><dt><var>context</var> . <code id=dom-context-2d-linewidth-dev><a href=#dom-context-2d-linewidth>lineWidth</a></code> [ = <var>value</var> ]<dt><var>styles</var> . <code id=line-styles:dom-context-2d-linewidth><a href=#dom-context-2d-linewidth>lineWidth</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current line width.</p>

    <p>Can be set, to change the line width. Values that are not finite values greater than zero are
    ignored.</p>
   <dt><var>context</var> . <code id=dom-context-2d-linecap-dev><a href=#dom-context-2d-linecap>lineCap</a></code> [ = <var>value</var> ]<dt><var>styles</var> . <code id=line-styles:dom-context-2d-linecap><a href=#dom-context-2d-linecap>lineCap</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current line cap style.</p>

    <p>Can be set, to change the line cap style.</p>

    <p>The possible line cap styles are "<code>butt</code>", "<code>round</code>", and "<code>square</code>". Other values are ignored.</p>
   <dt><var>context</var> . <code id=dom-context-2d-linejoin-dev><a href=#dom-context-2d-linejoin>lineJoin</a></code> [ = <var>value</var> ]<dt><var>styles</var> . <code id=line-styles:dom-context-2d-linejoin><a href=#dom-context-2d-linejoin>lineJoin</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current line join style.</p>

    <p>Can be set, to change the line join style.</p>

    <p>The possible line join styles are "<code>bevel</code>", "<code>round</code>", and "<code>miter</code>". Other values are ignored.</p>
   <dt><var>context</var> . <code id=dom-context-2d-miterlimit-dev><a href=#dom-context-2d-miterlimit>miterLimit</a></code> [ = <var>value</var> ]<dt><var>styles</var> . <code id=line-styles:dom-context-2d-miterlimit><a href=#dom-context-2d-miterlimit>miterLimit</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current miter limit ratio.</p>

    <p>Can be set, to change the miter limit ratio. Values that are not finite values greater than
    zero are ignored.</p>
   <dt><var>context</var> . <code id=dom-context-2d-setlinedash-dev><a href=#dom-context-2d-setlinedash>setLineDash</a></code>(<var>segments</var>)<dt><var>styles</var> . <code id=line-styles:dom-context-2d-setlinedash><a href=#dom-context-2d-setlinedash>setLineDash</a></code>(<var>segments</var>)<dd>
    <p>Sets the current line dash pattern (as used when stroking). The argument is a list of
    distances for which to alternately have the line on and the line off.</p>
   <dt><var>segments</var> = <var>context</var> . <code id=dom-context-2d-getlinedash-dev><a href=#dom-context-2d-getlinedash>getLineDash</a></code>()<dt><var>segments</var> = <var>styles</var> . <code id=line-styles:dom-context-2d-getlinedash><a href=#dom-context-2d-getlinedash>getLineDash</a></code>()<dd>
    <p>Returns a copy of the current line dash pattern. The array returned will always have an even
    number of entries (i.e. the pattern is normalized).</p>
   <dt><var>context</var> . <code id=dom-context-2d-linedashoffset-dev><a href=#dom-context-2d-linedashoffset>lineDashOffset</a></code><dt><var>styles</var> . <code id=line-styles:dom-context-2d-linedashoffset><a href=#dom-context-2d-linedashoffset>lineDashOffset</a></code><dd>
    <p>Returns the phase offset (in the same units as the line dash pattern).</p>

    <p>Can be set, to change the phase offset. Values that are not finite values are ignored.</p>
   </dl>

  

  <p>Objects that implement the <code id=line-styles:canvaspathdrawingstyles><a href=#canvaspathdrawingstyles>CanvasPathDrawingStyles</a></code> interface have attributes and
  methods (defined in this section) that control how lines are treated by the object.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineWidth title="The CanvasRenderingContext2D.lineWidth property of the Canvas 2D API sets the thickness of lines.">CanvasRenderingContext2D/lineWidth</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-linewidth><code>lineWidth</code></dfn> attribute gives the
  width of lines, in coordinate space units. On getting, it must return the current value. On
  setting, zero, negative, infinite, and NaN values must be ignored, leaving the value unchanged;
  other values must change the current value to the new value.</p>

  <p>When the object implementing the <code id=line-styles:canvaspathdrawingstyles-2><a href=#canvaspathdrawingstyles>CanvasPathDrawingStyles</a></code> interface is created, the
  <code id=line-styles:dom-context-2d-linewidth-2><a href=#dom-context-2d-linewidth>lineWidth</a></code> attribute must initially have the value
  1.0.</p>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineCap title="The CanvasRenderingContext2D.lineCap property of the Canvas 2D API determines the shape used to draw the end points of lines.">CanvasRenderingContext2D/lineCap</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-linecap><code>lineCap</code></dfn> attribute defines the type
  of endings that UAs will place on the end of lines. The three valid values are "<code>butt</code>", "<code>round</code>", and "<code>square</code>".</p>

  <p>On getting, it must return the current value. On setting, the current value must be changed
  to the new value.</p>

  <p>When the object implementing the <code id=line-styles:canvaspathdrawingstyles-3><a href=#canvaspathdrawingstyles>CanvasPathDrawingStyles</a></code> interface is created, the
  <code id=line-styles:dom-context-2d-linecap-2><a href=#dom-context-2d-linecap>lineCap</a></code> attribute must initially have the value
  "<code>butt</code>".</p>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineJoin title="The CanvasRenderingContext2D.lineJoin property of the Canvas 2D API determines the shape used to join two line segments where they meet.">CanvasRenderingContext2D/lineJoin</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-linejoin><code>lineJoin</code></dfn> attribute defines the type
  of corners that UAs will place where two lines meet. The three valid values are
  "<code>bevel</code>", "<code>round</code>", and "<code>miter</code>".</p>

  <p>On getting, it must return the current value. On setting, the current value must be changed
  to the new value.</p>

  <p>When the object implementing the <code id=line-styles:canvaspathdrawingstyles-4><a href=#canvaspathdrawingstyles>CanvasPathDrawingStyles</a></code> interface is created, the
  <code id=line-styles:dom-context-2d-linejoin-2><a href=#dom-context-2d-linejoin>lineJoin</a></code> attribute must initially have the value
  "<code>miter</code>".</p>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/miterLimit title="The CanvasRenderingContext2D.miterLimit property of the Canvas 2D API sets the miter limit ratio.">CanvasRenderingContext2D/miterLimit</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>When the <code id=line-styles:dom-context-2d-linejoin-3><a href=#dom-context-2d-linejoin>lineJoin</a></code> attribute has the value "<code>miter</code>", strokes use the miter limit ratio to decide how to render joins. The
  miter limit ratio can be explicitly set using the <dfn id=dom-context-2d-miterlimit><code>miterLimit</code></dfn> attribute. On getting, it must return
  the current value. On setting, zero, negative, infinite, and NaN values must be ignored, leaving
  the value unchanged; other values must change the current value to the new value.</p>
  

  <p>When the object implementing the <code id=line-styles:canvaspathdrawingstyles-5><a href=#canvaspathdrawingstyles>CanvasPathDrawingStyles</a></code> interface is created, the
  <code id=line-styles:dom-context-2d-miterlimit-2><a href=#dom-context-2d-miterlimit>miterLimit</a></code> attribute must initially have the value
  10.0.</p>

  <hr>

  <p>Each <code id=line-styles:canvaspathdrawingstyles-6><a href=#canvaspathdrawingstyles>CanvasPathDrawingStyles</a></code> object has a <dfn id=dash-list>dash list</dfn>, which is either
  empty or consists of an even number of non-negative numbers. Initially, the <a href=#dash-list id=line-styles:dash-list>dash list</a>
  must be empty.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/setLineDash title="The setLineDash() method of the Canvas 2D API's CanvasRenderingContext2D interface sets the line dash pattern used when stroking lines. It uses an array of values that specify alternating lengths of lines and gaps which describe the pattern.">CanvasRenderingContext2D/setLineDash</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>27+</span></span><span class="safari yes"><span>Safari</span><span>6.1+</span></span><span class="chrome yes"><span>Chrome</span><span>23+</span></span><hr><span class="opera yes"><span>Opera</span><span>15+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>11</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>27+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>7+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>25+</span></span><span class="webview_android yes"><span>WebView Android</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.5+</span></span><span class="opera_android yes"><span>Opera Android</span><span>14+</span></span></div></div></aside><p>The <dfn id=dom-context-2d-setlinedash><code>setLineDash()</code></dfn> method, when
  invoked, must run these steps:</p>

  <ol><li><p>Let <var>a</var> be the argument.<li><p>If any value in <var>a</var> is not finite (e.g. an Infinity or a NaN value), or
   if any value is negative (less than zero), then return (without throwing an exception;
   user agents could show a message on a developer console, though, as that would be helpful for
   debugging).<li><p>If the number of elements in <var>a</var> is odd, then let <var>a</var>
   be the concatenation of two copies of <var>a</var>.<li><p>Let the object's <a href=#dash-list id=line-styles:dash-list-2>dash list</a> be <var>a</var>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/getLineDash title="The getLineDash() method of the Canvas 2D API's CanvasRenderingContext2D interface gets the current line dash pattern.">CanvasRenderingContext2D/getLineDash</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>27+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>11</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>27+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>When the <dfn id=dom-context-2d-getlinedash><code>getLineDash()</code></dfn> method is
  invoked, it must return a sequence whose values are the values of the object's <a href=#dash-list id=line-styles:dash-list-3>dash
  list</a>, in the same order.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineDashOffset title="The CanvasRenderingContext2D.lineDashOffset property of the Canvas 2D API sets the line dash offset, or &quot;phase.&quot;">CanvasRenderingContext2D/lineDashOffset</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>27+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>11</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>27+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>It is sometimes useful to change the "phase" of the dash pattern, e.g. to achieve a "marching
  ants" effect. The phase can be set using the <dfn id=dom-context-2d-linedashoffset><code>lineDashOffset</code></dfn> attribute. On getting, it must
  return the current value. On setting, infinite and NaN values must be ignored, leaving the value
  unchanged; other values must change the current value to the new value.</p>

  <p>When the object implementing the <code id=line-styles:canvaspathdrawingstyles-7><a href=#canvaspathdrawingstyles>CanvasPathDrawingStyles</a></code> interface is created, the
  <code id=line-styles:dom-context-2d-linedashoffset-2><a href=#dom-context-2d-linedashoffset>lineDashOffset</a></code> attribute must initially have
  the value 0.0.</p>

  <hr>

  <p>When a user agent is to <dfn id=trace-a-path>trace a path</dfn>, given an object <var>style</var>
  that implements the <code id=line-styles:canvaspathdrawingstyles-8><a href=#canvaspathdrawingstyles>CanvasPathDrawingStyles</a></code> interface, it must run the following
  algorithm. This algorithm returns a new <a href=#concept-path id=line-styles:concept-path>path</a>.</p>

  <ol><li><p>Let <var>path</var> be a copy of the path being traced.<li><p>Prune all zero-length <a href=#line-segments id=line-styles:line-segments>line segments</a> from <var>path</var>.<li><p>Remove from <var>path</var> any subpaths containing no lines (i.e. subpaths with
   just one point).<li><p>Replace each point in each subpath of <var>path</var> other than the first point
   and the last point of each subpath by a <i>join</i> that joins the line leading to that point to
   the line leading out of that point, such that the subpaths all consist of two points (a starting
   point with a line leading out of it, and an ending point with a line leading into it), one or
   more lines (connecting the points and the joins), and zero or more joins (each connecting one
   line to another), connected together such that each subpath is a series of one or more lines with
   a join between each one and a point on each end.<li><p>Add a straight closing line to each closed subpath in <var>path</var> connecting
   the last point and the first point of that subpath; change the last point to a join (from the
   previously last line to the newly added closing line), and change the first point to a join (from
   the newly added closing line to the first line).</p>

   <li><p>If <var>style</var>'s <a href=#dash-list id=line-styles:dash-list-4>dash list</a> is empty, then jump to the step
   labeled <i>convert</i>.<li><p>Let <var>pattern width</var> be the concatenation of all the entries of
   <var>style</var>'s <a href=#dash-list id=line-styles:dash-list-5>dash list</a>, in coordinate space units.</p>

   <li><p>For each subpath <var>subpath</var> in <var>path</var>, run the
   following substeps. These substeps mutate the subpaths in <var>path</var> <i>in
   vivo</i>.</p>

    <ol><li><p>Let <var>subpath width</var> be the length of all the lines of <var>subpath</var>, in coordinate space units.</p>

     <li><p>Let <var>offset</var> be the value of <var>style</var>'s <code id=line-styles:dom-context-2d-linedashoffset-3><a href=#dom-context-2d-linedashoffset>lineDashOffset</a></code>, in coordinate space
     units.<li>
      <p>While <var>offset</var> is greater than <var>pattern width</var>,
      decrement it by <var>pattern width</var>.</p>

      <p>While <var>offset</var> is less than zero, increment it by <var>pattern
      width</var>.</p>
     <li><p>Define <var>L</var> to be a linear coordinate line defined along all lines in
     <var>subpath</var>, such that the start of the first line in the subpath is defined
     as coordinate 0, and the end of the last line in the subpath is defined as coordinate <var>subpath width</var>.<li><p>Let <var>position</var> be zero minus <var>offset</var>.<li><p>Let <var>index</var> be 0.<li><p>Let <var>current state</var> be <i>off</i> (the other states being <i>on</i>
     and <i>zero-on</i>).<li><p><i>Dash on</i>: Let <var>segment length</var> be
     the value of <var>style</var>'s <a href=#dash-list id=line-styles:dash-list-6>dash
     list</a>'s <var>index</var>th entry.<li><p>Increment <var>position</var> by <var>segment length</var>.<li><p>If <var>position</var> is greater than <var>subpath width</var>,
     then end these substeps for this subpath and start them again for the next subpath; if there
     are no more subpaths, then jump to the step labeled <i>convert</i> instead.<li><p>If <var>segment length</var> is nonzero, then let <var>current state</var> be
     <i>on</i>.<li><p>Increment <var>index</var> by one.<li><p><i>Dash off</i>: Let <var>segment
     length</var> be the value of <var>style</var>'s <a href=#dash-list id=line-styles:dash-list-7>dash list</a>'s <var>index</var>th entry.<li><p>Let <var>start</var> be the offset <var>position</var> on <var>L</var>.<li><p>Increment <var>position</var> by <var>segment length</var>.<li><p>If <var>position</var> is less than zero, then jump to the step labeled
     <i>post-cut</i>.<li><p>If <var>start</var> is less than zero, then let <var>start</var> be
     zero.<li><p>If <var>position</var> is greater than <var>subpath width</var>,
     then let <var>end</var> be the offset <var>subpath width</var> on <var>L</var>. Otherwise, let <var>end</var> be the offset <var>position</var> on <var>L</var>.<li>
      <p>Jump to the first appropriate step:</p>

      <dl class=switch><dt>If <var>segment length</var> is zero and <var>current state</var> is
       <i>off</i><dd>
        <p>Do nothing, just continue to the next step.</p>
       <dt>If <var>current state</var> is <i>off</i><dd>
        <p>Cut the line on which <var>end</var> finds itself short at <var>end</var> and place a point there, cutting in two the subpath that it was in;
        remove all line segments, joins, points, and subpaths that are between <var>start</var> and <var>end</var>; and finally place a single point at <var>start</var> with no lines connecting to it.</p>

        <p>The point has a <i>directionality</i> for the purposes of drawing line caps (see below).
        The directionality is the direction that the original line had at that point (i.e. when <var>L</var> was defined above).</p>
       <dt>Otherwise<dd>
        <p>Cut the line on which <var>start</var> finds itself into two at <var>start</var> and place a point there, cutting in two the subpath that it was in, and
        similarly cut the line on which <var>end</var> finds itself short at <var>end</var> and place a point there, cutting in two the subpath that <em>it</em> was in,
        and then remove all line segments, joins, points, and subpaths that are between <var>start</var> and <var>end</var>.</p>

        <p>If <var>start</var> and <var>end</var> are the same point, then this
        results in just the line being cut in two and two points being inserted there, with nothing
        being removed, unless a join also happens to be at that point, in which case the join must
        be removed.</p>
       </dl>
     <li><p><i>Post-cut</i>: If <var>position</var> is greater than <var>subpath width</var>, then jump to the step labeled <i>convert</i>.<li><p>If <var>segment length</var> is greater than zero, then let
     <var>positioned-at-on-dash</var> be false.<li><p>Increment <var>index</var> by one. If it is equal to the number of entries in
     <var>style</var>'s <a href=#dash-list id=line-styles:dash-list-8>dash list</a>, then let <var>index</var> be
     0.<li><p>Return to the step labeled <i>dash on</i>.</ol>
   <li>
    <p><i>Convert</i>: This is the step that converts the path to a new path that represents its
    stroke.</p>

    <p>Create a new <a href=#concept-path id=line-styles:concept-path-2>path</a> that describes the edge of the areas
    that would be covered if a straight line of length equal to <var>style</var>'s
    <code id=line-styles:dom-context-2d-linewidth-3><a href=#dom-context-2d-linewidth>lineWidth</a></code> was swept along each subpath in <var>path</var> while being kept at an angle such that the line is orthogonal to the path
    being swept, replacing each point with the end cap necessary to satisfy <var>style</var>'s <code id=line-styles:dom-context-2d-linecap-3><a href=#dom-context-2d-linecap>lineCap</a></code> attribute as
    described previously and elaborated below, and replacing each join with the join necessary to
    satisfy <var>style</var>'s <code id=line-styles:dom-context-2d-linejoin-4><a href=#dom-context-2d-linejoin>lineJoin</a></code>
    type, as defined below.</p>

    <p><strong>Caps</strong>: Each point has a flat edge perpendicular to the direction of the line
    coming out of it. This is then augmented according to the value of <var>style</var>'s <code id=line-styles:dom-context-2d-linecap-4><a href=#dom-context-2d-linecap>lineCap</a></code>. The "<code>butt</code>" value means that no additional line cap is added. The "<code>round</code>" value means that a semi-circle with the diameter equal to
    <var>style</var>'s <code id=line-styles:dom-context-2d-linewidth-4><a href=#dom-context-2d-linewidth>lineWidth</a></code> width must
    additionally be placed on to the line coming out of each point. The "<code>square</code>" value means that a rectangle with the length of <var>style</var>'s <code id=line-styles:dom-context-2d-linewidth-5><a href=#dom-context-2d-linewidth>lineWidth</a></code> width and the
    width of half <var>style</var>'s <code id=line-styles:dom-context-2d-linewidth-6><a href=#dom-context-2d-linewidth>lineWidth</a></code> width, placed flat against the edge
    perpendicular to the direction of the line coming out of the point, must be added at each
    point.</p>

    <p>Points with no lines coming out of them must have two caps placed back-to-back as if it was
    really two points connected to each other by an infinitesimally short straight line in the
    direction of the point's <i>directionality</i> (as defined above).</p>

    <p><strong>Joins</strong>: In addition to the point where a join occurs, two additional points
    are relevant to each join, one for each line: the two corners found half the line width away
    from the join point, one perpendicular to each line, each on the side furthest from the other
    line.</p>

    <p>A triangle connecting these two opposite corners with a straight line, with the third point
    of the triangle being the join point, must be added at all joins. The <code id=line-styles:dom-context-2d-linejoin-5><a href=#dom-context-2d-linejoin>lineJoin</a></code> attribute controls whether anything else is
    rendered. The three aforementioned values have the following meanings:</p>

    <p>The "<code>bevel</code>" value means that this is all that is rendered at
    joins.</p>

    <p>The "<code>round</code>" value means that an arc connecting the two aforementioned
    corners of the join, abutting (and not overlapping) the aforementioned triangle, with the
    diameter equal to the line width and the origin at the point of the join, must be added at
    joins.</p>

    <p>The "<code>miter</code>" value means that a second triangle must (if it can given
    the miter length) be added at the join, with one line being the line between the two
    aforementioned corners, abutting the first triangle, and the other two being continuations of
    the outside edges of the two joining lines, as long as required to intersect without going over
    the miter length.</p>

    <p>The miter length is the distance from the point where the join occurs to the intersection of
    the line edges on the outside of the join. The miter limit ratio is the maximum allowed ratio of
    the miter length to half the line width. If the miter length would cause the miter limit ratio
    (as set by <var>style</var>'s <code id=line-styles:dom-context-2d-miterlimit-3><a href=#dom-context-2d-miterlimit>miterLimit</a></code> attribute) to be exceeded, then this second
    triangle must not be added.</p> 



    <p>The subpaths in the newly created path must be oriented such that for any point, the number
    of times a half-infinite straight line drawn from that point crosses a subpath is even if and
    only if the number of times a half-infinite straight line drawn from that same point crosses a
    subpath going in one direction is equal to the number of times it crosses a subpath going in the
    other direction.</p>
   <li><p>Return the newly created path.</ol>



  


  <h6 id=text-styles><span class=secno>4.12.5.1.4</span> Text styles<a href=#text-styles class=self-link></a></h6>

  <dl class=domintro><dt><var>context</var> . <code id=dom-context-2d-font-dev><a href=#dom-context-2d-font>font</a></code> [ = <var>value</var> ]<dt><var>styles</var> . <code id=text-styles:dom-context-2d-font><a href=#dom-context-2d-font>font</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current font settings.</p>

    <p>Can be set, to change the font. The syntax is the same as for the CSS <a id="text-styles:'font'" href=https://drafts.csswg.org/css-fonts/#font-prop data-x-internal="'font'">'font'</a>
    property; values that cannot be parsed as CSS font values are ignored.</p>

    <p>Relative keywords and lengths are computed relative to the font of the <code id=text-styles:the-canvas-element><a href=#the-canvas-element>canvas</a></code>
    element.</p>
   <dt><var>context</var> . <code id=dom-context-2d-textalign-dev><a href=#dom-context-2d-textalign>textAlign</a></code> [ = <var>value</var> ]<dt><var>styles</var> . <code id=text-styles:dom-context-2d-textalign><a href=#dom-context-2d-textalign>textAlign</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current text alignment settings.</p>

    <p>Can be set, to change the alignment. The possible values are and their meanings are given
    below. Other values are ignored. The default is "<code>start</code>".</p>
   <dt><var>context</var> . <code id=dom-context-2d-textbaseline-dev><a href=#dom-context-2d-textbaseline>textBaseline</a></code> [ = <var>value</var> ]<dt><var>styles</var> . <code id=text-styles:dom-context-2d-textbaseline><a href=#dom-context-2d-textbaseline>textBaseline</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current baseline alignment settings.</p>

    <p>Can be set, to change the baseline alignment. The possible values and their meanings are
    given below. Other values are ignored. The default is "<code id=text-styles:dom-context-2d-textbaseline-alphabetic><a href=#dom-context-2d-textbaseline-alphabetic>alphabetic</a></code>".</p>
   <dt><var>context</var> . <code id=dom-context-2d-direction-dev><a href=#dom-context-2d-direction>direction</a></code> [ = <var>value</var> ]<dt><var>styles</var> . <code id=text-styles:dom-context-2d-direction><a href=#dom-context-2d-direction>direction</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current directionality.</p>

    <p>Can be set, to change the directionality. The possible values and their meanings are given
    below. Other values are ignored. The default is "<code id=text-styles:dom-context-2d-direction-inherit><a href=#dom-context-2d-direction-inherit>inherit</a></code>".</p>
   </dl>

  

  <p>Objects that implement the <code id=text-styles:canvastextdrawingstyles><a href=#canvastextdrawingstyles>CanvasTextDrawingStyles</a></code> interface have attributes
  (defined in this section) that control how text is laid out (rasterized or outlined) by the
  object. Such objects can also have a <dfn id=font-style-source-object>font style source object</dfn>. For
  <code id=text-styles:canvasrenderingcontext2d><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code> objects, this is the <code id=text-styles:the-canvas-element-2><a href=#the-canvas-element>canvas</a></code> element given by
  the value of the context's <code id=text-styles:dom-context-2d-canvas><a href=#dom-context-2d-canvas>canvas</a></code> attribute. For
  <code id=text-styles:offscreencanvasrenderingcontext2d><a href=#offscreencanvasrenderingcontext2d>OffscreenCanvasRenderingContext2D</a></code> objects, this is the <a href=#associated-offscreencanvas-object id=text-styles:associated-offscreencanvas-object>associated
  <code>OffscreenCanvas</code> object</a>.</p>

  <p>Font resolution for the <a href=#font-style-source-object id=text-styles:font-style-source-object>font style source object</a> requires a <a id=text-styles:font-source href=https://drafts.csswg.org/css-font-loading/#font-source data-x-internal=font-source>font
  source</a>. This is determined for a given <var>object</var> implementing
  <code id=text-styles:canvastextdrawingstyles-2><a href=#canvastextdrawingstyles>CanvasTextDrawingStyles</a></code> by the following steps: <a href=references.html#refsCSSFONTLOAD>[CSSFONTLOAD]</a></p>

  <ol><li><p>If <var>object</var>'s <a href=#font-style-source-object id=text-styles:font-style-source-object-2>font style source object</a> is a <code id=text-styles:the-canvas-element-3><a href=#the-canvas-element>canvas</a></code>
   element, return the element's <a id=text-styles:node-document href=https://dom.spec.whatwg.org/#concept-node-document data-x-internal=node-document>node document</a>.<li>
    <p>Otherwise, <var>object</var>'s <a href=#font-style-source-object id=text-styles:font-style-source-object-3>font style source object</a> is an
    <code id=text-styles:offscreencanvas><a href=#offscreencanvas>OffscreenCanvas</a></code> object:</p>

    <ol><li><p>Let <var>global</var> be <var>object</var>'s <a id=text-styles:concept-relevant-global href=webappapis.html#concept-relevant-global>relevant global
     object</a>.<li><p>If <var>global</var> is a <code id=text-styles:window><a href=window-object.html#window>Window</a></code> object, then return <var>global</var>'s
     <a href=window-object.html#concept-document-window id=text-styles:concept-document-window>associated <code>Document</code></a>.<li><p>Assert: <var>global</var> implements <code id=text-styles:workerglobalscope><a href=workers.html#workerglobalscope>WorkerGlobalScope</a></code>.<li><p>Return <var>global</var>.</ol>
   </ol>

  <div class=example>
   <p>This is an example of font resolution with a regular <code id=text-styles:the-canvas-element-4><a href=#the-canvas-element>canvas</a></code> element with ID <code>c1</code>.</p>

   <pre><code class='js'><c- kr>const</c-> font <c- o>=</c-> <c- k>new</c-> FontFace<c- p>(</c-><c- u>&quot;MyCanvasFont&quot;</c-><c- p>,</c-> <c- u>&quot;url(mycanvasfont.ttf)&quot;</c-><c- p>);</c->
documents<c- p>.</c->fonts<c- p>.</c->add<c- p>(</c->font<c- p>);</c->

<c- kr>const</c-> context <c- o>=</c-> document<c- p>.</c->getElementById<c- p>(</c-><c- u>&quot;c1&quot;</c-><c- p>).</c->getContext<c- p>(</c-><c- u>&quot;2d&quot;</c-><c- p>);</c->
document<c- p>.</c->fonts<c- p>.</c->ready<c- p>.</c->then<c- p>(</c-><c- a>function</c-><c- p>()</c-> <c- p>{</c->
  context<c- p>.</c->font <c- o>=</c-> <c- u>&quot;64px MyCanvasFont&quot;</c-><c- p>;</c->
  context<c- p>.</c->fillText<c- p>(</c-><c- u>&quot;hello&quot;</c-><c- p>,</c-> <c- mi>0</c-><c- p>,</c-> <c- mi>0</c-><c- p>);</c->
<c- p>});</c-></code></pre>

   <p>In this example, the canvas will display text using <code>mycanvasfont.ttf</code> as
   its font.</p>
  </div>

  <div class=example>
   <p>This is an example of how font resolution can happen using <code id=text-styles:offscreencanvas-2><a href=#offscreencanvas>OffscreenCanvas</a></code>.
   Assuming a <code id=text-styles:the-canvas-element-5><a href=#the-canvas-element>canvas</a></code> element with ID <code>c2</code> which is transferred to
   a worker like so:</p>

   <pre><code class='js'><c- kr>const</c-> offscreenCanvas <c- o>=</c-> document<c- p>.</c->getElementById<c- p>(</c-><c- u>&quot;c2&quot;</c-><c- p>).</c->transferControlToOffscreen<c- p>();</c->
worker<c- p>.</c->postMesage<c- p>(</c->offscreenCanvas<c- p>,</c-> <c- p>[</c->offscreenCanvas<c- p>]);</c-></code></pre>

   <p>Then, in the worker:</p>
   <pre><code class='js'>self<c- p>.</c->onmessage <c- o>=</c-> <c- a>function</c-><c- p>(</c->ev<c- p>)</c-> <c- p>{</c->
  <c- kr>const</c-> transferredCanvas <c- o>=</c-> ev<c- p>.</c->data<c- p>;</c->
  <c- kr>const</c-> context <c- o>=</c-> transferredCanvas<c- p>.</c->getContext<c- p>(</c-><c- u>&quot;2d&quot;</c-><c- p>);</c->
  <c- kr>const</c-> font <c- o>=</c-> <c- k>new</c-> FontFace<c- p>(</c-><c- u>&quot;MyFont&quot;</c-><c- p>,</c-> <c- u>&quot;url(myfont.ttf)&quot;</c-><c- p>);</c->
  self<c- p>.</c->fonts<c- p>.</c->add<c- p>(</c->font<c- p>);</c->
  self<c- p>.</c->fonts<c- p>.</c->ready<c- p>.</c->then<c- p>(</c-><c- a>function</c-><c- p>()</c-> <c- p>{</c->
    context<c- p>.</c->font <c- o>=</c-> <c- u>&quot;64px MyFont&quot;</c-><c- p>;</c->
    context<c- p>.</c->fillText<c- p>(</c-><c- u>&quot;hello&quot;</c-><c- p>,</c-> <c- mi>0</c-><c- p>,</c-> <c- mi>0</c-><c- p>);</c->
  <c- p>});</c->
<c- p>};</c-></code></pre>

   <p>In this example, the canvas will display a text using <code>myfont.ttf</code>.
   Notice that the font is only loaded inside the worker, and not in the document context.</p>
  </div>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/font title="The CanvasRenderingContext2D.font property of the Canvas 2D API specifies the current text style to use when drawing text. This string uses the same syntax as the CSS font specifier.">CanvasRenderingContext2D/font</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-font><code>font</code></dfn> IDL attribute, on setting, must
  be <a href=https://drafts.csswg.org/css-syntax/#parse-grammar id=text-styles:parse-something-according-to-a-css-grammar data-x-internal=parse-something-according-to-a-css-grammar>parsed as a CSS &lt;'font'>
  value</a> (but without supporting property-independent style sheet syntax like 'inherit'), and
  the resulting font must be assigned to the context, with the <a id="text-styles:'line-height'" href=https://drafts.csswg.org/css2/visudet.html#propdef-line-height data-x-internal="'line-height'">'line-height'</a> component
  forced to 'normal', with the <a id="text-styles:'font-size'" href=https://drafts.csswg.org/css-fonts/#font-size-prop data-x-internal="'font-size'">'font-size'</a> component converted to <a href=https://drafts.csswg.org/css-values/#px id="text-styles:'px'" data-x-internal="'px'">CSS pixels</a>, and with system fonts being computed to explicit values. If the
  new value is syntactically incorrect (including using property-independent style sheet syntax like
  'inherit' or 'initial'), then it must be ignored, without assigning a new font value. <a href=references.html#refsCSS>[CSS]</a></p>

  <p>Font family names must be interpreted in the context of the <a href=#font-style-source-object id=text-styles:font-style-source-object-4>font style source
  object</a> when the font is to be used; any fonts embedded using <code>@font-face</code> or loaded using <code id=text-styles:fontface><a href=infrastructure.html#fontface>FontFace</a></code> objects that are visible to the
  <a href=#font-style-source-object id=text-styles:font-style-source-object-5>font style source object</a> must therefore be available once they are loaded. (Each <a href=#font-style-source-object id=text-styles:font-style-source-object-6>font style source
  object</a> has a <a id=text-styles:font-source-2 href=https://drafts.csswg.org/css-font-loading/#font-source data-x-internal=font-source>font source</a>, which determines what fonts are available.) If a font
  is used before it is fully loaded, or if the <a href=#font-style-source-object id=text-styles:font-style-source-object-7>font style source object</a> does not have
  that font in scope at the time the font is to be used, then it must be treated as if it was an
  unknown font, falling back to another as described by the relevant CSS specifications. <a href=references.html#refsCSSFONTS>[CSSFONTS]</a> <a href=references.html#refsCSSFONTLOAD>[CSSFONTLOAD]</a></p>

  <p>On getting, the <code id=text-styles:dom-context-2d-font-2><a href=#dom-context-2d-font>font</a></code> attribute must return the <a href=https://drafts.csswg.org/cssom/#serialize-a-css-value id=text-styles:serializing-a-css-value data-x-internal=serializing-a-css-value>serialized form</a> of the current font of the context (with
  no <a id="text-styles:'line-height'-2" href=https://drafts.csswg.org/css2/visudet.html#propdef-line-height data-x-internal="'line-height'">'line-height'</a> component). <a href=references.html#refsCSSOM>[CSSOM]</a></p>

  <div class=example>

   <p>For example, after the following statement:</p>

   <pre><code class='js'>context<c- p>.</c->font <c- o>=</c-> <c- t>&apos;italic 400 12px/2 Unknown Font, sans-serif&apos;</c-><c- p>;</c-></code></pre>

   <p>...the expression <code>context.font</code> would evaluate to the string "<code>italic 12px "Unknown Font", sans-serif</code>". The "400"
   font-weight doesn't appear because that is the default value. The line-height doesn't appear
   because it is forced to "normal", the default value.</p>

  </div>

  <p>When the object implementing the <code id=text-styles:canvastextdrawingstyles-3><a href=#canvastextdrawingstyles>CanvasTextDrawingStyles</a></code> interface is created, the
  font of the context must be set to 10px sans-serif. When the <a id="text-styles:'font-size'-2" href=https://drafts.csswg.org/css-fonts/#font-size-prop data-x-internal="'font-size'">'font-size'</a> component is
  set to lengths using percentages, <a id="text-styles:'em'" href=https://drafts.csswg.org/css-values/#em data-x-internal="'em'">'em'</a> or <a id="text-styles:'ex'" href=https://drafts.csswg.org/css-values/#ex data-x-internal="'ex'">'ex'</a> units, or the 'larger' or
  'smaller' keywords, these must be interpreted relative to the <a id=text-styles:computed-value href=https://drafts.csswg.org/css-cascade/#computed-value data-x-internal=computed-value>computed value</a> of the
  <a id="text-styles:'font-size'-3" href=https://drafts.csswg.org/css-fonts/#font-size-prop data-x-internal="'font-size'">'font-size'</a> property of the <a href=#font-style-source-object id=text-styles:font-style-source-object-8>font style source object</a> at the time that
  the attribute is set, if it is an element. When the <a id="text-styles:'font-weight'" href=https://drafts.csswg.org/css-fonts/#font-weight-prop data-x-internal="'font-weight'">'font-weight'</a> component is set to
  the relative values 'bolder' and 'lighter', these must be interpreted relative to the
  <a id=text-styles:computed-value-2 href=https://drafts.csswg.org/css-cascade/#computed-value data-x-internal=computed-value>computed value</a> of the <a id="text-styles:'font-weight'-2" href=https://drafts.csswg.org/css-fonts/#font-weight-prop data-x-internal="'font-weight'">'font-weight'</a> property of the <a href=#font-style-source-object id=text-styles:font-style-source-object-9>font style
  source object</a> at the time that the attribute is set, if it is an element. If the <a href=https://drafts.csswg.org/css-cascade/#computed-value id=text-styles:computed-value-3 data-x-internal=computed-value>computed values</a> are undefined for a particular case (e.g. because
  the <a href=#font-style-source-object id=text-styles:font-style-source-object-10>font style source object</a> is not an element or is not <a id=text-styles:being-rendered href=rendering.html#being-rendered>being
  rendered</a>), then the relative keywords must be interpreted relative to the normal-weight
  10px sans-serif default.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/textAlign title="The CanvasRenderingContext2D.textAlign property of the Canvas 2D API specifies the current text alignment used when drawing text.">CanvasRenderingContext2D/textAlign</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-textalign><code>textAlign</code></dfn> IDL attribute, on
  getting, must return the current value. On setting, the current value must be changed to the new
  value. When the object implementing the <code id=text-styles:canvastextdrawingstyles-4><a href=#canvastextdrawingstyles>CanvasTextDrawingStyles</a></code> interface is
  created, the <code id=text-styles:dom-context-2d-textalign-2><a href=#dom-context-2d-textalign>textAlign</a></code> attribute must initially
  have the value <code id=text-styles:dom-context-2d-textalign-start><a href=#dom-context-2d-textalign-start>start</a></code>.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/textBaseline title="The CanvasRenderingContext2D.textBaseline property of the Canvas 2D API specifies the current text baseline used when drawing text.">CanvasRenderingContext2D/textBaseline</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-textbaseline><code>textBaseline</code></dfn> IDL attribute, on
  getting, must return the current value. On setting, the current value must be changed to the new
  value. When the object implementing the <code id=text-styles:canvastextdrawingstyles-5><a href=#canvastextdrawingstyles>CanvasTextDrawingStyles</a></code> interface is
  created, the <code id=text-styles:dom-context-2d-textbaseline-2><a href=#dom-context-2d-textbaseline>textBaseline</a></code> attribute must
  initially have the value <code id=text-styles:dom-context-2d-textbaseline-alphabetic-2><a href=#dom-context-2d-textbaseline-alphabetic>alphabetic</a></code>.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/direction title="The CanvasRenderingContext2D.direction property of the Canvas 2D API specifies the current text direction used to draw text.">CanvasRenderingContext2D/direction</a><p class=""><div class=support><span class="firefox no"><span>Firefox</span><span>No</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="opera no"><span>Opera</span><span>No</span></span><span class="edge_blink yes"><span>Edge</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><p>The <dfn id=dom-context-2d-direction><code>direction</code></dfn> IDL attribute, on
  getting, must return the current value. On setting, the current value must be changed to the new
  value. When the object implementing the <code id=text-styles:canvastextdrawingstyles-6><a href=#canvastextdrawingstyles>CanvasTextDrawingStyles</a></code> interface is
  created, the <code id=text-styles:dom-context-2d-direction-2><a href=#dom-context-2d-direction>direction</a></code> attribute must initially
  have the value "<code id=text-styles:dom-context-2d-direction-inherit-2><a href=#dom-context-2d-direction-inherit>inherit</a></code>".</p>

  

  <p>The <code id=text-styles:dom-context-2d-textalign-3><a href=#dom-context-2d-textalign>textAlign</a></code> attribute's allowed keywords are
  as follows:</p>

  <dl><dt><dfn id=dom-context-2d-textalign-start><code>start</code></dfn>
   <dd><p>Align to the start edge of the text (left side in left-to-right text, right side in
   right-to-left text).<dt><dfn id=dom-context-2d-textalign-end><code>end</code></dfn>
   <dd><p>Align to the end edge of the text (right side in left-to-right text, left side in
   right-to-left text).<dt><dfn id=dom-context-2d-textalign-left><code>left</code></dfn>
   <dd><p>Align to the left.<dt><dfn id=dom-context-2d-textalign-right><code>right</code></dfn>
   <dd><p>Align to the right.<dt><dfn id=dom-context-2d-textalign-center><code>center</code></dfn>
   <dd><p>Align to the center.</dl>

  <p>The <code id=text-styles:dom-context-2d-textbaseline-3><a href=#dom-context-2d-textbaseline>textBaseline</a></code>
  attribute's allowed keywords correspond to alignment points in the
  font:</p>

  <p><img src=/images/baselines.png width=738 alt="The top of the em square is roughly at the top of the glyphs in a font, the hanging baseline is where some glyphs like आ are anchored, the middle is half-way between the top of the em square and the bottom of the em square, the alphabetic baseline is where characters like Á, ÿ, f, and Ω are anchored, the ideographic baseline is where glyphs like 私 and 達 are anchored, and the bottom of the em square is roughly at the bottom of the glyphs in a font. The top and bottom of the bounding box can be far from these baselines, due to glyphs extending far outside the em square." height=300></p>

  <p>The keywords map to these alignment points as follows:</p>

  <dl><dt><dfn id=dom-context-2d-textbaseline-top><code>top</code></dfn>
   <dd>The top of the em square<dt><dfn id=dom-context-2d-textbaseline-hanging><code>hanging</code></dfn>
   <dd>The hanging baseline<dt><dfn id=dom-context-2d-textbaseline-middle><code>middle</code></dfn>
   <dd>The middle of the em square<dt><dfn id=dom-context-2d-textbaseline-alphabetic><code>alphabetic</code></dfn>
   <dd>The alphabetic baseline<dt><dfn id=dom-context-2d-textbaseline-ideographic><code>ideographic</code></dfn>
   <dd>The ideographic baseline<dt><dfn id=dom-context-2d-textbaseline-bottom><code>bottom</code></dfn>
   <dd>The bottom of the em square</dl>

  <p>The <code id=text-styles:dom-context-2d-direction-3><a href=#dom-context-2d-direction>direction</a></code> attribute's allowed keywords are
  as follows:</p>

  <dl><dt><dfn id=dom-context-2d-direction-ltr><code>ltr</code></dfn>

   <dd><p>Treat input to the <a href=#text-preparation-algorithm id=text-styles:text-preparation-algorithm>text preparation algorithm</a> as left-to-right text.<dt><dfn id=dom-context-2d-direction-rtl><code>rtl</code></dfn>

   <dd><p>Treat input to the <a href=#text-preparation-algorithm id=text-styles:text-preparation-algorithm-2>text preparation algorithm</a> as right-to-left text.<dt><dfn id=dom-context-2d-direction-inherit><code>inherit</code></dfn>

   <dd><p>Default to the directionality of the <code id=text-styles:the-canvas-element-6><a href=#the-canvas-element>canvas</a></code> element or <code id=text-styles:document><a href=dom.html#document>Document</a></code>
   as appropriate.</dl>

  <p>The <dfn id=text-preparation-algorithm>text preparation algorithm</dfn> is as follows. It takes as input a string <var>text
  </var>, a <code id=text-styles:canvastextdrawingstyles-7><a href=#canvastextdrawingstyles>CanvasTextDrawingStyles</a></code> object <var>target</var>, and an optional length
  <var>maxWidth</var>. It returns an array of glyph shapes, each positioned on a common coordinate
  space, a <var>physical alignment</var> whose value is one of <i>left</i>, <i>right</i>, and
  <i>center</i>, and an <a id=text-styles:inline-box href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a>. (Most callers of this algorithm ignore the
  <var>physical alignment</var> and the <a id=text-styles:inline-box-2 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a>.)</p>

  <ol><li><p>If <var>maxWidth</var> was provided but is less than or equal to zero or equal to NaN,
   then return an empty array.<li><p>Replace all <a id=text-styles:space-characters href=https://infra.spec.whatwg.org/#ascii-whitespace data-x-internal=space-characters>ASCII whitespace</a> in <var>text</var> with U+0020 SPACE
   characters.<li><p>Let <var>font</var> be the current font of <var>target</var>, as given
   by that object's <code id=text-styles:dom-context-2d-font-3><a href=#dom-context-2d-font>font</a></code> attribute.<li>
    <p>Apply the appropriate step from the following list to determine the value of <var>direction</var>:</p>

    <dl class=switch><dt>If the <var>target</var> object's <code id=text-styles:dom-context-2d-direction-4><a href=#dom-context-2d-direction>direction</a></code> attribute has the value "<code id=text-styles:dom-context-2d-direction-ltr><a href=#dom-context-2d-direction-ltr>ltr</a></code>"<dd>Let <var>direction</var> be '<a href=dom.html#concept-ltr id=text-styles:concept-ltr>ltr</a>'.<dt>If the <var>target</var> object's <code id=text-styles:dom-context-2d-direction-5><a href=#dom-context-2d-direction>direction</a></code> attribute has the value "<code id=text-styles:dom-context-2d-direction-rtl><a href=#dom-context-2d-direction-rtl>rtl</a></code>"<dd>Let <var>direction</var> be '<a href=dom.html#concept-rtl id=text-styles:concept-rtl>rtl</a>'.<dt>If the <var>target</var> object's <a href=#font-style-source-object id=text-styles:font-style-source-object-11>font style source object</a> is an
     element<dd>Let <var>direction</var> be <a id=text-styles:the-directionality href=dom.html#the-directionality>the directionality</a> of the <var>target</var> object's <a href=#font-style-source-object id=text-styles:font-style-source-object-12>font style source object</a>.<dt>If the <var>target</var> object's <a href=#font-style-source-object id=text-styles:font-style-source-object-13>font style source object</a> is a
     <code id=text-styles:document-2><a href=dom.html#document>Document</a></code> with a non-null <a id=text-styles:document-element href=https://dom.spec.whatwg.org/#document-element data-x-internal=document-element>document element</a><dd>Let <var>direction</var> be <a id=text-styles:the-directionality-2 href=dom.html#the-directionality>the directionality</a> of the <var>target</var>
     object's <a href=#font-style-source-object id=text-styles:font-style-source-object-14>font style source object</a>'s <a id=text-styles:document-element-2 href=https://dom.spec.whatwg.org/#document-element data-x-internal=document-element>document element</a>.<dt>Otherwise<dd>Let <var>direction</var> be '<a href=dom.html#concept-ltr id=text-styles:concept-ltr-2>ltr</a>'.</dl>
   <li><p>Form a hypothetical infinitely-wide CSS <a id=text-styles:line-box href=https://drafts.csswg.org/css2/visuren.html#line-box data-x-internal=line-box>line box</a> containing a single
   <a id=text-styles:inline-box-3 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a> containing the text <var>text</var>, with all the properties at their
   initial values except the <a id="text-styles:'font'-2" href=https://drafts.csswg.org/css-fonts/#font-prop data-x-internal="'font'">'font'</a> property of the <a id=text-styles:inline-box-4 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a> set to
   <var>font</var>, the <a id="text-styles:'direction'" href=https://drafts.csswg.org/css-writing-modes/#direction data-x-internal="'direction'">'direction'</a> property of the <a id=text-styles:inline-box-5 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a> set to
   <var>direction</var>, and the <a id="text-styles:'white-space'" href=https://drafts.csswg.org/css-text/#white-space-property data-x-internal="'white-space'">'white-space'</a> property set to 'pre'. <a href=references.html#refsCSS>[CSS]</a><li><p>If <var>maxWidth</var> was provided and the hypothetical width of the
   <a id=text-styles:inline-box-6 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a> in the hypothetical <a id=text-styles:line-box-2 href=https://drafts.csswg.org/css2/visuren.html#line-box data-x-internal=line-box>line box</a> is greater than
   <var>maxWidth</var> <a href=https://drafts.csswg.org/css-values/#px id="text-styles:'px'-2" data-x-internal="'px'">CSS pixels</a>, then change <var>font</var> to have a
   more condensed font (if one is available or if a reasonably readable one can be synthesized by
   applying a horizontal scale factor to the font) or a smaller font, and return to the previous
   step.<li>
    <p>The <var>anchor point</var> is a point on the <a id=text-styles:inline-box-7 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a>, and the <var>physical
    alignment</var> is one of the values <i>left</i>, <i>right</i>, and <i>center</i>. These
    variables are determined by the <code id=text-styles:dom-context-2d-textalign-4><a href=#dom-context-2d-textalign>textAlign</a></code> and
    <code id=text-styles:dom-context-2d-textbaseline-4><a href=#dom-context-2d-textbaseline>textBaseline</a></code> values as follows:</p>

    <p>Horizontal position:</p>

    <dl><dt>If <code id=text-styles:dom-context-2d-textalign-5><a href=#dom-context-2d-textalign>textAlign</a></code> is <code id=text-styles:dom-context-2d-textalign-left><a href=#dom-context-2d-textalign-left>left</a></code><dt>If <code id=text-styles:dom-context-2d-textalign-6><a href=#dom-context-2d-textalign>textAlign</a></code> is <code id=text-styles:dom-context-2d-textalign-start-2><a href=#dom-context-2d-textalign-start>start</a></code> and <var>direction</var> is
     'ltr'<dt>If <code id=text-styles:dom-context-2d-textalign-7><a href=#dom-context-2d-textalign>textAlign</a></code> is <code id=text-styles:dom-context-2d-textalign-end><a href=#dom-context-2d-textalign-end>end</a></code> and <var>direction</var> is 'rtl'<dd>Let the <var>anchor point</var>'s horizontal position be the left edge of the
     <a id=text-styles:inline-box-8 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a>, and let <var>physical alignment</var> be <i>left</i>.<dt>If <code id=text-styles:dom-context-2d-textalign-8><a href=#dom-context-2d-textalign>textAlign</a></code> is <code id=text-styles:dom-context-2d-textalign-right><a href=#dom-context-2d-textalign-right>right</a></code><dt>If <code id=text-styles:dom-context-2d-textalign-9><a href=#dom-context-2d-textalign>textAlign</a></code> is <code id=text-styles:dom-context-2d-textalign-end-2><a href=#dom-context-2d-textalign-end>end</a></code> and <var>direction</var> is 'ltr'<dt>If <code id=text-styles:dom-context-2d-textalign-10><a href=#dom-context-2d-textalign>textAlign</a></code> is <code id=text-styles:dom-context-2d-textalign-start-3><a href=#dom-context-2d-textalign-start>start</a></code> and <var>direction</var> is
     'rtl'<dd>Let the <var>anchor point</var>'s horizontal position be the right edge of the
     <a id=text-styles:inline-box-9 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a>, and let <var>physical alignment</var> be <i>right</i>.<dt>If <code id=text-styles:dom-context-2d-textalign-11><a href=#dom-context-2d-textalign>textAlign</a></code> is <code id=text-styles:dom-context-2d-textalign-center><a href=#dom-context-2d-textalign-center>center</a></code><dd>Let the <var>anchor point</var>'s horizontal position be half way between the left
     and right edges of the <a id=text-styles:inline-box-10 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a>, and let <var>physical alignment</var> be
     <i>center</i>.</dl>

    <p>Vertical position:</p>

    <dl><dt>If <code id=text-styles:dom-context-2d-textbaseline-5><a href=#dom-context-2d-textbaseline>textBaseline</a></code> is <code id=text-styles:dom-context-2d-textbaseline-top><a href=#dom-context-2d-textbaseline-top>top</a></code><dd>Let the <var>anchor point</var>'s vertical position be the top of the em box of
     the first available font of the <a id=text-styles:inline-box-11 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a>.<dt>If <code id=text-styles:dom-context-2d-textbaseline-6><a href=#dom-context-2d-textbaseline>textBaseline</a></code> is <code id=text-styles:dom-context-2d-textbaseline-hanging><a href=#dom-context-2d-textbaseline-hanging>hanging</a></code><dd>Let the <var>anchor point</var>'s vertical position be the hanging baseline of the
     first available font of the <a id=text-styles:inline-box-12 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a>.<dt>If <code id=text-styles:dom-context-2d-textbaseline-7><a href=#dom-context-2d-textbaseline>textBaseline</a></code> is <code id=text-styles:dom-context-2d-textbaseline-middle><a href=#dom-context-2d-textbaseline-middle>middle</a></code><dd>Let the <var>anchor point</var>'s vertical position be half way between the bottom
     and the top of the em box of the first available font of the <a id=text-styles:inline-box-13 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a>.<dt>If <code id=text-styles:dom-context-2d-textbaseline-8><a href=#dom-context-2d-textbaseline>textBaseline</a></code> is <code id=text-styles:dom-context-2d-textbaseline-alphabetic-3><a href=#dom-context-2d-textbaseline-alphabetic>alphabetic</a></code><dd>Let the <var>anchor point</var>'s vertical position be the alphabetic baseline of
     the first available font of the <a id=text-styles:inline-box-14 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a>.<dt>If <code id=text-styles:dom-context-2d-textbaseline-9><a href=#dom-context-2d-textbaseline>textBaseline</a></code> is <code id=text-styles:dom-context-2d-textbaseline-ideographic><a href=#dom-context-2d-textbaseline-ideographic>ideographic</a></code><dd>Let the <var>anchor point</var>'s vertical position be the ideographic baseline of
     the first available font of the <a id=text-styles:inline-box-15 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a>.<dt>If <code id=text-styles:dom-context-2d-textbaseline-10><a href=#dom-context-2d-textbaseline>textBaseline</a></code> is <code id=text-styles:dom-context-2d-textbaseline-bottom><a href=#dom-context-2d-textbaseline-bottom>bottom</a></code><dd>Let the <var>anchor point</var>'s vertical position be the bottom of the em box of
     the first available font of the <a id=text-styles:inline-box-16 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a>.</dl>
   <li>
    <p>Let <var>result</var> be an array constructed by iterating over each glyph in the
    <a id=text-styles:inline-box-17 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a> from left to right (if any), adding to the array, for each glyph, the
    shape of the glyph as it is in the <a id=text-styles:inline-box-18 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a>, positioned on a coordinate space
    using <a href=https://drafts.csswg.org/css-values/#px id="text-styles:'px'-3" data-x-internal="'px'">CSS pixels</a> with its origin is at the <var>anchor
    point</var>.</p>
   <li><p>Return <var>result</var>, <var>physical alignment</var>, and the inline
   box.</ol>


  <h6 id=building-paths><span class=secno>4.12.5.1.5</span> Building paths<a href=#building-paths class=self-link></a></h6>

  <p>Objects that implement the <code id=building-paths:canvaspath><a href=#canvaspath>CanvasPath</a></code> interface have a <a href=#concept-path id=building-paths:concept-path>path</a>. A <dfn id=concept-path>path</dfn> has a list of zero or
  more subpaths. Each subpath consists of a list of one or more points, connected by straight or
  curved <dfn id=line-segments>line segments</dfn>, and a flag indicating whether the subpath is closed or not. A
  closed subpath is one where the last point of the subpath is connected to the first point of the
  subpath by a straight line. Subpaths with only one point are ignored when painting the path.</p>

  <p><a href=#concept-path id=building-paths:concept-path-2>Paths</a> have a <dfn id=need-new-subpath>need new subpath</dfn> flag. When this
  flag is set, certain APIs create a new subpath rather than extending the previous one. When a
  <a href=#concept-path id=building-paths:concept-path-3>path</a> is created, its <a href=#need-new-subpath id=building-paths:need-new-subpath>need new subpath</a> flag must be
  set.</p>

  <p>When an object implementing the <code id=building-paths:canvaspath-2><a href=#canvaspath>CanvasPath</a></code> interface is created, its <a href=#concept-path id=building-paths:concept-path-4>path</a> must be initialized to zero subpaths.</p>

  <dl class=domintro><dt><var>context</var> . <code id=dom-context-2d-moveto-dev><a href=#dom-context-2d-moveto>moveTo</a></code>(<var>x</var>, <var>y</var>)<dt><var>path</var> . <code id=building-paths:dom-context-2d-moveto><a href=#dom-context-2d-moveto>moveTo</a></code>(<var>x</var>, <var>y</var>)<dd>
    <p>Creates a new subpath with the given point.</p>
   <dt><var>context</var> . <code id=dom-context-2d-closepath-dev><a href=#dom-context-2d-closepath>closePath</a></code>()<dt><var>path</var> . <code id=building-paths:dom-context-2d-closepath><a href=#dom-context-2d-closepath>closePath</a></code>()<dd>
    <p>Marks the current subpath as closed, and starts a new subpath with a point the same as the
    start and end of the newly closed subpath.</p>
   <dt><var>context</var> . <code id=dom-context-2d-lineto-dev><a href=#dom-context-2d-lineto>lineTo</a></code>(<var>x</var>, <var>y</var>)<dt><var>path</var> . <code id=building-paths:dom-context-2d-lineto><a href=#dom-context-2d-lineto>lineTo</a></code>(<var>x</var>, <var>y</var>)<dd>
    <p>Adds the given point to the current subpath, connected to the previous one by a straight
    line.</p>
   <dt><var>context</var> . <code id=dom-context-2d-quadraticcurveto-dev><a href=#dom-context-2d-quadraticcurveto>quadraticCurveTo</a></code>(<var>cpx</var>, <var>cpy</var>, <var>x</var>, <var>y</var>)<dt><var>path</var> . <code id=building-paths:dom-context-2d-quadraticcurveto><a href=#dom-context-2d-quadraticcurveto>quadraticCurveTo</a></code>(<var>cpx</var>, <var>cpy</var>, <var>x</var>, <var>y</var>)<dd>
    <p>Adds the given point to the current subpath, connected to the previous one by a quadratic
    Bézier curve with the given control point.</p>
   <dt><var>context</var> . <code id=dom-context-2d-beziercurveto-dev><a href=#dom-context-2d-beziercurveto>bezierCurveTo</a></code>(<var>cp1x</var>, <var>cp1y</var>, <var>cp2x</var>, <var>cp2y</var>, <var>x</var>, <var>y</var>)<dt><var>path</var> . <code id=building-paths:dom-context-2d-beziercurveto><a href=#dom-context-2d-beziercurveto>bezierCurveTo</a></code>(<var>cp1x</var>, <var>cp1y</var>, <var>cp2x</var>, <var>cp2y</var>, <var>x</var>, <var>y</var>)<dd>
    <p>Adds the given point to the current subpath, connected to the previous one by a cubic
    Bézier curve with the given control points.</p>
   <dt><var>context</var> . <code id=dom-context-2d-arcto-dev><a href=#dom-context-2d-arcto>arcTo</a></code>(<var>x1</var>, <var>y1</var>, <var>x2</var>, <var>y2</var>, <var>radius</var>)<dt><var>path</var> . <code id=building-paths:dom-context-2d-arcto><a href=#dom-context-2d-arcto>arcTo</a></code>(<var>x1</var>, <var>y1</var>, <var>x2</var>, <var>y2</var>, <var>radius</var>)<dd>
    <p>Adds an arc with the given control points and radius to the current subpath, connected to the
    previous point by a straight line.</p>

    <p>Throws an <a id=building-paths:indexsizeerror href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a> <code id=building-paths:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code> if the given
    radius is negative.</p>

    <figure class=diagrams>
     
     <img width=357 src=/images/arcTo1.png height=254 alt="">
     <img width=468 src=/images/arcTo2.png height=310 alt="">
     <img width=513 src=/images/arcTo3.png height=233 alt="">
    </figure>


   <dt><var>context</var> . <code id=dom-context-2d-arc-dev><a href=#dom-context-2d-arc>arc</a></code>(<var>x</var>, <var>y</var>, <var>radius</var>, <var>startAngle</var>, <var>endAngle</var> [, <var>anticlockwise</var> ] )<dt><var>path</var> . <code id=building-paths:dom-context-2d-arc><a href=#dom-context-2d-arc>arc</a></code>(<var>x</var>, <var>y</var>, <var>radius</var>, <var>startAngle</var>, <var>endAngle</var> [, <var>anticlockwise</var> ] )<dd>
    <p>Adds points to the subpath such that the arc described by the circumference of the circle
    described by the arguments, starting at the given start angle and ending at the given end angle,
    going in the given direction (defaulting to clockwise), is added to the path, connected to the
    previous point by a straight line.</p>

    <p>Throws an <a id=building-paths:indexsizeerror-2 href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a> <code id=building-paths:domexception-2><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code> if the given
    radius is negative.</p>

    <figure class=diagrams>
     
     <img width=590 src=/images/arc1.png height=255 alt="">
    </figure>


   <dt><var>context</var> . <code id=dom-context-2d-ellipse-dev><a href=#dom-context-2d-ellipse>ellipse</a></code>(<var>x</var>, <var>y</var>, <var>radiusX</var>, <var>radiusY</var>, <var>rotation</var>, <var>startAngle</var>, <var>endAngle</var> [, <var>anticlockwise</var>] )<dt><var>path</var> . <code id=building-paths:dom-context-2d-ellipse><a href=#dom-context-2d-ellipse>ellipse</a></code>(<var>x</var>, <var>y</var>, <var>radiusX</var>, <var>radiusY</var>, <var>rotation</var>, <var>startAngle</var>, <var>endAngle</var> [, <var>anticlockwise</var>] )<dd>
    <p>Adds points to the subpath such that the arc described by the circumference of the ellipse
    described by the arguments, starting at the given start angle and ending at the given end angle,
    going in the given direction (defaulting to clockwise), is added to the path, connected to the
    previous point by a straight line.</p>

    <p>Throws an <a id=building-paths:indexsizeerror-3 href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a> <code id=building-paths:domexception-3><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code> if the given
    radius is negative.</p>
   <dt><var>context</var> . <code id=dom-context-2d-rect-dev><a href=#dom-context-2d-rect>rect</a></code>(<var>x</var>, <var>y</var>, <var>w</var>, <var>h</var>)<dt><var>path</var> . <code id=building-paths:dom-context-2d-rect><a href=#dom-context-2d-rect>rect</a></code>(<var>x</var>, <var>y</var>, <var>w</var>, <var>h</var>)<dd>
    <p>Adds a new closed subpath to the path, representing the given rectangle.</p>
   </dl>

  

  <p>The following methods allow authors to manipulate the <a href=#concept-path id=building-paths:concept-path-5>paths</a>
  of objects implementing the <code id=building-paths:canvaspath-3><a href=#canvaspath>CanvasPath</a></code> interface.</p>

  <p>For objects implementing the <code id=building-paths:canvasdrawpath><a href=#canvasdrawpath>CanvasDrawPath</a></code> and <code id=building-paths:canvastransform><a href=#canvastransform>CanvasTransform</a></code>
  interfaces, the points passed to the methods, and the resulting lines added to <a href=#current-default-path id=building-paths:current-default-path>current
  default path</a> by these methods, must be transformed according to the <a href=#transformations id=building-paths:transformations>current transformation matrix</a> before being added to
  the path.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/moveTo title="The CanvasRenderingContext2D.moveTo() method of the Canvas 2D API begins a new sub-path at the point specified by the given (x, y) coordinates.">CanvasRenderingContext2D/moveTo</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-moveto><code>moveTo(<var>x</var>, <var>y</var>)</code></dfn>
  method, when invoked, must run these steps:</p>

  <ol><li><p>If either of the arguments are infinite or NaN, then return.<li><p>Create a new subpath with the specified point as its first (and only) point.</ol>

  <p>When the user agent is to <dfn id=ensure-there-is-a-subpath>ensure there is a subpath</dfn> for a coordinate (<var>x</var>,
  <var>y</var>) on a <a href=#concept-path id=building-paths:concept-path-6>path</a>, the user agent must check to see if
  the <a href=#concept-path id=building-paths:concept-path-7>path</a> has its <a href=#need-new-subpath id=building-paths:need-new-subpath-2>need new subpath</a> flag set. If it
  does, then the user agent must create a new subpath with the point (<var>x</var>, <var>y</var>) as
  its first (and only) point, as if the <code id=building-paths:dom-context-2d-moveto-2><a href=#dom-context-2d-moveto>moveTo()</a></code> method
  had been called, and must then unset the <a href=#concept-path id=building-paths:concept-path-8>path</a>'s <a href=#need-new-subpath id=building-paths:need-new-subpath-3>need new
  subpath</a> flag.</p>


  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/closePath title="The CanvasRenderingContext2D.closePath() method of the Canvas 2D API attempts to add a straight line from the current point to the start of the current sub-path. If the shape has already been closed or has only one point, this function does nothing.">CanvasRenderingContext2D/closePath</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-closepath><code>closePath()</code></dfn> method, when invoked,
  must do nothing if the object's path has no subpaths. Otherwise, it must mark the last subpath as
  closed, create a new subpath whose first point is the same as the previous subpath's first point,
  and finally add this new subpath to the path.</p>

  <p class=note>If the last subpath had more than one point in its list of points, then this is
  equivalent to adding a straight line connecting the last point back to the first point of the last
  subpath, thus "closing" the subpath.</p>

  <hr>

  <p>New points and the lines connecting them are added to subpaths using the methods described
  below. In all cases, the methods only modify the last subpath in the object's path.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineTo title="The CanvasRenderingContext2D method lineTo(), part of the Canvas 2D API, adds a straight line to the current sub-path by connecting the sub-path's last point to the specified (x, y) coordinates.">CanvasRenderingContext2D/lineTo</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-lineto><code>lineTo(<var>x</var>, <var>y</var>)</code></dfn>
  method, when invoked, must run these steps:</p>

  <ol><li><p>If either of the arguments are infinite or NaN, then return.<li><p>If the object's path has no subpaths, then <a href=#ensure-there-is-a-subpath id=building-paths:ensure-there-is-a-subpath>ensure there is a subpath</a> for
   <span>(<var>x</var>, <var>y</var>)</span>.<li><p>Otherwise, connect the last point in the subpath to the given point (<var>x</var>,
   <var>y</var>) using a straight line, and then add the given point (<var>x</var>, <var>y</var>) to
   the subpath.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/quadraticCurveTo title="The CanvasRenderingContext2D.quadraticCurveTo() method of the Canvas 2D API adds a quadratic Bézier curve to the current sub-path. It requires two points: the first one is a control point and the second one is the end point. The starting point is the latest point in the current path, which can be changed using moveTo() before creating the quadratic Bézier curve.">CanvasRenderingContext2D/quadraticCurveTo</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-quadraticcurveto><code>quadraticCurveTo(<var>cpx</var>,
  <var>cpy</var>, <var>x</var>, <var>y</var>)</code></dfn> method, when invoked, must run these
  steps:</p>

  <ol><li><p>If any of the arguments are infinite or NaN, then return.<li><p><a href=#ensure-there-is-a-subpath id=building-paths:ensure-there-is-a-subpath-2>Ensure there is a subpath</a> for <span>(<var>cpx</var>,
   <var>cpy</var>)</span><li><p>Connect the last point in the subpath to the given point (<var>x</var>, <var>y</var>)
   using a quadratic Bézier curve with control point (<var>cpx</var>, <var>cpy</var>). <a href=references.html#refsBEZIER>[BEZIER]</a><li><p>Add the given point (<var>x</var>, <var>y</var>) to the subpath.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/bezierCurveTo title="The CanvasRenderingContext2D.bezierCurveTo() method of the Canvas 2D API adds a cubic Bézier curve to the current sub-path. It requires three points: the first two are control points and the third one is the end point. The starting point is the latest point in the current path, which can be changed using moveTo() before creating the Bézier curve.">CanvasRenderingContext2D/bezierCurveTo</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-beziercurveto><code>bezierCurveTo(<var>cp1x</var>,
  <var>cp1y</var>, <var>cp2x</var>, <var>cp2y</var>, <var>x</var>, <var>y</var>)</code></dfn>
  method, when invoked, must run these steps:</p>

  <ol><li><p>If any of the arguments are infinite or NaN, then return.<li><p><a href=#ensure-there-is-a-subpath id=building-paths:ensure-there-is-a-subpath-3>Ensure there is a subpath</a> for <span>(<var>cp1x</var>,
   <var>cp1y</var>)</span>.<li><p>Connect the last point in the subpath to the given point (<var>x</var>, <var>y</var>)
   using a cubic Bézier curve with control points (<var>cp1x</var>, <var>cp1y</var>) and
   (<var>cp2x</var>, <var>cp2y</var>). <a href=references.html#refsBEZIER>[BEZIER]</a><li><p>Add the point (<var>x</var>, <var>y</var>) to the subpath.</ol>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/arcTo title="The CanvasRenderingContext2D.arcTo() method of the Canvas 2D API adds a circular arc to the current sub-path, using the given control points and radius. The arc is automatically connected to the path's latest point with a straight line, if necessary for the specified parameters.">CanvasRenderingContext2D/arcTo</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-arcto><code>arcTo(<var>x1</var>, <var>y1</var>, <var>x2</var>,
  <var>y2</var>, <var>radius</var>)</code></dfn> method, when invoked, must run these steps:</p>

  <ol><li><p>If any of the arguments are infinite or NaN, then return.<li><p><a href=#ensure-there-is-a-subpath id=building-paths:ensure-there-is-a-subpath-4>Ensure there is a subpath</a> for <span>(<var>x1</var>,
   <var>y1</var>)</span>.<li><p>If <var>radius</var> is negative, then throw an <a id=building-paths:indexsizeerror-4 href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a>
   <code id=building-paths:domexception-4><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let the point (<var>x0</var>, <var>y0</var>) be the last point in the subpath, transformed
   by the inverse of the <a href=#transformations id=building-paths:transformations-2>current transformation
   matrix</a> (so that it is in the same coordinate system as the points passed to the
   method).<li><p>If the point (<var>x0</var>, <var>y0</var>) is equal to the point (<var>x1</var>,
   <var>y1</var>), or if the point (<var>x1</var>, <var>y1</var>) is equal to the point
   (<var>x2</var>, <var>y2</var>), or if <var>radius</var> is zero, then add the point
   (<var>x1</var>, <var>y1</var>) to the subpath, and connect that point to the previous point
   (<var>x0</var>, <var>y0</var>) by a straight line.<li><p>Otherwise, if the points (<var>x0</var>, <var>y0</var>), (<var>x1</var>, <var>y1</var>),
   and (<var>x2</var>, <var>y2</var>) all lie on a single straight line, then add the point
   (<var>x1</var>, <var>y1</var>) to the subpath, and connect that point to the previous point
   (<var>x0</var>, <var>y0</var>) by a straight line.<li><p>Otherwise, let <var>The Arc</var> be the shortest arc given by circumference of the circle
   that has radius <var>radius</var>, and that has one point tangent to the half-infinite line that
   crosses the point (<var>x0</var>, <var>y0</var>) and ends at the point (<var>x1</var>,
   <var>y1</var>), and that has a different point tangent to the half-infinite line that ends at the
   point (<var>x1</var>, <var>y1</var>) and crosses the point (<var>x2</var>, <var>y2</var>). The
   points at which this circle touches these two lines are called the start and end tangent points
   respectively. Connect the point (<var>x0</var>, <var>y0</var>) to the start tangent point by a
   straight line, adding the start tangent point to the subpath, and then connect the start tangent
   point to the end tangent point by <var>The Arc</var>, adding the end tangent point to the
   subpath.</ol>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/arc title="The CanvasRenderingContext2D.arc() method of the Canvas 2D API adds a circular arc to the current sub-path.">CanvasRenderingContext2D/arc</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>11.6+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>12+</span></span></div></div></aside><p>The <dfn id=dom-context-2d-arc><code>arc(<var>x</var>, <var>y</var>, <var>radius</var>,
  <var>startAngle</var>, <var>endAngle</var>, <var>anticlockwise</var>)</code></dfn> method, when
  invoked, must run the <a href=#ellipse-method-steps id=building-paths:ellipse-method-steps>ellipse method steps</a> with this, <var>x</var>, <var>y</var>,
  <var>radius</var>, <var>radius</var>, 0, <var>startAngle</var>, <var>endAngle</var>, and
  <var>anticlockwise</var>.</p>

  <p class=note>This makes it equivalent to <code id=building-paths:dom-context-2d-ellipse-2><a href=#dom-context-2d-ellipse>ellipse()</a></code>
  except that both radii are equal and <var>rotation</var> is 0.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/ellipse title="The CanvasRenderingContext2D.ellipse() method of the Canvas 2D API adds an elliptical arc to the current sub-path.">CanvasRenderingContext2D/ellipse</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>48+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>31+</span></span><hr><span class="opera yes"><span>Opera</span><span>18+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>13+</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><p>The <dfn id=dom-context-2d-ellipse><code>ellipse(<var>x</var>, <var>y</var>,
  <var>radiusX</var>, <var>radiusY</var>, <var>rotation</var>, <var>startAngle</var>,
  <var>endAngle</var>, <var>anticlockwise</var>)</code></dfn> method, when invoked, must run the
  <a href=#ellipse-method-steps id=building-paths:ellipse-method-steps-2>ellipse method steps</a> with this, <var>x</var>, <var>y</var>, <var>radiusX</var>,
  <var>radiusY</var>, <var>rotation</var>, <var>startAngle</var>, <var>endAngle</var>, and
  <var>anticlockwise</var>.</p>

  <p>The <dfn id=ellipse-method-steps>ellipse method steps</dfn>, given <var>canvasPath</var>, <var>x</var>, <var>y</var>,
  <var>radiusX</var>, <var>radiusY</var>, <var>rotation</var>, <var>startAngle</var>,
  <var>endAngle</var>, and <var>anticlockwise</var>, are:

  <ol><li><p>If any of the arguments are infinite or NaN, then return.<li><p>If either <var>radiusX</var> or <var>radiusY</var> are negative, then throw an
   <a id=building-paths:indexsizeerror-5 href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a> <code id=building-paths:domexception-5><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>If <var>canvasPath</var>'s path has any subpaths, then add a straight line from the last
   point in the subpath to the start point of the arc.<li>
    <p>Add the start and end points of the arc to the subpath, and connect them with an arc. The arc
    and its start and end points are defined as follows:</p>

    <p>Consider an ellipse that has its origin at (<var>x</var>, <var>y</var>), that has a
    major-axis radius <var>radiusX</var> and a minor-axis radius <var>radiusY</var>, and that is
    rotated about its origin such that its semi-major axis is inclined <var>rotation</var> radians
    clockwise from the x-axis.</p>

    <p>If <var>anticlockwise</var> is false and <span><var>endAngle</var>-<var>startAngle</var></span> is equal to or greater than <span>2π</span>, or, if <var>anticlockwise</var> is <em>true</em> and <span><var>startAngle</var>-<var>endAngle</var></span> is equal to or greater than <span>2π</span>, then the arc is the whole circumference of this ellipse, and the point
    at <var>startAngle</var> along this circle's circumference, measured in radians clockwise from
    the ellipse's semi-major axis, acts as both the start point and the end point.</p>

    <p>Otherwise, the points at <var>startAngle</var> and <var>endAngle</var> along this circle's
    circumference, measured in radians clockwise from the ellipse's semi-major axis, are the start
    and end points respectively, and the arc is the path along the circumference of this ellipse
    from the start point to the end point, going anti-clockwise if <var>anticlockwise</var> is true,
    and clockwise otherwise. Since the points are on the ellipse, as opposed to being simply angles
    from zero, the arc can never cover an angle greater than <span>2π</span>
    radians.</p>

    <p class=note>Even if the arc covers the entire circumference of the ellipse and there are no
    other points in the subpath, the path is not closed unless the <code id=building-paths:dom-context-2d-closepath-2><a href=#dom-context-2d-closepath>closePath()</a></code> method is appropriately invoked.</p>
   </ol>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/rect title="The CanvasRenderingContext2D.rect() method of the Canvas 2D API adds a rectangle to the current path.">CanvasRenderingContext2D/rect</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-rect><code>rect(<var>x</var>, <var>y</var>, <var>w</var>,
  <var>h</var>)</code></dfn> method, when invoked, must run these steps:</p>

  <ol><li><p>If any of the arguments are infinite or NaN, then return.<li><p>Create a new subpath containing just the four points (<var>x</var>, <var>y</var>),
   (<var>x</var>+<var>w</var>, <var>y</var>), (<var>x</var>+<var>w</var>,
   <var>y</var>+<var>h</var>), (<var>x</var>, <var>y</var>+<var>h</var>), in that order, with those
   four points connected by straight lines.<li><p>Mark the subpath as closed.<li><p>Create a new subpath with the point (<var>x</var>, <var>y</var>) as the only point in the
   subpath.</ol>

  

  



  <h6 id=path2d-objects><span class=secno>4.12.5.1.6</span> <code id=path2d-objects:path2d><a href=#path2d>Path2D</a></code> objects<a href=#path2d-objects class=self-link></a></h6><div class=status><input onclick=toggleStatus(this) value=⋰ type=button><p class=support><strong>Support:</strong> path2d<span class="and_chr yes"><span>Chrome for Android</span> <span>80+</span></span><span class="chrome yes"><span>Chrome</span> <span>68+</span></span><span class="ios_saf yes"><span>iOS Safari</span> <span>9.0+</span></span><span class="firefox yes"><span>Firefox</span> <span>48+</span></span><span class="safari yes"><span>Safari</span> <span>9.1+</span></span><span class="samsung yes"><span>Samsung Internet</span> <span>10.1+</span></span><span class="and_uc partial"><span>UC Browser for Android (limited)</span> <span>12.12+</span></span><span class="edge yes"><span>Edge</span> <span>79+</span></span><span class="ie no"><span>IE</span> <span>None</span></span><span class="opera yes"><span>Opera</span> <span>55+</span></span><span class="op_mini no"><span>Opera Mini</span> <span>None</span></span><span class="android yes"><span>Android Browser</span> <span>80+</span></span><p class=caniuse>Source: <a href="https://caniuse.com/#feat=path2d">caniuse.com</a></div>

  <p><code id=path2d-objects:path2d-2><a href=#path2d>Path2D</a></code> objects can be used to declare paths that are then later used on
  objects implementing the <code id=path2d-objects:canvasdrawpath><a href=#canvasdrawpath>CanvasDrawPath</a></code> interface. In addition to many of the APIs
  described in earlier sections, <code id=path2d-objects:path2d-3><a href=#path2d>Path2D</a></code> objects have methods to combine paths, and to
  add text to paths.</p>

  <dl class=domintro><dt><var>path</var> = new <code id=dom-path2d-dev><a href=#dom-path2d>Path2D</a></code>()<dd><p>Creates a new empty <code id=path2d-objects:path2d-4><a href=#path2d>Path2D</a></code> object.<dt><var>path</var> = new <code id=path2d-objects:dom-path2d><a href=#dom-path2d>Path2D</a></code>(<var>path</var>)<dd>
    <p>When <var>path</var> is a <code id=path2d-objects:path2d-5><a href=#path2d>Path2D</a></code> object, returns a copy.</p>

    <p>When <var>path</var> is a string, creates the path described by the argument, interpreted as
    SVG path data. <a href=references.html#refsSVG>[SVG]</a>
   <dt><var>path</var> . <code id=dom-path2d-addpath-dev><a href=#dom-path2d-addpath>addPath</a></code>(<var>path</var> [, <var>transform</var> ] )<dd><p>Adds to the path the path given by the argument.</dl>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Path2D/Path2D title="The Path2D() constructor returns a newly instantiated Path2D object, optionally with another path as an argument (creates a copy), or optionally with a string consisting of SVG path data.">Path2D/Path2D</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>31+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie unknown"><span>Internet Explorer</span><span>?</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>31+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>42+</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Path2D title="The Path2D interface of the Canvas 2D API is used to declare a path that can then be used on a CanvasRenderingContext2D object. The path methods of the CanvasRenderingContext2D interface are also present on this interface, which gives you the convenience of being able to retain and replay your path whenever desired.">Path2D</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>31+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie unknown"><span>Internet Explorer</span><span>?</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>31+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-path2d><code>Path2D(<var>path</var>)</code></dfn> constructor, when
  invoked, must run these steps:</p>

  <ol><li><p>Let <var>output</var> be a new <code id=path2d-objects:path2d-6><a href=#path2d>Path2D</a></code> object.<li><p>If <var>path</var> is not given, then return <var>output</var>.<li><p>If <var>path</var> is a <code id=path2d-objects:path2d-7><a href=#path2d>Path2D</a></code> object, then add all subpaths of
   <var>path</var> to <var>output</var> and return <var>output</var>. (In other words, it returns a
   copy of the argument.)<li>
    <p>Let <var>svgPath</var> be the result of parsing and interpreting <var>path</var> according to
    <cite>SVG 2</cite>'s rules for path data. <a href=references.html#refsSVG>[SVG]</a></p>

    <p class=note>The resulting path could be empty. SVG defines error handling rules for parsing
    and applying path data.</p>
   <li><p>Let (<var>x</var>, <var>y</var>) be the last point in <var>svgPath</var>.<li><p>Add all the subpaths, if any, from <var>svgPath</var> to <var>output</var>.<li><p>Create a new subpath in <var>output</var> with (<var>x</var>, <var>y</var>) as the only
   point in the subpath.<li><p>Return <var>output</var>.</ol>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Path2D/addPath title="The Path2D.addPath() method of the Canvas 2D API adds one Path2D object to another Path2D object.">Path2D/addPath</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>34+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>34+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-path2d-addpath><code>addPath(<var>b</var>,
  <var>transform</var>)</code></dfn> method, when invoked on a <code id=path2d-objects:path2d-8><a href=#path2d>Path2D</a></code> object
  <var>a</var>, must run these steps:</p>

  <ol><li><p>If the <code id=path2d-objects:path2d-9><a href=#path2d>Path2D</a></code> object <var>b</var> has no subpaths, then return.<li><p>Let <var>matrix</var> be the result of <a href=https://drafts.fxtf.org/geometry/#create-a-dommatrix-from-the-2d-dictionary id=path2d-objects:create-a-dommatrix-from-a-2d-dictionary data-x-internal=create-a-dommatrix-from-a-2d-dictionary>creating a <code>DOMMatrix</code> from the 2D dictionary</a>
   <var>transform</var>.<li><p>If one or more of <var>matrix</var>'s <a id=path2d-objects:m11-element href=https://drafts.fxtf.org/geometry/#matrix-m11-element data-x-internal=m11-element>m11 element</a>, <a id=path2d-objects:m12-element href=https://drafts.fxtf.org/geometry/#matrix-m12-element data-x-internal=m12-element>m12 element</a>,
   <a id=path2d-objects:m21-element href=https://drafts.fxtf.org/geometry/#matrix-m21-element data-x-internal=m21-element>m21 element</a>, <a id=path2d-objects:m22-element href=https://drafts.fxtf.org/geometry/#matrix-m22-element data-x-internal=m22-element>m22 element</a>, <a id=path2d-objects:m41-element href=https://drafts.fxtf.org/geometry/#matrix-m41-element data-x-internal=m41-element>m41 element</a>, or <a id=path2d-objects:m42-element href=https://drafts.fxtf.org/geometry/#matrix-m42-element data-x-internal=m42-element>m42
   element</a> are infinite or NaN, then return.<li><p>Create a copy of all the subpaths in <var>b</var>. Let this copy be known as
   <var>c</var>.<li><p>Transform all the coordinates and lines in <var>c</var> by the transform matrix
   <var>matrix</var>.<li><p>Let (<var>x</var>, <var>y</var>) be the last point in the last subpath
   of <var>c</var>.<li><p>Add all the subpaths in <var>c</var> to <var>a</var>.<li><p>Create a new subpath in <var>a</var> with (<var>x</var>, <var>y</var>) as the only point
   in the subpath.</ol>

  


  <h6 id=transformations><span class=secno>4.12.5.1.7</span> <dfn>Transformations</dfn><a href=#transformations class=self-link></a></h6>

  <p>Objects that implement the <code id=transformations:canvastransform><a href=#canvastransform>CanvasTransform</a></code> interface have a <dfn id=current-transformation-matrix>current
  transformation matrix</dfn>, as well as methods (described in this section) to manipulate it. When
  an object implementing the <code id=transformations:canvastransform-2><a href=#canvastransform>CanvasTransform</a></code> interface is created, its transformation
  matrix must be initialized to the identity matrix.</p>

  <p>The <a href=#current-transformation-matrix id=transformations:current-transformation-matrix>current transformation matrix</a> is applied to coordinates when creating the
  <a href=#current-default-path id=transformations:current-default-path>current default path</a>, and when painting text, shapes, and <code id=transformations:path2d><a href=#path2d>Path2D</a></code>
  objects, on objects implementing the <code id=transformations:canvastransform-3><a href=#canvastransform>CanvasTransform</a></code> interface.</p>
  

  

  <p>The transformations must be performed in reverse order.</p>

  <p class=note>For instance, if a scale transformation that doubles the width is applied to the
  canvas, followed by a rotation transformation that rotates drawing operations by a quarter turn,
  and a rectangle twice as wide as it is tall is then drawn on the canvas, the actual result will be
  a square.</p> 

  

  <dl class=domintro><dt><var>context</var> . <code id=dom-context-2d-scale-dev><a href=#dom-context-2d-scale>scale</a></code>(<var>x</var>, <var>y</var>)<dd>
    <p>Changes the <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-2>current transformation matrix</a> to apply a scaling transformation
    with the given characteristics.</p>
   <dt><var>context</var> . <code id=dom-context-2d-rotate-dev><a href=#dom-context-2d-rotate>rotate</a></code>(<var>angle</var>)<dd>
    <p>Changes the <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-3>current transformation matrix</a> to apply a rotation transformation
    with the given characteristics. The angle is in radians.</p>
   <dt><var>context</var> . <code id=dom-context-2d-translate-dev><a href=#dom-context-2d-translate>translate</a></code>(<var>x</var>, <var>y</var>)<dd>
    <p>Changes the <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-4>current transformation matrix</a> to apply a translation transformation
    with the given characteristics.</p>
   <dt><var>context</var> . <code id=dom-context-2d-transform-dev><a href=#dom-context-2d-transform>transform</a></code>(<var>a</var>, <var>b</var>, <var>c</var>, <var>d</var>, <var>e</var>, <var>f</var>)<dd>
    <p>Changes the <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-5>current transformation matrix</a> to apply the matrix given by the
    arguments as described below.</p>
   <dt><var>matrix</var> = <var>context</var> . <code id=dom-context-2d-gettransform-dev><a href=#dom-context-2d-gettransform>getTransform</a></code>()<dd>
    <p>Returns a copy of the <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-6>current transformation matrix</a>, as a newly created
    <code id=transformations:dommatrix><a data-x-internal=dommatrix href=https://drafts.fxtf.org/geometry/#dommatrix>DOMMatrix</a></code> object.</p>
   <dt><var>context</var> . <code id=dom-context-2d-settransform-dev><a href=#dom-context-2d-settransform>setTransform</a></code>(<var>a</var>, <var>b</var>, <var>c</var>, <var>d</var>, <var>e</var>, <var>f</var>)<dd>
    <p>Changes the <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-7>current transformation matrix</a> <em>to</em> the matrix given by the
    arguments as described below.</p>
   <dt><var>context</var> . <code id=dom-context-2d-settransform-matrix-dev><a href=#dom-context-2d-settransform-matrix>setTransform</a></code>(<var>transform</var>)<dd>
    <p>Changes the <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-8>current transformation matrix</a> <em>to</em> the matrix represented by
    the passed <code id=transformations:dommatrix2dinit><a data-x-internal=dommatrix2dinit href=https://drafts.fxtf.org/geometry/#dictdef-dommatrix2dinit>DOMMatrix2DInit</a></code> dictionary.</p>
   <dt><var>context</var> . <code id=dom-context-2d-resettransform-dev><a href=#dom-context-2d-resettransform>resetTransform</a></code>()<dd>
    <p>Changes the <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-9>current transformation matrix</a> to the identity matrix.</p>
   </dl>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/scale title="The CanvasRenderingContext2D.scale() method of the Canvas 2D API adds a scaling transformation to the canvas units horizontally and/or vertically.">CanvasRenderingContext2D/scale</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-scale><code>scale(<var>x</var>, <var>y</var>)</code></dfn>
  method, when invoked, must run these steps:</p>

  <ol><li><p>If either of the arguments are infinite or NaN, then return.<li><p>Add the scaling transformation described by the arguments to the <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-10>current
   transformation matrix</a>. The <var>x</var> argument represents the scale factor in the
   horizontal direction and the <var>y</var> argument represents the scale factor in the vertical
   direction. The factors are multiples.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/rotate title="The CanvasRenderingContext2D.rotate() method of the Canvas 2D API adds a rotation to the transformation matrix.">CanvasRenderingContext2D/rotate</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-rotate><code>rotate(<var>angle</var>)</code></dfn> method,
  when invoked, must run these steps:</p>

  <ol><li><p>If <var>angle</var> is infinite or NaN, then return.<li><p>Add the rotation transformation described by the argument to the <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-11>current
   transformation matrix</a>. The <var>angle</var> argument represents a clockwise rotation angle
   expressed in radians.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/translate title="The CanvasRenderingContext2D.translate() method of the Canvas 2D API adds a translation transformation to the current matrix.">CanvasRenderingContext2D/translate</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-translate><code>translate(<var>x</var>,
  <var>y</var>)</code></dfn> method, when invoked, must run these steps:</p>

  <ol><li><p>If either of the arguments are infinite or NaN, then return.<li><p>Add the translation transformation described by the arguments to the <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-12>current
   transformation matrix</a>. The <var>x</var> argument represents the translation distance in
   the horizontal direction and the <var>y</var> argument represents the translation distance in the
   vertical direction. The arguments are in coordinate space units.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/transform title="The CanvasRenderingContext2D.transform() method of the Canvas 2D API multiplies the current transformation with the matrix described by the arguments of this method. This lets you scale, rotate, translate (move), and skew the context.">CanvasRenderingContext2D/transform</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-transform><code>transform(<var>a</var>, <var>b</var>,
  <var>c</var>, <var>d</var>, <var>e</var>, <var>f</var>)</code></dfn> method, when invoked, must
  run these steps:</p>

  <ol><li><p>If any of the arguments are infinite or NaN, then return.<li><p>Replace the <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-13>current transformation matrix</a> with the result of multiplying the
   current transformation matrix with the matrix described by:</ol>

  

  <table class=matrix><tr><td><var>a</var><td><var>c</var><td><var>e</var><tr><td><var>b</var><td><var>d</var><td><var>f</var><tr><td>0<td>0<td>1</table>

  <p class=note>The arguments <var>a</var>, <var>b</var>, <var>c</var>, <var>d</var>,
  <var>e</var>, and <var>f</var> are sometimes called <var>m11</var>, <var>m12</var>,
  <var>m21</var>, <var>m22</var>, <var>dx</var>, and <var>dy</var> or <var>m11</var>,
  <var>m21</var>, <var>m12</var>, <var>m22</var>, <var>dx</var>, and <var>dy</var>. Care ought to be
  taken in particular with the order of the second and third arguments (<var>b</var> and
  <var>c</var>) as their order varies from API to API and APIs sometimes use the notation
  <var>m12</var>/<var>m21</var> and sometimes <var>m21</var>/<var>m12</var> for those positions.</p>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/getTransform title="The CanvasRenderingContext2D.getTransform() method of the Canvas 2D API retrieves the current transformation matrix being applied to the context.">CanvasRenderingContext2D/getTransform</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>70+</span></span><span class="safari yes"><span>Safari</span><span>11+</span></span><span class="chrome yes"><span>Chrome</span><span>68+</span></span><hr><span class="opera yes"><span>Opera</span><span>55+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>11+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>68+</span></span><span class="webview_android yes"><span>WebView Android</span><span>68+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>10.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>48+</span></span></div></div></aside><p>The <dfn id=dom-context-2d-gettransform><code>getTransform()</code></dfn> method, when
  invoked, must return a newly created <code id=transformations:dommatrix-2><a data-x-internal=dommatrix href=https://drafts.fxtf.org/geometry/#dommatrix>DOMMatrix</a></code> representing a copy of the
  <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-14>current transformation matrix</a> matrix of the context.</p>

  <p class=note>This returned object is not live, so updating it will not affect the
  <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-15>current transformation matrix</a>, and updating the <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-16>current transformation
  matrix</a> will not affect an already returned <code id=transformations:dommatrix-3><a data-x-internal=dommatrix href=https://drafts.fxtf.org/geometry/#dommatrix>DOMMatrix</a></code>.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/setTransform title="The CanvasRenderingContext2D.setTransform() method of the Canvas 2D API resets (overrides) the current transformation to the identity matrix, and then invokes a transformation described by the arguments of this method. This lets you scale, rotate, translate (move), and skew the context.">CanvasRenderingContext2D/setTransform</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-settransform><code>setTransform(<var>a</var>, <var>b</var>,
  <var>c</var>, <var>d</var>, <var>e</var>, <var>f</var>)</code></dfn> method, when invoked, must
  run these steps:</p>

  <ol><li><p>If any of the arguments are infinite or NaN, then return.<li><p>Reset the <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-17>current transformation matrix</a> to the identity matrix.<li><p>Invoke the <code><a href=#dom-context-2d-transform id=transformations:dom-context-2d-transform>transform</a>(<var>a</var>, <var>b</var>, <var>c</var>,
   <var>d</var>, <var>e</var>, <var>f</var>)</code> method with the same arguments.</ol>

  <p>The <dfn id=dom-context-2d-settransform-matrix><code>setTransform(<var>transform</var>)</code></dfn>
  method, when invoked, must run these steps:</p>

  <ol><li><p>Let <var>matrix</var> be the result of <a href=https://drafts.fxtf.org/geometry/#create-a-dommatrix-from-the-2d-dictionary id=transformations:create-a-dommatrix-from-a-2d-dictionary data-x-internal=create-a-dommatrix-from-a-2d-dictionary>creating a <code>DOMMatrix</code> from the 2D dictionary</a>
   <var>transform</var>.</p>

   <li><p>If one or more of <var>matrix</var>'s <a id=transformations:m11-element href=https://drafts.fxtf.org/geometry/#matrix-m11-element data-x-internal=m11-element>m11 element</a>, <a id=transformations:m12-element href=https://drafts.fxtf.org/geometry/#matrix-m12-element data-x-internal=m12-element>m12 element</a>,
   <a id=transformations:m21-element href=https://drafts.fxtf.org/geometry/#matrix-m21-element data-x-internal=m21-element>m21 element</a>, <a id=transformations:m22-element href=https://drafts.fxtf.org/geometry/#matrix-m22-element data-x-internal=m22-element>m22 element</a>, <a id=transformations:m41-element href=https://drafts.fxtf.org/geometry/#matrix-m41-element data-x-internal=m41-element>m41 element</a>, or <a id=transformations:m42-element href=https://drafts.fxtf.org/geometry/#matrix-m42-element data-x-internal=m42-element>m42
   element</a> are infinite or NaN, then return.<li><p>Reset the <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-18>current transformation matrix</a> to <var>matrix</var>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/resetTransform title="The CanvasRenderingContext2D.resetTransform() method of the Canvas 2D API resets the current transform to the identity matrix.">CanvasRenderingContext2D/resetTransform</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>36+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>31+</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>36+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><p>The <dfn id=dom-context-2d-resettransform><code>resetTransform()</code></dfn> method,
  when invoked, must reset the <a href=#current-transformation-matrix id=transformations:current-transformation-matrix-19>current transformation matrix</a> to the identity
  matrix.</p>

  

  <div class=note>
   <p>Given a matrix of the form created by the <code id=transformations:dom-context-2d-transform-2><a href=#dom-context-2d-transform>transform()</a></code> and <code id=transformations:dom-context-2d-settransform><a href=#dom-context-2d-settransform>setTransform()</a></code> methods, i.e.,</p>

   <table class=matrix><tr><td><var>a</var><td><var>c</var><td><var>e</var><tr><td><var>b</var><td><var>d</var><td><var>f</var><tr><td>0<td>0<td>1</table>

   <p>the resulting transformed coordinates after transform matrix multiplication will be</p>

   <p class=equations>
    <var>x</var><sub>new</sub> = <var>a</var> <var>x</var> + <var>c</var> <var>y</var> + <var>e</var><br>
    <var>y</var><sub>new</sub> = <var>b</var> <var>x</var> + <var>d</var> <var>y</var> + <var>f</var>
   </p>
  </div>



  <h6 id=image-sources-for-2d-rendering-contexts><span class=secno>4.12.5.1.8</span> Image sources for 2D rendering contexts<a href=#image-sources-for-2d-rendering-contexts class=self-link></a></h6>

  <p>Some methods on the <code id=image-sources-for-2d-rendering-contexts:canvasdrawimage><a href=#canvasdrawimage>CanvasDrawImage</a></code> and <code id=image-sources-for-2d-rendering-contexts:canvasfillstrokestyles><a href=#canvasfillstrokestyles>CanvasFillStrokeStyles</a></code>
  interfaces take the union type <code id=image-sources-for-2d-rendering-contexts:canvasimagesource><a href=#canvasimagesource>CanvasImageSource</a></code> as an argument.</p>

  <p>This union type allows objects implementing any of the following interfaces to be used as image
  sources:</p>

  <ul><li><code id=image-sources-for-2d-rendering-contexts:htmlorsvgimageelement><a href=#htmlorsvgimageelement>HTMLOrSVGImageElement</a></code> (<code id=image-sources-for-2d-rendering-contexts:the-img-element><a href=embedded-content.html#the-img-element>img</a></code> or <a id=image-sources-for-2d-rendering-contexts:svg-image href=https://svgwg.org/svg2-draft/embedded.html#ImageElement data-x-internal=svg-image>SVG <code>image</code></a>
   elements)<li><code id=image-sources-for-2d-rendering-contexts:htmlvideoelement><a href=media.html#htmlvideoelement>HTMLVideoElement</a></code> (<code id=image-sources-for-2d-rendering-contexts:the-video-element><a href=media.html#the-video-element>video</a></code> elements)<li><code id=image-sources-for-2d-rendering-contexts:htmlcanvaselement><a href=#htmlcanvaselement>HTMLCanvasElement</a></code> (<code id=image-sources-for-2d-rendering-contexts:the-canvas-element><a href=#the-canvas-element>canvas</a></code> elements)<li><code id=image-sources-for-2d-rendering-contexts:imagebitmap><a href=imagebitmap-and-animations.html#imagebitmap>ImageBitmap</a></code></ul>

  <p class=note>Although not formally specified as such, <a id=image-sources-for-2d-rendering-contexts:svg-image-2 href=https://svgwg.org/svg2-draft/embedded.html#ImageElement data-x-internal=svg-image>SVG <code>image</code></a>
  elements are expected to be implemented nearly identical to <code id=image-sources-for-2d-rendering-contexts:the-img-element-2><a href=embedded-content.html#the-img-element>img</a></code> elements. That is,
  <a id=image-sources-for-2d-rendering-contexts:svg-image-3 href=https://svgwg.org/svg2-draft/embedded.html#ImageElement data-x-internal=svg-image>SVG <code>image</code></a> elements share the fundamental concepts and features of
  <code id=image-sources-for-2d-rendering-contexts:the-img-element-3><a href=embedded-content.html#the-img-element>img</a></code> elements.</p>

  <p class=note>The <code id=image-sources-for-2d-rendering-contexts:imagebitmap-2><a href=imagebitmap-and-animations.html#imagebitmap>ImageBitmap</a></code> interface can be created from a number of other
  image-representing types, including <code id=image-sources-for-2d-rendering-contexts:imagedata><a href=#imagedata>ImageData</a></code>.</p>

  <p>To <dfn id=check-the-usability-of-the-image-argument>check the usability of the <var>image</var> argument</dfn>, where <var>image</var>
  is a <code id=image-sources-for-2d-rendering-contexts:canvasimagesource-2><a href=#canvasimagesource>CanvasImageSource</a></code> object, run these steps:</p>

  <ol><li>
    <p>Switch on <var>image</var>:</p>

    <dl class=switch><dt><code id=image-sources-for-2d-rendering-contexts:htmlorsvgimageelement-2><a href=#htmlorsvgimageelement>HTMLOrSVGImageElement</a></code><dd>
      <p>If <var>image</var>'s <a id=image-sources-for-2d-rendering-contexts:current-request href=images.html#current-request>current request</a>'s <a href=images.html#img-req-state id=image-sources-for-2d-rendering-contexts:img-req-state>state</a> is <a href=images.html#img-error id=image-sources-for-2d-rendering-contexts:img-error>broken</a>, then
      throw an <a id=image-sources-for-2d-rendering-contexts:invalidstateerror href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=image-sources-for-2d-rendering-contexts:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.</p>

      <p>If <var>image</var> is not <a href=images.html#img-good id=image-sources-for-2d-rendering-contexts:img-good>fully decodable</a>,
      then return <i>bad</i>.</p>

      <p>If <var>image</var> has an <a id=image-sources-for-2d-rendering-contexts:intrinsic-width href=https://drafts.csswg.org/css-images/#intrinsic-width data-x-internal=intrinsic-width>intrinsic width</a> or <a id=image-sources-for-2d-rendering-contexts:intrinsic-height href=https://drafts.csswg.org/css-images/#intrinsic-height data-x-internal=intrinsic-height>intrinsic height</a>
      (or both) equal to zero, then return <i>bad</i>.</p> 
     <dt><code id=image-sources-for-2d-rendering-contexts:htmlvideoelement-2><a href=media.html#htmlvideoelement>HTMLVideoElement</a></code><dd><p>If <var>image</var>'s <code id=image-sources-for-2d-rendering-contexts:dom-media-readystate><a href=media.html#dom-media-readystate>readyState</a></code>
     attribute is either <code id=image-sources-for-2d-rendering-contexts:dom-media-have_nothing><a href=media.html#dom-media-have_nothing>HAVE_NOTHING</a></code> or <code id=image-sources-for-2d-rendering-contexts:dom-media-have_metadata><a href=media.html#dom-media-have_metadata>HAVE_METADATA</a></code>, then return <i>bad</i>.<dt><code id=image-sources-for-2d-rendering-contexts:htmlcanvaselement-2><a href=#htmlcanvaselement>HTMLCanvasElement</a></code><dt><code id=image-sources-for-2d-rendering-contexts:offscreencanvas><a href=#offscreencanvas>OffscreenCanvas</a></code><dd><p>If <var>image</var> has either a horizontal dimension or a vertical dimension
     equal to zero, then throw an <a id=image-sources-for-2d-rendering-contexts:invalidstateerror-2 href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a>
     <code id=image-sources-for-2d-rendering-contexts:domexception-2><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<dt><code id=image-sources-for-2d-rendering-contexts:imagebitmap-3><a href=imagebitmap-and-animations.html#imagebitmap>ImageBitmap</a></code><dd><p>If <var>image</var>'s <a id=image-sources-for-2d-rendering-contexts:detached href=structured-data.html#detached>[[Detached]]</a> internal slot value
     is set to true, then throw an <a id=image-sources-for-2d-rendering-contexts:invalidstateerror-3 href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a>
     <code id=image-sources-for-2d-rendering-contexts:domexception-3><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.</dl>
   <li>
    <p>Return <i>good</i>.</p>
   </ol>

  <p>When a <code id=image-sources-for-2d-rendering-contexts:canvasimagesource-3><a href=#canvasimagesource>CanvasImageSource</a></code> object represents an <code id=image-sources-for-2d-rendering-contexts:htmlorsvgimageelement-3><a href=#htmlorsvgimageelement>HTMLOrSVGImageElement</a></code>,
  the element's image must be used as the source image.</p>

  <p>Specifically, when a <code id=image-sources-for-2d-rendering-contexts:canvasimagesource-4><a href=#canvasimagesource>CanvasImageSource</a></code> object represents an animated image in an
  <code id=image-sources-for-2d-rendering-contexts:htmlorsvgimageelement-4><a href=#htmlorsvgimageelement>HTMLOrSVGImageElement</a></code>, the user agent must use the default image of the animation
  (the one that the format defines is to be used when animation is not supported or is disabled),
  or, if there is no such image, the first frame of the animation, when rendering the image for
  <code id=image-sources-for-2d-rendering-contexts:canvasrenderingcontext2d><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code> APIs.</p>

  <p>When a <code id=image-sources-for-2d-rendering-contexts:canvasimagesource-5><a href=#canvasimagesource>CanvasImageSource</a></code> object represents an <code id=image-sources-for-2d-rendering-contexts:htmlvideoelement-3><a href=media.html#htmlvideoelement>HTMLVideoElement</a></code>, then
  the frame at the <a id=image-sources-for-2d-rendering-contexts:current-playback-position href=media.html#current-playback-position>current playback position</a> when the method with the argument is
  invoked must be used as the source image when rendering the image for
  <code id=image-sources-for-2d-rendering-contexts:canvasrenderingcontext2d-2><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code> APIs, and the source image's dimensions must be the <a href=media.html#concept-video-intrinsic-width id=image-sources-for-2d-rendering-contexts:concept-video-intrinsic-width>intrinsic width</a> and <a href=media.html#concept-video-intrinsic-height id=image-sources-for-2d-rendering-contexts:concept-video-intrinsic-height>intrinsic height</a> of the <a id=image-sources-for-2d-rendering-contexts:media-resource href=media.html#media-resource>media resource</a>
  (i.e. after any aspect-ratio correction has been applied).</p>

  <p>When a <code id=image-sources-for-2d-rendering-contexts:canvasimagesource-6><a href=#canvasimagesource>CanvasImageSource</a></code> object represents an <code id=image-sources-for-2d-rendering-contexts:htmlcanvaselement-3><a href=#htmlcanvaselement>HTMLCanvasElement</a></code>, the
  element's bitmap must be used as the source image.</p>

  <p>When a <code id=image-sources-for-2d-rendering-contexts:canvasimagesource-7><a href=#canvasimagesource>CanvasImageSource</a></code> object represents an element that is <a id=image-sources-for-2d-rendering-contexts:being-rendered href=rendering.html#being-rendered>being
  rendered</a> and that element has been resized, the original image data of the source image
  must be used, not the image as it is rendered (e.g. <code id=image-sources-for-2d-rendering-contexts:attr-dim-width><a href=embedded-content-other.html#attr-dim-width>width</a></code> and
  <code id=image-sources-for-2d-rendering-contexts:attr-dim-height><a href=embedded-content-other.html#attr-dim-height>height</a></code> attributes on the source element have no effect on how
  the object is interpreted when rendering the image for <code id=image-sources-for-2d-rendering-contexts:canvasrenderingcontext2d-3><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code>
  APIs).</p>

  <p>When a <code id=image-sources-for-2d-rendering-contexts:canvasimagesource-8><a href=#canvasimagesource>CanvasImageSource</a></code> object represents an <code id=image-sources-for-2d-rendering-contexts:imagebitmap-4><a href=imagebitmap-and-animations.html#imagebitmap>ImageBitmap</a></code>, the
  object's bitmap image data must be used as the source image.</p>

  <p>An object <var>image</var> <dfn id=the-image-argument-is-not-origin-clean>is not
  origin-clean</dfn> if, switching on <var>image</var>:</p>

  <dl class=switch><dt><code id=image-sources-for-2d-rendering-contexts:htmlorsvgimageelement-5><a href=#htmlorsvgimageelement>HTMLOrSVGImageElement</a></code>
   <dt><code id=image-sources-for-2d-rendering-contexts:htmlvideoelement-4><a href=media.html#htmlvideoelement>HTMLVideoElement</a></code>
   <dd><p><var>image</var>'s <a id=image-sources-for-2d-rendering-contexts:concept-origin href=origin.html#concept-origin>origin</a> is not <a id=image-sources-for-2d-rendering-contexts:same-origin href=origin.html#same-origin>same origin</a> with <a id=image-sources-for-2d-rendering-contexts:entry-settings-object href=webappapis.html#entry-settings-object>entry
   settings object</a>'s <a href=webappapis.html#concept-settings-object-origin id=image-sources-for-2d-rendering-contexts:concept-settings-object-origin>origin</a>.<dt><code id=image-sources-for-2d-rendering-contexts:htmlcanvaselement-4><a href=#htmlcanvaselement>HTMLCanvasElement</a></code>
   <dt><code id=image-sources-for-2d-rendering-contexts:imagebitmap-5><a href=imagebitmap-and-animations.html#imagebitmap>ImageBitMap</a></code>
   <dd><p><var>image</var>'s bitmap's <a href=#concept-canvas-origin-clean id=image-sources-for-2d-rendering-contexts:concept-canvas-origin-clean>origin-clean</a>
   flag is false.</dl>



  <h6 id=fill-and-stroke-styles><span class=secno>4.12.5.1.9</span> Fill and stroke styles<a href=#fill-and-stroke-styles class=self-link></a></h6>

  <dl class=domintro><dt><var>context</var> . <code id=dom-context-2d-fillstyle-dev><a href=#dom-context-2d-fillstyle>fillStyle</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current style used for filling shapes.</p>

    <p>Can be set, to change the fill style.</p>

    <p>The style can be either a string containing a CSS color, or a <code id=fill-and-stroke-styles:canvasgradient><a href=#canvasgradient>CanvasGradient</a></code> or
    <code id=fill-and-stroke-styles:canvaspattern><a href=#canvaspattern>CanvasPattern</a></code> object. Invalid values are ignored.</p>
   <dt><var>context</var> . <code id=dom-context-2d-strokestyle-dev><a href=#dom-context-2d-strokestyle>strokeStyle</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current style used for stroking shapes.</p>

    <p>Can be set, to change the stroke style.</p>

    <p>The style can be either a string containing a CSS color, or a <code id=fill-and-stroke-styles:canvasgradient-2><a href=#canvasgradient>CanvasGradient</a></code> or
    <code id=fill-and-stroke-styles:canvaspattern-2><a href=#canvaspattern>CanvasPattern</a></code> object. Invalid values are ignored.</p>
   </dl>

  

  

  <p>Objects that implement the <code id=fill-and-stroke-styles:canvasfillstrokestyles><a href=#canvasfillstrokestyles>CanvasFillStrokeStyles</a></code> interface have attributes and
  methods (defined in this section) that control how shapes are treated by the object.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/fillStyle title="The CanvasRenderingContext2D.fillStyle property of the Canvas 2D API specifies the color, gradient, or pattern to use inside shapes. The default style is #000 (black).">CanvasRenderingContext2D/fillStyle</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/strokeStyle title="The CanvasRenderingContext2D.strokeStyle property of the Canvas 2D API specifies the color, gradient, or pattern to use for the strokes (outlines) around shapes. The default is #000 (black).">CanvasRenderingContext2D/strokeStyle</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-fillstyle><code>fillStyle</code></dfn> attribute represents the
  color or style to use inside shapes, and the <dfn id=dom-context-2d-strokestyle><code>strokeStyle</code></dfn> attribute represents the color
  or style to use for the lines around the shapes.</p>

  <p>Both attributes can be either strings, <code id=fill-and-stroke-styles:canvasgradient-3><a href=#canvasgradient>CanvasGradient</a></code>s, or
  <code id=fill-and-stroke-styles:canvaspattern-3><a href=#canvaspattern>CanvasPattern</a></code>s. On setting, strings must be <a href=infrastructure.html#parsed-as-a-css-color-value id=fill-and-stroke-styles:parsed-as-a-css-color-value>parsed</a> with this <code id=fill-and-stroke-styles:the-canvas-element><a href=#the-canvas-element>canvas</a></code> element and the color assigned, and
  <code id=fill-and-stroke-styles:canvasgradient-4><a href=#canvasgradient>CanvasGradient</a></code> and <code id=fill-and-stroke-styles:canvaspattern-4><a href=#canvaspattern>CanvasPattern</a></code> objects must be assigned themselves. If
  parsing the value results in failure, then it must be ignored, and the attribute must retain its
  previous value. If the new value is a <code id=fill-and-stroke-styles:canvaspattern-5><a href=#canvaspattern>CanvasPattern</a></code> object that is marked as <a href=#concept-canvas-pattern-not-origin-clean id=fill-and-stroke-styles:concept-canvas-pattern-not-origin-clean>not origin-clean</a>, then the
  <code id=fill-and-stroke-styles:canvasrenderingcontext2d><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code>'s <a href=#concept-canvas-origin-clean id=fill-and-stroke-styles:concept-canvas-origin-clean>origin-clean</a> flag must be set to false.</p>

  <p>When set to a <code id=fill-and-stroke-styles:canvaspattern-6><a href=#canvaspattern>CanvasPattern</a></code> or <code id=fill-and-stroke-styles:canvasgradient-5><a href=#canvasgradient>CanvasGradient</a></code> object, the assignment
  is <a id=fill-and-stroke-styles:live href=infrastructure.html#live>live</a>, meaning that changes made to the object after the assignment do affect
  subsequent stroking or filling of shapes.</p>

  <p>On getting, if the value is a color, then the <a href=#serialisation-of-a-color id=fill-and-stroke-styles:serialisation-of-a-color>serialization of the color</a> must be returned. Otherwise, if it is not a color but a
  <code id=fill-and-stroke-styles:canvasgradient-6><a href=#canvasgradient>CanvasGradient</a></code> or <code id=fill-and-stroke-styles:canvaspattern-7><a href=#canvaspattern>CanvasPattern</a></code>, then the respective object must be
  returned. (Such objects are opaque and therefore only useful for assigning to other attributes or
  for comparison to other gradients or patterns.)</p>

  <p>The <dfn id=serialisation-of-a-color>serialization of a color</dfn> for a color
  value is a string, computed as follows: if it has alpha equal to 1.0, then the string is a
  lowercase six-digit hex value, prefixed with a "#" character (U+0023 NUMBER SIGN), with the first
  two digits representing the red component, the next two digits representing the green component,
  and the last two digits representing the blue component, the digits being <a href=https://infra.spec.whatwg.org/#ascii-lower-hex-digit id=fill-and-stroke-styles:lowercase-ascii-hex-digits data-x-internal=lowercase-ascii-hex-digits>ASCII lower hex digits</a>. Otherwise, the color value has alpha less than
  1.0, and the string is the color value in the CSS <code>rgba()</code>
  functional-notation format: the literal string "<code>rgba</code>" (U+0072 U+0067 U+0062
  U+0061) followed by a U+0028 LEFT PARENTHESIS, a base-ten integer in the range 0-255 representing
  the red component (using <a id=fill-and-stroke-styles:ascii-digits href=https://infra.spec.whatwg.org/#ascii-digit data-x-internal=ascii-digits>ASCII digits</a> in the shortest form possible), a literal
  U+002C COMMA and U+0020 SPACE, an integer for the green component, a comma and a space, an integer
  for the blue component, another comma and space, a U+0030 DIGIT ZERO, if the alpha value is
  greater than zero then a U+002E FULL STOP (representing the decimal point), if the alpha value is
  greater than zero then one or more <a id=fill-and-stroke-styles:ascii-digits-2 href=https://infra.spec.whatwg.org/#ascii-digit data-x-internal=ascii-digits>ASCII digits</a> representing the fractional part of
  the alpha, and finally a U+0029
  RIGHT PARENTHESIS. User agents must express the fractional part of the alpha value, if any, with
  the level of precision necessary for the alpha value, when reparsed, to be interpreted as the same
  alpha value.</p>
  

  <p>When the context is created, the <code id=fill-and-stroke-styles:dom-context-2d-fillstyle><a href=#dom-context-2d-fillstyle>fillStyle</a></code> and <code id=fill-and-stroke-styles:dom-context-2d-strokestyle><a href=#dom-context-2d-strokestyle>strokeStyle</a></code> attributes
  must initially have the string value <code>#000000</code>.</p>

  <p>When the value is a color, it must not be affected by the transformation matrix when used to
  draw on bitmaps.</p> 

  

  <hr>

  <p>There are two types of gradients, linear gradients and radial gradients, both represented by
  objects implementing the opaque <code id=fill-and-stroke-styles:canvasgradient-7><a href=#canvasgradient>CanvasGradient</a></code> interface.</p>

  <p id=interpolation>Once a gradient has been created (see below), stops are placed along it to
  define how the colors are distributed along the gradient. The color of the
  gradient at each stop is the color specified for that stop. Between each such stop, the colors and
  the alpha component must be linearly interpolated over the RGBA space without premultiplying the
  alpha value to find the color to use at that offset. Before the first stop, the color must be the
  color of the first stop. After the last stop, the color must be the color of the last stop. When
  there are no stops, the gradient is <a id=fill-and-stroke-styles:transparent-black href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a>.</p>

  <dl class=domintro><dt><var>gradient</var> . <code id=dom-canvasgradient-addcolorstop-dev><a href=#dom-canvasgradient-addcolorstop>addColorStop</a></code>(<var>offset</var>, <var>color</var>)<dd>
    <p>Adds a color stop with the given color to the gradient at the given offset. 0.0 is the offset
    at one end of the gradient, 1.0 is the offset at the other end.</p>

    <p>Throws an <a id=fill-and-stroke-styles:indexsizeerror href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a> <code id=fill-and-stroke-styles:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code> if the offset
    is out of range. Throws a <a id=fill-and-stroke-styles:syntaxerror href=https://heycam.github.io/webidl/#syntaxerror data-x-internal=syntaxerror>"<code>SyntaxError</code>"</a> <code id=fill-and-stroke-styles:domexception-2><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code> if
    the color cannot be parsed.</p>
   <dt><var>gradient</var> = <var>context</var> . <code id=dom-context-2d-createlineargradient-dev><a href=#dom-context-2d-createlineargradient>createLinearGradient</a></code>(<var>x0</var>, <var>y0</var>, <var>x1</var>, <var>y1</var>)<dd>
    <p>Returns a <code id=fill-and-stroke-styles:canvasgradient-8><a href=#canvasgradient>CanvasGradient</a></code> object that represents a
    linear gradient that paints along the line given by the
    coordinates represented by the arguments.</p>
   <dt><var>gradient</var> = <var>context</var> . <code id=dom-context-2d-createradialgradient-dev><a href=#dom-context-2d-createradialgradient>createRadialGradient</a></code>(<var>x0</var>, <var>y0</var>, <var>r0</var>, <var>x1</var>, <var>y1</var>, <var>r1</var>)<dd>
    <p>Returns a <code id=fill-and-stroke-styles:canvasgradient-9><a href=#canvasgradient>CanvasGradient</a></code> object that represents a
    radial gradient that paints along the cone given by the circles
    represented by the arguments.</p>

    <p>If either of the radii are negative, throws an
    <a id=fill-and-stroke-styles:indexsizeerror-2 href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a> <code id=fill-and-stroke-styles:domexception-3><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code> exception.</p>
   </dl>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasGradient/addColorStop title="The CanvasGradient.addColorStop() method adds a new color stop, defined by an offset and a color, to a given canvas gradient.">CanvasGradient/addColorStop</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.6+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-canvasgradient-addcolorstop><code>addColorStop(<var>offset</var>,
  <var>color</var>)</code></dfn> method on the <code id=fill-and-stroke-styles:canvasgradient-10><a href=#canvasgradient>CanvasGradient</a></code>, when invoked, must run
  these steps:</p>

  <ol><li><p>If the <var>offset</var> is less than 0 or greater than 1, then throw an
   <a id=fill-and-stroke-styles:indexsizeerror-3 href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a> <code id=fill-and-stroke-styles:domexception-4><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li>
    <p>Let <var>parsed color</var> be the result of <a href=infrastructure.html#parsed-as-a-css-color-value id=fill-and-stroke-styles:parsed-as-a-css-color-value-2>parsing</a> <var>color</var>.</p>

    <p class=note>No element is passed to the parser because <code id=fill-and-stroke-styles:canvasgradient-11><a href=#canvasgradient>CanvasGradient</a></code> objects
    are <code id=fill-and-stroke-styles:the-canvas-element-2><a href=#the-canvas-element>canvas</a></code>-neutral — a <code id=fill-and-stroke-styles:canvasgradient-12><a href=#canvasgradient>CanvasGradient</a></code> object created by one
    <code id=fill-and-stroke-styles:the-canvas-element-3><a href=#the-canvas-element>canvas</a></code> can be used by another, and there is therefore no way to know which is the
    "element in question" at the time that the color is specified.</p>
   <li><p>If <var>parsed color</var> is failure, throw a <a id=fill-and-stroke-styles:syntaxerror-2 href=https://heycam.github.io/webidl/#syntaxerror data-x-internal=syntaxerror>"<code>SyntaxError</code>"</a>
   <code id=fill-and-stroke-styles:domexception-5><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li>
    <p>Place a new stop on the gradient, at offset <var>offset</var> relative to the whole gradient,
    and with the color <var>parsed color</var>.</p>

    <p>If multiple stops are added at the same offset on a gradient, then they must be placed in the
    order added, with the first one closest to the start of the gradient, and each subsequent one
    infinitesimally further along towards the end point (in effect causing all but the first and
    last stop added at each point to be ignored).</p>
   </ol>


  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/createLinearGradient title="The CanvasRenderingContext2D.createLinearGradient() method of the Canvas 2D API creates a gradient along the line connecting two given coordinates.">CanvasRenderingContext2D/createLinearGradient</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-createlineargradient><code>createLinearGradient(<var>x0</var>,
  <var>y0</var>, <var>x1</var>, <var>y1</var>)</code></dfn> method takes four arguments that
  represent the start point (<var>x0</var>, <var>y0</var>) and end point (<var>x1</var>,
  <var>y1</var>) of the gradient. The method, when invoked, must return a linear
  <code id=fill-and-stroke-styles:canvasgradient-13><a href=#canvasgradient>CanvasGradient</a></code> initialized with the specified line.</p>

  <p>Linear gradients must be rendered such that all points on a line perpendicular to the line that
  crosses the start and end points have the color at the point where those two lines cross (with the
  colors coming from the <a href=#interpolation>interpolation and extrapolation</a> described
  above). The points in the linear gradient must be transformed as described by the <a href=#transformations id=fill-and-stroke-styles:transformations>current transformation matrix</a> when rendering.</p>

  <p>If <var>x0</var> = <var>x1</var> and <span><var>y0</var> = <var>y1</var></span>, then the linear
  gradient must paint nothing.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/createRadialGradient title="The CanvasRenderingContext2D.createRadialGradient() method of the Canvas 2D API creates a radial gradient using the size and coordinates of two circles.">CanvasRenderingContext2D/createRadialGradient</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-createradialgradient><code>createRadialGradient(<var>x0</var>,
  <var>y0</var>, <var>r0</var>, <var>x1</var>, <var>y1</var>, <var>r1</var>)</code></dfn> method
  takes six arguments, the first three representing the start circle with origin (<var>x0</var>,
  <var>y0</var>) and radius <var>r0</var>, and the last three representing the end circle with
  origin (<var>x1</var>, <var>y1</var>) and radius <var>r1</var>. The values are in coordinate space
  units. If either of <var>r0</var> or <var>r1</var> are negative, then an
  <a id=fill-and-stroke-styles:indexsizeerror-4 href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a> <code id=fill-and-stroke-styles:domexception-6><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code> must be thrown. Otherwise,
  the method, when invoked, must return a radial <code id=fill-and-stroke-styles:canvasgradient-14><a href=#canvasgradient>CanvasGradient</a></code> initialized with the
  two specified circles.</p>

  <p>Radial gradients must be rendered by following these steps:</p>

  <ol><li><p>If <var>x<sub>0</sub></var> = <var>x<sub>1</sub></var> and <var>y<sub>0</sub></var> = <var>y<sub>1</sub></var> and <var>r<sub>0</sub></var> = <var>r<sub>1</sub></var>, then the radial gradient must
   paint nothing. Return.<li>
    <p>Let <span>x(<var>ω</var>) = (<var>x<sub>1</sub></var>-<var>x<sub>0</sub></var>)<var>ω</var> + <var>x<sub>0</sub></var></span></p>

    <p>Let <span>y(<var>ω</var>) = (<var>y<sub>1</sub></var>-<var>y<sub>0</sub></var>)<var>ω</var> + <var>y<sub>0</sub></var></span></p>

    <p>Let <span>r(<var>ω</var>) = (<var>r<sub>1</sub></var>-<var>r<sub>0</sub></var>)<var>ω</var> + <var>r<sub>0</sub></var></span></p>

    <p>Let the color at <var>ω</var> be the color at that position on the gradient
    (with the colors coming from the <a href=#interpolation>interpolation and extrapolation</a>
    described above).</p>
   <li><p>For all values of <var>ω</var> where <span>r(<var>ω</var>) > 0</span>, starting with the value of <var>ω</var> nearest to positive infinity and ending with the value of <var>ω</var> nearest to negative infinity, draw the circumference of the circle with
   radius <span>r(<var>ω</var>)</span> at position (<span>x(<var>ω</var>)</span>, <span>y(<var>ω</var>)</span>), with the
   color at <var>ω</var>, but only painting on the parts of the bitmap that have not
   yet been painted on by earlier circles in this step for this rendering of the gradient.</ol>

  <p class=note>This effectively creates a cone, touched by the two circles defined in the
  creation of the gradient, with the part of the cone before the start circle (0.0) using the color
  of the first offset, the part of the cone after the end circle (1.0) using the color of the last
  offset, and areas outside the cone untouched by the gradient (<a id=fill-and-stroke-styles:transparent-black-2 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a>).</p>

  <p>The resulting radial gradient must then be transformed as described by the <a href=#transformations id=fill-and-stroke-styles:transformations-2>current transformation matrix</a> when rendering.</p>

  <p>Gradients must be painted only where the relevant stroking or filling effects requires that
  they be drawn.</p>

  

  <hr>

  <p>Patterns are represented by objects implementing the opaque <code id=fill-and-stroke-styles:canvaspattern-8><a href=#canvaspattern>CanvasPattern</a></code>
  interface.</p>

  <dl class=domintro><dt><var>pattern</var> = <var>context</var> . <code id=dom-context-2d-createpattern-dev><a href=#dom-context-2d-createpattern>createPattern</a></code>(<var>image</var>, <var>repetition</var>)<dd>
    <p>Returns a <code id=fill-and-stroke-styles:canvaspattern-9><a href=#canvaspattern>CanvasPattern</a></code> object that uses the given image and repeats in the
    direction(s) given by the <var>repetition</var> argument.</p>

    <p>The allowed values for <var>repetition</var> are <code>repeat</code> (both
    directions), <code>repeat-x</code> (horizontal only), <code>repeat-y</code>
    (vertical only), and <code>no-repeat</code> (neither). If the <var>repetition</var> argument is empty, the value <code>repeat</code> is used.</p>

    <p>If the image isn't yet fully decoded, then nothing is drawn. If the image is a canvas with no
    data, throws an <a id=fill-and-stroke-styles:invalidstateerror href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=fill-and-stroke-styles:domexception-7><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.</p>
   <dt><var>pattern</var> . <code id=dom-canvaspattern-settransform-dev><a href=#dom-canvaspattern-settransform>setTransform</a></code>(<var>transform</var>)<dd>
    <p>Sets the transformation matrix that will be used when rendering the pattern during a fill or
    stroke painting operation.</p>
   </dl>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/createPattern title="The CanvasRenderingContext2D.createPattern() method of the Canvas 2D API creates a pattern using the specified image and repetition. This method returns a CanvasPattern.">CanvasRenderingContext2D/createPattern</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-createpattern><code>createPattern(<var>image</var>,
  <var>repetition</var>)</code></dfn> method, when invoked, must run these steps:</p>

  <ol><li><p>Let <var>usability</var> be the result of <a href=#check-the-usability-of-the-image-argument id=fill-and-stroke-styles:check-the-usability-of-the-image-argument>checking the usability of</a> <var>image</var>.<li><p>If <var>result</var> is <i>bad</i>, then return null.<li><p>Assert: <var>result</var> is <i>good</i>.<li><p>If <var>repetition</var> is the empty string, then set it to "<code>repeat</code>".</p>

   <li><p>If <var>repetition</var> is not a <a id=fill-and-stroke-styles:case-sensitive href=infrastructure.html#case-sensitive>case-sensitive</a> match for one of
   "<code>repeat</code>", "<code>repeat-x</code>", "<code>repeat-y</code>", or "<code>no-repeat</code>", then throw a
   <a id=fill-and-stroke-styles:syntaxerror-3 href=https://heycam.github.io/webidl/#syntaxerror data-x-internal=syntaxerror>"<code>SyntaxError</code>"</a> <code id=fill-and-stroke-styles:domexception-8><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>pattern</var> be a new <code id=fill-and-stroke-styles:canvaspattern-10><a href=#canvaspattern>CanvasPattern</a></code> object with the image
   <var>image</var> and the repetition behavior given by <var>repetition</var>.<li><p>If <var>image</var> <a href=#the-image-argument-is-not-origin-clean id=fill-and-stroke-styles:the-image-argument-is-not-origin-clean>is not origin-clean</a>, then mark <var>pattern</var> as <dfn id=concept-canvas-pattern-not-origin-clean>not origin-clean</dfn>.<li><p>Return <var>pattern</var>.</ol>

  <p>Modifying the <var>image</var> used when creating a <code id=fill-and-stroke-styles:canvaspattern-11><a href=#canvaspattern>CanvasPattern</a></code> object
  after calling the <code id=fill-and-stroke-styles:dom-context-2d-createpattern><a href=#dom-context-2d-createpattern>createPattern()</a></code> method must
  not affect the pattern(s) rendered by the <code id=fill-and-stroke-styles:canvaspattern-12><a href=#canvaspattern>CanvasPattern</a></code> object.</p>

  <p>Patterns have a transformation matrix, which controls how the pattern is used when it is
  painted. Initially, a pattern's transformation matrix must be the identity matrix.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasPattern/setTransform title="The CanvasPattern.setTransform() method uses an SVGMatrix object as the pattern's transformation matrix and invokes it on the pattern.">CanvasPattern/setTransform</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>33+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>68+</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>33+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>11+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>68+</span></span><span class="webview_android yes"><span>WebView Android</span><span>68+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>10.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside><p>The <dfn id=dom-canvaspattern-settransform><code>setTransform(<var>transform</var>)</code></dfn> method,
  when invoked, must run these steps:</p>

  <ol><li><p>Let <var>matrix</var> be the result of <a href=https://drafts.fxtf.org/geometry/#create-a-dommatrix-from-the-2d-dictionary id=fill-and-stroke-styles:create-a-dommatrix-from-a-2d-dictionary data-x-internal=create-a-dommatrix-from-a-2d-dictionary>creating a <code>DOMMatrix</code> from the 2D dictionary</a>
   <var>transform</var>.</p>

   <li><p>If one or more of <var>matrix</var>'s <a id=fill-and-stroke-styles:m11-element href=https://drafts.fxtf.org/geometry/#matrix-m11-element data-x-internal=m11-element>m11 element</a>, <a id=fill-and-stroke-styles:m12-element href=https://drafts.fxtf.org/geometry/#matrix-m12-element data-x-internal=m12-element>m12 element</a>,
   <a id=fill-and-stroke-styles:m21-element href=https://drafts.fxtf.org/geometry/#matrix-m21-element data-x-internal=m21-element>m21 element</a>, <a id=fill-and-stroke-styles:m22-element href=https://drafts.fxtf.org/geometry/#matrix-m22-element data-x-internal=m22-element>m22 element</a>, <a id=fill-and-stroke-styles:m41-element href=https://drafts.fxtf.org/geometry/#matrix-m41-element data-x-internal=m41-element>m41 element</a>, or <a id=fill-and-stroke-styles:m42-element href=https://drafts.fxtf.org/geometry/#matrix-m42-element data-x-internal=m42-element>m42
   element</a> are infinite or NaN, then return.<li><p>Reset the pattern's transformation matrix to <var>matrix</var>.</ol>

  <p>When a pattern is to be rendered within an area, the user agent must run the following steps to
  determine what is rendered:</p>

  <ol><li><p>Create an infinite <a id=fill-and-stroke-styles:transparent-black-3 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a> bitmap.<li>
    <p>Place a copy of the image on the bitmap, anchored such that its top left corner is at the
    origin of the coordinate space, with one coordinate space unit per <a href=https://drafts.csswg.org/css-values/#px id="fill-and-stroke-styles:'px'" data-x-internal="'px'">CSS
    pixel</a> of the image, then place repeated copies of this image horizontally to the left and
    right, if the repetition behavior is "<code>repeat-x</code>", or vertically up and
    down, if the repetition behavior is "<code>repeat-y</code>", or in all four
    directions all over the bitmap, if the repetition behavior is "<code>repeat</code>".</p>

    <p>If the original image data is a bitmap image, then the value painted at a point in the area
    of the repetitions is computed by filtering the original image data. When scaling up, if the
    <code id=fill-and-stroke-styles:dom-context-2d-imagesmoothingenabled><a href=#dom-context-2d-imagesmoothingenabled>imageSmoothingEnabled</a></code> attribute is
    set to false, then the image must be rendered using nearest-neighbor interpolation. Otherwise,
    the user agent may use any filtering algorithm (for example bilinear interpolation or
    nearest-neighbor). User agents which support multiple filtering algorithms may use the value of
    the <code id=fill-and-stroke-styles:dom-context-2d-imagesmoothingquality><a href=#dom-context-2d-imagesmoothingquality>imageSmoothingQuality</a></code> attribute
    to guide the choice of filtering algorithm. When such a filtering algorithm requires a pixel
    value from outside the original image data, it must instead use the value from wrapping the
    pixel's coordinates to the original image's dimensions. (That is, the filter uses 'repeat'
    behavior, regardless of the value of the pattern's repetition behavior.)</p> 
   <li><p>Transform the resulting bitmap according to the pattern's transformation matrix.<li><p>Transform the resulting bitmap again, this time according to the <a href=#transformations id=fill-and-stroke-styles:transformations-3>current transformation matrix</a>.<li><p>Replace any part of the image outside the area in which the pattern is to be rendered with
   <a id=fill-and-stroke-styles:transparent-black-4 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a>.<li><p>The resulting bitmap is what is to be rendered, with the same origin and same
   scale.</ol>

  <hr>

  <p>If a radial gradient or repeated pattern is used when the transformation matrix is singular,
  then the resulting style must be <a id=fill-and-stroke-styles:transparent-black-5 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a> (otherwise the gradient or pattern
  would be collapsed to a point or line, leaving the other pixels undefined). Linear gradients and
  solid colors always define all points even with singular transformation matrices.</p>

  




  <h6 id=drawing-rectangles-to-the-bitmap><span class=secno>4.12.5.1.10</span> Drawing rectangles to the bitmap<a href=#drawing-rectangles-to-the-bitmap class=self-link></a></h6>

  <p>Objects that implement the <code id=drawing-rectangles-to-the-bitmap:canvasrect><a href=#canvasrect>CanvasRect</a></code> interface provide the following methods for
  immediately drawing rectangles to the bitmap. The methods each take four arguments; the first two
  give the <var>x</var> and <var>y</var> coordinates of the top left of the rectangle, and the
  second two give the width <var>w</var> and height <var>h</var> of the rectangle, respectively.</p>

  

  <p>The <a href=#transformations id=drawing-rectangles-to-the-bitmap:transformations>current transformation matrix</a> must be
  applied to the following four coordinates, which form the path that must then be closed to get the
  specified rectangle: <span>(<var>x</var>, <var>y</var>)</span>, <span>(<var>x</var>+<var>w</var>, <var>y</var>)</span>, <span>(<var>x</var>+<var>w</var>, <var>y</var>+<var>h</var>)</span>, <span>(<var>x</var>, <var>y</var>+<var>h</var>)</span>.</p>

  <p>Shapes are painted without affecting the <a href=#current-default-path id=drawing-rectangles-to-the-bitmap:current-default-path>current default path</a>, and are subject to
  the <a href=#clipping-region id=drawing-rectangles-to-the-bitmap:clipping-region>clipping region</a>, and, with the exception of <code id=drawing-rectangles-to-the-bitmap:dom-context-2d-clearrect><a href=#dom-context-2d-clearrect>clearRect()</a></code>, also <a href=#shadows id=drawing-rectangles-to-the-bitmap:shadows>shadow
  effects</a>, <a href=#dom-context-2d-globalalpha id=drawing-rectangles-to-the-bitmap:dom-context-2d-globalalpha>global alpha</a>, and <a href=#dom-context-2d-globalcompositeoperation id=drawing-rectangles-to-the-bitmap:dom-context-2d-globalcompositeoperation>global composition operators</a>.</p>

  

  <dl class=domintro><dt><var>context</var> . <code id=dom-context-2d-clearrect-dev><a href=#dom-context-2d-clearrect>clearRect</a></code>(<var>x</var>, <var>y</var>, <var>w</var>, <var>h</var>)<dd>
    <p>Clears all pixels on the bitmap in the given rectangle to <a id=drawing-rectangles-to-the-bitmap:transparent-black href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a>.</p>
   <dt><var>context</var> . <code id=dom-context-2d-fillrect-dev><a href=#dom-context-2d-fillrect>fillRect</a></code>(<var>x</var>, <var>y</var>, <var>w</var>, <var>h</var>)<dd>
    <p>Paints the given rectangle onto the bitmap, using the current fill style.</p>
   <dt><var>context</var> . <code id=dom-context-2d-strokerect-dev><a href=#dom-context-2d-strokerect>strokeRect</a></code>(<var>x</var>, <var>y</var>, <var>w</var>, <var>h</var>)<dd>
    <p>Paints the box that outlines the given rectangle onto the bitmap, using the current stroke
    style.</p>
   </dl>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/clearRect title="The CanvasRenderingContext2D.clearRect() method of the Canvas 2D API erases the pixels in a rectangular area by setting them to transparent black.">CanvasRenderingContext2D/clearRect</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-clearrect><code>clearRect(<var>x</var>, <var>y</var>,
  <var>w</var>, <var>h</var>)</code></dfn> method, when invoked, must run these steps:</p>

  <ol><li><p>If any of the arguments are infinite or NaN, then return.<li><p>Let <var>pixels</var> be the set of pixels in the specified rectangle that also
   intersect the current <a href=#clipping-region id=drawing-rectangles-to-the-bitmap:clipping-region-2>clipping region</a>.<li><p>Clear the pixels in <var>pixels</var> to a <a id=drawing-rectangles-to-the-bitmap:transparent-black-2 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a>, erasing any
   previous image.</ol>

  <p class=note>If either height or width are zero, this method has no effect, since the set of
  pixels would be empty.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/fillRect title="The CanvasRenderingContext2D.fillRect() method of the Canvas 2D API draws a rectangle that is filled according to the current fillStyle.">CanvasRenderingContext2D/fillRect</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>2+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside><p>The <dfn id=dom-context-2d-fillrect><code>fillRect(<var>x</var>, <var>y</var>,
  <var>w</var>, <var>h</var>)</code></dfn> method, when invoked, must must run these steps:</p>

  <ol><li><p>If any of the arguments are infinite or NaN, then return.<li><p>If either <var>w</var> or <var>h</var> are zero, then return.<li><p>Paint the specified rectangular area using the <code id=drawing-rectangles-to-the-bitmap:dom-context-2d-fillstyle><a href=#dom-context-2d-fillstyle>fillStyle</a></code>.</p>
  </ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/strokeRect title="The CanvasRenderingContext2D.strokeRect() method of the Canvas 2D API draws a rectangle that is stroked (outlined) according to the current strokeStyle and other context settings.">CanvasRenderingContext2D/strokeRect</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-strokerect><code>strokeRect(<var>x</var>, <var>y</var>,
  <var>w</var>, <var>h</var>)</code></dfn> method, when invoked, must run these steps:</p>

  <ol><li><p>If any of the arguments are infinite or NaN, then return.<li><p>Take the result of <a href=#trace-a-path id=drawing-rectangles-to-the-bitmap:trace-a-path>tracing the path</a> described below,
   using the <code id=drawing-rectangles-to-the-bitmap:canvaspathdrawingstyles><a href=#canvaspathdrawingstyles>CanvasPathDrawingStyles</a></code> interface's line styles, and fill it with the
   <code id=drawing-rectangles-to-the-bitmap:dom-context-2d-strokestyle><a href=#dom-context-2d-strokestyle>strokeStyle</a></code>.</ol>

  <p>If both <var>w</var> and <var>h</var> are zero, the path has a single subpath
  with just one point (<var>x</var>, <var>y</var>), and no lines, and this method
  thus has no effect (the <a href=#trace-a-path id=drawing-rectangles-to-the-bitmap:trace-a-path-2>trace a path</a> algorithm returns an empty path in that
  case).</p>

  <p>If just one of either <var>w</var> or <var>h</var> is zero, then the path has
  a single subpath consisting of two points, with coordinates (<var>x</var>, <var>y</var>) and (<var>x</var>+<var>w</var>, <var>y</var>+<var>h</var>), in that order, connected by a single straight line.</p>

  <p>Otherwise, the path has a single subpath consisting of four points, with coordinates (<span><var>x</var></span>, <var>y</var>), (<span><var>x</var>+<var>w</var></span>, <var>y</var>), (<var>x</var>+<var>w</var>,
  <var>y</var>+<var>h</var>), and (<var>x</var>, <var>y</var>+<var>h</var>),
  connected to each other in that order by straight lines.</p>

  



  <h6 id=drawing-text-to-the-bitmap><span class=secno>4.12.5.1.11</span> Drawing text to the bitmap<a href=#drawing-text-to-the-bitmap class=self-link></a></h6><div class=status><input onclick=toggleStatus(this) value=⋰ type=button><p class=support><strong>Support:</strong> canvas-text<span class="and_chr yes"><span>Chrome for Android</span> <span>80+</span></span><span class="chrome yes"><span>Chrome</span> <span>4+</span></span><span class="ios_saf yes"><span>iOS Safari</span> <span>3.2+</span></span><span class="firefox yes"><span>Firefox</span> <span>3.5+</span></span><span class="safari yes"><span>Safari</span> <span>4+</span></span><span class="samsung yes"><span>Samsung Internet</span> <span>4+</span></span><span class="and_uc yes"><span>UC Browser for Android</span> <span>12.12+</span></span><span class="edge yes"><span>Edge</span> <span>12+</span></span><span class="ie yes"><span>IE</span> <span>9+</span></span><span class="opera yes"><span>Opera</span> <span>10.5+</span></span><span class="op_mini no"><span>Opera Mini</span> <span>None</span></span><span class="android yes"><span>Android Browser</span> <span>2.1+</span></span><p class=caniuse>Source: <a href="https://caniuse.com/#feat=canvas-text">caniuse.com</a></div>

  <dl id=text-0 class=domintro><dt><var>context</var> . <code id=dom-context-2d-filltext-dev><a href=#dom-context-2d-filltext>fillText</a></code>(<var>text</var>, <var>x</var>, <var>y</var> [, <var>maxWidth</var> ] )<dt><var>context</var> . <code id=dom-context-2d-stroketext-dev><a href=#dom-context-2d-stroketext>strokeText</a></code>(<var>text</var>, <var>x</var>, <var>y</var> [, <var>maxWidth</var> ] )<dd>
    <p>Fills or strokes (respectively) the given text at the given position. If a maximum width is
    provided, the text will be scaled to fit that width if necessary.</p>
   <dt><var>metrics</var> = <var>context</var> . <code id=dom-context-2d-measuretext-dev><a href=#dom-context-2d-measuretext>measureText</a></code>(<var>text</var>)<dd>
    <p>Returns a <code id=drawing-text-to-the-bitmap:textmetrics><a href=#textmetrics>TextMetrics</a></code> object with the metrics of the given text in the current
    font.</p>
   <dt><var>metrics</var> . <code id=dom-textmetrics-width-dev><a href=#dom-textmetrics-width>width</a></code><dt><var>metrics</var> . <code id=dom-textmetrics-actualboundingboxleft-dev><a href=#dom-textmetrics-actualboundingboxleft>actualBoundingBoxLeft</a></code><dt><var>metrics</var> . <code id=dom-textmetrics-actualboundingboxright-dev><a href=#dom-textmetrics-actualboundingboxright>actualBoundingBoxRight</a></code><dt><var>metrics</var> . <code id=dom-textmetrics-fontboundingboxascent-dev><a href=#dom-textmetrics-fontboundingboxascent>fontBoundingBoxAscent</a></code><dt><var>metrics</var> . <code id=dom-textmetrics-fontboundingboxdescent-dev><a href=#dom-textmetrics-fontboundingboxdescent>fontBoundingBoxDescent</a></code><dt><var>metrics</var> . <code id=dom-textmetrics-actualboundingboxascent-dev><a href=#dom-textmetrics-actualboundingboxascent>actualBoundingBoxAscent</a></code><dt><var>metrics</var> . <code id=dom-textmetrics-actualboundingboxdescent-dev><a href=#dom-textmetrics-actualboundingboxdescent>actualBoundingBoxDescent</a></code><dt><var>metrics</var> . <code id=dom-textmetrics-emheightascent-dev><a href=#dom-textmetrics-emheightascent>emHeightAscent</a></code><dt><var>metrics</var> . <code id=dom-textmetrics-emheightdescent-dev><a href=#dom-textmetrics-emheightdescent>emHeightDescent</a></code><dt><var>metrics</var> . <code id=dom-textmetrics-hangingbaseline-dev><a href=#dom-textmetrics-hangingbaseline>hangingBaseline</a></code><dt><var>metrics</var> . <code id=dom-textmetrics-alphabeticbaseline-dev><a href=#dom-textmetrics-alphabeticbaseline>alphabeticBaseline</a></code><dt><var>metrics</var> . <code id=dom-textmetrics-ideographicbaseline-dev><a href=#dom-textmetrics-ideographicbaseline>ideographicBaseline</a></code><dd>
    <p>Returns the measurement described below.</p>
   </dl>

  

  <p>Objects that implement the <code id=drawing-text-to-the-bitmap:canvastext><a href=#canvastext>CanvasText</a></code> interface provide the following methods for
  rendering text.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/fillText title="The CanvasRenderingContext2D method fillText(), part of the Canvas 2D API, draws a text string at the specified coordinates, filling the string's characters with the current fillStyle. An optional parameter allows specifying a maximum width for the rendered text, which the user agent will achieve by condensing the text or by using a lower font size.">CanvasRenderingContext2D/fillText</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/strokeText title="The CanvasRenderingContext2D method strokeText(), part of the Canvas 2D API, strokes — that is, draws the outlines of — the characters of a text string at the specified coordinates. An optional parameter allows specifying a maximum width for the rendered text, which the user agent will achieve by condensing the text or by using a lower font size.">CanvasRenderingContext2D/strokeText</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-filltext><code>fillText()</code></dfn> and <dfn id=dom-context-2d-stroketext><code>strokeText()</code></dfn> methods take three or four arguments,
  <var>text</var>, <var>x</var>, <var>y</var>, and optionally <var>maxWidth</var>, and render the
  given <var>text</var> at the given (<var>x</var>, <var>y</var>) coordinates ensuring that the text
  isn't wider than <var>maxWidth</var> if specified, using the current <code id=drawing-text-to-the-bitmap:dom-context-2d-font><a href=#dom-context-2d-font>font</a></code>, <code id=drawing-text-to-the-bitmap:dom-context-2d-textalign><a href=#dom-context-2d-textalign>textAlign</a></code>, and <code id=drawing-text-to-the-bitmap:dom-context-2d-textbaseline><a href=#dom-context-2d-textbaseline>textBaseline</a></code> values. Specifically, when the methods
  are invoked, the user agent must run these steps:</p>

  <ol><li><p>If any of the arguments are infinite or NaN, then return.<li><p>Run the <a href=#text-preparation-algorithm id=drawing-text-to-the-bitmap:text-preparation-algorithm>text preparation algorithm</a>, passing it <var>text</var>, the object
   implementing the <code id=drawing-text-to-the-bitmap:canvastext-2><a href=#canvastext>CanvasText</a></code> interface, and, if the <var>maxWidth</var> argument was
   provided, that argument. Let <var>glyphs</var> be the result.</p>

   <li><p>Move all the shapes in <var>glyphs</var> to the right by <var>x</var>
   <a href=https://drafts.csswg.org/css-values/#px id="drawing-text-to-the-bitmap:'px'" data-x-internal="'px'">CSS pixels</a> and down by <var>y</var> <a href=https://drafts.csswg.org/css-values/#px id="drawing-text-to-the-bitmap:'px'-2" data-x-internal="'px'">CSS
   pixels</a>.<li>
    <p>Paint the shapes given in <var>glyphs</var>, as transformed by the <a href=#transformations id=drawing-text-to-the-bitmap:transformations>current transformation matrix</a>, with each <a href=https://drafts.csswg.org/css-values/#px id="drawing-text-to-the-bitmap:'px'-3" data-x-internal="'px'">CSS pixel</a> in the coordinate space of <var>glyphs</var> mapped to one
    coordinate space unit.</p>

    <p>For <code id=drawing-text-to-the-bitmap:dom-context-2d-filltext><a href=#dom-context-2d-filltext>fillText()</a></code>, <code id=drawing-text-to-the-bitmap:dom-context-2d-fillstyle><a href=#dom-context-2d-fillstyle>fillStyle</a></code> must be applied to the shapes and <code id=drawing-text-to-the-bitmap:dom-context-2d-strokestyle><a href=#dom-context-2d-strokestyle>strokeStyle</a></code> must be ignored. For <code id=drawing-text-to-the-bitmap:dom-context-2d-stroketext><a href=#dom-context-2d-stroketext>strokeText()</a></code>, the reverse holds: <code id=drawing-text-to-the-bitmap:dom-context-2d-strokestyle-2><a href=#dom-context-2d-strokestyle>strokeStyle</a></code> must be applied to the result of <a href=#trace-a-path id=drawing-text-to-the-bitmap:trace-a-path>tracing</a> the shapes using the object implementing the
    <code id=drawing-text-to-the-bitmap:canvastext-3><a href=#canvastext>CanvasText</a></code> interface for the line styles, and <code id=drawing-text-to-the-bitmap:dom-context-2d-fillstyle-2><a href=#dom-context-2d-fillstyle>fillStyle</a></code> must be ignored.</p>

    <p>These shapes are painted without affecting the current path, and are subject to <a href=#shadows id=drawing-text-to-the-bitmap:shadows>shadow effects</a>, <a href=#dom-context-2d-globalalpha id=drawing-text-to-the-bitmap:dom-context-2d-globalalpha>global
    alpha</a>, the <a href=#clipping-region id=drawing-text-to-the-bitmap:clipping-region>clipping region</a>, and <a href=#dom-context-2d-globalcompositeoperation id=drawing-text-to-the-bitmap:dom-context-2d-globalcompositeoperation>global composition operators</a>.</p>
   </ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/measureText title="The CanvasRenderingContext2D.measureText() method returns a TextMetrics object that contains information about the measured text (such as its width, for example).">CanvasRenderingContext2D/measureText</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>2+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>
  <a id=drawing-text-to-the-bitmap:tracking-vector title="There is a tracking vector here." href=https://infra.spec.whatwg.org/#tracking-vector class=tracking-vector data-x-internal=tracking-vector><img width=46 alt="(This is a tracking vector.)" crossorigin="" src=https://resources.whatwg.org/tracking-vector.svg height=64></a>
  The <dfn id=dom-context-2d-measuretext><code>measureText()</code></dfn> method takes one
  argument, <var>text</var>. When the method is invoked, the user agent must run the <a href=#text-preparation-algorithm id=drawing-text-to-the-bitmap:text-preparation-algorithm-2>text
  preparation algorithm</a>, passing it <var>text</var> and the object implementing the
  <code id=drawing-text-to-the-bitmap:canvastext-4><a href=#canvastext>CanvasText</a></code> interface, and then using the returned <a id=drawing-text-to-the-bitmap:inline-box href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a> must return
  a new <code id=drawing-text-to-the-bitmap:textmetrics-2><a href=#textmetrics>TextMetrics</a></code> object with members behaving as described in the following list:
  <a href=references.html#refsCSS>[CSS]</a></p>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/TextMetrics/width title="The read-only width property of the TextMetrics interface contains the text's advance width (the width of that inline box) in CSS pixels.">TextMetrics/width</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>31+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>3.2+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/TextMetrics/actualBoundingBoxLeft title="The read-only actualBoundingBoxLeft property of the TextMetrics interface is a double giving the distance parallel to the baseline from the alignment point given by the CanvasRenderingContext2D.textAlign property to the left side of the bounding rectangle of the given text, in CSS pixels.">TextMetrics/actualBoundingBoxLeft</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>74+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>77+</span></span><hr><span class="opera unknown"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>77+</span></span><span class="webview_android yes"><span>WebView Android</span><span>77+</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android unknown"><span>Opera Android</span><span>?</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/TextMetrics/actualBoundingBoxRight title="The read-only actualBoundingBoxRight property of the TextMetrics interface is a double giving the distance parallel to the baseline from the alignment point given by the CanvasRenderingContext2D.textAlign property to the right side of the bounding rectangle of the given text, in CSS pixels.">TextMetrics/actualBoundingBoxRight</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>74+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>77+</span></span><hr><span class="opera unknown"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>77+</span></span><span class="webview_android yes"><span>WebView Android</span><span>77+</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android unknown"><span>Opera Android</span><span>?</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/TextMetrics/fontBoundingBoxAscent title="The read-only fontBoundingBoxAscent property of the TextMetrics interface is a double giving the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline attribute to the top of the highest bounding rectangle of all the fonts used to render the text, in CSS pixels.">TextMetrics/fontBoundingBoxAscent</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span title="Requires setting a user preference or runtime flag.">🔰 74+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="opera unknown"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android unknown"><span>Opera Android</span><span>?</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/TextMetrics/fontBoundingBoxDescent title="The read-only fontBoundingBoxDescent property of the TextMetrics interface is a double giving the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline attribute to the bottom of the bounding rectangle of all the fonts used to render the text, in CSS pixels.">TextMetrics/fontBoundingBoxDescent</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span title="Requires setting a user preference or runtime flag.">🔰 74+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="opera unknown"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android unknown"><span>Opera Android</span><span>?</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/TextMetrics/actualBoundingBoxAscent title="The read-only actualBoundingBoxAscent property of the TextMetrics interface is a double giving the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline attribute to the top of the bounding rectangle used to render the text, in CSS pixels.">TextMetrics/actualBoundingBoxAscent</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>74+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>77+</span></span><hr><span class="opera unknown"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>77+</span></span><span class="webview_android yes"><span>WebView Android</span><span>77+</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android unknown"><span>Opera Android</span><span>?</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/TextMetrics/actualBoundingBoxDescent title="The read-only actualBoundingBoxDescent property of the TextMetrics interface is a double giving the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline attribute to the bottom of the bounding rectangle used to render the text, in CSS pixels.">TextMetrics/actualBoundingBoxDescent</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>74+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>77+</span></span><hr><span class="opera unknown"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>77+</span></span><span class="webview_android yes"><span>WebView Android</span><span>77+</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android unknown"><span>Opera Android</span><span>?</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/TextMetrics/emHeightAscent title="The read-only emHeightAscent property of the TextMetrics interface is a double giving the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline property to the top of the em square in the line box, in CSS pixels.">TextMetrics/emHeightAscent</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span title="Requires setting a user preference or runtime flag.">🔰 74+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="opera unknown"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android unknown"><span>Opera Android</span><span>?</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/TextMetrics/emHeightDescent title="The read-only emHeightDescent property of the TextMetrics interface is a double giving the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline property to the bottom of the em square in the line box, in CSS pixels.">TextMetrics/emHeightDescent</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span title="Requires setting a user preference or runtime flag.">🔰 74+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="opera unknown"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android unknown"><span>Opera Android</span><span>?</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/TextMetrics/hangingBaseline title="The read-only hangingBaseline property of the TextMetrics interface is a double giving the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline property to the hanging baseline of the line box, in CSS pixels.">TextMetrics/hangingBaseline</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span title="Requires setting a user preference or runtime flag.">🔰 74+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="opera unknown"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android unknown"><span>Opera Android</span><span>?</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/TextMetrics/alphabeticBaseline title="The read-only alphabeticBaseline property of the TextMetrics interface is a double giving the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline property to the alphabetic baseline of the line box, in CSS pixels.">TextMetrics/alphabeticBaseline</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span title="Requires setting a user preference or runtime flag.">🔰 74+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="opera unknown"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android unknown"><span>Opera Android</span><span>?</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/TextMetrics/ideographicBaseline title="The read-only ideographicBaseline property of the TextMetrics interface is a double giving the distance from the horizontal line indicated by the CanvasRenderingContext2D.textBaseline property to the ideographic baseline of the line box, in CSS pixels.">TextMetrics/ideographicBaseline</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span title="Requires setting a user preference or runtime flag.">🔰 74+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="opera unknown"><span>Opera</span><span>?</span></span><span class="edge_blink yes"><span>Edge</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android unknown"><span>Opera Android</span><span>?</span></span></div></div></aside><dl><dt><dfn id=dom-textmetrics-width><code>width</code></dfn> attribute<dd><p>The width of that <a id=drawing-text-to-the-bitmap:inline-box-2 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a>, in <a href=https://drafts.csswg.org/css-values/#px id="drawing-text-to-the-bitmap:'px'-4" data-x-internal="'px'">CSS pixels</a>. (The
   text's advance width.)<dt><dfn id=dom-textmetrics-actualboundingboxleft><code>actualBoundingBoxLeft</code></dfn> attribute<dd>
    <p>The distance parallel to the baseline from the alignment point given by the <code id=drawing-text-to-the-bitmap:dom-context-2d-textalign-2><a href=#dom-context-2d-textalign>textAlign</a></code> attribute to the left side of the bounding
    rectangle of the given text, in <a href=https://drafts.csswg.org/css-values/#px id="drawing-text-to-the-bitmap:'px'-5" data-x-internal="'px'">CSS pixels</a>; positive numbers
    indicating a distance going left from the given alignment point.

    <p class=note>The sum of this value and the next (<code id=drawing-text-to-the-bitmap:dom-textmetrics-actualboundingboxright><a href=#dom-textmetrics-actualboundingboxright>actualBoundingBoxRight</a></code>) can be wider than
    the width of the <a id=drawing-text-to-the-bitmap:inline-box-3 href=https://drafts.csswg.org/css2/visuren.html#inline-box data-x-internal=inline-box>inline box</a> (<code id=drawing-text-to-the-bitmap:dom-textmetrics-width><a href=#dom-textmetrics-width>width</a></code>), in
    particular with slanted fonts where characters overhang their advance width.</p>
   <dt><dfn id=dom-textmetrics-actualboundingboxright><code>actualBoundingBoxRight</code></dfn> attribute<dd>
    <p>The distance parallel to the baseline from the alignment point given by the <code id=drawing-text-to-the-bitmap:dom-context-2d-textalign-3><a href=#dom-context-2d-textalign>textAlign</a></code> attribute to the right side of the bounding
    rectangle of the given text, in <a href=https://drafts.csswg.org/css-values/#px id="drawing-text-to-the-bitmap:'px'-6" data-x-internal="'px'">CSS pixels</a>; positive numbers
    indicating a distance going right from the given alignment point.</p>
   <dt><dfn id=dom-textmetrics-fontboundingboxascent><code>fontBoundingBoxAscent</code></dfn> attribute<dd>
    <p>The distance from the horizontal line indicated by the <code id=drawing-text-to-the-bitmap:dom-context-2d-textbaseline-2><a href=#dom-context-2d-textbaseline>textBaseline</a></code> attribute to the top of the highest
    bounding rectangle of all the fonts used to render the text, in <a href=https://drafts.csswg.org/css-values/#px id="drawing-text-to-the-bitmap:'px'-7" data-x-internal="'px'">CSS
    pixels</a>; positive numbers indicating a distance going up from the given baseline.</p>

    <p class=note>This value and the next are useful when rendering a background that have to have
    a consistent height even if the exact text being rendered changes. The <code id=drawing-text-to-the-bitmap:dom-textmetrics-actualboundingboxascent><a href=#dom-textmetrics-actualboundingboxascent>actualBoundingBoxAscent</a></code> attribute (and
    its corresponding attribute for the descent) are useful when drawing a bounding box around
    specific text.</p>
   <dt><dfn id=dom-textmetrics-fontboundingboxdescent><code>fontBoundingBoxDescent</code></dfn> attribute<dd><p>The distance from the horizontal line indicated by the <code id=drawing-text-to-the-bitmap:dom-context-2d-textbaseline-3><a href=#dom-context-2d-textbaseline>textBaseline</a></code> attribute to the bottom of the lowest
   bounding rectangle of all the fonts used to render the text, in <a href=https://drafts.csswg.org/css-values/#px id="drawing-text-to-the-bitmap:'px'-8" data-x-internal="'px'">CSS
   pixels</a>; positive numbers indicating a distance going down from the given
   baseline.<dt><dfn id=dom-textmetrics-actualboundingboxascent><code>actualBoundingBoxAscent</code></dfn> attribute<dd>
    <p>The distance from the horizontal line indicated by the <code id=drawing-text-to-the-bitmap:dom-context-2d-textbaseline-4><a href=#dom-context-2d-textbaseline>textBaseline</a></code> attribute to the top of the bounding
    rectangle of the given text, in <a href=https://drafts.csswg.org/css-values/#px id="drawing-text-to-the-bitmap:'px'-9" data-x-internal="'px'">CSS pixels</a>; positive numbers
    indicating a distance going up from the given baseline.

    <p class=note>This number can vary greatly based on the input text, even if the first font
    specified covers all the characters in the input. For example, the <code id=drawing-text-to-the-bitmap:dom-textmetrics-actualboundingboxascent-2><a href=#dom-textmetrics-actualboundingboxascent>actualBoundingBoxAscent</a></code> of a lowercase
    "o" from an alphabetic baseline would be less than that of an uppercase "F". The value can
    easily be negative; for example, the distance from the top of the em box (<code id=drawing-text-to-the-bitmap:dom-context-2d-textbaseline-5><a href=#dom-context-2d-textbaseline>textBaseline</a></code> value "<code id=drawing-text-to-the-bitmap:dom-context-2d-textbaseline-top><a href=#dom-context-2d-textbaseline-top>top</a></code>") to the top of the bounding rectangle when
    the given text is just a single comma "<code>,</code>" would likely (unless the font is
    quite unusual) be negative.</p>
   <dt><dfn id=dom-textmetrics-actualboundingboxdescent><code>actualBoundingBoxDescent</code></dfn> attribute<dd><p>The distance from the horizontal line indicated by the <code id=drawing-text-to-the-bitmap:dom-context-2d-textbaseline-6><a href=#dom-context-2d-textbaseline>textBaseline</a></code> attribute to the bottom of the bounding
   rectangle of the given text, in <a href=https://drafts.csswg.org/css-values/#px id="drawing-text-to-the-bitmap:'px'-10" data-x-internal="'px'">CSS pixels</a>; positive numbers
   indicating a distance going down from the given baseline.<dt><dfn id=dom-textmetrics-emheightascent><code>emHeightAscent</code></dfn> attribute<dd><p>The distance from the horizontal line indicated by the <code id=drawing-text-to-the-bitmap:dom-context-2d-textbaseline-7><a href=#dom-context-2d-textbaseline>textBaseline</a></code> attribute to the highest top of the em
   squares in the <a id=drawing-text-to-the-bitmap:line-box href=https://drafts.csswg.org/css2/visuren.html#line-box data-x-internal=line-box>line box</a>, in <a href=https://drafts.csswg.org/css-values/#px id="drawing-text-to-the-bitmap:'px'-11" data-x-internal="'px'">CSS pixels</a>; positive numbers
   indicating that the given baseline is below the top of that em square (so this value will usually
   be positive). Zero if the given baseline is the top of that em square; half the font size if the
   given baseline is the middle of that em square.<dt><dfn id=dom-textmetrics-emheightdescent><code>emHeightDescent</code></dfn> attribute<dd><p>The distance from the horizontal line indicated by the <code id=drawing-text-to-the-bitmap:dom-context-2d-textbaseline-8><a href=#dom-context-2d-textbaseline>textBaseline</a></code> attribute to the lowest bottom of the em
   squares in the <a id=drawing-text-to-the-bitmap:line-box-2 href=https://drafts.csswg.org/css2/visuren.html#line-box data-x-internal=line-box>line box</a>, in <a href=https://drafts.csswg.org/css-values/#px id="drawing-text-to-the-bitmap:'px'-12" data-x-internal="'px'">CSS pixels</a>; positive numbers
   indicating that the given baseline is above the bottom of that em square. (Zero if the given baseline
   is the bottom of that em square.)<dt><dfn id=dom-textmetrics-hangingbaseline><code>hangingBaseline</code></dfn> attribute<dd><p>The distance from the horizontal line indicated by the <code id=drawing-text-to-the-bitmap:dom-context-2d-textbaseline-9><a href=#dom-context-2d-textbaseline>textBaseline</a></code> attribute to the hanging baseline of the
   <a id=drawing-text-to-the-bitmap:line-box-3 href=https://drafts.csswg.org/css2/visuren.html#line-box data-x-internal=line-box>line box</a>, in <a href=https://drafts.csswg.org/css-values/#px id="drawing-text-to-the-bitmap:'px'-13" data-x-internal="'px'">CSS pixels</a>; positive numbers indicating that
   the given baseline is below the hanging baseline. (Zero if the given baseline is the hanging
   baseline.)<dt><dfn id=dom-textmetrics-alphabeticbaseline><code>alphabeticBaseline</code></dfn> attribute<dd><p>The distance from the horizontal line indicated by the <code id=drawing-text-to-the-bitmap:dom-context-2d-textbaseline-10><a href=#dom-context-2d-textbaseline>textBaseline</a></code> attribute to the alphabetic baseline of
   the <a id=drawing-text-to-the-bitmap:line-box-4 href=https://drafts.csswg.org/css2/visuren.html#line-box data-x-internal=line-box>line box</a>, in <a href=https://drafts.csswg.org/css-values/#px id="drawing-text-to-the-bitmap:'px'-14" data-x-internal="'px'">CSS pixels</a>; positive numbers indicating
   that the given baseline is below the alphabetic baseline. (Zero if the given baseline is the
   alphabetic baseline.)<dt><dfn id=dom-textmetrics-ideographicbaseline><code>ideographicBaseline</code></dfn> attribute<dd><p>The distance from the horizontal line indicated by the <code id=drawing-text-to-the-bitmap:dom-context-2d-textbaseline-11><a href=#dom-context-2d-textbaseline>textBaseline</a></code> attribute to the ideographic baseline of
   the <a id=drawing-text-to-the-bitmap:line-box-5 href=https://drafts.csswg.org/css2/visuren.html#line-box data-x-internal=line-box>line box</a>, in <a href=https://drafts.csswg.org/css-values/#px id="drawing-text-to-the-bitmap:'px'-15" data-x-internal="'px'">CSS pixels</a>; positive numbers indicating
   that the given baseline is below the ideographic baseline. (Zero if the given baseline is the
   ideographic baseline.)</dl>

  <p class=note>Glyphs rendered using <code id=drawing-text-to-the-bitmap:dom-context-2d-filltext-2><a href=#dom-context-2d-filltext>fillText()</a></code> and
  <code id=drawing-text-to-the-bitmap:dom-context-2d-stroketext-2><a href=#dom-context-2d-stroketext>strokeText()</a></code> can spill out of the box given by the
  font size (the em square size) and the width returned by <code id=drawing-text-to-the-bitmap:dom-context-2d-measuretext><a href=#dom-context-2d-measuretext>measureText()</a></code> (the text width). Authors are encouraged
  to use the bounding box values described above if this is an issue.</p>

  <p class=note>A future version of the 2D context API might provide a way to render fragments of
  documents, rendered using CSS, straight to the canvas. This would be provided in preference to a
  dedicated way of doing multiline layout.</p>



  <h6 id=drawing-paths-to-the-canvas><span class=secno>4.12.5.1.12</span> Drawing paths to the canvas<a href=#drawing-paths-to-the-canvas class=self-link></a></h6>

  <p>Objects that implement the <code id=drawing-paths-to-the-canvas:canvasdrawpath><a href=#canvasdrawpath>CanvasDrawPath</a></code> interface have a <dfn id=current-default-path>current default
  path</dfn>. There is only one <a href=#current-default-path id=drawing-paths-to-the-canvas:current-default-path>current default path</a>, it is not part of the
  <a href=#drawing-state id=drawing-paths-to-the-canvas:drawing-state>drawing state</a>. The <a href=#current-default-path id=drawing-paths-to-the-canvas:current-default-path-2>current default path</a> is a <a href=#concept-path id=drawing-paths-to-the-canvas:concept-path>path</a>, as described above.</p>

  <dl class=domintro><dt><var>context</var> . <code id=dom-context-2d-beginpath-dev><a href=#dom-context-2d-beginpath>beginPath</a></code>()<dd>
    <p>Resets the <a href=#current-default-path id=drawing-paths-to-the-canvas:current-default-path-3>current default path</a>.</p>
   <dt><var>context</var> . <code id=dom-context-2d-fill-dev><a href=#dom-context-2d-fill>fill</a></code>( [ <var>fillRule</var> ] )<dt><var>context</var> . <code id=drawing-paths-to-the-canvas:dom-context-2d-fill><a href=#dom-context-2d-fill>fill</a></code>(<var>path</var> [, <var>fillRule</var> ] )<dd>
    <p>Fills the subpaths of the <a href=#current-default-path id=drawing-paths-to-the-canvas:current-default-path-4>current default path</a> or the given path with the
    current fill style, obeying the given fill rule.</p>
   <dt><var>context</var> . <code id=dom-context-2d-stroke-dev><a href=#dom-context-2d-stroke>stroke</a></code>()<dt><var>context</var> . <code id=drawing-paths-to-the-canvas:dom-context-2d-stroke><a href=#dom-context-2d-stroke>stroke</a></code>(<var>path</var>)<dd>
    <p>Strokes the subpaths of the <a href=#current-default-path id=drawing-paths-to-the-canvas:current-default-path-5>current default path</a> or the given path with the
    current stroke style.</p>
   <dt><var>context</var> . <code id=dom-context-2d-clip-dev><a href=#dom-context-2d-clip>clip</a></code>( [ <var>fillRule</var> ] )<dt><var>context</var> . <code id=drawing-paths-to-the-canvas:dom-context-2d-clip><a href=#dom-context-2d-clip>clip</a></code>(<var>path</var> [, <var>fillRule</var> ] )<dd>
    <p>Further constrains the clipping region to the <a href=#current-default-path id=drawing-paths-to-the-canvas:current-default-path-6>current default path</a> or the given
    path, using the given fill rule to determine what points are in the path.</p>
   <dt><var>context</var> . <code id=dom-context-2d-ispointinpath-dev><a href=#dom-context-2d-ispointinpath>isPointInPath</a></code>(<var>x</var>, <var>y</var> [, <var>fillRule</var> ] )<dt><var>context</var> . <code id=drawing-paths-to-the-canvas:dom-context-2d-ispointinpath><a href=#dom-context-2d-ispointinpath>isPointInPath</a></code>(<var>path</var>, <var>x</var>, <var>y</var> [, <var>fillRule</var> ] )<dd>
    <p>Returns true if the given point is in the <a href=#current-default-path id=drawing-paths-to-the-canvas:current-default-path-7>current default path</a> or the given
    path, using the given fill rule to determine what points are in the path.</p>
   <dt><var>context</var> . <code id=dom-context-2d-ispointinstroke-dev><a href=#dom-context-2d-ispointinstroke>isPointInStroke</a></code>(<var>x</var>, <var>y</var>)<dt><var>context</var> . <code id=drawing-paths-to-the-canvas:dom-context-2d-ispointinstroke><a href=#dom-context-2d-ispointinstroke>isPointInStroke</a></code>(<var>path</var>, <var>x</var>, <var>y</var>)<dd>
    <p>Returns true if the given point would be in the region covered by the stroke of the
    <a href=#current-default-path id=drawing-paths-to-the-canvas:current-default-path-8>current default path</a> or the given path, given the current stroke style.</p>
   </dl>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/beginPath title="The CanvasRenderingContext2D.beginPath() method of the Canvas 2D API starts a new path by emptying the list of sub-paths. Call this method when you want to create a new path.">CanvasRenderingContext2D/beginPath</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-beginpath><code>beginPath()</code></dfn> method, when invoked,
  must empty the list of subpaths in the context's <a href=#current-default-path id=drawing-paths-to-the-canvas:current-default-path-9>current default path</a> so that the it
  once again has zero subpaths.</p>

  <p>Where the following method definitions use the term <i>intended path</i>, it means the
  <code id=drawing-paths-to-the-canvas:path2d><a href=#path2d>Path2D</a></code> argument, if one was provided, or the <a href=#current-default-path id=drawing-paths-to-the-canvas:current-default-path-10>current default path</a>
  otherwise.</p>

  <p>When the intended path is a <code id=drawing-paths-to-the-canvas:path2d-2><a href=#path2d>Path2D</a></code> object, the coordinates and lines of its
  subpaths must be transformed according to the <a href=#transformations id=drawing-paths-to-the-canvas:transformations>
  current transformation matrix</a> on the object implementing the
  <code id=drawing-paths-to-the-canvas:canvastransform><a href=#canvastransform>CanvasTransform</a></code> interface when used by these methods (without affecting the
  <code id=drawing-paths-to-the-canvas:path2d-3><a href=#path2d>Path2D</a></code> object itself). When the intended path is the <a href=#current-default-path id=drawing-paths-to-the-canvas:current-default-path-11>current default
  path</a>, it is not affected by the transform. (This is because transformations already affect
  the <a href=#current-default-path id=drawing-paths-to-the-canvas:current-default-path-12>current default path</a> when it is constructed, so applying it when it is painted as
  well would result in a double transformation.)</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/fill title="The CanvasRenderingContext2D.fill() method of the Canvas 2D API fills the current or given path with the current fillStyle.">CanvasRenderingContext2D/fill</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-fill><code>fill()</code></dfn> method, when invoked, must fill
  all the subpaths of the intended path, using <code id=drawing-paths-to-the-canvas:dom-context-2d-fillstyle><a href=#dom-context-2d-fillstyle>fillStyle</a></code>, and using the <a href=#fill-rule id=drawing-paths-to-the-canvas:fill-rule>fill rule</a> indicated
  by the <var>fillRule</var> argument. Open subpaths must be implicitly closed when being filled
  (without affecting the actual subpaths).</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/stroke title="The CanvasRenderingContext2D.stroke() method of the Canvas 2D API strokes (outlines) the current or given path with the current stroke style.">CanvasRenderingContext2D/stroke</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-stroke><code>stroke()</code></dfn> method, when invoked, must
  <a href=#trace-a-path id=drawing-paths-to-the-canvas:trace-a-path>trace</a> the intended path, using this
  <code id=drawing-paths-to-the-canvas:canvaspathdrawingstyles><a href=#canvaspathdrawingstyles>CanvasPathDrawingStyles</a></code> object for the line styles, and then fill the resulting path
  using the <code id=drawing-paths-to-the-canvas:dom-context-2d-strokestyle><a href=#dom-context-2d-strokestyle>strokeStyle</a></code> attribute, using the <a href=#dom-context-2d-fillrule-nonzero id=drawing-paths-to-the-canvas:dom-context-2d-fillrule-nonzero>nonzero winding rule</a>.</p>

  <p class=note>As a result of how the algorithm to <a href=#trace-a-path id=drawing-paths-to-the-canvas:trace-a-path-2>trace a path</a> is defined,
  overlapping parts of the paths in one stroke operation are treated as if their union was what was
  painted.</p>

  <p class=note>The stroke <em>style</em> is affected by the transformation during painting, even
  if the intended path is the <a href=#current-default-path id=drawing-paths-to-the-canvas:current-default-path-13>current default path</a>.</p>

  <p>Paths, when filled or stroked, must be painted without affecting the <a href=#current-default-path id=drawing-paths-to-the-canvas:current-default-path-14>current default
  path</a> or any <code id=drawing-paths-to-the-canvas:path2d-4><a href=#path2d>Path2D</a></code> objects, and must be subject to <a href=#shadows id=drawing-paths-to-the-canvas:shadows>shadow effects</a>, <a href=#dom-context-2d-globalalpha id=drawing-paths-to-the-canvas:dom-context-2d-globalalpha>global
  alpha</a>, the <a href=#clipping-region id=drawing-paths-to-the-canvas:clipping-region>clipping region</a>, and <a href=#dom-context-2d-globalcompositeoperation id=drawing-paths-to-the-canvas:dom-context-2d-globalcompositeoperation>global composition operators</a>. (The effect
  of transformations is described above and varies based on which path is being used.)</p>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/clip title="The CanvasRenderingContext2D.clip() method of the Canvas 2D API turns the current or given path into the current clipping region. It replaces any previous clipping region.">CanvasRenderingContext2D/clip</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-clip><code>clip()</code></dfn> method, when invoked, must
  create a new <dfn id=clipping-region>clipping region</dfn> by calculating the intersection of the current clipping
  region and the area described by the intended path, using the <a href=#fill-rule id=drawing-paths-to-the-canvas:fill-rule-2>fill rule</a> indicated by
  the <var>fillRule</var> argument. Open subpaths must be implicitly closed when computing the
  clipping region, without affecting the actual subpaths. The new clipping region replaces the
  current clipping region.</p>

  <p>When the context is initialized, the clipping region must be set to the largest infinite
  surface (i.e. by default, no clipping occurs).</p>

  

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/isPointInPath title="The CanvasRenderingContext2D.isPointInPath() method of the Canvas 2D API reports whether or not the specified point is contained in the current path.">CanvasRenderingContext2D/isPointInPath</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>2+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-ispointinpath><code>isPointInPath()</code></dfn> method, when
  invoked, must return true if the point given by the <var>x</var> and <var>y</var> coordinates
  passed to the method, when treated as coordinates in the canvas coordinate space unaffected by the
  current transformation, is inside the intended path as determined by the <a href=#fill-rule id=drawing-paths-to-the-canvas:fill-rule-3>fill rule</a>
  indicated by the <var>fillRule</var> argument; and must return false otherwise. Open subpaths must
  be implicitly closed when computing the area inside the path, without affecting the actual
  subpaths. Points on the path itself must be considered to be inside the path. If either of the
  arguments are infinite or NaN, then the method must return false.</p>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/isPointInStroke title="The CanvasRenderingContext2D.isPointInStroke() method of the Canvas 2D API reports whether or not the specified point is inside the area contained by the stroking of a path.">CanvasRenderingContext2D/isPointInStroke</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>20+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>20+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-ispointinstroke><code>isPointInStroke()</code></dfn> method,
  when invoked, must return true if the point given by the <var>x</var> and <var>y</var> coordinates
  passed to the method, when treated as coordinates in the canvas coordinate space unaffected by the
  current transformation, is inside the path that results from <a href=#trace-a-path id=drawing-paths-to-the-canvas:trace-a-path-3>tracing</a> the intended path, using the <a href=#dom-context-2d-fillrule-nonzero id=drawing-paths-to-the-canvas:dom-context-2d-fillrule-nonzero-2>nonzero winding rule</a>, and using the
  <code id=drawing-paths-to-the-canvas:canvaspathdrawingstyles-2><a href=#canvaspathdrawingstyles>CanvasPathDrawingStyles</a></code> interface for the line styles; and must return false
  otherwise. Points on the resulting path must be considered to be inside the path. If either of the
  arguments are infinite or NaN, then the method must return false.</p>

  <hr>

  

  <div id=drawCustomFocusRingExample class=example>

   <p>This <code id=drawing-paths-to-the-canvas:the-canvas-element><a href=#the-canvas-element>canvas</a></code> element has a couple of checkboxes. The path-related commands are
   highlighted:</p>

   <pre><code class='html'><c- p>&lt;</c-><c- f>canvas</c-> <c- e>height</c-><c- o>=</c-><c- s>400</c-> <c- e>width</c-><c- o>=</c-><c- s>750</c-><c- p>&gt;</c->
 <c- p>&lt;</c-><c- f>label</c-><c- p>&gt;&lt;</c-><c- f>input</c-> <c- e>type</c-><c- o>=</c-><c- s>checkbox</c-> <c- e>id</c-><c- o>=</c-><c- s>showA</c-><c- p>&gt;</c-> Show As<c- p>&lt;/</c-><c- f>label</c-><c- p>&gt;</c->
 <c- p>&lt;</c-><c- f>label</c-><c- p>&gt;&lt;</c-><c- f>input</c-> <c- e>type</c-><c- o>=</c-><c- s>checkbox</c-> <c- e>id</c-><c- o>=</c-><c- s>showB</c-><c- p>&gt;</c-> Show Bs<c- p>&lt;/</c-><c- f>label</c-><c- p>&gt;</c->
 <c- c>&lt;!-- ... --&gt;</c->
<c- p>&lt;/</c-><c- f>canvas</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>script</c-><c- p>&gt;</c->
 <c- a>function</c-> drawCheckbox<c- p>(</c->context<c- p>,</c-> element<c- p>,</c-> x<c- p>,</c-> y<c- p>,</c-> paint<c- p>)</c-> <c- p>{</c->
   context<c- p>.</c->save<c- p>();</c->
   context<c- p>.</c->font <c- o>=</c-> <c- t>&apos;10px sans-serif&apos;</c-><c- p>;</c->
   context<c- p>.</c->textAlign <c- o>=</c-> <c- t>&apos;left&apos;</c-><c- p>;</c->
   context<c- p>.</c->textBaseline <c- o>=</c-> <c- t>&apos;middle&apos;</c-><c- p>;</c->
   <c- a>var</c-> metrics <c- o>=</c-> context<c- p>.</c->measureText<c- p>(</c->element<c- p>.</c->labels<c- p>[</c-><c- mi>0</c-><c- p>].</c->textContent<c- p>);</c->
   <c- k>if</c-> <c- p>(</c->paint<c- p>)</c-> <c- p>{</c->
<strong>     context<c- p>.</c->beginPath<c- p>();</c->
     context<c- p>.</c->strokeStyle <c- o>=</c-> <c- t>&apos;black&apos;</c-><c- p>;</c->
     context<c- p>.</c->rect<c- p>(</c->x<c- o>-</c-><c- mi>5</c-><c- p>,</c-> y<c- o>-</c-><c- mi>5</c-><c- p>,</c-> <c- mi>10</c-><c- p>,</c-> <c- mi>10</c-><c- p>);</c->
     context<c- p>.</c->stroke<c- p>();</c->
</strong>     <c- k>if</c-> <c- p>(</c->element<c- p>.</c->checked<c- p>)</c-> <c- p>{</c->
<strong>       context<c- p>.</c->fillStyle <c- o>=</c-> <c- t>&apos;black&apos;</c-><c- p>;</c->
       context<c- p>.</c->fill<c- p>();</c->
</strong>     <c- p>}</c->
     context<c- p>.</c->fillText<c- p>(</c->element<c- p>.</c->labels<c- p>[</c-><c- mi>0</c-><c- p>].</c->textContent<c- p>,</c-> x<c- o>+</c-><c- mi>5</c-><c- p>,</c-> y<c- p>);</c->
   <c- p>}</c->
<strong>   context<c- p>.</c->beginPath<c- p>();</c->
   context<c- p>.</c->rect<c- p>(</c->x<c- o>-</c-><c- mi>7</c-><c- p>,</c-> y<c- o>-</c-><c- mi>7</c-><c- p>,</c-> <c- mi>12</c-> <c- o>+</c-> metrics<c- p>.</c->width<c- o>+</c-><c- mi>2</c-><c- p>,</c-> <c- mi>14</c-><c- p>);</c->
</strong>
   context<c- p>.</c->drawFocusIfNeeded<c- p>(</c->element<c- p>);</c->
   context<c- p>.</c->restore<c- p>();</c->
 <c- p>}</c->
 <c- a>function</c-> drawBase<c- p>()</c-> <c- p>{</c-> <c- d>/* ... */</c-> <c- p>}</c->
 <c- a>function</c-> drawAs<c- p>()</c-> <c- p>{</c-> <c- d>/* ... */</c-> <c- p>}</c->
 <c- a>function</c-> drawBs<c- p>()</c-> <c- p>{</c-> <c- d>/* ... */</c-> <c- p>}</c->
 <c- a>function</c-> redraw<c- p>()</c-> <c- p>{</c->
   <c- a>var</c-> canvas <c- o>=</c-> document<c- p>.</c->getElementsByTagName<c- p>(</c-><c- t>&apos;canvas&apos;</c-><c- p>)[</c-><c- mi>0</c-><c- p>];</c->
   <c- a>var</c-> context <c- o>=</c-> canvas<c- p>.</c->getContext<c- p>(</c-><c- t>&apos;2d&apos;</c-><c- p>);</c->
   context<c- p>.</c->clearRect<c- p>(</c-><c- mi>0</c-><c- p>,</c-> <c- mi>0</c-><c- p>,</c-> canvas<c- p>.</c->width<c- p>,</c-> canvas<c- p>.</c->height<c- p>);</c->
   drawCheckbox<c- p>(</c->context<c- p>,</c-> document<c- p>.</c->getElementById<c- p>(</c-><c- t>&apos;showA&apos;</c-><c- p>),</c-> <c- mi>20</c-><c- p>,</c-> <c- mi>40</c-><c- p>,</c-> <c- kc>true</c-><c- p>);</c->
   drawCheckbox<c- p>(</c->context<c- p>,</c-> document<c- p>.</c->getElementById<c- p>(</c-><c- t>&apos;showB&apos;</c-><c- p>),</c-> <c- mi>20</c-><c- p>,</c-> <c- mi>60</c-><c- p>,</c-> <c- kc>true</c-><c- p>);</c->
   drawBase<c- p>();</c->
   <c- k>if</c-> <c- p>(</c->document<c- p>.</c->getElementById<c- p>(</c-><c- t>&apos;showA&apos;</c-><c- p>).</c->checked<c- p>)</c->
     drawAs<c- p>();</c->
   <c- k>if</c-> <c- p>(</c->document<c- p>.</c->getElementById<c- p>(</c-><c- t>&apos;showB&apos;</c-><c- p>).</c->checked<c- p>)</c->
     drawBs<c- p>();</c->
 <c- p>}</c->
 <c- a>function</c-> processClick<c- p>(</c->event<c- p>)</c-> <c- p>{</c->
   <c- a>var</c-> canvas <c- o>=</c-> document<c- p>.</c->getElementsByTagName<c- p>(</c-><c- t>&apos;canvas&apos;</c-><c- p>)[</c-><c- mi>0</c-><c- p>];</c->
   <c- a>var</c-> context <c- o>=</c-> canvas<c- p>.</c->getContext<c- p>(</c-><c- t>&apos;2d&apos;</c-><c- p>);</c->
   <c- a>var</c-> x <c- o>=</c-> event<c- p>.</c->clientX<c- p>;</c->
   <c- a>var</c-> y <c- o>=</c-> event<c- p>.</c->clientY<c- p>;</c->
   <c- a>var</c-> node <c- o>=</c-> event<c- p>.</c->target<c- p>;</c->
   <c- k>while</c-> <c- p>(</c->node<c- p>)</c-> <c- p>{</c->
     x <c- o>-=</c-> node<c- p>.</c->offsetLeft <c- o>-</c-> node<c- p>.</c->scrollLeft<c- p>;</c->
     y <c- o>-=</c-> node<c- p>.</c->offsetTop <c- o>-</c-> node<c- p>.</c->scrollTop<c- p>;</c->
     node <c- o>=</c-> node<c- p>.</c->offsetParent<c- p>;</c->
   <c- p>}</c->
   drawCheckbox<c- p>(</c->context<c- p>,</c-> document<c- p>.</c->getElementById<c- p>(</c-><c- t>&apos;showA&apos;</c-><c- p>),</c-> <c- mi>20</c-><c- p>,</c-> <c- mi>40</c-><c- p>,</c-> <c- kc>false</c-><c- p>);</c->
   <c- k>if</c-> <c- p>(</c-><strong>context<c- p>.</c->isPointInPath<c- p>(</c->x<c- p>,</c-> y<c- p>)</c-></strong><c- p>)</c->
     document<c- p>.</c->getElementById<c- p>(</c-><c- t>&apos;showA&apos;</c-><c- p>).</c->checked <c- o>=</c-> <c- o>!</c-><c- p>(</c->document<c- p>.</c->getElementById<c- p>(</c-><c- t>&apos;showA&apos;</c-><c- p>).</c->checked<c- p>);</c->
   drawCheckbox<c- p>(</c->context<c- p>,</c-> document<c- p>.</c->getElementById<c- p>(</c-><c- t>&apos;showB&apos;</c-><c- p>),</c-> <c- mi>20</c-><c- p>,</c-> <c- mi>60</c-><c- p>,</c-> <c- kc>false</c-><c- p>);</c->
   <c- k>if</c-> <c- p>(</c-><strong>context<c- p>.</c->isPointInPath<c- p>(</c->x<c- p>,</c-> y<c- p>)</c-></strong><c- p>)</c->
     document<c- p>.</c->getElementById<c- p>(</c-><c- t>&apos;showB&apos;</c-><c- p>).</c->checked <c- o>=</c-> <c- o>!</c-><c- p>(</c->document<c- p>.</c->getElementById<c- p>(</c-><c- t>&apos;showB&apos;</c-><c- p>).</c->checked<c- p>);</c->
   redraw<c- p>();</c->
 <c- p>}</c->
 document<c- p>.</c->getElementsByTagName<c- p>(</c-><c- t>&apos;canvas&apos;</c-><c- p>)[</c-><c- mi>0</c-><c- p>].</c->addEventListener<c- p>(</c-><c- t>&apos;focus&apos;</c-><c- p>,</c-> redraw<c- p>,</c-> <c- kc>true</c-><c- p>);</c->
 document<c- p>.</c->getElementsByTagName<c- p>(</c-><c- t>&apos;canvas&apos;</c-><c- p>)[</c-><c- mi>0</c-><c- p>].</c->addEventListener<c- p>(</c-><c- t>&apos;blur&apos;</c-><c- p>,</c-> redraw<c- p>,</c-> <c- kc>true</c-><c- p>);</c->
 document<c- p>.</c->getElementsByTagName<c- p>(</c-><c- t>&apos;canvas&apos;</c-><c- p>)[</c-><c- mi>0</c-><c- p>].</c->addEventListener<c- p>(</c-><c- t>&apos;change&apos;</c-><c- p>,</c-> redraw<c- p>,</c-> <c- kc>true</c-><c- p>);</c->
 document<c- p>.</c->getElementsByTagName<c- p>(</c-><c- t>&apos;canvas&apos;</c-><c- p>)[</c-><c- mi>0</c-><c- p>].</c->addEventListener<c- p>(</c-><c- t>&apos;click&apos;</c-><c- p>,</c-> processClick<c- p>,</c-> <c- kc>false</c-><c- p>);</c->
 redraw<c- p>();</c->
<c- p>&lt;/</c-><c- f>script</c-><c- p>&gt;</c-></code></pre>


  </div>

  <h6 id=drawing-focus-rings-and-scrolling-paths-into-view><span class=secno>4.12.5.1.13</span> Drawing focus rings and scrolling paths into view<a href=#drawing-focus-rings-and-scrolling-paths-into-view class=self-link></a></h6>

  <dl class=domintro><dt><var>context</var> . <code id=dom-context-2d-drawfocusifneeded-dev><a href=#dom-context-2d-drawfocusifneeded>drawFocusIfNeeded</a></code>(<var>element</var>)<dt><var>context</var> . <code id=drawing-focus-rings-and-scrolling-paths-into-view:dom-context-2d-drawfocusifneeded><a href=#dom-context-2d-drawfocusifneeded>drawFocusIfNeeded</a></code>(<var>path</var>, <var>element</var>)<dd>
    <p>If the given element is <a id=drawing-focus-rings-and-scrolling-paths-into-view:focused href=interaction.html#focused>focused</a>, draws a focus ring around the <a href=#current-default-path id=drawing-focus-rings-and-scrolling-paths-into-view:current-default-path>current
    default path</a> or the given path, following the platform conventions for focus rings.</p>
   <dt><var>context</var> . <code id=dom-context-2d-scrollpathintoview-dev><a href=#dom-context-2d-scrollpathintoview>scrollPathIntoView</a></code>()<dt><var>context</var> . <code id=drawing-focus-rings-and-scrolling-paths-into-view:dom-context-2d-scrollpathintoview><a href=#dom-context-2d-scrollpathintoview>scrollPathIntoView</a></code>(<var>path</var>)<dd>
    <p>Scrolls the <a href=#current-default-path id=drawing-focus-rings-and-scrolling-paths-into-view:current-default-path-2>current default path</a> or the given path into view. This is especially
    useful on devices with small screens, where the whole canvas might not be visible at once.</p>
   </dl>

  

  Objects that implement the <code id=drawing-focus-rings-and-scrolling-paths-into-view:canvasuserinterface><a href=#canvasuserinterface>CanvasUserInterface</a></code> interface provide the following
  methods to control drawing focus rings and scrolling paths into view.

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/drawFocusIfNeeded title="The CanvasRenderingContext2D.drawFocusIfNeeded() method of the Canvas 2D API draws a focus ring around the current or given path, if the specified element is focused.">CanvasRenderingContext2D/drawFocusIfNeeded</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>32+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>14+</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>32+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p id=dom-context-2d-drawosfocusring>The <dfn id=dom-context-2d-drawfocusifneeded><code>drawFocusIfNeeded(<var>element</var>)</code></dfn>
  method, when invoked, must run these steps:</p>

  <ol><li><p>If <var>element</var> is not <a id=drawing-focus-rings-and-scrolling-paths-into-view:focused-2 href=interaction.html#focused>focused</a> or is not a descendant of the element with
   whose context the method is associated, then return.<li>
    <p>Draw a focus ring of the appropriate style along the intended path, following platform
    conventions.</p>

    <p class=note>Some platforms only draw focus rings around elements that have been focused from
    the keyboard, and not those focused from the mouse. Other platforms simply don't draw focus
    rings around some elements at all unless relevant accessibility features are enabled. This API
    is intended to follow these conventions. User agents that implement distinctions based on the
    manner in which the element was focused are encouraged to classify focus driven by the <code id=drawing-focus-rings-and-scrolling-paths-into-view:dom-focus><a href=interaction.html#dom-focus>focus()</a></code> method based on the kind of user interaction event from which
    the call was triggered (if any).</p>

    <p>The focus ring should not be subject to the <a href=#shadows id=drawing-focus-rings-and-scrolling-paths-into-view:shadows>shadow effects</a>, the
    <a href=#dom-context-2d-globalalpha id=drawing-focus-rings-and-scrolling-paths-into-view:dom-context-2d-globalalpha>global alpha</a>, the <a href=#dom-context-2d-globalcompositeoperation id=drawing-focus-rings-and-scrolling-paths-into-view:dom-context-2d-globalcompositeoperation>global composition operators</a>, or any of
    the members in the <code id=drawing-focus-rings-and-scrolling-paths-into-view:canvasfillstrokestyles><a href=#canvasfillstrokestyles>CanvasFillStrokeStyles</a></code>, <code id=drawing-focus-rings-and-scrolling-paths-into-view:canvaspathdrawingstyles><a href=#canvaspathdrawingstyles>CanvasPathDrawingStyles</a></code>,
    <code id=drawing-focus-rings-and-scrolling-paths-into-view:canvastextdrawingstyles><a href=#canvastextdrawingstyles>CanvasTextDrawingStyles</a></code> interfaces, but <em>should</em> be subject to the
    <a href=#clipping-region id=drawing-focus-rings-and-scrolling-paths-into-view:clipping-region>clipping region</a>. (The effect of transformations is described above and varies based
    on which path is being used.)</p>
   <li><p><a href=#inform>Inform the user</a> that the focus is at the location given by the
   intended path. User agents may wait until the next time the <a id=drawing-focus-rings-and-scrolling-paths-into-view:event-loop href=webappapis.html#event-loop>event loop</a> reaches its
   <a id=drawing-focus-rings-and-scrolling-paths-into-view:update-the-rendering href=webappapis.html#update-the-rendering>update the rendering</a> step to optionally inform the user.</ol>

  <p>User agents should not implicitly close open subpaths in the intended path when drawing the
  focus ring.</p>

  <p class=note>This might be a moot point, however. For example, if the focus ring is drawn as an
  axis-aligned bounding rectangle around the points in the intended path, then whether the subpaths
  are closed or not has no effect. This specification intentionally does not specify precisely how
  focus rings are to be drawn: user agents are expected to honor their platform's native
  conventions.</p>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in one engine only." class=less-than-two-engines-flag>⚠</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/scrollPathIntoView title="The CanvasRenderingContext2D.scrollPathIntoView() method of the Canvas 2D API scrolls the current or given path into view. It is similar to Element.scrollIntoView().">CanvasRenderingContext2D/scrollPathIntoView</a><p class=less-than-two-engines-text>Support in one engine only.<div class=support><span class="firefox no"><span>Firefox</span><span>No</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span title="Requires setting a user preference or runtime flag.">🔰 Yes</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><p>The <dfn id=dom-context-2d-scrollpathintoview><code>scrollPathIntoView()</code></dfn>
  method, when invoked, must run these steps:</p>

  <ol><li><p>Let <var>specifiedRectangle</var> be the rectangle of the bounding box of the intended
   path.<li><p>Let <var>notionalChild</var> be a hypothetical element that is a rendered child of the
   <code id=drawing-focus-rings-and-scrolling-paths-into-view:the-canvas-element><a href=#the-canvas-element>canvas</a></code> element whose dimensions are those of <var>specifiedRectangle</var>.<li><p><a href=https://drafts.csswg.org/cssom-view/#scroll-an-element-into-view id=drawing-focus-rings-and-scrolling-paths-into-view:scroll-an-element-into-view data-x-internal=scroll-an-element-into-view>Scroll <var>notionalChild</var> into
   view</a> with <var>behavior</var> set to "auto", <var>block</var> set to "start", and
   <var>inline</var> set to "nearest".</p>

   <li><p>Optionally, <a href=#inform>inform the user</a> that the caret or selection (or both)
   cover <var>specifiedRectangle</var> of the canvas. The user agent may wait until the next time
   the <a id=drawing-focus-rings-and-scrolling-paths-into-view:event-loop-2 href=webappapis.html#event-loop>event loop</a> reaches its <a id=drawing-focus-rings-and-scrolling-paths-into-view:update-the-rendering-2 href=webappapis.html#update-the-rendering>update the rendering</a> step to optionally
   inform the user.</ol>

  <p id=inform>"Inform the user", as used in this section, does not imply any persistent state
  change. It could mean, for instance, calling a system accessibility API to notify assistive
  technologies such as magnification tools so that the user's magnifier moves to the given area of
  the canvas. However, it does not associate the path with the element, or provide a region for
  tactile feedback, etc.</p>

  

  <h6 id=drawing-images><span class=secno>4.12.5.1.14</span> Drawing images<a href=#drawing-images class=self-link></a></h6>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/drawImage title="The CanvasRenderingContext2D.drawImage() method of the Canvas 2D API provides different ways to draw an image onto the canvas.">CanvasRenderingContext2D/drawImage</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>2+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside><p>Objects that implement the <code id=drawing-images:canvasdrawimage><a href=#canvasdrawimage>CanvasDrawImage</a></code> interface have the <dfn id=dom-context-2d-drawimage><code>drawImage</code></dfn> method to draw images.</p>

  

  <p>This method can be invoked with three different sets of arguments:</p>

  <ul class=brief><li><code>drawImage(<var>image</var>, <var>dx</var>, <var>dy</var>)</code>
   <li><code>drawImage(<var>image</var>, <var>dx</var>, <var>dy</var>, <var>dw</var>, <var>dh</var>)</code>
   <li><code>drawImage(<var>image</var>, <var>sx</var>, <var>sy</var>, <var>sw</var>, <var>sh</var>, <var>dx</var>, <var>dy</var>, <var>dw</var>, <var>dh</var>)</code>
  </ul>

  

  <dl class=domintro><dt><var>context</var> . <code id=dom-context-2d-drawimage-dev><a href=#dom-context-2d-drawimage>drawImage</a></code>(<var>image</var>, <var>dx</var>, <var>dy</var>)<dt><var>context</var> . <code id=drawing-images:dom-context-2d-drawimage><a href=#dom-context-2d-drawimage>drawImage</a></code>(<var>image</var>, <var>dx</var>, <var>dy</var>, <var>dw</var>, <var>dh</var>)<dt><var>context</var> . <code id=drawing-images:dom-context-2d-drawimage-2><a href=#dom-context-2d-drawimage>drawImage</a></code>(<var>image</var>, <var>sx</var>, <var>sy</var>, <var>sw</var>, <var>sh</var>, <var>dx</var>, <var>dy</var>, <var>dw</var>, <var>dh</var>)<dd>
    <p>Draws the given image onto the canvas. The arguments are
    interpreted as follows:</p>

    <p><img src=/images/drawImage.png width=356 alt="The sx and sy parameters give the x and y coordinates of the source rectangle; the sw and sh arguments give the width and height of the source rectangle; the dx and dy give the x and y coordinates of the destination rectangle; and the dw and dh arguments give the width and height of the destination rectangle." height=356></p>

    <p>If the image isn't yet fully decoded, then nothing is drawn. If the image is a canvas with no
    data, throws an <a id=drawing-images:invalidstateerror href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=drawing-images:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.</p>
   </dl>

  

  <p>When the <code id=drawing-images:dom-context-2d-drawimage-3><a href=#dom-context-2d-drawimage>drawImage()</a></code> method is invoked, the user
  agent must run these steps:</p>

  <ol><li><p>If any of the arguments are infinite or NaN, then return.<li><p>Let <var>usability</var> be the result of <a href=#check-the-usability-of-the-image-argument id=drawing-images:check-the-usability-of-the-image-argument>checking the usability of <var>image</var></a>.<li><p>If <var>usability</var> is <i>bad</i>, then return (without drawing anything).<li>
    <p>Establish the source and destination rectangles as follows:</p>

    <p>If not specified, the <var>dw</var> and <var>dh</var> arguments must default to the values of
    <var>sw</var> and <var>sh</var>, interpreted such that one <a href=https://drafts.csswg.org/css-values/#px id="drawing-images:'px'" data-x-internal="'px'">CSS pixel</a>
    in the image is treated as one unit in the <a href=#output-bitmap id=drawing-images:output-bitmap>output bitmap</a>'s coordinate space. If the
    <var>sx</var>, <var>sy</var>, <var>sw</var>, and <var>sh</var> arguments are omitted, then they
    must default to 0, 0, the image's <a id=drawing-images:intrinsic-width href=https://drafts.csswg.org/css-images/#intrinsic-width data-x-internal=intrinsic-width>intrinsic width</a> in image pixels, and the image's
    <a id=drawing-images:intrinsic-height href=https://drafts.csswg.org/css-images/#intrinsic-height data-x-internal=intrinsic-height>intrinsic height</a> in image pixels, respectively. If the image has no <a id=drawing-images:intrinsic-dimensions href=https://drafts.csswg.org/css-images/#intrinsic-dimensions data-x-internal=intrinsic-dimensions>intrinsic
    dimensions</a>, then the <i>concrete object size</i> must be used instead, as determined
    using the CSS "<a href=https://drafts.csswg.org/css-images/#default-sizing>Concrete Object
    Size Resolution</a>" algorithm, with the <i>specified size</i> having neither a definite width
    nor height, nor any additional constraints, the object's intrinsic properties being those of the
    <var>image</var> argument, and the <a id=drawing-images:default-object-size href=https://drafts.csswg.org/css-images/#default-object-size data-x-internal=default-object-size>default object size</a> being the size of the
    <a href=#output-bitmap id=drawing-images:output-bitmap-2>output bitmap</a>. <a href=references.html#refsCSSIMAGES>[CSSIMAGES]</a></p>

    <p>The source rectangle is the rectangle whose corners are the four points (<var>sx</var>, <var>sy</var>), (<var>sx</var>+<var>sw</var>, <var>sy</var>), (<var>sx</var>+<var>sw</var>, <var>sy</var>+<var>sh</var>),
    (<var>sx</var>, <var>sy</var>+<var>sh</var>).</p>

    <p>The destination rectangle is the rectangle whose corners are the four points (<var>dx</var>, <var>dy</var>), (<var>dx</var>+<var>dw</var>, <var>dy</var>), (<var>dx</var>+<var>dw</var>, <var>dy</var>+<var>dh</var>),
    (<var>dx</var>, <var>dy</var>+<var>dh</var>).</p>

    <p>When the source rectangle is outside the source image, the source rectangle must be clipped
    to the source image and the destination rectangle must be clipped in the same proportion.</p>

    <p class=note>When the destination rectangle is outside the destination image (the
    <a href=#output-bitmap id=drawing-images:output-bitmap-3>output bitmap</a>), the pixels that land outside the <a href=#output-bitmap id=drawing-images:output-bitmap-4>output bitmap</a> are
    discarded, as if the destination was an infinite canvas whose rendering was clipped to the
    dimensions of the <a href=#output-bitmap id=drawing-images:output-bitmap-5>output bitmap</a>.</p>
   <li><p>If one of the <var>sw</var> or <var>sh</var> arguments is zero, then return. Nothing is
   painted.<li>
    <p>Paint the region of the <var>image</var> argument specified by the source rectangle
    on the region of the rendering context's <a href=#output-bitmap id=drawing-images:output-bitmap-6>output bitmap</a> specified by the
    destination rectangle, after applying the <a href=#transformations id=drawing-images:transformations>current
    transformation matrix</a> to the destination rectangle.</p>

    <p>The image data must be processed in the original direction, even if the dimensions given are
    negative. </p>

    <p>When scaling up, if the <code id=drawing-images:dom-context-2d-imagesmoothingenabled><a href=#dom-context-2d-imagesmoothingenabled>imageSmoothingEnabled</a></code> attribute is set to
    true, the user agent should attempt to apply a smoothing algorithm to the image data when it is
    scaled. User agents which support multiple filtering algorithms may use the value of the <code id=drawing-images:dom-context-2d-imagesmoothingquality><a href=#dom-context-2d-imagesmoothingquality>imageSmoothingQuality</a></code> attribute to guide
    the choice of filtering algorithm when the <code id=drawing-images:dom-context-2d-imagesmoothingenabled-2><a href=#dom-context-2d-imagesmoothingenabled>imageSmoothingEnabled</a></code> attribute is set to
    true. Otherwise, the image must be rendered using nearest-neighbor interpolation.</p>

    <p class=note>This specification does not define the precise algorithm to use when scaling an
    image down, or when scaling an image up when the <code id=drawing-images:dom-context-2d-imagesmoothingenabled-3><a href=#dom-context-2d-imagesmoothingenabled>imageSmoothingEnabled</a></code> attribute is set to
    true.</p>

    <p class=note>When a <code id=drawing-images:the-canvas-element><a href=#the-canvas-element>canvas</a></code> element is drawn onto itself, the <a href=#drawing-model id=drawing-images:drawing-model>drawing
    model</a> requires the source to be copied before the image is drawn, so it is possible to
    copy parts of a <code id=drawing-images:the-canvas-element-2><a href=#the-canvas-element>canvas</a></code> element onto overlapping parts of itself.</p>

    <p>If the original image data is a bitmap image, then the value painted at a point in the
    destination rectangle is computed by filtering the original image data. The user agent may use
    any filtering algorithm (for example bilinear interpolation or nearest-neighbor). When the
    filtering algorithm requires a pixel value from outside the original image data, it must instead
    use the value from the nearest edge pixel. (That is, the filter uses 'clamp-to-edge' behavior.)
    When the filtering algorithm requires a pixel value from outside the source rectangle but inside
    the original image data, then the value from the original image data must be used.</p>
    
    

    <p class=note>Thus, scaling an image in parts or in whole will have the same effect. This does
    mean that when sprites coming from a single sprite sheet are to be scaled, adjacent images in
    the sprite sheet can interfere. This can be avoided by ensuring each sprite in the sheet is
    surrounded by a border of <a id=drawing-images:transparent-black href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a>, or by copying sprites to be scaled
    into temporary <code id=drawing-images:the-canvas-element-3><a href=#the-canvas-element>canvas</a></code> elements and drawing the scaled sprites from there.</p>

    <p>Images are painted without affecting the current path, and are subject to <a href=#shadows id=drawing-images:shadows>shadow effects</a>, <a href=#dom-context-2d-globalalpha id=drawing-images:dom-context-2d-globalalpha>global
    alpha</a>, the <a href=#clipping-region id=drawing-images:clipping-region>clipping region</a>, and <a href=#dom-context-2d-globalcompositeoperation id=drawing-images:dom-context-2d-globalcompositeoperation>global composition operators</a>.</p>
   <li><p>If <var>image</var> <a href=#the-image-argument-is-not-origin-clean id=drawing-images:the-image-argument-is-not-origin-clean>is not origin-clean</a>, then set the
   <code id=drawing-images:canvasrenderingcontext2d><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code>'s <a href=#concept-canvas-origin-clean id=drawing-images:concept-canvas-origin-clean>origin-clean</a> flag to false.</ol>

  


  <h6 id=pixel-manipulation><span class=secno>4.12.5.1.15</span> <dfn>Pixel manipulation</dfn><a href=#pixel-manipulation class=self-link></a></h6>

  <dl class=domintro><dt><var>imagedata</var> = new <code id=dom-imagedata-dev><a href=#dom-imagedata>ImageData</a></code>(<var>sw</var>, <var>sh</var>)<dt><var>imagedata</var> = <var>context</var> . <code id=dom-context-2d-createimagedata-dev><a href=#dom-context-2d-createimagedata>createImageData</a></code>(<var>sw</var>, <var>sh</var>)<dd>
    <p>Returns an <code id=pixel-manipulation:imagedata><a href=#imagedata>ImageData</a></code> object with the given dimensions. All the pixels in the
    returned object are <a id=pixel-manipulation:transparent-black href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a>.</p>

    <p>Throws an <a id=pixel-manipulation:indexsizeerror href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a> <code id=pixel-manipulation:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code> if either of
    the width or height arguments are zero.</p>
   <dt><var>imagedata</var> = <var>context</var> . <code id=pixel-manipulation:dom-context-2d-createimagedata><a href=#dom-context-2d-createimagedata>createImageData</a></code>(<var>imagedata</var>)<dd><p>Returns an <code id=pixel-manipulation:imagedata-2><a href=#imagedata>ImageData</a></code> object with the same dimensions as the argument. All the
   pixels in the returned object are <a id=pixel-manipulation:transparent-black-2 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a>.<dt><var>imagedata</var> = new <code id=pixel-manipulation:dom-imagedata><a href=#dom-imagedata>ImageData</a></code>(<var>data</var>, <var>sw</var> [, <var>sh</var> ] )<dd>
    <p>Returns an <code id=pixel-manipulation:imagedata-3><a href=#imagedata>ImageData</a></code> object using the data provided in the <code id=pixel-manipulation:idl-uint8clampedarray><a data-x-internal=idl-uint8clampedarray href=https://heycam.github.io/webidl/#idl-Uint8ClampedArray>Uint8ClampedArray</a></code> argument, interpreted using the given
    dimensions.</p>

    <p>As each pixel in the data is represented by four numbers, the length of the data needs to be
    a multiple of four times the given width. If the height is provided as well, then the length
    needs to be exactly the width times the height times 4.</p>

    <p>Throws an <a id=pixel-manipulation:indexsizeerror-2 href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a> <code id=pixel-manipulation:domexception-2><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code> if the given
    data and dimensions can't be interpreted consistently, or if either dimension is zero.</p>
   <dt><var>imagedata</var> = <var>context</var> . <code id=dom-context-2d-getimagedata-dev><a href=#dom-context-2d-getimagedata>getImageData</a></code>(<var>sx</var>, <var>sy</var>, <var>sw</var>, <var>sh</var>)<dd>
    <p>Returns an <code id=pixel-manipulation:imagedata-4><a href=#imagedata>ImageData</a></code> object containing the image data for the given rectangle of
    the bitmap.</p>

    <p>Throws an <a id=pixel-manipulation:indexsizeerror-3 href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a> <code id=pixel-manipulation:domexception-3><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code> if the either
    of the width or height arguments are zero.</p>
   <dt><var>imagedata</var> . <code id=dom-imagedata-width-dev><a href=#dom-imagedata-width>width</a></code><dt><var>imagedata</var> . <code id=dom-imagedata-height-dev><a href=#dom-imagedata-height>height</a></code><dd><p>Returns the actual dimensions of the data in the <code id=pixel-manipulation:imagedata-5><a href=#imagedata>ImageData</a></code> object, in
   pixels.<dt><var>imagedata</var> . <code id=dom-imagedata-data-dev><a href=#dom-imagedata-data>data</a></code><dd><p>Returns the one-dimensional array containing the data in RGBA order, as integers in the
   range 0 to 255.<dt><var>context</var> . <code id=dom-context-2d-putimagedata-dev><a href=#dom-context-2d-putimagedata>putImageData</a></code>(<var>imagedata</var>, <var>dx</var>, <var>dy</var> [, <var>dirtyX</var>, <var>dirtyY</var>, <var>dirtyWidth</var>, <var>dirtyHeight</var> ] )<dd>
    <p>Paints the data from the given <code id=pixel-manipulation:imagedata-6><a href=#imagedata>ImageData</a></code> object onto the bitmap. If a dirty
    rectangle is provided, only the pixels from that rectangle are painted.</p>

    <p>The <code id=pixel-manipulation:dom-context-2d-globalalpha><a href=#dom-context-2d-globalalpha>globalAlpha</a></code> and <code id=pixel-manipulation:dom-context-2d-globalcompositeoperation><a href=#dom-context-2d-globalcompositeoperation>globalCompositeOperation</a></code> attributes, as
    well as the shadow attributes, are ignored for the purposes of this method call; pixels in the
    canvas are replaced wholesale, with no composition, alpha blending, no shadows, etc.</p>

    <p>Throws an <a id=pixel-manipulation:invalidstateerror href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=pixel-manipulation:domexception-4><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code> if the
    <var>imagedata</var> object's <code id=pixel-manipulation:dom-imagedata-data><a href=#dom-imagedata-data>data</a></code> attribute value's
    [[ViewedArrayBuffer]] internal slot is detached.</p>
   </dl>

  

  <p>Objects that implement the <code id=pixel-manipulation:canvasimagedata><a href=#canvasimagedata>CanvasImageData</a></code> interface provide the following methods
  for reading and writing pixel data to the bitmap.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/ImageData/ImageData title="The ImageData() constructor returns a newly instantiated ImageData object built from the typed array given and having the specified width and height.">ImageData/ImageData</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>29+</span></span><span class="safari unknown"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>42+</span></span><hr><span class="opera yes"><span>Opera</span><span>29+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>29+</span></span><span class="safari_ios unknown"><span>Safari iOS</span><span>?</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>42+</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android unknown"><span>Opera Android</span><span>?</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/createImageData title="The CanvasRenderingContext2D.createImageData() method of the Canvas 2D API creates a new, blank ImageData object with the specified dimensions. All of the pixels in the new object are transparent black.">CanvasRenderingContext2D/createImageData</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>2+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-imagedata><code>ImageData()</code></dfn> constructors and the
  <dfn id=dom-context-2d-createimagedata><code>createImageData()</code></dfn> methods are
  used to instantiate new <code id=pixel-manipulation:imagedata-7><a href=#imagedata>ImageData</a></code> objects.</p>

  <p>When the <code id=pixel-manipulation:dom-imagedata-2><a href=#dom-imagedata>ImageData()</a></code> constructor is invoked with two
  numeric arguments <var>sw</var> and <var>sh</var>, it must run these steps:</p>

  <ol><li><p>If one or both of <var>sw</var> and <var>sh</var> are zero, then throw an
   <a id=pixel-manipulation:indexsizeerror-4 href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a> <code id=pixel-manipulation:domexception-5><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p><a href=#create-an-imagedata-object id=pixel-manipulation:create-an-imagedata-object>Create an <code>ImageData</code> object</a> with parameter
   <var>pixelsPerRow</var> set to <var>sw</var>, and <var>rows</var> set to <var>sh</var>.<li><p>Initialize the image data of the newly created <code id=pixel-manipulation:imagedata-8><a href=#imagedata>ImageData</a></code> object to
   <a id=pixel-manipulation:transparent-black-3 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a>.<li><p>Return the newly created <code id=pixel-manipulation:imagedata-9><a href=#imagedata>ImageData</a></code> object.</ol>

  <p>When the <code id=pixel-manipulation:dom-imagedata-3><a href=#dom-imagedata>ImageData()</a></code> constructor is invoked with its first
  argument being an <code id=pixel-manipulation:idl-uint8clampedarray-2><a data-x-internal=idl-uint8clampedarray href=https://heycam.github.io/webidl/#idl-Uint8ClampedArray>Uint8ClampedArray</a></code> <var>source</var>
  and its second and optional third arguments being numeric arguments <var>sw</var> and
  <var>sh</var>, it must run these steps:</p>

  <ol><li><p>Let <var>length</var> be the number of bytes in <var>source</var>.<li><p>If <var>length</var> is not a nonzero integral multiple of four, then throw an
   <a id=pixel-manipulation:invalidstateerror-2 href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=pixel-manipulation:domexception-6><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>length</var> be <var>length</var> divided by four.</p>

   <li>
    <p>If <var>length</var> is not an integral multiple of <var>sw</var>, then throw an
    <a id=pixel-manipulation:indexsizeerror-5 href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a> <code id=pixel-manipulation:domexception-7><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.</p>

    <p class=note>At this step, the length is guaranteed to be greater than zero (otherwise the
    second step above would have aborted the steps), so if <var>sw</var> is zero, this
    step will throw the exception and return.</p>
   <li><p>Let <var>height</var> be <var>length</var> divided by <var>sw</var>.<li><p>If the <var>sh</var> argument was not omitted, and its value is not equal to
   <var>height</var>, then throw an <a id=pixel-manipulation:indexsizeerror-6 href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a>
   <code id=pixel-manipulation:domexception-8><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li>
    <p><a href=#create-an-imagedata-object id=pixel-manipulation:create-an-imagedata-object-2>Create an <code>ImageData</code> object</a>, with parameter <var>pixelsPerRow</var>
    set to <var>sw</var>, <var>rows</var> set to <var>sh</var>, and using <var>source</var>.
    Return the newly created <code id=pixel-manipulation:imagedata-10><a href=#imagedata>ImageData</a></code> object.</p>

    <p class=note>The resulting object's data is not a <em>copy</em> of <var>source</var>, it's
    the actual <code id=pixel-manipulation:idl-uint8clampedarray-3><a data-x-internal=idl-uint8clampedarray href=https://heycam.github.io/webidl/#idl-Uint8ClampedArray>Uint8ClampedArray</a></code> object passed as the
    first argument to the constructor.</p>
   </ol>

  <p>When the <code id=pixel-manipulation:dom-context-2d-createimagedata-2><a href=#dom-context-2d-createimagedata>createImageData()</a></code> method is
  invoked with two numeric arguments <var>sw</var> and <var>sh</var>, it must <a href=#create-an-imagedata-object id=pixel-manipulation:create-an-imagedata-object-3>create an
  <code>ImageData</code> object</a>, with parameter <var>pixelsPerRow</var> set to the
  absolute magnitude of <var>sw</var>, and parameter <var>rows</var> set to the absolute magnitude
  of <var>sh</var>. Initialize the image data of the new <code id=pixel-manipulation:imagedata-11><a href=#imagedata>ImageData</a></code> object to
  <a id=pixel-manipulation:transparent-black-4 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a>. If both <var>sw</var> and <var>sh</var> are nonzero, then return
  the new <code id=pixel-manipulation:imagedata-12><a href=#imagedata>ImageData</a></code> object. If one or both of <var>sw</var> and <var>sh</var> are
  zero, then throw an <a id=pixel-manipulation:indexsizeerror-7 href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a> <code id=pixel-manipulation:domexception-9><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>
  instead.</p>

  <p>When the <code id=pixel-manipulation:dom-context-2d-createimagedata-3><a href=#dom-context-2d-createimagedata>createImageData()</a></code> method is
  invoked with a single <var>imagedata</var> argument, it must <a href=#create-an-imagedata-object id=pixel-manipulation:create-an-imagedata-object-4>create an
  <code>ImageData</code> object</a>, with parameter <var>pixelsPerRow</var> set to the value of
  the <code id=pixel-manipulation:dom-imagedata-width><a href=#dom-imagedata-width>width</a></code> attribute of the <code id=pixel-manipulation:imagedata-13><a href=#imagedata>ImageData</a></code>
  object passed as the argument, and the <var>rows</var> parameter set to the value of the
  <code id=pixel-manipulation:dom-imagedata-height><a href=#dom-imagedata-height>height</a></code> attribute.
  Initialize the image data of the new <code id=pixel-manipulation:imagedata-14><a href=#imagedata>ImageData</a></code> object to <a id=pixel-manipulation:transparent-black-5 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent
  black</a>. Return the newly created <code id=pixel-manipulation:imagedata-15><a href=#imagedata>ImageData</a></code> object.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/getImageData title="The CanvasRenderingContext2D method getImageData() of the Canvas 2D API returns an ImageData object representing the underlying pixel data for a specified portion of the canvas.">CanvasRenderingContext2D/getImageData</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>2+</span></span><span class="safari yes"><span>Safari</span><span>4+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>9.5+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>3.2+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside><p>The <dfn id=dom-context-2d-getimagedata><code>getImageData(<var>sx</var>,
  <var>sy</var>, <var>sw</var>, <var>sh</var>)</code></dfn> method, when invoked, must,
  if either the <var>sw</var> or <var>sh</var> arguments are zero, throw an
  <a id=pixel-manipulation:indexsizeerror-8 href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a> <code id=pixel-manipulation:domexception-10><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>; otherwise,
  
  if the <code id=pixel-manipulation:canvasrenderingcontext2d><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code>'s <a href=#concept-canvas-origin-clean id=pixel-manipulation:concept-canvas-origin-clean>origin-clean</a> flag is set to false, it must throw a
  <a id=pixel-manipulation:securityerror href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=pixel-manipulation:domexception-11><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>;
  
  otherwise, it must <a href=#create-an-imagedata-object id=pixel-manipulation:create-an-imagedata-object-5>create an <code>ImageData</code> object</a>, with parameter
  <var>pixelsPerRow</var> set to <var>sw</var>, and parameter <var>rows</var> set to <var>sh</var>.
  Set the pixel values of the image data of the newly created <code id=pixel-manipulation:imagedata-16><a href=#imagedata>ImageData</a></code> object to
  represent the <a href=#output-bitmap id=pixel-manipulation:output-bitmap>output bitmap</a> for the area of that bitmap denoted by the rectangle
  whose corners are the four points (<var>sx</var>, <var>sy</var>), (<span><var>sx</var>+<var>sw</var></span>, <var>sy</var>), (<span><var>sx</var>+<var>sw</var></span>, <span><var>sy</var>+<var>sh</var></span>), (<var>sx</var>,
  <var>sy</var>+<var>sh</var>), in the bitmap's coordinate space units.
  Pixels outside the <a href=#output-bitmap id=pixel-manipulation:output-bitmap-2>output bitmap</a> must be set to <a id=pixel-manipulation:transparent-black-6 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a>. Pixel
  values must not be premultiplied by alpha.</p>

  <p>When the user agent is required to <dfn id=create-an-imagedata-object>create an <code>ImageData</code> object</dfn>, given a
  positive integer number of rows <var>rows</var>, a positive integer number of pixels per row
  <var>pixelsPerRow</var>, and an optional <code id=pixel-manipulation:idl-uint8clampedarray-4><a data-x-internal=idl-uint8clampedarray href=https://heycam.github.io/webidl/#idl-Uint8ClampedArray>Uint8ClampedArray</a></code> <var>source</var>, it must run these
  steps:</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/ImageData/data title="The readonly ImageData.data property returns a Uint8ClampedArray that contains the ImageData object's pixel data. Data is stored as a one-dimensional array in the RGBA order, with integer values between 0 and 255 (inclusive).">ImageData/data</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>14+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>14+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/ImageData/width title="The readonly ImageData.width property returns the number of pixels per row in the ImageData object.">ImageData/width</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>14+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>14+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/ImageData/height title="The readonly ImageData.height property returns the number of rows in the ImageData object.">ImageData/height</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>14+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>14+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><ol><li><p>Let <var>imageData</var> be a new uninitialized <code id=pixel-manipulation:imagedata-17><a href=#imagedata>ImageData</a></code> object.<li><p>If <var>source</var> is specified, then assign the <dfn id=dom-imagedata-data><code>data</code></dfn> attribute of <var>imageData</var> to
   <var>source</var>.<li>
    <p>If <var>source</var> is not specified, then initialize the <code id=pixel-manipulation:dom-imagedata-data-2><a href=#dom-imagedata-data>data</a></code> attribute of <var>imageData</var> to a new <code id=pixel-manipulation:idl-uint8clampedarray-5><a data-x-internal=idl-uint8clampedarray href=https://heycam.github.io/webidl/#idl-Uint8ClampedArray>Uint8ClampedArray</a></code> object. The <code id=pixel-manipulation:idl-uint8clampedarray-6><a data-x-internal=idl-uint8clampedarray href=https://heycam.github.io/webidl/#idl-Uint8ClampedArray>Uint8ClampedArray</a></code> object must use a new <a href=#canvas-pixel-arraybuffer id=pixel-manipulation:canvas-pixel-arraybuffer>Canvas
    Pixel <code>ArrayBuffer</code></a> for its storage, and must have a
    zero start offset and a length equal to the length of its storage, in bytes. The <a href=#canvas-pixel-arraybuffer id=pixel-manipulation:canvas-pixel-arraybuffer-2>Canvas
    Pixel <code>ArrayBuffer</code></a> must have the correct size to
    store <var>rows</var> × <var>pixelsPerRow</var> pixels.</p>

    <p>If the <a href=#canvas-pixel-arraybuffer id=pixel-manipulation:canvas-pixel-arraybuffer-3>Canvas Pixel <code>ArrayBuffer</code></a> cannot be
    allocated, then rethrow the <code id=pixel-manipulation:js-rangeerror><a data-x-internal=js-rangeerror href=https://tc39.es/ecma262/#sec-native-error-types-used-in-this-standard-rangeerror>RangeError</a></code> thrown by JavaScript,
    and return.</p>
   <li><p>Initialize the <dfn id=dom-imagedata-width><code>width</code></dfn> attribute of
   <var>imageData</var> to <var>pixelsPerRow</var>.<li><p>Initialize the <dfn id=dom-imagedata-height><code>height</code></dfn> attribute of
   <var>imageData</var> to <var>rows</var>.<li><p>Return <var>imageData</var>.</ol>

  <p><code id=pixel-manipulation:imagedata-18><a href=#imagedata>ImageData</a></code> objects are <a id=pixel-manipulation:serializable-objects href=structured-data.html#serializable-objects>serializable objects</a>. Their <a id=pixel-manipulation:serialization-steps href=structured-data.html#serialization-steps>serialization
  steps</a>, given <var>value</var> and <var>serialized</var>, are:</p>

  <ol><li><p>Set <var>serialized</var>.[[Data]] to the <a id=pixel-manipulation:sub-serialization href=structured-data.html#sub-serialization>sub-serialization</a> of the value of
   <var>value</var>'s <code id=pixel-manipulation:dom-imagedata-data-3><a href=#dom-imagedata-data>data</a></code> attribute.<li><p>Set <var>serialized</var>.[[Width]] to the value of <var>value</var>'s <code id=pixel-manipulation:dom-imagedata-width-2><a href=#dom-imagedata-width>width</a></code> attribute.<li><p>Set <var>serialized</var>.[[Height]] to the value of <var>value</var>'s <code id=pixel-manipulation:dom-imagedata-height-2><a href=#dom-imagedata-height>height</a></code> attribute.</ol>

  <p>Their <a id=pixel-manipulation:deserialization-steps href=structured-data.html#deserialization-steps>deserialization steps</a>, given <var>serialized</var> and <var>value</var>,
  are:</p>

  <ol><li><p>Initialize <var>value</var>'s <code id=pixel-manipulation:dom-imagedata-data-4><a href=#dom-imagedata-data>data</a></code> attribute
   to the <a id=pixel-manipulation:sub-deserialization href=structured-data.html#sub-deserialization>sub-deserialization</a> of <var>serialized</var>.[[Data]].<li><p>Initialize <var>value</var>'s <code id=pixel-manipulation:dom-imagedata-width-3><a href=#dom-imagedata-width>width</a></code> attribute
   to <var>serialized</var>.[[Width]].<li><p>Initialize <var>value</var>'s <code id=pixel-manipulation:dom-imagedata-height-3><a href=#dom-imagedata-height>height</a></code> attribute
   to <var>serialized</var>.[[Height]].</ol>

  <p>A <dfn id=canvas-pixel-arraybuffer>Canvas Pixel <code>ArrayBuffer</code></dfn> is an <code id=pixel-manipulation:idl-arraybuffer><a data-x-internal=idl-arraybuffer href=https://heycam.github.io/webidl/#idl-ArrayBuffer>ArrayBuffer</a></code> whose data is represented in left-to-right order, row
  by row top to bottom, starting with the top left, with each pixel's red, green, blue, and alpha
  components being given in that order for each pixel. Each component of each pixel represented in
  this array must be in the range 0..255, representing the 8 bit value for that component. The
  components must be assigned consecutive indices starting with 0 for the top left pixel's red
  component.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/putImageData title="The CanvasRenderingContext2D.putImageData() method of the Canvas 2D API paints data from the given ImageData object onto the canvas. If a dirty rectangle is provided, only the pixels from that rectangle are painted. This method is not affected by the canvas transformation matrix.">CanvasRenderingContext2D/putImageData</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>2+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-putimagedata><code>putImageData()</code></dfn> method writes
  data from <code id=pixel-manipulation:imagedata-19><a href=#imagedata>ImageData</a></code> structures back to the rendering context's <a href=#output-bitmap id=pixel-manipulation:output-bitmap-3>output
  bitmap</a>. Its arguments are: <var>imagedata</var>, <var>dx</var>, <var>dy</var>,
  <var>dirtyX</var>, <var>dirtyY</var>, <var>dirtyWidth</var>, and <var>dirtyHeight</var>.</p>

  <p>When the last four arguments to this method are omitted, they must be assumed to have the
  values 0, 0, the <code id=pixel-manipulation:dom-imagedata-width-4><a href=#dom-imagedata-width>width</a></code> member of the <var>imagedata</var> structure, and the <code id=pixel-manipulation:dom-imagedata-height-4><a href=#dom-imagedata-height>height</a></code>
  member of the <var>imagedata</var> structure, respectively.</p>

  <p>The method, when invoked, must act as follows:</p>

  <ol><li><p>Let <var>buffer</var> be <var>imagedata</var>'s <code id=pixel-manipulation:dom-imagedata-data-5><a href=#dom-imagedata-data>data</a></code> attribute value's [[ViewedArrayBuffer]] internal
   slot.<li><p>If <a id=pixel-manipulation:isdetachedbuffer href=https://tc39.es/ecma262/#sec-isdetachedbuffer data-x-internal=isdetachedbuffer>IsDetachedBuffer</a>(<var>buffer</var>) is true, then throw an
   <a id=pixel-manipulation:invalidstateerror-3 href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=pixel-manipulation:domexception-12><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li>
    <p>If <var>dirtyWidth</var> is negative, then let <var>dirtyX</var> be <span><var>dirtyX</var>+<var>dirtyWidth</var></span>, and let <var>dirtyWidth</var> be equal
    to the absolute magnitude of <var>dirtyWidth</var>.</p>

    <p>If <var>dirtyHeight</var> is negative, then let <var>dirtyY</var> be <span><var>dirtyY</var>+<var>dirtyHeight</var></span>, and let <var>dirtyHeight</var> be
    equal to the absolute magnitude of <var>dirtyHeight</var>.</p>
   <li>
    <p>If <var>dirtyX</var> is negative, then let <var>dirtyWidth</var> be <span><var>dirtyWidth</var>+<var>dirtyX</var></span>, and let <var>dirtyX</var> be zero.</p>

    <p>If <var>dirtyY</var> is negative, then let <var>dirtyHeight</var> be <span><var>dirtyHeight</var>+<var>dirtyY</var></span>, and let <var>dirtyY</var> be zero.</p>
   <li>
    <p>If <var>dirtyX</var>+<var>dirtyWidth</var> is greater than the <code id=pixel-manipulation:dom-imagedata-width-5><a href=#dom-imagedata-width>width</a></code> attribute of the <var>imagedata</var> argument, then
    let <var>dirtyWidth</var> be the value of that <code id=pixel-manipulation:dom-imagedata-width-6><a href=#dom-imagedata-width>width</a></code>
    attribute, minus the value of <var>dirtyX</var>.</p>

    <p>If <var>dirtyY</var>+<var>dirtyHeight</var> is greater than the <code id=pixel-manipulation:dom-imagedata-height-5><a href=#dom-imagedata-height>height</a></code> attribute of the <var>imagedata</var> argument, then
    let <var>dirtyHeight</var> be the value of that <code id=pixel-manipulation:dom-imagedata-height-6><a href=#dom-imagedata-height>height</a></code> attribute, minus the value of <var>dirtyY</var>.</p>
   <li>
    <p>If, after those changes, either <var>dirtyWidth</var> or <var>dirtyHeight</var> are negative
    or zero, then return without affecting any bitmaps.</p>
   <li><p>For all integer values of <var>x</var> and <var>y</var> where <span><var>dirtyX</var> ≤ <var>x</var> &lt; <span><var>dirtyX</var>+<var>dirtyWidth</var></span></span> and <span><var>dirtyY</var> ≤ <var>y</var> &lt; <span><var>dirtyY</var>+<var>dirtyHeight</var></span></span>, copy the
   four channels of the pixel with coordinate (<var>x</var>, <var>y</var>) in
   the <var>imagedata</var> data structure's <a href=#canvas-pixel-arraybuffer id=pixel-manipulation:canvas-pixel-arraybuffer-4>Canvas Pixel
   <code>ArrayBuffer</code></a> to the pixel with coordinate (<span><var>dx</var>+<var>x</var></span>, <var>dy</var>+<var>y</var>)
   in the rendering context's <a href=#output-bitmap id=pixel-manipulation:output-bitmap-4>output bitmap</a>.</ol>

  <p class=note>Due to the lossy nature of converting to and from premultiplied alpha color
  values, pixels that have just been set using <code id=pixel-manipulation:dom-context-2d-putimagedata><a href=#dom-context-2d-putimagedata>putImageData()</a></code> might be returned to an equivalent
  <code id=pixel-manipulation:dom-context-2d-getimagedata><a href=#dom-context-2d-getimagedata>getImageData()</a></code> as different values.</p>

  <p>The current path, <a href=#transformations id=pixel-manipulation:transformations>transformation matrix</a>,
  <a href=#shadows id=pixel-manipulation:shadows>shadow attributes</a>, <a href=#dom-context-2d-globalalpha id=pixel-manipulation:dom-context-2d-globalalpha-2>global
  alpha</a>, the <a href=#clipping-region id=pixel-manipulation:clipping-region>clipping region</a>, and <a href=#dom-context-2d-globalcompositeoperation id=pixel-manipulation:dom-context-2d-globalcompositeoperation-2>global composition operator</a> must not
  affect the methods described in this section.</p>

  

  <div class=example>

   <p>In the following example, the script generates an <code id=pixel-manipulation:imagedata-20><a href=#imagedata>ImageData</a></code> object so that it can
   draw onto it.</p>

   <pre><code class='js'><c- c1>// canvas is a reference to a &lt;canvas&gt; element</c->
<c- a>var</c-> context <c- o>=</c-> canvas<c- p>.</c->getContext<c- p>(</c-><c- t>&apos;2d&apos;</c-><c- p>);</c->

<c- c1>// create a blank slate</c->
<c- a>var</c-> data <c- o>=</c-> context<c- p>.</c->createImageData<c- p>(</c->canvas<c- p>.</c->width<c- p>,</c-> canvas<c- p>.</c->height<c- p>);</c->

<c- c1>// create some plasma</c->
FillPlasma<c- p>(</c->data<c- p>,</c-> <c- t>&apos;green&apos;</c-><c- p>);</c-> <c- c1>// green plasma</c->

<c- c1>// add a cloud to the plasma</c->
AddCloud<c- p>(</c->data<c- p>,</c-> data<c- p>.</c->width<c- o>/</c-><c- mi>2</c-><c- p>,</c-> data<c- p>.</c->height<c- o>/</c-><c- mi>2</c-><c- p>);</c-> <c- c1>// put a cloud in the middle</c->

<c- c1>// paint the plasma+cloud on the canvas</c->
context<c- p>.</c->putImageData<c- p>(</c->data<c- p>,</c-> <c- mi>0</c-><c- p>,</c-> <c- mi>0</c-><c- p>);</c->

<c- c1>// support methods</c->
<c- a>function</c-> FillPlasma<c- p>(</c->data<c- p>,</c-> color<c- p>)</c-> <c- p>{</c-> <c- p>...</c-> <c- p>}</c->
<c- a>function</c-> AddCloud<c- p>(</c->data<c- p>,</c-> x<c- p>,</c-> y<c- p>)</c-> <c- p>{</c-> <c- p>...</c-> <c- p>}</c-></code></pre>

  </div>

  <div class=example>

   <p>Here is an example of using <code id=pixel-manipulation:dom-context-2d-getimagedata-2><a href=#dom-context-2d-getimagedata>getImageData()</a></code> and <code id=pixel-manipulation:dom-context-2d-putimagedata-2><a href=#dom-context-2d-putimagedata>putImageData()</a></code> to implement an edge detection
   filter.</p>

   <pre><code class='html'><c- cp>&lt;!DOCTYPE HTML&gt;</c->
<c- p>&lt;</c-><c- f>html</c-> <c- e>lang</c-><c- o>=</c-><c- s>&quot;en&quot;</c-><c- p>&gt;</c->
 <c- p>&lt;</c-><c- f>head</c-><c- p>&gt;</c->
  <c- p>&lt;</c-><c- f>title</c-><c- p>&gt;</c->Edge detection demo<c- p>&lt;/</c-><c- f>title</c-><c- p>&gt;</c->
  <c- p>&lt;</c-><c- f>script</c-><c- p>&gt;</c->
   <c- a>var</c-> image <c- o>=</c-> <c- k>new</c-> Image<c- p>();</c->
   <c- a>function</c-> init<c- p>()</c-> <c- p>{</c->
     image<c- p>.</c->onload <c- o>=</c-> demo<c- p>;</c->
     image<c- p>.</c->src <c- o>=</c-> <c- u>&quot;image.jpeg&quot;</c-><c- p>;</c->
   <c- p>}</c->
   <c- a>function</c-> demo<c- p>()</c-> <c- p>{</c->
     <c- a>var</c-> canvas <c- o>=</c-> document<c- p>.</c->getElementsByTagName<c- p>(</c-><c- t>&apos;canvas&apos;</c-><c- p>)[</c-><c- mi>0</c-><c- p>];</c->
     <c- a>var</c-> context <c- o>=</c-> canvas<c- p>.</c->getContext<c- p>(</c-><c- t>&apos;2d&apos;</c-><c- p>);</c->

     <c- c1>// draw the image onto the canvas</c->
     context<c- p>.</c->drawImage<c- p>(</c->image<c- p>,</c-> <c- mi>0</c-><c- p>,</c-> <c- mi>0</c-><c- p>);</c->

     <c- c1>// get the image data to manipulate</c->
     <c- a>var</c-> input <c- o>=</c-> context<c- p>.</c->getImageData<c- p>(</c-><c- mi>0</c-><c- p>,</c-> <c- mi>0</c-><c- p>,</c-> canvas<c- p>.</c->width<c- p>,</c-> canvas<c- p>.</c->height<c- p>);</c->

     <c- c1>// get an empty slate to put the data into</c->
     <c- a>var</c-> output <c- o>=</c-> context<c- p>.</c->createImageData<c- p>(</c->canvas<c- p>.</c->width<c- p>,</c-> canvas<c- p>.</c->height<c- p>);</c->

     <c- c1>// alias some variables for convenience</c->
     <c- c1>// In this case input.width and input.height</c->
     <c- c1>// match canvas.width and canvas.height</c->
     <c- c1>// but we&apos;ll use the former to keep the code generic.</c->
     <c- a>var</c-> w <c- o>=</c-> input<c- p>.</c->width<c- p>,</c-> h <c- o>=</c-> input<c- p>.</c->height<c- p>;</c->
     <c- a>var</c-> inputData <c- o>=</c-> input<c- p>.</c->data<c- p>;</c->
     <c- a>var</c-> outputData <c- o>=</c-> output<c- p>.</c->data<c- p>;</c->

     <c- c1>// edge detection</c->
     <c- k>for</c-> <c- p>(</c-><c- a>var</c-> y <c- o>=</c-> <c- mi>1</c-><c- p>;</c-> y <c- o>&lt;</c-> h<c- o>-</c-><c- mi>1</c-><c- p>;</c-> y <c- o>+=</c-> <c- mi>1</c-><c- p>)</c-> <c- p>{</c->
       <c- k>for</c-> <c- p>(</c-><c- a>var</c-> x <c- o>=</c-> <c- mi>1</c-><c- p>;</c-> x <c- o>&lt;</c-> w<c- o>-</c-><c- mi>1</c-><c- p>;</c-> x <c- o>+=</c-> <c- mi>1</c-><c- p>)</c-> <c- p>{</c->
         <c- k>for</c-> <c- p>(</c-><c- a>var</c-> c <c- o>=</c-> <c- mi>0</c-><c- p>;</c-> c <c- o>&lt;</c-> <c- mi>3</c-><c- p>;</c-> c <c- o>+=</c-> <c- mi>1</c-><c- p>)</c-> <c- p>{</c->
           <c- a>var</c-> i <c- o>=</c-> <c- p>(</c->y<c- o>*</c->w <c- o>+</c-> x<c- p>)</c-><c- o>*</c-><c- mi>4</c-> <c- o>+</c-> c<c- p>;</c->
           outputData<c- p>[</c->i<c- p>]</c-> <c- o>=</c-> <c- mi>127</c-> <c- o>+</c-> <c- o>-</c->inputData<c- p>[</c->i <c- o>-</c-> w<c- o>*</c-><c- mi>4</c-> <c- o>-</c-> <c- mi>4</c-><c- p>]</c-> <c- o>-</c->   inputData<c- p>[</c->i <c- o>-</c-> w<c- o>*</c-><c- mi>4</c-><c- p>]</c-> <c- o>-</c-> inputData<c- p>[</c->i <c- o>-</c-> w<c- o>*</c-><c- mi>4</c-> <c- o>+</c-> <c- mi>4</c-><c- p>]</c-> <c- o>+</c->
                                 <c- o>-</c->inputData<c- p>[</c->i <c- o>-</c-> <c- mi>4</c-><c- p>]</c->       <c- o>+</c-> <c- mi>8</c-><c- o>*</c->inputData<c- p>[</c->i<c- p>]</c->       <c- o>-</c-> inputData<c- p>[</c->i <c- o>+</c-> <c- mi>4</c-><c- p>]</c-> <c- o>+</c->
                                 <c- o>-</c->inputData<c- p>[</c->i <c- o>+</c-> w<c- o>*</c-><c- mi>4</c-> <c- o>-</c-> <c- mi>4</c-><c- p>]</c-> <c- o>-</c->   inputData<c- p>[</c->i <c- o>+</c-> w<c- o>*</c-><c- mi>4</c-><c- p>]</c-> <c- o>-</c-> inputData<c- p>[</c->i <c- o>+</c-> w<c- o>*</c-><c- mi>4</c-> <c- o>+</c-> <c- mi>4</c-><c- p>];</c->
         <c- p>}</c->
         outputData<c- p>[(</c->y<c- o>*</c->w <c- o>+</c-> x<c- p>)</c-><c- o>*</c-><c- mi>4</c-> <c- o>+</c-> <c- mi>3</c-><c- p>]</c-> <c- o>=</c-> <c- mi>255</c-><c- p>;</c-> <c- c1>// alpha</c->
       <c- p>}</c->
     <c- p>}</c->

     <c- c1>// put the image data back after manipulation</c->
     context<c- p>.</c->putImageData<c- p>(</c->output<c- p>,</c-> <c- mi>0</c-><c- p>,</c-> <c- mi>0</c-><c- p>);</c->
   <c- p>}</c->
  <c- p>&lt;/</c-><c- f>script</c-><c- p>&gt;</c->
 <c- p>&lt;/</c-><c- f>head</c-><c- p>&gt;</c->
 <c- p>&lt;</c-><c- f>body</c-> <c- e>onload</c-><c- o>=</c-><c- s>&quot;init()&quot;</c-><c- p>&gt;</c->
  <c- p>&lt;</c-><c- f>canvas</c-><c- p>&gt;&lt;/</c-><c- f>canvas</c-><c- p>&gt;</c->
 <c- p>&lt;/</c-><c- f>body</c-><c- p>&gt;</c->
<c- p>&lt;/</c-><c- f>html</c-><c- p>&gt;</c-></code></pre>

  </div>




  <h6 id=compositing><span class=secno>4.12.5.1.16</span> Compositing<a href=#compositing class=self-link></a></h6>

  <dl class=domintro><dt><var>context</var> . <code id=dom-context-2d-globalalpha-dev><a href=#dom-context-2d-globalalpha>globalAlpha</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current alpha value applied to rendering operations.</p>

    <p>Can be set, to change the alpha value. Values outside of the range 0.0 .. 1.0 are
    ignored.</p>
   <dt><var>context</var> . <code id=dom-context-2d-globalcompositeoperation-dev><a href=#dom-context-2d-globalcompositeoperation>globalCompositeOperation</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current composition operation, from the values defined in <cite>Compositing and
    Blending</cite>. <a href=references.html#refsCOMPOSITE>[COMPOSITE]</a>.</p>

    <p>Can be set, to change the composition operation. Unknown values are ignored.</p>
   </dl>

  

  <p>All drawing operations on an object which implements the <code id=compositing:canvascompositing><a href=#canvascompositing>CanvasCompositing</a></code>
  interface are affected by the global compositing attributes, <code id=compositing:dom-context-2d-globalalpha><a href=#dom-context-2d-globalalpha>globalAlpha</a></code> and <code id=compositing:dom-context-2d-globalcompositeoperation><a href=#dom-context-2d-globalcompositeoperation>globalCompositeOperation</a></code>.</p>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/globalAlpha title="The CanvasRenderingContext2D.globalAlpha property of the Canvas 2D API specifies the alpha (transparency) value that is applied to shapes and images before they are drawn onto the canvas.">CanvasRenderingContext2D/globalAlpha</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-globalalpha><code>globalAlpha</code></dfn> attribute gives an
  alpha value that is applied to shapes and images before they are composited onto the <a href=#output-bitmap id=compositing:output-bitmap>output
  bitmap</a>. The value must be in the range from 0.0 (fully transparent) to 1.0 (no additional
  transparency). If an attempt is made to set the attribute to a value outside this range, including
  Infinity and Not-a-Number (NaN) values, then the attribute must retain its previous value. When
  the context is created, the <code id=compositing:dom-context-2d-globalalpha-2><a href=#dom-context-2d-globalalpha>globalAlpha</a></code> attribute
  must initially have the value 1.0.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/globalCompositeOperation title="The CanvasRenderingContext2D.globalCompositeOperation property of the Canvas 2D API sets the type of compositing operation to apply when drawing new shapes.">CanvasRenderingContext2D/globalCompositeOperation</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>2+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span><hr><span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>9+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>10.1+</span></span></div></div></aside><p>The <dfn id=dom-context-2d-globalcompositeoperation><code>globalCompositeOperation</code></dfn> attribute
  sets the <dfn id=current-composition-operator>current composition operator</dfn>, which controls how shapes and images are drawn onto the
  <a href=#output-bitmap id=compositing:output-bitmap-2>output bitmap</a>, once they have had <code id=compositing:dom-context-2d-globalalpha-3><a href=#dom-context-2d-globalalpha>globalAlpha</a></code> and the current transformation matrix
  applied. The possible values are those defined in <cite>Compositing and Blending</cite>, and
  include the values <dfn id=gcop-source-over><code>source-over</code></dfn>
  and <dfn id=gcop-copy><code>copy</code></dfn>.
  <a href=references.html#refsCOMPOSITE>[COMPOSITE]</a></p>

  <p>These values are all case-sensitive — they must be used exactly as defined. User agents
  must not recognize values that are not a <a id=compositing:case-sensitive href=infrastructure.html#case-sensitive>case-sensitive</a> match for one of the values
  given in <cite>Compositing and Blending</cite>. <a href=references.html#refsCOMPOSITE>[COMPOSITE]</a></p>

  <p>On setting, if the user agent does not recognize the specified value, it must be ignored,
  leaving the value of <code id=compositing:dom-context-2d-globalcompositeoperation-2><a href=#dom-context-2d-globalcompositeoperation>globalCompositeOperation</a></code> unaffected.
  Otherwise, the attribute must be set to the given new value.</p>

  <p>When the context is created, the <code id=compositing:dom-context-2d-globalcompositeoperation-3><a href=#dom-context-2d-globalcompositeoperation>globalCompositeOperation</a></code> attribute must
  initially have the value <code id=compositing:gcop-source-over><a href=#gcop-source-over>source-over</a></code>.</p>

  



  <h6 id=image-smoothing><span class=secno>4.12.5.1.17</span> Image smoothing<a href=#image-smoothing class=self-link></a></h6>

  <dl class=domintro><dt><var>context</var> . <code id=dom-context-2d-imagesmoothingenabled-dev><a href=#dom-context-2d-imagesmoothingenabled>imageSmoothingEnabled</a></code> [ = <var>value</var> ]<dd>
    <p>Returns whether pattern fills and the <code id=image-smoothing:dom-context-2d-drawimage><a href=#dom-context-2d-drawimage>drawImage()</a></code> method will attempt to smooth images if
    their pixels don't line up exactly with the display, when scaling images up.</p>

    <p>Can be set, to change whether images are smoothed (true) or not (false).</p>
   <dt><var>context</var> . <code id=dom-context-2d-imagesmoothingquality-dev><a href=#dom-context-2d-imagesmoothingquality>imageSmoothingQuality</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current image-smoothing-quality preference.</p>

    <p>Can be set, to change the preferred quality of image smoothing. The possible values are
    "<code id=image-smoothing:dom-context-2d-imagesmoothingquality-low><a href=#dom-context-2d-imagesmoothingquality-low>low</a></code>", "<code id=image-smoothing:dom-context-2d-imagesmoothingquality-medium><a href=#dom-context-2d-imagesmoothingquality-medium>medium</a></code>" and "<code id=image-smoothing:dom-context-2d-imagesmoothingquality-high><a href=#dom-context-2d-imagesmoothingquality-high>high</a></code>". Unknown values are ignored.</p>
   </dl>

  

  <p>Objects that implement the <code id=image-smoothing:canvasimagesmoothing><a href=#canvasimagesmoothing>CanvasImageSmoothing</a></code> interface have attributes that
  control how image smoothing is performed.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/imageSmoothingEnabled title="The imageSmoothingEnabled property of the CanvasRenderingContext2D interface, part of the Canvas API, determines whether scaled images are smoothed (true, default) or not (false). On getting the imageSmoothingEnabled property, the last value it was set to is returned.">CanvasRenderingContext2D/imageSmoothingEnabled</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>51+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>30+</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>15+</span></span><span class="ie yes"><span>Internet Explorer</span><span title="Requires a prefix or alternative name.">🔰 Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>51+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-imagesmoothingenabled><code>imageSmoothingEnabled</code></dfn>
  attribute, on getting, must return the last value it was set to. On setting, it must be set to the
  new value. When the object implementing the <code id=image-smoothing:canvasimagesmoothing-2><a href=#canvasimagesmoothing>CanvasImageSmoothing</a></code> interface is
  created, the attribute must be set to true.</p>

  <p>The <dfn id=dom-context-2d-imagesmoothingquality><code>imageSmoothingQuality</code></dfn>
  attribute, on getting, must return the last value it was set to. On setting, it must be set to the
  new value. When the object implementing the <code id=image-smoothing:canvasimagesmoothing-3><a href=#canvasimagesmoothing>CanvasImageSmoothing</a></code> interface is
  created, the attribute must be set to "<code id=image-smoothing:dom-context-2d-imagesmoothingquality-low-2><a href=#dom-context-2d-imagesmoothingquality-low>low</a></code>".</p>

  


  <h6 id=shadows><span class=secno>4.12.5.1.18</span> <dfn>Shadows</dfn><a href=#shadows class=self-link></a></h6>

  <p>All drawing operations on an object which implements the <code id=shadows:canvasshadowstyles><a href=#canvasshadowstyles>CanvasShadowStyles</a></code>
  interface are affected by the four global shadow attributes.</p>

  <dl class=domintro><dt><var>context</var> . <code id=dom-context-2d-shadowcolor-dev><a href=#dom-context-2d-shadowcolor>shadowColor</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current shadow color.</p>

    <p>Can be set, to change the shadow color. Values that cannot be parsed as CSS colors are ignored.</p>
   <dt><var>context</var> . <code id=dom-context-2d-shadowoffsetx-dev><a href=#dom-context-2d-shadowoffsetx>shadowOffsetX</a></code> [ = <var>value</var> ]<dt><var>context</var> . <code id=dom-context-2d-shadowoffsety-dev><a href=#dom-context-2d-shadowoffsety>shadowOffsetY</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current shadow offset.</p>

    <p>Can be set, to change the shadow offset. Values that are not finite numbers are ignored.</p>
   <dt><var>context</var> . <code id=dom-context-2d-shadowblur-dev><a href=#dom-context-2d-shadowblur>shadowBlur</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current level of blur applied to shadows.</p>

    <p>Can be set, to change the blur level. Values that are not finite numbers greater than or
    equal to zero are ignored.</p>
   </dl>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/shadowColor title="The CanvasRenderingContext2D.shadowColor property of the Canvas 2D API specifies the color of shadows.">CanvasRenderingContext2D/shadowColor</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-shadowcolor><code>shadowColor</code></dfn> attribute sets the
  color of the shadow.</p>

  <p>When the context is created, the <code id=shadows:dom-context-2d-shadowcolor><a href=#dom-context-2d-shadowcolor>shadowColor</a></code>
  attribute initially must be <a id=shadows:transparent-black href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a>.</p>

  <p>On getting, the <a href=#serialisation-of-a-color id=shadows:serialisation-of-a-color>serialization of the color</a>
  must be returned.</p>

  <p>On setting, the new value must be <a href=infrastructure.html#parsed-as-a-css-color-value id=shadows:parsed-as-a-css-color-value>parsed</a>
  with this <code id=shadows:the-canvas-element><a href=#the-canvas-element>canvas</a></code> element and the color assigned. If parsing the value results in
  failure then it must be ignored, and the attribute must retain its previous value. <a href=references.html#refsCSSCOLOR>[CSSCOLOR]</a></p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/shadowOffsetX title="The CanvasRenderingContext2D.shadowOffsetX property of the Canvas 2D API specifies the distance that shadows will be offset horizontally.">CanvasRenderingContext2D/shadowOffsetX</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/shadowOffsetY title="The CanvasRenderingContext2D.shadowOffsetY property of the Canvas 2D API specifies the distance that shadows will be offset vertically.">CanvasRenderingContext2D/shadowOffsetY</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-shadowoffsetx><code>shadowOffsetX</code></dfn> and <dfn id=dom-context-2d-shadowoffsety><code>shadowOffsetY</code></dfn> attributes specify the distance
  that the shadow will be offset in the positive horizontal and positive vertical distance
  respectively. Their values are in coordinate space units. They are not affected by the current
  transformation matrix.</p>

  <p>When the context is created, the shadow offset attributes must initially have the value
  0.</p>

  <p>On getting, they must return their current value. On setting, the attribute being set must be
  set to the new value, except if the value is infinite or NaN, in which case the new value must be
  ignored.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/shadowBlur title="The CanvasRenderingContext2D.shadowBlur property of the Canvas 2D API specifies the amount of blur applied to shadows. The default is 0 (no blur).">CanvasRenderingContext2D/shadowBlur</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>1.5+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-context-2d-shadowblur><code>shadowBlur</code></dfn> attribute specifies
  the level of the blurring effect. (The units do not map to coordinate space units, and are not
  affected by the current transformation matrix.)</p>

  <p>When the context is created, the <code id=shadows:dom-context-2d-shadowblur><a href=#dom-context-2d-shadowblur>shadowBlur</a></code>
  attribute must initially have the value 0.</p>

  <p>On getting, the attribute must return its current value. On setting the attribute must be set
  to the new value, except if the value is negative, infinite or NaN, in which case the new value
  must be ignored.</p>

  <p><dfn id=when-shadows-are-drawn>Shadows are only drawn if</dfn> the opacity component of
  the alpha component of the color of <code id=shadows:dom-context-2d-shadowcolor-2><a href=#dom-context-2d-shadowcolor>shadowColor</a></code> is
  nonzero and either the <code id=shadows:dom-context-2d-shadowblur-2><a href=#dom-context-2d-shadowblur>shadowBlur</a></code> is nonzero, or
  the <code id=shadows:dom-context-2d-shadowoffsetx><a href=#dom-context-2d-shadowoffsetx>shadowOffsetX</a></code> is nonzero, or the <code id=shadows:dom-context-2d-shadowoffsety><a href=#dom-context-2d-shadowoffsety>shadowOffsetY</a></code> is nonzero.</p>

  <p><a href=#when-shadows-are-drawn id=shadows:when-shadows-are-drawn>When shadows are drawn</a>, they must be rendered as follows:</p>

  <ol><li><p>Let <var>A</var> be an infinite <a id=shadows:transparent-black-2 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a> bitmap on which the source
   image for which a shadow is being created has been rendered.<li><p>Let <var>B</var> be an infinite <a id=shadows:transparent-black-3 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a> bitmap, with a coordinate
   space and an origin identical to <var>A</var>.<li><p>Copy the alpha channel of <var>A</var> to <var>B</var>, offset by <code id=shadows:dom-context-2d-shadowoffsetx-2><a href=#dom-context-2d-shadowoffsetx>shadowOffsetX</a></code> in the positive <var>x</var>
   direction, and <code id=shadows:dom-context-2d-shadowoffsety-2><a href=#dom-context-2d-shadowoffsety>shadowOffsetY</a></code> in the positive
   <var>y</var> direction.<li>
    <p>If <code id=shadows:dom-context-2d-shadowblur-3><a href=#dom-context-2d-shadowblur>shadowBlur</a></code> is greater than 0:</p>

    <ol><li> <p>Let <var>σ</var> be half the value of <code id=shadows:dom-context-2d-shadowblur-4><a href=#dom-context-2d-shadowblur>shadowBlur</a></code>.<li> <p>Perform a 2D Gaussian Blur on <var>B</var>, using <var>σ</var>
     as the standard deviation.</p>  </ol>

    <p>User agents may limit values of <var>σ</var> to an implementation-specific
    maximum value to avoid exceeding hardware limitations during the Gaussian blur operation.</p>
   <li><p>Set the red, green, and blue components of every pixel in <var>B</var> to the
   red, green, and blue components (respectively) of the color of <code id=shadows:dom-context-2d-shadowcolor-3><a href=#dom-context-2d-shadowcolor>shadowColor</a></code>.<li><p>Multiply the alpha component of every pixel in <var>B</var> by the alpha
   component of the color of <code id=shadows:dom-context-2d-shadowcolor-4><a href=#dom-context-2d-shadowcolor>shadowColor</a></code>.<li><p>The shadow is in the bitmap <var>B</var>, and is rendered as part of the
   <a href=#drawing-model id=shadows:drawing-model>drawing model</a> described below.</ol>

  

  <p>If the current composition operation is <code id=shadows:gcop-copy><a href=#gcop-copy>copy</a></code>, then shadows
  effectively won't render (since the shape will overwrite the shadow).</p>

  <h6 id=filters><span class=secno>4.12.5.1.19</span> Filters<a href=#filters class=self-link></a></h6><aside class="mdn-anno wrapped"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/filter title="The CanvasRenderingContext2D.filter property of the Canvas 2D API provides filter effects such as blurring and grayscaling. It is similar to the CSS filter property and accepts the same values.">CanvasRenderingContext2D/filter</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>49+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>52+</span></span><hr><span class="opera no"><span>Opera</span><span>No</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>49+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>52+</span></span><span class="webview_android yes"><span>WebView Android</span><span>52+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>6.0+</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside>

  <p>All drawing operations on an object which implements the <code id=filters:canvasfilters><a href=#canvasfilters>CanvasFilters</a></code>
  interface are affected by the global <dfn id=dom-context-2d-filter><code>filter</code></dfn>
  attribute.</p>

  <dl class=domintro><dt><var>context</var> . <code id=dom-context-2d-filter-dev><a href=#dom-context-2d-filter>filter</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the current filter.</p>

    <p>Can be set, to change the filter. Values that cannot be parsed as a
    <a id=filters:filter-function-list href=https://drafts.fxtf.org/filter-effects/#typedef-filter-function-list data-x-internal=filter-function-list>&lt;filter-function-list></a> value are ignored.</p>
   </dl>

  

  <p>The <code id=filters:dom-context-2d-filter><a href=#dom-context-2d-filter>filter</a></code> attribute, on getting, must
  return the last value it was successfully set to. The value must not be re-serialized. On setting,
  if the new value is 'none' (not the empty string, null, or undefined), filters must be disabled
  for the context. Otherwise, the value must be parsed as a
  <a id=filters:filter-function-list-2 href=https://drafts.fxtf.org/filter-effects/#typedef-filter-function-list data-x-internal=filter-function-list>&lt;filter-function-list></a> value. If the value cannot be parsed as a
  <a id=filters:filter-function-list-3 href=https://drafts.fxtf.org/filter-effects/#typedef-filter-function-list data-x-internal=filter-function-list>&lt;filter-function-list></a> value, where using property-independent style sheet
  syntax like 'inherit' or 'initial' is considered an invalid value, then it must be ignored, and
  the attribute must retain its previous value. When creating the object implementing the
  <code id=filters:canvasfilters-2><a href=#canvasfilters>CanvasFilters</a></code> interface, the attribute must be set to 'none'.</p>

  <p>A <a id=filters:filter-function-list-4 href=https://drafts.fxtf.org/filter-effects/#typedef-filter-function-list data-x-internal=filter-function-list>&lt;filter-function-list></a> value consists of a sequence of one or more
  filter functions or references to SVG filters. The input to the filter is used as the input
  to the first item in the list. Subsequent items take the output of the previous item as
  their input. <a href=references.html#refsFILTERS>[FILTERS]</a></p>

  <p>Coordinates used in the value of the <code id=filters:dom-context-2d-filter-2><a href=#dom-context-2d-filter>filter</a></code> attribute are interpreted such that one pixel is
  equivalent to one SVG user space unit and to one canvas coordinate space unit. Filter coordinates
  are not affected by the <a href=#transformations id=filters:transformations>current transformation
  matrix</a>. The current transformation matrix affects only the input to the filter. Filters
  are applied in the <a href=#output-bitmap id=filters:output-bitmap>output bitmap</a>'s coordinate space.</p>

  <p>When the value of the <code id=filters:dom-context-2d-filter-3><a href=#dom-context-2d-filter>filter</a></code> attribute defines
  lengths using percentages or using <a id="filters:'em'" href=https://drafts.csswg.org/css-values/#em data-x-internal="'em'">'em'</a> or <a id="filters:'ex'" href=https://drafts.csswg.org/css-values/#ex data-x-internal="'ex'">'ex'</a> units, these must be
  interpreted relative to the <a id=filters:computed-value href=https://drafts.csswg.org/css-cascade/#computed-value data-x-internal=computed-value>computed value</a> of the <a id="filters:'font-size'" href=https://drafts.csswg.org/css-fonts/#font-size-prop data-x-internal="'font-size'">'font-size'</a> property
  of the <a href=#font-style-source-object id=filters:font-style-source-object>font style source object</a> at the time that the attribute is set, if it is an
  element. If the <a href=https://drafts.csswg.org/css-cascade/#computed-value id=filters:computed-value-2 data-x-internal=computed-value>computed values</a> are undefined for a
  particular case (e.g. because the <a href=#font-style-source-object id=filters:font-style-source-object-2>font style source object</a> is not an element or is
  not <a id=filters:being-rendered href=rendering.html#being-rendered>being rendered</a>), then the relative keywords must be interpreted relative to the
  default value of the <code id=filters:dom-context-2d-font><a href=#dom-context-2d-font>font</a></code> attribute. The 'larger' and
  'smaller' keywords are not supported.</p>

  <p>If the value of the <code id=filters:dom-context-2d-filter-4><a href=#dom-context-2d-filter>filter</a></code> attribute refers to an
  SVG filter in the same document, and this SVG filter changes, then the changed filter is used for
  the next draw operation.</p>

  <p>If the value of the <code id=filters:dom-context-2d-filter-5><a href=#dom-context-2d-filter>filter</a></code> attribute refers to an
  SVG filter in an external resource document and that document is not loaded when a drawing
  operation is invoked, then the drawing operation must proceed with no filtering.</p>

  

  <h6 id=working-with-externally-defined-svg-filters><span class=secno>4.12.5.1.20</span> Working with externally-defined SVG filters<a href=#working-with-externally-defined-svg-filters class=self-link></a></h6>

  <p><i>This section is non-normative.</i></p>

  <p>Since drawing is performed using filter value 'none' until an externally-defined
  filter has finished loading, authors might wish to determine whether such a filter
  has finished loading before proceeding with a drawing operation. One way to accomplish
  this is to load the externally-defined filter elsewhere within the same page in some
  element that sends a <code>load</code> event (for example, an <a id=working-with-externally-defined-svg-filters:svg-use href=https://svgwg.org/svg2-draft/struct.html#UseElement data-x-internal=svg-use>SVG
  <code>use</code></a> element), and wait for the <code>load</code> event to be
  dispatched.</p>

  

  <h6 id=drawing-model><span class=secno>4.12.5.1.21</span> <dfn>Drawing model</dfn><a href=#drawing-model class=self-link></a></h6>

  <p>When a shape or image is painted, user agents must follow these steps, in the order given (or
  act as if they do):</p>

  <ol><li><p>Render the shape or image onto an infinite <a id=drawing-model:transparent-black href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a> bitmap, creating
   image <var>A</var>, as described in the previous sections. For shapes, the current fill, stroke,
   and line styles must be honored, and the stroke must itself also be subjected to the current
   transformation matrix.<li><p>When the filter attribute is set to a value other than 'none' and all the
   externally-defined filters it references, if any, are in documents that are currently loaded,
   then use image <var>A</var> as the input to the <code id=drawing-model:dom-context-2d-filter><a href=#dom-context-2d-filter>filter</a></code>, creating image <var>B</var>. Otherwise, let
   <var>B</var> be an alias for <var>A</var>.<li><p><a href=#when-shadows-are-drawn id=drawing-model:when-shadows-are-drawn>When shadows are drawn</a>, render the shadow from image <var>B</var>,
   using the current shadow styles, creating image <var>C</var>.<li><p><a href=#when-shadows-are-drawn id=drawing-model:when-shadows-are-drawn-2>When shadows are drawn</a>, multiply the alpha component of every pixel in <var>C</var> by <code id=drawing-model:dom-context-2d-globalalpha><a href=#dom-context-2d-globalalpha>globalAlpha</a></code>.<li><p><a href=#when-shadows-are-drawn id=drawing-model:when-shadows-are-drawn-3>When shadows are drawn</a>, composite <var>C</var> within the
   <a href=#clipping-region id=drawing-model:clipping-region>clipping region</a> over the current <a href=#output-bitmap id=drawing-model:output-bitmap>output bitmap</a> using the <a href=#current-composition-operator id=drawing-model:current-composition-operator>current
   composition operator</a>.<li><p>Multiply the alpha component of every pixel in <var>B</var> by <code id=drawing-model:dom-context-2d-globalalpha-2><a href=#dom-context-2d-globalalpha>globalAlpha</a></code>.<li><p>Composite <var>B</var> within the <a href=#clipping-region id=drawing-model:clipping-region-2>clipping region</a> over the current
   <a href=#output-bitmap id=drawing-model:output-bitmap-2>output bitmap</a> using the <a href=#current-composition-operator id=drawing-model:current-composition-operator-2>current composition operator</a>.</ol>

  <p>When compositing onto the <a href=#output-bitmap id=drawing-model:output-bitmap-3>output bitmap</a>, pixels that would fall outside of the
  <a href=#output-bitmap id=drawing-model:output-bitmap-4>output bitmap</a> must be discarded.</p>

  




  <h6 id=best-practices><span class=secno>4.12.5.1.22</span> Best practices<a href=#best-practices class=self-link></a></h6>

  <p>When a canvas is interactive, authors should include <a id=best-practices:focusable href=interaction.html#focusable>focusable</a> elements in the
  element's fallback content corresponding to each <a id=best-practices:focusable-2 href=interaction.html#focusable>focusable</a> part of the canvas, as in
  the <a href=#drawCustomFocusRingExample>example above</a>.</p>

  <p>When rendering focus rings, to ensure that focus rings have the appearance of native focus
  rings, authors should use the <code id=best-practices:dom-context-2d-drawfocusifneeded><a href=#dom-context-2d-drawfocusifneeded>drawFocusIfNeeded()</a></code> method, passing it the
  element for which a ring is being drawn. This method only draws the focus ring if the element is
  <a id=best-practices:focused href=interaction.html#focused>focused</a>, so that it can simply be called whenever drawing the element, without
  checking whether the element is focused or not first.</p>

  <p>In addition to drawing focus rings, authors should use the <code id=best-practices:dom-context-2d-scrollpathintoview><a href=#dom-context-2d-scrollpathintoview>scrollPathIntoView()</a></code> method when an element in
  the canvas is focused, to make sure it is visible on the screen (if applicable).</p>

  <p id=no-text-editing-in-canvas-please>Authors should avoid implementing text editing controls
  using the <code id=best-practices:the-canvas-element><a href=#the-canvas-element>canvas</a></code> element. Doing so has a large number of disadvantages:</p>

  <ul><li>Mouse placement of the caret has to be reimplemented.<li>Keyboard movement of the caret has to be reimplemented (possibly across lines, for multiline
   text input).<li>Scrolling of the text control has to be implemented (horizontally for long lines, vertically
   for multiline input).<li>Native features such as copy-and-paste have to be reimplemented.<li>Native features such as spell-checking have to be reimplemented.<li>Native features such as drag-and-drop have to be reimplemented.<li>Native features such as page-wide text search have to be reimplemented.<li>Native features specific to the user, for example custom text services, have to be
   reimplemented. This is close to impossible since each user might have different services
   installed, and there is an unbounded set of possible such services.<li>Bidirectional text editing has to be reimplemented.<li>For multiline text editing, line wrapping has to be implemented for all relevant
   languages.<li>Text selection has to be reimplemented.<li>Dragging of bidirectional text selections has to be reimplemented.<li>Platform-native keyboard shortcuts have to be reimplemented.<li>Platform-native input method editors (IMEs) have to be reimplemented.<li>Undo and redo functionality has to be reimplemented.<li>Accessibility features such as magnification following the caret or selection have to be
   reimplemented.</ul>

  <p>This is a huge amount of work, and authors are most strongly encouraged to avoid doing any of
  it by instead using the <code id=best-practices:the-input-element><a href=input.html#the-input-element>input</a></code> element, the <code id=best-practices:the-textarea-element><a href=form-elements.html#the-textarea-element>textarea</a></code> element, or the
  <code id=best-practices:attr-contenteditable><a href=interaction.html#attr-contenteditable>contenteditable</a></code> attribute.</p>


  <h6 id=examples><span class=secno>4.12.5.1.23</span> Examples<a href=#examples class=self-link></a></h6>

  <p><i>This section is non-normative.</i></p>

  <div class=example>

  <p>Here is an example of a script that uses canvas to draw <a href="data:text/html;charset=utf-8;base64,PCFET0NUWVBFIEhUTUw%2BDQo8aHRtbCBsYW5nPSJlbiI%2BDQogPGhlYWQ%2BDQogIDx0aXRsZT5QcmV0dHkgR2xvd2luZyBMaW5lczwvdGl0bGU%2BDQogPC9oZWFkPg0KIDxib2R5Pg0KPGNhbnZhcyB3aWR0aD0iODAwIiBoZWlnaHQ9IjQ1MCI%2BPC9jYW52YXM%2BDQo8c2NyaXB0Pg0KDQogdmFyIGNvbnRleHQgPSBkb2N1bWVudC5nZXRFbGVtZW50c0J5VGFnTmFtZSgnY2FudmFzJylbMF0uZ2V0Q29udGV4dCgnMmQnKTsNCg0KIHZhciBsYXN0WCA9IGNvbnRleHQuY2FudmFzLndpZHRoICogTWF0aC5yYW5kb20oKTsNCiB2YXIgbGFzdFkgPSBjb250ZXh0LmNhbnZhcy5oZWlnaHQgKiBNYXRoLnJhbmRvbSgpOw0KIHZhciBodWUgPSAwOw0KIGZ1bmN0aW9uIGxpbmUoKSB7DQogICBjb250ZXh0LnNhdmUoKTsNCiAgIGNvbnRleHQudHJhbnNsYXRlKGNvbnRleHQuY2FudmFzLndpZHRoLzIsIGNvbnRleHQuY2FudmFzLmhlaWdodC8yKTsNCiAgIGNvbnRleHQuc2NhbGUoMC45LCAwLjkpOw0KICAgY29udGV4dC50cmFuc2xhdGUoLWNvbnRleHQuY2FudmFzLndpZHRoLzIsIC1jb250ZXh0LmNhbnZhcy5oZWlnaHQvMik7DQogICBjb250ZXh0LmJlZ2luUGF0aCgpOw0KICAgY29udGV4dC5saW5lV2lkdGggPSA1ICsgTWF0aC5yYW5kb20oKSAqIDEwOw0KICAgY29udGV4dC5tb3ZlVG8obGFzdFgsIGxhc3RZKTsNCiAgIGxhc3RYID0gY29udGV4dC5jYW52YXMud2lkdGggKiBNYXRoLnJhbmRvbSgpOw0KICAgbGFzdFkgPSBjb250ZXh0LmNhbnZhcy5oZWlnaHQgKiBNYXRoLnJhbmRvbSgpOw0KICAgY29udGV4dC5iZXppZXJDdXJ2ZVRvKGNvbnRleHQuY2FudmFzLndpZHRoICogTWF0aC5yYW5kb20oKSwNCiAgICAgICAgICAgICAgICAgICAgICAgICBjb250ZXh0LmNhbnZhcy5oZWlnaHQgKiBNYXRoLnJhbmRvbSgpLA0KICAgICAgICAgICAgICAgICAgICAgICAgIGNvbnRleHQuY2FudmFzLndpZHRoICogTWF0aC5yYW5kb20oKSwNCiAgICAgICAgICAgICAgICAgICAgICAgICBjb250ZXh0LmNhbnZhcy5oZWlnaHQgKiBNYXRoLnJhbmRvbSgpLA0KICAgICAgICAgICAgICAgICAgICAgICAgIGxhc3RYLCBsYXN0WSk7DQoNCiAgIGh1ZSA9IGh1ZSArIDEwICogTWF0aC5yYW5kb20oKTsNCiAgIGNvbnRleHQuc3Ryb2tlU3R5bGUgPSAnaHNsKCcgKyBodWUgKyAnLCA1MCUsIDUwJSknOw0KICAgY29udGV4dC5zaGFkb3dDb2xvciA9ICd3aGl0ZSc7DQogICBjb250ZXh0LnNoYWRvd0JsdXIgPSAxMDsNCiAgIGNvbnRleHQuc3Ryb2tlKCk7DQogICBjb250ZXh0LnJlc3RvcmUoKTsNCiB9DQogc2V0SW50ZXJ2YWwobGluZSwgNTApOw0KDQogZnVuY3Rpb24gYmxhbmsoKSB7DQogICBjb250ZXh0LmZpbGxTdHlsZSA9ICdyZ2JhKDAsMCwwLDAuMSknOw0KICAgY29udGV4dC5maWxsUmVjdCgwLCAwLCBjb250ZXh0LmNhbnZhcy53aWR0aCwgY29udGV4dC5jYW52YXMuaGVpZ2h0KTsNCiB9DQogc2V0SW50ZXJ2YWwoYmxhbmssIDQwKTsNCg0KPC9zY3JpcHQ%2BDQogPC9ib2R5Pg0KPC9odG1sPg0K">pretty glowing lines</a>.</p>

  <pre><code class='html'><c- p>&lt;</c-><c- f>canvas</c-> <c- e>width</c-><c- o>=</c-><c- s>&quot;800&quot;</c-> <c- e>height</c-><c- o>=</c-><c- s>&quot;450&quot;</c-><c- p>&gt;&lt;/</c-><c- f>canvas</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>script</c-><c- p>&gt;</c->

 <c- a>var</c-> context <c- o>=</c-> document<c- p>.</c->getElementsByTagName<c- p>(</c-><c- t>&apos;canvas&apos;</c-><c- p>)[</c-><c- mi>0</c-><c- p>].</c->getContext<c- p>(</c-><c- t>&apos;2d&apos;</c-><c- p>);</c->

 <c- a>var</c-> lastX <c- o>=</c-> context<c- p>.</c->canvas<c- p>.</c->width <c- o>*</c-> Math<c- p>.</c->random<c- p>();</c->
 <c- a>var</c-> lastY <c- o>=</c-> context<c- p>.</c->canvas<c- p>.</c->height <c- o>*</c-> Math<c- p>.</c->random<c- p>();</c->
 <c- a>var</c-> hue <c- o>=</c-> <c- mi>0</c-><c- p>;</c->
 <c- a>function</c-> line<c- p>()</c-> <c- p>{</c->
   context<c- p>.</c->save<c- p>();</c->
   context<c- p>.</c->translate<c- p>(</c->context<c- p>.</c->canvas<c- p>.</c->width<c- o>/</c-><c- mi>2</c-><c- p>,</c-> context<c- p>.</c->canvas<c- p>.</c->height<c- o>/</c-><c- mi>2</c-><c- p>);</c->
   context<c- p>.</c->scale<c- p>(</c-><c- mf>0.9</c-><c- p>,</c-> <c- mf>0.9</c-><c- p>);</c->
   context<c- p>.</c->translate<c- p>(</c-><c- o>-</c->context<c- p>.</c->canvas<c- p>.</c->width<c- o>/</c-><c- mi>2</c-><c- p>,</c-> <c- o>-</c->context<c- p>.</c->canvas<c- p>.</c->height<c- o>/</c-><c- mi>2</c-><c- p>);</c->
   context<c- p>.</c->beginPath<c- p>();</c->
   context<c- p>.</c->lineWidth <c- o>=</c-> <c- mi>5</c-> <c- o>+</c-> Math<c- p>.</c->random<c- p>()</c-> <c- o>*</c-> <c- mi>10</c-><c- p>;</c->
   context<c- p>.</c->moveTo<c- p>(</c->lastX<c- p>,</c-> lastY<c- p>);</c->
   lastX <c- o>=</c-> context<c- p>.</c->canvas<c- p>.</c->width <c- o>*</c-> Math<c- p>.</c->random<c- p>();</c->
   lastY <c- o>=</c-> context<c- p>.</c->canvas<c- p>.</c->height <c- o>*</c-> Math<c- p>.</c->random<c- p>();</c->
   context<c- p>.</c->bezierCurveTo<c- p>(</c->context<c- p>.</c->canvas<c- p>.</c->width <c- o>*</c-> Math<c- p>.</c->random<c- p>(),</c->
                         context<c- p>.</c->canvas<c- p>.</c->height <c- o>*</c-> Math<c- p>.</c->random<c- p>(),</c->
                         context<c- p>.</c->canvas<c- p>.</c->width <c- o>*</c-> Math<c- p>.</c->random<c- p>(),</c->
                         context<c- p>.</c->canvas<c- p>.</c->height <c- o>*</c-> Math<c- p>.</c->random<c- p>(),</c->
                         lastX<c- p>,</c-> lastY<c- p>);</c->

   hue <c- o>=</c-> hue <c- o>+</c-> <c- mi>10</c-> <c- o>*</c-> Math<c- p>.</c->random<c- p>();</c->
   context<c- p>.</c->strokeStyle <c- o>=</c-> <c- t>&apos;hsl(&apos;</c-> <c- o>+</c-> hue <c- o>+</c-> <c- t>&apos;, 50%, 50%)&apos;</c-><c- p>;</c->
   context<c- p>.</c->shadowColor <c- o>=</c-> <c- t>&apos;white&apos;</c-><c- p>;</c->
   context<c- p>.</c->shadowBlur <c- o>=</c-> <c- mi>10</c-><c- p>;</c->
   context<c- p>.</c->stroke<c- p>();</c->
   context<c- p>.</c->restore<c- p>();</c->
 <c- p>}</c->
 setInterval<c- p>(</c->line<c- p>,</c-> <c- mi>50</c-><c- p>);</c->

 <c- a>function</c-> blank<c- p>()</c-> <c- p>{</c->
   context<c- p>.</c->fillStyle <c- o>=</c-> <c- t>&apos;rgba(0,0,0,0.1)&apos;</c-><c- p>;</c->
   context<c- p>.</c->fillRect<c- p>(</c-><c- mi>0</c-><c- p>,</c-> <c- mi>0</c-><c- p>,</c-> context<c- p>.</c->canvas<c- p>.</c->width<c- p>,</c-> context<c- p>.</c->canvas<c- p>.</c->height<c- p>);</c->
 <c- p>}</c->
 setInterval<c- p>(</c->blank<c- p>,</c-> <c- mi>40</c-><c- p>);</c->

<c- p>&lt;/</c-><c- f>script</c-><c- p>&gt;</c-></code></pre>

  </div>

  <div class=example>

   <p>The 2D rendering context for <code id=examples:the-canvas-element><a href=#the-canvas-element>canvas</a></code> is often used for sprite-based games. The
   following example demonstrates this:</p>

   <iframe src=/demos/canvas/blue-robot/index-idle.html width=396 height=216></iframe>

   <p>Here is the source for this example:</p>

   <pre><code class='html'><c- cp>&lt;!DOCTYPE HTML&gt;</c->
<c- p>&lt;</c-><c- f>meta</c-> <c- e>charset</c-><c- o>=</c-><c- s>&quot;utf-8&quot;</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>title</c-><c- p>&gt;</c->Blue Robot Demo<c- p>&lt;/</c-><c- f>title</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>style</c-><c- p>&gt;</c->
  <c- f>html</c-> <c- p>{</c-> <c- k>overflow</c-><c- p>:</c-> <c- kc>hidden</c-><c- p>;</c-> <c- k>min-height</c-><c- p>:</c-> <c- mi>200</c-><c- b>px</c-><c- p>;</c-> <c- k>min-width</c-><c- p>:</c-> <c- mi>380</c-><c- b>px</c-><c- p>;</c-> <c- p>}</c->
  <c- f>body</c-> <c- p>{</c-> <c- k>height</c-><c- p>:</c-> <c- mi>200</c-><c- b>px</c-><c- p>;</c-> <c- k>position</c-><c- p>:</c-> <c- kc>relative</c-><c- p>;</c-> <c- k>margin</c-><c- p>:</c-> <c- mi>8</c-><c- b>px</c-><c- p>;</c-> <c- p>}</c->
  <c- p>.</c-><c- nc>buttons</c-> <c- p>{</c-> <c- k>position</c-><c- p>:</c-> <c- kc>absolute</c-><c- p>;</c-> <c- k>bottom</c-><c- p>:</c-> <c- mi>0</c-><c- b>px</c-><c- p>;</c-> <c- k>left</c-><c- p>:</c-> <c- mi>0</c-><c- b>px</c-><c- p>;</c-> <c- k>margin</c-><c- p>:</c-> <c- mi>4</c-><c- b>px</c-><c- p>;</c-> <c- p>}</c->
<c- p>&lt;/</c-><c- f>style</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>canvas</c-> <c- e>width</c-><c- o>=</c-><c- s>&quot;380&quot;</c-> <c- e>height</c-><c- o>=</c-><c- s>&quot;200&quot;</c-><c- p>&gt;&lt;/</c-><c- f>canvas</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>script</c-><c- p>&gt;</c->
 <c- a>var</c-> Landscape <c- o>=</c-> <c- a>function</c-> <c- p>(</c->context<c- p>,</c-> width<c- p>,</c-> height<c- p>)</c-> <c- p>{</c->
   <c- k>this</c-><c- p>.</c->offset <c- o>=</c-> <c- mi>0</c-><c- p>;</c->
   <c- k>this</c-><c- p>.</c->width <c- o>=</c-> width<c- p>;</c->
   <c- k>this</c-><c- p>.</c->advance <c- o>=</c-> <c- a>function</c-> <c- p>(</c->dx<c- p>)</c-> <c- p>{</c->
     <c- k>this</c-><c- p>.</c->offset <c- o>+=</c-> dx<c- p>;</c->
   <c- p>};</c->
   <c- k>this</c-><c- p>.</c->horizon <c- o>=</c-> height <c- o>*</c-> <c- mf>0.7</c-><c- p>;</c->
   <c- c1>// This creates the sky gradient (from a darker blue to white at the bottom)</c->
   <c- k>this</c-><c- p>.</c->sky <c- o>=</c-> context<c- p>.</c->createLinearGradient<c- p>(</c-><c- mi>0</c-><c- p>,</c-> <c- mi>0</c-><c- p>,</c-> <c- mi>0</c-><c- p>,</c-> <c- k>this</c-><c- p>.</c->horizon<c- p>);</c->
   <c- k>this</c-><c- p>.</c->sky<c- p>.</c->addColorStop<c- p>(</c-><c- mf>0.0</c-><c- p>,</c-> <c- t>&apos;rgb(55,121,179)&apos;</c-><c- p>);</c->
   <c- k>this</c-><c- p>.</c->sky<c- p>.</c->addColorStop<c- p>(</c-><c- mf>0.7</c-><c- p>,</c-> <c- t>&apos;rgb(121,194,245)&apos;</c-><c- p>);</c->
   <c- k>this</c-><c- p>.</c->sky<c- p>.</c->addColorStop<c- p>(</c-><c- mf>1.0</c-><c- p>,</c-> <c- t>&apos;rgb(164,200,214)&apos;</c-><c- p>);</c->
   <c- c1>// this creates the grass gradient (from a darker green to a lighter green)</c->
   <c- k>this</c-><c- p>.</c->earth <c- o>=</c-> context<c- p>.</c->createLinearGradient<c- p>(</c-><c- mi>0</c-><c- p>,</c-> <c- k>this</c-><c- p>.</c->horizon<c- p>,</c-> <c- mi>0</c-><c- p>,</c-> height<c- p>);</c->
   <c- k>this</c-><c- p>.</c->earth<c- p>.</c->addColorStop<c- p>(</c-><c- mf>0.0</c-><c- p>,</c-> <c- t>&apos;rgb(81,140,20)&apos;</c-><c- p>);</c->
   <c- k>this</c-><c- p>.</c->earth<c- p>.</c->addColorStop<c- p>(</c-><c- mf>1.0</c-><c- p>,</c-> <c- t>&apos;rgb(123,177,57)&apos;</c-><c- p>);</c->
   <c- k>this</c-><c- p>.</c->paintBackground <c- o>=</c-> <c- a>function</c-> <c- p>(</c->context<c- p>,</c-> width<c- p>,</c-> height<c- p>)</c-> <c- p>{</c->
     <c- c1>// first, paint the sky and grass rectangles</c->
     context<c- p>.</c->fillStyle <c- o>=</c-> <c- k>this</c-><c- p>.</c->sky<c- p>;</c->
     context<c- p>.</c->fillRect<c- p>(</c-><c- mi>0</c-><c- p>,</c-> <c- mi>0</c-><c- p>,</c-> width<c- p>,</c-> <c- k>this</c-><c- p>.</c->horizon<c- p>);</c->
     context<c- p>.</c->fillStyle <c- o>=</c-> <c- k>this</c-><c- p>.</c->earth<c- p>;</c->
     context<c- p>.</c->fillRect<c- p>(</c-><c- mi>0</c-><c- p>,</c-> <c- k>this</c-><c- p>.</c->horizon<c- p>,</c-> width<c- p>,</c-> height<c- o>-</c-><c- k>this</c-><c- p>.</c->horizon<c- p>);</c->
     <c- c1>// then, draw the cloudy banner</c->
     <c- c1>// we make it cloudy by having the draw text off the top of the</c->
     <c- c1>// canvas, and just having the blurred shadow shown on the canvas</c->
     context<c- p>.</c->save<c- p>();</c->
     context<c- p>.</c->translate<c- p>(</c->width<c- o>-</c-><c- p>((</c-><c- k>this</c-><c- p>.</c->offset<c- o>+</c-><c- p>(</c-><c- k>this</c-><c- p>.</c->width<c- o>*</c-><c- mf>3.2</c-><c- p>))</c-> <c- o>%</c-> <c- p>(</c-><c- k>this</c-><c- p>.</c->width<c- o>*</c-><c- mf>4.0</c-><c- p>))</c-><c- o>+</c-><c- mi>0</c-><c- p>,</c-> <c- mi>0</c-><c- p>);</c->
     context<c- p>.</c->shadowColor <c- o>=</c-> <c- t>&apos;white&apos;</c-><c- p>;</c->
     context<c- p>.</c->shadowOffsetY <c- o>=</c-> <c- mi>30</c-><c- o>+</c-><c- k>this</c-><c- p>.</c->horizon<c- o>/</c-><c- mi>3</c-><c- p>;</c-> <c- c1>// offset down on canvas</c->
     context<c- p>.</c->shadowBlur <c- o>=</c-> <c- t>&apos;5&apos;</c-><c- p>;</c->
     context<c- p>.</c->fillStyle <c- o>=</c-> <c- t>&apos;white&apos;</c-><c- p>;</c->
     context<c- p>.</c->textAlign <c- o>=</c-> <c- t>&apos;left&apos;</c-><c- p>;</c->
     context<c- p>.</c->textBaseline <c- o>=</c-> <c- t>&apos;top&apos;</c-><c- p>;</c->
     context<c- p>.</c->font <c- o>=</c-> <c- t>&apos;20px sans-serif&apos;</c-><c- p>;</c->
     context<c- p>.</c->fillText<c- p>(</c-><c- t>&apos;WHATWG ROCKS&apos;</c-><c- p>,</c-> <c- mi>10</c-><c- p>,</c-> <c- o>-</c-><c- mi>30</c-><c- p>);</c-> <c- c1>// text up above canvas</c->
     context<c- p>.</c->restore<c- p>();</c->
     <c- c1>// then, draw the background tree</c->
     context<c- p>.</c->save<c- p>();</c->
     context<c- p>.</c->translate<c- p>(</c->width<c- o>-</c-><c- p>((</c-><c- k>this</c-><c- p>.</c->offset<c- o>+</c-><c- p>(</c-><c- k>this</c-><c- p>.</c->width<c- o>*</c-><c- mf>0.2</c-><c- p>))</c-> <c- o>%</c-> <c- p>(</c-><c- k>this</c-><c- p>.</c->width<c- o>*</c-><c- mf>1.5</c-><c- p>))</c-><c- o>+</c-><c- mi>30</c-><c- p>,</c-> <c- mi>0</c-><c- p>);</c->
     context<c- p>.</c->beginPath<c- p>();</c->
     context<c- p>.</c->fillStyle <c- o>=</c-> <c- t>&apos;rgb(143,89,2)&apos;</c-><c- p>;</c->
     context<c- p>.</c->lineStyle <c- o>=</c-> <c- t>&apos;rgb(10,10,10)&apos;</c-><c- p>;</c->
     context<c- p>.</c->lineWidth <c- o>=</c-> <c- mi>2</c-><c- p>;</c->
     context<c- p>.</c->rect<c- p>(</c-><c- mi>0</c-><c- p>,</c-> <c- k>this</c-><c- p>.</c->horizon<c- o>+</c-><c- mi>5</c-><c- p>,</c-> <c- mi>10</c-><c- p>,</c-> <c- o>-</c-><c- mi>50</c-><c- p>);</c-> <c- c1>// trunk</c->
     context<c- p>.</c->fill<c- p>();</c->
     context<c- p>.</c->stroke<c- p>();</c->
     context<c- p>.</c->beginPath<c- p>();</c->
     context<c- p>.</c->fillStyle <c- o>=</c-> <c- t>&apos;rgb(78,154,6)&apos;</c-><c- p>;</c->
     context<c- p>.</c->arc<c- p>(</c-><c- mi>5</c-><c- p>,</c-> <c- k>this</c-><c- p>.</c->horizon<c- o>-</c-><c- mi>60</c-><c- p>,</c-> <c- mi>30</c-><c- p>,</c-> <c- mi>0</c-><c- p>,</c-> Math<c- p>.</c->PI<c- o>*</c-><c- mi>2</c-><c- p>);</c-> <c- c1>// leaves</c->
     context<c- p>.</c->fill<c- p>();</c->
     context<c- p>.</c->stroke<c- p>();</c->
     context<c- p>.</c->restore<c- p>();</c->
   <c- p>};</c->
   <c- k>this</c-><c- p>.</c->paintForeground <c- o>=</c-> <c- a>function</c-> <c- p>(</c->context<c- p>,</c-> width<c- p>,</c-> height<c- p>)</c-> <c- p>{</c->
     <c- c1>// draw the box that goes in front</c->
     context<c- p>.</c->save<c- p>();</c->
     context<c- p>.</c->translate<c- p>(</c->width<c- o>-</c-><c- p>((</c-><c- k>this</c-><c- p>.</c->offset<c- o>+</c-><c- p>(</c-><c- k>this</c-><c- p>.</c->width<c- o>*</c-><c- mf>0.7</c-><c- p>))</c-> <c- o>%</c-> <c- p>(</c-><c- k>this</c-><c- p>.</c->width<c- o>*</c-><c- mf>1.1</c-><c- p>))</c-><c- o>+</c-><c- mi>0</c-><c- p>,</c-> <c- mi>0</c-><c- p>);</c->
     context<c- p>.</c->beginPath<c- p>();</c->
     context<c- p>.</c->rect<c- p>(</c-><c- mi>0</c-><c- p>,</c-> <c- k>this</c-><c- p>.</c->horizon <c- o>-</c-> <c- mi>5</c-><c- p>,</c-> <c- mi>25</c-><c- p>,</c-> <c- mi>25</c-><c- p>);</c->
     context<c- p>.</c->fillStyle <c- o>=</c-> <c- t>&apos;rgb(220,154,94)&apos;</c-><c- p>;</c->
     context<c- p>.</c->lineStyle <c- o>=</c-> <c- t>&apos;rgb(10,10,10)&apos;</c-><c- p>;</c->
     context<c- p>.</c->lineWidth <c- o>=</c-> <c- mi>2</c-><c- p>;</c->
     context<c- p>.</c->fill<c- p>();</c->
     context<c- p>.</c->stroke<c- p>();</c->
     context<c- p>.</c->restore<c- p>();</c->
   <c- p>};</c->
 <c- p>};</c->
<c- p>&lt;/</c-><c- f>script</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>script</c-><c- p>&gt;</c->
 <c- a>var</c-> BlueRobot <c- o>=</c-> <c- a>function</c-> <c- p>()</c-> <c- p>{</c->
   <c- k>this</c-><c- p>.</c->sprites <c- o>=</c-> <c- k>new</c-> Image<c- p>();</c->
   <c- k>this</c-><c- p>.</c->sprites<c- p>.</c->src <c- o>=</c-> <c- t>&apos;blue-robot.png&apos;</c-><c- p>;</c-> <c- c1>// this sprite sheet has 8 cells</c->
   <c- k>this</c-><c- p>.</c->targetMode <c- o>=</c-> <c- t>&apos;idle&apos;</c-><c- p>;</c->
   <c- k>this</c-><c- p>.</c->walk <c- o>=</c-> <c- a>function</c-> <c- p>()</c-> <c- p>{</c->
     <c- k>this</c-><c- p>.</c->targetMode <c- o>=</c-> <c- t>&apos;walk&apos;</c-><c- p>;</c->
   <c- p>};</c->
   <c- k>this</c-><c- p>.</c->stop <c- o>=</c-> <c- a>function</c-> <c- p>()</c-> <c- p>{</c->
     <c- k>this</c-><c- p>.</c->targetMode <c- o>=</c-> <c- t>&apos;idle&apos;</c-><c- p>;</c->
   <c- p>};</c->
   <c- k>this</c-><c- p>.</c->frameIndex <c- o>=</c-> <c- p>{</c->
     <c- t>&apos;idle&apos;</c-><c- o>:</c-> <c- p>[</c-><c- mi>0</c-><c- p>],</c-> <c- c1>// first cell is the idle frame</c->
     <c- t>&apos;walk&apos;</c-><c- o>:</c-> <c- p>[</c-><c- mi>1</c-><c- p>,</c-><c- mi>2</c-><c- p>,</c-><c- mi>3</c-><c- p>,</c-><c- mi>4</c-><c- p>,</c-><c- mi>5</c-><c- p>,</c-><c- mi>6</c-><c- p>],</c-> <c- c1>// the walking animation is cells 1-6</c->
     <c- t>&apos;stop&apos;</c-><c- o>:</c-> <c- p>[</c-><c- mi>7</c-><c- p>],</c-> <c- c1>// last cell is the stopping animation</c->
   <c- p>};</c->
   <c- k>this</c-><c- p>.</c->mode <c- o>=</c-> <c- t>&apos;idle&apos;</c-><c- p>;</c->
   <c- k>this</c-><c- p>.</c->frame <c- o>=</c-> <c- mi>0</c-><c- p>;</c-> <c- c1>// index into frameIndex</c->
   <c- k>this</c-><c- p>.</c->tick <c- o>=</c-> <c- a>function</c-> <c- p>()</c-> <c- p>{</c->
     <c- c1>// this advances the frame and the robot</c->
     <c- c1>// the return value is how many pixels the robot has moved</c->
     <c- k>this</c-><c- p>.</c->frame <c- o>+=</c-> <c- mi>1</c-><c- p>;</c->
     <c- k>if</c-> <c- p>(</c-><c- k>this</c-><c- p>.</c->frame <c- o>&gt;=</c-> <c- k>this</c-><c- p>.</c->frameIndex<c- p>[</c-><c- k>this</c-><c- p>.</c->mode<c- p>].</c->length<c- p>)</c-> <c- p>{</c->
       <c- c1>// we&apos;ve reached the end of this animation cycle</c->
       <c- k>this</c-><c- p>.</c->frame <c- o>=</c-> <c- mi>0</c-><c- p>;</c->
       <c- k>if</c-> <c- p>(</c-><c- k>this</c-><c- p>.</c->mode <c- o>!=</c-> <c- k>this</c-><c- p>.</c->targetMode<c- p>)</c-> <c- p>{</c->
         <c- c1>// switch to next cycle</c->
         <c- k>if</c-> <c- p>(</c-><c- k>this</c-><c- p>.</c->mode <c- o>==</c-> <c- t>&apos;walk&apos;</c-><c- p>)</c-> <c- p>{</c->
           <c- c1>// we need to stop walking before we decide what to do next</c->
           <c- k>this</c-><c- p>.</c->mode <c- o>=</c-> <c- t>&apos;stop&apos;</c-><c- p>;</c->
         <c- p>}</c-> <c- k>else</c-> <c- k>if</c-> <c- p>(</c-><c- k>this</c-><c- p>.</c->mode <c- o>==</c-> <c- t>&apos;stop&apos;</c-><c- p>)</c-> <c- p>{</c->
           <c- k>if</c-> <c- p>(</c-><c- k>this</c-><c- p>.</c->targetMode <c- o>==</c-> <c- t>&apos;walk&apos;</c-><c- p>)</c->
             <c- k>this</c-><c- p>.</c->mode <c- o>=</c-> <c- t>&apos;walk&apos;</c-><c- p>;</c->
           <c- k>else</c->
             <c- k>this</c-><c- p>.</c->mode <c- o>=</c-> <c- t>&apos;idle&apos;</c-><c- p>;</c->
         <c- p>}</c-> <c- k>else</c-> <c- k>if</c-> <c- p>(</c-><c- k>this</c-><c- p>.</c->mode <c- o>==</c-> <c- t>&apos;idle&apos;</c-><c- p>)</c-> <c- p>{</c->
           <c- k>if</c-> <c- p>(</c-><c- k>this</c-><c- p>.</c->targetMode <c- o>==</c-> <c- t>&apos;walk&apos;</c-><c- p>)</c->
             <c- k>this</c-><c- p>.</c->mode <c- o>=</c-> <c- t>&apos;walk&apos;</c-><c- p>;</c->
         <c- p>}</c->
       <c- p>}</c->
     <c- p>}</c->
     <c- k>if</c-> <c- p>(</c-><c- k>this</c-><c- p>.</c->mode <c- o>==</c-> <c- t>&apos;walk&apos;</c-><c- p>)</c->
       <c- k>return</c-> <c- mi>8</c-><c- p>;</c->
     <c- k>return</c-> <c- mi>0</c-><c- p>;</c->
   <c- p>},</c->
   <c- k>this</c-><c- p>.</c->paint <c- o>=</c-> <c- a>function</c-> <c- p>(</c->context<c- p>,</c-> x<c- p>,</c-> y<c- p>)</c-> <c- p>{</c->
     <c- k>if</c-> <c- p>(</c-><c- o>!</c-><c- k>this</c-><c- p>.</c->sprites<c- p>.</c->complete<c- p>)</c-> <c- k>return</c-><c- p>;</c->
     <c- c1>// draw the right frame out of the sprite sheet onto the canvas</c->
     <c- c1>// we assume each frame is as high as the sprite sheet</c->
     <c- c1>// the x,y coordinates give the position of the bottom center of the sprite</c->
     context<c- p>.</c->drawImage<c- p>(</c-><c- k>this</c-><c- p>.</c->sprites<c- p>,</c->
                       <c- k>this</c-><c- p>.</c->frameIndex<c- p>[</c-><c- k>this</c-><c- p>.</c->mode<c- p>][</c-><c- k>this</c-><c- p>.</c->frame<c- p>]</c-> <c- o>*</c-> <c- k>this</c-><c- p>.</c->sprites<c- p>.</c->height<c- p>,</c-> <c- mi>0</c-><c- p>,</c-> <c- k>this</c-><c- p>.</c->sprites<c- p>.</c->height<c- p>,</c-> <c- k>this</c-><c- p>.</c->sprites<c- p>.</c->height<c- p>,</c->
                       x<c- o>-</c-><c- k>this</c-><c- p>.</c->sprites<c- p>.</c->height<c- o>/</c-><c- mi>2</c-><c- p>,</c-> y<c- o>-</c-><c- k>this</c-><c- p>.</c->sprites<c- p>.</c->height<c- p>,</c-> <c- k>this</c-><c- p>.</c->sprites<c- p>.</c->height<c- p>,</c-> <c- k>this</c-><c- p>.</c->sprites<c- p>.</c->height<c- p>);</c->
   <c- p>};</c->
 <c- p>};</c->
<c- p>&lt;/</c-><c- f>script</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>script</c-><c- p>&gt;</c->
 <c- a>var</c-> canvas <c- o>=</c-> document<c- p>.</c->getElementsByTagName<c- p>(</c-><c- t>&apos;canvas&apos;</c-><c- p>)[</c-><c- mi>0</c-><c- p>];</c->
 <c- a>var</c-> context <c- o>=</c-> canvas<c- p>.</c->getContext<c- p>(</c-><c- t>&apos;2d&apos;</c-><c- p>);</c->
 <c- a>var</c-> landscape <c- o>=</c-> <c- k>new</c-> Landscape<c- p>(</c->context<c- p>,</c-> canvas<c- p>.</c->width<c- p>,</c-> canvas<c- p>.</c->height<c- p>);</c->
 <c- a>var</c-> blueRobot <c- o>=</c-> <c- k>new</c-> BlueRobot<c- p>();</c->
 <c- c1>// paint when the browser wants us to, using requestAnimationFrame()</c->
 <c- a>function</c-> paint<c- p>()</c-> <c- p>{</c->
   context<c- p>.</c->clearRect<c- p>(</c-><c- mi>0</c-><c- p>,</c-> <c- mi>0</c-><c- p>,</c-> canvas<c- p>.</c->width<c- p>,</c-> canvas<c- p>.</c->height<c- p>);</c->
   landscape<c- p>.</c->paintBackground<c- p>(</c->context<c- p>,</c-> canvas<c- p>.</c->width<c- p>,</c-> canvas<c- p>.</c->height<c- p>);</c->
   blueRobot<c- p>.</c->paint<c- p>(</c->context<c- p>,</c-> canvas<c- p>.</c->width<c- o>/</c-><c- mi>2</c-><c- p>,</c-> landscape<c- p>.</c->horizon<c- o>*</c-><c- mf>1.1</c-><c- p>);</c->
   landscape<c- p>.</c->paintForeground<c- p>(</c->context<c- p>,</c-> canvas<c- p>.</c->width<c- p>,</c-> canvas<c- p>.</c->height<c- p>);</c->
   requestAnimationFrame<c- p>(</c->paint<c- p>);</c->
 <c- p>}</c->
 paint<c- p>();</c->
 <c- c1>// but tick every 100ms, so that we don&apos;t slow down when we don&apos;t paint</c->
 setInterval<c- p>(</c-><c- a>function</c-> <c- p>()</c-> <c- p>{</c->
   <c- a>var</c-> dx <c- o>=</c-> blueRobot<c- p>.</c->tick<c- p>();</c->
   landscape<c- p>.</c->advance<c- p>(</c->dx<c- p>);</c->
 <c- p>},</c-> <c- mi>100</c-><c- p>);</c->
<c- p>&lt;/</c-><c- f>script</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>p</c-> <c- e>class</c-><c- o>=</c-><c- s>&quot;buttons&quot;</c-><c- p>&gt;</c->
 <c- p>&lt;</c-><c- f>input</c-> <c- e>type</c-><c- o>=</c-><c- s>button</c-> <c- e>value</c-><c- o>=</c-><c- s>&quot;Walk&quot;</c-> <c- e>onclick</c-><c- o>=</c-><c- s>&quot;blueRobot.walk()&quot;</c-><c- p>&gt;</c->
 <c- p>&lt;</c-><c- f>input</c-> <c- e>type</c-><c- o>=</c-><c- s>button</c-> <c- e>value</c-><c- o>=</c-><c- s>&quot;Stop&quot;</c-> <c- e>onclick</c-><c- o>=</c-><c- s>&quot;blueRobot.stop()&quot;</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>footer</c-><c- p>&gt;</c->
 <c- p>&lt;</c-><c- f>small</c-><c- p>&gt;</c-> Blue Robot Player Sprite by <c- p>&lt;</c-><c- f>a</c-> <c- e>href</c-><c- o>=</c-><c- s>&quot;https://johncolburn.deviantart.com/&quot;</c-><c- p>&gt;</c->JohnColburn<c- p>&lt;/</c-><c- f>a</c-><c- p>&gt;</c->.
 Licensed under the terms of the Creative Commons Attribution Share-Alike 3.0 Unported license.<c- p>&lt;/</c-><c- f>small</c-><c- p>&gt;</c->
 <c- p>&lt;</c-><c- f>small</c-><c- p>&gt;</c-> This work is itself licensed under a <c- p>&lt;</c-><c- f>a</c-> <c- e>rel</c-><c- o>=</c-><c- s>&quot;license&quot;</c-> <c- e>href</c-><c- o>=</c-><c- s>&quot;https://creativecommons.org/licenses/by-sa/3.0/&quot;</c-><c- p>&gt;</c->Creative
 Commons Attribution-ShareAlike 3.0 Unported License<c- p>&lt;/</c-><c- f>a</c-><c- p>&gt;</c->.<c- p>&lt;/</c-><c- f>small</c-><c- p>&gt;</c->
<c- p>&lt;/</c-><c- f>footer</c-><c- p>&gt;</c->
</code></pre>

  </div>




  <h5 id=the-imagebitmap-rendering-context><span class=secno>4.12.5.2</span> The <code id=the-imagebitmap-rendering-context:imagebitmap><a href=imagebitmap-and-animations.html#imagebitmap>ImageBitmap</a></code> rendering context<a href=#the-imagebitmap-rendering-context class=self-link></a></h5>

  <h6 id=introduction-6><span class=secno>4.12.5.2.1</span> Introduction<a href=#introduction-6 class=self-link></a></h6>

  <p><code id=introduction-6:imagebitmaprenderingcontext><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingContext</a></code> is a performance-oriented interface that provides a
  low overhead method for displaying the contents of <code id=introduction-6:imagebitmap><a href=imagebitmap-and-animations.html#imagebitmap>ImageBitmap</a></code> objects. It uses
  transfer semantics to reduce overall memory consumption. It also streamlines performance by
  avoiding intermediate compositing, unlike the <code id=introduction-6:dom-context-2d-drawimage><a href=#dom-context-2d-drawimage>drawImage()</a></code> method of
  <code id=introduction-6:canvasrenderingcontext2d><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code>.</p>

  <p>Using an <code id=introduction-6:the-img-element><a href=embedded-content.html#the-img-element>img</a></code> element as an intermediate for getting an image resource into a
  canvas, for example, would result in two copies of the decoded image existing in memory at the
  same time: the <code id=introduction-6:the-img-element-2><a href=embedded-content.html#the-img-element>img</a></code> element's copy, and the one in the canvas's backing store. This
  memory cost can be prohibitive when dealing with extremely large images. This can be avoided by
  using <code id=introduction-6:imagebitmaprenderingcontext-2><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingContext</a></code>.</p>

  <div class=example>
   <p>Using <code id=introduction-6:imagebitmaprenderingcontext-3><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingContext</a></code>, here is how to transcode an image to the JPEG
   format in a memory- and CPU-efficient way:</p>

   <pre><code class='js'>createImageBitmap<c- p>(</c->inputImageBlob<c- p>).</c->then<c- p>(</c->image <c- p>=&gt;</c-> <c- p>{</c->
  <c- kr>const</c-> canvas <c- o>=</c-> document<c- p>.</c->createElement<c- p>(</c-><c- t>&apos;canvas&apos;</c-><c- p>);</c->
  <c- kr>const</c-> context <c- o>=</c-> canvas<c- p>.</c->getContext<c- p>(</c-><c- t>&apos;bitmaprenderer&apos;</c-><c- p>);</c->
  context<c- p>.</c->transferFromImageBitmap<c- p>(</c->image<c- p>);</c->

  canvas<c- p>.</c->toBlob<c- p>(</c->outputJPEGBlob <c- p>=&gt;</c-> <c- p>{</c->
    <c- c1>// Do something with outputJPEGBlob.</c->
  <c- p>},</c-> <c- t>&apos;image/jpeg&apos;</c-><c- p>);</c->
<c- p>});</c-></code></pre>
  </div>

  <h6 id=the-imagebitmaprenderingcontext-interface><span class=secno>4.12.5.2.2</span> The <code id=the-imagebitmaprenderingcontext-interface:imagebitmaprenderingcontext><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingContext</a></code> interface<a href=#the-imagebitmaprenderingcontext-interface class=self-link></a></h6><aside class="mdn-anno wrapped"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/ImageBitmapRenderingContext title="The ImageBitmapRenderingContext interface is a canvas rendering context that provides the functionality to replace the canvas's contents with the given ImageBitmap. Its context id (the first argument to HTMLCanvasElement.getContext() or OffscreenCanvas.getContext()) is &quot;bitmaprenderer&quot;.">ImageBitmapRenderingContext</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>46+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>66+</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>46+</span></span><span class="safari_ios unknown"><span>Safari iOS</span><span>?</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>66+</span></span><span class="webview_android yes"><span>WebView Android</span><span>66+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>9.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside>

  <pre><code class='idl'>[<c- g>Exposed</c->=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <dfn id='imagebitmaprenderingcontext'><c- g>ImageBitmapRenderingContext</c-></dfn> {
  <c- b>readonly</c-> <c- b>attribute</c-> (<a href='#htmlcanvaselement' id='the-imagebitmaprenderingcontext-interface:htmlcanvaselement'><c- n>HTMLCanvasElement</c-></a> <c- b>or</c-> <a href='#offscreencanvas' id='the-imagebitmaprenderingcontext-interface:offscreencanvas'><c- n>OffscreenCanvas</c-></a>) <a href='#dom-imagebitmaprenderingcontext-canvas' id='the-imagebitmaprenderingcontext-interface:dom-imagebitmaprenderingcontext-canvas'><c- g>canvas</c-></a>;
  <c- b>void</c-> <a href='#dom-imagebitmaprenderingcontext-transferfromimagebitmap' id='the-imagebitmaprenderingcontext-interface:dom-imagebitmaprenderingcontext-transferfromimagebitmap'><c- g>transferFromImageBitmap</c-></a>(<a href='imagebitmap-and-animations.html#imagebitmap' id='the-imagebitmaprenderingcontext-interface:imagebitmap'><c- n>ImageBitmap</c-></a>? <c- g>bitmap</c->);
};

<c- b>dictionary</c-> <dfn id='imagebitmaprenderingcontextsettings'><c- g>ImageBitmapRenderingContextSettings</c-></dfn> {
  <c- b>boolean</c-> <a href='#dom-imagebitmaprenderingcontextsettings-alpha' id='the-imagebitmaprenderingcontext-interface:dom-imagebitmaprenderingcontextsettings-alpha'><c- g>alpha</c-></a> = <c- b>true</c->;
};</code></pre>

  <dl class=domintro><dt><var>context</var> = <var>canvas</var> . <code id=the-imagebitmaprenderingcontext-interface:dom-canvas-getcontext><a href=#dom-canvas-getcontext>getContext</a></code>('bitmaprenderer' [, { [ <code id=the-imagebitmaprenderingcontext-interface:dom-imagebitmaprenderingcontextsettings-alpha-2><a href=#dom-imagebitmaprenderingcontextsettings-alpha>alpha</a></code>: false ] } ] )<dd>
    <p>Returns an <code id=the-imagebitmaprenderingcontext-interface:imagebitmaprenderingcontext-2><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingContext</a></code> object that is permanently bound to a
    particular <code id=the-imagebitmaprenderingcontext-interface:the-canvas-element><a href=#the-canvas-element>canvas</a></code> element.</p>

    <p>If the <code id=the-imagebitmaprenderingcontext-interface:dom-imagebitmaprenderingcontextsettings-alpha-3><a href=#dom-imagebitmaprenderingcontextsettings-alpha>alpha</a></code> setting is
    provided and set to false, then the canvas is forced to always be opaque.</p>
   <dt><var>context</var> . <code id=dom-imagebitmaprenderingcontext-canvas-dev><a href=#dom-imagebitmaprenderingcontext-canvas>canvas</a></code><dd>
    <p>Returns the <code id=the-imagebitmaprenderingcontext-interface:the-canvas-element-2><a href=#the-canvas-element>canvas</a></code> element that the context is bound to.</p>
   <dt><var>context</var> . <code id=dom-imagebitmaprenderingcontext-transferfromimagebitmap-dev><a href=#dom-imagebitmaprenderingcontext-transferfromimagebitmap>transferFromImageBitmap</a></code>(imageBitmap)<dd>
    <p>Transfers the underlying <a href=imagebitmap-and-animations.html#concept-imagebitmap-bitmap-data id=the-imagebitmaprenderingcontext-interface:concept-imagebitmap-bitmap-data>bitmap data</a>
    from <var>imageBitmap</var> to <var>context</var>, and the bitmap becomes the contents of the
    <code id=the-imagebitmaprenderingcontext-interface:the-canvas-element-3><a href=#the-canvas-element>canvas</a></code> element to which <var>context</var> is bound.</p>
   <dt><var>context</var> . <code id=the-imagebitmaprenderingcontext-interface:dom-imagebitmaprenderingcontext-transferfromimagebitmap-2><a href=#dom-imagebitmaprenderingcontext-transferfromimagebitmap>transferFromImageBitmap</a></code>(null)<dd>
    <p>Replaces contents of the <code id=the-imagebitmaprenderingcontext-interface:the-canvas-element-4><a href=#the-canvas-element>canvas</a></code> element to which <var>context</var>
    is bound with a <a id=the-imagebitmaprenderingcontext-interface:transparent-black href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a> bitmap whose size corresponds to the <code id=the-imagebitmaprenderingcontext-interface:attr-canvas-width><a href=#attr-canvas-width>width</a></code> and <code id=the-imagebitmaprenderingcontext-interface:attr-canvas-height><a href=#attr-canvas-height>height</a></code>
    content attributes of the <code id=the-imagebitmaprenderingcontext-interface:the-canvas-element-5><a href=#the-canvas-element>canvas</a></code> element.</p>
   </dl>

  

  <p>The <dfn id=dom-imagebitmaprenderingcontext-canvas><code>canvas</code></dfn> attribute
  must return the value it was initialized to when the object was created.</p>

  <p>An <code id=the-imagebitmaprenderingcontext-interface:imagebitmaprenderingcontext-3><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingContext</a></code> object has an <dfn id=concept-imagebitmaprenderingcontext-output-bitmap>output bitmap</dfn>, which is a
  reference to <a href=imagebitmap-and-animations.html#concept-imagebitmap-bitmap-data id=the-imagebitmaprenderingcontext-interface:concept-imagebitmap-bitmap-data-2>bitmap data</a>.</p>

  <p>An <code id=the-imagebitmaprenderingcontext-interface:imagebitmaprenderingcontext-4><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingContext</a></code> object has a <dfn id=concept-imagebitmaprenderingcontext-bitmap-mode>bitmap mode</dfn>, which can be set to
  <dfn id=concept-imagebitmaprenderingcontext-valid>valid</dfn> or <dfn id=concept-imagebitmaprenderingcontext-blank>blank</dfn>. A value of <a href=#concept-imagebitmaprenderingcontext-valid id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-valid>valid</a> indicates that the context's
  <a href=#concept-imagebitmaprenderingcontext-output-bitmap id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-output-bitmap>output bitmap</a> refers to
  <a href=imagebitmap-and-animations.html#concept-imagebitmap-bitmap-data id=the-imagebitmaprenderingcontext-interface:concept-imagebitmap-bitmap-data-3>bitmap data</a> that was acquired via <code id=the-imagebitmaprenderingcontext-interface:dom-imagebitmaprenderingcontext-transferfromimagebitmap-3><a href=#dom-imagebitmaprenderingcontext-transferfromimagebitmap>transferFromImageBitmap()</a></code>.
  A value <a href=#concept-imagebitmaprenderingcontext-blank id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-blank>blank</a> indicates that the
  context's <a href=#concept-imagebitmaprenderingcontext-output-bitmap id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-output-bitmap-2>output
  bitmap</a> is a default transparent bitmap.</p>

  <p>An <code id=the-imagebitmaprenderingcontext-interface:imagebitmaprenderingcontext-5><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingContext</a></code> object also has an <dfn id=concept-imagebitmaprenderingcontext-alpha>alpha</dfn> flag, which can be set to true or
  false. When an <code id=the-imagebitmaprenderingcontext-interface:imagebitmaprenderingcontext-6><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingContext</a></code> object has its <a href=#concept-imagebitmaprenderingcontext-alpha id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-alpha>alpha</a> flag set to false, the contents
  of the <code id=the-imagebitmaprenderingcontext-interface:the-canvas-element-6><a href=#the-canvas-element>canvas</a></code> element to which the context is bound are obtained by
  compositing the context's <a href=#concept-imagebitmaprenderingcontext-output-bitmap id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-output-bitmap-3>output bitmap</a> onto an
  <a id=the-imagebitmaprenderingcontext-interface:opaque-black href=https://drafts.csswg.org/css-color/#opaque-black data-x-internal=opaque-black>opaque black</a> bitmap of the same size using the source-over composite operation. If
  the <a href=#concept-imagebitmaprenderingcontext-alpha id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-alpha-2>alpha</a> flag is set to true,
  then the <a href=#concept-imagebitmaprenderingcontext-output-bitmap id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-output-bitmap-4>output bitmap</a> is
  used as the contents of the <code id=the-imagebitmaprenderingcontext-interface:the-canvas-element-7><a href=#the-canvas-element>canvas</a></code> element to which the context is bound. <a href=references.html#refsCOMPOSITE>[COMPOSITE]</a></p>

  <p class=note>The step of compositing over an <a id=the-imagebitmaprenderingcontext-interface:opaque-black-2 href=https://drafts.csswg.org/css-color/#opaque-black data-x-internal=opaque-black>opaque black</a> bitmap ought to be
  elided whenever equivalent results can be obtained more efficiently by other means.</p>

  <hr>

  <p>When a user agent is required to <dfn id="set-an-imagebitmaprenderingcontext's-output-bitmap">set an <code>ImageBitmapRenderingContext</code>'s output
  bitmap</dfn>, with a <var>context</var> argument that is an
  <code id=the-imagebitmaprenderingcontext-interface:imagebitmaprenderingcontext-7><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingContext</a></code> object and an optional argument <var>bitmap</var> that
  refers to <a href=imagebitmap-and-animations.html#concept-imagebitmap-bitmap-data id=the-imagebitmaprenderingcontext-interface:concept-imagebitmap-bitmap-data-4>bitmap data</a>, it must run these
  steps:</p>

  <ol><li><p>If a <var>bitmap</var> argument was not provided, then:</p>

    <ol><li><p>Set <var>context</var>'s <a href=#concept-imagebitmaprenderingcontext-bitmap-mode id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-bitmap-mode>bitmap mode</a> to <a href=#concept-imagebitmaprenderingcontext-blank id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-blank-2>blank</a>.<li><p>Let <var>canvas</var> be the <code id=the-imagebitmaprenderingcontext-interface:the-canvas-element-8><a href=#the-canvas-element>canvas</a></code> element to which <var>context</var>
     is bound.<li><p>Set <var>context</var>'s <a href=#concept-imagebitmaprenderingcontext-output-bitmap id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-output-bitmap-5>output bitmap</a> to be
     <a id=the-imagebitmaprenderingcontext-interface:transparent-black-2 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a> with an <a id=the-imagebitmaprenderingcontext-interface:intrinsic-width href=https://drafts.csswg.org/css-images/#intrinsic-width data-x-internal=intrinsic-width>intrinsic width</a> equal to <a href=#obtain-numeric-values id=the-imagebitmaprenderingcontext-interface:obtain-numeric-values>the numeric value</a> of <var>canvas</var>'s <code id=the-imagebitmaprenderingcontext-interface:attr-canvas-width-2><a href=#attr-canvas-width>width</a></code> attribute and an <a id=the-imagebitmaprenderingcontext-interface:intrinsic-height href=https://drafts.csswg.org/css-images/#intrinsic-height data-x-internal=intrinsic-height>intrinsic height</a> equal
     to <a href=#obtain-numeric-values id=the-imagebitmaprenderingcontext-interface:obtain-numeric-values-2>the numeric value</a> of <var>canvas</var>'s
     <code id=the-imagebitmaprenderingcontext-interface:attr-canvas-height-2><a href=#attr-canvas-height>height</a></code> attribute, those values being interpreted
     in <a href=https://drafts.csswg.org/css-values/#px id="the-imagebitmaprenderingcontext-interface:'px'" data-x-internal="'px'">CSS pixels</a>.<li><p>Set the <a href=#concept-imagebitmaprenderingcontext-output-bitmap id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-output-bitmap-6>output bitmap</a>'s <a href=#concept-canvas-origin-clean id=the-imagebitmaprenderingcontext-interface:concept-canvas-origin-clean>origin-clean</a> flag to true.</ol>
   <li><p>If a <var>bitmap</var> argument was provided, then:</p>

    <ol><li><p>Set <var>context</var>'s <a href=#concept-imagebitmaprenderingcontext-bitmap-mode id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-bitmap-mode-2>bitmap mode</a> to <a href=#concept-imagebitmaprenderingcontext-valid id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-valid-2>valid</a>.<li>
      <p>Set <var>context</var>'s <a href=#concept-imagebitmaprenderingcontext-output-bitmap id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-output-bitmap-7>output bitmap</a> to refer
      to the same underlying bitmap data as <var>bitmap</var>, without making a copy.</p>

      <p class=note>The <a href=#concept-canvas-origin-clean id=the-imagebitmaprenderingcontext-interface:concept-canvas-origin-clean-2>origin-clean</a> flag of
      <var>bitmap</var> is included in the bitmap data to be referenced by <var>context</var>'s
      <a href=#concept-imagebitmaprenderingcontext-output-bitmap id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-output-bitmap-8>output bitmap</a>.</p>
     </ol>
   </ol>

  <hr>

  <p>The <dfn id=imagebitmaprenderingcontext-creation-algorithm><code>ImageBitmapRenderingContext</code> creation algorithm</dfn>, which is passed a
  <var>target</var> and <var>options</var>, consists of running these steps:</p>

  <ol><li><p>Let <var>settings</var> be the result of <a href=https://heycam.github.io/webidl/#es-type-mapping id=the-imagebitmaprenderingcontext-interface:concept-idl-convert data-x-internal=concept-idl-convert>converting</a> <var>options</var> to the dictionary type
   <code id=the-imagebitmaprenderingcontext-interface:imagebitmaprenderingcontextsettings><a href=#imagebitmaprenderingcontextsettings>ImageBitmapRenderingContextSettings</a></code>. (This can throw an exception.)<li><p>Let <var>context</var> be a new <code id=the-imagebitmaprenderingcontext-interface:imagebitmaprenderingcontext-8><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingContext</a></code> object.<li><p>Initialize <var>context</var>'s <code id=the-imagebitmaprenderingcontext-interface:dom-context-2d-canvas><a href=#dom-context-2d-canvas>canvas</a></code>
   attribute to point to <var>target</var>.<li><p>Set <var>context</var>'s <a href=#concept-imagebitmaprenderingcontext-output-bitmap id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-output-bitmap-9>output bitmap</a> to the same
   bitmap as <var>target</var>'s bitmap (so that they are shared).<li><p>Run the steps to <a href="#set-an-imagebitmaprenderingcontext's-output-bitmap" id="the-imagebitmaprenderingcontext-interface:set-an-imagebitmaprenderingcontext's-output-bitmap">set an <code>ImageBitmapRenderingContext</code>'s output
   bitmap</a> with <var>context</var>.<li><p>Initialize <var>context</var>'s <a href=#concept-imagebitmaprenderingcontext-alpha id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-alpha-3>alpha</a> flag to true.

   <li>
    <p>Process each of the members of <var>settings</var> as follows:</p>

    <dl><dt><dfn id=dom-imagebitmaprenderingcontextsettings-alpha><code>alpha</code></dfn><dd>If false, then set <var>context</var>'s <a href=#concept-imagebitmaprenderingcontext-alpha id=the-imagebitmaprenderingcontext-interface:concept-imagebitmaprenderingcontext-alpha-4>alpha</a> flag to false.</dl>
   <li><p>Return <var>context</var>.</ol>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/ImageBitmapRenderingContext/transferFromImageBitmap title="The ImageBitmapRenderingContext.transferFromImageBitmap() method displays the given ImageBitmap in the canvas associated with this rendering context. The ownership of the ImageBitmap is transferred to the canvas as well.">ImageBitmapRenderingContext/transferFromImageBitmap</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>52+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>66+</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>52+</span></span><span class="safari_ios unknown"><span>Safari iOS</span><span>?</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>66+</span></span><span class="webview_android yes"><span>WebView Android</span><span>66+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>9.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-imagebitmaprenderingcontext-transferfromimagebitmap><code>transferFromImageBitmap(<var>imageBitmap</var>)</code></dfn>
  method, when invoked, must run these steps:</p>

  <ol><li><p>Let <var>bitmapContext</var> be the <code id=the-imagebitmaprenderingcontext-interface:imagebitmaprenderingcontext-9><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingContext</a></code> object on
   which the <code id=the-imagebitmaprenderingcontext-interface:dom-imagebitmaprenderingcontext-transferfromimagebitmap-4><a href=#dom-imagebitmaprenderingcontext-transferfromimagebitmap>transferFromImageBitmap()</a></code>
   method was called.<li><p>If <var>imageBitmap</var> is null, then run the steps to <a href="#set-an-imagebitmaprenderingcontext's-output-bitmap" id="the-imagebitmaprenderingcontext-interface:set-an-imagebitmaprenderingcontext's-output-bitmap-2">set an
   ImageBitmapRenderingContext's output bitmap</a>, with <var>bitmapContext</var> as the
   <var>context</var> argument and no <var>bitmap</var> argument, then return.<li><p>If the value of <var>imageBitmap</var>'s <a id=the-imagebitmaprenderingcontext-interface:detached href=structured-data.html#detached>[[Detached]]</a> internal slot is set to
   true, then throw an <a id=the-imagebitmaprenderingcontext-interface:invalidstateerror href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=the-imagebitmaprenderingcontext-interface:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Run the steps to <a href="#set-an-imagebitmaprenderingcontext's-output-bitmap" id="the-imagebitmaprenderingcontext-interface:set-an-imagebitmaprenderingcontext's-output-bitmap-3">set an <code>ImageBitmapRenderingContext</code>'s output
   bitmap</a>, with the <var>context</var> argument equal to <var>bitmapContext</var>, and the
   <var>bitmap</var> argument referring to <var>imageBitmap</var>'s underlying <a href=imagebitmap-and-animations.html#concept-imagebitmap-bitmap-data id=the-imagebitmaprenderingcontext-interface:concept-imagebitmap-bitmap-data-5>bitmap data</a>.

   <li><p>Set the value of <var>imageBitmap</var>'s <a id=the-imagebitmaprenderingcontext-interface:detached-2 href=structured-data.html#detached>[[Detached]]</a> internal slot to
   true.<li><p>Unset <var>imageBitmap's</var> <a href=imagebitmap-and-animations.html#concept-imagebitmap-bitmap-data id=the-imagebitmaprenderingcontext-interface:concept-imagebitmap-bitmap-data-6>bitmap
   data</a>.</ol>

  




  <h5 id=the-offscreencanvas-interface><span class=secno>4.12.5.3</span> The <code id=the-offscreencanvas-interface:offscreencanvas><a href=#offscreencanvas>OffscreenCanvas</a></code> interface<a href=#the-offscreencanvas-interface class=self-link></a></h5><div class=status><input onclick=toggleStatus(this) value=⋰ type=button><p class=support><strong>Support:</strong> offscreencanvas<span class="and_chr yes"><span>Chrome for Android</span> <span>80+</span></span><span class="chrome yes"><span>Chrome</span> <span>69+</span></span><span class="ios_saf no"><span>iOS Safari</span> <span>None</span></span><span class="firefox no"><span>Firefox</span> <span>None</span></span><span class="safari no"><span>Safari</span> <span>None</span></span><span class="samsung yes"><span>Samsung Internet</span> <span>10.1+</span></span><span class="and_uc no"><span>UC Browser for Android</span> <span>None</span></span><span class="edge yes"><span>Edge</span> <span>79+</span></span><span class="ie no"><span>IE</span> <span>None</span></span><span class="opera yes"><span>Opera</span> <span>64+</span></span><span class="op_mini no"><span>Opera Mini</span> <span>None</span></span><span class="android yes"><span>Android Browser</span> <span>80+</span></span><p class=caniuse>Source: <a href="https://caniuse.com/#feat=offscreencanvas">caniuse.com</a></div><aside class="mdn-anno wrapped"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in one engine only." class=less-than-two-engines-flag>⚠</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/OffscreenCanvas title="The OffscreenCanvas interface provides a canvas that can be rendered off screen. It is available in both the window and worker contexts.">OffscreenCanvas</a><p class=less-than-two-engines-text>Support in one engine only.<div class=support><span class="firefox yes"><span>Firefox</span><span title="Partial implementation.">🔰 44+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>69+</span></span><hr><span class="opera yes"><span>Opera</span><span>56+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span title="Partial implementation.">🔰 44+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>69+</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>10.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>48+</span></span></div></div></aside>

  <pre><code class='idl'><c- b>typedef</c-> (<a href='#offscreencanvasrenderingcontext2d' id='the-offscreencanvas-interface:offscreencanvasrenderingcontext2d'><c- n>OffscreenCanvasRenderingContext2D</c-></a> <c- b>or</c-> <a href='#imagebitmaprenderingcontext' id='the-offscreencanvas-interface:imagebitmaprenderingcontext'><c- n>ImageBitmapRenderingContext</c-></a> <c- b>or</c-> <a href='https://www.khronos.org/registry/webgl/specs/latest/1.0/#WebGLRenderingContext' data-x-internal='webglrenderingcontext' id='the-offscreencanvas-interface:webglrenderingcontext'><c- n>WebGLRenderingContext</c-></a> <c- b>or</c-> <a href='https://www.khronos.org/registry/webgl/specs/latest/2.0/#WebGL2RenderingContext' data-x-internal='webgl2renderingcontext' id='the-offscreencanvas-interface:webgl2renderingcontext'><c- n>WebGL2RenderingContext</c-></a>) <dfn id='offscreenrenderingcontext'><c- g>OffscreenRenderingContext</c-></dfn>;

<c- b>dictionary</c-> <dfn id='imageencodeoptions'><c- g>ImageEncodeOptions</c-></dfn> {
  <c- b>DOMString</c-> <a href='#image-encode-options-type' id='the-offscreencanvas-interface:image-encode-options-type'><c- g>type</c-></a> = &quot;image/png&quot;;
  <c- b>unrestricted</c-> <c- b>double</c-> <a href='#image-encode-options-quality' id='the-offscreencanvas-interface:image-encode-options-quality'><c- g>quality</c-></a>;
};

<c- b>enum</c-> <dfn id='offscreenrenderingcontextid'><c- g>OffscreenRenderingContextId</c-></dfn> { <c- s>&quot;</c-><a href='#offscreen-context-type-2d' id='the-offscreencanvas-interface:offscreen-context-type-2d'><c- s>2d</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#offscreen-context-type-bitmaprenderer' id='the-offscreencanvas-interface:offscreen-context-type-bitmaprenderer'><c- s>bitmaprenderer</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#offscreen-context-type-webgl' id='the-offscreencanvas-interface:offscreen-context-type-webgl'><c- s>webgl</c-></a><c- s>&quot;</c->, <c- s>&quot;</c-><a href='#offscreen-context-type-webgl2' id='the-offscreencanvas-interface:offscreen-context-type-webgl2'><c- s>webgl2</c-></a><c- s>&quot;</c-> };

[<c- g>Exposed</c->=(<c- n>Window</c->,<c- n>Worker</c->), <a href='structured-data.html#transferable' id='the-offscreencanvas-interface:transferable'><c- g>Transferable</c-></a>]
<c- b>interface</c-> <dfn id='offscreencanvas'><c- g>OffscreenCanvas</c-></dfn> : <a href='https://dom.spec.whatwg.org/#interface-eventtarget' data-x-internal='eventtarget' id='the-offscreencanvas-interface:eventtarget'><c- n>EventTarget</c-></a> {
  <a href='#dom-offscreencanvas' id='the-offscreencanvas-interface:dom-offscreencanvas'><c- b>constructor</c-></a>([<c- g>EnforceRange</c->] <c- b>unsigned</c-> <c- b>long</c-> <c- b>long</c-> <c- g>width</c->, [<c- g>EnforceRange</c->] <c- b>unsigned</c-> <c- b>long</c-> <c- b>long</c-> <c- g>height</c->);

  <c- b>attribute</c-> [<c- g>EnforceRange</c->] <c- b>unsigned</c-> <c- b>long</c-> <c- b>long</c-> <a href='#dom-offscreencanvas-width' id='the-offscreencanvas-interface:dom-offscreencanvas-width'><c- g>width</c-></a>;
  <c- b>attribute</c-> [<c- g>EnforceRange</c->] <c- b>unsigned</c-> <c- b>long</c-> <c- b>long</c-> <a href='#dom-offscreencanvas-height' id='the-offscreencanvas-interface:dom-offscreencanvas-height'><c- g>height</c-></a>;

  <a href='#offscreenrenderingcontext' id='the-offscreencanvas-interface:offscreenrenderingcontext'><c- n>OffscreenRenderingContext</c-></a>? <a href='#dom-offscreencanvas-getcontext' id='the-offscreencanvas-interface:dom-offscreencanvas-getcontext'><c- g>getContext</c-></a>(<a href='#offscreenrenderingcontextid' id='the-offscreencanvas-interface:offscreenrenderingcontextid'><c- n>OffscreenRenderingContextId</c-></a> <c- g>contextId</c->, <c- b>optional</c-> <c- b>any</c-> <c- g>options</c-> = <c- b>null</c->);
  <a href='imagebitmap-and-animations.html#imagebitmap' id='the-offscreencanvas-interface:imagebitmap'><c- n>ImageBitmap</c-></a> <a href='#dom-offscreencanvas-transfertoimagebitmap' id='the-offscreencanvas-interface:dom-offscreencanvas-transfertoimagebitmap'><c- g>transferToImageBitmap</c-></a>();
  <c- b>Promise</c->&lt;<a href='https://w3c.github.io/FileAPI/#dfn-Blob' data-x-internal='blob' id='the-offscreencanvas-interface:blob'><c- n>Blob</c-></a>&gt; <a href='#dom-offscreencanvas-converttoblob' id='the-offscreencanvas-interface:dom-offscreencanvas-converttoblob'><c- g>convertToBlob</c-></a>(<c- b>optional</c-> <a href='#imageencodeoptions' id='the-offscreencanvas-interface:imageencodeoptions'><c- n>ImageEncodeOptions</c-></a> <c- g>options</c-> = {});
};</code></pre>

  <p class=note><code id=the-offscreencanvas-interface:offscreencanvas-2><a href=#offscreencanvas>OffscreenCanvas</a></code> is an <code id=the-offscreencanvas-interface:eventtarget-2><a data-x-internal=eventtarget href=https://dom.spec.whatwg.org/#interface-eventtarget>EventTarget</a></code> so that WebGL can
  fire <code>webglcontextlost</code> and <code>webglcontextrestored</code>
  events at it. <a href=references.html#refsWEBGL>[WEBGL]</a></p>

  <p><code id=the-offscreencanvas-interface:offscreencanvas-3><a href=#offscreencanvas>OffscreenCanvas</a></code> objects are used to create rendering contexts, much like an
  <code id=the-offscreencanvas-interface:htmlcanvaselement><a href=#htmlcanvaselement>HTMLCanvasElement</a></code>, but with no connection to the DOM. This makes it possible to
  use canvas rendering contexts in <a href=workers.html#workers>workers</a>.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in one engine only." class=less-than-two-engines-flag>⚠</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/WebGLRenderingContext/commit title="The WebGLRenderingContext.commit() method pushes frames back to the original HTMLCanvasElement, if the context is not directly fixed to a specific canvas.">WebGLRenderingContext/commit</a><p class=less-than-two-engines-text>Support in one engine only.<div class=support><span class="firefox yes"><span>Firefox</span><span title="Requires setting a user preference or runtime flag.">🔰 44+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome no"><span>Chrome</span><span>No</span></span><hr><span class="opera no"><span>Opera</span><span>No</span></span><span class="edge_blink no"><span>Edge</span><span>No</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><p>An <code id=the-offscreencanvas-interface:offscreencanvas-4><a href=#offscreencanvas>OffscreenCanvas</a></code> object may hold a weak reference to a <dfn id=offscreencanvas-placeholder>placeholder <code>canvas</code> element</dfn>, which is
  typically in the DOM, whose embedded content is provided by the <code id=the-offscreencanvas-interface:offscreencanvas-5><a href=#offscreencanvas>OffscreenCanvas</a></code>
  object. The bitmap of the <code id=the-offscreencanvas-interface:offscreencanvas-6><a href=#offscreencanvas>OffscreenCanvas</a></code> object is pushed to the <a href=#offscreencanvas-placeholder id=the-offscreencanvas-interface:offscreencanvas-placeholder>placeholder <code>canvas</code> element</a> by
  calling the <dfn id=offscreencontext-commit><code>commit()</code></dfn> method of the
  <code id=the-offscreencanvas-interface:offscreencanvas-7><a href=#offscreencanvas>OffscreenCanvas</a></code> object's rendering context. All rendering context types that
  can be created by an <code id=the-offscreencanvas-interface:offscreencanvas-8><a href=#offscreencanvas>OffscreenCanvas</a></code> object must implement a <code id=the-offscreencanvas-interface:offscreencontext-commit><a href=#offscreencontext-commit>commit()</a></code> method. The exact behavior of the commit
  method (e.g. whether it copies or transfers bitmaps) may vary, as defined by the rendering
  contexts' respective specifications. Only the <a href=#offscreencanvasrenderingcontext2d id=the-offscreencanvas-interface:offscreencanvasrenderingcontext2d-2>2D context for offscreen canvases</a> is defined
  in this specification.</p>

  <dl class=domintro><dt><var>offscreenCanvas</var> = new <code id=dom-offscreencanvas-dev><a href=#dom-offscreencanvas>OffscreenCanvas</a></code>(<var>width</var>,
   <var>height</var>)<dt>
   <dd>
    <p>Returns a new <code id=the-offscreencanvas-interface:offscreencanvas-9><a href=#offscreencanvas>OffscreenCanvas</a></code> object that is not linked to a <a href=#offscreencanvas-placeholder id=the-offscreencanvas-interface:offscreencanvas-placeholder-2>placeholder <code>canvas</code> element</a>, and
    whose bitmap's size is determined by the <var>width</var> and <var>height</var> arguments.</p>
   <dt><var>context</var> = <var>offscreenCanvas</var> . <code id=dom-offscreencanvas-getcontext-dev><a href=#dom-offscreencanvas-getcontext>getContext</a></code>(<var>contextId</var> [,
   <var>options</var> ] )<dd>
    <p>Returns an object that exposes an API for drawing on the <code id=the-offscreencanvas-interface:offscreencanvas-10><a href=#offscreencanvas>OffscreenCanvas</a></code>
    object. <var>contextId</var> specifies the desired API: "<code id=the-offscreencanvas-interface:offscreen-context-type-2d-2><a href=#offscreen-context-type-2d>2d</a></code>", "<code id=the-offscreencanvas-interface:offscreen-context-type-bitmaprenderer-2><a href=#offscreen-context-type-bitmaprenderer>bitmaprenderer</a></code>", "<code id=the-offscreencanvas-interface:offscreen-context-type-webgl-2><a href=#offscreen-context-type-webgl>webgl</a></code>", or "<code id=the-offscreencanvas-interface:offscreen-context-type-webgl2-2><a href=#offscreen-context-type-webgl2>webgl2</a></code>". <var>options</var> is handled by that
    API.</p>

    <p>This specification defines the "<code id=the-offscreencanvas-interface:canvas-context-2d><a href=#canvas-context-2d>2d</a></code>" context below,
    which is similar but distinct from the "<code id=the-offscreencanvas-interface:offscreen-context-type-2d-3><a href=#offscreen-context-type-2d>2d</a></code>"
    context that is created from a <code id=the-offscreencanvas-interface:the-canvas-element><a href=#the-canvas-element>canvas</a></code> element. The WebGL specifications define the
    "<code id=the-offscreencanvas-interface:offscreen-context-type-webgl-3><a href=#offscreen-context-type-webgl>webgl</a></code>" and "<code id=the-offscreencanvas-interface:offscreen-context-type-webgl2-3><a href=#offscreen-context-type-webgl2>webgl2</a></code>" contexts. <a href=references.html#refsWEBGL>[WEBGL]</a></p>

    <p>Returns null if the canvas has already been initialized with another context type (e.g.,
    trying to get a "<code id=the-offscreencanvas-interface:offscreen-context-type-2d-4><a href=#offscreen-context-type-2d>2d</a></code>" context after getting a
    "<code id=the-offscreencanvas-interface:offscreen-context-type-webgl-4><a href=#offscreen-context-type-webgl>webgl</a></code>" context).</p>
   </dl>

  

  <p>An <code id=the-offscreencanvas-interface:offscreencanvas-11><a href=#offscreencanvas>OffscreenCanvas</a></code> object has an internal <dfn id=offscreencanvas-bitmap>bitmap</dfn> that is initialized when the object
  is created. The width and height of the <a href=#offscreencanvas-bitmap id=the-offscreencanvas-interface:offscreencanvas-bitmap>bitmap</a> are
  equal to the values of the <code id=the-offscreencanvas-interface:dom-offscreencanvas-width-2><a href=#dom-offscreencanvas-width>width</a></code> and <code id=the-offscreencanvas-interface:dom-offscreencanvas-height-2><a href=#dom-offscreencanvas-height>height</a></code> attributes of the <code id=the-offscreencanvas-interface:offscreencanvas-12><a href=#offscreencanvas>OffscreenCanvas</a></code>
  object. Initially, all the bitmap's pixels are <a id=the-offscreencanvas-interface:transparent-black href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a>.</p>

  <p>An <code id=the-offscreencanvas-interface:offscreencanvas-13><a href=#offscreencanvas>OffscreenCanvas</a></code> object can have a rendering context bound to it. Initially,
  it does not have a bound rendering context. To keep track of whether it has a rendering context
  or not, and what kind of rendering context it is, an <code id=the-offscreencanvas-interface:offscreencanvas-14><a href=#offscreencanvas>OffscreenCanvas</a></code> object also
  has a <dfn id=offscreencanvas-context-mode>context mode</dfn>, which is initially <dfn id=offscreencanvas-context-none>none</dfn> but can be changed to either <dfn id=offscreencanvas-context-2d>2d</dfn>, <dfn id=offscreencanvas-context-bitmaprenderer>bitmaprenderer</dfn>, <dfn id=offscreencanvas-context-webgl>webgl</dfn>, <dfn id=offscreencanvas-context-webgl2>webgl2</dfn>, or <dfn id=offscreencanvas-context-detached>detached</dfn> by algorithms defined in this
  specification.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in one engine only." class=less-than-two-engines-flag>⚠</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/OffscreenCanvas/OffscreenCanvas title="The OffscreenCanvas() constructor returns a newly instantiated OffscreenCanvas object.">OffscreenCanvas/OffscreenCanvas</a><p class=less-than-two-engines-text>Support in one engine only.<div class=support><span class="firefox yes"><span>Firefox</span><span title="Partial implementation.">🔰 46+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>69+</span></span><hr><span class="opera yes"><span>Opera</span><span>56+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span title="Partial implementation.">🔰 46+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>69+</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>10.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The constructor <dfn id=dom-offscreencanvas><code>OffscreenCanvas(<var>width</var>,
  <var>height</var>)</code></dfn>, when invoked, must create a new <code id=the-offscreencanvas-interface:offscreencanvas-15><a href=#offscreencanvas>OffscreenCanvas</a></code>
  object with its <a href=#offscreencanvas-bitmap id=the-offscreencanvas-interface:offscreencanvas-bitmap-2>bitmap</a> initialized to a rectangular
  array of <a id=the-offscreencanvas-interface:transparent-black-2 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a> pixels of the dimensions specified by <var>width</var> and
  <var>height</var>; and its <code id=the-offscreencanvas-interface:dom-offscreencanvas-width-3><a href=#dom-offscreencanvas-width>width</a></code> and <code id=the-offscreencanvas-interface:dom-offscreencanvas-height-3><a href=#dom-offscreencanvas-height>height</a></code> attributes initialized to <var>width</var> and
  <var>height</var> respectively.</p>

  <hr>

  <p><code id=the-offscreencanvas-interface:offscreencanvas-16><a href=#offscreencanvas>OffscreenCanvas</a></code> objects are <a href=structured-data.html#transferable-objects id=the-offscreencanvas-interface:transferable-objects>transferable</a>. Their <a id=the-offscreencanvas-interface:transfer-steps href=structured-data.html#transfer-steps>transfer steps</a>, given <var>value</var> and
  <var>dataHolder</var>, are as follows:</p>

  <ol><li><p>If <var>value</var>'s <a href=#offscreencanvas-context-mode id=the-offscreencanvas-interface:offscreencanvas-context-mode>context mode</a> is
   not equal to <a href=#offscreencanvas-context-none id=the-offscreencanvas-interface:offscreencanvas-context-none>none</a>, then throw an
   <a id=the-offscreencanvas-interface:invalidstateerror href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=the-offscreencanvas-interface:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Set <var>value</var>'s <a href=#offscreencanvas-context-mode id=the-offscreencanvas-interface:offscreencanvas-context-mode-2>context mode</a> to
   <a href=#offscreencanvas-context-detached id=the-offscreencanvas-interface:offscreencanvas-context-detached>detached</a>.<li><p>Let <var>width</var> and <var>height</var> be the dimensions of <var>value</var>'s <a href=#offscreencanvas-bitmap id=the-offscreencanvas-interface:offscreencanvas-bitmap-3>bitmap</a>.<li><p>Unset <var>value</var>'s <a href=#offscreencanvas-bitmap id=the-offscreencanvas-interface:offscreencanvas-bitmap-4>bitmap</a>.<li><p>Set <var>dataHolder</var>.[[Width]] to <var>width</var> and
   <var>dataHolder</var>.[[Height]] to <var>height</var>.<li><p>Set <var>dataHolder</var>.[[PlaceholderCanvas]] to be a weak reference to
   <var>value</var>'s <a href=#offscreencanvas-placeholder id=the-offscreencanvas-interface:offscreencanvas-placeholder-3>placeholder <code>canvas</code>
   element</a>, if <var>value</var> has one, or null if it does not.</ol>

  <p>Their <a id=the-offscreencanvas-interface:transfer-receiving-steps href=structured-data.html#transfer-receiving-steps>transfer-receiving steps</a>, given <var>dataHolder</var> and <var>value</var>,
  are:</p>

  <ol><li><p>Initialize <var>value</var>'s <a href=#offscreencanvas-bitmap id=the-offscreencanvas-interface:offscreencanvas-bitmap-5>bitmap</a> to a
   rectangular array of <a id=the-offscreencanvas-interface:transparent-black-3 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a> pixels with width given by
   <var>dataHolder</var>.[[Width]] and height given by <var>dataHolder</var>.[[Height]].<li><p>If <var>dataHolder</var>.[[PlaceholderCanvas]] is not null, set <var>value</var>'s <a href=#offscreencanvas-placeholder id=the-offscreencanvas-interface:offscreencanvas-placeholder-4>placeholder <code>canvas</code> element</a> to
   <var>dataHolder</var>.[[PlaceholderCanvas]] (while maintaining the weak reference
   semantics).</ol>

  <hr>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in one engine only." class=less-than-two-engines-flag>⚠</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/OffscreenCanvas/getContext title="The OffscreenCanvas.getContext() method returns a drawing context for an offscreen canvas, or null if the context identifier is not supported.">OffscreenCanvas/getContext</a><p class=less-than-two-engines-text>Support in one engine only.<div class=support><span class="firefox yes"><span>Firefox</span><span title="Partial implementation.">🔰 44+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>69+</span></span><hr><span class="opera yes"><span>Opera</span><span>56+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span title="Partial implementation.">🔰 44+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>69+</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>10.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>48+</span></span></div></div></aside><p>The <dfn id=dom-offscreencanvas-getcontext><code>getContext(<var>contextId</var>,
  <var>options</var>)</code></dfn> method of an <code id=the-offscreencanvas-interface:offscreencanvas-17><a href=#offscreencanvas>OffscreenCanvas</a></code> object, when
  invoked, must run these steps:</p>

  <ol><li><p>If <var>options</var> is not an <a href=https://heycam.github.io/webidl/#idl-object id=the-offscreencanvas-interface:idl-object data-x-internal=idl-object>object</a>, then set
   <var>options</var> to null.<li><p>Set <var>options</var> to the result of <a href=https://heycam.github.io/webidl/#es-type-mapping id=the-offscreencanvas-interface:concept-idl-convert data-x-internal=concept-idl-convert>converting</a> <var>options</var> to a JavaScript value.<li>
    <p>Run the steps in the cell of the following table whose column header matches this
    <code id=the-offscreencanvas-interface:offscreencanvas-18><a href=#offscreencanvas>OffscreenCanvas</a></code> object's <a href=#offscreencanvas-context-mode id=the-offscreencanvas-interface:offscreencanvas-context-mode-3>context
    mode</a> and whose row header matches <var>contextId</var>:</p>

    <table><thead><tr><td>
       <th><a href=#offscreencanvas-context-none id=the-offscreencanvas-interface:offscreencanvas-context-none-2>none</a>
       <th><a href=#offscreencanvas-context-2d id=the-offscreencanvas-interface:offscreencanvas-context-2d>2d</a>
       <th><a href=#offscreencanvas-context-bitmaprenderer id=the-offscreencanvas-interface:offscreencanvas-context-bitmaprenderer>bitmaprenderer</a>
       <th><a href=#offscreencanvas-context-webgl id=the-offscreencanvas-interface:offscreencanvas-context-webgl>webgl</a> or <a href=#offscreencanvas-context-webgl2 id=the-offscreencanvas-interface:offscreencanvas-context-webgl2>webgl2</a>
       <th><a href=#offscreencanvas-context-detached id=the-offscreencanvas-interface:offscreencanvas-context-detached-2>detached</a>
     <tbody><tr><th>"<dfn id=offscreen-context-type-2d><code>2d</code></dfn>"
       <td>
        Follow the <a href=#offscreen-2d-context-creation-algorithm id=the-offscreencanvas-interface:offscreen-2d-context-creation-algorithm>offscreen 2D context
        creation algorithm</a> defined in the section below, passing it this
        <code id=the-offscreencanvas-interface:offscreencanvas-19><a href=#offscreencanvas>OffscreenCanvas</a></code> object and <var>options</var>, to obtain an
        <code id=the-offscreencanvas-interface:offscreencanvasrenderingcontext2d-3><a href=#offscreencanvasrenderingcontext2d>OffscreenCanvasRenderingContext2D</a></code> object; if this does not throw an exception,
        then set this <code id=the-offscreencanvas-interface:offscreencanvas-20><a href=#offscreencanvas>OffscreenCanvas</a></code> object's <a href=#offscreencanvas-context-mode id=the-offscreencanvas-interface:offscreencanvas-context-mode-4>context mode</a> to <a href=#offscreencanvas-context-2d id=the-offscreencanvas-interface:offscreencanvas-context-2d-2>2d</a>, and return the new
        <code id=the-offscreencanvas-interface:offscreencanvasrenderingcontext2d-4><a href=#offscreencanvasrenderingcontext2d>OffscreenCanvasRenderingContext2D</a></code> object.
       <td>
        Return the same object as was returned the last time the method was invoked with this same
        first argument.
       <td>
        Return null.
       <td>
        Return null.
       <td>
        Throw an <a id=the-offscreencanvas-interface:invalidstateerror-2 href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=the-offscreencanvas-interface:domexception-2><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.
      <tr><th>"<dfn id=offscreen-context-type-bitmaprenderer><code>bitmaprenderer</code></dfn>"
       <td>
        Follow the <a href=#imagebitmaprenderingcontext-creation-algorithm id=the-offscreencanvas-interface:imagebitmaprenderingcontext-creation-algorithm><code>ImageBitmapRenderingContext</code> creation algorithm</a>
        defined in the section above, passing it this
        <code id=the-offscreencanvas-interface:offscreencanvas-21><a href=#offscreencanvas>OffscreenCanvas</a></code> object and <var>options</var>,
        to obtain an <code id=the-offscreencanvas-interface:imagebitmaprenderingcontext-2><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingcontext</a></code> object; if this does not throw
        an exception, then set this <code id=the-offscreencanvas-interface:offscreencanvas-22><a href=#offscreencanvas>OffscreenCanvas</a></code> object's <a href=#offscreencanvas-context-mode id=the-offscreencanvas-interface:offscreencanvas-context-mode-5>context mode</a> to <a href=#offscreencanvas-context-bitmaprenderer id=the-offscreencanvas-interface:offscreencanvas-context-bitmaprenderer-2>bitmaprenderer</a>, and return the new
        <code id=the-offscreencanvas-interface:imagebitmaprenderingcontext-3><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingcontext</a></code> object.
       <td>
        Return null.
       <td>
        Return the same object as was returned the last time the method was invoked with this same
        first argument.
       <td>
        Return null.
       <td>
        Throw an <a id=the-offscreencanvas-interface:invalidstateerror-3 href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=the-offscreencanvas-interface:domexception-3><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.
      <tr><th>"<dfn id=offscreen-context-type-webgl><code>webgl</code></dfn>" or "<dfn id=offscreen-context-type-webgl2><code>webgl2</code></dfn>"
       <td>
        Follow the instructions given in the WebGL specifications' <i>Context Creation</i> sections
        to obtain either a <code id=the-offscreencanvas-interface:webglrenderingcontext-2><a data-x-internal=webglrenderingcontext href=https://www.khronos.org/registry/webgl/specs/latest/1.0/#WebGLRenderingContext>WebGLRenderingContext</a></code>, <code id=the-offscreencanvas-interface:webgl2renderingcontext-2><a data-x-internal=webgl2renderingcontext href=https://www.khronos.org/registry/webgl/specs/latest/2.0/#WebGL2RenderingContext>WebGL2RenderingContext</a></code>,
        or null; if the returned value is null, then return null; otherwise, set this
        <code id=the-offscreencanvas-interface:offscreencanvas-23><a href=#offscreencanvas>OffscreenCanvas</a></code> object's <a href=#offscreencanvas-context-mode id=the-offscreencanvas-interface:offscreencanvas-context-mode-6>context
        mode</a> to <a href=#offscreencanvas-context-webgl id=the-offscreencanvas-interface:offscreencanvas-context-webgl-2>webgl</a> or <a href=#offscreencanvas-context-webgl2 id=the-offscreencanvas-interface:offscreencanvas-context-webgl2-2>webgl2</a>, and return the
        <code id=the-offscreencanvas-interface:webglrenderingcontext-3><a data-x-internal=webglrenderingcontext href=https://www.khronos.org/registry/webgl/specs/latest/1.0/#WebGLRenderingContext>WebGLRenderingContext</a></code> or <code id=the-offscreencanvas-interface:webgl2renderingcontext-3><a data-x-internal=webgl2renderingcontext href=https://www.khronos.org/registry/webgl/specs/latest/2.0/#WebGL2RenderingContext>WebGL2RenderingContext</a></code> object. <a href=references.html#refsWEBGL>[WEBGL]</a>
       <td>
        Return null.
       <td>
        Return null.
       <td>
        Return the same value as was returned the last time the method was invoked with this same
        first argument.
       <td>
        Throw an <a id=the-offscreencanvas-interface:invalidstateerror-4 href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=the-offscreencanvas-interface:domexception-4><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.
    </table>
   </ol>

  <hr>

  

  <dl class=domintro><dt><var>offscreenCanvas</var> . <code id=dom-offscreencanvas-width-dev><a href=#dom-offscreencanvas-width>width</a></code> [
   = <var>value</var> ]<dt><var>offscreenCanvas</var> . <code id=dom-offscreencanvas-height-dev><a href=#dom-offscreencanvas-height>height</a></code> [
   = <var>value</var> ]<dd>
    <p>These attributes return the dimensions of the <code id=the-offscreencanvas-interface:offscreencanvas-24><a href=#offscreencanvas>OffscreenCanvas</a></code> object's <a href=#offscreencanvas-bitmap id=the-offscreencanvas-interface:offscreencanvas-bitmap-6>bitmap</a>.</p>

    <p>They can be set, to replace the <a href=#offscreencanvas-bitmap id=the-offscreencanvas-interface:offscreencanvas-bitmap-7>bitmap</a> with a
    new, <a id=the-offscreencanvas-interface:transparent-black-4 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a> bitmap of the specified dimensions (effectively resizing
    it).</p>
   </dl>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in one engine only." class=less-than-two-engines-flag>⚠</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/OffscreenCanvas/width title="The width property returns and sets the width of an OffscreenCanvas object.">OffscreenCanvas/width</a><p class=less-than-two-engines-text>Support in one engine only.<div class=support><span class="firefox yes"><span>Firefox</span><span title="Partial implementation.">🔰 44+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>69+</span></span><hr><span class="opera yes"><span>Opera</span><span>56+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span title="Partial implementation.">🔰 44+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>69+</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>10.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>48+</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/OffscreenCanvas/height title="The height property returns and sets the height of an OffscreenCanvas object.">OffscreenCanvas/height</a><p class=less-than-two-engines-text>Support in one engine only.<div class=support><span class="firefox yes"><span>Firefox</span><span title="Partial implementation.">🔰 44+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>69+</span></span><hr><span class="opera yes"><span>Opera</span><span>56+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span title="Partial implementation.">🔰 44+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>69+</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>10.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>48+</span></span></div></div></aside><p>If either the <dfn id=dom-offscreencanvas-width><code>width</code></dfn> or <dfn id=dom-offscreencanvas-height><code>height</code></dfn> attributes of an
  <code id=the-offscreencanvas-interface:offscreencanvas-25><a href=#offscreencanvas>OffscreenCanvas</a></code> object are set (to a new value or to the same value as before) and
  the <code id=the-offscreencanvas-interface:offscreencanvas-26><a href=#offscreencanvas>OffscreenCanvas</a></code> object's <a href=#offscreencanvas-context-mode id=the-offscreencanvas-interface:offscreencanvas-context-mode-7>context
  mode</a> is <a href=#offscreencanvas-context-2d id=the-offscreencanvas-interface:offscreencanvas-context-2d-3>2d</a>, then replace the
  <code id=the-offscreencanvas-interface:offscreencanvas-27><a href=#offscreencanvas>OffscreenCanvas</a></code> object's <a href=#offscreencanvas-bitmap id=the-offscreencanvas-interface:offscreencanvas-bitmap-8>bitmap</a> with a
  new <a id=the-offscreencanvas-interface:transparent-black-5 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a> bitmap and <a href=#reset-the-rendering-context-to-its-default-state id=the-offscreencanvas-interface:reset-the-rendering-context-to-its-default-state>reset the rendering context to its default
  state</a>. The new bitmap's dimensions are equal to the new values of the <code id=the-offscreencanvas-interface:dom-offscreencanvas-width-4><a href=#dom-offscreencanvas-width>width</a></code> and <code id=the-offscreencanvas-interface:dom-offscreencanvas-height-4><a href=#dom-offscreencanvas-height>height</a></code> attributes.</p>

  <p>The resizing behavior for "<code id=the-offscreencanvas-interface:offscreen-context-type-webgl-5><a href=#offscreen-context-type-webgl>webgl</a></code>" and "<code id=the-offscreencanvas-interface:offscreen-context-type-webgl2-4><a href=#offscreen-context-type-webgl2>webgl2</a></code>" contexts is defined in the WebGL
  specifications. <a href=references.html#refsWEBGL>[WEBGL]</a></p>

  

  <p class=note>If an <code id=the-offscreencanvas-interface:offscreencanvas-28><a href=#offscreencanvas>OffscreenCanvas</a></code> object whose dimensions were changed has
  a <a href=#offscreencanvas-placeholder id=the-offscreencanvas-interface:offscreencanvas-placeholder-5>placeholder <code>canvas</code> element</a>, then
  the <a href=#offscreencanvas-placeholder id=the-offscreencanvas-interface:offscreencanvas-placeholder-6>placeholder <code>canvas</code> element</a>'s
  <a href=https://drafts.csswg.org/css-images/#intrinsic-dimensions id=the-offscreencanvas-interface:intrinsic-dimensions data-x-internal=intrinsic-dimensions>intrinsic size</a> will only be updated via the <code id=the-offscreencanvas-interface:offscreencontext-commit-2><a href=#offscreencontext-commit>commit()</a></code> method of the <code id=the-offscreencanvas-interface:offscreencanvas-29><a href=#offscreencanvas>OffscreenCanvas</a></code>
  object's rendering context.</p>

  <dl class=domintro><dt><var>promise</var> = <var>offscreenCanvas</var> . <code id=dom-offscreencanvas-converttoblob-dev><a href=#dom-offscreencanvas-converttoblob>convertToBlob</a></code>( [<var>options</var>] )<dd>
    <p>Returns a promise that will fulfill with a new <code id=the-offscreencanvas-interface:blob-2><a data-x-internal=blob href=https://w3c.github.io/FileAPI/#dfn-Blob>Blob</a></code> object representing a file
    containing the image in the <code id=the-offscreencanvas-interface:offscreencanvas-30><a href=#offscreencanvas>OffscreenCanvas</a></code> object.</p>

    <p>The argument, if provided, is a dictionary that controls the encoding options of the image
    file to be created. The <code id=the-offscreencanvas-interface:image-encode-options-type-2><a href=#image-encode-options-type>type</a></code>
    field specifies the file format and has a default value of "<code id=the-offscreencanvas-interface:image/png><a href=indices.html#image/png>image/png</a></code>"; that type
    is also used if the requested type isn't supported. If the image format supports variable
    quality (such as "<code id=the-offscreencanvas-interface:image/jpeg><a href=indices.html#image/jpeg>image/jpeg</a></code>"), then the <code id=the-offscreencanvas-interface:image-encode-options-quality-2><a href=#image-encode-options-quality>quality</a></code> field is a number in the range 0.0
    to 1.0 inclusive indicating the desired quality level for the resulting image.</p>
   <dt><var>canvas</var> . <code id=dom-offscreencanvas-transfertoimagebitmap-dev><a href=#dom-offscreencanvas-transfertoimagebitmap>transferToImageBitmap</a></code>()<dd>
    <p>Returns a newly created <code id=the-offscreencanvas-interface:imagebitmap-2><a href=imagebitmap-and-animations.html#imagebitmap>ImageBitmap</a></code> object with the image in the
    <code id=the-offscreencanvas-interface:offscreencanvas-31><a href=#offscreencanvas>OffscreenCanvas</a></code> object. The image in the <code id=the-offscreencanvas-interface:offscreencanvas-32><a href=#offscreencanvas>OffscreenCanvas</a></code> object is
    replaced with a new blank image.</p>
   </dl>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in one engine only." class=less-than-two-engines-flag>⚠</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/OffscreenCanvas/convertToBlob title="The OffscreenCanvas.convertToBlob()method creates a Blob object representing the image contained in the canvas.">OffscreenCanvas/convertToBlob</a><p class=less-than-two-engines-text>Support in one engine only.<div class=support><span class="firefox yes"><span>Firefox</span><span title="Partial implementation.">🔰 46+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>69+</span></span><hr><span class="opera yes"><span>Opera</span><span>56+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span title="Partial implementation.">🔰 46+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>69+</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>10.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>48+</span></span></div></div></aside><p>The <dfn id=dom-offscreencanvas-converttoblob><code>convertToBlob(<var>options</var>)</code></dfn> method,
  when invoked, must run the following steps:</p>

  <ol><li><p>If the value of this <code id=the-offscreencanvas-interface:offscreencanvas-33><a href=#offscreencanvas>OffscreenCanvas</a></code> object's <a id=the-offscreencanvas-interface:detached href=structured-data.html#detached>[[Detached]]</a>
   internal slot is set to true, then return a promise rejected with an
   <a id=the-offscreencanvas-interface:invalidstateerror-5 href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=the-offscreencanvas-interface:domexception-5><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>If this <code id=the-offscreencanvas-interface:offscreencanvas-34><a href=#offscreencanvas>OffscreenCanvas</a></code> object's <a href=#offscreencanvas-context-mode id=the-offscreencanvas-interface:offscreencanvas-context-mode-8>context mode</a> is <a href=#offscreencanvas-context-2d id=the-offscreencanvas-interface:offscreencanvas-context-2d-4>2d</a> and the rendering context's <a href=#offscreencontext2d-bitmap id=the-offscreencanvas-interface:offscreencontext2d-bitmap>bitmap</a>'s <a href=#offscreencontext2d-origin-clean id=the-offscreencanvas-interface:offscreencontext2d-origin-clean>origin-clean</a> flag is set to false, then return a
   promise rejected with a <a id=the-offscreencanvas-interface:securityerror href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=the-offscreencanvas-interface:domexception-6><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.</p>

   <li><p>If this <code id=the-offscreencanvas-interface:offscreencanvas-35><a href=#offscreencanvas>OffscreenCanvas</a></code> object's <a href=#offscreencanvas-bitmap id=the-offscreencanvas-interface:offscreencanvas-bitmap-9>bitmap</a> has no pixels (i.e., either its
   horizontal dimension or its vertical dimension is zero) then return a promise rejected with an
   <a id=the-offscreencanvas-interface:indexsizeerror href=https://heycam.github.io/webidl/#indexsizeerror data-x-internal=indexsizeerror>"<code>IndexSizeError</code>"</a> <code id=the-offscreencanvas-interface:domexception-7><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>bitmap</var> be a copy of this <code id=the-offscreencanvas-interface:offscreencanvas-36><a href=#offscreencanvas>OffscreenCanvas</a></code> object's <a href=#offscreencanvas-bitmap id=the-offscreencanvas-interface:offscreencanvas-bitmap-10>bitmap</a>.<li><p>Let <var>result</var> be a new promise object.<li>
    <p>Run these steps <a id=the-offscreencanvas-interface:in-parallel href=infrastructure.html#in-parallel>in parallel</a>:</p>

    <ol><li><p>Let <var>file</var> be <a href=#a-serialisation-of-the-bitmap-as-a-file id=the-offscreencanvas-interface:a-serialisation-of-the-bitmap-as-a-file>a
     serialization of <var>bitmap</var> as a file</a>, with <var>options</var>'s <dfn id=image-encode-options-type><code>type</code></dfn> and <dfn id=image-encode-options-quality><code>quality</code></dfn> if present.<li>
      <p><a id=the-offscreencanvas-interface:queue-an-element-task href=webappapis.html#queue-an-element-task>Queue an element task</a> on the <a href=#canvas-blob-serialisation-task-source id=the-offscreencanvas-interface:canvas-blob-serialisation-task-source>canvas blob serialization task
      source</a> given the <code id=the-offscreencanvas-interface:the-canvas-element-2><a href=#the-canvas-element>canvas</a></code> element to run these steps:</p>

      <ol><li><p>If <var>file</var> is null, then reject <var>result</var> with an
       <a id=the-offscreencanvas-interface:encodingerror href=https://heycam.github.io/webidl/#encodingerror data-x-internal=encodingerror>"<code>EncodingError</code>"</a> <code id=the-offscreencanvas-interface:domexception-8><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Otherwise, resolve <var>result</var> with a new <code id=the-offscreencanvas-interface:blob-3><a data-x-internal=blob href=https://w3c.github.io/FileAPI/#dfn-Blob>Blob</a></code> object, created in
       the <a href=webappapis.html#concept-relevant-realm id=the-offscreencanvas-interface:concept-relevant-realm>relevant Realm</a> of this
       <code id=the-offscreencanvas-interface:offscreencanvas-37><a href=#offscreencanvas>OffscreenCanvas</a></code> object, representing <var>file</var>. <a href=references.html#refsFILEAPI>[FILEAPI]</a></ol>
     </ol>
   <li><p>Return <var>result</var>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in one engine only." class=less-than-two-engines-flag>⚠</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/OffscreenCanvas/transferToImageBitmap title="The OffscreenCanvas.transferToImageBitmap() method creates an ImageBitmap object from the most recently rendered image of the OffscreenCanvas.">OffscreenCanvas/transferToImageBitmap</a><p class=less-than-two-engines-text>Support in one engine only.<div class=support><span class="firefox yes"><span>Firefox</span><span title="Partial implementation.">🔰 46+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>69+</span></span><hr><span class="opera yes"><span>Opera</span><span>56+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span title="Partial implementation.">🔰 46+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>69+</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>10.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>48+</span></span></div></div></aside><p>The <dfn id=dom-offscreencanvas-transfertoimagebitmap><code>transferToImageBitmap()</code></dfn> method,
  when invoked, must run the following steps:</p>
  <ol><li><p>If the value of this <code id=the-offscreencanvas-interface:offscreencanvas-38><a href=#offscreencanvas>OffscreenCanvas</a></code> object's <a id=the-offscreencanvas-interface:detached-2 href=structured-data.html#detached>[[Detached]]</a>
   internal slot is set to true, then throw an <a id=the-offscreencanvas-interface:invalidstateerror-6 href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a>
   <code id=the-offscreencanvas-interface:domexception-9><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>If this <code id=the-offscreencanvas-interface:offscreencanvas-39><a href=#offscreencanvas>OffscreenCanvas</a></code> object's <a href=#offscreencanvas-context-mode id=the-offscreencanvas-interface:offscreencanvas-context-mode-9>context mode</a> is set to <a href=#offscreencanvas-context-none id=the-offscreencanvas-interface:offscreencanvas-context-none-3>none</a>, then throw an
   <a id=the-offscreencanvas-interface:invalidstateerror-7 href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=the-offscreencanvas-interface:domexception-10><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Let <var>image</var> be a newly created <code id=the-offscreencanvas-interface:imagebitmap-3><a href=imagebitmap-and-animations.html#imagebitmap>ImageBitmap</a></code> object that references
   the same underlying bitmap data as this <code id=the-offscreencanvas-interface:offscreencanvas-40><a href=#offscreencanvas>OffscreenCanvas</a></code> object's <a href=#offscreencanvas-bitmap id=the-offscreencanvas-interface:offscreencanvas-bitmap-11>bitmap</a>.<li>
    <p>Set this <code id=the-offscreencanvas-interface:offscreencanvas-41><a href=#offscreencanvas>OffscreenCanvas</a></code> object's <a href=#offscreencanvas-bitmap id=the-offscreencanvas-interface:offscreencanvas-bitmap-12>bitmap</a> to reference a newly created bitmap of the same
    dimensions as the previous bitmap, and with its pixels initialized to <a id=the-offscreencanvas-interface:transparent-black-6 href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent
    black</a>, or <a id=the-offscreencanvas-interface:opaque-black href=https://drafts.csswg.org/css-color/#opaque-black data-x-internal=opaque-black>opaque black</a> if the rendering context's <a href=#offscreencontext2d-alpha id=the-offscreencanvas-interface:offscreencontext2d-alpha>alpha</a> flag is set to false.</p>

    <p class=note>This means that if the rendering context of this <code id=the-offscreencanvas-interface:offscreencanvas-42><a href=#offscreencanvas>OffscreenCanvas</a></code> is
    a <code id=the-offscreencanvas-interface:webglrenderingcontext-4><a data-x-internal=webglrenderingcontext href=https://www.khronos.org/registry/webgl/specs/latest/1.0/#WebGLRenderingContext>WebGLRenderingContext</a></code>, the value of <code id=the-offscreencanvas-interface:webglcontextattributes><a data-x-internal=webglcontextattributes href=https://www.khronos.org/registry/webgl/specs/latest/1.0/#WebGLContextAttributes>preserveDrawingBuffer</a></code> will have no effect. <a href=references.html#refsWEBGL>[WEBGL]</a></p>
   <li><p>Return <var>image</var>.</ol>
  

  <h6 id=the-offscreen-2d-rendering-context><span class=secno>4.12.5.3.1</span> The offscreen 2D rendering context<a href=#the-offscreen-2d-rendering-context class=self-link></a></h6>

  <pre><code class='idl'>[<c- g>Exposed</c->=(<c- n>Window</c->,<c- n>Worker</c->)]
<c- b>interface</c-> <dfn id='offscreencanvasrenderingcontext2d'><c- g>OffscreenCanvasRenderingContext2D</c-></dfn> {
  <c- b>void</c-> <a href='#offscreencontext2d-commit' id='the-offscreen-2d-rendering-context:offscreencontext2d-commit'><c- g>commit</c-></a>();
  <c- b>readonly</c-> <c- b>attribute</c-> <a href='#offscreencanvas' id='the-offscreen-2d-rendering-context:offscreencanvas'><c- n>OffscreenCanvas</c-></a> <a href='#offscreencontext2d-canvas' id='the-offscreen-2d-rendering-context:offscreencontext2d-canvas'><c- g>canvas</c-></a>;
};

<a href='#offscreencanvasrenderingcontext2d' id='the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d'><c- n>OffscreenCanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasstate' id='the-offscreen-2d-rendering-context:canvasstate'><c- n>CanvasState</c-></a>;
<a href='#offscreencanvasrenderingcontext2d' id='the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-2'><c- n>OffscreenCanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvastransform' id='the-offscreen-2d-rendering-context:canvastransform'><c- n>CanvasTransform</c-></a>;
<a href='#offscreencanvasrenderingcontext2d' id='the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-3'><c- n>OffscreenCanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvascompositing' id='the-offscreen-2d-rendering-context:canvascompositing'><c- n>CanvasCompositing</c-></a>;
<a href='#offscreencanvasrenderingcontext2d' id='the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-4'><c- n>OffscreenCanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasimagesmoothing' id='the-offscreen-2d-rendering-context:canvasimagesmoothing'><c- n>CanvasImageSmoothing</c-></a>;
<a href='#offscreencanvasrenderingcontext2d' id='the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-5'><c- n>OffscreenCanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasfillstrokestyles' id='the-offscreen-2d-rendering-context:canvasfillstrokestyles'><c- n>CanvasFillStrokeStyles</c-></a>;
<a href='#offscreencanvasrenderingcontext2d' id='the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-6'><c- n>OffscreenCanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasshadowstyles' id='the-offscreen-2d-rendering-context:canvasshadowstyles'><c- n>CanvasShadowStyles</c-></a>;
<a href='#offscreencanvasrenderingcontext2d' id='the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-7'><c- n>OffscreenCanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasfilters' id='the-offscreen-2d-rendering-context:canvasfilters'><c- n>CanvasFilters</c-></a>;
<a href='#offscreencanvasrenderingcontext2d' id='the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-8'><c- n>OffscreenCanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasrect' id='the-offscreen-2d-rendering-context:canvasrect'><c- n>CanvasRect</c-></a>;
<a href='#offscreencanvasrenderingcontext2d' id='the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-9'><c- n>OffscreenCanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasdrawpath' id='the-offscreen-2d-rendering-context:canvasdrawpath'><c- n>CanvasDrawPath</c-></a>;
<a href='#offscreencanvasrenderingcontext2d' id='the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-10'><c- n>OffscreenCanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvastext' id='the-offscreen-2d-rendering-context:canvastext'><c- n>CanvasText</c-></a>;
<a href='#offscreencanvasrenderingcontext2d' id='the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-11'><c- n>OffscreenCanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasdrawimage' id='the-offscreen-2d-rendering-context:canvasdrawimage'><c- n>CanvasDrawImage</c-></a>;
<a href='#offscreencanvasrenderingcontext2d' id='the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-12'><c- n>OffscreenCanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvasimagedata' id='the-offscreen-2d-rendering-context:canvasimagedata'><c- n>CanvasImageData</c-></a>;
<a href='#offscreencanvasrenderingcontext2d' id='the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-13'><c- n>OffscreenCanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvaspathdrawingstyles' id='the-offscreen-2d-rendering-context:canvaspathdrawingstyles'><c- n>CanvasPathDrawingStyles</c-></a>;
<a href='#offscreencanvasrenderingcontext2d' id='the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-14'><c- n>OffscreenCanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvastextdrawingstyles' id='the-offscreen-2d-rendering-context:canvastextdrawingstyles'><c- n>CanvasTextDrawingStyles</c-></a>;
<a href='#offscreencanvasrenderingcontext2d' id='the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-15'><c- n>OffscreenCanvasRenderingContext2D</c-></a> <c- b>includes</c-> <a href='#canvaspath' id='the-offscreen-2d-rendering-context:canvaspath'><c- n>CanvasPath</c-></a>;</code></pre>

  <p>The <code id=the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-16><a href=#offscreencanvasrenderingcontext2d>OffscreenCanvasRenderingContext2D</a></code> object is a rendering context for drawing to
  the <a href=#offscreencanvas-bitmap id=the-offscreen-2d-rendering-context:offscreencanvas-bitmap>bitmap</a> of an <code id=the-offscreen-2d-rendering-context:offscreencanvas-2><a href=#offscreencanvas>OffscreenCanvas</a></code> object.
  It is similar to the <code id=the-offscreen-2d-rendering-context:canvasrenderingcontext2d><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code> object, with the following
  differences:</p>

  <ul><li><p>there is no support for <a href=#canvasuserinterface id=the-offscreen-2d-rendering-context:canvasuserinterface>user interface</a>
   features;<li><p>its <code id=the-offscreen-2d-rendering-context:offscreencontext2d-canvas-2><a href=#offscreencontext2d-canvas>canvas</a></code> attribute refers to an
   <code id=the-offscreen-2d-rendering-context:offscreencanvas-3><a href=#offscreencanvas>OffscreenCanvas</a></code> object rather than a <code id=the-offscreen-2d-rendering-context:the-canvas-element><a href=#the-canvas-element>canvas</a></code> element;<li><p>it has a <code id=the-offscreen-2d-rendering-context:offscreencontext2d-commit-2><a href=#offscreencontext2d-commit>commit()</a></code> method for pushing the
   rendered image to the context's <code id=the-offscreen-2d-rendering-context:offscreencanvas-4><a href=#offscreencanvas>OffscreenCanvas</a></code> object's <a href=#offscreencanvas-placeholder id=the-offscreen-2d-rendering-context:offscreencanvas-placeholder>placeholder <code>canvas</code> element</a>.</ul>

  <p>An <code id=the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-17><a href=#offscreencanvasrenderingcontext2d>OffscreenCanvasRenderingContext2D</a></code> object has a <dfn id=offscreencontext2d-bitmap>bitmap</dfn> that is initialized when the object is
  created.</p>

  <p>The <a href=#offscreencontext2d-bitmap id=the-offscreen-2d-rendering-context:offscreencontext2d-bitmap>bitmap</a> has an <dfn id=offscreencontext2d-origin-clean>origin-clean</dfn> flag, which can be set to true or
  false. Initially, when one of these bitmaps is created, its <a href=#offscreencontext2d-origin-clean id=the-offscreen-2d-rendering-context:offscreencontext2d-origin-clean>origin-clean</a> flag must be set to true.</p>

  <p>An <code id=the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-18><a href=#offscreencanvasrenderingcontext2d>OffscreenCanvasRenderingContext2D</a></code> object also has an <dfn id=offscreencontext2d-alpha>alpha</dfn> flag, which can be set to true or false. Initially,
  when the context is created, its alpha flag must be set to true. When an
  <code id=the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-19><a href=#offscreencanvasrenderingcontext2d>OffscreenCanvasRenderingContext2D</a></code> object has its <a href=#offscreencontext2d-alpha id=the-offscreen-2d-rendering-context:offscreencontext2d-alpha>alpha</a> flag set to false, then its alpha channel must be
  fixed to 1.0 (fully opaque) for all pixels, and attempts to change the alpha component of any pixel
  must be silently ignored.</p>

  <p>An <code id=the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-20><a href=#offscreencanvasrenderingcontext2d>OffscreenCanvasRenderingContext2D</a></code> object has an <dfn id=associated-offscreencanvas-object>associated
  <code>OffscreenCanvas</code> object</dfn>, which is the <code id=the-offscreen-2d-rendering-context:offscreencanvas-5><a href=#offscreencanvas>OffscreenCanvas</a></code> object
  from which the <code id=the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-21><a href=#offscreencanvasrenderingcontext2d>OffscreenCanvasRenderingContext2D</a></code> object was created.

  <dl class=domintro><dt><var>offscreenCanvasRenderingContext2D</var> . <code id=offscreencontext2d-commit-dev><a href=#offscreencontext2d-commit>commit</a></code>()<dd>
    <p>Copies the rendering context's <a href=#offscreencontext2d-bitmap id=the-offscreen-2d-rendering-context:offscreencontext2d-bitmap-2>bitmap</a> to
    the bitmap of the <a href=#offscreencanvas-placeholder id=the-offscreen-2d-rendering-context:offscreencanvas-placeholder-2>placeholder <code>canvas</code>
    element</a> of the <a href=#associated-offscreencanvas-object id=the-offscreen-2d-rendering-context:associated-offscreencanvas-object>associated <code>OffscreenCanvas</code> object</a>. The copy
    operation is synchronous. Calling this method is not needed for the transfer, since it happens
    automatically during the <a id=the-offscreen-2d-rendering-context:event-loop href=webappapis.html#event-loop>event loop</a> execution.</p>
   <dt><var>offscreenCanvas</var> = <var>offscreenCanvasRenderingContext2D</var> . <code id=offscreencontext2d-canvas-dev><a href=#offscreencontext2d-canvas>canvas</a></code><dd>
    <p>Returns the <a href=#associated-offscreencanvas-object id=the-offscreen-2d-rendering-context:associated-offscreencanvas-object-2>associated <code>OffscreenCanvas</code> object</a>.</p>
   </dl>

  

  <p>The <dfn id=offscreen-2d-context-creation-algorithm>offscreen 2D context creation algorithm</dfn>, which is passed a
  <var>target</var> (an <code id=the-offscreen-2d-rendering-context:offscreencanvas-6><a href=#offscreencanvas>OffscreenCanvas</a></code> object) and optionally some arguments,
  consists of running the following steps:</p>

  <ol><li><p>If the algorithm was passed some arguments, let <var>arg</var> be the first such
   argument. Otherwise, let <var>arg</var> be undefined.<li><p>Let <var>settings</var> be the result of <a href=https://heycam.github.io/webidl/#es-type-mapping id=the-offscreen-2d-rendering-context:concept-idl-convert data-x-internal=concept-idl-convert>converting</a> <var>options</var> to the dictionary type
   <code id=the-offscreen-2d-rendering-context:canvasrenderingcontext2dsettings><a href=#canvasrenderingcontext2dsettings>CanvasRenderingContext2DSettings</a></code>. (This can throw an exception.).<li><p>Let <var>context</var> be a new <code id=the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-22><a href=#offscreencanvasrenderingcontext2d>OffscreenCanvasRenderingContext2D</a></code>
   object.<li><p>Set <var>context</var>'s <a href=#associated-offscreencanvas-object id=the-offscreen-2d-rendering-context:associated-offscreencanvas-object-3>associated <code>OffscreenCanvas</code> object</a> to
   <var>target</var>.<li><p>Process each of the members of <var>settings</var> as follows:</p>
    <dl><dt><code id=the-offscreen-2d-rendering-context:dom-canvasrenderingcontext2dsettings-alpha><a href=#dom-canvasrenderingcontext2dsettings-alpha>alpha</a></code><dd>If false, set <var>context</var>'s <a href=#offscreencontext2d-alpha id=the-offscreen-2d-rendering-context:offscreencontext2d-alpha-2>alpha</a>
     flag to false.</dl>
   <li><p>Set <var>context</var>'s <a href=#offscreencontext2d-bitmap id=the-offscreen-2d-rendering-context:offscreencontext2d-bitmap-3>bitmap</a> to a newly
   created bitmap with the dimensions specified by the <code id=the-offscreen-2d-rendering-context:dom-offscreencanvas-width><a href=#dom-offscreencanvas-width>width</a></code> and <code id=the-offscreen-2d-rendering-context:dom-offscreencanvas-height><a href=#dom-offscreencanvas-height>height</a></code> attributes of <var>target</var>, and set
   <var>target</var>'s bitmap to the same bitmap (so that they are shared).<li><p>If <var>context</var>'s <a href=#offscreencontext2d-alpha id=the-offscreen-2d-rendering-context:offscreencontext2d-alpha-3>alpha</a> flag is set
   to true, initialize all the pixels of <var>context</var>'s <a href=#offscreencontext2d-bitmap id=the-offscreen-2d-rendering-context:offscreencontext2d-bitmap-4>bitmap</a> to <a id=the-offscreen-2d-rendering-context:transparent-black href=https://drafts.csswg.org/css-color/#transparent-black data-x-internal=transparent-black>transparent black</a>. Otherwise,
   initialize the pixels to <a id=the-offscreen-2d-rendering-context:opaque-black href=https://drafts.csswg.org/css-color/#opaque-black data-x-internal=opaque-black>opaque black</a>.<li><p>Return <var>context</var>.</ol>

  <p>The <dfn id=offscreencontext2d-commit><code>commit()</code></dfn> method, when invoked,
  must run the following steps:</p>

  <ol><li><p>If this <code id=the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-23><a href=#offscreencanvasrenderingcontext2d>OffscreenCanvasRenderingContext2D</a></code>'s <a href=#associated-offscreencanvas-object id=the-offscreen-2d-rendering-context:associated-offscreencanvas-object-4>associated
    <code>OffscreenCanvas</code> object</a> does not have a <a href=#offscreencanvas-placeholder id=the-offscreen-2d-rendering-context:offscreencanvas-placeholder-3>placeholder <code>canvas</code> element</a>, then
    return.<li><p>Let <var>image</var> be a copy of this <code id=the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-24><a href=#offscreencanvasrenderingcontext2d>OffscreenCanvasRenderingContext2D</a></code>'s
    <a href=#offscreencontext2d-bitmap id=the-offscreen-2d-rendering-context:offscreencontext2d-bitmap-5>bitmap</a>, including the value of its <a href=#offscreencontext2d-origin-clean id=the-offscreen-2d-rendering-context:offscreencontext2d-origin-clean-2>origin-clean</a> flag.<li>
     <p><a id=the-offscreen-2d-rendering-context:queue-an-element-task href=webappapis.html#queue-an-element-task>Queue an element task</a> on the <a id=the-offscreen-2d-rendering-context:dom-manipulation-task-source href=webappapis.html#dom-manipulation-task-source>DOM manipulation task source</a> given
     the <a href=#offscreencanvas-placeholder id=the-offscreen-2d-rendering-context:offscreencanvas-placeholder-4>placeholder <code>canvas</code> element</a>
     to set the <a href=#offscreencanvas-placeholder id=the-offscreen-2d-rendering-context:offscreencanvas-placeholder-5>placeholder <code>canvas</code>
     element</a>'s <a href=#output-bitmap id=the-offscreen-2d-rendering-context:output-bitmap>output bitmap</a> to be a reference to <var>image</var>.</p>

     <p class=note>If <var>image</var> has different dimensions than the bitmap previously
     referenced as the <a href=#offscreencanvas-placeholder id=the-offscreen-2d-rendering-context:offscreencanvas-placeholder-6>placeholder <code>canvas</code>
     element</a>'s <a href=#output-bitmap id=the-offscreen-2d-rendering-context:output-bitmap-2>output bitmap</a>, then this task will result in a change in
     the <a href=#offscreencanvas-placeholder id=the-offscreen-2d-rendering-context:offscreencanvas-placeholder-7>placeholder <code>canvas</code>
     element</a>'s <a href=https://drafts.csswg.org/css-images/#intrinsic-dimensions id=the-offscreen-2d-rendering-context:intrinsic-dimensions data-x-internal=intrinsic-dimensions>intrinsic size</a>, which can affect
     document layout.</p>
    </ol>

  <p class=note>Implementations are encouraged to short-circuit the graphics update steps of
  the <a id=the-offscreen-2d-rendering-context:window-event-loop href=webappapis.html#window-event-loop>window event loop</a> for the purposes of updating the contents of a <a href=#offscreencanvas-placeholder id=the-offscreen-2d-rendering-context:offscreencanvas-placeholder-8>placeholder <code>canvas</code> element</a> to the
  display. This could mean, for example, that the <code id=the-offscreen-2d-rendering-context:offscreencontext2d-commit-3><a href=#offscreencontext2d-commit>commit()</a></code> method can copy the bitmap contents directly
  to a graphics buffer that is mapped to the physical display location of the <a href=#offscreencanvas-placeholder id=the-offscreen-2d-rendering-context:offscreencanvas-placeholder-9>placeholder <code>canvas</code> element</a>. This or
  similar short-circuiting approaches can significantly reduce display latency, especially in cases
  where the <code id=the-offscreen-2d-rendering-context:offscreencontext2d-commit-4><a href=#offscreencontext2d-commit>commit()</a></code> method is invoked from a
  <a id=the-offscreen-2d-rendering-context:worker-event-loop-2 href=webappapis.html#worker-event-loop-2>worker event loop</a> and the <a id=the-offscreen-2d-rendering-context:window-event-loop-2 href=webappapis.html#window-event-loop>window event loop</a> of the <a href=#offscreencanvas-placeholder id=the-offscreen-2d-rendering-context:offscreencanvas-placeholder-10>placeholder <code>canvas</code> element</a> is busy.
  However, such shortcuts can not have any script-observable side-effects. This means that the
  committed bitmap still needs to be sent to the <a href=#offscreencanvas-placeholder id=the-offscreen-2d-rendering-context:offscreencanvas-placeholder-11>placeholder <code>canvas</code> element</a>, in case the
  element is used as a <code id=the-offscreen-2d-rendering-context:canvasimagesource><a href=#canvasimagesource>CanvasImageSource</a></code>, as an <code id=the-offscreen-2d-rendering-context:imagebitmapsource><a href=imagebitmap-and-animations.html#imagebitmapsource>ImageBitmapSource</a></code>, or in
  case <code id=the-offscreen-2d-rendering-context:dom-canvas-todataurl><a href=#dom-canvas-todataurl>toDataURL()</a></code> or <code id=the-offscreen-2d-rendering-context:dom-canvas-toblob><a href=#dom-canvas-toblob>toBlob()</a></code> are called on it.</p>

  <p>The <dfn id=offscreencontext2d-canvas><code>canvas</code></dfn> attribute, on getting,
  must return this <code id=the-offscreen-2d-rendering-context:offscreencanvasrenderingcontext2d-25><a href=#offscreencanvasrenderingcontext2d>OffscreenCanvasRenderingContext2D</a></code>'s <a href=#associated-offscreencanvas-object id=the-offscreen-2d-rendering-context:associated-offscreencanvas-object-5>associated
  <code>OffscreenCanvas</code> object</a>.

  </p>

  

  <h5 id=colour-spaces-and-colour-correction><span class=secno>4.12.5.4</span> Color spaces and color correction<a href=#colour-spaces-and-colour-correction class=self-link></a></h5>

  <p>The <code id=colour-spaces-and-colour-correction:the-canvas-element><a href=#the-canvas-element>canvas</a></code> APIs must perform color correction at only two points: when rendering
  images with their own gamma correction and color space information onto a bitmap, to convert the
  image to the color space used by the bitmaps (e.g. using the 2D Context's <code id=colour-spaces-and-colour-correction:dom-context-2d-drawimage><a href=#dom-context-2d-drawimage>drawImage()</a></code> method with an
  <code id=colour-spaces-and-colour-correction:htmlorsvgimageelement><a href=#htmlorsvgimageelement>HTMLOrSVGImageElement</a></code> object), and when rendering the actual canvas bitmap to the
  output device.</p>

  <p class=note>Thus, in the 2D context, colors used to draw shapes onto the canvas will exactly
  match colors obtained through the <code id=colour-spaces-and-colour-correction:dom-context-2d-getimagedata><a href=#dom-context-2d-getimagedata>getImageData()</a></code> method.</p>

  <p>The <code id=colour-spaces-and-colour-correction:dom-canvas-todataurl><a href=#dom-canvas-todataurl>toDataURL()</a></code> method, when invoked, must not
  include color space information in the resources they return. Where the output format allows it,
  the color of pixels in resources created by <code id=colour-spaces-and-colour-correction:dom-canvas-todataurl-2><a href=#dom-canvas-todataurl>toDataURL()</a></code>
  must match those returned by the <code id=colour-spaces-and-colour-correction:dom-context-2d-getimagedata-2><a href=#dom-context-2d-getimagedata>getImageData()</a></code>
  method.</p>

  <p>In user agents that support CSS, the color space used by a <code id=colour-spaces-and-colour-correction:the-canvas-element-2><a href=#the-canvas-element>canvas</a></code> element must
  match the color space used for processing any colors for that element in CSS.</p>

  <p>The gamma correction and color space information of images must be handled in such a way that
  an image rendered directly using an <code id=colour-spaces-and-colour-correction:the-img-element><a href=embedded-content.html#the-img-element>img</a></code> element would use the same colors as one
  painted on a <code id=colour-spaces-and-colour-correction:the-canvas-element-3><a href=#the-canvas-element>canvas</a></code> element that is then itself rendered. Furthermore, the rendering
  of images that have no color correction information (such as those returned by the <code id=colour-spaces-and-colour-correction:dom-canvas-todataurl-3><a href=#dom-canvas-todataurl>toDataURL()</a></code> method) must be rendered with no color
  correction.</p>

  <p class=note>Thus, in the 2D context, calling the <code id=colour-spaces-and-colour-correction:dom-context-2d-drawimage-2><a href=#dom-context-2d-drawimage>drawImage()</a></code> method to render the output of the <code id=colour-spaces-and-colour-correction:dom-canvas-todataurl-4><a href=#dom-canvas-todataurl>toDataURL()</a></code> method to the canvas, given the appropriate
  dimensions, has no visible effect.</p>

  



  <h5 id=serialising-bitmaps-to-a-file><span class=secno>4.12.5.5</span> Serializing bitmaps to a file<a href=#serialising-bitmaps-to-a-file class=self-link></a></h5>

  

  <p>When a user agent is to create <dfn id=a-serialisation-of-the-bitmap-as-a-file>a
  serialization of the bitmap as a file</dfn>, given a <var>type</var> and an optional
  <var>quality</var>, it must create an image file in the format given by <var>type</var>. If an
  error occurs during the creation of the image file (e.g. an internal encoder error), then the
  result of the serialization is null. <a href=references.html#refsPNG>[PNG]</a></p>

  <p>The image file's pixel data must be the bitmap's pixel data scaled to one image pixel per
  coordinate space unit, and if the file format used supports encoding resolution metadata, the
  resolution must be given as 96dpi (one image pixel per <a href=https://drafts.csswg.org/css-values/#px id="serialising-bitmaps-to-a-file:'px'" data-x-internal="'px'">CSS pixel</a>).</p>

  <p>If <var>type</var> is supplied, then it must be interpreted as a <a href=https://mimesniff.spec.whatwg.org/#mime-type id=serialising-bitmaps-to-a-file:mime-type data-x-internal=mime-type>MIME
  type</a> giving the format to use. If the type has any parameters, then it must be treated as
  not supported.</p>

  <p class=example>For example, the value "<code id=serialising-bitmaps-to-a-file:image/png><a href=indices.html#image/png>image/png</a></code>" would mean to generate a PNG
  image, the value "<code id=serialising-bitmaps-to-a-file:image/jpeg><a href=indices.html#image/jpeg>image/jpeg</a></code>" would mean to generate a JPEG image, and the value
  "<code id=serialising-bitmaps-to-a-file:image/svg+xml><a href=indices.html#image/svg+xml>image/svg+xml</a></code>" would mean to generate an SVG image (which would require that the
  user agent track how the bitmap was generated, an unlikely, though potentially awesome,
  feature).</p>

  <p>User agents must support PNG ("<code id=serialising-bitmaps-to-a-file:image/png-2><a href=indices.html#image/png>image/png</a></code>"). User agents may support other types.
  If the user agent does not support the requested type, then it must create the file using the PNG
  format. <a href=references.html#refsPNG>[PNG]</a></p>

  <p>User agents must <a href=https://infra.spec.whatwg.org/#ascii-lowercase id=serialising-bitmaps-to-a-file:converted-to-ascii-lowercase data-x-internal=converted-to-ascii-lowercase>convert the provided type to ASCII
  lowercase</a> before establishing if they support that type.</p>

  <p>For image types that do not support an alpha channel, the serialized image must be the bitmap
  image composited onto an <a id=serialising-bitmaps-to-a-file:opaque-black href=https://drafts.csswg.org/css-color/#opaque-black data-x-internal=opaque-black>opaque black</a> background using the source-over operator.</p>

  <p>If <var>type</var> is an image format that supports variable quality (such as
  "<code id=serialising-bitmaps-to-a-file:image/jpeg-2><a href=indices.html#image/jpeg>image/jpeg</a></code>"), <var>quality</var> is given, and <var>type</var> is not
  "<code id=serialising-bitmaps-to-a-file:image/png-3><a href=indices.html#image/png>image/png</a></code>", then, if <a href=https://tc39.es/ecma262/#sec-ecmascript-data-types-and-values id=serialising-bitmaps-to-a-file:js-type data-x-internal=js-type>Type</a>(<var>quality</var>) is
  Number, and <var>quality</var> is in the range 0.0 to 1.0 inclusive, the user agent must treat
  <var>quality</var> as the desired quality level. Otherwise, the user agent must use its default
  quality value, as if the <var>quality</var> argument had not been given.</p>

  <p class=note>The use of type-testing here, instead of simply declaring <var>quality</var> as
  a Web IDL <code>double</code>, is a historical artifact.</p>

  <p class=note>Different implementations can have slightly different interpretations of
  "quality". When the quality is not specified, an implementation-specific default is used that
  represents a reasonable compromise between compression ratio, image quality, and encoding
  time.</p>

  


  

  <h5 id=security-with-canvas-elements><span class=secno>4.12.5.6</span> Security with <code id=security-with-canvas-elements:the-canvas-element><a href=#the-canvas-element>canvas</a></code> elements<a href=#security-with-canvas-elements class=self-link></a></h5>

  <p><i>This section is non-normative.</i></p>

  <p><strong>Information leakage</strong> can occur if scripts from one <a id=security-with-canvas-elements:concept-origin href=origin.html#concept-origin>origin</a> can
  access information (e.g. read pixels) from images from another origin (one that isn't the <a href=origin.html#same-origin id=security-with-canvas-elements:same-origin>same</a>).</p>

  <p>To mitigate this, bitmaps used with <code id=security-with-canvas-elements:the-canvas-element-2><a href=#the-canvas-element>canvas</a></code> elements and <code id=security-with-canvas-elements:imagebitmap><a href=imagebitmap-and-animations.html#imagebitmap>ImageBitmap</a></code>
  objects are defined to have a flag indicating whether they are <a href=#concept-canvas-origin-clean id=security-with-canvas-elements:concept-canvas-origin-clean>origin-clean</a>. All bitmaps start with their <a href=#concept-canvas-origin-clean id=security-with-canvas-elements:concept-canvas-origin-clean-2>origin-clean</a> set to true. The flag is set to false
  when cross-origin images are used.</p>

  <p>The <code id=security-with-canvas-elements:dom-canvas-todataurl><a href=#dom-canvas-todataurl>toDataURL()</a></code>, <code id=security-with-canvas-elements:dom-canvas-toblob><a href=#dom-canvas-toblob>toBlob()</a></code>, and <code id=security-with-canvas-elements:dom-context-2d-getimagedata><a href=#dom-context-2d-getimagedata>getImageData()</a></code> methods check the flag and will
  throw a <a id=security-with-canvas-elements:securityerror href=https://heycam.github.io/webidl/#securityerror data-x-internal=securityerror>"<code>SecurityError</code>"</a> <code id=security-with-canvas-elements:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code> rather than leak
  cross-origin data.</p>

  <p>The value of the <a href=#concept-canvas-origin-clean id=security-with-canvas-elements:concept-canvas-origin-clean-3>origin-clean</a> flag is
  propagated from a source <code id=security-with-canvas-elements:the-canvas-element-3><a href=#the-canvas-element>canvas</a></code> element's bitmap to a new <code id=security-with-canvas-elements:imagebitmap-2><a href=imagebitmap-and-animations.html#imagebitmap>ImageBitmap</a></code>
  object by <code id=security-with-canvas-elements:dom-createimagebitmap><a href=imagebitmap-and-animations.html#dom-createimagebitmap>createImageBitmap()</a></code>. Conversely, a
  destination <code id=security-with-canvas-elements:the-canvas-element-4><a href=#the-canvas-element>canvas</a></code> element's bitmap will have its <a href=#concept-canvas-origin-clean id=security-with-canvas-elements:concept-canvas-origin-clean-4>origin-clean</a> flags set to false by <code id=security-with-canvas-elements:dom-context-2d-drawimage><a href=#dom-context-2d-drawimage>drawImage</a></code> if the source image is an
  <code id=security-with-canvas-elements:imagebitmap-3><a href=imagebitmap-and-animations.html#imagebitmap>ImageBitmap</a></code> object whose bitmap has its <a href=#concept-canvas-origin-clean id=security-with-canvas-elements:concept-canvas-origin-clean-5>origin-clean</a> flag set to false.</p>

  <p>The flag can be reset in certain situations; for example, when changing the value of the
  <code id=security-with-canvas-elements:attr-canvas-width><a href=#attr-canvas-width>width</a></code> or the <code id=security-with-canvas-elements:attr-canvas-height><a href=#attr-canvas-height>height</a></code> content attribute of the <code id=security-with-canvas-elements:the-canvas-element-5><a href=#the-canvas-element>canvas</a></code> element
  to which a <code id=security-with-canvas-elements:canvasrenderingcontext2d><a href=#canvasrenderingcontext2d>CanvasRenderingContext2D</a></code> is bound, the bitmap is
  cleared and its <a href=#concept-canvas-origin-clean id=security-with-canvas-elements:concept-canvas-origin-clean-6>origin-clean</a> flag is reset.</p>

  <p>When using an <code id=security-with-canvas-elements:imagebitmaprenderingcontext><a href=#imagebitmaprenderingcontext>ImageBitmapRenderingContext</a></code>, the value of the <a href=#concept-canvas-origin-clean id=security-with-canvas-elements:concept-canvas-origin-clean-7>origin-clean</a> flag is propagated from
  <code id=security-with-canvas-elements:imagebitmap-4><a href=imagebitmap-and-animations.html#imagebitmap>ImageBitmap</a></code> objects when they are transferred to the <code id=security-with-canvas-elements:the-canvas-element-6><a href=#the-canvas-element>canvas</a></code>
  via <a href=#dom-imagebitmaprenderingcontext-transferfromimagebitmap id=security-with-canvas-elements:dom-imagebitmaprenderingcontext-transferfromimagebitmap>transferFromImageBitmap()</a>.</p>

  

  <nav><a href=scripting.html>← 4.12 Scripting</a> — <a href=./>Table of Contents</a> — <a href=custom-elements.html>4.13 Custom elements →</a></nav>