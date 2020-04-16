<!doctype html><html lang="en">
 <head>
  <meta charset="utf-8">
  <meta content="width=device-width, initial-scale=1, shrink-to-fit=no" name="viewport">
  <meta content="#3c790a" name="theme-color">
  <title>Console Standard</title>
  <link crossorigin href="https://resources.whatwg.org/spec.css" rel="stylesheet">
  <link crossorigin href="https://resources.whatwg.org/standard.css" rel="stylesheet">
  <link crossorigin href="https://resources.whatwg.org/standard-shared-with-dev.css" rel="stylesheet">
  <link crossorigin href="https://resources.whatwg.org/logo-console.svg" rel="icon">
<script async crossorigin src="https://resources.whatwg.org/file-issue.js"></script>
<script async crossorigin src="https://resources.whatwg.org/commit-snapshot-shortcut-key.js"></script>
  <meta content="Bikeshed version c1dbacab, updated Mon Mar 30 18:56:12 2020 -0700" name="generator">
<style>/* style-dfn-panel */

.dfn-panel {
    position: absolute;
    z-index: 35;
    height: auto;
    width: -webkit-fit-content;
    width: fit-content;
    max-width: 300px;
    max-height: 500px;
    overflow: auto;
    padding: 0.5em 0.75em;
    font: small Helvetica Neue, sans-serif, Droid Sans Fallback;
    background: #DDDDDD;
    color: black;
    border: outset 0.2em;
}
.dfn-panel:not(.on) { display: none; }
.dfn-panel * { margin: 0; padding: 0; text-indent: 0; }
.dfn-panel > b { display: block; }
.dfn-panel a { color: black; }
.dfn-panel a:not(:hover) { text-decoration: none !important; border-bottom: none !important; }
.dfn-panel > b + b { margin-top: 0.25em; }
.dfn-panel ul { padding: 0; }
.dfn-panel li { list-style: inside; }
.dfn-panel.activated {
    display: inline-block;
    position: fixed;
    left: .5em;
    bottom: 2em;
    margin: 0 auto;
    max-width: calc(100vw - 1.5em - .4em - .5em);
    max-height: 30vh;
}

.dfn-paneled { cursor: pointer; }
</style>
 <body class="h-entry status-LS">
  <div class="head">
    <a class="logo" href="https://whatwg.org/"> <img alt="WHATWG" crossorigin height="100" src="https://resources.whatwg.org/logo-console.svg"> </a> 
   <hgroup>
    <h1 class="p-name no-ref" id="title">Console</h1>
    <h2 class="no-num no-toc no-ref heading settled" id="subtitle"><span class="content">Living Standard — Last Updated <time class="dt-updated" datetime="2020-04-06">6 April 2020</time></span></h2>
   </hgroup>
   <div data-fill-with="spec-metadata">
    <dl>
     <dt>Participate:
     <dd><a href="https://github.com/whatwg/console">GitHub whatwg/console</a> (<a href="https://github.com/whatwg/console/issues/new">new issue</a>, <a href="https://github.com/whatwg/console/issues">open issues</a>)
     <dd><a href="https://wiki.whatwg.org/wiki/IRC">IRC: #whatwg on Freenode</a>
     <dt>Commits:
     <dd><a href="https://github.com/whatwg/console/commits">GitHub whatwg/console/commits</a>
     <dd><a href="/commit-snapshots/f276b49ad99c815a17a86b6c6cbc8ca842eb69d3/" id="commit-snapshot-link">Snapshot as of this commit</a>
     <dd><a href="https://twitter.com/consolelog">@consolelog</a>
     <dt>Tests:
     <dd><a href="https://github.com/web-platform-tests/wpt/tree/master/console">web-platform-tests console/</a> (<a href="https://github.com/web-platform-tests/wpt/labels/console">ongoing work</a>)
     <dt>Translations <small>(non-normative)</small>:
     <dd><span title="Japanese"><a href="https://triple-underscore.github.io/console-ja.html" hreflang="ja" lang="ja" rel="alternate">日本語</a></span>
    </dl>
   </div>
   <div data-fill-with="warning"></div>
  </div>
  <div class="p-summary" data-fill-with="abstract">
   <h2 class="no-num no-toc no-ref heading settled" id="abstract"><span class="content">Abstract</span></h2>
   <p>This specification defines APIs for console debugging facilities.</p>
  </div>
  <nav data-fill-with="table-of-contents" id="toc">
   <h2 class="no-num no-toc no-ref" id="contents">Table of Contents</h2>
   <ol class="toc" role="directory">
    <li>
     <a href="#console-namespace"><span class="secno">1</span> <span class="content">Namespace <code class="idl"><span>console</span></code></span></a>
     <ol class="toc">
      <li>
       <a href="#logging"><span class="secno">1.1</span> <span class="content">Logging functions</span></a>
       <ol class="toc">
        <li><a href="#assert"><span class="secno">1.1.1</span> <span class="content">assert(<var>condition</var>, ...<var>data</var>)</span></a>
        <li><a href="#clear"><span class="secno">1.1.2</span> <span class="content">clear()</span></a>
        <li><a href="#debug"><span class="secno">1.1.3</span> <span class="content">debug(...<var>data</var>)</span></a>
        <li><a href="#error"><span class="secno">1.1.4</span> <span class="content">error(...<var>data</var>)</span></a>
        <li><a href="#info"><span class="secno">1.1.5</span> <span class="content">info(...<var>data</var>)</span></a>
        <li><a href="#log"><span class="secno">1.1.6</span> <span class="content">log(...<var>data</var>)</span></a>
        <li><a href="#table"><span class="secno">1.1.7</span> <span class="content">table(<var>tabularData</var>, <var>properties</var>)</span></a>
        <li><a href="#trace"><span class="secno">1.1.8</span> <span class="content">trace(...<var>data</var>)</span></a>
        <li><a href="#warn"><span class="secno">1.1.9</span> <span class="content">warn(...<var>data</var>)</span></a>
        <li><a href="#dir"><span class="secno">1.1.10</span> <span class="content">dir(<var>item</var>, <var>options</var>)</span></a>
        <li><a href="#dirxml"><span class="secno">1.1.11</span> <span class="content">dirxml(...<var>data</var>)</span></a>
       </ol>
      <li>
       <a href="#counting"><span class="secno">1.2</span> <span class="content">Counting functions</span></a>
       <ol class="toc">
        <li><a href="#count"><span class="secno">1.2.1</span> <span class="content">count(<var>label</var>)</span></a>
        <li><a href="#countreset"><span class="secno">1.2.2</span> <span class="content">countReset(<var>label</var>)</span></a>
       </ol>
      <li>
       <a href="#grouping"><span class="secno">1.3</span> <span class="content">Grouping functions</span></a>
       <ol class="toc">
        <li><a href="#group"><span class="secno">1.3.1</span> <span class="content">group(...<var>data</var>)</span></a>
        <li><a href="#groupcollapsed"><span class="secno">1.3.2</span> <span class="content">groupCollapsed(...<var>data</var>)</span></a>
        <li><a href="#groupend"><span class="secno">1.3.3</span> <span class="content">groupEnd()</span></a>
       </ol>
      <li>
       <a href="#timing"><span class="secno">1.4</span> <span class="content">Timing functions</span></a>
       <ol class="toc">
        <li><a href="#time"><span class="secno">1.4.1</span> <span class="content">time(<var>label</var>)</span></a>
        <li><a href="#timelog"><span class="secno">1.4.2</span> <span class="content">timeLog(<var>label</var>, ...<var>data</var>)</span></a>
        <li><a href="#timeend"><span class="secno">1.4.3</span> <span class="content">timeEnd(<var>label</var>)</span></a>
       </ol>
     </ol>
    <li>
     <a href="#supporting-ops"><span class="secno">2</span> <span class="content">Supporting abstract operations</span></a>
     <ol class="toc">
      <li><a href="#logger"><span class="secno">2.1</span> <span class="content">Logger(<var>logLevel</var>, <var>args</var>)</span></a>
      <li>
       <a href="#formatter"><span class="secno">2.2</span> <span class="content">Formatter(<var>args</var>)</span></a>
       <ol class="toc">
        <li><a href="#formatting-specifiers"><span class="secno">2.2.1</span> <span class="content">Summary of formatting specifiers</span></a>
       </ol>
      <li>
       <a href="#printer"><span class="secno">2.3</span> <span class="content">Printer(<var>logLevel</var>, <var>args</var>[, <var>options</var>])</span></a>
       <ol class="toc">
        <li><a href="#loglevel-severity"><span class="secno">2.3.1</span> <span class="content">Indicating <var>logLevel</var> severity</span></a>
        <li><a href="#printer-ux-innovation"><span class="secno">2.3.2</span> <span class="content">Printer user experience innovation</span></a>
        <li><a href="#object-formats"><span class="secno">2.3.3</span> <span class="content">Common object formats</span></a>
        <li><a href="#nodejs-printer"><span class="secno">2.3.4</span> <span class="content">Example printer in Node.js</span></a>
       </ol>
      <li><a href="#reporting-warnings"><span class="secno">2.4</span> <span class="content">Reporting warnings to the console</span></a>
     </ol>
    <li><a href="#acks"><span class="secno"></span> <span class="content">Acknowledgments</span></a>
    <li>
     <a href="#index"><span class="secno"></span> <span class="content">Index</span></a>
     <ol class="toc">
      <li><a href="#index-defined-here"><span class="secno"></span> <span class="content">Terms defined by this specification</span></a>
      <li><a href="#index-defined-elsewhere"><span class="secno"></span> <span class="content">Terms defined by reference</span></a>
     </ol>
    <li>
     <a href="#references"><span class="secno"></span> <span class="content">References</span></a>
     <ol class="toc">
      <li><a href="#normative"><span class="secno"></span> <span class="content">Normative References</span></a>
     </ol>
    <li><a href="#idl-index"><span class="secno"></span> <span class="content">IDL Index</span></a>
   </ol>
  </nav>
  <main>
   <h2 class="no-num no-toc heading settled" id="status"><span class="content">Status</span></h2>
   <p>This specification is an early work in progress that welcomes feedback to refine toward more
precise and compatible definitions. It is also the editors' first specification, so please be kind
and constructive.</p>
   <p>Please join us in the <a href="https://github.com/whatwg/console/issues">issue tracker</a> for more
discussion.</p>
   <h2 class="heading settled" data-level="1" id="console-namespace"><span class="secno">1. </span><span class="content">Namespace <code class="idl"><a data-link-type="idl" href="#namespacedef-console" id="ref-for-namespacedef-console">console</a></code></span><span id="console-interface"></span><a class="self-link" href="#console-namespace"></a></h2>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed"><c- g>Exposed</c-></a>=(<c- n>Window</c->,<c- n>Worker</c->,<c- n>Worklet</c->)]
<c- b>namespace</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="namespace" data-export id="namespacedef-console"><code><c- g>console</c-></code></dfn> { // but see namespace object requirements below
  // Logging
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#assert" id="ref-for-assert"><c- g>assert</c-></a>(<c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean"><c- b>boolean</c-></a> <dfn class="idl-code" data-dfn-for="console/assert(condition, ...data), console/assert(condition), console/assert()" data-dfn-type="argument" data-export id="dom-console-assert-condition-data-condition"><code><c- g>condition</c-></code><a class="self-link" href="#dom-console-assert-condition-data-condition"></a></dfn> = <c- b>false</c->, <c- b>any</c->... <dfn class="idl-code" data-dfn-for="console/assert(condition, ...data), console/assert(condition), console/assert()" data-dfn-type="argument" data-export id="dom-console-assert-condition-data-data"><code><c- g>data</c-></code><a class="self-link" href="#dom-console-assert-condition-data-data"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#clear" id="ref-for-clear"><c- g>clear</c-></a>();
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#debug" id="ref-for-debug"><c- g>debug</c-></a>(<c- b>any</c->... <dfn class="idl-code" data-dfn-for="console/debug(...data), console/debug()" data-dfn-type="argument" data-export id="dom-console-debug-data-data"><code><c- g>data</c-></code><a class="self-link" href="#dom-console-debug-data-data"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#error" id="ref-for-error"><c- g>error</c-></a>(<c- b>any</c->... <dfn class="idl-code" data-dfn-for="console/error(...data), console/error()" data-dfn-type="argument" data-export id="dom-console-error-data-data"><code><c- g>data</c-></code><a class="self-link" href="#dom-console-error-data-data"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#info" id="ref-for-info"><c- g>info</c-></a>(<c- b>any</c->... <dfn class="idl-code" data-dfn-for="console/info(...data), console/info()" data-dfn-type="argument" data-export id="dom-console-info-data-data"><code><c- g>data</c-></code><a class="self-link" href="#dom-console-info-data-data"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#log" id="ref-for-log"><c- g>log</c-></a>(<c- b>any</c->... <dfn class="idl-code" data-dfn-for="console/log(...data), console/log()" data-dfn-type="argument" data-export id="dom-console-log-data-data"><code><c- g>data</c-></code><a class="self-link" href="#dom-console-log-data-data"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#table" id="ref-for-table"><c- g>table</c-></a>(<c- b>optional</c-> <c- b>any</c-> <dfn class="idl-code" data-dfn-for="console/table(tabularData, properties), console/table(tabularData), console/table()" data-dfn-type="argument" data-export id="dom-console-table-tabulardata-properties-tabulardata"><code><c- g>tabularData</c-></code><a class="self-link" href="#dom-console-table-tabulardata-properties-tabulardata"></a></dfn>, <c- b>optional</c-> <c- b>sequence</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString"><c- b>DOMString</c-></a>> <dfn class="idl-code" data-dfn-for="console/table(tabularData, properties), console/table(tabularData), console/table()" data-dfn-type="argument" data-export id="dom-console-table-tabulardata-properties-properties"><code><c- g>properties</c-></code><a class="self-link" href="#dom-console-table-tabulardata-properties-properties"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#trace" id="ref-for-trace"><c- g>trace</c-></a>(<c- b>any</c->... <dfn class="idl-code" data-dfn-for="console/trace(...data), console/trace()" data-dfn-type="argument" data-export id="dom-console-trace-data-data"><code><c- g>data</c-></code><a class="self-link" href="#dom-console-trace-data-data"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#warn" id="ref-for-warn"><c- g>warn</c-></a>(<c- b>any</c->... <dfn class="idl-code" data-dfn-for="console/warn(...data), console/warn()" data-dfn-type="argument" data-export id="dom-console-warn-data-data"><code><c- g>data</c-></code><a class="self-link" href="#dom-console-warn-data-data"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dir" id="ref-for-dir"><c- g>dir</c-></a>(<c- b>optional</c-> <c- b>any</c-> <dfn class="idl-code" data-dfn-for="console/dir(item, options), console/dir(item), console/dir()" data-dfn-type="argument" data-export id="dom-console-dir-item-options-item"><code><c- g>item</c-></code><a class="self-link" href="#dom-console-dir-item-options-item"></a></dfn>, <c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-object" id="ref-for-idl-object"><c- b>object</c-></a>? <dfn class="idl-code" data-dfn-for="console/dir(item, options), console/dir(item), console/dir()" data-dfn-type="argument" data-export id="dom-console-dir-item-options-options"><code><c- g>options</c-></code><a class="self-link" href="#dom-console-dir-item-options-options"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dirxml" id="ref-for-dirxml"><c- g>dirxml</c-></a>(<c- b>any</c->... <dfn class="idl-code" data-dfn-for="console/dirxml(...data), console/dirxml()" data-dfn-type="argument" data-export id="dom-console-dirxml-data-data"><code><c- g>data</c-></code><a class="self-link" href="#dom-console-dirxml-data-data"></a></dfn>);

  // Counting
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#count" id="ref-for-count"><c- g>count</c-></a>(<c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString①"><c- b>DOMString</c-></a> <dfn class="idl-code" data-dfn-for="console/count(label), console/count()" data-dfn-type="argument" data-export id="dom-console-count-label-label"><code><c- g>label</c-></code><a class="self-link" href="#dom-console-count-label-label"></a></dfn> = "default");
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#countreset" id="ref-for-countreset"><c- g>countReset</c-></a>(<c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString②"><c- b>DOMString</c-></a> <dfn class="idl-code" data-dfn-for="console/countReset(label), console/countReset()" data-dfn-type="argument" data-export id="dom-console-countreset-label-label"><code><c- g>label</c-></code><a class="self-link" href="#dom-console-countreset-label-label"></a></dfn> = "default");

  // Grouping
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#group" id="ref-for-group"><c- g>group</c-></a>(<c- b>any</c->... <dfn class="idl-code" data-dfn-for="console/group(...data), console/group()" data-dfn-type="argument" data-export id="dom-console-group-data-data"><code><c- g>data</c-></code><a class="self-link" href="#dom-console-group-data-data"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#groupcollapsed" id="ref-for-groupcollapsed"><c- g>groupCollapsed</c-></a>(<c- b>any</c->... <dfn class="idl-code" data-dfn-for="console/groupCollapsed(...data), console/groupCollapsed()" data-dfn-type="argument" data-export id="dom-console-groupcollapsed-data-data"><code><c- g>data</c-></code><a class="self-link" href="#dom-console-groupcollapsed-data-data"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#groupend" id="ref-for-groupend"><c- g>groupEnd</c-></a>();

  // Timing
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#time" id="ref-for-time"><c- g>time</c-></a>(<c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString③"><c- b>DOMString</c-></a> <dfn class="idl-code" data-dfn-for="console/time(label), console/time()" data-dfn-type="argument" data-export id="dom-console-time-label-label"><code><c- g>label</c-></code><a class="self-link" href="#dom-console-time-label-label"></a></dfn> = "default");
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#timelog" id="ref-for-timelog"><c- g>timeLog</c-></a>(<c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString④"><c- b>DOMString</c-></a> <dfn class="idl-code" data-dfn-for="console/timeLog(label, ...data), console/timeLog(label), console/timeLog()" data-dfn-type="argument" data-export id="dom-console-timelog-label-data-label"><code><c- g>label</c-></code><a class="self-link" href="#dom-console-timelog-label-data-label"></a></dfn> = "default", <c- b>any</c->... <dfn class="idl-code" data-dfn-for="console/timeLog(label, ...data), console/timeLog(label), console/timeLog()" data-dfn-type="argument" data-export id="dom-console-timelog-label-data-data"><code><c- g>data</c-></code><a class="self-link" href="#dom-console-timelog-label-data-data"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#timeend" id="ref-for-timeend"><c- g>timeEnd</c-></a>(<c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString⑤"><c- b>DOMString</c-></a> <dfn class="idl-code" data-dfn-for="console/timeEnd(label), console/timeEnd()" data-dfn-type="argument" data-export id="dom-console-timeend-label-label"><code><c- g>label</c-></code><a class="self-link" href="#dom-console-timeend-label-label"></a></dfn> = "default");
};
</pre>
   <p class="note" role="note"> For historical reasons, <code class="idl"><a data-link-type="idl" href="#namespacedef-console" id="ref-for-namespacedef-console①">console</a></code> is lowercased. </p>
   <p class="note" role="note"> It is important that <code class="idl"><a data-link-type="idl" href="#namespacedef-console" id="ref-for-namespacedef-console②">console</a></code> is always visible and usable to scripts, even if the developer
  console has not been opened or does not exist. </p>
   <p>For historical web-compatibility reasons, the <a data-link-type="dfn" href="https://heycam.github.io/webidl/#dfn-namespace-object" id="ref-for-dfn-namespace-object">namespace object</a> for <code class="idl"><a data-link-type="idl" href="#namespacedef-console" id="ref-for-namespacedef-console③">console</a></code> must have as
its [[Prototype]] an empty object, created as if by <a data-link-type="abstract-op" href="https://tc39.github.io/ecma262/#sec-objectcreate" id="ref-for-sec-objectcreate">ObjectCreate</a>(<code class="idl"><a data-link-type="idl" href="https://tc39.github.io/ecma262/#sec-properties-of-the-object-prototype-object" id="ref-for-sec-properties-of-the-object-prototype-object">%ObjectPrototype%</a></code>), instead of <code class="idl"><a data-link-type="idl" href="https://tc39.github.io/ecma262/#sec-properties-of-the-object-prototype-object" id="ref-for-sec-properties-of-the-object-prototype-object①">%ObjectPrototype%</a></code>.</p>
   <h3 class="heading settled" data-level="1.1" id="logging"><span class="secno">1.1. </span><span class="content">Logging functions</span><a class="self-link" href="#logging"></a></h3>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.1.1" data-lt="assert(condition, ...data)|assert(condition)|assert()" id="assert"><span class="secno">1.1.1. </span><span class="content">assert(<var>condition</var>, ...<var>data</var>)</span><span id="assert-condition-data"></span><span id="dom-console-assert"></span></h4>
   <ol>
    <li data-md>
     <p>If <var>condition</var> is true, return.</p>
    <li data-md>
     <p>Let <var>message</var> be a string without any formatting specifiers indicating generically an assertion
 failure (such as "Assertion failed").</p>
    <li data-md>
     <p>If <var>data</var> is <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-is-empty" id="ref-for-list-is-empty">empty</a>, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-append" id="ref-for-list-append">append</a> <var>message</var> to <var>data</var>.</p>
    <li data-md>
     <p>Otherwise:</p>
     <ol>
      <li data-md>
       <p>Let <var>first</var> be <var>data</var>[0].</p>
      <li data-md>
       <p>If <a data-link-type="abstract-op" href="https://tc39.github.io/ecma262/#sec-ecmascript-data-types-and-values" id="ref-for-sec-ecmascript-data-types-and-values">Type</a>(<var>first</var>) is not String, then <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-prepend" id="ref-for-list-prepend">prepend</a> <var>message</var> to <var>data</var>.</p>
      <li data-md>
       <p>Otherwise:</p>
       <ol>
        <li data-md>
         <p>Let <var>concat</var> be the concatenation of <var>message</var>, U+003A (:), U+0020 SPACE, and <var>first</var>.</p>
        <li data-md>
         <p>Set <var>data</var>[0] to <var>concat</var>.</p>
       </ol>
     </ol>
    <li data-md>
     <p>Perform <a data-link-type="abstract-op" href="#logger" id="ref-for-logger">Logger</a>("assert", <var>data</var>).</p>
   </ol>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.1.2" data-lt="clear()" id="clear"><span class="secno">1.1.2. </span><span class="content">clear()</span><span id="dom-console-clear"></span></h4>
   <ol>
    <li data-md>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-empty" id="ref-for-list-empty">Empty</a> the appropriate <a data-link-type="dfn" href="#group-stack" id="ref-for-group-stack">group stack</a>.</p>
    <li data-md>
     <p>If possible for the environment, clear the console. (Otherwise, do nothing.)</p>
   </ol>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.1.3" data-lt="debug(...data)|debug()" id="debug"><span class="secno">1.1.3. </span><span class="content">debug(...<var>data</var>)</span><span id="debug-data"></span><span id="dom-console-debug"></span></h4>
   <ol>
    <li data-md>
     <p>Perform <a data-link-type="abstract-op" href="#logger" id="ref-for-logger①">Logger</a>("debug", <var>data</var>).</p>
   </ol>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.1.4" data-lt="error(...data)|error()" id="error"><span class="secno">1.1.4. </span><span class="content">error(...<var>data</var>)</span><span id="error-data"></span><span id="dom-console-error"></span></h4>
   <ol>
    <li data-md>
     <p>Perform <a data-link-type="abstract-op" href="#logger" id="ref-for-logger②">Logger</a>("error", <var>data</var>).</p>
   </ol>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.1.5" data-lt="info(...data)|info()" id="info"><span class="secno">1.1.5. </span><span class="content">info(...<var>data</var>)</span><span id="info-data"></span><span id="dom-console-info"></span></h4>
   <ol>
    <li data-md>
     <p>Perform <a data-link-type="abstract-op" href="#logger" id="ref-for-logger③">Logger</a>("info", <var>data</var>).</p>
   </ol>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.1.6" data-lt="log(...data)|log()" id="log"><span class="secno">1.1.6. </span><span class="content">log(...<var>data</var>)</span><span id="log-data"></span><span id="dom-console-log"></span></h4>
   <ol>
    <li data-md>
     <p>Perform <a data-link-type="abstract-op" href="#logger" id="ref-for-logger④">Logger</a>("log", <var>data</var>).</p>
   </ol>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.1.7" data-lt="table(tabularData, properties)|table(tabularData)|table()" id="table"><span class="secno">1.1.7. </span><span class="content">table(<var>tabularData</var>, <var>properties</var>)</span><span id="table-tabulardata-properties"></span><span id="dom-console-table"></span></h4>
   <p>Try to construct a table with the columns of the properties of <var>tabularData</var> (or use <var>properties</var>) and rows of <var>tabularData</var> and log it with a logLevel of "log". Fall
back to just logging the argument if it can’t be parsed as tabular.</p>
   <p class="XXX">TODO: This will need a good algorithm.</p>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.1.8" data-lt="trace(...data)|trace()" id="trace"><span class="secno">1.1.8. </span><span class="content">trace(...<var>data</var>)</span><span id="trace-data"></span><span id="dom-console-trace"></span></h4>
   <ol>
    <li data-md>
     <p>Let <var>trace</var> be some implementation-specific, potentially-interactive representation of the
 callstack from where this function was called.</p>
    <li data-md>
     <p>Optionally, let <var>formattedData</var> be the result of <a data-link-type="abstract-op" href="#formatter" id="ref-for-formatter">Formatter</a>(<var>data</var>), and
 incorporate <var>formattedData</var> as a label for <var>trace</var>.</p>
    <li data-md>
     <p>Perform <a data-link-type="abstract-op" href="#printer" id="ref-for-printer">Printer</a>("trace", « <var>trace</var> »).</p>
   </ol>
   <p class="note" role="note"> The identifier of a function printed in a stack trace is implementation-dependant. It is also not
  guaranteed to be the same identifier that would be seen in <code>new Error().stack</code>. </p>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.1.9" data-lt="warn(...data)|warn()" id="warn"><span class="secno">1.1.9. </span><span class="content">warn(...<var>data</var>)</span><span id="warn-data"></span><span id="dom-console-warn"></span></h4>
   <ol>
    <li data-md>
     <p>Perform <a data-link-type="abstract-op" href="#logger" id="ref-for-logger⑤">Logger</a>("warn", <var>data</var>).</p>
   </ol>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.1.10" data-lt="dir(item, options)|dir(item)|dir()" id="dir"><span class="secno">1.1.10. </span><span class="content">dir(<var>item</var>, <var>options</var>)</span></h4>
   <ol>
    <li data-md>
     <p>Let <var>object</var> be <var>item</var> with <a data-link-type="dfn" href="#generic-javascript-object-formatting" id="ref-for-generic-javascript-object-formatting">generic JavaScript object formatting</a> applied.</p>
    <li data-md>
     <p>Perform <a data-link-type="abstract-op" href="#printer" id="ref-for-printer①">Printer</a>("dir", « <var>object</var> », <var>options</var>).</p>
   </ol>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.1.11" data-lt="dirxml(...data)|dirxml()" id="dirxml"><span class="secno">1.1.11. </span><span class="content">dirxml(...<var>data</var>)</span></h4>
   <ol>
    <li data-md>
     <p>Let <var>finalList</var> be a new <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list" id="ref-for-list">list</a>, initially empty.</p>
    <li data-md>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate">For each</a> <var>item</var> of <var>data</var>:</p>
     <ol>
      <li data-md>
       <p>Let <var>converted</var> be a DOM tree representation of <var>item</var> if possible; otherwise let <var>converted</var> be <var>item</var> with <a data-link-type="dfn" href="#optimally-useful-formatting" id="ref-for-optimally-useful-formatting">optimally useful formatting</a> applied.</p>
      <li data-md>
       <p>Append <var>converted</var> to <var>finalList</var>.</p>
     </ol>
    <li data-md>
     <p>Perform <a data-link-type="abstract-op" href="#logger" id="ref-for-logger⑥">Logger</a>("dirxml", <var>finalList</var>).</p>
   </ol>
   <h3 class="heading settled" data-level="1.2" id="counting"><span class="secno">1.2. </span><span class="content">Counting functions</span><a class="self-link" href="#counting"></a></h3>
   <p>Each <code class="idl"><a data-link-type="idl" href="#namespacedef-console" id="ref-for-namespacedef-console④">console</a></code> namespace object has an associated <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="count-map">count map</dfn>, which is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ordered-map" id="ref-for-ordered-map">map</a> of <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#string" id="ref-for-string">strings</a> to numbers, initially empty.</p>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.2.1" data-lt="count(label)|count()" id="count"><span class="secno">1.2.1. </span><span class="content">count(<var>label</var>)</span><span id="count-label"></span><span id="dom-console-count"></span></h4>
   <ol>
    <li data-md>
     <p>Let <var>map</var> be the associated <a data-link-type="dfn" href="#count-map" id="ref-for-count-map">count map</a>.</p>
    <li data-md>
     <p>If <var>map</var>[<var>label</var>] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists">exists</a>, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-set" id="ref-for-map-set">set</a> <var>map</var>[<var>label</var>] to <var>map</var>[<var>label</var>] + 1.</p>
    <li data-md>
     <p>Otherwise, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-set" id="ref-for-map-set①">set</a> <var>map</var>[<var>label</var>] to 1.</p>
    <li data-md>
     <p>Let <var>concat</var> be the concatenation of <var>label</var>, U+003A (:), U+0020 SPACE, and <a data-link-type="abstract-op" href="https://tc39.github.io/ecma262/#sec-tostring" id="ref-for-sec-tostring">ToString</a>(<var>map</var>[<var>label</var>]).</p>
    <li data-md>
     <p>Perform <a data-link-type="abstract-op" href="#logger" id="ref-for-logger⑦">Logger</a>("count", « <var>concat</var> »).</p>
   </ol>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.2.2" data-lt="countReset(label)|countReset()" id="countreset"><span class="secno">1.2.2. </span><span class="content">countReset(<var>label</var>)</span></h4>
   <ol>
    <li data-md>
     <p>Let <var>map</var> be the associated <a data-link-type="dfn" href="#count-map" id="ref-for-count-map①">count map</a>.</p>
    <li data-md>
     <p>If <var>map</var>[<var>label</var>] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists①">exists</a>, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-set" id="ref-for-map-set②">set</a> <var>map</var>[<var>label</var>] to 0.</p>
    <li data-md>
     <p>Otherwise:</p>
     <ol>
      <li data-md>
       <p>Let <var>message</var> be a string without any formatting specifiers indicating generically that the
given label does not have an associated count.</p>
      <li data-md>
       <p>Perform <a data-link-type="abstract-op" href="#logger" id="ref-for-logger⑧">Logger</a>("countReset", « <var>message</var> »);</p>
     </ol>
   </ol>
   <h3 class="heading settled" data-level="1.3" id="grouping"><span class="secno">1.3. </span><span class="content">Grouping functions</span><a class="self-link" href="#grouping"></a></h3>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-group">group</dfn> is an implementation-specific, potentially-interactive view
for output produced by calls to <a data-link-type="abstract-op" href="#printer" id="ref-for-printer②">Printer</a>, with one further level of indentation
than its parent. Each <code class="idl"><a data-link-type="idl" href="#namespacedef-console" id="ref-for-namespacedef-console⑤">console</a></code> namespace object has an associated <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="group-stack">group stack</dfn>, which
is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#stack" id="ref-for-stack">stack</a>, initially empty. Only the last <a data-link-type="dfn" href="#concept-group" id="ref-for-concept-group">group</a> in a <a data-link-type="dfn" href="#group-stack" id="ref-for-group-stack①">group stack</a> will host
output produced by calls to <a data-link-type="abstract-op" href="#printer" id="ref-for-printer③">Printer</a>.</p>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.3.1" data-lt="group(...data)|group()" id="group"><span class="secno">1.3.1. </span><span class="content">group(...<var>data</var>)</span><span id="group-data"></span><span id="dom-console-group"></span></h4>
   <ol>
    <li data-md>
     <p>Let <var>group</var> be a new <a data-link-type="dfn" href="#concept-group" id="ref-for-concept-group①">group</a>.</p>
    <li data-md>
     <p>If <var>data</var> is not <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-is-empty" id="ref-for-list-is-empty①">empty</a>, let <var>groupLabel</var> be the result of <a data-link-type="abstract-op" href="#formatter" id="ref-for-formatter①">Formatter</a>(<var>data</var>). Otherwise, let <var>groupLabel</var> be an implementation-chosen
 label representing a <a data-link-type="dfn" href="#concept-group" id="ref-for-concept-group②">group</a>.</p>
    <li data-md>
     <p>Incorporate <var>groupLabel</var> as a label for <var>group</var>.</p>
    <li data-md>
     <p>Optionally, if the environment supports interactive groups, <var>group</var> should be expanded by
 default.</p>
    <li data-md>
     <p>Perform <a data-link-type="abstract-op" href="#printer" id="ref-for-printer④">Printer</a>("group", « <var>group</var> »).</p>
    <li data-md>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#stack-push" id="ref-for-stack-push">Push</a> <var>group</var> onto the appropriate <a data-link-type="dfn" href="#group-stack" id="ref-for-group-stack②">group stack</a>.</p>
   </ol>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.3.2" data-lt="groupCollapsed(...data)|groupCollapsed()" id="groupcollapsed"><span class="secno">1.3.2. </span><span class="content">groupCollapsed(...<var>data</var>)</span><span id="groupcollapsed-data"></span><span id="dom-console-groupcollapsed"></span></h4>
   <ol>
    <li data-md>
     <p>Let <var>group</var> be a new <a data-link-type="dfn" href="#concept-group" id="ref-for-concept-group③">group</a>.</p>
    <li data-md>
     <p>If <var>data</var> is not empty, let <var>groupLabel</var> be the result of <a data-link-type="abstract-op" href="#formatter" id="ref-for-formatter②">Formatter</a>(<var>data</var>). Otherwise, let <var>groupLabel</var> be an implementation-chosen
 label representing a <a data-link-type="dfn" href="#concept-group" id="ref-for-concept-group④">group</a>.</p>
    <li data-md>
     <p>Incorporate <var>groupLabel</var> as a label for <var>group</var>.</p>
    <li data-md>
     <p>Optionally, if the environment supports interactive groups, <var>group</var> should be collapsed by
 default.</p>
    <li data-md>
     <p>Perform <a data-link-type="abstract-op" href="#printer" id="ref-for-printer⑤">Printer</a>("groupCollapsed", « <var>group</var> »).</p>
    <li data-md>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#stack-push" id="ref-for-stack-push①">Push</a> <var>group</var> onto the appropriate <a data-link-type="dfn" href="#group-stack" id="ref-for-group-stack③">group stack</a>.</p>
   </ol>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.3.3" data-lt="groupEnd()" id="groupend"><span class="secno">1.3.3. </span><span class="content">groupEnd()</span><span id="dom-console-groupend"></span></h4>
   <ol>
    <li data-md>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#stack-pop" id="ref-for-stack-pop">Pop</a> the last <a data-link-type="dfn" href="#concept-group" id="ref-for-concept-group⑤">group</a> from the <a data-link-type="dfn" href="#group-stack" id="ref-for-group-stack④">group stack</a>.</p>
   </ol>
   <h3 class="heading settled" data-level="1.4" id="timing"><span class="secno">1.4. </span><span class="content">Timing functions</span><a class="self-link" href="#timing"></a></h3>
   <p>Each <code class="idl"><a data-link-type="idl" href="#namespacedef-console" id="ref-for-namespacedef-console⑥">console</a></code> namespace object has an associated <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="timer-table">timer table</dfn>, which is a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ordered-map" id="ref-for-ordered-map①">map</a> of <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#string" id="ref-for-string①">strings</a> to times, initially empty.</p>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.4.1" data-lt="time(label)|time()" id="time"><span class="secno">1.4.1. </span><span class="content">time(<var>label</var>)</span><span id="time-label"></span><span id="dom-console-time"></span></h4>
   <ol>
    <li data-md>
     <p>If the associated <a data-link-type="dfn" href="#timer-table" id="ref-for-timer-table">timer table</a> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists②">contains</a> an entry with key <var>label</var>, return,
 optionally reporting a warning to the console indicating that a timer with label <var>label</var> has
 already been started.</p>
    <li data-md>
     <p>Otherwise, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-set" id="ref-for-map-set③">set</a> the value of the entry with key <var>label</var> in the associated <a data-link-type="dfn" href="#timer-table" id="ref-for-timer-table①">timer table</a> to the current time.</p>
   </ol>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.4.2" data-lt="timeLog(label, ...data)|timeLog(label)|timeLog()" id="timelog"><span class="secno">1.4.2. </span><span class="content">timeLog(<var>label</var>, ...<var>data</var>)</span></h4>
   <ol>
    <li data-md>
     <p>Let <var>timerTable</var> be the associated <a data-link-type="dfn" href="#timer-table" id="ref-for-timer-table②">timer table</a>.</p>
    <li data-md>
     <p>Let <var>startTime</var> be <var>timerTable</var>[<var>label</var>].</p>
    <li data-md>
     <p>Let <var>duration</var> be a string representing the difference between the current time and <var>startTime</var>, in an implementation-defined format.</p>
     <p class="example" id="duration-string-example"><a class="self-link" href="#duration-string-example"></a>"4650", "4650.69 ms", "5 seconds", and "00:05"
 are all reasonable ways of displaying a 4650.69 ms duration.</p>
    <li data-md>
     <p>Let <var>concat</var> be the concatenation of <var>label</var>, U+003A (:), U+0020 SPACE, and <var>duration</var>.</p>
    <li data-md>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-prepend" id="ref-for-list-prepend①">Prepend</a> <var>concat</var> to <var>data</var>.</p>
    <li data-md>
     <p>Perform <a data-link-type="abstract-op" href="#printer" id="ref-for-printer⑥">Printer</a>("timeLog", data).</p>
   </ol>
   <div class="example" id="timelog-example">
    <a class="self-link" href="#timelog-example"></a> The <var>data</var> parameter in calls to <code class="idl"><a data-link-type="idl" href="#timelog" id="ref-for-timelog①">timeLog()</a></code> is included in the call to <a data-link-type="abstract-op" href="#logger" id="ref-for-logger⑨">Logger</a> to make it easier for users to supply intermediate timer logs with
  some extra data throughout the life of a timer. For example: 
<pre><code class="lang-javascript highlight">console<c- p>.</c->time<c- p>(</c-><c- u>"MyTimer"</c-><c- p>);</c->
console<c- p>.</c->timeLog<c- p>(</c-><c- u>"MyTimer"</c-><c- p>,</c-> <c- u>"Starting application up…"</c-><c- p>);</c->
<c- c1>// Perhaps some code runs to bootstrap a complex app</c->
<c- c1>// ...</c->
console<c- p>.</c->timeLog<c- p>(</c-><c- u>"MyTimer"</c-><c- p>,</c-> <c- u>"UI is setup, making API calls now"</c-><c- p>);</c->
<c- c1>// Perhaps some fetch()'s here filling the app with data</c->
<c- c1>// ...</c->
console<c- p>.</c->timeEnd<c- p>(</c-><c- u>"MyTimer"</c-><c- p>);</c->
</code></pre>
   </div>
   <h4 class="heading settled dfn-paneled idl-code" data-dfn-for="console" data-dfn-type="method" data-export data-level="1.4.3" data-lt="timeEnd(label)|timeEnd()" id="timeend"><span class="secno">1.4.3. </span><span class="content">timeEnd(<var>label</var>)</span><span id="timeend-label"></span><span id="dom-console-timeend"></span></h4>
   <ol>
    <li data-md>
     <p>Let <var>timerTable</var> be the associated <a data-link-type="dfn" href="#timer-table" id="ref-for-timer-table③">timer table</a>.</p>
    <li data-md>
     <p>Let <var>startTime</var> be <var>timerTable</var>[<var>label</var>].</p>
    <li data-md>
     <p><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-remove" id="ref-for-map-remove">Remove</a> <var>timerTable</var>[<var>label</var>].</p>
    <li data-md>
     <p>Let <var>duration</var> be a string representing the difference between the current time and <var>startTime</var>, in an implementation-defined format.</p>
    <li data-md>
     <p>Let <var>concat</var> be the concatenation of <var>label</var>, U+003A (:), U+0020 SPACE, and <var>duration</var>.</p>
    <li data-md>
     <p>Perform <a data-link-type="abstract-op" href="#printer" id="ref-for-printer⑦">Printer</a>("timeEnd", « <var>concat</var> »).</p>
   </ol>
   <p class="note" role="note">See <a href="https://github.com/whatwg/console/issues/134">whatwg/console#134</a> for plans to make <code class="idl"><a data-link-type="idl" href="#timeend" id="ref-for-timeend①">timeEnd()</a></code> and <code class="idl"><a data-link-type="idl" href="#timelog" id="ref-for-timelog②">timeLog()</a></code> formally report warnings to the
console when a given <var>label</var> does not exist in the associated <a data-link-type="dfn" href="#timer-table" id="ref-for-timer-table④">timer table</a>. </p>
   <h2 class="heading settled" data-level="2" id="supporting-ops"><span class="secno">2. </span><span class="content">Supporting abstract operations</span><a class="self-link" href="#supporting-ops"></a></h2>
   <h3 class="heading settled dfn-paneled" data-dfn-type="abstract-op" data-export data-level="2.1" data-lt="Logger" id="logger"><span class="secno">2.1. </span><span class="content">Logger(<var>logLevel</var>, <var>args</var>)</span></h3>
   <p>The logger operation accepts a log level and a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list" id="ref-for-list①">list</a> of other arguments. Its main output is the
implementation-defined side effect of printing the result to the console. This specification
describes how it processes format specifiers while doing so.</p>
   <ol>
    <li data-md>
     <p>If <var>args</var> is <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-is-empty" id="ref-for-list-is-empty②">empty</a>, return.</p>
    <li data-md>
     <p>Let <var>first</var> be <var>args</var>[0].</p>
    <li data-md>
     <p>Let <var>rest</var> be all elements following <var>first</var> in <var>args</var>.</p>
    <li data-md>
     <p>If <var>rest</var> is <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-is-empty" id="ref-for-list-is-empty③">empty</a>, perform <a data-link-type="abstract-op" href="#printer" id="ref-for-printer⑧">Printer</a>(<var>logLevel</var>, « <var>first</var> ») and return.</p>
    <li data-md>
     <p>If <var>first</var> does not contain any format specifiers, perform <a data-link-type="abstract-op" href="#printer" id="ref-for-printer⑨">Printer</a>(<var>logLevel</var>, <var>args</var>).</p>
    <li data-md>
     <p>Otherwise, perform <a data-link-type="abstract-op" href="#printer" id="ref-for-printer①⓪">Printer</a>(<var>logLevel</var>, <a data-link-type="abstract-op" href="#formatter" id="ref-for-formatter③">Formatter</a>(<var>args</var>)).</p>
    <li data-md>
     <p>Return <em>undefined</em>.</p>
   </ol>
   <div class="note" role="note">
     It’s important that the printing occurs before returning from the algorithm. Many developer
  consoles print the result of the last operation entered into them. In such consoles, when a
  developer enters <code>console.log("hello!")</code>, this will first print "hello!", then the
  undefined return value from the console.log call. 
    <p><img alt="Indicating that printing is done before return" crossorigin src="images/print-before-returning.png"></p>
   </div>
   <h3 class="heading settled dfn-paneled" data-dfn-type="abstract-op" data-export data-level="2.2" data-lt="Formatter" id="formatter"><span class="secno">2.2. </span><span class="content">Formatter(<var>args</var>)</span></h3>
   <p>The formatter operation tries to format the first argument provided, using the other arguments. It
will try to format the input until no formatting specifiers are left in the first argument, or no
more arguments are left. It returns a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list" id="ref-for-list②">list</a> of objects suitable for printing.</p>
   <ol>
    <li data-md>
     <p>Let <var>target</var> be the first element of <var>args</var>.</p>
    <li data-md>
     <p>Let <var>current</var> be the second element of <var>args</var>.</p>
    <li data-md>
     <p>Find the first possible format specifier <var>specifier</var>, from the left to the right in <var>target</var>.</p>
     <ol>
      <li data-md>
       <p>If <var>specifier</var> is <code>%s</code>, let <var>converted</var> be the result of <a data-link-type="abstract-op" href="https://tc39.github.io/ecma262/#sec-call" id="ref-for-sec-call">Call</a>(<a data-link-type="idl" href="https://tc39.github.io/ecma262/#sec-string-constructor" id="ref-for-sec-string-constructor">%String%</a>, <strong>undefined</strong>, « <var>current</var> »).</p>
      <li data-md>
       <p>If <var>specifier</var> is <code>%d</code> or <code>%i</code>:</p>
       <ol>
        <li data-md>
         <p>If <a data-link-type="abstract-op" href="https://tc39.github.io/ecma262/#sec-ecmascript-data-types-and-values" id="ref-for-sec-ecmascript-data-types-and-values①">Type</a>(<var>current</var>) is Symbol, let <var>converted</var> be <code>NaN</code></p>
        <li data-md>
         <p>Otherwise, let <var>converted</var> be the result of <a data-link-type="abstract-op" href="https://tc39.github.io/ecma262/#sec-call" id="ref-for-sec-call①">Call</a>(<a data-link-type="dfn" href="https://tc39.github.io/ecma262/#sec-parseint-string-radix" id="ref-for-sec-parseint-string-radix">%parseInt%</a>, <strong>undefined</strong>, « <var>current</var>, 10 »).</p>
       </ol>
      <li data-md>
       <p>If <var>specifier</var> is <code>%f</code>:</p>
       <ol>
        <li data-md>
         <p>If <a data-link-type="abstract-op" href="https://tc39.github.io/ecma262/#sec-ecmascript-data-types-and-values" id="ref-for-sec-ecmascript-data-types-and-values②">Type</a>(<var>current</var>) is Symbol, let <var>converted</var> be <code>NaN</code></p>
        <li data-md>
         <p>Otherwise, let <var>converted</var> be the result of <a data-link-type="abstract-op" href="https://tc39.github.io/ecma262/#sec-call" id="ref-for-sec-call②">Call</a>(<a data-link-type="dfn" href="https://tc39.github.io/ecma262/#sec-parsefloat-string" id="ref-for-sec-parsefloat-string">%parseFloat%</a>, <strong>undefined</strong>, « <var>current</var> »).</p>
       </ol>
      <li data-md>
       <p>If <var>specifier</var> is <code>%o</code>, optionally let <var>converted</var> be <var>current</var> with <a data-link-type="dfn" href="#optimally-useful-formatting" id="ref-for-optimally-useful-formatting①">optimally useful formatting</a> applied.</p>
      <li data-md>
       <p>If <var>specifier</var> is <code>%O</code>, optionally let <var>converted</var> be <var>current</var> with <a data-link-type="dfn" href="#generic-javascript-object-formatting" id="ref-for-generic-javascript-object-formatting①">generic JavaScript object formatting</a> applied.</p>
      <li data-md>
       <p class="XXX">TODO: process %c</p>
      <li data-md>
       <p>If any of the previous steps set <var>converted</var>, replace <var>specifier</var> in <var>target</var> with <var>converted</var>.</p>
      <li data-md>
       <p>Let <var>result</var> be a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list" id="ref-for-list③">list</a> containing <var>target</var> together with the elements of <var>args</var> starting
 from the third onward.</p>
     </ol>
    <li data-md>
     <p>If <var>target</var> does not have any format specifiers left, return <var>result</var>.</p>
    <li data-md>
     <p>If <var>result</var>’s <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-size" id="ref-for-list-size">size</a> is 1, return <var>result</var>.</p>
    <li data-md>
     <p>Return <a data-link-type="abstract-op" href="#formatter" id="ref-for-formatter④">Formatter</a>(<var>result</var>).</p>
   </ol>
   <h4 class="heading settled" data-level="2.2.1" id="formatting-specifiers"><span class="secno">2.2.1. </span><span class="content">Summary of formatting specifiers</span><a class="self-link" href="#formatting-specifiers"></a></h4>
   <p>The following is an informative summary of the format specifiers processed by the above algorithm.</p>
   <table>
    <thead>
     <tr>
      <th>Specifier
      <th>Purpose
      <th>Type Conversion
    <tbody>
     <tr>
      <td><code>%s</code>
      <td>Element which substitutes is converted to a string
      <td><a data-link-type="idl" href="https://tc39.github.io/ecma262/#sec-string-constructor" id="ref-for-sec-string-constructor①">%String%</a>(<var>element</var>)
     <tr>
      <td><code>%d</code> or <code>%i</code>
      <td>Element which substitutes is converted to an integer
      <td><a data-link-type="dfn" href="https://tc39.github.io/ecma262/#sec-parseint-string-radix" id="ref-for-sec-parseint-string-radix①">%parseInt%</a>(<var>element</var>, 10)
     <tr>
      <td><code>%f</code>
      <td>Element which substitutes is converted to a float
      <td><a data-link-type="dfn" href="https://tc39.github.io/ecma262/#sec-parsefloat-string" id="ref-for-sec-parsefloat-string①">%parseFloat%</a>(<var>element</var>, 10)
     <tr>
      <td><code>%o</code>
      <td>Element is displayed with <a data-link-type="dfn" href="#optimally-useful-formatting" id="ref-for-optimally-useful-formatting②">optimally useful formatting</a>
      <td>n/a
     <tr>
      <td><code>%O</code>
      <td>Element is displayed with <a data-link-type="dfn" href="#generic-javascript-object-formatting" id="ref-for-generic-javascript-object-formatting②">generic JavaScript object formatting</a>
      <td>n/a
     <tr>
      <td><code>%c</code>
      <td>Applies provided CSS
      <td>n/a
   </table>
   <h3 class="heading settled dfn-paneled" data-dfn-type="abstract-op" data-export data-level="2.3" data-lt="Printer" id="printer"><span class="secno">2.3. </span><span class="content">Printer(<var>logLevel</var>, <var>args</var>[, <var>options</var>])</span></h3>
   <p>The printer operation is implementation-defined. It accepts a log level indicating severity, a List
of arguments to print, and an optional object of implementation-specific formatting options.
Elements appearing in <var>args</var> will be one of the following:</p>
   <ul>
    <li data-md>
     <p>JavaScript objects of any type.</p>
    <li data-md>
     <p>Implementation-specific representations of printable things such as a stack trace or <a data-link-type="dfn" href="#concept-group" id="ref-for-concept-group⑥">group</a>.</p>
    <li data-md>
     <p>Objects with either <a data-link-type="dfn" href="#generic-javascript-object-formatting" id="ref-for-generic-javascript-object-formatting③">generic JavaScript object formatting</a> or <a data-link-type="dfn" href="#optimally-useful-formatting" id="ref-for-optimally-useful-formatting③">optimally useful formatting</a> applied.</p>
   </ul>
   <p>If the <var>options</var> object is passed, and is not undefined or null, implementations may use <var>options</var> to apply implementation-specific formatting to the elements in <var>args</var>.</p>
   <p>How the implementation prints <var>args</var> is up to the implementation, but implementations should
separate the objects by a space or something similar, as that has become a developer expectation.</p>
   <p>By the time the printer operation is called, all format specifiers will have been taken into
account, and any arguments that are meant to be consumed by format specifiers will not be present in <var>args</var>. The implementation’s job is simply to print the List. The output produced by calls to
Printer should appear only within the last <a data-link-type="dfn" href="#concept-group" id="ref-for-concept-group⑦">group</a> on the appropriate <a data-link-type="dfn" href="#group-stack" id="ref-for-group-stack⑤">group stack</a> if the <a data-link-type="dfn" href="#group-stack" id="ref-for-group-stack⑥">group stack</a> is not empty, or elsewhere in the console otherwise.</p>
   <p>If the console is not open when the printer operation is called, implementations should buffer
messages to show them in the future up to an implementation-chosen limit (typically on the order of
at least 100).</p>
   <h4 class="heading settled" data-level="2.3.1" id="loglevel-severity"><span class="secno">2.3.1. </span><span class="content">Indicating <var>logLevel</var> severity</span><a class="self-link" href="#loglevel-severity"></a></h4>
   <p>Each <code class="idl"><a data-link-type="idl" href="#namespacedef-console" id="ref-for-namespacedef-console⑦">console</a></code> function uses a unique value for the <var>logLevel</var> parameter when calling
Printer, allowing implementations to customize each printed message depending on the function from
which it originated. However, it is common practice to group together certain functions and treat
their output similarly, in four broad categories. This table summarizes these common groupings:</p>
   <table>
    <thead>
     <tr>
      <th>Grouping
      <th><code class="idl"><a data-link-type="idl" href="#namespacedef-console" id="ref-for-namespacedef-console⑧">console</a></code> functions
      <th>Description
    <tbody>
     <tr>
      <td>log
      <td> <code class="idl"><a data-link-type="idl" href="#log" id="ref-for-log①">log()</a></code>, <code class="idl"><a data-link-type="idl" href="#trace" id="ref-for-trace①">trace()</a></code>, <code class="idl"><a data-link-type="idl" href="#dir" id="ref-for-dir①">dir()</a></code>, <code class="idl"><a data-link-type="idl" href="#dirxml" id="ref-for-dirxml①">dirxml()</a></code>, <code class="idl"><a data-link-type="idl" href="#group" id="ref-for-group①">group()</a></code>, <code class="idl"><a data-link-type="idl" href="#groupcollapsed" id="ref-for-groupcollapsed①">groupCollapsed()</a></code>, <code class="idl"><a data-link-type="idl" href="#debug" id="ref-for-debug①">debug()</a></code>, <code class="idl"><a data-link-type="idl" href="#timelog" id="ref-for-timelog③">timeLog()</a></code> 
      <td> A generic log 
     <tr>
      <td>info
      <td><code class="idl"><a data-link-type="idl" href="#count" id="ref-for-count①">count()</a></code>, <code class="idl"><a data-link-type="idl" href="#info" id="ref-for-info①">info()</a></code>, <code class="idl"><a data-link-type="idl" href="#timeend" id="ref-for-timeend②">timeEnd()</a></code>
      <td> An informative log 
     <tr>
      <td>warn
      <td> <code class="idl"><a data-link-type="idl" href="#warn" id="ref-for-warn①">warn()</a></code>, <code class="idl"><a data-link-type="idl" href="#countreset" id="ref-for-countreset①">countReset()</a></code> 
      <td> A log warning the user of something indicated by the message 
     <tr>
      <td>error
      <td><code class="idl"><a data-link-type="idl" href="#error" id="ref-for-error①">error()</a></code>, <code class="idl"><a data-link-type="idl" href="#assert" id="ref-for-assert①">assert()</a></code>
      <td> A log indicating an error to the user 
   </table>
   <p>These groupings are meant to document common practices, and do not constrain implementations from
providing special behavior for each function, as in the following examples:</p>
   <div class="example" id="timeEnd-formatting">
    <a class="self-link" href="#timeEnd-formatting"></a> Here you can see one implementation chose to make output produced by calls to <code class="idl"><a data-link-type="idl" href="#timeend" id="ref-for-timeend③">timeEnd()</a></code> blue, while leaving <code class="idl"><a data-link-type="idl" href="#info" id="ref-for-info②">info()</a></code> a more neutral color. 
    <p><img alt="A demonstration of timeEnd and info formatting differences" crossorigin src="images/timeEnd-formatting.png"></p>
   </div>
   <div class="example" id="count-output">
    <a class="self-link" href="#count-output"></a> Calls to <code class="idl"><a data-link-type="idl" href="#count" id="ref-for-count②">count()</a></code> might not always print new output, but instead could update
  previously-output counts. 
    <p><img alt="A demonstration of count behavior" crossorigin src="images/edge-Count.png"></p>
   </div>
   <h4 class="heading settled" data-level="2.3.2" id="printer-ux-innovation"><span class="secno">2.3.2. </span><span class="content">Printer user experience innovation</span><a class="self-link" href="#printer-ux-innovation"></a></h4>
   <p>Since <a data-link-type="abstract-op" href="#printer" id="ref-for-printer①①">Printer</a> is implementation-defined, it is common to see UX innovations in
its implementations. The following is a non-exhaustive list of potential UX enhancements:</p>
   <ul>
    <li>
     <p>De-duplication of identical output to prevent spam.</p>
     <div class="example" id="dedupe-example">
      <a class="self-link" href="#dedupe-example"></a> In this example, the implementation not only batches multiple identical messages, but also
      provides the number of messages that have been batched together. 
      <p><img alt="A demonstration of console message de-duplication" crossorigin src="images/dedupe.png"></p>
     </div>
    <li>
     <p>Extra UI off to the side allowing the user to filter messages by log level severity.</p>
     <div class="example" id="severity-filter-example"><a class="self-link" href="#severity-filter-example"></a> <img alt crossorigin src="images/severity-filter.png"> </div>
    <li> Extra UI off to the side indicating the current state of the <a data-link-type="dfn" href="#timer-table" id="ref-for-timer-table⑤">timer table</a>, <a data-link-type="dfn" href="#group-stack" id="ref-for-group-stack⑦">group stack</a>, or other internally maintained data. 
    <li>Flashing portions of the console to alert the user of something important.
   </ul>
   <h4 class="heading settled" data-level="2.3.3" id="object-formats"><span class="secno">2.3.3. </span><span class="content">Common object formats</span><a class="self-link" href="#object-formats"></a></h4>
   <p>Typically objects will be printed in a format that is suitable for their context. This section
describes common ways in which objects are formatted to be most useful in their context. It should
be noted that the formatting described in this section is applied to implementation-specific object
representations that will eventually be passed into <a data-link-type="abstract-op" href="#printer" id="ref-for-printer①②">Printer</a>, where the actual
side effect of formatting will be seen.</p>
   <p>An object with <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="generic-javascript-object-formatting">generic JavaScript object formatting</dfn> is a potentially expandable
representation of a generic JavaScript object. An object with <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="optimally-useful-formatting">optimally useful formatting</dfn> is an implementation-specific, potentially-interactive
representation of an object judged to be maximally useful and informative.</p>
   <h4 class="heading settled" data-level="2.3.4" id="nodejs-printer"><span class="secno">2.3.4. </span><span class="content">Example printer in Node.js</span><a class="self-link" href="#nodejs-printer"></a></h4>
   <div class="example" id="nodejs-printer-example">
    <a class="self-link" href="#nodejs-printer-example"></a> The simplest way to implement the printer operation on the Node.js platform is to join the
  previously formatted arguments separated by a space and write the output to <code>stdout</code> or <code>stderr</code>. 
    <p>Example implementation in Node.js using <a data-link-type="biblio" href="#biblio-ecmascript">[ECMASCRIPT]</a>:</p>
<pre><code class="lang-javascript highlight"><c- kr>const</c-> util <c- o>=</c-> require<c- p>(</c-><c- t>'util'</c-><c- p>);</c->

<c- a>function</c-> print<c- p>(</c->logLevel<c- p>,</c-> <c- p>...</c->args<c- p>)</c-> <c- p>{</c->
  <c- kr>const</c-> message <c- o>=</c-> util<c- p>.</c->format<c- p>(...</c->args<c- p>);</c->

  <c- k>if</c-> <c- p>(</c->logLevel <c- o>===</c-> <c- t>'error'</c-><c- p>)</c-> <c- p>{</c->
    process<c- p>.</c->stderr<c- p>.</c->write<c- p>(</c->message <c- o>+</c-> <c- t>'\n'</c-><c- p>);</c->
  <c- p>}</c-> <c- k>else</c-> <c- k>if</c-> <c- p>(</c->logLevel <c- o>===</c-> <c- t>'log'</c-> <c- o>||</c-> logLevel <c- o>===</c-> <c- t>'info'</c-> <c- o>||</c-> logLevel <c- o>===</c-> <c- t>'warn'</c-><c- p>)</c-> <c- p>{</c->
    process<c- p>.</c->stdout<c- p>.</c->write<c- p>(</c->message <c- o>+</c-> <c- t>'\n'</c-><c- p>);</c->
  <c- p>}</c->
<c- p>}</c->
</code></pre>
    <p>Here a lot of the work is done by the <code>util.format</code> function. It stringifies nested objects, and
  converts non-string arguments into a readable string version, e.g. undefined becomes the string
  "undefined" and false becomes "false":</p>
<pre><code class="lang-javascript highlight">print<c- p>(</c-><c- t>'log'</c-><c- p>,</c-> <c- t>'duck'</c-><c- p>,</c-> <c- p>[{</c->foo<c- o>:</c-> <c- t>'bar'</c-><c- p>}]);</c->     <c- c1>// prints: </c-><code class="highlight"><c- c1>duck <c- p>[</c-> <c- p>{</c-> foo<c- o>:</c-> <c- t>'bar'</c-> <c- p>}</c-> <c- p>]</c->\n</c-></code><c- c1> on stdout</c->
print<c- p>(</c-><c- t>'log'</c-><c- p>,</c-> <c- t>'duck'</c-><c- p>,</c-> <c- kc>false</c-><c- p>);</c->              <c- c1>// prints: </c-><code class="highlight"><c- c1>duck <c- kc>false</c->\n</c-></code><c- c1> on stdout</c->
print<c- p>(</c-><c- t>'log'</c-><c- p>,</c-> <c- t>'duck'</c-><c- p>,</c-> <c- kc>undefined</c-><c- p>);</c->          <c- c1>// prints: </c-><code class="highlight"><c- c1>duck <c- kc>undefined</c->\n</c-></code><c- c1> on stdout</c->
</code></pre>
   </div>
   <h3 class="heading settled" data-level="2.4" id="reporting-warnings"><span class="secno">2.4. </span><span class="content">Reporting warnings to the console</span><a class="self-link" href="#reporting-warnings"></a></h3>
   <p>To <dfn data-dfn-type="dfn" data-export id="report-a-warning-to-the-console">report a warning to the console<a class="self-link" href="#report-a-warning-to-the-console"></a></dfn> given a generic description of a warning <var>description</var>, implementations must run these steps:</p>
   <ol>
    <li data-md>
     <p>Let <var>warning</var> be an implementation-defined string derived from <var>description</var>.</p>
    <li data-md>
     <p>Perform <a data-link-type="abstract-op" href="#printer" id="ref-for-printer①③">Printer</a>("reportWarning", « <var>warning</var> »).</p>
   </ol>
   <h2 class="no-num heading settled" id="acks"><span class="content">Acknowledgments</span><a class="self-link" href="#acks"></a></h2>
   <p>The editors would like to thank
Boris Zbarsky,
Brent S.A. Cowgill,
Brian Grinstead,
Corey Farwell,
Ian Kilpatrick,
Jeff Carpenter,
Joseph Pecoraro,
Justin Woo,
Luc Martin,
Noah Bass,
Paul Irish,
Raphaël, and
Victor Costan
for their contributions to this specification. You are awesome!</p>
   <p>This standard is written by <a href="https://terinstock.com">Terin Stock</a> (<a href="mailto:terin@terinstock.com">terin@terinstock.com</a>), <a href="http://kowalski.gd">Robert Kowalski</a> (<a href="mailto:rok@kowalski.gd">rok@kowalski.gd</a>), and <a href="https://domfarolino.com">Dominic Farolino</a> (<a href="mailto:domfarolino@gmail.com">domfarolino@gmail.com</a>)
with major help from <a href="https://domenic.me/">Domenic Denicola</a> (<a href="https://google.com">Google</a>, <a href="mailto:d@domenic.me">d@domenic.me</a>).</p>
   <p>Copyright © 2020 WHATWG (Apple, Google, Mozilla, Microsoft). This work is licensed under a <a href="https://creativecommons.org/licenses/by/4.0/" rel="license">Creative Commons Attribution
4.0 International License</a>. </p>
  </main>
<script>
"use strict";
if ("serviceWorker" in navigator) {
  navigator.serviceWorker.register("/service-worker.js");
}
</script>
  <h2 class="no-num no-ref heading settled" id="index"><span class="content">Index</span><a class="self-link" href="#index"></a></h2>
  <h3 class="no-num no-ref heading settled" id="index-defined-here"><span class="content">Terms defined by this specification</span><a class="self-link" href="#index-defined-here"></a></h3>
  <ul class="index">
   <li><a href="#assert">assert()</a><span>, in §1.1</span>
   <li><a href="#assert">assert(condition)</a><span>, in §1.1</span>
   <li><a href="#assert">assert(condition, ...data)</a><span>, in §1.1</span>
   <li><a href="#clear">clear()</a><span>, in §1.1.1</span>
   <li><a href="#namespacedef-console">console</a><span>, in §1</span>
   <li><a href="#count">count()</a><span>, in §1.2</span>
   <li><a href="#count">count(label)</a><span>, in §1.2</span>
   <li><a href="#count-map">count map</a><span>, in §1.2</span>
   <li><a href="#countreset">countReset()</a><span>, in §1.2.1</span>
   <li><a href="#countreset">countReset(label)</a><span>, in §1.2.1</span>
   <li><a href="#debug">debug()</a><span>, in §1.1.2</span>
   <li><a href="#debug">debug(...data)</a><span>, in §1.1.2</span>
   <li><a href="#dir">dir()</a><span>, in §1.1.9</span>
   <li><a href="#dir">dir(item)</a><span>, in §1.1.9</span>
   <li><a href="#dir">dir(item, options)</a><span>, in §1.1.9</span>
   <li><a href="#dirxml">dirxml()</a><span>, in §1.1.10</span>
   <li><a href="#dirxml">dirxml(...data)</a><span>, in §1.1.10</span>
   <li><a href="#error">error()</a><span>, in §1.1.3</span>
   <li><a href="#error">error(...data)</a><span>, in §1.1.3</span>
   <li><a href="#formatter">Formatter</a><span>, in §2.1</span>
   <li><a href="#generic-javascript-object-formatting">generic JavaScript object formatting</a><span>, in §2.3.3</span>
   <li><a href="#concept-group">group</a><span>, in §1.3</span>
   <li><a href="#group">group()</a><span>, in §1.3</span>
   <li><a href="#groupcollapsed">groupCollapsed()</a><span>, in §1.3.1</span>
   <li><a href="#groupcollapsed">groupCollapsed(...data)</a><span>, in §1.3.1</span>
   <li><a href="#group">group(...data)</a><span>, in §1.3</span>
   <li><a href="#groupend">groupEnd()</a><span>, in §1.3.2</span>
   <li><a href="#group-stack">group stack</a><span>, in §1.3</span>
   <li><a href="#info">info()</a><span>, in §1.1.4</span>
   <li><a href="#info">info(...data)</a><span>, in §1.1.4</span>
   <li><a href="#log">log()</a><span>, in §1.1.5</span>
   <li><a href="#log">log(...data)</a><span>, in §1.1.5</span>
   <li><a href="#logger">Logger</a><span>, in §2</span>
   <li><a href="#optimally-useful-formatting">optimally useful formatting</a><span>, in §2.3.3</span>
   <li><a href="#printer">Printer</a><span>, in §2.2.1</span>
   <li><a href="#report-a-warning-to-the-console">report a warning to the console</a><span>, in §2.4</span>
   <li><a href="#table">table()</a><span>, in §1.1.6</span>
   <li><a href="#table">table(tabularData)</a><span>, in §1.1.6</span>
   <li><a href="#table">table(tabularData, properties)</a><span>, in §1.1.6</span>
   <li><a href="#time">time()</a><span>, in §1.4</span>
   <li><a href="#timeend">timeEnd()</a><span>, in §1.4.2</span>
   <li><a href="#timeend">timeEnd(label)</a><span>, in §1.4.2</span>
   <li><a href="#time">time(label)</a><span>, in §1.4</span>
   <li><a href="#timelog">timeLog()</a><span>, in §1.4.1</span>
   <li><a href="#timelog">timeLog(label)</a><span>, in §1.4.1</span>
   <li><a href="#timelog">timeLog(label, ...data)</a><span>, in §1.4.1</span>
   <li><a href="#timer-table">timer table</a><span>, in §1.4</span>
   <li><a href="#trace">trace()</a><span>, in §1.1.7</span>
   <li><a href="#trace">trace(...data)</a><span>, in §1.1.7</span>
   <li><a href="#warn">warn()</a><span>, in §1.1.8</span>
   <li><a href="#warn">warn(...data)</a><span>, in §1.1.8</span>
  </ul>
  <aside class="dfn-panel" data-for="term-for-sec-properties-of-the-object-prototype-object">
   <a href="https://tc39.github.io/ecma262/#sec-properties-of-the-object-prototype-object">https://tc39.github.io/ecma262/#sec-properties-of-the-object-prototype-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-sec-properties-of-the-object-prototype-object">1. Namespace console</a> <a href="#ref-for-sec-properties-of-the-object-prototype-object①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-sec-string-constructor">
   <a href="https://tc39.github.io/ecma262/#sec-string-constructor">https://tc39.github.io/ecma262/#sec-string-constructor</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-sec-string-constructor">2.2. Formatter(args)</a>
    <li><a href="#ref-for-sec-string-constructor①">2.2.1. Summary of formatting specifiers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-sec-parsefloat-string">
   <a href="https://tc39.github.io/ecma262/#sec-parsefloat-string">https://tc39.github.io/ecma262/#sec-parsefloat-string</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-sec-parsefloat-string">2.2. Formatter(args)</a>
    <li><a href="#ref-for-sec-parsefloat-string①">2.2.1. Summary of formatting specifiers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-sec-parseint-string-radix">
   <a href="https://tc39.github.io/ecma262/#sec-parseint-string-radix">https://tc39.github.io/ecma262/#sec-parseint-string-radix</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-sec-parseint-string-radix">2.2. Formatter(args)</a>
    <li><a href="#ref-for-sec-parseint-string-radix①">2.2.1. Summary of formatting specifiers</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-sec-call">
   <a href="https://tc39.github.io/ecma262/#sec-call">https://tc39.github.io/ecma262/#sec-call</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-sec-call">2.2. Formatter(args)</a> <a href="#ref-for-sec-call①">(2)</a> <a href="#ref-for-sec-call②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-sec-objectcreate">
   <a href="https://tc39.github.io/ecma262/#sec-objectcreate">https://tc39.github.io/ecma262/#sec-objectcreate</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-sec-objectcreate">1. Namespace console</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-sec-tostring">
   <a href="https://tc39.github.io/ecma262/#sec-tostring">https://tc39.github.io/ecma262/#sec-tostring</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-sec-tostring">1.2.1. count(label)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-sec-ecmascript-data-types-and-values">
   <a href="https://tc39.github.io/ecma262/#sec-ecmascript-data-types-and-values">https://tc39.github.io/ecma262/#sec-ecmascript-data-types-and-values</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-sec-ecmascript-data-types-and-values">1.1.1. assert(condition, ...data)</a>
    <li><a href="#ref-for-sec-ecmascript-data-types-and-values①">2.2. Formatter(args)</a> <a href="#ref-for-sec-ecmascript-data-types-and-values②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-append">
   <a href="https://infra.spec.whatwg.org/#list-append">https://infra.spec.whatwg.org/#list-append</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-append">1.1.1. assert(condition, ...data)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-map-exists">
   <a href="https://infra.spec.whatwg.org/#map-exists">https://infra.spec.whatwg.org/#map-exists</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-map-exists">1.2.1. count(label)</a>
    <li><a href="#ref-for-map-exists①">1.2.2. countReset(label)</a>
    <li><a href="#ref-for-map-exists②">1.4.1. time(label)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-empty">
   <a href="https://infra.spec.whatwg.org/#list-empty">https://infra.spec.whatwg.org/#list-empty</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-empty">1.1.2. clear()</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-map-exists">
   <a href="https://infra.spec.whatwg.org/#map-exists">https://infra.spec.whatwg.org/#map-exists</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-map-exists">1.2.1. count(label)</a>
    <li><a href="#ref-for-map-exists①">1.2.2. countReset(label)</a>
    <li><a href="#ref-for-map-exists②">1.4.1. time(label)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-iterate">
   <a href="https://infra.spec.whatwg.org/#list-iterate">https://infra.spec.whatwg.org/#list-iterate</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-iterate">1.1.11. dirxml(...data)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-is-empty">
   <a href="https://infra.spec.whatwg.org/#list-is-empty">https://infra.spec.whatwg.org/#list-is-empty</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-is-empty">1.1.1. assert(condition, ...data)</a>
    <li><a href="#ref-for-list-is-empty①">1.3.1. group(...data)</a>
    <li><a href="#ref-for-list-is-empty②">2.1. Logger(logLevel, args)</a> <a href="#ref-for-list-is-empty③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list">
   <a href="https://infra.spec.whatwg.org/#list">https://infra.spec.whatwg.org/#list</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list">1.1.11. dirxml(...data)</a>
    <li><a href="#ref-for-list①">2.1. Logger(logLevel, args)</a>
    <li><a href="#ref-for-list②">2.2. Formatter(args)</a> <a href="#ref-for-list③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ordered-map">
   <a href="https://infra.spec.whatwg.org/#ordered-map">https://infra.spec.whatwg.org/#ordered-map</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ordered-map">1.2. Counting functions</a>
    <li><a href="#ref-for-ordered-map①">1.4. Timing functions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-stack-pop">
   <a href="https://infra.spec.whatwg.org/#stack-pop">https://infra.spec.whatwg.org/#stack-pop</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-stack-pop">1.3.3. groupEnd()</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-prepend">
   <a href="https://infra.spec.whatwg.org/#list-prepend">https://infra.spec.whatwg.org/#list-prepend</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-prepend">1.1.1. assert(condition, ...data)</a>
    <li><a href="#ref-for-list-prepend①">1.4.2. timeLog(label, ...data)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-stack-push">
   <a href="https://infra.spec.whatwg.org/#stack-push">https://infra.spec.whatwg.org/#stack-push</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-stack-push">1.3.1. group(...data)</a>
    <li><a href="#ref-for-stack-push①">1.3.2. groupCollapsed(...data)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-map-remove">
   <a href="https://infra.spec.whatwg.org/#map-remove">https://infra.spec.whatwg.org/#map-remove</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-map-remove">1.4.3. timeEnd(label)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-map-set">
   <a href="https://infra.spec.whatwg.org/#map-set">https://infra.spec.whatwg.org/#map-set</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-map-set">1.2.1. count(label)</a> <a href="#ref-for-map-set①">(2)</a>
    <li><a href="#ref-for-map-set②">1.2.2. countReset(label)</a>
    <li><a href="#ref-for-map-set③">1.4.1. time(label)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-size">
   <a href="https://infra.spec.whatwg.org/#list-size">https://infra.spec.whatwg.org/#list-size</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-size">2.2. Formatter(args)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-stack">
   <a href="https://infra.spec.whatwg.org/#stack">https://infra.spec.whatwg.org/#stack</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-stack">1.3. Grouping functions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-string">
   <a href="https://infra.spec.whatwg.org/#string">https://infra.spec.whatwg.org/#string</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-string">1.2. Counting functions</a>
    <li><a href="#ref-for-string①">1.4. Timing functions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-DOMString">
   <a href="https://heycam.github.io/webidl/#idl-DOMString">https://heycam.github.io/webidl/#idl-DOMString</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-DOMString">1. Namespace console</a> <a href="#ref-for-idl-DOMString①">(2)</a> <a href="#ref-for-idl-DOMString②">(3)</a> <a href="#ref-for-idl-DOMString③">(4)</a> <a href="#ref-for-idl-DOMString④">(5)</a> <a href="#ref-for-idl-DOMString⑤">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-Exposed">
   <a href="https://heycam.github.io/webidl/#Exposed">https://heycam.github.io/webidl/#Exposed</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Exposed">1. Namespace console</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-boolean">
   <a href="https://heycam.github.io/webidl/#idl-boolean">https://heycam.github.io/webidl/#idl-boolean</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-boolean">1. Namespace console</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dfn-namespace-object">
   <a href="https://heycam.github.io/webidl/#dfn-namespace-object">https://heycam.github.io/webidl/#dfn-namespace-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-namespace-object">1. Namespace console</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-object">
   <a href="https://heycam.github.io/webidl/#idl-object">https://heycam.github.io/webidl/#idl-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-object">1. Namespace console</a>
   </ul>
  </aside>
  <h3 class="no-num no-ref heading settled" id="index-defined-elsewhere"><span class="content">Terms defined by reference</span><a class="self-link" href="#index-defined-elsewhere"></a></h3>
  <ul class="index">
   <li>
    <a data-link-type="biblio">[ECMASCRIPT]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-sec-properties-of-the-object-prototype-object" style="color:initial">%ObjectPrototype%</span>
     <li><span class="dfn-paneled" id="term-for-sec-string-constructor" style="color:initial">%String%</span>
     <li><span class="dfn-paneled" id="term-for-sec-parsefloat-string" style="color:initial">%parsefloat%</span>
     <li><span class="dfn-paneled" id="term-for-sec-parseint-string-radix" style="color:initial">%parseint%</span>
     <li><span class="dfn-paneled" id="term-for-sec-call" style="color:initial">Call</span>
     <li><span class="dfn-paneled" id="term-for-sec-objectcreate" style="color:initial">ObjectCreate</span>
     <li><span class="dfn-paneled" id="term-for-sec-tostring" style="color:initial">ToString</span>
     <li><span class="dfn-paneled" id="term-for-sec-ecmascript-data-types-and-values" style="color:initial">Type</span>
    </ul>
   <li>
    <a data-link-type="biblio">[INFRA]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-list-append" style="color:initial">append</span>
     <li><span class="dfn-paneled" id="term-for-map-exists" style="color:initial">contain</span>
     <li><span class="dfn-paneled" id="term-for-list-empty" style="color:initial">empty</span>
     <li><span class="dfn-paneled" id="term-for-map-exists①" style="color:initial">exist</span>
     <li><span class="dfn-paneled" id="term-for-list-iterate" style="color:initial">for each</span>
     <li><span class="dfn-paneled" id="term-for-list-is-empty" style="color:initial">is empty</span>
     <li><span class="dfn-paneled" id="term-for-list" style="color:initial">list</span>
     <li><span class="dfn-paneled" id="term-for-ordered-map" style="color:initial">map</span>
     <li><span class="dfn-paneled" id="term-for-stack-pop" style="color:initial">pop</span>
     <li><span class="dfn-paneled" id="term-for-list-prepend" style="color:initial">prepend</span>
     <li><span class="dfn-paneled" id="term-for-stack-push" style="color:initial">push</span>
     <li><span class="dfn-paneled" id="term-for-map-remove" style="color:initial">remove</span>
     <li><span class="dfn-paneled" id="term-for-map-set" style="color:initial">set</span>
     <li><span class="dfn-paneled" id="term-for-list-size" style="color:initial">size</span>
     <li><span class="dfn-paneled" id="term-for-stack" style="color:initial">stack</span>
     <li><span class="dfn-paneled" id="term-for-string" style="color:initial">string</span>
    </ul>
   <li>
    <a data-link-type="biblio">[WebIDL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-idl-DOMString" style="color:initial">DOMString</span>
     <li><span class="dfn-paneled" id="term-for-Exposed" style="color:initial">Exposed</span>
     <li><span class="dfn-paneled" id="term-for-idl-boolean" style="color:initial">boolean</span>
     <li><span class="dfn-paneled" id="term-for-dfn-namespace-object" style="color:initial">namespace object</span>
     <li><span class="dfn-paneled" id="term-for-idl-object" style="color:initial">object</span>
    </ul>
  </ul>
  <h2 class="no-num no-ref heading settled" id="references"><span class="content">References</span><a class="self-link" href="#references"></a></h2>
  <h3 class="no-num no-ref heading settled" id="normative"><span class="content">Normative References</span><a class="self-link" href="#normative"></a></h3>
  <dl>
   <dt id="biblio-ecmascript">[ECMASCRIPT]
   <dd><a href="https://tc39.es/ecma262/">ECMAScript Language Specification</a>. URL: <a href="https://tc39.es/ecma262/">https://tc39.es/ecma262/</a>
   <dt id="biblio-infra">[INFRA]
   <dd>Anne van Kesteren; Domenic Denicola. <a href="https://infra.spec.whatwg.org/">Infra Standard</a>. Living Standard. URL: <a href="https://infra.spec.whatwg.org/">https://infra.spec.whatwg.org/</a>
   <dt id="biblio-webidl">[WebIDL]
   <dd>Boris Zbarsky. <a href="https://heycam.github.io/webidl/">Web IDL</a>. URL: <a href="https://heycam.github.io/webidl/">https://heycam.github.io/webidl/</a>
  </dl>
  <h2 class="no-num no-ref heading settled" id="idl-index"><span class="content">IDL Index</span><a class="self-link" href="#idl-index"></a></h2>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=(<c- n>Window</c->,<c- n>Worker</c->,<c- n>Worklet</c->)]
<c- b>namespace</c-> <a href="#namespacedef-console"><code><c- g>console</c-></code></a> { // but see namespace object requirements below
  // Logging
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#assert"><c- g>assert</c-></a>(<c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a href="#dom-console-assert-condition-data-condition"><code><c- g>condition</c-></code></a> = <c- b>false</c->, <c- b>any</c->... <a href="#dom-console-assert-condition-data-data"><code><c- g>data</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#clear"><c- g>clear</c-></a>();
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#debug"><c- g>debug</c-></a>(<c- b>any</c->... <a href="#dom-console-debug-data-data"><code><c- g>data</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#error"><c- g>error</c-></a>(<c- b>any</c->... <a href="#dom-console-error-data-data"><code><c- g>data</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#info"><c- g>info</c-></a>(<c- b>any</c->... <a href="#dom-console-info-data-data"><code><c- g>data</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#log"><c- g>log</c-></a>(<c- b>any</c->... <a href="#dom-console-log-data-data"><code><c- g>data</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#table"><c- g>table</c-></a>(<c- b>optional</c-> <c- b>any</c-> <a href="#dom-console-table-tabulardata-properties-tabulardata"><code><c- g>tabularData</c-></code></a>, <c- b>optional</c-> <c- b>sequence</c->&lt;<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString"><c- b>DOMString</c-></a>> <a href="#dom-console-table-tabulardata-properties-properties"><code><c- g>properties</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#trace"><c- g>trace</c-></a>(<c- b>any</c->... <a href="#dom-console-trace-data-data"><code><c- g>data</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#warn"><c- g>warn</c-></a>(<c- b>any</c->... <a href="#dom-console-warn-data-data"><code><c- g>data</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dir"><c- g>dir</c-></a>(<c- b>optional</c-> <c- b>any</c-> <a href="#dom-console-dir-item-options-item"><code><c- g>item</c-></code></a>, <c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-object"><c- b>object</c-></a>? <a href="#dom-console-dir-item-options-options"><code><c- g>options</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dirxml"><c- g>dirxml</c-></a>(<c- b>any</c->... <a href="#dom-console-dirxml-data-data"><code><c- g>data</c-></code></a>);

  // Counting
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#count"><c- g>count</c-></a>(<c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString"><c- b>DOMString</c-></a> <a href="#dom-console-count-label-label"><code><c- g>label</c-></code></a> = "default");
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#countreset"><c- g>countReset</c-></a>(<c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString"><c- b>DOMString</c-></a> <a href="#dom-console-countreset-label-label"><code><c- g>label</c-></code></a> = "default");

  // Grouping
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#group"><c- g>group</c-></a>(<c- b>any</c->... <a href="#dom-console-group-data-data"><code><c- g>data</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#groupcollapsed"><c- g>groupCollapsed</c-></a>(<c- b>any</c->... <a href="#dom-console-groupcollapsed-data-data"><code><c- g>data</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#groupend"><c- g>groupEnd</c-></a>();

  // Timing
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#time"><c- g>time</c-></a>(<c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString"><c- b>DOMString</c-></a> <a href="#dom-console-time-label-label"><code><c- g>label</c-></code></a> = "default");
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#timelog"><c- g>timeLog</c-></a>(<c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString"><c- b>DOMString</c-></a> <a href="#dom-console-timelog-label-data-label"><code><c- g>label</c-></code></a> = "default", <c- b>any</c->... <a href="#dom-console-timelog-label-data-data"><code><c- g>data</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#timeend"><c- g>timeEnd</c-></a>(<c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString"><c- b>DOMString</c-></a> <a href="#dom-console-timeend-label-label"><code><c- g>label</c-></code></a> = "default");
};

</pre>
  <aside class="dfn-panel" data-for="namespacedef-console">
   <b><a href="#namespacedef-console">#namespacedef-console</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-namespacedef-console">1. Namespace console</a> <a href="#ref-for-namespacedef-console①">(2)</a> <a href="#ref-for-namespacedef-console②">(3)</a> <a href="#ref-for-namespacedef-console③">(4)</a>
    <li><a href="#ref-for-namespacedef-console④">1.2. Counting functions</a>
    <li><a href="#ref-for-namespacedef-console⑤">1.3. Grouping functions</a>
    <li><a href="#ref-for-namespacedef-console⑥">1.4. Timing functions</a>
    <li><a href="#ref-for-namespacedef-console⑦">2.3.1. Indicating logLevel severity</a> <a href="#ref-for-namespacedef-console⑧">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="assert">
   <b><a href="#assert">#assert</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-assert">1. Namespace console</a>
    <li><a href="#ref-for-assert①">2.3.1. Indicating logLevel severity</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="clear">
   <b><a href="#clear">#clear</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-clear">1. Namespace console</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="debug">
   <b><a href="#debug">#debug</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-debug">1. Namespace console</a>
    <li><a href="#ref-for-debug①">2.3.1. Indicating logLevel severity</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="error">
   <b><a href="#error">#error</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-error">1. Namespace console</a>
    <li><a href="#ref-for-error①">2.3.1. Indicating logLevel severity</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="info">
   <b><a href="#info">#info</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-info">1. Namespace console</a>
    <li><a href="#ref-for-info①">2.3.1. Indicating logLevel severity</a> <a href="#ref-for-info②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="log">
   <b><a href="#log">#log</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-log">1. Namespace console</a>
    <li><a href="#ref-for-log①">2.3.1. Indicating logLevel severity</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="table">
   <b><a href="#table">#table</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-table">1. Namespace console</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="trace">
   <b><a href="#trace">#trace</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-trace">1. Namespace console</a>
    <li><a href="#ref-for-trace①">2.3.1. Indicating logLevel severity</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="warn">
   <b><a href="#warn">#warn</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-warn">1. Namespace console</a>
    <li><a href="#ref-for-warn①">2.3.1. Indicating logLevel severity</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dir">
   <b><a href="#dir">#dir</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dir">1. Namespace console</a>
    <li><a href="#ref-for-dir①">2.3.1. Indicating logLevel severity</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dirxml">
   <b><a href="#dirxml">#dirxml</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dirxml">1. Namespace console</a>
    <li><a href="#ref-for-dirxml①">2.3.1. Indicating logLevel severity</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="count-map">
   <b><a href="#count-map">#count-map</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-count-map">1.2.1. count(label)</a>
    <li><a href="#ref-for-count-map①">1.2.2. countReset(label)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="count">
   <b><a href="#count">#count</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-count">1. Namespace console</a>
    <li><a href="#ref-for-count①">2.3.1. Indicating logLevel severity</a> <a href="#ref-for-count②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="countreset">
   <b><a href="#countreset">#countreset</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-countreset">1. Namespace console</a>
    <li><a href="#ref-for-countreset①">2.3.1. Indicating logLevel severity</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-group">
   <b><a href="#concept-group">#concept-group</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-group">1.3. Grouping functions</a>
    <li><a href="#ref-for-concept-group①">1.3.1. group(...data)</a> <a href="#ref-for-concept-group②">(2)</a>
    <li><a href="#ref-for-concept-group③">1.3.2. groupCollapsed(...data)</a> <a href="#ref-for-concept-group④">(2)</a>
    <li><a href="#ref-for-concept-group⑤">1.3.3. groupEnd()</a>
    <li><a href="#ref-for-concept-group⑥">2.3. Printer(logLevel, args[, options])</a> <a href="#ref-for-concept-group⑦">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="group-stack">
   <b><a href="#group-stack">#group-stack</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-group-stack">1.1.2. clear()</a>
    <li><a href="#ref-for-group-stack①">1.3. Grouping functions</a>
    <li><a href="#ref-for-group-stack②">1.3.1. group(...data)</a>
    <li><a href="#ref-for-group-stack③">1.3.2. groupCollapsed(...data)</a>
    <li><a href="#ref-for-group-stack④">1.3.3. groupEnd()</a>
    <li><a href="#ref-for-group-stack⑤">2.3. Printer(logLevel, args[, options])</a> <a href="#ref-for-group-stack⑥">(2)</a>
    <li><a href="#ref-for-group-stack⑦">2.3.2. Printer user experience innovation</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="group">
   <b><a href="#group">#group</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-group">1. Namespace console</a>
    <li><a href="#ref-for-group①">2.3.1. Indicating logLevel severity</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="groupcollapsed">
   <b><a href="#groupcollapsed">#groupcollapsed</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-groupcollapsed">1. Namespace console</a>
    <li><a href="#ref-for-groupcollapsed①">2.3.1. Indicating logLevel severity</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="groupend">
   <b><a href="#groupend">#groupend</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-groupend">1. Namespace console</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="timer-table">
   <b><a href="#timer-table">#timer-table</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-timer-table">1.4.1. time(label)</a> <a href="#ref-for-timer-table①">(2)</a>
    <li><a href="#ref-for-timer-table②">1.4.2. timeLog(label, ...data)</a>
    <li><a href="#ref-for-timer-table③">1.4.3. timeEnd(label)</a> <a href="#ref-for-timer-table④">(2)</a>
    <li><a href="#ref-for-timer-table⑤">2.3.2. Printer user experience innovation</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="time">
   <b><a href="#time">#time</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-time">1. Namespace console</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="timelog">
   <b><a href="#timelog">#timelog</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-timelog">1. Namespace console</a>
    <li><a href="#ref-for-timelog①">1.4.2. timeLog(label, ...data)</a>
    <li><a href="#ref-for-timelog②">1.4.3. timeEnd(label)</a>
    <li><a href="#ref-for-timelog③">2.3.1. Indicating logLevel severity</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="timeend">
   <b><a href="#timeend">#timeend</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-timeend">1. Namespace console</a>
    <li><a href="#ref-for-timeend①">1.4.3. timeEnd(label)</a>
    <li><a href="#ref-for-timeend②">2.3.1. Indicating logLevel severity</a> <a href="#ref-for-timeend③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="logger">
   <b><a href="#logger">#logger</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-logger">1.1.1. assert(condition, ...data)</a>
    <li><a href="#ref-for-logger①">1.1.3. debug(...data)</a>
    <li><a href="#ref-for-logger②">1.1.4. error(...data)</a>
    <li><a href="#ref-for-logger③">1.1.5. info(...data)</a>
    <li><a href="#ref-for-logger④">1.1.6. log(...data)</a>
    <li><a href="#ref-for-logger⑤">1.1.9. warn(...data)</a>
    <li><a href="#ref-for-logger⑥">1.1.11. dirxml(...data)</a>
    <li><a href="#ref-for-logger⑦">1.2.1. count(label)</a>
    <li><a href="#ref-for-logger⑧">1.2.2. countReset(label)</a>
    <li><a href="#ref-for-logger⑨">1.4.2. timeLog(label, ...data)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="formatter">
   <b><a href="#formatter">#formatter</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-formatter">1.1.8. trace(...data)</a>
    <li><a href="#ref-for-formatter①">1.3.1. group(...data)</a>
    <li><a href="#ref-for-formatter②">1.3.2. groupCollapsed(...data)</a>
    <li><a href="#ref-for-formatter③">2.1. Logger(logLevel, args)</a>
    <li><a href="#ref-for-formatter④">2.2. Formatter(args)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="printer">
   <b><a href="#printer">#printer</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-printer">1.1.8. trace(...data)</a>
    <li><a href="#ref-for-printer①">1.1.10. dir(item, options)</a>
    <li><a href="#ref-for-printer②">1.3. Grouping functions</a> <a href="#ref-for-printer③">(2)</a>
    <li><a href="#ref-for-printer④">1.3.1. group(...data)</a>
    <li><a href="#ref-for-printer⑤">1.3.2. groupCollapsed(...data)</a>
    <li><a href="#ref-for-printer⑥">1.4.2. timeLog(label, ...data)</a>
    <li><a href="#ref-for-printer⑦">1.4.3. timeEnd(label)</a>
    <li><a href="#ref-for-printer⑧">2.1. Logger(logLevel, args)</a> <a href="#ref-for-printer⑨">(2)</a> <a href="#ref-for-printer①⓪">(3)</a>
    <li><a href="#ref-for-printer①①">2.3.2. Printer user experience innovation</a>
    <li><a href="#ref-for-printer①②">2.3.3. Common object formats</a>
    <li><a href="#ref-for-printer①③">2.4. Reporting warnings to the console</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="generic-javascript-object-formatting">
   <b><a href="#generic-javascript-object-formatting">#generic-javascript-object-formatting</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-generic-javascript-object-formatting">1.1.10. dir(item, options)</a>
    <li><a href="#ref-for-generic-javascript-object-formatting①">2.2. Formatter(args)</a>
    <li><a href="#ref-for-generic-javascript-object-formatting②">2.2.1. Summary of formatting specifiers</a>
    <li><a href="#ref-for-generic-javascript-object-formatting③">2.3. Printer(logLevel, args[, options])</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="optimally-useful-formatting">
   <b><a href="#optimally-useful-formatting">#optimally-useful-formatting</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-optimally-useful-formatting">1.1.11. dirxml(...data)</a>
    <li><a href="#ref-for-optimally-useful-formatting①">2.2. Formatter(args)</a>
    <li><a href="#ref-for-optimally-useful-formatting②">2.2.1. Summary of formatting specifiers</a>
    <li><a href="#ref-for-optimally-useful-formatting③">2.3. Printer(logLevel, args[, options])</a>
   </ul>
  </aside>
<script>/* script-dfn-panel */

document.body.addEventListener("click", function(e) {
    var queryAll = function(sel) { return [].slice.call(document.querySelectorAll(sel)); }
    // Find the dfn element or panel, if any, that was clicked on.
    var el = e.target;
    var target;
    var hitALink = false;
    while(el.parentElement) {
        if(el.tagName == "A") {
            // Clicking on a link in a <dfn> shouldn't summon the panel
            hitALink = true;
        }
        if(el.classList.contains("dfn-paneled")) {
            target = "dfn";
            break;
        }
        if(el.classList.contains("dfn-panel")) {
            target = "dfn-panel";
            break;
        }
        el = el.parentElement;
    }
    if(target != "dfn-panel") {
        // Turn off any currently "on" or "activated" panels.
        queryAll(".dfn-panel.on, .dfn-panel.activated").forEach(function(el){
            el.classList.remove("on");
            el.classList.remove("activated");
        });
    }
    if(target == "dfn" && !hitALink) {
        // open the panel
        var dfnPanel = document.querySelector(".dfn-panel[data-for='" + el.id + "']");
        if(dfnPanel) {
            dfnPanel.classList.add("on");
            var rect = el.getBoundingClientRect();
            dfnPanel.style.left = window.scrollX + rect.right + 5 + "px";
            dfnPanel.style.top = window.scrollY + rect.top + "px";
            var panelRect = dfnPanel.getBoundingClientRect();
            var panelWidth = panelRect.right - panelRect.left;
            if(panelRect.right > document.body.scrollWidth && (rect.left - (panelWidth + 5)) > 0) {
                // Reposition, because the panel is overflowing
                dfnPanel.style.left = window.scrollX + rect.left - (panelWidth + 5) + "px";
            }
        } else {
            console.log("Couldn't find .dfn-panel[data-for='" + el.id + "']");
        }
    } else if(target == "dfn-panel") {
        // Switch it to "activated" state, which pins it.
        el.classList.add("activated");
        el.style.left = null;
        el.style.top = null;
    }

});
</script>