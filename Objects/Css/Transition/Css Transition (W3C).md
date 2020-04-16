<!doctype html><html lang="en">
 <head>
  <meta content="text/html; charset=utf-8" http-equiv="Content-Type">
  <title>CSS Transitions</title>
  <meta content="width=device-width, initial-scale=1, shrink-to-fit=no" name="viewport">
  <meta content="refining" name="csswg-work-status">
  <meta content="ED" name="w3c-status">
  <meta content="CSS Transitions allows property changes in CSS values to occur smoothly over a specified duration." name="abstract">
  <link href="../default.css" rel="stylesheet" type="text/css">
  <link href="../csslogo.ico" rel="shortcut icon" type="image/x-icon">
<style>
  body {
    background: url("https://www.w3.org/StyleSheets/TR/logo-ED") top left no-repeat;
  }
  </style>
  <meta content="Bikeshed version d4d56a96, updated Fri Apr 10 11:10:34 2020 -0700" name="generator">
  <link href="https://www.w3.org/TR/css-transitions-1/" rel="canonical">
<script defer src="https://test.csswg.org/harness/annotate.js#!css-transitions-1_dev/css-transitions-1" type="text/javascript"></script>
<style type="text/css">
    div.prod { margin: 1em 2em; }

    table.event-handlers {
      border-collapse: collapse;
    }
    table.event-handlers th,
    table.event-handlers td {
      padding: 0.2em 1em;
    }
    table.event-handlers td {
      border: 1px solid black;
    }
  </style>
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
 <script nonce='ySBNYfzJTuqXl+8DFjZj26s2D+IZrmgUiwQvO7BCcro=' type='text/javascript'><!--
Stream=function(uri,params,callback){this.xhr=new XMLHttpRequest();this.callback=callback;this.persist=false;if(!params){params={};}var loginKey=system.getCookie('loginkey');if(loginKey){params['loginkey']=loginKey;}params['stream']=++this.gStreamId;this.uri=(params ?uri+'?'+system.encodeParams(params):uri);var stream=this;this.xhr.onreadystatechange=function(){if((200==stream.xhr.status)&&((3==stream.xhr.readyState)||(4==stream.xhr.readyState))){var message=stream.xhr.responseText.substring(stream.processed);if(-1!=message.indexOf("\uEE00\uEEFF\uEE00")){var messages=message.split("\uEE00\uEEFF\uEE00");for(var index=0;index<(messages.length-1);index++){message=messages[index];stream.processed+=(message.length+3);try{response=JSON.parse(message.trim());}catch(err){console.log("stream parse error: "+message.trim());console.log(err);continue;}stream.callback(response.message,response.data);}}if(4==stream.xhr.readyState){if(stream.persist&&(!stream.closed)){setTimeout(function(){if(!stream.closed){stream.connect();}},10);}stream.closed=true;}}};this.connect();return this;};Stream.prototype={gStreamId:Math.floor(Math.random()*0xFFFFFFFF),connect:function(){this.processed=0;this.closed=false;this.xhr.open('GET',this.uri,true);this.xhr.setRequestHeader('Accept','application/json');this.xhr.send();},close:function(){this.closed=true;if((4!=this.xhr.readyState)&&(0!=this.xhr.readyState)){this.xhr.abort();}},setTimeout:function(callback,timeoutMS){this.xhr.timeout=timeoutMS;var stream=this;this.xhr.ontimeout=function(){stream.closed=true;callback(stream);};},};
// --></script><script nonce='ySBNYfzJTuqXl+8DFjZj26s2D+IZrmgUiwQvO7BCcro=' type='text/javascript'><!--
var gDraftAPIURI="https:\/\/drafts.csswg.org\/api\/drafts\/";var gCookiePrefix="drafts_";var gRepo="csswg";var gDate=false;var gBranch=null;var gHead=null;var gRepoPath="css-transitions-1\/Overview.bs";if(!Array.indexOf){Array.prototype.indexOf=function(obj){for(var index=0;index<this.length;index++){if(this[index]==obj){return index;}}return-1;}}if(!Date.now){Date.now=function(){return new Date().getTime();}}try{if(1!=Node.ELEMENT_NODE){throw true;}}catch(exc){var Node={ELEMENT_NODE:1,ATTRIBUTE_NODE:2,TEXT_NODE:3};}var system={getCookie:function(name){var cookies=document.cookie.split(';');name+='=';var prefixedName=gCookiePrefix+name;for(var index=0;index<cookies.length;index++){cookie=cookies[index].trim();if(prefixedName==cookie.substring(0,prefixedName.length)){return unescape(cookie.substring(prefixedName.length));}if(name==cookie.substring(0,name.length)){return unescape(cookie.substring(name.length));}}return null;},encodeParams:function(params,arrayName){var paramString='';for(param in params){if(params.hasOwnProperty(param)){if(paramString){paramString+='&';}var name=param;if(arrayName){name=arrayName+'['+param+']';}if(Array.isArray(params[param])){for(var index=0;index<params[param].length;index++){paramString+=name+'[]='+params[param][index];}}else if('object'==typeof(params[param])){paramString+=this.encodeParams(params[param],param);}else if('boolean'==typeof(params[param])){paramString+=name+'='+(params[param]+0);}else{paramString+=name+'='+encodeURIComponent(params[param]);}}}return paramString;},addLoadEvent:function(onLoad){try{var oldOnLoad=window.onload;if('function'!=typeof(window.onload)){window.onload=onLoad;}else{window.onload=function(){if(oldOnLoad){oldOnLoad();}onLoad();}}}catch(err){}}};var updateCount=0;var maxStreamListenTime=5*60*1000;var minStreamListenTime=10*1000;var streamInterval=20*60*1000;var streamListenTime=maxStreamListenTime;var streamStartTime=0;function updateBikeshed(message,data){var bikeshedIcon=document.getElementById('bikeshed');if(bikeshedIcon){bikeshedIcon.setAttribute('class',data.status);switch(data.status){case'pending':case'generating':bikeshedIcon.setAttribute('title','Bikeshed Pending');break;case'success':bikeshedIcon.setAttribute('title','Bikeshed Succeeded');break;case'warning':bikeshedIcon.setAttribute('title','Bikeshed Warnings');break;case'fatal':bikeshedIcon.setAttribute('title','Bikeshed Errors');break;case'previous':case'error':bikeshedIcon.setAttribute('title','Bikeshed Failed');break;}}updateCount++;if((1<updateCount)||(gDate&&(data.date!=gDate))){streamListenTime=maxStreamListenTime;gUpdateStream.setTimeout(streamTimeout,(Date.now()-streamStartTime)+streamListenTime);if((gDate<data.date)&&(('committed'==data.status)||('success'==data.status)||('warning'==data.status))){window.location.reload();}}gDate=data.date;}function streamTimeout(stream){streamListenTime=minStreamListenTime;setTimeout(function(){startStream();},streamInterval);}function startStream(){updateCount=0;streamStartTime=Date.now();gUpdateStream=new Stream(gDraftAPIURI,{'repo':gRepo,'date':gDate,'branch':gBranch,'head':gHead,'path':gRepoPath},updateBikeshed);gUpdateStream.persist=true;gUpdateStream.setTimeout(streamTimeout,streamListenTime);}function setupPage(){var bikeshedIcon=document.getElementById('bikeshed');if(bikeshedIcon){bikeshedIcon.onclick=function(domEvent){if(domEvent.shiftKey){var url=bikeshedIcon.getAttribute('href').replace('/bikeshed/','/static/')+window.location.hash;window.location.href=url;if(domEvent){(domEvent.preventDefault)?domEvent.preventDefault():domEvent.returnValue=false;}}};}startStream();}system.addLoadEvent(setupPage);
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
   <h1 class="p-name no-ref" id="title">CSS Transitions</h1>
   <h2 class="no-num no-toc no-ref heading settled" id="subtitle"><span class="content">Editor’s Draft, <time class="dt-updated" datetime="2020-01-16">16 January 2020</time></span></h2>
   <details>
    <summary>Specification Metadata</summary>
    <div data-fill-with="spec-metadata">
     <dl>
      <dt>This version:
      <dd><a class="u-url" href="https://drafts.csswg.org/css-transitions/">https://drafts.csswg.org/css-transitions/</a>
      <dt>Latest published version:
      <dd><a href="https://www.w3.org/TR/css-transitions-1/">https://www.w3.org/TR/css-transitions-1/</a>
      <dt>Previous Versions:
      <dd><a href="https://www.w3.org/TR/2018/WD-css-transitions-1-20181011/" rel="prev">https://www.w3.org/TR/2018/WD-css-transitions-1-20181011/</a>
      <dd><a href="https://www.w3.org/TR/2017/WD-css-transitions-1-20171130/" rel="prev">https://www.w3.org/TR/2017/WD-css-transitions-1-20171130/</a>
      <dd><a href="https://www.w3.org/TR/2013/WD-css3-transitions-20131119/" rel="prev">https://www.w3.org/TR/2013/WD-css3-transitions-20131119/</a>
      <dt>Test Suite:
      <dd><a href="http://test.csswg.org/suites/css-transitions-1_dev/nightly-unstable/">http://test.csswg.org/suites/css-transitions-1_dev/nightly-unstable/</a>
      <dt>Issue Tracking:
      <dd><a href="https://www.w3.org/Bugs/Public/buglist.cgi?query_format=advanced&amp;amp;product=CSS&amp;amp;component=Transitions&amp;amp;resolution=---&amp;amp;status_whiteboard=defer%20to%20level%202&amp;amp;status_whiteboard_type=notregexp">Bugzilla bugs for this level</a>
      <dd><a href="https://www.w3.org/Bugs/Public/buglist.cgi?query_format=advanced&amp;amp;product=CSS&amp;amp;component=Transitions&amp;amp;resolution=---">Bugzilla bugs for all levels</a>
      <dd><a href="https://github.com/w3c/csswg-drafts/labels/css-transitions-1">GitHub Issues</a>
      <dt class="editor">Editors:
      <dd class="editor p-author h-card vcard" data-editor-id="15393"><a class="p-name fn u-url url" href="https://dbaron.org/">L. David Baron</a> (<a class="p-org org" href="https://www.mozilla.org/">Mozilla</a>)
      <dd class="editor p-author h-card vcard" data-editor-id="42080"><a class="p-name fn u-email email" href="mailto:dino@apple.com">Dean Jackson</a> (<a class="p-org org" href="https://www.apple.com/">Apple Inc</a>)
      <dd class="editor p-author h-card vcard" data-editor-id="43194"><a class="p-name fn u-email email" href="mailto:bbirtles@mozilla.com">Brian Birtles</a> (<a class="p-org org" href="https://www.mozilla.org/">Mozilla</a>)
      <dt class="editor">Former Editors:
      <dd class="editor p-author h-card vcard" data-editor-id="34140"><a class="p-name fn u-email email" href="mailto:hyatt@apple.com">David Hyatt</a> (<a class="p-org org" href="https://www.apple.com/">Apple Inc</a>)
      <dd class="editor p-author h-card vcard"><a class="p-name fn u-email email" href="mailto:cmarrin@apple.com">Chris Marrin</a> (<a class="p-org org" href="https://www.apple.com/">Apple Inc</a>)
      <dt>Suggest an Edit for this Spec:
      <dd><a href="https://github.com/w3c/csswg-drafts/blob/master/css-transitions-1/Overview.bs">GitHub Editor</a>
     </dl>
    </div>
   </details>
   <div data-fill-with="warning"></div>
   <p class="copyright" data-fill-with="copyright"><a href="https://www.w3.org/Consortium/Legal/ipr-notice#Copyright">Copyright</a> © 2020 <a href="https://www.w3.org/"><abbr title="World Wide Web Consortium">W3C</abbr></a><sup>®</sup> (<a href="https://www.csail.mit.edu/"><abbr title="Massachusetts Institute of Technology">MIT</abbr></a>, <a href="https://www.ercim.eu/"><abbr title="European Research Consortium for Informatics and Mathematics">ERCIM</abbr></a>, <a href="https://www.keio.ac.jp/">Keio</a>, <a href="https://ev.buaa.edu.cn/">Beihang</a>). W3C <a href="https://www.w3.org/Consortium/Legal/ipr-notice#Legal_Disclaimer">liability</a>, <a href="https://www.w3.org/Consortium/Legal/ipr-notice#W3C_Trademarks">trademark</a> and <a href="https://www.w3.org/Consortium/Legal/2015/copyright-software-and-document">permissive document license</a> rules apply. </p>
   <hr title="Separator for header">
  </div>
  <div class="p-summary" data-fill-with="abstract">
   <h2 class="no-num no-toc no-ref heading settled" id="abstract"><span class="content">Abstract</span></h2>
   <p>CSS Transitions allows property changes in CSS values to occur smoothly over a specified duration.</p>
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
	When filing an issue, please put the text “css-transitions” in the title,
	preferably like this:
	“[css-transitions] <i data-lt>…summary of comment…</i>”.
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
   <p><strong>This document</strong> is expected to be relatively close to last call.  While some issues raised have yet to be addressed, new features are extremely unlikely to be considered for this level.</p>
  </div>
  <div data-fill-with="at-risk"></div>
  <nav data-fill-with="table-of-contents" id="toc">
   <h2 class="no-num no-toc no-ref" id="contents">Table of Contents</h2>
   <ol class="toc" role="directory">
    <li>
     <a href="#introduction"><span class="secno">1</span> <span class="content">Introduction</span></a>
     <ol class="toc">
      <li><a href="#values"><span class="secno">1.1</span> <span class="content">Value Definitions</span></a>
     </ol>
    <li>
     <a href="#transitions"><span class="secno">2</span> <span class="content"><span>Transitions</span></span></a>
     <ol class="toc">
      <li><a href="#transition-property-property"><span class="secno">2.1</span> <span class="content"><span>The <span class="property">transition-property</span> Property</span></span></a>
      <li><a href="#transition-duration-property"><span class="secno">2.2</span> <span class="content"><span>The <span class="property">transition-duration</span> Property</span></span></a>
      <li><a href="#transition-timing-function-property"><span class="secno">2.3</span> <span class="content"><span>The <span class="property">transition-timing-function</span> Property</span></span></a>
      <li><a href="#transition-delay-property"><span class="secno">2.4</span> <span class="content"><span>The <span class="property">transition-delay</span> Property</span></span></a>
      <li><a href="#transition-shorthand-property"><span class="secno">2.5</span> <span class="content"><span>The <span class="property">transition</span> Shorthand Property</span></span></a>
     </ol>
    <li>
     <a href="#starting"><span class="secno">3</span> <span class="content">Starting of transitions</span></a>
     <ol class="toc">
      <li><a href="#reversing"><span class="secno">3.1</span> <span class="content">Faster reversing of interrupted transitions</span></a>
     </ol>
    <li><a href="#application"><span class="secno">4</span> <span class="content">Application of transitions</span></a>
    <li><a href="#complete"><span class="secno">5</span> <span class="content">Completion of transitions</span></a>
    <li>
     <a href="#transition-events"><span class="secno">6</span> <span class="content"><span>Transition Events</span></span></a>
     <ol class="toc">
      <li>
       <a href="#interface-transitionevent"><span class="secno">6.1</span> <span class="content">Interface <code class="idl"><span>TransitionEvent</span></code></span></a>
       <ol class="toc">
        <li><a href="#interface-transitionevent-idl"><span class="secno">6.1.1</span> <span class="content">IDL Definition</span></a>
        <li><a href="#interface-transitionevent-attributes"><span class="secno">6.1.2</span> <span class="content">Attributes</span></a>
       </ol>
      <li><a href="#event-transitionevent"><span class="secno">6.2</span> <span class="content">Types of <code>TransitionEvent</code></span></a>
      <li><a href="#event-handlers-on-elements-document-objects-and-window-objects"><span class="secno">6.3</span> <span class="content">Event handlers on elements, <code>Document</code> objects, and <code>Window</code> objects</span></a>
     </ol>
    <li>
     <a href="#interface-dom"><span class="secno">7</span> <span class="content">DOM Interfaces</span></a>
     <ol class="toc">
      <li><a href="#interface-globaleventhandlers-idl"><span class="secno">7.1</span> <span class="content">IDL Definition</span></a>
     </ol>
    <li><a href="#security"><span class="secno">8</span> <span class="content">Security Considerations</span></a>
    <li><a href="#privacy"><span class="secno">9</span> <span class="content">Privacy Considerations</span></a>
    <li>
     <a href="#accessibility"><span class="secno">10</span> <span class="content">Accessibility Considerations</span></a>
     <ol class="toc">
      <li><a href="#accessibility-motion"><span class="secno">10.1</span> <span class="content">Motion</span></a>
      <li><a href="#accessibility-cascade"><span class="secno">10.2</span> <span class="content">Cascade</span></a>
     </ol>
    <li><a href="#changes"><span class="secno">11</span> <span class="content">Changes since Working Draft of 30 November 2017</span></a>
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
    <li><a href="#property-index"><span class="secno"></span> <span class="content">Property Index</span></a>
    <li><a href="#idl-index"><span class="secno"></span> <span class="content">IDL Index</span></a>
   </ol>
  </nav>
  <main>
   <h2 class="heading settled" data-level="1" id="introduction"><span class="secno">1. </span><span class="content">Introduction</span><a class="self-link" href="#introduction"></a></h2>
   <p><em>This section is not normative.</em> </p>
   <p> This document introduces new CSS features to enable <em>implicit transitions</em>, which describe how CSS properties can be made to change smoothly from one value to another over a given duration. </p>
   <h3 class="heading settled" data-level="1.1" id="values"><span class="secno">1.1. </span><span class="content">Value Definitions</span><a class="self-link" href="#values"></a></h3>
   <p>This specification follows the <a href="https://www.w3.org/TR/CSS2/about.html#property-defs">CSS property definition conventions</a> from <a data-link-type="biblio" href="#biblio-css2">[CSS2]</a> using the <a href="https://www.w3.org/TR/css-values-3/#value-defs">value definition syntax</a> from <a data-link-type="biblio" href="#biblio-css-values-3">[CSS-VALUES-3]</a>.
      Value types not defined in this specification are defined in CSS Values &amp; Units <span>[CSS-VALUES-3]</span>.
      Combination with other CSS modules may expand the definitions of these value types.</p>
   <p>In addition to the property-specific values listed in their definitions,
      all properties defined in this specification
      also accept the <a data-link-type="dfn" href="https://drafts.csswg.org/css-values-4/#css-wide-keywords" id="ref-for-css-wide-keywords">CSS-wide keywords</a> keywords as their property value.
      For readability they have not been repeated explicitly.</p>
   <h2 class="heading settled" data-level="2" id="transitions"><span class="secno">2. </span><span class="content"><span id="transitions-">Transitions</span></span><a class="self-link" href="#transitions"></a></h2>
   <p> Normally when the value of a CSS property changes, the rendered result is instantly updated, with the affected elements immediately changing from the old property value to the new property value. This section describes a way to specify transitions using new CSS properties. These properties are used to animate smoothly from the old state to the new state over time. </p>
   <p> For example, suppose that transitions of one second have been defined on the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css2/visuren.html#propdef-left" id="ref-for-propdef-left">left</a> and <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css2/colors.html#propdef-background-color" id="ref-for-propdef-background-color">background-color</a> properties. The following diagram illustrates the effect of updating those properties on an element, in this case moving it to the right and changing the background from red to blue. This assumes other transition parameters still have their default values. </p>
   <figure>
     <img alt="Example showing the initial, intermediate, and final states of a box whose color and position is interpolated" src="transition-example.svg" width="518"> 
    <figcaption> Transitions of <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css2/visuren.html#propdef-left" id="ref-for-propdef-left①">left</a> and <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css2/colors.html#propdef-background-color" id="ref-for-propdef-background-color①">background-color</a>. </figcaption>
   </figure>
   <p> Transitions are a presentational effect. The <a data-link-type="dfn" href="https://drafts.csswg.org/css-cascade-4/#computed-value" id="ref-for-computed-value">computed value</a> of a property transitions over time from the old value to the new value. Therefore if a script queries the <span id="ref-for-computed-value①">computed value</span> of a property (or other data depending on it) as it is transitioning, it will see an intermediate value that represents the current animated value of the property. </p>
   <p> The transition for a property is defined using a number of new properties. For example: </p>
   <div class="example" id="example-c14634d9">
    <a class="self-link" href="#example-c14634d9"></a> 
    <p style="display:none"> Example(s): </p>
<pre>div {
  transition-property: opacity;
  transition-duration: 2s;
}
</pre>
    The above example defines a transition on the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-color-3/#opacity" id="ref-for-opacity">opacity</a> property that, when a new value is assigned to it, will cause a smooth change between the old value and the new value over a period of two seconds. 
   </div>
   <p> Each of the transition properties accepts a comma-separated list, allowing multiple transitions to be defined, each acting on a different property. In this case, the individual transitions take their parameters from the same index in all the lists. For example: </p>
   <div class="example" id="example-0825db11">
    <a class="self-link" href="#example-0825db11"></a> 
    <p style="display:none"> Example(s): </p>
<pre>div {
  transition-property: opacity, left;
  transition-duration: 2s, 4s;
}

</pre>
    This will cause the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-color-3/#opacity" id="ref-for-opacity①">opacity</a> property to transition over a period of two seconds and the left property to transition over a period of four seconds. 
   </div>
   <p id="list-matching"> In the case where the lists of values in transition properties
        do not have the same length, the length of the <a class="property" data-link-type="propdesc" href="#propdef-transition-property" id="ref-for-propdef-transition-property">transition-property</a> list determines the number of items in
        each list examined when starting transitions.  The lists are
        matched up from the first value: excess values at the end are
        not used.  If one of the other properties doesn’t have enough
        comma-separated values to match the number of values of <span class="property" id="ref-for-propdef-transition-property①">transition-property</span>, the user agent must calculate its used value by
        repeating the list of values until there are enough.  This
        truncation or repetition does not affect the computed value. <span class="note"> Note: This is analogous to the behavior of the <a class="property" data-link-type="propdesc">background-*</a> properties, with <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-backgrounds-3/#propdef-background-image" id="ref-for-propdef-background-image">background-image</a> analogous to <a class="property" data-link-type="propdesc" href="#propdef-transition-property" id="ref-for-propdef-transition-property②">transition-property</a>. </span> </p>
   <div class="example" id="example-d94cbd75">
    <a class="self-link" href="#example-d94cbd75"></a> 
    <p style="display:none"> Example(s): </p>
<pre>div {
  transition-property: opacity, left, top, width;
  transition-duration: 2s, 1s;
}
</pre>
    The above example defines a transition on the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-color-3/#opacity" id="ref-for-opacity②">opacity</a> property of 2 seconds duration, a      transition on the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css2/visuren.html#propdef-left" id="ref-for-propdef-left②">left</a> property of 1
      second duration, a transition on the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css2/visuren.html#propdef-top" id="ref-for-propdef-top">top</a> property of 2 seconds duration and a
      transition on the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css2/visudet.html#propdef-width" id="ref-for-propdef-width">width</a> property of 1
      second duration. 
   </div>
   <p> While authors can use transitions to create dynamically changing content,
        dynamically changing content can lead to seizures in some users.
        For information on how to avoid content that can lead to seizures, see <a href="https://www.w3.org/TR/WCAG20/#seizure">Guideline 2.3:
        Seizures:
        Do not design content in a way that is known to cause seizures</a> (<a data-link-type="biblio" href="#biblio-wcag20">[WCAG20]</a>). </p>
   <h3 class="heading settled" data-level="2.1" id="transition-property-property"><span class="secno">2.1. </span><span class="content"><span id="the-transition-property-property-">The <a class="property" data-link-type="propdesc" href="#propdef-transition-property" id="ref-for-propdef-transition-property③">transition-property</a> Property</span></span><a class="self-link" href="#transition-property-property"></a></h3>
   <p> The <a class="property" data-link-type="propdesc" href="#propdef-transition-property" id="ref-for-propdef-transition-property④">transition-property</a> property specifies the name of the CSS property to which the transition is applied. </p>
   <table class="def propdef" data-link-for-hint="transition-property">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-type="property" data-export id="propdef-transition-property">transition-property</dfn>
     <tr class="value">
      <th><a href="https://drafts.csswg.org/css-values/#value-defs">Value:</a>
      <td class="prod">none <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one">|</a> <a class="production css" data-link-type="type" href="#single-transition-property" id="ref-for-single-transition-property">&lt;single-transition-property></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-comma" id="ref-for-mult-comma">#</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#initial-values">Initial:</a>
      <td>all 
     <tr>
      <th>Applies to:
      <td><a href="https://drafts.csswg.org/css-pseudo/#generated-content" title="Includes ::before and ::after pseudo-elements.">all elements</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#inherited-property">Inherited:</a>
      <td>no 
     <tr>
      <th><a href="https://drafts.csswg.org/css-values/#percentages">Percentages:</a>
      <td>N/A 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#computed">Computed value:</a>
      <td>the keyword <a class="css" data-link-type="maybe" href="#valdef-transition-property-none" id="ref-for-valdef-transition-property-none">none</a> else a list of identifiers 
     <tr>
      <th>Canonical order:
      <td>per grammar 
     <tr>
      <th><a href="https://drafts.csswg.org/web-animations/#animation-type">Animation type:</a>
      <td>not animatable 
   </table>
   <div class="prod"> <dfn class="dfn-paneled css" data-dfn-type="type" data-export id="single-transition-property">&lt;single-transition-property></dfn> = <a class="css" data-link-type="maybe" href="#valdef-transition-property-all" id="ref-for-valdef-transition-property-all">all</a> <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one①">|</a> <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-4/#identifier-value" id="ref-for-identifier-value">&lt;custom-ident></a>; </div>
   <p> A value of <dfn class="dfn-paneled css" data-dfn-for="transition-property" data-dfn-type="value" data-export id="valdef-transition-property-none">none</dfn> means that no property will transition.
        Otherwise, a list of properties to be transitioned, or the
        keyword <dfn class="dfn-paneled css" data-dfn-for="transition-property" data-dfn-type="value" data-export id="valdef-transition-property-all">all</dfn> which indicates that all properties are to be
        transitioned, is given. </p>
   <p> If one of the identifiers listed is not a recognized property
        name, the implementation must
        still start transitions on the animatable properties in the
        list using the duration, delay, and timing function at their
        respective indices in the lists for <a class="property" data-link-type="propdesc" href="#propdef-transition-duration" id="ref-for-propdef-transition-duration">transition-duration</a>, <a class="property" data-link-type="propdesc" href="#propdef-transition-delay" id="ref-for-propdef-transition-delay">transition-delay</a>, and <a class="property" data-link-type="propdesc" href="#propdef-transition-timing-function" id="ref-for-propdef-transition-timing-function">transition-timing-function</a>.  In other
        words, unrecognized properties must be kept in
        the list to preserve the matching of indices. </p>
   <p> The <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-4/#identifier-value" id="ref-for-identifier-value①">&lt;custom-ident></a> production in <a class="production css" data-link-type="type" href="#single-transition-property" id="ref-for-single-transition-property①">&lt;single-transition-property></a> also excludes the keyword <a class="css" data-link-type="maybe" href="#valdef-transition-property-none" id="ref-for-valdef-transition-property-none①">none</a>,
        in addition to the keywords always excluded from <span class="production" id="ref-for-identifier-value②">&lt;custom-ident></span>.
        This means that <span class="css" id="ref-for-valdef-transition-property-none②">none</span>, <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-cascade-4/#valdef-all-inherit" id="ref-for-valdef-all-inherit">inherit</a>, and <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-cascade-4/#valdef-all-initial" id="ref-for-valdef-all-initial">initial</a> are not
        permitted as items within a list of more that one identifier;
        any list that uses them is syntactically invalid. </p>
   <p> For the keyword <a class="css" data-link-type="maybe" href="#valdef-transition-property-all" id="ref-for-valdef-transition-property-all①">all</a>,
        or if one of the identifiers listed is a
        shorthand property, implementations must start transitions for
        all its longhand sub-properties (or, for <span class="css" id="ref-for-valdef-transition-property-all②">all</span>, all properties), using the duration, delay,
        and timing function at the index corresponding to the shorthand. </p>
   <p> If a property is specified multiple times in the value of <a class="property" data-link-type="propdesc" href="#propdef-transition-property" id="ref-for-propdef-transition-property⑤">transition-property</a> (either on its own, via a shorthand that
        contains it, or via the <a class="css" data-link-type="maybe" href="#valdef-transition-property-all" id="ref-for-valdef-transition-property-all③">all</a> value), then the transition that
        starts uses the duration, delay, and timing function at the
        index corresponding to the <em>last</em> item in the value of <span class="property" id="ref-for-propdef-transition-property⑥">transition-property</span> that calls for animating that property. </p>
   <p class="note" role="note"> Note:  The <a class="css" data-link-type="maybe" href="#valdef-transition-property-all" id="ref-for-valdef-transition-property-all④">all</a> value and <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-cascade-4/#propdef-all" id="ref-for-propdef-all">all</a> shorthand
        property work in similar ways, so the <span class="css" id="ref-for-valdef-transition-property-all⑤">all</span> value is just like a shorthand that
        covers all properties. </p>
   <h3 class="heading settled" data-level="2.2" id="transition-duration-property"><span class="secno">2.2. </span><span class="content"><span id="the-transition-duration-property-">The <a class="property" data-link-type="propdesc" href="#propdef-transition-duration" id="ref-for-propdef-transition-duration①">transition-duration</a> Property</span></span><a class="self-link" href="#transition-duration-property"></a></h3>
   <p> The <a class="property" data-link-type="propdesc" href="#propdef-transition-duration" id="ref-for-propdef-transition-duration②">transition-duration</a> property defines the length of time that a transition takes. </p>
   <table class="def propdef" data-link-for-hint="transition-duration">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-type="property" data-export id="propdef-transition-duration">transition-duration</dfn>
     <tr class="value">
      <th><a href="https://drafts.csswg.org/css-values/#value-defs">Value:</a>
      <td class="prod"><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#time-value" id="ref-for-time-value" title="Expands to: ms | s">&lt;time></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-comma" id="ref-for-mult-comma①">#</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#initial-values">Initial:</a>
      <td><span class="css">0s</span> 
     <tr>
      <th>Applies to:
      <td><a href="https://drafts.csswg.org/css-pseudo/#generated-content" title="Includes ::before and ::after pseudo-elements.">all elements</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#inherited-property">Inherited:</a>
      <td>no 
     <tr>
      <th><a href="https://drafts.csswg.org/css-values/#percentages">Percentages:</a>
      <td>N/A 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#computed">Computed value:</a>
      <td>list, each item a duration 
     <tr>
      <th>Canonical order:
      <td>per grammar 
     <tr>
      <th><a href="https://drafts.csswg.org/web-animations/#animation-type">Animation type:</a>
      <td>not animatable 
   </table>
   <p> This property specifies how long the transition from the old value to the new value should take. By default the value is <span class="css">0s</span>, meaning that the transition is immediate (i.e. there will be no animation). A negative value for <a class="property" data-link-type="propdesc" href="#propdef-transition-duration" id="ref-for-propdef-transition-duration③">transition-duration</a> renders the declaration invalid. </p>
   <h3 class="heading settled" data-level="2.3" id="transition-timing-function-property"><span class="secno">2.3. </span><span class="content"><span id="transition-timing-function_tag">The <a class="property" data-link-type="propdesc" href="#propdef-transition-timing-function" id="ref-for-propdef-transition-timing-function①">transition-timing-function</a> Property</span></span><a class="self-link" href="#transition-timing-function-property"></a></h3>
   <p> The <a class="property" data-link-type="propdesc" href="#propdef-transition-timing-function" id="ref-for-propdef-transition-timing-function②">transition-timing-function</a> property
        describes how the intermediate values used during a transition will be
        calculated. It allows for a transition to change speed over its
        duration. These effects are commonly called <em>easing</em> functions. </p>
   <p> Timing functions are defined in the separate CSS Easing Functions module <a data-link-type="biblio" href="#biblio-css-easing-1">[css-easing-1]</a>.
        The <a data-link-type="dfn" href="https://drafts.csswg.org/css-easing-1/#input-progress-value" id="ref-for-input-progress-value">input progress value</a> used is the percentage
        of the transition duration, and the <a data-link-type="dfn" href="https://drafts.csswg.org/css-easing-1/#output-progress-value" id="ref-for-output-progress-value">output progress
        value</a> is used as the <var>p</var> value when <a data-link-type="dfn" href="https://drafts.csswg.org/css-values-4/#interpolation" id="ref-for-interpolation">interpolating</a> the property value (see <a href="#application">§ 4 Application of transitions</a>). </p>
   <table class="def propdef" data-link-for-hint="transition-timing-function">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-type="property" data-export id="propdef-transition-timing-function">transition-timing-function</dfn>
     <tr class="value">
      <th><a href="https://drafts.csswg.org/css-values/#value-defs">Value:</a>
      <td class="prod"><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-easing-1/#typedef-easing-function" id="ref-for-typedef-easing-function">&lt;easing-function></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-comma" id="ref-for-mult-comma②">#</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#initial-values">Initial:</a>
      <td><span class="css">ease</span> 
     <tr>
      <th>Applies to:
      <td><a href="https://drafts.csswg.org/css-pseudo/#generated-content" title="Includes ::before and ::after pseudo-elements.">all elements</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#inherited-property">Inherited:</a>
      <td>no 
     <tr>
      <th><a href="https://drafts.csswg.org/css-values/#percentages">Percentages:</a>
      <td>N/A 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#computed">Computed value:</a>
      <td>as specified 
     <tr>
      <th>Canonical order:
      <td>per grammar 
     <tr>
      <th><a href="https://drafts.csswg.org/web-animations/#animation-type">Animation type:</a>
      <td>not animatable 
   </table>
   <h3 class="heading settled" data-level="2.4" id="transition-delay-property"><span class="secno">2.4. </span><span class="content"><span id="the-transition-delay-property-">The <a class="property" data-link-type="propdesc" href="#propdef-transition-delay" id="ref-for-propdef-transition-delay①">transition-delay</a> Property</span></span><a class="self-link" href="#transition-delay-property"></a></h3>
   <p> The <a class="property" data-link-type="propdesc" href="#propdef-transition-delay" id="ref-for-propdef-transition-delay②">transition-delay</a> property defines when the transition will start. It allows a transition to begin execution some some period of time from when it is applied. A <span class="property" id="ref-for-propdef-transition-delay③">transition-delay</span> value of <span class="css">0s</span> means the transition will execute as soon as the property is changed. Otherwise, the value specifies an offset from the moment the property is changed, and the transition will delay execution by that offset. </p>
   <p> If the value for <a class="property" data-link-type="propdesc" href="#propdef-transition-delay" id="ref-for-propdef-transition-delay④">transition-delay</a> is a negative time offset then the transition will execute the moment the property is changed, but will appear to have begun execution at the specified offset. That is, the transition will appear to begin part-way through its play cycle. In the case where a transition has implied starting values and a negative <span class="property" id="ref-for-propdef-transition-delay⑤">transition-delay</span>, the starting values are taken from the moment the property is changed. </p>
   <table class="def propdef" data-link-for-hint="transition-delay">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-type="property" data-export id="propdef-transition-delay">transition-delay</dfn>
     <tr class="value">
      <th><a href="https://drafts.csswg.org/css-values/#value-defs">Value:</a>
      <td class="prod"><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#time-value" id="ref-for-time-value①" title="Expands to: ms | s">&lt;time></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-comma" id="ref-for-mult-comma③">#</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#initial-values">Initial:</a>
      <td><span class="css">0s</span> 
     <tr>
      <th>Applies to:
      <td><a href="https://drafts.csswg.org/css-pseudo/#generated-content" title="Includes ::before and ::after pseudo-elements.">all elements</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#inherited-property">Inherited:</a>
      <td>no 
     <tr>
      <th><a href="https://drafts.csswg.org/css-values/#percentages">Percentages:</a>
      <td>N/A 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#computed">Computed value:</a>
      <td>list, each item a duration 
     <tr>
      <th>Canonical order:
      <td>per grammar 
     <tr>
      <th><a href="https://drafts.csswg.org/web-animations/#animation-type">Animation type:</a>
      <td>not animatable 
   </table>
   <h3 class="heading settled" data-level="2.5" id="transition-shorthand-property"><span class="secno">2.5. </span><span class="content"><span id="the-transition-shorthand-property-">The <a class="property" data-link-type="propdesc" href="#propdef-transition" id="ref-for-propdef-transition">transition</a> Shorthand Property</span></span><a class="self-link" href="#transition-shorthand-property"></a></h3>
   <p> The <a class="property" data-link-type="propdesc" href="#propdef-transition" id="ref-for-propdef-transition①">transition</a> shorthand property combines the four properties described above into a single property. </p>
   <table class="def propdef" data-link-for-hint="transition">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-type="property" data-export id="propdef-transition">transition</dfn>
     <tr class="value">
      <th><a href="https://drafts.csswg.org/css-values/#value-defs">Value:</a>
      <td class="prod"><a class="production css" data-link-type="type" href="#single-transition" id="ref-for-single-transition">&lt;single-transition></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-comma" id="ref-for-mult-comma④">#</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#initial-values">Initial:</a>
      <td>see individual properties 
     <tr>
      <th>Applies to:
      <td><a href="https://drafts.csswg.org/css-pseudo/#generated-content" title="Includes ::before and ::after pseudo-elements.">all elements</a> 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#inherited-property">Inherited:</a>
      <td>no 
     <tr>
      <th><a href="https://drafts.csswg.org/css-values/#percentages">Percentages:</a>
      <td>N/A 
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#computed">Computed value:</a>
      <td>see individual properties 
     <tr>
      <th>Canonical order:
      <td>per grammar 
     <tr>
      <th><a href="https://drafts.csswg.org/web-animations/#animation-type">Animatable:</a>
      <td>no 
     <tr>
      <th><a href="https://drafts.csswg.org/web-animations/#animation-type">Animation type:</a>
      <td>not animatable 
   </table>
   <div class="prod"> <dfn class="dfn-paneled css" data-dfn-type="type" data-export id="single-transition">&lt;single-transition></dfn> = [ <a class="css" data-link-type="maybe" href="#valdef-transition-property-none" id="ref-for-valdef-transition-property-none③">none</a> <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one②">|</a> <a class="production css" data-link-type="type" href="#single-transition-property" id="ref-for-single-transition-property②">&lt;single-transition-property></a> ] <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-any" id="ref-for-comb-any">||</a> <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#time-value" id="ref-for-time-value②" title="Expands to: ms | s">&lt;time></a> <span id="ref-for-comb-any①">||</span> <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-easing-1/#typedef-easing-function" id="ref-for-typedef-easing-function①">&lt;easing-function></a> <span id="ref-for-comb-any②">||</span> <span class="production" id="ref-for-time-value③" title="Expands to: ms | s">&lt;time></span> </div>
   <p> Note that order is important within the items in this property:
        the first value that can be parsed as a time is assigned to the
        transition-duration,
        and the second value that can be parsed as a time is assigned to
        transition-delay. </p>
   <p> If there is more than one <a class="production css" data-link-type="type" href="#single-transition" id="ref-for-single-transition①">&lt;single-transition></a> in the shorthand,
        and any of the transitions has <a class="css" data-link-type="maybe" href="#valdef-transition-property-none" id="ref-for-valdef-transition-property-none④">none</a> as the <a class="production css" data-link-type="type" href="#single-transition-property" id="ref-for-single-transition-property③">&lt;single-transition-property></a>,
        then the declaration is invalid. </p>
   <h2 class="heading settled" data-level="3" id="starting"><span class="secno">3. </span><span class="content">Starting of transitions</span><a class="self-link" href="#starting"></a></h2>
   <p> Implementations must maintain a set of <dfn class="dfn-paneled" data-dfn-type="dfn" data-export data-lt="running transition" id="running-transition">running transitions</dfn>,
        each of which applies to a specific element and non-shorthand
        property.  Each of these transitions also has a <dfn class="dfn-paneled" data-dfn-for="transition" data-dfn-type="dfn" data-export id="transition-start-time">start time</dfn>, <dfn class="dfn-paneled" data-dfn-for="transition" data-dfn-type="dfn" data-export id="transition-end-time">end time</dfn>, <dfn class="dfn-paneled" data-dfn-for="transition" data-dfn-type="dfn" data-export id="transition-start-value">start value</dfn>, <dfn class="dfn-paneled" data-dfn-for="transition" data-dfn-type="dfn" data-export id="transition-end-value">end value</dfn>, <dfn class="dfn-paneled" data-dfn-for="transition" data-dfn-type="dfn" data-export id="transition-reversing-adjusted-start-value">reversing-adjusted start value</dfn>, and <dfn class="dfn-paneled" data-dfn-for="transition" data-dfn-type="dfn" data-export id="transition-reversing-shortening-factor">reversing shortening factor</dfn>.
        Transitions are added to this set as described in this section,
        and are removed from this set
        when they <a data-link-type="dfn" href="#dfn-complete" id="ref-for-dfn-complete">complete</a> or when implementations are required to <dfn class="dfn-paneled" data-dfn-for="transition" data-dfn-type="dfn" data-export id="transition-cancel">cancel</dfn> them. <span class="note"> For the rationale behind the <a data-link-type="dfn" href="#transition-reversing-adjusted-start-value" id="ref-for-transition-reversing-adjusted-start-value">reversing-adjusted start value</a> and <a data-link-type="dfn" href="#transition-reversing-shortening-factor" id="ref-for-transition-reversing-shortening-factor">reversing shortening factor</a>, see <a href="#reversing">§ 3.1 Faster reversing of interrupted transitions</a>. </span> </p>
   <p> Implementations must also maintain a set of <dfn class="dfn-paneled" data-dfn-type="dfn" data-export data-lt="completed transition" id="completed-transition">completed transitions</dfn>,
        each of which
        (like <a data-link-type="dfn" href="#running-transition" id="ref-for-running-transition">running transitions</a>)
        applies to a specific element and non-shorthand property. <span class="note"> This specification maintains the invariant that
          there is never both a <a data-link-type="dfn" href="#running-transition" id="ref-for-running-transition①">running transition</a> and
          a <a data-link-type="dfn" href="#completed-transition" id="ref-for-completed-transition">completed transition</a> for the same property and element. </span> </p>
   <p> If an element is no longer in the document,
        implementations must <a data-link-type="dfn" href="#transition-cancel" id="ref-for-transition-cancel">cancel</a> any <a data-link-type="dfn" href="#running-transition" id="ref-for-running-transition②">running transitions</a> on it and remove transitions on it from the <a data-link-type="dfn" href="#completed-transition" id="ref-for-completed-transition①">completed transitions</a>. </p>
   <div class="note" role="note">
    <p> This set of completed transitions
          needs to be maintained
          in order to prevent
          transitions from repeating themselves in certain cases,
          i.e., to maintain the invariant
          that this specification tries to maintain
          that unrelated style changes do not trigger transitions. </p>
    <p class="example" id="example-4b88a0cc"><a class="self-link" href="#example-4b88a0cc"></a> An example where maintaining the set of completed transitions
          is necessary would be a transition on
          an inherited property,
          where the parent specifies a transition of that property for
          a longer duration (say, <a class="css" data-link-type="propdesc" href="#propdef-transition" id="ref-for-propdef-transition②">transition: 4s text-indent</a>)
          and a child element that inherits the parent’s value specifies
          a transition of the same property for a shorter duration
          (say, <span class="css" id="ref-for-propdef-transition③">transition: 1s text-indent</span>).
          Without the maintenance of this set of completed transitions,
          implementations could start additional transitions on the child
          after the initial 1 second transition on the child completes. </p>
   </div>
   <p> Various things can cause the <a data-link-type="dfn" href="https://drafts.csswg.org/css-cascade-4/#computed-value" id="ref-for-computed-value②">computed values</a> of properties
        on an element to change.
        These include
        insertion and removal of elements from the document tree
        (which both changes whether those elements have <span id="ref-for-computed-value③">computed values</span> and
        can change the styles of other elements through selector matching),
        changes to the document tree that cause
        changes to which selectors match elements,
        changes to style sheets or style attributes,
        and other things.
        This specification does not define when <span id="ref-for-computed-value④">computed values</span> are updated,
        beyond saying that implementations must not
        use, present, or display something resulting from the CSS
        cascading, value computation, and inheritance process <a data-link-type="biblio" href="#biblio-css3cascade">[CSS3CASCADE]</a> without updating the <span id="ref-for-computed-value⑤">computed value</span> (which means merely that implementations cannot avoid
        meeting requirements of this specification
        by claiming not to have updated the <span id="ref-for-computed-value⑥">computed value</span> as part of handling a style change).
        However,
        when an implementation updates the <span id="ref-for-computed-value⑦">computed value</span> of a
        property on an element
        to reflect one of these changes,
        or computes the <span id="ref-for-computed-value⑧">computed value</span> of a property on an element
        newly added to the document,
        it must update the <span id="ref-for-computed-value⑨">computed value</span> for all properties and elements to reflect all
        of these changes at the same time
        (or at least it must be undetectable that it was done at a
        different time).
        This processing of a set of simultaneous style changes is called a <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="style-change-event">style change event</dfn>.
        (Implementations typically have a <a data-link-type="dfn" href="#style-change-event" id="ref-for-style-change-event">style change event</a> to
        correspond with their desired screen refresh rate,
        and when up-to-date computed style or layout information is needed
        for a script API that depends on it.) </p>
   <p> Since this specification does not define
        when a <a data-link-type="dfn" href="#style-change-event" id="ref-for-style-change-event①">style change event</a> occurs,
        and thus what changes to computed values are considered simultaneous,
        authors should be aware that changing any of the transition
        properties a small amount of time after making a change that
        might transition can result in behavior that varies between
        implementations, since the changes might be considered
        simultaneous in some implementations but not others. </p>
   <p> When a <a data-link-type="dfn" href="#style-change-event" id="ref-for-style-change-event②">style change event</a> occurs,
        implementations must start transitions based on
        the <a data-link-type="dfn" href="https://drafts.csswg.org/css-cascade-4/#computed-value" id="ref-for-computed-value①⓪">computed values</a> that changed in that event.
        If an element is not in the document during that
        style change event or was not in the document during
        the previous style change event,
        then transitions are not started for that element
        in that style change event.
        Otherwise,
        define the <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="before-change-style">before-change style</dfn> as
        the <span id="ref-for-computed-value①①">computed values</span> of all properties on the element as of
        the previous <span id="ref-for-style-change-event③">style change event</span>,
        except with any styles derived from declarative
        animations such as CSS Transitions, CSS Animations
        (<a data-link-type="biblio" href="#biblio-css3-animations">[CSS3-ANIMATIONS]</a>),
        and SMIL Animations (<a data-link-type="biblio" href="#biblio-smil-animation">[SMIL-ANIMATION]</a>, <a data-link-type="biblio" href="#biblio-svg11">[SVG11]</a>)
        updated to the current time.
        Likewise, define the <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="after-change-style">after-change style</dfn> as
        the <span id="ref-for-computed-value①②">computed values</span> of all properties
        on the element based on the information
        known at the start of that <span id="ref-for-style-change-event④">style change event</span>,
        but using the computed values of the <a class="property" data-link-type="propdesc">animation-*</a> properties from the <a data-link-type="dfn" href="#before-change-style" id="ref-for-before-change-style">before-change style</a>,
        excluding any styles from CSS Transitions in the computation,
        and inheriting from
        the <a data-link-type="dfn" href="#after-change-style" id="ref-for-after-change-style">after-change style</a> of the parent.
        Note that this means the <span id="ref-for-after-change-style①">after-change style</span> does not differ from
        the <span id="ref-for-before-change-style①">before-change style</span> due to newly created or canceled CSS
        Animations. </p>
   <div class="note" role="note">
    <p> Note that this definition of the <a data-link-type="dfn" href="#after-change-style" id="ref-for-after-change-style②">after-change style</a> means that a single change
          can start a transition on the same property
          on both an ancestor element and its descendant element.
          This can happen when a property change is inherited
          from one element with <a class="property" data-link-type="propdesc">transition-*</a> properties
          that say to animate the changing property
          to another element with <span class="property">transition-*</span> properties
          that also say to animate the changing property. </p>
    <p> When this happens, both transitions will run,
          and the transition on the descendant will override
          the transition on the ancestor
          because of the normal
          CSS cascading and inheritance rules (<a data-link-type="biblio" href="#biblio-css3cascade">[CSS3CASCADE]</a>). </p>
    <p> If the transition on the descendant completes before
          the transition on the ancestor,
          the descendant will then resume inheriting
          the (still transitioning) value from its parent.
          This effect is likely not a desirable effect,
          but it is essentially doing what the author asked for. </p>
   </div>
   <p> For each element with a <a data-link-type="dfn" href="#before-change-style" id="ref-for-before-change-style②">before-change style</a> and
        an <a data-link-type="dfn" href="#after-change-style" id="ref-for-after-change-style③">after-change style</a>,
        and each property (other than shorthands),
        define the <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="matching-transition-property-value">matching transition-property value</dfn> as
        the last value in the <a class="property" data-link-type="propdesc" href="#propdef-transition-property" id="ref-for-propdef-transition-property⑦">transition-property</a> in the element’s <span id="ref-for-after-change-style④">after-change style</span> that matches the property,
        as described in <a href="#transition-property-property">§ 2.1 The transition-property Property</a>.
        If there is such a value, then corresponding to it, there is
        a <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="matching-transition-duration">matching transition duration</dfn>,
        a <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="matching-transition-delay">matching transition delay</dfn>, and
        a <dfn data-dfn-type="dfn" data-export id="matching-transition-timing-function">matching transition timing function<a class="self-link" href="#matching-transition-timing-function"></a></dfn> in the values in the <span id="ref-for-after-change-style⑤">after-change style</span> of <a class="property" data-link-type="propdesc" href="#propdef-transition-duration" id="ref-for-propdef-transition-duration④">transition-duration</a>, <a class="property" data-link-type="propdesc" href="#propdef-transition-delay" id="ref-for-propdef-transition-delay⑥">transition-delay</a>, and <a class="property" data-link-type="propdesc" href="#propdef-transition-timing-function" id="ref-for-propdef-transition-timing-function③">transition-timing-function</a> (see <a href="#list-matching">the rules on matching lists</a>).
        Define the <dfn class="dfn-paneled" data-dfn-for="transition" data-dfn-type="dfn" data-export id="transition-combined-duration">combined duration</dfn> of the transition
        as the sum of max(<a data-link-type="dfn" href="#matching-transition-duration" id="ref-for-matching-transition-duration">matching transition duration</a>, <span class="css">0s</span>) and
        the <a data-link-type="dfn" href="#matching-transition-delay" id="ref-for-matching-transition-delay">matching transition delay</a>. </p>
   <p>When comparing the <a data-link-type="dfn" href="#before-change-style" id="ref-for-before-change-style③">before-change style</a> and <a data-link-type="dfn" href="#after-change-style" id="ref-for-after-change-style⑥">after-change style</a> for a given property,
      the property values are <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="transitionable">transitionable</dfn> if they have an <a data-link-type="dfn" href="https://drafts.csswg.org/web-animations-1/#animation-type" id="ref-for-animation-type">animation type</a> that is <em>neither</em> <a data-link-type="dfn" href="https://drafts.csswg.org/web-animations-1/#not-animatable" id="ref-for-not-animatable">not animatable</a> <em>nor</em> <a data-link-type="dfn" href="https://drafts.csswg.org/web-animations-1/#discrete" id="ref-for-discrete">discrete</a>.</p>
   <p class="note" role="note"><span>Note:</span> Even if a <em>property</em> is defined to have an <a data-link-type="dfn" href="https://drafts.csswg.org/web-animations-1/#animation-type" id="ref-for-animation-type①">animation type</a> that is <em>not</em> <a data-link-type="dfn" href="https://drafts.csswg.org/web-animations-1/#discrete" id="ref-for-discrete①">discrete</a>,
      for a particular pair of <em>property values</em> the <span id="ref-for-animation-type②">animation type</span> may be <span id="ref-for-discrete②">discrete</span>.
      For example,
      the <span id="ref-for-animation-type③">animation type</span> of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-backgrounds-3/#propdef-box-shadow" id="ref-for-propdef-box-shadow">box-shadow</a> property is <a data-link-type="dfn" href="https://drafts.csswg.org/web-animations-1/#combining-shadow-lists" id="ref-for-combining-shadow-lists">shadow list</a>,
      which defines that
      when the <a class="css" data-link-type="maybe" href="https://www.w3.org/TR/css3-background/#shadow-inset" id="ref-for-shadow-inset">inset</a> keyword is absent in one value
      but present in the other, <span id="ref-for-discrete③">discrete</span> animation is used.
      As a result <span class="css">0px 0px black</span> and <span class="css">inset 10px 10px black</span> are <em>not</em> <a data-link-type="dfn" href="#transitionable" id="ref-for-transitionable">transitionable</a>.</p>
   <p>For each element and property, the implementation must act
      as follows:</p>
   <ol>
    <li>
      If all of the following are true: 
     <ul>
      <li> the element does not have
            a <a data-link-type="dfn" href="#running-transition" id="ref-for-running-transition③">running transition</a> for the property, 
      <li> the <a data-link-type="dfn" href="#before-change-style" id="ref-for-before-change-style④">before-change style</a> is different from
            the <a data-link-type="dfn" href="#after-change-style" id="ref-for-after-change-style⑦">after-change style</a> for that property,
            and the values for the property are <a data-link-type="dfn" href="#transitionable" id="ref-for-transitionable①">transitionable</a>, 
      <li> the element does not have a <a data-link-type="dfn" href="#completed-transition" id="ref-for-completed-transition②">completed transition</a> for the property
            or the <a data-link-type="dfn" href="#transition-end-value" id="ref-for-transition-end-value">end value</a> of the <span id="ref-for-completed-transition③">completed transition</span> is different from the <a data-link-type="dfn" href="#after-change-style" id="ref-for-after-change-style⑧">after-change style</a> for the property, 
      <li> there is a <a data-link-type="dfn" href="#matching-transition-property-value" id="ref-for-matching-transition-property-value">matching transition-property value</a>, and 
      <li> the <a data-link-type="dfn" href="#transition-combined-duration" id="ref-for-transition-combined-duration">combined duration</a> is greater than <span class="css">0s</span>, 
     </ul>
      then implementations must
        remove the <a data-link-type="dfn" href="#completed-transition" id="ref-for-completed-transition④">completed transition</a> (if present) from the set
        of completed transitions and
        start a transition whose: 
     <ul>
      <li> <a data-link-type="dfn" href="#transition-start-time" id="ref-for-transition-start-time">start time</a> is
            the time of the <a data-link-type="dfn" href="#style-change-event" id="ref-for-style-change-event⑤">style change event</a> plus
            the <a data-link-type="dfn" href="#matching-transition-delay" id="ref-for-matching-transition-delay①">matching transition delay</a>, 
      <li> <a data-link-type="dfn" href="#transition-end-time" id="ref-for-transition-end-time">end time</a> is
            the <a data-link-type="dfn" href="#transition-start-time" id="ref-for-transition-start-time①">start time</a> plus
            the <a data-link-type="dfn" href="#matching-transition-duration" id="ref-for-matching-transition-duration①">matching transition duration</a>, 
      <li> <a data-link-type="dfn" href="#transition-start-value" id="ref-for-transition-start-value">start value</a> is
            the value of the transitioning property
            in the <a data-link-type="dfn" href="#before-change-style" id="ref-for-before-change-style⑤">before-change style</a>, 
      <li> <a data-link-type="dfn" href="#transition-end-value" id="ref-for-transition-end-value①">end value</a> is
            the value of the transitioning property
            in the <a data-link-type="dfn" href="#after-change-style" id="ref-for-after-change-style⑨">after-change style</a>, 
      <li> <a data-link-type="dfn" href="#transition-reversing-adjusted-start-value" id="ref-for-transition-reversing-adjusted-start-value①">reversing-adjusted start value</a> is the same as
            the <a data-link-type="dfn" href="#transition-start-value" id="ref-for-transition-start-value①">start value</a>, and 
      <li> <a data-link-type="dfn" href="#transition-reversing-shortening-factor" id="ref-for-transition-reversing-shortening-factor①">reversing shortening factor</a> is 1. 
     </ul>
    <li> Otherwise,
        if the element has a <a data-link-type="dfn" href="#completed-transition" id="ref-for-completed-transition⑤">completed transition</a> for the property
        and the <a data-link-type="dfn" href="#transition-end-value" id="ref-for-transition-end-value②">end value</a> of the <span id="ref-for-completed-transition⑥">completed transition</span> is different from the <a data-link-type="dfn" href="#after-change-style" id="ref-for-after-change-style①⓪">after-change style</a> for the property,
        then implementations must
        remove the <span id="ref-for-completed-transition⑦">completed transition</span> from the set of <span id="ref-for-completed-transition⑧">completed transitions</span>. 
    <li> If the element has a <a data-link-type="dfn" href="#running-transition" id="ref-for-running-transition④">running transition</a> or <a data-link-type="dfn" href="#completed-transition" id="ref-for-completed-transition⑨">completed transition</a> for the property,
        and there is <strong>not</strong> a <a data-link-type="dfn" href="#matching-transition-property-value" id="ref-for-matching-transition-property-value①">matching transition-property value</a>,
        then implementations must <a data-link-type="dfn" href="#transition-cancel" id="ref-for-transition-cancel①">cancel</a> the <span id="ref-for-running-transition⑤">running transition</span> or remove the <span id="ref-for-completed-transition①⓪">completed transition</span> from the set of <span id="ref-for-completed-transition①①">completed transitions</span>. 
    <li>
      If the element has a <a data-link-type="dfn" href="#running-transition" id="ref-for-running-transition⑥">running transition</a> for the property,
        there is a <a data-link-type="dfn" href="#matching-transition-property-value" id="ref-for-matching-transition-property-value②">matching transition-property value</a>,
        and the <a data-link-type="dfn" href="#transition-end-value" id="ref-for-transition-end-value③">end value</a> of the <span id="ref-for-running-transition⑦">running transition</span> is <strong>not</strong> equal to the value of the property in the <a data-link-type="dfn" href="#after-change-style" id="ref-for-after-change-style①①">after-change style</a>, then: 
     <ol>
      <li> If the <a data-link-type="dfn" href="#current-value" id="ref-for-current-value">current value</a> of the property
            in the <a data-link-type="dfn" href="#running-transition" id="ref-for-running-transition⑧">running transition</a> is equal to
            the value of the property in the <a data-link-type="dfn" href="#after-change-style" id="ref-for-after-change-style①②">after-change style</a>,
            or if these two values are not <a data-link-type="dfn" href="#transitionable" id="ref-for-transitionable②">transitionable</a>,
            then implementations must <a data-link-type="dfn" href="#transition-cancel" id="ref-for-transition-cancel②">cancel</a> the <span id="ref-for-running-transition⑨">running transition</span>. 
      <li> Otherwise, if the <a data-link-type="dfn" href="#transition-combined-duration" id="ref-for-transition-combined-duration①">combined duration</a> is
            less than or equal to <span class="css">0s</span>,
            or if the <a data-link-type="dfn" href="#current-value" id="ref-for-current-value①">current value</a> of the property in the <a data-link-type="dfn" href="#running-transition" id="ref-for-running-transition①⓪">running transition</a> is not <a data-link-type="dfn" href="#transitionable" id="ref-for-transitionable③">transitionable</a> with
            the value of the property in the <a data-link-type="dfn" href="#after-change-style" id="ref-for-after-change-style①③">after-change style</a>,
            then implementations must <a data-link-type="dfn" href="#transition-cancel" id="ref-for-transition-cancel③">cancel</a> the <span id="ref-for-running-transition①①">running transition</span>. 
      <li>
        Otherwise, if the <a data-link-type="dfn" href="#transition-reversing-adjusted-start-value" id="ref-for-transition-reversing-adjusted-start-value②">reversing-adjusted start value</a> of the <a data-link-type="dfn" href="#running-transition" id="ref-for-running-transition①②">running transition</a> is the same as the value of
            the property in the <a data-link-type="dfn" href="#after-change-style" id="ref-for-after-change-style①④">after-change style</a> <span class="note">(see the <a href="#reversing">section on reversing of
            transitions</a> for why these case exists)</span>,
            implementations must <a data-link-type="dfn" href="#transition-cancel" id="ref-for-transition-cancel④">cancel</a> the <span id="ref-for-running-transition①③">running transition</span> and
            start a new transition whose: 
       <ul>
        <li> <a data-link-type="dfn" href="#transition-reversing-adjusted-start-value" id="ref-for-transition-reversing-adjusted-start-value③">reversing-adjusted start value</a> is
                the <a data-link-type="dfn" href="#transition-end-value" id="ref-for-transition-end-value④">end value</a> of the <a data-link-type="dfn" href="#running-transition" id="ref-for-running-transition①④">running transition</a> <span class="note">(Note: This represents the logical start state of
                the transition, and allows some calculations to ignore that
                the transition started before that state was reached, which
                in turn allows repeated reversals of the same transition to
                work correctly),</span> 
        <li>
          <a data-link-type="dfn" href="#transition-reversing-shortening-factor" id="ref-for-transition-reversing-shortening-factor②">reversing shortening factor</a> is the absolute value, clamped to the range [0, 1],
                of the sum of: 
         <ol>
          <li>the output of the timing function of the old transition
                  at the time of the <a data-link-type="dfn" href="#style-change-event" id="ref-for-style-change-event⑥">style change event</a>,
                  times the <a data-link-type="dfn" href="#transition-reversing-shortening-factor" id="ref-for-transition-reversing-shortening-factor③">reversing shortening factor</a> of the
                  old transition
          <li>1 minus the <a data-link-type="dfn" href="#transition-reversing-shortening-factor" id="ref-for-transition-reversing-shortening-factor④">reversing shortening factor</a> of
                  the old transition.
         </ol>
          <span class="note">Note: This represents the portion of the
                space between the <a data-link-type="dfn" href="#transition-reversing-adjusted-start-value" id="ref-for-transition-reversing-adjusted-start-value④">reversing-adjusted start value</a> and the <a data-link-type="dfn" href="#transition-end-value" id="ref-for-transition-end-value⑤">end value</a> that the old transition has
                traversed (in amounts of the value, not time), except with the
                absolute value and clamping to handle timing functions that
                have y1 or y2 outside the range [0, 1].</span> 
        <li>
          <a data-link-type="dfn" href="#transition-start-time" id="ref-for-transition-start-time②">start time</a> is
                the time of the <a data-link-type="dfn" href="#style-change-event" id="ref-for-style-change-event⑦">style change event</a> plus: 
         <ol>
          <li>if the <a data-link-type="dfn" href="#matching-transition-delay" id="ref-for-matching-transition-delay②">matching transition delay</a> is nonnegative,
                      the <span id="ref-for-matching-transition-delay③">matching transition delay</span>, or 
          <li>if the <a data-link-type="dfn" href="#matching-transition-delay" id="ref-for-matching-transition-delay④">matching transition delay</a> is negative,
                      the product of
                      the new transition’s <a data-link-type="dfn" href="#transition-reversing-shortening-factor" id="ref-for-transition-reversing-shortening-factor⑤">reversing shortening factor</a> and
                      the <span id="ref-for-matching-transition-delay⑤">matching transition delay</span>, 
         </ol>
        <li> <a data-link-type="dfn" href="#transition-end-time" id="ref-for-transition-end-time①">end time</a> is
                the <a data-link-type="dfn" href="#transition-start-time" id="ref-for-transition-start-time③">start time</a> plus the product of
                the <a data-link-type="dfn" href="#matching-transition-duration" id="ref-for-matching-transition-duration②">matching transition duration</a> and
                the new transition’s <a data-link-type="dfn" href="#transition-reversing-shortening-factor" id="ref-for-transition-reversing-shortening-factor⑥">reversing shortening factor</a>, 
        <li> <a data-link-type="dfn" href="#transition-start-value" id="ref-for-transition-start-value②">start value</a> is
                the <a data-link-type="dfn" href="#current-value" id="ref-for-current-value②">current value</a> of the property
                in the <a data-link-type="dfn" href="#running-transition" id="ref-for-running-transition①⑤">running transition</a>, 
        <li> <a data-link-type="dfn" href="#transition-end-value" id="ref-for-transition-end-value⑥">end value</a> is
                the value of the property
                in the <a data-link-type="dfn" href="#after-change-style" id="ref-for-after-change-style①⑤">after-change style</a>, 
       </ul>
      <li>
        Otherwise, implementations must <a data-link-type="dfn" href="#transition-cancel" id="ref-for-transition-cancel⑤">cancel</a> the <a data-link-type="dfn" href="#running-transition" id="ref-for-running-transition①⑥">running transition</a> and start a new transition whose: 
       <ul>
        <li> <a data-link-type="dfn" href="#transition-start-time" id="ref-for-transition-start-time④">start time</a> is
                the time of the <a data-link-type="dfn" href="#style-change-event" id="ref-for-style-change-event⑧">style change event</a> plus
                the <a data-link-type="dfn" href="#matching-transition-delay" id="ref-for-matching-transition-delay⑥">matching transition delay</a>, 
        <li> <a data-link-type="dfn" href="#transition-end-time" id="ref-for-transition-end-time②">end time</a> is
                the <a data-link-type="dfn" href="#transition-start-time" id="ref-for-transition-start-time⑤">start time</a> plus
                the <a data-link-type="dfn" href="#matching-transition-duration" id="ref-for-matching-transition-duration③">matching transition duration</a>, 
        <li> <a data-link-type="dfn" href="#transition-start-value" id="ref-for-transition-start-value③">start value</a> is
                the <a data-link-type="dfn" href="#current-value" id="ref-for-current-value③">current value</a> of the property
                in the <a data-link-type="dfn" href="#running-transition" id="ref-for-running-transition①⑦">running transition</a>, 
        <li> <a data-link-type="dfn" href="#transition-end-value" id="ref-for-transition-end-value⑦">end value</a> is
                the value of the property
                in the <a data-link-type="dfn" href="#after-change-style" id="ref-for-after-change-style①⑥">after-change style</a>, 
        <li> <a data-link-type="dfn" href="#transition-reversing-adjusted-start-value" id="ref-for-transition-reversing-adjusted-start-value⑤">reversing-adjusted start value</a> is the same as
                the <a data-link-type="dfn" href="#transition-start-value" id="ref-for-transition-start-value④">start value</a>, and 
        <li> <a data-link-type="dfn" href="#transition-reversing-shortening-factor" id="ref-for-transition-reversing-shortening-factor⑦">reversing shortening factor</a> is 1. 
       </ul>
     </ol>
   </ol>
   <div class="note" role="note">
    <p> Note that the above rules mean that
          when the computed value of an animatable property changes,
          the transitions that start are based on the
          values of the <a class="property" data-link-type="propdesc" href="#propdef-transition-property" id="ref-for-propdef-transition-property⑧">transition-property</a>, <a class="property" data-link-type="propdesc" href="#propdef-transition-duration" id="ref-for-propdef-transition-duration⑤">transition-duration</a>, <a class="property" data-link-type="propdesc" href="#propdef-transition-timing-function" id="ref-for-propdef-transition-timing-function④">transition-timing-function</a>, and <a class="property" data-link-type="propdesc" href="#propdef-transition-delay" id="ref-for-propdef-transition-delay⑦">transition-delay</a> properties
          at the time the animatable property would first have its new
          computed value.
          This means that when one of these <a class="property" data-link-type="propdesc">transition-*</a> properties
          changes at the same time as
          a property whose change might transition,
          it is the <em>new</em> values of the <span class="property">transition-*</span> properties
          that control the transition. </p>
    <div class="example" id="manual-reversing-example">
     <a class="self-link" href="#manual-reversing-example"></a> 
     <p style="display:none"> Example(s): </p>
     <p>This provides a way for authors to specify different values
          of the <a class="property" data-link-type="propdesc">transition-*</a> properties for the “forward”
          and “reverse” transitions,
          when the transitions are between two states
          (but see <a href="#reversing">below</a> for special reversing behavior when
          an <em>incomplete</em> transition is interrupted).  Authors can
          specify the value of <a class="property" data-link-type="propdesc" href="#propdef-transition-duration" id="ref-for-propdef-transition-duration⑥">transition-duration</a>, <a class="property" data-link-type="propdesc" href="#propdef-transition-timing-function" id="ref-for-propdef-transition-timing-function⑤">transition-timing-function</a>, or <a class="property" data-link-type="propdesc" href="#propdef-transition-delay" id="ref-for-propdef-transition-delay⑧">transition-delay</a> in the same
          rule where they specify the value that triggers the transition,
          or can change these properties at the same time as they change
          the property that triggers the transition.  Since it’s the new
          values of these <span class="property">transition-*</span> properties that affect the
          transition, these values will be used for the transitions <em>to</em> the associated transitioning values.  For example: </p>
<pre>li {
  transition: background-color linear 1s;
  background: blue;
}
li:hover {
  background-color: green;
  transition-duration: 2s; /* applies to the transition *to* the :hover state */
}</pre>
     <p> When a list item with these style rules enters the :hover
            state, the computed <a class="property" data-link-type="propdesc" href="#propdef-transition-duration" id="ref-for-propdef-transition-duration⑦">transition-duration</a> at the time that <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css2/colors.html#propdef-background-color" id="ref-for-propdef-background-color②">background-color</a> would have its new value (<span class="css">green</span>) is <span class="css">2s</span>,
            so the transition from <span class="css">blue</span> to <span class="css">green</span> takes 2 seconds.
            However, when the list item leaves the :hover state, the
            transition from <span class="css">green</span> to <span class="css">blue</span> takes 1 second. </p>
    </div>
   </div>
   <p class="note" role="note"> Note that once the transition of a property has started
        (including being in its delay phase),
        it continues running based on
        the original timing function, duration, and
        delay, even if the <a class="property" data-link-type="propdesc" href="#propdef-transition-timing-function" id="ref-for-propdef-transition-timing-function⑥">transition-timing-function</a>, <a class="property" data-link-type="propdesc" href="#propdef-transition-duration" id="ref-for-propdef-transition-duration⑧">transition-duration</a>, or <a class="property" data-link-type="propdesc" href="#propdef-transition-delay" id="ref-for-propdef-transition-delay⑨">transition-delay</a> property changes
        before the transition is complete.  However, if the <a class="property" data-link-type="propdesc" href="#propdef-transition-property" id="ref-for-propdef-transition-property⑨">transition-property</a> property changes such that the transition
        would not have started, the transition stops (and the
        property immediately changes to its final value). </p>
   <p class="note" role="note"> Note that above rules mean that
        transitions do not start when the computed
        value of a property changes as a result of declarative animation
        (as opposed to scripted animation).
        This happens because the before-change style includes up-to-date
        style for declarative animations. </p>
   <h3 class="heading settled" data-level="3.1" id="reversing"><span class="secno">3.1. </span><span class="content">Faster reversing of interrupted transitions</span><a class="self-link" href="#reversing"></a></h3>
   <div class="note" role="note">
    <p> Many common transitions effects involve transitions between two states,
        such as the transition that occurs when the mouse pointer moves
        over a user interface element, and then later moves out of that element.
        With these effects, it is common for a running transition
        to be interrupted before it completes,
        and the property reset to the starting value of that transition.
        An example is a hover effect on an element,
        where a transition starts when the pointer enters the element,
        and then the pointer exits the element before the effect has completed.
        If the outgoing and incoming transitions
        are executed using their specified durations and timing functions,
        the resulting effect can be distractingly asymmetric
        because the second transition
        takes the full specified time to move a shortened distance.
        Instead, this specification makes second transition shorter. </p>
    <p> The mechanism the above rules use to cause this involves the <a data-link-type="dfn" href="#transition-reversing-shortening-factor" id="ref-for-transition-reversing-shortening-factor⑧">reversing shortening factor</a> and the <a data-link-type="dfn" href="#transition-reversing-adjusted-start-value" id="ref-for-transition-reversing-adjusted-start-value⑥">reversing-adjusted start value</a>.
        In particular, the reversing behavior is present whenever
        the <span id="ref-for-transition-reversing-shortening-factor⑨">reversing shortening factor</span> is less than 1. </p>
    <p class="note" role="note"> Note that these rules do not fully address the problem for
        transition patterns that involve more than two states. </p>
    <p class="note" role="note"> Note that these rules lead to the entire timing function of the
        new transition being used, rather than jumping into the middle
        of a timing function, which can create a jarring effect. </p>
    <p class="note" role="note"> This was one of several possibilities that was considered by the
        working group.  See the <a href="transition-reversing-demo">reversing demo</a> demonstrating a number of them, leading to a working group
        resolution made on 2013-06-07 and edits made on 2013-11-11. </p>
   </div>
   <h2 class="heading settled" data-level="4" id="application"><span class="secno">4. </span><span class="content">Application of transitions</span><a class="self-link" href="#application"></a></h2>
   <p> When a property on an element is undergoing a transition
        (that is, when or after the transition has started and before the <a data-link-type="dfn" href="#transition-end-time" id="ref-for-transition-end-time③">end time</a> of the transition)
        the transition adds a style called the <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="current-value">current value</dfn> to the CSS cascade
        at the level defined for CSS Transitions in <a data-link-type="biblio" href="#biblio-css3cascade">[CSS3CASCADE]</a>. </p>
   <p class="note" role="note"> Note that this means that computed values
        resulting from CSS transitions
        can inherit to descendants just like
        any other computed values.
        In the normal case, this means that
        a transition of an inherited property
        applies to descendant elements
        just as an author would expect. </p>
   <p> Implementations must add this value to the cascade
        if and only if
        that property is not currently
        undergoing a CSS Animation (<a data-link-type="biblio" href="#biblio-css3-animations">[CSS3-ANIMATIONS]</a>) on the same element. </p>
   <p class="note" role="note"> Note that this behavior of transitions not applying to the cascade
        when an animation on the same element and property is running
        does not affect whether the transition has started or ended.
        APIs that expose whether transitions are running
        (such as <a href="#transition-events">transition events</a>)
        still report that a transition is running. </p>
   <p> If the current time is at or before the <a data-link-type="dfn" href="#transition-start-time" id="ref-for-transition-start-time⑥">start time</a> of the transition
        (that is, during the delay phase of the transition),
        the <a data-link-type="dfn" href="#current-value" id="ref-for-current-value④">current value</a> is a specified style that will compute
        to the <a data-link-type="dfn" href="#transition-start-value" id="ref-for-transition-start-value⑤">start value</a> of the transition. </p>
   <p> If the current time is after the <a data-link-type="dfn" href="#transition-start-time" id="ref-for-transition-start-time⑦">start time</a> of the transition
        (that is, during the duration phase of the transition),
        the <a data-link-type="dfn" href="#current-value" id="ref-for-current-value⑤">current value</a> is a specified style that will compute
        to the result of <a data-link-type="dfn" href="https://drafts.csswg.org/css-values-4/#interpolation" id="ref-for-interpolation①">interpolating</a> the property
        using the following values: </p>
   <ul>
    <li data-md>
     <p><var>V<sub>a</sub></var>: <a data-link-type="dfn" href="#transition-start-value" id="ref-for-transition-start-value⑥">start value</a> of the transition</p>
    <li data-md>
     <p><var>V<sub>b</sub></var>: <a data-link-type="dfn" href="#transition-end-value" id="ref-for-transition-end-value⑧">end value</a> of the transition</p>
    <li data-md>
     <p><var>p</var>: the output of the <a href="#transition-timing-function-property">timing function</a> for input (current time - start time) / (end time - start time)</p>
   </ul>
   <p></p>
   <p>The specific <a data-link-type="dfn" href="https://drafts.csswg.org/css-values-4/#interpolation" id="ref-for-interpolation②">interpolation</a> procedure to be used
      is defined by the property’s <a data-link-type="dfn" href="https://drafts.csswg.org/web-animations-1/#animation-type" id="ref-for-animation-type④">animation type</a>.</p>
   <h2 class="heading settled" data-level="5" id="complete"><span class="secno">5. </span><span class="content">Completion of transitions</span><a class="self-link" href="#complete"></a></h2>
   <p> <a data-link-type="dfn" href="#running-transition" id="ref-for-running-transition①⑧">Running transitions</a> <dfn class="dfn-paneled" data-dfn-for="transition" data-dfn-type="dfn" data-export id="dfn-complete">complete</dfn> at a time that is equal to or after their end time,
        but prior to to the first <a data-link-type="dfn" href="#style-change-event" id="ref-for-style-change-event⑨">style change event</a> whose time is equal to or after their <a data-link-type="dfn" href="#transition-end-time" id="ref-for-transition-end-time④">end time</a>.
        When a transition completes,
        implementations must move
        all transitions that complete at that time
        from the set of <span id="ref-for-running-transition①⑨">running transitions</span> to the set of <a data-link-type="dfn" href="#completed-transition" id="ref-for-completed-transition①②">completed transitions</a> and then fire the <a href="#transition-events">events</a> for those completions. <span class="note">(Note that doing otherwise, that is,
        firing some of the events before doing all of the moving
        from <a data-link-type="dfn" href="#running-transition" id="ref-for-running-transition②⓪">running transitions</a> to <a data-link-type="dfn" href="#completed-transition" id="ref-for-completed-transition①③">completed transitions</a>,
        could allow
        a style change event to happen
        without the necessary transitions completing,
        since firing the event could cause a style change event,
        if an event handler requests up-to-date computed style or
        layout data.)</span> </p>
   <h2 class="heading settled" data-level="6" id="transition-events"><span class="secno">6. </span><span class="content"><span id="transition-events-">Transition Events</span></span><a class="self-link" href="#transition-events"></a></h2>
   <p>The creation, beginning, completion, and cancellation of CSS transitions
generate corresponding DOM Events.
An event is <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#concept-event-dispatch" id="ref-for-concept-event-dispatch">dispatched</a> to the element for each property that undergoes
a transition on that element.
This allows a content developer to perform actions that synchronize
with changes to transitions.</p>
   <p>Each event provides the name of the property the transition is
associated with as well as the duration of the transition.</p>
   <h3 class="heading settled" data-level="6.1" id="interface-transitionevent"><span class="secno">6.1. </span><span class="content">Interface <code class="idl"><a data-link-type="idl" href="#transitionevent" id="ref-for-transitionevent">TransitionEvent</a></code></span><a class="self-link" href="#interface-transitionevent"></a></h3>
   <p>The <code class="idl"><a data-link-type="idl" href="#transitionevent" id="ref-for-transitionevent①">TransitionEvent</a></code> interface provides specific contextual information
associated with transitions.</p>
   <h4 class="heading settled" data-level="6.1.1" id="interface-transitionevent-idl"><span class="secno">6.1.1. </span><span class="content">IDL Definition</span><a class="self-link" href="#interface-transitionevent-idl"></a></h4>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="transitionevent"><code><c- g>TransitionEvent</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#event" id="ref-for-event"><c- n>Event</c-></a> {
  <a class="idl-code" data-link-type="constructor" href="#dom-transitionevent-transitionevent" id="ref-for-dom-transitionevent-transitionevent"><c- g>constructor</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="TransitionEvent/TransitionEvent(type, transitionEventInitDict), TransitionEvent/constructor(type, transitionEventInitDict), TransitionEvent/TransitionEvent(type), TransitionEvent/constructor(type)" data-dfn-type="argument" data-export id="dom-transitionevent-transitionevent-type-transitioneventinitdict-type"><code><c- g>type</c-></code><a class="self-link" href="#dom-transitionevent-transitionevent-type-transitioneventinitdict-type"></a></dfn>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-transitioneventinit" id="ref-for-dictdef-transitioneventinit"><c- n>TransitionEventInit</c-></a> <dfn class="idl-code" data-dfn-for="TransitionEvent/TransitionEvent(type, transitionEventInitDict), TransitionEvent/constructor(type, transitionEventInitDict), TransitionEvent/TransitionEvent(type), TransitionEvent/constructor(type)" data-dfn-type="argument" data-export id="dom-transitionevent-transitionevent-type-transitioneventinitdict-transitioneventinitdict"><code><c- g>transitionEventInitDict</c-></code><a class="self-link" href="#dom-transitionevent-transitionevent-type-transitioneventinitdict-transitioneventinitdict"></a></dfn> = {});
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#Events-TransitionEvent-propertyName" id="ref-for-Events-TransitionEvent-propertyName"><c- g>propertyName</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#Events-TransitionEvent-elapsedTime" id="ref-for-Events-TransitionEvent-elapsedTime"><c- g>elapsedTime</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#Events-TransitionEvent-pseudoElement" id="ref-for-Events-TransitionEvent-pseudoElement"><c- g>pseudoElement</c-></a>;
};

<c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-transitioneventinit"><code><c- g>TransitionEventInit</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#dictdef-eventinit" id="ref-for-dictdef-eventinit"><c- n>EventInit</c-></a> {
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring③"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-default="&quot;&quot;" data-dfn-for="TransitionEventInit" data-dfn-type="dict-member" data-export data-type="CSSOMString " id="dom-transitioneventinit-propertyname"><code><c- g>propertyName</c-></code><a class="self-link" href="#dom-transitioneventinit-propertyname"></a></dfn> = "";
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double①"><c- b>double</c-></a> <dfn class="idl-code" data-default="0.0" data-dfn-for="TransitionEventInit" data-dfn-type="dict-member" data-export data-type="double " id="dom-transitioneventinit-elapsedtime"><code><c- g>elapsedTime</c-></code><a class="self-link" href="#dom-transitioneventinit-elapsedtime"></a></dfn> = 0.0;
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring④"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-default="&quot;&quot;" data-dfn-for="TransitionEventInit" data-dfn-type="dict-member" data-export data-type="CSSOMString " id="dom-transitioneventinit-pseudoelement"><code><c- g>pseudoElement</c-></code><a class="self-link" href="#dom-transitioneventinit-pseudoelement"></a></dfn> = "";
};
</pre>
   <h4 class="heading settled" data-level="6.1.2" id="interface-transitionevent-attributes"><span class="secno">6.1.2. </span><span class="content">Attributes</span><a class="self-link" href="#interface-transitionevent-attributes"></a></h4>
   <dl>
    <dt data-md><code class="attribute-name"><dfn class="dfn-paneled idl-code" data-dfn-for="TransitionEvent" data-dfn-type="attribute" data-export id="Events-TransitionEvent-propertyName"><code>propertyName</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑤">CSSOMString</a>, readonly</span></code>
    <dd data-md>
     <p>The name of the CSS property associated with the transition.</p>
     <p class="note" role="note">Note:  This is always the name of a longhand property.  See <a class="property" data-link-type="propdesc" href="#propdef-transition-property" id="ref-for-propdef-transition-property①⓪">transition-property</a> for how specifying shorthand properties causes transitions on longhands.</p>
    <dt data-md><code class="attribute-name"><dfn class="dfn-paneled idl-code" data-dfn-for="TransitionEvent" data-dfn-type="attribute" data-export id="Events-TransitionEvent-elapsedTime"><code>elapsedTime</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double②">double</a>, readonly</span></code>
    <dd data-md>
     <p>The amount of time the transition has been running, in seconds, when this
event fired not including any time spent in the delay phase.
The calculation for of this member is defined along with each event type.</p>
    <dt data-md><code class="attribute-name"><dfn class="dfn-paneled idl-code" data-dfn-for="TransitionEvent" data-dfn-type="attribute" data-export id="Events-TransitionEvent-pseudoElement"><code>pseudoElement</code></dfn>, <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring⑥">CSSOMString</a>, readonly</span></code>
    <dd data-md>
     <p>The name (beginning with two colons) of the CSS
pseudo-element on which the transition occurred (in
which case the target of the event is that
pseudo-element’s corresponding element), or the empty
string if the transition occurred on an element (which
means the target of the event is that element).</p>
   </dl>
   <p><code id="TransitionEvent-constructor"><dfn class="dfn-paneled idl-code" data-dfn-for="TransitionEvent" data-dfn-type="constructor" data-export data-lt="TransitionEvent(type, transitionEventInitDict)|constructor(type, transitionEventInitDict)|TransitionEvent(type)|constructor(type)" id="dom-transitionevent-transitionevent"><code>TransitionEvent(type, transitionEventInitDict)</code></dfn></code> is an <a data-link-type="dfn" href="http://w3c.github.io/dom/#constructing-events" id="ref-for-constructing-events">event constructor</a>.</p>
   <h3 class="heading settled" data-level="6.2" id="event-transitionevent"><span class="secno">6.2. </span><span class="content">Types of <code>TransitionEvent</code></span><a class="self-link" href="#event-transitionevent"></a></h3>
   <p>The different types of transition events that can occur are:</p>
   <dl>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="transitionevent" data-dfn-type="event" data-export id="transitionrun"><code>transitionrun</code></dfn>
    <dd>
      The <code class="idl"><a data-link-type="idl" href="#transitionrun" id="ref-for-transitionrun">transitionrun</a></code> event occurs when a transition is created (i.e.,
      when it is added to the set of <a data-link-type="dfn" href="#running-transition" id="ref-for-running-transition②①">running transitions</a>). 
     <p>A negative <a class="property" data-link-type="propdesc" href="#propdef-transition-delay" id="ref-for-propdef-transition-delay①⓪">transition-delay</a> will cause the event to fire with
      an <code class="idl"><a data-link-type="idl" href="#Events-TransitionEvent-elapsedTime" id="ref-for-Events-TransitionEvent-elapsedTime①">elapsedTime</a></code> equal to the absolute value of the
      delay capped to the <a class="property" data-link-type="propdesc" href="#propdef-transition-duration" id="ref-for-propdef-transition-duration⑨">transition-duration</a> of the animation. That is,
      the elapsed time is equal to <code>min(max(-<a class="property" data-link-type="propdesc" href="#propdef-transition-delay" id="ref-for-propdef-transition-delay①①">transition-delay</a>, 0), <a class="property" data-link-type="propdesc" href="#propdef-transition-duration" id="ref-for-propdef-transition-duration①⓪">transition-duration</a>)</code>.</p>
     <ul>
      <li>Bubbles: Yes
      <li>Cancelable: No
      <li>Context Info: propertyName, elapsedTime, pseudoElement
     </ul>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="transitionevent" data-dfn-type="event" data-export id="transitionstart"><code>transitionstart</code></dfn>
    <dd>
      The <code class="idl"><a data-link-type="idl" href="#transitionstart" id="ref-for-transitionstart">transitionstart</a></code> event occurs when a transition’s delay phase ends. 
     <p>The value of <code class="idl"><a data-link-type="idl" href="#Events-TransitionEvent-elapsedTime" id="ref-for-Events-TransitionEvent-elapsedTime②">elapsedTime</a></code> for <code class="idl"><a data-link-type="idl" href="#transitionstart" id="ref-for-transitionstart①">transitionstart</a></code> events is the same as the value used for <code class="idl"><a data-link-type="idl" href="#transitionrun" id="ref-for-transitionrun①">transitionrun</a></code> events.</p>
     <ul>
      <li>Bubbles: Yes
      <li>Cancelable: No
      <li>Context Info: propertyName, elapsedTime, pseudoElement
     </ul>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="transitionevent" data-dfn-type="event" data-export id="transitionend"><code>transitionend</code></dfn>
    <dd>
      The <code class="idl"><a data-link-type="idl" href="#transitionend" id="ref-for-transitionend">transitionend</a></code> event occurs at the completion of the transition. In
      the case where a transition is removed before completion, such as if the <a class="property" data-link-type="propdesc" href="#propdef-transition-property" id="ref-for-propdef-transition-property①①">transition-property</a> is removed, then the event will not fire. 
     <p>The value of <code class="idl"><a data-link-type="idl" href="#Events-TransitionEvent-elapsedTime" id="ref-for-Events-TransitionEvent-elapsedTime③">elapsedTime</a></code> for this event is equal to
      the value of <a class="property" data-link-type="propdesc" href="#propdef-transition-duration" id="ref-for-propdef-transition-duration①①">transition-duration</a>.</p>
     <ul>
      <li>Bubbles: Yes
      <li>Cancelable: No
      <li>Context Info: propertyName, elapsedTime, pseudoElement
     </ul>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="transitionevent" data-dfn-type="event" data-export id="transitioncancel"><code>transitioncancel</code></dfn>
    <dd>
      The <code class="idl"><a data-link-type="idl" href="#transitioncancel" id="ref-for-transitioncancel">transitioncancel</a></code> event occurs when a transition is <a data-link-type="dfn" href="#transition-cancel" id="ref-for-transition-cancel⑥">canceled</a>. 
     <p>The <code class="idl"><a data-link-type="idl" href="#Events-TransitionEvent-elapsedTime" id="ref-for-Events-TransitionEvent-elapsedTime④">elapsedTime</a></code> for <code class="idl"><a data-link-type="idl" href="#transitioncancel" id="ref-for-transitioncancel①">transitioncancel</a></code> events is
      the number of seconds from the end of the transition’s delay to the
      moment when the transition was canceled.
      If the transition had a negative <a class="property" data-link-type="propdesc" href="#propdef-transition-delay" id="ref-for-propdef-transition-delay①②">transition-delay</a>, the beginning of the
      transition is the moment equal to the absolute value of <span class="property" id="ref-for-propdef-transition-delay①③">transition-delay</span> seconds <em>prior</em> to when the transition was actually triggered.
      Alternatively, if the transition had a positive <span class="property" id="ref-for-propdef-transition-delay①④">transition-delay</span> and the
      event is fired before the transition’s delay has expired, the <code class="idl"><a data-link-type="idl" href="https://drafts.csswg.org/css-animations-1/#dom-animationevent-elapsedtime" id="ref-for-dom-animationevent-elapsedtime">elapsedTime</a></code> will be zero.</p>
     <ul>
      <li>Bubbles: Yes
      <li>Cancelable: No
      <li>Context Info: propertyName, elapsedTime, pseudoElement
     </ul>
   </dl>
   <h3 class="heading settled" data-level="6.3" id="event-handlers-on-elements-document-objects-and-window-objects"><span class="secno">6.3. </span><span class="content">Event handlers on elements, <code>Document</code> objects, and <code>Window</code> objects</span><a class="self-link" href="#event-handlers-on-elements-document-objects-and-window-objects"></a></h3>
   <p>The following are the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handlers" id="ref-for-event-handlers">event handlers</a> (and their corresponding <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-event-type" id="ref-for-event-handler-event-type">event
handler event types</a>) that must be supported by all <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#html-elements" id="ref-for-html-elements">HTML elements</a>, as
both <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-content-attributes" id="ref-for-event-handler-content-attributes">event handler content attributes</a> and <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-idl-attributes" id="ref-for-event-handler-idl-attributes">event handler IDL
attributes</a>; and that must be supported by all <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/#document" id="ref-for-document">Document</a></code> and <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window">Window</a></code> objects, as <span id="ref-for-event-handler-idl-attributes①">event handler IDL attributes</span>:</p>
   <table class="event-handlers">
    <tbody>
     <tr>
      <th><a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handlers" id="ref-for-event-handlers①">Event handler</a>
      <th><a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-event-type" id="ref-for-event-handler-event-type①">Event handler event type</a>
     <tr>
      <td><code class="idl"><a data-link-type="idl" href="#dom-globaleventhandlers-ontransitionrun" id="ref-for-dom-globaleventhandlers-ontransitionrun">ontransitionrun</a></code>
      <td><a data-link-type="idl" href="#transitionrun" id="ref-for-transitionrun②">transitionrun</a>
     <tr>
      <td><code class="idl"><a data-link-type="idl" href="#dom-globaleventhandlers-ontransitionstart" id="ref-for-dom-globaleventhandlers-ontransitionstart">ontransitionstart</a></code>
      <td><a data-link-type="idl" href="#transitionstart" id="ref-for-transitionstart②">transitionstart</a>
     <tr>
      <td><code class="idl"><a data-link-type="idl" href="#dom-globaleventhandlers-ontransitionend" id="ref-for-dom-globaleventhandlers-ontransitionend">ontransitionend</a></code>
      <td><a data-link-type="idl" href="#transitionend" id="ref-for-transitionend①">transitionend</a>
     <tr>
      <td><code class="idl"><a data-link-type="idl" href="#dom-globaleventhandlers-ontransitioncancel" id="ref-for-dom-globaleventhandlers-ontransitioncancel">ontransitioncancel</a></code>
      <td><a data-link-type="idl" href="#transitioncancel" id="ref-for-transitioncancel②">transitioncancel</a>
   </table>
   <h2 class="heading settled" data-level="7" id="interface-dom"><span class="secno">7. </span><span class="content">DOM Interfaces</span><a class="self-link" href="#interface-dom"></a></h2>
   <p>This specification extends the <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/webappapis.html#globaleventhandlers" id="ref-for-globaleventhandlers">GlobalEventHandlers</a></code> interface mixin from HTML to
add <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-idl-attributes" id="ref-for-event-handler-idl-attributes②">event handler IDL attributes</a> for <a href="#transition-events">transition events</a> as defined in <a href="#event-handlers-on-elements-document-objects-and-window-objects">§ 6.3 Event handlers on elements, Document objects, and Window objects</a>.</p>
   <h3 class="heading settled" data-level="7.1" id="interface-globaleventhandlers-idl"><span class="secno">7.1. </span><span class="content">IDL Definition</span><a class="self-link" href="#interface-globaleventhandlers-idl"></a></h3>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <c- b>mixin</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/webappapis.html#globaleventhandlers" id="ref-for-globaleventhandlers①"><c- g>GlobalEventHandlers</c-></a> {
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler" id="ref-for-eventhandler"><c- n>EventHandler</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="GlobalEventHandlers" data-dfn-type="attribute" data-export data-type="EventHandler" id="dom-globaleventhandlers-ontransitionrun"><code><c- g>ontransitionrun</c-></code></dfn>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler" id="ref-for-eventhandler①"><c- n>EventHandler</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="GlobalEventHandlers" data-dfn-type="attribute" data-export data-type="EventHandler" id="dom-globaleventhandlers-ontransitionstart"><code><c- g>ontransitionstart</c-></code></dfn>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler" id="ref-for-eventhandler②"><c- n>EventHandler</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="GlobalEventHandlers" data-dfn-type="attribute" data-export data-type="EventHandler" id="dom-globaleventhandlers-ontransitionend"><code><c- g>ontransitionend</c-></code></dfn>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler" id="ref-for-eventhandler③"><c- n>EventHandler</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="GlobalEventHandlers" data-dfn-type="attribute" data-export data-type="EventHandler" id="dom-globaleventhandlers-ontransitioncancel"><code><c- g>ontransitioncancel</c-></code></dfn>;
};
</pre>
   <h2 class="heading settled" data-level="8" id="security"><span class="secno">8. </span><span class="content">Security Considerations</span><a class="self-link" href="#security"></a></h2>
   <p><em>This section is not normative.</em></p>
   <p>The security implications of this specification are limited
because it doesn’t allow Web content to do things
that it could not do before.
Rather, it allows things that could previously be done with script
to be done declaratively,
and it ways that implementations can optimize (for frame rate and
CPU usage).</p>
   <p>One of the major categories of optimizations
that implementations can make is implementing animation
of certain high-value properties (such as <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-transforms-1/#propdef-transform" id="ref-for-propdef-transform">transform</a> and <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-color-3/#opacity" id="ref-for-opacity③">opacity</a>)
run on a browser’s compositor thread or process
without updating style or layout on the main Web content thread
unless up-to-date style data are needed.
This optimization often requires allocations of graphics memory
to display the contents of the element being animated.
Implementations should take care to ensure that Web content
cannot trigger unsafe out-of-memory handling
by using large numbers of animations
or animations on elements covering large areas
(where large may be defined in terms of pre-transform or post-transform size).</p>
   <h2 class="heading settled" data-level="9" id="privacy"><span class="secno">9. </span><span class="content">Privacy Considerations</span><a class="self-link" href="#privacy"></a></h2>
   <p><em>This section is not normative.</em></p>
   <p>As for security, the privacy considerations of this specification are limited
because it does not allow Web content to do things that it could not do before.</p>
   <p>This specification may provide additional mechanisms that help to determine
characteristics of the user’s hardware or software.
However, ability to determine performance characteristics of the user’s
hardware or software is common to many Web technologies,
and this specification does not introduce new capabilities.</p>
   <p>As described in <a href="#accessibility">§ 10 Accessibility Considerations</a>,
implementations may provide mitigations to help users with disabilities.
These mitigations are likely to be detectable by Web content,
which means that users who would benefit from these mitigations
may face a tradeoff between keeping their disability private from
the Web content or benefiting from the mitigation.</p>
   <h2 class="heading settled" data-level="10" id="accessibility"><span class="secno">10. </span><span class="content">Accessibility Considerations</span><a class="self-link" href="#accessibility"></a></h2>
   <p><em>This section is not normative.</em></p>
   <h3 class="heading settled" data-level="10.1" id="accessibility-motion"><span class="secno">10.1. </span><span class="content">Motion</span><a class="self-link" href="#accessibility-motion"></a></h3>
   <p>This specification provides declarative mechanisms for animations
that previously needed to be done using script.
Providing a declarative mechanism has multiple effects:
it makes such animations easier to make and thus likely to be more common,
but it also makes it easier for user agents to modify those animations
if such modifications are needed to meet a user’s accessibility needs.</p>
   <p>Thus, users who are sensitive to movement,
or who require additional time to read or understand content,
may benefit from user agent features that allow
animations to be disabled or slowed down.
(But see <a href="#privacy">§ 9 Privacy Considerations</a> for information on the privacy implications
of such mitigations.)</p>
   <p>User agent implementors should be aware that Web content
may depend on the firing of <a href="#transition-events">transition events</a>,
so implementations of such mitigations may wish to fire transition events
even if the transitions were not run as continuous animations.
However, it is probably poor practice for Web content to depend on
such events to function correctly.</p>
   <h3 class="heading settled" data-level="10.2" id="accessibility-cascade"><span class="secno">10.2. </span><span class="content">Cascade</span><a class="self-link" href="#accessibility-cascade"></a></h3>
   <p>The CSS <a data-link-type="dfn" href="https://drafts.csswg.org/css-cascade-4/#cascade" id="ref-for-cascade">cascade</a> is a general mechanism in CSS
that allows user needs to interact with author styles.
This specification interacts with the cascade,
but since it only allows animation between values
that result from the existing cascade rules,
it does not interfere with the user’s ability to force
CSS properties to have particular values.</p>
   <p>The cascade also allows users to disable transitions entirely
by overriding the transition properties.</p>
   <h2 class="heading settled" data-level="11" id="changes"><span class="secno">11. </span><span class="content">Changes since Working Draft of 30 November 2017</span><a class="self-link" href="#changes"></a></h2>
   <p>The following are the substantive changes made since the <a href="https://www.w3.org/TR/2017/WD-css-transitions-1-20171130/">Working Draft
dated 11 October 2018</a>:</p>
   <ul>
    <li data-md>
     <p>(Nothing yet)</p>
   </ul>
   <p>For more details on these changes, see the version control <a href="https://github.com/w3c/csswg-drafts/commits/master/css-transitions-1/Overview.bs">change log</a>.</p>
   <p>For changes in earlier working drafts:</p>
   <ol>
    <li data-md>
     <p>See the <a href="https://www.w3.org/TR/2018/WD-css-transitions-1-20181011/#changes">changes
 section in the 11 October 2018 Working Draft</a>.</p>
    <li data-md>
     <p>See the <a href="https://www.w3.org/TR/2017/WD-css-transitions-1-20171130/#changes">changes
 section in the 30 November 2017 Working Draft</a>.</p>
    <li data-md>
     <p>See the <a href="https://www.w3.org/TR/2013/WD-css3-transitions-20131119/#changes">changes
 section in the 19 November 2013 Working Draft</a>.</p>
    <li data-md>
     <p>See the <a href="https://www.w3.org/TR/2013/WD-css3-transitions-20130212/ChangeLog">the
 ChangeLog</a> for changes in previous working drafts.</p>
    <li data-md>
     <p>For more details on these changes, see the version control change logs,
 which are split in many parts because of file renaming:</p>
     <ul>
      <li data-md>
       <p><a href="https://github.com/w3c/csswg-drafts/commits/master/css-transitions-1/Overview.bs">change log since 2017 October 12</a>,</p>
      <li data-md>
       <p><a href="https://hg.csswg.org/drafts/log/tip/css-transitions/Overview.bs">change log from 2015 January 26 to 2017 October 12</a>,</p>
      <li data-md>
       <p><a href="https://hg.csswg.org/drafts/log/tip/css-transitions/Overview.src.html">change log from 2013 March 28 to 2015 January 26</a>,</p>
      <li data-md>
       <p><a href="https://hg.csswg.org/drafts/log/tip/css3-transitions/Overview.src.html">change log before 2013 March 28</a>.</p>
     </ul>
   </ol>
   <h2 class="heading settled" data-level="12" id="acknowledgments"><span class="secno">12. </span><span class="content">Acknowledgments</span><a class="self-link" href="#acknowledgments"></a></h2>
   <p>Thanks especially to the feedback from
Tab Atkins,
Carine Bournez,
Aryeh Gregor,
Vincent Hardy,
Anne van Kesteren,
Cameron McCormack,
Alex Mogilevsky,
Jasper St. Pierre,
Estelle Weyl,
and all the rest of the <a href="http://lists.w3.org/Archives/Public/www-style/">www-style</a> community.</p>
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
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="transitioncancel">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Document/transitioncancel_event" title="The transitioncancel event is fired when a CSS transition is canceled.">Document/transitioncancel_event</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>53+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>53+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLElement/transitioncancel_event" title="The transitioncancel event is fired when a CSS transition is canceled.">HTMLElement/transitioncancel_event</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>53+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>74+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>62+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>53+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>74+</span></span><span class="webview_android yes"><span>Android WebView</span><span>74+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>11.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>53+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/transitioncancel_event" title="The transitioncancel event is fired when a CSS transition is canceled.">Window/transitioncancel_event</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>53+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>53+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="transitionend">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Document/transitionend_event" title="The transitionend event is fired when a CSS transition has completed. In the case where a transition is removed before completion, such as if the transition-property is removed or display is set to none, then the event will not be generated.">Document/transitionend_event</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>51+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>51+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLElement/transitionend_event" title="The transitionend event is fired when a CSS transition has completed. In the case where a transition is removed before completion, such as if the transition-property is removed or display is set to none, then the event will not be generated.">HTMLElement/transitionend_event</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>51+</span></span><span class="safari yes"><span>Safari</span><span>6.1+</span></span><span class="chrome yes"><span>Chrome</span><span>26+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>51+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>7+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>26+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.5+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>12.1+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/transitionend_event" title="The transitionend event is fired when a CSS transition has completed. In the case where a transition is removed before completion, such as if the transition-property is removed or display is set to none, then the event will not be generated.">Window/transitionend_event</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>51+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>51+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="transitionrun">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Document/transitionrun_event" title="The transitionrun event is fired when a CSS transition is first created, i.e. before any transition-delay has begun.">Document/transitionrun_event</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>53+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>53+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLElement/transitionrun_event" title="The transitionrun event is fired when a CSS transition is first created, i.e. before any transition-delay has begun.">HTMLElement/transitionrun_event</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>53+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>74+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>62+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>53+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>74+</span></span><span class="webview_android yes"><span>Android WebView</span><span>74+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>11.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>53+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/transitionrun_event" title="The transitionrun event is fired when a CSS transition is first created, i.e. before any transition-delay has begun.">Window/transitionrun_event</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>53+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>53+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="transitionstart">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Document/transitionstart_event" title="The transitionstart event is fired when a CSS transition has actually started, i.e., after any transition-delay has ended.">Document/transitionstart_event</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>53+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>53+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLElement/transitionstart_event" title="The transitionstart event is fired when a CSS transition has actually started, i.e., after any transition-delay has ended.">HTMLElement/transitionstart_event</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>53+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>74+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>62+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>53+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>74+</span></span><span class="webview_android yes"><span>Android WebView</span><span>74+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>11.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>53+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/transitionstart_event" title="The transitionstart event is fired when a CSS transition has actually started, i.e., after any transition-delay has ended.">Window/transitionstart_event</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>53+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>53+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-globaleventhandlers-ontransitioncancel">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/GlobalEventHandlers/ontransitioncancel" title="The ontransitioncancel property of the GlobalEventHandlers mixin is an EventHandler that processes transitioncancel events.">GlobalEventHandlers/ontransitioncancel</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>53+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>53+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-globaleventhandlers-ontransitionend">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/GlobalEventHandlers/ontransitionend" title="The ontransitionend property of the GlobalEventHandlers mixin is an EventHandler that processes transitionend events.">GlobalEventHandlers/ontransitionend</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>51+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>51+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-transitionevent-transitionevent">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/TransitionEvent/TransitionEvent" title="The TransitionEvent() constructor returns a newly created TransitionEvent, representing an event in relation with an transition.">TransitionEvent/TransitionEvent</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>23+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>27+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>23+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>27+</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>2.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="Events-TransitionEvent-propertyName">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/TransitionEvent/animationName" title="The TransitionEvent.transitionName read-only property is a DOMString containing the name of the CSS property associated with the transition.">TransitionEvent/animationName</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>4+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="Events-TransitionEvent-elapsedTime">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/TransitionEvent/elapsedTime" title="The TransitionEvent.elapsedTime read-only property is a float giving the amount of time the animation has been running, in seconds, when this event fired. This value is not affected by the transition-delay property.">TransitionEvent/elapsedTime</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>4+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>2+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="Events-TransitionEvent-pseudoElement">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/TransitionEvent/pseudoElement" title="The TransitionEvent.pseudoElement read-only property is a DOMString, starting with &apos;::&apos;, containing the name of the pseudo-element the animation runs on. If the transition doesn&apos;t run on a pseudo-element but on the element, an empty string: &apos;&apos;.">TransitionEvent/pseudoElement</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>23+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>2+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>23+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="interface-transitionevent">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/TransitionEvent" title="The TransitionEvent interface represents events providing information related to transitions.">TransitionEvent</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>4+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>27+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>27+</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>2.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="transition-delay-property">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/transition-delay" title="The transition-delay CSS property specifies the duration to wait before starting a property&apos;s transition effect when its value changes.">transition-delay</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>16+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>26+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>16+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>26+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.5+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>12.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="transition-duration-property">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/transition-duration" title="The transition-duration CSS property sets the length of time a transition animation should take to complete. By default, the value is 0s, meaning that no animation will occur.">transition-duration</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>16+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>26+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>16+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>26+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.5+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>12.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="transition-property-property">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/transition-property" title="The transition-property CSS property sets the CSS properties to which a transition effect should be applied.">transition-property</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>16+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>26+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>16+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>26+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.5+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>12.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="transition-timing-function-property">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/transition-timing-function" title="The transition-timing-function CSS property sets how intermediate values are calculated for CSS properties being affected by a transition effect.">transition-timing-function</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>16+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>26+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>16+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>26+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.5+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>12.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="transition-shorthand-property">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/transition" title="The transition CSS property is a shorthand property for transition-property, transition-duration, transition-timing-function, and transition-delay.">transition</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>16+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>26+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>16+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>26+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.5+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>12.1+</span></span>
    </div>
   </div>
  </aside>
  <h2 class="no-num no-ref heading settled" id="index"><span class="content">Index</span><a class="self-link" href="#index"></a></h2>
  <h3 class="no-num no-ref heading settled" id="index-defined-here"><span class="content">Terms defined by this specification</span><a class="self-link" href="#index-defined-here"></a></h3>
  <ul class="index">
   <li><a href="#after-change-style">after-change style</a><span>, in §3</span>
   <li><a href="#valdef-transition-property-all">all</a><span>, in §2.1</span>
   <li><a href="#before-change-style">before-change style</a><span>, in §3</span>
   <li><a href="#transition-cancel">cancel</a><span>, in §3</span>
   <li><a href="#transition-combined-duration">combined duration</a><span>, in §3</span>
   <li><a href="#dfn-complete">complete</a><span>, in §5</span>
   <li><a href="#completed-transition">completed transition</a><span>, in §3</span>
   <li><a href="#dom-transitionevent-transitionevent">constructor(type)</a><span>, in §6.1.2</span>
   <li><a href="#dom-transitionevent-transitionevent">constructor(type, transitionEventInitDict)</a><span>, in §6.1.2</span>
   <li><a href="#current-value">current value</a><span>, in §4</span>
   <li>
    elapsedTime
    <ul>
     <li><a href="#Events-TransitionEvent-elapsedTime">attribute for TransitionEvent</a><span>, in §6.1.2</span>
     <li><a href="#dom-transitioneventinit-elapsedtime">dict-member for TransitionEventInit</a><span>, in §6.1.1</span>
    </ul>
   <li><a href="#transition-end-time">end time</a><span>, in §3</span>
   <li><a href="#transition-end-value">end value</a><span>, in §3</span>
   <li><a href="#matching-transition-delay">matching transition delay</a><span>, in §3</span>
   <li><a href="#matching-transition-duration">matching transition duration</a><span>, in §3</span>
   <li><a href="#matching-transition-property-value">matching transition-property value</a><span>, in §3</span>
   <li><a href="#matching-transition-timing-function">matching transition timing function</a><span>, in §3</span>
   <li><a href="#valdef-transition-property-none">none</a><span>, in §2.1</span>
   <li><a href="#dom-globaleventhandlers-ontransitioncancel">ontransitioncancel</a><span>, in §7.1</span>
   <li><a href="#dom-globaleventhandlers-ontransitionend">ontransitionend</a><span>, in §7.1</span>
   <li><a href="#dom-globaleventhandlers-ontransitionrun">ontransitionrun</a><span>, in §7.1</span>
   <li><a href="#dom-globaleventhandlers-ontransitionstart">ontransitionstart</a><span>, in §7.1</span>
   <li>
    propertyName
    <ul>
     <li><a href="#Events-TransitionEvent-propertyName">attribute for TransitionEvent</a><span>, in §6.1.2</span>
     <li><a href="#dom-transitioneventinit-propertyname">dict-member for TransitionEventInit</a><span>, in §6.1.1</span>
    </ul>
   <li>
    pseudoElement
    <ul>
     <li><a href="#Events-TransitionEvent-pseudoElement">attribute for TransitionEvent</a><span>, in §6.1.2</span>
     <li><a href="#dom-transitioneventinit-pseudoelement">dict-member for TransitionEventInit</a><span>, in §6.1.1</span>
    </ul>
   <li><a href="#transition-reversing-adjusted-start-value">reversing-adjusted start value</a><span>, in §3</span>
   <li><a href="#transition-reversing-shortening-factor">reversing shortening factor</a><span>, in §3</span>
   <li><a href="#running-transition">running transition</a><span>, in §3</span>
   <li><a href="#single-transition">&lt;single-transition></a><span>, in §2.5</span>
   <li><a href="#single-transition-property">&lt;single-transition-property></a><span>, in §2.1</span>
   <li><a href="#transition-start-time">start time</a><span>, in §3</span>
   <li><a href="#transition-start-value">start value</a><span>, in §3</span>
   <li><a href="#style-change-event">style change event</a><span>, in §3</span>
   <li><a href="#propdef-transition">transition</a><span>, in §2.5</span>
   <li><a href="#transitionable">transitionable</a><span>, in §3</span>
   <li><a href="#transitioncancel">transitioncancel</a><span>, in §6.2</span>
   <li><a href="#propdef-transition-delay">transition-delay</a><span>, in §2.4</span>
   <li><a href="#propdef-transition-duration">transition-duration</a><span>, in §2.2</span>
   <li><a href="#transitionend">transitionend</a><span>, in §6.2</span>
   <li><a href="#transitionevent">TransitionEvent</a><span>, in §6.1.1</span>
   <li><a href="#dictdef-transitioneventinit">TransitionEventInit</a><span>, in §6.1.1</span>
   <li><a href="#dom-transitionevent-transitionevent">TransitionEvent(type)</a><span>, in §6.1.2</span>
   <li><a href="#dom-transitionevent-transitionevent">TransitionEvent(type, transitionEventInitDict)</a><span>, in §6.1.2</span>
   <li><a href="#propdef-transition-property">transition-property</a><span>, in §2.1</span>
   <li><a href="#transitionrun">transitionrun</a><span>, in §6.2</span>
   <li><a href="#transitionstart">transitionstart</a><span>, in §6.2</span>
   <li><a href="#propdef-transition-timing-function">transition-timing-function</a><span>, in §2.3</span>
  </ul>
  <aside class="dfn-panel" data-for="term-for-propdef-background-image">
   <a href="https://drafts.csswg.org/css-backgrounds-3/#propdef-background-image">https://drafts.csswg.org/css-backgrounds-3/#propdef-background-image</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-background-image">2. Transitions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-box-shadow">
   <a href="https://drafts.csswg.org/css-backgrounds-3/#propdef-box-shadow">https://drafts.csswg.org/css-backgrounds-3/#propdef-box-shadow</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-box-shadow">3. Starting of transitions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-all">
   <a href="https://drafts.csswg.org/css-cascade-4/#propdef-all">https://drafts.csswg.org/css-cascade-4/#propdef-all</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-all">2.1. The transition-property Property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cascade">
   <a href="https://drafts.csswg.org/css-cascade-4/#cascade">https://drafts.csswg.org/css-cascade-4/#cascade</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cascade">10.2. Cascade</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-computed-value">
   <a href="https://drafts.csswg.org/css-cascade-4/#computed-value">https://drafts.csswg.org/css-cascade-4/#computed-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-computed-value">2. Transitions</a> <a href="#ref-for-computed-value①">(2)</a>
    <li><a href="#ref-for-computed-value②">3. Starting of transitions</a> <a href="#ref-for-computed-value③">(2)</a> <a href="#ref-for-computed-value④">(3)</a> <a href="#ref-for-computed-value⑤">(4)</a> <a href="#ref-for-computed-value⑥">(5)</a> <a href="#ref-for-computed-value⑦">(6)</a> <a href="#ref-for-computed-value⑧">(7)</a> <a href="#ref-for-computed-value⑨">(8)</a> <a href="#ref-for-computed-value①⓪">(9)</a> <a href="#ref-for-computed-value①①">(10)</a> <a href="#ref-for-computed-value①②">(11)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-all-inherit">
   <a href="https://drafts.csswg.org/css-cascade-4/#valdef-all-inherit">https://drafts.csswg.org/css-cascade-4/#valdef-all-inherit</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-all-inherit">2.1. The transition-property Property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-all-initial">
   <a href="https://drafts.csswg.org/css-cascade-4/#valdef-all-initial">https://drafts.csswg.org/css-cascade-4/#valdef-all-initial</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-all-initial">2.1. The transition-property Property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-opacity">
   <a href="https://drafts.csswg.org/css-color-3/#opacity">https://drafts.csswg.org/css-color-3/#opacity</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-opacity">2. Transitions</a> <a href="#ref-for-opacity①">(2)</a> <a href="#ref-for-opacity②">(3)</a>
    <li><a href="#ref-for-opacity③">8. Security Considerations</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-typedef-easing-function">
   <a href="https://drafts.csswg.org/css-easing-1/#typedef-easing-function">https://drafts.csswg.org/css-easing-1/#typedef-easing-function</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-easing-function">2.3. The transition-timing-function Property</a>
    <li><a href="#ref-for-typedef-easing-function①">2.5. The transition Shorthand Property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-input-progress-value">
   <a href="https://drafts.csswg.org/css-easing-1/#input-progress-value">https://drafts.csswg.org/css-easing-1/#input-progress-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-input-progress-value">2.3. The transition-timing-function Property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-output-progress-value">
   <a href="https://drafts.csswg.org/css-easing-1/#output-progress-value">https://drafts.csswg.org/css-easing-1/#output-progress-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-output-progress-value">2.3. The transition-timing-function Property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-transform">
   <a href="https://drafts.csswg.org/css-transforms-1/#propdef-transform">https://drafts.csswg.org/css-transforms-1/#propdef-transform</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-transform">8. Security Considerations</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-time-value">
   <a href="https://drafts.csswg.org/css-values-3/#time-value">https://drafts.csswg.org/css-values-3/#time-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-time-value">2.2. The transition-duration Property</a>
    <li><a href="#ref-for-time-value①">2.4. The transition-delay Property</a>
    <li><a href="#ref-for-time-value②">2.5. The transition Shorthand Property</a> <a href="#ref-for-time-value③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mult-comma">
   <a href="https://drafts.csswg.org/css-values-4/#mult-comma">https://drafts.csswg.org/css-values-4/#mult-comma</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mult-comma">2.1. The transition-property Property</a>
    <li><a href="#ref-for-mult-comma①">2.2. The transition-duration Property</a>
    <li><a href="#ref-for-mult-comma②">2.3. The transition-timing-function Property</a>
    <li><a href="#ref-for-mult-comma③">2.4. The transition-delay Property</a>
    <li><a href="#ref-for-mult-comma④">2.5. The transition Shorthand Property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-identifier-value">
   <a href="https://drafts.csswg.org/css-values-4/#identifier-value">https://drafts.csswg.org/css-values-4/#identifier-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-identifier-value">2.1. The transition-property Property</a> <a href="#ref-for-identifier-value①">(2)</a> <a href="#ref-for-identifier-value②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-css-wide-keywords">
   <a href="https://drafts.csswg.org/css-values-4/#css-wide-keywords">https://drafts.csswg.org/css-values-4/#css-wide-keywords</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-wide-keywords">1.1. Value Definitions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-interpolation">
   <a href="https://drafts.csswg.org/css-values-4/#interpolation">https://drafts.csswg.org/css-values-4/#interpolation</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-interpolation">2.3. The transition-timing-function Property</a>
    <li><a href="#ref-for-interpolation①">4. Application of transitions</a> <a href="#ref-for-interpolation②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-interpolation">
   <a href="https://drafts.csswg.org/css-values-4/#interpolation">https://drafts.csswg.org/css-values-4/#interpolation</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-interpolation">2.3. The transition-timing-function Property</a>
    <li><a href="#ref-for-interpolation①">4. Application of transitions</a> <a href="#ref-for-interpolation②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-comb-one">
   <a href="https://drafts.csswg.org/css-values-4/#comb-one">https://drafts.csswg.org/css-values-4/#comb-one</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-comb-one">2.1. The transition-property Property</a> <a href="#ref-for-comb-one①">(2)</a>
    <li><a href="#ref-for-comb-one②">2.5. The transition Shorthand Property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-comb-any">
   <a href="https://drafts.csswg.org/css-values-4/#comb-any">https://drafts.csswg.org/css-values-4/#comb-any</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-comb-any">2.5. The transition Shorthand Property</a> <a href="#ref-for-comb-any①">(2)</a> <a href="#ref-for-comb-any②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-background-color">
   <a href="https://drafts.csswg.org/css2/colors.html#propdef-background-color">https://drafts.csswg.org/css2/colors.html#propdef-background-color</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-background-color">2. Transitions</a> <a href="#ref-for-propdef-background-color①">(2)</a>
    <li><a href="#ref-for-propdef-background-color②">3. Starting of transitions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-left">
   <a href="https://drafts.csswg.org/css2/visuren.html#propdef-left">https://drafts.csswg.org/css2/visuren.html#propdef-left</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-left">2. Transitions</a> <a href="#ref-for-propdef-left①">(2)</a> <a href="#ref-for-propdef-left②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-top">
   <a href="https://drafts.csswg.org/css2/visuren.html#propdef-top">https://drafts.csswg.org/css2/visuren.html#propdef-top</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-top">2. Transitions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-width">
   <a href="https://drafts.csswg.org/css2/visudet.html#propdef-width">https://drafts.csswg.org/css2/visudet.html#propdef-width</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-width">2. Transitions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-animationevent-elapsedtime">
   <a href="https://drafts.csswg.org/css-animations-1/#dom-animationevent-elapsedtime">https://drafts.csswg.org/css-animations-1/#dom-animationevent-elapsedtime</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-animationevent-elapsedtime">6.2. Types of TransitionEvent</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssomstring">
   <a href="https://drafts.csswg.org/cssom-1/#cssomstring">https://drafts.csswg.org/cssom-1/#cssomstring</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssomstring">6.1.1. IDL Definition</a> <a href="#ref-for-cssomstring①">(2)</a> <a href="#ref-for-cssomstring②">(3)</a> <a href="#ref-for-cssomstring③">(4)</a> <a href="#ref-for-cssomstring④">(5)</a>
    <li><a href="#ref-for-cssomstring⑤">6.1.2. Attributes</a> <a href="#ref-for-cssomstring⑥">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event">
   <a href="https://dom.spec.whatwg.org/#event">https://dom.spec.whatwg.org/#event</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event">6.1.1. IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dictdef-eventinit">
   <a href="https://dom.spec.whatwg.org/#dictdef-eventinit">https://dom.spec.whatwg.org/#dictdef-eventinit</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-eventinit">6.1.1. IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-document">
   <a href="https://html.spec.whatwg.org/#document">https://html.spec.whatwg.org/#document</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-document">6.3. Event handlers on elements, Document objects, and Window objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-eventhandler">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler">https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventhandler">7.1. IDL Definition</a> <a href="#ref-for-eventhandler①">(2)</a> <a href="#ref-for-eventhandler②">(3)</a> <a href="#ref-for-eventhandler③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-globaleventhandlers">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#globaleventhandlers">https://html.spec.whatwg.org/multipage/webappapis.html#globaleventhandlers</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-globaleventhandlers">7. DOM Interfaces</a>
    <li><a href="#ref-for-globaleventhandlers①">7.1. IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-window">
   <a href="https://html.spec.whatwg.org/multipage/window-object.html#window">https://html.spec.whatwg.org/multipage/window-object.html#window</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-window">6.3. Event handlers on elements, Document objects, and Window objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-event-dispatch">
   <a href="https://html.spec.whatwg.org/multipage/infrastructure.html#concept-event-dispatch">https://html.spec.whatwg.org/multipage/infrastructure.html#concept-event-dispatch</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-event-dispatch">6. Transition Events</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event-handler-content-attributes">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-content-attributes">https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-content-attributes</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event-handler-content-attributes">6.3. Event handlers on elements, Document objects, and Window objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event-handler-event-type">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-event-type">https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-event-type</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event-handler-event-type">6.3. Event handlers on elements, Document objects, and Window objects</a> <a href="#ref-for-event-handler-event-type①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event-handler-idl-attributes">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-idl-attributes">https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-idl-attributes</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event-handler-idl-attributes">6.3. Event handlers on elements, Document objects, and Window objects</a> <a href="#ref-for-event-handler-idl-attributes①">(2)</a>
    <li><a href="#ref-for-event-handler-idl-attributes②">7. DOM Interfaces</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event-handlers">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handlers">https://html.spec.whatwg.org/multipage/webappapis.html#event-handlers</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event-handlers">6.3. Event handlers on elements, Document objects, and Window objects</a> <a href="#ref-for-event-handlers①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-html-elements">
   <a href="https://html.spec.whatwg.org/multipage/infrastructure.html#html-elements">https://html.spec.whatwg.org/multipage/infrastructure.html#html-elements</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-html-elements">6.3. Event handlers on elements, Document objects, and Window objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-animation-type">
   <a href="https://drafts.csswg.org/web-animations-1/#animation-type">https://drafts.csswg.org/web-animations-1/#animation-type</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-animation-type">3. Starting of transitions</a> <a href="#ref-for-animation-type①">(2)</a> <a href="#ref-for-animation-type②">(3)</a> <a href="#ref-for-animation-type③">(4)</a>
    <li><a href="#ref-for-animation-type④">4. Application of transitions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-combining-shadow-lists">
   <a href="https://drafts.csswg.org/web-animations-1/#combining-shadow-lists">https://drafts.csswg.org/web-animations-1/#combining-shadow-lists</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-combining-shadow-lists">3. Starting of transitions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-discrete">
   <a href="https://drafts.csswg.org/web-animations-1/#discrete">https://drafts.csswg.org/web-animations-1/#discrete</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-discrete">3. Starting of transitions</a> <a href="#ref-for-discrete①">(2)</a> <a href="#ref-for-discrete②">(3)</a> <a href="#ref-for-discrete③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-not-animatable">
   <a href="https://drafts.csswg.org/web-animations-1/#not-animatable">https://drafts.csswg.org/web-animations-1/#not-animatable</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-not-animatable">3. Starting of transitions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-Exposed">
   <a href="https://heycam.github.io/webidl/#Exposed">https://heycam.github.io/webidl/#Exposed</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Exposed">6.1.1. IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-double">
   <a href="https://heycam.github.io/webidl/#idl-double">https://heycam.github.io/webidl/#idl-double</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-double">6.1.1. IDL Definition</a> <a href="#ref-for-idl-double①">(2)</a>
    <li><a href="#ref-for-idl-double②">6.1.2. Attributes</a>
   </ul>
  </aside>
  <h3 class="no-num no-ref heading settled" id="index-defined-elsewhere"><span class="content">Terms defined by reference</span><a class="self-link" href="#index-defined-elsewhere"></a></h3>
  <ul class="index">
   <li>
    <a data-link-type="biblio">[css-backgrounds-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-background-image" style="color:initial">background-image</span>
     <li><span class="dfn-paneled" id="term-for-propdef-box-shadow" style="color:initial">box-shadow</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-cascade-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-all" style="color:initial">all</span>
     <li><span class="dfn-paneled" id="term-for-cascade" style="color:initial">cascade</span>
     <li><span class="dfn-paneled" id="term-for-computed-value" style="color:initial">computed value</span>
     <li><span class="dfn-paneled" id="term-for-valdef-all-inherit" style="color:initial">inherit</span>
     <li><span class="dfn-paneled" id="term-for-valdef-all-initial" style="color:initial">initial</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-color-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-opacity" style="color:initial">opacity</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-easing-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-typedef-easing-function" style="color:initial">&lt;easing-function></span>
     <li><span class="dfn-paneled" id="term-for-input-progress-value" style="color:initial">input progress value</span>
     <li><span class="dfn-paneled" id="term-for-output-progress-value" style="color:initial">output progress value</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-transforms-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-transform" style="color:initial">transform</span>
    </ul>
   <li>
    <a data-link-type="biblio">[CSS-VALUES-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-time-value" style="color:initial">&lt;time></span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-values-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-mult-comma" style="color:initial">#</span>
     <li><span class="dfn-paneled" id="term-for-identifier-value" style="color:initial">&lt;custom-ident></span>
     <li><span class="dfn-paneled" id="term-for-css-wide-keywords" style="color:initial">css-wide keywords</span>
     <li><span class="dfn-paneled" id="term-for-interpolation" style="color:initial">interpolate</span>
     <li><span class="dfn-paneled" id="term-for-interpolation①" style="color:initial">interpolation</span>
     <li><span class="dfn-paneled" id="term-for-comb-one" style="color:initial">|</span>
     <li><span class="dfn-paneled" id="term-for-comb-any" style="color:initial">||</span>
    </ul>
   <li>
    <a data-link-type="biblio">[CSS2]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-background-color" style="color:initial">background-color</span>
     <li><span class="dfn-paneled" id="term-for-propdef-left" style="color:initial">left</span>
     <li><span class="dfn-paneled" id="term-for-propdef-top" style="color:initial">top</span>
     <li><span class="dfn-paneled" id="term-for-propdef-width" style="color:initial">width</span>
    </ul>
   <li>
    <a data-link-type="biblio">[CSS3-ANIMATIONS]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-dom-animationevent-elapsedtime" style="color:initial">elapsedTime</span>
    </ul>
   <li>
    <a data-link-type="biblio">[cssom-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-cssomstring" style="color:initial">CSSOMString</span>
    </ul>
   <li>
    <a data-link-type="biblio">[DOM]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-event" style="color:initial">Event</span>
     <li><span class="dfn-paneled" id="term-for-dictdef-eventinit" style="color:initial">EventInit</span>
    </ul>
   <li>
    <a data-link-type="biblio">[HTML]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-document" style="color:initial">Document</span>
     <li><span class="dfn-paneled" id="term-for-eventhandler" style="color:initial">EventHandler</span>
     <li><span class="dfn-paneled" id="term-for-globaleventhandlers" style="color:initial">GlobalEventHandlers</span>
     <li><span class="dfn-paneled" id="term-for-window" style="color:initial">Window</span>
     <li><span class="dfn-paneled" id="term-for-concept-event-dispatch" style="color:initial">dispatch</span>
     <li><span class="dfn-paneled" id="term-for-event-handler-content-attributes" style="color:initial">event handler content attributes</span>
     <li><span class="dfn-paneled" id="term-for-event-handler-event-type" style="color:initial">event handler event type</span>
     <li><span class="dfn-paneled" id="term-for-event-handler-idl-attributes" style="color:initial">event handler idl attributes</span>
     <li><span class="dfn-paneled" id="term-for-event-handlers" style="color:initial">event handlers</span>
     <li><span class="dfn-paneled" id="term-for-html-elements" style="color:initial">html elements</span>
    </ul>
   <li>
    <a data-link-type="biblio">[web-animations-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-animation-type" style="color:initial">animation type</span>
     <li><span class="dfn-paneled" id="term-for-combining-shadow-lists" style="color:initial">combining shadow lists</span>
     <li><span class="dfn-paneled" id="term-for-discrete" style="color:initial">discrete</span>
     <li><span class="dfn-paneled" id="term-for-not-animatable" style="color:initial">not animatable</span>
    </ul>
   <li>
    <a data-link-type="biblio">[WebIDL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-Exposed" style="color:initial">Exposed</span>
     <li><span class="dfn-paneled" id="term-for-idl-double" style="color:initial">double</span>
    </ul>
  </ul>
  <h2 class="no-num no-ref heading settled" id="references"><span class="content">References</span><a class="self-link" href="#references"></a></h2>
  <h3 class="no-num no-ref heading settled" id="normative"><span class="content">Normative References</span><a class="self-link" href="#normative"></a></h3>
  <dl>
   <dt id="biblio-css-cascade-4">[CSS-CASCADE-4]
   <dd>Elika Etemad; Tab Atkins Jr.. <a href="https://www.w3.org/TR/css-cascade-4/">CSS Cascading and Inheritance Level 4</a>. 28 August 2018. CR. URL: <a href="https://www.w3.org/TR/css-cascade-4/">https://www.w3.org/TR/css-cascade-4/</a>
   <dt id="biblio-css-color-3">[CSS-COLOR-3]
   <dd>Tantek Çelik; Chris Lilley; David Baron. <a href="https://www.w3.org/TR/css-color-3/">CSS Color Module Level 3</a>. 19 June 2018. REC. URL: <a href="https://www.w3.org/TR/css-color-3/">https://www.w3.org/TR/css-color-3/</a>
   <dt id="biblio-css-easing-1">[CSS-EASING-1]
   <dd>Brian Birtles; Dean Jackson; Matt Rakow. <a href="https://www.w3.org/TR/css-easing-1/">CSS Easing Functions Level 1</a>. 30 April 2019. CR. URL: <a href="https://www.w3.org/TR/css-easing-1/">https://www.w3.org/TR/css-easing-1/</a>
   <dt id="biblio-css-transforms-1">[CSS-TRANSFORMS-1]
   <dd>Simon Fraser; et al. <a href="https://www.w3.org/TR/css-transforms-1/">CSS Transforms Module Level 1</a>. 14 February 2019. CR. URL: <a href="https://www.w3.org/TR/css-transforms-1/">https://www.w3.org/TR/css-transforms-1/</a>
   <dt id="biblio-css-values-3">[CSS-VALUES-3]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-values-3/">CSS Values and Units Module Level 3</a>. 6 June 2019. CR. URL: <a href="https://www.w3.org/TR/css-values-3/">https://www.w3.org/TR/css-values-3/</a>
   <dt id="biblio-css-values-4">[CSS-VALUES-4]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-values-4/">CSS Values and Units Module Level 4</a>. 31 January 2019. WD. URL: <a href="https://www.w3.org/TR/css-values-4/">https://www.w3.org/TR/css-values-4/</a>
   <dt id="biblio-css2">[CSS2]
   <dd>Bert Bos; et al. <a href="https://www.w3.org/TR/CSS2/">Cascading Style Sheets Level 2 Revision 1 (CSS 2.1) Specification</a>. 7 June 2011. REC. URL: <a href="https://www.w3.org/TR/CSS2/">https://www.w3.org/TR/CSS2/</a>
   <dt id="biblio-css3-animations">[CSS3-ANIMATIONS]
   <dd>Dean Jackson; et al. <a href="https://www.w3.org/TR/css-animations-1/">CSS Animations Level 1</a>. 11 October 2018. WD. URL: <a href="https://www.w3.org/TR/css-animations-1/">https://www.w3.org/TR/css-animations-1/</a>
   <dt id="biblio-css3cascade">[CSS3CASCADE]
   <dd>Elika Etemad; Tab Atkins Jr.. <a href="https://www.w3.org/TR/css-cascade-3/">CSS Cascading and Inheritance Level 3</a>. 28 August 2018. CR. URL: <a href="https://www.w3.org/TR/css-cascade-3/">https://www.w3.org/TR/css-cascade-3/</a>
   <dt id="biblio-cssom-1">[CSSOM-1]
   <dd>Simon Pieters; Glenn Adams. <a href="https://www.w3.org/TR/cssom-1/">CSS Object Model (CSSOM)</a>. 17 March 2016. WD. URL: <a href="https://www.w3.org/TR/cssom-1/">https://www.w3.org/TR/cssom-1/</a>
   <dt id="biblio-dom">[DOM]
   <dd>Anne van Kesteren. <a href="https://dom.spec.whatwg.org/">DOM Standard</a>. Living Standard. URL: <a href="https://dom.spec.whatwg.org/">https://dom.spec.whatwg.org/</a>
   <dt id="biblio-html">[HTML]
   <dd>Anne van Kesteren; et al. <a href="https://html.spec.whatwg.org/multipage/">HTML Standard</a>. Living Standard. URL: <a href="https://html.spec.whatwg.org/multipage/">https://html.spec.whatwg.org/multipage/</a>
   <dt id="biblio-rfc2119">[RFC2119]
   <dd>S. Bradner. <a href="https://tools.ietf.org/html/rfc2119">Key words for use in RFCs to Indicate Requirement Levels</a>. March 1997. Best Current Practice. URL: <a href="https://tools.ietf.org/html/rfc2119">https://tools.ietf.org/html/rfc2119</a>
   <dt id="biblio-web-animations-1">[WEB-ANIMATIONS-1]
   <dd>Brian Birtles; et al. <a href="https://www.w3.org/TR/web-animations-1/">Web Animations</a>. 11 October 2018. WD. URL: <a href="https://www.w3.org/TR/web-animations-1/">https://www.w3.org/TR/web-animations-1/</a>
   <dt id="biblio-webidl">[WebIDL]
   <dd>Boris Zbarsky. <a href="https://heycam.github.io/webidl/">Web IDL</a>. 15 December 2016. ED. URL: <a href="https://heycam.github.io/webidl/">https://heycam.github.io/webidl/</a>
  </dl>
  <h3 class="no-num no-ref heading settled" id="informative"><span class="content">Informative References</span><a class="self-link" href="#informative"></a></h3>
  <dl>
   <dt id="biblio-css-backgrounds-3">[CSS-BACKGROUNDS-3]
   <dd>Bert Bos; Elika Etemad; Brad Kemper. <a href="https://www.w3.org/TR/css-backgrounds-3/">CSS Backgrounds and Borders Module Level 3</a>. 17 October 2017. CR. URL: <a href="https://www.w3.org/TR/css-backgrounds-3/">https://www.w3.org/TR/css-backgrounds-3/</a>
   <dt id="biblio-smil-animation">[SMIL-ANIMATION]
   <dd>Patrick Schmitz; Aaron Cohen. <a href="https://www.w3.org/TR/smil-animation/">SMIL Animation</a>. 4 September 2001. REC. URL: <a href="https://www.w3.org/TR/smil-animation/">https://www.w3.org/TR/smil-animation/</a>
   <dt id="biblio-svg11">[SVG11]
   <dd>Erik Dahlström; et al. <a href="https://www.w3.org/TR/SVG11/">Scalable Vector Graphics (SVG) 1.1 (Second Edition)</a>. 16 August 2011. REC. URL: <a href="https://www.w3.org/TR/SVG11/">https://www.w3.org/TR/SVG11/</a>
   <dt id="biblio-wcag20">[WCAG20]
   <dd>Ben Caldwell; et al. <a href="https://www.w3.org/TR/WCAG20/">Web Content Accessibility Guidelines (WCAG) 2.0</a>. 11 December 2008. REC. URL: <a href="https://www.w3.org/TR/WCAG20/">https://www.w3.org/TR/WCAG20/</a>
  </dl>
  <h2 class="no-num no-ref heading settled" id="property-index"><span class="content">Property Index</span><a class="self-link" href="#property-index"></a></h2>
  <div class="big-element-wrapper">
   <table class="index">
    <thead>
     <tr>
      <th scope="col">Name
      <th scope="col">Value
      <th scope="col">Initial
      <th scope="col">Applies to
      <th scope="col">Inh.
      <th scope="col">%ages
      <th scope="col">Ani­mat­able
      <th scope="col">Anim­ation type
      <th scope="col">Canonical order
      <th scope="col">Com­puted value
    <tbody>
     <tr>
      <th scope="row"><a class="css" data-link-type="property" href="#propdef-transition" id="ref-for-propdef-transition④">transition</a>
      <td>&lt;single-transition>#
      <td>see individual properties
      <td>all elements
      <td>no
      <td>N/A
      <td>no
      <td>not animatable
      <td>per grammar
      <td>see individual properties
     <tr>
      <th scope="row"><a class="css" data-link-type="property" href="#propdef-transition-delay" id="ref-for-propdef-transition-delay①⑤">transition-delay</a>
      <td>&lt;time>#
      <td>0s
      <td>all elements
      <td>no
      <td>N/A
      <td>
      <td>not animatable
      <td>per grammar
      <td>list, each item a duration
     <tr>
      <th scope="row"><a class="css" data-link-type="property" href="#propdef-transition-duration" id="ref-for-propdef-transition-duration①②">transition-duration</a>
      <td>&lt;time>#
      <td>0s
      <td>all elements
      <td>no
      <td>N/A
      <td>
      <td>not animatable
      <td>per grammar
      <td>list, each item a duration
     <tr>
      <th scope="row"><a class="css" data-link-type="property" href="#propdef-transition-property" id="ref-for-propdef-transition-property①②">transition-property</a>
      <td>none | &lt;single-transition-property>#
      <td>all
      <td>all elements
      <td>no
      <td>N/A
      <td>
      <td>not animatable
      <td>per grammar
      <td>the keyword none else a list of identifiers
     <tr>
      <th scope="row"><a class="css" data-link-type="property" href="#propdef-transition-timing-function" id="ref-for-propdef-transition-timing-function⑦">transition-timing-function</a>
      <td>&lt;easing-function>#
      <td>ease
      <td>all elements
      <td>no
      <td>N/A
      <td>
      <td>not animatable
      <td>per grammar
      <td>as specified
   </table>
  </div>
  <h2 class="no-num no-ref heading settled" id="idl-index"><span class="content">IDL Index</span><a class="self-link" href="#idl-index"></a></h2>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#transitionevent"><code><c- g>TransitionEvent</c-></code></a> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#event"><c- n>Event</c-></a> {
  <a class="idl-code" data-link-type="constructor" href="#dom-transitionevent-transitionevent"><c- g>constructor</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-transitionevent-transitionevent-type-transitioneventinitdict-type"><code><c- g>type</c-></code></a>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-transitioneventinit"><c- n>TransitionEventInit</c-></a> <a href="#dom-transitionevent-transitionevent-type-transitioneventinitdict-transitioneventinitdict"><code><c- g>transitionEventInitDict</c-></code></a> = {});
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#Events-TransitionEvent-propertyName"><c- g>propertyName</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#Events-TransitionEvent-elapsedTime"><c- g>elapsedTime</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#Events-TransitionEvent-pseudoElement"><c- g>pseudoElement</c-></a>;
};

<c- b>dictionary</c-> <a href="#dictdef-transitioneventinit"><code><c- g>TransitionEventInit</c-></code></a> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#dictdef-eventinit"><c- n>EventInit</c-></a> {
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a data-default="&quot;&quot;" data-type="CSSOMString " href="#dom-transitioneventinit-propertyname"><code><c- g>propertyName</c-></code></a> = "";
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a data-default="0.0" data-type="double " href="#dom-transitioneventinit-elapsedtime"><code><c- g>elapsedTime</c-></code></a> = 0.0;
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a data-default="&quot;&quot;" data-type="CSSOMString " href="#dom-transitioneventinit-pseudoelement"><code><c- g>pseudoElement</c-></code></a> = "";
};

<c- b>partial</c-> <c- b>interface</c-> <c- b>mixin</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/webappapis.html#globaleventhandlers"><c- g>GlobalEventHandlers</c-></a> {
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler"><c- n>EventHandler</c-></a> <a data-type="EventHandler" href="#dom-globaleventhandlers-ontransitionrun"><code><c- g>ontransitionrun</c-></code></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler"><c- n>EventHandler</c-></a> <a data-type="EventHandler" href="#dom-globaleventhandlers-ontransitionstart"><code><c- g>ontransitionstart</c-></code></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler"><c- n>EventHandler</c-></a> <a data-type="EventHandler" href="#dom-globaleventhandlers-ontransitionend"><code><c- g>ontransitionend</c-></code></a>;
  <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler"><c- n>EventHandler</c-></a> <a data-type="EventHandler" href="#dom-globaleventhandlers-ontransitioncancel"><code><c- g>ontransitioncancel</c-></code></a>;
};

</pre>
  <aside class="dfn-panel" data-for="propdef-transition-property">
   <b><a href="#propdef-transition-property">#propdef-transition-property</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-transition-property">2. Transitions</a> <a href="#ref-for-propdef-transition-property①">(2)</a> <a href="#ref-for-propdef-transition-property②">(3)</a>
    <li><a href="#ref-for-propdef-transition-property③">2.1. The transition-property Property</a> <a href="#ref-for-propdef-transition-property④">(2)</a> <a href="#ref-for-propdef-transition-property⑤">(3)</a> <a href="#ref-for-propdef-transition-property⑥">(4)</a>
    <li><a href="#ref-for-propdef-transition-property⑦">3. Starting of transitions</a> <a href="#ref-for-propdef-transition-property⑧">(2)</a> <a href="#ref-for-propdef-transition-property⑨">(3)</a>
    <li><a href="#ref-for-propdef-transition-property①⓪">6.1.2. Attributes</a>
    <li><a href="#ref-for-propdef-transition-property①①">6.2. Types of TransitionEvent</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="single-transition-property">
   <b><a href="#single-transition-property">#single-transition-property</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-single-transition-property">2.1. The transition-property Property</a> <a href="#ref-for-single-transition-property①">(2)</a>
    <li><a href="#ref-for-single-transition-property②">2.5. The transition Shorthand Property</a> <a href="#ref-for-single-transition-property③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-transition-property-none">
   <b><a href="#valdef-transition-property-none">#valdef-transition-property-none</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-transition-property-none">2.1. The transition-property Property</a> <a href="#ref-for-valdef-transition-property-none①">(2)</a> <a href="#ref-for-valdef-transition-property-none②">(3)</a>
    <li><a href="#ref-for-valdef-transition-property-none③">2.5. The transition Shorthand Property</a> <a href="#ref-for-valdef-transition-property-none④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-transition-property-all">
   <b><a href="#valdef-transition-property-all">#valdef-transition-property-all</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-transition-property-all">2.1. The transition-property Property</a> <a href="#ref-for-valdef-transition-property-all①">(2)</a> <a href="#ref-for-valdef-transition-property-all②">(3)</a> <a href="#ref-for-valdef-transition-property-all③">(4)</a> <a href="#ref-for-valdef-transition-property-all④">(5)</a> <a href="#ref-for-valdef-transition-property-all⑤">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="propdef-transition-duration">
   <b><a href="#propdef-transition-duration">#propdef-transition-duration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-transition-duration">2.1. The transition-property Property</a>
    <li><a href="#ref-for-propdef-transition-duration①">2.2. The transition-duration Property</a> <a href="#ref-for-propdef-transition-duration②">(2)</a> <a href="#ref-for-propdef-transition-duration③">(3)</a>
    <li><a href="#ref-for-propdef-transition-duration④">3. Starting of transitions</a> <a href="#ref-for-propdef-transition-duration⑤">(2)</a> <a href="#ref-for-propdef-transition-duration⑥">(3)</a> <a href="#ref-for-propdef-transition-duration⑦">(4)</a> <a href="#ref-for-propdef-transition-duration⑧">(5)</a>
    <li><a href="#ref-for-propdef-transition-duration⑨">6.2. Types of TransitionEvent</a> <a href="#ref-for-propdef-transition-duration①⓪">(2)</a> <a href="#ref-for-propdef-transition-duration①①">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="propdef-transition-timing-function">
   <b><a href="#propdef-transition-timing-function">#propdef-transition-timing-function</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-transition-timing-function">2.1. The transition-property Property</a>
    <li><a href="#ref-for-propdef-transition-timing-function①">2.3. The transition-timing-function Property</a> <a href="#ref-for-propdef-transition-timing-function②">(2)</a>
    <li><a href="#ref-for-propdef-transition-timing-function③">3. Starting of transitions</a> <a href="#ref-for-propdef-transition-timing-function④">(2)</a> <a href="#ref-for-propdef-transition-timing-function⑤">(3)</a> <a href="#ref-for-propdef-transition-timing-function⑥">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="propdef-transition-delay">
   <b><a href="#propdef-transition-delay">#propdef-transition-delay</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-transition-delay">2.1. The transition-property Property</a>
    <li><a href="#ref-for-propdef-transition-delay①">2.4. The transition-delay Property</a> <a href="#ref-for-propdef-transition-delay②">(2)</a> <a href="#ref-for-propdef-transition-delay③">(3)</a> <a href="#ref-for-propdef-transition-delay④">(4)</a> <a href="#ref-for-propdef-transition-delay⑤">(5)</a>
    <li><a href="#ref-for-propdef-transition-delay⑥">3. Starting of transitions</a> <a href="#ref-for-propdef-transition-delay⑦">(2)</a> <a href="#ref-for-propdef-transition-delay⑧">(3)</a> <a href="#ref-for-propdef-transition-delay⑨">(4)</a>
    <li><a href="#ref-for-propdef-transition-delay①⓪">6.2. Types of TransitionEvent</a> <a href="#ref-for-propdef-transition-delay①①">(2)</a> <a href="#ref-for-propdef-transition-delay①②">(3)</a> <a href="#ref-for-propdef-transition-delay①③">(4)</a> <a href="#ref-for-propdef-transition-delay①④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="propdef-transition">
   <b><a href="#propdef-transition">#propdef-transition</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-transition">2.5. The transition Shorthand Property</a> <a href="#ref-for-propdef-transition①">(2)</a>
    <li><a href="#ref-for-propdef-transition②">3. Starting of transitions</a> <a href="#ref-for-propdef-transition③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="single-transition">
   <b><a href="#single-transition">#single-transition</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-single-transition">2.5. The transition Shorthand Property</a> <a href="#ref-for-single-transition①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="running-transition">
   <b><a href="#running-transition">#running-transition</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-running-transition">3. Starting of transitions</a> <a href="#ref-for-running-transition①">(2)</a> <a href="#ref-for-running-transition②">(3)</a> <a href="#ref-for-running-transition③">(4)</a> <a href="#ref-for-running-transition④">(5)</a> <a href="#ref-for-running-transition⑤">(6)</a> <a href="#ref-for-running-transition⑥">(7)</a> <a href="#ref-for-running-transition⑦">(8)</a> <a href="#ref-for-running-transition⑧">(9)</a> <a href="#ref-for-running-transition⑨">(10)</a> <a href="#ref-for-running-transition①⓪">(11)</a> <a href="#ref-for-running-transition①①">(12)</a> <a href="#ref-for-running-transition①②">(13)</a> <a href="#ref-for-running-transition①③">(14)</a> <a href="#ref-for-running-transition①④">(15)</a> <a href="#ref-for-running-transition①⑤">(16)</a> <a href="#ref-for-running-transition①⑥">(17)</a> <a href="#ref-for-running-transition①⑦">(18)</a>
    <li><a href="#ref-for-running-transition①⑧">5. Completion of transitions</a> <a href="#ref-for-running-transition①⑨">(2)</a> <a href="#ref-for-running-transition②⓪">(3)</a>
    <li><a href="#ref-for-running-transition②①">6.2. Types of TransitionEvent</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="transition-start-time">
   <b><a href="#transition-start-time">#transition-start-time</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-transition-start-time">3. Starting of transitions</a> <a href="#ref-for-transition-start-time①">(2)</a> <a href="#ref-for-transition-start-time②">(3)</a> <a href="#ref-for-transition-start-time③">(4)</a> <a href="#ref-for-transition-start-time④">(5)</a> <a href="#ref-for-transition-start-time⑤">(6)</a>
    <li><a href="#ref-for-transition-start-time⑥">4. Application of transitions</a> <a href="#ref-for-transition-start-time⑦">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="transition-end-time">
   <b><a href="#transition-end-time">#transition-end-time</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-transition-end-time">3. Starting of transitions</a> <a href="#ref-for-transition-end-time①">(2)</a> <a href="#ref-for-transition-end-time②">(3)</a>
    <li><a href="#ref-for-transition-end-time③">4. Application of transitions</a>
    <li><a href="#ref-for-transition-end-time④">5. Completion of transitions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="transition-start-value">
   <b><a href="#transition-start-value">#transition-start-value</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-transition-start-value">3. Starting of transitions</a> <a href="#ref-for-transition-start-value①">(2)</a> <a href="#ref-for-transition-start-value②">(3)</a> <a href="#ref-for-transition-start-value③">(4)</a> <a href="#ref-for-transition-start-value④">(5)</a>
    <li><a href="#ref-for-transition-start-value⑤">4. Application of transitions</a> <a href="#ref-for-transition-start-value⑥">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="transition-end-value">
   <b><a href="#transition-end-value">#transition-end-value</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-transition-end-value">3. Starting of transitions</a> <a href="#ref-for-transition-end-value①">(2)</a> <a href="#ref-for-transition-end-value②">(3)</a> <a href="#ref-for-transition-end-value③">(4)</a> <a href="#ref-for-transition-end-value④">(5)</a> <a href="#ref-for-transition-end-value⑤">(6)</a> <a href="#ref-for-transition-end-value⑥">(7)</a> <a href="#ref-for-transition-end-value⑦">(8)</a>
    <li><a href="#ref-for-transition-end-value⑧">4. Application of transitions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="transition-reversing-adjusted-start-value">
   <b><a href="#transition-reversing-adjusted-start-value">#transition-reversing-adjusted-start-value</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-transition-reversing-adjusted-start-value">3. Starting of transitions</a> <a href="#ref-for-transition-reversing-adjusted-start-value①">(2)</a> <a href="#ref-for-transition-reversing-adjusted-start-value②">(3)</a> <a href="#ref-for-transition-reversing-adjusted-start-value③">(4)</a> <a href="#ref-for-transition-reversing-adjusted-start-value④">(5)</a> <a href="#ref-for-transition-reversing-adjusted-start-value⑤">(6)</a>
    <li><a href="#ref-for-transition-reversing-adjusted-start-value⑥">3.1. Faster reversing of interrupted transitions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="transition-reversing-shortening-factor">
   <b><a href="#transition-reversing-shortening-factor">#transition-reversing-shortening-factor</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-transition-reversing-shortening-factor">3. Starting of transitions</a> <a href="#ref-for-transition-reversing-shortening-factor①">(2)</a> <a href="#ref-for-transition-reversing-shortening-factor②">(3)</a> <a href="#ref-for-transition-reversing-shortening-factor③">(4)</a> <a href="#ref-for-transition-reversing-shortening-factor④">(5)</a> <a href="#ref-for-transition-reversing-shortening-factor⑤">(6)</a> <a href="#ref-for-transition-reversing-shortening-factor⑥">(7)</a> <a href="#ref-for-transition-reversing-shortening-factor⑦">(8)</a>
    <li><a href="#ref-for-transition-reversing-shortening-factor⑧">3.1. Faster reversing of interrupted transitions</a> <a href="#ref-for-transition-reversing-shortening-factor⑨">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="transition-cancel">
   <b><a href="#transition-cancel">#transition-cancel</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-transition-cancel">3. Starting of transitions</a> <a href="#ref-for-transition-cancel①">(2)</a> <a href="#ref-for-transition-cancel②">(3)</a> <a href="#ref-for-transition-cancel③">(4)</a> <a href="#ref-for-transition-cancel④">(5)</a> <a href="#ref-for-transition-cancel⑤">(6)</a>
    <li><a href="#ref-for-transition-cancel⑥">6.2. Types of TransitionEvent</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="completed-transition">
   <b><a href="#completed-transition">#completed-transition</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-completed-transition">3. Starting of transitions</a> <a href="#ref-for-completed-transition①">(2)</a> <a href="#ref-for-completed-transition②">(3)</a> <a href="#ref-for-completed-transition③">(4)</a> <a href="#ref-for-completed-transition④">(5)</a> <a href="#ref-for-completed-transition⑤">(6)</a> <a href="#ref-for-completed-transition⑥">(7)</a> <a href="#ref-for-completed-transition⑦">(8)</a> <a href="#ref-for-completed-transition⑧">(9)</a> <a href="#ref-for-completed-transition⑨">(10)</a> <a href="#ref-for-completed-transition①⓪">(11)</a> <a href="#ref-for-completed-transition①①">(12)</a>
    <li><a href="#ref-for-completed-transition①②">5. Completion of transitions</a> <a href="#ref-for-completed-transition①③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="style-change-event">
   <b><a href="#style-change-event">#style-change-event</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-style-change-event">3. Starting of transitions</a> <a href="#ref-for-style-change-event①">(2)</a> <a href="#ref-for-style-change-event②">(3)</a> <a href="#ref-for-style-change-event③">(4)</a> <a href="#ref-for-style-change-event④">(5)</a> <a href="#ref-for-style-change-event⑤">(6)</a> <a href="#ref-for-style-change-event⑥">(7)</a> <a href="#ref-for-style-change-event⑦">(8)</a> <a href="#ref-for-style-change-event⑧">(9)</a>
    <li><a href="#ref-for-style-change-event⑨">5. Completion of transitions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="before-change-style">
   <b><a href="#before-change-style">#before-change-style</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-before-change-style">3. Starting of transitions</a> <a href="#ref-for-before-change-style①">(2)</a> <a href="#ref-for-before-change-style②">(3)</a> <a href="#ref-for-before-change-style③">(4)</a> <a href="#ref-for-before-change-style④">(5)</a> <a href="#ref-for-before-change-style⑤">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="after-change-style">
   <b><a href="#after-change-style">#after-change-style</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-after-change-style">3. Starting of transitions</a> <a href="#ref-for-after-change-style①">(2)</a> <a href="#ref-for-after-change-style②">(3)</a> <a href="#ref-for-after-change-style③">(4)</a> <a href="#ref-for-after-change-style④">(5)</a> <a href="#ref-for-after-change-style⑤">(6)</a> <a href="#ref-for-after-change-style⑥">(7)</a> <a href="#ref-for-after-change-style⑦">(8)</a> <a href="#ref-for-after-change-style⑧">(9)</a> <a href="#ref-for-after-change-style⑨">(10)</a> <a href="#ref-for-after-change-style①⓪">(11)</a> <a href="#ref-for-after-change-style①①">(12)</a> <a href="#ref-for-after-change-style①②">(13)</a> <a href="#ref-for-after-change-style①③">(14)</a> <a href="#ref-for-after-change-style①④">(15)</a> <a href="#ref-for-after-change-style①⑤">(16)</a> <a href="#ref-for-after-change-style①⑥">(17)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="matching-transition-property-value">
   <b><a href="#matching-transition-property-value">#matching-transition-property-value</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-matching-transition-property-value">3. Starting of transitions</a> <a href="#ref-for-matching-transition-property-value①">(2)</a> <a href="#ref-for-matching-transition-property-value②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="matching-transition-duration">
   <b><a href="#matching-transition-duration">#matching-transition-duration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-matching-transition-duration">3. Starting of transitions</a> <a href="#ref-for-matching-transition-duration①">(2)</a> <a href="#ref-for-matching-transition-duration②">(3)</a> <a href="#ref-for-matching-transition-duration③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="matching-transition-delay">
   <b><a href="#matching-transition-delay">#matching-transition-delay</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-matching-transition-delay">3. Starting of transitions</a> <a href="#ref-for-matching-transition-delay①">(2)</a> <a href="#ref-for-matching-transition-delay②">(3)</a> <a href="#ref-for-matching-transition-delay③">(4)</a> <a href="#ref-for-matching-transition-delay④">(5)</a> <a href="#ref-for-matching-transition-delay⑤">(6)</a> <a href="#ref-for-matching-transition-delay⑥">(7)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="transition-combined-duration">
   <b><a href="#transition-combined-duration">#transition-combined-duration</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-transition-combined-duration">3. Starting of transitions</a> <a href="#ref-for-transition-combined-duration①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="transitionable">
   <b><a href="#transitionable">#transitionable</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-transitionable">3. Starting of transitions</a> <a href="#ref-for-transitionable①">(2)</a> <a href="#ref-for-transitionable②">(3)</a> <a href="#ref-for-transitionable③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="current-value">
   <b><a href="#current-value">#current-value</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-current-value">3. Starting of transitions</a> <a href="#ref-for-current-value①">(2)</a> <a href="#ref-for-current-value②">(3)</a> <a href="#ref-for-current-value③">(4)</a>
    <li><a href="#ref-for-current-value④">4. Application of transitions</a> <a href="#ref-for-current-value⑤">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dfn-complete">
   <b><a href="#dfn-complete">#dfn-complete</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dfn-complete">3. Starting of transitions</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="transitionevent">
   <b><a href="#transitionevent">#transitionevent</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-transitionevent">6.1. Interface TransitionEvent</a> <a href="#ref-for-transitionevent①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-transitioneventinit">
   <b><a href="#dictdef-transitioneventinit">#dictdef-transitioneventinit</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-transitioneventinit">6.1.1. IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="Events-TransitionEvent-propertyName">
   <b><a href="#Events-TransitionEvent-propertyName">#Events-TransitionEvent-propertyName</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Events-TransitionEvent-propertyName">6.1.1. IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="Events-TransitionEvent-elapsedTime">
   <b><a href="#Events-TransitionEvent-elapsedTime">#Events-TransitionEvent-elapsedTime</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Events-TransitionEvent-elapsedTime">6.1.1. IDL Definition</a>
    <li><a href="#ref-for-Events-TransitionEvent-elapsedTime①">6.2. Types of TransitionEvent</a> <a href="#ref-for-Events-TransitionEvent-elapsedTime②">(2)</a> <a href="#ref-for-Events-TransitionEvent-elapsedTime③">(3)</a> <a href="#ref-for-Events-TransitionEvent-elapsedTime④">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="Events-TransitionEvent-pseudoElement">
   <b><a href="#Events-TransitionEvent-pseudoElement">#Events-TransitionEvent-pseudoElement</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Events-TransitionEvent-pseudoElement">6.1.1. IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-transitionevent-transitionevent">
   <b><a href="#dom-transitionevent-transitionevent">#dom-transitionevent-transitionevent</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-transitionevent-transitionevent">6.1.1. IDL Definition</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="transitionrun">
   <b><a href="#transitionrun">#transitionrun</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-transitionrun">6.2. Types of TransitionEvent</a> <a href="#ref-for-transitionrun①">(2)</a>
    <li><a href="#ref-for-transitionrun②">6.3. Event handlers on elements, Document objects, and Window objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="transitionstart">
   <b><a href="#transitionstart">#transitionstart</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-transitionstart">6.2. Types of TransitionEvent</a> <a href="#ref-for-transitionstart①">(2)</a>
    <li><a href="#ref-for-transitionstart②">6.3. Event handlers on elements, Document objects, and Window objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="transitionend">
   <b><a href="#transitionend">#transitionend</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-transitionend">6.2. Types of TransitionEvent</a>
    <li><a href="#ref-for-transitionend①">6.3. Event handlers on elements, Document objects, and Window objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="transitioncancel">
   <b><a href="#transitioncancel">#transitioncancel</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-transitioncancel">6.2. Types of TransitionEvent</a> <a href="#ref-for-transitioncancel①">(2)</a>
    <li><a href="#ref-for-transitioncancel②">6.3. Event handlers on elements, Document objects, and Window objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-globaleventhandlers-ontransitionrun">
   <b><a href="#dom-globaleventhandlers-ontransitionrun">#dom-globaleventhandlers-ontransitionrun</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-globaleventhandlers-ontransitionrun">6.3. Event handlers on elements, Document objects, and Window objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-globaleventhandlers-ontransitionstart">
   <b><a href="#dom-globaleventhandlers-ontransitionstart">#dom-globaleventhandlers-ontransitionstart</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-globaleventhandlers-ontransitionstart">6.3. Event handlers on elements, Document objects, and Window objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-globaleventhandlers-ontransitionend">
   <b><a href="#dom-globaleventhandlers-ontransitionend">#dom-globaleventhandlers-ontransitionend</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-globaleventhandlers-ontransitionend">6.3. Event handlers on elements, Document objects, and Window objects</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-globaleventhandlers-ontransitioncancel">
   <b><a href="#dom-globaleventhandlers-ontransitioncancel">#dom-globaleventhandlers-ontransitioncancel</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-globaleventhandlers-ontransitioncancel">6.3. Event handlers on elements, Document objects, and Window objects</a>
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
            </script><a class='success' href='/bikeshed/css-transitions/' id='generator' title='Bikeshed Succeeded'><svg height='24' viewbox='0 0 100 100' width='24'><g stroke="blue" stroke-width="6" fill="none"><path fill="blue" stroke="none" d="M 5 95 L 5 35 L 50 10 L 50 95"/><path d="M 1 37 L 54 8"/><path fill="blue" stroke="none" d="M 1 40 v -6 l 60 -32 v 6 z" /><circle cx="75" cy="79" r="15" /><circle fill="blue" stroke="none" cx="75" cy="79" r="4" /><path d="M 75 79 L 65 49 L 55 49" /><path d="M 67 55 L 48 69" /></g></svg></a>