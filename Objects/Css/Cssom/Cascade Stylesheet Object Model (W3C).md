<!doctype html><html lang="en">
 <head>
  <meta content="text/html; charset=utf-8" http-equiv="Content-Type">
  <title>CSS Object Model (CSSOM)</title>
  <meta content="width=device-width, initial-scale=1, shrink-to-fit=no" name="viewport">
  <meta content="exploring" name="csswg-work-status">
  <meta content="ED" name="w3c-status">
  <meta content="CSSOM defines APIs (including generic parsing and serialization rules) for Media Queries, Selectors, and of course CSS itself." name="abstract">
  <link href="../default.css" rel="stylesheet" type="text/css">
  <link href="../csslogo.ico" rel="shortcut icon" type="image/x-icon">
<style>
  body {
    background: url("https://www.w3.org/StyleSheets/TR/logo-ED") top left no-repeat;
  }
  </style>
  <meta content="Bikeshed version d4d56a96, updated Fri Apr 10 11:10:34 2020 -0700" name="generator">
  <link href="https://www.w3.org/TR/cssom-1/" rel="canonical">
<script defer src="https://test.csswg.org/harness/annotate.js#!cssom-1_dev/cssom-1" type="text/javascript"></script>
<style>/* style-autolinks */

.css.css, .property.property, .descriptor.descriptor {
    color: #005a9c;
    font-size: inherit;
    font-family: inherit;
}
.css::before, .property::before, .descriptor::before {
    content: "‘";
}
.css::after, .property::after, .descriptor::after {
    content: "’";
}
.property, .descriptor {
    /* Don't wrap property and descriptor names */
    white-space: nowrap;
}
.type { /* CSS value <type> */
    font-style: italic;
}
pre .property::before, pre .property::after {
    content: "";
}
[data-link-type="property"]::before,
[data-link-type="propdesc"]::before,
[data-link-type="descriptor"]::before,
[data-link-type="value"]::before,
[data-link-type="function"]::before,
[data-link-type="at-rule"]::before,
[data-link-type="selector"]::before,
[data-link-type="maybe"]::before {
    content: "‘";
}
[data-link-type="property"]::after,
[data-link-type="propdesc"]::after,
[data-link-type="descriptor"]::after,
[data-link-type="value"]::after,
[data-link-type="function"]::after,
[data-link-type="at-rule"]::after,
[data-link-type="selector"]::after,
[data-link-type="maybe"]::after {
    content: "’";
}

[data-link-type].production::before,
[data-link-type].production::after,
.prod [data-link-type]::before,
.prod [data-link-type]::after {
    content: "";
}

[data-link-type=element],
[data-link-type=element-attr] {
    font-family: Menlo, Consolas, "DejaVu Sans Mono", monospace;
    font-size: .9em;
}
[data-link-type=element]::before { content: "<" }
[data-link-type=element]::after  { content: ">" }

[data-link-type=biblio] {
    white-space: pre;
}</style>
<style>/* style-counters */

body {
    counter-reset: example figure issue;
}
.issue {
    counter-increment: issue;
}
.issue:not(.no-marker)::before {
    content: "Issue " counter(issue);
}

.example {
    counter-increment: example;
}
.example:not(.no-marker)::before {
    content: "Example " counter(example);
}
.invalid.example:not(.no-marker)::before,
.illegal.example:not(.no-marker)::before {
    content: "Invalid Example" counter(example);
}

figcaption {
    counter-increment: figure;
}
figcaption:not(.no-marker)::before {
    content: "Figure " counter(figure) " ";
}</style>
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
<style>/* style-md-lists */

/* This is a weird hack for me not yet following the commonmark spec
   regarding paragraph and lists. */
[data-md] > :first-child {
    margin-top: 0;
}
[data-md] > :last-child {
    margin-bottom: 0;
}</style>
<style>/* style-mdn-anno */

            @media (max-width: 767px) { .mdn-anno { opacity: .1 } }
            .mdn-anno { font: 1em sans-serif; padding: 0.3em; position: absolute; z-index: 8; right: 0.3em; background: #EEE; color: black; box-shadow: 0 0 3px #999; overflow: hidden; border-collapse: initial; border-spacing: initial; min-width: 9em; max-width: min-content; white-space: nowrap; word-wrap: normal; hyphens: none}
            .mdn-anno:not(.wrapped) { opacity: 1}
            .mdn-anno:hover { z-index: 9 }
            .mdn-anno.wrapped { min-width: 0 }
            .mdn-anno.wrapped > :not(button) { display: none; }
            .mdn-anno > .mdn-anno-btn { cursor: pointer; border: none; color: #000; background: transparent; margin: -8px; float: right; padding: 10px 8px 8px 8px; outline: none; }
            .mdn-anno > .mdn-anno-btn > .less-than-two-engines-flag { color: red; padding-right: 2px; }
            .mdn-anno > .mdn-anno-btn > .all-engines-flag { color: green; padding-right: 2px; }
            .mdn-anno > .mdn-anno-btn > span { color: #fff; background-color: #000; font-weight: normal; font-family: zillaslab, Palatino, "Palatino Linotype", serif; padding: 2px 3px 0px 3px; line-height: 1.3em; vertical-align: top; }
            .mdn-anno > .feature { margin-top: 20px; }
            .mdn-anno > .feature:not(:first-of-type) { border-top: 1px solid #999; margin-top: 6px; padding-top: 2px; }
            .mdn-anno > .feature > .less-than-two-engines-text { color: red }
            .mdn-anno > .feature > .all-engines-text { color: green }
            .mdn-anno > .feature > p { font-size: .75em; margin-top: 6px; margin-bottom: 0; }
            .mdn-anno > .feature > p + p { margin-top: 3px; }
            .mdn-anno > .feature > .support { display: block; font-size: 0.6em; margin: 0; padding: 0; margin-top: 2px }
            .mdn-anno > .feature > .support + div { padding-top: 0.5em; }
            .mdn-anno > .feature > .support > hr { display: block; border: none; border-top: 1px dotted #999; padding: 3px 0px 0px 0px; margin: 2px 3px 0px 3px; }
            .mdn-anno > .feature > .support > hr::before { content: ""; }
            .mdn-anno > .feature > .support > span { padding: 0.2em 0; display: block; display: table; }
            .mdn-anno > .feature > .support > span.no { color: #CCCCCC; filter: grayscale(100%); }
            .mdn-anno > .feature > .support > span.no::before { opacity: 0.5; }
            .mdn-anno > .feature > .support > span:first-of-type { padding-top: 0.5em; }
            .mdn-anno > .feature > .support > span > span { padding: 0 0.5em; display: table-cell; }
            .mdn-anno > .feature > .support > span > span:first-child { width: 100%; }
            .mdn-anno > .feature > .support > span > span:last-child { width: 100%; white-space: pre; padding: 0; }
            .mdn-anno > .feature > .support > span::before { content: ' '; display: table-cell; min-width: 1.5em; height: 1.5em; background: no-repeat center center; background-size: contain; text-align: right; font-size: 0.75em; font-weight: bold; }
            .mdn-anno > .feature > .support > .chrome_android::before { background-image: url(https://resources.whatwg.org/browser-logos/chrome.svg); }
            .mdn-anno > .feature > .support > .firefox_android::before { background-image: url(https://resources.whatwg.org/browser-logos/firefox.png); }
            .mdn-anno > .feature > .support > .chrome::before { background-image: url(https://resources.whatwg.org/browser-logos/chrome.svg); }
            .mdn-anno > .feature > .support > .edge_blink::before { background-image: url(https://resources.whatwg.org/browser-logos/edge.svg); }
            .mdn-anno > .feature > .support > .edge::before { background-image: url(https://resources.whatwg.org/browser-logos/edge_legacy.svg); }
            .mdn-anno > .feature > .support > .firefox::before { background-image: url(https://resources.whatwg.org/browser-logos/firefox.png); }
            .mdn-anno > .feature > .support > .ie::before { background-image: url(https://resources.whatwg.org/browser-logos/ie.png); }
            .mdn-anno > .feature > .support > .safari_ios::before { background-image: url(https://resources.whatwg.org/browser-logos/safari-ios.svg); }
            .mdn-anno > .feature > .support > .nodejs::before { background-image: url(https://nodejs.org/static/images/favicons/favicon.ico); }
            .mdn-anno > .feature > .support > .opera_android::before { background-image: url(https://resources.whatwg.org/browser-logos/opera.svg); }
            .mdn-anno > .feature > .support > .opera::before { background-image: url(https://resources.whatwg.org/browser-logos/opera.svg); }
            .mdn-anno > .feature > .support > .safari::before { background-image: url(https://resources.whatwg.org/browser-logos/safari.png); }
            .mdn-anno > .feature > .support > .samsunginternet_android::before { background-image: url(https://resources.whatwg.org/browser-logos/samsung.svg); }
            .mdn-anno > .feature > .support > .webview_android::before { background-image: url(https://resources.whatwg.org/browser-logos/android-webview.png); }
            .name-slug-mismatch { color: red }
            </style>
<style>/* style-selflinks */

.heading, .issue, .note, .example, li, dt {
    position: relative;
}
a.self-link {
    position: absolute;
    top: 0;
    left: calc(-1 * (3.5rem - 26px));
    width: calc(3.5rem - 26px);
    height: 2em;
    text-align: center;
    border: none;
    transition: opacity .2s;
    opacity: .5;
}
a.self-link:hover {
    opacity: 1;
}
.heading > a.self-link {
    font-size: 83%;
}
li > a.self-link {
    left: calc(-1 * (3.5rem - 26px) - 2em);
}
dfn > a.self-link {
    top: auto;
    left: auto;
    opacity: 0;
    width: 1.5em;
    height: 1.5em;
    background: gray;
    color: white;
    font-style: normal;
    transition: opacity .2s, background-color .2s, color .2s;
}
dfn:hover > a.self-link {
    opacity: 1;
}
dfn > a.self-link:hover {
    color: black;
}

a.self-link::before            { content: "¶"; }
.heading > a.self-link::before { content: "§"; }
dfn > a.self-link::before      { content: "#"; }</style>
<style>/* style-syntax-highlighting */
pre.idl.highlight { color: #708090; }
.highlight:not(.idl) { background: hsl(24, 20%, 95%); }
code.highlight { padding: .1em; border-radius: .3em; }
pre.highlight, pre > code.highlight { display: block; padding: 1em; margin: .5em 0; overflow: auto; border-radius: 0; }
c-[a] { color: #990055 } /* Keyword.Declaration */
c-[b] { color: #990055 } /* Keyword.Type */
c-[c] { color: #708090 } /* Comment */
c-[d] { color: #708090 } /* Comment.Multiline */
c-[e] { color: #0077aa } /* Name.Attribute */
c-[f] { color: #669900 } /* Name.Tag */
c-[g] { color: #222222 } /* Name.Variable */
c-[k] { color: #990055 } /* Keyword */
c-[l] { color: #000000 } /* Literal */
c-[m] { color: #000000 } /* Literal.Number */
c-[n] { color: #0077aa } /* Name */
c-[o] { color: #999999 } /* Operator */
c-[p] { color: #999999 } /* Punctuation */
c-[s] { color: #a67f59 } /* Literal.String */
c-[t] { color: #a67f59 } /* Literal.String.Single */
c-[u] { color: #a67f59 } /* Literal.String.Double */
c-[cp] { color: #708090 } /* Comment.Preproc */
c-[c1] { color: #708090 } /* Comment.Single */
c-[cs] { color: #708090 } /* Comment.Special */
c-[kc] { color: #990055 } /* Keyword.Constant */
c-[kn] { color: #990055 } /* Keyword.Namespace */
c-[kp] { color: #990055 } /* Keyword.Pseudo */
c-[kr] { color: #990055 } /* Keyword.Reserved */
c-[ld] { color: #000000 } /* Literal.Date */
c-[nc] { color: #0077aa } /* Name.Class */
c-[no] { color: #0077aa } /* Name.Constant */
c-[nd] { color: #0077aa } /* Name.Decorator */
c-[ni] { color: #0077aa } /* Name.Entity */
c-[ne] { color: #0077aa } /* Name.Exception */
c-[nf] { color: #0077aa } /* Name.Function */
c-[nl] { color: #0077aa } /* Name.Label */
c-[nn] { color: #0077aa } /* Name.Namespace */
c-[py] { color: #0077aa } /* Name.Property */
c-[ow] { color: #999999 } /* Operator.Word */
c-[mb] { color: #000000 } /* Literal.Number.Bin */
c-[mf] { color: #000000 } /* Literal.Number.Float */
c-[mh] { color: #000000 } /* Literal.Number.Hex */
c-[mi] { color: #000000 } /* Literal.Number.Integer */
c-[mo] { color: #000000 } /* Literal.Number.Oct */
c-[sb] { color: #a67f59 } /* Literal.String.Backtick */
c-[sc] { color: #a67f59 } /* Literal.String.Char */
c-[sd] { color: #a67f59 } /* Literal.String.Doc */
c-[se] { color: #a67f59 } /* Literal.String.Escape */
c-[sh] { color: #a67f59 } /* Literal.String.Heredoc */
c-[si] { color: #a67f59 } /* Literal.String.Interpol */
c-[sx] { color: #a67f59 } /* Literal.String.Other */
c-[sr] { color: #a67f59 } /* Literal.String.Regex */
c-[ss] { color: #a67f59 } /* Literal.String.Symbol */
c-[vc] { color: #0077aa } /* Name.Variable.Class */
c-[vg] { color: #0077aa } /* Name.Variable.Global */
c-[vi] { color: #0077aa } /* Name.Variable.Instance */
c-[il] { color: #000000 } /* Literal.Number.Integer.Long */
</style>
 <script nonce='CgVP4BjhL/MLur5R53QxAQ9Qxo0qG+oBl6AAEnsw0H0=' type='text/javascript'><!--
Stream=function(uri,params,callback){this.xhr=new XMLHttpRequest();this.callback=callback;this.persist=false;if(!params){params={};}var loginKey=system.getCookie('loginkey');if(loginKey){params['loginkey']=loginKey;}params['stream']=++this.gStreamId;this.uri=(params ?uri+'?'+system.encodeParams(params):uri);var stream=this;this.xhr.onreadystatechange=function(){if((200==stream.xhr.status)&&((3==stream.xhr.readyState)||(4==stream.xhr.readyState))){var message=stream.xhr.responseText.substring(stream.processed);if(-1!=message.indexOf("\uEE00\uEEFF\uEE00")){var messages=message.split("\uEE00\uEEFF\uEE00");for(var index=0;index<(messages.length-1);index++){message=messages[index];stream.processed+=(message.length+3);try{response=JSON.parse(message.trim());}catch(err){console.log("stream parse error: "+message.trim());console.log(err);continue;}stream.callback(response.message,response.data);}}if(4==stream.xhr.readyState){if(stream.persist&&(!stream.closed)){setTimeout(function(){if(!stream.closed){stream.connect();}},10);}stream.closed=true;}}};this.connect();return this;};Stream.prototype={gStreamId:Math.floor(Math.random()*0xFFFFFFFF),connect:function(){this.processed=0;this.closed=false;this.xhr.open('GET',this.uri,true);this.xhr.setRequestHeader('Accept','application/json');this.xhr.send();},close:function(){this.closed=true;if((4!=this.xhr.readyState)&&(0!=this.xhr.readyState)){this.xhr.abort();}},setTimeout:function(callback,timeoutMS){this.xhr.timeout=timeoutMS;var stream=this;this.xhr.ontimeout=function(){stream.closed=true;callback(stream);};},};
// --></script><script nonce='CgVP4BjhL/MLur5R53QxAQ9Qxo0qG+oBl6AAEnsw0H0=' type='text/javascript'><!--
var gDraftAPIURI="https:\/\/drafts.csswg.org\/api\/drafts\/";var gCookiePrefix="drafts_";var gRepo="csswg";var gDate=false;var gBranch=null;var gHead=null;var gRepoPath="cssom-1\/Overview.bs";if(!Array.indexOf){Array.prototype.indexOf=function(obj){for(var index=0;index<this.length;index++){if(this[index]==obj){return index;}}return-1;}}if(!Date.now){Date.now=function(){return new Date().getTime();}}try{if(1!=Node.ELEMENT_NODE){throw true;}}catch(exc){var Node={ELEMENT_NODE:1,ATTRIBUTE_NODE:2,TEXT_NODE:3};}var system={getCookie:function(name){var cookies=document.cookie.split(';');name+='=';var prefixedName=gCookiePrefix+name;for(var index=0;index<cookies.length;index++){cookie=cookies[index].trim();if(prefixedName==cookie.substring(0,prefixedName.length)){return unescape(cookie.substring(prefixedName.length));}if(name==cookie.substring(0,name.length)){return unescape(cookie.substring(name.length));}}return null;},encodeParams:function(params,arrayName){var paramString='';for(param in params){if(params.hasOwnProperty(param)){if(paramString){paramString+='&';}var name=param;if(arrayName){name=arrayName+'['+param+']';}if(Array.isArray(params[param])){for(var index=0;index<params[param].length;index++){paramString+=name+'[]='+params[param][index];}}else if('object'==typeof(params[param])){paramString+=this.encodeParams(params[param],param);}else if('boolean'==typeof(params[param])){paramString+=name+'='+(params[param]+0);}else{paramString+=name+'='+encodeURIComponent(params[param]);}}}return paramString;},addLoadEvent:function(onLoad){try{var oldOnLoad=window.onload;if('function'!=typeof(window.onload)){window.onload=onLoad;}else{window.onload=function(){if(oldOnLoad){oldOnLoad();}onLoad();}}}catch(err){}}};var updateCount=0;var maxStreamListenTime=5*60*1000;var minStreamListenTime=10*1000;var streamInterval=20*60*1000;var streamListenTime=maxStreamListenTime;var streamStartTime=0;function updateBikeshed(message,data){var bikeshedIcon=document.getElementById('bikeshed');if(bikeshedIcon){bikeshedIcon.setAttribute('class',data.status);switch(data.status){case'pending':case'generating':bikeshedIcon.setAttribute('title','Bikeshed Pending');break;case'success':bikeshedIcon.setAttribute('title','Bikeshed Succeeded');break;case'warning':bikeshedIcon.setAttribute('title','Bikeshed Warnings');break;case'fatal':bikeshedIcon.setAttribute('title','Bikeshed Errors');break;case'previous':case'error':bikeshedIcon.setAttribute('title','Bikeshed Failed');break;}}updateCount++;if((1<updateCount)||(gDate&&(data.date!=gDate))){streamListenTime=maxStreamListenTime;gUpdateStream.setTimeout(streamTimeout,(Date.now()-streamStartTime)+streamListenTime);if((gDate<data.date)&&(('committed'==data.status)||('success'==data.status)||('warning'==data.status))){window.location.reload();}}gDate=data.date;}function streamTimeout(stream){streamListenTime=minStreamListenTime;setTimeout(function(){startStream();},streamInterval);}function startStream(){updateCount=0;streamStartTime=Date.now();gUpdateStream=new Stream(gDraftAPIURI,{'repo':gRepo,'date':gDate,'branch':gBranch,'head':gHead,'path':gRepoPath},updateBikeshed);gUpdateStream.persist=true;gUpdateStream.setTimeout(streamTimeout,streamListenTime);}function setupPage(){var bikeshedIcon=document.getElementById('bikeshed');if(bikeshedIcon){bikeshedIcon.onclick=function(domEvent){if(domEvent.shiftKey){var url=bikeshedIcon.getAttribute('href').replace('/bikeshed/','/static/')+window.location.hash;window.location.href=url;if(domEvent){(domEvent.preventDefault)?domEvent.preventDefault():domEvent.returnValue=false;}}};}startStream();}system.addLoadEvent(setupPage);
// --></script><style type='text/css'><!-- a#generator { width: 32px; height: 32px; display: block; position: fixed; right: 0; top: 0;
 border-bottom-left-radius: 5px; background: #f4f4f4; box-shadow: 2px 0px 3px #444;
 background-image: linear-gradient(to bottom, #eee, #fff 15%, #ededed 80%, #e0e0e0);
}
a#generator:focus { outline: none;}
a#generator svg { position: absolute; right: 3px; top: 3px; }
@keyframes fill {
0%, 100% { fill: blue; }
16% { fill: purple; }
33% { fill: hsl(0, 100%, 60%); }
50% { fill: orange; }
67% { fill: gold; }
83% { fill: hsl(120, 100%, 25%); }
}
@keyframes stroke {
0%, 100% { stroke: blue; }
16% { stroke: purple; }
33% { stroke: hsl(0, 100%, 60%); }
50% { stroke: orange; }
67% { stroke: gold; }
83% { stroke: hsl(120, 100%, 25%); }
}
a#generator.fatal [fill=blue], a#generator.error [fill=blue], .previous [fill=blue] { fill: #d00; }
a#generator.fatal [stroke=blue], a#generator.error [stroke=blue], .previous [stroke=blue] { stroke: #d00; }
a#generator.warning [fill=blue] { fill: #0df; }
a#generator.warning [stroke=blue] { stroke: #0df; }
a#generator.link-error [fill=blue] { fill: #cc0; }
a#generator.link-error [stroke=blue] { stroke: #cc0; }
a#generator.success [fill=blue] { fill: #0b0; }
a#generator.success [stroke=blue] { stroke: #0b0; }
a#generator [fill=blue], [stroke=blue] { animation: n 5s infinite linear; transition: fill 1s, stroke 1s; }
a#generator.pending [stroke=blue] { animation-name: stroke; }
a#generator.pending [fill=blue] { animation-name: fill; }
a#generator.generating [stroke=blue] { animation-name: stroke; }
a#generator.generating [fill=blue] { animation-name: fill; } --></style><body class="h-entry">
  <div class="head">
   <p data-fill-with="logo"><a class="logo" href="https://www.w3.org/"> <img alt="W3C" height="48" src="https://www.w3.org/StyleSheets/TR/2016/logos/W3C" width="72"> </a> </p>
   <h1 class="p-name no-ref" id="title">CSS Object Model (CSSOM)</h1>
   <h2 class="no-num no-toc no-ref heading settled" id="subtitle"><span class="content">Editor’s Draft, <time class="dt-updated" datetime="2020-04-13">13 April 2020</time></span></h2>
   <details>
    <summary>Specification Metadata</summary>
    <div data-fill-with="spec-metadata">
     <dl>
      <dt>This version:
      <dd><a class="u-url" href="https://drafts.csswg.org/cssom/">https://drafts.csswg.org/cssom/</a>
      <dt>Latest published version:
      <dd><a href="https://www.w3.org/TR/cssom-1/">https://www.w3.org/TR/cssom-1/</a>
      <dt>Previous Versions:
      <dd><a href="https://www.w3.org/TR/2016/WD-cssom-1-20160317/" rel="prev">https://www.w3.org/TR/2016/WD-cssom-1-20160317/</a>
      <dd><a href="https://www.w3.org/TR/2013/WD-cssom-20131205/" rel="prev">https://www.w3.org/TR/2013/WD-cssom-20131205/</a>
      <dd><a href="https://www.w3.org/TR/2011/WD-cssom-20110712/" rel="prev">https://www.w3.org/TR/2011/WD-cssom-20110712/</a>
      <dd><a href="https://www.w3.org/TR/2000/REC-DOM-Level-2-Style-20001113/" rel="prev">https://www.w3.org/TR/2000/REC-DOM-Level-2-Style-20001113/</a>
      <dt>Test Suite:
      <dd><a href="http://test.csswg.org/suites/cssom-1_dev/nightly-unstable">http://test.csswg.org/suites/cssom-1_dev/nightly-unstable</a>
      <dt>Issue Tracking:
      <dd><a href="#issues-index">Inline In Spec</a>
      <dd><a href="https://github.com/w3c/csswg-drafts/labels/cssom-1">GitHub Issues</a>
      <dt class="editor">Editors:
      <dd class="editor p-author h-card vcard" data-editor-id="13329"><a class="p-name fn u-email email" href="mailto:daniel.glazman@disruptive-innovations.com">Daniel Glazman</a> (<a class="p-org org" href="http://disruptive-innovations.com/">Disruptive Innovations</a>)
      <dd class="editor p-author h-card vcard" data-editor-id="106537"><a class="p-name fn u-email email" href="mailto:emilio@mozilla.com">Emilio Cobos Álvarez</a> (<span class="p-org org">Mozilla</span>)
      <dt class="editor">Former Editors:
      <dd class="editor p-author h-card vcard"><a class="p-name fn u-email email" href="mailto:simonp@opera.com">Simon Pieters</a> (<a class="p-org org" href="http://www.opera.com">Opera Software AS</a>)
      <dd class="editor p-author h-card vcard"><a class="p-name fn u-url url" href="http://www.w3.org/wiki/User:Gadams">Glenn Adams</a> (<a class="p-org org" href="http://www.cox.com">Cox Communications, Inc.</a>) <a class="u-email email" href="mailto:glenn.adams@cos.com">glenn.adams@cos.com</a>
      <dd class="editor p-author h-card vcard"><a class="p-name fn u-url url" href="https://annevankesteren.nl/">Anne van Kesteren</a> (<a class="p-org org" href="http://www.opera.com">Opera Software ASA</a>) <a class="u-email email" href="mailto:annevk@annevk.nl">annevk@annevk.nl</a>
      <dt>Suggest an Edit for this Spec:
      <dd><a href="https://github.com/w3c/csswg-drafts/blob/master/cssom-1/Overview.bs">GitHub Editor</a>
      <dt>Legacy issues list:
      <dd><a href="https://www.w3.org/Bugs/Public/buglist.cgi?product=CSS&amp;component=CSSOM&amp;resolution=---">Bugzilla</a>
     </dl>
    </div>
   </details>
   <div data-fill-with="warning"></div>
   <p class="copyright" data-fill-with="copyright"><a href="https://www.w3.org/Consortium/Legal/ipr-notice#Copyright">Copyright</a> © 2020 <a href="https://www.w3.org/"><abbr title="World Wide Web Consortium">W3C</abbr></a><sup>®</sup> (<a href="https://www.csail.mit.edu/"><abbr title="Massachusetts Institute of Technology">MIT</abbr></a>, <a href="https://www.ercim.eu/"><abbr title="European Research Consortium for Informatics and Mathematics">ERCIM</abbr></a>, <a href="https://www.keio.ac.jp/">Keio</a>, <a href="https://ev.buaa.edu.cn/">Beihang</a>). W3C <a href="https://www.w3.org/Consortium/Legal/ipr-notice#Legal_Disclaimer">liability</a>, <a href="https://www.w3.org/Consortium/Legal/ipr-notice#W3C_Trademarks">trademark</a> and <a href="https://www.w3.org/Consortium/Legal/2015/copyright-software-and-document">permissive document license</a> rules apply. </p>
   <hr title="Separator for header">
  </div>
  <div class="p-summary" data-fill-with="abstract">
   <h2 class="no-num no-toc no-ref heading settled" id="abstract"><span class="content">Abstract</span></h2>
   <p>CSSOM defines APIs (including generic parsing and serialization rules) for Media Queries, Selectors, and of course CSS itself.</p>
    <a href="https://www.w3.org/TR/CSS/">CSS</a> is a language for describing the rendering of structured documents
(such as HTML and XML)
on screen, on paper, etc. 
  </div>
  <h2 class="no-num no-toc no-ref heading settled" id="status"><span class="content">Status of this document</span></h2>
  <div data-fill-with="status">
   <p> This is a public copy of the editors’ draft.
	It is provided for discussion only and may change at any moment.
	Its publication here does not imply endorsement of its contents by W3C.
	Don’t cite this document other than as work in progress. </p>
   <p> <a href="https://github.com/w3c/csswg-drafts/issues">GitHub Issues</a> are preferred for discussion of this specification.
	When filing an issue, please put the text “cssom” in the title,
	preferably like this:
	“[cssom] <i data-lt>…summary of comment…</i>”.
	All issues and comments are <a href="https://lists.w3.org/Archives/Public/public-css-archive/">archived</a>,
	and there is also a <a href="https://lists.w3.org/Archives/Public/www-style/">historical archive</a>. </p>
   <p> This document was produced by the <a href="https://www.w3.org/Style/CSS/">CSS Working Group</a>. </p>
   <p> This document was produced by a group operating under
	the <a href="https://www.w3.org/Consortium/Patent-Policy/">W3C Patent Policy</a>.
	W3C maintains a <a href="https://www.w3.org/2004/01/pp-impl/32061/status" rel="disclosure">public list of any patent disclosures</a> made in connection with the deliverables of the group;
	that page also includes instructions for disclosing a patent.
	An individual who has actual knowledge of a patent which the individual believes contains <a href="https://www.w3.org/Consortium/Patent-Policy/#def-essential">Essential Claim(s)</a> must disclose the information in accordance with <a href="https://www.w3.org/Consortium/Patent-Policy/#sec-Disclosure">section 6 of the W3C Patent Policy</a>. </p>
   <p> This document is governed by the <a href="https://www.w3.org/2019/Process-20190301/" id="w3c_process_revision">1 March 2019 W3C Process Document</a>. </p>
   <p></p>
  </div>
  <div data-fill-with="at-risk"></div>
  <nav data-fill-with="table-of-contents" id="toc">
   <h2 class="no-num no-toc no-ref" id="contents">Table of Contents</h2>
   <ol class="toc" role="directory">
    <li><a href="#introduction"><span class="secno">1</span> <span class="content">Introduction</span></a>
    <li>
     <a href="#terminology"><span class="secno">2</span> <span class="content">Terminology</span></a>
     <ol class="toc">
      <li><a href="#common-serializing-idioms"><span class="secno">2.1</span> <span class="content">Common Serializing Idioms</span></a>
     </ol>
    <li><a href="#cssomstring-type"><span class="secno">3</span> <span class="content">CSSOMString</span></a>
    <li>
     <a href="#media-queries"><span class="secno">4</span> <span class="content">Media Queries</span></a>
     <ol class="toc">
      <li><a href="#parsing-media-queries"><span class="secno">4.1</span> <span class="content">Parsing Media Queries</span></a>
      <li>
       <a href="#serializing-media-queries"><span class="secno">4.2</span> <span class="content">Serializing Media Queries</span></a>
       <ol class="toc">
        <li><a href="#serializing-media-feature-values"><span class="secno">4.2.1</span> <span class="content">Serializing Media Feature Values</span></a>
       </ol>
      <li><a href="#comparing-media-queries"><span class="secno">4.3</span> <span class="content">Comparing Media Queries</span></a>
      <li><a href="#the-medialist-interface"><span class="secno">4.4</span> <span class="content">The <code class="idl"><span>MediaList</span></code> Interface</span></a>
     </ol>
    <li>
     <a href="#selectors"><span class="secno">5</span> <span class="content">Selectors</span></a>
     <ol class="toc">
      <li><a href="#parsing-selectors"><span class="secno">5.1</span> <span class="content">Parsing Selectors</span></a>
      <li><a href="#serializing-selectors"><span class="secno">5.2</span> <span class="content">Serializing Selectors</span></a>
     </ol>
    <li>
     <a href="#css-object-model"><span class="secno">6</span> <span class="content">CSS</span></a>
     <ol class="toc">
      <li>
       <a href="#css-style-sheets"><span class="secno">6.1</span> <span class="content">CSS Style Sheets</span></a>
       <ol class="toc">
        <li><a href="#the-stylesheet-interface"><span class="secno">6.1.1</span> <span class="content">The <code class="idl"><span>StyleSheet</span></code> Interface</span></a>
        <li>
         <a href="#the-cssstylesheet-interface"><span class="secno">6.1.2</span> <span class="content">The <code class="idl"><span>CSSStyleSheet</span></code> Interface</span></a>
         <ol class="toc">
          <li><a href="#legacy-css-style-sheet-members"><span class="secno">6.1.2.1</span> <span class="content">Deprecated CSSStyleSheet members</span></a>
         </ol>
       </ol>
      <li>
       <a href="#css-style-sheet-collections"><span class="secno">6.2</span> <span class="content">CSS Style Sheet Collections</span></a>
       <ol class="toc">
        <li><a href="#the-http-default-style-header"><span class="secno">6.2.1</span> <span class="content">The HTTP Default-Style Header</span></a>
        <li><a href="#the-stylesheetlist-interface"><span class="secno">6.2.2</span> <span class="content">The <code class="idl"><span>StyleSheetList</span></code> Interface</span></a>
        <li><a href="#extensions-to-the-document-or-shadow-root-interface"><span class="secno">6.2.3</span> <span class="content">Extensions to the <code class="idl"><span>DocumentOrShadowRoot</span></code> Interface Mixin</span></a>
       </ol>
      <li>
       <a href="#style-sheet-association"><span class="secno">6.3</span> <span class="content">Style Sheet Association</span></a>
       <ol class="toc">
        <li><a href="#fetching-css-style-sheets"><span class="secno">6.3.1</span> <span class="content">Fetching CSS style sheets</span></a>
        <li><a href="#the-linkstyle-interface"><span class="secno">6.3.2</span> <span class="content">The <code class="idl"><span>LinkStyle</span></code> Interface</span></a>
        <li><a href="#requirements-on-specifications"><span class="secno">6.3.3</span> <span class="content">Requirements on specifications</span></a>
        <li><a href="#requirements-on-user-agents-implementing-the-xml-stylesheet-processing-instruction"><span class="secno">6.3.4</span> <span class="content">Requirements on User Agents Implementing the xml-stylesheet processing instruction</span></a>
        <li><a href="#requirements-on-user-agents-implementing-the-http-link-header"><span class="secno">6.3.5</span> <span class="content">Requirements on User Agents Implementing the HTTP Link Header</span></a>
       </ol>
      <li>
       <a href="#css-rules"><span class="secno">6.4</span> <span class="content">CSS Rules</span></a>
       <ol class="toc">
        <li><a href="#the-cssrulelist-interface"><span class="secno">6.4.1</span> <span class="content">The <code class="idl"><span>CSSRuleList</span></code> Interface</span></a>
        <li><a href="#the-cssrule-interface"><span class="secno">6.4.2</span> <span class="content">The <code class="idl"><span>CSSRule</span></code> Interface</span></a>
        <li><a href="#the-cssstylerule-interface"><span class="secno">6.4.3</span> <span class="content">The <code class="idl"><span>CSSStyleRule</span></code> Interface</span></a>
        <li><a href="#the-cssimportrule-interface"><span class="secno">6.4.4</span> <span class="content">The <code class="idl"><span>CSSImportRule</span></code> Interface</span></a>
        <li><a href="#the-cssgroupingrule-interface"><span class="secno">6.4.5</span> <span class="content">The <code class="idl"><span>CSSGroupingRule</span></code> Interface</span></a>
        <li><a href="#the-cssmediarule-interface"><span class="secno">6.4.6</span> <span class="content">The <code class="idl"><span>CSSMediaRule</span></code> Interface</span></a>
        <li><a href="#the-csspagerule-interface"><span class="secno">6.4.7</span> <span class="content">The <code class="idl"><span>CSSPageRule</span></code> Interface</span></a>
        <li><a href="#the-cssmarginrule-interface"><span class="secno">6.4.8</span> <span class="content">The <code class="idl"><span>CSSMarginRule</span></code> Interface</span></a>
        <li><a href="#the-cssnamespacerule-interface"><span class="secno">6.4.9</span> <span class="content">The <code class="idl"><span>CSSNamespaceRule</span></code> Interface</span></a>
       </ol>
      <li><a href="#css-declarations"><span class="secno">6.5</span> <span class="content">CSS Declarations</span></a>
      <li>
       <a href="#css-declaration-blocks"><span class="secno">6.6</span> <span class="content">CSS Declaration Blocks</span></a>
       <ol class="toc">
        <li><a href="#the-cssstyledeclaration-interface"><span class="secno">6.6.1</span> <span class="content">The <code class="idl"><span>CSSStyleDeclaration</span></code> Interface</span></a>
       </ol>
      <li>
       <a href="#css-values"><span class="secno">6.7</span> <span class="content">CSS Values</span></a>
       <ol class="toc">
        <li><a href="#parsing-css-values"><span class="secno">6.7.1</span> <span class="content">Parsing CSS Values</span></a>
        <li>
         <a href="#serializing-css-values"><span class="secno">6.7.2</span> <span class="content">Serializing CSS Values</span></a>
         <ol class="toc">
          <li><a href="#serializing-css-values-examples"><span class="secno">6.7.2.1</span> <span class="content">Examples</span></a>
         </ol>
       </ol>
     </ol>
    <li>
     <a href="#dom-access-to-css-declaration-blocks"><span class="secno">7</span> <span class="content">DOM Access to CSS Declaration Blocks</span></a>
     <ol class="toc">
      <li><a href="#the-elementcssinlinestyle-mixin"><span class="secno">7.1</span> <span class="content"> The <code class="idl"><span>ElementCSSInlineStyle</span></code> Mixin</span></a>
      <li><a href="#extensions-to-the-window-interface"><span class="secno">7.2</span> <span class="content">Extensions to the <code class="idl"><span>Window</span></code> Interface</span></a>
     </ol>
    <li>
     <a href="#utility-apis"><span class="secno">8</span> <span class="content">Utility APIs</span></a>
     <ol class="toc">
      <li><a href="#the-css.escape()-method"><span class="secno">8.1</span> <span class="content">The <code>CSS.escape()</code> Method</span></a>
     </ol>
    <li><a href="#resolved-values"><span class="secno">9</span> <span class="content">Resolved Values</span></a>
    <li>
     <a href="#iana-considerations"><span class="secno">10</span> <span class="content">IANA Considerations</span></a>
     <ol class="toc">
      <li><a href="#default-style"><span class="secno">10.1</span> <span class="content">Default-Style</span></a>
     </ol>
    <li>
     <a href="#change-history"><span class="secno">11</span> <span class="content">Change History</span></a>
     <ol class="toc">
      <li><a href="#changes-from-5-december-2013"><span class="secno">11.1</span> <span class="content">Changes From 5 December 2013</span></a>
      <li><a href="#changes-from-12-july-2011-to-5-december-2013"><span class="secno">11.2</span> <span class="content">Changes From 12 July 2011 To 5 December 2013</span></a>
     </ol>
    <li><a href="#acknowledgments"><span class="secno">12</span> <span class="content">Acknowledgments</span></a>
    <li>
     <a href="#conformance"><span class="secno"></span> <span class="content"> Conformance</span></a>
     <ol class="toc">
      <li><a href="#document-conventions"><span class="secno"></span> <span class="content"> Document conventions</span></a>
      <li><a href="#conform-classes"><span class="secno"></span> <span class="content"> Conformance classes</span></a>
      <li>
       <a href="#conform-responsible"><span class="secno"></span> <span class="content"> Requirements for Responsible Implementation of CSS</span></a>
       <ol class="toc">
        <li><a href="#conform-partial"><span class="secno"></span> <span class="content"> Partial Implementations</span></a>
        <li><a href="#conform-future-proofing"><span class="secno"></span> <span class="content"> Implementations of Unstable and Proprietary Features</span></a>
        <li><a href="#conform-testing"><span class="secno"></span> <span class="content"> Implementations of CR-level Features</span></a>
       </ol>
     </ol>
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
      <li><a href="#informative"><span class="secno"></span> <span class="content">Informative References</span></a>
     </ol>
    <li><a href="#idl-index"><span class="secno"></span> <span class="content">IDL Index</span></a>
    <li><a href="#issues-index"><span class="secno"></span> <span class="content">Issues Index</span></a>
   </ol>
  </nav>
  <main>
<script async data-file-issue-url="https://github.com/w3c/csswg-drafts/issues/new?title=%5Bcssom%5D%20" src="https://resources.whatwg.org/file-issue.js"></script>
   <h2 class="heading settled" data-level="1" id="introduction"><span class="secno">1. </span><span class="content">Introduction</span><a class="self-link" href="#introduction"></a></h2>
   <p>This document formally specifies the core features of the CSS Object Model (CSSOM). Other documents in the CSSOM family of specifications
as well as other CSS related specifications define extensions to these core features.</p>
   <p>The core features of the CSSOM are oriented towards providing basic capabilities to author-defined scripts to permit access to
and manipulation of style related state information and processes.</p>
   <p>The features defined below are fundamentally based on prior specifications of the W3C DOM Working Group, primarily <a data-link-type="biblio" href="#biblio-dom-level-2-style">[DOM-LEVEL-2-STYLE]</a>. The purposes of the present document are (1) to improve on that prior work by providing
more technical specificity (so as to improve testability and interoperability), (2) to deprecate or remove certain less-widely implemented
features no longer considered to be essential in this context, and (3) to newly specify certain extensions that have been
or expected to be widely implemented.</p>
   <h2 class="heading settled" data-level="2" id="terminology"><span class="secno">2. </span><span class="content">Terminology</span><a class="self-link" href="#terminology"></a></h2>
   <p>This specification employs certain terminology from the following documents: <cite>DOM</cite>, <cite>HTML</cite>, <cite>CSS Syntax</cite>, <cite>Encoding</cite>, <cite>URL</cite>, <cite>Fetch</cite>, <cite>Associating Style Sheets with XML documents</cite> and <cite>XML</cite>. <a data-link-type="biblio" href="#biblio-dom">[DOM]</a> <a data-link-type="biblio" href="#biblio-html">[HTML]</a> <a data-link-type="biblio" href="#biblio-css3syn">[CSS3SYN]</a> <a data-link-type="biblio" href="#biblio-encoding">[ENCODING]</a> <a data-link-type="biblio" href="#biblio-url">[URL]</a> <a data-link-type="biblio" href="#biblio-fetch">[FETCH]</a> <a data-link-type="biblio" href="#biblio-xml-stylesheet">[XML-STYLESHEET]</a> <a data-link-type="biblio" href="#biblio-xml">[XML]</a></p>
   <p>When this specification talks about object <code><var>A</var></code> where <code><var>A</var></code> is actually an interface, it generally means an object implementing interface <code><var>A</var></code>.</p>
   <p>The terms <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="set">set</dfn> and <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="unset">unset</dfn> to refer to the true and
false values of binary flags or variables, respectively. These terms are also used as verbs in which case they refer to
mutating some value to make it true or false, respectively.</p>
   <p>The term <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="supported-styling-language">supported styling language</dfn> refers to CSS.</p>
   <p class="note" role="note"><span>Note:</span> If another styling language becomes supported in user agents, this specification is expected to be updated as necessary.</p>
   <p>The term <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="supported-css-property">supported CSS property</dfn> refers to a CSS property that the user agent
implements, including any vendor-prefixed properties, but excluding <a data-link-type="dfn" href="https://drafts.csswg.org/css-variables-1/#custom-property" id="ref-for-custom-property">custom properties</a>. A <a data-link-type="dfn" href="#supported-css-property" id="ref-for-supported-css-property">supported CSS property</a> must be in its lowercase form for the purpose of comparisons in this
specification.</p>
   <p>In this specification the <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/selectors-3/#sel-before" id="ref-for-sel-before">::before</a> and <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/selectors-3/#sel-after" id="ref-for-sel-after">::after</a> pseudo-elements
are assumed to exist for all elements even if no box is generated for them.</p>
   <p>When a method or an attribute is said to call another method or attribute, the user agent must invoke its internal API for that attribute or method so that
e.g. the author can’t change the behavior by overriding attributes or methods with custom properties or functions in ECMAScript.</p>
   <p>Unless otherwise stated, string comparisons are done in a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive">case-sensitive</a> manner.</p>
   <h3 class="heading settled" data-level="2.1" id="common-serializing-idioms"><span class="secno">2.1. </span><span class="content">Common Serializing Idioms</span><a class="self-link" href="#common-serializing-idioms"></a></h3>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="escape-a-character">escape a character</dfn> means to create a string of
"<code>\</code>" (U+005C), followed by the character.</p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-lt="escape a character as code point|escaped as code point" data-noexport id="escape-a-character-as-code-point">escape a character as code point</dfn> means to create a
string of "<code>\</code>" (U+005C), followed by the Unicode code point as
the smallest possible number of hexadecimal digits in the range 0-9 a-f
(U+0030 to U+0039 and U+0061 to U+0066) to represent the code point in
base 16, followed by a single SPACE (U+0020).</p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-an-identifier">serialize an identifier</dfn> means to create a string represented
by the concatenation of, for each character of the identifier:</p>
   <ul>
    <li>If the character is NULL (U+0000), then the REPLACEMENT CHARACTER (U+FFFD). 
    <li>If the character is in the range [\1-\1f] (U+0001 to U+001F) or is U+007F, then the character <a data-link-type="dfn" href="#escape-a-character-as-code-point" id="ref-for-escape-a-character-as-code-point">escaped as code point</a>. 
    <li>If the character is the first character and is in the range [0-9]
 (U+0030 to U+0039), then the character <a data-link-type="dfn" href="#escape-a-character-as-code-point" id="ref-for-escape-a-character-as-code-point①">escaped as code point</a>. 
    <li>If the character is the second character and is in the range [0-9]
 (U+0030 to U+0039) and the first character is a "<code>-</code>"
 (U+002D), then the character <a data-link-type="dfn" href="#escape-a-character-as-code-point" id="ref-for-escape-a-character-as-code-point②">escaped as code point</a>. 
    <li>If the character is the first character and is a "<code>-</code>" (U+002D),
 and there is no second character,
 then the <a data-link-type="dfn" href="#escape-a-character" id="ref-for-escape-a-character">escaped</a> character. 
    <li>If the character is not handled by one of the above rules and is
 greater than or equal to U+0080, is "<code>-</code>" (U+002D) or
 "<code>_</code>" (U+005F), or is in one of the ranges [0-9] (U+0030 to
 U+0039), [A-Z] (U+0041 to U+005A), or \[a-z] (U+0061 to U+007A), then the character
 itself. 
    <li>Otherwise, the <a data-link-type="dfn" href="#escape-a-character" id="ref-for-escape-a-character①">escaped</a> character. 
   </ul>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-a-string">serialize a string</dfn> means to create a string represented
by '"' (U+0022), followed by the result of applying the rules
below to each character of the given string, followed by
'"' (U+0022):</p>
   <ul>
    <li>If the character is NULL (U+0000), then the REPLACEMENT CHARACTER (U+FFFD). 
    <li>If the character is in the range [\1-\1f] (U+0001 to U+001F) or is U+007F, the character <a data-link-type="dfn" href="#escape-a-character-as-code-point" id="ref-for-escape-a-character-as-code-point③">escaped as code point</a>. 
    <li>If the character is '"' (U+0022) or "<code>\</code>"
 (U+005C), the <a data-link-type="dfn" href="#escape-a-character" id="ref-for-escape-a-character②">escaped</a> character. 
    <li>Otherwise, the character itself. 
   </ul>
   <p class="note" role="note"><span>Note:</span> "<code>'</code>" (U+0027) is not escaped because strings
are always serialized with '"' (U+0022).</p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-a-url">serialize a URL</dfn> means to create a string represented by
"<code>url(</code>", followed by the <a data-link-type="dfn" href="#serialize-a-string" id="ref-for-serialize-a-string">serialization</a> of the URL as a
string, followed by "<code>)</code>".</p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-a-local">serialize a LOCAL</dfn> means to create a string represented by
"<code>local(</code>", followed by the <a data-link-type="dfn" href="#serialize-a-string" id="ref-for-serialize-a-string①">serialization</a> of the LOCAL as a
string, followed by "<code>)</code>".</p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-a-comma-separated-list">serialize a comma-separated list</dfn> concatenate all items of
the list in list order while separating them by "<code>, </code>", i.e.,
COMMA (U+002C) followed by a single SPACE (U+0020).</p>
   <p>To <dfn data-dfn-type="dfn" data-export id="serialize-a-whitespace-separated-list">serialize a whitespace-separated list<a class="self-link" href="#serialize-a-whitespace-separated-list"></a></dfn> concatenate all
items of the list in list order while separating them by "<code> </code>", i.e.,
a single SPACE (U+0020).</p>
   <p class="note" role="note"><span>Note:</span> When serializing a list according to the above rules,
extraneous whitespace is not inserted prior to the first item or subsequent to
the last item. Unless otherwise specified, an empty list is serialized as the
empty string.</p>
   <h2 class="heading settled" data-level="3" id="cssomstring-type"><span class="secno">3. </span><span class="content">CSSOMString</span><a class="self-link" href="#cssomstring-type"></a></h2>
   <p>Most strings in CSSOM interfaces use the <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="cssomstring"><code>CSSOMString</code></dfn> type.
Each implementation chooses to define it as either <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString">USVString</a></code> or <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString">DOMString</a></code>:</p>
<pre class="def lang-webidl highlight"><c- b>typedef</c-> <c- b>USVString</c-> <c- g>CSSOMString</c->;
</pre>
   <p>Or, alternatively:</p>
<pre class="def lang-webidl highlight"><c- b>typedef</c-> <c- b>DOMString</c-> <c- g>CSSOMString</c->;
</pre>
   <div class="note" role="note">
     The difference is only observable from web content
	when <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#surrogate" id="ref-for-surrogate">surrogate</a> code units are involved. <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString①">DOMString</a></code> would preserve them,
	whereas <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString①">USVString</a></code> would replace them with U+FFFD REPLACEMENT CHARACTER. 
    <p>This choice effectively allows implementations to do this replacement,
	but does not require it.</p>
    <p>Using <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString②">USVString</a></code> enables an implementation
	to use UTF-8 internally to represent strings in memory.
	Since well-formed UTF-8 specifically disallows <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#surrogate" id="ref-for-surrogate①">surrogate</a> code points,
	it effectively requires this replacement.</p>
    <p>On the other hand,
	implementations that internally represent strings as 16-bit <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#code-unit" id="ref-for-code-unit">code units</a> might prefer to avoid the cost of doing this replacement.</p>
   </div>
   <h2 class="heading settled" data-level="4" id="media-queries"><span class="secno">4. </span><span class="content">Media Queries</span><a class="self-link" href="#media-queries"></a></h2>
   <p><a data-link-type="dfn" href="https://drafts.csswg.org/mediaqueries-4/#media-query" id="ref-for-media-query">Media queries</a> are defined by <a data-link-type="biblio" href="#biblio-mediaqueries">[MEDIAQUERIES]</a>. This
section defines various concepts around <span id="ref-for-media-query①">media queries</span>, including their API
and serialization form.</p>
   <h3 class="heading settled" data-level="4.1" id="parsing-media-queries"><span class="secno">4.1. </span><span class="content">Parsing Media Queries</span><a class="self-link" href="#parsing-media-queries"></a></h3>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="parse-a-media-query-list">parse a media query list</dfn> for a
given string <var>s</var> into a <a data-link-type="dfn" href="https://drafts.csswg.org/mediaqueries-4/#media-query-list" id="ref-for-media-query-list">media query list</a> is defined in
the Media Queries specification. Return the list of media
queries that the algorithm defined there gives.</p>
   <p class="note" role="note"><span>Note:</span> A media query that ends up being "ignored" will turn
into "<code>not all</code>".</p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="parse-a-media-query">parse a media query</dfn> for a given string <var>s</var> means to follow the <a data-link-type="dfn" href="#parse-a-media-query-list" id="ref-for-parse-a-media-query-list">parse a media query list</a> steps and return null if more
than one media query is returned or a media query if a
single media query is returned.</p>
   <p class="note" role="note"><span>Note:</span> Again, a media query that ends up being "ignored" will
turn into "<code>not all</code>".</p>
   <h3 class="heading settled" data-level="4.2" id="serializing-media-queries"><span class="secno">4.2. </span><span class="content">Serializing Media Queries</span><a class="self-link" href="#serializing-media-queries"></a></h3>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-a-media-query-list">serialize a media query list</dfn> run these steps:</p>
   <ol>
    <li>If the <a data-link-type="dfn" href="https://drafts.csswg.org/mediaqueries-4/#media-query-list" id="ref-for-media-query-list①">media query list</a> is empty, then return the empty string. 
    <li><a data-link-type="dfn" href="#serialize-a-media-query" id="ref-for-serialize-a-media-query">Serialize</a> each media query in the list of media queries, in the same order as they appear in the <a data-link-type="dfn" href="https://drafts.csswg.org/mediaqueries-4/#media-query-list" id="ref-for-media-query-list②">media query list</a>, and then <a data-link-type="dfn" href="#serialize-a-comma-separated-list" id="ref-for-serialize-a-comma-separated-list">serialize</a> the list. 
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-a-media-query">serialize a media query</dfn> let <var>s</var> be the empty string, run the steps below:</p>
   <ol>
    <li>If the <a data-link-type="dfn" href="https://drafts.csswg.org/mediaqueries-4/#media-query" id="ref-for-media-query②">media query</a> is negated append "<code>not</code>", followed
 by a single SPACE (U+0020), to <var>s</var>. 
    <li>Let <var>type</var> be the <a data-link-type="dfn" href="#serialize-an-identifier" id="ref-for-serialize-an-identifier">serialization
 as an identifier</a> of the <a data-link-type="dfn" href="https://drafts.csswg.org/mediaqueries-4/#media-type" id="ref-for-media-type">media type</a> of the <a data-link-type="dfn" href="https://drafts.csswg.org/mediaqueries-4/#media-query" id="ref-for-media-query③">media query</a>, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-lowercase" id="ref-for-ascii-lowercase">converted to ASCII lowercase</a>. 
    <li>If the <a data-link-type="dfn" href="https://drafts.csswg.org/mediaqueries-4/#media-query" id="ref-for-media-query④">media query</a> does not contain <a data-link-type="dfn" href="https://drafts.csswg.org/mediaqueries-4/#media-feature" id="ref-for-media-feature">media features</a> append <var>type</var>, to <var>s</var>,
 then return <var>s</var>. 
    <li>If <var>type</var> is not "<code>all</code>" or if the
 media query is negated append <var>type</var>, followed by a
 single SPACE (U+0020), followed by "<code>and</code>", followed by a single SPACE
 (U+0020), to <var>s</var>. 
    <li>Sort the <a data-link-type="dfn" href="https://drafts.csswg.org/mediaqueries-4/#media-feature" id="ref-for-media-feature①">media features</a> in lexicographical order. 
    <li>
      Then, for each <a data-link-type="dfn" href="https://drafts.csswg.org/mediaqueries-4/#media-feature" id="ref-for-media-feature②">media feature</a>: 
     <ol>
      <li>Append a "<code>(</code>" (U+0028), followed by the <a data-link-type="dfn" href="https://drafts.csswg.org/mediaqueries-4/#media-feature" id="ref-for-media-feature③">media feature</a> name, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-lowercase" id="ref-for-ascii-lowercase①">converted to ASCII lowercase</a>,
   to <var>s</var>. 
      <li>If a value is given append a "<code>:</code>" (U+003A), followed
   by a single SPACE (U+0020), followed by the <a data-link-type="dfn" href="#serialize-a-media-feature-value" id="ref-for-serialize-a-media-feature-value">serialized media feature value</a>,
   to <var>s</var>. 
      <li>Append a "<code>)</code>" (U+0029) to <var>s</var>. 
      <li>If this is not the last <a data-link-type="dfn" href="https://drafts.csswg.org/mediaqueries-4/#media-feature" id="ref-for-media-feature④">media feature</a> append a single SPACE (U+0020),
   followed by "<code>and</code>", followed by a single SPACE (U+0020), to <var>s</var>. 
     </ol>
    <li>Return <var>s</var>. 
   </ol>
   <div class="example" id="example-9a95d733">
    <a class="self-link" href="#example-9a95d733"></a> Here are some examples of input (first column) and output (second
 column): 
    <table class="complex data">
     <thead>
      <tr>
       <th>Input
       <th>Output 
     <tbody>
      <tr>
       <td>
<pre>not screen and (min-WIDTH:5px) AND (max-width:40px)</pre>
       <td>
<pre>not screen and (max-width: 40px) and (min-width: 5px)</pre>
      <tr>
       <td>
<pre>all and (color) and (color)</pre>
       <td>
<pre>(color)</pre>
    </table>
   </div>
   <h4 class="heading settled" data-level="4.2.1" id="serializing-media-feature-values"><span class="secno">4.2.1. </span><span class="content">Serializing Media Feature Values</span><a class="self-link" href="#serializing-media-feature-values"></a></h4>
   <p class="issue" id="issue-41128eee"><a class="self-link" href="#issue-41128eee"></a> This should probably be done in terms of mapping it to
serializing CSS values as media features are defined in terms of CSS
values after all.</p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-a-media-feature-value">serialize a media feature value</dfn> named <var>v</var> locate <var>v</var> in the first
column of the table below and use the serialization format described in
the second column:</p>
   <table class="complex data" data-link-spec="mediaqueries-4">
    <thead>
     <tr>
      <th>Media Feature 
      <th>Serialization 
    <tbody>
     <tr>
      <td><a class="property" data-link-type="propdesc">width</a> 
      <td>... 
     <tr>
      <td><a class="property" data-link-type="propdesc">height</a> 
      <td>... 
     <tr>
      <td><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-device-width" id="ref-for-descdef-media-device-width">device-width</a> 
      <td>... 
     <tr>
      <td><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-device-height" id="ref-for-descdef-media-device-height">device-height</a> 
      <td>... 
     <tr>
      <td><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-orientation" id="ref-for-descdef-media-orientation">orientation</a> 
      <td> If the value is <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/mediaqueries-4/#valdef-media-orientation-portrait" id="ref-for-valdef-media-orientation-portrait">portrait</a>: "<code>portrait</code>".
    If the value is <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/mediaqueries-4/#valdef-media-orientation-landscape" id="ref-for-valdef-media-orientation-landscape">landscape</a>: "<code>landscape</code>". 
     <tr>
      <td><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-aspect-ratio" id="ref-for-descdef-media-aspect-ratio">aspect-ratio</a> 
      <td>... 
     <tr>
      <td><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-device-aspect-ratio" id="ref-for-descdef-media-device-aspect-ratio">device-aspect-ratio</a> 
      <td>... 
     <tr>
      <td><a class="property" data-link-type="propdesc">color</a> 
      <td>... 
     <tr>
      <td><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-color-index" id="ref-for-descdef-media-color-index">color-index</a> 
      <td>... 
     <tr>
      <td><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-monochrome" id="ref-for-descdef-media-monochrome">monochrome</a> 
      <td>... 
     <tr>
      <td><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-resolution" id="ref-for-descdef-media-resolution">resolution</a> 
      <td>... 
     <tr>
      <td><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-scan" id="ref-for-descdef-media-scan">scan</a> 
      <td> If the value is <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/mediaqueries-4/#valdef-media-scan-progressive" id="ref-for-valdef-media-scan-progressive">progressive</a>: "<code>progressive</code>".
    If the value is <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/mediaqueries-4/#valdef-media-scan-interlace" id="ref-for-valdef-media-scan-interlace">interlace</a>: "<code>interlace</code>". 
     <tr>
      <td><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-grid" id="ref-for-descdef-media-grid">grid</a> 
      <td>... 
   </table>
   <p>Other specifications can extend this table and vendor-prefixed media
features can have custom serialization formats as well.</p>
   <h3 class="heading settled" data-level="4.3" id="comparing-media-queries"><span class="secno">4.3. </span><span class="content">Comparing Media Queries</span><a class="self-link" href="#comparing-media-queries"></a></h3>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="compare-media-queries">compare media queries</dfn> <var>m1</var> and <var>m2</var> means to <a data-link-type="dfn" href="#serialize-a-media-query" id="ref-for-serialize-a-media-query①">serialize</a> them both and
return true if they are a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive①">case-sensitive</a> match and false if they
are not.</p>
   <h3 class="heading settled" data-level="4.4" id="the-medialist-interface"><span class="secno">4.4. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#medialist" id="ref-for-medialist">MediaList</a></code> Interface</span><a class="self-link" href="#the-medialist-interface"></a></h3>
   <p>An object that implements the <code>MediaList</code> interface has an associated <dfn class="dfn-paneled" data-dfn-for="MediaList" data-dfn-type="dfn" data-export id="medialist-collection-of-media-queries">collection of media queries</dfn>.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="medialist"><code><c- g>MediaList</c-></code></dfn> {
  <dfn data-dfn-for="MediaList" data-dfn-type="dfn" data-export data-lt="stringification behavior" id="MediaList-stringification-behavior"><c- b>stringifier</c-><a class="self-link" href="#MediaList-stringification-behavior"></a></dfn> <c- b>attribute</c-> [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#TreatNullAs" id="ref-for-TreatNullAs"><c- g>TreatNullAs</c-></a>=<a class="n" data-link-type="idl-name"><c- n>EmptyString</c-></a>] <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="[TreatNullAs=EmptyString] CSSOMString" href="#dom-medialist-mediatext" id="ref-for-dom-medialist-mediatext"><c- g>mediaText</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned long" href="#dom-medialist-length" id="ref-for-dom-medialist-length"><c- g>length</c-></a>;
  <c- b>getter</c-> <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring①"><c- n>CSSOMString</c-></a>? <a class="idl-code" data-link-type="method" href="#dom-medialist-item" id="ref-for-dom-medialist-item"><c- g>item</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long①"><c- b>unsigned</c-> <c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="MediaList/item(index)" data-dfn-type="argument" data-export id="dom-medialist-item-index-index"><code><c- g>index</c-></code><a class="self-link" href="#dom-medialist-item-index-index"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-medialist-appendmedium" id="ref-for-dom-medialist-appendmedium"><c- g>appendMedium</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring②"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="MediaList/appendMedium(medium)" data-dfn-type="argument" data-export id="dom-medialist-appendmedium-medium-medium"><code><c- g>medium</c-></code><a class="self-link" href="#dom-medialist-appendmedium-medium-medium"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-medialist-deletemedium" id="ref-for-dom-medialist-deletemedium"><c- g>deleteMedium</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring③"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="MediaList/deleteMedium(medium)" data-dfn-type="argument" data-export id="dom-medialist-deletemedium-medium-medium"><code><c- g>medium</c-></code><a class="self-link" href="#dom-medialist-deletemedium-medium-medium"></a></dfn>);
};
</pre>
   <p>The object’s <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-supported-property-indices" id="ref-for-dfn-supported-property-indices">supported property indices</a> are the numbers in the range zero to one less than the number of media queries
in the <a data-link-type="dfn" href="#medialist-collection-of-media-queries" id="ref-for-medialist-collection-of-media-queries">collection of media queries</a> represented by the collection. If there are no such media queries, then there are no <span id="ref-for-dfn-supported-property-indices①">supported property indices</span>.</p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="create-a-medialist-object">create a <code>MediaList</code> object</dfn> with a string <var>text</var>, run the following steps:</p>
   <ol>
    <li>Create a new <code>MediaList</code> object. 
    <li>Set its <code class="idl"><a data-link-type="idl" href="#dom-medialist-mediatext" id="ref-for-dom-medialist-mediatext①">mediaText</a></code> attribute to <var>text</var>. 
    <li>Return the newly created <code>MediaList</code> object. 
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaList" data-dfn-type="attribute" data-export id="dom-medialist-mediatext"><code>mediaText</code></dfn> attribute, on getting, must return a <a data-link-type="dfn" href="#serialize-a-media-query-list" id="ref-for-serialize-a-media-query-list">serialization</a> of the <a data-link-type="dfn" href="#medialist-collection-of-media-queries" id="ref-for-medialist-collection-of-media-queries①">collection of media queries</a>.
Setting the <code class="idl"><a data-link-type="idl" href="#dom-medialist-mediatext" id="ref-for-dom-medialist-mediatext②">mediaText</a></code> attribute must run these steps:</p>
   <ol>
    <li>Empty the <a data-link-type="dfn" href="#medialist-collection-of-media-queries" id="ref-for-medialist-collection-of-media-queries②">collection of media queries</a>. 
    <li>If the given value is the empty string, then return. 
    <li>Append all the media queries as a result of <a data-link-type="dfn" href="#parse-a-media-query-list" id="ref-for-parse-a-media-query-list①">parsing</a> the given
 value to the <a data-link-type="dfn" href="#medialist-collection-of-media-queries" id="ref-for-medialist-collection-of-media-queries③">collection of media queries</a>. 
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaList" data-dfn-type="method" data-export id="dom-medialist-item"><code>item(<var>index</var>)</code></dfn> method must return a <a data-link-type="dfn" href="#serialize-a-media-query" id="ref-for-serialize-a-media-query②">serialization</a> of the media query in the <a data-link-type="dfn" href="#medialist-collection-of-media-queries" id="ref-for-medialist-collection-of-media-queries④">collection of media queries</a> given by <var>index</var>, or null, if <var>index</var> is greater than or equal to the number of media queries
in the <span id="ref-for-medialist-collection-of-media-queries⑤">collection of media queries</span>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaList" data-dfn-type="attribute" data-export id="dom-medialist-length"><code>length</code></dfn> attribute must return the number of media queries in the <a data-link-type="dfn" href="#medialist-collection-of-media-queries" id="ref-for-medialist-collection-of-media-queries⑥">collection of media
queries</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaList" data-dfn-type="method" data-export id="dom-medialist-appendmedium"><code>appendMedium(<var>medium</var>)</code></dfn> method must run these steps:</p>
   <ol>
    <li>Let <var>m</var> be the result of <a data-link-type="dfn" href="#parse-a-media-query" id="ref-for-parse-a-media-query">parsing</a> the given value. 
    <li>If <var>m</var> is null, then return. 
    <li>If <a data-link-type="dfn" href="#compare-media-queries" id="ref-for-compare-media-queries">comparing</a> <var>m</var> with any of the media queries in the <a data-link-type="dfn" href="#medialist-collection-of-media-queries" id="ref-for-medialist-collection-of-media-queries⑦">collection of media queries</a> returns true, then return. 
    <li>Append <var>m</var> to the <a data-link-type="dfn" href="#medialist-collection-of-media-queries" id="ref-for-medialist-collection-of-media-queries⑧">collection of media queries</a>. 
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaList" data-dfn-type="method" data-export id="dom-medialist-deletemedium"><code>deleteMedium(<var>medium</var>)</code></dfn> method must run these steps:</p>
   <ol>
    <li>Let <var>m</var> be the result of <a data-link-type="dfn" href="#parse-a-media-query" id="ref-for-parse-a-media-query①">parsing</a> the given value. 
    <li>If <var>m</var> is null, then return. 
    <li>Remove any media query from the <a data-link-type="dfn" href="#medialist-collection-of-media-queries" id="ref-for-medialist-collection-of-media-queries⑨">collection of media queries</a> for which <a data-link-type="dfn" href="#compare-media-queries" id="ref-for-compare-media-queries①">comparing</a> the media query with <var>m</var> returns true.
 If nothing was removed, then <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#notfounderror" id="ref-for-notfounderror">NotFoundError</a></code> exception. 
   </ol>
   <h2 class="heading settled" data-level="5" id="selectors"><span class="secno">5. </span><span class="content">Selectors</span><a class="self-link" href="#selectors"></a></h2>
   <p>Selectors are defined in the Selectors specification. This section
mainly defines how to serialize them.</p>
   <h3 class="heading settled" data-level="5.1" id="parsing-selectors"><span class="secno">5.1. </span><span class="content">Parsing Selectors</span><a class="self-link" href="#parsing-selectors"></a></h3>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="parse-a-group-of-selectors">parse a group of selectors</dfn> means to parse the value using the <code>selectors_group</code> production defined in the Selectors specification and return either a
group of selectors if parsing did not fail or null if parsing did
fail.</p>
   <h3 class="heading settled" data-level="5.2" id="serializing-selectors"><span class="secno">5.2. </span><span class="content">Serializing Selectors</span><a class="self-link" href="#serializing-selectors"></a></h3>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-a-group-of-selectors">serialize a group of selectors</dfn> <a data-link-type="dfn" href="#serialize-a-selector" id="ref-for-serialize-a-selector">serialize</a> each selector in the
group of selectors and then <a data-link-type="dfn" href="#serialize-a-comma-separated-list" id="ref-for-serialize-a-comma-separated-list①">serialize</a> a
comma-separated list of these serializations.</p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-a-selector">serialize a selector</dfn> let <var>s</var> be the empty string, run the steps below for each
part of the chain of the selector, and finally return <var>s</var>:</p>
   <ol>
    <li>If there is only one <a data-link-type="dfn" href="https://drafts.csswg.org/selectors-4/#simple" id="ref-for-simple">simple selector</a> in the <a data-link-type="dfn" href="https://drafts.csswg.org/selectors-4/#compound" id="ref-for-compound">compound selectors</a> which is a <a data-link-type="dfn" href="https://drafts.csswg.org/selectors-4/#universal-selector" id="ref-for-universal-selector">universal selector</a>, append the result of <a data-link-type="dfn" href="#serialize-a-simple-selector" id="ref-for-serialize-a-simple-selector">serializing</a> the <span id="ref-for-universal-selector①">universal selector</span> to <var>s</var>. 
    <li>Otherwise, for each <a data-link-type="dfn" href="https://drafts.csswg.org/selectors-4/#simple" id="ref-for-simple①">simple selector</a> in the <a data-link-type="dfn" href="https://drafts.csswg.org/selectors-4/#compound" id="ref-for-compound①">compound selectors</a> that is not a
 universal selector of which the <a data-link-type="dfn" href="https://drafts.csswg.org/css-namespaces-3/#namespace-prefix" id="ref-for-namespace-prefix">namespace prefix</a> maps to a namespace that is not the <a data-link-type="dfn" href="https://drafts.csswg.org/css-namespaces-3/#default-namespace" id="ref-for-default-namespace">default namespace</a> <a data-link-type="dfn" href="#serialize-a-simple-selector" id="ref-for-serialize-a-simple-selector①">serialize</a> the <span id="ref-for-simple②">simple selector</span> and append the result to <var>s</var>. 
    <li>If this is not the last part of the chain of the selector append a
 single SPACE (U+0020), followed by the combinator
 "<code>></code>",
 "<code>+</code>",
 "<code>~</code>",
 "<code>>></code>",
 "<code>||</code>",
 as appropriate, followed by another single SPACE (U+0020) if the combinator was
 not whitespace, to <var>s</var>. 
    <li>If this is the last part of the chain of the selector and there is
 a pseudo-element, append "<code>::</code>" followed by the name of the
 pseudo-element, to <var>s</var>. 
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-a-simple-selector">serialize a simple selector</dfn> let <var>s</var> be the empty string, run the steps below, and
finally return <var>s</var>:</p>
   <dl class="switch">
    <dt>type selector 
    <dt>universal selector 
    <dd>
     <ol>
      <li>If the <a data-link-type="dfn" href="https://drafts.csswg.org/css-namespaces-3/#namespace-prefix" id="ref-for-namespace-prefix①">namespace prefix</a> maps to a namespace that is
   not the <a data-link-type="dfn" href="https://drafts.csswg.org/css-namespaces-3/#default-namespace" id="ref-for-default-namespace①">default namespace</a> and is not the
   null namespace (not in a namespace) append the <a data-link-type="dfn" href="#serialize-an-identifier" id="ref-for-serialize-an-identifier①">serialization</a> of the <span id="ref-for-namespace-prefix②">namespace prefix</span> as an identifier, followed by a
   "<code>|</code>" (U+007C) to <var>s</var>. 
      <li>If the <a data-link-type="dfn" href="https://drafts.csswg.org/css-namespaces-3/#namespace-prefix" id="ref-for-namespace-prefix③">namespace prefix</a> maps to a namespace that is
   the null namespace (not in a namespace) append
   "<code>|</code>" (U+007C) to <var>s</var>. 
      <li>If this is a type selector append the <a data-link-type="dfn" href="#serialize-an-identifier" id="ref-for-serialize-an-identifier②">serialization</a> of the element name
   as an identifier to <var>s</var>. 
      <li>If this is a universal selector append "<code>*</code>" (U+002A)
   to <var>s</var>. 
     </ol>
    <dt>attribute selector 
    <dd>
     <ol>
      <li>Append "<code>[</code>" (U+005B) to <var>s</var>. 
      <li>If the <a data-link-type="dfn" href="https://drafts.csswg.org/css-namespaces-3/#namespace-prefix" id="ref-for-namespace-prefix④">namespace prefix</a> maps to a namespace that is
   not the null namespace (not in a namespace) append the <a data-link-type="dfn" href="#serialize-an-identifier" id="ref-for-serialize-an-identifier③">serialization</a> of the <span id="ref-for-namespace-prefix⑤">namespace prefix</span> as an identifier, followed by a
   "<code>|</code>" (U+007C) to <var>s</var>. 
      <li>Append the <a data-link-type="dfn" href="#serialize-an-identifier" id="ref-for-serialize-an-identifier④">serialization</a> of the attribute name as an identifier to <var>s</var>. 
      <li>If there is an attribute value specified, append
   "<code>=</code>",
   "<code>~=</code>",
   "<code>|=</code>",
   "<code>^=</code>",
   "<code>$=</code>", or
   "<code>*=</code>"
   as appropriate (depending on the type of attribute selector), followed
   by the <a data-link-type="dfn" href="#serialize-a-string" id="ref-for-serialize-a-string②">serialization</a> of the
   attribute value as a string, to <var>s</var>. 
      <li>If the attribute selector has the case-sensitivity flag present,
   append "<code> i</code>" (U+0020 U+0069) to <var>s</var>. 
      <li>Append "<code>]</code>" (U+005D) to <var>s</var>. 
     </ol>
    <dt>class selector 
    <dd>Append a "<code>.</code>" (U+002E), followed by the <a data-link-type="dfn" href="#serialize-an-identifier" id="ref-for-serialize-an-identifier⑤">serialization</a> of the class name
 as an identifier to <var>s</var>. 
    <dt>ID selector 
    <dd>Append a "<code>#</code>" (U+0023), followed by the <a data-link-type="dfn" href="#serialize-an-identifier" id="ref-for-serialize-an-identifier⑥">serialization</a> of the ID
 as an identifier to <var>s</var>. 
    <dt>pseudo-class 
    <dd>
      If the pseudo-class does not accept arguments append
  "<code>:</code>" (U+003A), followed by the name of the pseudo-class, to <var>s</var>. 
     <p>Otherwise, append "<code>:</code>" (U+003A), followed by the name of
  the pseudo-class, followed by "<code>(</code>" (U+0028), followed by the
  value of the pseudo-class argument(s) determined as per below, followed by
  "<code>)</code>" (U+0029), to <var>s</var>.</p>
     <dl class="switch">
      <dt><code>:lang()</code> 
      <dd>The <a data-link-type="dfn" href="#serialize-a-comma-separated-list" id="ref-for-serialize-a-comma-separated-list②">serialization of a
   comma-separated list</a> of each argument’s <a data-link-type="dfn" href="#serialize-a-string" id="ref-for-serialize-a-string③">serialization as a string</a>, preserving
   relative order. 
      <dt><code>:nth-child()</code> 
      <dt><code>:nth-last-child()</code> 
      <dt><code>:nth-of-type()</code> 
      <dt><code>:nth-last-of-type()</code> 
      <dd>The result of serializing the value using the rules to <a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#serialize-an-anb-value" id="ref-for-serialize-an-anb-value">serialize an &lt;an+b> value</a>. 
      <dt><code>:not()</code> 
      <dd>The result of serializing the value using the rules for <a data-link-type="dfn" href="#serialize-a-group-of-selectors" id="ref-for-serialize-a-group-of-selectors">serializing a group of selectors</a>. 
     </dl>
   </dl>
   <h2 class="heading settled" data-level="6" id="css-object-model"><span class="secno">6. </span><span class="content">CSS</span><a class="self-link" href="#css-object-model"></a></h2>
   <h3 class="heading settled" data-level="6.1" id="css-style-sheets"><span class="secno">6.1. </span><span class="content">CSS Style Sheets</span><a class="self-link" href="#css-style-sheets"></a></h3>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="css-style-sheet">CSS style sheet</dfn> is an abstract concept that
represents a style sheet as defined by the CSS specification. In the CSSOM a <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet">CSS style sheet</a> is represented as a <code class="idl"><a data-link-type="idl" href="#cssstylesheet" id="ref-for-cssstylesheet">CSSStyleSheet</a></code> object. A <span id="ref-for-css-style-sheet①">CSS style sheet</span> has a number of associated state items:</p>
   <dl>
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSStyleSheet" data-dfn-type="dfn" data-noexport id="concept-css-style-sheet-type">type</dfn> 
    <dd>The literal string "<code>text/css</code>". 
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSStyleSheet" data-dfn-type="dfn" data-noexport id="concept-css-style-sheet-location">location</dfn> 
    <dd>Specified when created. The <a data-link-type="dfn" href="https://url.spec.whatwg.org/#absolute-url-string" id="ref-for-absolute-url-string">absolute-URL string</a> of the first request of the <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet②">CSS style sheet</a> or null if the <span id="ref-for-css-style-sheet③">CSS style sheet</span> was
 embedded. Does not change during the lifetime of the <span id="ref-for-css-style-sheet④">CSS style sheet</span>. 
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSStyleSheet" data-dfn-type="dfn" data-noexport id="concept-css-style-sheet-parent-css-style-sheet">parent CSS style sheet</dfn> 
    <dd>Specified when created. The <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet⑤">CSS style sheet</a> that is the parent of the <span id="ref-for-css-style-sheet⑥">CSS style sheet</span> or null if there is no associated parent. 
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSStyleSheet" data-dfn-type="dfn" data-noexport id="concept-css-style-sheet-owner-node">owner node</dfn> 
    <dd>Specified when created. The DOM node associated with the <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet⑦">CSS style sheet</a> or
 null if there is no associated DOM node. 
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSStyleSheet" data-dfn-type="dfn" data-noexport id="concept-css-style-sheet-owner-css-rule">owner CSS rule</dfn> 
    <dd>Specified when created. The <a data-link-type="dfn" href="#css-rule" id="ref-for-css-rule">CSS rule</a> in the <a data-link-type="dfn" href="#concept-css-style-sheet-parent-css-style-sheet" id="ref-for-concept-css-style-sheet-parent-css-style-sheet">parent CSS style sheet</a> that caused the inclusion of the <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet⑧">CSS style sheet</a> or null if
 there is no associated rule. 
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSStyleSheet" data-dfn-type="dfn" data-noexport id="concept-css-style-sheet-media">media</dfn> 
    <dd>
      Specified when created. The <code class="idl"><a data-link-type="idl" href="#medialist" id="ref-for-medialist①">MediaList</a></code> object associated with the <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet⑨">CSS style sheet</a>. 
     <p>If this property is specified to a string, the <a data-link-type="dfn" href="#concept-css-style-sheet-media" id="ref-for-concept-css-style-sheet-media">media</a> must be set to the return value of invoking <a data-link-type="dfn" href="#create-a-medialist-object" id="ref-for-create-a-medialist-object">create a <code>MediaList</code> object</a> steps for that string.</p>
     <p>If this property is specified to an attribute of the <a data-link-type="dfn" href="#concept-css-style-sheet-owner-node" id="ref-for-concept-css-style-sheet-owner-node">owner node</a>, the <a data-link-type="dfn" href="#concept-css-style-sheet-media" id="ref-for-concept-css-style-sheet-media①">media</a> must be set to the return value of invoking <a data-link-type="dfn" href="#create-a-medialist-object" id="ref-for-create-a-medialist-object①">create a <code>MediaList</code> object</a> steps
  for the value of that attribute. Whenever the attribute is set, changed or removed, the <span id="ref-for-concept-css-style-sheet-media②">media</span>’s <code class="idl"><a data-link-type="idl" href="#dom-medialist-mediatext" id="ref-for-dom-medialist-mediatext③">mediaText</a></code> attribute must be set to the new value of the attribute, or to null if the attribute is absent.</p>
     <p class="note" role="note"><span>Note:</span> Changing the <a data-link-type="dfn" href="#concept-css-style-sheet-media" id="ref-for-concept-css-style-sheet-media③">media</a>’s <code class="idl"><a data-link-type="idl" href="#dom-medialist-mediatext" id="ref-for-dom-medialist-mediatext④">mediaText</a></code> attribute does not
  change the corresponding attribute on the <a data-link-type="dfn" href="#concept-css-style-sheet-owner-node" id="ref-for-concept-css-style-sheet-owner-node①">owner node</a>.</p>
     <p class="note" role="note"><span>Note:</span> The <a data-link-type="dfn" href="#concept-css-style-sheet-owner-node" id="ref-for-concept-css-style-sheet-owner-node②">owner node</a> of a <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet①⓪">CSS style sheet</a>, if non-null, is the node whose <a data-link-type="dfn" href="#associated-css-style-sheet" id="ref-for-associated-css-style-sheet">associated
  CSS style sheet</a> is the <span id="ref-for-css-style-sheet①①">CSS style sheet</span> in question, when the <span id="ref-for-css-style-sheet①②">CSS style sheet</span> is <a data-link-type="dfn" href="#add-a-css-style-sheet" id="ref-for-add-a-css-style-sheet">added</a>.</p>
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSStyleSheet" data-dfn-type="dfn" data-noexport id="concept-css-style-sheet-title">title</dfn> 
    <dd>
      Specified when created. The title of the <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet①③">CSS style sheet</a>, which can be the empty string. 
     <div class="example" id="example-a945fdba">
      <a class="self-link" href="#example-a945fdba"></a> In the following, the <a data-link-type="dfn" href="#concept-css-style-sheet-title" id="ref-for-concept-css-style-sheet-title">title</a> is non-empty
   for the first style sheet, but is empty for the second and third style sheets. 
<pre>&lt;style title="papaya whip">
  body { background: #ffefd5; }
&lt;/style>
</pre>
<pre>&lt;style title="">
  body { background: orange; }
&lt;/style>
</pre>
<pre>&lt;style>
  body { background: brown; }
&lt;/style>
</pre>
     </div>
     <p>If this property is specified to an attribute of the <a data-link-type="dfn" href="#concept-css-style-sheet-owner-node" id="ref-for-concept-css-style-sheet-owner-node③">owner node</a>, the <a data-link-type="dfn" href="#concept-css-style-sheet-title" id="ref-for-concept-css-style-sheet-title①">title</a> must be set to the value of that attribute. Whenever the attribute is set, changed or removed, the <span id="ref-for-concept-css-style-sheet-title②">title</span> must be set to the new value of the attribute, or to the empty string if the attribute is absent.</p>
     <p class="note" role="note"><span>Note:</span> HTML only <a href="https://html.spec.whatwg.org/#the-style-element:concept-css-style-sheet-title">specifies</a> <a data-link-type="dfn" href="#concept-css-style-sheet-title" id="ref-for-concept-css-style-sheet-title③">title</a> to be an attribute of the <a data-link-type="dfn" href="#concept-css-style-sheet-owner-node" id="ref-for-concept-css-style-sheet-owner-node④">owner node</a> if the node is in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#in-a-document-tree" id="ref-for-in-a-document-tree">in a document tree</a>.</p>
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSStyleSheet" data-dfn-type="dfn" data-noexport id="concept-css-style-sheet-alternate-flag">alternate flag</dfn> 
    <dd>
      Specified when created. Either set or unset. Unset by default. 
     <div class="example" id="example-cd0d9c55">
      <a class="self-link" href="#example-cd0d9c55"></a> The following <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet①④">CSS style sheets</a> have
   their <a data-link-type="dfn" href="#concept-css-style-sheet-alternate-flag" id="ref-for-concept-css-style-sheet-alternate-flag">alternate flag</a> set: 
<pre>&lt;?xml-stylesheet alternate="yes" title="x" href="data:text/css,…"?></pre>
<pre>&lt;link rel="alternate stylesheet" title="x" href="data:text/css,…"></pre>
     </div>
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSStyleSheet" data-dfn-type="dfn" data-noexport id="concept-css-style-sheet-disabled-flag">disabled flag</dfn> 
    <dd>
      Either set or unset. Unset by default. 
     <p class="note" role="note"><span>Note:</span> Even when unset it does not necessarily mean that the <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet①⑤">CSS style sheet</a> is actually used for rendering.</p>
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSStyleSheet" data-dfn-type="dfn" data-noexport id="concept-css-style-sheet-css-rules">CSS rules</dfn> 
    <dd>The CSS rules associated with the <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet①⑥">CSS style sheet</a>. 
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSStyleSheet" data-dfn-type="dfn" data-noexport id="concept-css-style-sheet-origin-clean-flag">origin-clean flag</dfn> 
    <dd>Specified when created. Either set or unset. If it is set, the API allows reading and modifying of the <a data-link-type="dfn" href="#concept-css-style-sheet-css-rules" id="ref-for-concept-css-style-sheet-css-rules">CSS rules</a>. 
   </dl>
   <h4 class="heading settled" data-level="6.1.1" id="the-stylesheet-interface"><span class="secno">6.1.1. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#stylesheet" id="ref-for-stylesheet">StyleSheet</a></code> Interface</span><a class="self-link" href="#the-stylesheet-interface"></a></h4>
   <p>The <code class="idl"><a data-link-type="idl" href="#stylesheet" id="ref-for-stylesheet①">StyleSheet</a></code> interface represents an abstract, base style sheet.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed①"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="stylesheet"><code><c- g>StyleSheet</c-></code></dfn> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring④"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#dom-stylesheet-type" id="ref-for-dom-stylesheet-type"><c- g>type</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString③"><c- b>USVString</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString?" href="#dom-stylesheet-href" id="ref-for-dom-stylesheet-href"><c- g>href</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> (<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element" id="ref-for-element"><c- n>Element</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#processinginstruction" id="ref-for-processinginstruction"><c- n>ProcessingInstruction</c-></a>)? <a class="idl-code" data-link-type="attribute" data-readonly data-type="(Element or ProcessingInstruction)?" href="#dom-stylesheet-ownernode" id="ref-for-dom-stylesheet-ownernode"><c- g>ownerNode</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssstylesheet" id="ref-for-cssstylesheet①"><c- n>CSSStyleSheet</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleSheet?" href="#dom-stylesheet-parentstylesheet" id="ref-for-dom-stylesheet-parentstylesheet"><c- g>parentStyleSheet</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString②"><c- b>DOMString</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="DOMString?" href="#dom-stylesheet-title" id="ref-for-dom-stylesheet-title"><c- g>title</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#PutForwards" id="ref-for-PutForwards"><c- g>PutForwards</c-></a>=<a class="idl-code" data-link-type="attribute" href="#dom-medialist-mediatext" id="ref-for-dom-medialist-mediatext⑤"><c- n>mediaText</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#medialist" id="ref-for-medialist②"><c- n>MediaList</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="MediaList" href="#dom-stylesheet-media" id="ref-for-dom-stylesheet-media"><c- g>media</c-></a>;
  <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-type="boolean" href="#dom-stylesheet-disabled" id="ref-for-dom-stylesheet-disabled"><c- g>disabled</c-></a>;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="StyleSheet" data-dfn-type="attribute" data-export id="dom-stylesheet-type"><code>type</code></dfn> attribute must return the <a data-link-type="dfn" href="#concept-css-style-sheet-type" id="ref-for-concept-css-style-sheet-type">type</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="StyleSheet" data-dfn-type="attribute" data-export id="dom-stylesheet-href"><code>href</code></dfn> attribute must return the <a data-link-type="dfn" href="#concept-css-style-sheet-location" id="ref-for-concept-css-style-sheet-location">location</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="StyleSheet" data-dfn-type="attribute" data-export id="dom-stylesheet-ownernode"><code>ownerNode</code></dfn> attribute must return the <a data-link-type="dfn" href="#concept-css-style-sheet-owner-node" id="ref-for-concept-css-style-sheet-owner-node⑤">owner node</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="StyleSheet" data-dfn-type="attribute" data-export id="dom-stylesheet-parentstylesheet"><code>parentStyleSheet</code></dfn> attribute must return the <a data-link-type="dfn" href="#concept-css-style-sheet-parent-css-style-sheet" id="ref-for-concept-css-style-sheet-parent-css-style-sheet①">parent CSS style sheet</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="StyleSheet" data-dfn-type="attribute" data-export id="dom-stylesheet-title"><code>title</code></dfn> attribute must return the <a data-link-type="dfn" href="#concept-css-style-sheet-title" id="ref-for-concept-css-style-sheet-title④">title</a> or null if <span id="ref-for-concept-css-style-sheet-title⑤">title</span> is the empty string.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="StyleSheet" data-dfn-type="attribute" data-export id="dom-stylesheet-media"><code>media</code></dfn> attribute must return the <a data-link-type="dfn" href="#concept-css-style-sheet-media" id="ref-for-concept-css-style-sheet-media④">media</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="StyleSheet" data-dfn-type="attribute" data-export id="dom-stylesheet-disabled"><code>disabled</code></dfn> attribute, on getting, must return true if the <a data-link-type="dfn" href="#concept-css-style-sheet-disabled-flag" id="ref-for-concept-css-style-sheet-disabled-flag">disabled flag</a> is set, or false otherwise. On setting, the <code class="idl"><a data-link-type="idl" href="#dom-stylesheet-disabled" id="ref-for-dom-stylesheet-disabled①">disabled</a></code> attribute must set the <span id="ref-for-concept-css-style-sheet-disabled-flag①">disabled flag</span> if the new value is true, or unset the <span id="ref-for-concept-css-style-sheet-disabled-flag②">disabled flag</span> otherwise.</p>
   <h4 class="heading settled" data-level="6.1.2" id="the-cssstylesheet-interface"><span class="secno">6.1.2. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#cssstylesheet" id="ref-for-cssstylesheet②">CSSStyleSheet</a></code> Interface</span><a class="self-link" href="#the-cssstylesheet-interface"></a></h4>
   <p>The <code class="idl"><a data-link-type="idl" href="#cssstylesheet" id="ref-for-cssstylesheet③">CSSStyleSheet</a></code> interface represents a <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet①⑦">CSS style sheet</a>.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed②"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="cssstylesheet"><code><c- g>CSSStyleSheet</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#stylesheet" id="ref-for-stylesheet②"><c- n>StyleSheet</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssrule" id="ref-for-cssrule"><c- n>CSSRule</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSRule?" href="#dom-cssstylesheet-ownerrule" id="ref-for-dom-cssstylesheet-ownerrule"><c- g>ownerRule</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject①"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssrulelist" id="ref-for-cssrulelist"><c- n>CSSRuleList</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSRuleList" href="#dom-cssstylesheet-cssrules" id="ref-for-dom-cssstylesheet-cssrules"><c- g>cssRules</c-></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long②"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="method" href="#dom-cssstylesheet-insertrule" id="ref-for-dom-cssstylesheet-insertrule"><c- g>insertRule</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring⑤"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleSheet/insertRule(rule, index), CSSStyleSheet/insertRule(rule)" data-dfn-type="argument" data-export id="dom-cssstylesheet-insertrule-rule-index-rule"><code><c- g>rule</c-></code><a class="self-link" href="#dom-cssstylesheet-insertrule-rule-index-rule"></a></dfn>, <c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long③"><c- b>unsigned</c-> <c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleSheet/insertRule(rule, index), CSSStyleSheet/insertRule(rule)" data-dfn-type="argument" data-export id="dom-cssstylesheet-insertrule-rule-index-index"><code><c- g>index</c-></code><a class="self-link" href="#dom-cssstylesheet-insertrule-rule-index-index"></a></dfn> = 0);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-cssstylesheet-deleterule" id="ref-for-dom-cssstylesheet-deleterule"><c- g>deleteRule</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long④"><c- b>unsigned</c-> <c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleSheet/deleteRule(index)" data-dfn-type="argument" data-export id="dom-cssstylesheet-deleterule-index-index"><code><c- g>index</c-></code><a class="self-link" href="#dom-cssstylesheet-deleterule-index-index"></a></dfn>);
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleSheet" data-dfn-type="attribute" data-export id="dom-cssstylesheet-ownerrule"><code>ownerRule</code></dfn> attribute must return the <a data-link-type="dfn" href="#concept-css-style-sheet-owner-css-rule" id="ref-for-concept-css-style-sheet-owner-css-rule">owner CSS rule</a>.
If a value other than null is ever returned, then that same value must always be returned on each get access.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleSheet" data-dfn-type="attribute" data-export id="dom-cssstylesheet-cssrules"><code>cssRules</code></dfn> attribute must follow these steps:</p>
   <ol>
    <li>If the <a data-link-type="dfn" href="#concept-css-style-sheet-origin-clean-flag" id="ref-for-concept-css-style-sheet-origin-clean-flag">origin-clean flag</a> is unset, <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#securityerror" id="ref-for-securityerror">SecurityError</a></code> exception. 
    <li>
     Return a read-only, live <code class="idl"><a data-link-type="idl" href="#cssrulelist" id="ref-for-cssrulelist①">CSSRuleList</a></code> object representing
 the <a data-link-type="dfn" href="#concept-css-style-sheet-css-rules" id="ref-for-concept-css-style-sheet-css-rules①">CSS rules</a>. 
     <p class="note" role="note"><span>Note:</span> Even though the returned <code class="idl"><a data-link-type="idl" href="#cssrulelist" id="ref-for-cssrulelist②">CSSRuleList</a></code> object is read-only (from the perspective of
 client-authored script), it can nevertheless change over time due to its liveness status. For example, invoking
 the <code class="idl"><a data-link-type="idl" href="#dom-cssstylesheet-insertrule" id="ref-for-dom-cssstylesheet-insertrule①">insertRule()</a></code> or <code class="idl"><a data-link-type="idl" href="#dom-cssstylesheet-deleterule" id="ref-for-dom-cssstylesheet-deleterule①">deleteRule()</a></code> methods can result in
 mutations reflected in the returned object.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleSheet" data-dfn-type="method" data-export data-lt="insertRule(rule, index)|insertRule(rule)" id="dom-cssstylesheet-insertrule"><code>insertRule(<var>rule</var>, <var>index</var>)</code></dfn> method must run the following steps:</p>
   <ol>
    <li>If the <a data-link-type="dfn" href="#concept-css-style-sheet-origin-clean-flag" id="ref-for-concept-css-style-sheet-origin-clean-flag①">origin-clean flag</a> is unset, <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw②">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#securityerror" id="ref-for-securityerror①">SecurityError</a></code> exception. 
    <li>Return the result of invoking <a data-link-type="dfn" href="#insert-a-css-rule" id="ref-for-insert-a-css-rule">insert a CSS rule</a> <var>rule</var> in the <a data-link-type="dfn" href="#concept-css-style-sheet-css-rules" id="ref-for-concept-css-style-sheet-css-rules②">CSS rules</a> at <var>index</var>. 
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleSheet" data-dfn-type="method" data-export id="dom-cssstylesheet-deleterule"><code>deleteRule(<var>index</var>)</code></dfn> method must run the following steps:</p>
   <ol>
    <li>If the <a data-link-type="dfn" href="#concept-css-style-sheet-origin-clean-flag" id="ref-for-concept-css-style-sheet-origin-clean-flag②">origin-clean flag</a> is unset, <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw③">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#securityerror" id="ref-for-securityerror②">SecurityError</a></code> exception. 
    <li><a data-link-type="dfn" href="#remove-a-css-rule" id="ref-for-remove-a-css-rule">Remove a CSS rule</a> in the <a data-link-type="dfn" href="#concept-css-style-sheet-css-rules" id="ref-for-concept-css-style-sheet-css-rules③">CSS rules</a> at <var>index</var>. 
   </ol>
   <h5 class="heading settled" data-level="6.1.2.1" id="legacy-css-style-sheet-members"><span class="secno">6.1.2.1. </span><span class="content">Deprecated CSSStyleSheet members</span><a class="self-link" href="#legacy-css-style-sheet-members"></a></h5>
   <p class="note" role="note"><span>Note:</span> These members are required for compatibility with existing sites.</p>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="#cssstylesheet" id="ref-for-cssstylesheet④"><c- g>CSSStyleSheet</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject②"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssrulelist" id="ref-for-cssrulelist③"><c- n>CSSRuleList</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSRuleList" href="#dom-cssstylesheet-rules" id="ref-for-dom-cssstylesheet-rules"><c- g>rules</c-></a>;
  <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="method" href="#dom-cssstylesheet-addrule" id="ref-for-dom-cssstylesheet-addrule"><c- g>addRule</c-></a>(<c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString③"><c- b>DOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleSheet/addRule(selector, style, index), CSSStyleSheet/addRule(selector, style), CSSStyleSheet/addRule(selector), CSSStyleSheet/addRule()" data-dfn-type="argument" data-export id="dom-cssstylesheet-addrule-selector-style-index-selector"><code><c- g>selector</c-></code><a class="self-link" href="#dom-cssstylesheet-addrule-selector-style-index-selector"></a></dfn> = "undefined", <c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString" id="ref-for-idl-DOMString④"><c- b>DOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleSheet/addRule(selector, style, index), CSSStyleSheet/addRule(selector, style), CSSStyleSheet/addRule(selector), CSSStyleSheet/addRule()" data-dfn-type="argument" data-export id="dom-cssstylesheet-addrule-selector-style-index-style"><code><c- g>style</c-></code><a class="self-link" href="#dom-cssstylesheet-addrule-selector-style-index-style"></a></dfn> = "undefined", <c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long⑤"><c- b>unsigned</c-> <c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleSheet/addRule(selector, style, index), CSSStyleSheet/addRule(selector, style), CSSStyleSheet/addRule(selector), CSSStyleSheet/addRule()" data-dfn-type="argument" data-export id="dom-cssstylesheet-addrule-selector-style-index-index"><code><c- g>index</c-></code><a class="self-link" href="#dom-cssstylesheet-addrule-selector-style-index-index"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-cssstylesheet-removerule" id="ref-for-dom-cssstylesheet-removerule"><c- g>removeRule</c-></a>(<c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long⑥"><c- b>unsigned</c-> <c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleSheet/removeRule(index), CSSStyleSheet/removeRule()" data-dfn-type="argument" data-export id="dom-cssstylesheet-removerule-index-index"><code><c- g>index</c-></code><a class="self-link" href="#dom-cssstylesheet-removerule-index-index"></a></dfn> = 0);
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleSheet" data-dfn-type="attribute" data-export id="dom-cssstylesheet-rules"><code>rules</code></dfn> attribute must follow the same steps as <code class="idl"><a data-link-type="idl" href="#dom-cssstylesheet-cssrules" id="ref-for-dom-cssstylesheet-cssrules①">cssRules</a></code>, and return the same object <code class="idl"><a data-link-type="idl" href="#dom-cssstylesheet-cssrules" id="ref-for-dom-cssstylesheet-cssrules②">cssRules</a></code> would return.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleSheet" data-dfn-type="method" data-export data-lt="removeRule(index)|removeRule()" id="dom-cssstylesheet-removerule"><code>removeRule(<var>index</var>)</code></dfn> method must run the same steps as <code class="idl"><a data-link-type="idl" href="#dom-cssstylesheet-deleterule" id="ref-for-dom-cssstylesheet-deleterule②">deleteRule()</a></code>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleSheet" data-dfn-type="method" data-export data-lt="addRule(selector, style, index)|addRule(selector, style)|addRule(selector)|addRule()|addRule(selector, block, optionalIndex)" id="dom-cssstylesheet-addrule"><code>addRule(<var>selector</var>, <var>block</var>, <var>optionalIndex</var>)</code></dfn> method must run the following steps:</p>
   <ol>
    <li>Let <var>rule</var> be an empty string. 
    <li>Append <var>selector</var> to <var>rule</var>. 
    <li>Append <code>" { "</code> to <var>rule</var>. 
    <li>If <var>block</var> is not empty, append <var>block</var>, followed by a space, to <var>rule</var>. 
    <li>Append <code>"}"</code> to <var>rule</var> 
    <li>Let <var>index</var> be <var>optionalIndex</var> if provided, or the number of <a data-link-type="dfn" href="#concept-css-style-sheet-css-rules" id="ref-for-concept-css-style-sheet-css-rules④">CSS rules</a> in the stylesheet otherwise. 
    <li>Call <code class="idl"><a data-link-type="idl" href="#dom-cssstylesheet-insertrule" id="ref-for-dom-cssstylesheet-insertrule②">insertRule()</a></code>, with <var>rule</var> and <var>index</var> as arguments. 
    <li>Return <code>-1</code>. 
   </ol>
   <p class="advisement"> Authors should not use these members
  and should instead use and teach the standard <code class="idl"><a data-link-type="idl" href="#cssstylesheet" id="ref-for-cssstylesheet⑤">CSSStyleSheet</a></code> interface defined earlier,
  which is consistent with <code class="idl"><a data-link-type="idl" href="#cssgroupingrule" id="ref-for-cssgroupingrule">CSSGroupingRule</a></code>. </p>
   <h3 class="heading settled" data-level="6.2" id="css-style-sheet-collections"><span class="secno">6.2. </span><span class="content">CSS Style Sheet Collections</span><a class="self-link" href="#css-style-sheet-collections"></a></h3>
   <p>Below various new concepts are defined that are associated with each <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#documentorshadowroot" id="ref-for-documentorshadowroot">DocumentOrShadowRoot</a></code> object.</p>
   <p>Each <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#documentorshadowroot" id="ref-for-documentorshadowroot①">DocumentOrShadowRoot</a></code> has an associated list of zero or more <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet①⑧">CSS style sheets</a>, named the <dfn class="dfn-paneled" data-dfn-for="DocumentOrShadowRoot" data-dfn-type="dfn" data-export id="documentorshadowroot-document-or-shadow-root-css-style-sheets">document or shadow root CSS style sheets</dfn>. This is
an ordered list that contains all <span id="ref-for-css-style-sheet①⑨">CSS style sheets</span> associated with the <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#documentorshadowroot" id="ref-for-documentorshadowroot②">DocumentOrShadowRoot</a></code>, in <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#tree-order" id="ref-for-tree-order">tree order</a>, with <span id="ref-for-css-style-sheet②⓪">CSS style sheets</span> created from HTTP <code>Link</code> headers first, if any, in header
order.</p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="create-a-css-style-sheet">create a CSS style sheet</dfn>, run these
steps:</p>
   <ol>
    <li>Create a new <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet②①">CSS style sheet</a> object and set its
 properties as specified. 
    <li>
      Then run the <a data-link-type="dfn" href="#add-a-css-style-sheet" id="ref-for-add-a-css-style-sheet①">add a CSS style sheet</a> steps for the newly created <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet②②">CSS style sheet</a>. 
     <p class="warning">If the <a data-link-type="dfn" href="#concept-css-style-sheet-origin-clean-flag" id="ref-for-concept-css-style-sheet-origin-clean-flag③">origin-clean flag</a> is unset, this can expose information from the user’s
  intranet. </p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="add-a-css-style-sheet">add a CSS style sheet</dfn>, run these
steps:</p>
   <ol>
    <li>Add the <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet②③">CSS style sheet</a> to the list of <a data-link-type="dfn" href="#documentorshadowroot-document-or-shadow-root-css-style-sheets" id="ref-for-documentorshadowroot-document-or-shadow-root-css-style-sheets">document or shadow root CSS style sheets</a> at the appropriate location. The
 remainder of these steps deal with the <a data-link-type="dfn" href="#concept-css-style-sheet-disabled-flag" id="ref-for-concept-css-style-sheet-disabled-flag③">disabled flag</a>. 
    <li>If the <a data-link-type="dfn" href="#concept-css-style-sheet-disabled-flag" id="ref-for-concept-css-style-sheet-disabled-flag④">disabled flag</a> is set, then return. 
    <li>If the <a data-link-type="dfn" href="#concept-css-style-sheet-title" id="ref-for-concept-css-style-sheet-title⑥">title</a> is not the empty string, the <a data-link-type="dfn" href="#concept-css-style-sheet-alternate-flag" id="ref-for-concept-css-style-sheet-alternate-flag①">alternate flag</a> is unset, and <a data-link-type="dfn" href="#preferred-css-style-sheet-set-name" id="ref-for-preferred-css-style-sheet-set-name">preferred CSS style sheet set name</a> is the empty string <a data-link-type="dfn" href="#change-the-preferred-css-style-sheet-set-name" id="ref-for-change-the-preferred-css-style-sheet-set-name">change the preferred CSS style sheet set name</a> to the <span id="ref-for-concept-css-style-sheet-title⑦">title</span>. 
    <li>
      If any of the following is true, then unset the <a data-link-type="dfn" href="#concept-css-style-sheet-disabled-flag" id="ref-for-concept-css-style-sheet-disabled-flag⑤">disabled flag</a> and return: 
     <ul>
      <li>The <a data-link-type="dfn" href="#concept-css-style-sheet-title" id="ref-for-concept-css-style-sheet-title⑧">title</a> is the empty string. 
      <li>The <a data-link-type="dfn" href="#last-css-style-sheet-set-name" id="ref-for-last-css-style-sheet-set-name">last CSS style sheet set name</a> is null and the <a data-link-type="dfn" href="#concept-css-style-sheet-title" id="ref-for-concept-css-style-sheet-title⑨">title</a> is a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive②">case-sensitive</a> match
   for the <a data-link-type="dfn" href="#preferred-css-style-sheet-set-name" id="ref-for-preferred-css-style-sheet-set-name①">preferred CSS style sheet set name</a>. 
      <li>The <a data-link-type="dfn" href="#concept-css-style-sheet-title" id="ref-for-concept-css-style-sheet-title①⓪">title</a> is a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive③">case-sensitive</a> match for the <a data-link-type="dfn" href="#last-css-style-sheet-set-name" id="ref-for-last-css-style-sheet-set-name①">last CSS style sheet set name</a>. 
     </ul>
    <li>Set the <a data-link-type="dfn" href="#concept-css-style-sheet-disabled-flag" id="ref-for-concept-css-style-sheet-disabled-flag⑥">disabled flag</a>. 
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="remove-a-css-style-sheet">remove a CSS style sheet</dfn>, run these steps:</p>
   <ol>
    <li>Remove the <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet②④">CSS style sheet</a> from the list of <a data-link-type="dfn" href="#documentorshadowroot-document-or-shadow-root-css-style-sheets" id="ref-for-documentorshadowroot-document-or-shadow-root-css-style-sheets①">document or shadow root CSS style sheets</a>. 
    <li>Set the <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet②⑤">CSS style sheet</a>’s <a data-link-type="dfn" href="#concept-css-style-sheet-parent-css-style-sheet" id="ref-for-concept-css-style-sheet-parent-css-style-sheet②">parent CSS style sheet</a>, <a data-link-type="dfn" href="#concept-css-style-sheet-owner-node" id="ref-for-concept-css-style-sheet-owner-node⑥">owner node</a> and <a data-link-type="dfn" href="#concept-css-style-sheet-owner-css-rule" id="ref-for-concept-css-style-sheet-owner-css-rule①">owner CSS rule</a> to null. 
   </ol>
   <p>A <dfn data-dfn-type="dfn" data-export id="persistent-css-style-sheet">persistent CSS style sheet<a class="self-link" href="#persistent-css-style-sheet"></a></dfn> is a <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet②⑥">CSS style sheet</a> from the <a data-link-type="dfn" href="#documentorshadowroot-document-or-shadow-root-css-style-sheets" id="ref-for-documentorshadowroot-document-or-shadow-root-css-style-sheets②">document or shadow root CSS style sheets</a> whose <a data-link-type="dfn" href="#concept-css-style-sheet-title" id="ref-for-concept-css-style-sheet-title①①">title</a> is the empty string and whose <a data-link-type="dfn" href="#concept-css-style-sheet-alternate-flag" id="ref-for-concept-css-style-sheet-alternate-flag②">alternate flag</a> is unset.</p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="css-style-sheet-set">CSS style sheet set</dfn> is an ordered
collection of one or more <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet②⑦">CSS style sheets</a> from the <a data-link-type="dfn" href="#documentorshadowroot-document-or-shadow-root-css-style-sheets" id="ref-for-documentorshadowroot-document-or-shadow-root-css-style-sheets③">document or shadow root CSS style sheets</a> which have an identical <a data-link-type="dfn" href="#concept-css-style-sheet-title" id="ref-for-concept-css-style-sheet-title①②">title</a> that is not the empty string.</p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="css-style-sheet-set-name">CSS style sheet set name</dfn> is the <a data-link-type="dfn" href="#concept-css-style-sheet-title" id="ref-for-concept-css-style-sheet-title①③">title</a> the <a data-link-type="dfn" href="#css-style-sheet-set" id="ref-for-css-style-sheet-set">CSS style sheet set</a> has in
common.</p>
   <p>An <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="enabled-css-style-sheet-set">enabled CSS style sheet set</dfn> is a <a data-link-type="dfn" href="#css-style-sheet-set" id="ref-for-css-style-sheet-set①">CSS style sheet set</a> of which each <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet②⑧">CSS style sheet</a> has
its <a data-link-type="dfn" href="#concept-css-style-sheet-disabled-flag" id="ref-for-concept-css-style-sheet-disabled-flag⑦">disabled flag</a> unset.</p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="enable-a-css-style-sheet-set">enable a CSS style sheet set</dfn> with name <var>name</var>, run these steps:</p>
   <ol>
    <li>If <var>name</var> is the empty string, set the <a data-link-type="dfn" href="#concept-css-style-sheet-disabled-flag" id="ref-for-concept-css-style-sheet-disabled-flag⑧">disabled flag</a> for each <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet②⑨">CSS style sheet</a> that is in a <a data-link-type="dfn" href="#css-style-sheet-set" id="ref-for-css-style-sheet-set②">CSS style sheet set</a> and return. 
    <li>Unset the <a data-link-type="dfn" href="#concept-css-style-sheet-disabled-flag" id="ref-for-concept-css-style-sheet-disabled-flag⑨">disabled flag</a> for each <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet③⓪">CSS style sheet</a> in a <a data-link-type="dfn" href="#css-style-sheet-set" id="ref-for-css-style-sheet-set③">CSS style sheet set</a> whose <a data-link-type="dfn" href="#css-style-sheet-set-name" id="ref-for-css-style-sheet-set-name">CSS style sheet set name</a> is a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive④">case-sensitive</a> match for <var>name</var> and set it for all other <span id="ref-for-css-style-sheet③①">CSS style sheets</span> in a <span id="ref-for-css-style-sheet-set④">CSS style sheet set</span>. 
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="select-a-css-style-sheet-set">select a CSS style sheet set</dfn> with name <var>name</var>, run these steps:</p>
   <ol>
    <li><a data-link-type="dfn" href="#enable-a-css-style-sheet-set" id="ref-for-enable-a-css-style-sheet-set">enable a CSS style sheet set</a> with name <var>name</var>. 
    <li>Set <a data-link-type="dfn" href="#last-css-style-sheet-set-name" id="ref-for-last-css-style-sheet-set-name②">last CSS style sheet set name</a> to <var>name</var>. 
   </ol>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="last-css-style-sheet-set-name">last CSS style sheet set name</dfn> is a concept to determine what <a data-link-type="dfn" href="#css-style-sheet-set" id="ref-for-css-style-sheet-set⑤">CSS style sheet set</a> was last <a data-link-type="dfn" href="#select-a-css-style-sheet-set" id="ref-for-select-a-css-style-sheet-set">selected</a>. Initially its
value is null.</p>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="preferred-css-style-sheet-set-name">preferred CSS style sheet set name</dfn> is a concept to determine which <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet③②">CSS style sheets</a> need to have their <a data-link-type="dfn" href="#concept-css-style-sheet-disabled-flag" id="ref-for-concept-css-style-sheet-disabled-flag①⓪">disabled flag</a> unset. Initially its value
is the empty string.</p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="change-the-preferred-css-style-sheet-set-name">change the preferred CSS style sheet set name</dfn> with name <var>name</var>, run these steps:</p>
   <ol>
    <li>Let <var>current</var> be the <a data-link-type="dfn" href="#preferred-css-style-sheet-set-name" id="ref-for-preferred-css-style-sheet-set-name②">preferred CSS style sheet set name</a>. 
    <li>Set <a data-link-type="dfn" href="#preferred-css-style-sheet-set-name" id="ref-for-preferred-css-style-sheet-set-name③">preferred CSS style sheet set name</a> to <var>name</var>. 
    <li>If <var>name</var> is not a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive⑤">case-sensitive</a> match for <var>current</var> and <a data-link-type="dfn" href="#last-css-style-sheet-set-name" id="ref-for-last-css-style-sheet-set-name③">last CSS style sheet set name</a> is null <a data-link-type="dfn" href="#enable-a-css-style-sheet-set" id="ref-for-enable-a-css-style-sheet-set①">enable a CSS style sheet set</a> with name <var>name</var>. 
   </ol>
   <h4 class="heading settled" data-level="6.2.1" id="the-http-default-style-header"><span class="secno">6.2.1. </span><span class="content">The HTTP Default-Style Header</span><a class="self-link" href="#the-http-default-style-header"></a></h4>
   <p>The HTTP <a data-link-type="dfn" href="#http-default-style" id="ref-for-http-default-style">Default-Style</a> header
can be used to set the <a data-link-type="dfn" href="#preferred-css-style-sheet-set-name" id="ref-for-preferred-css-style-sheet-set-name④">preferred CSS style sheet set name</a> influencing which <a data-link-type="dfn" href="#css-style-sheet-set" id="ref-for-css-style-sheet-set⑥">CSS style sheet set</a> is (initially) the <a data-link-type="dfn" href="#enabled-css-style-sheet-set" id="ref-for-enabled-css-style-sheet-set">enabled CSS style sheet set</a>.</p>
   <p>For each HTTP <a data-link-type="dfn" href="#http-default-style" id="ref-for-http-default-style①">Default-Style</a> header, in header order, the user agent must <a data-link-type="dfn" href="#change-the-preferred-css-style-sheet-set-name" id="ref-for-change-the-preferred-css-style-sheet-set-name①">change the preferred CSS style sheet set name</a> with name being the
value of the header.</p>
   <h4 class="heading settled" data-level="6.2.2" id="the-stylesheetlist-interface"><span class="secno">6.2.2. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#stylesheetlist" id="ref-for-stylesheetlist">StyleSheetList</a></code> Interface</span><a class="self-link" href="#the-stylesheetlist-interface"></a></h4>
   <p>The <code class="idl"><a data-link-type="idl" href="#stylesheetlist" id="ref-for-stylesheetlist①">StyleSheetList</a></code> interface represents an ordered collection of <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet③③">CSS style sheets</a>.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed③"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="stylesheetlist"><code><c- g>StyleSheetList</c-></code></dfn> {
  <c- b>getter</c-> <a class="n" data-link-type="idl-name" href="#cssstylesheet" id="ref-for-cssstylesheet⑥"><c- n>CSSStyleSheet</c-></a>? <a class="idl-code" data-link-type="method" href="#dom-stylesheetlist-item" id="ref-for-dom-stylesheetlist-item"><c- g>item</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long⑦"><c- b>unsigned</c-> <c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="StyleSheetList/item(index)" data-dfn-type="argument" data-export id="dom-stylesheetlist-item-index-index"><code><c- g>index</c-></code><a class="self-link" href="#dom-stylesheetlist-item-index-index"></a></dfn>);
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long⑧"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned long" href="#dom-stylesheetlist-length" id="ref-for-dom-stylesheetlist-length"><c- g>length</c-></a>;
};
</pre>
   <p>The object’s <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-supported-property-indices" id="ref-for-dfn-supported-property-indices②">supported property indices</a> are the numbers in the range zero to one less than the number of <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet③④">CSS style sheets</a> represented by the collection. If there are no such <span id="ref-for-css-style-sheet③⑤">CSS style sheets</span>,
then there are no <span id="ref-for-dfn-supported-property-indices③">supported property indices</span>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="StyleSheetList" data-dfn-type="method" data-export id="dom-stylesheetlist-item"><code>item(<var>index</var>)</code></dfn> method must return the <var>index</var>th <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet③⑥">CSS style
sheet</a> in the collection. If there is no <var>index</var>th object in the collection, then the method must return null.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="StyleSheetList" data-dfn-type="attribute" data-export id="dom-stylesheetlist-length"><code>length</code></dfn> attribute must return the number of <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet③⑦">CSS style sheets</a> represented by the collection.</p>
   <h4 class="heading settled" data-level="6.2.3" id="extensions-to-the-document-or-shadow-root-interface"><span class="secno">6.2.3. </span><span class="content">Extensions to the <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#documentorshadowroot" id="ref-for-documentorshadowroot③">DocumentOrShadowRoot</a></code> Interface Mixin</span><a class="self-link" href="#extensions-to-the-document-or-shadow-root-interface"></a></h4>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <c- b>mixin</c-> <a class="idl-code" data-link-type="interface" href="https://dom.spec.whatwg.org/#documentorshadowroot" id="ref-for-documentorshadowroot④"><c- g>DocumentOrShadowRoot</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject③"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#stylesheetlist" id="ref-for-stylesheetlist②"><c- n>StyleSheetList</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="StyleSheetList" href="#dom-documentorshadowroot-stylesheets" id="ref-for-dom-documentorshadowroot-stylesheets"><c- g>styleSheets</c-></a>;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="DocumentOrShadowRoot" data-dfn-type="attribute" data-export id="dom-documentorshadowroot-stylesheets"><code>styleSheets</code></dfn> attribute must return a <code class="idl"><a data-link-type="idl" href="#stylesheetlist" id="ref-for-stylesheetlist③">StyleSheetList</a></code> collection representing
the <a data-link-type="dfn" href="#documentorshadowroot-document-or-shadow-root-css-style-sheets" id="ref-for-documentorshadowroot-document-or-shadow-root-css-style-sheets④">document or shadow root CSS style sheets</a>.</p>
   <h3 class="heading settled" data-level="6.3" id="style-sheet-association"><span class="secno">6.3. </span><span class="content">Style Sheet Association</span><a class="self-link" href="#style-sheet-association"></a></h3>
   <p>This section defines the interface an <a data-link-type="dfn" href="#concept-css-style-sheet-owner-node" id="ref-for-concept-css-style-sheet-owner-node⑦">owner node</a> of a <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet③⑧">CSS style sheet</a> has to
implement and defines the requirements for <a data-link-type="dfn" href="https://www.w3.org/TR/xml-stylesheet/#dt-xml-stylesheet-processing-instruction" id="ref-for-dt-xml-stylesheet-processing-instruction">xml-stylesheet processing instructions</a> and HTTP <code>Link</code> headers when the link
relation type is an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#ascii-case-insensitive" id="ref-for-ascii-case-insensitive">ASCII case-insensitive</a> match for
"<code>stylesheet</code>".</p>
   <h4 class="heading settled" data-level="6.3.1" id="fetching-css-style-sheets"><span class="secno">6.3.1. </span><span class="content">Fetching CSS style sheets</span><a class="self-link" href="#fetching-css-style-sheets"></a></h4>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="fetch-a-css-style-sheet">fetch a CSS style sheet</dfn> with parsed URL <var>parsed URL</var>, referrer <var>referrer</var>, document <var>document</var>, optionally a set of parameters <var>parameters</var> (used as input to creating a <a data-link-type="dfn" href="https://fetch.spec.whatwg.org/#concept-request" id="ref-for-concept-request">request</a>), follow these steps:</p>
   <ol>
    <li>Let <var>origin</var> be <var>document</var>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin">origin</a>. 
    <li>Let <var>request</var> be a new <a data-link-type="dfn" href="https://fetch.spec.whatwg.org/#concept-request" id="ref-for-concept-request①">request</a>, with the <a data-link-type="dfn" href="https://fetch.spec.whatwg.org/#concept-request-url" id="ref-for-concept-request-url">url</a> <var>parsed URL</var>, <a data-link-type="dfn" href="https://fetch.spec.whatwg.org/#concept-request-origin" id="ref-for-concept-request-origin">origin</a> <var>origin</var>, <a data-link-type="dfn" href="https://fetch.spec.whatwg.org/#concept-request-referrer" id="ref-for-concept-request-referrer">referrer</a> <var>referrer</var>, and if specified the set of parameters <var>parameters</var>. 
    <li>Let <var>response</var> be the result of <a data-link-type="dfn" href="https://fetch.spec.whatwg.org/#concept-fetch" id="ref-for-concept-fetch">fetching</a> <var>request</var>. 
    <li>Wait until <var>response</var> is available. 
    <li>If <var>response</var> is a <a data-link-type="dfn" href="https://fetch.spec.whatwg.org/#concept-network-error" id="ref-for-concept-network-error">network error</a>, return an error. 
    <li>If <var>document</var> is in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks">quirks mode</a>, <var>response</var> is <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/urls-and-fetching.html#cors-same-origin" id="ref-for-cors-same-origin">CORS-same-origin</a> and the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#content-type" id="ref-for-content-type">Content-Type metadata</a> of <var>response</var> is not a <a data-link-type="dfn" href="#supported-styling-language" id="ref-for-supported-styling-language">supported styling language</a> change the <span id="ref-for-content-type①">Content-Type metadata</span> of <var>response</var> to <code>text/css</code>. 
    <li>If <var>response</var> is not in a <a data-link-type="dfn" href="#supported-styling-language" id="ref-for-supported-styling-language①">supported styling language</a> return an error. 
    <li>Return <var>response</var>. 
   </ol>
   <h4 class="heading settled" data-level="6.3.2" id="the-linkstyle-interface"><span class="secno">6.3.2. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#linkstyle" id="ref-for-linkstyle">LinkStyle</a></code> Interface</span><a class="self-link" href="#the-linkstyle-interface"></a></h4>
   <p>The <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="associated-css-style-sheet">associated CSS style sheet</dfn> of a node is the <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet③⑨">CSS style sheet</a> in the list of <a data-link-type="dfn" href="#documentorshadowroot-document-or-shadow-root-css-style-sheets" id="ref-for-documentorshadowroot-document-or-shadow-root-css-style-sheets⑤">document or shadow root CSS style sheets</a> of which the <a data-link-type="dfn" href="#concept-css-style-sheet-owner-node" id="ref-for-concept-css-style-sheet-owner-node⑧">owner node</a> is said node.
This node must also implement the <code class="idl"><a data-link-type="idl" href="#linkstyle" id="ref-for-linkstyle①">LinkStyle</a></code> interface.</p>
<pre class="idl highlight def"><c- b>interface</c-> <c- b>mixin</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="linkstyle"><code><c- g>LinkStyle</c-></code></dfn> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssstylesheet" id="ref-for-cssstylesheet⑦"><c- n>CSSStyleSheet</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleSheet?" href="#dom-linkstyle-sheet" id="ref-for-dom-linkstyle-sheet"><c- g>sheet</c-></a>;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="LinkStyle" data-dfn-type="attribute" data-export id="dom-linkstyle-sheet"><code>sheet</code></dfn> attribute must return the <a data-link-type="dfn" href="#associated-css-style-sheet" id="ref-for-associated-css-style-sheet①">associated CSS style sheet</a> for the node or null
if there is no <span id="ref-for-associated-css-style-sheet②">associated CSS style sheet</span>.</p>
   <div class="example" id="example-3accc107">
    <a class="self-link" href="#example-3accc107"></a> In the following fragment, the first <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/semantics.html#the-style-element" id="ref-for-the-style-element">style</a></code> element has a <code class="idl"><a data-link-type="idl" href="#dom-linkstyle-sheet" id="ref-for-dom-linkstyle-sheet①">sheet</a></code> attribute that returns a <code class="idl"><a data-link-type="idl" href="#stylesheet" id="ref-for-stylesheet③">StyleSheet</a></code> object representing the style sheet, but for
 the second <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/semantics.html#the-style-element" id="ref-for-the-style-element①">style</a></code> element, the <code class="idl"><a data-link-type="idl" href="#dom-linkstyle-sheet" id="ref-for-dom-linkstyle-sheet②">sheet</a></code> attribute returns null,
 assuming the user agent supports CSS (<code>text/css</code>), but does
 not support the (hypothetical) ExampleSheets (<code>text/example-sheets</code>). 
<pre>&lt;style type="text/css">
  body { background:lime }
&lt;/style>
</pre>
<pre>&lt;style type="text/example-sheets">
  $(body).background := lime
&lt;/style>
</pre>
   </div>
   <p class="note" role="note"><span>Note:</span> Whether or not the node refers to a style sheet is defined
by the specification that defines the semantics of said node.</p>
   <h4 class="heading settled" data-level="6.3.3" id="requirements-on-specifications"><span class="secno">6.3.3. </span><span class="content">Requirements on specifications</span><a class="self-link" href="#requirements-on-specifications"></a></h4>
   <p>Specifications introducing new ways of associating style sheets through
the DOM should define which nodes implement the <code class="idl"><a data-link-type="idl" href="#linkstyle" id="ref-for-linkstyle②">LinkStyle</a></code> interface. When doing so, they
must also define when a <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet④⓪">CSS style sheet</a> is <a data-link-type="dfn" href="#create-a-css-style-sheet" id="ref-for-create-a-css-style-sheet">created</a>.</p>
   <h4 class="heading settled" data-level="6.3.4" id="requirements-on-user-agents-implementing-the-xml-stylesheet-processing-instruction"><span class="secno">6.3.4. </span><span class="content">Requirements on User Agents Implementing the xml-stylesheet processing instruction</span><a class="self-link" href="#requirements-on-user-agents-implementing-the-xml-stylesheet-processing-instruction"></a></h4>
<pre class="idl highlight def"><a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#processinginstruction" id="ref-for-processinginstruction①"><c- n>ProcessingInstruction</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#linkstyle" id="ref-for-linkstyle③"><c- n>LinkStyle</c-></a>;</pre>
   <p>The <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="prolog">prolog</dfn> refers to <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node" id="ref-for-concept-node">nodes</a> that are children of the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document" id="ref-for-concept-document">document</a> and are not <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-tree-following" id="ref-for-concept-tree-following">following</a> the <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#element" id="ref-for-element①">Element</a></code> child of the <span id="ref-for-concept-document①">document</span>, if any.</p>
   <p>When a <code>ProcessingInstruction</code> <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#boundary-point-node" id="ref-for-boundary-point-node">node</a> <var>node</var> becomes part of the <a data-link-type="dfn" href="#prolog" id="ref-for-prolog">prolog</a>, is no longer part of the <span id="ref-for-prolog①">prolog</span>, or has its <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-cd-data" id="ref-for-concept-cd-data">data</a> changed, these steps
must be run:</p>
   <ol>
    <li>If an instance of this algorithm is currently running for <var>node</var>, abort that instance, and stop the associated <a data-link-type="dfn" href="https://fetch.spec.whatwg.org/#concept-fetch" id="ref-for-concept-fetch①">fetching</a> if applicable. 
    <li>If <var>node</var> has an <a data-link-type="dfn" href="#associated-css-style-sheet" id="ref-for-associated-css-style-sheet③">associated CSS style sheet</a>, <a data-link-type="dfn" href="#remove-a-css-style-sheet" id="ref-for-remove-a-css-style-sheet">remove</a> it. 
    <li>If <var>node</var> is not an <a data-link-type="dfn" href="https://www.w3.org/TR/xml-stylesheet/#dt-xml-stylesheet-processing-instruction" id="ref-for-dt-xml-stylesheet-processing-instruction①">xml-stylesheet processing instruction</a>, then return. 
    <li>If <var>node</var> does not have an <code>href</code> <a data-link-type="dfn" href="https://www.w3.org/TR/xml-stylesheet/#dt-pseudo-attribute" id="ref-for-dt-pseudo-attribute">pseudo-attribute</a>, then return. 
    <li>Let <var>title</var> be the value of the <code>title</code> <a data-link-type="dfn" href="https://www.w3.org/TR/xml-stylesheet/#dt-pseudo-attribute" id="ref-for-dt-pseudo-attribute①">pseudo-attribute</a> or the empty string if the <code>title</code> <span id="ref-for-dt-pseudo-attribute②">pseudo-attribute</span> is not specified. 
    <li>If there is an <code>alternate</code> <a data-link-type="dfn" href="https://www.w3.org/TR/xml-stylesheet/#dt-pseudo-attribute" id="ref-for-dt-pseudo-attribute③">pseudo-attribute</a> whose value is a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive⑥">case-sensitive</a> match
 for "<code>yes</code>" and <var>title</var> is the
 empty string, then return. 
    <li>If there is a <code>type</code> <a data-link-type="dfn" href="https://www.w3.org/TR/xml-stylesheet/#dt-pseudo-attribute" id="ref-for-dt-pseudo-attribute④">pseudo-attribute</a> whose
 value is not a <a data-link-type="dfn" href="#supported-styling-language" id="ref-for-supported-styling-language②">supported styling language</a> the user agent
 may return. 
    <li>Let <var>input URL</var> be the value specified by the <code>href</code> <a data-link-type="dfn" href="https://www.w3.org/TR/xml-stylesheet/#dt-pseudo-attribute" id="ref-for-dt-pseudo-attribute⑤">pseudo-attribute</a>. 
    <li>Let <var>document</var> be <var>node</var>’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document">node document</a> 
    <li>Let <var>base URL</var> be <var>document</var>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#document-base-url" id="ref-for-document-base-url">document base URL</a>. 
    <li>Let <var>referrer</var> be <var>document</var>’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-url" id="ref-for-concept-document-url">address</a>. 
    <li>Let <var>parsed URL</var> be the return value of invoking the <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-parser" id="ref-for-concept-url-parser">URL parser</a> with the
 string <var>input URL</var> and the base URL <var>base URL</var>. 
    <li>If <var>parsed URL</var> is failure, then return. 
    <li>Let <var>response</var> be the result of <a data-link-type="dfn" href="#fetch-a-css-style-sheet" id="ref-for-fetch-a-css-style-sheet">fetching a CSS style sheet</a> with parsed URL <var>parsed URL</var>,
 referrer <var>referrer</var> and document <var>document</var>. 
    <li>If <var>response</var> is an error, then return. 
    <li>
      <a data-link-type="dfn" href="#create-a-css-style-sheet" id="ref-for-create-a-css-style-sheet①">Create a CSS style sheet</a> with the following properties: 
     <dl>
      <dt><a data-link-type="dfn" href="#concept-css-style-sheet-location" id="ref-for-concept-css-style-sheet-location①">location</a> 
      <dd>The result of invoking the <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-serializer" id="ref-for-concept-url-serializer">URL serializer</a> with <var>parsed URL</var>. 
      <dt><a data-link-type="dfn" href="#concept-css-style-sheet-parent-css-style-sheet" id="ref-for-concept-css-style-sheet-parent-css-style-sheet③">parent CSS style sheet</a> 
      <dd>null. 
      <dt><a data-link-type="dfn" href="#concept-css-style-sheet-owner-node" id="ref-for-concept-css-style-sheet-owner-node⑨">owner node</a> 
      <dd><var>node</var>. 
      <dt><a data-link-type="dfn" href="#concept-css-style-sheet-owner-css-rule" id="ref-for-concept-css-style-sheet-owner-css-rule②">owner CSS rule</a> 
      <dd>null. 
      <dt><a data-link-type="dfn" href="#concept-css-style-sheet-media" id="ref-for-concept-css-style-sheet-media⑤">media</a> 
      <dd>The value of the <code>media</code> <a data-link-type="dfn" href="https://www.w3.org/TR/xml-stylesheet/#dt-pseudo-attribute" id="ref-for-dt-pseudo-attribute⑥">pseudo-attribute</a> if any, or the empty string otherwise. 
      <dt><a data-link-type="dfn" href="#concept-css-style-sheet-title" id="ref-for-concept-css-style-sheet-title①④">title</a> 
      <dd><var>title</var>. 
      <dt><a data-link-type="dfn" href="#concept-css-style-sheet-alternate-flag" id="ref-for-concept-css-style-sheet-alternate-flag③">alternate flag</a> 
      <dd>Set if the <code>alternate</code> <a data-link-type="dfn" href="https://www.w3.org/TR/xml-stylesheet/#dt-pseudo-attribute" id="ref-for-dt-pseudo-attribute⑦">pseudo-attribute</a> value is a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive⑦">case-sensitive</a> match for
   "<code>yes</code>", or unset otherwise. 
      <dt><a data-link-type="dfn" href="#concept-css-style-sheet-origin-clean-flag" id="ref-for-concept-css-style-sheet-origin-clean-flag④">origin-clean flag</a> 
      <dd>Set if <var>response</var> is <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/urls-and-fetching.html#cors-same-origin" id="ref-for-cors-same-origin①">CORS-same-origin</a>, or unset otherwise. 
     </dl>
     <p>The CSS <a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#environment-encoding" id="ref-for-environment-encoding">environment encoding</a> is the result of running the following steps:</p>
     <ol>
      <li>If the element has a <code>charset</code> <a data-link-type="dfn" href="https://www.w3.org/TR/xml-stylesheet/#dt-pseudo-attribute" id="ref-for-dt-pseudo-attribute⑧">pseudo-attribute</a>, <a data-link-type="dfn" href="https://encoding.spec.whatwg.org/#concept-encoding-get" id="ref-for-concept-encoding-get">get an encoding</a> from that pseudo-attribute’s value.
   If that succeeds, return the resulting encoding and abort these steps. 
      <li>Otherwise, return the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-encoding" id="ref-for-concept-document-encoding">document’s character encoding</a>. <a data-link-type="biblio" href="#biblio-dom">[DOM]</a> 
     </ol>
   </ol>
   <p>A style sheet referenced by an <a data-link-type="dfn" href="https://www.w3.org/TR/xml-stylesheet/#dt-xml-stylesheet-processing-instruction" id="ref-for-dt-xml-stylesheet-processing-instruction②">xml-stylesheet processing instruction</a> using the rules in this section, in the context of
the <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document">Document</a></code> of an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/xhtml.html#xml-parser" id="ref-for-xml-parser">XML parser</a> is said to be <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/semantics.html#a-style-sheet-that-is-blocking-scripts" id="ref-for-a-style-sheet-that-is-blocking-scripts">a style sheet that is blocking scripts</a> if the <code>ProcessingInstruction</code> <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#boundary-point-node" id="ref-for-boundary-point-node①">node</a> was created by that <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document①">Document</a></code>'s parser, and the style sheet was
enabled when the node was created by the parser, and the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/semantics.html#style-sheet-ready" id="ref-for-style-sheet-ready">style sheet ready</a> flag is not yet set, and, the last time the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-loop" id="ref-for-event-loop">event loop</a> reached step 1, the node was in that Document, and the user agent hasn’t given up on that particular style sheet
yet. A user agent may give up on such a style sheet at any time.</p>
   <h4 class="heading settled" data-level="6.3.5" id="requirements-on-user-agents-implementing-the-http-link-header"><span class="secno">6.3.5. </span><span class="content">Requirements on User Agents Implementing the HTTP Link Header</span><a class="self-link" href="#requirements-on-user-agents-implementing-the-http-link-header"></a></h4>
   <p class="atrisk">For each HTTP <code>Link</code> header of which one
of the link relation types is an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#ascii-case-insensitive" id="ref-for-ascii-case-insensitive①">ASCII case-insensitive</a> match
for "<code>stylesheet</code>" these steps
must be run: </p>
   <ol>
    <li>Let <var>title</var> be the value of the first of all the <code>title</code> parameters.
 If there are no such parameters it is the empty string. 
    <li>If one of the (other) link relation types is an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#ascii-case-insensitive" id="ref-for-ascii-case-insensitive②">ASCII case-insensitive</a> match for
 "<code>alternate</code>" and <var>title</var> is the
 empty string, then return. 
    <li>
     Let <var>input URL</var> be the value specified. 
     <p class="issue" id="issue-d4a93110"><a class="self-link" href="#issue-d4a93110"></a> Be more specific</p>
    <li>
     Let <var>base URL</var> be the document’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#document-base-url" id="ref-for-document-base-url①">document base URL</a>. 
     <p class="issue" id="issue-af048285"><a class="self-link" href="#issue-af048285"></a> Is there a document at this point?</p>
    <li>Let <var>referrer</var> be the document’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-url" id="ref-for-concept-document-url①">address</a>. 
    <li>Let <var>origin</var> be the document’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin" id="ref-for-concept-origin①">origin</a>. 
    <li>Let <var>parsed URL</var> be the return value of invoking the <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-parser" id="ref-for-concept-url-parser①">URL parser</a> with the
 string <var>input URL</var> and the base URL <var>base URL</var>. 
    <li>If <var>parsed URL</var> is failure, then return. 
    <li>
     Let <var>response</var> be the result of <a data-link-type="dfn" href="#fetch-a-css-style-sheet" id="ref-for-fetch-a-css-style-sheet①">fetching a CSS style sheet</a> with parsed URL <var>parsed URL</var>,
 referrer <var>referrer</var> and document being the document. 
     <p class="issue" id="issue-45012e41"><a class="self-link" href="#issue-45012e41"></a> What if the HTML parser hasn’t decided on quirks/non-quirks yet?</p>
    <li>
      <a data-link-type="dfn" href="#create-a-css-style-sheet" id="ref-for-create-a-css-style-sheet②">Create a CSS style sheet</a> with the following properties: 
     <dl>
      <dt><a data-link-type="dfn" href="#concept-css-style-sheet-location" id="ref-for-concept-css-style-sheet-location②">location</a> 
      <dd>The result of invoking the <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url-serializer" id="ref-for-concept-url-serializer①">URL serializer</a> with <var>parsed URL</var>. 
      <dt><a data-link-type="dfn" href="#concept-css-style-sheet-owner-node" id="ref-for-concept-css-style-sheet-owner-node①⓪">owner node</a> 
      <dd>null. 
      <dt><a data-link-type="dfn" href="#concept-css-style-sheet-parent-css-style-sheet" id="ref-for-concept-css-style-sheet-parent-css-style-sheet④">parent CSS style sheet</a> 
      <dd>null. 
      <dt><a data-link-type="dfn" href="#concept-css-style-sheet-owner-css-rule" id="ref-for-concept-css-style-sheet-owner-css-rule③">owner CSS rule</a> 
      <dd>null. 
      <dt><a data-link-type="dfn" href="#concept-css-style-sheet-media" id="ref-for-concept-css-style-sheet-media⑥">media</a> 
      <dd>The value of the first <code>media</code> parameter. 
      <dt><a data-link-type="dfn" href="#concept-css-style-sheet-title" id="ref-for-concept-css-style-sheet-title①⑤">title</a> 
      <dd><var>title</var>. 
      <dt><a data-link-type="dfn" href="#concept-css-style-sheet-alternate-flag" id="ref-for-concept-css-style-sheet-alternate-flag④">alternate flag</a> 
      <dd>Set if one of the specified link relation type for this HTTP <code>Link</code> header is an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#ascii-case-insensitive" id="ref-for-ascii-case-insensitive③">ASCII case-insensitive</a> match for
   "<code>alternate</code>", or false otherwise. 
      <dt><a data-link-type="dfn" href="#concept-css-style-sheet-origin-clean-flag" id="ref-for-concept-css-style-sheet-origin-clean-flag⑤">origin-clean flag</a> 
      <dd>Set if <var>response</var> is <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/urls-and-fetching.html#cors-same-origin" id="ref-for-cors-same-origin②">CORS-same-origin</a>, or unset otherwise. 
     </dl>
   </ol>
   <p>A style sheet referenced by a HTTP <code>Link</code> header using the rules in this section is said to be <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/semantics.html#a-style-sheet-that-is-blocking-scripts" id="ref-for-a-style-sheet-that-is-blocking-scripts①">a style sheet
that is blocking scripts</a> if the style sheet was enabled when created, and the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/semantics.html#style-sheet-ready" id="ref-for-style-sheet-ready①">style sheet ready</a> flag is not yet set,
and the user agent hasn’t given up on that particular style sheet yet. A user agent may give up on such a style sheet at any time.</p>
   <h3 class="heading settled" data-level="6.4" id="css-rules"><span class="secno">6.4. </span><span class="content">CSS Rules</span><a class="self-link" href="#css-rules"></a></h3>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="css-rule">CSS rule</dfn> is an abstract concept that
denotes a rule as defined by the CSS specification. A <a data-link-type="dfn" href="#css-rule" id="ref-for-css-rule①">CSS rule</a> is represented as an object that implements a subclass of
the <code class="idl"><a data-link-type="idl" href="#cssrule" id="ref-for-cssrule①">CSSRule</a></code> interface, and which has the following
associated state items:</p>
   <dl>
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSRule" data-dfn-type="dfn" data-noexport id="concept-css-rule-type">type</dfn> 
    <dd>A non-negative integer associated with a particular type of rule.
This item is initialized when a rule is created and cannot change. 
    <dt><dfn data-dfn-for="CSSRule" data-dfn-type="dfn" data-noexport id="concept-css-rule-text">text<a class="self-link" href="#concept-css-rule-text"></a></dfn> 
    <dd>A text representation of the rule suitable for direct use in a style sheet.
This item is initialized when a rule is created and can be changed. 
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSRule" data-dfn-type="dfn" data-noexport id="concept-css-rule-parent-css-rule">parent CSS rule</dfn> 
    <dd>A reference to an enclosing <a data-link-type="dfn" href="#css-rule" id="ref-for-css-rule②">CSS rule</a> or null.
If the rule has an enclosing rule when it is created, then this item is initialized to the enclosing rule; otherwise it is null. It can be changed to
null. 
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSRule" data-dfn-type="dfn" data-noexport id="concept-css-rule-parent-css-style-sheet">parent CSS style sheet</dfn> 
    <dd>A reference to a parent <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet④①">CSS style sheet</a> or null.
This item is initialized to reference an associated style sheet when the rule is created. It can be changed to null. 
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSRule" data-dfn-type="dfn" data-noexport id="concept-css-rule-child-css-rules">child CSS rules</dfn> 
    <dd>A list of child <a data-link-type="dfn" href="#css-rule" id="ref-for-css-rule③">CSS rules</a>. The list can be mutated. 
   </dl>
   <p>In addition to the above state, each <a data-link-type="dfn" href="#css-rule" id="ref-for-css-rule④">CSS rule</a> may be associated
with other state in accordance with its <a data-link-type="dfn" href="#concept-css-rule-type" id="ref-for-concept-css-rule-type">type</a>.</p>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="parse-a-css-rule">parse a CSS rule</dfn> from a string <var>string</var>, run the following steps:</p>
   <ol>
    <li>Let <var>rule</var> be the return value of invoking <a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#parse-a-rule" id="ref-for-parse-a-rule">parse a rule</a> with <var>string</var>. 
    <li>If <var>rule</var> is a syntax error, return <var>rule</var>. 
    <li>Let <var>parsed rule</var> be the result of parsing <var>rule</var> according to the appropriate CSS specifications, dropping parts that are said to be
 ignored. If the whole style rule is dropped, return a syntax error. 
    <li>Return <var>parsed rule</var>. 
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-a-css-rule">serialize a CSS rule</dfn>, perform one of the following in accordance with the <a data-link-type="dfn" href="#css-rule" id="ref-for-css-rule⑤">CSS rule</a>’s <a data-link-type="dfn" href="#concept-css-rule-type" id="ref-for-concept-css-rule-type①">type</a>:</p>
   <dl class="switch">
    <dt><code class="idl"><a data-link-type="idl" href="#cssstylerule" id="ref-for-cssstylerule">CSSStyleRule</a></code> 
    <dd>
      The result of concatenating the following: 
     <ol>
      <li>The result of performing <a data-link-type="dfn" href="#serialize-a-group-of-selectors" id="ref-for-serialize-a-group-of-selectors①">serialize a group of selectors</a> on the rule’s associated selectors. 
      <li>The string "<code> { </code>", i.e., a single SPACE (U+0020), followed by LEFT CURLY BRACKET (U+007B),
   followed by a single SPACE (U+0020). 
      <li>The result of performing <a data-link-type="dfn" href="#serialize-a-css-declaration-block" id="ref-for-serialize-a-css-declaration-block">serialize a CSS declaration block</a> on the rule’s associated declarations. 
      <li>If the rule is associated with one or more declarations, the string "<code> </code>", i.e., a single SPACE (U+0020). 
      <li>The string "<code>}</code>", RIGHT CURLY BRACKET (U+007D). 
     </ol>
    <dt><code class="idl"><a data-link-type="idl" href="#cssimportrule" id="ref-for-cssimportrule">CSSImportRule</a></code> 
    <dd>
      The result of concatenating the following: 
     <ol>
      <li>The string "<code>@import</code>" followed by a single SPACE (U+0020). 
      <li>The result of performing <a data-link-type="dfn" href="#serialize-a-url" id="ref-for-serialize-a-url">serialize a URL</a> on the rule’s location. 
      <li>If the rule’s associated media list is not empty, a single SPACE (U+0020) followed by the
   result of performing <a data-link-type="dfn" href="#serialize-a-media-query-list" id="ref-for-serialize-a-media-query-list①">serialize a media query list</a> on the media list. 
      <li>The string "<code>;</code>", i.e., SEMICOLON (U+003B). 
     </ol>
     <div class="example" id="example-844003e0">
      <a class="self-link" href="#example-844003e0"></a> 
<pre>@import url("import.css");</pre>
<pre>@import url("print.css") print;</pre>
     </div>
    <dt><code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/css-conditional-3/#cssmediarule" id="ref-for-cssmediarule">CSSMediaRule</a></code> 
    <dd>
      The result of concatenating the following: 
     <ol>
      <li>The string "<code>@media</code>", followed by a single SPACE (U+0020).
      <li>The result of performing <a data-link-type="dfn" href="#serialize-a-media-query-list" id="ref-for-serialize-a-media-query-list②">serialize a media query list</a> on rule’s media query list.
      <li>A single SPACE (U+0020), followed by the string "{", i.e., LEFT CURLY BRACKET (U+007B), followed by a newline.
      <li>The result of performing <a data-link-type="dfn" href="#serialize-a-css-rule" id="ref-for-serialize-a-css-rule">serialize a CSS rule</a> on each rule, separated by a newline and indented by two spaces, in rule’s CSSRules list.
      <li>A newline, followed by the string "}", i.e., RIGHT CURLY BRACKET (U+007D)
     </ol>
    <dt><code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/css-fonts-4/#cssfontfacerule" id="ref-for-cssfontfacerule">CSSFontFaceRule</a></code> 
    <dd>
      The result of concatenating the following: 
     <ol>
      <li>The string "<code>@font-face {</code>", followed by a single SPACE (U+0020).
      <li>The string "<code>font-family:</code>", followed by a single SPACE (U+0020).
      <li>The result of performing <a data-link-type="dfn" href="#serialize-a-string" id="ref-for-serialize-a-string④">serialize a string</a> on the rule’s font family name.
      <li>The string "<code>;</code>", i.e., SEMICOLON (U+003B). 
      <li>
        If the rule’s associated source list is not empty, follow these substeps: 
       <ol>
        <li>A single SPACE (U+0020), followed by the string "<code>src:</code>", followed by a single
     SPACE (U+0020).
        <li>The result of invoking <a data-link-type="dfn" href="#serialize-a-comma-separated-list" id="ref-for-serialize-a-comma-separated-list③">serialize a comma-separated list</a> on performing <a data-link-type="dfn" href="#serialize-a-url" id="ref-for-serialize-a-url①">serialize a
     URL</a> or <a data-link-type="dfn" href="#serialize-a-local" id="ref-for-serialize-a-local">serialize a LOCAL</a> for each source on the source list.
        <li>The string "<code>;</code>", i.e., SEMICOLON (U+003B).
       </ol>
      <li>If rule’s associated <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-fonts-4/#descdef-font-face-unicode-range" id="ref-for-descdef-font-face-unicode-range">unicode-range</a> descriptor is present, a single
   SPACE (U+0020), followed by the string "<code>unicode-range:</code>", followed by a single SPACE
   (U+0020), followed by the result of performing serialize a <span class="production" id="ref-for-descdef-font-face-unicode-range①">&lt;'unicode-range'></span>, followed by the
   string "<code>;</code>", i.e., SEMICOLON (U+003B).
      <li>If rule’s associated <a class="property" data-link-type="propdesc">font-variant</a> descriptor is present, a single
   SPACE (U+0020), followed by the string "<code>font-variant:</code>", followed by a single SPACE
   (U+0020), followed by the result of performing serialize a <span class="production">&lt;'font-variant'></span>, followed by the
   string "<code>;</code>", i.e., SEMICOLON (U+003B).
      <li>If rule’s associated <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-fonts-4/#descdef-font-face-font-feature-settings" id="ref-for-descdef-font-face-font-feature-settings">font-feature-settings</a> descriptor is present, a
   single SPACE (U+0020), followed by the string "<code>font-feature-settings:</code>", followed by
   a single SPACE (U+0020), followed by the result of performing serialize a <span class="production" id="ref-for-descdef-font-face-font-feature-settings①">&lt;'font-feature-settings'></span>, followed by the string "<code>;</code>", i.e., SEMICOLON
   (U+003B).
      <li>If rule’s associated <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-fonts-4/#descdef-font-face-font-stretch" id="ref-for-descdef-font-face-font-stretch">font-stretch</a> descriptor is present, a single
   SPACE (U+0020), followed by the string "<code>font-stretch:</code>", followed by a single SPACE
   (U+0020), followed by the result of performing serialize a <span class="production" id="ref-for-descdef-font-face-font-stretch①">&lt;'font-stretch'></span>, followed by the
   string "<code>;</code>", i.e., SEMICOLON (U+003B).
      <li>If rule’s associated <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-fonts-4/#descdef-font-face-font-weight" id="ref-for-descdef-font-face-font-weight">font-weight</a> descriptor is present, a single SPACE
   (U+0020), followed by the string "<code>font-weight:</code>", followed by a single SPACE
   (U+0020), followed by the result of performing serialize a <span class="production" id="ref-for-descdef-font-face-font-weight①">&lt;'font-weight'></span>, followed by the
   string "<code>;</code>", i.e., SEMICOLON (U+003B).
      <li>If rule’s associated <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-fonts-4/#descdef-font-face-font-style" id="ref-for-descdef-font-face-font-style">font-style</a> descriptor is present, a single SPACE
   (U+0020), followed by the string "<code>font-style:</code>", followed by a single SPACE (U+0020),
   followed by the result of performing serialize a <span class="production" id="ref-for-descdef-font-face-font-style①">&lt;'font-style'></span>, followed by the string
   "<code>;</code>", i.e., SEMICOLON (U+003B).
      <li>A single SPACE (U+0020), followed by the string "}", i.e., RIGHT CURLY BRACKET (U+007D).
     </ol>
     <p class="issue" id="issue-f92cf3b3"><a class="self-link" href="#issue-f92cf3b3"></a> Need to define how the <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/css-fonts-4/#cssfontfacerule" id="ref-for-cssfontfacerule①">CSSFontFaceRule</a></code> descriptors' values are serialized.</p>
    <dt><code class="idl"><a data-link-type="idl" href="#csspagerule" id="ref-for-csspagerule">CSSPageRule</a></code> 
    <dd>
     <p class="issue" id="issue-be6dc86c"><a class="self-link" href="#issue-be6dc86c"></a> Need to define how <code class="idl"><a data-link-type="idl" href="#csspagerule" id="ref-for-csspagerule①">CSSPageRule</a></code> is serialized.</p>
    <dt><code class="idl"><a data-link-type="idl" href="#cssnamespacerule" id="ref-for-cssnamespacerule">CSSNamespaceRule</a></code> 
    <dd>The literal string "<code>@namespace</code>", followed by a single SPACE
 (U+0020), followed by the <a data-link-type="dfn" href="#serialize-an-identifier" id="ref-for-serialize-an-identifier⑦">serialization as an identifier</a> of the <code class="idl"><a data-link-type="idl" href="#dom-cssnamespacerule-prefix" id="ref-for-dom-cssnamespacerule-prefix">prefix</a></code> attribute (if
 any), followed by a single SPACE (U+0020) if there is a prefix, followed by the <a data-link-type="dfn" href="#serialize-a-url" id="ref-for-serialize-a-url②">serialization as URL</a> of the <code class="idl"><a data-link-type="idl" href="#dom-cssnamespacerule-namespaceuri" id="ref-for-dom-cssnamespacerule-namespaceuri">namespaceURI</a></code> attribute, followed the character "<code>;</code>" (U+003B). 
   </dl>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="insert-a-css-rule">insert a CSS rule</dfn> <var>rule</var> in a CSS rule list <var>list</var> at index <var>index</var>, follow these steps:</p>
   <ol>
    <li>Set <var>length</var> to the number of items in <var>list</var>. 
    <li>If <var>index</var> is greater than <var>length</var>, then <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw④">throw</a> an <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#indexsizeerror" id="ref-for-indexsizeerror">IndexSizeError</a></code> exception. 
    <li>Set <var>new rule</var> to the results of performing <a data-link-type="dfn" href="#parse-a-css-rule" id="ref-for-parse-a-css-rule">parse a CSS rule</a> on argument <var>rule</var>. 
    <li>If <var>new rule</var> is a syntax error, <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw⑤">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#syntaxerror" id="ref-for-syntaxerror">SyntaxError</a></code> exception. 
    <li>
     If <var>new rule</var> cannot be inserted into <var>list</var> at the zero-index position <var>index</var> due to constraints
 specified by CSS, then <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw⑥">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#hierarchyrequesterror" id="ref-for-hierarchyrequesterror">HierarchyRequestError</a></code> exception. <a data-link-type="biblio" href="#biblio-css21">[CSS21]</a> 
     <p class="note" role="note"><span>Note:</span> For example, a CSS style sheet cannot contain an <code>@import</code> at-rule after a style rule.</p>
    <li>If <var>new rule</var> is an <code>@namespace</code> at-rule, and <var>list</var> contains anything other than <code>@import</code> at-rules, and <code>@namespace</code> at-rules, <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw⑦">throw</a> an <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#invalidstateerror" id="ref-for-invalidstateerror">InvalidStateError</a></code> exception. 
    <li>Insert <var>new rule</var> into <var>list</var> at the zero-indexed position <var>index</var>. 
    <li>Return <var>index</var>. 
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="remove-a-css-rule">remove a CSS rule</dfn> from a CSS rule list <var>list</var> at index <var>index</var>, follow these steps:</p>
   <ol>
    <li>Set <var>length</var> to the number of items in <var>list</var>. 
    <li>If <var>index</var> is greater than or equal to <var>length</var>, then <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw⑧">throw</a> an <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#indexsizeerror" id="ref-for-indexsizeerror①">IndexSizeError</a></code> exception. 
    <li>Set <var>old rule</var> to the <var>index</var>th item in <var>list</var>. 
    <li>If <var>old rule</var> is an <code>@namespace</code> at-rule, and <var>list</var> contains anything other than <code>@import</code> at-rules, and <code>@namespace</code> at-rules, <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw⑨">throw</a> an <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#invalidstateerror" id="ref-for-invalidstateerror①">InvalidStateError</a></code> exception. 
    <li>Remove rule <var>old rule</var> from <var>list</var> at the zero-indexed position <var>index</var>. 
    <li>Set <var>old rule</var>’s <a data-link-type="dfn" href="#concept-css-rule-parent-css-rule" id="ref-for-concept-css-rule-parent-css-rule">parent CSS rule</a> and <a data-link-type="dfn" href="#concept-css-rule-parent-css-style-sheet" id="ref-for-concept-css-rule-parent-css-style-sheet">parent CSS style sheet</a> to null. 
   </ol>
   <h4 class="heading settled" data-level="6.4.1" id="the-cssrulelist-interface"><span class="secno">6.4.1. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#cssrulelist" id="ref-for-cssrulelist④">CSSRuleList</a></code> Interface</span><a class="self-link" href="#the-cssrulelist-interface"></a></h4>
   <p>The <code class="idl"><a data-link-type="idl" href="#cssrulelist" id="ref-for-cssrulelist⑤">CSSRuleList</a></code> interface represents an ordered collection of CSS style rules.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed④"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="cssrulelist"><code><c- g>CSSRuleList</c-></code></dfn> {
  <c- b>getter</c-> <a class="n" data-link-type="idl-name" href="#cssrule" id="ref-for-cssrule②"><c- n>CSSRule</c-></a>? <a class="idl-code" data-link-type="method" href="#dom-cssrulelist-item" id="ref-for-dom-cssrulelist-item"><c- g>item</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long⑨"><c- b>unsigned</c-> <c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="CSSRuleList/item(index)" data-dfn-type="argument" data-export id="dom-cssrulelist-item-index-index"><code><c- g>index</c-></code><a class="self-link" href="#dom-cssrulelist-item-index-index"></a></dfn>);
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long①⓪"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned long" href="#dom-cssrulelist-length" id="ref-for-dom-cssrulelist-length"><c- g>length</c-></a>;
};
</pre>
   <p>The object’s <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-supported-property-indices" id="ref-for-dfn-supported-property-indices④">supported property indices</a> are the numbers in the range zero to one less than the number of <code class="idl"><a data-link-type="idl" href="#cssrule" id="ref-for-cssrule③">CSSRule</a></code> objects represented by the collection. If there are no such <code class="idl"><a data-link-type="idl" href="#cssrule" id="ref-for-cssrule④">CSSRule</a></code> objects, then there are no <span id="ref-for-dfn-supported-property-indices⑤">supported property indices</span>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSRuleList" data-dfn-type="method" data-export id="dom-cssrulelist-item"><code>item(<var>index</var>)</code></dfn> method must return the <var>index</var>th <code class="idl"><a data-link-type="idl" href="#cssrule" id="ref-for-cssrule⑤">CSSRule</a></code> object in the collection. If there is no <var>index</var>th object in the collection, then the method must return null.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSRuleList" data-dfn-type="attribute" data-export id="dom-cssrulelist-length"><code>length</code></dfn> attribute must return the number of <code class="idl"><a data-link-type="idl" href="#cssrule" id="ref-for-cssrule⑥">CSSRule</a></code> objects represented by the
collection.</p>
   <h4 class="heading settled" data-level="6.4.2" id="the-cssrule-interface"><span class="secno">6.4.2. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#cssrule" id="ref-for-cssrule⑦">CSSRule</a></code> Interface</span><a class="self-link" href="#the-cssrule-interface"></a></h4>
   <p>The <code class="idl"><a data-link-type="idl" href="#cssrule" id="ref-for-cssrule⑧">CSSRule</a></code> interface represents an abstract, base CSS style rule. Each
distinct CSS style rule type is represented by a distinct interface that
inherits from this interface.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed⑤"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="cssrule"><code><c- g>CSSRule</c-></code></dfn> {
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring⑥"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-cssrule-csstext" id="ref-for-dom-cssrule-csstext"><c- g>cssText</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssrule" id="ref-for-cssrule⑨"><c- n>CSSRule</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSRule?" href="#dom-cssrule-parentrule" id="ref-for-dom-cssrule-parentrule"><c- g>parentRule</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssstylesheet" id="ref-for-cssstylesheet⑧"><c- n>CSSStyleSheet</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleSheet?" href="#dom-cssrule-parentstylesheet" id="ref-for-dom-cssrule-parentstylesheet"><c- g>parentStyleSheet</c-></a>;

  // the following attribute and constants are historical
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned short" href="#dom-cssrule-type" id="ref-for-dom-cssrule-type"><c- g>type</c-></a>;
  <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short①"><c- b>unsigned</c-> <c- b>short</c-></a> <dfn class="idl-code" data-dfn-for="CSSRule" data-dfn-type="const" data-export id="dom-cssrule-style_rule"><code><c- g>STYLE_RULE</c-></code><a class="self-link" href="#dom-cssrule-style_rule"></a></dfn> = 1;
  <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short②"><c- b>unsigned</c-> <c- b>short</c-></a> <dfn class="idl-code" data-dfn-for="CSSRule" data-dfn-type="const" data-export id="dom-cssrule-charset_rule"><code><c- g>CHARSET_RULE</c-></code><a class="self-link" href="#dom-cssrule-charset_rule"></a></dfn> = 2;
  <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short③"><c- b>unsigned</c-> <c- b>short</c-></a> <dfn class="idl-code" data-dfn-for="CSSRule" data-dfn-type="const" data-export id="dom-cssrule-import_rule"><code><c- g>IMPORT_RULE</c-></code><a class="self-link" href="#dom-cssrule-import_rule"></a></dfn> = 3;
  <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short④"><c- b>unsigned</c-> <c- b>short</c-></a> <dfn class="idl-code" data-dfn-for="CSSRule" data-dfn-type="const" data-export id="dom-cssrule-media_rule"><code><c- g>MEDIA_RULE</c-></code><a class="self-link" href="#dom-cssrule-media_rule"></a></dfn> = 4;
  <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short⑤"><c- b>unsigned</c-> <c- b>short</c-></a> <dfn class="idl-code" data-dfn-for="CSSRule" data-dfn-type="const" data-export id="dom-cssrule-font_face_rule"><code><c- g>FONT_FACE_RULE</c-></code><a class="self-link" href="#dom-cssrule-font_face_rule"></a></dfn> = 5;
  <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short⑥"><c- b>unsigned</c-> <c- b>short</c-></a> <dfn class="idl-code" data-dfn-for="CSSRule" data-dfn-type="const" data-export id="dom-cssrule-page_rule"><code><c- g>PAGE_RULE</c-></code><a class="self-link" href="#dom-cssrule-page_rule"></a></dfn> = 6;
  <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short⑦"><c- b>unsigned</c-> <c- b>short</c-></a> <dfn class="idl-code" data-dfn-for="CSSRule" data-dfn-type="const" data-export id="dom-cssrule-margin_rule"><code><c- g>MARGIN_RULE</c-></code><a class="self-link" href="#dom-cssrule-margin_rule"></a></dfn> = 9;
  <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short⑧"><c- b>unsigned</c-> <c- b>short</c-></a> <dfn class="idl-code" data-dfn-for="CSSRule" data-dfn-type="const" data-export id="dom-cssrule-namespace_rule"><code><c- g>NAMESPACE_RULE</c-></code><a class="self-link" href="#dom-cssrule-namespace_rule"></a></dfn> = 10;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSRule" data-dfn-type="attribute" data-export id="dom-cssrule-csstext"><code>cssText</code></dfn> attribute must return a <a data-link-type="dfn" href="#serialize-a-css-rule" id="ref-for-serialize-a-css-rule①">serialization</a> of the <a data-link-type="dfn" href="#css-rule" id="ref-for-css-rule⑥">CSS rule</a>.
On setting the <code class="idl"><a data-link-type="idl" href="#dom-cssrule-csstext" id="ref-for-dom-cssrule-csstext①">cssText</a></code> attribute must do nothing.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSRule" data-dfn-type="attribute" data-export id="dom-cssrule-parentrule"><code>parentRule</code></dfn> attribute must return the <a data-link-type="dfn" href="#concept-css-rule-parent-css-rule" id="ref-for-concept-css-rule-parent-css-rule①">parent CSS
rule</a>.</p>
   <p class="note" role="note"><span>Note:</span> For example, <code>@media</code> can enclose a rule, in which case <code class="idl"><a data-link-type="idl" href="#dom-cssrule-parentrule" id="ref-for-dom-cssrule-parentrule①">parentRule</a></code> would
be non-null; in cases where there is no enclosing rule, <code class="idl"><a data-link-type="idl" href="#dom-cssrule-parentrule" id="ref-for-dom-cssrule-parentrule②">parentRule</a></code> will be null.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSRule" data-dfn-type="attribute" data-export id="dom-cssrule-parentstylesheet"><code>parentStyleSheet</code></dfn> attribute must return the <a data-link-type="dfn" href="#concept-css-rule-parent-css-style-sheet" id="ref-for-concept-css-rule-parent-css-style-sheet①">parent CSS style sheet</a>.</p>
   <p class="note" role="note"><span>Note:</span> The only circumstance where null is returned when a rule has been <a data-link-type="dfn" href="#remove-a-css-rule" id="ref-for-remove-a-css-rule①">removed</a>.</p>
   <p class="note" role="note"><span>Note:</span> Removing a <code>Node</code> that implements the <code>LinkStyle</code> interface from a <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document②">Document</a></code> instance does not (by itself) cause the <code>CSSStyleSheet</code> referenced by a <code>CSSRule</code> to be
unreachable.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSRule" data-dfn-type="attribute" data-export id="dom-cssrule-type"><code>type</code></dfn> attribute is deprecated.
It must return an integer, as follows:</p>
   <dl class="switch">
    <dt>If the object is a <code class="idl"><a data-link-type="idl" href="#cssstylerule" id="ref-for-cssstylerule①">CSSStyleRule</a></code> 
    <dd>Return 1. 
    <dt>If the object is a <code class="idl"><a data-link-type="idl" href="#cssimportrule" id="ref-for-cssimportrule①">CSSImportRule</a></code> 
    <dd>Return 3. 
    <dt>If the object is a <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/css-conditional-3/#cssmediarule" id="ref-for-cssmediarule①">CSSMediaRule</a></code> 
    <dd>Return 4. 
    <dt>If the object is a <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/css-fonts-4/#cssfontfacerule" id="ref-for-cssfontfacerule②">CSSFontFaceRule</a></code> 
    <dd>Return 5. 
    <dt>If the object is a <code class="idl"><a data-link-type="idl" href="#csspagerule" id="ref-for-csspagerule②">CSSPageRule</a></code> 
    <dd>Return 6. 
    <dt>If the object is a <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/css-animations-1/#csskeyframesrule" id="ref-for-csskeyframesrule">CSSKeyframesRule</a></code> 
    <dd>Return 7. 
    <dt>If the object is a <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/css-animations-1/#csskeyframerule" id="ref-for-csskeyframerule">CSSKeyframeRule</a></code> 
    <dd>Return 8. 
    <dt>If the object is a <code class="idl"><a data-link-type="idl" href="#cssmarginrule" id="ref-for-cssmarginrule">CSSMarginRule</a></code> 
    <dd>Return 9. 
    <dt>If the object is a <code class="idl"><a data-link-type="idl" href="#cssnamespacerule" id="ref-for-cssnamespacerule①">CSSNamespaceRule</a></code> 
    <dd>Return 10. 
    <dt>If the object is a <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/css-counter-styles-3/#csscounterstylerule" id="ref-for-csscounterstylerule">CSSCounterStyleRule</a></code> 
    <dd>Return 11. 
    <dt>If the object is a <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/css-conditional-3/#csssupportsrule" id="ref-for-csssupportsrule">CSSSupportsRule</a></code> 
    <dd>Return 12. 
    <dt>If the object is a <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/css-fonts-4/#cssfontfeaturevaluesrule①" id="ref-for-cssfontfeaturevaluesrule①">CSSFontFeatureValuesRule</a></code> 
    <dd>Return 14. 
    <dt>If the object is a <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/css-device-adapt-1/#cssviewportrule" id="ref-for-cssviewportrule">CSSViewportRule</a></code> 
    <dd>Return 15. 
    <dt>Otherwise 
    <dd>Return 0. 
   </dl>
   <p class="note" role="note"><span>Note:</span> The practice of using an integer enumeration
and several constants to <em>identify</em> the integers
is a legacy design practice that is no longer used in Web APIs.
Instead, to tell what type of rule a given object is,
it is recommended to check <code class="highlight">rule<c- p>.</c->constructor<c- p>.</c->name</code>,
which will return a string like <code class="highlight"><c- u>"CSSStyleRule"</c-></code>.</p>
   <h4 class="heading settled" data-level="6.4.3" id="the-cssstylerule-interface"><span class="secno">6.4.3. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#cssstylerule" id="ref-for-cssstylerule②">CSSStyleRule</a></code> Interface</span><a class="self-link" href="#the-cssstylerule-interface"></a></h4>
   <p>The <code>CSSStyleRule</code> interface represents a style rule.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed⑥"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="cssstylerule"><code><c- g>CSSStyleRule</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#cssrule" id="ref-for-cssrule①⓪"><c- n>CSSRule</c-></a> {
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring⑦"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-cssstylerule-selectortext" id="ref-for-dom-cssstylerule-selectortext"><c- g>selectorText</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject④"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#PutForwards" id="ref-for-PutForwards①"><c- g>PutForwards</c-></a>=<a class="idl-code" data-link-type="attribute" href="#dom-cssstyledeclaration-csstext" id="ref-for-dom-cssstyledeclaration-csstext"><c- n>cssText</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssstyledeclaration" id="ref-for-cssstyledeclaration"><c- n>CSSStyleDeclaration</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleDeclaration" href="#dom-cssstylerule-style" id="ref-for-dom-cssstylerule-style"><c- g>style</c-></a>;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleRule" data-dfn-type="attribute" data-export id="dom-cssstylerule-selectortext"><code>selectorText</code></dfn> attribute, on getting, must return the result of <a data-link-type="dfn" href="#serialize-a-group-of-selectors" id="ref-for-serialize-a-group-of-selectors②">serializing</a> the associated <a data-link-type="dfn">group of selectors</a>.
On setting the <code class="idl"><a data-link-type="idl" href="#dom-cssstylerule-selectortext" id="ref-for-dom-cssstylerule-selectortext①">selectorText</a></code> attribute these steps must be run:</p>
   <ol>
    <li>Run the <a data-link-type="dfn" href="#parse-a-group-of-selectors" id="ref-for-parse-a-group-of-selectors">parse a group of selectors</a> algorithm on the given value. 
    <li>If the algorithm returns a non-null value replace the associated <a data-link-type="dfn">group of selectors</a> with the returned value. 
    <li>Otherwise, if the algorithm returns a null value, do nothing. 
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleRule" data-dfn-type="attribute" data-export id="dom-cssstylerule-style"><code>style</code></dfn> attribute must return a <code>CSSStyleDeclaration</code> object for the style rule, with the
following properties:</p>
   <dl>
    <dt><a data-link-type="dfn" href="#cssstyledeclaration-computed-flag" id="ref-for-cssstyledeclaration-computed-flag">computed flag</a> 
    <dd>Unset. 
    <dt><a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations">declarations</a> 
    <dd>The declared declarations in the rule, in <a data-link-type="dfn" href="#concept-declarations-specified-order" id="ref-for-concept-declarations-specified-order">specified order</a>. 
    <dt><a data-link-type="dfn" href="#cssstyledeclaration-parent-css-rule" id="ref-for-cssstyledeclaration-parent-css-rule">parent CSS rule</a> 
    <dd>The <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object">context object</a>. 
    <dt><a data-link-type="dfn" href="#cssstyledeclaration-owner-node" id="ref-for-cssstyledeclaration-owner-node">owner node</a> 
    <dd>Null. 
   </dl>
   <p>The <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-declarations-specified-order">specified order</dfn> for declarations is the same as specified, but with shorthand properties
expanded into their longhand properties, in canonical order. If a property is specified more than once (after shorthand expansion), only the
one with greatest cascading order must be represented, at the same relative position as it was specified. <a data-link-type="biblio" href="#biblio-css3cascade">[CSS3CASCADE]</a></p>
   <h4 class="heading settled" data-level="6.4.4" id="the-cssimportrule-interface"><span class="secno">6.4.4. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#cssimportrule" id="ref-for-cssimportrule②">CSSImportRule</a></code> Interface</span><a class="self-link" href="#the-cssimportrule-interface"></a></h4>
   <p>The <code>CSSImportRule</code> interface represents an <code>@import</code> at-rule.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed⑦"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="cssimportrule"><code><c- g>CSSImportRule</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#cssrule" id="ref-for-cssrule①①"><c- n>CSSRule</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString" id="ref-for-idl-USVString④"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-cssimportrule-href" id="ref-for-dom-cssimportrule-href"><c- g>href</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject⑤"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#PutForwards" id="ref-for-PutForwards②"><c- g>PutForwards</c-></a>=<a class="idl-code" data-link-type="attribute" href="#dom-medialist-mediatext" id="ref-for-dom-medialist-mediatext⑥"><c- n>mediaText</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#medialist" id="ref-for-medialist③"><c- n>MediaList</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="MediaList" href="#dom-cssimportrule-media" id="ref-for-dom-cssimportrule-media"><c- g>media</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject⑥"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssstylesheet" id="ref-for-cssstylesheet⑨"><c- n>CSSStyleSheet</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleSheet" href="#dom-cssimportrule-stylesheet" id="ref-for-dom-cssimportrule-stylesheet"><c- g>styleSheet</c-></a>;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSImportRule" data-dfn-type="attribute" data-export id="dom-cssimportrule-href"><code>href</code></dfn> attribute must return the <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url">URL</a> specified by
the <code>@import</code> at-rule.</p>
   <p class="note" role="note"><span>Note:</span> To get the resolved <a data-link-type="dfn" href="https://url.spec.whatwg.org/#concept-url" id="ref-for-concept-url①">URL</a> use the <code class="idl"><a data-link-type="idl" href="#dom-stylesheet-href" id="ref-for-dom-stylesheet-href①">href</a></code> attribute of the associated <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet④②">CSS style sheet</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSImportRule" data-dfn-type="attribute" data-export id="dom-cssimportrule-media"><code>media</code></dfn> attribute must return the value of the <code class="idl"><a data-link-type="idl" href="#dom-stylesheet-media" id="ref-for-dom-stylesheet-media①">media</a></code> attribute of the associated <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet④③">CSS style sheet</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSImportRule" data-dfn-type="attribute" data-export id="dom-cssimportrule-stylesheet"><code>styleSheet</code></dfn> attribute must return the associated <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet④④">CSS style sheet</a>.</p>
   <p class="note" role="note"><span>Note:</span> An <code>@import</code> at-rule always has an associated <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet④⑤">CSS style sheet</a>.</p>
   <h4 class="heading settled" data-level="6.4.5" id="the-cssgroupingrule-interface"><span class="secno">6.4.5. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#cssgroupingrule" id="ref-for-cssgroupingrule①">CSSGroupingRule</a></code> Interface</span><a class="self-link" href="#the-cssgroupingrule-interface"></a></h4>
   <p>The <code>CSSGroupingRule</code> interface represents an at-rule that contains other rules nested inside itself.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed⑧"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="cssgroupingrule"><code><c- g>CSSGroupingRule</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#cssrule" id="ref-for-cssrule①②"><c- n>CSSRule</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject⑦"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssrulelist" id="ref-for-cssrulelist⑥"><c- n>CSSRuleList</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSRuleList" href="#dom-cssgroupingrule-cssrules" id="ref-for-dom-cssgroupingrule-cssrules"><c- g>cssRules</c-></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long①①"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="method" href="#dom-cssgroupingrule-insertrule" id="ref-for-dom-cssgroupingrule-insertrule"><c- g>insertRule</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring⑧"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSSGroupingRule/insertRule(rule, index), CSSGroupingRule/insertRule(rule)" data-dfn-type="argument" data-export id="dom-cssgroupingrule-insertrule-rule-index-rule"><code><c- g>rule</c-></code><a class="self-link" href="#dom-cssgroupingrule-insertrule-rule-index-rule"></a></dfn>, <c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long①②"><c- b>unsigned</c-> <c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="CSSGroupingRule/insertRule(rule, index), CSSGroupingRule/insertRule(rule)" data-dfn-type="argument" data-export id="dom-cssgroupingrule-insertrule-rule-index-index"><code><c- g>index</c-></code><a class="self-link" href="#dom-cssgroupingrule-insertrule-rule-index-index"></a></dfn> = 0);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-cssgroupingrule-deleterule" id="ref-for-dom-cssgroupingrule-deleterule"><c- g>deleteRule</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long①③"><c- b>unsigned</c-> <c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="CSSGroupingRule/deleteRule(index)" data-dfn-type="argument" data-export id="dom-cssgroupingrule-deleterule-index-index"><code><c- g>index</c-></code><a class="self-link" href="#dom-cssgroupingrule-deleterule-index-index"></a></dfn>);
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSGroupingRule" data-dfn-type="attribute" data-export id="dom-cssgroupingrule-cssrules"><code>cssRules</code></dfn> attribute must return a <code>CSSRuleList</code> object for the <a data-link-type="dfn" href="#concept-css-rule-child-css-rules" id="ref-for-concept-css-rule-child-css-rules">child CSS rules</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSGroupingRule" data-dfn-type="method" data-export data-lt="insertRule(rule, index)|insertRule(rule)" id="dom-cssgroupingrule-insertrule"><code>insertRule(<var>rule</var>, <var>index</var>)</code></dfn> method must return the result of
invoking <a data-link-type="dfn" href="#insert-a-css-rule" id="ref-for-insert-a-css-rule①">insert a CSS rule</a> <var>rule</var> into the <a data-link-type="dfn" href="#concept-css-rule-child-css-rules" id="ref-for-concept-css-rule-child-css-rules①">child CSS rules</a> at <var>index</var>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSGroupingRule" data-dfn-type="method" data-export id="dom-cssgroupingrule-deleterule"><code>deleteRule(<var>index</var>)</code></dfn> method must <a data-link-type="dfn" href="#remove-a-css-rule" id="ref-for-remove-a-css-rule②">remove a CSS rule</a> from the <a data-link-type="dfn" href="#concept-css-rule-child-css-rules" id="ref-for-concept-css-rule-child-css-rules②">child CSS rules</a> at <var>index</var>.</p>
   <h4 class="heading settled" data-level="6.4.6" id="the-cssmediarule-interface"><span class="secno">6.4.6. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/css-conditional-3/#cssmediarule" id="ref-for-cssmediarule②">CSSMediaRule</a></code> Interface</span><a class="self-link" href="#the-cssmediarule-interface"></a></h4>
   <p>The <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/css-conditional-3/#cssmediarule" id="ref-for-cssmediarule③">CSSMediaRule</a></code> interface is defined in <cite>CSS Conditional Rules</cite>. <a data-link-type="biblio" href="#biblio-css3-conditional">[CSS3-CONDITIONAL]</a></p>
   <h4 class="heading settled" data-level="6.4.7" id="the-csspagerule-interface"><span class="secno">6.4.7. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#csspagerule" id="ref-for-csspagerule③">CSSPageRule</a></code> Interface</span><a class="self-link" href="#the-csspagerule-interface"></a></h4>
   <p>The <code>CSSPageRule</code> interface represents an <code>@page</code> at-rule.</p>
   <p class="issue" id="issue-ba9fab84"><a class="self-link" href="#issue-ba9fab84"></a> Need to define the rules for <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="parse-a-list-of-css-page-selectors">parse a list of CSS page selectors</dfn> and <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-a-list-of-css-page-selectors">serialize a list of CSS page selectors</dfn>.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed⑨"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="csspagerule"><code><c- g>CSSPageRule</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#cssgroupingrule" id="ref-for-cssgroupingrule②"><c- n>CSSGroupingRule</c-></a> {
           <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring⑨"><c- n>CSSOMString</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="CSSPageRule" data-dfn-type="attribute" data-export data-type="CSSOMString" id="dom-csspagerule-selectortext"><code><c- g>selectorText</c-></code></dfn>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject⑧"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#PutForwards" id="ref-for-PutForwards③"><c- g>PutForwards</c-></a>=<a class="idl-code" data-link-type="attribute" href="#dom-cssstyledeclaration-csstext" id="ref-for-dom-cssstyledeclaration-csstext①"><c- n>cssText</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssstyledeclaration" id="ref-for-cssstyledeclaration①"><c- n>CSSStyleDeclaration</c-></a> <dfn class="idl-code" data-dfn-for="CSSPageRule" data-dfn-type="attribute" data-export data-readonly data-type="CSSStyleDeclaration" id="dom-csspagerule-style"><code><c- g>style</c-></code><a class="self-link" href="#dom-csspagerule-style"></a></dfn>;
};
</pre>
   <p>The <dfn class="idl-code" data-dfn-for="CSSGroupingRule" data-dfn-type="attribute" data-export id="dom-cssgroupingrule-selectortext"><code>selectorText</code><a class="self-link" href="#dom-cssgroupingrule-selectortext"></a></dfn> attribute, on getting, must return the result of <a data-link-type="dfn" href="#serialize-a-list-of-css-page-selectors" id="ref-for-serialize-a-list-of-css-page-selectors">serializing</a> the associated <a data-link-type="dfn">list of CSS page selectors</a>.
On setting the <code class="idl"><a data-link-type="idl" href="#dom-csspagerule-selectortext" id="ref-for-dom-csspagerule-selectortext">selectorText</a></code> attribute  these steps must be run:</p>
   <ol>
    <li>Run the <a data-link-type="dfn" href="#parse-a-list-of-css-page-selectors" id="ref-for-parse-a-list-of-css-page-selectors">parse a list of CSS page selectors</a> algorithm on the given value. 
    <li>If the algorithm returns a non-null value replace the associated <a data-link-type="dfn">list of CSS page selectors</a> with the returned value. 
    <li>Otherwise, if the algorithm returns a null value, do nothing. 
   </ol>
   <p>The <dfn class="idl-code" data-dfn-for="CSSGroupingRule" data-dfn-type="attribute" data-export id="dom-cssgroupingrule-style"><code>style</code><a class="self-link" href="#dom-cssgroupingrule-style"></a></dfn> attribute must return a <code>CSSStyleDeclaration</code> object for the <code>@page</code> at-rule, with the following properties:</p>
   <dl>
    <dt><a data-link-type="dfn" href="#cssstyledeclaration-computed-flag" id="ref-for-cssstyledeclaration-computed-flag①">computed flag</a> 
    <dd>Unset. 
    <dt><a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations①">declarations</a> 
    <dd>The declared declarations in the rule, in <a data-link-type="dfn" href="#concept-declarations-specified-order" id="ref-for-concept-declarations-specified-order①">specified order</a>. 
    <dt><a data-link-type="dfn" href="#cssstyledeclaration-parent-css-rule" id="ref-for-cssstyledeclaration-parent-css-rule①">parent CSS rule</a> 
    <dd>The <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object①">context object</a>. 
    <dt><a data-link-type="dfn" href="#cssstyledeclaration-owner-node" id="ref-for-cssstyledeclaration-owner-node①">owner node</a> 
    <dd>Null. 
   </dl>
   <h4 class="heading settled" data-level="6.4.8" id="the-cssmarginrule-interface"><span class="secno">6.4.8. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#cssmarginrule" id="ref-for-cssmarginrule①">CSSMarginRule</a></code> Interface</span><a class="self-link" href="#the-cssmarginrule-interface"></a></h4>
   <p>The <code>CSSMarginRule</code> interface represents a margin at-rule (e.g. <code>@top-left</code>) in an <code>@page</code> at-rule. <a data-link-type="biblio" href="#biblio-css3page">[CSS3PAGE]</a></p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed①⓪"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="cssmarginrule"><code><c- g>CSSMarginRule</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#cssrule" id="ref-for-cssrule①③"><c- n>CSSRule</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring①⓪"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#dom-cssmarginrule-name" id="ref-for-dom-cssmarginrule-name"><c- g>name</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject⑨"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#PutForwards" id="ref-for-PutForwards④"><c- g>PutForwards</c-></a>=<a class="idl-code" data-link-type="attribute" href="#dom-cssstyledeclaration-csstext" id="ref-for-dom-cssstyledeclaration-csstext②"><c- n>cssText</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssstyledeclaration" id="ref-for-cssstyledeclaration②"><c- n>CSSStyleDeclaration</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleDeclaration" href="#dom-cssmarginrule-style" id="ref-for-dom-cssmarginrule-style"><c- g>style</c-></a>;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSMarginRule" data-dfn-type="attribute" data-export id="dom-cssmarginrule-name"><code>name</code></dfn> attribute must return the name of the margin at-rule. The <code>@</code> character is not
included in the name. <a data-link-type="biblio" href="#biblio-css3syn">[CSS3SYN]</a></p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSMarginRule" data-dfn-type="attribute" data-export id="dom-cssmarginrule-style"><code>style</code></dfn> attribute must return a <code>CSSStyleDeclaration</code> object for the
margin at-rule, with the following properties:</p>
   <dl>
    <dt><a data-link-type="dfn" href="#cssstyledeclaration-computed-flag" id="ref-for-cssstyledeclaration-computed-flag②">computed flag</a> 
    <dd>Unset. 
    <dt><a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations②">declarations</a> 
    <dd>The declared declarations in the rule, in <a data-link-type="dfn" href="#concept-declarations-specified-order" id="ref-for-concept-declarations-specified-order②">specified order</a>. 
    <dt><a data-link-type="dfn" href="#cssstyledeclaration-parent-css-rule" id="ref-for-cssstyledeclaration-parent-css-rule②">parent CSS rule</a> 
    <dd>The <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object②">context object</a>. 
    <dt><a data-link-type="dfn" href="#cssstyledeclaration-owner-node" id="ref-for-cssstyledeclaration-owner-node②">owner node</a> 
    <dd>Null. 
   </dl>
   <h4 class="heading settled" data-level="6.4.9" id="the-cssnamespacerule-interface"><span class="secno">6.4.9. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#cssnamespacerule" id="ref-for-cssnamespacerule②">CSSNamespaceRule</a></code> Interface</span><a class="self-link" href="#the-cssnamespacerule-interface"></a></h4>
   <p>The <code>CSSNamespaceRule</code> interface represents an <code>@namespace</code> at-rule.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed①①"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="cssnamespacerule"><code><c- g>CSSNamespaceRule</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#cssrule" id="ref-for-cssrule①④"><c- n>CSSRule</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring①①"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#dom-cssnamespacerule-namespaceuri" id="ref-for-dom-cssnamespacerule-namespaceuri①"><c- g>namespaceURI</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring①②"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#dom-cssnamespacerule-prefix" id="ref-for-dom-cssnamespacerule-prefix①"><c- g>prefix</c-></a>;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSNamespaceRule" data-dfn-type="attribute" data-export id="dom-cssnamespacerule-namespaceuri"><code>namespaceURI</code></dfn> attribute must return the namespace of the <code>@namespace</code> at-rule.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSNamespaceRule" data-dfn-type="attribute" data-export id="dom-cssnamespacerule-prefix"><code>prefix</code></dfn> attribute must return the prefix of the <code>@namespace</code> at-rule or the
empty string if there is no prefix.</p>
   <h3 class="heading settled" data-level="6.5" id="css-declarations"><span class="secno">6.5. </span><span class="content">CSS Declarations</span><a class="self-link" href="#css-declarations"></a></h3>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="css-declaration">CSS declaration</dfn> is an abstract concept that is not exposed as an object in the DOM. A <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration">CSS declaration</a> has the following associated
properties:</p>
   <dl>
    <dt><dfn class="dfn-paneled" data-dfn-for="CSS declaration" data-dfn-type="dfn" data-noexport id="css-declaration-property-name">property name</dfn> 
    <dd>The property name of the declaration. 
    <dt><dfn class="dfn-paneled" data-dfn-for="CSS declaration" data-dfn-type="dfn" data-noexport id="css-declaration-value">value</dfn> 
    <dd>The value of the declaration represented as a list of component values. 
    <dt><dfn class="dfn-paneled" data-dfn-for="CSS declaration" data-dfn-type="dfn" data-noexport id="css-declaration-important-flag">important flag</dfn> 
    <dd>Either set or unset. Can be changed. 
    <dt><dfn data-dfn-for="CSS declaration" data-dfn-type="dfn" data-noexport id="css-declaration-case-sensitive-flag">case-sensitive flag<a class="self-link" href="#css-declaration-case-sensitive-flag"></a></dfn> 
    <dd>Set if the <a data-link-type="dfn" href="#css-declaration-property-name" id="ref-for-css-declaration-property-name">property name</a> is defined to be case-sensitive according to its specification,
 otherwise unset. 
   </dl>
   <h3 class="heading settled" data-level="6.6" id="css-declaration-blocks"><span class="secno">6.6. </span><span class="content">CSS Declaration Blocks</span><a class="self-link" href="#css-declaration-blocks"></a></h3>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="css-declaration-block">CSS declaration block</dfn> is an ordered collection of CSS
properties with their associated values, also named <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration①">CSS declarations</a>. In
the DOM a <a data-link-type="dfn" href="#css-declaration-block" id="ref-for-css-declaration-block">CSS declaration block</a> is a <code>CSSStyleDeclaration</code> object. A <span id="ref-for-css-declaration-block①">CSS declaration block</span> has the following associated properties:</p>
   <dl>
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSStyleDeclaration" data-dfn-type="dfn" data-export id="cssstyledeclaration-computed-flag">computed flag</dfn> 
    <dd>Set if the object is a computed style declaration, rather than a specified
     style. Unless otherwise stated it is unset. 
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSStyleDeclaration" data-dfn-type="dfn" data-export id="cssstyledeclaration-declarations">declarations</dfn> 
    <dd>The <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration②">CSS declarations</a> associated with the object. 
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSStyleDeclaration" data-dfn-type="dfn" data-export id="cssstyledeclaration-parent-css-rule">parent CSS rule</dfn> 
    <dd>The <a data-link-type="dfn" href="#css-rule" id="ref-for-css-rule⑦">CSS rule</a> that the <a data-link-type="dfn" href="#css-declaration-block" id="ref-for-css-declaration-block②">CSS declaration block</a> is associated with, if any, or null otherwise. 
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSStyleDeclaration" data-dfn-type="dfn" data-export id="cssstyledeclaration-owner-node">owner node</dfn> 
    <dd>The <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#element" id="ref-for-element②">Element</a></code> that the <a data-link-type="dfn" href="#css-declaration-block" id="ref-for-css-declaration-block③">CSS declaration block</a> is associated with, if any, or
 null otherwise. 
    <dt><dfn class="dfn-paneled" data-dfn-for="CSSStyleDeclaration" data-dfn-type="dfn" data-export id="cssstyledeclaration-updating-flag">updating flag</dfn> 
    <dd>Unset by default. Set when the <a data-link-type="dfn" href="#css-declaration-block" id="ref-for-css-declaration-block④">CSS declaration block</a> is updating
 the <a data-link-type="dfn" href="#cssstyledeclaration-owner-node" id="ref-for-cssstyledeclaration-owner-node③">owner node</a>’s <code>style</code> attribute. 
   </dl>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="parse-a-css-declaration-block">parse a CSS declaration block</dfn> from a string <var>string</var>, follow these steps:</p>
   <ol>
    <li>Let <var>declarations</var> be the return value of invoking <a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#parse-a-list-of-declarations" id="ref-for-parse-a-list-of-declarations">parse a list of declarations</a> with <var>string</var>. 
    <li>Let <var>parsed declarations</var> be a new empty list. 
    <li>
     For each item <var>declaration</var> in <var>declarations</var>, follow these substeps: 
     <ol>
      <li>Let <var>parsed declaration</var> be the result of parsing <var>declaration</var> according to the appropriate CSS specifications, dropping parts that
   are said to be ignored. If the whole declaration is dropped, let <var>parsed declaration</var> be null. 
      <li>If <var>parsed declaration</var> is not null, append it to <var>parsed declarations</var>. 
     </ol>
    <li>Return <var>parsed declarations</var>. 
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-a-css-declaration">serialize a CSS declaration</dfn> with property name <var>property</var>, value <var>value</var> and optionally an <i>important</i> flag set, follow
these steps:</p>
   <ol>
    <li>Let <var>s</var> be the empty string. 
    <li>Append <var>property</var> to <var>s</var>. 
    <li>Append "<code>: </code>" (U+003A U+0020) to <var>s</var>. 
    <li>Append <var>value</var> to <var>s</var>. 
    <li>If the <i>important</i> flag is set, append "<code> !important</code>" (U+0020 U+0021 U+0069 U+006D U+0070 U+006F U+0072 U+0074 U+0061 U+006E
 U+0074) to <var>s</var>. 
    <li>Append "<code>;</code>" (U+003B) to <var>s</var>. 
    <li>Return <var>s</var>. 
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-a-css-declaration-block">serialize a CSS declaration block</dfn> <var>declaration block</var> means to run the steps below:</p>
   <ol>
    <li>Let <var>list</var> be an empty array. 
    <li>Let <var>already serialized</var> be an empty array. 
    <li>
     <i>Declaration loop</i>: For each <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration③">CSS declaration</a> <var>declaration</var> in <var>declaration block</var>’s <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations③">declarations</a>, follow these substeps: 
     <ol>
      <li>Let <var>property</var> be <var>declaration</var>’s <a data-link-type="dfn" href="#css-declaration-property-name" id="ref-for-css-declaration-property-name①">property name</a>. 
      <li>If <var>property</var> is in <var>already serialized</var>, continue with the steps labeled <i>declaration loop</i>. 
      <li>
       If <var>property</var> maps to one or more shorthand properties, let <var>shorthands</var> be an array of those shorthand properties, in <a data-link-type="dfn" href="#concept-shorthands-preferred-order" id="ref-for-concept-shorthands-preferred-order">preferred order</a>, and follow these substeps: 
       <ol>
        <li>Let <var>longhands</var> be an array consisting of all <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration④">CSS declarations</a> in <var>declaration block</var>’s <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations④">declarations</a> that that are not in <var>already serialized</var> and have a <a data-link-type="dfn" href="#css-declaration-property-name" id="ref-for-css-declaration-property-name②">property name</a> that
     maps to one of the shorthand properties in <var>shorthands</var>. 
        <li>
         <i>Shorthand loop</i>: For each <var>shorthand</var> in <var>shorthands</var>, follow these substeps: 
         <ol>
          <li>If all properties that map to <var>shorthand</var> are not present in <var>longhands</var>, continue with the steps labeled <i>shorthand loop</i>. 
          <li>Let <var>current longhands</var> be an empty array. 
          <li>Append all <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration⑤">CSS declarations</a> in <var>longhands</var> have a <a data-link-type="dfn" href="#css-declaration-property-name" id="ref-for-css-declaration-property-name③">property name</a> that maps to <var>shorthand</var> to <var>current longhands</var>. 
          <li>If there is one or more <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration⑥">CSS declarations</a> in <var>current longhands</var> have their <a data-link-type="dfn" href="#css-declaration-important-flag" id="ref-for-css-declaration-important-flag">important flag</a> set and one or more with it unset, continue with
       the steps labeled <i>shorthand loop</i>. 
          <li>Let <var>value</var> be the result of invoking <a data-link-type="dfn" href="#serialize-a-css-value" id="ref-for-serialize-a-css-value">serialize a CSS value</a> of <var>current longhands</var>. 
          <li>If <var>value</var> is the empty string, continue with the steps labeled <i>shorthand loop</i>. 
          <li>Let <var>serialized declaration</var> be the result of invoking <a data-link-type="dfn" href="#serialize-a-css-declaration" id="ref-for-serialize-a-css-declaration">serialize a CSS declaration</a> with property name <var>shorthand</var>, value <var>value</var>, and the <i>important</i> flag set if the <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration⑦">CSS declarations</a> in <var>current longhands</var> have their <a data-link-type="dfn" href="#css-declaration-important-flag" id="ref-for-css-declaration-important-flag①">important flag</a> set. 
          <li>Append <var>serialized declaration</var> to <var>list</var>. 
          <li>Append the property names of all items of <var>current longhands</var> to <var>already serialized</var>. 
          <li>Remove the items present in <var>current longhands</var> from <var>longhands</var>. 
         </ol>
       </ol>
      <li>If <var>property</var> is in <var>already serialized</var>, continue with the steps labeled <i>declaration loop</i>. 
      <li>Let <var>value</var> be the result of invoking <a data-link-type="dfn" href="#serialize-a-css-value" id="ref-for-serialize-a-css-value①">serialize a CSS value</a> of <var>declaration</var>. 
      <li>Let <var>serialized declaration</var> be the result of invoking <a data-link-type="dfn" href="#serialize-a-css-declaration" id="ref-for-serialize-a-css-declaration①">serialize a CSS declaration</a> with property name <var>property</var>, value <var>value</var>, and the <i>important</i> flag set if <var>declaration</var> has its <a data-link-type="dfn" href="#css-declaration-important-flag" id="ref-for-css-declaration-important-flag②">important
   flag</a> set. 
      <li>Append <var>serialized declaration</var> to <var>list</var>. 
      <li>Append <var>property</var> to <var>already serialized</var>. 
     </ol>
    <li>Return <var>list</var> joined with "<code> </code>" (U+0020). 
   </ol>
   <p class="note" role="note"><span>Note:</span> The serialization of an empty CSS declaration block is the empty string.</p>
   <p class="note" role="note"><span>Note:</span> The serialization of a non-empty CSS declaration block does not include any surrounding whitespace, i.e., no whitespace appears
before the first property name and no whitespace appears after the final semicolon delimiter that follows the last property value.</p>
   <p>A <a data-link-type="dfn" href="#css-declaration-block" id="ref-for-css-declaration-block⑤">CSS declaration block</a> has these <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-element-attributes-change-ext" id="ref-for-concept-element-attributes-change-ext">attribute change steps</a> for its <a data-link-type="dfn" href="#cssstyledeclaration-owner-node" id="ref-for-cssstyledeclaration-owner-node④">owner node</a> with <var>localName</var>, <var>value</var>, and <var>namespace</var>:</p>
   <ol>
    <li>If the <a data-link-type="dfn" href="#cssstyledeclaration-computed-flag" id="ref-for-cssstyledeclaration-computed-flag③">computed flag</a> is set, then return. 
    <li>If the <a data-link-type="dfn" href="#cssstyledeclaration-updating-flag" id="ref-for-cssstyledeclaration-updating-flag">updating flag</a> is set, then return. 
    <li>If <var>localName</var> is not "<code>style</code>", or <var>namespace</var> is not null, then return. 
    <li>If <var>value</var> is null, empty the <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations⑤">declarations</a>. 
    <li>Otherwise, let the <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations⑥">declarations</a> be the result of <a data-link-type="dfn" href="#parse-a-css-declaration-block" id="ref-for-parse-a-css-declaration-block">parse a CSS declaration block</a> from a string <var>value</var>. 
   </ol>
   <p>When a <a data-link-type="dfn" href="#css-declaration-block" id="ref-for-css-declaration-block⑥">CSS declaration block</a> object is created, then:</p>
   <ol>
    <li>Let <var>owner node</var> be the <a data-link-type="dfn" href="#cssstyledeclaration-owner-node" id="ref-for-cssstyledeclaration-owner-node⑤">owner node</a>. 
    <li>If <var>owner node</var> is null, or the <a data-link-type="dfn" href="#cssstyledeclaration-computed-flag" id="ref-for-cssstyledeclaration-computed-flag④">computed flag</a> is set, then return. 
    <li>Let <var>value</var> be the result of <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-element-attributes-get-by-namespace" id="ref-for-concept-element-attributes-get-by-namespace">getting an attribute</a> given null, "<code>style</code>", and <var>owner node</var>. 
    <li>If <var>value</var> is not null, let the <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations⑦">declarations</a> be the result of <a data-link-type="dfn" href="#parse-a-css-declaration-block" id="ref-for-parse-a-css-declaration-block①">parse a CSS declaration block</a> from a string <var>value</var>. 
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="update-style-attribute-for">update style attribute for</dfn> <var>declaration block</var> means to run the steps below:</p>
   <ol>
    <li>Assert: <var>declaration block</var>’s <a data-link-type="dfn" href="#cssstyledeclaration-computed-flag" id="ref-for-cssstyledeclaration-computed-flag⑤">computed flag</a> is unset. 
    <li>Let <var>owner node</var> be <var>declaration block</var>’s <a data-link-type="dfn" href="#cssstyledeclaration-owner-node" id="ref-for-cssstyledeclaration-owner-node⑥">owner node</a>. 
    <li>If <var>owner node</var> is null, then return. 
    <li>Set <var>declaration block</var>’s <a data-link-type="dfn" href="#cssstyledeclaration-updating-flag" id="ref-for-cssstyledeclaration-updating-flag①">updating flag</a>. 
    <li><a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-element-attributes-set-value" id="ref-for-concept-element-attributes-set-value">Set an attribute value</a> for <var>owner node</var> using "<code>style</code>" and the result of <a data-link-type="dfn" href="#serialize-a-css-declaration-block" id="ref-for-serialize-a-css-declaration-block①">serializing</a> <var>declaration block</var>. 
    <li>Unset <var>declaration block</var>’s <a data-link-type="dfn" href="#cssstyledeclaration-updating-flag" id="ref-for-cssstyledeclaration-updating-flag②">updating flag</a>. 
   </ol>
   <p>The <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="concept-shorthands-preferred-order">preferred order</dfn> of a list of shorthand properties <var>shorthands</var> is as follows:</p>
   <ol>
    <li>Order <var>shorthands</var> lexicographically. 
    <li>Move all items in <var>shorthands</var> that begin with "<code>-</code>" (U+002D) last in the list, retaining their relative order. 
    <li>Move all items in <var>shorthands</var> that begin with "<code>-</code>" (U+002D) but do not begin with "<code>-webkit-</code>" last in the
 list, retaining their relative order. 
    <li>Order <var>shorthands</var> by the number of longhand properties that map to it, with the greatest number first. 
   </ol>
   <h4 class="heading settled" data-level="6.6.1" id="the-cssstyledeclaration-interface"><span class="secno">6.6.1. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#cssstyledeclaration" id="ref-for-cssstyledeclaration③">CSSStyleDeclaration</a></code> Interface</span><a class="self-link" href="#the-cssstyledeclaration-interface"></a></h4>
   <p>The <code>CSSStyleDeclaration</code> interface represents a <a data-link-type="dfn" href="#css-declaration-block" id="ref-for-css-declaration-block⑦">CSS declaration block</a>, including its underlying state, where this
underlying state depends upon the source of the <code>CSSStyleDeclaration</code> instance.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed①②"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="cssstyledeclaration"><code><c- g>CSSStyleDeclaration</c-></code></dfn> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://html.spec.whatwg.org/multipage/custom-elements.html#cereactions" id="ref-for-cereactions"><c- g>CEReactions</c-></a>] <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring①③"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-cssstyledeclaration-csstext" id="ref-for-dom-cssstyledeclaration-csstext③"><c- g>cssText</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long①④"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned long" href="#dom-cssstyledeclaration-length" id="ref-for-dom-cssstyledeclaration-length"><c- g>length</c-></a>;
  <c- b>getter</c-> <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring①④"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="method" href="#dom-cssstyledeclaration-item" id="ref-for-dom-cssstyledeclaration-item"><c- g>item</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long①⑤"><c- b>unsigned</c-> <c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleDeclaration/item(index)" data-dfn-type="argument" data-export id="dom-cssstyledeclaration-item-index-index"><code><c- g>index</c-></code><a class="self-link" href="#dom-cssstyledeclaration-item-index-index"></a></dfn>);
  <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring①⑤"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="method" href="#dom-cssstyledeclaration-getpropertyvalue" id="ref-for-dom-cssstyledeclaration-getpropertyvalue"><c- g>getPropertyValue</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring①⑥"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleDeclaration/getPropertyValue(property)" data-dfn-type="argument" data-export id="dom-cssstyledeclaration-getpropertyvalue-property-property"><code><c- g>property</c-></code><a class="self-link" href="#dom-cssstyledeclaration-getpropertyvalue-property-property"></a></dfn>);
  <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring①⑦"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="method" href="#dom-cssstyledeclaration-getpropertypriority" id="ref-for-dom-cssstyledeclaration-getpropertypriority"><c- g>getPropertyPriority</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring①⑧"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleDeclaration/getPropertyPriority(property)" data-dfn-type="argument" data-export id="dom-cssstyledeclaration-getpropertypriority-property-property"><code><c- g>property</c-></code><a class="self-link" href="#dom-cssstyledeclaration-getpropertypriority-property-property"></a></dfn>);
  [<a class="idl-code" data-link-type="extended-attribute" href="https://html.spec.whatwg.org/multipage/custom-elements.html#cereactions" id="ref-for-cereactions①"><c- g>CEReactions</c-></a>] <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-cssstyledeclaration-setproperty" id="ref-for-dom-cssstyledeclaration-setproperty"><c- g>setProperty</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring①⑨"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleDeclaration/setProperty(property, value, priority), CSSStyleDeclaration/setProperty(property, value)" data-dfn-type="argument" data-export id="dom-cssstyledeclaration-setproperty-property-value-priority-property"><code><c- g>property</c-></code><a class="self-link" href="#dom-cssstyledeclaration-setproperty-property-value-priority-property"></a></dfn>, [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#TreatNullAs" id="ref-for-TreatNullAs①"><c- g>TreatNullAs</c-></a>=<a class="n" data-link-type="idl-name"><c- n>EmptyString</c-></a>] <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring②⓪"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleDeclaration/setProperty(property, value, priority), CSSStyleDeclaration/setProperty(property, value)" data-dfn-type="argument" data-export id="dom-cssstyledeclaration-setproperty-property-value-priority-value"><code><c- g>value</c-></code><a class="self-link" href="#dom-cssstyledeclaration-setproperty-property-value-priority-value"></a></dfn>, <c- b>optional</c-> [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#TreatNullAs" id="ref-for-TreatNullAs②"><c- g>TreatNullAs</c-></a>=<a class="n" data-link-type="idl-name"><c- n>EmptyString</c-></a>] <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring②①"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleDeclaration/setProperty(property, value, priority), CSSStyleDeclaration/setProperty(property, value)" data-dfn-type="argument" data-export id="dom-cssstyledeclaration-setproperty-property-value-priority-priority"><code><c- g>priority</c-></code><a class="self-link" href="#dom-cssstyledeclaration-setproperty-property-value-priority-priority"></a></dfn> = "");
  [<a class="idl-code" data-link-type="extended-attribute" href="https://html.spec.whatwg.org/multipage/custom-elements.html#cereactions" id="ref-for-cereactions②"><c- g>CEReactions</c-></a>] <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring②②"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="method" href="#dom-cssstyledeclaration-removeproperty" id="ref-for-dom-cssstyledeclaration-removeproperty"><c- g>removeProperty</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring②③"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleDeclaration/removeProperty(property)" data-dfn-type="argument" data-export id="dom-cssstyledeclaration-removeproperty-property-property"><code><c- g>property</c-></code><a class="self-link" href="#dom-cssstyledeclaration-removeproperty-property-property"></a></dfn>);
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssrule" id="ref-for-cssrule①⑤"><c- n>CSSRule</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSRule?" href="#dom-cssstyledeclaration-parentrule" id="ref-for-dom-cssstyledeclaration-parentrule"><c- g>parentRule</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://html.spec.whatwg.org/multipage/custom-elements.html#cereactions" id="ref-for-cereactions③"><c- g>CEReactions</c-></a>] <c- b>attribute</c-> [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#TreatNullAs" id="ref-for-TreatNullAs③"><c- g>TreatNullAs</c-></a>=<a class="n" data-link-type="idl-name"><c- n>EmptyString</c-></a>] <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring②④"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="[TreatNullAs=EmptyString] CSSOMString" href="#dom-cssstyledeclaration-cssfloat" id="ref-for-dom-cssstyledeclaration-cssfloat"><c- g>cssFloat</c-></a>;
};
</pre>
   <p>The object’s <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-supported-property-indices" id="ref-for-dfn-supported-property-indices⑥">supported property indices</a> are the numbers in the range zero to one less than the number of <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration⑧">CSS declarations</a> in the <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations⑧">declarations</a>. If there are no such <span id="ref-for-css-declaration⑨">CSS declarations</span>, then there are no <span id="ref-for-dfn-supported-property-indices⑦">supported property indices</span>.</p>
   <p>Getting the <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleDeclaration" data-dfn-type="attribute" data-export id="dom-cssstyledeclaration-csstext"><code>cssText</code></dfn> attribute must run these steps:</p>
   <ol>
    <li data-md>
     <p>If the <a data-link-type="dfn" href="#cssstyledeclaration-computed-flag" id="ref-for-cssstyledeclaration-computed-flag⑥">computed flag</a> is set, then return the empty string.</p>
    <li data-md>
     <p>Return the result of <a data-link-type="dfn" href="#serialize-a-css-declaration-block" id="ref-for-serialize-a-css-declaration-block②">serializing</a> the <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations⑨">declarations</a>.</p>
   </ol>
   <p>Setting the <code class="idl"><a data-link-type="idl" href="#dom-cssstyledeclaration-csstext" id="ref-for-dom-cssstyledeclaration-csstext④">cssText</a></code> attribute must run these steps:</p>
   <ol>
    <li>If the <a data-link-type="dfn" href="#cssstyledeclaration-computed-flag" id="ref-for-cssstyledeclaration-computed-flag⑦">computed flag</a> is set,
 then <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①⓪">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#nomodificationallowederror" id="ref-for-nomodificationallowederror">NoModificationAllowedError</a></code> exception. 
    <li>Empty the <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations①⓪">declarations</a>. 
    <li><a data-link-type="dfn" href="#parse-a-css-declaration-block" id="ref-for-parse-a-css-declaration-block②">Parse</a> the given value and, if the return value is not the empty list, insert the items in the list
 into the <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations①①">declarations</a>, in <a data-link-type="dfn" href="#concept-declarations-specified-order" id="ref-for-concept-declarations-specified-order③">specified order</a>. 
    <li><a data-link-type="dfn" href="#update-style-attribute-for" id="ref-for-update-style-attribute-for">Update style attribute for</a> the <a data-link-type="dfn" href="#css-declaration-block" id="ref-for-css-declaration-block⑧">CSS declaration block</a>. 
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleDeclaration" data-dfn-type="attribute" data-export id="dom-cssstyledeclaration-length"><code>length</code></dfn> attribute must return the number of <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration①⓪">CSS
declarations</a> in the <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations①②">declarations</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleDeclaration" data-dfn-type="method" data-export id="dom-cssstyledeclaration-item"><code>item(<var>index</var>)</code></dfn> method must return the <a data-link-type="dfn" href="#css-declaration-property-name" id="ref-for-css-declaration-property-name④">property name</a> of the <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration①①">CSS declaration</a> at position <var>index</var>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleDeclaration" data-dfn-type="method" data-export id="dom-cssstyledeclaration-getpropertyvalue"><code>getPropertyValue(<var>property</var>)</code></dfn> method must run these steps:</p>
   <ol>
    <li>
     If <var>property</var> is not a <a data-link-type="dfn" href="https://drafts.csswg.org/css-variables-1/#custom-property" id="ref-for-custom-property①">custom property</a>, follow these substeps: 
     <ol>
      <li>Let <var>property</var> be <var>property</var> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-lowercase" id="ref-for-ascii-lowercase②">converted to ASCII lowercase</a>. 
      <li>
       If <var>property</var> is a shorthand property, then follow these substeps: 
       <ol>
        <li>Let <var>list</var> be a new empty array. 
        <li>
         For each longhand property <var>longhand</var> that <var>property</var> maps to, in canonical order, follow these substeps: 
         <ol>
          <li>If <var>longhand</var> is a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive⑧">case-sensitive</a> match for a <a data-link-type="dfn" href="#css-declaration-property-name" id="ref-for-css-declaration-property-name⑤">property
       name</a> of a <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration①②">CSS declaration</a> in the <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations①③">declarations</a>, let <var>declaration</var> be that <span id="ref-for-css-declaration①③">CSS declaration</span>, or null otherwise. 
          <li>If <var>declaration</var> is null, then return the empty string. 
          <li>Append the <var>declaration</var> to <var>list</var>. 
         </ol>
        <li>If <a data-link-type="dfn" href="#css-declaration-important-flag" id="ref-for-css-declaration-important-flag③">important flags</a> of all declarations in <var>list</var> are same,
     then return the <a data-link-type="dfn" href="#serialize-a-css-value" id="ref-for-serialize-a-css-value②">serialization</a> of <var>list</var>. 
        <li>Return the empty string. 
       </ol>
     </ol>
    <li>If <var>property</var> is a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive⑨">case-sensitive</a> match for a <a data-link-type="dfn" href="#css-declaration-property-name" id="ref-for-css-declaration-property-name⑥">property name</a> of a <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration①④">CSS declaration</a> in the <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations①④">declarations</a>, then return the result of invoking <a data-link-type="dfn" href="#serialize-a-css-value" id="ref-for-serialize-a-css-value③">serialize a CSS value</a> of that declaration. 
    <li>Return the empty string. 
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleDeclaration" data-dfn-type="method" data-export id="dom-cssstyledeclaration-getpropertypriority"><code>getPropertyPriority(<var>property</var>)</code></dfn> method must run these steps:</p>
   <ol>
    <li>
     If <var>property</var> is not a <a data-link-type="dfn" href="https://drafts.csswg.org/css-variables-1/#custom-property" id="ref-for-custom-property②">custom property</a>, follow these substeps: 
     <ol>
      <li>Let <var>property</var> be <var>property</var> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-lowercase" id="ref-for-ascii-lowercase③">converted to ASCII lowercase</a>. 
      <li>
       If <var>property</var> is a shorthand property, follow these substeps: 
       <ol>
        <li>Let <var>list</var> be a new array. 
        <li>For each longhand property <var>longhand</var> that <var>property</var> maps to, append the result of invoking <code class="idl"><a data-link-type="idl" href="#dom-cssstyledeclaration-getpropertypriority" id="ref-for-dom-cssstyledeclaration-getpropertypriority①">getPropertyPriority()</a></code> with <var>longhand</var> as argument to <var>list</var>. 
        <li>If all items in <var>list</var> are the string "<code>important</code>", then return the string "<code>important</code>". 
       </ol>
     </ol>
    <li>If <var>property</var> is a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive①⓪">case-sensitive</a> match for a <a data-link-type="dfn" href="#css-declaration-property-name" id="ref-for-css-declaration-property-name⑦">property name</a> of a <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration①⑤">CSS
 declaration</a> in the <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations①⑤">declarations</a> that has the <a data-link-type="dfn" href="#css-declaration-important-flag" id="ref-for-css-declaration-important-flag④">important flag</a> set, return the string "<code>important</code>". 
    <li>Return the empty string. 
   </ol>
   <div class="example" id="example-666534ab"><a class="self-link" href="#example-666534ab"></a>E.g. for <code>background-color:lime !IMPORTANT</code> the return
value would be "<code>important</code>".</div>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleDeclaration" data-dfn-type="method" data-export data-lt="setProperty(property, value, priority)|setProperty(property, value)" id="dom-cssstyledeclaration-setproperty"><code>setProperty(<var>property</var>, <var>value</var>, <var>priority</var>)</code></dfn> method must run these steps:</p>
   <ol>
    <li>If the <a data-link-type="dfn" href="#cssstyledeclaration-computed-flag" id="ref-for-cssstyledeclaration-computed-flag⑧">computed flag</a> is set,
 then <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①①">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#nomodificationallowederror" id="ref-for-nomodificationallowederror①">NoModificationAllowedError</a></code> exception. 
    <li>
     If <var>property</var> is not a <a data-link-type="dfn" href="https://drafts.csswg.org/css-variables-1/#custom-property" id="ref-for-custom-property③">custom property</a>, follow these substeps: 
     <ol>
      <li>Let <var>property</var> be <var>property</var> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-lowercase" id="ref-for-ascii-lowercase④">converted to ASCII lowercase</a>. 
      <li>If <var>property</var> is not a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive①①">case-sensitive</a> match for a <a data-link-type="dfn" href="#supported-css-property" id="ref-for-supported-css-property①">supported CSS property</a>, then return. 
     </ol>
    <li>If <var>value</var> is the empty string, invoke <code class="idl"><a data-link-type="idl" href="#dom-cssstyledeclaration-removeproperty" id="ref-for-dom-cssstyledeclaration-removeproperty①">removeProperty()</a></code> with <var>property</var> as argument and return. 
    <li>If <var>priority</var> is not the empty string and is not an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#ascii-case-insensitive" id="ref-for-ascii-case-insensitive④">ASCII case-insensitive</a> match for the string
 "<code>important</code>", then return. 
    <li>
      Let <var>component value list</var> be the result of <a data-link-type="dfn" href="#parse-a-css-value" id="ref-for-parse-a-css-value">parsing</a> <var>value</var> for property <var>property</var>. 
     <p class="note" role="note"><span>Note:</span> <var>value</var> can not include "<code>!important</code>".</p>
    <li>If <var>component value list</var> is null, then return. 
    <li>Let <var>updated</var> be false. 
    <li>
     If <var>property</var> is a shorthand property, then for each longhand property <var>longhand</var> that <var>property</var> maps to, in canonical
 order, follow these substeps: 
     <ol>
      <li>Let <var>longhand result</var> be the result of <a data-link-type="dfn" href="#set-a-css-declaration" id="ref-for-set-a-css-declaration">set the CSS declaration</a> <var>longhand</var> with the appropriate value(s) from <var>component value list</var>, with the <i>important</i> flag set if <var>priority</var> is not the empty string, and unset otherwise, and with the list of declarations
   being the <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations①⑥">declarations</a>. 
      <li>If <var>longhand result</var> is true, let <var>updated</var> be true. 
     </ol>
    <li>Otherwise, let <var>updated</var> be the result of <a data-link-type="dfn" href="#set-a-css-declaration" id="ref-for-set-a-css-declaration①">set the CSS declaration</a> <var>property</var> with value <var>component value list</var>, with the <i>important</i> flag set if <var>priority</var> is not the empty string, and unset otherwise, and with the list of declarations being the <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations①⑦">declarations</a>. 
    <li>If <var>updated</var> is true, <a data-link-type="dfn" href="#update-style-attribute-for" id="ref-for-update-style-attribute-for①">update style attribute for</a> the <a data-link-type="dfn" href="#css-declaration-block" id="ref-for-css-declaration-block⑨">CSS declaration block</a>. 
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="set-a-css-declaration">set a CSS declaration</dfn> <var>property</var> with a value <var>component value list</var> and optionally with an <i>important</i> flag set, in
a list of declarations <var>declarations</var>, the user agent must ensure the following constraints hold after its steps:</p>
   <ul>
    <li> Exactly one <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration①⑥">CSS declaration</a> whose <a data-link-type="dfn" href="#css-declaration-property-name" id="ref-for-css-declaration-property-name⑧">property name</a> is a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive①②">case-sensitive</a> match of <var>property</var> must exist in <var>declarations</var>.
  Such declaration is referenced as the <var>target declaration</var> below. 
    <li> The <var>target declaration</var> must have value being <var>component value list</var>,
  and <var>target declaration</var>’s <a data-link-type="dfn" href="#css-declaration-important-flag" id="ref-for-css-declaration-important-flag⑤">important flag</a> must be <a data-link-type="dfn" href="#set" id="ref-for-set">set</a> if <i>important</i> flag is set, and <a data-link-type="dfn" href="#unset" id="ref-for-unset">unset</a> otherwise. 
    <li> Any <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration①⑦">CSS declaration</a> which is not the <var>target declaration</var> must not be changed, inserted,
  or removed from <var>declarations</var>. 
    <li> If there are <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration①⑧">CSS declarations</a> in <var>declarations</var> whose <a data-link-type="dfn" href="#css-declaration-property-name" id="ref-for-css-declaration-property-name⑨">property name</a> is in the same <a data-link-type="dfn" href="https://drafts.csswg.org/css-logical-1/#logical-property-group" id="ref-for-logical-property-group">logical property group</a> as <var>property</var>, but has a different <a data-link-type="dfn" href="https://drafts.csswg.org/css-logical-1/#mapping-logic" id="ref-for-mapping-logic">mapping logic</a>, <var>target declaration</var> must be
  at an index after all of those <span id="ref-for-css-declaration①⑨">CSS declarations</span>. 
    <li> The steps must return true if the serialization of <var>declarations</var> was changed as result
  of the steps. It may return false otherwise. 
   </ul>
   <p class="issue" id="issue-aaf411cc"><a class="self-link" href="#issue-aaf411cc"></a> Should we add something like "Any observable side effect must not be made outside <var>declarations</var>"? The current constraints sound like a hole for undefined behavior.</p>
   <p class="note" role="note"><span>Note:</span> The steps of <a data-link-type="dfn" href="#set-a-css-declaration" id="ref-for-set-a-css-declaration②">set a CSS declaration</a> are not defined in this level of CSSOM. User agents may
use different algorithms as long as the constraints above hold.</p>
   <div class="example" id="example-a40690cb">
    <a class="self-link" href="#example-a40690cb"></a> The simplest way to conform with the constraints would be to always remove any existing declaration
 matching <var>property</var>, and append the new declaration to the end. But based on implementation
 feedback, this approach would likely regress performance. 
    <p>Another possible algorithm is:</p>
    <ol>
     <li>
      If <var>property</var> is a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive①③">case-sensitive</a> match for a <a data-link-type="dfn" href="#css-declaration-property-name" id="ref-for-css-declaration-property-name①⓪">property name</a> of a <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration②⓪">CSS declaration</a> in <var>declarations</var>, follow these substeps: 
      <ol>
       <li>Let <var>target declaration</var> be such <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration②①">CSS declaration</a>. 
       <li>Let <var>needs append</var> be false. 
       <li>
        <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-iterate" id="ref-for-list-iterate">For each</a> <var>declaration</var> in <var>declarations</var> after <var>target declaration</var>: 
        <ol>
         <li>If <var>declaration</var>’s <a data-link-type="dfn" href="#css-declaration-property-name" id="ref-for-css-declaration-property-name①①">property name</a> is not in the same <a data-link-type="dfn" href="https://drafts.csswg.org/css-logical-1/#logical-property-group" id="ref-for-logical-property-group①">logical property group</a> as <var>property</var>, then <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#iteration-continue" id="ref-for-iteration-continue">continue</a>. 
         <li>If <var>declaration</var>’ <a data-link-type="dfn" href="#css-declaration-property-name" id="ref-for-css-declaration-property-name①②">property name</a> has the same <a data-link-type="dfn" href="https://drafts.csswg.org/css-logical-1/#mapping-logic" id="ref-for-mapping-logic①">mapping logic</a> as <var>property</var>, then <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#iteration-continue" id="ref-for-iteration-continue①">continue</a>. 
         <li>Let <var>needs append</var> be true. 
         <li><a data-link-type="dfn" href="https://infra.spec.whatwg.org/#iteration-break" id="ref-for-iteration-break">Break</a>. 
        </ol>
       <li>
        If <var>needs append</var> is false, then: 
        <ol>
         <li>Let <var>needs update</var> be false. 
         <li>If <var>target declaration</var>’s <a data-link-type="dfn" href="#css-declaration-value" id="ref-for-css-declaration-value">value</a> is not equal to <var>component
        value list</var>, then let <var>needs update</var> be true. 
         <li>If <var>target declaration</var>’s <a data-link-type="dfn" href="#css-declaration-important-flag" id="ref-for-css-declaration-important-flag⑥">important flag</a> is not equal to
        whether <i>important</i> flag is set, then let <var>needs update</var> be true. 
         <li>If <var>needs update</var> is false, then return false. 
         <li>Set <var>target declaration</var>’s <a data-link-type="dfn" href="#css-declaration-value" id="ref-for-css-declaration-value①">value</a> to <var>component value list</var>. 
         <li>If <i>important</i> flag is set, then set <var>target declaration</var>’s <a data-link-type="dfn" href="#css-declaration-important-flag" id="ref-for-css-declaration-important-flag⑦">important flag</a>, otherwise unset it. 
         <li>Return true. 
        </ol>
       <li>Otherwise, remove <var>target declaration</var> from <var>declarations</var>. 
      </ol>
     <li>Append a new <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration②②">CSS declaration</a> with <a data-link-type="dfn" href="#css-declaration-property-name" id="ref-for-css-declaration-property-name①③">property name</a> <var>property</var>, <a data-link-type="dfn" href="#css-declaration-value" id="ref-for-css-declaration-value②">value</a> <var>component value list</var>, and <a data-link-type="dfn" href="#css-declaration-important-flag" id="ref-for-css-declaration-important-flag⑧">important flag</a> set if <i>important</i> flag is set to <var>declarations</var>. 
     <li>Return true. 
    </ol>
   </div>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleDeclaration" data-dfn-type="method" data-export id="dom-cssstyledeclaration-removeproperty"><code>removeProperty(<var>property</var>)</code></dfn> method must run these steps:</p>
   <ol>
    <li>If the <a data-link-type="dfn" href="#cssstyledeclaration-computed-flag" id="ref-for-cssstyledeclaration-computed-flag⑨">computed flag</a> is set,
 then <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①②">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#nomodificationallowederror" id="ref-for-nomodificationallowederror②">NoModificationAllowedError</a></code> exception. 
    <li>If <var>property</var> is not a <a data-link-type="dfn" href="https://drafts.csswg.org/css-variables-1/#custom-property" id="ref-for-custom-property④">custom property</a>,
 let <var>property</var> be <var>property</var> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-lowercase" id="ref-for-ascii-lowercase⑤">converted to ASCII lowercase</a>. 
    <li>Let <var>value</var> be the return value of invoking <code class="idl"><a data-link-type="idl" href="#dom-cssstyledeclaration-getpropertyvalue" id="ref-for-dom-cssstyledeclaration-getpropertyvalue①">getPropertyValue()</a></code> with <var>property</var> as argument. 
    <li>Let <var>removed</var> be false. 
    <li>
     If <var>property</var> is a shorthand property, for each longhand property <var>longhand</var> that <var>property</var> maps to: 
     <ol>
      <li>If <var>longhand</var> is not a <a data-link-type="dfn" href="#css-declaration-property-name" id="ref-for-css-declaration-property-name①④">property name</a> of a <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration②③">CSS declaration</a> in the <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations①⑧">declarations</a>, <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#iteration-continue" id="ref-for-iteration-continue②">continue</a>. 
      <li>Remove that <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration②④">CSS declaration</a> and let <var>removed</var> be true. 
     </ol>
    <li>Otherwise, if <var>property</var> is a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive①④">case-sensitive</a> match for a <a data-link-type="dfn" href="#css-declaration-property-name" id="ref-for-css-declaration-property-name①⑤">property name</a> of a <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration②⑤">CSS declaration</a> in the <a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations①⑨">declarations</a>, remove that <span id="ref-for-css-declaration②⑥">CSS declaration</span> and let <var>removed</var> be true. 
    <li>If <var>removed</var> is true, <a data-link-type="dfn" href="#update-style-attribute-for" id="ref-for-update-style-attribute-for②">Update style attribute for</a> the <a data-link-type="dfn" href="#css-declaration-block" id="ref-for-css-declaration-block①⓪">CSS declaration block</a>. 
    <li>Return <var>value</var>. 
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleDeclaration" data-dfn-type="attribute" data-export id="dom-cssstyledeclaration-parentrule"><code>parentRule</code></dfn> attribute must return the <a data-link-type="dfn" href="#cssstyledeclaration-parent-css-rule" id="ref-for-cssstyledeclaration-parent-css-rule③">parent CSS rule</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleDeclaration" data-dfn-type="attribute" data-export id="dom-cssstyledeclaration-cssfloat"><code>cssFloat</code></dfn> attribute, on getting, must return the result of invoking <code class="idl"><a data-link-type="idl" href="#dom-cssstyledeclaration-getpropertyvalue" id="ref-for-dom-cssstyledeclaration-getpropertyvalue②">getPropertyValue()</a></code> with <code>float</code> as argument. On setting, the attribute must invoke <code class="idl"><a data-link-type="idl" href="#dom-cssstyledeclaration-setproperty" id="ref-for-dom-cssstyledeclaration-setproperty①">setProperty()</a></code> with <code>float</code> as first argument, as second argument the given value, and no third argument.
Any exceptions thrown must be re-thrown.</p>
   <p>For each CSS property <var>property</var> that is a <a data-link-type="dfn" href="#supported-css-property" id="ref-for-supported-css-property②">supported CSS property</a>,
the following partial interface applies where <var>camel-cased attribute</var> is obtained by running the <a data-link-type="dfn" href="#css-property-to-idl-attribute" id="ref-for-css-property-to-idl-attribute">CSS property to IDL attribute</a> algorithm for <var>property</var>.</p>
<pre class="idl extract highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="#cssstyledeclaration" id="ref-for-cssstyledeclaration④"><c- g>CSSStyleDeclaration</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://html.spec.whatwg.org/multipage/custom-elements.html#cereactions" id="ref-for-cereactions④"><c- g>CEReactions</c-></a>] <c- b>attribute</c-> [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#TreatNullAs" id="ref-for-TreatNullAs④"><c- g>TreatNullAs</c-></a>=<a class="n" data-link-type="idl-name"><c- n>EmptyString</c-></a>] <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring②⑤"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleDeclaration" data-dfn-type="attribute" data-export data-lt="camel_cased_attribute" data-type="[TreatNullAs=EmptyString] CSSOMString" id="dom-cssstyledeclaration-camel_cased_attribute"><code><c- g>_camel_cased_attribute</c-></code><a class="self-link" href="#dom-cssstyledeclaration-camel_cased_attribute"></a></dfn>;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleDeclaration" data-dfn-type="attribute" data-export id="dom-cssstyledeclaration-camel-cased-attribute"><code><var>camel-cased attribute</var></code></dfn> attribute, on getting, must return the
result of invoking <code class="idl"><a data-link-type="idl" href="#dom-cssstyledeclaration-getpropertyvalue" id="ref-for-dom-cssstyledeclaration-getpropertyvalue③">getPropertyValue()</a></code> with the
argument being the result of running the <a data-link-type="dfn" href="#idl-attribute-to-css-property" id="ref-for-idl-attribute-to-css-property">IDL attribute to CSS property</a> algorithm for <var>camel-cased attribute</var>.</p>
   <p>Setting the <a class="idl-code" data-link-type="attribute" href="#dom-cssstyledeclaration-camel-cased-attribute" id="ref-for-dom-cssstyledeclaration-camel-cased-attribute"><var>camel-cased attribute</var></a> attribute must invoke <code class="idl"><a data-link-type="idl" href="#dom-cssstyledeclaration-setproperty" id="ref-for-dom-cssstyledeclaration-setproperty②">setProperty()</a></code> with the
first argument being the result of running the <a data-link-type="dfn" href="#idl-attribute-to-css-property" id="ref-for-idl-attribute-to-css-property①">IDL attribute to CSS property</a> algorithm for <var>camel-cased attribute</var>, as second argument the given value, and no third argument. Any
exceptions thrown must be re-thrown.</p>
   <div class="example" id="example-5f92c57f"><a class="self-link" href="#example-5f92c57f"></a>For example, for the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-fonts-3/#propdef-font-size" id="ref-for-propdef-font-size">font-size</a> property there would be a <code>fontSize</code> IDL attribute.</div>
   <p>For each CSS property <var>property</var> that is a <a data-link-type="dfn" href="#supported-css-property" id="ref-for-supported-css-property③">supported CSS property</a> and that begins
with the string <code>-webkit-</code>, the following partial interface applies where <var>webkit-cased attribute</var> is obtained by running the <a data-link-type="dfn" href="#css-property-to-idl-attribute" id="ref-for-css-property-to-idl-attribute①">CSS property to IDL attribute</a> algorithm for <var>property</var>, with the <i>lowercase first</i> flag set.</p>
<pre class="idl extract highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="#cssstyledeclaration" id="ref-for-cssstyledeclaration⑤"><c- g>CSSStyleDeclaration</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://html.spec.whatwg.org/multipage/custom-elements.html#cereactions" id="ref-for-cereactions⑤"><c- g>CEReactions</c-></a>] <c- b>attribute</c-> [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#TreatNullAs" id="ref-for-TreatNullAs⑤"><c- g>TreatNullAs</c-></a>=<a class="n" data-link-type="idl-name"><c- n>EmptyString</c-></a>] <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring②⑥"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleDeclaration" data-dfn-type="attribute" data-export data-lt="webkit_cased_attribute" data-type="[TreatNullAs=EmptyString] CSSOMString" id="dom-cssstyledeclaration-webkit_cased_attribute"><code><c- g>_webkit_cased_attribute</c-></code><a class="self-link" href="#dom-cssstyledeclaration-webkit_cased_attribute"></a></dfn>;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleDeclaration" data-dfn-type="attribute" data-export id="dom-cssstyledeclaration-webkit-cased-attribute"><code><var>webkit-cased attribute</var></code></dfn> attribute, on
getting, must return the result of invoking <code class="idl"><a data-link-type="idl" href="#dom-cssstyledeclaration-getpropertyvalue" id="ref-for-dom-cssstyledeclaration-getpropertyvalue④">getPropertyValue()</a></code> with the
argument being the result of running the <a data-link-type="dfn" href="#idl-attribute-to-css-property" id="ref-for-idl-attribute-to-css-property②">IDL attribute to CSS property</a> algorithm for <var>webkit-cased attribute</var>, with the <i>dash prefix</i> flag set.</p>
   <p>Setting the <a class="idl-code" data-link-type="attribute" href="#dom-cssstyledeclaration-webkit-cased-attribute" id="ref-for-dom-cssstyledeclaration-webkit-cased-attribute"><var>webkit-cased attribute</var></a> attribute must invoke <code class="idl"><a data-link-type="idl" href="#dom-cssstyledeclaration-setproperty" id="ref-for-dom-cssstyledeclaration-setproperty③">setProperty()</a></code> with the first argument being the result
of running the <a data-link-type="dfn" href="#idl-attribute-to-css-property" id="ref-for-idl-attribute-to-css-property③">IDL attribute to CSS property</a> algorithm for <var>webkit-cased attribute</var>,
with the <i>dash prefix</i> flag set, as second argument the given value, and no third argument.
Any exceptions thrown must be re-thrown.</p>
   <div class="example" id="example-9b35d744"><a class="self-link" href="#example-9b35d744"></a>For example, if the user agent supports the <a class="property" data-link-type="propdesc">-webkit-transform</a> property, there
would be a <code>webkitTransform</code> IDL attribute. There would also be a <code>WebkitTransform</code> IDL attribute because of the rules for camel-cased attributes.</div>
   <p>For each CSS property <var>property</var> that is a <a data-link-type="dfn" href="#supported-css-property" id="ref-for-supported-css-property④">supported CSS property</a>,
except for properties that have no "<code>-</code>" (U+002D) in the property name,
the following partial interface applies where <var>dashed attribute</var> is <var>property</var>.</p>
<pre class="idl extract highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="#cssstyledeclaration" id="ref-for-cssstyledeclaration⑥"><c- g>CSSStyleDeclaration</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://html.spec.whatwg.org/multipage/custom-elements.html#cereactions" id="ref-for-cereactions⑥"><c- g>CEReactions</c-></a>] <c- b>attribute</c-> [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#TreatNullAs" id="ref-for-TreatNullAs⑥"><c- g>TreatNullAs</c-></a>=<a class="n" data-link-type="idl-name"><c- n>EmptyString</c-></a>] <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring②⑦"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSSStyleDeclaration" data-dfn-type="attribute" data-export data-lt="dashed_attribute" data-type="[TreatNullAs=EmptyString] CSSOMString" id="dom-cssstyledeclaration-dashed_attribute"><code><c- g>_dashed_attribute</c-></code><a class="self-link" href="#dom-cssstyledeclaration-dashed_attribute"></a></dfn>;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSSStyleDeclaration" data-dfn-type="attribute" data-export id="dom-cssstyledeclaration-dashed-attribute"><code><var>dashed attribute</var></code></dfn> attribute, on getting, must return the
result of invoking <code class="idl"><a data-link-type="idl" href="#dom-cssstyledeclaration-getpropertyvalue" id="ref-for-dom-cssstyledeclaration-getpropertyvalue⑤">getPropertyValue()</a></code> with the
argument being <var>dashed attribute</var>.</p>
   <p>Setting the <a class="idl-code" data-link-type="attribute" href="#dom-cssstyledeclaration-dashed-attribute" id="ref-for-dom-cssstyledeclaration-dashed-attribute"><var>dashed attribute</var></a> attribute must invoke <code class="idl"><a data-link-type="idl" href="#dom-cssstyledeclaration-setproperty" id="ref-for-dom-cssstyledeclaration-setproperty④">setProperty()</a></code> with the
first argument being <var>dashed attribute</var>, as second argument the given value, and no third argument. Any
exceptions thrown must be re-thrown.</p>
   <div class="example" id="example-5db10c4f">
    <a class="self-link" href="#example-5db10c4f"></a> For example, for the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-fonts-3/#propdef-font-size" id="ref-for-propdef-font-size①">font-size</a> property there would be a <code>font-size</code> IDL attribute. In JavaScript, the property can be accessed as
 follows, assuming <var>element</var> is an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#html-elements" id="ref-for-html-elements">HTML element</a>: 
<pre><var>element</var>.style['font-size'];</pre>
   </div>
   <p>The <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="css-property-to-idl-attribute">CSS property to IDL attribute</dfn> algorithm for <var>property</var>, optionally with a <i>lowercase first</i> flag set, is as follows:</p>
   <ol>
    <li>Let <var>output</var> be the empty string. 
    <li>Let <var>uppercase next</var> be unset. 
    <li>If the <i>lowercase first</i> flag is set, remove the first character from <var>property</var>. 
    <li>
     For each character <var>c</var> in <var>property</var>: 
     <ol>
      <li>If <var>c</var> is "<code>-</code>" (U+002D), let <var>uppercase next</var> be set. 
      <li>Otherwise, if <var>uppercase next</var> is set, let <var>uppercase next</var> be unset and append <var>c</var> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-uppercase" id="ref-for-ascii-uppercase">converted to ASCII uppercase</a> to <var>output</var>. 
      <li>Otherwise, append <var>c</var> to <var>output</var>. 
     </ol>
    <li>Return <var>output</var>. 
   </ol>
   <p>The <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="idl-attribute-to-css-property">IDL attribute to CSS property</dfn> algorithm for <var>attribute</var>, optionally with a <i>dash prefix</i> flag set, is as follows:</p>
   <ol>
    <li>Let <var>output</var> be the empty string. 
    <li>If the <i>dash prefix</i> flag is set, append "<code>-</code>" (U+002D) to <var>output</var>. 
    <li>
     For each character <var>c</var> in <var>attribute</var>: 
     <ol>
      <li>If <var>c</var> is in the range U+0041 to U+005A (ASCII uppercase), append "<code>-</code>" (U+002D) followed by <var>c</var> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-lowercase" id="ref-for-ascii-lowercase⑥">converted to ASCII lowercase</a> to <var>output</var>. 
      <li>Otherwise, append <var>c</var> to <var>output</var>. 
     </ol>
    <li>Return <var>output</var>. 
   </ol>
   <h3 class="heading settled" data-level="6.7" id="css-values"><span class="secno">6.7. </span><span class="content">CSS Values</span><a class="self-link" href="#css-values"></a></h3>
   <h4 class="heading settled" data-level="6.7.1" id="parsing-css-values"><span class="secno">6.7.1. </span><span class="content">Parsing CSS Values</span><a class="self-link" href="#parsing-css-values"></a></h4>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="parse-a-css-value">parse a CSS value</dfn> <var>value</var> for a given <var>property</var> means to follow these steps:</p>
   <ol>
    <li>Let <var>list</var> be the value returned by invoking <a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#parse-a-list-of-component-values" id="ref-for-parse-a-list-of-component-values">parse a list of component values</a> from <var>value</var>. 
    <li>Match <var>list</var> against the grammar for the property <var>property</var> in the CSS specification. 
    <li>If the above step failed, return null. 
    <li>Return <var>list</var>. 
   </ol>
   <p class="note" role="note"><span>Note:</span> "<code>!important</code>" declarations are not
part of the property value space and will therefore cause <a data-link-type="dfn" href="#parse-a-css-value" id="ref-for-parse-a-css-value①">parse a CSS value</a> to return null.</p>
   <h4 class="heading settled" data-level="6.7.2" id="serializing-css-values"><span class="secno">6.7.2. </span><span class="content">Serializing CSS Values</span><a class="self-link" href="#serializing-css-values"></a></h4>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-a-css-value">serialize a CSS value</dfn> of a <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration②⑦">CSS declaration</a> <var>declaration</var> or a list of longhand <span id="ref-for-css-declaration②⑧">CSS declarations</span> <var>list</var>,
follow these rules:</p>
   <ol>
    <li data-md>
     <p>If this algorithm is invoked with a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list" id="ref-for-list">list</a> <var>list</var>:</p>
     <ol>
      <li data-md>
       <p>Let <var>shorthand</var> be the first shorthand property,
in <a data-link-type="dfn" href="#concept-shorthands-preferred-order" id="ref-for-concept-shorthands-preferred-order①">preferred order</a>,
that exactly maps to all of the longhand properties in <var>list</var>.</p>
      <li data-md>
       <p>If there is no such shorthand or <var>shorthand</var> cannot exactly represent the values of all the properties in <var>list</var>,
return the empty string.</p>
      <li data-md>
       <p>Otherwise, <a data-link-type="dfn" href="#serialize-a-css-value" id="ref-for-serialize-a-css-value④">serialize a CSS value</a> from a hypothetical declaration of the property <var>shorthand</var> with its value representing the combined values of the declarations in <var>list</var>.</p>
     </ol>
    <li data-md>
     <p>Represent the value of the <var>declaration</var> as a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list" id="ref-for-list①">list</a> of CSS component values <var>components</var> that, when <a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar" id="ref-for-css-parse-something-according-to-a-css-grammar">parsed</a> according to the property’s grammar,
would represent that value.
Additionally:</p>
     <ul>
      <li data-md>
       <p>If certain component values can appear in any order
without changing the meaning of the value
(a pattern typically represented by a double bar <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-any" id="ref-for-comb-any">||</a> in the value syntax),
reorder the component values to use the canonical order of component values
as given in the property definition table.</p>
      <li data-md>
       <p>If component values can be omitted or replaced with a shorter representation
without changing the meaning of the value,
omit/replace them.</p>
      <li data-md>
       <p>If either of the above syntactic translations would be less backwards-compatible,
do not perform them.</p>
     </ul>
     <p class="note" role="note"><span>Note:</span> The rules described here outlines the <em>general principles</em> of serialization.
For legacy reasons, some properties serialize in a different manner,
which is intentionally undefined here due to lack of resources.
Please consult your local reverse-engineer for details.</p>
    <li data-md>
     <p>Remove any <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-syntax-3/#typedef-whitespace-token" id="ref-for-typedef-whitespace-token">&lt;whitespace-token></a>s from <var>components</var>.</p>
    <li data-md>
     <p>Replace each component value in <var>components</var> with the result of invoking <a data-link-type="dfn" href="#serialize-a-css-component-value" id="ref-for-serialize-a-css-component-value">serialize a CSS component value</a>.</p>
    <li data-md>
     <p>Join the items of <var>components</var> into a single string,
inserting " " (U+0020 SPACE) between each pair of items
unless the second item is a "," (U+002C COMMA)
Return the result.</p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="serialize-a-css-component-value">serialize a CSS component value</dfn> depends on the component, as follows:</p>
   <dl class="switch">
    <dt>keyword 
    <dd>The keyword <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ascii-lowercase" id="ref-for-ascii-lowercase⑦">converted to ASCII lowercase</a>. 
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#angle-value" id="ref-for-angle-value" title="Expands to: deg | grad | rad | turn">&lt;angle></a> 
    <dd>
      The &lt;number> component serialized as per &lt;number> followed by the unit in canonical form as defined in its respective specification. 
     <p class="issue" id="issue-5f483407"><a class="self-link" href="#issue-5f483407"></a> Probably should distinguish between specified and computed / resolved values.</p>
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-color-3/#valuea-def-color" id="ref-for-valuea-def-color" title="Expands to: aliceblue | antiquewhite | aqua | aquamarine | azure | beige | bisque | black | blanchedalmond | blue | blueviolet | brown | burlywood | cadetblue | chartreuse | chocolate | coral | cornflowerblue | cornsilk | crimson | currentcolor | cyan | darkblue | darkcyan | darkgoldenrod | darkgray | darkgreen | darkgrey | darkkhaki | darkmagenta | darkolivegreen | darkorange | darkorchid | darkred | darksalmon | darkseagreen | darkslateblue | darkslategray | darkslategrey | darkturquoise | darkviolet | deeppink | deepskyblue | dimgray | dimgrey | dodgerblue | firebrick | floralwhite | forestgreen | fuchsia | gainsboro | ghostwhite | gold | goldenrod | gray | green | greenyellow | grey | honeydew | hotpink | indianred | indigo | ivory | khaki | lavender | lavenderblush | lawngreen | lemonchiffon | lightblue | lightcoral | lightcyan | lightgoldenrodyellow | lightgray | lightgreen | lightgrey | lightpink | lightsalmon | lightseagreen | lightskyblue | lightslategray | lightslategrey | lightsteelblue | lightyellow | lime | limegreen | linen | magenta | maroon | mediumaquamarine | mediumblue | mediumorchid | mediumpurple | mediumseagreen | mediumslateblue | mediumspringgreen | mediumturquoise | mediumvioletred | midnightblue | mintcream | mistyrose | moccasin | navajowhite | navy | oldlace | olive | olivedrab | orange | orangered | orchid | palegoldenrod | palegreen | paleturquoise | palevioletred | papayawhip | peachpuff | peru | pink | plum | powderblue | purple | rebeccapurple | red | rosybrown | royalblue | saddlebrown | salmon | sandybrown | seagreen | seashell | sienna | silver | skyblue | slateblue | slategray | slategrey | snow | springgreen | steelblue | tan | teal | thistle | tomato | transparent | turquoise | violet | wheat | white | whitesmoke | yellow | yellowgreen">&lt;color></a> 
    <dd>
      If &lt;color> is a component of a resolved or computed value, then
 return the color using the <code>rgb()</code> or <code>rgba()</code> functional
 notation as follows: 
     <ol>
      <li>If the alpha component of the color is equal to one, then return the serialization of the <code>rgb()</code> functional equivalent of the opaque color. 
      <li>If the alpha component of the color is not equal to one, then return the serialization of the <code>rgba()</code> functional equivalent of the non-opaque color. 
     </ol>
      The serialization of the <code>rgb()</code> functional equivalent is the concatenation of the following: 
     <ol>
      <li>The string "<code>rgb(</code>". 
      <li>The shortest base-ten integer serialization of the color’s red component. 
      <li>The string "<code>, </code>". 
      <li>The shortest base-ten serialization of the color’s green component. 
      <li>The string "<code>, </code>". 
      <li>The shortest base-ten serialization of the color’s blue component. 
      <li>The string "<code>)</code>". 
     </ol>
      The serialization of the <code>rgba()</code> functional equivalent is the concatenation of the following: 
     <ol>
      <li>The string "<code>rgba(</code>". 
      <li>The shortest base-ten serialization of the color’s red component. 
      <li>The string "<code>, </code>". 
      <li>The shortest base-ten serialization of the color’s green component. 
      <li>The string "<code>, </code>". 
      <li>The shortest base-ten serialization of the color’s blue component. 
      <li>The string "<code>, </code>". 
      <li>The serialization of the color’s alpha component as an &lt;alphavalue>. 
      <li>The string "<code>)</code>". 
     </ol>
     <p>In the above rules, the string "<code>, </code>" denotes a COMMA (U+002C) followed by a single SPACE (U+0020).</p>
     <p>If <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-color-3/#valuea-def-color" id="ref-for-valuea-def-color①" title="Expands to: aliceblue | antiquewhite | aqua | aquamarine | azure | beige | bisque | black | blanchedalmond | blue | blueviolet | brown | burlywood | cadetblue | chartreuse | chocolate | coral | cornflowerblue | cornsilk | crimson | currentcolor | cyan | darkblue | darkcyan | darkgoldenrod | darkgray | darkgreen | darkgrey | darkkhaki | darkmagenta | darkolivegreen | darkorange | darkorchid | darkred | darksalmon | darkseagreen | darkslateblue | darkslategray | darkslategrey | darkturquoise | darkviolet | deeppink | deepskyblue | dimgray | dimgrey | dodgerblue | firebrick | floralwhite | forestgreen | fuchsia | gainsboro | ghostwhite | gold | goldenrod | gray | green | greenyellow | grey | honeydew | hotpink | indianred | indigo | ivory | khaki | lavender | lavenderblush | lawngreen | lemonchiffon | lightblue | lightcoral | lightcyan | lightgoldenrodyellow | lightgray | lightgreen | lightgrey | lightpink | lightsalmon | lightseagreen | lightskyblue | lightslategray | lightslategrey | lightsteelblue | lightyellow | lime | limegreen | linen | magenta | maroon | mediumaquamarine | mediumblue | mediumorchid | mediumpurple | mediumseagreen | mediumslateblue | mediumspringgreen | mediumturquoise | mediumvioletred | midnightblue | mintcream | mistyrose | moccasin | navajowhite | navy | oldlace | olive | olivedrab | orange | orangered | orchid | palegoldenrod | palegreen | paleturquoise | palevioletred | papayawhip | peachpuff | peru | pink | plum | powderblue | purple | rebeccapurple | red | rosybrown | royalblue | saddlebrown | salmon | sandybrown | seagreen | seashell | sienna | silver | skyblue | slateblue | slategray | slategrey | snow | springgreen | steelblue | tan | teal | thistle | tomato | transparent | turquoise | violet | wheat | white | whitesmoke | yellow | yellowgreen">&lt;color></a> is a component of a specified value, then
 return the color as follows:</p>
     <ol>
      <li>If the color was explicitly specified by the author, then return the original, author specified color value. 
      <li>Otherwise, return the value that would be returned if the color were a component of a computed value. 
     </ol>
     <p class="issue" id="issue-b55f28a2"><a class="self-link" href="#issue-b55f28a2"></a> Should author specified values be normalized for case? Or should original case be preserved?</p>
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-color-3/#alphavalue-def" id="ref-for-alphavalue-def">&lt;alphavalue></a> 
    <dd>
      If the value is internally represented as an integer between 0 and 255 inclusive (i.e. 8-bit unsigned integer),
  follow these steps: 
     <ol>
      <li>Let <var>alpha</var> be the given integer. 
      <li>If there exists an integer between 0 and 100 inclusive that,
   when multiplied with 2.55 and rounded to the closest integer (rounding up if two values are equally close), equals <var>alpha</var>,
   let <var>rounded</var> be that integer divided by 100. 
      <li>Otherwise, let <var>rounded</var> be <var>alpha</var> divided by 0.255 and rounded to the closest integer (rounding up if two values are equally close),
   divided by 1000. 
      <li>Return the result of serializing <var>rounded</var> as a &lt;number>. 
     </ol>
     <p>Otherwise, return the result of serializing the given value as a &lt;number>.</p>
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-lists-3/#typedef-counter" id="ref-for-typedef-counter">&lt;counter></a> 
    <dd>
      The return value of the following algorithm: 
     <ol>
      <li>Let <var>s</var> be the empty string. 
      <li>If &lt;counter> has three CSS component values append the string
   "<code>counters(</code>" to <var>s</var>. 
      <li>If &lt;counter> has two CSS component values append the string
   "<code>counter(</code>" to <var>s</var>. 
      <li>Let <var>list</var> be a list of CSS component values belonging to &lt;counter>, omitting the last CSS component value if it is "decimal". 
      <li>Let each item in <var>list</var> be the result of invoking <a data-link-type="dfn" href="#serialize-a-css-component-value" id="ref-for-serialize-a-css-component-value①">serialize a CSS component value</a> on that item. 
      <li>Append the result of invoking <a data-link-type="dfn" href="#serialize-a-comma-separated-list" id="ref-for-serialize-a-comma-separated-list④">serialize a comma-separated list</a> on <var>list</var> to <var>s</var>. 
      <li>Append "<code>)</code>" (U+0029) to <var>s</var>. 
      <li>Return <var>s</var>. 
     </ol>
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-4/#frequency-value" id="ref-for-frequency-value" title="Expands to: hz | khz">&lt;frequency></a> 
    <dd>
      The &lt;number> component serialized as per &lt;number> followed by the unit in its canonical form as defined in its respective specification. 
     <p class="issue" id="issue-5f483407①"><a class="self-link" href="#issue-5f483407①"></a> Probably should distinguish between specified and computed / resolved values.</p>
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css2/syndata.html#value-def-identifier" id="ref-for-value-def-identifier">&lt;identifier></a> 
    <dd>The identifier <a data-link-type="dfn" href="#serialize-an-identifier" id="ref-for-serialize-an-identifier⑧">serialized as an identifier</a>. 
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#integer-value" id="ref-for-integer-value">&lt;integer></a> 
    <dd>A base-ten integer using digits 0-9 (U+0030 to U+0039) in the
 shortest form possible, preceded by "<code>-</code>" (U+002D) if it is
 negative. 
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#length-value" id="ref-for-length-value" title="Expands to: advance measure | cap | ch | cm | em | ex | ic | in | lh | mm | pc | pt | px | q | rem | rlh | vb | vh | vi | vmax | vmin | vw">&lt;length></a> 
    <dd>
      The &lt;number> component serialized as per &lt;number> followed by the unit in its canonical form as defined in its respective specification. 
     <p class="issue" id="issue-5f483407②"><a class="self-link" href="#issue-5f483407②"></a> Probably should distinguish between specified and computed / resolved values.</p>
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#number-value" id="ref-for-number-value">&lt;number></a> 
    <dd>
      A base-ten number using digits 0-9 (U+0030 to U+0039) in the shortest form possible,
  using "<code>.</code>" to separate decimals (if any),
  rounding the value if necessary to not produce more than 6 decimals,
  preceded by "<code>-</code>" (U+002D) if it is negative. 
     <p class="note" role="note"><span>Note:</span> scientific notation is not used.</p>
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#percentage-value" id="ref-for-percentage-value">&lt;percentage></a> 
    <dd>The &lt;number> component serialized as per &lt;number> followed
 by the literal string "<code>%</code>" (U+0025). 
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#resolution-value" id="ref-for-resolution-value" title="Expands to: dpcm | dpi | dppx | x">&lt;resolution></a> 
    <dd>The resolution in dots per <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px">CSS pixel</a> serialized as per
 &lt;number> followed by the literal string "<code>dppx</code>". 
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/mediaqueries-4/#typedef-ratio" id="ref-for-typedef-ratio">&lt;ratio></a> 
    <dd>The numerator serialized as per &lt;number>
     followed by the literal string "<code> / </code>",
     followed by the denominator serialized as per &lt;number>. 
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css2/visufx.html#value-def-shape" id="ref-for-value-def-shape">&lt;shape></a> 
    <dd>
      The return value of the following algorithm: 
     <ol>
      <li>Let <var>s</var> be the string "<code>rect(</code>". 
      <li>Let <var>list</var> be a list of the CSS component values belonging to &lt;shape>. 
      <li>Let each item in <var>list</var> be the result of invoking <a data-link-type="dfn" href="#serialize-a-css-component-value" id="ref-for-serialize-a-css-component-value②">serialize a CSS component value</a> of that item. 
      <li>Append the result of invoking <a data-link-type="dfn" href="#serialize-a-comma-separated-list" id="ref-for-serialize-a-comma-separated-list⑤">serialize a comma-separated list</a> on <var>list</var> to <var>s</var>. 
      <li>Append "<code>)</code>" (U+0029) to <var>s</var>. 
      <li>Return <var>s</var>. 
     </ol>
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#string-value" id="ref-for-string-value">&lt;string></a> 
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-fonts-4/#family-name-value" id="ref-for-family-name-value">&lt;family-name></a> 
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css2/aural.html#value-def-specific-voice" id="ref-for-value-def-specific-voice">&lt;specific-voice></a> 
    <dd>The string <a data-link-type="dfn" href="#serialize-a-string" id="ref-for-serialize-a-string⑤">serialized as a string</a>. 
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-4/#time-value" id="ref-for-time-value" title="Expands to: ms | s">&lt;time></a> 
    <dd>The time in seconds serialized as per &lt;number> followed by
 the literal string "<code>s</code>". 
    <dt><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#url-value" id="ref-for-url-value">&lt;url></a> 
    <dd>
     The <a data-link-type="dfn" href="https://url.spec.whatwg.org/#absolute-url-string" id="ref-for-absolute-url-string①">absolute-URL string</a> <a data-link-type="dfn" href="#serialize-a-url" id="ref-for-serialize-a-url③">serialized as URL</a>. 
     <p class="issue" id="issue-1e63f5cb"><a class="self-link" href="#issue-1e63f5cb"></a> This should differentiate specified and computed <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#url-value" id="ref-for-url-value①">&lt;url></a> values, see <a href="https://github.com/w3c/csswg-drafts/issues/3195">#3195</a>.</p>
   </dl>
   <p>&lt;absolute-size>,
 &lt;border-width>,
 &lt;border-style>,
 &lt;bottom>,
 &lt;generic-family>,
 &lt;generic-voice>,
 &lt;left>,
 &lt;margin-width>,
 &lt;padding-width>,
 &lt;relative-size>,
 &lt;right>, and
 &lt;top>,
 are considered macros by this specification. They all represent instances
 of components outlined above.</p>
   <p class="issue" id="issue-08e9ac89"><a class="self-link" href="#issue-08e9ac89"></a> One idea is that we can remove this section somewhere in
the CSS3/CSS4 timeline by moving the above definitions to the drafts that
define the CSS components.</p>
   <h5 class="heading settled" data-level="6.7.2.1" id="serializing-css-values-examples"><span class="secno">6.7.2.1. </span><span class="content">Examples</span><a class="self-link" href="#serializing-css-values-examples"></a></h5>
   <p>Here are some examples of before and after results on specified values.
The before column could be what the author wrote in a style sheet, while
the after column shows what querying the DOM would return.</p>
   <div class="example" id="example-9eae7eae">
    <a class="self-link" href="#example-9eae7eae"></a> 
    <table class="complex data">
     <thead>
      <tr>
       <th>Before
       <th>After 
     <tbody>
      <tr>
       <td><code>background: none</code>
       <td><code>background: rgba(0, 0, 0, 0)</code> 
      <tr>
       <td><code>outline: none</code>
       <td><code>outline: invert</code> 
      <tr>
       <td><code>border: none</code>
       <td><code>border: medium</code> 
      <tr>
       <td><code>list-style: none</code>
       <td><code>list-style: disc</code> 
      <tr>
       <td><code>margin: 0 1px 1px 1px</code>
       <td><code>margin: 0px 1px 1px</code> 
      <tr>
       <td><code>azimuth: behind left</code>
       <td><code>azimuth: 220deg</code> 
      <tr>
       <td><code>font-family: a, 'b"', serif</code>
       <td><code>font-family: "a", "b\"", serif</code> 
      <tr>
       <td><code>content: url('h)i') '\[\]'</code>
       <td><code>content: url("h)i") "[]"</code> 
      <tr>
       <td><code>azimuth: leftwards</code>
       <td><code>azimuth: leftwards</code> 
      <tr>
       <td><code>color: rgb(18, 52, 86)</code>
       <td><code>color: #123456</code> 
      <tr>
       <td><code>color: rgba(000001, 0, 0, 1)</code>
       <td><code>color: #000000</code> 
    </table>
    <p class="issue" id="issue-3a42ec46"><a class="self-link" href="#issue-3a42ec46"></a> Some of these need to be updated per the new rules.</p>
   </div>
   <h2 class="heading settled" data-level="7" id="dom-access-to-css-declaration-blocks"><span class="secno">7. </span><span class="content">DOM Access to CSS Declaration Blocks</span><a class="self-link" href="#dom-access-to-css-declaration-blocks"></a></h2>
   <h3 class="heading settled" data-level="7.1" id="the-elementcssinlinestyle-mixin"><span class="secno">7.1. </span><span class="content"> The <code class="idl"><a data-link-type="idl" href="#elementcssinlinestyle" id="ref-for-elementcssinlinestyle">ElementCSSInlineStyle</a></code> Mixin</span><span id="the-elementcssinlinestyle-interface"></span><a class="self-link" href="#the-elementcssinlinestyle-mixin"></a></h3>
   <p>The <code>ElementCSSInlineStyle</code> mixin provides access to inline style properties of an element.</p>
<pre class="idl highlight def"><c- b>interface</c-> <c- b>mixin</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="elementcssinlinestyle"><code><c- g>ElementCSSInlineStyle</c-></code></dfn> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject①⓪"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#PutForwards" id="ref-for-PutForwards⑤"><c- g>PutForwards</c-></a>=<a class="idl-code" data-link-type="attribute" href="#dom-cssstyledeclaration-csstext" id="ref-for-dom-cssstyledeclaration-csstext⑤"><c- n>cssText</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssstyledeclaration" id="ref-for-cssstyledeclaration⑦"><c- n>CSSStyleDeclaration</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleDeclaration" href="#dom-elementcssinlinestyle-style" id="ref-for-dom-elementcssinlinestyle-style"><c- g>style</c-></a>;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="ElementCSSInlineStyle" data-dfn-type="attribute" data-export id="dom-elementcssinlinestyle-style"><code>style</code></dfn> attribute must return a <a data-link-type="dfn" href="#css-declaration-block" id="ref-for-css-declaration-block①①">CSS declaration block</a> object whose <a data-link-type="dfn" href="#cssstyledeclaration-computed-flag" id="ref-for-cssstyledeclaration-computed-flag①⓪">computed flag</a> is unset, whose <a data-link-type="dfn" href="#cssstyledeclaration-parent-css-rule" id="ref-for-cssstyledeclaration-parent-css-rule④">parent CSS rule</a> is null, and
whose <a data-link-type="dfn" href="#cssstyledeclaration-owner-node" id="ref-for-cssstyledeclaration-owner-node⑦">owner node</a> is the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object③">context object</a>.</p>
   <p>If the user agent supports HTML, the following IDL applies: <a data-link-type="biblio" href="#biblio-html">[HTML]</a></p>
<pre class="idl highlight def"><a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/dom.html#htmlelement" id="ref-for-htmlelement"><c- n>HTMLElement</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#elementcssinlinestyle" id="ref-for-elementcssinlinestyle①"><c- n>ElementCSSInlineStyle</c-></a>;
</pre>
   <p>If the user agent supports SVG, the following IDL applies: <a data-link-type="biblio" href="#biblio-svg11">[SVG11]</a></p>
<pre class="idl highlight def"><a class="n" data-link-type="idl-name" href="https://svgwg.org/svg2-draft/types.html#InterfaceSVGElement" id="ref-for-InterfaceSVGElement"><c- n>SVGElement</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#elementcssinlinestyle" id="ref-for-elementcssinlinestyle②"><c- n>ElementCSSInlineStyle</c-></a>;
</pre>
   <h3 class="heading settled" data-level="7.2" id="extensions-to-the-window-interface"><span class="secno">7.2. </span><span class="content">Extensions to the <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window">Window</a></code> Interface</span><a class="self-link" href="#extensions-to-the-window-interface"></a></h3>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window①"><c- g>Window</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject"><c- g>NewObject</c-></a>] <a class="n" data-link-type="idl-name" href="#cssstyledeclaration" id="ref-for-cssstyledeclaration⑧"><c- n>CSSStyleDeclaration</c-></a> <a class="idl-code" data-link-type="method" href="#dom-window-getcomputedstyle" id="ref-for-dom-window-getcomputedstyle"><c- g>getComputedStyle</c-></a>(<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element" id="ref-for-element③"><c- n>Element</c-></a> <dfn class="idl-code" data-dfn-for="Window/getComputedStyle(elt, pseudoElt), Window/getComputedStyle(elt)" data-dfn-type="argument" data-export id="dom-window-getcomputedstyle-elt-pseudoelt-elt"><code><c- g>elt</c-></code><a class="self-link" href="#dom-window-getcomputedstyle-elt-pseudoelt-elt"></a></dfn>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring②⑧"><c- n>CSSOMString</c-></a>? <dfn class="idl-code" data-dfn-for="Window/getComputedStyle(elt, pseudoElt), Window/getComputedStyle(elt)" data-dfn-type="argument" data-export id="dom-window-getcomputedstyle-elt-pseudoelt-pseudoelt"><code><c- g>pseudoElt</c-></code><a class="self-link" href="#dom-window-getcomputedstyle-elt-pseudoelt-pseudoelt"></a></dfn>);
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="method" data-export data-lt="getComputedStyle(elt, pseudoElt)|getComputedStyle(elt)" id="dom-window-getcomputedstyle"><code>getComputedStyle(<var>elt</var>, <var>pseudoElt</var>)</code></dfn> method must run these
steps:</p>
   <ol>
    <li>Let <var>doc</var> be <var>elt</var>’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document①">node document</a>. 
    <li>Let <var>obj</var> be <var>elt</var>. 
    <li>
     If <var>pseudoElt</var> is provided, and it’s not the empty string, then: 
     <ol>
      <li><a data-link-type="dfn" href="https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar" id="ref-for-css-parse-something-according-to-a-css-grammar①">Parse</a> <var>pseudoElt</var> as a <a class="production css" data-link-type="type" href="https://drafts.csswg.org/selectors-4/#typedef-pseudo-element-selector" id="ref-for-typedef-pseudo-element-selector">&lt;pseudo-element-selector></a>, and let <var>type</var> be the result. 
      <li>If <var>type</var> is failure, or is an <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-scoping-1/#selectordef-slotted" id="ref-for-selectordef-slotted">::slotted()</a> or <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-shadow-parts-1/#selectordef-part" id="ref-for-selectordef-part">::part()</a> pseudo-element, <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-throw" id="ref-for-dfn-throw①③">throw</a> a <code class="idl"><a data-link-type="idl" href="https://heycam.github.io/webidl/#exceptiondef-typeerror" id="ref-for-exceptiondef-typeerror">TypeError</a></code> exception. 
      <li>Otherwise let <var>obj</var> be the given pseudo-element of <var>elt</var>. 
     </ol>
     <p class="note" role="note"><span>Note:</span> CSS2 pseudo-elements should match both the double and single-colon
  versions. That is, both <code>:before</code> and <code>::before</code> should
  match above.</p>
    <li>Let <var>decls</var> be an empty list of <a data-link-type="dfn" href="#css-declaration" id="ref-for-css-declaration②⑨">CSS declarations</a>. 
    <li>
     If <var>elt</var> is <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#connected" id="ref-for-connected">connected</a>, part of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-scoping-1/#flat-tree" id="ref-for-flat-tree">flat tree</a>,
  and its <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-shadow-including-root" id="ref-for-concept-shadow-including-root">shadow-including root</a> has a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#browsing-context" id="ref-for-browsing-context">browsing context</a> which either
  doesn’t have a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#browsing-context-container" id="ref-for-browsing-context-container">browsing context container</a>, or whose <span id="ref-for-browsing-context-container①">browsing context container</span> is <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/rendering.html#being-rendered" id="ref-for-being-rendered">being rendered</a>,
  set <var>decls</var> to a list of all longhand properties that are <a data-link-type="dfn" href="#supported-css-property" id="ref-for-supported-css-property⑤">supported CSS properties</a>, in lexicographical order,
  with the value being the <a data-link-type="dfn" href="#resolved-value" id="ref-for-resolved-value">resolved value</a> computed for <var>obj</var> using the style rules associated with <var>doc</var>. Additionally, append to <var>decls</var> all the <a data-link-type="dfn" href="https://drafts.csswg.org/css-variables-1/#custom-property" id="ref-for-custom-property⑤">custom properties</a> whose <a data-link-type="dfn" href="https://drafts.csswg.org/css-cascade-4/#computed-value" id="ref-for-computed-value">computed value</a> for <var>obj</var> is not the <a data-link-type="dfn" href="https://drafts.csswg.org/css-variables-1/#guaranteed-invalid-value" id="ref-for-guaranteed-invalid-value">guaranteed-invalid value</a>. 
     <p class="issue" id="issue-28428295"><a class="self-link" href="#issue-28428295"></a> There are UAs that handle shorthands, and all UAs handle shorthands
  that used to be longhands like <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-overflow-3/#propdef-overflow" id="ref-for-propdef-overflow">overflow</a>, see <a href="https://github.com/w3c/csswg-drafts/issues/2529">#2529</a>.</p>
     <p class="issue" id="issue-0b704bc1"><a class="self-link" href="#issue-0b704bc1"></a> Order of custom properties is currently undefined, see <a href="https://github.com/w3c/csswg-drafts/issues/4947">#4947</a>.</p>
    <li>
      Return a live <a data-link-type="dfn" href="#css-declaration-block" id="ref-for-css-declaration-block①②">CSS declaration block</a> with the following properties: 
     <dl>
      <dt><a data-link-type="dfn" href="#cssstyledeclaration-computed-flag" id="ref-for-cssstyledeclaration-computed-flag①①">computed flag</a> 
      <dd>Set. 
      <dt><a data-link-type="dfn" href="#cssstyledeclaration-declarations" id="ref-for-cssstyledeclaration-declarations②⓪">declarations</a> 
      <dd><var>decls</var>. 
      <dt><a data-link-type="dfn" href="#cssstyledeclaration-parent-css-rule" id="ref-for-cssstyledeclaration-parent-css-rule⑤">parent CSS rule</a> 
      <dd>Null. 
      <dt><a data-link-type="dfn" href="#cssstyledeclaration-owner-node" id="ref-for-cssstyledeclaration-owner-node⑧">owner node</a> 
      <dd><var>obj</var>. 
     </dl>
   </ol>
   <p class="warning">The <code class="idl"><a data-link-type="idl" href="#dom-window-getcomputedstyle" id="ref-for-dom-window-getcomputedstyle①">getComputedStyle()</a></code> method exposes information from <a data-link-type="dfn" href="#css-style-sheet" id="ref-for-css-style-sheet④⑥">CSS style
sheets</a> with the <a data-link-type="dfn" href="#concept-css-style-sheet-origin-clean-flag" id="ref-for-concept-css-style-sheet-origin-clean-flag⑥">origin-clean flag</a> unset. </p>
   <p class="issue" id="issue-854608f5"><a class="self-link" href="#issue-854608f5"></a> Should getComputedStyle() provide a useful serialization?
See <a href="https://github.com/w3c/csswg-drafts/issues/1033">#1033</a></p>
   <h2 class="heading settled" data-level="8" id="utility-apis"><span class="secno">8. </span><span class="content">Utility APIs</span><a class="self-link" href="#utility-apis"></a></h2>
   <h3 class="heading settled" data-level="8.1" id="the-css.escape()-method"><span class="secno">8.1. </span><span class="content">The <code>CSS.escape()</code> Method</span><a class="self-link" href="#the-css.escape()-method"></a></h3>
   <p>The <code>CSS</code> namespace holds useful CSS-related functions that do not belong elsewhere.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed①③"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>namespace</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="namespace" data-export id="namespacedef-css"><code><c- g>CSS</c-></code></dfn> {
  <a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring②⑨"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="method" href="#dom-css-escape" id="ref-for-dom-css-escape"><c- g>escape</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring" id="ref-for-cssomstring③⓪"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="CSS/escape(ident)" data-dfn-type="argument" data-export id="dom-css-escape-ident-ident"><code><c- g>ident</c-></code><a class="self-link" href="#dom-css-escape-ident-ident"></a></dfn>);
};
</pre>
   <p class="issue" id="issue-24739c22"><a class="self-link" href="#issue-24739c22"></a> This was previously specified as an IDL interface
that only held static methods.
Switching to an IDL namespace is *nearly* identical,
so it’s expected that there won’t be any compat concerns.
If any are discovered, please report
so we can consider reverting this change.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CSS" data-dfn-type="method" data-export id="dom-css-escape"><code>escape(<var>ident</var>)</code></dfn> operation must return the result of invoking <a data-link-type="dfn" href="#serialize-an-identifier" id="ref-for-serialize-an-identifier⑨">serialize an identifier</a> of <var>ident</var>.</p>
   <div class="example" id="example-c8dd1300">
    <a class="self-link" href="#example-c8dd1300"></a> For example, to serialize a string for use as part of a selector, the <code class="idl"><a data-link-type="idl" href="#dom-css-escape" id="ref-for-dom-css-escape①">escape()</a></code> method can be used: 
<pre>var element = document.querySelector('#' + CSS.escape(id) + ' > img');</pre>
   </div>
   <div class="example" id="example-6c87326f">
    <a class="self-link" href="#example-6c87326f"></a> The <code class="idl"><a data-link-type="idl" href="#dom-css-escape" id="ref-for-dom-css-escape②">escape()</a></code> method can also be used for escaping strings, although it escapes characters that don’t strictly need to be
 escaped: 
<pre>var element = document.querySelector('a[href="#' + CSS.escape(fragment) + '"]');</pre>
   </div>
   <p>Specifications that define operations on the <code class="idl"><a data-link-type="idl" href="#namespacedef-css" id="ref-for-namespacedef-css">CSS</a></code> namespace and want to
store some state should store the state on the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#current-global-object" id="ref-for-current-global-object">current global
object</a>’s <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/window-object.html#concept-document-window" id="ref-for-concept-document-window">associated <code>Document</code></a>.</p>
   <h2 class="heading settled" data-level="9" id="resolved-values"><span class="secno">9. </span><span class="content">Resolved Values</span><a class="self-link" href="#resolved-values"></a></h2>
   <p><code class="idl"><a data-link-type="idl" href="#dom-window-getcomputedstyle" id="ref-for-dom-window-getcomputedstyle②">getComputedStyle()</a></code> was
historically defined to return the "computed value" of an element or
pseudo-element. However, the concept of "computed value" changed between
revisions of CSS while the implementation of <code class="idl"><a data-link-type="idl" href="#dom-window-getcomputedstyle" id="ref-for-dom-window-getcomputedstyle③">getComputedStyle()</a></code> had to
remain the same for compatibility with deployed scripts. To address this
issue this specification introduces the concept of a <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="resolved-value">resolved value</dfn>.</p>
   <p>The <a data-link-type="dfn" href="#resolved-value" id="ref-for-resolved-value①">resolved value</a> for a given longhand property can be determined
as follows:</p>
   <dl class="switch">
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-backgrounds-3/#propdef-background-color" id="ref-for-propdef-background-color">background-color</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-border-block-end-color" id="ref-for-propdef-border-block-end-color">border-block-end-color</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-border-block-start-color" id="ref-for-propdef-border-block-start-color">border-block-start-color</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-backgrounds-3/#propdef-border-bottom-color" id="ref-for-propdef-border-bottom-color">border-bottom-color</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-border-inline-end-color" id="ref-for-propdef-border-inline-end-color">border-inline-end-color</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-border-inline-start-color" id="ref-for-propdef-border-inline-start-color">border-inline-start-color</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-backgrounds-3/#propdef-border-left-color" id="ref-for-propdef-border-left-color">border-left-color</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-backgrounds-3/#propdef-border-right-color" id="ref-for-propdef-border-right-color">border-right-color</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-backgrounds-3/#propdef-border-top-color" id="ref-for-propdef-border-top-color">border-top-color</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-backgrounds-3/#propdef-box-shadow" id="ref-for-propdef-box-shadow">box-shadow</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-ui-4/#propdef-caret-color" id="ref-for-propdef-caret-color">caret-color</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-color-4/#propdef-color" id="ref-for-propdef-color">color</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-ui-4/#propdef-outline-color" id="ref-for-propdef-outline-color">outline-color</a> 
    <dt>A <dfn data-dfn-type="dfn" data-export id="resolved-value-special-case-property-like-color">resolved value special case property like <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-color-4/#propdef-color" id="ref-for-propdef-color①">color</a><a class="self-link" href="#resolved-value-special-case-property-like-color"></a></dfn> defined in another specification 
    <dd>The <a data-link-type="dfn" href="#resolved-value" id="ref-for-resolved-value②">resolved value</a> is the <a data-link-type="dfn" href="https://drafts.csswg.org/css-cascade-4/#used-value" id="ref-for-used-value">used value</a>. 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css2/visudet.html#propdef-line-height" id="ref-for-propdef-line-height">line-height</a> 
    <dd>The <a data-link-type="dfn" href="#resolved-value" id="ref-for-resolved-value③">resolved value</a> is <a class="property" data-link-type="propdesc">normal</a> if the <a data-link-type="dfn" href="https://drafts.csswg.org/css-cascade-4/#computed-value" id="ref-for-computed-value①">computed value</a> is <span class="property">normal</span>, or the <a data-link-type="dfn" href="https://drafts.csswg.org/css-cascade-4/#used-value" id="ref-for-used-value①">used value</a> otherwise. 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-block-size" id="ref-for-propdef-block-size">block-size</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css2/visudet.html#propdef-height" id="ref-for-propdef-height">height</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-inline-size" id="ref-for-propdef-inline-size">inline-size</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-margin-block-end" id="ref-for-propdef-margin-block-end">margin-block-end</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-margin-block-start" id="ref-for-propdef-margin-block-start">margin-block-start</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-box-3/#propdef-margin-bottom" id="ref-for-propdef-margin-bottom">margin-bottom</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-margin-inline-end" id="ref-for-propdef-margin-inline-end">margin-inline-end</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-margin-inline-start" id="ref-for-propdef-margin-inline-start">margin-inline-start</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-box-3/#propdef-margin-left" id="ref-for-propdef-margin-left">margin-left</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-box-3/#propdef-margin-right" id="ref-for-propdef-margin-right">margin-right</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-box-3/#propdef-margin-top" id="ref-for-propdef-margin-top">margin-top</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-padding-block-end" id="ref-for-propdef-padding-block-end">padding-block-end</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-padding-block-start" id="ref-for-propdef-padding-block-start">padding-block-start</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-box-3/#propdef-padding-bottom" id="ref-for-propdef-padding-bottom">padding-bottom</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-padding-inline-end" id="ref-for-propdef-padding-inline-end">padding-inline-end</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-padding-inline-start" id="ref-for-propdef-padding-inline-start">padding-inline-start</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-box-3/#propdef-padding-left" id="ref-for-propdef-padding-left">padding-left</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-box-3/#propdef-padding-right" id="ref-for-propdef-padding-right">padding-right</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-box-3/#propdef-padding-top" id="ref-for-propdef-padding-top">padding-top</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css2/visudet.html#propdef-width" id="ref-for-propdef-width">width</a> 
    <dt>A <dfn data-dfn-type="dfn" data-export id="resolved-value-special-case-property-like-height">resolved value special case property like <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css2/visudet.html#propdef-height" id="ref-for-propdef-height①">height</a><a class="self-link" href="#resolved-value-special-case-property-like-height"></a></dfn> defined in another specification 
    <dd>If the property applies to the element or pseudo-element and the <a data-link-type="dfn" href="#resolved-value" id="ref-for-resolved-value④">resolved value</a> of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-display-3/#propdef-display" id="ref-for-propdef-display">display</a> property is not <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-display-3/#valdef-display-none" id="ref-for-valdef-display-none">none</a> or <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-display-3/#valdef-display-contents" id="ref-for-valdef-display-contents">contents</a>, then the <span id="ref-for-resolved-value⑤">resolved value</span> is the <a data-link-type="dfn" href="https://drafts.csswg.org/css-cascade-4/#used-value" id="ref-for-used-value②">used value</a>. Otherwise the <span id="ref-for-resolved-value⑥">resolved value</span> is the <a data-link-type="dfn" href="https://drafts.csswg.org/css-cascade-4/#computed-value" id="ref-for-computed-value②">computed value</a>. 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-position-3/#propdef-bottom" id="ref-for-propdef-bottom">bottom</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-position-3/#propdef-left" id="ref-for-propdef-left">left</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-inset-block-end" id="ref-for-propdef-inset-block-end">inset-block-end</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-inset-block-start" id="ref-for-propdef-inset-block-start">inset-block-start</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-inset-inline-end" id="ref-for-propdef-inset-inline-end">inset-inline-end</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-logical-1/#propdef-inset-inline-start" id="ref-for-propdef-inset-inline-start">inset-inline-start</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-position-3/#propdef-right" id="ref-for-propdef-right">right</a> 
    <dt><a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-position-3/#propdef-top" id="ref-for-propdef-top">top</a> 
    <dt>A <dfn data-dfn-type="dfn" data-export id="resolved-value-special-case-property-like-top">resolved value special case property like <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-position-3/#propdef-top" id="ref-for-propdef-top①">top</a><a class="self-link" href="#resolved-value-special-case-property-like-top"></a></dfn> defined in another specification 
    <dd>If the property applies to a positioned element and the <a data-link-type="dfn" href="#resolved-value" id="ref-for-resolved-value⑦">resolved value</a> of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-display-3/#propdef-display" id="ref-for-propdef-display①">display</a> property is not <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-display-3/#valdef-display-none" id="ref-for-valdef-display-none①">none</a> or <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-display-3/#valdef-display-contents" id="ref-for-valdef-display-contents①">contents</a>, and the property is not over-constrained,
 then the <span id="ref-for-resolved-value⑧">resolved value</span> is the <a data-link-type="dfn" href="https://drafts.csswg.org/css-cascade-4/#used-value" id="ref-for-used-value③">used value</a>. Otherwise the <span id="ref-for-resolved-value⑨">resolved value</span> is the <a data-link-type="dfn" href="https://drafts.csswg.org/css-cascade-4/#computed-value" id="ref-for-computed-value③">computed value</a>. 
    <dt>A <dfn data-dfn-type="dfn" data-export id="resolved-value-special-case-property">resolved value special case property<a class="self-link" href="#resolved-value-special-case-property"></a></dfn> defined in another specification 
    <dd>As defined in the relevant specification. 
    <dt>Any other property 
    <dd>The <a data-link-type="dfn" href="#resolved-value" id="ref-for-resolved-value①⓪">resolved value</a> is the <a data-link-type="dfn" href="https://drafts.csswg.org/css-cascade-4/#computed-value" id="ref-for-computed-value④">computed value</a>. 
   </dl>
   <h2 class="heading settled" data-level="10" id="iana-considerations"><span class="secno">10. </span><span class="content">IANA Considerations</span><a class="self-link" href="#iana-considerations"></a></h2>
   <h3 class="heading settled" data-level="10.1" id="default-style"><span class="secno">10.1. </span><span class="content">Default-Style</span><a class="self-link" href="#default-style"></a></h3>
   <p>This section describes a header field for registration in the Permanent
Message Header Field Registry.</p>
   <dl>
    <dt>Header field name 
    <dd><dfn class="dfn-paneled" data-dfn-type="dfn" data-lt="http-default-style" data-noexport id="http-default-style">Default-Style</dfn> 
    <dt>Applicable protocol 
    <dd>http 
    <dt>Status 
    <dd>standard 
    <dt>Author/Change controller 
    <dd>W3C 
    <dt>Specification document(s) 
    <dd>This document is the relevant specification. 
    <dt>Related information 
    <dd>None. 
   </dl>
   <h2 class="heading settled" data-level="11" id="change-history"><span class="secno">11. </span><span class="content">Change History</span><a class="self-link" href="#change-history"></a></h2>
   <p>This section documents some of the changes between publications of this specification. This section is not exhaustive. Bug fixes and editorial changes are
generally not listed.</p>
   <h3 class="heading settled" data-level="11.1" id="changes-from-5-december-2013"><span class="secno">11.1. </span><span class="content">Changes From 5 December 2013</span><a class="self-link" href="#changes-from-5-december-2013"></a></h3>
   <ul>
    <li data-md>
     <p>The <code>styleSheets</code> IDL attribute is moved from <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document③">Document</a></code> to <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#documentorshadowroot" id="ref-for-documentorshadowroot⑤">DocumentOrShadowRoot</a></code>.</p>
    <li data-md>
     <p>API for alternative stylesheets is removed: <code>selectedStyleSheetSet</code>, <code>lastStyleSheetSet</code>, <code>preferredStyleSheetSet</code>, <code>styleSheetSets</code>, <code>enableStyleSheetsForSet()</code> on <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document④">Document</a></code>.</p>
    <li data-md>
     <p>The <code>pseudo()</code> method on <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#element" id="ref-for-element④">Element</a></code> and the <code>PseudoElement</code> interface is
removed.</p>
    <li data-md>
     <p>The <code>cascadedStyle</code>, <code>defaultStyle</code>, <code>rawComputedStyle</code> and <code>usedStyle</code> IDL attributes on <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#element" id="ref-for-element⑤">Element</a></code> are removed.</p>
    <li data-md>
     <p>The <code class="idl"><a data-link-type="idl" href="#dom-cssrule-csstext" id="ref-for-dom-cssrule-csstext②">cssText</a></code> IDL attribute’s setter on <code class="idl"><a data-link-type="idl" href="#cssrule" id="ref-for-cssrule①⑥">CSSRule</a></code> is changed to do nothing.</p>
    <li data-md>
     <p>IDL attributes of the form <code>webkitFoo</code> (with lowercase <code>w</code>) on <code class="idl"><a data-link-type="idl" href="#cssstyledeclaration" id="ref-for-cssstyledeclaration⑨">CSSStyleDeclaration</a></code> are added.</p>
    <li data-md>
     <p><code class="idl"><a data-link-type="idl" href="#cssnamespacerule" id="ref-for-cssnamespacerule③">CSSNamespaceRule</a></code> is changed back to readonly.</p>
    <li data-md>
     <p>Handling of <code>@charset</code> in <code class="idl"><a data-link-type="idl" href="#dom-cssstylesheet-insertrule" id="ref-for-dom-cssstylesheet-insertrule③">insertRule()</a></code> is removed.</p>
    <li data-md>
     <p><code>CSSCharsetRule</code> is removed again.</p>
    <li data-md>
     <p>Serialization of identifiers and strings is changed.</p>
    <li data-md>
     <p>Serialization of selectors now supports combinators ">>" and "||" and the "i" flag in attribute selectors.</p>
    <li data-md>
     <p>Serialization of :lang() is changed.</p>
    <li data-md>
     <p>Serialization of <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-color-3/#valuea-def-color" id="ref-for-valuea-def-color②" title="Expands to: aliceblue | antiquewhite | aqua | aquamarine | azure | beige | bisque | black | blanchedalmond | blue | blueviolet | brown | burlywood | cadetblue | chartreuse | chocolate | coral | cornflowerblue | cornsilk | crimson | currentcolor | cyan | darkblue | darkcyan | darkgoldenrod | darkgray | darkgreen | darkgrey | darkkhaki | darkmagenta | darkolivegreen | darkorange | darkorchid | darkred | darksalmon | darkseagreen | darkslateblue | darkslategray | darkslategrey | darkturquoise | darkviolet | deeppink | deepskyblue | dimgray | dimgrey | dodgerblue | firebrick | floralwhite | forestgreen | fuchsia | gainsboro | ghostwhite | gold | goldenrod | gray | green | greenyellow | grey | honeydew | hotpink | indianred | indigo | ivory | khaki | lavender | lavenderblush | lawngreen | lemonchiffon | lightblue | lightcoral | lightcyan | lightgoldenrodyellow | lightgray | lightgreen | lightgrey | lightpink | lightsalmon | lightseagreen | lightskyblue | lightslategray | lightslategrey | lightsteelblue | lightyellow | lime | limegreen | linen | magenta | maroon | mediumaquamarine | mediumblue | mediumorchid | mediumpurple | mediumseagreen | mediumslateblue | mediumspringgreen | mediumturquoise | mediumvioletred | midnightblue | mintcream | mistyrose | moccasin | navajowhite | navy | oldlace | olive | olivedrab | orange | orangered | orchid | palegoldenrod | palegreen | paleturquoise | palevioletred | papayawhip | peachpuff | peru | pink | plum | powderblue | purple | rebeccapurple | red | rosybrown | royalblue | saddlebrown | salmon | sandybrown | seagreen | seashell | sienna | silver | skyblue | slateblue | slategray | slategrey | snow | springgreen | steelblue | tan | teal | thistle | tomato | transparent | turquoise | violet | wheat | white | whitesmoke | yellow | yellowgreen">&lt;color></a> and <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#number-value" id="ref-for-number-value①">&lt;number></a> is changed.</p>
    <li data-md>
     <p><code class="idl"><a data-link-type="idl" href="#dom-cssstyledeclaration-setproperty" id="ref-for-dom-cssstyledeclaration-setproperty⑤">setProperty()</a></code> on <code class="idl"><a data-link-type="idl" href="#cssstyledeclaration" id="ref-for-cssstyledeclaration①⓪">CSSStyleDeclaration</a></code> is changed.</p>
    <li data-md>
     <p><code>setPropertyValue</code> and <code>setPropertyPriority</code> are removed from <code class="idl"><a data-link-type="idl" href="#cssstyledeclaration" id="ref-for-cssstyledeclaration①①">CSSStyleDeclaration</a></code> due to lack of interest from implementations.</p>
   </ul>
   <h3 class="heading settled" data-level="11.2" id="changes-from-12-july-2011-to-5-december-2013"><span class="secno">11.2. </span><span class="content">Changes From 12 July 2011 To 5 December 2013</span><a class="self-link" href="#changes-from-12-july-2011-to-5-december-2013"></a></h3>
   <ul>
    <li>Cross-origin stylesheets are not allowed to be read or changed. 
    <li><code>CSSCharsetRule</code> is re-introduced. 
    <li><code>CSSGroupingRule</code> and <code>CSSMarginRule</code> are introduced. 
    <li><code>CSSNamespaceRule</code> is now mutable. 
    <li><a data-link-type="dfn" href="#parse-a-css-declaration-block" id="ref-for-parse-a-css-declaration-block③">Parse</a> and <a data-link-type="dfn" href="#serialize-a-css-declaration-block" id="ref-for-serialize-a-css-declaration-block③">serialize</a> a CSS declaration block is
 now defined. 
    <li>Shorthands are now supported in <code class="idl"><a data-link-type="idl" href="#dom-cssstyledeclaration-setproperty" id="ref-for-dom-cssstyledeclaration-setproperty⑥">setProperty()</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-cssstyledeclaration-getpropertyvalue" id="ref-for-dom-cssstyledeclaration-getpropertyvalue⑥">getPropertyValue()</a></code>, et al. 
    <li><code>setPropertyValue</code> and <code>setPropertyPriority</code> are added to <code class="idl"><a data-link-type="idl" href="#cssstyledeclaration" id="ref-for-cssstyledeclaration①②">CSSStyleDeclaration</a></code>. 
    <li>The <code>style</code> and <code>media</code> attributes of various interfaces are annotated with the <code>[PutForwards]</code> WebIDL
 extended attribute. 
    <li>The <code>pseudo()</code> method on <code>Element</code> is introduced. 
    <li>The <code>PseudoElement</code> interface is introduced. 
    <li>The <code>cascadedStyle</code>, <code>rawComputedStyle</code> and <code>usedStyle</code> attributes on <code>Element</code> and <code>PseudoElement</code> are introduced. 
    <li>The <a class="idl-code" data-link-type="method" href="#dom-css-escape" id="ref-for-dom-css-escape③">CSS.escape()</a> static method is introduced. 
   </ul>
   <h2 class="heading settled" data-level="12" id="acknowledgments"><span class="secno">12. </span><span class="content">Acknowledgments</span><a class="self-link" href="#acknowledgments"></a></h2>
   <p>The editors would like to thank
Alexey Feldgendler,
Benjamin Poulain,
Björn Höhrmann,
Boris Zbasky,
Brian Kardell,
Chris Dumez,
Christian Krebs,
Daniel Glazman,
David Baron,
Domenic Denicola,
Dominique Hazael-Massieux, <i>fantasai</i>,
Hallvord R. M. Steen,
Ian Hickson,
John Daggett,
Lachlan Hunt,
Mike Sherov,
Myles C. Maxfield,
Morten Stenshorne,
Ms2ger,
Nazım Can Altınova,
Øyvind Stenhaug,
Peter Sloetjes,
Philip Jägenstedt,
Philip Taylor,
Richard Gibson,
Robert O’Callahan,
Simon Sapin,
Sjoerd Visscher,
Sylvain Galineau,
Tarquin Wilton-Jones,
Xidorn Quan, and
Zack Weinberg
for contributing to this specification.</p>
   <p>Additional thanks to Ian Hickson for writing the
initial version of the alternative style sheets API and canonicalization
(now serialization) rules for CSS values.</p>
  </main>
  <h2 class="no-ref no-num heading settled" id="conformance"><span class="content"> Conformance</span><a class="self-link" href="#conformance"></a></h2>
  <h3 class="heading settled" id="document-conventions"><span class="content"> Document conventions</span><a class="self-link" href="#document-conventions"></a></h3>
  <p>Conformance requirements are expressed with a combination of
	descriptive assertions and RFC 2119 terminology. The key words “MUST”,
	“MUST NOT”, “REQUIRED”, “SHALL”, “SHALL NOT”, “SHOULD”, “SHOULD NOT”,
	“RECOMMENDED”, “MAY”, and “OPTIONAL” in the normative parts of this
	document are to be interpreted as described in RFC 2119.
	However, for readability, these words do not appear in all uppercase
	letters in this specification. </p>
  <p>All of the text of this specification is normative except sections
	explicitly marked as non-normative, examples, and notes. <a data-link-type="biblio" href="#biblio-rfc2119">[RFC2119]</a> </p>
  <p>Examples in this specification are introduced with the words “for example”
	or are set apart from the normative text with <code>class="example"</code>,
	like this: </p>
  <div class="example" id="example-ae2b6bc0">
   <a class="self-link" href="#example-ae2b6bc0"></a> 
   <p>This is an example of an informative example. </p>
  </div>
  <p>Informative notes begin with the word “Note” and are set apart from the
	normative text with <code>class="note"</code>, like this: </p>
  <p class="note" role="note">Note, this is an informative note. </p>
  <p>Advisements are normative sections styled to evoke special attention and are
	set apart from other normative text with <code>&lt;strong class="advisement"></code>, like
	this: <strong class="advisement"> UAs MUST provide an accessible alternative. </strong> </p>
  <h3 class="heading settled" id="conform-classes"><span class="content"> Conformance classes</span><a class="self-link" href="#conform-classes"></a></h3>
  <p>Conformance to this specification
	is defined for three conformance classes: </p>
  <dl>
   <dt>style sheet 
   <dd>A <a href="http://www.w3.org/TR/CSS2/conform.html#style-sheet">CSS
			style sheet</a>. 
   <dt>renderer 
   <dd>A <a href="http://www.w3.org/TR/CSS2/conform.html#user-agent">UA</a> that interprets the semantics of a style sheet and renders
			documents that use them. 
   <dt>authoring tool 
   <dd>A <a href="http://www.w3.org/TR/CSS2/conform.html#user-agent">UA</a> that writes a style sheet. 
  </dl>
  <p>A style sheet is conformant to this specification
	if all of its statements that use syntax defined in this module are valid
	according to the generic CSS grammar and the individual grammars of each
	feature defined in this module. </p>
  <p>A renderer is conformant to this specification
	if, in addition to interpreting the style sheet as defined by the
	appropriate specifications, it supports all the features defined
	by this specification by parsing them correctly
	and rendering the document accordingly. However, the inability of a
	UA to correctly render a document due to limitations of the device
	does not make the UA non-conformant. (For example, a UA is not
	required to render color on a monochrome monitor.) </p>
  <p>An authoring tool is conformant to this specification
	if it writes style sheets that are syntactically correct according to the
	generic CSS grammar and the individual grammars of each feature in
	this module, and meet all other conformance requirements of style sheets
	as described in this module. </p>
  <h3 class="heading settled" id="conform-responsible"><span class="content"> Requirements for Responsible Implementation of CSS</span><a class="self-link" href="#conform-responsible"></a></h3>
  <p>The following sections define several conformance requirements
		for implementing CSS responsibly,
		in a way that promotes interoperability in the present and future. </p>
  <h4 class="heading settled" id="conform-partial"><span class="content"> Partial Implementations</span><a class="self-link" href="#conform-partial"></a></h4>
  <p>So that authors can exploit the forward-compatible parsing rules to assign fallback values, <strong>CSS renderers <em>must</em> treat as invalid
		(and <a href="http://www.w3.org/TR/CSS2/conform.html#ignore">ignore as appropriate</a>)
		any at-rules, properties, property values, keywords, and other syntactic constructs
		for which they have no usable level of support</strong>.
		In particular, user agents <em>must not</em> selectively ignore
		unsupported property values and honor supported values in a single multi-value property declaration:
		if any value is considered invalid (as unsupported values must be),
		CSS requires that the entire declaration be ignored. </p>
  <h4 class="heading settled" id="conform-future-proofing"><span class="content"> Implementations of Unstable and Proprietary Features</span><a class="self-link" href="#conform-future-proofing"></a></h4>
  <p>To avoid clashes with future stable CSS features,
		the CSSWG recommends <a href="http://www.w3.org/TR/CSS/#future-proofing">following best practices</a> for the implementation of <a href="http://www.w3.org/TR/CSS/#unstable">unstable</a> features and <a href="http://www.w3.org/TR/CSS/#proprietary-extension">proprietary extensions</a> to CSS. </p>
  <h4 class="heading settled" id="conform-testing"><span class="content"> Implementations of CR-level Features</span><a class="self-link" href="#conform-testing"></a></h4>
  <p>Once a specification reaches the Candidate Recommendation stage,
		implementers should release an <a data-link-type="dfn" href="http://www.w3.org/TR/CSS/#vendor-prefix">unprefixed</a> implementation
		of any CR-level feature they can demonstrate
		to be correctly implemented according to spec,
		and should avoid exposing a prefixed variant of that feature. </p>
  <p>To establish and maintain the interoperability of CSS across
		implementations, the CSS Working Group requests that non-experimental
		CSS renderers submit an implementation report (and, if necessary, the
		testcases used for that implementation report) to the W3C before
		releasing an unprefixed implementation of any CSS features. Testcases
		submitted to W3C are subject to review and correction by the CSS
		Working Group. </p>
  <p>
   Further information on submitting testcases and implementation reports
		can be found from on the CSS Working Group’s website at <a href="http://www.w3.org/Style/CSS/Test/">http://www.w3.org/Style/CSS/Test/</a>.
		Questions should be directed to the <a href="http://lists.w3.org/Archives/Public/public-css-testsuite">public-css-testsuite@w3.org</a> mailing list. 
<script src="https://www.w3.org/scripts/TR/2016/fixup.js"></script>
  </p>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-css.escape()-method">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSS/escape" title="The CSS.escape() static method returns a CSSOMString containing the escaped string passed as parameter, mostly for use as part of a CSS selector.">CSS/escape</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>31+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>46+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>33+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>31+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>10+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>46+</span></span><span class="webview_android yes"><span>Android WebView</span><span>46+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>33+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSS" title="The CSS interface holds useful CSS-related methods. No object with this interface are implemented: it contains only static methods and therefore is a utilitarian interface.">CSS</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>22+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>28+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>22+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>28+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.5+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>12.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="cssgroupingrule">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSGroupingRule" title="An object implementing the CSSGroupingRule interface represents any CSS at-rule that contains other rules nested within it.">CSSGroupingRule</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>20+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>32+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>20+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>32+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-cssmediarule-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSMediaRule" title="The CSSMediaRule interface represents a single CSS @media rule. It implements the CSSConditionRule interface, and therefore the CSSGroupingRule and the CSSRule interface with a type value of 4 (CSSRule.MEDIA_RULE).">CSSMediaRule</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>17+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>17+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssnamespacerule-namespaceuri">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSNamespaceRule/namespaceURI" title="The CSSNamespaceRule.namespaceURI read-only property returns a DOMString containing the text of the URI of the given namespace.">CSSNamespaceRule/namespaceURI</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>59+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>47+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>36+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>59+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>47+</span></span><span class="webview_android yes"><span>Android WebView</span><span>47+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>36+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSNamespaceRule/prefix" title="The CSSNamespaceRule.prefix read-only property returns a DOMString with the name of the prefix associated to this namespace. If there is no such prefix, returns  null.">CSSNamespaceRule/prefix</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>59+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>47+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>36+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>59+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>47+</span></span><span class="webview_android yes"><span>Android WebView</span><span>47+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>36+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-cssnamespacerule-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSNamespaceRule" title="The CSSNamespaceRule interface describes an object representing a single CSS @namespace at-rule. It implements the CSSRule interface, with a type value of 10 (CSSRule.NAMESPACE_RULE).">CSSNamespaceRule</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>59+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>47+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>36+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>59+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>47+</span></span><span class="webview_android yes"><span>Android WebView</span><span>47+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>36+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-csspagerule-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSPageRule" title="CSSPageRule is an interface representing a single CSS @page rule. It implements the CSSRule interface with a type value of 6 (CSSRule.PAGE_RULE).">CSSPageRule</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>19+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>32+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>Yes</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>19+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>32+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssrule-csstext">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSRule/cssText" title="The cssText property of the CSSRule interface returns the actual text of a CSSStyleSheet style-rule.">CSSRule/cssText</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssrule-parentstylesheet">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSRule/parentStyleSheet" title="The parentStyleSheet property of the CSSRule interface returns the StyleSheet object in which the current rule is defined.">CSSRule/parentStyleSheet</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="css-rules">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSRule" title="The CSSRule interface represents a single CSS rule. There are several types of rules, listed in the Type constants section below.">CSSRule</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-cssrulelist-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSRuleList" title="A CSSRuleList is an (indirect-modify only) array-like object containing an ordered collection of CSSRule objects.">CSSRuleList</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssstyledeclaration-csstext">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleDeclaration/cssText" title="The cssText property of the CSSStyleDeclaration interface returns or sets the text of the element&apos;s inline style declaration only.">CSSStyleDeclaration/cssText</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssstyledeclaration-getpropertypriority">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleDeclaration/getPropertyPriority" title="The CSSStyleDeclaration.getPropertyPriority() method interface returns a DOMString that provides all explicitly set priorities on the CSS property.">CSSStyleDeclaration/getPropertyPriority</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>Yes</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssstyledeclaration-getpropertyvalue">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleDeclaration/getPropertyValue" title="The CSSStyleDeclaration.getPropertyValue() method interface returns a DOMString containing the value of a specified CSS property.">CSSStyleDeclaration/getPropertyValue</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>Yes</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssstyledeclaration-item">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleDeclaration/item" title="The CSSStyleDeclaration.item() method interface returns a CSS property name from a CSSStyleDeclaration by index">CSSStyleDeclaration/item</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>Yes</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssstyledeclaration-length">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleDeclaration/length" title="The read-only property returns an integer that represents the number of style declarations in this CSS declaration block.">CSSStyleDeclaration/length</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>Yes</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssstyledeclaration-parentrule">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleDeclaration/parentRule" title="The CSSStyleDeclaration.parentRule read-only property returns a CSSRule that is the parent of this style block">CSSStyleDeclaration/parentRule</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>Yes</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssstyledeclaration-removeproperty">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleDeclaration/removeProperty" title="The CSSStyleDeclaration.removeProperty() method interface removes a property from a CSS style declaration object.">CSSStyleDeclaration/removeProperty</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>Yes</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssstyledeclaration-setproperty">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleDeclaration/setProperty" title="The CSSStyleDeclaration.setProperty() method interface sets a new value for a property on a CSS style declaration object.">CSSStyleDeclaration/setProperty</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>6+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-cssstyledeclaration-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleDeclaration" title="The CSSStyleDeclaration interface represents an object that is a CSS declaration block, and exposes style information and various style-related methods and properties.">CSSStyleDeclaration</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>Yes</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssstylerule-selectortext">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleRule/selectorText" title="The CSSRule.selectorText property gets the textual representation of the selector for the rule set. This is readonly in some browsers; to set stylesheet rules dynamically cross-browser, see Using dynamic styling information.">CSSStyleRule/selectorText</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssstylerule-style">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleRule/style" title="The CSSRule.style property is the CSSStyleDeclaration interface for the declaration block of the CSSRule.">CSSStyleRule/style</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-cssstylerule-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleRule" title="CSSStyleRule represents a single CSS style rule. It implements the CSSRule interface with a type value of 1 (CSSRule.STYLE_RULE).">CSSStyleRule</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssstylesheet-cssrules">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleSheet/cssRules" title="The read-only CSSStyleSheet property cssRules returns a live CSSRuleList which provides a real-time, up-to-date list of every CSS rule which comprises the stylesheet.">CSSStyleSheet/cssRules</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssstylesheet-deleterule">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleSheet/deleteRule" title="The CSSStyleSheet method deleteRule() removes a rule from the stylesheet object.">CSSStyleSheet/deleteRule</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssstylesheet-insertrule">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleSheet/insertRule" title="The CSSStyleSheet.insertRule() method inserts a new CSS rule into the current style sheet, with some restrictions.">CSSStyleSheet/insertRule</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-cssstylesheet-ownerrule">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleSheet/ownerRule" title="The read-only CSSStyleSheet property ownerRule returns the CSSImportRule corresponding to the @import at-rule which imported the stylesheet into the document.">CSSStyleSheet/ownerRule</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="cssstylesheet">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CSSStyleSheet" title="The CSSStyleSheet interface represents a single CSS stylesheet, and lets you inspect and modify the list of rules contained in the stylesheet.">CSSStyleSheet</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-elementcssinlinestyle-style">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/ElementCSSInlineStyle/style" title="The style property is used to get as well as set the inline style of an element. When getting, it returns a CSSStyleDeclaration object that contains a list of all styles properties for that element with values assigned for the attributes that are defined in the element&apos;s inline style attribute.">ElementCSSInlineStyle/style</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>11+</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>8+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>8+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>11+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-linkstyle-interface">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/LinkStyle" title="The LinkStyle interface provides access to the associated CSS style sheet of a node.">LinkStyle</a></p>
    <p class="less-than-two-engines-text">In no current engines.</p>
    <div class="support">
     <span class="firefox no"><span>Firefox</span><span>?</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome no"><span>Chrome</span><span>?</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink no"><span>Edge</span><span>?</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>?</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>?</span></span><span class="webview_android no"><span>Android WebView</span><span>?</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>?</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-medialist-mediatext">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MediaList/mediaText" title="The mediaText property of the MediaList interface is a stringifier that returns a DOMString representing the MediaList as text, and also allows you to set a new MediaList.">MediaList/mediaText</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-medialist-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MediaList" title="The MediaList interface represents the media queries of a stylesheet, e.g. those set using a <link> element&apos;s media attribute.">MediaList</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-stylesheet-disabled">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/StyleSheet/disabled" title="The disabled property of the StyleSheet interface determines whether the style sheet is prevented from applying to the document.">StyleSheet/disabled</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-stylesheet-href">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/StyleSheet/href" title="The href property of the StyleSheet interface returns the location of the style sheet.">StyleSheet/href</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-stylesheet-media">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/StyleSheet/media" title="The media property of the StyleSheet interface specifies the intended destination media for style information. It is a read-only, array-like MediaList object and can be removed with deleteMedium() and added with appendMedium().">StyleSheet/media</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-stylesheet-ownernode">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/StyleSheet/ownerNode" title="The ownerNode property of the StyleSheet interface returns the node that associates this style sheet with the document.">StyleSheet/ownerNode</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-stylesheet-parentstylesheet">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/StyleSheet/parentStyleSheet" title="The parentStyleSheet property of the StyleSheet interface returns the style sheet, if any, that is including the given style sheet.">StyleSheet/parentStyleSheet</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-stylesheet-title">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/StyleSheet/title" title="The title property of the StyleSheet interface returns the advisory title of the current style sheet.">StyleSheet/title</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-stylesheet-type">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/StyleSheet/type" title="The type property of the StyleSheet interface specifies the style sheet language for the given style sheet.">StyleSheet/type</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="stylesheet">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/StyleSheet" title="An object implementing the StyleSheet interface represents a single style sheet. CSS style sheets will further implement the more specialized CSSStyleSheet interface.">StyleSheet</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-stylesheetlist-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/StyleSheetList" title="The StyleSheetList interface represents a list of StyleSheet.">StyleSheetList</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>31+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>31+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-getcomputedstyle">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/getComputedStyle" title="The Window.getComputedStyle() method returns an object containing the values of all CSS properties of an element, after applying active stylesheets and resolving any basic computation those values may contain.">Window/getComputedStyle</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>7.2+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <h2 class="no-num no-ref heading settled" id="index"><span class="content">Index</span><a class="self-link" href="#index"></a></h2>
  <h3 class="no-num no-ref heading settled" id="index-defined-here"><span class="content">Terms defined by this specification</span><a class="self-link" href="#index-defined-here"></a></h3>
  <ul class="index">
   <li><a href="#add-a-css-style-sheet">add a CSS style sheet</a><span>, in §6.2</span>
   <li><a href="#dom-cssstylesheet-addrule">addRule()</a><span>, in §6.1.2.1</span>
   <li><a href="#dom-cssstylesheet-addrule">addRule(selector)</a><span>, in §6.1.2.1</span>
   <li><a href="#dom-cssstylesheet-addrule">addRule(selector, block, optionalIndex)</a><span>, in §6.1.2.1</span>
   <li><a href="#dom-cssstylesheet-addrule">addRule(selector, style)</a><span>, in §6.1.2.1</span>
   <li><a href="#dom-cssstylesheet-addrule">addRule(selector, style, index)</a><span>, in §6.1.2.1</span>
   <li><a href="#concept-css-style-sheet-alternate-flag">alternate flag</a><span>, in §6.1</span>
   <li><a href="#dom-medialist-appendmedium">appendMedium(medium)</a><span>, in §4.4</span>
   <li><a href="#associated-css-style-sheet">associated CSS style sheet</a><span>, in §6.3.2</span>
   <li><a href="#dom-cssstyledeclaration-camel-cased-attribute">camel-cased attribute</a><span>, in §6.6.1</span>
   <li><a href="#dom-cssstyledeclaration-camel_cased_attribute">camel_cased_attribute</a><span>, in §6.6.1</span>
   <li><a href="#css-declaration-case-sensitive-flag">case-sensitive flag</a><span>, in §6.5</span>
   <li><a href="#change-the-preferred-css-style-sheet-set-name">change the preferred CSS style sheet set name</a><span>, in §6.2</span>
   <li><a href="#dom-cssrule-charset_rule">CHARSET_RULE</a><span>, in §6.4.2</span>
   <li><a href="#concept-css-rule-child-css-rules">child CSS rules</a><span>, in §6.4</span>
   <li><a href="#medialist-collection-of-media-queries">collection of media queries</a><span>, in §4.4</span>
   <li><a href="#compare-media-queries">compare media queries</a><span>, in §4.3</span>
   <li><a href="#cssstyledeclaration-computed-flag">computed flag</a><span>, in §6.6</span>
   <li><a href="#create-a-css-style-sheet">create a CSS style sheet</a><span>, in §6.2</span>
   <li><a href="#create-a-medialist-object">create a MediaList object</a><span>, in §4.4</span>
   <li><a href="#namespacedef-css">CSS</a><span>, in §8.1</span>
   <li><a href="#css-declaration">CSS declaration</a><span>, in §6.5</span>
   <li><a href="#css-declaration-block">CSS declaration block</a><span>, in §6.6</span>
   <li><a href="#dom-cssstyledeclaration-cssfloat">cssFloat</a><span>, in §6.6.1</span>
   <li><a href="#cssgroupingrule">CSSGroupingRule</a><span>, in §6.4.5</span>
   <li><a href="#cssimportrule">CSSImportRule</a><span>, in §6.4.4</span>
   <li><a href="#cssmarginrule">CSSMarginRule</a><span>, in §6.4.8</span>
   <li><a href="#cssnamespacerule">CSSNamespaceRule</a><span>, in §6.4.9</span>
   <li><a href="#cssomstring">CSSOMString</a><span>, in §3</span>
   <li><a href="#csspagerule">CSSPageRule</a><span>, in §6.4.7</span>
   <li><a href="#css-property-to-idl-attribute">CSS property to IDL attribute</a><span>, in §6.6.1</span>
   <li><a href="#css-rule">CSS rule</a><span>, in §6.4</span>
   <li><a href="#cssrule">CSSRule</a><span>, in §6.4.2</span>
   <li><a href="#cssrulelist">CSSRuleList</a><span>, in §6.4.1</span>
   <li><a href="#concept-css-style-sheet-css-rules">CSS rules</a><span>, in §6.1</span>
   <li>
    cssRules
    <ul>
     <li><a href="#dom-cssgroupingrule-cssrules">attribute for CSSGroupingRule</a><span>, in §6.4.5</span>
     <li><a href="#dom-cssstylesheet-cssrules">attribute for CSSStyleSheet</a><span>, in §6.1.2</span>
    </ul>
   <li><a href="#cssstyledeclaration">CSSStyleDeclaration</a><span>, in §6.6.1</span>
   <li><a href="#cssstylerule">CSSStyleRule</a><span>, in §6.4.3</span>
   <li><a href="#css-style-sheet">CSS style sheet</a><span>, in §6.1</span>
   <li><a href="#cssstylesheet">CSSStyleSheet</a><span>, in §6.1.2</span>
   <li><a href="#css-style-sheet-set">CSS style sheet set</a><span>, in §6.2</span>
   <li><a href="#css-style-sheet-set-name">CSS style sheet set name</a><span>, in §6.2</span>
   <li>
    cssText
    <ul>
     <li><a href="#dom-cssrule-csstext">attribute for CSSRule</a><span>, in §6.4.2</span>
     <li><a href="#dom-cssstyledeclaration-csstext">attribute for CSSStyleDeclaration</a><span>, in §6.6.1</span>
    </ul>
   <li><a href="#dom-cssstyledeclaration-dashed-attribute">dashed attribute</a><span>, in §6.6.1</span>
   <li><a href="#dom-cssstyledeclaration-dashed_attribute">dashed_attribute</a><span>, in §6.6.1</span>
   <li><a href="#cssstyledeclaration-declarations">declarations</a><span>, in §6.6</span>
   <li><a href="#dom-medialist-deletemedium">deleteMedium(medium)</a><span>, in §4.4</span>
   <li>
    deleteRule(index)
    <ul>
     <li><a href="#dom-cssgroupingrule-deleterule">method for CSSGroupingRule</a><span>, in §6.4.5</span>
     <li><a href="#dom-cssstylesheet-deleterule">method for CSSStyleSheet</a><span>, in §6.1.2</span>
    </ul>
   <li><a href="#dom-stylesheet-disabled">disabled</a><span>, in §6.1.1</span>
   <li><a href="#concept-css-style-sheet-disabled-flag">disabled flag</a><span>, in §6.1</span>
   <li><a href="#documentorshadowroot-document-or-shadow-root-css-style-sheets">document or shadow root CSS style sheets</a><span>, in §6.2</span>
   <li><a href="#elementcssinlinestyle">ElementCSSInlineStyle</a><span>, in §7.1</span>
   <li><a href="#enable-a-css-style-sheet-set">enable a CSS style sheet set</a><span>, in §6.2</span>
   <li><a href="#enabled-css-style-sheet-set">enabled CSS style sheet set</a><span>, in §6.2</span>
   <li><a href="#escape-a-character">escape a character</a><span>, in §2.1</span>
   <li><a href="#escape-a-character-as-code-point">escape a character as code point</a><span>, in §2.1</span>
   <li><a href="#escape-a-character-as-code-point">escaped as code point</a><span>, in §2.1</span>
   <li><a href="#dom-css-escape">escape(ident)</a><span>, in §8.1</span>
   <li><a href="#fetch-a-css-style-sheet">fetch a CSS style sheet</a><span>, in §6.3.1</span>
   <li><a href="#dom-cssrule-font_face_rule">FONT_FACE_RULE</a><span>, in §6.4.2</span>
   <li><a href="#dom-window-getcomputedstyle">getComputedStyle(elt)</a><span>, in §7.2</span>
   <li><a href="#dom-window-getcomputedstyle">getComputedStyle(elt, pseudoElt)</a><span>, in §7.2</span>
   <li><a href="#dom-cssstyledeclaration-getpropertypriority">getPropertyPriority(property)</a><span>, in §6.6.1</span>
   <li><a href="#dom-cssstyledeclaration-getpropertyvalue">getPropertyValue(property)</a><span>, in §6.6.1</span>
   <li>
    href
    <ul>
     <li><a href="#dom-cssimportrule-href">attribute for CSSImportRule</a><span>, in §6.4.4</span>
     <li><a href="#dom-stylesheet-href">attribute for StyleSheet</a><span>, in §6.1.1</span>
    </ul>
   <li><a href="#http-default-style">http-default-style</a><span>, in §10.1</span>
   <li><a href="#idl-attribute-to-css-property">IDL attribute to CSS property</a><span>, in §6.6.1</span>
   <li><a href="#css-declaration-important-flag">important flag</a><span>, in §6.5</span>
   <li><a href="#dom-cssrule-import_rule">IMPORT_RULE</a><span>, in §6.4.2</span>
   <li><a href="#insert-a-css-rule">insert a CSS rule</a><span>, in §6.4</span>
   <li>
    insertRule(rule)
    <ul>
     <li><a href="#dom-cssgroupingrule-insertrule">method for CSSGroupingRule</a><span>, in §6.4.5</span>
     <li><a href="#dom-cssstylesheet-insertrule">method for CSSStyleSheet</a><span>, in §6.1.2</span>
    </ul>
   <li>
    insertRule(rule, index)
    <ul>
     <li><a href="#dom-cssgroupingrule-insertrule">method for CSSGroupingRule</a><span>, in §6.4.5</span>
     <li><a href="#dom-cssstylesheet-insertrule">method for CSSStyleSheet</a><span>, in §6.1.2</span>
    </ul>
   <li>
    item(index)
    <ul>
     <li><a href="#dom-cssrulelist-item">method for CSSRuleList</a><span>, in §6.4.1</span>
     <li><a href="#dom-cssstyledeclaration-item">method for CSSStyleDeclaration</a><span>, in §6.6.1</span>
     <li><a href="#dom-medialist-item">method for MediaList</a><span>, in §4.4</span>
     <li><a href="#dom-stylesheetlist-item">method for StyleSheetList</a><span>, in §6.2.2</span>
    </ul>
   <li><a href="#last-css-style-sheet-set-name">last CSS style sheet set name</a><span>, in §6.2</span>
   <li>
    length
    <ul>
     <li><a href="#dom-cssrulelist-length">attribute for CSSRuleList</a><span>, in §6.4.1</span>
     <li><a href="#dom-cssstyledeclaration-length">attribute for CSSStyleDeclaration</a><span>, in §6.6.1</span>
     <li><a href="#dom-medialist-length">attribute for MediaList</a><span>, in §4.4</span>
     <li><a href="#dom-stylesheetlist-length">attribute for StyleSheetList</a><span>, in §6.2.2</span>
    </ul>
   <li><a href="#linkstyle">LinkStyle</a><span>, in §6.3.2</span>
   <li><a href="#concept-css-style-sheet-location">location</a><span>, in §6.1</span>
   <li><a href="#dom-cssrule-margin_rule">MARGIN_RULE</a><span>, in §6.4.2</span>
   <li>
    media
    <ul>
     <li><a href="#dom-cssimportrule-media">attribute for CSSImportRule</a><span>, in §6.4.4</span>
     <li><a href="#dom-stylesheet-media">attribute for StyleSheet</a><span>, in §6.1.1</span>
     <li><a href="#concept-css-style-sheet-media">dfn for CSSStyleSheet</a><span>, in §6.1</span>
    </ul>
   <li><a href="#medialist">MediaList</a><span>, in §4.4</span>
   <li><a href="#dom-cssrule-media_rule">MEDIA_RULE</a><span>, in §6.4.2</span>
   <li><a href="#dom-medialist-mediatext">mediaText</a><span>, in §4.4</span>
   <li><a href="#dom-cssmarginrule-name">name</a><span>, in §6.4.8</span>
   <li><a href="#dom-cssrule-namespace_rule">NAMESPACE_RULE</a><span>, in §6.4.2</span>
   <li><a href="#dom-cssnamespacerule-namespaceuri">namespaceURI</a><span>, in §6.4.9</span>
   <li><a href="#concept-css-style-sheet-origin-clean-flag">origin-clean flag</a><span>, in §6.1</span>
   <li><a href="#concept-css-style-sheet-owner-css-rule">owner CSS rule</a><span>, in §6.1</span>
   <li>
    owner node
    <ul>
     <li><a href="#cssstyledeclaration-owner-node">dfn for CSSStyleDeclaration</a><span>, in §6.6</span>
     <li><a href="#concept-css-style-sheet-owner-node">dfn for CSSStyleSheet</a><span>, in §6.1</span>
    </ul>
   <li><a href="#dom-stylesheet-ownernode">ownerNode</a><span>, in §6.1.1</span>
   <li><a href="#dom-cssstylesheet-ownerrule">ownerRule</a><span>, in §6.1.2</span>
   <li><a href="#dom-cssrule-page_rule">PAGE_RULE</a><span>, in §6.4.2</span>
   <li>
    parent CSS rule
    <ul>
     <li><a href="#concept-css-rule-parent-css-rule">dfn for CSSRule</a><span>, in §6.4</span>
     <li><a href="#cssstyledeclaration-parent-css-rule">dfn for CSSStyleDeclaration</a><span>, in §6.6</span>
    </ul>
   <li>
    parent CSS style sheet
    <ul>
     <li><a href="#concept-css-rule-parent-css-style-sheet">dfn for CSSRule</a><span>, in §6.4</span>
     <li><a href="#concept-css-style-sheet-parent-css-style-sheet">dfn for CSSStyleSheet</a><span>, in §6.1</span>
    </ul>
   <li>
    parentRule
    <ul>
     <li><a href="#dom-cssrule-parentrule">attribute for CSSRule</a><span>, in §6.4.2</span>
     <li><a href="#dom-cssstyledeclaration-parentrule">attribute for CSSStyleDeclaration</a><span>, in §6.6.1</span>
    </ul>
   <li>
    parentStyleSheet
    <ul>
     <li><a href="#dom-cssrule-parentstylesheet">attribute for CSSRule</a><span>, in §6.4.2</span>
     <li><a href="#dom-stylesheet-parentstylesheet">attribute for StyleSheet</a><span>, in §6.1.1</span>
    </ul>
   <li><a href="#parse-a-css-declaration-block">parse a CSS declaration block</a><span>, in §6.6</span>
   <li><a href="#parse-a-css-rule">parse a CSS rule</a><span>, in §6.4</span>
   <li><a href="#parse-a-css-value">parse a CSS value</a><span>, in §6.7.1</span>
   <li><a href="#parse-a-group-of-selectors">parse a group of selectors</a><span>, in §5.1</span>
   <li><a href="#parse-a-list-of-css-page-selectors">parse a list of CSS page selectors</a><span>, in §6.4.7</span>
   <li><a href="#parse-a-media-query">parse a media query</a><span>, in §4.1</span>
   <li><a href="#parse-a-media-query-list">parse a media query list</a><span>, in §4.1</span>
   <li><a href="#persistent-css-style-sheet">persistent CSS style sheet</a><span>, in §6.2</span>
   <li><a href="#preferred-css-style-sheet-set-name">preferred CSS style sheet set name</a><span>, in §6.2</span>
   <li><a href="#concept-shorthands-preferred-order">preferred order</a><span>, in §6.6</span>
   <li><a href="#dom-cssnamespacerule-prefix">prefix</a><span>, in §6.4.9</span>
   <li><a href="#prolog">prolog</a><span>, in §6.3.4</span>
   <li><a href="#css-declaration-property-name">property name</a><span>, in §6.5</span>
   <li><a href="#remove-a-css-rule">remove a CSS rule</a><span>, in §6.4</span>
   <li><a href="#remove-a-css-style-sheet">remove a CSS style sheet</a><span>, in §6.2</span>
   <li><a href="#dom-cssstyledeclaration-removeproperty">removeProperty(property)</a><span>, in §6.6.1</span>
   <li><a href="#dom-cssstylesheet-removerule">removeRule()</a><span>, in §6.1.2.1</span>
   <li><a href="#dom-cssstylesheet-removerule">removeRule(index)</a><span>, in §6.1.2.1</span>
   <li><a href="#resolved-value">resolved value</a><span>, in §9</span>
   <li><a href="#resolved-value-special-case-property">resolved value special case property</a><span>, in §9</span>
   <li><a href="#resolved-value-special-case-property-like-color">resolved value special case property like color</a><span>, in §9</span>
   <li><a href="#resolved-value-special-case-property-like-height">resolved value special case property like height</a><span>, in §9</span>
   <li><a href="#resolved-value-special-case-property-like-top">resolved value special case property like top</a><span>, in §9</span>
   <li><a href="#dom-cssstylesheet-rules">rules</a><span>, in §6.1.2.1</span>
   <li><a href="#select-a-css-style-sheet-set">select a CSS style sheet set</a><span>, in §6.2</span>
   <li>
    selectorText
    <ul>
     <li><a href="#dom-cssgroupingrule-selectortext">attribute for CSSGroupingRule</a><span>, in §6.4.7</span>
     <li><a href="#dom-csspagerule-selectortext">attribute for CSSPageRule</a><span>, in §6.4.7</span>
     <li><a href="#dom-cssstylerule-selectortext">attribute for CSSStyleRule</a><span>, in §6.4.3</span>
    </ul>
   <li><a href="#serialize-a-comma-separated-list">serialize a comma-separated list</a><span>, in §2.1</span>
   <li><a href="#serialize-a-css-component-value">serialize a CSS component value</a><span>, in §6.7.2</span>
   <li><a href="#serialize-a-css-declaration">serialize a CSS declaration</a><span>, in §6.6</span>
   <li><a href="#serialize-a-css-declaration-block">serialize a CSS declaration block</a><span>, in §6.6</span>
   <li><a href="#serialize-a-css-rule">serialize a CSS rule</a><span>, in §6.4</span>
   <li><a href="#serialize-a-css-value">serialize a CSS value</a><span>, in §6.7.2</span>
   <li><a href="#serialize-a-group-of-selectors">serialize a group of selectors</a><span>, in §5.2</span>
   <li><a href="#serialize-a-list-of-css-page-selectors">serialize a list of CSS page selectors</a><span>, in §6.4.7</span>
   <li><a href="#serialize-a-local">serialize a LOCAL</a><span>, in §2.1</span>
   <li><a href="#serialize-a-media-feature-value">serialize a media feature value</a><span>, in §4.2.1</span>
   <li><a href="#serialize-a-media-query">serialize a media query</a><span>, in §4.2</span>
   <li><a href="#serialize-a-media-query-list">serialize a media query list</a><span>, in §4.2</span>
   <li><a href="#serialize-an-identifier">serialize an identifier</a><span>, in §2.1</span>
   <li><a href="#serialize-a-selector">serialize a selector</a><span>, in §5.2</span>
   <li><a href="#serialize-a-simple-selector">serialize a simple selector</a><span>, in §5.2</span>
   <li><a href="#serialize-a-string">serialize a string</a><span>, in §2.1</span>
   <li><a href="#serialize-a-url">serialize a URL</a><span>, in §2.1</span>
   <li><a href="#serialize-a-whitespace-separated-list">serialize a whitespace-separated list</a><span>, in §2.1</span>
   <li><a href="#set">set</a><span>, in §2</span>
   <li><a href="#set-a-css-declaration">set a CSS declaration</a><span>, in §6.6.1</span>
   <li><a href="#dom-cssstyledeclaration-setproperty">setProperty(property, value)</a><span>, in §6.6.1</span>
   <li><a href="#dom-cssstyledeclaration-setproperty">setProperty(property, value, priority)</a><span>, in §6.6.1</span>
   <li><a href="#dom-linkstyle-sheet">sheet</a><span>, in §6.3.2</span>
   <li><a href="#concept-declarations-specified-order">specified order</a><span>, in §6.4.3</span>
   <li><a href="#MediaList-stringification-behavior">stringification behavior</a><span>, in §4.4</span>
   <li>
    style
    <ul>
     <li><a href="#dom-cssgroupingrule-style">attribute for CSSGroupingRule</a><span>, in §6.4.7</span>
     <li><a href="#dom-cssmarginrule-style">attribute for CSSMarginRule</a><span>, in §6.4.8</span>
     <li><a href="#dom-csspagerule-style">attribute for CSSPageRule</a><span>, in §6.4.7</span>
     <li><a href="#dom-cssstylerule-style">attribute for CSSStyleRule</a><span>, in §6.4.3</span>
     <li><a href="#dom-elementcssinlinestyle-style">attribute for ElementCSSInlineStyle</a><span>, in §7.1</span>
    </ul>
   <li><a href="#dom-cssrule-style_rule">STYLE_RULE</a><span>, in §6.4.2</span>
   <li><a href="#stylesheet">StyleSheet</a><span>, in §6.1.1</span>
   <li><a href="#dom-cssimportrule-stylesheet">styleSheet</a><span>, in §6.4.4</span>
   <li><a href="#stylesheetlist">StyleSheetList</a><span>, in §6.2.2</span>
   <li><a href="#dom-documentorshadowroot-stylesheets">styleSheets</a><span>, in §6.2.3</span>
   <li><a href="#supported-css-property">supported CSS property</a><span>, in §2</span>
   <li><a href="#supported-styling-language">supported styling language</a><span>, in §2</span>
   <li><a href="#concept-css-rule-text">text</a><span>, in §6.4</span>
   <li>
    title
    <ul>
     <li><a href="#dom-stylesheet-title">attribute for StyleSheet</a><span>, in §6.1.1</span>
     <li><a href="#concept-css-style-sheet-title">dfn for CSSStyleSheet</a><span>, in §6.1</span>
    </ul>
   <li>
    type
    <ul>
     <li><a href="#dom-cssrule-type">attribute for CSSRule</a><span>, in §6.4.2</span>
     <li><a href="#dom-stylesheet-type">attribute for StyleSheet</a><span>, in §6.1.1</span>
     <li><a href="#concept-css-rule-type">dfn for CSSRule</a><span>, in §6.4</span>
     <li><a href="#concept-css-style-sheet-type">dfn for CSSStyleSheet</a><span>, in §6.1</span>
    </ul>
   <li><a href="#unset">unset</a><span>, in §2</span>
   <li><a href="#update-style-attribute-for">update style attribute for</a><span>, in §6.6</span>
   <li><a href="#cssstyledeclaration-updating-flag">updating flag</a><span>, in §6.6</span>
   <li><a href="#css-declaration-value">value</a><span>, in §6.5</span>
   <li><a href="#dom-cssstyledeclaration-webkit-cased-attribute">webkit-cased attribute</a><span>, in §6.6.1</span>
   <li><a href="#dom-cssstyledeclaration-webkit_cased_attribute">webkit_cased_attribute</a><span>, in §6.6.1</span>
  </ul>
  <aside class="dfn-panel" data-for="term-for-csskeyframerule">
   <a href="https://drafts.csswg.org/css-animations-1/#csskeyframerule">https://drafts.csswg.org/css-animations-1/#csskeyframerule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-csskeyframerule">6.4.2. The CSSRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-csskeyframesrule">
   <a href="https://drafts.csswg.org/css-animations-1/#csskeyframesrule">https://drafts.csswg.org/css-animations-1/#csskeyframesrule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-csskeyframesrule">6.4.2. The CSSRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-background-color">
   <a href="https://drafts.csswg.org/css-backgrounds-3/#propdef-background-color">https://drafts.csswg.org/css-backgrounds-3/#propdef-background-color</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-background-color">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-border-bottom-color">
   <a href="https://drafts.csswg.org/css-backgrounds-3/#propdef-border-bottom-color">https://drafts.csswg.org/css-backgrounds-3/#propdef-border-bottom-color</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-border-bottom-color">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-border-left-color">
   <a href="https://drafts.csswg.org/css-backgrounds-3/#propdef-border-left-color">https://drafts.csswg.org/css-backgrounds-3/#propdef-border-left-color</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-border-left-color">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-border-right-color">
   <a href="https://drafts.csswg.org/css-backgrounds-3/#propdef-border-right-color">https://drafts.csswg.org/css-backgrounds-3/#propdef-border-right-color</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-border-right-color">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-border-top-color">
   <a href="https://drafts.csswg.org/css-backgrounds-3/#propdef-border-top-color">https://drafts.csswg.org/css-backgrounds-3/#propdef-border-top-color</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-border-top-color">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-box-shadow">
   <a href="https://drafts.csswg.org/css-backgrounds-3/#propdef-box-shadow">https://drafts.csswg.org/css-backgrounds-3/#propdef-box-shadow</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-box-shadow">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-margin-bottom">
   <a href="https://drafts.csswg.org/css-box-3/#propdef-margin-bottom">https://drafts.csswg.org/css-box-3/#propdef-margin-bottom</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-margin-bottom">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-margin-left">
   <a href="https://drafts.csswg.org/css-box-3/#propdef-margin-left">https://drafts.csswg.org/css-box-3/#propdef-margin-left</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-margin-left">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-margin-right">
   <a href="https://drafts.csswg.org/css-box-3/#propdef-margin-right">https://drafts.csswg.org/css-box-3/#propdef-margin-right</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-margin-right">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-margin-top">
   <a href="https://drafts.csswg.org/css-box-3/#propdef-margin-top">https://drafts.csswg.org/css-box-3/#propdef-margin-top</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-margin-top">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-padding-bottom">
   <a href="https://drafts.csswg.org/css-box-3/#propdef-padding-bottom">https://drafts.csswg.org/css-box-3/#propdef-padding-bottom</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-padding-bottom">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-padding-left">
   <a href="https://drafts.csswg.org/css-box-3/#propdef-padding-left">https://drafts.csswg.org/css-box-3/#propdef-padding-left</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-padding-left">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-padding-right">
   <a href="https://drafts.csswg.org/css-box-3/#propdef-padding-right">https://drafts.csswg.org/css-box-3/#propdef-padding-right</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-padding-right">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-padding-top">
   <a href="https://drafts.csswg.org/css-box-3/#propdef-padding-top">https://drafts.csswg.org/css-box-3/#propdef-padding-top</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-padding-top">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-computed-value">
   <a href="https://drafts.csswg.org/css-cascade-4/#computed-value">https://drafts.csswg.org/css-cascade-4/#computed-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-computed-value">7.2. Extensions to the Window Interface</a>
    <li><a href="#ref-for-computed-value①">9. Resolved Values</a> <a href="#ref-for-computed-value②">(2)</a> <a href="#ref-for-computed-value③">(3)</a> <a href="#ref-for-computed-value④">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-used-value">
   <a href="https://drafts.csswg.org/css-cascade-4/#used-value">https://drafts.csswg.org/css-cascade-4/#used-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-used-value">9. Resolved Values</a> <a href="#ref-for-used-value①">(2)</a> <a href="#ref-for-used-value②">(3)</a> <a href="#ref-for-used-value③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-alphavalue-def">
   <a href="https://drafts.csswg.org/css-color-3/#alphavalue-def">https://drafts.csswg.org/css-color-3/#alphavalue-def</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-alphavalue-def">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valuea-def-color">
   <a href="https://drafts.csswg.org/css-color-3/#valuea-def-color">https://drafts.csswg.org/css-color-3/#valuea-def-color</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valuea-def-color">6.7.2. Serializing CSS Values</a> <a href="#ref-for-valuea-def-color①">(2)</a>
    <li><a href="#ref-for-valuea-def-color②">11.1. Changes From 5 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-color">
   <a href="https://drafts.csswg.org/css-color-4/#propdef-color">https://drafts.csswg.org/css-color-4/#propdef-color</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-color">9. Resolved Values</a> <a href="#ref-for-propdef-color①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-csscounterstylerule">
   <a href="https://drafts.csswg.org/css-counter-styles-3/#csscounterstylerule">https://drafts.csswg.org/css-counter-styles-3/#csscounterstylerule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-csscounterstylerule">6.4.2. The CSSRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssviewportrule">
   <a href="https://drafts.csswg.org/css-device-adapt-1/#cssviewportrule">https://drafts.csswg.org/css-device-adapt-1/#cssviewportrule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssviewportrule">6.4.2. The CSSRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-display-contents">
   <a href="https://drafts.csswg.org/css-display-3/#valdef-display-contents">https://drafts.csswg.org/css-display-3/#valdef-display-contents</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-display-contents">9. Resolved Values</a> <a href="#ref-for-valdef-display-contents①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-display">
   <a href="https://drafts.csswg.org/css-display-3/#propdef-display">https://drafts.csswg.org/css-display-3/#propdef-display</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-display">9. Resolved Values</a> <a href="#ref-for-propdef-display①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-display-none">
   <a href="https://drafts.csswg.org/css-display-3/#valdef-display-none">https://drafts.csswg.org/css-display-3/#valdef-display-none</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-display-none">9. Resolved Values</a> <a href="#ref-for-valdef-display-none①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-font-size">
   <a href="https://drafts.csswg.org/css-fonts-3/#propdef-font-size">https://drafts.csswg.org/css-fonts-3/#propdef-font-size</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-font-size">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-propdef-font-size①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-family-name-value">
   <a href="https://drafts.csswg.org/css-fonts-4/#family-name-value">https://drafts.csswg.org/css-fonts-4/#family-name-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-family-name-value">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssfontfacerule">
   <a href="https://drafts.csswg.org/css-fonts-4/#cssfontfacerule">https://drafts.csswg.org/css-fonts-4/#cssfontfacerule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssfontfacerule">6.4. CSS Rules</a> <a href="#ref-for-cssfontfacerule①">(2)</a>
    <li><a href="#ref-for-cssfontfacerule②">6.4.2. The CSSRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssfontfeaturevaluesrule①">
   <a href="https://drafts.csswg.org/css-fonts-4/#cssfontfeaturevaluesrule①">https://drafts.csswg.org/css-fonts-4/#cssfontfeaturevaluesrule①</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssfontfeaturevaluesrule①">6.4.2. The CSSRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-font-face-font-feature-settings">
   <a href="https://drafts.csswg.org/css-fonts-4/#descdef-font-face-font-feature-settings">https://drafts.csswg.org/css-fonts-4/#descdef-font-face-font-feature-settings</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-font-face-font-feature-settings">6.4. CSS Rules</a> <a href="#ref-for-descdef-font-face-font-feature-settings①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-font-face-font-stretch">
   <a href="https://drafts.csswg.org/css-fonts-4/#descdef-font-face-font-stretch">https://drafts.csswg.org/css-fonts-4/#descdef-font-face-font-stretch</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-font-face-font-stretch">6.4. CSS Rules</a> <a href="#ref-for-descdef-font-face-font-stretch①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-font-face-font-style">
   <a href="https://drafts.csswg.org/css-fonts-4/#descdef-font-face-font-style">https://drafts.csswg.org/css-fonts-4/#descdef-font-face-font-style</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-font-face-font-style">6.4. CSS Rules</a> <a href="#ref-for-descdef-font-face-font-style①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-font-face-font-weight">
   <a href="https://drafts.csswg.org/css-fonts-4/#descdef-font-face-font-weight">https://drafts.csswg.org/css-fonts-4/#descdef-font-face-font-weight</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-font-face-font-weight">6.4. CSS Rules</a> <a href="#ref-for-descdef-font-face-font-weight①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-font-face-unicode-range">
   <a href="https://drafts.csswg.org/css-fonts-4/#descdef-font-face-unicode-range">https://drafts.csswg.org/css-fonts-4/#descdef-font-face-unicode-range</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-font-face-unicode-range">6.4. CSS Rules</a> <a href="#ref-for-descdef-font-face-unicode-range①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-typedef-counter">
   <a href="https://drafts.csswg.org/css-lists-3/#typedef-counter">https://drafts.csswg.org/css-lists-3/#typedef-counter</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-counter">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-block-size">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-block-size">https://drafts.csswg.org/css-logical-1/#propdef-block-size</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-block-size">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-border-block-end-color">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-border-block-end-color">https://drafts.csswg.org/css-logical-1/#propdef-border-block-end-color</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-border-block-end-color">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-border-block-start-color">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-border-block-start-color">https://drafts.csswg.org/css-logical-1/#propdef-border-block-start-color</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-border-block-start-color">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-border-inline-end-color">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-border-inline-end-color">https://drafts.csswg.org/css-logical-1/#propdef-border-inline-end-color</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-border-inline-end-color">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-border-inline-start-color">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-border-inline-start-color">https://drafts.csswg.org/css-logical-1/#propdef-border-inline-start-color</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-border-inline-start-color">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-inline-size">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-inline-size">https://drafts.csswg.org/css-logical-1/#propdef-inline-size</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-inline-size">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-inset-block-end">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-inset-block-end">https://drafts.csswg.org/css-logical-1/#propdef-inset-block-end</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-inset-block-end">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-inset-block-start">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-inset-block-start">https://drafts.csswg.org/css-logical-1/#propdef-inset-block-start</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-inset-block-start">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-inset-inline-end">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-inset-inline-end">https://drafts.csswg.org/css-logical-1/#propdef-inset-inline-end</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-inset-inline-end">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-inset-inline-start">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-inset-inline-start">https://drafts.csswg.org/css-logical-1/#propdef-inset-inline-start</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-inset-inline-start">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-logical-property-group">
   <a href="https://drafts.csswg.org/css-logical-1/#logical-property-group">https://drafts.csswg.org/css-logical-1/#logical-property-group</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-logical-property-group">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-logical-property-group①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mapping-logic">
   <a href="https://drafts.csswg.org/css-logical-1/#mapping-logic">https://drafts.csswg.org/css-logical-1/#mapping-logic</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mapping-logic">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-mapping-logic①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-margin-block-end">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-margin-block-end">https://drafts.csswg.org/css-logical-1/#propdef-margin-block-end</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-margin-block-end">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-margin-block-start">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-margin-block-start">https://drafts.csswg.org/css-logical-1/#propdef-margin-block-start</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-margin-block-start">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-margin-inline-end">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-margin-inline-end">https://drafts.csswg.org/css-logical-1/#propdef-margin-inline-end</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-margin-inline-end">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-margin-inline-start">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-margin-inline-start">https://drafts.csswg.org/css-logical-1/#propdef-margin-inline-start</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-margin-inline-start">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-padding-block-end">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-padding-block-end">https://drafts.csswg.org/css-logical-1/#propdef-padding-block-end</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-padding-block-end">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-padding-block-start">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-padding-block-start">https://drafts.csswg.org/css-logical-1/#propdef-padding-block-start</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-padding-block-start">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-padding-inline-end">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-padding-inline-end">https://drafts.csswg.org/css-logical-1/#propdef-padding-inline-end</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-padding-inline-end">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-padding-inline-start">
   <a href="https://drafts.csswg.org/css-logical-1/#propdef-padding-inline-start">https://drafts.csswg.org/css-logical-1/#propdef-padding-inline-start</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-padding-inline-start">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-default-namespace">
   <a href="https://drafts.csswg.org/css-namespaces-3/#default-namespace">https://drafts.csswg.org/css-namespaces-3/#default-namespace</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-default-namespace">5.2. Serializing Selectors</a> <a href="#ref-for-default-namespace①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-namespace-prefix">
   <a href="https://drafts.csswg.org/css-namespaces-3/#namespace-prefix">https://drafts.csswg.org/css-namespaces-3/#namespace-prefix</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-namespace-prefix">5.2. Serializing Selectors</a> <a href="#ref-for-namespace-prefix①">(2)</a> <a href="#ref-for-namespace-prefix②">(3)</a> <a href="#ref-for-namespace-prefix③">(4)</a> <a href="#ref-for-namespace-prefix④">(5)</a> <a href="#ref-for-namespace-prefix⑤">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-overflow">
   <a href="https://drafts.csswg.org/css-overflow-3/#propdef-overflow">https://drafts.csswg.org/css-overflow-3/#propdef-overflow</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-overflow">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-bottom">
   <a href="https://drafts.csswg.org/css-position-3/#propdef-bottom">https://drafts.csswg.org/css-position-3/#propdef-bottom</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-bottom">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-left">
   <a href="https://drafts.csswg.org/css-position-3/#propdef-left">https://drafts.csswg.org/css-position-3/#propdef-left</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-left">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-right">
   <a href="https://drafts.csswg.org/css-position-3/#propdef-right">https://drafts.csswg.org/css-position-3/#propdef-right</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-right">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-top">
   <a href="https://drafts.csswg.org/css-position-3/#propdef-top">https://drafts.csswg.org/css-position-3/#propdef-top</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-top">9. Resolved Values</a> <a href="#ref-for-propdef-top①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-selectordef-slotted">
   <a href="https://drafts.csswg.org/css-scoping-1/#selectordef-slotted">https://drafts.csswg.org/css-scoping-1/#selectordef-slotted</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-selectordef-slotted">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-flat-tree">
   <a href="https://drafts.csswg.org/css-scoping-1/#flat-tree">https://drafts.csswg.org/css-scoping-1/#flat-tree</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-flat-tree">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-selectordef-part">
   <a href="https://drafts.csswg.org/css-shadow-parts-1/#selectordef-part">https://drafts.csswg.org/css-shadow-parts-1/#selectordef-part</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-selectordef-part">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-caret-color">
   <a href="https://drafts.csswg.org/css-ui-4/#propdef-caret-color">https://drafts.csswg.org/css-ui-4/#propdef-caret-color</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-caret-color">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-outline-color">
   <a href="https://drafts.csswg.org/css-ui-4/#propdef-outline-color">https://drafts.csswg.org/css-ui-4/#propdef-outline-color</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-outline-color">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-angle-value">
   <a href="https://drafts.csswg.org/css-values-3/#angle-value">https://drafts.csswg.org/css-values-3/#angle-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-angle-value">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-integer-value">
   <a href="https://drafts.csswg.org/css-values-3/#integer-value">https://drafts.csswg.org/css-values-3/#integer-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-integer-value">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-length-value">
   <a href="https://drafts.csswg.org/css-values-3/#length-value">https://drafts.csswg.org/css-values-3/#length-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-length-value">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-number-value">
   <a href="https://drafts.csswg.org/css-values-3/#number-value">https://drafts.csswg.org/css-values-3/#number-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-number-value">6.7.2. Serializing CSS Values</a>
    <li><a href="#ref-for-number-value①">11.1. Changes From 5 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-percentage-value">
   <a href="https://drafts.csswg.org/css-values-3/#percentage-value">https://drafts.csswg.org/css-values-3/#percentage-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-percentage-value">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-resolution-value">
   <a href="https://drafts.csswg.org/css-values-3/#resolution-value">https://drafts.csswg.org/css-values-3/#resolution-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-resolution-value">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-string-value">
   <a href="https://drafts.csswg.org/css-values-3/#string-value">https://drafts.csswg.org/css-values-3/#string-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-string-value">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-url-value">
   <a href="https://drafts.csswg.org/css-values-3/#url-value">https://drafts.csswg.org/css-values-3/#url-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-url-value">6.7.2. Serializing CSS Values</a> <a href="#ref-for-url-value①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-frequency-value">
   <a href="https://drafts.csswg.org/css-values-4/#frequency-value">https://drafts.csswg.org/css-values-4/#frequency-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-frequency-value">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-time-value">
   <a href="https://drafts.csswg.org/css-values-4/#time-value">https://drafts.csswg.org/css-values-4/#time-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-time-value">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-px">
   <a href="https://drafts.csswg.org/css-values-4/#px">https://drafts.csswg.org/css-values-4/#px</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-px">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-comb-any">
   <a href="https://drafts.csswg.org/css-values-4/#comb-any">https://drafts.csswg.org/css-values-4/#comb-any</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-comb-any">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-custom-property">
   <a href="https://drafts.csswg.org/css-variables-1/#custom-property">https://drafts.csswg.org/css-variables-1/#custom-property</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-custom-property">2. Terminology</a>
    <li><a href="#ref-for-custom-property①">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-custom-property②">(2)</a> <a href="#ref-for-custom-property③">(3)</a> <a href="#ref-for-custom-property④">(4)</a>
    <li><a href="#ref-for-custom-property⑤">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-guaranteed-invalid-value">
   <a href="https://drafts.csswg.org/css-variables-1/#guaranteed-invalid-value">https://drafts.csswg.org/css-variables-1/#guaranteed-invalid-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-guaranteed-invalid-value">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-value-def-identifier">
   <a href="https://drafts.csswg.org/css2/syndata.html#value-def-identifier">https://drafts.csswg.org/css2/syndata.html#value-def-identifier</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-value-def-identifier">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-value-def-shape">
   <a href="https://drafts.csswg.org/css2/visufx.html#value-def-shape">https://drafts.csswg.org/css2/visufx.html#value-def-shape</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-value-def-shape">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-value-def-specific-voice">
   <a href="https://drafts.csswg.org/css2/aural.html#value-def-specific-voice">https://drafts.csswg.org/css2/aural.html#value-def-specific-voice</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-value-def-specific-voice">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-height">
   <a href="https://drafts.csswg.org/css2/visudet.html#propdef-height">https://drafts.csswg.org/css2/visudet.html#propdef-height</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-height">9. Resolved Values</a> <a href="#ref-for-propdef-height①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-line-height">
   <a href="https://drafts.csswg.org/css2/visudet.html#propdef-line-height">https://drafts.csswg.org/css2/visudet.html#propdef-line-height</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-line-height">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-width">
   <a href="https://drafts.csswg.org/css2/visudet.html#propdef-width">https://drafts.csswg.org/css2/visudet.html#propdef-width</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-width">9. Resolved Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssmediarule">
   <a href="https://drafts.csswg.org/css-conditional-3/#cssmediarule">https://drafts.csswg.org/css-conditional-3/#cssmediarule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssmediarule">6.4. CSS Rules</a>
    <li><a href="#ref-for-cssmediarule①">6.4.2. The CSSRule Interface</a>
    <li><a href="#ref-for-cssmediarule②">6.4.6. The CSSMediaRule Interface</a> <a href="#ref-for-cssmediarule③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-csssupportsrule">
   <a href="https://drafts.csswg.org/css-conditional-3/#csssupportsrule">https://drafts.csswg.org/css-conditional-3/#csssupportsrule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-csssupportsrule">6.4.2. The CSSRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-typedef-whitespace-token">
   <a href="https://drafts.csswg.org/css-syntax-3/#typedef-whitespace-token">https://drafts.csswg.org/css-syntax-3/#typedef-whitespace-token</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-whitespace-token">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-environment-encoding">
   <a href="https://drafts.csswg.org/css-syntax-3/#environment-encoding">https://drafts.csswg.org/css-syntax-3/#environment-encoding</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-environment-encoding">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-css-parse-something-according-to-a-css-grammar">
   <a href="https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar">https://drafts.csswg.org/css-syntax-3/#css-parse-something-according-to-a-css-grammar</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-parse-something-according-to-a-css-grammar">6.7.2. Serializing CSS Values</a>
    <li><a href="#ref-for-css-parse-something-according-to-a-css-grammar①">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-parse-a-list-of-component-values">
   <a href="https://drafts.csswg.org/css-syntax-3/#parse-a-list-of-component-values">https://drafts.csswg.org/css-syntax-3/#parse-a-list-of-component-values</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-parse-a-list-of-component-values">6.7.1. Parsing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-parse-a-list-of-declarations">
   <a href="https://drafts.csswg.org/css-syntax-3/#parse-a-list-of-declarations">https://drafts.csswg.org/css-syntax-3/#parse-a-list-of-declarations</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-parse-a-list-of-declarations">6.6. CSS Declaration Blocks</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-parse-a-rule">
   <a href="https://drafts.csswg.org/css-syntax-3/#parse-a-rule">https://drafts.csswg.org/css-syntax-3/#parse-a-rule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-parse-a-rule">6.4. CSS Rules</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-serialize-an-anb-value">
   <a href="https://drafts.csswg.org/css-syntax-3/#serialize-an-anb-value">https://drafts.csswg.org/css-syntax-3/#serialize-an-anb-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-an-anb-value">5.2. Serializing Selectors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-document">
   <a href="https://dom.spec.whatwg.org/#document">https://dom.spec.whatwg.org/#document</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-document">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a> <a href="#ref-for-document①">(2)</a>
    <li><a href="#ref-for-document②">6.4.2. The CSSRule Interface</a>
    <li><a href="#ref-for-document③">11.1. Changes From 5 December 2013</a> <a href="#ref-for-document④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-documentorshadowroot">
   <a href="https://dom.spec.whatwg.org/#documentorshadowroot">https://dom.spec.whatwg.org/#documentorshadowroot</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-documentorshadowroot">6.2. CSS Style Sheet Collections</a> <a href="#ref-for-documentorshadowroot①">(2)</a> <a href="#ref-for-documentorshadowroot②">(3)</a>
    <li><a href="#ref-for-documentorshadowroot③">6.2.3. Extensions to the DocumentOrShadowRoot Interface Mixin</a> <a href="#ref-for-documentorshadowroot④">(2)</a>
    <li><a href="#ref-for-documentorshadowroot⑤">11.1. Changes From 5 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-element">
   <a href="https://dom.spec.whatwg.org/#element">https://dom.spec.whatwg.org/#element</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-element">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-element①">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
    <li><a href="#ref-for-element②">6.6. CSS Declaration Blocks</a>
    <li><a href="#ref-for-element③">7.2. Extensions to the Window Interface</a>
    <li><a href="#ref-for-element④">11.1. Changes From 5 December 2013</a> <a href="#ref-for-element⑤">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-processinginstruction">
   <a href="https://dom.spec.whatwg.org/#processinginstruction">https://dom.spec.whatwg.org/#processinginstruction</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-processinginstruction">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-processinginstruction①">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-element-attributes-change-ext">
   <a href="https://dom.spec.whatwg.org/#concept-element-attributes-change-ext">https://dom.spec.whatwg.org/#concept-element-attributes-change-ext</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-element-attributes-change-ext">6.6. CSS Declaration Blocks</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-connected">
   <a href="https://dom.spec.whatwg.org/#connected">https://dom.spec.whatwg.org/#connected</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-connected">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-context-object">
   <a href="https://dom.spec.whatwg.org/#context-object">https://dom.spec.whatwg.org/#context-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-context-object">6.4.3. The CSSStyleRule Interface</a>
    <li><a href="#ref-for-context-object①">6.4.7. The CSSPageRule Interface</a>
    <li><a href="#ref-for-context-object②">6.4.8. The CSSMarginRule Interface</a>
    <li><a href="#ref-for-context-object③">7.1. 
The ElementCSSInlineStyle Mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-cd-data">
   <a href="https://dom.spec.whatwg.org/#concept-cd-data">https://dom.spec.whatwg.org/#concept-cd-data</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-cd-data">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-document">
   <a href="https://dom.spec.whatwg.org/#concept-document">https://dom.spec.whatwg.org/#concept-document</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-document">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a> <a href="#ref-for-concept-document①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-document-encoding">
   <a href="https://dom.spec.whatwg.org/#concept-document-encoding">https://dom.spec.whatwg.org/#concept-document-encoding</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-document-encoding">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-tree-following">
   <a href="https://dom.spec.whatwg.org/#concept-tree-following">https://dom.spec.whatwg.org/#concept-tree-following</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-tree-following">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-element-attributes-get-by-namespace">
   <a href="https://dom.spec.whatwg.org/#concept-element-attributes-get-by-namespace">https://dom.spec.whatwg.org/#concept-element-attributes-get-by-namespace</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-element-attributes-get-by-namespace">6.6. CSS Declaration Blocks</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-in-a-document-tree">
   <a href="https://dom.spec.whatwg.org/#in-a-document-tree">https://dom.spec.whatwg.org/#in-a-document-tree</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-in-a-document-tree">6.1. CSS Style Sheets</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-boundary-point-node">
   <a href="https://dom.spec.whatwg.org/#boundary-point-node">https://dom.spec.whatwg.org/#boundary-point-node</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-boundary-point-node">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a> <a href="#ref-for-boundary-point-node①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-node">
   <a href="https://dom.spec.whatwg.org/#concept-node">https://dom.spec.whatwg.org/#concept-node</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-node">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-element-attributes-set-value">
   <a href="https://dom.spec.whatwg.org/#concept-element-attributes-set-value">https://dom.spec.whatwg.org/#concept-element-attributes-set-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-element-attributes-set-value">6.6. CSS Declaration Blocks</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-shadow-including-root">
   <a href="https://dom.spec.whatwg.org/#concept-shadow-including-root">https://dom.spec.whatwg.org/#concept-shadow-including-root</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-shadow-including-root">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-encoding-get">
   <a href="https://encoding.spec.whatwg.org/#concept-encoding-get">https://encoding.spec.whatwg.org/#concept-encoding-get</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-encoding-get">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cereactions">
   <a href="https://html.spec.whatwg.org/multipage/custom-elements.html#cereactions">https://html.spec.whatwg.org/multipage/custom-elements.html#cereactions</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cereactions">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-cereactions①">(2)</a> <a href="#ref-for-cereactions②">(3)</a> <a href="#ref-for-cereactions③">(4)</a> <a href="#ref-for-cereactions④">(5)</a> <a href="#ref-for-cereactions⑤">(6)</a> <a href="#ref-for-cereactions⑥">(7)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-htmlelement">
   <a href="https://html.spec.whatwg.org/multipage/dom.html#htmlelement">https://html.spec.whatwg.org/multipage/dom.html#htmlelement</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-htmlelement">7.1. 
The ElementCSSInlineStyle Mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-window">
   <a href="https://html.spec.whatwg.org/multipage/window-object.html#window">https://html.spec.whatwg.org/multipage/window-object.html#window</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-window">7.2. Extensions to the Window Interface</a> <a href="#ref-for-window①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ascii-case-insensitive">
   <a href="https://html.spec.whatwg.org/multipage/infrastructure.html#ascii-case-insensitive">https://html.spec.whatwg.org/multipage/infrastructure.html#ascii-case-insensitive</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ascii-case-insensitive">6.3. Style Sheet Association</a>
    <li><a href="#ref-for-ascii-case-insensitive①">6.3.5. Requirements on User Agents Implementing the HTTP Link Header</a> <a href="#ref-for-ascii-case-insensitive②">(2)</a> <a href="#ref-for-ascii-case-insensitive③">(3)</a>
    <li><a href="#ref-for-ascii-case-insensitive④">6.6.1. The CSSStyleDeclaration Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-document-window">
   <a href="https://html.spec.whatwg.org/multipage/window-object.html#concept-document-window">https://html.spec.whatwg.org/multipage/window-object.html#concept-document-window</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-document-window">8.1. The CSS.escape() Method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-browsing-context-container">
   <a href="https://html.spec.whatwg.org/multipage/browsers.html#browsing-context-container">https://html.spec.whatwg.org/multipage/browsers.html#browsing-context-container</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-browsing-context-container">7.2. Extensions to the Window Interface</a> <a href="#ref-for-browsing-context-container①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-case-sensitive">
   <a href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive">https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-case-sensitive">2. Terminology</a>
    <li><a href="#ref-for-case-sensitive①">4.3. Comparing Media Queries</a>
    <li><a href="#ref-for-case-sensitive②">6.2. CSS Style Sheet Collections</a> <a href="#ref-for-case-sensitive③">(2)</a> <a href="#ref-for-case-sensitive④">(3)</a> <a href="#ref-for-case-sensitive⑤">(4)</a>
    <li><a href="#ref-for-case-sensitive⑥">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a> <a href="#ref-for-case-sensitive⑦">(2)</a>
    <li><a href="#ref-for-case-sensitive⑧">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-case-sensitive⑨">(2)</a> <a href="#ref-for-case-sensitive①⓪">(3)</a> <a href="#ref-for-case-sensitive①①">(4)</a> <a href="#ref-for-case-sensitive①②">(5)</a> <a href="#ref-for-case-sensitive①③">(6)</a> <a href="#ref-for-case-sensitive①④">(7)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cors-same-origin">
   <a href="https://html.spec.whatwg.org/multipage/urls-and-fetching.html#cors-same-origin">https://html.spec.whatwg.org/multipage/urls-and-fetching.html#cors-same-origin</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cors-same-origin">6.3.1. Fetching CSS style sheets</a>
    <li><a href="#ref-for-cors-same-origin①">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
    <li><a href="#ref-for-cors-same-origin②">6.3.5. Requirements on User Agents Implementing the HTTP Link Header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-current-global-object">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#current-global-object">https://html.spec.whatwg.org/multipage/webappapis.html#current-global-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-current-global-object">8.1. The CSS.escape() Method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-origin">
   <a href="https://html.spec.whatwg.org/multipage/origin.html#concept-origin">https://html.spec.whatwg.org/multipage/origin.html#concept-origin</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-origin">6.3.1. Fetching CSS style sheets</a>
    <li><a href="#ref-for-concept-origin①">6.3.5. Requirements on User Agents Implementing the HTTP Link Header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-the-style-element">
   <a href="https://html.spec.whatwg.org/multipage/semantics.html#the-style-element">https://html.spec.whatwg.org/multipage/semantics.html#the-style-element</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-the-style-element">6.3.2. The LinkStyle Interface</a> <a href="#ref-for-the-style-element①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ascii-lowercase">
   <a href="https://infra.spec.whatwg.org/#ascii-lowercase">https://infra.spec.whatwg.org/#ascii-lowercase</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ascii-lowercase">4.2. Serializing Media Queries</a> <a href="#ref-for-ascii-lowercase①">(2)</a>
    <li><a href="#ref-for-ascii-lowercase②">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-ascii-lowercase③">(2)</a> <a href="#ref-for-ascii-lowercase④">(3)</a> <a href="#ref-for-ascii-lowercase⑤">(4)</a> <a href="#ref-for-ascii-lowercase⑥">(5)</a>
    <li><a href="#ref-for-ascii-lowercase⑦">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ascii-uppercase">
   <a href="https://infra.spec.whatwg.org/#ascii-uppercase">https://infra.spec.whatwg.org/#ascii-uppercase</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ascii-uppercase">6.6.1. The CSSStyleDeclaration Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-iteration-break">
   <a href="https://infra.spec.whatwg.org/#iteration-break">https://infra.spec.whatwg.org/#iteration-break</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-iteration-break">6.6.1. The CSSStyleDeclaration Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-code-unit">
   <a href="https://infra.spec.whatwg.org/#code-unit">https://infra.spec.whatwg.org/#code-unit</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-code-unit">3. CSSOMString</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-iteration-continue">
   <a href="https://infra.spec.whatwg.org/#iteration-continue">https://infra.spec.whatwg.org/#iteration-continue</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-iteration-continue">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-iteration-continue①">(2)</a> <a href="#ref-for-iteration-continue②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-iterate">
   <a href="https://infra.spec.whatwg.org/#list-iterate">https://infra.spec.whatwg.org/#list-iterate</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-iterate">6.6.1. The CSSStyleDeclaration Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list">
   <a href="https://infra.spec.whatwg.org/#list">https://infra.spec.whatwg.org/#list</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list">6.7.2. Serializing CSS Values</a> <a href="#ref-for-list①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-surrogate">
   <a href="https://infra.spec.whatwg.org/#surrogate">https://infra.spec.whatwg.org/#surrogate</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-surrogate">3. CSSOMString</a> <a href="#ref-for-surrogate①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-typedef-ratio">
   <a href="https://drafts.csswg.org/mediaqueries-4/#typedef-ratio">https://drafts.csswg.org/mediaqueries-4/#typedef-ratio</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-ratio">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-media-aspect-ratio">
   <a href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-aspect-ratio">https://drafts.csswg.org/mediaqueries-4/#descdef-media-aspect-ratio</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-media-aspect-ratio">4.2.1. Serializing Media Feature Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-media-color-index">
   <a href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-color-index">https://drafts.csswg.org/mediaqueries-4/#descdef-media-color-index</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-media-color-index">4.2.1. Serializing Media Feature Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-media-device-aspect-ratio">
   <a href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-device-aspect-ratio">https://drafts.csswg.org/mediaqueries-4/#descdef-media-device-aspect-ratio</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-media-device-aspect-ratio">4.2.1. Serializing Media Feature Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-media-device-height">
   <a href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-device-height">https://drafts.csswg.org/mediaqueries-4/#descdef-media-device-height</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-media-device-height">4.2.1. Serializing Media Feature Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-media-device-width">
   <a href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-device-width">https://drafts.csswg.org/mediaqueries-4/#descdef-media-device-width</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-media-device-width">4.2.1. Serializing Media Feature Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-media-grid">
   <a href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-grid">https://drafts.csswg.org/mediaqueries-4/#descdef-media-grid</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-media-grid">4.2.1. Serializing Media Feature Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-media-scan-interlace">
   <a href="https://drafts.csswg.org/mediaqueries-4/#valdef-media-scan-interlace">https://drafts.csswg.org/mediaqueries-4/#valdef-media-scan-interlace</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-media-scan-interlace">4.2.1. Serializing Media Feature Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-media-orientation-landscape">
   <a href="https://drafts.csswg.org/mediaqueries-4/#valdef-media-orientation-landscape">https://drafts.csswg.org/mediaqueries-4/#valdef-media-orientation-landscape</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-media-orientation-landscape">4.2.1. Serializing Media Feature Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-media-feature">
   <a href="https://drafts.csswg.org/mediaqueries-4/#media-feature">https://drafts.csswg.org/mediaqueries-4/#media-feature</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-media-feature">4.2. Serializing Media Queries</a> <a href="#ref-for-media-feature①">(2)</a> <a href="#ref-for-media-feature②">(3)</a> <a href="#ref-for-media-feature③">(4)</a> <a href="#ref-for-media-feature④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-media-query">
   <a href="https://drafts.csswg.org/mediaqueries-4/#media-query">https://drafts.csswg.org/mediaqueries-4/#media-query</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-media-query">4. Media Queries</a> <a href="#ref-for-media-query①">(2)</a>
    <li><a href="#ref-for-media-query②">4.2. Serializing Media Queries</a> <a href="#ref-for-media-query③">(2)</a> <a href="#ref-for-media-query④">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-media-query-list">
   <a href="https://drafts.csswg.org/mediaqueries-4/#media-query-list">https://drafts.csswg.org/mediaqueries-4/#media-query-list</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-media-query-list">4.1. Parsing Media Queries</a>
    <li><a href="#ref-for-media-query-list①">4.2. Serializing Media Queries</a> <a href="#ref-for-media-query-list②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-media-type">
   <a href="https://drafts.csswg.org/mediaqueries-4/#media-type">https://drafts.csswg.org/mediaqueries-4/#media-type</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-media-type">4.2. Serializing Media Queries</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-media-monochrome">
   <a href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-monochrome">https://drafts.csswg.org/mediaqueries-4/#descdef-media-monochrome</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-media-monochrome">4.2.1. Serializing Media Feature Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-media-orientation">
   <a href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-orientation">https://drafts.csswg.org/mediaqueries-4/#descdef-media-orientation</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-media-orientation">4.2.1. Serializing Media Feature Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-media-orientation-portrait">
   <a href="https://drafts.csswg.org/mediaqueries-4/#valdef-media-orientation-portrait">https://drafts.csswg.org/mediaqueries-4/#valdef-media-orientation-portrait</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-media-orientation-portrait">4.2.1. Serializing Media Feature Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-media-scan-progressive">
   <a href="https://drafts.csswg.org/mediaqueries-4/#valdef-media-scan-progressive">https://drafts.csswg.org/mediaqueries-4/#valdef-media-scan-progressive</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-media-scan-progressive">4.2.1. Serializing Media Feature Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-media-resolution">
   <a href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-resolution">https://drafts.csswg.org/mediaqueries-4/#descdef-media-resolution</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-media-resolution">4.2.1. Serializing Media Feature Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-media-scan">
   <a href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-scan">https://drafts.csswg.org/mediaqueries-4/#descdef-media-scan</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-media-scan">4.2.1. Serializing Media Feature Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-sel-after">
   <a href="https://drafts.csswg.org/selectors-3/#sel-after">https://drafts.csswg.org/selectors-3/#sel-after</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-sel-after">2. Terminology</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-sel-before">
   <a href="https://drafts.csswg.org/selectors-3/#sel-before">https://drafts.csswg.org/selectors-3/#sel-before</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-sel-before">2. Terminology</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-typedef-pseudo-element-selector">
   <a href="https://drafts.csswg.org/selectors-4/#typedef-pseudo-element-selector">https://drafts.csswg.org/selectors-4/#typedef-pseudo-element-selector</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-pseudo-element-selector">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-compound">
   <a href="https://drafts.csswg.org/selectors-4/#compound">https://drafts.csswg.org/selectors-4/#compound</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-compound">5.2. Serializing Selectors</a> <a href="#ref-for-compound①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-simple">
   <a href="https://drafts.csswg.org/selectors-4/#simple">https://drafts.csswg.org/selectors-4/#simple</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-simple">5.2. Serializing Selectors</a> <a href="#ref-for-simple①">(2)</a> <a href="#ref-for-simple②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-universal-selector">
   <a href="https://drafts.csswg.org/selectors-4/#universal-selector">https://drafts.csswg.org/selectors-4/#universal-selector</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-universal-selector">5.2. Serializing Selectors</a> <a href="#ref-for-universal-selector①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-InterfaceSVGElement">
   <a href="https://svgwg.org/svg2-draft/types.html#InterfaceSVGElement">https://svgwg.org/svg2-draft/types.html#InterfaceSVGElement</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-InterfaceSVGElement">7.1. 
The ElementCSSInlineStyle Mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-absolute-url-string">
   <a href="https://url.spec.whatwg.org/#absolute-url-string">https://url.spec.whatwg.org/#absolute-url-string</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-absolute-url-string">6.1. CSS Style Sheets</a>
    <li><a href="#ref-for-absolute-url-string①">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-DOMString">
   <a href="https://heycam.github.io/webidl/#idl-DOMString">https://heycam.github.io/webidl/#idl-DOMString</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-DOMString">3. CSSOMString</a> <a href="#ref-for-idl-DOMString①">(2)</a>
    <li><a href="#ref-for-idl-DOMString②">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-idl-DOMString③">6.1.2.1. Deprecated CSSStyleSheet members</a> <a href="#ref-for-idl-DOMString④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-Exposed">
   <a href="https://heycam.github.io/webidl/#Exposed">https://heycam.github.io/webidl/#Exposed</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Exposed">4.4. The MediaList Interface</a>
    <li><a href="#ref-for-Exposed①">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-Exposed②">6.1.2. The CSSStyleSheet Interface</a>
    <li><a href="#ref-for-Exposed③">6.2.2. The StyleSheetList Interface</a>
    <li><a href="#ref-for-Exposed④">6.4.1. The CSSRuleList Interface</a>
    <li><a href="#ref-for-Exposed⑤">6.4.2. The CSSRule Interface</a>
    <li><a href="#ref-for-Exposed⑥">6.4.3. The CSSStyleRule Interface</a>
    <li><a href="#ref-for-Exposed⑦">6.4.4. The CSSImportRule Interface</a>
    <li><a href="#ref-for-Exposed⑧">6.4.5. The CSSGroupingRule Interface</a>
    <li><a href="#ref-for-Exposed⑨">6.4.7. The CSSPageRule Interface</a>
    <li><a href="#ref-for-Exposed①⓪">6.4.8. The CSSMarginRule Interface</a>
    <li><a href="#ref-for-Exposed①①">6.4.9. The CSSNamespaceRule Interface</a>
    <li><a href="#ref-for-Exposed①②">6.6.1. The CSSStyleDeclaration Interface</a>
    <li><a href="#ref-for-Exposed①③">8.1. The CSS.escape() Method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-hierarchyrequesterror">
   <a href="https://heycam.github.io/webidl/#hierarchyrequesterror">https://heycam.github.io/webidl/#hierarchyrequesterror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-hierarchyrequesterror">6.4. CSS Rules</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-indexsizeerror">
   <a href="https://heycam.github.io/webidl/#indexsizeerror">https://heycam.github.io/webidl/#indexsizeerror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-indexsizeerror">6.4. CSS Rules</a> <a href="#ref-for-indexsizeerror①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-invalidstateerror">
   <a href="https://heycam.github.io/webidl/#invalidstateerror">https://heycam.github.io/webidl/#invalidstateerror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-invalidstateerror">6.4. CSS Rules</a> <a href="#ref-for-invalidstateerror①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-NewObject">
   <a href="https://heycam.github.io/webidl/#NewObject">https://heycam.github.io/webidl/#NewObject</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-NewObject">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-nomodificationallowederror">
   <a href="https://heycam.github.io/webidl/#nomodificationallowederror">https://heycam.github.io/webidl/#nomodificationallowederror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-nomodificationallowederror">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-nomodificationallowederror①">(2)</a> <a href="#ref-for-nomodificationallowederror②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-notfounderror">
   <a href="https://heycam.github.io/webidl/#notfounderror">https://heycam.github.io/webidl/#notfounderror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-notfounderror">4.4. The MediaList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-PutForwards">
   <a href="https://heycam.github.io/webidl/#PutForwards">https://heycam.github.io/webidl/#PutForwards</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-PutForwards">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-PutForwards①">6.4.3. The CSSStyleRule Interface</a>
    <li><a href="#ref-for-PutForwards②">6.4.4. The CSSImportRule Interface</a>
    <li><a href="#ref-for-PutForwards③">6.4.7. The CSSPageRule Interface</a>
    <li><a href="#ref-for-PutForwards④">6.4.8. The CSSMarginRule Interface</a>
    <li><a href="#ref-for-PutForwards⑤">7.1. 
The ElementCSSInlineStyle Mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-SameObject">
   <a href="https://heycam.github.io/webidl/#SameObject">https://heycam.github.io/webidl/#SameObject</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-SameObject">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-SameObject①">6.1.2. The CSSStyleSheet Interface</a>
    <li><a href="#ref-for-SameObject②">6.1.2.1. Deprecated CSSStyleSheet members</a>
    <li><a href="#ref-for-SameObject③">6.2.3. Extensions to the DocumentOrShadowRoot Interface Mixin</a>
    <li><a href="#ref-for-SameObject④">6.4.3. The CSSStyleRule Interface</a>
    <li><a href="#ref-for-SameObject⑤">6.4.4. The CSSImportRule Interface</a> <a href="#ref-for-SameObject⑥">(2)</a>
    <li><a href="#ref-for-SameObject⑦">6.4.5. The CSSGroupingRule Interface</a>
    <li><a href="#ref-for-SameObject⑧">6.4.7. The CSSPageRule Interface</a>
    <li><a href="#ref-for-SameObject⑨">6.4.8. The CSSMarginRule Interface</a>
    <li><a href="#ref-for-SameObject①⓪">7.1. 
The ElementCSSInlineStyle Mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-securityerror">
   <a href="https://heycam.github.io/webidl/#securityerror">https://heycam.github.io/webidl/#securityerror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-securityerror">6.1.2. The CSSStyleSheet Interface</a> <a href="#ref-for-securityerror①">(2)</a> <a href="#ref-for-securityerror②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-syntaxerror">
   <a href="https://heycam.github.io/webidl/#syntaxerror">https://heycam.github.io/webidl/#syntaxerror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-syntaxerror">6.4. CSS Rules</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-TreatNullAs">
   <a href="https://heycam.github.io/webidl/#TreatNullAs">https://heycam.github.io/webidl/#TreatNullAs</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-TreatNullAs">4.4. The MediaList Interface</a>
    <li><a href="#ref-for-TreatNullAs①">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-TreatNullAs②">(2)</a> <a href="#ref-for-TreatNullAs③">(3)</a> <a href="#ref-for-TreatNullAs④">(4)</a> <a href="#ref-for-TreatNullAs⑤">(5)</a> <a href="#ref-for-TreatNullAs⑥">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-exceptiondef-typeerror">
   <a href="https://heycam.github.io/webidl/#exceptiondef-typeerror">https://heycam.github.io/webidl/#exceptiondef-typeerror</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-exceptiondef-typeerror">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-USVString">
   <a href="https://heycam.github.io/webidl/#idl-USVString">https://heycam.github.io/webidl/#idl-USVString</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-USVString">3. CSSOMString</a> <a href="#ref-for-idl-USVString①">(2)</a> <a href="#ref-for-idl-USVString②">(3)</a>
    <li><a href="#ref-for-idl-USVString③">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-idl-USVString④">6.4.4. The CSSImportRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-boolean">
   <a href="https://heycam.github.io/webidl/#idl-boolean">https://heycam.github.io/webidl/#idl-boolean</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-boolean">6.1.1. The StyleSheet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-unsigned-long">
   <a href="https://heycam.github.io/webidl/#idl-unsigned-long">https://heycam.github.io/webidl/#idl-unsigned-long</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-unsigned-long">4.4. The MediaList Interface</a> <a href="#ref-for-idl-unsigned-long①">(2)</a>
    <li><a href="#ref-for-idl-unsigned-long②">6.1.2. The CSSStyleSheet Interface</a> <a href="#ref-for-idl-unsigned-long③">(2)</a> <a href="#ref-for-idl-unsigned-long④">(3)</a>
    <li><a href="#ref-for-idl-unsigned-long⑤">6.1.2.1. Deprecated CSSStyleSheet members</a> <a href="#ref-for-idl-unsigned-long⑥">(2)</a>
    <li><a href="#ref-for-idl-unsigned-long⑦">6.2.2. The StyleSheetList Interface</a> <a href="#ref-for-idl-unsigned-long⑧">(2)</a>
    <li><a href="#ref-for-idl-unsigned-long⑨">6.4.1. The CSSRuleList Interface</a> <a href="#ref-for-idl-unsigned-long①⓪">(2)</a>
    <li><a href="#ref-for-idl-unsigned-long①①">6.4.5. The CSSGroupingRule Interface</a> <a href="#ref-for-idl-unsigned-long①②">(2)</a> <a href="#ref-for-idl-unsigned-long①③">(3)</a>
    <li><a href="#ref-for-idl-unsigned-long①④">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-idl-unsigned-long①⑤">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-unsigned-short">
   <a href="https://heycam.github.io/webidl/#idl-unsigned-short">https://heycam.github.io/webidl/#idl-unsigned-short</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-unsigned-short">6.4.2. The CSSRule Interface</a> <a href="#ref-for-idl-unsigned-short①">(2)</a> <a href="#ref-for-idl-unsigned-short②">(3)</a> <a href="#ref-for-idl-unsigned-short③">(4)</a> <a href="#ref-for-idl-unsigned-short④">(5)</a> <a href="#ref-for-idl-unsigned-short⑤">(6)</a> <a href="#ref-for-idl-unsigned-short⑥">(7)</a> <a href="#ref-for-idl-unsigned-short⑦">(8)</a> <a href="#ref-for-idl-unsigned-short⑧">(9)</a>
   </ul>
  </aside>
  <h3 class="no-num no-ref heading settled" id="index-defined-elsewhere"><span class="content">Terms defined by reference</span><a class="self-link" href="#index-defined-elsewhere"></a></h3>
  <ul class="index">
   <li>
    <a data-link-type="biblio">[css-animations-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-csskeyframerule" style="color:initial">CSSKeyframeRule</span>
     <li><span class="dfn-paneled" id="term-for-csskeyframesrule" style="color:initial">CSSKeyframesRule</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-backgrounds-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-background-color" style="color:initial">background-color</span>
     <li><span class="dfn-paneled" id="term-for-propdef-border-bottom-color" style="color:initial">border-bottom-color</span>
     <li><span class="dfn-paneled" id="term-for-propdef-border-left-color" style="color:initial">border-left-color</span>
     <li><span class="dfn-paneled" id="term-for-propdef-border-right-color" style="color:initial">border-right-color</span>
     <li><span class="dfn-paneled" id="term-for-propdef-border-top-color" style="color:initial">border-top-color</span>
     <li><span class="dfn-paneled" id="term-for-propdef-box-shadow" style="color:initial">box-shadow</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-box-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-margin-bottom" style="color:initial">margin-bottom</span>
     <li><span class="dfn-paneled" id="term-for-propdef-margin-left" style="color:initial">margin-left</span>
     <li><span class="dfn-paneled" id="term-for-propdef-margin-right" style="color:initial">margin-right</span>
     <li><span class="dfn-paneled" id="term-for-propdef-margin-top" style="color:initial">margin-top</span>
     <li><span class="dfn-paneled" id="term-for-propdef-padding-bottom" style="color:initial">padding-bottom</span>
     <li><span class="dfn-paneled" id="term-for-propdef-padding-left" style="color:initial">padding-left</span>
     <li><span class="dfn-paneled" id="term-for-propdef-padding-right" style="color:initial">padding-right</span>
     <li><span class="dfn-paneled" id="term-for-propdef-padding-top" style="color:initial">padding-top</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-cascade-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-computed-value" style="color:initial">computed value</span>
     <li><span class="dfn-paneled" id="term-for-used-value" style="color:initial">used value</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-color-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-alphavalue-def" style="color:initial">&lt;alphavalue></span>
     <li><span class="dfn-paneled" id="term-for-valuea-def-color" style="color:initial">&lt;color></span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-color-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-color" style="color:initial">color</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-counter-styles-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-csscounterstylerule" style="color:initial">CSSCounterStyleRule</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-device-adapt-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-cssviewportrule" style="color:initial">CSSViewportRule</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-display-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-valdef-display-contents" style="color:initial">contents</span>
     <li><span class="dfn-paneled" id="term-for-propdef-display" style="color:initial">display</span>
     <li><span class="dfn-paneled" id="term-for-valdef-display-none" style="color:initial">none</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-fonts-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-font-size" style="color:initial">font-size</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-fonts-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-family-name-value" style="color:initial">&lt;family-name></span>
     <li><span class="dfn-paneled" id="term-for-cssfontfacerule" style="color:initial">CSSFontFaceRule</span>
     <li><span class="dfn-paneled" id="term-for-cssfontfeaturevaluesrule①" style="color:initial">CSSFontFeatureValuesRule</span>
     <li><span class="dfn-paneled" id="term-for-descdef-font-face-font-feature-settings" style="color:initial">font-feature-settings</span>
     <li><span class="dfn-paneled" id="term-for-descdef-font-face-font-stretch" style="color:initial">font-stretch</span>
     <li><span class="dfn-paneled" id="term-for-descdef-font-face-font-style" style="color:initial">font-style</span>
     <li><span class="dfn-paneled" id="term-for-descdef-font-face-font-weight" style="color:initial">font-weight</span>
     <li><span class="dfn-paneled" id="term-for-descdef-font-face-unicode-range" style="color:initial">unicode-range</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-lists-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-typedef-counter" style="color:initial">&lt;counter></span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-logical-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-block-size" style="color:initial">block-size</span>
     <li><span class="dfn-paneled" id="term-for-propdef-border-block-end-color" style="color:initial">border-block-end-color</span>
     <li><span class="dfn-paneled" id="term-for-propdef-border-block-start-color" style="color:initial">border-block-start-color</span>
     <li><span class="dfn-paneled" id="term-for-propdef-border-inline-end-color" style="color:initial">border-inline-end-color</span>
     <li><span class="dfn-paneled" id="term-for-propdef-border-inline-start-color" style="color:initial">border-inline-start-color</span>
     <li><span class="dfn-paneled" id="term-for-propdef-inline-size" style="color:initial">inline-size</span>
     <li><span class="dfn-paneled" id="term-for-propdef-inset-block-end" style="color:initial">inset-block-end</span>
     <li><span class="dfn-paneled" id="term-for-propdef-inset-block-start" style="color:initial">inset-block-start</span>
     <li><span class="dfn-paneled" id="term-for-propdef-inset-inline-end" style="color:initial">inset-inline-end</span>
     <li><span class="dfn-paneled" id="term-for-propdef-inset-inline-start" style="color:initial">inset-inline-start</span>
     <li><span class="dfn-paneled" id="term-for-logical-property-group" style="color:initial">logical property group</span>
     <li><span class="dfn-paneled" id="term-for-mapping-logic" style="color:initial">mapping logic</span>
     <li><span class="dfn-paneled" id="term-for-propdef-margin-block-end" style="color:initial">margin-block-end</span>
     <li><span class="dfn-paneled" id="term-for-propdef-margin-block-start" style="color:initial">margin-block-start</span>
     <li><span class="dfn-paneled" id="term-for-propdef-margin-inline-end" style="color:initial">margin-inline-end</span>
     <li><span class="dfn-paneled" id="term-for-propdef-margin-inline-start" style="color:initial">margin-inline-start</span>
     <li><span class="dfn-paneled" id="term-for-propdef-padding-block-end" style="color:initial">padding-block-end</span>
     <li><span class="dfn-paneled" id="term-for-propdef-padding-block-start" style="color:initial">padding-block-start</span>
     <li><span class="dfn-paneled" id="term-for-propdef-padding-inline-end" style="color:initial">padding-inline-end</span>
     <li><span class="dfn-paneled" id="term-for-propdef-padding-inline-start" style="color:initial">padding-inline-start</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-namespaces-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-default-namespace" style="color:initial">default namespace</span>
     <li><span class="dfn-paneled" id="term-for-namespace-prefix" style="color:initial">namespace prefix</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-overflow-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-overflow" style="color:initial">overflow</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-position-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-bottom" style="color:initial">bottom</span>
     <li><span class="dfn-paneled" id="term-for-propdef-left" style="color:initial">left</span>
     <li><span class="dfn-paneled" id="term-for-propdef-right" style="color:initial">right</span>
     <li><span class="dfn-paneled" id="term-for-propdef-top" style="color:initial">top</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-scoping-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-selectordef-slotted" style="color:initial">::slotted()</span>
     <li><span class="dfn-paneled" id="term-for-flat-tree" style="color:initial">flat tree</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-shadow-parts-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-selectordef-part" style="color:initial">::part()</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-ui-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-caret-color" style="color:initial">caret-color</span>
     <li><span class="dfn-paneled" id="term-for-propdef-outline-color" style="color:initial">outline-color</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-values-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-angle-value" style="color:initial">&lt;angle></span>
     <li><span class="dfn-paneled" id="term-for-integer-value" style="color:initial">&lt;integer></span>
     <li><span class="dfn-paneled" id="term-for-length-value" style="color:initial">&lt;length></span>
     <li><span class="dfn-paneled" id="term-for-number-value" style="color:initial">&lt;number></span>
     <li><span class="dfn-paneled" id="term-for-percentage-value" style="color:initial">&lt;percentage></span>
     <li><span class="dfn-paneled" id="term-for-resolution-value" style="color:initial">&lt;resolution></span>
     <li><span class="dfn-paneled" id="term-for-string-value" style="color:initial">&lt;string></span>
     <li><span class="dfn-paneled" id="term-for-url-value" style="color:initial">&lt;url></span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-values-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-frequency-value" style="color:initial">&lt;frequency></span>
     <li><span class="dfn-paneled" id="term-for-time-value" style="color:initial">&lt;time></span>
     <li><span class="dfn-paneled" id="term-for-px" style="color:initial">px</span>
     <li><span class="dfn-paneled" id="term-for-comb-any" style="color:initial">||</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-variables-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-custom-property" style="color:initial">custom property</span>
     <li><span class="dfn-paneled" id="term-for-guaranteed-invalid-value" style="color:initial">guaranteed-invalid value</span>
    </ul>
   <li>
    <a data-link-type="biblio">[CSS21]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-value-def-identifier" style="color:initial">&lt;identifier></span>
     <li><span class="dfn-paneled" id="term-for-value-def-shape" style="color:initial">&lt;shape></span>
     <li><span class="dfn-paneled" id="term-for-value-def-specific-voice" style="color:initial">&lt;specific-voice></span>
     <li><span class="dfn-paneled" id="term-for-propdef-height" style="color:initial">height</span>
     <li><span class="dfn-paneled" id="term-for-propdef-line-height" style="color:initial">line-height</span>
     <li><span class="dfn-paneled" id="term-for-propdef-width" style="color:initial">width</span>
    </ul>
   <li>
    <a data-link-type="biblio">[CSS3-CONDITIONAL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-cssmediarule" style="color:initial">CSSMediaRule</span>
     <li><span class="dfn-paneled" id="term-for-csssupportsrule" style="color:initial">CSSSupportsRule</span>
    </ul>
   <li>
    <a data-link-type="biblio">[CSS3SYN]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-typedef-whitespace-token" style="color:initial">&lt;whitespace-token></span>
     <li><span class="dfn-paneled" id="term-for-environment-encoding" style="color:initial">environment encoding</span>
     <li><span class="dfn-paneled" id="term-for-css-parse-something-according-to-a-css-grammar" style="color:initial">parse</span>
     <li><span class="dfn-paneled" id="term-for-parse-a-list-of-component-values" style="color:initial">parse a list of component values</span>
     <li><span class="dfn-paneled" id="term-for-parse-a-list-of-declarations" style="color:initial">parse a list of declarations</span>
     <li><span class="dfn-paneled" id="term-for-parse-a-rule" style="color:initial">parse a rule</span>
     <li><span class="dfn-paneled" id="term-for-serialize-an-anb-value" style="color:initial">serialize an &lt;an+b> value</span>
    </ul>
   <li>
    <a data-link-type="biblio">[DOM]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-document" style="color:initial">Document</span>
     <li><span class="dfn-paneled" id="term-for-documentorshadowroot" style="color:initial">DocumentOrShadowRoot</span>
     <li><span class="dfn-paneled" id="term-for-element" style="color:initial">Element</span>
     <li><span class="dfn-paneled" id="term-for-processinginstruction" style="color:initial">ProcessingInstruction</span>
     <li><span class="dfn-paneled" id="term-for-concept-element-attributes-change-ext" style="color:initial">attribute change steps</span>
     <li><span class="dfn-paneled" id="term-for-connected" style="color:initial">connected</span>
     <li><span class="dfn-paneled" id="term-for-context-object" style="color:initial">context object</span>
     <li><span class="dfn-paneled" id="term-for-concept-cd-data" style="color:initial">data</span>
     <li><span class="dfn-paneled" id="term-for-concept-document" style="color:initial">document</span>
     <li><span class="dfn-paneled" id="term-for-concept-document-encoding" style="color:initial">encoding</span>
     <li><span class="dfn-paneled" id="term-for-concept-tree-following" style="color:initial">following</span>
     <li><span class="dfn-paneled" id="term-for-concept-element-attributes-get-by-namespace" style="color:initial">get an attribute by namespace and local name</span>
     <li><span class="dfn-paneled" id="term-for-in-a-document-tree" style="color:initial">in a document tree</span>
     <li><span class="dfn-paneled" id="term-for-boundary-point-node" style="color:initial">node</span>
     <li><span class="dfn-paneled" id="term-for-concept-node" style="color:initial">nodes</span>
     <li><span class="dfn-paneled" id="term-for-concept-element-attributes-set-value" style="color:initial">set an attribute value</span>
     <li><span class="dfn-paneled" id="term-for-concept-shadow-including-root" style="color:initial">shadow-including root</span>
    </ul>
   <li>
    <a data-link-type="biblio">[ENCODING]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-concept-encoding-get" style="color:initial">get an encoding</span>
    </ul>
   <li>
    <a data-link-type="biblio">[HTML]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-cereactions" style="color:initial">CEReactions</span>
     <li><span class="dfn-paneled" id="term-for-htmlelement" style="color:initial">HTMLElement</span>
     <li><span class="dfn-paneled" id="term-for-window" style="color:initial">Window</span>
     <li><span class="dfn-paneled" id="term-for-ascii-case-insensitive" style="color:initial">ascii case-insensitive</span>
     <li><span class="dfn-paneled" id="term-for-concept-document-window" style="color:initial">associated document</span>
     <li><span class="dfn-paneled" id="term-for-browsing-context-container" style="color:initial">browsing context container</span>
     <li><span class="dfn-paneled" id="term-for-case-sensitive" style="color:initial">case-sensitive</span>
     <li><span class="dfn-paneled" id="term-for-cors-same-origin" style="color:initial">cors-same-origin</span>
     <li><span class="dfn-paneled" id="term-for-current-global-object" style="color:initial">current global object</span>
     <li><span class="dfn-paneled" id="term-for-concept-origin" style="color:initial">origin</span>
     <li><span class="dfn-paneled" id="term-for-the-style-element" style="color:initial">style</span>
    </ul>
   <li>
    <a data-link-type="biblio">[INFRA]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-ascii-lowercase" style="color:initial">ascii lowercase</span>
     <li><span class="dfn-paneled" id="term-for-ascii-uppercase" style="color:initial">ascii uppercase</span>
     <li><span class="dfn-paneled" id="term-for-iteration-break" style="color:initial">break</span>
     <li><span class="dfn-paneled" id="term-for-code-unit" style="color:initial">code unit</span>
     <li><span class="dfn-paneled" id="term-for-iteration-continue" style="color:initial">continue</span>
     <li><span class="dfn-paneled" id="term-for-list-iterate" style="color:initial">for each</span>
     <li><span class="dfn-paneled" id="term-for-list" style="color:initial">list</span>
     <li><span class="dfn-paneled" id="term-for-surrogate" style="color:initial">surrogate</span>
    </ul>
   <li>
    <a data-link-type="biblio">[MEDIAQUERIES]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-typedef-ratio" style="color:initial">&lt;ratio></span>
     <li><span class="dfn-paneled" id="term-for-descdef-media-aspect-ratio" style="color:initial">aspect-ratio</span>
     <li><span class="dfn-paneled" id="term-for-descdef-media-color-index" style="color:initial">color-index</span>
     <li><span class="dfn-paneled" id="term-for-descdef-media-device-aspect-ratio" style="color:initial">device-aspect-ratio</span>
     <li><span class="dfn-paneled" id="term-for-descdef-media-device-height" style="color:initial">device-height</span>
     <li><span class="dfn-paneled" id="term-for-descdef-media-device-width" style="color:initial">device-width</span>
     <li><span class="dfn-paneled" id="term-for-descdef-media-grid" style="color:initial">grid</span>
     <li><span class="dfn-paneled" id="term-for-valdef-media-scan-interlace" style="color:initial">interlace</span>
     <li><span class="dfn-paneled" id="term-for-valdef-media-orientation-landscape" style="color:initial">landscape</span>
     <li><span class="dfn-paneled" id="term-for-media-feature" style="color:initial">media feature</span>
     <li><span class="dfn-paneled" id="term-for-media-query" style="color:initial">media query</span>
     <li><span class="dfn-paneled" id="term-for-media-query-list" style="color:initial">media query list</span>
     <li><span class="dfn-paneled" id="term-for-media-type" style="color:initial">media type</span>
     <li><span class="dfn-paneled" id="term-for-descdef-media-monochrome" style="color:initial">monochrome</span>
     <li><span class="dfn-paneled" id="term-for-descdef-media-orientation" style="color:initial">orientation</span>
     <li><span class="dfn-paneled" id="term-for-valdef-media-orientation-portrait" style="color:initial">portrait</span>
     <li><span class="dfn-paneled" id="term-for-valdef-media-scan-progressive" style="color:initial">progressive</span>
     <li><span class="dfn-paneled" id="term-for-descdef-media-resolution" style="color:initial">resolution</span>
     <li><span class="dfn-paneled" id="term-for-descdef-media-scan" style="color:initial">scan</span>
    </ul>
   <li>
    <a data-link-type="biblio">[selectors-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-sel-after" style="color:initial">::after</span>
     <li><span class="dfn-paneled" id="term-for-sel-before" style="color:initial">::before</span>
    </ul>
   <li>
    <a data-link-type="biblio">[selectors-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-typedef-pseudo-element-selector" style="color:initial">&lt;pseudo-element-selector></span>
     <li><span class="dfn-paneled" id="term-for-compound" style="color:initial">compound selector</span>
     <li><span class="dfn-paneled" id="term-for-simple" style="color:initial">simple selector</span>
     <li><span class="dfn-paneled" id="term-for-universal-selector" style="color:initial">universal selector</span>
    </ul>
   <li>
    <a data-link-type="biblio">[SVG2]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-InterfaceSVGElement" style="color:initial">SVGElement</span>
    </ul>
   <li>
    <a data-link-type="biblio">[URL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-absolute-url-string" style="color:initial">absolute-url string</span>
    </ul>
   <li>
    <a data-link-type="biblio">[WebIDL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-idl-DOMString" style="color:initial">DOMString</span>
     <li><span class="dfn-paneled" id="term-for-Exposed" style="color:initial">Exposed</span>
     <li><span class="dfn-paneled" id="term-for-hierarchyrequesterror" style="color:initial">HierarchyRequestError</span>
     <li><span class="dfn-paneled" id="term-for-indexsizeerror" style="color:initial">IndexSizeError</span>
     <li><span class="dfn-paneled" id="term-for-invalidstateerror" style="color:initial">InvalidStateError</span>
     <li><span class="dfn-paneled" id="term-for-NewObject" style="color:initial">NewObject</span>
     <li><span class="dfn-paneled" id="term-for-nomodificationallowederror" style="color:initial">NoModificationAllowedError</span>
     <li><span class="dfn-paneled" id="term-for-notfounderror" style="color:initial">NotFoundError</span>
     <li><span class="dfn-paneled" id="term-for-PutForwards" style="color:initial">PutForwards</span>
     <li><span class="dfn-paneled" id="term-for-SameObject" style="color:initial">SameObject</span>
     <li><span class="dfn-paneled" id="term-for-securityerror" style="color:initial">SecurityError</span>
     <li><span class="dfn-paneled" id="term-for-syntaxerror" style="color:initial">SyntaxError</span>
     <li><span class="dfn-paneled" id="term-for-TreatNullAs" style="color:initial">TreatNullAs</span>
     <li><span class="dfn-paneled" id="term-for-exceptiondef-typeerror" style="color:initial">TypeError</span>
     <li><span class="dfn-paneled" id="term-for-idl-USVString" style="color:initial">USVString</span>
     <li><span class="dfn-paneled" id="term-for-idl-boolean" style="color:initial">boolean</span>
     <li><span class="dfn-paneled" id="term-for-idl-unsigned-long" style="color:initial">unsigned long</span>
     <li><span class="dfn-paneled" id="term-for-idl-unsigned-short" style="color:initial">unsigned short</span>
    </ul>
  </ul>
  <h2 class="no-num no-ref heading settled" id="references"><span class="content">References</span><a class="self-link" href="#references"></a></h2>
  <h3 class="no-num no-ref heading settled" id="normative"><span class="content">Normative References</span><a class="self-link" href="#normative"></a></h3>
  <dl>
   <dt id="biblio-css-animations-1">[CSS-ANIMATIONS-1]
   <dd>Dean Jackson; et al. <a href="https://www.w3.org/TR/css-animations-1/">CSS Animations Level 1</a>. 11 October 2018. WD. URL: <a href="https://www.w3.org/TR/css-animations-1/">https://www.w3.org/TR/css-animations-1/</a>
   <dt id="biblio-css-backgrounds-3">[CSS-BACKGROUNDS-3]
   <dd>Bert Bos; Elika Etemad; Brad Kemper. <a href="https://www.w3.org/TR/css-backgrounds-3/">CSS Backgrounds and Borders Module Level 3</a>. 17 October 2017. CR. URL: <a href="https://www.w3.org/TR/css-backgrounds-3/">https://www.w3.org/TR/css-backgrounds-3/</a>
   <dt id="biblio-css-box-3">[CSS-BOX-3]
   <dd>Elika Etemad. <a href="https://www.w3.org/TR/css-box-3/">CSS Box Model Module Level 3</a>. 18 December 2018. WD. URL: <a href="https://www.w3.org/TR/css-box-3/">https://www.w3.org/TR/css-box-3/</a>
   <dt id="biblio-css-cascade-4">[CSS-CASCADE-4]
   <dd>Elika Etemad; Tab Atkins Jr.. <a href="https://www.w3.org/TR/css-cascade-4/">CSS Cascading and Inheritance Level 4</a>. 28 August 2018. CR. URL: <a href="https://www.w3.org/TR/css-cascade-4/">https://www.w3.org/TR/css-cascade-4/</a>
   <dt id="biblio-css-color-3">[CSS-COLOR-3]
   <dd>Tantek Çelik; Chris Lilley; David Baron. <a href="https://www.w3.org/TR/css-color-3/">CSS Color Module Level 3</a>. 19 June 2018. REC. URL: <a href="https://www.w3.org/TR/css-color-3/">https://www.w3.org/TR/css-color-3/</a>
   <dt id="biblio-css-color-4">[CSS-COLOR-4]
   <dd>Tab Atkins Jr.; Chris Lilley. <a href="https://www.w3.org/TR/css-color-4/">CSS Color Module Level 4</a>. 5 November 2019. WD. URL: <a href="https://www.w3.org/TR/css-color-4/">https://www.w3.org/TR/css-color-4/</a>
   <dt id="biblio-css-counter-styles-3">[CSS-COUNTER-STYLES-3]
   <dd>Tab Atkins Jr.. <a href="https://www.w3.org/TR/css-counter-styles-3/">CSS Counter Styles Level 3</a>. 14 December 2017. CR. URL: <a href="https://www.w3.org/TR/css-counter-styles-3/">https://www.w3.org/TR/css-counter-styles-3/</a>
   <dt id="biblio-css-device-adapt-1">[CSS-DEVICE-ADAPT-1]
   <dd>Rune Lillesveen; Florian Rivoal; Matt Rakow. <a href="https://www.w3.org/TR/css-device-adapt-1/">CSS Device Adaptation Module Level 1</a>. 29 March 2016. WD. URL: <a href="https://www.w3.org/TR/css-device-adapt-1/">https://www.w3.org/TR/css-device-adapt-1/</a>
   <dt id="biblio-css-display-3">[CSS-DISPLAY-3]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-display-3/">CSS Display Module Level 3</a>. 11 July 2019. CR. URL: <a href="https://www.w3.org/TR/css-display-3/">https://www.w3.org/TR/css-display-3/</a>
   <dt id="biblio-css-fonts-4">[CSS-FONTS-4]
   <dd>John Daggett; Myles Maxfield; Chris Lilley. <a href="https://www.w3.org/TR/css-fonts-4/">CSS Fonts Module Level 4</a>. 13 November 2019. WD. URL: <a href="https://www.w3.org/TR/css-fonts-4/">https://www.w3.org/TR/css-fonts-4/</a>
   <dt id="biblio-css-lists-3">[CSS-LISTS-3]
   <dd>Elika Etemad; Tab Atkins Jr.. <a href="https://www.w3.org/TR/css-lists-3/">CSS Lists Module Level 3</a>. 17 August 2019. WD. URL: <a href="https://www.w3.org/TR/css-lists-3/">https://www.w3.org/TR/css-lists-3/</a>
   <dt id="biblio-css-logical-1">[CSS-LOGICAL-1]
   <dd>Rossen Atanassov; Elika Etemad. <a href="https://www.w3.org/TR/css-logical-1/">CSS Logical Properties and Values Level 1</a>. 27 August 2018. WD. URL: <a href="https://www.w3.org/TR/css-logical-1/">https://www.w3.org/TR/css-logical-1/</a>
   <dt id="biblio-css-namespaces-3">[CSS-NAMESPACES-3]
   <dd>Elika Etemad. <a href="https://www.w3.org/TR/css-namespaces-3/">CSS Namespaces Module Level 3</a>. 20 March 2014. REC. URL: <a href="https://www.w3.org/TR/css-namespaces-3/">https://www.w3.org/TR/css-namespaces-3/</a>
   <dt id="biblio-css-overflow-3">[CSS-OVERFLOW-3]
   <dd>David Baron; Elika Etemad; Florian Rivoal. <a href="https://www.w3.org/TR/css-overflow-3/">CSS Overflow Module Level 3</a>. 31 July 2018. WD. URL: <a href="https://www.w3.org/TR/css-overflow-3/">https://www.w3.org/TR/css-overflow-3/</a>
   <dt id="biblio-css-position-3">[CSS-POSITION-3]
   <dd>Rossen Atanassov; Arron Eicholz. <a href="https://www.w3.org/TR/css-position-3/">CSS Positioned Layout Module Level 3</a>. 17 May 2016. WD. URL: <a href="https://www.w3.org/TR/css-position-3/">https://www.w3.org/TR/css-position-3/</a>
   <dt id="biblio-css-scoping-1">[CSS-SCOPING-1]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-scoping-1/">CSS Scoping Module Level 1</a>. 3 April 2014. WD. URL: <a href="https://www.w3.org/TR/css-scoping-1/">https://www.w3.org/TR/css-scoping-1/</a>
   <dt id="biblio-css-shadow-parts-1">[CSS-SHADOW-PARTS-1]
   <dd>Tab Atkins Jr.; Fergal Daly. <a href="https://www.w3.org/TR/css-shadow-parts-1/">CSS Shadow Parts</a>. 15 November 2018. WD. URL: <a href="https://www.w3.org/TR/css-shadow-parts-1/">https://www.w3.org/TR/css-shadow-parts-1/</a>
   <dt id="biblio-css-ui-4">[CSS-UI-4]
   <dd>Florian Rivoal. <a href="https://www.w3.org/TR/css-ui-4/">CSS Basic User Interface Module Level 4</a>. 24 January 2020. WD. URL: <a href="https://www.w3.org/TR/css-ui-4/">https://www.w3.org/TR/css-ui-4/</a>
   <dt id="biblio-css-values-3">[CSS-VALUES-3]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-values-3/">CSS Values and Units Module Level 3</a>. 6 June 2019. CR. URL: <a href="https://www.w3.org/TR/css-values-3/">https://www.w3.org/TR/css-values-3/</a>
   <dt id="biblio-css-values-4">[CSS-VALUES-4]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-values-4/">CSS Values and Units Module Level 4</a>. 31 January 2019. WD. URL: <a href="https://www.w3.org/TR/css-values-4/">https://www.w3.org/TR/css-values-4/</a>
   <dt id="biblio-css-variables-1">[CSS-VARIABLES-1]
   <dd>Tab Atkins Jr.. <a href="https://www.w3.org/TR/css-variables-1/">CSS Custom Properties for Cascading Variables Module Level 1</a>. 3 December 2015. CR. URL: <a href="https://www.w3.org/TR/css-variables-1/">https://www.w3.org/TR/css-variables-1/</a>
   <dt id="biblio-css21">[CSS21]
   <dd>Bert Bos; et al. <a href="https://www.w3.org/TR/CSS2/">Cascading Style Sheets Level 2 Revision 1 (CSS 2.1) Specification</a>. 7 June 2011. REC. URL: <a href="https://www.w3.org/TR/CSS2/">https://www.w3.org/TR/CSS2/</a>
   <dt id="biblio-css3-conditional">[CSS3-CONDITIONAL]
   <dd>David Baron. <a href="https://www.w3.org/TR/css3-conditional/">CSS Conditional Rules Module Level 3</a>. 4 April 2013. CR. URL: <a href="https://www.w3.org/TR/css3-conditional/">https://www.w3.org/TR/css3-conditional/</a>
   <dt id="biblio-css3cascade">[CSS3CASCADE]
   <dd>Elika Etemad; Tab Atkins Jr.. <a href="https://www.w3.org/TR/css-cascade-3/">CSS Cascading and Inheritance Level 3</a>. 28 August 2018. CR. URL: <a href="https://www.w3.org/TR/css-cascade-3/">https://www.w3.org/TR/css-cascade-3/</a>
   <dt id="biblio-css3page">[CSS3PAGE]
   <dd>Elika Etemad; Simon Sapin. <a href="https://www.w3.org/TR/css-page-3/">CSS Paged Media Module Level 3</a>. 18 October 2018. WD. URL: <a href="https://www.w3.org/TR/css-page-3/">https://www.w3.org/TR/css-page-3/</a>
   <dt id="biblio-css3syn">[CSS3SYN]
   <dd>Tab Atkins Jr.; Simon Sapin. <a href="https://www.w3.org/TR/css-syntax-3/">CSS Syntax Module Level 3</a>. 16 July 2019. CR. URL: <a href="https://www.w3.org/TR/css-syntax-3/">https://www.w3.org/TR/css-syntax-3/</a>
   <dt id="biblio-dom">[DOM]
   <dd>Anne van Kesteren. <a href="https://dom.spec.whatwg.org/">DOM Standard</a>. Living Standard. URL: <a href="https://dom.spec.whatwg.org/">https://dom.spec.whatwg.org/</a>
   <dt id="biblio-encoding">[ENCODING]
   <dd>Anne van Kesteren. <a href="https://encoding.spec.whatwg.org/">Encoding Standard</a>. Living Standard. URL: <a href="https://encoding.spec.whatwg.org/">https://encoding.spec.whatwg.org/</a>
   <dt id="biblio-fetch">[FETCH]
   <dd>Anne van Kesteren. <a href="https://fetch.spec.whatwg.org/">Fetch Standard</a>. Living Standard. URL: <a href="https://fetch.spec.whatwg.org/">https://fetch.spec.whatwg.org/</a>
   <dt id="biblio-html">[HTML]
   <dd>Anne van Kesteren; et al. <a href="https://html.spec.whatwg.org/multipage/">HTML Standard</a>. Living Standard. URL: <a href="https://html.spec.whatwg.org/multipage/">https://html.spec.whatwg.org/multipage/</a>
   <dt id="biblio-infra">[INFRA]
   <dd>Anne van Kesteren; Domenic Denicola. <a href="https://infra.spec.whatwg.org/">Infra Standard</a>. Living Standard. URL: <a href="https://infra.spec.whatwg.org/">https://infra.spec.whatwg.org/</a>
   <dt id="biblio-mediaqueries">[MEDIAQUERIES]
   <dd>Florian Rivoal; Tab Atkins Jr.. <a href="https://www.w3.org/TR/mediaqueries-4/">Media Queries Level 4</a>. 5 September 2017. CR. URL: <a href="https://www.w3.org/TR/mediaqueries-4/">https://www.w3.org/TR/mediaqueries-4/</a>
   <dt id="biblio-rfc2119">[RFC2119]
   <dd>S. Bradner. <a href="https://tools.ietf.org/html/rfc2119">Key words for use in RFCs to Indicate Requirement Levels</a>. March 1997. Best Current Practice. URL: <a href="https://tools.ietf.org/html/rfc2119">https://tools.ietf.org/html/rfc2119</a>
   <dt id="biblio-selectors-3">[SELECTORS-3]
   <dd>Tantek Çelik; et al. <a href="https://www.w3.org/TR/selectors-3/">Selectors Level 3</a>. 6 November 2018. REC. URL: <a href="https://www.w3.org/TR/selectors-3/">https://www.w3.org/TR/selectors-3/</a>
   <dt id="biblio-selectors-4">[SELECTORS-4]
   <dd>Elika Etemad; Tab Atkins Jr.. <a href="https://www.w3.org/TR/selectors-4/">Selectors Level 4</a>. 21 November 2018. WD. URL: <a href="https://www.w3.org/TR/selectors-4/">https://www.w3.org/TR/selectors-4/</a>
   <dt id="biblio-svg2">[SVG2]
   <dd>Amelia Bellamy-Royds; et al. <a href="https://www.w3.org/TR/SVG2/">Scalable Vector Graphics (SVG) 2</a>. 4 October 2018. CR. URL: <a href="https://www.w3.org/TR/SVG2/">https://www.w3.org/TR/SVG2/</a>
   <dt id="biblio-url">[URL]
   <dd>Anne van Kesteren. <a href="https://url.spec.whatwg.org/">URL Standard</a>. Living Standard. URL: <a href="https://url.spec.whatwg.org/">https://url.spec.whatwg.org/</a>
   <dt id="biblio-webidl">[WebIDL]
   <dd>Boris Zbarsky. <a href="https://heycam.github.io/webidl/">Web IDL</a>. 15 December 2016. ED. URL: <a href="https://heycam.github.io/webidl/">https://heycam.github.io/webidl/</a>
   <dt id="biblio-xml">[XML]
   <dd>Tim Bray; et al. <a href="https://www.w3.org/TR/xml/">Extensible Markup Language (XML) 1.0 (Fifth Edition)</a>. 26 November 2008. REC. URL: <a href="https://www.w3.org/TR/xml/">https://www.w3.org/TR/xml/</a>
   <dt id="biblio-xml-stylesheet">[XML-STYLESHEET]
   <dd>James Clark; Simon Pieters; Henry Thompson. <a href="https://www.w3.org/TR/xml-stylesheet/">Associating Style Sheets with XML documents 1.0 (Second Edition)</a>. 28 October 2010. REC. URL: <a href="https://www.w3.org/TR/xml-stylesheet/">https://www.w3.org/TR/xml-stylesheet/</a>
  </dl>
  <h3 class="no-num no-ref heading settled" id="informative"><span class="content">Informative References</span><a class="self-link" href="#informative"></a></h3>
  <dl>
   <dt id="biblio-css-fonts-3">[CSS-FONTS-3]
   <dd>John Daggett; Myles Maxfield; Chris Lilley. <a href="https://www.w3.org/TR/css-fonts-3/">CSS Fonts Module Level 3</a>. 20 September 2018. REC. URL: <a href="https://www.w3.org/TR/css-fonts-3/">https://www.w3.org/TR/css-fonts-3/</a>
   <dt id="biblio-dom-level-2-style">[DOM-LEVEL-2-STYLE]
   <dd>Chris Wilson; Philippe Le Hégaret. <a href="https://www.w3.org/TR/DOM-Level-2-Style/">Document Object Model (DOM) Level 2 Style Specification</a>. 13 November 2000. REC. URL: <a href="https://www.w3.org/TR/DOM-Level-2-Style/">https://www.w3.org/TR/DOM-Level-2-Style/</a>
   <dt id="biblio-svg11">[SVG11]
   <dd>Erik Dahlström; et al. <a href="https://www.w3.org/TR/SVG11/">Scalable Vector Graphics (SVG) 1.1 (Second Edition)</a>. 16 August 2011. REC. URL: <a href="https://www.w3.org/TR/SVG11/">https://www.w3.org/TR/SVG11/</a>
  </dl>
  <h2 class="no-num no-ref heading settled" id="idl-index"><span class="content">IDL Index</span><a class="self-link" href="#idl-index"></a></h2>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#medialist"><code><c- g>MediaList</c-></code></a> {
  <a href="#MediaList-stringification-behavior"><c- b>stringifier</c-></a> <c- b>attribute</c-> [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#TreatNullAs"><c- g>TreatNullAs</c-></a>=<a class="n" data-link-type="idl-name"><c- n>EmptyString</c-></a>] <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="[TreatNullAs=EmptyString] CSSOMString" href="#dom-medialist-mediatext"><c- g>mediaText</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned long" href="#dom-medialist-length"><c- g>length</c-></a>;
  <c- b>getter</c-> <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a>? <a class="idl-code" data-link-type="method" href="#dom-medialist-item"><c- g>item</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a href="#dom-medialist-item-index-index"><code><c- g>index</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-medialist-appendmedium"><c- g>appendMedium</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-medialist-appendmedium-medium-medium"><code><c- g>medium</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-medialist-deletemedium"><c- g>deleteMedium</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-medialist-deletemedium-medium-medium"><code><c- g>medium</c-></code></a>);
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#stylesheet"><code><c- g>StyleSheet</c-></code></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#dom-stylesheet-type"><c- g>type</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString"><c- b>USVString</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString?" href="#dom-stylesheet-href"><c- g>href</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> (<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element"><c- n>Element</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#processinginstruction"><c- n>ProcessingInstruction</c-></a>)? <a class="idl-code" data-link-type="attribute" data-readonly data-type="(Element or ProcessingInstruction)?" href="#dom-stylesheet-ownernode"><c- g>ownerNode</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssstylesheet"><c- n>CSSStyleSheet</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleSheet?" href="#dom-stylesheet-parentstylesheet"><c- g>parentStyleSheet</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString"><c- b>DOMString</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="DOMString?" href="#dom-stylesheet-title"><c- g>title</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#PutForwards"><c- g>PutForwards</c-></a>=<a class="idl-code" data-link-type="attribute" href="#dom-medialist-mediatext"><c- n>mediaText</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#medialist"><c- n>MediaList</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="MediaList" href="#dom-stylesheet-media"><c- g>media</c-></a>;
  <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-type="boolean" href="#dom-stylesheet-disabled"><c- g>disabled</c-></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#cssstylesheet"><code><c- g>CSSStyleSheet</c-></code></a> : <a class="n" data-link-type="idl-name" href="#stylesheet"><c- n>StyleSheet</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssrule"><c- n>CSSRule</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSRule?" href="#dom-cssstylesheet-ownerrule"><c- g>ownerRule</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssrulelist"><c- n>CSSRuleList</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSRuleList" href="#dom-cssstylesheet-cssrules"><c- g>cssRules</c-></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="method" href="#dom-cssstylesheet-insertrule"><c- g>insertRule</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-cssstylesheet-insertrule-rule-index-rule"><code><c- g>rule</c-></code></a>, <c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a href="#dom-cssstylesheet-insertrule-rule-index-index"><code><c- g>index</c-></code></a> = 0);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-cssstylesheet-deleterule"><c- g>deleteRule</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a href="#dom-cssstylesheet-deleterule-index-index"><code><c- g>index</c-></code></a>);
};

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="#cssstylesheet"><c- g>CSSStyleSheet</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssrulelist"><c- n>CSSRuleList</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSRuleList" href="#dom-cssstylesheet-rules"><c- g>rules</c-></a>;
  <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="method" href="#dom-cssstylesheet-addrule"><c- g>addRule</c-></a>(<c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString"><c- b>DOMString</c-></a> <a href="#dom-cssstylesheet-addrule-selector-style-index-selector"><code><c- g>selector</c-></code></a> = "undefined", <c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-DOMString"><c- b>DOMString</c-></a> <a href="#dom-cssstylesheet-addrule-selector-style-index-style"><code><c- g>style</c-></code></a> = "undefined", <c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a href="#dom-cssstylesheet-addrule-selector-style-index-index"><code><c- g>index</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-cssstylesheet-removerule"><c- g>removeRule</c-></a>(<c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a href="#dom-cssstylesheet-removerule-index-index"><code><c- g>index</c-></code></a> = 0);
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#stylesheetlist"><code><c- g>StyleSheetList</c-></code></a> {
  <c- b>getter</c-> <a class="n" data-link-type="idl-name" href="#cssstylesheet"><c- n>CSSStyleSheet</c-></a>? <a class="idl-code" data-link-type="method" href="#dom-stylesheetlist-item"><c- g>item</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a href="#dom-stylesheetlist-item-index-index"><code><c- g>index</c-></code></a>);
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned long" href="#dom-stylesheetlist-length"><c- g>length</c-></a>;
};

<c- b>partial</c-> <c- b>interface</c-> <c- b>mixin</c-> <a class="idl-code" data-link-type="interface" href="https://dom.spec.whatwg.org/#documentorshadowroot"><c- g>DocumentOrShadowRoot</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#stylesheetlist"><c- n>StyleSheetList</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="StyleSheetList" href="#dom-documentorshadowroot-stylesheets"><c- g>styleSheets</c-></a>;
};

<c- b>interface</c-> <c- b>mixin</c-> <a href="#linkstyle"><code><c- g>LinkStyle</c-></code></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssstylesheet"><c- n>CSSStyleSheet</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleSheet?" href="#dom-linkstyle-sheet"><c- g>sheet</c-></a>;
};

<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#processinginstruction"><c- n>ProcessingInstruction</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#linkstyle"><c- n>LinkStyle</c-></a>;
[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#cssrulelist"><code><c- g>CSSRuleList</c-></code></a> {
  <c- b>getter</c-> <a class="n" data-link-type="idl-name" href="#cssrule"><c- n>CSSRule</c-></a>? <a class="idl-code" data-link-type="method" href="#dom-cssrulelist-item"><c- g>item</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a href="#dom-cssrulelist-item-index-index"><code><c- g>index</c-></code></a>);
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned long" href="#dom-cssrulelist-length"><c- g>length</c-></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#cssrule"><code><c- g>CSSRule</c-></code></a> {
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-cssrule-csstext"><c- g>cssText</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssrule"><c- n>CSSRule</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSRule?" href="#dom-cssrule-parentrule"><c- g>parentRule</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssstylesheet"><c- n>CSSStyleSheet</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleSheet?" href="#dom-cssrule-parentstylesheet"><c- g>parentStyleSheet</c-></a>;

  // the following attribute and constants are historical
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned short" href="#dom-cssrule-type"><c- g>type</c-></a>;
  <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a href="#dom-cssrule-style_rule"><code><c- g>STYLE_RULE</c-></code></a> = 1;
  <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a href="#dom-cssrule-charset_rule"><code><c- g>CHARSET_RULE</c-></code></a> = 2;
  <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a href="#dom-cssrule-import_rule"><code><c- g>IMPORT_RULE</c-></code></a> = 3;
  <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a href="#dom-cssrule-media_rule"><code><c- g>MEDIA_RULE</c-></code></a> = 4;
  <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a href="#dom-cssrule-font_face_rule"><code><c- g>FONT_FACE_RULE</c-></code></a> = 5;
  <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a href="#dom-cssrule-page_rule"><code><c- g>PAGE_RULE</c-></code></a> = 6;
  <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a href="#dom-cssrule-margin_rule"><code><c- g>MARGIN_RULE</c-></code></a> = 9;
  <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a href="#dom-cssrule-namespace_rule"><code><c- g>NAMESPACE_RULE</c-></code></a> = 10;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#cssstylerule"><code><c- g>CSSStyleRule</c-></code></a> : <a class="n" data-link-type="idl-name" href="#cssrule"><c- n>CSSRule</c-></a> {
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-cssstylerule-selectortext"><c- g>selectorText</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#PutForwards"><c- g>PutForwards</c-></a>=<a class="idl-code" data-link-type="attribute" href="#dom-cssstyledeclaration-csstext"><c- n>cssText</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssstyledeclaration"><c- n>CSSStyleDeclaration</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleDeclaration" href="#dom-cssstylerule-style"><c- g>style</c-></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#cssimportrule"><code><c- g>CSSImportRule</c-></code></a> : <a class="n" data-link-type="idl-name" href="#cssrule"><c- n>CSSRule</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-USVString"><c- b>USVString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="USVString" href="#dom-cssimportrule-href"><c- g>href</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#PutForwards"><c- g>PutForwards</c-></a>=<a class="idl-code" data-link-type="attribute" href="#dom-medialist-mediatext"><c- n>mediaText</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#medialist"><c- n>MediaList</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="MediaList" href="#dom-cssimportrule-media"><c- g>media</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssstylesheet"><c- n>CSSStyleSheet</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleSheet" href="#dom-cssimportrule-stylesheet"><c- g>styleSheet</c-></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#cssgroupingrule"><code><c- g>CSSGroupingRule</c-></code></a> : <a class="n" data-link-type="idl-name" href="#cssrule"><c- n>CSSRule</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssrulelist"><c- n>CSSRuleList</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSRuleList" href="#dom-cssgroupingrule-cssrules"><c- g>cssRules</c-></a>;
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="method" href="#dom-cssgroupingrule-insertrule"><c- g>insertRule</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-cssgroupingrule-insertrule-rule-index-rule"><code><c- g>rule</c-></code></a>, <c- b>optional</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a href="#dom-cssgroupingrule-insertrule-rule-index-index"><code><c- g>index</c-></code></a> = 0);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-cssgroupingrule-deleterule"><c- g>deleteRule</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a href="#dom-cssgroupingrule-deleterule-index-index"><code><c- g>index</c-></code></a>);
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#csspagerule"><code><c- g>CSSPageRule</c-></code></a> : <a class="n" data-link-type="idl-name" href="#cssgroupingrule"><c- n>CSSGroupingRule</c-></a> {
           <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a data-type="CSSOMString" href="#dom-csspagerule-selectortext"><code><c- g>selectorText</c-></code></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#PutForwards"><c- g>PutForwards</c-></a>=<a class="idl-code" data-link-type="attribute" href="#dom-cssstyledeclaration-csstext"><c- n>cssText</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssstyledeclaration"><c- n>CSSStyleDeclaration</c-></a> <a data-readonly data-type="CSSStyleDeclaration" href="#dom-csspagerule-style"><code><c- g>style</c-></code></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#cssmarginrule"><code><c- g>CSSMarginRule</c-></code></a> : <a class="n" data-link-type="idl-name" href="#cssrule"><c- n>CSSRule</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#dom-cssmarginrule-name"><c- g>name</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#PutForwards"><c- g>PutForwards</c-></a>=<a class="idl-code" data-link-type="attribute" href="#dom-cssstyledeclaration-csstext"><c- n>cssText</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssstyledeclaration"><c- n>CSSStyleDeclaration</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleDeclaration" href="#dom-cssmarginrule-style"><c- g>style</c-></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#cssnamespacerule"><code><c- g>CSSNamespaceRule</c-></code></a> : <a class="n" data-link-type="idl-name" href="#cssrule"><c- n>CSSRule</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#dom-cssnamespacerule-namespaceuri"><c- g>namespaceURI</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#dom-cssnamespacerule-prefix"><c- g>prefix</c-></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#cssstyledeclaration"><code><c- g>CSSStyleDeclaration</c-></code></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://html.spec.whatwg.org/multipage/custom-elements.html#cereactions"><c- g>CEReactions</c-></a>] <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="CSSOMString" href="#dom-cssstyledeclaration-csstext"><c- g>cssText</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned long" href="#dom-cssstyledeclaration-length"><c- g>length</c-></a>;
  <c- b>getter</c-> <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="method" href="#dom-cssstyledeclaration-item"><c- g>item</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a href="#dom-cssstyledeclaration-item-index-index"><code><c- g>index</c-></code></a>);
  <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="method" href="#dom-cssstyledeclaration-getpropertyvalue"><c- g>getPropertyValue</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-cssstyledeclaration-getpropertyvalue-property-property"><code><c- g>property</c-></code></a>);
  <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="method" href="#dom-cssstyledeclaration-getpropertypriority"><c- g>getPropertyPriority</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-cssstyledeclaration-getpropertypriority-property-property"><code><c- g>property</c-></code></a>);
  [<a class="idl-code" data-link-type="extended-attribute" href="https://html.spec.whatwg.org/multipage/custom-elements.html#cereactions"><c- g>CEReactions</c-></a>] <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-cssstyledeclaration-setproperty"><c- g>setProperty</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-cssstyledeclaration-setproperty-property-value-priority-property"><code><c- g>property</c-></code></a>, [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#TreatNullAs"><c- g>TreatNullAs</c-></a>=<a class="n" data-link-type="idl-name"><c- n>EmptyString</c-></a>] <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-cssstyledeclaration-setproperty-property-value-priority-value"><code><c- g>value</c-></code></a>, <c- b>optional</c-> [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#TreatNullAs"><c- g>TreatNullAs</c-></a>=<a class="n" data-link-type="idl-name"><c- n>EmptyString</c-></a>] <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-cssstyledeclaration-setproperty-property-value-priority-priority"><code><c- g>priority</c-></code></a> = "");
  [<a class="idl-code" data-link-type="extended-attribute" href="https://html.spec.whatwg.org/multipage/custom-elements.html#cereactions"><c- g>CEReactions</c-></a>] <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="method" href="#dom-cssstyledeclaration-removeproperty"><c- g>removeProperty</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-cssstyledeclaration-removeproperty-property-property"><code><c- g>property</c-></code></a>);
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssrule"><c- n>CSSRule</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSRule?" href="#dom-cssstyledeclaration-parentrule"><c- g>parentRule</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://html.spec.whatwg.org/multipage/custom-elements.html#cereactions"><c- g>CEReactions</c-></a>] <c- b>attribute</c-> [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#TreatNullAs"><c- g>TreatNullAs</c-></a>=<a class="n" data-link-type="idl-name"><c- n>EmptyString</c-></a>] <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-type="[TreatNullAs=EmptyString] CSSOMString" href="#dom-cssstyledeclaration-cssfloat"><c- g>cssFloat</c-></a>;
};

<c- b>interface</c-> <c- b>mixin</c-> <a href="#elementcssinlinestyle"><code><c- g>ElementCSSInlineStyle</c-></code></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#PutForwards"><c- g>PutForwards</c-></a>=<a class="idl-code" data-link-type="attribute" href="#dom-cssstyledeclaration-csstext"><c- n>cssText</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#cssstyledeclaration"><c- n>CSSStyleDeclaration</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleDeclaration" href="#dom-elementcssinlinestyle-style"><c- g>style</c-></a>;
};

<a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/dom.html#htmlelement"><c- n>HTMLElement</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#elementcssinlinestyle"><c- n>ElementCSSInlineStyle</c-></a>;

<a class="n" data-link-type="idl-name" href="https://svgwg.org/svg2-draft/types.html#InterfaceSVGElement"><c- n>SVGElement</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#elementcssinlinestyle"><c- n>ElementCSSInlineStyle</c-></a>;

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/window-object.html#window"><c- g>Window</c-></a> {
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject"><c- g>NewObject</c-></a>] <a class="n" data-link-type="idl-name" href="#cssstyledeclaration"><c- n>CSSStyleDeclaration</c-></a> <a class="idl-code" data-link-type="method" href="#dom-window-getcomputedstyle"><c- g>getComputedStyle</c-></a>(<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element"><c- n>Element</c-></a> <a href="#dom-window-getcomputedstyle-elt-pseudoelt-elt"><code><c- g>elt</c-></code></a>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a>? <a href="#dom-window-getcomputedstyle-elt-pseudoelt-pseudoelt"><code><c- g>pseudoElt</c-></code></a>);
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>namespace</c-> <a href="#namespacedef-css"><code><c- g>CSS</c-></code></a> {
  <a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="method" href="#dom-css-escape"><c- g>escape</c-></a>(<a class="n" data-link-type="idl-name" href="#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-css-escape-ident-ident"><code><c- g>ident</c-></code></a>);
};

</pre>
  <h2 class="no-num no-ref heading settled" id="issues-index"><span class="content">Issues Index</span><a class="self-link" href="#issues-index"></a></h2>
  <div style="counter-reset:issue">
   <div class="issue"> This should probably be done in terms of mapping it to
serializing CSS values as media features are defined in terms of CSS
values after all.<a href="#issue-41128eee"> ↵ </a></div>
   <div class="issue"> Be more specific<a href="#issue-d4a93110"> ↵ </a></div>
   <div class="issue"> Is there a document at this point?<a href="#issue-af048285"> ↵ </a></div>
   <div class="issue"> What if the HTML parser hasn’t decided on quirks/non-quirks yet?<a href="#issue-45012e41"> ↵ </a></div>
   <div class="issue"> Need to define how the <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/css-fonts-4/#cssfontfacerule">CSSFontFaceRule</a></code> descriptors' values are serialized.<a href="#issue-f92cf3b3"> ↵ </a></div>
   <div class="issue"> Need to define how <code class="idl"><a data-link-type="idl" href="#csspagerule">CSSPageRule</a></code> is serialized.<a href="#issue-be6dc86c"> ↵ </a></div>
   <div class="issue"> Need to define the rules for <span>parse a list of CSS page selectors</span> and <span>serialize a list of CSS page selectors</span>.<a href="#issue-ba9fab84"> ↵ </a></div>
   <div class="issue"> Should we add something like "Any observable side effect must not be made outside <var>declarations</var>"? The current constraints sound like a hole for undefined behavior.<a href="#issue-aaf411cc"> ↵ </a></div>
   <div class="issue"> Probably should distinguish between specified and computed / resolved values.<a href="#issue-5f483407"> ↵ </a></div>
   <div class="issue"> Should author specified values be normalized for case? Or should original case be preserved?<a href="#issue-b55f28a2"> ↵ </a></div>
   <div class="issue"> Probably should distinguish between specified and computed / resolved values.<a href="#issue-5f483407①"> ↵ </a></div>
   <div class="issue"> Probably should distinguish between specified and computed / resolved values.<a href="#issue-5f483407②"> ↵ </a></div>
   <div class="issue"> This should differentiate specified and computed <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#url-value">&lt;url></a> values, see <a href="https://github.com/w3c/csswg-drafts/issues/3195">#3195</a>.<a href="#issue-1e63f5cb"> ↵ </a></div>
   <div class="issue"> One idea is that we can remove this section somewhere in
the CSS3/CSS4 timeline by moving the above definitions to the drafts that
define the CSS components.<a href="#issue-08e9ac89"> ↵ </a></div>
   <div class="issue"> Some of these need to be updated per the new rules.<a href="#issue-3a42ec46"> ↵ </a></div>
   <div class="issue"> There are UAs that handle shorthands, and all UAs handle shorthands
  that used to be longhands like <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-overflow-3/#propdef-overflow">overflow</a>, see <a href="https://github.com/w3c/csswg-drafts/issues/2529">#2529</a>.<a href="#issue-28428295"> ↵ </a></div>
   <div class="issue"> Order of custom properties is currently undefined, see <a href="https://github.com/w3c/csswg-drafts/issues/4947">#4947</a>.<a href="#issue-0b704bc1"> ↵ </a></div>
   <div class="issue"> Should getComputedStyle() provide a useful serialization?
See <a href="https://github.com/w3c/csswg-drafts/issues/1033">#1033</a><a href="#issue-854608f5"> ↵ </a></div>
   <div class="issue"> This was previously specified as an IDL interface
that only held static methods.
Switching to an IDL namespace is *nearly* identical,
so it’s expected that there won’t be any compat concerns.
If any are discovered, please report
so we can consider reverting this change.<a href="#issue-24739c22"> ↵ </a></div>
  </div>
  <aside class="dfn-panel" data-for="set">
   <b><a href="#set">#set</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-set">6.6.1. The CSSStyleDeclaration Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="unset">
   <b><a href="#unset">#unset</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-unset">6.6.1. The CSSStyleDeclaration Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="supported-styling-language">
   <b><a href="#supported-styling-language">#supported-styling-language</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-supported-styling-language">6.3.1. Fetching CSS style sheets</a> <a href="#ref-for-supported-styling-language①">(2)</a>
    <li><a href="#ref-for-supported-styling-language②">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="supported-css-property">
   <b><a href="#supported-css-property">#supported-css-property</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-supported-css-property">2. Terminology</a>
    <li><a href="#ref-for-supported-css-property①">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-supported-css-property②">(2)</a> <a href="#ref-for-supported-css-property③">(3)</a> <a href="#ref-for-supported-css-property④">(4)</a>
    <li><a href="#ref-for-supported-css-property⑤">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="escape-a-character">
   <b><a href="#escape-a-character">#escape-a-character</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-escape-a-character">2.1. Common Serializing Idioms</a> <a href="#ref-for-escape-a-character①">(2)</a> <a href="#ref-for-escape-a-character②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="escape-a-character-as-code-point">
   <b><a href="#escape-a-character-as-code-point">#escape-a-character-as-code-point</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-escape-a-character-as-code-point">2.1. Common Serializing Idioms</a> <a href="#ref-for-escape-a-character-as-code-point①">(2)</a> <a href="#ref-for-escape-a-character-as-code-point②">(3)</a> <a href="#ref-for-escape-a-character-as-code-point③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-an-identifier">
   <b><a href="#serialize-an-identifier">#serialize-an-identifier</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-an-identifier">4.2. Serializing Media Queries</a>
    <li><a href="#ref-for-serialize-an-identifier①">5.2. Serializing Selectors</a> <a href="#ref-for-serialize-an-identifier②">(2)</a> <a href="#ref-for-serialize-an-identifier③">(3)</a> <a href="#ref-for-serialize-an-identifier④">(4)</a> <a href="#ref-for-serialize-an-identifier⑤">(5)</a> <a href="#ref-for-serialize-an-identifier⑥">(6)</a>
    <li><a href="#ref-for-serialize-an-identifier⑦">6.4. CSS Rules</a>
    <li><a href="#ref-for-serialize-an-identifier⑧">6.7.2. Serializing CSS Values</a>
    <li><a href="#ref-for-serialize-an-identifier⑨">8.1. The CSS.escape() Method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-a-string">
   <b><a href="#serialize-a-string">#serialize-a-string</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-string">2.1. Common Serializing Idioms</a> <a href="#ref-for-serialize-a-string①">(2)</a>
    <li><a href="#ref-for-serialize-a-string②">5.2. Serializing Selectors</a> <a href="#ref-for-serialize-a-string③">(2)</a>
    <li><a href="#ref-for-serialize-a-string④">6.4. CSS Rules</a>
    <li><a href="#ref-for-serialize-a-string⑤">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-a-url">
   <b><a href="#serialize-a-url">#serialize-a-url</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-url">6.4. CSS Rules</a> <a href="#ref-for-serialize-a-url①">(2)</a> <a href="#ref-for-serialize-a-url②">(3)</a>
    <li><a href="#ref-for-serialize-a-url③">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-a-local">
   <b><a href="#serialize-a-local">#serialize-a-local</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-local">6.4. CSS Rules</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-a-comma-separated-list">
   <b><a href="#serialize-a-comma-separated-list">#serialize-a-comma-separated-list</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-comma-separated-list">4.2. Serializing Media Queries</a>
    <li><a href="#ref-for-serialize-a-comma-separated-list①">5.2. Serializing Selectors</a> <a href="#ref-for-serialize-a-comma-separated-list②">(2)</a>
    <li><a href="#ref-for-serialize-a-comma-separated-list③">6.4. CSS Rules</a>
    <li><a href="#ref-for-serialize-a-comma-separated-list④">6.7.2. Serializing CSS Values</a> <a href="#ref-for-serialize-a-comma-separated-list⑤">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssomstring">
   <b><a href="#cssomstring">#cssomstring</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssomstring">4.4. The MediaList Interface</a> <a href="#ref-for-cssomstring①">(2)</a> <a href="#ref-for-cssomstring②">(3)</a> <a href="#ref-for-cssomstring③">(4)</a>
    <li><a href="#ref-for-cssomstring④">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-cssomstring⑤">6.1.2. The CSSStyleSheet Interface</a>
    <li><a href="#ref-for-cssomstring⑥">6.4.2. The CSSRule Interface</a>
    <li><a href="#ref-for-cssomstring⑦">6.4.3. The CSSStyleRule Interface</a>
    <li><a href="#ref-for-cssomstring⑧">6.4.5. The CSSGroupingRule Interface</a>
    <li><a href="#ref-for-cssomstring⑨">6.4.7. The CSSPageRule Interface</a>
    <li><a href="#ref-for-cssomstring①⓪">6.4.8. The CSSMarginRule Interface</a>
    <li><a href="#ref-for-cssomstring①①">6.4.9. The CSSNamespaceRule Interface</a> <a href="#ref-for-cssomstring①②">(2)</a>
    <li><a href="#ref-for-cssomstring①③">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-cssomstring①④">(2)</a> <a href="#ref-for-cssomstring①⑤">(3)</a> <a href="#ref-for-cssomstring①⑥">(4)</a> <a href="#ref-for-cssomstring①⑦">(5)</a> <a href="#ref-for-cssomstring①⑧">(6)</a> <a href="#ref-for-cssomstring①⑨">(7)</a> <a href="#ref-for-cssomstring②⓪">(8)</a> <a href="#ref-for-cssomstring②①">(9)</a> <a href="#ref-for-cssomstring②②">(10)</a> <a href="#ref-for-cssomstring②③">(11)</a> <a href="#ref-for-cssomstring②④">(12)</a> <a href="#ref-for-cssomstring②⑤">(13)</a> <a href="#ref-for-cssomstring②⑥">(14)</a> <a href="#ref-for-cssomstring②⑦">(15)</a>
    <li><a href="#ref-for-cssomstring②⑧">7.2. Extensions to the Window Interface</a>
    <li><a href="#ref-for-cssomstring②⑨">8.1. The CSS.escape() Method</a> <a href="#ref-for-cssomstring③⓪">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="parse-a-media-query-list">
   <b><a href="#parse-a-media-query-list">#parse-a-media-query-list</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-parse-a-media-query-list">4.1. Parsing Media Queries</a>
    <li><a href="#ref-for-parse-a-media-query-list①">4.4. The MediaList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="parse-a-media-query">
   <b><a href="#parse-a-media-query">#parse-a-media-query</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-parse-a-media-query">4.4. The MediaList Interface</a> <a href="#ref-for-parse-a-media-query①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-a-media-query-list">
   <b><a href="#serialize-a-media-query-list">#serialize-a-media-query-list</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-media-query-list">4.4. The MediaList Interface</a>
    <li><a href="#ref-for-serialize-a-media-query-list①">6.4. CSS Rules</a> <a href="#ref-for-serialize-a-media-query-list②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-a-media-query">
   <b><a href="#serialize-a-media-query">#serialize-a-media-query</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-media-query">4.2. Serializing Media Queries</a>
    <li><a href="#ref-for-serialize-a-media-query①">4.3. Comparing Media Queries</a>
    <li><a href="#ref-for-serialize-a-media-query②">4.4. The MediaList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-a-media-feature-value">
   <b><a href="#serialize-a-media-feature-value">#serialize-a-media-feature-value</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-media-feature-value">4.2. Serializing Media Queries</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="compare-media-queries">
   <b><a href="#compare-media-queries">#compare-media-queries</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-compare-media-queries">4.4. The MediaList Interface</a> <a href="#ref-for-compare-media-queries①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="medialist-collection-of-media-queries">
   <b><a href="#medialist-collection-of-media-queries">#medialist-collection-of-media-queries</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-medialist-collection-of-media-queries">4.4. The MediaList Interface</a> <a href="#ref-for-medialist-collection-of-media-queries①">(2)</a> <a href="#ref-for-medialist-collection-of-media-queries②">(3)</a> <a href="#ref-for-medialist-collection-of-media-queries③">(4)</a> <a href="#ref-for-medialist-collection-of-media-queries④">(5)</a> <a href="#ref-for-medialist-collection-of-media-queries⑤">(6)</a> <a href="#ref-for-medialist-collection-of-media-queries⑥">(7)</a> <a href="#ref-for-medialist-collection-of-media-queries⑦">(8)</a> <a href="#ref-for-medialist-collection-of-media-queries⑧">(9)</a> <a href="#ref-for-medialist-collection-of-media-queries⑨">(10)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="medialist">
   <b><a href="#medialist">#medialist</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-medialist">4.4. The MediaList Interface</a>
    <li><a href="#ref-for-medialist①">6.1. CSS Style Sheets</a>
    <li><a href="#ref-for-medialist②">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-medialist③">6.4.4. The CSSImportRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="create-a-medialist-object">
   <b><a href="#create-a-medialist-object">#create-a-medialist-object</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-create-a-medialist-object">6.1. CSS Style Sheets</a> <a href="#ref-for-create-a-medialist-object①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-medialist-mediatext">
   <b><a href="#dom-medialist-mediatext">#dom-medialist-mediatext</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-medialist-mediatext">4.4. The MediaList Interface</a> <a href="#ref-for-dom-medialist-mediatext①">(2)</a> <a href="#ref-for-dom-medialist-mediatext②">(3)</a>
    <li><a href="#ref-for-dom-medialist-mediatext③">6.1. CSS Style Sheets</a> <a href="#ref-for-dom-medialist-mediatext④">(2)</a>
    <li><a href="#ref-for-dom-medialist-mediatext⑤">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-dom-medialist-mediatext⑥">6.4.4. The CSSImportRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-medialist-item">
   <b><a href="#dom-medialist-item">#dom-medialist-item</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-medialist-item">4.4. The MediaList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-medialist-length">
   <b><a href="#dom-medialist-length">#dom-medialist-length</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-medialist-length">4.4. The MediaList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-medialist-appendmedium">
   <b><a href="#dom-medialist-appendmedium">#dom-medialist-appendmedium</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-medialist-appendmedium">4.4. The MediaList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-medialist-deletemedium">
   <b><a href="#dom-medialist-deletemedium">#dom-medialist-deletemedium</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-medialist-deletemedium">4.4. The MediaList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="parse-a-group-of-selectors">
   <b><a href="#parse-a-group-of-selectors">#parse-a-group-of-selectors</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-parse-a-group-of-selectors">6.4.3. The CSSStyleRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-a-group-of-selectors">
   <b><a href="#serialize-a-group-of-selectors">#serialize-a-group-of-selectors</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-group-of-selectors">5.2. Serializing Selectors</a>
    <li><a href="#ref-for-serialize-a-group-of-selectors①">6.4. CSS Rules</a>
    <li><a href="#ref-for-serialize-a-group-of-selectors②">6.4.3. The CSSStyleRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-a-selector">
   <b><a href="#serialize-a-selector">#serialize-a-selector</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-selector">5.2. Serializing Selectors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-a-simple-selector">
   <b><a href="#serialize-a-simple-selector">#serialize-a-simple-selector</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-simple-selector">5.2. Serializing Selectors</a> <a href="#ref-for-serialize-a-simple-selector①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="css-style-sheet">
   <b><a href="#css-style-sheet">#css-style-sheet</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-style-sheet">6.1. CSS Style Sheets</a> <a href="#ref-for-css-style-sheet①">(2)</a> <a href="#ref-for-css-style-sheet②">(3)</a> <a href="#ref-for-css-style-sheet③">(4)</a> <a href="#ref-for-css-style-sheet④">(5)</a> <a href="#ref-for-css-style-sheet⑤">(6)</a> <a href="#ref-for-css-style-sheet⑥">(7)</a> <a href="#ref-for-css-style-sheet⑦">(8)</a> <a href="#ref-for-css-style-sheet⑧">(9)</a> <a href="#ref-for-css-style-sheet⑨">(10)</a> <a href="#ref-for-css-style-sheet①⓪">(11)</a> <a href="#ref-for-css-style-sheet①①">(12)</a> <a href="#ref-for-css-style-sheet①②">(13)</a> <a href="#ref-for-css-style-sheet①③">(14)</a> <a href="#ref-for-css-style-sheet①④">(15)</a> <a href="#ref-for-css-style-sheet①⑤">(16)</a> <a href="#ref-for-css-style-sheet①⑥">(17)</a>
    <li><a href="#ref-for-css-style-sheet①⑦">6.1.2. The CSSStyleSheet Interface</a>
    <li><a href="#ref-for-css-style-sheet①⑧">6.2. CSS Style Sheet Collections</a> <a href="#ref-for-css-style-sheet①⑨">(2)</a> <a href="#ref-for-css-style-sheet②⓪">(3)</a> <a href="#ref-for-css-style-sheet②①">(4)</a> <a href="#ref-for-css-style-sheet②②">(5)</a> <a href="#ref-for-css-style-sheet②③">(6)</a> <a href="#ref-for-css-style-sheet②④">(7)</a> <a href="#ref-for-css-style-sheet②⑤">(8)</a> <a href="#ref-for-css-style-sheet②⑥">(9)</a> <a href="#ref-for-css-style-sheet②⑦">(10)</a> <a href="#ref-for-css-style-sheet②⑧">(11)</a> <a href="#ref-for-css-style-sheet②⑨">(12)</a> <a href="#ref-for-css-style-sheet③⓪">(13)</a> <a href="#ref-for-css-style-sheet③①">(14)</a> <a href="#ref-for-css-style-sheet③②">(15)</a>
    <li><a href="#ref-for-css-style-sheet③③">6.2.2. The StyleSheetList Interface</a> <a href="#ref-for-css-style-sheet③④">(2)</a> <a href="#ref-for-css-style-sheet③⑤">(3)</a> <a href="#ref-for-css-style-sheet③⑥">(4)</a> <a href="#ref-for-css-style-sheet③⑦">(5)</a>
    <li><a href="#ref-for-css-style-sheet③⑧">6.3. Style Sheet Association</a>
    <li><a href="#ref-for-css-style-sheet③⑨">6.3.2. The LinkStyle Interface</a>
    <li><a href="#ref-for-css-style-sheet④⓪">6.3.3. Requirements on specifications</a>
    <li><a href="#ref-for-css-style-sheet④①">6.4. CSS Rules</a>
    <li><a href="#ref-for-css-style-sheet④②">6.4.4. The CSSImportRule Interface</a> <a href="#ref-for-css-style-sheet④③">(2)</a> <a href="#ref-for-css-style-sheet④④">(3)</a> <a href="#ref-for-css-style-sheet④⑤">(4)</a>
    <li><a href="#ref-for-css-style-sheet④⑥">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-css-style-sheet-type">
   <b><a href="#concept-css-style-sheet-type">#concept-css-style-sheet-type</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-css-style-sheet-type">6.1.1. The StyleSheet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-css-style-sheet-location">
   <b><a href="#concept-css-style-sheet-location">#concept-css-style-sheet-location</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-css-style-sheet-location">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-concept-css-style-sheet-location①">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
    <li><a href="#ref-for-concept-css-style-sheet-location②">6.3.5. Requirements on User Agents Implementing the HTTP Link Header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-css-style-sheet-parent-css-style-sheet">
   <b><a href="#concept-css-style-sheet-parent-css-style-sheet">#concept-css-style-sheet-parent-css-style-sheet</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-css-style-sheet-parent-css-style-sheet">6.1. CSS Style Sheets</a>
    <li><a href="#ref-for-concept-css-style-sheet-parent-css-style-sheet①">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-concept-css-style-sheet-parent-css-style-sheet②">6.2. CSS Style Sheet Collections</a>
    <li><a href="#ref-for-concept-css-style-sheet-parent-css-style-sheet③">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
    <li><a href="#ref-for-concept-css-style-sheet-parent-css-style-sheet④">6.3.5. Requirements on User Agents Implementing the HTTP Link Header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-css-style-sheet-owner-node">
   <b><a href="#concept-css-style-sheet-owner-node">#concept-css-style-sheet-owner-node</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-css-style-sheet-owner-node">6.1. CSS Style Sheets</a> <a href="#ref-for-concept-css-style-sheet-owner-node①">(2)</a> <a href="#ref-for-concept-css-style-sheet-owner-node②">(3)</a> <a href="#ref-for-concept-css-style-sheet-owner-node③">(4)</a> <a href="#ref-for-concept-css-style-sheet-owner-node④">(5)</a>
    <li><a href="#ref-for-concept-css-style-sheet-owner-node⑤">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-concept-css-style-sheet-owner-node⑥">6.2. CSS Style Sheet Collections</a>
    <li><a href="#ref-for-concept-css-style-sheet-owner-node⑦">6.3. Style Sheet Association</a>
    <li><a href="#ref-for-concept-css-style-sheet-owner-node⑧">6.3.2. The LinkStyle Interface</a>
    <li><a href="#ref-for-concept-css-style-sheet-owner-node⑨">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
    <li><a href="#ref-for-concept-css-style-sheet-owner-node①⓪">6.3.5. Requirements on User Agents Implementing the HTTP Link Header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-css-style-sheet-owner-css-rule">
   <b><a href="#concept-css-style-sheet-owner-css-rule">#concept-css-style-sheet-owner-css-rule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-css-style-sheet-owner-css-rule">6.1.2. The CSSStyleSheet Interface</a>
    <li><a href="#ref-for-concept-css-style-sheet-owner-css-rule①">6.2. CSS Style Sheet Collections</a>
    <li><a href="#ref-for-concept-css-style-sheet-owner-css-rule②">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
    <li><a href="#ref-for-concept-css-style-sheet-owner-css-rule③">6.3.5. Requirements on User Agents Implementing the HTTP Link Header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-css-style-sheet-media">
   <b><a href="#concept-css-style-sheet-media">#concept-css-style-sheet-media</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-css-style-sheet-media">6.1. CSS Style Sheets</a> <a href="#ref-for-concept-css-style-sheet-media①">(2)</a> <a href="#ref-for-concept-css-style-sheet-media②">(3)</a> <a href="#ref-for-concept-css-style-sheet-media③">(4)</a>
    <li><a href="#ref-for-concept-css-style-sheet-media④">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-concept-css-style-sheet-media⑤">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
    <li><a href="#ref-for-concept-css-style-sheet-media⑥">6.3.5. Requirements on User Agents Implementing the HTTP Link Header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-css-style-sheet-title">
   <b><a href="#concept-css-style-sheet-title">#concept-css-style-sheet-title</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-css-style-sheet-title">6.1. CSS Style Sheets</a> <a href="#ref-for-concept-css-style-sheet-title①">(2)</a> <a href="#ref-for-concept-css-style-sheet-title②">(3)</a> <a href="#ref-for-concept-css-style-sheet-title③">(4)</a>
    <li><a href="#ref-for-concept-css-style-sheet-title④">6.1.1. The StyleSheet Interface</a> <a href="#ref-for-concept-css-style-sheet-title⑤">(2)</a>
    <li><a href="#ref-for-concept-css-style-sheet-title⑥">6.2. CSS Style Sheet Collections</a> <a href="#ref-for-concept-css-style-sheet-title⑦">(2)</a> <a href="#ref-for-concept-css-style-sheet-title⑧">(3)</a> <a href="#ref-for-concept-css-style-sheet-title⑨">(4)</a> <a href="#ref-for-concept-css-style-sheet-title①⓪">(5)</a> <a href="#ref-for-concept-css-style-sheet-title①①">(6)</a> <a href="#ref-for-concept-css-style-sheet-title①②">(7)</a> <a href="#ref-for-concept-css-style-sheet-title①③">(8)</a>
    <li><a href="#ref-for-concept-css-style-sheet-title①④">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
    <li><a href="#ref-for-concept-css-style-sheet-title①⑤">6.3.5. Requirements on User Agents Implementing the HTTP Link Header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-css-style-sheet-alternate-flag">
   <b><a href="#concept-css-style-sheet-alternate-flag">#concept-css-style-sheet-alternate-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-css-style-sheet-alternate-flag">6.1. CSS Style Sheets</a>
    <li><a href="#ref-for-concept-css-style-sheet-alternate-flag①">6.2. CSS Style Sheet Collections</a> <a href="#ref-for-concept-css-style-sheet-alternate-flag②">(2)</a>
    <li><a href="#ref-for-concept-css-style-sheet-alternate-flag③">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
    <li><a href="#ref-for-concept-css-style-sheet-alternate-flag④">6.3.5. Requirements on User Agents Implementing the HTTP Link Header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-css-style-sheet-disabled-flag">
   <b><a href="#concept-css-style-sheet-disabled-flag">#concept-css-style-sheet-disabled-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-css-style-sheet-disabled-flag">6.1.1. The StyleSheet Interface</a> <a href="#ref-for-concept-css-style-sheet-disabled-flag①">(2)</a> <a href="#ref-for-concept-css-style-sheet-disabled-flag②">(3)</a>
    <li><a href="#ref-for-concept-css-style-sheet-disabled-flag③">6.2. CSS Style Sheet Collections</a> <a href="#ref-for-concept-css-style-sheet-disabled-flag④">(2)</a> <a href="#ref-for-concept-css-style-sheet-disabled-flag⑤">(3)</a> <a href="#ref-for-concept-css-style-sheet-disabled-flag⑥">(4)</a> <a href="#ref-for-concept-css-style-sheet-disabled-flag⑦">(5)</a> <a href="#ref-for-concept-css-style-sheet-disabled-flag⑧">(6)</a> <a href="#ref-for-concept-css-style-sheet-disabled-flag⑨">(7)</a> <a href="#ref-for-concept-css-style-sheet-disabled-flag①⓪">(8)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-css-style-sheet-css-rules">
   <b><a href="#concept-css-style-sheet-css-rules">#concept-css-style-sheet-css-rules</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-css-style-sheet-css-rules">6.1. CSS Style Sheets</a>
    <li><a href="#ref-for-concept-css-style-sheet-css-rules①">6.1.2. The CSSStyleSheet Interface</a> <a href="#ref-for-concept-css-style-sheet-css-rules②">(2)</a> <a href="#ref-for-concept-css-style-sheet-css-rules③">(3)</a>
    <li><a href="#ref-for-concept-css-style-sheet-css-rules④">6.1.2.1. Deprecated CSSStyleSheet members</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-css-style-sheet-origin-clean-flag">
   <b><a href="#concept-css-style-sheet-origin-clean-flag">#concept-css-style-sheet-origin-clean-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-css-style-sheet-origin-clean-flag">6.1.2. The CSSStyleSheet Interface</a> <a href="#ref-for-concept-css-style-sheet-origin-clean-flag①">(2)</a> <a href="#ref-for-concept-css-style-sheet-origin-clean-flag②">(3)</a>
    <li><a href="#ref-for-concept-css-style-sheet-origin-clean-flag③">6.2. CSS Style Sheet Collections</a>
    <li><a href="#ref-for-concept-css-style-sheet-origin-clean-flag④">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
    <li><a href="#ref-for-concept-css-style-sheet-origin-clean-flag⑤">6.3.5. Requirements on User Agents Implementing the HTTP Link Header</a>
    <li><a href="#ref-for-concept-css-style-sheet-origin-clean-flag⑥">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="stylesheet">
   <b><a href="#stylesheet">#stylesheet</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-stylesheet">6.1.1. The StyleSheet Interface</a> <a href="#ref-for-stylesheet①">(2)</a>
    <li><a href="#ref-for-stylesheet②">6.1.2. The CSSStyleSheet Interface</a>
    <li><a href="#ref-for-stylesheet③">6.3.2. The LinkStyle Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-stylesheet-type">
   <b><a href="#dom-stylesheet-type">#dom-stylesheet-type</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-stylesheet-type">6.1.1. The StyleSheet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-stylesheet-href">
   <b><a href="#dom-stylesheet-href">#dom-stylesheet-href</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-stylesheet-href">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-dom-stylesheet-href①">6.4.4. The CSSImportRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-stylesheet-ownernode">
   <b><a href="#dom-stylesheet-ownernode">#dom-stylesheet-ownernode</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-stylesheet-ownernode">6.1.1. The StyleSheet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-stylesheet-parentstylesheet">
   <b><a href="#dom-stylesheet-parentstylesheet">#dom-stylesheet-parentstylesheet</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-stylesheet-parentstylesheet">6.1.1. The StyleSheet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-stylesheet-title">
   <b><a href="#dom-stylesheet-title">#dom-stylesheet-title</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-stylesheet-title">6.1.1. The StyleSheet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-stylesheet-media">
   <b><a href="#dom-stylesheet-media">#dom-stylesheet-media</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-stylesheet-media">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-dom-stylesheet-media①">6.4.4. The CSSImportRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-stylesheet-disabled">
   <b><a href="#dom-stylesheet-disabled">#dom-stylesheet-disabled</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-stylesheet-disabled">6.1.1. The StyleSheet Interface</a> <a href="#ref-for-dom-stylesheet-disabled①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssstylesheet">
   <b><a href="#cssstylesheet">#cssstylesheet</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssstylesheet">6.1. CSS Style Sheets</a>
    <li><a href="#ref-for-cssstylesheet①">6.1.1. The StyleSheet Interface</a>
    <li><a href="#ref-for-cssstylesheet②">6.1.2. The CSSStyleSheet Interface</a> <a href="#ref-for-cssstylesheet③">(2)</a>
    <li><a href="#ref-for-cssstylesheet④">6.1.2.1. Deprecated CSSStyleSheet members</a> <a href="#ref-for-cssstylesheet⑤">(2)</a>
    <li><a href="#ref-for-cssstylesheet⑥">6.2.2. The StyleSheetList Interface</a>
    <li><a href="#ref-for-cssstylesheet⑦">6.3.2. The LinkStyle Interface</a>
    <li><a href="#ref-for-cssstylesheet⑧">6.4.2. The CSSRule Interface</a>
    <li><a href="#ref-for-cssstylesheet⑨">6.4.4. The CSSImportRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstylesheet-ownerrule">
   <b><a href="#dom-cssstylesheet-ownerrule">#dom-cssstylesheet-ownerrule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstylesheet-ownerrule">6.1.2. The CSSStyleSheet Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstylesheet-cssrules">
   <b><a href="#dom-cssstylesheet-cssrules">#dom-cssstylesheet-cssrules</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstylesheet-cssrules">6.1.2. The CSSStyleSheet Interface</a>
    <li><a href="#ref-for-dom-cssstylesheet-cssrules①">6.1.2.1. Deprecated CSSStyleSheet members</a> <a href="#ref-for-dom-cssstylesheet-cssrules②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstylesheet-insertrule">
   <b><a href="#dom-cssstylesheet-insertrule">#dom-cssstylesheet-insertrule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstylesheet-insertrule">6.1.2. The CSSStyleSheet Interface</a> <a href="#ref-for-dom-cssstylesheet-insertrule①">(2)</a>
    <li><a href="#ref-for-dom-cssstylesheet-insertrule②">6.1.2.1. Deprecated CSSStyleSheet members</a>
    <li><a href="#ref-for-dom-cssstylesheet-insertrule③">11.1. Changes From 5 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstylesheet-deleterule">
   <b><a href="#dom-cssstylesheet-deleterule">#dom-cssstylesheet-deleterule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstylesheet-deleterule">6.1.2. The CSSStyleSheet Interface</a> <a href="#ref-for-dom-cssstylesheet-deleterule①">(2)</a>
    <li><a href="#ref-for-dom-cssstylesheet-deleterule②">6.1.2.1. Deprecated CSSStyleSheet members</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstylesheet-rules">
   <b><a href="#dom-cssstylesheet-rules">#dom-cssstylesheet-rules</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstylesheet-rules">6.1.2.1. Deprecated CSSStyleSheet members</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstylesheet-removerule">
   <b><a href="#dom-cssstylesheet-removerule">#dom-cssstylesheet-removerule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstylesheet-removerule">6.1.2.1. Deprecated CSSStyleSheet members</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstylesheet-addrule">
   <b><a href="#dom-cssstylesheet-addrule">#dom-cssstylesheet-addrule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstylesheet-addrule">6.1.2.1. Deprecated CSSStyleSheet members</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="documentorshadowroot-document-or-shadow-root-css-style-sheets">
   <b><a href="#documentorshadowroot-document-or-shadow-root-css-style-sheets">#documentorshadowroot-document-or-shadow-root-css-style-sheets</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-documentorshadowroot-document-or-shadow-root-css-style-sheets">6.2. CSS Style Sheet Collections</a> <a href="#ref-for-documentorshadowroot-document-or-shadow-root-css-style-sheets①">(2)</a> <a href="#ref-for-documentorshadowroot-document-or-shadow-root-css-style-sheets②">(3)</a> <a href="#ref-for-documentorshadowroot-document-or-shadow-root-css-style-sheets③">(4)</a>
    <li><a href="#ref-for-documentorshadowroot-document-or-shadow-root-css-style-sheets④">6.2.3. Extensions to the DocumentOrShadowRoot Interface Mixin</a>
    <li><a href="#ref-for-documentorshadowroot-document-or-shadow-root-css-style-sheets⑤">6.3.2. The LinkStyle Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="create-a-css-style-sheet">
   <b><a href="#create-a-css-style-sheet">#create-a-css-style-sheet</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-create-a-css-style-sheet">6.3.3. Requirements on specifications</a>
    <li><a href="#ref-for-create-a-css-style-sheet①">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
    <li><a href="#ref-for-create-a-css-style-sheet②">6.3.5. Requirements on User Agents Implementing the HTTP Link Header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="add-a-css-style-sheet">
   <b><a href="#add-a-css-style-sheet">#add-a-css-style-sheet</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-add-a-css-style-sheet">6.1. CSS Style Sheets</a>
    <li><a href="#ref-for-add-a-css-style-sheet①">6.2. CSS Style Sheet Collections</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="remove-a-css-style-sheet">
   <b><a href="#remove-a-css-style-sheet">#remove-a-css-style-sheet</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-remove-a-css-style-sheet">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="css-style-sheet-set">
   <b><a href="#css-style-sheet-set">#css-style-sheet-set</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-style-sheet-set">6.2. CSS Style Sheet Collections</a> <a href="#ref-for-css-style-sheet-set①">(2)</a> <a href="#ref-for-css-style-sheet-set②">(3)</a> <a href="#ref-for-css-style-sheet-set③">(4)</a> <a href="#ref-for-css-style-sheet-set④">(5)</a> <a href="#ref-for-css-style-sheet-set⑤">(6)</a>
    <li><a href="#ref-for-css-style-sheet-set⑥">6.2.1. The HTTP Default-Style Header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="css-style-sheet-set-name">
   <b><a href="#css-style-sheet-set-name">#css-style-sheet-set-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-style-sheet-set-name">6.2. CSS Style Sheet Collections</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="enabled-css-style-sheet-set">
   <b><a href="#enabled-css-style-sheet-set">#enabled-css-style-sheet-set</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-enabled-css-style-sheet-set">6.2.1. The HTTP Default-Style Header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="enable-a-css-style-sheet-set">
   <b><a href="#enable-a-css-style-sheet-set">#enable-a-css-style-sheet-set</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-enable-a-css-style-sheet-set">6.2. CSS Style Sheet Collections</a> <a href="#ref-for-enable-a-css-style-sheet-set①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="select-a-css-style-sheet-set">
   <b><a href="#select-a-css-style-sheet-set">#select-a-css-style-sheet-set</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-select-a-css-style-sheet-set">6.2. CSS Style Sheet Collections</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="last-css-style-sheet-set-name">
   <b><a href="#last-css-style-sheet-set-name">#last-css-style-sheet-set-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-last-css-style-sheet-set-name">6.2. CSS Style Sheet Collections</a> <a href="#ref-for-last-css-style-sheet-set-name①">(2)</a> <a href="#ref-for-last-css-style-sheet-set-name②">(3)</a> <a href="#ref-for-last-css-style-sheet-set-name③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="preferred-css-style-sheet-set-name">
   <b><a href="#preferred-css-style-sheet-set-name">#preferred-css-style-sheet-set-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-preferred-css-style-sheet-set-name">6.2. CSS Style Sheet Collections</a> <a href="#ref-for-preferred-css-style-sheet-set-name①">(2)</a> <a href="#ref-for-preferred-css-style-sheet-set-name②">(3)</a> <a href="#ref-for-preferred-css-style-sheet-set-name③">(4)</a>
    <li><a href="#ref-for-preferred-css-style-sheet-set-name④">6.2.1. The HTTP Default-Style Header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="change-the-preferred-css-style-sheet-set-name">
   <b><a href="#change-the-preferred-css-style-sheet-set-name">#change-the-preferred-css-style-sheet-set-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-change-the-preferred-css-style-sheet-set-name">6.2. CSS Style Sheet Collections</a>
    <li><a href="#ref-for-change-the-preferred-css-style-sheet-set-name①">6.2.1. The HTTP Default-Style Header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="stylesheetlist">
   <b><a href="#stylesheetlist">#stylesheetlist</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-stylesheetlist">6.2.2. The StyleSheetList Interface</a> <a href="#ref-for-stylesheetlist①">(2)</a>
    <li><a href="#ref-for-stylesheetlist②">6.2.3. Extensions to the DocumentOrShadowRoot Interface Mixin</a> <a href="#ref-for-stylesheetlist③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-stylesheetlist-item">
   <b><a href="#dom-stylesheetlist-item">#dom-stylesheetlist-item</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-stylesheetlist-item">6.2.2. The StyleSheetList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-stylesheetlist-length">
   <b><a href="#dom-stylesheetlist-length">#dom-stylesheetlist-length</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-stylesheetlist-length">6.2.2. The StyleSheetList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-documentorshadowroot-stylesheets">
   <b><a href="#dom-documentorshadowroot-stylesheets">#dom-documentorshadowroot-stylesheets</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-documentorshadowroot-stylesheets">6.2.3. Extensions to the DocumentOrShadowRoot Interface Mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="fetch-a-css-style-sheet">
   <b><a href="#fetch-a-css-style-sheet">#fetch-a-css-style-sheet</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-fetch-a-css-style-sheet">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
    <li><a href="#ref-for-fetch-a-css-style-sheet①">6.3.5. Requirements on User Agents Implementing the HTTP Link Header</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="associated-css-style-sheet">
   <b><a href="#associated-css-style-sheet">#associated-css-style-sheet</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-associated-css-style-sheet">6.1. CSS Style Sheets</a>
    <li><a href="#ref-for-associated-css-style-sheet①">6.3.2. The LinkStyle Interface</a> <a href="#ref-for-associated-css-style-sheet②">(2)</a>
    <li><a href="#ref-for-associated-css-style-sheet③">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="linkstyle">
   <b><a href="#linkstyle">#linkstyle</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-linkstyle">6.3.2. The LinkStyle Interface</a> <a href="#ref-for-linkstyle①">(2)</a>
    <li><a href="#ref-for-linkstyle②">6.3.3. Requirements on specifications</a>
    <li><a href="#ref-for-linkstyle③">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-linkstyle-sheet">
   <b><a href="#dom-linkstyle-sheet">#dom-linkstyle-sheet</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-linkstyle-sheet">6.3.2. The LinkStyle Interface</a> <a href="#ref-for-dom-linkstyle-sheet①">(2)</a> <a href="#ref-for-dom-linkstyle-sheet②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="prolog">
   <b><a href="#prolog">#prolog</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-prolog">6.3.4. Requirements on User Agents Implementing the xml-stylesheet processing instruction</a> <a href="#ref-for-prolog①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="css-rule">
   <b><a href="#css-rule">#css-rule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-rule">6.1. CSS Style Sheets</a>
    <li><a href="#ref-for-css-rule①">6.4. CSS Rules</a> <a href="#ref-for-css-rule②">(2)</a> <a href="#ref-for-css-rule③">(3)</a> <a href="#ref-for-css-rule④">(4)</a> <a href="#ref-for-css-rule⑤">(5)</a>
    <li><a href="#ref-for-css-rule⑥">6.4.2. The CSSRule Interface</a>
    <li><a href="#ref-for-css-rule⑦">6.6. CSS Declaration Blocks</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-css-rule-type">
   <b><a href="#concept-css-rule-type">#concept-css-rule-type</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-css-rule-type">6.4. CSS Rules</a> <a href="#ref-for-concept-css-rule-type①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-css-rule-parent-css-rule">
   <b><a href="#concept-css-rule-parent-css-rule">#concept-css-rule-parent-css-rule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-css-rule-parent-css-rule">6.4. CSS Rules</a>
    <li><a href="#ref-for-concept-css-rule-parent-css-rule①">6.4.2. The CSSRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-css-rule-parent-css-style-sheet">
   <b><a href="#concept-css-rule-parent-css-style-sheet">#concept-css-rule-parent-css-style-sheet</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-css-rule-parent-css-style-sheet">6.4. CSS Rules</a>
    <li><a href="#ref-for-concept-css-rule-parent-css-style-sheet①">6.4.2. The CSSRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-css-rule-child-css-rules">
   <b><a href="#concept-css-rule-child-css-rules">#concept-css-rule-child-css-rules</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-css-rule-child-css-rules">6.4.5. The CSSGroupingRule Interface</a> <a href="#ref-for-concept-css-rule-child-css-rules①">(2)</a> <a href="#ref-for-concept-css-rule-child-css-rules②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="parse-a-css-rule">
   <b><a href="#parse-a-css-rule">#parse-a-css-rule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-parse-a-css-rule">6.4. CSS Rules</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-a-css-rule">
   <b><a href="#serialize-a-css-rule">#serialize-a-css-rule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-css-rule">6.4. CSS Rules</a>
    <li><a href="#ref-for-serialize-a-css-rule①">6.4.2. The CSSRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="insert-a-css-rule">
   <b><a href="#insert-a-css-rule">#insert-a-css-rule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-insert-a-css-rule">6.1.2. The CSSStyleSheet Interface</a>
    <li><a href="#ref-for-insert-a-css-rule①">6.4.5. The CSSGroupingRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="remove-a-css-rule">
   <b><a href="#remove-a-css-rule">#remove-a-css-rule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-remove-a-css-rule">6.1.2. The CSSStyleSheet Interface</a>
    <li><a href="#ref-for-remove-a-css-rule①">6.4.2. The CSSRule Interface</a>
    <li><a href="#ref-for-remove-a-css-rule②">6.4.5. The CSSGroupingRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssrulelist">
   <b><a href="#cssrulelist">#cssrulelist</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssrulelist">6.1.2. The CSSStyleSheet Interface</a> <a href="#ref-for-cssrulelist①">(2)</a> <a href="#ref-for-cssrulelist②">(3)</a>
    <li><a href="#ref-for-cssrulelist③">6.1.2.1. Deprecated CSSStyleSheet members</a>
    <li><a href="#ref-for-cssrulelist④">6.4.1. The CSSRuleList Interface</a> <a href="#ref-for-cssrulelist⑤">(2)</a>
    <li><a href="#ref-for-cssrulelist⑥">6.4.5. The CSSGroupingRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssrulelist-item">
   <b><a href="#dom-cssrulelist-item">#dom-cssrulelist-item</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssrulelist-item">6.4.1. The CSSRuleList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssrulelist-length">
   <b><a href="#dom-cssrulelist-length">#dom-cssrulelist-length</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssrulelist-length">6.4.1. The CSSRuleList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssrule">
   <b><a href="#cssrule">#cssrule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssrule">6.1.2. The CSSStyleSheet Interface</a>
    <li><a href="#ref-for-cssrule①">6.4. CSS Rules</a>
    <li><a href="#ref-for-cssrule②">6.4.1. The CSSRuleList Interface</a> <a href="#ref-for-cssrule③">(2)</a> <a href="#ref-for-cssrule④">(3)</a> <a href="#ref-for-cssrule⑤">(4)</a> <a href="#ref-for-cssrule⑥">(5)</a>
    <li><a href="#ref-for-cssrule⑦">6.4.2. The CSSRule Interface</a> <a href="#ref-for-cssrule⑧">(2)</a> <a href="#ref-for-cssrule⑨">(3)</a>
    <li><a href="#ref-for-cssrule①⓪">6.4.3. The CSSStyleRule Interface</a>
    <li><a href="#ref-for-cssrule①①">6.4.4. The CSSImportRule Interface</a>
    <li><a href="#ref-for-cssrule①②">6.4.5. The CSSGroupingRule Interface</a>
    <li><a href="#ref-for-cssrule①③">6.4.8. The CSSMarginRule Interface</a>
    <li><a href="#ref-for-cssrule①④">6.4.9. The CSSNamespaceRule Interface</a>
    <li><a href="#ref-for-cssrule①⑤">6.6.1. The CSSStyleDeclaration Interface</a>
    <li><a href="#ref-for-cssrule①⑥">11.1. Changes From 5 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssrule-csstext">
   <b><a href="#dom-cssrule-csstext">#dom-cssrule-csstext</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssrule-csstext">6.4.2. The CSSRule Interface</a> <a href="#ref-for-dom-cssrule-csstext①">(2)</a>
    <li><a href="#ref-for-dom-cssrule-csstext②">11.1. Changes From 5 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssrule-parentrule">
   <b><a href="#dom-cssrule-parentrule">#dom-cssrule-parentrule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssrule-parentrule">6.4.2. The CSSRule Interface</a> <a href="#ref-for-dom-cssrule-parentrule①">(2)</a> <a href="#ref-for-dom-cssrule-parentrule②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssrule-parentstylesheet">
   <b><a href="#dom-cssrule-parentstylesheet">#dom-cssrule-parentstylesheet</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssrule-parentstylesheet">6.4.2. The CSSRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssrule-type">
   <b><a href="#dom-cssrule-type">#dom-cssrule-type</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssrule-type">6.4.2. The CSSRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssstylerule">
   <b><a href="#cssstylerule">#cssstylerule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssstylerule">6.4. CSS Rules</a>
    <li><a href="#ref-for-cssstylerule①">6.4.2. The CSSRule Interface</a>
    <li><a href="#ref-for-cssstylerule②">6.4.3. The CSSStyleRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstylerule-selectortext">
   <b><a href="#dom-cssstylerule-selectortext">#dom-cssstylerule-selectortext</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstylerule-selectortext">6.4.3. The CSSStyleRule Interface</a> <a href="#ref-for-dom-cssstylerule-selectortext①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstylerule-style">
   <b><a href="#dom-cssstylerule-style">#dom-cssstylerule-style</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstylerule-style">6.4.3. The CSSStyleRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-declarations-specified-order">
   <b><a href="#concept-declarations-specified-order">#concept-declarations-specified-order</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-declarations-specified-order">6.4.3. The CSSStyleRule Interface</a>
    <li><a href="#ref-for-concept-declarations-specified-order①">6.4.7. The CSSPageRule Interface</a>
    <li><a href="#ref-for-concept-declarations-specified-order②">6.4.8. The CSSMarginRule Interface</a>
    <li><a href="#ref-for-concept-declarations-specified-order③">6.6.1. The CSSStyleDeclaration Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssimportrule">
   <b><a href="#cssimportrule">#cssimportrule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssimportrule">6.4. CSS Rules</a>
    <li><a href="#ref-for-cssimportrule①">6.4.2. The CSSRule Interface</a>
    <li><a href="#ref-for-cssimportrule②">6.4.4. The CSSImportRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssimportrule-href">
   <b><a href="#dom-cssimportrule-href">#dom-cssimportrule-href</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssimportrule-href">6.4.4. The CSSImportRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssimportrule-media">
   <b><a href="#dom-cssimportrule-media">#dom-cssimportrule-media</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssimportrule-media">6.4.4. The CSSImportRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssimportrule-stylesheet">
   <b><a href="#dom-cssimportrule-stylesheet">#dom-cssimportrule-stylesheet</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssimportrule-stylesheet">6.4.4. The CSSImportRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssgroupingrule">
   <b><a href="#cssgroupingrule">#cssgroupingrule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssgroupingrule">6.1.2.1. Deprecated CSSStyleSheet members</a>
    <li><a href="#ref-for-cssgroupingrule①">6.4.5. The CSSGroupingRule Interface</a>
    <li><a href="#ref-for-cssgroupingrule②">6.4.7. The CSSPageRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssgroupingrule-cssrules">
   <b><a href="#dom-cssgroupingrule-cssrules">#dom-cssgroupingrule-cssrules</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssgroupingrule-cssrules">6.4.5. The CSSGroupingRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssgroupingrule-insertrule">
   <b><a href="#dom-cssgroupingrule-insertrule">#dom-cssgroupingrule-insertrule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssgroupingrule-insertrule">6.4.5. The CSSGroupingRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssgroupingrule-deleterule">
   <b><a href="#dom-cssgroupingrule-deleterule">#dom-cssgroupingrule-deleterule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssgroupingrule-deleterule">6.4.5. The CSSGroupingRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="parse-a-list-of-css-page-selectors">
   <b><a href="#parse-a-list-of-css-page-selectors">#parse-a-list-of-css-page-selectors</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-parse-a-list-of-css-page-selectors">6.4.7. The CSSPageRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-a-list-of-css-page-selectors">
   <b><a href="#serialize-a-list-of-css-page-selectors">#serialize-a-list-of-css-page-selectors</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-list-of-css-page-selectors">6.4.7. The CSSPageRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="csspagerule">
   <b><a href="#csspagerule">#csspagerule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-csspagerule">6.4. CSS Rules</a> <a href="#ref-for-csspagerule①">(2)</a>
    <li><a href="#ref-for-csspagerule②">6.4.2. The CSSRule Interface</a>
    <li><a href="#ref-for-csspagerule③">6.4.7. The CSSPageRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-csspagerule-selectortext">
   <b><a href="#dom-csspagerule-selectortext">#dom-csspagerule-selectortext</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-csspagerule-selectortext">6.4.7. The CSSPageRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssmarginrule">
   <b><a href="#cssmarginrule">#cssmarginrule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssmarginrule">6.4.2. The CSSRule Interface</a>
    <li><a href="#ref-for-cssmarginrule①">6.4.8. The CSSMarginRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssmarginrule-name">
   <b><a href="#dom-cssmarginrule-name">#dom-cssmarginrule-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssmarginrule-name">6.4.8. The CSSMarginRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssmarginrule-style">
   <b><a href="#dom-cssmarginrule-style">#dom-cssmarginrule-style</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssmarginrule-style">6.4.8. The CSSMarginRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssnamespacerule">
   <b><a href="#cssnamespacerule">#cssnamespacerule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssnamespacerule">6.4. CSS Rules</a>
    <li><a href="#ref-for-cssnamespacerule①">6.4.2. The CSSRule Interface</a>
    <li><a href="#ref-for-cssnamespacerule②">6.4.9. The CSSNamespaceRule Interface</a>
    <li><a href="#ref-for-cssnamespacerule③">11.1. Changes From 5 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssnamespacerule-namespaceuri">
   <b><a href="#dom-cssnamespacerule-namespaceuri">#dom-cssnamespacerule-namespaceuri</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssnamespacerule-namespaceuri">6.4. CSS Rules</a>
    <li><a href="#ref-for-dom-cssnamespacerule-namespaceuri①">6.4.9. The CSSNamespaceRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssnamespacerule-prefix">
   <b><a href="#dom-cssnamespacerule-prefix">#dom-cssnamespacerule-prefix</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssnamespacerule-prefix">6.4. CSS Rules</a>
    <li><a href="#ref-for-dom-cssnamespacerule-prefix①">6.4.9. The CSSNamespaceRule Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="css-declaration">
   <b><a href="#css-declaration">#css-declaration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-declaration">6.5. CSS Declarations</a>
    <li><a href="#ref-for-css-declaration①">6.6. CSS Declaration Blocks</a> <a href="#ref-for-css-declaration②">(2)</a> <a href="#ref-for-css-declaration③">(3)</a> <a href="#ref-for-css-declaration④">(4)</a> <a href="#ref-for-css-declaration⑤">(5)</a> <a href="#ref-for-css-declaration⑥">(6)</a> <a href="#ref-for-css-declaration⑦">(7)</a>
    <li><a href="#ref-for-css-declaration⑧">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-css-declaration⑨">(2)</a> <a href="#ref-for-css-declaration①⓪">(3)</a> <a href="#ref-for-css-declaration①①">(4)</a> <a href="#ref-for-css-declaration①②">(5)</a> <a href="#ref-for-css-declaration①③">(6)</a> <a href="#ref-for-css-declaration①④">(7)</a> <a href="#ref-for-css-declaration①⑤">(8)</a> <a href="#ref-for-css-declaration①⑥">(9)</a> <a href="#ref-for-css-declaration①⑦">(10)</a> <a href="#ref-for-css-declaration①⑧">(11)</a> <a href="#ref-for-css-declaration①⑨">(12)</a> <a href="#ref-for-css-declaration②⓪">(13)</a> <a href="#ref-for-css-declaration②①">(14)</a> <a href="#ref-for-css-declaration②②">(15)</a> <a href="#ref-for-css-declaration②③">(16)</a> <a href="#ref-for-css-declaration②④">(17)</a> <a href="#ref-for-css-declaration②⑤">(18)</a> <a href="#ref-for-css-declaration②⑥">(19)</a>
    <li><a href="#ref-for-css-declaration②⑦">6.7.2. Serializing CSS Values</a> <a href="#ref-for-css-declaration②⑧">(2)</a>
    <li><a href="#ref-for-css-declaration②⑨">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="css-declaration-property-name">
   <b><a href="#css-declaration-property-name">#css-declaration-property-name</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-declaration-property-name">6.5. CSS Declarations</a>
    <li><a href="#ref-for-css-declaration-property-name①">6.6. CSS Declaration Blocks</a> <a href="#ref-for-css-declaration-property-name②">(2)</a> <a href="#ref-for-css-declaration-property-name③">(3)</a>
    <li><a href="#ref-for-css-declaration-property-name④">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-css-declaration-property-name⑤">(2)</a> <a href="#ref-for-css-declaration-property-name⑥">(3)</a> <a href="#ref-for-css-declaration-property-name⑦">(4)</a> <a href="#ref-for-css-declaration-property-name⑧">(5)</a> <a href="#ref-for-css-declaration-property-name⑨">(6)</a> <a href="#ref-for-css-declaration-property-name①⓪">(7)</a> <a href="#ref-for-css-declaration-property-name①①">(8)</a> <a href="#ref-for-css-declaration-property-name①②">(9)</a> <a href="#ref-for-css-declaration-property-name①③">(10)</a> <a href="#ref-for-css-declaration-property-name①④">(11)</a> <a href="#ref-for-css-declaration-property-name①⑤">(12)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="css-declaration-value">
   <b><a href="#css-declaration-value">#css-declaration-value</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-declaration-value">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-css-declaration-value①">(2)</a> <a href="#ref-for-css-declaration-value②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="css-declaration-important-flag">
   <b><a href="#css-declaration-important-flag">#css-declaration-important-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-declaration-important-flag">6.6. CSS Declaration Blocks</a> <a href="#ref-for-css-declaration-important-flag①">(2)</a> <a href="#ref-for-css-declaration-important-flag②">(3)</a>
    <li><a href="#ref-for-css-declaration-important-flag③">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-css-declaration-important-flag④">(2)</a> <a href="#ref-for-css-declaration-important-flag⑤">(3)</a> <a href="#ref-for-css-declaration-important-flag⑥">(4)</a> <a href="#ref-for-css-declaration-important-flag⑦">(5)</a> <a href="#ref-for-css-declaration-important-flag⑧">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="css-declaration-block">
   <b><a href="#css-declaration-block">#css-declaration-block</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-declaration-block">6.6. CSS Declaration Blocks</a> <a href="#ref-for-css-declaration-block①">(2)</a> <a href="#ref-for-css-declaration-block②">(3)</a> <a href="#ref-for-css-declaration-block③">(4)</a> <a href="#ref-for-css-declaration-block④">(5)</a> <a href="#ref-for-css-declaration-block⑤">(6)</a> <a href="#ref-for-css-declaration-block⑥">(7)</a>
    <li><a href="#ref-for-css-declaration-block⑦">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-css-declaration-block⑧">(2)</a> <a href="#ref-for-css-declaration-block⑨">(3)</a> <a href="#ref-for-css-declaration-block①⓪">(4)</a>
    <li><a href="#ref-for-css-declaration-block①①">7.1. 
The ElementCSSInlineStyle Mixin</a>
    <li><a href="#ref-for-css-declaration-block①②">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssstyledeclaration-computed-flag">
   <b><a href="#cssstyledeclaration-computed-flag">#cssstyledeclaration-computed-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssstyledeclaration-computed-flag">6.4.3. The CSSStyleRule Interface</a>
    <li><a href="#ref-for-cssstyledeclaration-computed-flag①">6.4.7. The CSSPageRule Interface</a>
    <li><a href="#ref-for-cssstyledeclaration-computed-flag②">6.4.8. The CSSMarginRule Interface</a>
    <li><a href="#ref-for-cssstyledeclaration-computed-flag③">6.6. CSS Declaration Blocks</a> <a href="#ref-for-cssstyledeclaration-computed-flag④">(2)</a> <a href="#ref-for-cssstyledeclaration-computed-flag⑤">(3)</a>
    <li><a href="#ref-for-cssstyledeclaration-computed-flag⑥">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-cssstyledeclaration-computed-flag⑦">(2)</a> <a href="#ref-for-cssstyledeclaration-computed-flag⑧">(3)</a> <a href="#ref-for-cssstyledeclaration-computed-flag⑨">(4)</a>
    <li><a href="#ref-for-cssstyledeclaration-computed-flag①⓪">7.1. 
The ElementCSSInlineStyle Mixin</a>
    <li><a href="#ref-for-cssstyledeclaration-computed-flag①①">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssstyledeclaration-declarations">
   <b><a href="#cssstyledeclaration-declarations">#cssstyledeclaration-declarations</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssstyledeclaration-declarations">6.4.3. The CSSStyleRule Interface</a>
    <li><a href="#ref-for-cssstyledeclaration-declarations①">6.4.7. The CSSPageRule Interface</a>
    <li><a href="#ref-for-cssstyledeclaration-declarations②">6.4.8. The CSSMarginRule Interface</a>
    <li><a href="#ref-for-cssstyledeclaration-declarations③">6.6. CSS Declaration Blocks</a> <a href="#ref-for-cssstyledeclaration-declarations④">(2)</a> <a href="#ref-for-cssstyledeclaration-declarations⑤">(3)</a> <a href="#ref-for-cssstyledeclaration-declarations⑥">(4)</a> <a href="#ref-for-cssstyledeclaration-declarations⑦">(5)</a>
    <li><a href="#ref-for-cssstyledeclaration-declarations⑧">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-cssstyledeclaration-declarations⑨">(2)</a> <a href="#ref-for-cssstyledeclaration-declarations①⓪">(3)</a> <a href="#ref-for-cssstyledeclaration-declarations①①">(4)</a> <a href="#ref-for-cssstyledeclaration-declarations①②">(5)</a> <a href="#ref-for-cssstyledeclaration-declarations①③">(6)</a> <a href="#ref-for-cssstyledeclaration-declarations①④">(7)</a> <a href="#ref-for-cssstyledeclaration-declarations①⑤">(8)</a> <a href="#ref-for-cssstyledeclaration-declarations①⑥">(9)</a> <a href="#ref-for-cssstyledeclaration-declarations①⑦">(10)</a> <a href="#ref-for-cssstyledeclaration-declarations①⑧">(11)</a> <a href="#ref-for-cssstyledeclaration-declarations①⑨">(12)</a>
    <li><a href="#ref-for-cssstyledeclaration-declarations②⓪">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssstyledeclaration-parent-css-rule">
   <b><a href="#cssstyledeclaration-parent-css-rule">#cssstyledeclaration-parent-css-rule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssstyledeclaration-parent-css-rule">6.4.3. The CSSStyleRule Interface</a>
    <li><a href="#ref-for-cssstyledeclaration-parent-css-rule①">6.4.7. The CSSPageRule Interface</a>
    <li><a href="#ref-for-cssstyledeclaration-parent-css-rule②">6.4.8. The CSSMarginRule Interface</a>
    <li><a href="#ref-for-cssstyledeclaration-parent-css-rule③">6.6.1. The CSSStyleDeclaration Interface</a>
    <li><a href="#ref-for-cssstyledeclaration-parent-css-rule④">7.1. 
The ElementCSSInlineStyle Mixin</a>
    <li><a href="#ref-for-cssstyledeclaration-parent-css-rule⑤">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssstyledeclaration-owner-node">
   <b><a href="#cssstyledeclaration-owner-node">#cssstyledeclaration-owner-node</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssstyledeclaration-owner-node">6.4.3. The CSSStyleRule Interface</a>
    <li><a href="#ref-for-cssstyledeclaration-owner-node①">6.4.7. The CSSPageRule Interface</a>
    <li><a href="#ref-for-cssstyledeclaration-owner-node②">6.4.8. The CSSMarginRule Interface</a>
    <li><a href="#ref-for-cssstyledeclaration-owner-node③">6.6. CSS Declaration Blocks</a> <a href="#ref-for-cssstyledeclaration-owner-node④">(2)</a> <a href="#ref-for-cssstyledeclaration-owner-node⑤">(3)</a> <a href="#ref-for-cssstyledeclaration-owner-node⑥">(4)</a>
    <li><a href="#ref-for-cssstyledeclaration-owner-node⑦">7.1. 
The ElementCSSInlineStyle Mixin</a>
    <li><a href="#ref-for-cssstyledeclaration-owner-node⑧">7.2. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssstyledeclaration-updating-flag">
   <b><a href="#cssstyledeclaration-updating-flag">#cssstyledeclaration-updating-flag</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssstyledeclaration-updating-flag">6.6. CSS Declaration Blocks</a> <a href="#ref-for-cssstyledeclaration-updating-flag①">(2)</a> <a href="#ref-for-cssstyledeclaration-updating-flag②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="parse-a-css-declaration-block">
   <b><a href="#parse-a-css-declaration-block">#parse-a-css-declaration-block</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-parse-a-css-declaration-block">6.6. CSS Declaration Blocks</a> <a href="#ref-for-parse-a-css-declaration-block①">(2)</a>
    <li><a href="#ref-for-parse-a-css-declaration-block②">6.6.1. The CSSStyleDeclaration Interface</a>
    <li><a href="#ref-for-parse-a-css-declaration-block③">11.2. Changes From 12 July 2011 To 5 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-a-css-declaration">
   <b><a href="#serialize-a-css-declaration">#serialize-a-css-declaration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-css-declaration">6.6. CSS Declaration Blocks</a> <a href="#ref-for-serialize-a-css-declaration①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-a-css-declaration-block">
   <b><a href="#serialize-a-css-declaration-block">#serialize-a-css-declaration-block</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-css-declaration-block">6.4. CSS Rules</a>
    <li><a href="#ref-for-serialize-a-css-declaration-block①">6.6. CSS Declaration Blocks</a>
    <li><a href="#ref-for-serialize-a-css-declaration-block②">6.6.1. The CSSStyleDeclaration Interface</a>
    <li><a href="#ref-for-serialize-a-css-declaration-block③">11.2. Changes From 12 July 2011 To 5 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="update-style-attribute-for">
   <b><a href="#update-style-attribute-for">#update-style-attribute-for</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-update-style-attribute-for">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-update-style-attribute-for①">(2)</a> <a href="#ref-for-update-style-attribute-for②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-shorthands-preferred-order">
   <b><a href="#concept-shorthands-preferred-order">#concept-shorthands-preferred-order</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-shorthands-preferred-order">6.6. CSS Declaration Blocks</a>
    <li><a href="#ref-for-concept-shorthands-preferred-order①">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssstyledeclaration">
   <b><a href="#cssstyledeclaration">#cssstyledeclaration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssstyledeclaration">6.4.3. The CSSStyleRule Interface</a>
    <li><a href="#ref-for-cssstyledeclaration①">6.4.7. The CSSPageRule Interface</a>
    <li><a href="#ref-for-cssstyledeclaration②">6.4.8. The CSSMarginRule Interface</a>
    <li><a href="#ref-for-cssstyledeclaration③">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-cssstyledeclaration④">(2)</a> <a href="#ref-for-cssstyledeclaration⑤">(3)</a> <a href="#ref-for-cssstyledeclaration⑥">(4)</a>
    <li><a href="#ref-for-cssstyledeclaration⑦">7.1. 
The ElementCSSInlineStyle Mixin</a>
    <li><a href="#ref-for-cssstyledeclaration⑧">7.2. Extensions to the Window Interface</a>
    <li><a href="#ref-for-cssstyledeclaration⑨">11.1. Changes From 5 December 2013</a> <a href="#ref-for-cssstyledeclaration①⓪">(2)</a> <a href="#ref-for-cssstyledeclaration①①">(3)</a>
    <li><a href="#ref-for-cssstyledeclaration①②">11.2. Changes From 12 July 2011 To 5 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstyledeclaration-csstext">
   <b><a href="#dom-cssstyledeclaration-csstext">#dom-cssstyledeclaration-csstext</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstyledeclaration-csstext">6.4.3. The CSSStyleRule Interface</a>
    <li><a href="#ref-for-dom-cssstyledeclaration-csstext①">6.4.7. The CSSPageRule Interface</a>
    <li><a href="#ref-for-dom-cssstyledeclaration-csstext②">6.4.8. The CSSMarginRule Interface</a>
    <li><a href="#ref-for-dom-cssstyledeclaration-csstext③">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-dom-cssstyledeclaration-csstext④">(2)</a>
    <li><a href="#ref-for-dom-cssstyledeclaration-csstext⑤">7.1. 
The ElementCSSInlineStyle Mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstyledeclaration-length">
   <b><a href="#dom-cssstyledeclaration-length">#dom-cssstyledeclaration-length</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstyledeclaration-length">6.6.1. The CSSStyleDeclaration Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstyledeclaration-item">
   <b><a href="#dom-cssstyledeclaration-item">#dom-cssstyledeclaration-item</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstyledeclaration-item">6.6.1. The CSSStyleDeclaration Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstyledeclaration-getpropertyvalue">
   <b><a href="#dom-cssstyledeclaration-getpropertyvalue">#dom-cssstyledeclaration-getpropertyvalue</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstyledeclaration-getpropertyvalue">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-dom-cssstyledeclaration-getpropertyvalue①">(2)</a> <a href="#ref-for-dom-cssstyledeclaration-getpropertyvalue②">(3)</a> <a href="#ref-for-dom-cssstyledeclaration-getpropertyvalue③">(4)</a> <a href="#ref-for-dom-cssstyledeclaration-getpropertyvalue④">(5)</a> <a href="#ref-for-dom-cssstyledeclaration-getpropertyvalue⑤">(6)</a>
    <li><a href="#ref-for-dom-cssstyledeclaration-getpropertyvalue⑥">11.2. Changes From 12 July 2011 To 5 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstyledeclaration-getpropertypriority">
   <b><a href="#dom-cssstyledeclaration-getpropertypriority">#dom-cssstyledeclaration-getpropertypriority</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstyledeclaration-getpropertypriority">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-dom-cssstyledeclaration-getpropertypriority①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstyledeclaration-setproperty">
   <b><a href="#dom-cssstyledeclaration-setproperty">#dom-cssstyledeclaration-setproperty</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstyledeclaration-setproperty">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-dom-cssstyledeclaration-setproperty①">(2)</a> <a href="#ref-for-dom-cssstyledeclaration-setproperty②">(3)</a> <a href="#ref-for-dom-cssstyledeclaration-setproperty③">(4)</a> <a href="#ref-for-dom-cssstyledeclaration-setproperty④">(5)</a>
    <li><a href="#ref-for-dom-cssstyledeclaration-setproperty⑤">11.1. Changes From 5 December 2013</a>
    <li><a href="#ref-for-dom-cssstyledeclaration-setproperty⑥">11.2. Changes From 12 July 2011 To 5 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="set-a-css-declaration">
   <b><a href="#set-a-css-declaration">#set-a-css-declaration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-set-a-css-declaration">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-set-a-css-declaration①">(2)</a> <a href="#ref-for-set-a-css-declaration②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstyledeclaration-removeproperty">
   <b><a href="#dom-cssstyledeclaration-removeproperty">#dom-cssstyledeclaration-removeproperty</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstyledeclaration-removeproperty">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-dom-cssstyledeclaration-removeproperty①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstyledeclaration-parentrule">
   <b><a href="#dom-cssstyledeclaration-parentrule">#dom-cssstyledeclaration-parentrule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstyledeclaration-parentrule">6.6.1. The CSSStyleDeclaration Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstyledeclaration-cssfloat">
   <b><a href="#dom-cssstyledeclaration-cssfloat">#dom-cssstyledeclaration-cssfloat</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstyledeclaration-cssfloat">6.6.1. The CSSStyleDeclaration Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstyledeclaration-camel-cased-attribute">
   <b><a href="#dom-cssstyledeclaration-camel-cased-attribute">#dom-cssstyledeclaration-camel-cased-attribute</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstyledeclaration-camel-cased-attribute">6.6.1. The CSSStyleDeclaration Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstyledeclaration-webkit-cased-attribute">
   <b><a href="#dom-cssstyledeclaration-webkit-cased-attribute">#dom-cssstyledeclaration-webkit-cased-attribute</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstyledeclaration-webkit-cased-attribute">6.6.1. The CSSStyleDeclaration Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssstyledeclaration-dashed-attribute">
   <b><a href="#dom-cssstyledeclaration-dashed-attribute">#dom-cssstyledeclaration-dashed-attribute</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssstyledeclaration-dashed-attribute">6.6.1. The CSSStyleDeclaration Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="css-property-to-idl-attribute">
   <b><a href="#css-property-to-idl-attribute">#css-property-to-idl-attribute</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-property-to-idl-attribute">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-css-property-to-idl-attribute①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="idl-attribute-to-css-property">
   <b><a href="#idl-attribute-to-css-property">#idl-attribute-to-css-property</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-attribute-to-css-property">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-idl-attribute-to-css-property①">(2)</a> <a href="#ref-for-idl-attribute-to-css-property②">(3)</a> <a href="#ref-for-idl-attribute-to-css-property③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="parse-a-css-value">
   <b><a href="#parse-a-css-value">#parse-a-css-value</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-parse-a-css-value">6.6.1. The CSSStyleDeclaration Interface</a>
    <li><a href="#ref-for-parse-a-css-value①">6.7.1. Parsing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-a-css-value">
   <b><a href="#serialize-a-css-value">#serialize-a-css-value</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-css-value">6.6. CSS Declaration Blocks</a> <a href="#ref-for-serialize-a-css-value①">(2)</a>
    <li><a href="#ref-for-serialize-a-css-value②">6.6.1. The CSSStyleDeclaration Interface</a> <a href="#ref-for-serialize-a-css-value③">(2)</a>
    <li><a href="#ref-for-serialize-a-css-value④">6.7.2. Serializing CSS Values</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="serialize-a-css-component-value">
   <b><a href="#serialize-a-css-component-value">#serialize-a-css-component-value</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-serialize-a-css-component-value">6.7.2. Serializing CSS Values</a> <a href="#ref-for-serialize-a-css-component-value①">(2)</a> <a href="#ref-for-serialize-a-css-component-value②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="elementcssinlinestyle">
   <b><a href="#elementcssinlinestyle">#elementcssinlinestyle</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-elementcssinlinestyle">7.1. 
The ElementCSSInlineStyle Mixin</a> <a href="#ref-for-elementcssinlinestyle①">(2)</a> <a href="#ref-for-elementcssinlinestyle②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-elementcssinlinestyle-style">
   <b><a href="#dom-elementcssinlinestyle-style">#dom-elementcssinlinestyle-style</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-elementcssinlinestyle-style">7.1. 
The ElementCSSInlineStyle Mixin</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-getcomputedstyle">
   <b><a href="#dom-window-getcomputedstyle">#dom-window-getcomputedstyle</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-getcomputedstyle">7.2. Extensions to the Window Interface</a> <a href="#ref-for-dom-window-getcomputedstyle①">(2)</a>
    <li><a href="#ref-for-dom-window-getcomputedstyle②">9. Resolved Values</a> <a href="#ref-for-dom-window-getcomputedstyle③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="namespacedef-css">
   <b><a href="#namespacedef-css">#namespacedef-css</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-namespacedef-css">8.1. The CSS.escape() Method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-css-escape">
   <b><a href="#dom-css-escape">#dom-css-escape</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-css-escape">8.1. The CSS.escape() Method</a> <a href="#ref-for-dom-css-escape①">(2)</a> <a href="#ref-for-dom-css-escape②">(3)</a>
    <li><a href="#ref-for-dom-css-escape③">11.2. Changes From 12 July 2011 To 5 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="resolved-value">
   <b><a href="#resolved-value">#resolved-value</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-resolved-value">7.2. Extensions to the Window Interface</a>
    <li><a href="#ref-for-resolved-value①">9. Resolved Values</a> <a href="#ref-for-resolved-value②">(2)</a> <a href="#ref-for-resolved-value③">(3)</a> <a href="#ref-for-resolved-value④">(4)</a> <a href="#ref-for-resolved-value⑤">(5)</a> <a href="#ref-for-resolved-value⑥">(6)</a> <a href="#ref-for-resolved-value⑦">(7)</a> <a href="#ref-for-resolved-value⑧">(8)</a> <a href="#ref-for-resolved-value⑨">(9)</a> <a href="#ref-for-resolved-value①⓪">(10)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="http-default-style">
   <b><a href="#http-default-style">#http-default-style</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-http-default-style">6.2.1. The HTTP Default-Style Header</a> <a href="#ref-for-http-default-style①">(2)</a>
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
<script>/* script-mdn-anno */

            function positionAnnos() {
                var annos = [].slice.call(document.querySelectorAll(".mdn-anno"));
                for(var i = 0; i < annos.length; i++) {
                    var anno = annos[i];
                    id = anno.getAttribute("data-mdn-for");
                    var dfn = document.querySelector("[id='" + id +"']");
                    if (dfn !== null) {
                        var rect = dfn.getBoundingClientRect(id);
                        anno.style.top = (window.scrollY + rect.top) + "px";
                        /* See https://domspec.herokuapp.com/#dom-event-cancelable
                         * for an example of a spec that defines multiple terms in
                         * the same sentence on the same line. In such cases, we
                         * need to offset the vertical positioning of each Nth anno
                         * for that term, to prevent the annos from being placed
                         * exactly on top of the previous ones at that position. */
                        var top = anno.style.top;
                        var offset = 10 * (document.querySelectorAll("[style='top: " + top + ";']").length - 1)
                        anno.style.top = (Number(top.slice(0, -2)) + offset) + "px";
                    } else {
                        console.error('MDN anno references non-existent element ID "%s".%o', id, anno);
                    }
                }
            }
            window.addEventListener("load", positionAnnos())
            document.body.addEventListener("click", (e) => {
                if(e.target.closest(".mdn-anno-btn")) {
                    e.target.closest(".mdn-anno").classList.toggle("wrapped");
                }
            });
            /* If this is a document styled for W3C publication with a ToC
             * sidebar, and the ToC "Collapse Sidebar" button is pushed, some
             * MDN annos seem to end up getting wildly out of place unless we
             * reposition them where they belong. */
            const tocToggle = document.querySelector("#toc-toggle");
            if (tocToggle) {
                tocToggle.addEventListener("click", () => positionAnnos());
            }
            </script><a class='link-error' href='/bikeshed/cssom/' id='generator' title='Bikeshed Link Errors'><svg height='24' viewbox='0 0 100 100' width='24'><g stroke="blue" stroke-width="6" fill="none"><path fill="blue" stroke="none" d="M 5 95 L 5 35 L 50 10 L 50 95"/><path d="M 1 37 L 54 8"/><path fill="blue" stroke="none" d="M 1 40 v -6 l 60 -32 v 6 z" /><circle cx="75" cy="79" r="15" /><circle fill="blue" stroke="none" cx="75" cy="79" r="4" /><path d="M 75 79 L 65 49 L 55 49" /><path d="M 67 55 L 48 69" /></g></svg></a>