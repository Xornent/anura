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

  

  

  

  
  

  
  

  

  <nav><a href=interaction.html>← 6 User interaction</a> — <a href=./>Table of Contents</a> — <a href=browsers.html>7 Loading Web pages →</a></nav><ol class=toc><li id=toc-editing><ol><li><a href=dnd.html#dnd><span class=secno>6.8</span> Drag and drop</a><ol><li><a href=dnd.html#event-drag><span class=secno>6.8.1</span> Introduction</a><li><a href=dnd.html#the-drag-data-store><span class=secno>6.8.2</span> The drag data store</a><li><a href=dnd.html#the-datatransfer-interface><span class=secno>6.8.3</span> The <code>DataTransfer</code> interface</a><ol><li><a href=dnd.html#the-datatransferitemlist-interface><span class=secno>6.8.3.1</span> The <code>DataTransferItemList</code> interface</a><li><a href=dnd.html#the-datatransferitem-interface><span class=secno>6.8.3.2</span> The <code>DataTransferItem</code> interface</a></ol><li><a href=dnd.html#the-dragevent-interface><span class=secno>6.8.4</span> The <code>DragEvent</code> interface</a><li><a href=dnd.html#drag-and-drop-processing-model><span class=secno>6.8.5</span> Processing model</a><li><a href=dnd.html#dndevents><span class=secno>6.8.6</span> Events summary</a><li><a href=dnd.html#the-draggable-attribute><span class=secno>6.8.7</span> The <code>draggable</code> attribute</a><li><a href=dnd.html#security-risks-in-the-drag-and-drop-model><span class=secno>6.8.8</span> Security risks in the drag-and-drop model</a></ol></ol></ol><h3 id=dnd><span class=secno>6.8</span> <dfn>Drag and drop</dfn><a href=#dnd class=self-link></a></h3><div class=status><input onclick=toggleStatus(this) value=⋰ type=button><p class=support><strong>Support:</strong> dragndrop<span class="and_chr yes"><span>Chrome for Android</span> <span>80+</span></span><span class="chrome yes"><span>Chrome</span> <span>4+</span></span><span class="ios_saf no"><span>iOS Safari</span> <span>None</span></span><span class="firefox yes"><span>Firefox</span> <span>3.5+</span></span><span class="safari yes"><span>Safari</span> <span>3.1+</span></span><span class="samsung no"><span>Samsung Internet</span> <span>None</span></span><span class="and_uc no"><span>UC Browser for Android</span> <span>None</span></span><span class="edge yes"><span>Edge</span> <span>18+</span></span><span class="ie partial"><span>IE (limited)</span> <span>5.5+</span></span><span class="opera yes"><span>Opera</span> <span>12+</span></span><span class="op_mini no"><span>Opera Mini</span> <span>None</span></span><span class="android yes"><span>Android Browser</span> <span>80+</span></span><p class=caniuse>Source: <a href="https://caniuse.com/#feat=dragndrop">caniuse.com</a></div>



  <p>This section defines an event-based drag-and-drop mechanism.</p>

  <p>This specification does not define exactly what a <em>drag-and-drop operation</em> actually
  is.</p>

  <p>On a visual medium with a pointing device, a drag operation could be the default action of a
  <code id=dnd:event-mousedown><a data-x-internal=event-mousedown href=https://w3c.github.io/uievents/#event-type-mousedown>mousedown</a></code> event that is followed by a series of <code id=dnd:event-mousemove><a data-x-internal=event-mousemove href=https://w3c.github.io/uievents/#event-type-mousemove>mousemove</a></code> events, and the drop could be triggered by the mouse
  being released.</p>

  <p>When using an input modality other than a pointing device, users would probably have to
  explicitly indicate their intention to perform a drag-and-drop operation, stating what they wish
  to drag and where they wish to drop it, respectively.</p>

  

  <p>However it is implemented, drag-and-drop operations must have a starting point (e.g. where the
  mouse was clicked, or the start of the selection or element that was selected for the drag), may
  have any number of intermediate steps (elements that the mouse moves over during a drag, or
  elements that the user picks as possible drop points as they cycle through possibilities), and must
  either have an end point (the element above which the mouse button was released, or the element
  that was finally selected), or be canceled. The end point must be the last element selected as a
  possible drop point before the drop occurs (so if the operation is not canceled, there must be at
  least one element in the middle step).</p>

  


  <h4 id=event-drag><span class=secno>6.8.1</span> Introduction<a href=#event-drag class=self-link></a></h4>

  <p><i>This section is non-normative.</i></p>

  <p>To make an element draggable, give the element a <code id=event-drag:the-draggable-attribute><a href=#the-draggable-attribute>draggable</a></code>
  attribute, and set an event listener for <code id=event-drag:event-dnd-dragstart><a href=#event-dnd-dragstart>dragstart</a></code> that
  stores the data being dragged.</p>

  <p>The event handler typically needs to check that it's not a text selection that is being
  dragged, and then needs to store data into the <code id=event-drag:datatransfer><a href=#datatransfer>DataTransfer</a></code> object and set the
  allowed effects (copy, move, link, or some combination).</p>

  <p>For example:</p>

  <pre><code class='html'><c- p>&lt;</c-><c- f>p</c-><c- p>&gt;</c->What fruits do you like?<c- p>&lt;/</c-><c- f>p</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>ol</c-> <c- e>ondragstart</c-><c- o>=</c-><c- s>&quot;dragStartHandler(event)&quot;</c-><c- p>&gt;</c->
 <c- p>&lt;</c-><c- f>li</c-> <c- e>draggable</c-><c- o>=</c-><c- s>&quot;true&quot;</c-> <c- e>data-value</c-><c- o>=</c-><c- s>&quot;fruit-apple&quot;</c-><c- p>&gt;</c->Apples<c- p>&lt;/</c-><c- f>li</c-><c- p>&gt;</c->
 <c- p>&lt;</c-><c- f>li</c-> <c- e>draggable</c-><c- o>=</c-><c- s>&quot;true&quot;</c-> <c- e>data-value</c-><c- o>=</c-><c- s>&quot;fruit-orange&quot;</c-><c- p>&gt;</c->Oranges<c- p>&lt;/</c-><c- f>li</c-><c- p>&gt;</c->
 <c- p>&lt;</c-><c- f>li</c-> <c- e>draggable</c-><c- o>=</c-><c- s>&quot;true&quot;</c-> <c- e>data-value</c-><c- o>=</c-><c- s>&quot;fruit-pear&quot;</c-><c- p>&gt;</c->Pears<c- p>&lt;/</c-><c- f>li</c-><c- p>&gt;</c->
<c- p>&lt;/</c-><c- f>ol</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>script</c-><c- p>&gt;</c->
  <c- a>var</c-> internalDNDType <c- o>=</c-> <c- t>&apos;text/x-example&apos;</c-><c- p>;</c-> <c- c1>// set this to something specific to your site</c->
  <c- a>function</c-> dragStartHandler<c- p>(</c->event<c- p>)</c-> <c- p>{</c->
    <c- k>if</c-> <c- p>(</c->event<c- p>.</c->target <c- k>instanceof</c-> HTMLLIElement<c- p>)</c-> <c- p>{</c->
      <c- c1>// use the element&apos;s data-value=&quot;&quot; attribute as the value to be moving:</c->
      event<c- p>.</c->dataTransfer<c- p>.</c->setData<c- p>(</c->internalDNDType<c- p>,</c-> event<c- p>.</c->target<c- p>.</c->dataset<c- p>.</c->value<c- p>);</c->
      event<c- p>.</c->dataTransfer<c- p>.</c->effectAllowed <c- o>=</c-> <c- t>&apos;move&apos;</c-><c- p>;</c-> <c- c1>// only allow moves</c->
    <c- p>}</c-> <c- k>else</c-> <c- p>{</c->
      event<c- p>.</c->preventDefault<c- p>();</c-> <c- c1>// don&apos;t allow selection to be dragged</c->
    <c- p>}</c->
  <c- p>}</c->
<c- p>&lt;/</c-><c- f>script</c-><c- p>&gt;</c-></code></pre>

  <hr>

  <p>To accept a drop, the drop target has to listen to the following events:</p>

  <ol><li>The <code id=event-drag:event-dnd-dragenter><a href=#event-dnd-dragenter>dragenter</a></code> event handler reports
    whether or not the drop target is potentially willing to accept the drop, by canceling the
    event.<li>The <code id=event-drag:event-dnd-dragover><a href=#event-dnd-dragover>dragover</a></code> event handler specifies what feedback
    will be shown to the user, by setting the <code id=event-drag:dom-datatransfer-dropeffect><a href=#dom-datatransfer-dropeffect>dropEffect</a></code> attribute of the
    <code id=event-drag:datatransfer-2><a href=#datatransfer>DataTransfer</a></code> associated with the event. This event also needs to be canceled.<li>The <code id=event-drag:event-dnd-drop><a href=#event-dnd-drop>drop</a></code> event handler has a final chance to accept or
    reject the drop. If the drop is accepted, the event handler must perform the drop operation on
    the target. This event needs to be canceled, so that the <code id=event-drag:dom-datatransfer-dropeffect-2><a href=#dom-datatransfer-dropeffect>dropEffect</a></code> attribute's value can be used by the
    source. Otherwise, the drop operation is rejected.</ol>

  <p>For example:</p>

  <pre><code class='html'><c- p>&lt;</c-><c- f>p</c-><c- p>&gt;</c->Drop your favorite fruits below:<c- p>&lt;/</c-><c- f>p</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>ol</c-> <c- e>ondragenter</c-><c- o>=</c-><c- s>&quot;dragEnterHandler(event)&quot;</c-> <c- e>ondragover</c-><c- o>=</c-><c- s>&quot;dragOverHandler(event)&quot;</c->
    <c- e>ondrop</c-><c- o>=</c-><c- s>&quot;dropHandler(event)&quot;</c-><c- p>&gt;</c->
<c- p>&lt;/</c-><c- f>ol</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>script</c-><c- p>&gt;</c->
  <c- a>var</c-> internalDNDType <c- o>=</c-> <c- t>&apos;text/x-example&apos;</c-><c- p>;</c-> <c- c1>// set this to something specific to your site</c->
  <c- a>function</c-> dragEnterHandler<c- p>(</c->event<c- p>)</c-> <c- p>{</c->
    <c- a>var</c-> items <c- o>=</c-> event<c- p>.</c->dataTransfer<c- p>.</c->items<c- p>;</c->
    <c- k>for</c-> <c- p>(</c-><c- a>var</c-> i <c- o>=</c-> <c- mi>0</c-><c- p>;</c-> i <c- o>&lt;</c-> items<c- p>.</c->length<c- p>;</c-> <c- o>++</c->i<c- p>)</c-> <c- p>{</c->
      <c- a>var</c-> item <c- o>=</c-> items<c- p>[</c->i<c- p>];</c->
      <c- k>if</c-> <c- p>(</c->item<c- p>.</c->kind <c- o>==</c-> <c- t>&apos;string&apos;</c-> <c- o>&amp;&amp;</c-> item<c- p>.</c->type <c- o>==</c-> internalDNDType<c- p>)</c-> <c- p>{</c->
        event<c- p>.</c->preventDefault<c- p>();</c->
        <c- k>return</c-><c- p>;</c->
      <c- p>}</c->
    <c- p>}</c->
  <c- p>}</c->
  <c- a>function</c-> dragOverHandler<c- p>(</c->event<c- p>)</c-> <c- p>{</c->
    event<c- p>.</c->dataTransfer<c- p>.</c->dropEffect <c- o>=</c-> <c- t>&apos;move&apos;</c-><c- p>;</c->
    event<c- p>.</c->preventDefault<c- p>();</c->
  <c- p>}</c->
  <c- a>function</c-> dropHandler<c- p>(</c->event<c- p>)</c-> <c- p>{</c->
    <c- a>var</c-> li <c- o>=</c-> document<c- p>.</c->createElement<c- p>(</c-><c- t>&apos;li&apos;</c-><c- p>);</c->
    <c- a>var</c-> data <c- o>=</c-> event<c- p>.</c->dataTransfer<c- p>.</c->getData<c- p>(</c->internalDNDType<c- p>);</c->
    <c- k>if</c-> <c- p>(</c->data <c- o>==</c-> <c- t>&apos;fruit-apple&apos;</c-><c- p>)</c-> <c- p>{</c->
      li<c- p>.</c->textContent <c- o>=</c-> <c- t>&apos;Apples&apos;</c-><c- p>;</c->
    <c- p>}</c-> <c- k>else</c-> <c- k>if</c-> <c- p>(</c->data <c- o>==</c-> <c- t>&apos;fruit-orange&apos;</c-><c- p>)</c-> <c- p>{</c->
      li<c- p>.</c->textContent <c- o>=</c-> <c- t>&apos;Oranges&apos;</c-><c- p>;</c->
    <c- p>}</c-> <c- k>else</c-> <c- k>if</c-> <c- p>(</c->data <c- o>==</c-> <c- t>&apos;fruit-pear&apos;</c-><c- p>)</c-> <c- p>{</c->
      li<c- p>.</c->textContent <c- o>=</c-> <c- t>&apos;Pears&apos;</c-><c- p>;</c->
    <c- p>}</c-> <c- k>else</c-> <c- p>{</c->
      li<c- p>.</c->textContent <c- o>=</c-> <c- t>&apos;Unknown Fruit&apos;</c-><c- p>;</c->
    <c- p>}</c->
    event<c- p>.</c->target<c- p>.</c->appendChild<c- p>(</c->li<c- p>);</c->
  <c- p>}</c->
<c- p>&lt;/</c-><c- f>script</c-><c- p>&gt;</c-></code></pre>

  <hr>

  <p>To remove the original element (the one that was dragged) from the display, the <code id=event-drag:event-dnd-dragend><a href=#event-dnd-dragend>dragend</a></code> event can be used.</p>

  <p>For our example here, that means updating the original markup to handle that event:</p>

  <pre><code class='html'><c- p>&lt;</c-><c- f>p</c-><c- p>&gt;</c->What fruits do you like?<c- p>&lt;/</c-><c- f>p</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>ol</c-> <c- e>ondragstart</c-><c- o>=</c-><c- s>&quot;dragStartHandler(event)&quot;</c-> <c- e>ondragend</c-><c- o>=</c-><c- s>&quot;dragEndHandler(event)&quot;</c-><c- p>&gt;</c->
 <em>...as before...</em>
<c- p>&lt;/</c-><c- f>ol</c-><c- p>&gt;</c->
<c- p>&lt;</c-><c- f>script</c-><c- p>&gt;</c->
  <c- a>function</c-> dragStartHandler<c- p>(</c->event<c- p>)</c-> <c- p>{</c->
    <c- c1>// </c-><em><c- c1>...as before...</c-></em>
  <c- p>}</c->
  <c- a>function</c-> dragEndHandler<c- p>(</c->event<c- p>)</c-> <c- p>{</c->
    <c- k>if</c-> <c- p>(</c->event<c- p>.</c->dataTransfer<c- p>.</c->dropEffect <c- o>==</c-> <c- t>&apos;move&apos;</c-><c- p>)</c-> <c- p>{</c->
      <c- c1>// remove the dragged element</c->
      event<c- p>.</c->target<c- p>.</c->parentNode<c- p>.</c->removeChild<c- p>(</c->event<c- p>.</c->target<c- p>);</c->
    <c- p>}</c->
  <c- p>}</c->
<c- p>&lt;/</c-><c- f>script</c-><c- p>&gt;</c-></code></pre>



  <h4 id=the-drag-data-store><span class=secno>6.8.2</span> The drag data store<a href=#the-drag-data-store class=self-link></a></h4>

  <p>The data that underlies a drag-and-drop operation, known as the <dfn id=drag-data-store>drag data store</dfn>,
  consists of the following information:</p>

  <ul><li><p>A <dfn id=drag-data-store-item-list>drag data store item list</dfn>, which is a list of items representing the dragged
   data, each consisting of the following information:</p>

    <dl><dt><dfn id=the-drag-data-item-kind>The drag data item kind</dfn><dd>
      <p>The kind of data:</p>

      <dl><dt><i>Text</i><dd>
        <p>Text.</p>
       <dt><i>File</i><dd>
        <p>Binary data with a file name.</p>
       </dl>
     <dt><dfn id=the-drag-data-item-type-string>The drag data item type string</dfn><dd>
      <p>A Unicode string giving the type or format of the data, generally given by a <a id=the-drag-data-store:mime-type href=https://mimesniff.spec.whatwg.org/#mime-type data-x-internal=mime-type>MIME
      type</a>. Some values that are not <a href=https://mimesniff.spec.whatwg.org/#mime-type id=the-drag-data-store:mime-type-2 data-x-internal=mime-type>MIME types</a> are
      special-cased for legacy reasons. The API does not enforce the use of <a href=https://mimesniff.spec.whatwg.org/#mime-type id=the-drag-data-store:mime-type-3 data-x-internal=mime-type>MIME types</a>; other values can be used as well. In all cases, however, the values
      are all <a id=the-drag-data-store:converted-to-ascii-lowercase href=https://infra.spec.whatwg.org/#ascii-lowercase data-x-internal=converted-to-ascii-lowercase>converted to ASCII lowercase</a> by the API.</p>

      <p>There is a limit of one <i>text</i> item per <a href=#the-drag-data-item-type-string id=the-drag-data-store:the-drag-data-item-type-string>item type string</a>.</p> 
     <dt>The actual data<dd><p>A Unicode or binary string, in some cases with a file name (itself a Unicode string),
      as per <a href=#the-drag-data-item-kind id=the-drag-data-store:the-drag-data-item-kind>the drag data item kind</a>.</dl>

    <p>The <a href=#drag-data-store-item-list id=the-drag-data-store:drag-data-store-item-list>drag data store item list</a> is ordered in the order that the items were added
    to the list; most recently added last.</p>
   <li>
    <p>The following information, used to generate the UI feedback during the drag:</p>

    <ul><li>User-agent-defined default feedback information, known as the <dfn id=drag-data-store-default-feedback>drag data store default
     feedback</dfn>.<li>Optionally, a bitmap image and the coordinate of a point within that image, known as the
     <dfn id=drag-data-store-bitmap>drag data store bitmap</dfn> and <dfn id=drag-data-store-hot-spot-coordinate>drag data store hot spot coordinate</dfn>.</ul>
   <li>
    <p>A <dfn id=drag-data-store-mode>drag data store mode</dfn>, which is one of the following:</p>

    <dl><dt><dfn id=concept-dnd-rw>Read/write mode</dfn><dd>
      <p>For the <code id=the-drag-data-store:event-dnd-dragstart><a href=#event-dnd-dragstart>dragstart</a></code> event. New data can be added to the
      <a href=#drag-data-store id=the-drag-data-store:drag-data-store>drag data store</a>.</p>
     <dt><dfn id=concept-dnd-ro>Read-only mode</dfn><dd>
      <p>For the <code id=the-drag-data-store:event-dnd-drop><a href=#event-dnd-drop>drop</a></code> event. The list of items representing dragged
      data can be read, including the data. No new data can be added.</p>
     <dt><dfn id=concept-dnd-p>Protected mode</dfn><dd>
      <p>For all other events. The formats and kinds in the <a href=#drag-data-store id=the-drag-data-store:drag-data-store-2>drag data store</a> list of
      items representing dragged data can be enumerated, but the data itself is unavailable and no
      new data can be added.</p>
     </dl>
   <li>
    <p>A <dfn id=drag-data-store-allowed-effects-state>drag data store allowed effects state</dfn>, which is a string.</p>
   </ul>

  <p>When a <a href=#drag-data-store id=the-drag-data-store:drag-data-store-3>drag data store</a> is <dfn id=create-a-drag-data-store>created</dfn>, it
  must be initialized such that its <a href=#drag-data-store-item-list id=the-drag-data-store:drag-data-store-item-list-2>drag data store item list</a> is empty, it has no
  <a href=#drag-data-store-default-feedback id=the-drag-data-store:drag-data-store-default-feedback>drag data store default feedback</a>, it has no <a href=#drag-data-store-bitmap id=the-drag-data-store:drag-data-store-bitmap>drag data store bitmap</a> and
  <a href=#drag-data-store-hot-spot-coordinate id=the-drag-data-store:drag-data-store-hot-spot-coordinate>drag data store hot spot coordinate</a>, its <a href=#drag-data-store-mode id=the-drag-data-store:drag-data-store-mode>drag data store mode</a> is <a href=#concept-dnd-p id=the-drag-data-store:concept-dnd-p>protected mode</a>, and its <a href=#drag-data-store-allowed-effects-state id=the-drag-data-store:drag-data-store-allowed-effects-state>drag data store allowed effects
  state</a> is the string "<code id=the-drag-data-store:dom-datatransfer-effectallowed-uninitialized><a href=#dom-datatransfer-effectallowed-uninitialized>uninitialized</a></code>".</p>


  <h4 id=the-datatransfer-interface><span class=secno>6.8.3</span> The <code id=the-datatransfer-interface:datatransfer><a href=#datatransfer>DataTransfer</a></code> interface<a href=#the-datatransfer-interface class=self-link></a></h4>

  <p><code id=the-datatransfer-interface:datatransfer-2><a href=#datatransfer>DataTransfer</a></code> objects are used to expose the <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store>drag data store</a> that
  underlies a drag-and-drop operation.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransfer title="The DataTransfer object is used to hold the data that is being dragged during a drag and drop operation. It may hold one or more data items, each of one or more data types. For more information about drag and drop, see HTML Drag and Drop API.">DataTransfer</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.5+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>3+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>2+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>12+</span></span></div></div></aside><pre><code class='idl'>[<c- g>Exposed</c->=<c- n>Window</c->,
 <a href='#dom-datatransfer' id='the-datatransfer-interface:dom-datatransfer'><c- g>Constructor</c-></a>]
<c- b>interface</c-> <dfn id='datatransfer'><c- g>DataTransfer</c-></dfn> {
  <c- b>attribute</c-> <c- b>DOMString</c-> <a href='#dom-datatransfer-dropeffect' id='the-datatransfer-interface:dom-datatransfer-dropeffect'><c- g>dropEffect</c-></a>;
  <c- b>attribute</c-> <c- b>DOMString</c-> <a href='#dom-datatransfer-effectallowed' id='the-datatransfer-interface:dom-datatransfer-effectallowed'><c- g>effectAllowed</c-></a>;

  [<c- g>SameObject</c->] <c- b>readonly</c-> <c- b>attribute</c-> <a href='#datatransferitemlist' id='the-datatransfer-interface:datatransferitemlist'><c- n>DataTransferItemList</c-></a> <a href='#dom-datatransfer-items' id='the-datatransfer-interface:dom-datatransfer-items'><c- g>items</c-></a>;

  <c- b>void</c-> <a href='#dom-datatransfer-setdragimage' id='the-datatransfer-interface:dom-datatransfer-setdragimage'><c- g>setDragImage</c-></a>(<c- n>Element</c-> <c- g>image</c->, <c- b>long</c-> <c- g>x</c->, <c- b>long</c-> <c- g>y</c->);

  /* old interface */
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>FrozenArray</c->&lt;<c- b>DOMString</c->&gt; <a href='#dom-datatransfer-types' id='the-datatransfer-interface:dom-datatransfer-types'><c- g>types</c-></a>;
  <c- b>DOMString</c-> <a href='#dom-datatransfer-getdata' id='the-datatransfer-interface:dom-datatransfer-getdata'><c- g>getData</c-></a>(<c- b>DOMString</c-> <c- g>format</c->);
  <c- b>void</c-> <a href='#dom-datatransfer-setdata' id='the-datatransfer-interface:dom-datatransfer-setdata'><c- g>setData</c-></a>(<c- b>DOMString</c-> <c- g>format</c->, <c- b>DOMString</c-> <c- g>data</c->);
  <c- b>void</c-> <a href='#dom-datatransfer-cleardata' id='the-datatransfer-interface:dom-datatransfer-cleardata'><c- g>clearData</c-></a>(<c- b>optional</c-> <c- b>DOMString</c-> <c- g>format</c->);
  [<c- g>SameObject</c->] <c- b>readonly</c-> <c- b>attribute</c-> <a href='https://w3c.github.io/FileAPI/#filelist-section' data-x-internal='filelist' id='the-datatransfer-interface:filelist'><c- n>FileList</c-></a> <a href='#dom-datatransfer-files' id='the-datatransfer-interface:dom-datatransfer-files'><c- g>files</c-></a>;
};</code></pre>

  <dl class=domintro><dt><var>dataTransfer</var> = new <code id=dom-datatransfer-dev><a href=#dom-datatransfer>DataTransfer</a></code>()<dd>
    <p>Creates a new <code id=the-datatransfer-interface:datatransfer-3><a href=#datatransfer>DataTransfer</a></code> object with an empty <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-2>drag data
    store</a>.</p>
   <dt><var>dataTransfer</var> . <code id=dom-datatransfer-dropeffect-dev><a href=#dom-datatransfer-dropeffect>dropEffect</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the kind of operation that is currently selected. If the kind of operation isn't one
    of those that is allowed by the <code id=the-datatransfer-interface:dom-datatransfer-effectallowed-2><a href=#dom-datatransfer-effectallowed>effectAllowed</a></code> attribute, then the operation will
    fail.</p>

    <p>Can be set, to change the selected operation.</p>

    <p>The possible values are "<code id=the-datatransfer-interface:dom-datatransfer-dropeffect-none><a href=#dom-datatransfer-dropeffect-none>none</a></code>", "<code id=the-datatransfer-interface:dom-datatransfer-dropeffect-copy><a href=#dom-datatransfer-dropeffect-copy>copy</a></code>", "<code id=the-datatransfer-interface:dom-datatransfer-dropeffect-link><a href=#dom-datatransfer-dropeffect-link>link</a></code>", and "<code id=the-datatransfer-interface:dom-datatransfer-dropeffect-move><a href=#dom-datatransfer-dropeffect-move>move</a></code>".</p>
   <dt><var>dataTransfer</var> . <code id=dom-datatransfer-effectallowed-dev><a href=#dom-datatransfer-effectallowed>effectAllowed</a></code> [ = <var>value</var> ]<dd>
    <p>Returns the kinds of operations that are to be allowed.</p>

    <p>Can be set (during the <code id=the-datatransfer-interface:event-dnd-dragstart><a href=#event-dnd-dragstart>dragstart</a></code> event), to change
    the allowed operations.</p>

    <p>The possible values are "<code id=the-datatransfer-interface:dom-datatransfer-effectallowed-none><a href=#dom-datatransfer-effectallowed-none>none</a></code>",
    "<code id=the-datatransfer-interface:dom-datatransfer-effectallowed-copy><a href=#dom-datatransfer-effectallowed-copy>copy</a></code>", "<code id=the-datatransfer-interface:dom-datatransfer-effectallowed-copylink><a href=#dom-datatransfer-effectallowed-copylink>copyLink</a></code>", "<code id=the-datatransfer-interface:dom-datatransfer-effectallowed-copymove><a href=#dom-datatransfer-effectallowed-copymove>copyMove</a></code>", "<code id=the-datatransfer-interface:dom-datatransfer-effectallowed-link><a href=#dom-datatransfer-effectallowed-link>link</a></code>", "<code id=the-datatransfer-interface:dom-datatransfer-effectallowed-linkmove><a href=#dom-datatransfer-effectallowed-linkmove>linkMove</a></code>", "<code id=the-datatransfer-interface:dom-datatransfer-effectallowed-move><a href=#dom-datatransfer-effectallowed-move>move</a></code>", "<code id=the-datatransfer-interface:dom-datatransfer-effectallowed-all><a href=#dom-datatransfer-effectallowed-all>all</a></code>", and "<code id=the-datatransfer-interface:dom-datatransfer-effectallowed-uninitialized><a href=#dom-datatransfer-effectallowed-uninitialized>uninitialized</a></code>",</p>
   <dt><var>dataTransfer</var> . <code id=dom-datatransfer-items-dev><a href=#dom-datatransfer-items>items</a></code><dd>
    <p>Returns a <code id=the-datatransfer-interface:datatransferitemlist-2><a href=#datatransferitemlist>DataTransferItemList</a></code> object, with the drag data.</p>
   <dt><var>dataTransfer</var> . <code id=dom-datatransfer-setdragimage-dev><a href=#dom-datatransfer-setdragimage>setDragImage</a></code>(<var>element</var>, <var>x</var>, <var>y</var>)<dd>
    <p>Uses the given element to update the drag feedback, replacing any previously specified
    feedback.</p>
   <dt><var>dataTransfer</var> . <code id=dom-datatransfer-types-dev><a href=#dom-datatransfer-types>types</a></code><dd>
    <p>Returns a <a id=the-datatransfer-interface:frozen-array href=https://heycam.github.io/webidl/#dfn-frozen-array-type data-x-internal=frozen-array>frozen array</a> listing the formats that were set in the <code id=the-datatransfer-interface:event-dnd-dragstart-2><a href=#event-dnd-dragstart>dragstart</a></code> event. In addition, if any files are being
    dragged, then one of the types will be the string "<code>Files</code>".</p>
   <dt><var>data</var> = <var>dataTransfer</var> . <code id=dom-datatransfer-getdata-dev><a href=#dom-datatransfer-getdata>getData</a></code>(<var>format</var>)<dd>
    <p>Returns the specified data. If there is no such data, returns the empty string.</p>
   <dt><var>dataTransfer</var> . <code id=dom-datatransfer-setdata-dev><a href=#dom-datatransfer-setdata>setData</a></code>(<var>format</var>, <var>data</var>)<dd>
    <p>Adds the specified data.</p>
   <dt><var>dataTransfer</var> . <code id=dom-datatransfer-cleardata-dev><a href=#dom-datatransfer-cleardata>clearData</a></code>( [ <var>format</var> ] )<dd>
    <p>Removes the data of the specified formats. Removes all data if the argument is omitted.</p>
   <dt><var>dataTransfer</var> . <code id=dom-datatransfer-files-dev><a href=#dom-datatransfer-files>files</a></code><dd>
    <p>Returns a <code id=the-datatransfer-interface:filelist-2><a data-x-internal=filelist href=https://w3c.github.io/FileAPI/#filelist-section>FileList</a></code> of the files being dragged, if any.</p>
   </dl>

  <p><code id=the-datatransfer-interface:datatransfer-4><a href=#datatransfer>DataTransfer</a></code> objects that are created as part of <a href=#dndevents>drag-and-drop events</a> are only valid while those events are being fired.</p>

  

  <p>A <code id=the-datatransfer-interface:datatransfer-5><a href=#datatransfer>DataTransfer</a></code> object is associated with a <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-3>drag data store</a> while it
  is valid.</p>

  <p>A <code id=the-datatransfer-interface:datatransfer-6><a href=#datatransfer>DataTransfer</a></code> object has an associated <dfn id=concept-datatransfer-types>types array</dfn>, which is a
  <code id=the-datatransfer-interface:frozen-array-2><a data-x-internal=frozen-array href=https://heycam.github.io/webidl/#dfn-frozen-array-type>FrozenArray&lt;DOMString></a></code>, initially empty. When the contents
  of the <code id=the-datatransfer-interface:datatransfer-7><a href=#datatransfer>DataTransfer</a></code> object's <a href=#drag-data-store-item-list id=the-datatransfer-interface:drag-data-store-item-list>drag data store item list</a> change, or when
  the <code id=the-datatransfer-interface:datatransfer-8><a href=#datatransfer>DataTransfer</a></code> object becomes no longer associated with a <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-4>drag data
  store</a>, run the following steps:</p>

  <ol><li><p>Let <var>L</var> be an empty sequence.<li>
    <p>If the <code id=the-datatransfer-interface:datatransfer-9><a href=#datatransfer>DataTransfer</a></code> object is still associated with a <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-5>drag data
    store</a>, then:</p>

    <ol><li><p>For each item in the <code id=the-datatransfer-interface:datatransfer-10><a href=#datatransfer>DataTransfer</a></code> object's <a href=#drag-data-store-item-list id=the-datatransfer-interface:drag-data-store-item-list-2>drag data store item
     list</a>  whose <a href=#the-drag-data-item-kind id=the-datatransfer-interface:the-drag-data-item-kind>kind</a>
     is <i>text</i>, add an entry to <var>L</var> consisting of the item's <a href=#the-drag-data-item-type-string id=the-datatransfer-interface:the-drag-data-item-type-string>type string</a>.<li><p>If there are any items in the <code id=the-datatransfer-interface:datatransfer-11><a href=#datatransfer>DataTransfer</a></code> object's <a href=#drag-data-store-item-list id=the-datatransfer-interface:drag-data-store-item-list-3>drag data store
     item list</a> whose <a href=#the-drag-data-item-kind id=the-datatransfer-interface:the-drag-data-item-kind-2>kind</a> is <i>File</i>, then
     add an entry to <var>L</var> consisting of the string "<code>Files</code>". (This
     value can be distinguished from the other values because it is not lowercase.)</ol>
   <li><p>Set the <code id=the-datatransfer-interface:datatransfer-12><a href=#datatransfer>DataTransfer</a></code> object's <a href=#concept-datatransfer-types id=the-datatransfer-interface:concept-datatransfer-types>types
   array</a> to the result of <a id=the-datatransfer-interface:creating-a-frozen-array href=https://heycam.github.io/webidl/#dfn-create-frozen-array data-x-internal=creating-a-frozen-array>creating a frozen array</a> from <var>L</var>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in one engine only." class=less-than-two-engines-flag>⚠</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransfer/DataTransfer title="The DataTransfer constructor creates a new DataTransfer object instance.">DataTransfer/DataTransfer</a><p class=less-than-two-engines-text>Support in one engine only.<div class=support><span class="firefox unknown"><span>Firefox</span><span>?</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>60+</span></span><hr><span class="opera yes"><span>Opera</span><span>47+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie unknown"><span>Internet Explorer</span><span>?</span></span><hr><span class="firefox_android unknown"><span>Firefox Android</span><span>?</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>60+</span></span><span class="webview_android yes"><span>WebView Android</span><span>60+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>8.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>44+</span></span></div></div></aside><p>The <dfn id=dom-datatransfer><code>DataTransfer()</code></dfn> constructor, when
  invoked, must return a newly created <code id=the-datatransfer-interface:datatransfer-13><a href=#datatransfer>DataTransfer</a></code> object initialized as follows:</p>

  <ol><li><p>Set the <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-6>drag data store</a>'s <a href=#drag-data-store-item-list id=the-datatransfer-interface:drag-data-store-item-list-4>item
   list</a> to be an empty list.<li><p>Set the <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-7>drag data store</a>'s <a href=#drag-data-store-mode id=the-datatransfer-interface:drag-data-store-mode>mode</a> to
   <a href=#concept-dnd-rw id=the-datatransfer-interface:concept-dnd-rw>read/write mode</a>.<li><p>Set the <code id=the-datatransfer-interface:dom-datatransfer-dropeffect-2><a href=#dom-datatransfer-dropeffect>dropEffect</a></code> and
   <code id=the-datatransfer-interface:dom-datatransfer-effectallowed-3><a href=#dom-datatransfer-effectallowed>effectAllowed</a></code> to "none".</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransfer/dropEffect title="The DataTransfer.dropEffect property controls the feedback (typically visual) the user is given during a drag and drop operation. It will affect which cursor is displayed while dragging. For example, when the user hovers over a target drop element, the browser's cursor may indicate which type of operation will occur.">DataTransfer/dropEffect</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie unknown"><span>Internet Explorer</span><span>?</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-datatransfer-dropeffect><code>dropEffect</code></dfn> attribute controls
  the drag-and-drop feedback that the user is given during a drag-and-drop operation. When the
  <code id=the-datatransfer-interface:datatransfer-14><a href=#datatransfer>DataTransfer</a></code> object is created, the <code id=the-datatransfer-interface:dom-datatransfer-dropeffect-3><a href=#dom-datatransfer-dropeffect>dropEffect</a></code> attribute is set to a string value. On
  getting, it must return its current value. On setting, if the new value is one of "<dfn id=dom-datatransfer-dropeffect-none><code>none</code></dfn>", "<dfn id=dom-datatransfer-dropeffect-copy><code>copy</code></dfn>", "<dfn id=dom-datatransfer-dropeffect-link><code>link</code></dfn>", or "<dfn id=dom-datatransfer-dropeffect-move><code>move</code></dfn>", then the attribute's current value must be
  set to the new value. Other values must be ignored.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransfer/effectAllowed title="The DataTransfer.effectAllowed property specifies the effect that is allowed for a drag operation. The copy operation is used to indicate that the data being dragged will be copied from its present location to the drop location. The move operation is used to indicate that the data being dragged will be moved, and the link operation is used to indicate that some form of relationship or connection will be created between the source and drop locations.">DataTransfer/effectAllowed</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie unknown"><span>Internet Explorer</span><span>?</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-datatransfer-effectallowed><code>effectAllowed</code></dfn> attribute is
  used in the drag-and-drop processing model to initialize the <code id=the-datatransfer-interface:dom-datatransfer-dropeffect-4><a href=#dom-datatransfer-dropeffect>dropEffect</a></code> attribute during the <code id=the-datatransfer-interface:event-dnd-dragenter><a href=#event-dnd-dragenter>dragenter</a></code> and <code id=the-datatransfer-interface:event-dnd-dragover><a href=#event-dnd-dragover>dragover</a></code> events. When the <code id=the-datatransfer-interface:datatransfer-15><a href=#datatransfer>DataTransfer</a></code> object is
  created, the <code id=the-datatransfer-interface:dom-datatransfer-effectallowed-4><a href=#dom-datatransfer-effectallowed>effectAllowed</a></code> attribute is set
  to a string value. On getting, it must return its current value. On setting, if <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-8>drag data
  store</a>'s <a href=#drag-data-store-mode id=the-datatransfer-interface:drag-data-store-mode-2>mode</a> is the <a href=#concept-dnd-rw id=the-datatransfer-interface:concept-dnd-rw-2>read/write mode</a> and the new value is one of "<dfn id=dom-datatransfer-effectallowed-none><code>none</code></dfn>", "<dfn id=dom-datatransfer-effectallowed-copy><code>copy</code></dfn>", "<dfn id=dom-datatransfer-effectallowed-copylink><code>copyLink</code></dfn>", "<dfn id=dom-datatransfer-effectallowed-copymove><code>copyMove</code></dfn>", "<dfn id=dom-datatransfer-effectallowed-link><code>link</code></dfn>", "<dfn id=dom-datatransfer-effectallowed-linkmove><code>linkMove</code></dfn>", "<dfn id=dom-datatransfer-effectallowed-move><code>move</code></dfn>", "<dfn id=dom-datatransfer-effectallowed-all><code>all</code></dfn>", or "<dfn id=dom-datatransfer-effectallowed-uninitialized><code>uninitialized</code></dfn>", then the attribute's
  current value must be set to the new value. Otherwise it must be left unchanged.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransfer/items title="The read-only DataTransfer property items property is a list of the data transfer items in a drag operation. The list includes one item for each item in the operation and if the operation had no items, the list is empty.">DataTransfer/items</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>50+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>52+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-datatransfer-items><code>items</code></dfn> attribute must return a
  <code id=the-datatransfer-interface:datatransferitemlist-3><a href=#datatransferitemlist>DataTransferItemList</a></code> object associated with the <code id=the-datatransfer-interface:datatransfer-16><a href=#datatransfer>DataTransfer</a></code> object.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransfer/setDragImage title="When a drag occurs, a translucent image is generated from the drag target (the element the dragstart event is fired at), and follows the mouse pointer during the drag. This image is created automatically, so you do not need to create it yourself. However, if a custom image is desired, the DataTransfer.setDragImage() method can be used to set the custom image to be used. The image will typically be an <image> element but it can also be a <canvas> or any other visible element.">DataTransfer/setDragImage</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie unknown"><span>Internet Explorer</span><span>?</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-datatransfer-setdragimage><code>setDragImage(<var>element</var>,
  <var>x</var>, <var>y</var>)</code></dfn> method must run the following steps:</p>

  <ol><li><p>If the <code id=the-datatransfer-interface:datatransfer-17><a href=#datatransfer>DataTransfer</a></code> object is no longer associated with a <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-9>drag data
   store</a>, return. Nothing happens.<li><p>If the <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-10>drag data store</a>'s <a href=#drag-data-store-mode id=the-datatransfer-interface:drag-data-store-mode-3>mode</a> is
   not the <a href=#concept-dnd-rw id=the-datatransfer-interface:concept-dnd-rw-3>read/write mode</a>, return. Nothing
   happens.<li><p>If <var>element</var> is an <code id=the-datatransfer-interface:the-img-element><a href=embedded-content.html#the-img-element>img</a></code> element, then set the <a href=#drag-data-store-bitmap id=the-datatransfer-interface:drag-data-store-bitmap>drag data store
   bitmap</a> to the element's image (at its <a href=https://drafts.csswg.org/css-images/#intrinsic-dimensions id=the-datatransfer-interface:intrinsic-dimensions data-x-internal=intrinsic-dimensions>intrinsic
   size</a>); otherwise, set the <a href=#drag-data-store-bitmap id=the-datatransfer-interface:drag-data-store-bitmap-2>drag data store bitmap</a> to an image generated from
   the given element (the exact mechanism for doing so is not currently specified).<li><p>Set the <a href=#drag-data-store-hot-spot-coordinate id=the-datatransfer-interface:drag-data-store-hot-spot-coordinate>drag data store hot spot coordinate</a> to the given <var>x</var>,
   <var>y</var> coordinate.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransfer/types title="The DataTransfer.types read-only property returns an array of the drag data formats (as strings) that were set in the dragstart event. The order of the formats is the same order as the data included in the drag operation.">DataTransfer/types</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-datatransfer-types><code>types</code></dfn> attribute must return this
  <code id=the-datatransfer-interface:datatransfer-18><a href=#datatransfer>DataTransfer</a></code> object's <a href=#concept-datatransfer-types id=the-datatransfer-interface:concept-datatransfer-types-2>types
  array</a>.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransfer/getData title="The DataTransfer.getData() method retrieves drag data (as a DOMString) for the specified type. If the drag operation does not include data, this method returns an empty string.">DataTransfer/getData</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie unknown"><span>Internet Explorer</span><span>?</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-datatransfer-getdata><code>getData(<var>format</var>)</code></dfn> method
  must run the following steps:</p>

  <ol><li><p>If the <code id=the-datatransfer-interface:datatransfer-19><a href=#datatransfer>DataTransfer</a></code> object is no longer associated with a <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-11>drag data
   store</a>, then return the empty string.<li><p>If the <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-12>drag data store</a>'s <a href=#drag-data-store-mode id=the-datatransfer-interface:drag-data-store-mode-4>mode</a> is
   the <a href=#concept-dnd-p id=the-datatransfer-interface:concept-dnd-p>protected mode</a>, then return the empty string.<li><p>Let <var>format</var> be the first argument, <a id=the-datatransfer-interface:converted-to-ascii-lowercase href=https://infra.spec.whatwg.org/#ascii-lowercase data-x-internal=converted-to-ascii-lowercase>converted to ASCII
   lowercase</a>.<li><p>Let <var>convert-to-URL</var> be false.<li><p>If <var>format</var> equals "<code>text</code>", change it to "<code>text/plain</code>".<li><p>If <var>format</var> equals "<code>url</code>", change it to "<code>text/uri-list</code>" and set <var>convert-to-URL</var> to true.<li><p>If there is no item in the <a href=#drag-data-store-item-list id=the-datatransfer-interface:drag-data-store-item-list-5>drag data store item list</a> whose <a href=#the-drag-data-item-kind id=the-datatransfer-interface:the-drag-data-item-kind-3>kind</a> is <i>text</i> and whose <a href=#the-drag-data-item-type-string id=the-datatransfer-interface:the-drag-data-item-type-string-2>type string</a> is equal to <var>format</var>, return the empty string.<li><p>Let <var>result</var> be the data of the item in the <a href=#drag-data-store-item-list id=the-datatransfer-interface:drag-data-store-item-list-6>drag data store item
   list</a> whose <a href=#the-drag-data-item-kind id=the-datatransfer-interface:the-drag-data-item-kind-4>kind</a> is <i>Plain Unicode
   string</i> and whose <a href=#the-drag-data-item-type-string id=the-datatransfer-interface:the-drag-data-item-type-string-3>type string</a> is equal to
   <var>format</var>.<li><p>If <var>convert-to-URL</var> is true, then parse <var>result</var> as appropriate for
   <code>text/uri-list</code> data, and then set <var>result</var> to the first URL from
   the list, if any, or the empty string otherwise. <a href=references.html#refsRFC2483>[RFC2483]</a><li><p>Return <var>result</var>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransfer/setData title="The DataTransfer.setData() method sets the drag operation's drag data to the specified data and type. If data for the given type does not exist, it is added at the end of the drag data store, such that the last item in the types list will be the new type. If data for the given type already exists, the existing data is replaced in the same position. That is, the order of the types list is not changed when replacing data of the same type.">DataTransfer/setData</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>10+</span></span><span class="safari yes"><span>Safari</span><span>5+</span></span><span class="chrome yes"><span>Chrome</span><span>3+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>10+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>5+</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>18+</span></span><span class="webview_android yes"><span>WebView Android</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Android</span><span>12+</span></span></div></div></aside><p>The <dfn id=dom-datatransfer-setdata><code>setData(<var>format</var>,
  <var>data</var>)</code></dfn> method must run the following steps:</p>

  <ol><li><p>If the <code id=the-datatransfer-interface:datatransfer-20><a href=#datatransfer>DataTransfer</a></code> object is no longer associated with a <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-13>drag data
   store</a>, return. Nothing happens.<li><p>If the <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-14>drag data store</a>'s <a href=#drag-data-store-mode id=the-datatransfer-interface:drag-data-store-mode-5>mode</a> is
   not the <a href=#concept-dnd-rw id=the-datatransfer-interface:concept-dnd-rw-4>read/write mode</a>, return. Nothing
   happens.<li><p>Let <var>format</var> be the first argument, <a id=the-datatransfer-interface:converted-to-ascii-lowercase-2 href=https://infra.spec.whatwg.org/#ascii-lowercase data-x-internal=converted-to-ascii-lowercase>converted to ASCII
   lowercase</a>.<li>
    <p>If <var>format</var> equals "<code>text</code>", change it to "<code>text/plain</code>".</p>

    <p>If <var>format</var> equals "<code>url</code>", change it to "<code>text/uri-list</code>".</p>
   <li><p>Remove the item in the <a href=#drag-data-store-item-list id=the-datatransfer-interface:drag-data-store-item-list-7>drag data store item list</a> whose <a href=#the-drag-data-item-kind id=the-datatransfer-interface:the-drag-data-item-kind-5>kind</a> is <i>text</i> and whose <a href=#the-drag-data-item-type-string id=the-datatransfer-interface:the-drag-data-item-type-string-4>type string</a> is equal to <var>format</var>, if there is
   one.<li><p>Add an item to the <a href=#drag-data-store-item-list id=the-datatransfer-interface:drag-data-store-item-list-8>drag data store item list</a> whose <a href=#the-drag-data-item-kind id=the-datatransfer-interface:the-drag-data-item-kind-6>kind</a> is <i>text</i>, whose <a href=#the-drag-data-item-type-string id=the-datatransfer-interface:the-drag-data-item-type-string-5>type string</a> is equal to <var>format</var>, and whose data is the string
   given by the method's second argument.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransfer/clearData title="The DataTransfer.clearData() method removes the drag operation's drag data for the given type. If data for the given type does not exist, this method does nothing.">DataTransfer/clearData</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie unknown"><span>Internet Explorer</span><span>?</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-datatransfer-cleardata><code>clearData()</code></dfn> method must run the
  following steps:</p>

  <ol><li><p>If the <code id=the-datatransfer-interface:datatransfer-21><a href=#datatransfer>DataTransfer</a></code> object is no longer associated with a <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-15>drag data
   store</a>, return. Nothing happens.<li><p>If the <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-16>drag data store</a>'s <a href=#drag-data-store-mode id=the-datatransfer-interface:drag-data-store-mode-6>mode</a> is
   not the <a href=#concept-dnd-rw id=the-datatransfer-interface:concept-dnd-rw-5>read/write mode</a>, return. Nothing
   happens.<li><p>If the method was called with no arguments, remove each item in the <a href=#drag-data-store-item-list id=the-datatransfer-interface:drag-data-store-item-list-9>drag data store
   item list</a> whose <a href=#the-drag-data-item-kind id=the-datatransfer-interface:the-drag-data-item-kind-7>kind</a> is <i>Plain Unicode
   string</i>, and return.<li><p>Let <var>format</var> be the first argument, <a id=the-datatransfer-interface:converted-to-ascii-lowercase-3 href=https://infra.spec.whatwg.org/#ascii-lowercase data-x-internal=converted-to-ascii-lowercase>converted to ASCII
   lowercase</a>.<li>
    <p>If <var>format</var> equals "<code>text</code>", change it to "<code>text/plain</code>".</p>

    <p>If <var>format</var> equals "<code>url</code>", change it to "<code>text/uri-list</code>".</p>
   <li><p>Remove the item in the <a href=#drag-data-store-item-list id=the-datatransfer-interface:drag-data-store-item-list-10>drag data store item list</a> whose <a href=#the-drag-data-item-kind id=the-datatransfer-interface:the-drag-data-item-kind-8>kind</a> is <i>text</i> and whose <a href=#the-drag-data-item-type-string id=the-datatransfer-interface:the-drag-data-item-type-string-6>type string</a> is equal to <var>format</var>, if there is
   one.</ol>

  <p class=note>The <code id=the-datatransfer-interface:dom-datatransfer-cleardata-2><a href=#dom-datatransfer-cleardata>clearData()</a></code> method does not
  affect whether any files were included in the drag, so the <code id=the-datatransfer-interface:dom-datatransfer-types-2><a href=#dom-datatransfer-types>types</a></code> attribute's list might still not be empty after
  calling <code id=the-datatransfer-interface:dom-datatransfer-cleardata-3><a href=#dom-datatransfer-cleardata>clearData()</a></code> (it would still contain the
  "<code>Files</code>" string if any files were included in the drag).</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransfer/files title="The DataTransfer.files property is a list of the files in the drag operation. If the operation includes no files, the list is empty.">DataTransfer/files</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie unknown"><span>Internet Explorer</span><span>?</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside><p>The <dfn id=dom-datatransfer-files><code>files</code></dfn> attribute must return a
  <a id=the-datatransfer-interface:live href=infrastructure.html#live>live</a> <code id=the-datatransfer-interface:filelist-3><a data-x-internal=filelist href=https://w3c.github.io/FileAPI/#filelist-section>FileList</a></code> sequence consisting of <code id=the-datatransfer-interface:file><a data-x-internal=file href=https://w3c.github.io/FileAPI/#dfn-file>File</a></code> objects
  representing the files found by the following steps.
  Furthermore, for a given <code id=the-datatransfer-interface:filelist-4><a data-x-internal=filelist href=https://w3c.github.io/FileAPI/#filelist-section>FileList</a></code> object and a given underlying file, the same
  <code id=the-datatransfer-interface:file-2><a data-x-internal=file href=https://w3c.github.io/FileAPI/#dfn-file>File</a></code> object must be used each time.</p>

  <ol><li><p>Start with an empty list <var>L</var>.<li><p>If the <code id=the-datatransfer-interface:datatransfer-22><a href=#datatransfer>DataTransfer</a></code> object is no longer associated with a <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-17>drag data
   store</a>, the <code id=the-datatransfer-interface:filelist-5><a data-x-internal=filelist href=https://w3c.github.io/FileAPI/#filelist-section>FileList</a></code> is empty. Return the empty list <var>L</var>.<li><p>If the <a href=#drag-data-store id=the-datatransfer-interface:drag-data-store-18>drag data store</a>'s <a href=#drag-data-store-mode id=the-datatransfer-interface:drag-data-store-mode-7>mode</a> is
   the <a href=#concept-dnd-p id=the-datatransfer-interface:concept-dnd-p-2>protected mode</a>, Return the empty list
   <var>L</var>.<li><p>For each item in the <a href=#drag-data-store-item-list id=the-datatransfer-interface:drag-data-store-item-list-11>drag data store item list</a> 
   whose <a href=#the-drag-data-item-kind id=the-datatransfer-interface:the-drag-data-item-kind-9>kind</a> is <i>File</i> , add the item's data (the file, in particular its name and contents, as well as
   its <a href=#the-drag-data-item-type-string id=the-datatransfer-interface:the-drag-data-item-type-string-7>type</a>) to the list <var>L</var>.<li><p>The files found by these steps are those in the list <var>L</var>.</ol>

  <p class=note>This version of the API does not expose the types of the files during the
  drag.</p>

  


  <h5 id=the-datatransferitemlist-interface><span class=secno>6.8.3.1</span> The <code id=the-datatransferitemlist-interface:datatransferitemlist><a href=#datatransferitemlist>DataTransferItemList</a></code> interface<a href=#the-datatransferitemlist-interface class=self-link></a></h5><aside class="mdn-anno wrapped"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransferItemList/DataTransferItem title="The DataTransferItem() getter method implements support for accessing items in the DataTransferItemList using array-style syntax (that is DataTransferItem[index]).">DataTransferItemList/DataTransferItem</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>50+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>50+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside>

  <p>Each <code id=the-datatransferitemlist-interface:datatransfer><a href=#datatransfer>DataTransfer</a></code> object is associated with a <code id=the-datatransferitemlist-interface:datatransferitemlist-2><a href=#datatransferitemlist>DataTransferItemList</a></code>
  object.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransferItemList title="The DataTransferItemList object is a list of DataTransferItem objects representing items being dragged. During a drag operation, each DragEvent has a dataTransfer property and that property is a DataTransferItemList.">DataTransferItemList</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>50+</span></span><span class="safari yes"><span>Safari</span><span>11.1+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>50+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><pre><code class='idl'>[<c- g>Exposed</c->=<c- n>Window</c->]
<c- b>interface</c-> <dfn id='datatransferitemlist'><c- g>DataTransferItemList</c-></dfn> {
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>unsigned</c-> <c- b>long</c-> <a href='#dom-datatransferitemlist-length' id='the-datatransferitemlist-interface:dom-datatransferitemlist-length'><c- g>length</c-></a>;
  <a href='#dom-datatransferitemlist-item'><c- b>getter</c-></a> <a href='#datatransferitem' id='the-datatransferitemlist-interface:datatransferitem'><c- n>DataTransferItem</c-></a> (<c- b>unsigned</c-> <c- b>long</c-> <c- g>index</c->);
  <a href='#datatransferitem' id='the-datatransferitemlist-interface:datatransferitem-2'><c- n>DataTransferItem</c-></a>? <a href='#dom-datatransferitemlist-add' id='the-datatransferitemlist-interface:dom-datatransferitemlist-add'><c- g>add</c-></a>(<c- b>DOMString</c-> <c- g>data</c->, <c- b>DOMString</c-> <c- g>type</c->);
  <a href='#datatransferitem' id='the-datatransferitemlist-interface:datatransferitem-3'><c- n>DataTransferItem</c-></a>? <a href='#dom-datatransferitemlist-add' id='the-datatransferitemlist-interface:dom-datatransferitemlist-add-2'><c- g>add</c-></a>(<a href='https://w3c.github.io/FileAPI/#dfn-file' data-x-internal='file' id='the-datatransferitemlist-interface:file'><c- n>File</c-></a> <c- g>data</c->);
  <c- b>void</c-> <a href='#dom-datatransferitemlist-remove' id='the-datatransferitemlist-interface:dom-datatransferitemlist-remove'><c- g>remove</c-></a>(<c- b>unsigned</c-> <c- b>long</c-> <c- g>index</c->);
  <c- b>void</c-> <a href='#dom-datatransferitemlist-clear' id='the-datatransferitemlist-interface:dom-datatransferitemlist-clear'><c- g>clear</c-></a>();
};</code></pre>

  <dl class=domintro><dt><var>items</var> . <code id=dom-datatransferitemlist-length-dev><a href=#dom-datatransferitemlist-length>length</a></code><dd><p>Returns the number of items in the <a href=#drag-data-store id=the-datatransferitemlist-interface:drag-data-store>drag data store</a>.<dt><var>items</var>[<var>index</var>]<dd>
    <p>Returns the <code id=the-datatransferitemlist-interface:datatransferitem-4><a href=#datatransferitem>DataTransferItem</a></code> object representing the <var>index</var>th
    entry in the <a href=#drag-data-store id=the-datatransferitemlist-interface:drag-data-store-2>drag data store</a>.</p>
   <dt><var>items</var> . <code id=dom-datatransferitemlist-remove-dev><a href=#dom-datatransferitemlist-remove>remove</a></code>(<var>index</var>)<dd>
    <p>Removes the <var>index</var>th entry in the <a href=#drag-data-store id=the-datatransferitemlist-interface:drag-data-store-3>drag data store</a>.</p>
   <dt><var>items</var> . <code id=dom-datatransferitemlist-clear-dev><a href=#dom-datatransferitemlist-clear>clear</a></code>()<dd>
    <p>Removes all the entries in the <a href=#drag-data-store id=the-datatransferitemlist-interface:drag-data-store-4>drag data store</a>.</p>
   <dt><var>items</var> . <code id=dom-datatransferitemlist-add-dev><a href=#dom-datatransferitemlist-add>add</a></code>(<var>data</var>)<dt><var>items</var> . <code id=the-datatransferitemlist-interface:dom-datatransferitemlist-add-3><a href=#dom-datatransferitemlist-add>add</a></code>(<var>data</var>, <var>type</var>)<dd>
    <p>Adds a new entry for the given data to the <a href=#drag-data-store id=the-datatransferitemlist-interface:drag-data-store-5>drag data store</a>. If the data is plain
    text  then a <var>type</var> string has to be provided
    also.</p>
   </dl>

  

  <p>While the <code id=the-datatransferitemlist-interface:datatransferitemlist-3><a href=#datatransferitemlist>DataTransferItemList</a></code> object's <code id=the-datatransferitemlist-interface:datatransfer-2><a href=#datatransfer>DataTransfer</a></code> object is
  associated with a <a href=#drag-data-store id=the-datatransferitemlist-interface:drag-data-store-6>drag data store</a>, the <code id=the-datatransferitemlist-interface:datatransferitemlist-4><a href=#datatransferitemlist>DataTransferItemList</a></code> object's
  <i>mode</i> is the same as the <a href=#drag-data-store-mode id=the-datatransferitemlist-interface:drag-data-store-mode>drag data store mode</a>. When the
  <code id=the-datatransferitemlist-interface:datatransferitemlist-5><a href=#datatransferitemlist>DataTransferItemList</a></code> object's <code id=the-datatransferitemlist-interface:datatransfer-3><a href=#datatransfer>DataTransfer</a></code> object is <em>not</em>
  associated with a <a href=#drag-data-store id=the-datatransferitemlist-interface:drag-data-store-7>drag data store</a>, the <code id=the-datatransferitemlist-interface:datatransferitemlist-6><a href=#datatransferitemlist>DataTransferItemList</a></code> object's
  <i>mode</i> is the <i>disabled mode</i>. The <a href=#drag-data-store id=the-datatransferitemlist-interface:drag-data-store-8>drag data store</a> referenced in this
  section (which is used only when the <code id=the-datatransferitemlist-interface:datatransferitemlist-7><a href=#datatransferitemlist>DataTransferItemList</a></code> object is not in the
  <i>disabled mode</i>) is the <a href=#drag-data-store id=the-datatransferitemlist-interface:drag-data-store-9>drag data store</a> with which the
  <code id=the-datatransferitemlist-interface:datatransferitemlist-8><a href=#datatransferitemlist>DataTransferItemList</a></code> object's <code id=the-datatransferitemlist-interface:datatransfer-4><a href=#datatransfer>DataTransfer</a></code> object is associated.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransferItemList/length title="The read-only length property of the DataTransferItemList interface returns the number of items currently in the drag item list.">DataTransferItemList/length</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>50+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>50+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><p>The <dfn id=dom-datatransferitemlist-length><code>length</code></dfn> attribute must
  return zero if the object is in the <i>disabled mode</i>; otherwise it must return the number of
  items in the <a href=#drag-data-store-item-list id=the-datatransferitemlist-interface:drag-data-store-item-list>drag data store item list</a>.</p>

  <p>When a <code id=the-datatransferitemlist-interface:datatransferitemlist-9><a href=#datatransferitemlist>DataTransferItemList</a></code> object is not in the <i>disabled mode</i>, its
  <a id=the-datatransferitemlist-interface:supported-property-indices href=https://heycam.github.io/webidl/#dfn-supported-property-indices data-x-internal=supported-property-indices>supported property indices</a> are the numbers in the range

    <span>0 .. <var>n</var>-1</span>,

  where <var>n</var> is the number of items in the <a href=#drag-data-store-item-list id=the-datatransferitemlist-interface:drag-data-store-item-list-2>drag data store item
  list</a>.</p>

  <p id=dom-datatransferitemlist-item>To <a id=the-datatransferitemlist-interface:determine-the-value-of-an-indexed-property href=https://heycam.github.io/webidl/#dfn-determine-the-value-of-an-indexed-property data-x-internal=determine-the-value-of-an-indexed-property>determine the value of an indexed property</a>
  <var>i</var> of a <code id=the-datatransferitemlist-interface:datatransferitemlist-10><a href=#datatransferitemlist>DataTransferItemList</a></code> object, the user agent must return a
  <code id=the-datatransferitemlist-interface:datatransferitem-5><a href=#datatransferitem>DataTransferItem</a></code> object representing the <var>i</var>th item in the
  <a href=#drag-data-store id=the-datatransferitemlist-interface:drag-data-store-10>drag data store</a>. The same object must be returned each time a particular item is
  obtained from this <code id=the-datatransferitemlist-interface:datatransferitemlist-11><a href=#datatransferitemlist>DataTransferItemList</a></code> object. The <code id=the-datatransferitemlist-interface:datatransferitem-6><a href=#datatransferitem>DataTransferItem</a></code>
  object must be associated with the same <code id=the-datatransferitemlist-interface:datatransfer-5><a href=#datatransfer>DataTransfer</a></code> object as the
  <code id=the-datatransferitemlist-interface:datatransferitemlist-12><a href=#datatransferitemlist>DataTransferItemList</a></code> object when it is first created.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in one engine only." class=less-than-two-engines-flag>⚠</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransferItemList/add title="The DataTransferItemList.add() method creates a new DataTransferItem using the specified data and adds it to the drag data list. The item may be a File or a string of a given type. If the item is successfully added to the list, the newly-created DataTransferItem object is returned.">DataTransferItemList/add</a><p class=less-than-two-engines-text>Support in one engine only.<div class=support><span class="firefox yes"><span>Firefox</span><span>50+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome no"><span>Chrome</span><span>No</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink no"><span>Edge</span><span>No</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>50+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><p>The <dfn id=dom-datatransferitemlist-add><code>add()</code></dfn> method must run the
  following steps:</p>

  <ol><li><p>If the <code id=the-datatransferitemlist-interface:datatransferitemlist-13><a href=#datatransferitemlist>DataTransferItemList</a></code> object is not in the <i id=the-datatransferitemlist-interface:concept-dnd-rw><a href=#concept-dnd-rw>read/write mode</a></i>, return null.<li>
    <p>Jump to the appropriate set of steps from the following list:</p>

    <dl class=switch><dt>If the first argument to the method is a string<dd>
      <p>If there is already an item in the <a href=#drag-data-store-item-list id=the-datatransferitemlist-interface:drag-data-store-item-list-3>drag data store item list</a> whose <a href=#the-drag-data-item-kind id=the-datatransferitemlist-interface:the-drag-data-item-kind>kind</a> is <i>text</i> and whose <a href=#the-drag-data-item-type-string id=the-datatransferitemlist-interface:the-drag-data-item-type-string>type string</a> is equal to the value of the
      method's second argument, <a id=the-datatransferitemlist-interface:converted-to-ascii-lowercase href=https://infra.spec.whatwg.org/#ascii-lowercase data-x-internal=converted-to-ascii-lowercase>converted to ASCII lowercase</a>, then throw a
      <a id=the-datatransferitemlist-interface:notsupportederror href=https://heycam.github.io/webidl/#notsupportederror data-x-internal=notsupportederror>"<code>NotSupportedError</code>"</a> <code id=the-datatransferitemlist-interface:domexception><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.</p>

      <p>Otherwise, add an item to the <a href=#drag-data-store-item-list id=the-datatransferitemlist-interface:drag-data-store-item-list-4>drag data store item list</a> whose <a href=#the-drag-data-item-kind id=the-datatransferitemlist-interface:the-drag-data-item-kind-2>kind</a> is <i>text</i>, whose <a href=#the-drag-data-item-type-string id=the-datatransferitemlist-interface:the-drag-data-item-type-string-2>type string</a> is equal to the value of the method's second
      argument, <a id=the-datatransferitemlist-interface:converted-to-ascii-lowercase-2 href=https://infra.spec.whatwg.org/#ascii-lowercase data-x-internal=converted-to-ascii-lowercase>converted to ASCII lowercase</a>, and whose data is the string given by the
      method's first argument.</p>
     <dt>If the first argument to the method is a <code id=the-datatransferitemlist-interface:file-2><a data-x-internal=file href=https://w3c.github.io/FileAPI/#dfn-file>File</a></code><dd>
      <p>Add an item to the <a href=#drag-data-store-item-list id=the-datatransferitemlist-interface:drag-data-store-item-list-5>drag data store item list</a> whose <a href=#the-drag-data-item-kind id=the-datatransferitemlist-interface:the-drag-data-item-kind-3>kind</a> is <i>File</i>, whose <a href=#the-drag-data-item-type-string id=the-datatransferitemlist-interface:the-drag-data-item-type-string-3>type
      string</a> is the <code id=the-datatransferitemlist-interface:dom-blob-type><a data-x-internal=dom-blob-type href=https://w3c.github.io/FileAPI/#dfn-type>type</a></code> of the <code id=the-datatransferitemlist-interface:file-3><a data-x-internal=file href=https://w3c.github.io/FileAPI/#dfn-file>File</a></code>,
      <a id=the-datatransferitemlist-interface:converted-to-ascii-lowercase-3 href=https://infra.spec.whatwg.org/#ascii-lowercase data-x-internal=converted-to-ascii-lowercase>converted to ASCII lowercase</a>, and whose data is the same as the
      <code id=the-datatransferitemlist-interface:file-4><a data-x-internal=file href=https://w3c.github.io/FileAPI/#dfn-file>File</a></code>'s data.</p>
     </dl>
   <li><p><a href=#dom-datatransferitemlist-item>Determine the value of the indexed property</a>
   corresponding to the newly added item, and return that value (a newly created
   <code id=the-datatransferitemlist-interface:datatransferitem-7><a href=#datatransferitem>DataTransferItem</a></code> object).</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransferItemList/remove title=undefined.>DataTransferItemList/remove</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>50+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>50+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><p>The <dfn id=dom-datatransferitemlist-remove><code>remove()</code></dfn> method, when
  invoked with the argument <var>i</var>, must run these steps:</p>

  <ol><li><p>If the <code id=the-datatransferitemlist-interface:datatransferitemlist-14><a href=#datatransferitemlist>DataTransferItemList</a></code> object is not in the <i id=the-datatransferitemlist-interface:concept-dnd-rw-2><a href=#concept-dnd-rw>read/write mode</a></i>, throw an
   <a id=the-datatransferitemlist-interface:invalidstateerror href=https://heycam.github.io/webidl/#invalidstateerror data-x-internal=invalidstateerror>"<code>InvalidStateError</code>"</a> <code id=the-datatransferitemlist-interface:domexception-2><a data-x-internal=domexception href=https://heycam.github.io/webidl/#dfn-DOMException>DOMException</a></code>.<li><p>Remove the <var>i</var>th item from the <a href=#drag-data-store id=the-datatransferitemlist-interface:drag-data-store-11>drag data store</a>.</ol>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransferItemList/clear title="The DataTransferItemList method clear() removes all DataTransferItem objects from the drag data items list, leaving the list empty.">DataTransferItemList/clear</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>50+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>50+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><p>The <dfn id=dom-datatransferitemlist-clear><code>clear()</code></dfn> method, if the
  <code id=the-datatransferitemlist-interface:datatransferitemlist-15><a href=#datatransferitemlist>DataTransferItemList</a></code> object is in the <i id=the-datatransferitemlist-interface:concept-dnd-rw-3><a href=#concept-dnd-rw>read/write mode</a></i>,
  must remove all the items from the <a href=#drag-data-store id=the-datatransferitemlist-interface:drag-data-store-12>drag data store</a>. Otherwise, it must do
  nothing.</p>

  


  <h5 id=the-datatransferitem-interface><span class=secno>6.8.3.2</span> The <code id=the-datatransferitem-interface:datatransferitem><a href=#datatransferitem>DataTransferItem</a></code> interface<a href=#the-datatransferitem-interface class=self-link></a></h5>

  <p>Each <code id=the-datatransferitem-interface:datatransferitem-2><a href=#datatransferitem>DataTransferItem</a></code> object is associated with a <code id=the-datatransferitem-interface:datatransfer><a href=#datatransfer>DataTransfer</a></code>
  object.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransferItem title="The DataTransferItem object represents one drag data item. During a drag operation, each drag event has a dataTransfer property which contains a list of drag data items. Each item in the list is a DataTransferItem object.">DataTransferItem</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>50+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>50+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><pre><code class='idl'>[<c- g>Exposed</c->=<c- n>Window</c->]
<c- b>interface</c-> <dfn id='datatransferitem'><c- g>DataTransferItem</c-></dfn> {
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>DOMString</c-> <a href='#dom-datatransferitem-kind' id='the-datatransferitem-interface:dom-datatransferitem-kind'><c- g>kind</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <c- b>DOMString</c-> <a href='#dom-datatransferitem-type' id='the-datatransferitem-interface:dom-datatransferitem-type'><c- g>type</c-></a>;
  <c- b>void</c-> <a href='#dom-datatransferitem-getasstring' id='the-datatransferitem-interface:dom-datatransferitem-getasstring'><c- g>getAsString</c-></a>(<a href='#functionstringcallback' id='the-datatransferitem-interface:functionstringcallback'><c- n>FunctionStringCallback</c-></a>? <c- g>_callback</c->);
  <a href='https://w3c.github.io/FileAPI/#dfn-file' data-x-internal='file' id='the-datatransferitem-interface:file'><c- n>File</c-></a>? <a href='#dom-datatransferitem-getasfile' id='the-datatransferitem-interface:dom-datatransferitem-getasfile'><c- g>getAsFile</c-></a>();
};

<c- b>callback</c-> <dfn id='functionstringcallback'><c- g>FunctionStringCallback</c-></dfn> = <c- b>void</c-> (<c- b>DOMString</c-> <c- g>data</c->);</code></pre>

  <dl class=domintro><dt><var>item</var> . <code id=dom-datatransferitem-kind-dev><a href=#dom-datatransferitem-kind>kind</a></code><dd>
    <p>Returns <a href=#the-drag-data-item-kind id=the-datatransferitem-interface:the-drag-data-item-kind>the drag data item kind</a>, one of: "string",
     "file".</p>
   <dt><var>item</var> . <code id=dom-datatransferitem-type-dev><a href=#dom-datatransferitem-type>type</a></code><dd>
    <p>Returns <a href=#the-drag-data-item-type-string id=the-datatransferitem-interface:the-drag-data-item-type-string>the drag data item type string</a>.</p>
   <dt><var>item</var> . <code id=dom-datatransferitem-getasstring-dev><a href=#dom-datatransferitem-getasstring>getAsString</a></code>(<var>callback</var>)<dd>
    <p>Invokes the callback with the string data as the argument, if <a href=#the-drag-data-item-kind id=the-datatransferitem-interface:the-drag-data-item-kind-2>the drag data item
    kind</a> is <i>text</i>.</p>
   <dt><var>file</var> = <var>item</var> . <code id=dom-datatransferitem-getasfile-dev><a href=#dom-datatransferitem-getasfile>getAsFile</a></code>()<dd>
    <p>Returns a <code id=the-datatransferitem-interface:file-2><a data-x-internal=file href=https://w3c.github.io/FileAPI/#dfn-file>File</a></code> object, if <a href=#the-drag-data-item-kind id=the-datatransferitem-interface:the-drag-data-item-kind-3>the drag data item kind</a> is <i>File</i>.</p>
   </dl>

  

  <p>While the <code id=the-datatransferitem-interface:datatransferitem-3><a href=#datatransferitem>DataTransferItem</a></code> object's <code id=the-datatransferitem-interface:datatransfer-2><a href=#datatransfer>DataTransfer</a></code> object is associated
  with a <a href=#drag-data-store id=the-datatransferitem-interface:drag-data-store>drag data store</a> and that <a href=#drag-data-store id=the-datatransferitem-interface:drag-data-store-2>drag data store</a>'s <a href=#drag-data-store-item-list id=the-datatransferitem-interface:drag-data-store-item-list>drag data store
  item list</a> still contains the item that the <code id=the-datatransferitem-interface:datatransferitem-4><a href=#datatransferitem>DataTransferItem</a></code> object represents,
  the <code id=the-datatransferitem-interface:datatransferitem-5><a href=#datatransferitem>DataTransferItem</a></code> object's <i>mode</i> is the same as the <a href=#drag-data-store-mode id=the-datatransferitem-interface:drag-data-store-mode>drag data store
  mode</a>. When the <code id=the-datatransferitem-interface:datatransferitem-6><a href=#datatransferitem>DataTransferItem</a></code> object's <code id=the-datatransferitem-interface:datatransfer-3><a href=#datatransfer>DataTransfer</a></code> object is
  <em>not</em> associated with a <a href=#drag-data-store id=the-datatransferitem-interface:drag-data-store-3>drag data store</a>, or if the item that the
  <code id=the-datatransferitem-interface:datatransferitem-7><a href=#datatransferitem>DataTransferItem</a></code> object represents has been removed from the relevant <a href=#drag-data-store-item-list id=the-datatransferitem-interface:drag-data-store-item-list-2>drag data
  store item list</a>, the <code id=the-datatransferitem-interface:datatransferitem-8><a href=#datatransferitem>DataTransferItem</a></code> object's <i>mode</i> is the <i>disabled
  mode</i>. The <a href=#drag-data-store id=the-datatransferitem-interface:drag-data-store-4>drag data store</a> referenced in this section (which is used only when the
  <code id=the-datatransferitem-interface:datatransferitem-9><a href=#datatransferitem>DataTransferItem</a></code> object is not in the <i>disabled mode</i>) is the <a href=#drag-data-store id=the-datatransferitem-interface:drag-data-store-5>drag data
  store</a> with which the <code id=the-datatransferitem-interface:datatransferitem-10><a href=#datatransferitem>DataTransferItem</a></code> object's <code id=the-datatransferitem-interface:datatransfer-4><a href=#datatransfer>DataTransfer</a></code>
  object is associated.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransferItem/kind title="The read-only DataTransferItem.kind property returns a DataTransferItem representing the drag data item kind: some text or some file.">DataTransferItem/kind</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>50+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>50+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><p>The <dfn id=dom-datatransferitem-kind><code>kind</code></dfn> attribute must return the
  empty string if the <code id=the-datatransferitem-interface:datatransferitem-11><a href=#datatransferitem>DataTransferItem</a></code> object is in the <i>disabled mode</i>; otherwise
  it must return the string given in the cell from the second column of the following table from the
  row whose cell in the first column contains <a href=#the-drag-data-item-kind id=the-datatransferitem-interface:the-drag-data-item-kind-4>the drag data item kind</a> of the item
  represented by the <code id=the-datatransferitem-interface:datatransferitem-12><a href=#datatransferitem>DataTransferItem</a></code> object:</p>

  <table><thead><tr><th> Kind <th> String
   <tbody><tr><td> <i>Text</i> <td> "<code>string</code>"

    <tr><td> <i>File</i> <td> "<code>file</code>"

  </table>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransferItem/type title="The read-only DataTransferItem.type property returns the type (format) of the DataTransferItem object representing the drag data item. The type is a Unicode string generally given by a MIME type, although a MIME type is not required.">DataTransferItem/type</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>50+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>50+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><p>The <dfn id=dom-datatransferitem-type><code>type</code></dfn> attribute must return the
  empty string if the <code id=the-datatransferitem-interface:datatransferitem-13><a href=#datatransferitem>DataTransferItem</a></code> object is in the <i>disabled mode</i>; otherwise
  it must return <a href=#the-drag-data-item-type-string id=the-datatransferitem-interface:the-drag-data-item-type-string-2>the drag data item type string</a> of the item represented by the
  <code id=the-datatransferitem-interface:datatransferitem-14><a href=#datatransferitem>DataTransferItem</a></code> object.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransferItem/getAsString title="The DataTransferItem.getAsString() method invokes the given callback with the drag data item's string data as the argument if the item's kind is a Plain unicode string (i.e. kind is string).">DataTransferItem/getAsString</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>50+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>50+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><p>The <dfn id=dom-datatransferitem-getasstring><code>getAsString(<var>callback</var>)</code></dfn> method must run the following steps:</p>

  <ol><li><p>If the <var>callback</var> is null, return.<li><p>If the <code id=the-datatransferitem-interface:datatransferitem-15><a href=#datatransferitem>DataTransferItem</a></code> object is not in the <i id=the-datatransferitem-interface:concept-dnd-rw><a href=#concept-dnd-rw>read/write mode</a></i> or the <i id=the-datatransferitem-interface:concept-dnd-ro><a href=#concept-dnd-ro>read-only mode</a></i>,
   return. The callback is never invoked.<li><p>If <a href=#the-drag-data-item-kind id=the-datatransferitem-interface:the-drag-data-item-kind-5>the drag data item kind</a> is not <i>text</i>, then return.
   The callback is never invoked.<li><p>Otherwise, <a id=the-datatransferitem-interface:queue-a-task href=webappapis.html#queue-a-task>queue a task</a> to invoke <var>callback</var>, passing the
   actual data of the item represented by the <code id=the-datatransferitem-interface:datatransferitem-16><a href=#datatransferitem>DataTransferItem</a></code> object as the
   argument.</ol>



  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DataTransferItem/getAsFile title="If the item is a file, the DataTransferItem.getAsFile() method returns the drag data item's File object. If the item is not a file, this method returns null.">DataTransferItem/getAsFile</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span>50+</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>50+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><p>The <dfn id=dom-datatransferitem-getasfile><code>getAsFile()</code></dfn>
  method must run the following steps:</p>

  <ol><li><p>If the <code id=the-datatransferitem-interface:datatransferitem-17><a href=#datatransferitem>DataTransferItem</a></code> object is not in the <i id=the-datatransferitem-interface:concept-dnd-rw-2><a href=#concept-dnd-rw>read/write mode</a></i> or the <i id=the-datatransferitem-interface:concept-dnd-ro-2><a href=#concept-dnd-ro>read-only mode</a></i>,
   then return null.<li><p>If <a href=#the-drag-data-item-kind id=the-datatransferitem-interface:the-drag-data-item-kind-6>the drag data item kind</a> is not <i>File</i>, then return null.<li><p>Return a new <code id=the-datatransferitem-interface:file-3><a data-x-internal=file href=https://w3c.github.io/FileAPI/#dfn-file>File</a></code> object representing the actual data of the item represented
   by the <code id=the-datatransferitem-interface:datatransferitem-18><a href=#datatransferitem>DataTransferItem</a></code> object.</p>
  </ol>



  



  <h4 id=the-dragevent-interface><span class=secno>6.8.4</span> The <code id=the-dragevent-interface:dragevent><a href=#dragevent>DragEvent</a></code> interface<a href=#the-dragevent-interface class=self-link></a></h4><aside class="mdn-anno wrapped"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DragEvent/DragEvent title="This constructor is used to create a synthetic DragEvent object.">DragEvent/DragEvent</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.5+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>46+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside>

  <p>The drag-and-drop processing model involves several events. They all use the
  <code id=the-dragevent-interface:dragevent-2><a href=#dragevent>DragEvent</a></code> interface.</p>

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DragEvent title="The DragEvent interface is a DOM event that represents a drag and drop interaction. The user initiates a drag by placing a pointer device (such as a mouse) on the touch surface and then dragging the pointer to a new location (such as another DOM element). Applications are free to interpret a drag and drop interaction in an application-specific way.">DragEvent</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.5+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>3+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><pre><code class='idl'>[<c- g>Exposed</c->=<c- n>Window</c->,
 <c- g>Constructor</c->(<c- b>DOMString</c-> <c- g>type</c->, <c- b>optional</c-> <a href='#drageventinit' id='the-dragevent-interface:drageventinit'><c- n>DragEventInit</c-></a> <c- g>eventInitDict</c-> = {})]
<c- b>interface</c-> <dfn id='dragevent'><c- g>DragEvent</c-></dfn> : <a href='https://w3c.github.io/uievents/#mouseevent' data-x-internal='mouseevent' id='the-dragevent-interface:mouseevent'><c- n>MouseEvent</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a href='#datatransfer' id='the-dragevent-interface:datatransfer'><c- n>DataTransfer</c-></a>? <a href='#dom-dragevent-datatransfer' id='the-dragevent-interface:dom-dragevent-datatransfer'><c- g>dataTransfer</c-></a>;
};

<c- b>dictionary</c-> <dfn id='drageventinit'><c- g>DragEventInit</c-></dfn> : <a href='https://w3c.github.io/uievents/#dictdef-mouseeventinit' data-x-internal='mouseeventinit' id='the-dragevent-interface:mouseeventinit'><c- n>MouseEventInit</c-></a> {
  <a href='#datatransfer' id='the-dragevent-interface:datatransfer-2'><c- n>DataTransfer</c-></a>? <c- g>dataTransfer</c-> = <c- b>null</c->;
};</code></pre>

  <dl class=domintro><dt><var>event</var> . <code id=dom-dragevent-datatransfer-dev><a href=#dom-dragevent-datatransfer>dataTransfer</a></code><dd>
    <p>Returns the <code id=the-dragevent-interface:datatransfer-3><a href=#datatransfer>DataTransfer</a></code> object for the event.</p>
   </dl>

  <p class=note>Although, for consistency with other event interfaces, the <code id=the-dragevent-interface:dragevent-3><a href=#dragevent>DragEvent</a></code>
  interface has a constructor, it is not particularly useful. In particular, there's no way to
  create a useful <code id=the-dragevent-interface:datatransfer-4><a href=#datatransfer>DataTransfer</a></code> object from script, as <code id=the-dragevent-interface:datatransfer-5><a href=#datatransfer>DataTransfer</a></code> objects
  have a processing and security model that is coordinated by the browser during drag-and-drops.</p>

  

  <aside class="mdn-anno wrapped before"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/DragEvent/dataTransfer title="The DragEvent.dataTransfer property holds the drag operation's data (as a DataTransfer object).">DragEvent/dataTransfer</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.5+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>46+</span></span><hr><span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>Yes</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside><p>The <dfn id=dom-dragevent-datatransfer><code>dataTransfer</code></dfn> attribute of the
  <code id=the-dragevent-interface:dragevent-4><a href=#dragevent>DragEvent</a></code> interface must return the value it was initialized to. It represents the
  context information for the event.</p>

  

  

  <p>When a user agent is required to <dfn id=fire-a-dnd-event>fire a DND event</dfn> named <var>e</var> at an element,
  using a particular <a href=#drag-data-store id=the-dragevent-interface:drag-data-store>drag data store</a>, and optionally with a specific <var>related
  target</var>, the user agent must run the following steps:</p>

  <ol><li>Let <var>dataDragStoreWasChanged</var> be false.<li><p>If no specific <var>related target</var> was provided, set <var>related target</var> to
   null.<li><p>Let <var>window</var> be the <a id=the-dragevent-interface:concept-relevant-global href=webappapis.html#concept-relevant-global>relevant global object</a> of the
   <code id=the-dragevent-interface:document><a href=dom.html#document>Document</a></code> object of the specified target element.<li>
    <p>If <var>e</var> is <code id=the-dragevent-interface:event-dnd-dragstart><a href=#event-dnd-dragstart>dragstart</a></code>, then set the
    <a href=#drag-data-store-mode id=the-dragevent-interface:drag-data-store-mode>drag data store mode</a> to the <a href=#concept-dnd-rw id=the-dragevent-interface:concept-dnd-rw>read/write mode</a>
    and set <var>dataDragStoreWasChanged</var> to true.</p>

    <p>If <var>e</var> is <code id=the-dragevent-interface:event-dnd-drop><a href=#event-dnd-drop>drop</a></code>, set the <a href=#drag-data-store-mode id=the-dragevent-interface:drag-data-store-mode-2>drag data store
    mode</a> to the <a href=#concept-dnd-ro id=the-dragevent-interface:concept-dnd-ro>read-only mode</a>.</p>
   <li><p>Let <var>dataTransfer</var> be a newly created <code id=the-dragevent-interface:datatransfer-6><a href=#datatransfer>DataTransfer</a></code> object
   associated with the given <a href=#drag-data-store id=the-dragevent-interface:drag-data-store-2>drag data store</a>.<li><p id=effectAllowed-initialisation>Set the <code id=the-dragevent-interface:dom-datatransfer-effectallowed><a href=#dom-datatransfer-effectallowed>effectAllowed</a></code> attribute to the <a href=#drag-data-store id=the-dragevent-interface:drag-data-store-3>drag data
   store</a>'s <a href=#drag-data-store-allowed-effects-state id=the-dragevent-interface:drag-data-store-allowed-effects-state>drag data store allowed effects state</a>.<li>
    <p id=dropEffect-initialisation>Set the <code id=the-dragevent-interface:dom-datatransfer-dropeffect><a href=#dom-datatransfer-dropeffect>dropEffect</a></code> attribute to "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-none><a href=#dom-datatransfer-dropeffect-none>none</a></code>" if <var>e</var> is <code id=the-dragevent-interface:event-dnd-dragstart-2><a href=#event-dnd-dragstart>dragstart</a></code>, <code id=the-dragevent-interface:event-dnd-drag><a href=#event-dnd-drag>drag</a></code>, <code id=the-dragevent-interface:event-dnd-dragexit><a href=#event-dnd-dragexit>dragexit</a></code>, or <code id=the-dragevent-interface:event-dnd-dragleave><a href=#event-dnd-dragleave>dragleave</a></code>; to the value corresponding to the <a href=#current-drag-operation id=the-dragevent-interface:current-drag-operation>current
    drag operation</a> if <var>e</var> is <code id=the-dragevent-interface:event-dnd-drop-2><a href=#event-dnd-drop>drop</a></code> or
    <code id=the-dragevent-interface:event-dnd-dragend><a href=#event-dnd-dragend>dragend</a></code>; and to a value based on the <code id=the-dragevent-interface:dom-datatransfer-effectallowed-2><a href=#dom-datatransfer-effectallowed>effectAllowed</a></code> attribute's value and the
    drag-and-drop source, as given by the following table, otherwise (i.e. if <var>e</var>
    is <code id=the-dragevent-interface:event-dnd-dragenter><a href=#event-dnd-dragenter>dragenter</a></code> or <code id=the-dragevent-interface:event-dnd-dragover><a href=#event-dnd-dragover>dragover</a></code>):</p>

    <table><thead><tr><th><code id=the-dragevent-interface:dom-datatransfer-effectallowed-3><a href=#dom-datatransfer-effectallowed>effectAllowed</a></code><th><code id=the-dragevent-interface:dom-datatransfer-dropeffect-2><a href=#dom-datatransfer-dropeffect>dropEffect</a></code><tbody><tr><td>"<code id=the-dragevent-interface:dom-datatransfer-effectallowed-none><a href=#dom-datatransfer-effectallowed-none>none</a></code>"<td>"<code id=the-dragevent-interface:dom-datatransfer-dropeffect-none-2><a href=#dom-datatransfer-dropeffect-none>none</a></code>"<tr><td>"<code id=the-dragevent-interface:dom-datatransfer-effectallowed-copy><a href=#dom-datatransfer-effectallowed-copy>copy</a></code>"<td>"<code id=the-dragevent-interface:dom-datatransfer-dropeffect-copy><a href=#dom-datatransfer-dropeffect-copy>copy</a></code>"<tr><td>"<code id=the-dragevent-interface:dom-datatransfer-effectallowed-copylink><a href=#dom-datatransfer-effectallowed-copylink>copyLink</a></code>"<td>"<code id=the-dragevent-interface:dom-datatransfer-dropeffect-copy-2><a href=#dom-datatransfer-dropeffect-copy>copy</a></code>", or, <a href=#concept-platform-dropeffect-override id=the-dragevent-interface:concept-platform-dropeffect-override>if appropriate</a>, "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-link><a href=#dom-datatransfer-dropeffect-link>link</a></code>"<tr><td>"<code id=the-dragevent-interface:dom-datatransfer-effectallowed-copymove><a href=#dom-datatransfer-effectallowed-copymove>copyMove</a></code>"<td>"<code id=the-dragevent-interface:dom-datatransfer-dropeffect-copy-3><a href=#dom-datatransfer-dropeffect-copy>copy</a></code>", or, <a href=#concept-platform-dropeffect-override id=the-dragevent-interface:concept-platform-dropeffect-override-2>if appropriate</a>, "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-move><a href=#dom-datatransfer-dropeffect-move>move</a></code>"<tr><td>"<code id=the-dragevent-interface:dom-datatransfer-effectallowed-all><a href=#dom-datatransfer-effectallowed-all>all</a></code>"<td>"<code id=the-dragevent-interface:dom-datatransfer-dropeffect-copy-4><a href=#dom-datatransfer-dropeffect-copy>copy</a></code>", or, <a href=#concept-platform-dropeffect-override id=the-dragevent-interface:concept-platform-dropeffect-override-3>if appropriate</a>, either "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-link-2><a href=#dom-datatransfer-dropeffect-link>link</a></code>" or "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-move-2><a href=#dom-datatransfer-dropeffect-move>move</a></code>"<tr><td>"<code id=the-dragevent-interface:dom-datatransfer-effectallowed-link><a href=#dom-datatransfer-effectallowed-link>link</a></code>"<td>"<code id=the-dragevent-interface:dom-datatransfer-dropeffect-link-3><a href=#dom-datatransfer-dropeffect-link>link</a></code>"<tr><td>"<code id=the-dragevent-interface:dom-datatransfer-effectallowed-linkmove><a href=#dom-datatransfer-effectallowed-linkmove>linkMove</a></code>"<td>"<code id=the-dragevent-interface:dom-datatransfer-dropeffect-link-4><a href=#dom-datatransfer-dropeffect-link>link</a></code>", or, <a href=#concept-platform-dropeffect-override id=the-dragevent-interface:concept-platform-dropeffect-override-4>if appropriate</a>, "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-move-3><a href=#dom-datatransfer-dropeffect-move>move</a></code>"<tr><td>"<code id=the-dragevent-interface:dom-datatransfer-effectallowed-move><a href=#dom-datatransfer-effectallowed-move>move</a></code>"<td>"<code id=the-dragevent-interface:dom-datatransfer-dropeffect-move-4><a href=#dom-datatransfer-dropeffect-move>move</a></code>"<tr><td>"<code id=the-dragevent-interface:dom-datatransfer-effectallowed-uninitialized><a href=#dom-datatransfer-effectallowed-uninitialized>uninitialized</a></code>" when what is being dragged is a selection from a text control<td>"<code id=the-dragevent-interface:dom-datatransfer-dropeffect-move-5><a href=#dom-datatransfer-dropeffect-move>move</a></code>", or, <a href=#concept-platform-dropeffect-override id=the-dragevent-interface:concept-platform-dropeffect-override-5>if appropriate</a>, either "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-copy-5><a href=#dom-datatransfer-dropeffect-copy>copy</a></code>" or "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-link-5><a href=#dom-datatransfer-dropeffect-link>link</a></code>"<tr><td>"<code id=the-dragevent-interface:dom-datatransfer-effectallowed-uninitialized-2><a href=#dom-datatransfer-effectallowed-uninitialized>uninitialized</a></code>" when what is being dragged is a selection<td>"<code id=the-dragevent-interface:dom-datatransfer-dropeffect-copy-6><a href=#dom-datatransfer-dropeffect-copy>copy</a></code>", or, <a href=#concept-platform-dropeffect-override id=the-dragevent-interface:concept-platform-dropeffect-override-6>if appropriate</a>, either "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-link-6><a href=#dom-datatransfer-dropeffect-link>link</a></code>" or "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-move-6><a href=#dom-datatransfer-dropeffect-move>move</a></code>"<tr><td>"<code id=the-dragevent-interface:dom-datatransfer-effectallowed-uninitialized-3><a href=#dom-datatransfer-effectallowed-uninitialized>uninitialized</a></code>" when what is being dragged is an <code id=the-dragevent-interface:the-a-element><a href=text-level-semantics.html#the-a-element>a</a></code> element with an <code id=the-dragevent-interface:attr-hyperlink-href><a href=links.html#attr-hyperlink-href>href</a></code> attribute<td>"<code id=the-dragevent-interface:dom-datatransfer-dropeffect-link-7><a href=#dom-datatransfer-dropeffect-link>link</a></code>", or, <a href=#concept-platform-dropeffect-override id=the-dragevent-interface:concept-platform-dropeffect-override-7>if appropriate</a>, either "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-copy-7><a href=#dom-datatransfer-dropeffect-copy>copy</a></code>" or "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-move-7><a href=#dom-datatransfer-dropeffect-move>move</a></code>"<tr><td>Any other case<td>"<code id=the-dragevent-interface:dom-datatransfer-dropeffect-copy-8><a href=#dom-datatransfer-dropeffect-copy>copy</a></code>", or, <a href=#concept-platform-dropeffect-override id=the-dragevent-interface:concept-platform-dropeffect-override-8>if appropriate</a>, either "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-link-8><a href=#dom-datatransfer-dropeffect-link>link</a></code>" or "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-move-8><a href=#dom-datatransfer-dropeffect-move>move</a></code>"</table>

    <p>Where the table above provides <dfn id=concept-platform-dropeffect-override>possibly
    appropriate alternatives</dfn>, user agents may instead use the listed alternative values if
    platform conventions dictate that the user has requested those alternate effects.</p>

    <p class=example>For example, Windows platform conventions are such that dragging while
    holding the "alt" key indicates a preference for linking the data, rather than moving or copying
    it. Therefore, on a Windows system, if "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-link-9><a href=#dom-datatransfer-dropeffect-link>link</a></code>" is an option according to
    the table above while the "alt" key is depressed, the user agent could select that instead of
    "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-copy-9><a href=#dom-datatransfer-dropeffect-copy>copy</a></code>" or "<code id=the-dragevent-interface:dom-datatransfer-dropeffect-move-9><a href=#dom-datatransfer-dropeffect-move>move</a></code>".</p>
   <li><p>Let <var>event</var> be the result of <a id=the-dragevent-interface:creating-an-event href=https://dom.spec.whatwg.org/#concept-event-create data-x-internal=creating-an-event>creating an event</a> using
   <code id=the-dragevent-interface:dragevent-5><a href=#dragevent>DragEvent</a></code>.<li><p>Initialize <var>event</var>'s <code id=the-dragevent-interface:dom-event-type><a data-x-internal=dom-event-type href=https://dom.spec.whatwg.org/#dom-event-type>type</a></code> attribute to
   <var>e</var>, its <code id=the-dragevent-interface:dom-event-bubbles><a data-x-internal=dom-event-bubbles href=https://dom.spec.whatwg.org/#dom-event-bubbles>bubbles</a></code> attribute to true, its <code id=the-dragevent-interface:dom-uievent-view><a data-x-internal=dom-uievent-view href=https://w3c.github.io/uievents/#dom-uievent-view>view</a></code> attribute to <var>window</var>, its <code id=the-dragevent-interface:dom-mouseevent-relatedtarget><a data-x-internal=dom-mouseevent-relatedtarget href=https://w3c.github.io/uievents/#dom-mouseevent-relatedtarget>relatedTarget</a></code> attribute to <var>related
   target</var>, and its <code id=the-dragevent-interface:dom-dragevent-datatransfer-2><a href=#dom-dragevent-datatransfer>dataTransfer</a></code> attribute to
   <var>dataTransfer</var>.<li><p>If <var>e</var> is not <code id=the-dragevent-interface:event-dnd-dragexit-2><a href=#event-dnd-dragexit>dragexit</a></code>, <code id=the-dragevent-interface:event-dnd-dragleave-2><a href=#event-dnd-dragleave>dragleave</a></code>, or <code id=the-dragevent-interface:event-dnd-dragend-2><a href=#event-dnd-dragend>dragend</a></code>, then initialize <var>event</var>'s <code id=the-dragevent-interface:dom-event-cancelable><a data-x-internal=dom-event-cancelable href=https://dom.spec.whatwg.org/#dom-event-cancelable>cancelable</a></code> attribute to true.<li>
    <p>Initialize <var>event</var>'s mouse and key attributes initialized according to the state of
    the input devices as they would be for user interaction events.</p>

    

    <p>If there is no relevant pointing device, then initialize <var>event</var>'s <code>screenX</code>, <code>screenY</code>, <code>clientX</code>, <code>clientY</code>, and <code>button</code> attributes to 0.</p>
   <li><p><a href=https://dom.spec.whatwg.org/#concept-event-dispatch id=the-dragevent-interface:concept-event-dispatch data-x-internal=concept-event-dispatch>Dispatch</a> <var>event</var> at the specified
   target element.<li><p>Set the <a href=#drag-data-store-allowed-effects-state id=the-dragevent-interface:drag-data-store-allowed-effects-state-2>drag data store allowed effects state</a> to the current value of
   <var>dataTransfer</var>'s <code id=the-dragevent-interface:dom-datatransfer-effectallowed-4><a href=#dom-datatransfer-effectallowed>effectAllowed</a></code>
   attribute. (It can only have changed value if <var>e</var> is <code id=the-dragevent-interface:event-dnd-dragstart-3><a href=#event-dnd-dragstart>dragstart</a></code>.)<li><p>If <var>dataDragStoreWasChanged</var> is true, then set the <a href=#drag-data-store-mode id=the-dragevent-interface:drag-data-store-mode-3>drag data store
   mode</a> back to the <a href=#concept-dnd-p id=the-dragevent-interface:concept-dnd-p>protected mode</a>.<li><p>Break the association between <var>dataTransfer</var> and the <a href=#drag-data-store id=the-dragevent-interface:drag-data-store-4>drag data
   store</a>.</ol>

  


  

  <h4 id=drag-and-drop-processing-model><span class=secno>6.8.5</span> Processing model<a href=#drag-and-drop-processing-model class=self-link></a></h4>

  <p>When the user attempts to begin a drag operation, the user agent must run the following steps.
  User agents must act as if these steps were run even if the drag actually started in another
  document or application and the user agent was not aware that the drag was occurring until it
  intersected with a document under the user agent's purview.</p>

  <ol><li>
    <p>Determine what is being dragged, as follows:</p>

    <p>If the drag operation was invoked on a selection, then it is the selection that is being
    dragged.</p>

    <p>Otherwise, if the drag operation was invoked on a <code id=drag-and-drop-processing-model:document><a href=dom.html#document>Document</a></code>, it is the first
    element, going up the ancestor chain, starting at the node that the user tried to drag, that has
    the IDL attribute <code id=drag-and-drop-processing-model:dom-draggable><a href=#dom-draggable>draggable</a></code> set to true. If there is no such
    element, then nothing is being dragged; return, the drag-and-drop operation is never
    started.</p>

    <p>Otherwise, the drag operation was invoked outside the user agent's purview. What is being
    dragged is defined by the document or application where the drag was started.</p>

    <p class=note><code id=drag-and-drop-processing-model:the-img-element><a href=embedded-content.html#the-img-element>img</a></code> elements and <code id=drag-and-drop-processing-model:the-a-element><a href=text-level-semantics.html#the-a-element>a</a></code> elements with an <code id=drag-and-drop-processing-model:attr-hyperlink-href><a href=links.html#attr-hyperlink-href>href</a></code> attribute have their <code id=drag-and-drop-processing-model:dom-draggable-2><a href=#dom-draggable>draggable</a></code> attribute set to true by default.</p>
   <li><p><a href=#create-a-drag-data-store id=drag-and-drop-processing-model:create-a-drag-data-store>Create a drag data store</a>. All the DND events fired subsequently by the steps
   in this section must use this <a href=#drag-data-store id=drag-and-drop-processing-model:drag-data-store>drag data store</a>.<li>
    <p>Establish which DOM node is the <dfn id=source-node>source node</dfn>, as follows:</p>

    <p>If it is a selection that is being dragged, then the <a href=#source-node id=drag-and-drop-processing-model:source-node>source node</a> is the
    <code id=drag-and-drop-processing-model:text><a data-x-internal=text href=https://dom.spec.whatwg.org/#interface-text>Text</a></code> node that the user started the drag on (typically the <code id=drag-and-drop-processing-model:text-2><a data-x-internal=text href=https://dom.spec.whatwg.org/#interface-text>Text</a></code> node
    that the user originally clicked). If the user did not specify a particular node, for example if
    the user just told the user agent to begin a drag of "the selection", then the <a href=#source-node id=drag-and-drop-processing-model:source-node-2>source
    node</a> is the first <code id=drag-and-drop-processing-model:text-3><a data-x-internal=text href=https://dom.spec.whatwg.org/#interface-text>Text</a></code> node containing a part of the selection.</p>

    <p>Otherwise, if it is an element that is being dragged, then the <a href=#source-node id=drag-and-drop-processing-model:source-node-3>source node</a> is
    the element that is being dragged.</p>

    <p>Otherwise, the <a href=#source-node id=drag-and-drop-processing-model:source-node-4>source node</a> is part of another document or application. When this
    specification requires that an event be dispatched at the <a href=#source-node id=drag-and-drop-processing-model:source-node-5>source node</a> in this case,
    the user agent must instead follow the platform-specific conventions relevant to that
    situation.</p>

    <p class=note>Multiple events are fired on the <a href=#source-node id=drag-and-drop-processing-model:source-node-6>source node</a> during the course of
    the drag-and-drop operation.</p>
   <li>
    <p>Determine the <dfn id=list-of-dragged-nodes>list of dragged nodes</dfn>, as follows:</p>

    <p>If it is a selection that is being dragged, then the <a href=#list-of-dragged-nodes id=drag-and-drop-processing-model:list-of-dragged-nodes>list of dragged nodes</a>
    contains, in <a id=drag-and-drop-processing-model:tree-order href=https://dom.spec.whatwg.org/#concept-tree-order data-x-internal=tree-order>tree order</a>, every node that is partially or completely included in the
    selection (including all their ancestors).</p>

    <p>Otherwise, the <a href=#list-of-dragged-nodes id=drag-and-drop-processing-model:list-of-dragged-nodes-2>list of dragged nodes</a> contains only the <a href=#source-node id=drag-and-drop-processing-model:source-node-7>source node</a>,
    if any.</p>
   <li>
    <p>If it is a selection that is being dragged, then add an item to the <a href=#drag-data-store-item-list id=drag-and-drop-processing-model:drag-data-store-item-list>drag data store
    item list</a>, with its properties set as follows:</p>

    <dl><dt><a href=#the-drag-data-item-type-string id=drag-and-drop-processing-model:the-drag-data-item-type-string>The drag data item type string</a>
     <dd>"<code id=drag-and-drop-processing-model:text/plain><a data-x-internal=text/plain href=https://tools.ietf.org/html/rfc2046#section-4.1.3>text/plain</a></code>"<dt><a href=#the-drag-data-item-kind id=drag-and-drop-processing-model:the-drag-data-item-kind>The drag data item kind</a>
     <dd><i>Text</i><dt>The actual data<dd>The text of the selection</dl>

    <p>Otherwise, if any files are being dragged, then add one item per file to the <a href=#drag-data-store-item-list id=drag-and-drop-processing-model:drag-data-store-item-list-2>drag data
    store item list</a>, with their properties set as follows:</p>

    <dl><dt><a href=#the-drag-data-item-type-string id=drag-and-drop-processing-model:the-drag-data-item-type-string-2>The drag data item type string</a>
     <dd>The MIME type of the file, if known, or "<code id=drag-and-drop-processing-model:application/octet-stream><a data-x-internal=application/octet-stream href=https://tools.ietf.org/html/rfc2046#section-4.5.1>application/octet-stream</a></code>" otherwise.<dt><a href=#the-drag-data-item-kind id=drag-and-drop-processing-model:the-drag-data-item-kind-2>The drag data item kind</a>
     <dd><i>File</i><dt>The actual data<dd>The file's contents and name.</dl>

    <p class=note>Dragging files can currently only happen from outside a <a id=drag-and-drop-processing-model:browsing-context href=browsers.html#browsing-context>browsing
    context</a>, for example from a file system manager application.</p>

    <p>If the drag initiated outside of the application, the user agent must add items to the
    <a href=#drag-data-store-item-list id=drag-and-drop-processing-model:drag-data-store-item-list-3>drag data store item list</a> as appropriate for the data being dragged, honoring
    platform conventions where appropriate; however, if the platform conventions do not use <a href=https://mimesniff.spec.whatwg.org/#mime-type id=drag-and-drop-processing-model:mime-type data-x-internal=mime-type>MIME types</a> to label dragged data, the user agent must make a
    best-effort attempt to map the types to MIME types, and, in any case, all the <a href=#the-drag-data-item-type-string id=drag-and-drop-processing-model:the-drag-data-item-type-string-3>drag data item type strings</a> must be <a id=drag-and-drop-processing-model:converted-to-ascii-lowercase href=https://infra.spec.whatwg.org/#ascii-lowercase data-x-internal=converted-to-ascii-lowercase>converted to ASCII
    lowercase</a>.</p>

    <p>User agents may also add one or more items representing the selection or dragged element(s)
    in other forms, e.g. as HTML.</p>
   <li>
    <p>If the <a href=#list-of-dragged-nodes id=drag-and-drop-processing-model:list-of-dragged-nodes-3>list of dragged nodes</a> is not empty, then <a href=microdata.html#extracting-json id=drag-and-drop-processing-model:extracting-json>extract the microdata from those nodes into a JSON form</a>, and add one item to the
    <a href=#drag-data-store-item-list id=drag-and-drop-processing-model:drag-data-store-item-list-4>drag data store item list</a>, with its properties set as follows:</p>

    <dl><dt><a href=#the-drag-data-item-type-string id=drag-and-drop-processing-model:the-drag-data-item-type-string-4>The drag data item type string</a>
     <dd><code id=drag-and-drop-processing-model:application/microdata+json><a href=iana.html#application/microdata+json>application/microdata+json</a></code><dt><a href=#the-drag-data-item-kind id=drag-and-drop-processing-model:the-drag-data-item-kind-3>The drag data item kind</a>
     <dd><i>Text</i><dt>The actual data<dd>The resulting JSON string.</dl>
   <li>
    <p>Run the following substeps:</p>

    <ol><li><p>Let <var>urls</var> be an empty list of <a href=https://url.spec.whatwg.org/#syntax-url-absolute id=drag-and-drop-processing-model:absolute-url data-x-internal=absolute-url>absolute
     URLs</a>.<li>
      <p>For each <var>node</var> in the <a href=#list-of-dragged-nodes id=drag-and-drop-processing-model:list-of-dragged-nodes-4>list of dragged nodes</a>:</p>

      <dl><dt>If the node is an <code id=drag-and-drop-processing-model:the-a-element-2><a href=text-level-semantics.html#the-a-element>a</a></code> element with an <code id=drag-and-drop-processing-model:attr-hyperlink-href-2><a href=links.html#attr-hyperlink-href>href</a></code> attribute<dd>Add to <var>urls</var> the result of <a href=urls-and-fetching.html#parse-a-url id=drag-and-drop-processing-model:parse-a-url>parsing</a> the
       element's <code id=drag-and-drop-processing-model:attr-hyperlink-href-3><a href=links.html#attr-hyperlink-href>href</a></code> content attribute relative to the
       element's <a id=drag-and-drop-processing-model:node-document href=https://dom.spec.whatwg.org/#concept-node-document data-x-internal=node-document>node document</a>.<dt>If the node is an <code id=drag-and-drop-processing-model:the-img-element-2><a href=embedded-content.html#the-img-element>img</a></code> element with a <code id=drag-and-drop-processing-model:attr-img-src><a href=embedded-content.html#attr-img-src>src</a></code>
       attribute<dd>Add to <var>urls</var> the result of <a href=urls-and-fetching.html#parse-a-url id=drag-and-drop-processing-model:parse-a-url-2>parsing</a> the
       element's <code id=drag-and-drop-processing-model:attr-img-src-2><a href=embedded-content.html#attr-img-src>src</a></code> content attribute relative to the
       element's <a id=drag-and-drop-processing-model:node-document-2 href=https://dom.spec.whatwg.org/#concept-node-document data-x-internal=node-document>node document</a>.</dl>
     <li><p>If <var>urls</var> is still empty, then return.<li><p>Let <var>url string</var> be the result of concatenating the strings in <var>urls</var>,
     in the order they were added, separated by a U+000D CARRIAGE RETURN U+000A LINE FEED character
     pair (CRLF).<li><p>Add one item to the <a href=#drag-data-store-item-list id=drag-and-drop-processing-model:drag-data-store-item-list-5>drag data store item list</a>, with its properties set as
     follows:</p>

      <dl><dt><a href=#the-drag-data-item-type-string id=drag-and-drop-processing-model:the-drag-data-item-type-string-5>The drag data item type string</a>
       <dd><code id=drag-and-drop-processing-model:text/uri-list><a href=indices.html#text/uri-list>text/uri-list</a></code><dt><a href=#the-drag-data-item-kind id=drag-and-drop-processing-model:the-drag-data-item-kind-4>The drag data item kind</a>
       <dd><i>Text</i><dt>The actual data<dd><var>url string</var></dl>
     </ol>
   <li>
    <p>Update the <a href=#drag-data-store-default-feedback id=drag-and-drop-processing-model:drag-data-store-default-feedback>drag data store default feedback</a> as appropriate for the user agent
    (if the user is dragging the selection, then the selection would likely be the basis for this
    feedback; if the user is dragging an element, then that element's rendering would be used; if
    the drag began outside the user agent, then the platform conventions for determining the drag
    feedback should be used).</p>
   <li>
    <p><a href=#fire-a-dnd-event id=drag-and-drop-processing-model:fire-a-dnd-event>Fire a DND event</a> named <code id=drag-and-drop-processing-model:event-dnd-dragstart><a href=#event-dnd-dragstart>dragstart</a></code> at the
    <a href=#source-node id=drag-and-drop-processing-model:source-node-8>source node</a>.</p>

    <p>If the event is canceled, then the drag-and-drop operation should not occur; return.</p>
    

    <p class=note>Since events with no event listeners registered are, almost by definition, never
    canceled, drag-and-drop is always available to the user if the author does not specifically
    prevent it.</p>
   <li>
    <p><a href=#initiate-the-drag-and-drop-operation id=drag-and-drop-processing-model:initiate-the-drag-and-drop-operation>Initiate the drag-and-drop operation</a> in a manner consistent with platform
    conventions, and as described below.</p>

    <p id=base-dnd-feedback>The drag-and-drop feedback must be generated from the first of the
    following sources that is available:</p>

    <ol><li>The <a href=#drag-data-store-bitmap id=drag-and-drop-processing-model:drag-data-store-bitmap>drag data store bitmap</a>, if any. In this case, the <a href=#drag-data-store-hot-spot-coordinate id=drag-and-drop-processing-model:drag-data-store-hot-spot-coordinate>drag data store
     hot spot coordinate</a> should be used as hints for where to put the cursor relative to the
     resulting image. The values are expressed as distances in <a href=https://drafts.csswg.org/css-values/#px id="drag-and-drop-processing-model:'px'" data-x-internal="'px'">CSS pixels</a>
     from the left side and from the top side of the image respectively. <a href=references.html#refsCSS>[CSS]</a><li>The <a href=#drag-data-store-default-feedback id=drag-and-drop-processing-model:drag-data-store-default-feedback-2>drag data store default feedback</a>.</ol>
   </ol>

  <p>From the moment that the user agent is to <dfn id=initiate-the-drag-and-drop-operation>initiate the drag-and-drop operation</dfn>,
  until the end of the drag-and-drop operation, device input events (e.g. mouse and keyboard events)
  must be suppressed.</p>

  <p>During the drag operation, the element directly indicated by the user as the drop target is
  called the <dfn id=immediate-user-selection>immediate user selection</dfn>. (Only elements can be selected by the user; other
  nodes must not be made available as drop targets.) However, the <a href=#immediate-user-selection id=drag-and-drop-processing-model:immediate-user-selection>immediate user
  selection</a> is not necessarily the <dfn id=current-target-element>current target element</dfn>, which is the element
  currently selected for the drop part of the drag-and-drop operation.</p>

  <p>The <a href=#immediate-user-selection id=drag-and-drop-processing-model:immediate-user-selection-2>immediate user selection</a> changes as the user selects different elements
  (either by pointing at them with a pointing device, or by selecting them in some other way). The
  <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element>current target element</a> changes when the <a href=#immediate-user-selection id=drag-and-drop-processing-model:immediate-user-selection-3>immediate user selection</a>
  changes, based on the results of event listeners in the document, as described below.</p>

  <p>Both the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-2>current target element</a> and the <a href=#immediate-user-selection id=drag-and-drop-processing-model:immediate-user-selection-4>immediate user selection</a> can
  be null, which means no target element is selected. They can also both be elements in other
  (DOM-based) documents, or other (non-Web) programs altogether. (For example, a user could drag
  text to a word-processor.) The <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-3>current target element</a> is initially null.</p>

  <p>In addition, there is also a <dfn id=current-drag-operation>current drag operation</dfn>, which can take on the values
  "<dfn id=concept-current-drag-operation-none><code>none</code></dfn>", "<dfn id=concept-current-drag-operation-copy><code>copy</code></dfn>", "<dfn id=concept-current-drag-operation-link><code>link</code></dfn>", and "<dfn id=concept-current-drag-operation-move><code>move</code></dfn>". Initially, it has the value
  "<code id=drag-and-drop-processing-model:concept-current-drag-operation-none><a href=#concept-current-drag-operation-none>none</a></code>". It is updated by the user agent
  as described in the steps below.</p>

  <p>User agents must, as soon as the drag operation is <a href=#initiate-the-drag-and-drop-operation id=drag-and-drop-processing-model:initiate-the-drag-and-drop-operation-2>initiated</a> and every 350ms (±200ms) thereafter for as long as the drag
  operation is ongoing, <a id=drag-and-drop-processing-model:queue-a-task href=webappapis.html#queue-a-task>queue a task</a> to perform the following steps in sequence:</p>

  <ol><li>
    <p>If the user agent is still performing the previous iteration of the sequence (if any) when
    the next iteration becomes due, return for this iteration (effectively "skipping
    missed frames" of the drag-and-drop operation).</p>
   <li>
    <p><a href=#fire-a-dnd-event id=drag-and-drop-processing-model:fire-a-dnd-event-2>Fire a DND event</a> named <code id=drag-and-drop-processing-model:event-dnd-drag><a href=#event-dnd-drag>drag</a></code> at the
    <a href=#source-node id=drag-and-drop-processing-model:source-node-9>source node</a>. If this event is canceled, the user agent must set the <a href=#current-drag-operation id=drag-and-drop-processing-model:current-drag-operation>current
    drag operation</a> to "<code id=drag-and-drop-processing-model:concept-current-drag-operation-none-2><a href=#concept-current-drag-operation-none>none</a></code>" (no
    drag operation).</p>
   <li>
    <p>If the <code id=drag-and-drop-processing-model:event-dnd-drag-2><a href=#event-dnd-drag>drag</a></code> event was not canceled and the user has not
    ended the drag-and-drop operation, check the state of the drag-and-drop operation, as
    follows:</p>

    <ol><li>
      <p>If the user is indicating a different <a href=#immediate-user-selection id=drag-and-drop-processing-model:immediate-user-selection-5>immediate user selection</a> than during the
      last iteration (or if this is the first iteration), and if this <a href=#immediate-user-selection id=drag-and-drop-processing-model:immediate-user-selection-6>immediate user
      selection</a> is not the same as the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-4>current target element</a>, then <a href=#fire-a-dnd-event id=drag-and-drop-processing-model:fire-a-dnd-event-3>fire a
      DND event</a> named <code id=drag-and-drop-processing-model:event-dnd-dragexit><a href=#event-dnd-dragexit>dragexit</a></code> at the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-5>current
      target element</a>, and then update the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-6>current target element</a> as follows:</p>

      <dl class=switch><dt>If the new <a href=#immediate-user-selection id=drag-and-drop-processing-model:immediate-user-selection-7>immediate user selection</a> is null<dd><p>Set the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-7>current target element</a> to null also.<dt>If the new <a href=#immediate-user-selection id=drag-and-drop-processing-model:immediate-user-selection-8>immediate user selection</a> is in a non-DOM document or
       application<dd><p>Set the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-8>current target element</a> to the <a href=#immediate-user-selection id=drag-and-drop-processing-model:immediate-user-selection-9>immediate user
       selection</a>.<dt>Otherwise<dd>
        <p><a href=#fire-a-dnd-event id=drag-and-drop-processing-model:fire-a-dnd-event-4>Fire a DND event</a> named <code id=drag-and-drop-processing-model:event-dnd-dragenter><a href=#event-dnd-dragenter>dragenter</a></code>
        at the <a href=#immediate-user-selection id=drag-and-drop-processing-model:immediate-user-selection-10>immediate user selection</a>.</p>

        <p>If the event is canceled, then set the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-9>current target element</a> to the
        <a href=#immediate-user-selection id=drag-and-drop-processing-model:immediate-user-selection-11>immediate user selection</a>.</p>

        <p>Otherwise, run the appropriate step from the following list:</p>

        <dl class=switch><dt>If the <a href=#immediate-user-selection id=drag-and-drop-processing-model:immediate-user-selection-12>immediate user selection</a> is a text control (e.g.,
         <code id=drag-and-drop-processing-model:the-textarea-element><a href=form-elements.html#the-textarea-element>textarea</a></code>, or an <code id=drag-and-drop-processing-model:the-input-element><a href=input.html#the-input-element>input</a></code> element whose <code id=drag-and-drop-processing-model:attr-input-type><a href=input.html#attr-input-type>type</a></code> attribute is in the <a href="input.html#text-(type=text)-state-and-search-state-(type=search)" id="drag-and-drop-processing-model:text-(type=text)-state-and-search-state-(type=search)">Text</a> state) or an <a id=drag-and-drop-processing-model:editing-host href=interaction.html#editing-host>editing host</a> or
         <a id=drag-and-drop-processing-model:editable href=https://w3c.github.io/editing/execCommand.html#editable data-x-internal=editable>editable</a> element, and the <a href=#drag-data-store-item-list id=drag-and-drop-processing-model:drag-data-store-item-list-6>drag data store item list</a> has an item
         with <a href=#the-drag-data-item-type-string id=drag-and-drop-processing-model:the-drag-data-item-type-string-6>the drag data item type string</a> "<code id=drag-and-drop-processing-model:text/plain-2><a data-x-internal=text/plain href=https://tools.ietf.org/html/rfc2046#section-4.1.3>text/plain</a></code>" and <a href=#the-drag-data-item-kind id=drag-and-drop-processing-model:the-drag-data-item-kind-5>the
         drag data item kind</a> <i>text</i><dd><p>Set the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-10>current target element</a> to the <a href=#immediate-user-selection id=drag-and-drop-processing-model:immediate-user-selection-13>immediate user
         selection</a> anyway.<dt>If the <a href=#immediate-user-selection id=drag-and-drop-processing-model:immediate-user-selection-14>immediate user selection</a> is <a id=drag-and-drop-processing-model:the-body-element-2 href=dom.html#the-body-element-2>the body element</a><dd><p>Leave the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-11>current target element</a> unchanged.<dt>Otherwise<dd>
          <p><a href=#fire-a-dnd-event id=drag-and-drop-processing-model:fire-a-dnd-event-5>Fire a DND event</a> named <code id=drag-and-drop-processing-model:event-dnd-dragenter-2><a href=#event-dnd-dragenter>dragenter</a></code>
          at <a id=drag-and-drop-processing-model:the-body-element-2-2 href=dom.html#the-body-element-2>the body element</a>, if there is one, or at the <code id=drag-and-drop-processing-model:document-2><a href=dom.html#document>Document</a></code> object,
          if not. Then, set the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-12>current target element</a> to <a id=drag-and-drop-processing-model:the-body-element-2-3 href=dom.html#the-body-element-2>the body
          element</a>, regardless of whether that event was canceled or not.</p>
         </dl>
       </dl>
     <li>
      <p>If the previous step caused the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-13>current target element</a> to change, and if the
      previous target element was not null or a part of a non-DOM document, then <a href=#fire-a-dnd-event id=drag-and-drop-processing-model:fire-a-dnd-event-6>fire a DND
      event</a> named <code id=drag-and-drop-processing-model:event-dnd-dragleave><a href=#event-dnd-dragleave>dragleave</a></code> at the previous target
      element, with the new <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-14>current target element</a> as the specific <var>related
      target</var>.</p>
     <li>
      <p>If the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-15>current target element</a> is a DOM element, then <a href=#fire-a-dnd-event id=drag-and-drop-processing-model:fire-a-dnd-event-7>fire a DND
      event</a> named <code id=drag-and-drop-processing-model:event-dnd-dragover><a href=#event-dnd-dragover>dragover</a></code> at this <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-16>current
      target element</a>.</p>

      <p>If the <code id=drag-and-drop-processing-model:event-dnd-dragover-2><a href=#event-dnd-dragover>dragover</a></code> event is not canceled, run the
      appropriate step from the following list:</p>

      <dl class=switch><dt>If the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-17>current target element</a> is a text control (e.g.,
       <code id=drag-and-drop-processing-model:the-textarea-element-2><a href=form-elements.html#the-textarea-element>textarea</a></code>, or an <code id=drag-and-drop-processing-model:the-input-element-2><a href=input.html#the-input-element>input</a></code> element whose <code id=drag-and-drop-processing-model:attr-input-type-2><a href=input.html#attr-input-type>type</a></code> attribute is in the <a href="input.html#text-(type=text)-state-and-search-state-(type=search)" id="drag-and-drop-processing-model:text-(type=text)-state-and-search-state-(type=search)-2">Text</a> state) or an <a id=drag-and-drop-processing-model:editing-host-2 href=interaction.html#editing-host>editing host</a> or
       <a id=drag-and-drop-processing-model:editable-2 href=https://w3c.github.io/editing/execCommand.html#editable data-x-internal=editable>editable</a> element, and the <a href=#drag-data-store-item-list id=drag-and-drop-processing-model:drag-data-store-item-list-7>drag data store item list</a> has an item
       with <a href=#the-drag-data-item-type-string id=drag-and-drop-processing-model:the-drag-data-item-type-string-7>the drag data item type string</a> "<code id=drag-and-drop-processing-model:text/plain-3><a data-x-internal=text/plain href=https://tools.ietf.org/html/rfc2046#section-4.1.3>text/plain</a></code>" and <a href=#the-drag-data-item-kind id=drag-and-drop-processing-model:the-drag-data-item-kind-6>the drag
       data item kind</a> <i>text</i><dd><p>Set the <a href=#current-drag-operation id=drag-and-drop-processing-model:current-drag-operation-2>current drag operation</a> to either "<code id=drag-and-drop-processing-model:concept-current-drag-operation-copy><a href=#concept-current-drag-operation-copy>copy</a></code>" or "<code id=drag-and-drop-processing-model:concept-current-drag-operation-move><a href=#concept-current-drag-operation-move>move</a></code>", as appropriate given the platform
       conventions.<dt>Otherwise<dd><p>Reset the <a href=#current-drag-operation id=drag-and-drop-processing-model:current-drag-operation-3>current drag operation</a> to "<code id=drag-and-drop-processing-model:concept-current-drag-operation-none-3><a href=#concept-current-drag-operation-none>none</a></code>".</dl>

      <p>Otherwise (if the <code id=drag-and-drop-processing-model:event-dnd-dragover-3><a href=#event-dnd-dragover>dragover</a></code> event <em>is</em>
      canceled), set the <a href=#current-drag-operation id=drag-and-drop-processing-model:current-drag-operation-4>current drag operation</a> based on the values of the <code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed><a href=#dom-datatransfer-effectallowed>effectAllowed</a></code> and <code id=drag-and-drop-processing-model:dom-datatransfer-dropeffect><a href=#dom-datatransfer-dropeffect>dropEffect</a></code> attributes of the
      <code id=drag-and-drop-processing-model:dragevent><a href=#dragevent>DragEvent</a></code> object's <code id=drag-and-drop-processing-model:dom-dragevent-datatransfer><a href=#dom-dragevent-datatransfer>dataTransfer</a></code>
      object as they stood after the event <a href=https://dom.spec.whatwg.org/#concept-event-dispatch id=drag-and-drop-processing-model:concept-event-dispatch data-x-internal=concept-event-dispatch>dispatch</a>
      finished, as per the following table:</p>

      <table><thead><tr><th><code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed-2><a href=#dom-datatransfer-effectallowed>effectAllowed</a></code><th><code id=drag-and-drop-processing-model:dom-datatransfer-dropeffect-2><a href=#dom-datatransfer-dropeffect>dropEffect</a></code><th>Drag operation<tbody><tr><td>"<code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed-uninitialized><a href=#dom-datatransfer-effectallowed-uninitialized>uninitialized</a></code>", "<code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed-copy><a href=#dom-datatransfer-effectallowed-copy>copy</a></code>", "<code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed-copylink><a href=#dom-datatransfer-effectallowed-copylink>copyLink</a></code>", "<code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed-copymove><a href=#dom-datatransfer-effectallowed-copymove>copyMove</a></code>", or "<code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed-all><a href=#dom-datatransfer-effectallowed-all>all</a></code>"<td>"<code id=drag-and-drop-processing-model:dom-datatransfer-dropeffect-copy><a href=#dom-datatransfer-dropeffect-copy>copy</a></code>"<td>"<code id=drag-and-drop-processing-model:concept-current-drag-operation-copy-2><a href=#concept-current-drag-operation-copy>copy</a></code>"<tr><td>"<code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed-uninitialized-2><a href=#dom-datatransfer-effectallowed-uninitialized>uninitialized</a></code>", "<code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed-link><a href=#dom-datatransfer-effectallowed-link>link</a></code>", "<code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed-copylink-2><a href=#dom-datatransfer-effectallowed-copylink>copyLink</a></code>", "<code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed-linkmove><a href=#dom-datatransfer-effectallowed-linkmove>linkMove</a></code>", or "<code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed-all-2><a href=#dom-datatransfer-effectallowed-all>all</a></code>"<td>"<code id=drag-and-drop-processing-model:dom-datatransfer-dropeffect-link><a href=#dom-datatransfer-dropeffect-link>link</a></code>"<td>"<code id=drag-and-drop-processing-model:concept-current-drag-operation-link><a href=#concept-current-drag-operation-link>link</a></code>"<tr><td>"<code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed-uninitialized-3><a href=#dom-datatransfer-effectallowed-uninitialized>uninitialized</a></code>", "<code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed-move><a href=#dom-datatransfer-effectallowed-move>move</a></code>", "<code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed-copymove-2><a href=#dom-datatransfer-effectallowed-copymove>copyMove</a></code>", "<code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed-linkmove-2><a href=#dom-datatransfer-effectallowed-linkmove>linkMove</a></code>", or "<code id=drag-and-drop-processing-model:dom-datatransfer-effectallowed-all-3><a href=#dom-datatransfer-effectallowed-all>all</a></code>"<td>"<code id=drag-and-drop-processing-model:dom-datatransfer-dropeffect-move><a href=#dom-datatransfer-dropeffect-move>move</a></code>"<td>"<code id=drag-and-drop-processing-model:concept-current-drag-operation-move-2><a href=#concept-current-drag-operation-move>move</a></code>"<tr><td colspan=2>Any other case<td>"<code id=drag-and-drop-processing-model:concept-current-drag-operation-none-4><a href=#concept-current-drag-operation-none>none</a></code>"</table>
     <li>
      <p>Otherwise, if the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-18>current target element</a> is not a DOM element, use
      platform-specific mechanisms to determine what drag operation is being performed (none, copy,
      link, or move), and set the <a href=#current-drag-operation id=drag-and-drop-processing-model:current-drag-operation-5>current drag operation</a> accordingly.</p>
     <li>
      <p>Update the drag feedback (e.g. the mouse cursor) to match the <a href=#current-drag-operation id=drag-and-drop-processing-model:current-drag-operation-6>current drag
      operation</a>, as follows:</p>

      <table><thead><tr><th>Drag operation<th>Feedback<tbody><tr><td>"<code id=drag-and-drop-processing-model:concept-current-drag-operation-copy-3><a href=#concept-current-drag-operation-copy>copy</a></code>"<td>Data will be copied if dropped here.<tr><td>"<code id=drag-and-drop-processing-model:concept-current-drag-operation-link-2><a href=#concept-current-drag-operation-link>link</a></code>"<td>Data will be linked if dropped here.<tr><td>"<code id=drag-and-drop-processing-model:concept-current-drag-operation-move-3><a href=#concept-current-drag-operation-move>move</a></code>"<td>Data will be moved if dropped here.<tr><td>"<code id=drag-and-drop-processing-model:concept-current-drag-operation-none-5><a href=#concept-current-drag-operation-none>none</a></code>"<td>No operation allowed, dropping here will cancel the drag-and-drop operation.</table>
     </ol>
   <li>
    <p>Otherwise, if the user ended the drag-and-drop operation (e.g. by releasing the mouse button
    in a mouse-driven drag-and-drop interface), or if the <code id=drag-and-drop-processing-model:event-dnd-drag-3><a href=#event-dnd-drag>drag</a></code>
    event was canceled, then this will be the last iteration. Run the following steps, then stop the
    drag-and-drop operation:</p>

    <ol><li>
      <p>If the <a href=#current-drag-operation id=drag-and-drop-processing-model:current-drag-operation-7>current drag operation</a> is "<code id=drag-and-drop-processing-model:concept-current-drag-operation-none-6><a href=#concept-current-drag-operation-none>none</a></code>" (no drag operation), or, if the user
      ended the drag-and-drop operation by canceling it (e.g. by hitting the <kbd><kbd>Escape</kbd></kbd> key),
      or if the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-19>current target element</a> is null, then the drag operation failed. Run
      these substeps:</p>

      <ol><li><p>Let <var>dropped</var> be false.<li><p>If the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-20>current target element</a> is a DOM element, <a href=#fire-a-dnd-event id=drag-and-drop-processing-model:fire-a-dnd-event-8>fire a DND
       event</a> named <code id=drag-and-drop-processing-model:event-dnd-dragleave-2><a href=#event-dnd-dragleave>dragleave</a></code> at it; otherwise, if
       it is not null, use platform-specific conventions for drag cancelation.<li><p>Set the <a href=#current-drag-operation id=drag-and-drop-processing-model:current-drag-operation-8>current drag operation</a> to "<code id=drag-and-drop-processing-model:concept-current-drag-operation-none-7><a href=#concept-current-drag-operation-none>none</a></code>".</ol>

      <p>Otherwise, the drag operation might be a success; run these substeps:</p>

      <ol><li><p>Let <var>dropped</var> be true.<li><p>If the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-21>current target element</a> is a DOM element, <a href=#fire-a-dnd-event id=drag-and-drop-processing-model:fire-a-dnd-event-9>fire a DND
       event</a> named <code id=drag-and-drop-processing-model:event-dnd-drop><a href=#event-dnd-drop>drop</a></code> at it; otherwise, use
       platform-specific conventions for indicating a drop.<li>
        <p>If the event is canceled, set the <a href=#current-drag-operation id=drag-and-drop-processing-model:current-drag-operation-9>current drag operation</a> to the value of the
        <code id=drag-and-drop-processing-model:dom-datatransfer-dropeffect-3><a href=#dom-datatransfer-dropeffect>dropEffect</a></code> attribute of the
        <code id=drag-and-drop-processing-model:dragevent-2><a href=#dragevent>DragEvent</a></code> object's <code id=drag-and-drop-processing-model:dom-dragevent-datatransfer-2><a href=#dom-dragevent-datatransfer>dataTransfer</a></code>
        object as it stood after the event <a href=https://dom.spec.whatwg.org/#concept-event-dispatch id=drag-and-drop-processing-model:concept-event-dispatch-2 data-x-internal=concept-event-dispatch>dispatch</a>
        finished.</p>

        <p>Otherwise, the event is not canceled; perform the event's default action, which depends
        on the exact target as follows:</p>

        <dl class=switch><dt>If the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-22>current target element</a> is a text control (e.g.,
         <code id=drag-and-drop-processing-model:the-textarea-element-3><a href=form-elements.html#the-textarea-element>textarea</a></code>, or an <code id=drag-and-drop-processing-model:the-input-element-3><a href=input.html#the-input-element>input</a></code> element whose <code id=drag-and-drop-processing-model:attr-input-type-3><a href=input.html#attr-input-type>type</a></code> attribute is in the <a href="input.html#text-(type=text)-state-and-search-state-(type=search)" id="drag-and-drop-processing-model:text-(type=text)-state-and-search-state-(type=search)-3">Text</a> state) or an <a id=drag-and-drop-processing-model:editing-host-3 href=interaction.html#editing-host>editing host</a> or
         <a id=drag-and-drop-processing-model:editable-3 href=https://w3c.github.io/editing/execCommand.html#editable data-x-internal=editable>editable</a> element, and the <a href=#drag-data-store-item-list id=drag-and-drop-processing-model:drag-data-store-item-list-8>drag data store item list</a> has an item
         with <a href=#the-drag-data-item-type-string id=drag-and-drop-processing-model:the-drag-data-item-type-string-8>the drag data item type string</a> "<code id=drag-and-drop-processing-model:text/plain-4><a data-x-internal=text/plain href=https://tools.ietf.org/html/rfc2046#section-4.1.3>text/plain</a></code>" and <a href=#the-drag-data-item-kind id=drag-and-drop-processing-model:the-drag-data-item-kind-7>the
         drag data item kind</a> <i>text</i><dd><p>Insert the actual data of the first item in the <a href=#drag-data-store-item-list id=drag-and-drop-processing-model:drag-data-store-item-list-9>drag data store item
         list</a> to have <a href=#the-drag-data-item-type-string id=drag-and-drop-processing-model:the-drag-data-item-type-string-9>a drag data item type
         string</a> of "<code id=drag-and-drop-processing-model:text/plain-5><a data-x-internal=text/plain href=https://tools.ietf.org/html/rfc2046#section-4.1.3>text/plain</a></code>" and <a href=#the-drag-data-item-kind id=drag-and-drop-processing-model:the-drag-data-item-kind-8>a drag
         data item kind</a> that is <i>text</i> into the text control or
         <a id=drag-and-drop-processing-model:editing-host-4 href=interaction.html#editing-host>editing host</a> or <a id=drag-and-drop-processing-model:editable-4 href=https://w3c.github.io/editing/execCommand.html#editable data-x-internal=editable>editable</a> element in a manner consistent with
         platform-specific conventions (e.g. inserting it at the current mouse cursor position, or
         inserting it at the end of the field).<dt>Otherwise<dd><p>Reset the <a href=#current-drag-operation id=drag-and-drop-processing-model:current-drag-operation-10>current drag operation</a> to "<code id=drag-and-drop-processing-model:concept-current-drag-operation-none-8><a href=#concept-current-drag-operation-none>none</a></code>".</dl>
       </ol>
     <li>
      <p><a href=#fire-a-dnd-event id=drag-and-drop-processing-model:fire-a-dnd-event-10>Fire a DND event</a> named <code id=drag-and-drop-processing-model:event-dnd-dragend><a href=#event-dnd-dragend>dragend</a></code> at the
      <a href=#source-node id=drag-and-drop-processing-model:source-node-10>source node</a>.</p>
     <li>
      <p>Run the appropriate steps from the following list as the default action of the <code id=drag-and-drop-processing-model:event-dnd-dragend-2><a href=#event-dnd-dragend>dragend</a></code> event:</p>

      <dl class=switch><dt>If <var>dropped</var> is true, the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-23>current target element</a> is a <i>text
       control</i> (see below), the <a href=#current-drag-operation id=drag-and-drop-processing-model:current-drag-operation-11>current drag operation</a> is "<code id=drag-and-drop-processing-model:concept-current-drag-operation-move-4><a href=#concept-current-drag-operation-move>move</a></code>", and the source of the
       drag-and-drop operation is a selection in the DOM that is entirely contained within an
       <a id=drag-and-drop-processing-model:editing-host-5 href=interaction.html#editing-host>editing host</a><dd><p><a id=drag-and-drop-processing-model:delete-the-selection href=https://w3c.github.io/editing/execCommand.html#delete-the-selection data-x-internal=delete-the-selection>Delete the selection</a>.<dt>If <var>dropped</var> is true, the <a href=#current-target-element id=drag-and-drop-processing-model:current-target-element-24>current target element</a> is a <i>text
       control</i> (see below), the <a href=#current-drag-operation id=drag-and-drop-processing-model:current-drag-operation-12>current drag operation</a> is "<code id=drag-and-drop-processing-model:concept-current-drag-operation-move-5><a href=#concept-current-drag-operation-move>move</a></code>", and the source of the
       drag-and-drop operation is a selection in a text control<dd><p>The user agent should delete the dragged selection from the relevant text
       control.<dt>If <var>dropped</var> is false or if the <a href=#current-drag-operation id=drag-and-drop-processing-model:current-drag-operation-13>current drag operation</a> is "<code id=drag-and-drop-processing-model:concept-current-drag-operation-none-9><a href=#concept-current-drag-operation-none>none</a></code>"<dd><p>The drag was canceled. If the platform conventions dictate that this be represented to
       the user (e.g. by animating the dragged selection going back to the source of the
       drag-and-drop operation), then do so.<dt>Otherwise<dd><p>The event has no default action.</dl>

      <p>For the purposes of this step, a <i>text control</i> is a <code id=drag-and-drop-processing-model:the-textarea-element-4><a href=form-elements.html#the-textarea-element>textarea</a></code> element or
      an <code id=drag-and-drop-processing-model:the-input-element-4><a href=input.html#the-input-element>input</a></code> element whose <code id=drag-and-drop-processing-model:attr-input-type-4><a href=input.html#attr-input-type>type</a></code> attribute is in
      one of the
      <a href="input.html#text-(type=text)-state-and-search-state-(type=search)" id="drag-and-drop-processing-model:text-(type=text)-state-and-search-state-(type=search)-4">Text</a>,
      <a href="input.html#text-(type=text)-state-and-search-state-(type=search)" id="drag-and-drop-processing-model:text-(type=text)-state-and-search-state-(type=search)-5">Search</a>,
      <a href="input.html#telephone-state-(type=tel)" id="drag-and-drop-processing-model:telephone-state-(type=tel)">Tel</a>,
      <a href="input.html#url-state-(type=url)" id="drag-and-drop-processing-model:url-state-(type=url)">URL</a>,
      <a href="input.html#e-mail-state-(type=email)" id="drag-and-drop-processing-model:e-mail-state-(type=email)">E-mail</a>,
      <a href="input.html#password-state-(type=password)" id="drag-and-drop-processing-model:password-state-(type=password)">Password</a>, or
      <a href="input.html#number-state-(type=number)" id="drag-and-drop-processing-model:number-state-(type=number)">Number</a>
      states.</p>
     </ol>
   </ol>

  <p class=note>User agents are encouraged to consider how to react to drags near the edge of
  scrollable regions. For example, if a user drags a link to the bottom of the <a id=drag-and-drop-processing-model:viewport href=https://drafts.csswg.org/css2/visuren.html#viewport data-x-internal=viewport>viewport</a>
  on a long page, it might make sense to scroll the page so that the user can drop the link lower on
  the page.</p>

  <p class=note>This model is independent of which <code id=drag-and-drop-processing-model:document-3><a href=dom.html#document>Document</a></code> object the nodes involved
  are from; the events are fired as described above and the rest of the processing model runs as
  described above, irrespective of how many documents are involved in the operation.</p>

  


  <h4 id=dndevents><span class=secno>6.8.6</span> Events summary<a href=#dndevents class=self-link></a></h4><aside class="mdn-anno wrapped"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="" class=""></b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Document/drag_event title="The drag event is fired every few hundred milliseconds as an element or text selection is being dragged by the user.">Document/drag_event</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span title="Partial implementation.">🔰 3.5+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>11+</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Document/dragend_event title="The dragend event is fired when a drag operation is being ended (by releasing a mouse button or hitting the escape key).">Document/dragend_event</a><p class=""><div class=support><span class="firefox yes"><span>Firefox</span><span title="Partial implementation.">🔰 3.5+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>11+</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Document/dragenter_event title="The dragenter event is fired when a dragged element or text selection enters a valid drop target.">Document/dragenter_event</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.5+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>11+</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Document/dragexit_event title="The dragexit event is fired when an element is no longer the drag operation's immediate selection target.">Document/dragexit_event</a><p class=less-than-two-engines-text>No support in current engines.<div class=support><span class="firefox no"><span>Firefox</span><span>No</span></span><span class="safari no"><span>Safari</span><span>No</span></span><span class="chrome no"><span>Chrome</span><span>No</span></span><hr><span class="opera no"><span>Opera</span><span>No</span></span><span class="edge_blink no"><span>Edge</span><span>No</span></span><hr><span class="edge no"><span>Edge (Legacy)</span><span>No</span></span><span class="ie no"><span>Internet Explorer</span><span>No</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios no"><span>Safari iOS</span><span>No</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Document/dragleave_event title="The dragleave event is fired when a dragged element or text selection leaves a valid drop target.">Document/dragleave_event</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.5+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>11+</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Document/dragover_event title="The dragover event is fired when an element or text selection is being dragged over a valid drop target (every few hundred milliseconds).">Document/dragover_event</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.5+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>11+</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Document/dragstart_event title="The dragstart event is fired when the user starts dragging an element or text selection.">Document/dragstart_event</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.5+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>11+</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/API/Document/drop_event title="The drop event is fired when an element or text selection is dropped on a valid drop target.">Document/drop_event</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>3.5+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>10+</span></span><hr><span class="firefox_android no"><span>Firefox Android</span><span>No</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>11+</span></span><span class="chrome_android no"><span>Chrome Android</span><span>No</span></span><span class="webview_android no"><span>WebView Android</span><span>No</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>No</span></span><span class="opera_android no"><span>Opera Android</span><span>No</span></span></div></div></aside>

  <p><i>This section is non-normative.</i></p>

  <p>The following events are involved in the drag-and-drop
  model.</p>

  <table><thead><tr><th> Event name <th> Target <th> Cancelable? <th> <a href=#drag-data-store-mode id=dndevents:drag-data-store-mode>Drag data store mode</a> <th> <code id=dndevents:dom-datatransfer-dropeffect><a href=#dom-datatransfer-dropeffect>dropEffect</a></code> <th> Default Action <tbody><tr><td><dfn id=event-dnd-dragstart><code>dragstart</code></dfn><td><a href=#source-node id=dndevents:source-node>Source node</a><td>✓ Cancelable<td><a href=#concept-dnd-rw id=dndevents:concept-dnd-rw>Read/write mode</a>
     <td>"<code id=dndevents:dom-datatransfer-dropeffect-none><a href=#dom-datatransfer-dropeffect-none>none</a></code>"<td>Initiate the drag-and-drop operation<tr><td><dfn id=event-dnd-drag><code>drag</code></dfn><td><a href=#source-node id=dndevents:source-node-2>Source node</a><td>✓ Cancelable<td><a href=#concept-dnd-p id=dndevents:concept-dnd-p>Protected mode</a>
     <td>"<code id=dndevents:dom-datatransfer-dropeffect-none-2><a href=#dom-datatransfer-dropeffect-none>none</a></code>"<td>Continue the drag-and-drop operation<tr><td><dfn id=event-dnd-dragenter><code>dragenter</code></dfn><td><a href=#immediate-user-selection id=dndevents:immediate-user-selection>Immediate user selection</a> or <a id=dndevents:the-body-element-2 href=dom.html#the-body-element-2>the body element</a><td>✓ Cancelable<td><a href=#concept-dnd-p id=dndevents:concept-dnd-p-2>Protected mode</a>
     <td><a href=#dropEffect-initialisation>Based on <code>effectAllowed</code> value</a><td>Reject <a href=#immediate-user-selection id=dndevents:immediate-user-selection-2>immediate user selection</a> as potential <a href=#current-target-element id=dndevents:current-target-element>target element</a><tr><td><dfn id=event-dnd-dragexit><code>dragexit</code></dfn><td><a href=#current-target-element id=dndevents:current-target-element-2>Previous target element</a><td>—<td><a href=#concept-dnd-p id=dndevents:concept-dnd-p-3>Protected mode</a>
     <td>"<code id=dndevents:dom-datatransfer-dropeffect-none-3><a href=#dom-datatransfer-dropeffect-none>none</a></code>"<td>None<tr><td><dfn id=event-dnd-dragleave><code>dragleave</code></dfn><td><a href=#current-target-element id=dndevents:current-target-element-3>Previous target element</a><td>—<td><a href=#concept-dnd-p id=dndevents:concept-dnd-p-4>Protected mode</a>
     <td>"<code id=dndevents:dom-datatransfer-dropeffect-none-4><a href=#dom-datatransfer-dropeffect-none>none</a></code>"<td>None<tr><td><dfn id=event-dnd-dragover><code>dragover</code></dfn><td><a href=#current-target-element id=dndevents:current-target-element-4>Current target element</a><td>✓ Cancelable<td><a href=#concept-dnd-p id=dndevents:concept-dnd-p-5>Protected mode</a>
     <td><a href=#dropEffect-initialisation>Based on <code>effectAllowed</code> value</a><td>Reset the <a href=#current-drag-operation id=dndevents:current-drag-operation>current drag operation</a> to "none"<tr><td><dfn id=event-dnd-drop><code>drop</code></dfn><td><a href=#current-target-element id=dndevents:current-target-element-5>Current target element</a><td>✓ Cancelable<td><a href=#concept-dnd-ro id=dndevents:concept-dnd-ro>Read-only mode</a>
     <td><a href=#current-drag-operation id=dndevents:current-drag-operation-2>Current drag operation</a><td>Varies<tr><td><dfn id=event-dnd-dragend><code>dragend</code></dfn><td><a href=#source-node id=dndevents:source-node-3>Source node</a><td>—<td><a href=#concept-dnd-p id=dndevents:concept-dnd-p-6>Protected mode</a>
     
     <td><a href=#current-drag-operation id=dndevents:current-drag-operation-3>Current drag operation</a><td>Varies</table>

  <p>Not shown in the above table: all these events bubble, are composed, and the <code id=dndevents:dom-datatransfer-effectallowed><a href=#dom-datatransfer-effectallowed>effectAllowed</a></code> attribute always has the value it had
  after the <code id=dndevents:event-dnd-dragstart><a href=#event-dnd-dragstart>dragstart</a></code> event, defaulting to "<code id=dndevents:dom-datatransfer-effectallowed-uninitialized><a href=#dom-datatransfer-effectallowed-uninitialized>uninitialized</a></code>" in the <code id=dndevents:event-dnd-dragstart-2><a href=#event-dnd-dragstart>dragstart</a></code> event.</p>



  <h4 id=the-draggable-attribute><span class=secno>6.8.7</span> The <dfn><code>draggable</code></dfn> attribute<a href=#the-draggable-attribute class=self-link></a></h4><aside class="mdn-anno wrapped"><button onclick=toggleStatus(this) class=mdn-anno-btn><b title="Support in all current engines." class=all-engines-flag>✔</b><span>MDN</span></button><div class=feature><p><a href=https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes/draggable title="The draggable global attribute is an enumerated attribute that indicates whether the element can be dragged, either with native browser behavior or the HTML Drag and Drop API.">Global_attributes/draggable</a><p class=all-engines-text>Support in all current engines.<div class=support><span class="firefox yes"><span>Firefox</span><span>2+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span><hr><span class="opera yes"><span>Opera</span><span>12+</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span><hr><span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>Internet Explorer</span><span>Yes</span></span><hr><span class="firefox_android yes"><span>Firefox Android</span><span>4+</span></span><span class="safari_ios yes"><span>Safari iOS</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome Android</span><span>Yes</span></span><span class="webview_android yes"><span>WebView Android</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Android</span><span>Yes</span></span></div></div></aside>

  <p>All <a id=the-draggable-attribute:html-elements href=infrastructure.html#html-elements>HTML elements</a> may have the <code id=the-draggable-attribute:the-draggable-attribute><a href=#the-draggable-attribute>draggable</a></code>
  content attribute set. The <code id=the-draggable-attribute:the-draggable-attribute-2><a href=#the-draggable-attribute>draggable</a></code> attribute is an
  <a id=the-draggable-attribute:enumerated-attribute href=common-microsyntaxes.html#enumerated-attribute>enumerated attribute</a>. It has three states. The first state is <i>true</i> and it has
  the keyword <code>true</code>. The second state is <i>false</i> and it has the keyword
  <code>false</code>. The third state is <i>auto</i>; it has no keywords but it is the
  <i id=the-draggable-attribute:missing-value-default><a href=common-microsyntaxes.html#missing-value-default>missing value default</a></i> and the <i id=the-draggable-attribute:invalid-value-default><a href=common-microsyntaxes.html#invalid-value-default>invalid value default</a></i>.</p>

  <p>The <i>true</i> state means the element is draggable; the <i>false</i> state means that it is
  not. The <i>auto</i> state uses the default behavior of the user agent.</p>

  <p>An element with a <code id=the-draggable-attribute:the-draggable-attribute-3><a href=#the-draggable-attribute>draggable</a></code> attribute should also have a
  <code id=the-draggable-attribute:attr-title><a href=dom.html#attr-title>title</a></code> attribute that names the element for the purpose of
  non-visual interactions. </p>

  <dl class=domintro><dt><var>element</var> . <code id=dom-draggable-dev><a href=#dom-draggable>draggable</a></code> [ = <var>value</var> ]<dd>
    <p>Returns true if the element is draggable; otherwise, returns false.</p>

    <p>Can be set, to override the default and set the <code id=the-draggable-attribute:the-draggable-attribute-4><a href=#the-draggable-attribute>draggable</a></code>
    content attribute.</p>
   </dl>

  

  <p>The <dfn id=dom-draggable><code>draggable</code></dfn> IDL attribute, whose value depends
  on the content attribute's in the way described below, controls whether or not the element is
  draggable. Generally, only text selections are draggable, but elements whose <code id=the-draggable-attribute:dom-draggable><a href=#dom-draggable>draggable</a></code> IDL attribute is true become draggable as well.</p>

  <p>If an element's <code id=the-draggable-attribute:the-draggable-attribute-5><a href=#the-draggable-attribute>draggable</a></code> content attribute has the state
  <i>true</i>, the <code id=the-draggable-attribute:dom-draggable-2><a href=#dom-draggable>draggable</a></code> IDL attribute must return true.</p>

  <p>Otherwise, if the element's <code id=the-draggable-attribute:the-draggable-attribute-6><a href=#the-draggable-attribute>draggable</a></code> content attribute has
  the state <i>false</i>, the <code id=the-draggable-attribute:dom-draggable-3><a href=#dom-draggable>draggable</a></code> IDL attribute must return
  false.</p>

  <p>Otherwise, the element's <code id=the-draggable-attribute:the-draggable-attribute-7><a href=#the-draggable-attribute>draggable</a></code> content attribute has
  the state <i>auto</i>. If the element is an <code id=the-draggable-attribute:the-img-element><a href=embedded-content.html#the-img-element>img</a></code> element, an <code id=the-draggable-attribute:the-object-element><a href=iframe-embed-object.html#the-object-element>object</a></code>
  element that <a id=the-draggable-attribute:represents href=dom.html#represents>represents</a> an image, or an <code id=the-draggable-attribute:the-a-element><a href=text-level-semantics.html#the-a-element>a</a></code> element with an <code id=the-draggable-attribute:attr-hyperlink-href><a href=links.html#attr-hyperlink-href>href</a></code> content attribute, the <code id=the-draggable-attribute:dom-draggable-4><a href=#dom-draggable>draggable</a></code> IDL attribute must return true; otherwise, the <code id=the-draggable-attribute:dom-draggable-5><a href=#dom-draggable>draggable</a></code> IDL attribute must return false.</p>

  <p>If the <code id=the-draggable-attribute:dom-draggable-6><a href=#dom-draggable>draggable</a></code> IDL attribute is set to the value false,
  the <code id=the-draggable-attribute:the-draggable-attribute-8><a href=#the-draggable-attribute>draggable</a></code> content attribute must be set to the literal
  value "<code>false</code>". If the <code id=the-draggable-attribute:dom-draggable-7><a href=#dom-draggable>draggable</a></code> IDL
  attribute is set to the value true, the <code id=the-draggable-attribute:the-draggable-attribute-9><a href=#the-draggable-attribute>draggable</a></code> content
  attribute must be set to the literal value "<code>true</code>".</p>

  






  

  <h4 id=security-risks-in-the-drag-and-drop-model><span class=secno>6.8.8</span> Security risks in the drag-and-drop model<a href=#security-risks-in-the-drag-and-drop-model class=self-link></a></h4>

  <p>User agents must not make the data added to the <code id=security-risks-in-the-drag-and-drop-model:datatransfer><a href=#datatransfer>DataTransfer</a></code> object during the
  <code id=security-risks-in-the-drag-and-drop-model:event-dnd-dragstart><a href=#event-dnd-dragstart>dragstart</a></code> event available to scripts until the <code id=security-risks-in-the-drag-and-drop-model:event-dnd-drop><a href=#event-dnd-drop>drop</a></code> event, because otherwise, if a user were to drag sensitive
  information from one document to a second document, crossing a hostile third document in the
  process, the hostile document could intercept the data.</p>

  <p>For the same reason, user agents must consider a drop to be successful only if the user
  specifically ended the drag operation — if any scripts end the drag operation, it must be
  considered unsuccessful (canceled) and the <code id=security-risks-in-the-drag-and-drop-model:event-dnd-drop-2><a href=#event-dnd-drop>drop</a></code> event must not be
  fired.</p>

  <p>User agents should take care to not start drag-and-drop operations in response to script
  actions. For example, in a mouse-and-window environment, if a script moves a window while the user
  has their mouse button depressed, the UA would not consider that to start a drag. This is important
  because otherwise UAs could cause data to be dragged from sensitive sources and dropped into
  hostile documents without the user's consent.</p>

  <p>User agents should filter potentially active (scripted) content (e.g. HTML) when it is dragged
  and when it is dropped, using a safelist of known-safe features. Similarly, <a href=https://url.spec.whatwg.org/#syntax-url-relative id=security-risks-in-the-drag-and-drop-model:relative-url data-x-internal=relative-url>relative URLs</a> should be turned into absolute URLs to avoid references changing in
  unexpected ways. This specification does not specify how this is performed.</p>

  <div class=example>

   <p>Consider a hostile page providing some content and getting the user to select and drag and
   drop (or indeed, copy and paste) that content to a victim page's <code id=security-risks-in-the-drag-and-drop-model:attr-contenteditable><a href=interaction.html#attr-contenteditable>contenteditable</a></code> region. If the browser does not ensure that
   only safe content is dragged, potentially unsafe content such as scripts and event handlers in
   the selection, once dropped (or pasted) into the victim site, get the privileges of the victim
   site. This would thus enable a cross-site scripting attack.</p>

  </div>

  




  <nav><a href=interaction.html>← 6 User interaction</a> — <a href=./>Table of Contents</a> — <a href=browsers.html>7 Loading Web pages →</a></nav>