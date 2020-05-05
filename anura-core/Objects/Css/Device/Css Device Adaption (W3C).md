<!doctype html><html lang="en">
 <head>
  <meta content="text/html; charset=utf-8" http-equiv="Content-Type">
  <title>CSS Device Adaptation Module Level 1</title>
  <meta content="width=device-width, initial-scale=1, shrink-to-fit=no" name="viewport">
  <meta content="exploring" name="csswg-work-status">
  <meta content="ED" name="w3c-status">
  <meta content="This specification provides a way for an author to specify, in CSS, the size, zoom factor, and orientation of the viewport that is used as the base for the initial containing block." name="abstract">
  <link href="../default.css" rel="stylesheet" type="text/css">
  <link href="../csslogo.ico" rel="shortcut icon" type="image/x-icon">
<style>
  body {
    background: url("https://www.w3.org/StyleSheets/TR/logo-ED") top left no-repeat;
  }
  </style>
  <meta content="Bikeshed version d4d56a96, updated Fri Apr 10 11:10:34 2020 -0700" name="generator">
  <link href="http://www.w3.org/TR/css-device-adapt-1/" rel="canonical">
<style>
    /* Style for algorithm pseudo code. */

    #algorithm {
        font-family: serif;
        font-size: 1em;
        white-space: pre;
        margin: 1em;
        padding: 1em;
        background-color: #f4f4f4;
    }

    #algorithm .method {
        counter-reset: statement;
        line-height: 1.5em;
    }

    #algorithm .method-name {
        font-variant: small-caps;
    }

    #algorithm .statement {
        counter-increment: statement;
    }

    #algorithm .statement:before {
        content: counter(statement) "   ";
        display: inline-block;
        width: 2em;
    }

    #algorithm .keyword {
        font-weight: bold;
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
 <script nonce='8pgjqprUKodI2/pbVpZOR5zI09aNRTr/acI7c0w3ECs=' type='text/javascript'><!--
Stream=function(uri,params,callback){this.xhr=new XMLHttpRequest();this.callback=callback;this.persist=false;if(!params){params={};}var loginKey=system.getCookie('loginkey');if(loginKey){params['loginkey']=loginKey;}params['stream']=++this.gStreamId;this.uri=(params ?uri+'?'+system.encodeParams(params):uri);var stream=this;this.xhr.onreadystatechange=function(){if((200==stream.xhr.status)&&((3==stream.xhr.readyState)||(4==stream.xhr.readyState))){var message=stream.xhr.responseText.substring(stream.processed);if(-1!=message.indexOf("\uEE00\uEEFF\uEE00")){var messages=message.split("\uEE00\uEEFF\uEE00");for(var index=0;index<(messages.length-1);index++){message=messages[index];stream.processed+=(message.length+3);try{response=JSON.parse(message.trim());}catch(err){console.log("stream parse error: "+message.trim());console.log(err);continue;}stream.callback(response.message,response.data);}}if(4==stream.xhr.readyState){if(stream.persist&&(!stream.closed)){setTimeout(function(){if(!stream.closed){stream.connect();}},10);}stream.closed=true;}}};this.connect();return this;};Stream.prototype={gStreamId:Math.floor(Math.random()*0xFFFFFFFF),connect:function(){this.processed=0;this.closed=false;this.xhr.open('GET',this.uri,true);this.xhr.setRequestHeader('Accept','application/json');this.xhr.send();},close:function(){this.closed=true;if((4!=this.xhr.readyState)&&(0!=this.xhr.readyState)){this.xhr.abort();}},setTimeout:function(callback,timeoutMS){this.xhr.timeout=timeoutMS;var stream=this;this.xhr.ontimeout=function(){stream.closed=true;callback(stream);};},};
// --></script><script nonce='8pgjqprUKodI2/pbVpZOR5zI09aNRTr/acI7c0w3ECs=' type='text/javascript'><!--
var gDraftAPIURI="https:\/\/drafts.csswg.org\/api\/drafts\/";var gCookiePrefix="drafts_";var gRepo="csswg";var gDate=false;var gBranch=null;var gHead=null;var gRepoPath="css-device-adapt-1\/Overview.bs";if(!Array.indexOf){Array.prototype.indexOf=function(obj){for(var index=0;index<this.length;index++){if(this[index]==obj){return index;}}return-1;}}if(!Date.now){Date.now=function(){return new Date().getTime();}}try{if(1!=Node.ELEMENT_NODE){throw true;}}catch(exc){var Node={ELEMENT_NODE:1,ATTRIBUTE_NODE:2,TEXT_NODE:3};}var system={getCookie:function(name){var cookies=document.cookie.split(';');name+='=';var prefixedName=gCookiePrefix+name;for(var index=0;index<cookies.length;index++){cookie=cookies[index].trim();if(prefixedName==cookie.substring(0,prefixedName.length)){return unescape(cookie.substring(prefixedName.length));}if(name==cookie.substring(0,name.length)){return unescape(cookie.substring(name.length));}}return null;},encodeParams:function(params,arrayName){var paramString='';for(param in params){if(params.hasOwnProperty(param)){if(paramString){paramString+='&';}var name=param;if(arrayName){name=arrayName+'['+param+']';}if(Array.isArray(params[param])){for(var index=0;index<params[param].length;index++){paramString+=name+'[]='+params[param][index];}}else if('object'==typeof(params[param])){paramString+=this.encodeParams(params[param],param);}else if('boolean'==typeof(params[param])){paramString+=name+'='+(params[param]+0);}else{paramString+=name+'='+encodeURIComponent(params[param]);}}}return paramString;},addLoadEvent:function(onLoad){try{var oldOnLoad=window.onload;if('function'!=typeof(window.onload)){window.onload=onLoad;}else{window.onload=function(){if(oldOnLoad){oldOnLoad();}onLoad();}}}catch(err){}}};var updateCount=0;var maxStreamListenTime=5*60*1000;var minStreamListenTime=10*1000;var streamInterval=20*60*1000;var streamListenTime=maxStreamListenTime;var streamStartTime=0;function updateBikeshed(message,data){var bikeshedIcon=document.getElementById('bikeshed');if(bikeshedIcon){bikeshedIcon.setAttribute('class',data.status);switch(data.status){case'pending':case'generating':bikeshedIcon.setAttribute('title','Bikeshed Pending');break;case'success':bikeshedIcon.setAttribute('title','Bikeshed Succeeded');break;case'warning':bikeshedIcon.setAttribute('title','Bikeshed Warnings');break;case'fatal':bikeshedIcon.setAttribute('title','Bikeshed Errors');break;case'previous':case'error':bikeshedIcon.setAttribute('title','Bikeshed Failed');break;}}updateCount++;if((1<updateCount)||(gDate&&(data.date!=gDate))){streamListenTime=maxStreamListenTime;gUpdateStream.setTimeout(streamTimeout,(Date.now()-streamStartTime)+streamListenTime);if((gDate<data.date)&&(('committed'==data.status)||('success'==data.status)||('warning'==data.status))){window.location.reload();}}gDate=data.date;}function streamTimeout(stream){streamListenTime=minStreamListenTime;setTimeout(function(){startStream();},streamInterval);}function startStream(){updateCount=0;streamStartTime=Date.now();gUpdateStream=new Stream(gDraftAPIURI,{'repo':gRepo,'date':gDate,'branch':gBranch,'head':gHead,'path':gRepoPath},updateBikeshed);gUpdateStream.persist=true;gUpdateStream.setTimeout(streamTimeout,streamListenTime);}function setupPage(){var bikeshedIcon=document.getElementById('bikeshed');if(bikeshedIcon){bikeshedIcon.onclick=function(domEvent){if(domEvent.shiftKey){var url=bikeshedIcon.getAttribute('href').replace('/bikeshed/','/static/')+window.location.hash;window.location.href=url;if(domEvent){(domEvent.preventDefault)?domEvent.preventDefault():domEvent.returnValue=false;}}};}startStream();}system.addLoadEvent(setupPage);
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
   <h1 class="p-name no-ref" id="title">CSS Device Adaptation Module Level 1</h1>
   <h2 class="no-num no-toc no-ref heading settled" id="subtitle"><span class="content">Editor’s Draft, <time class="dt-updated" datetime="2019-08-09">9 August 2019</time></span></h2>
   <details>
    <summary>Specification Metadata</summary>
    <div data-fill-with="spec-metadata">
     <dl>
      <dt>This version:
      <dd><a class="u-url" href="https://drafts.csswg.org/css-device-adapt/">https://drafts.csswg.org/css-device-adapt/</a>
      <dt>Latest published version:
      <dd><a href="http://www.w3.org/TR/css-device-adapt-1/">http://www.w3.org/TR/css-device-adapt-1/</a>
      <dt>Previous Versions:
      <dd><a href="http://www.w3.org/TR/2016/WD-css-device-adapt-1-20160329/" rel="prev">http://www.w3.org/TR/2016/WD-css-device-adapt-1-20160329/</a>
      <dt>Issue Tracking:
      <dd><a href="https://www.w3.org/Bugs/Public/buglist.cgi?component=Device%20Adaptation&amp;list_id=52675&amp;product=CSS&amp;resolution=---">Bugzilla</a>
      <dd><a href="#issues-index">Inline In Spec</a>
      <dd><a href="https://github.com/w3c/csswg-drafts/labels/css-device-adapt-1">GitHub Issues</a>
      <dt class="editor">Editors:
      <dd class="editor p-author h-card vcard" data-editor-id="43241"><a class="p-name fn u-url url" href="https://florian.rivoal.net">Florian Rivoal</a> (<span class="p-org org">Invited Expert</span>)
      <dd class="editor p-author h-card vcard" data-editor-id="62267"><span class="p-name fn">Matt Rakow</span> (<span class="p-org org">Microsoft</span>)
      <dt class="editor">Former Editors:
      <dd class="editor p-author h-card vcard"><a class="p-name fn u-email email" href="mailto:rune@opera.com">Rune Lillesveen</a> (<span class="p-org org">Opera Software</span>)
      <dd class="editor p-author h-card vcard"><a class="p-name fn u-email email" href="mailto:rbetts@adobe.com">Ryan Betts</a> (<span class="p-org org">Adobe Systems</span>)
      <dd class="editor p-author h-card vcard"><a class="p-name fn u-email email" href="mailto:oyvinds@opera.com">Øyvind Stenhaug</a> (<span class="p-org org">Opera Software</span>)
      <dt>Suggest an Edit for this Spec:
      <dd><a href="https://github.com/w3c/csswg-drafts/blob/master/css-device-adapt-1/Overview.bs">GitHub Editor</a>
     </dl>
    </div>
   </details>
   <div data-fill-with="warning"></div>
   <p class="copyright" data-fill-with="copyright"><a href="https://www.w3.org/Consortium/Legal/ipr-notice#Copyright">Copyright</a> © 2019 <a href="https://www.w3.org/"><abbr title="World Wide Web Consortium">W3C</abbr></a><sup>®</sup> (<a href="https://www.csail.mit.edu/"><abbr title="Massachusetts Institute of Technology">MIT</abbr></a>, <a href="https://www.ercim.eu/"><abbr title="European Research Consortium for Informatics and Mathematics">ERCIM</abbr></a>, <a href="https://www.keio.ac.jp/">Keio</a>, <a href="https://ev.buaa.edu.cn/">Beihang</a>). W3C <a href="https://www.w3.org/Consortium/Legal/ipr-notice#Legal_Disclaimer">liability</a>, <a href="https://www.w3.org/Consortium/Legal/ipr-notice#W3C_Trademarks">trademark</a> and <a href="https://www.w3.org/Consortium/Legal/2015/copyright-software-and-document">permissive document license</a> rules apply. </p>
   <hr title="Separator for header">
  </div>
  <div class="p-summary" data-fill-with="abstract">
   <h2 class="no-num no-toc no-ref heading settled" id="abstract"><span class="content">Abstract</span></h2>
   <p>This specification provides a way for an author to specify, in CSS, the size, zoom factor, and orientation of the viewport that is used as the base for the initial containing block.</p>
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
	When filing an issue, please put the text “css-device-adapt” in the title,
	preferably like this:
	“[css-device-adapt] <i data-lt>…summary of comment…</i>”.
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
    <li><a href="#intro"><span class="secno">1</span> <span class="content"> Introduction</span></a>
    <li><a href="#scenarios"><span class="secno">2</span> <span class="content"> Motivating Scenarios</span></a>
    <li><a href="#values"><span class="secno">3</span> <span class="content"> Values</span></a>
    <li><a href="#the-viewport"><span class="secno">4</span> <span class="content"> The viewport</span></a>
    <li>
     <a href="#atviewport-rule"><span class="secno">5</span> <span class="content"> The <span>@viewport</span> rule</span></a>
     <ol class="toc">
      <li><a href="#syntax"><span class="secno">5.1</span> <span class="content"> Syntax</span></a>
     </ol>
    <li>
     <a href="#viewport-desc"><span class="secno">6</span> <span class="content"> Viewport descriptors</span></a>
     <ol class="toc">
      <li><a href="#min-max-width-desc"><span class="secno">6.1</span> <span class="content"> The <span class="property">min-width</span> and <span class="property">max-width</span> descriptors</span></a>
      <li><a href="#width-desc"><span class="secno">6.2</span> <span class="content"> The <span class="property">width</span> shorthand descriptor</span></a>
      <li><a href="#min-max-height-desc"><span class="secno">6.3</span> <span class="content"> The <span class="property">min-height</span> and <span class="property">max-height</span> descriptors</span></a>
      <li><a href="#height-desc"><span class="secno">6.4</span> <span class="content"> The <span class="property">height</span> shorthand descriptor</span></a>
      <li><a href="#zoom-desc"><span class="secno">6.5</span> <span class="content"> The <span class="property">zoom</span> descriptor</span></a>
      <li><a href="#min-zoom-desc"><span class="secno">6.6</span> <span class="content"> The <span class="property">min-zoom</span> descriptor</span></a>
      <li><a href="#max-zoom-desc"><span class="secno">6.7</span> <span class="content"> The <span class="property">max-zoom</span> descriptor</span></a>
      <li><a href="#user-zoom-desc"><span class="secno">6.8</span> <span class="content"> The <span class="property">user-zoom</span> descriptor</span></a>
      <li><a href="#orientation-desc"><span class="secno">6.9</span> <span class="content"> The <span class="property">orientation</span> descriptor</span></a>
     </ol>
    <li>
     <a href="#constraining"><span class="secno">7</span> <span class="content"> Constraining viewport descriptor values</span></a>
     <ol class="toc">
      <li><a href="#constraining-defs"><span class="secno">7.1</span> <span class="content"> Definitions</span></a>
      <li><a href="#constraining-procedure"><span class="secno">7.2</span> <span class="content"> The procedure</span></a>
     </ol>
    <li><a href="#media-queries"><span class="secno">8</span> <span class="content"> Media Queries</span></a>
    <li>
     <a href="#cssom"><span class="secno">9</span> <span class="content"> CSSOM</span></a>
     <ol class="toc">
      <li><a href="#css-rule-interface"><span class="secno">9.1</span> <span class="content"> Interface <code>CSSRule</code></span></a>
      <li><a href="#css-viewport-rule-interface"><span class="secno">9.2</span> <span class="content"> Interface <code>CSSViewportRule</code></span></a>
     </ol>
    <li>
     <a href="#viewport-meta"><span class="secno">10</span> <span class="content"> Viewport <code class="html">&lt;META></code> element</span></a>
     <ol class="toc">
      <li><a href="#meta-properties"><span class="secno">10.1</span> <span class="content"> Properties</span></a>
      <li><a href="#parsing-algorithm"><span class="secno">10.2</span> <span class="content"> Parsing algorithm</span></a>
      <li><a href="#extend-to-zoom"><span class="secno">10.3</span> <span class="content"><span class="css">extend-to-zoom</span></span></a>
      <li><a href="#translate-meta-to-at-viewport"><span class="secno">10.4</span> <span class="content"> Translation into <span class="css">@viewport</span> descriptors</span></a>
     </ol>
    <li><a href="#handling-auto-zoom"><span class="secno">11</span> <span class="content"> Handling <span class="css">auto</span> for <span class="property">zoom</span></span></a>
    <li>
     <a href="#ua-stylesheet"><span class="secno">12</span> <span class="content"> UA stylesheets</span></a>
     <ol class="toc">
      <li><a href="#large-screen-ua"><span class="secno">12.1</span> <span class="content"> Large screen UA styles</span></a>
      <li><a href="#small-screen-ua"><span class="secno">12.2</span> <span class="content"> Small screen UA styles</span></a>
     </ol>
    <li><a href="#changes"><span class="secno"></span> <span class="content">Appendix A. Changes</span></a>
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
    <li>
     <a href="#property-index"><span class="secno"></span> <span class="content">Property Index</span></a>
     <ol class="toc">
      <li><a href="#viewport-descriptor-table"><span class="secno"></span> <span class="content"><span>@viewport</span> Descriptors</span></a>
     </ol>
    <li><a href="#idl-index"><span class="secno"></span> <span class="content">IDL Index</span></a>
    <li><a href="#issues-index"><span class="secno"></span> <span class="content">Issues Index</span></a>
   </ol>
  </nav>
  <main>
   <h2 class="heading settled" data-level="1" id="intro"><span class="secno">1. </span><span class="content"> Introduction</span><a class="self-link" href="#intro"></a></h2>
   <p><em>This section is not normative.</em></p>
   <p>CSS 2.1 <a data-link-type="biblio" href="#biblio-css21">[CSS21]</a> specifies an <a href="https://www.w3.org/TR/CSS21/visudet.html#containing-block-details"> initial containing block</a> for continuous media that has the dimensions
of the <a href="https://www.w3.org/TR/CSS21/visuren.html#viewport"> viewport</a>. Since the viewport is generally no larger than the display,
devices with smaller displays such as phones or tablets typically present
a smaller viewport than larger devices like desktop or laptops.</p>
   <p>Unfortunately, many documents have historically been designed against larger
viewports and exhibit a variety of bugs when viewed in smaller viewports.
These include unintended layout wrapping, clipped content, awkward scrollable
bounds, and script errors. To avoid these issues, mobile browsers generally
use a fixed initial containing block width that mimics common desktop browser
window size (typically 980-1024px). The resulting layout is then scaled down
to fit in the available screen space.</p>
   <p>Although this approach mitigates the issues mentioned above, the downscaling
means the CSS pixel size will be smaller than <a href="https://www.w3.org/TR/CSS21/syndata.html#length-units">recommended</a> by CSS 2.1. Users will likely need to zoom on the content to view it
comfortably.</p>
   <p>This mitigation is unnecessary for sites that have been designed to work
well on small viewports.  This specification describes the CSS <code class="css">@viewport</code> rule which allows authors to control and
opt-out of this behavior.</p>
   <p class="issue" id="issue-6c09d247"><a class="self-link" href="#issue-6c09d247"></a> This specification is written from an implementation-centric point of view,
making it arguably difficult to read.
Significant editorial work may be needed
to make it more understandable to different audiences.
It also should clarify which viewport is referred to by various js APIs.
See <a href="http://www.quirksmode.org/blog/archives/2015/09/a_new_device_ad.html">this blog post by ppk</a> for a good discussion of these issues.</p>
   <p class="issue" id="issue-212a8da7"><a class="self-link" href="#issue-212a8da7"></a> Various issues about this specification and related specifications
are listed in <a href="https://www.w3.org/Graphics/SVG/WG/wiki/Proposals/Investigation_of_APIs_for_Level_of_detail#The_issues_on_existing_APIs">this report</a>.</p>
   <h2 class="heading settled" data-level="2" id="scenarios"><span class="secno">2. </span><span class="content"> Motivating Scenarios</span><a class="self-link" href="#scenarios"></a></h2>
   <div class="example" id="example-244c0de5">
    <a class="self-link" href="#example-244c0de5"></a> In this example, the document can be rendered without issue with any
    size viewport. The author indicates this using the <code class="css">@viewport</code> rule. 
<pre class="lang-html highlight"><c- cp>&lt;!doctype html></c->
<c- p>&lt;</c-><c- f>html</c-><c- p>></c->
<c- p>&lt;</c-><c- f>head</c-><c- p>></c->
<c- p>&lt;</c-><c- f>title</c-><c- p>></c->My Site<c- p>&lt;/</c-><c- f>title</c-><c- p>></c->
<c- p>&lt;</c-><c- f>style</c-><c- p>></c->
    <c- p>@</c-><c- k>viewport</c-> <c- p>{</c-> <c- f>width</c-><c- o>:</c-> <c- f>auto</c-><c- o>;</c-> <c- p>}</c->
<c- p>&lt;/</c-><c- f>style</c-><c- p>></c->
<c- p>&lt;/</c-><c- f>head</c-><c- p>></c->
<c- p>&lt;</c-><c- f>body</c-><c- p>></c->
    Since this document is just some simple text, it can be rendered
    at any width without issue.  The text will just re-wrap as needed
    when viewed in a smaller viewport.
<c- p>&lt;/</c-><c- f>body</c-><c- p>></c->
<c- p>&lt;/</c-><c- f>html</c-><c- p>></c->
</pre>
   </div>
   <div class="example" id="example-abe8e9b9">
    <a class="self-link" href="#example-abe8e9b9"></a> In this example, the document can be rendered without issue for viewports
    down to 384px, but smaller sizes would clip the diagram. The author
    indicates this using the <code class="css">@viewport</code> rule in
    combination with a media query. When the viewport would be smaller than
    384px, the user agent will select 384px as the initial containing block
    size and scale the resulting layout down to fit the available space. 
<pre class="lang-html highlight"><c- cp>&lt;!doctype html></c->
<c- p>&lt;</c-><c- f>html</c-><c- p>></c->
<c- p>&lt;</c-><c- f>head</c-><c- p>></c->
<c- p>&lt;</c-><c- f>style</c-><c- p>></c->
    <c- p>@</c-><c- k>viewport</c-> <c- p>{</c-> <c- f>width</c-><c- o>:</c-> <c- f>auto</c-><c- o>;</c-> <c- p>}</c->
    <c- p>@</c-><c- k>media</c-> <c- o>(</c-><c- f>max-width</c-><c- o>:</c-> <c- f>384px</c-><c- o>)</c-> <c- p>{</c->
        <c- p>@</c-><c- k>viewport</c-> <c- p>{</c-> <c- f>width</c-><c- o>:</c-> <c- f>384px</c-><c- o>;</c-> <c- p>}</c->
    <c- p>}</c->
    <c- f>body</c-> <c- p>{</c->
        <c- k>margin</c-><c- p>:</c-> <c- mi>0</c-><c- p>;</c->
    <c- p>}</c->
    <c- f>img</c-> <c- p>{</c->
        <c- k>min-width</c-><c- p>:</c-> <c- mi>384</c-><c- b>px</c-><c- p>;</c->
    <c- p>}</c->
<c- p>&lt;/</c-><c- f>style</c-><c- p>></c->
<c- p>&lt;</c-><c- f>title</c-><c- p>></c->My Other Site<c- p>&lt;/</c-><c- f>title</c-><c- p>></c->
<c- p>&lt;/</c-><c- f>head</c-><c- p>></c->
<c- p>&lt;</c-><c- f>body</c-><c- p>></c->
    <c- p>&lt;</c-><c- f>img</c-> <c- e>src</c-><c- o>=</c-><c- s>"diagram.png"</c-><c- p>></c->
<c- p>&lt;/</c-><c- f>body</c-><c- p>></c->
<c- p>&lt;/</c-><c- f>html</c-><c- p>></c->
</pre>
   </div>
   <h2 class="heading settled" data-level="3" id="values"><span class="secno">3. </span><span class="content"> Values</span><a class="self-link" href="#values"></a></h2>
   <p>This specification follows
the <a href="https://www.w3.org/TR/css3-syntax/#property-defs">CSS
property definition conventions</a> from <a data-link-type="biblio" href="#biblio-css3syn">[CSS3SYN]</a>.</p>
   <p>Value types are defined in <a data-link-type="biblio" href="#biblio-css3val">[CSS3VAL]</a>.</p>
   <h2 class="heading settled" data-level="4" id="the-viewport"><span class="secno">4. </span><span class="content"> The viewport</span><a class="self-link" href="#the-viewport"></a></h2>
   <p>In CSS 2.1 a <a href="https://www.w3.org/TR/CSS21/visuren.html#viewport">viewport</a> is a feature of a user agent for continuous media and used to
establish the initial containing block for continuous media. For paged
media, the initial containing block is based on the page area. The
page area can be set through <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-page-3/#at-ruledef-page" id="ref-for-at-ruledef-page">@page</a> rules. Hence, <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport">@viewport</a> applies to continuous media, and <span class="css" id="ref-for-at-ruledef-page①">@page</span> to paged media, and they
will not interact or conflict.</p>
   <p>This specification introduces a way of overriding the size of the viewport
provided by the user agent (UA). Because of this, we need to introduce the
difference between the <span class="css">initial viewport</span> and the <span class="css">actual viewport</span>.</p>
   <dl>
    <dt><dfn data-dfn-type="dfn" data-noexport id="initial-viewport">initial viewport<a class="self-link" href="#initial-viewport"></a></dfn>
    <dd> This refers to the viewport before any UA or author styles have
        overridden the viewport given by the window or viewing area of the UA.
        Note that the <span class="css">initial viewport</span> size will change with the
        size of the window or viewing area.
    <dt><dfn data-dfn-type="dfn" data-noexport id="actual-viewport">actual viewport<a class="self-link" href="#actual-viewport"></a></dfn>
    <dd> This is the viewport you get after the cascaded viewport descriptors,
        and the following <a href="#constraining-procedure">constraining procedure</a> have been applied. 
   </dl>
   <p>When the <span class="css">actual viewport</span> cannot fit inside the window or
viewing area, either because the <span class="css">actual viewport</span> is
larger than the <span class="css">initial viewport</span> or the zoom factor
causes only parts of the <span class="css">actual viewport</span> to be visible,
the UA should offer a scrolling or panning mechanism.</p>
   <p>It is recommended that initially the upper-left corners of the <span class="css">actual viewport</span> and the window or viewing area are aligned if the
base direction of the document is ltr. Similarly, that the upper-right
corners are aligned when the base direction is rtl. The base direction
for a document is defined as the computed value of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-writing-modes-3/#propdef-direction" id="ref-for-propdef-direction">direction</a> property for the first <code class="html">&lt;BODY></code> element of
an HTML or XHTML document. For other document types, it is the
computed <span class="property" id="ref-for-propdef-direction①">direction</span> for the root element.</p>
   <p class="issue" id="issue-3cd9f731"><a class="self-link" href="#issue-3cd9f731"></a>"dbaron: The question is, what does this do on the desktop
browser? (And what’s a desktop browser)". Need to say that a "desktop"
browser typically have no UA styles, as opposed to the <a href="#ua-stylesheet">UA stylesheet</a> outlined for current mobile
behaviour, and that no UA styles for <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport①">@viewport</a> will give "desktop"
behaviour per default (actual viewport is initial viewport).</p>
   <h2 class="heading settled" data-level="5" id="atviewport-rule"><span class="secno">5. </span><span class="content"> The <dfn class="dfn-paneled css" data-dfn-type="at-rule" data-export id="at-ruledef-viewport">@viewport</dfn> rule</span><a class="self-link" href="#atviewport-rule"></a></h2>
   <div class="note" role="note">
     <strong class="advisement">UA vendors implementing this specification
are strongly encouraged to do so both for their mobile and desktop browsers.
The <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport②">@viewport</a> mechanism is designed to be usable and useful
on all browsers, not only mobile ones.
However, if support is only available on mobile browsers for a significant time,
there is a risk that authors would write <span class="css" id="ref-for-at-ruledef-viewport③">@viewport</span> rules that work on mobile
but do the wrong if applied by a desktop browser.
This would make it difficult to later add support for <span class="css" id="ref-for-at-ruledef-viewport④">@viewport</span> in desktop browsers.</strong> 
    <p>An example of such misguided use would be to write <code class="highlight"><c- n>@viewport</c-> <c- p>{</c-> <c- k>width</c-><c- p>:</c-> <c- m>320</c-><c- l>px</c-><c- p>;</c-> <c- p>}</c-></code> instead of <code class="highlight"><c- n>@viewport</c-> <c- p>{</c-> <c- k>width</c-><c- p>:</c-> auto<c- p>;</c-> <c- p>}</c-></code> to make a document “mobile friendly”. </p>
   </div>
   <p>The <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport⑤">@viewport</a> <a href="https://www.w3.org/TR/CSS21/syndata.html#at-rules">at-rule</a> consists of the @-keyword followed by a block of descriptors
describing the viewport.</p>
   <p>The descriptors inside an <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport⑥">@viewport</a> rule are per document and
there is no inheritance involved. Hence declarations using the <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-cascade-4/#valdef-all-inherit" id="ref-for-valdef-all-inherit">inherit</a> keyword will be dropped. They work similarly
to <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-page-3/#at-ruledef-page" id="ref-for-at-ruledef-page②">@page</a> descriptors and follow the cascading order of CSS. Hence,
descriptors in <span class="css" id="ref-for-at-ruledef-viewport⑦">@viewport</span> rules will override descriptors from
preceding rules. The declarations allow !important which will affect
cascading of descriptors accordingly.</p>
   <p><a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport⑧">@viewport</a> rules apply to top level documents only.</p>
   <div class="example" id="example-184df5eb">
    <a class="self-link" href="#example-184df5eb"></a> This example sets the viewport to at least 320px, but otherwise match
    window width if it is wider than 320px. Note that it is enough to set
    the width as the height will be resolved from the width when auto. 
<pre>@viewport {
    width: 320px auto;
}
</pre>
   </div>
   <h3 class="heading settled" data-level="5.1" id="syntax"><span class="secno">5.1. </span><span class="content"> Syntax</span><a class="self-link" href="#syntax"></a></h3>
   <p>The syntax for the <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport⑨">@viewport</a> rule is as follows (using the
notation from
the <a href="https://www.w3.org/TR/CSS21/grammar.html">Grammar
appendix</a> of CSS 2.1 <a data-link-type="biblio" href="#biblio-css21">[CSS21]</a>):</p>
<pre>viewport
  : VIEWPORT_SYM S* '{' S* declaration? [ ';' S* declaration? ]* '}' S*
  ;
</pre>
   <p>with the new token:</p>
<pre>@{V}{I}{E}{W}{P}{O}{R}{T} {return VIEWPORT_SYM;}</pre>
   <p>where:</p>
<pre>V    v|\\0{0,4}(56|76)(\r\n|[ \t\r\n\f])?|\\v
W    w|\\0{0,4}(57|77)(\r\n|[ \t\r\n\f])?|\\w
</pre>
   <p>The <code>viewport</code> non-terminal is added to the <code>stylesheet</code> production along with the <code>ruleset</code>, <code>media</code>, and <code>page</code> non-terminals:</p>
<pre>stylesheet
  : [ CHARSET_SYM STRING ';' ]?
    [S|CDO|CDC]* [ import [ CDO S* | CDC S* ]* ]*
    [ [ ruleset | media | page | viewport ] [ CDO S* | CDC S* ]* ]*
  ;
</pre>
   <p>It is also added to the <a data-link-type="dfn" href="https://www.w3.org/TR/css3-conditional/#nested_statement" id="ref-for-nested_statement">nested_statement</a> production defined in <a data-link-type="biblio" href="#biblio-css3-conditional">[CSS3-CONDITIONAL]</a> to allow <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport①⓪">@viewport</a> rules nested inside <a data-link-type="dfn" href="https://www.w3.org/TR/css3-conditional/#conditional-group-rules" id="ref-for-conditional-group-rules">conditional group rules</a> such as <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-conditional-3/#at-ruledef-media" id="ref-for-at-ruledef-media">@media</a> or <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-conditional-3/#at-ruledef-supports" id="ref-for-at-ruledef-supports">@supports</a>:</p>
<pre>nested_statement
  : ruleset | media | page | font_face_rule | keyframes_rule |
    supports_rule | viewport
  ;
</pre>
   <h2 class="heading settled" data-level="6" id="viewport-desc"><span class="secno">6. </span><span class="content"> Viewport descriptors</span><a class="self-link" href="#viewport-desc"></a></h2>
   <p>This section presents the descriptors that are allowed inside an <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport①①">@viewport</a> rule. Other descriptors than those listed here will be
dropped.</p>
   <p>Relative length values are resolved against initial values. For
instance 'em’s are resolved against the initial value of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-fonts-3/#propdef-font-size" id="ref-for-propdef-font-size">font-size</a> property. Viewport lengths (<a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-values-4/#vw" id="ref-for-vw">vw</a>, <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-values-4/#vh" id="ref-for-vh">vh</a>, <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-values-4/#vmin" id="ref-for-vmin">vmin</a>, <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-values-4/#vmax" id="ref-for-vmax">vmax</a>) are relative to the initial viewport.</p>
   <h3 class="heading settled" data-level="6.1" id="min-max-width-desc"><span class="secno">6.1. </span><span class="content"> The <a class="property" data-link-type="propdesc">min-width</a> and <span class="property">max-width</span> descriptors</span><a class="self-link" href="#min-max-width-desc"></a></h3>
   <p class="issue" id="issue-081c4ec9"><a class="self-link" href="#issue-081c4ec9"></a>min- and max- functionality can be achieved with media queries, should these be removed?</p>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="css" data-dfn-for="@viewport" data-dfn-type="descriptor" data-export id="descdef-viewport-min-width">min-width<a class="self-link" href="#descdef-viewport-min-width"></a></dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport①②">@viewport</a>
     <tr>
      <th>Value:
      <td class="prod"><a class="production css" data-link-type="type" href="#typedef-viewport-length" id="ref-for-typedef-viewport-length">&lt;viewport-length></a>
     <tr>
      <th>Initial:
      <td>auto
     <tr>
      <th>Percentages:
      <td>Refer to the width of the <span class="css">initial viewport</span>
     <tr>
      <th>Computed value:
      <td>auto, an absolute length, or a percentage as specified
   </table>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="css" data-dfn-for="@viewport" data-dfn-type="descriptor" data-export id="descdef-viewport-max-width">max-width<a class="self-link" href="#descdef-viewport-max-width"></a></dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport①③">@viewport</a>
     <tr>
      <th>Value:
      <td class="prod"><a class="production css" data-link-type="type" href="#typedef-viewport-length" id="ref-for-typedef-viewport-length①">&lt;viewport-length></a>
     <tr>
      <th>Initial:
      <td>auto
     <tr>
      <th>Percentages:
      <td>Refer to the width of the <span class="css">initial viewport</span>
     <tr>
      <th>Computed value:
      <td>auto, an absolute length, or a percentage as specified
   </table>
   <p>Specifies the minimum and maximum width of
the <a href="https://www.w3.org/TR/CSS21/visuren.html#viewport">viewport</a> that is used to set the size of
the <a href="https://www.w3.org/TR/CSS21/visudet.html#containing-block-details"> initial containing block</a> where</p>
<pre class="prod"><dfn class="dfn-paneled" data-dfn-type="type" data-export id="typedef-viewport-length"><var>&lt;viewport-length></var></dfn> = auto <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one">|</a> &lt;length> <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one①">|</a> &lt;percentage></pre>
   <p>and the values have the following meanings:</p>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="viewport-length" data-dfn-type="value" data-export id="valdef-viewport-length-auto">auto</dfn>
    <dd> The used value is calculated from the other descriptors'
        values according to the <a href="#constraining-procedure">constraining procedure</a>. 
    <p class="issue" id="issue-7fbbd2b2"><a class="self-link" href="#issue-7fbbd2b2"></a>The user-agent stylesheets recommended in the informative section don’t adequately represent current implementation behaviors.  Should there be a more explicit mechanism for switching between UA default behavior and requesting the CSS pixel?</p>
    <dt><dfn class="css" data-dfn-for="viewport-length" data-dfn-type="value" data-export id="valdef-viewport-length-length"><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#length-value" id="ref-for-length-value" title="Expands to: advance measure | cap | ch | cm | em | ex | ic | in | lh | mm | pc | pt | px | q | rem | rlh | vb | vh | vi | vmax | vmin | vw">&lt;length></a><a class="self-link" href="#valdef-viewport-length-length"></a></dfn>
    <dd> A non-negative absolute or relative length. 
    <dt><dfn class="css" data-dfn-for="viewport-length" data-dfn-type="value" data-export id="valdef-viewport-length-percentage"><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#percentage-value" id="ref-for-percentage-value">&lt;percentage></a><a class="self-link" href="#valdef-viewport-length-percentage"></a></dfn>
    <dd> A percentage value relative to the width or height of the <span class="css">initial viewport</span> at zoom factor 1.0, for horizontal
        and vertical lengths respectively. Must be non-negative. 
   </dl>
   <p>The <a class="property" data-link-type="propdesc">min-width</a> and <span class="property">max-width</span> descriptors are inputs to the <a href="#constraining-procedure">constraining procedure</a>. The
width will initially be set as close as possible to the ''initial
viewport'' width within the min/max constraints.</p>
   <h3 class="heading settled" data-level="6.2" id="width-desc"><span class="secno">6.2. </span><span class="content"> The <a class="property" data-link-type="propdesc">width</a> shorthand descriptor</span><a class="self-link" href="#width-desc"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="css" data-dfn-for="@viewport" data-dfn-type="descriptor" data-export id="descdef-viewport-width">width<a class="self-link" href="#descdef-viewport-width"></a></dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport①④">@viewport</a>
     <tr>
      <th>Value:
      <td class="prod"><a class="production css" data-link-type="type" href="#typedef-viewport-length" id="ref-for-typedef-viewport-length②">&lt;viewport-length></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-num-range" id="ref-for-mult-num-range">{1,2}</a>
     <tr>
      <th>Initial:
      <td>See individual descriptors
     <tr>
      <th>Percentages:
      <td>See individual descriptors
     <tr>
      <th>Computed value:
      <td>See individual descriptors
   </table>
   <p>This is a shorthand descriptor for setting both <a class="property" data-link-type="propdesc">min-width</a> and <span class="property">max-width</span>. One <a class="production css" data-link-type="type" href="#typedef-viewport-length" id="ref-for-typedef-viewport-length③">&lt;viewport-length></a> value will set both <span class="property">min-width</span> and <span class="property">max-width</span> to that value. Two <span class="production" id="ref-for-typedef-viewport-length④">&lt;viewport-length></span> values will
set <span class="property">min-width</span> to the first and <span class="property">max-width</span> to the second.</p>
   <h3 class="heading settled" data-level="6.3" id="min-max-height-desc"><span class="secno">6.3. </span><span class="content"> The <a class="property" data-link-type="propdesc">min-height</a> and <span class="property">max-height</span> descriptors</span><a class="self-link" href="#min-max-height-desc"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="css" data-dfn-for="@viewport" data-dfn-type="descriptor" data-export id="descdef-viewport-min-height">min-height<a class="self-link" href="#descdef-viewport-min-height"></a></dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport①⑤">@viewport</a>
     <tr>
      <th>Value:
      <td class="prod"><a class="production css" data-link-type="type" href="#typedef-viewport-length" id="ref-for-typedef-viewport-length⑤">&lt;viewport-length></a>
     <tr>
      <th>Initial:
      <td>auto
     <tr>
      <th>Percentages:
      <td>Refer to the height of the <span class="css">initial viewport</span>
     <tr>
      <th>Computed value:
      <td>auto, an absolute length, or a percentage as specified
   </table>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="css" data-dfn-for="@viewport" data-dfn-type="descriptor" data-export id="descdef-viewport-max-height">max-height<a class="self-link" href="#descdef-viewport-max-height"></a></dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport①⑥">@viewport</a>
     <tr>
      <th>Value:
      <td class="prod"><a class="production css" data-link-type="type" href="#typedef-viewport-length" id="ref-for-typedef-viewport-length⑥">&lt;viewport-length></a>
     <tr>
      <th>Initial:
      <td>auto
     <tr>
      <th>Percentages:
      <td>Refer to the height of the <span class="css">initial viewport</span>
     <tr>
      <th>Computed value:
      <td>auto, an absolute length, or a percentage as specified
   </table>
   <p>Specifies the minimum and maximum height of the <a href="https://www.w3.org/TR/CSS21/visuren.html#viewport">viewport</a> that is used to set the size of the <a href="https://www.w3.org/TR/CSS21/visudet.html#containing-block-details"> initial containing block</a>.</p>
   <p>The min-height and max-height descriptors are inputs to
the <a href="#constraining-procedure">constraining procedure</a>.
The height will initially be set as close as possible to the ''initial
viewport'' height within the min/max constraints.</p>
   <h3 class="heading settled" data-level="6.4" id="height-desc"><span class="secno">6.4. </span><span class="content"> The <a class="property" data-link-type="propdesc">height</a> shorthand descriptor</span><a class="self-link" href="#height-desc"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="css" data-dfn-for="@viewport" data-dfn-type="descriptor" data-export id="descdef-viewport-height">height<a class="self-link" href="#descdef-viewport-height"></a></dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport①⑦">@viewport</a>
     <tr>
      <th>Value:
      <td class="prod"><a class="production css" data-link-type="type" href="#typedef-viewport-length" id="ref-for-typedef-viewport-length⑦">&lt;viewport-length></a><a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#mult-num-range" id="ref-for-mult-num-range①">{1,2}</a>
     <tr>
      <th>Initial:
      <td>See individual descriptors
     <tr>
      <th>Percentages:
      <td>See individual descriptors
     <tr>
      <th>Computed value:
      <td>See individual descriptors
   </table>
   <p>This is a shorthand descriptor for setting both min-height and max-height.
One <a class="production css" data-link-type="type" href="#typedef-viewport-length" id="ref-for-typedef-viewport-length⑧">&lt;viewport-length></a> value will set both min-height and max-height
to that value. Two <span class="production" id="ref-for-typedef-viewport-length⑨">&lt;viewport-length></span> values will set min-height to
the first and max-height to the second.</p>
   <h3 class="heading settled" data-level="6.5" id="zoom-desc"><span class="secno">6.5. </span><span class="content"> The <a class="property" data-link-type="propdesc" href="#descdef-viewport-zoom" id="ref-for-descdef-viewport-zoom">zoom</a> descriptor</span><a class="self-link" href="#zoom-desc"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-for="@viewport" data-dfn-type="descriptor" data-export id="descdef-viewport-zoom">zoom</dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport①⑧">@viewport</a>
     <tr>
      <th>Value:
      <td class="prod">auto <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one②">|</a> <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#number-value" id="ref-for-number-value">&lt;number></a> <span id="ref-for-comb-one③">|</span> <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#percentage-value" id="ref-for-percentage-value①">&lt;percentage></a>
     <tr>
      <th>Initial:
      <td>auto
     <tr>
      <th>Percentages:
      <td>The zoom factor itself
     <tr>
      <th>Computed value:
      <td>auto, or a non-negative number or percentage as specified
   </table>
   <p>Specifies the initial zoom factor for the window or viewing area. This
is a magnifying glass type of zoom. Interactively changing the zoom
factor from the initial zoom factor does not affect the size of the
initial or the actual viewport.</p>
   <p>Values have the following meanings:</p>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="zoom" data-dfn-type="value" data-export id="valdef-zoom-auto">auto</dfn>
    <dd> The zoom factor is UA-dependent. The UA may use the size of the area
        of the canvas on which the document is rendered to find that initial
        zoom factor. See <a href="#handling-auto-zoom">this section</a> for a
        proposed way of handling <a class="css" data-link-type="maybe" href="#valdef-zoom-auto" id="ref-for-valdef-zoom-auto">auto</a> values for <a class="property" data-link-type="propdesc" href="#descdef-viewport-zoom" id="ref-for-descdef-viewport-zoom①">zoom</a>. 
    <dt><var><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#number-value" id="ref-for-number-value①">&lt;number></a></var>
    <dd> A non-negative number used as a zoom factor. A factor of 1.0 means
        that no zooming is done. Values larger than 1.0 gives a zoomed-in
        effect and values smaller than 1.0 a zoomed-out effect. 
    <dt><var><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#percentage-value" id="ref-for-percentage-value②">&lt;percentage></a></var>
    <dd> A non-negative percentage value used as a zoom factor. A factor of
        100% means that no zooming is done. Values larger than 100% gives a
        zoomed-in effect and values smaller than 100% a zoomed-out effect. 
   </dl>
   <h3 class="heading settled" data-level="6.6" id="min-zoom-desc"><span class="secno">6.6. </span><span class="content"> The <a class="property" data-link-type="propdesc" href="#descdef-viewport-min-zoom" id="ref-for-descdef-viewport-min-zoom">min-zoom</a> descriptor</span><a class="self-link" href="#min-zoom-desc"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-for="@viewport" data-dfn-type="descriptor" data-export id="descdef-viewport-min-zoom">min-zoom</dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport①⑨">@viewport</a>
     <tr>
      <th>Value:
      <td class="prod">auto <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one④">|</a> <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#number-value" id="ref-for-number-value②">&lt;number></a> <span id="ref-for-comb-one⑤">|</span> <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#percentage-value" id="ref-for-percentage-value③">&lt;percentage></a>
     <tr>
      <th>Initial:
      <td>auto
     <tr>
      <th>Percentages:
      <td>The zoom factor itself
     <tr>
      <th>Computed value:
      <td>auto, or a non-negative number or percentage as specified
   </table>
   <p>Specifies the smallest allowed zoom factor. It is used as input to the <a href="#constraining-procedure">constraining procedure</a> to constrain
non-<a class="css" data-link-type="maybe" href="#valdef-zoom-auto" id="ref-for-valdef-zoom-auto①">auto</a> <a class="property" data-link-type="propdesc" href="#descdef-viewport-zoom" id="ref-for-descdef-viewport-zoom②">zoom</a> values, but also to limit the allowed zoom factor
that can be set through user interaction. The UA should also use this
value as a constraint when choosing an actual zoom factor when the
used value of <span class="property" id="ref-for-descdef-viewport-zoom③">zoom</span> is <span class="css" id="ref-for-valdef-zoom-auto②">auto</span>.</p>
   <p>Values have the following meanings:</p>
   <dl>
    <dt>auto
    <dd> The lower limit on zoom factor is UA dependent. There will be no minimum
        value constraint on the <a class="property" data-link-type="propdesc" href="#descdef-viewport-zoom" id="ref-for-descdef-viewport-zoom④">zoom</a> descriptor used in
        the <a href="#constraining-procedure">constraining
        procedure</a> 
    <dt><var><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#number-value" id="ref-for-number-value③">&lt;number></a></var>
    <dd> A non-negative number limiting the minimum value of the zoom factor. 
    <dt><var><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#percentage-value" id="ref-for-percentage-value④">&lt;percentage></a></var>
    <dd> A non-negative percentage limiting the minimum value of the zoom factor. 
   </dl>
   <h3 class="heading settled" data-level="6.7" id="max-zoom-desc"><span class="secno">6.7. </span><span class="content"> The <a class="property" data-link-type="propdesc" href="#descdef-viewport-max-zoom" id="ref-for-descdef-viewport-max-zoom">max-zoom</a> descriptor</span><a class="self-link" href="#max-zoom-desc"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-for="@viewport" data-dfn-type="descriptor" data-export id="descdef-viewport-max-zoom">max-zoom</dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport②⓪">@viewport</a>
     <tr>
      <th>Value:
      <td class="prod">auto <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one⑥">|</a> <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#number-value" id="ref-for-number-value④">&lt;number></a> <span id="ref-for-comb-one⑦">|</span> <a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#percentage-value" id="ref-for-percentage-value⑤">&lt;percentage></a>
     <tr>
      <th>Initial:
      <td>auto
     <tr>
      <th>Percentages:
      <td>The zoom factor itself
     <tr>
      <th>Computed value:
      <td>auto, or a non-negative number or percentage as specified
   </table>
   <p>Specifies the largest allowed zoom factor. It is used as input to the <a href="#constraining-procedure">constraining procedure</a> to constrain
non-<a class="css" data-link-type="maybe" href="#valdef-zoom-auto" id="ref-for-valdef-zoom-auto③">auto</a> <a class="property" data-link-type="propdesc" href="#descdef-viewport-zoom" id="ref-for-descdef-viewport-zoom⑤">zoom</a> values, but also to limit the allowed zoom factor
that can be set through user interaction. The UA may choose to ignore
this limit for accessibility/usability reasons – see the relevant note in
the <a class="property" data-link-type="propdesc" href="#descdef-viewport-user-zoom" id="ref-for-descdef-viewport-user-zoom">user-zoom</a> section. The UA should also use this
value as a constraint when choosing an actual zoom factor when the
used value of <span class="property" id="ref-for-descdef-viewport-zoom⑥">zoom</span> is <span class="css" id="ref-for-valdef-zoom-auto④">auto</span>.</p>
   <p>Values have the following meanings:</p>
   <dl>
    <dt>auto
    <dd> The upper limit on zoom factor is UA dependent. There will be
        no maximum value constraint on the <a class="property" data-link-type="propdesc" href="#descdef-viewport-zoom" id="ref-for-descdef-viewport-zoom⑦">zoom</a> descriptor used in
        the <a href="#constraining-procedure">constraining
        procedure</a> 
    <dt><var><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#number-value" id="ref-for-number-value⑤">&lt;number></a></var>
    <dd> A non-negative number limiting the maximum value of the zoom factor. 
    <dt><var><a class="production css" data-link-type="type" href="https://drafts.csswg.org/css-values-3/#percentage-value" id="ref-for-percentage-value⑥">&lt;percentage></a></var>
    <dd> A non-negative percentage limiting the maximum value of the zoom factor. 
   </dl>
   <h3 class="heading settled" data-level="6.8" id="user-zoom-desc"><span class="secno">6.8. </span><span class="content"> The <a class="property" data-link-type="propdesc" href="#descdef-viewport-user-zoom" id="ref-for-descdef-viewport-user-zoom①">user-zoom</a> descriptor</span><a class="self-link" href="#user-zoom-desc"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-for="@viewport" data-dfn-type="descriptor" data-export id="descdef-viewport-user-zoom">user-zoom</dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport②①">@viewport</a>
     <tr>
      <th>Value:
      <td class="prod">zoom <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one⑧">|</a> fixed
     <tr>
      <th>Initial:
      <td>zoom
     <tr>
      <th>Percentages:
      <td>N/A
     <tr>
      <th>Computed value:
      <td>as specified
   </table>
   <p>Specifies if the zoom factor can be changed by user interaction or not.</p>
   <p>Values have the following meanings:</p>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="user-zoom" data-dfn-type="value" data-export id="valdef-user-zoom-zoom">zoom</dfn>
    <dd> The user can interactively change the zoom factor. 
    <dt><dfn class="dfn-paneled css" data-dfn-for="user-zoom" data-dfn-type="value" data-export id="valdef-user-zoom-fixed">fixed</dfn>
    <dd> The user cannot interactively change the zoom factor. 
   </dl>
   <div class="note" role="note">
     Authors should not suppress (with <code>user-zoom: fixed</code>)
    or limit (with <code>max-zoom</code>) the ability of users to resize
    a document, as this causes accessibility and usability issues. 
    <p>There may be specific use cases where preventing users from zooming
    may be appropriate, such as map applications – where custom zoom
    functionality is handled via scripting. However, in general this
    practice should be avoided.</p>
    <p>Most user agents now allow users to always zoom, regardless
    of any restrictions specified by web content – either by default, or
    as a setting/option (which may however not be immediately apparent
    to users).</p>
   </div>
   <h3 class="heading settled" data-level="6.9" id="orientation-desc"><span class="secno">6.9. </span><span class="content"> The <a class="property" data-link-type="propdesc" href="#descdef-viewport-orientation" id="ref-for-descdef-viewport-orientation">orientation</a> descriptor</span><a class="self-link" href="#orientation-desc"></a></h3>
   <table class="def descdef">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-for="@viewport" data-dfn-type="descriptor" data-export id="descdef-viewport-orientation">orientation</dfn>
     <tr>
      <th>For:
      <td><a class="css" data-link-type="at-rule" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport②②">@viewport</a>
     <tr>
      <th>Value:
      <td class="prod">auto <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one⑨">|</a> portrait <span id="ref-for-comb-one①⓪">|</span> landscape
     <tr>
      <th>Initial:
      <td>auto
     <tr>
      <th>Percentages:
      <td>N/A
     <tr>
      <th>Computed value:
      <td>as specified
   </table>
   <p>This descriptor is used to request that a document is displayed in portrait
or landscape mode. For a UA/device where the orientation is changed upon
tilting the device, an author can use this descriptor to inhibit the
orientation change. The descriptor should be respected for
standalone web applications, and when the document is displayed
in fullscreen. It is recommended that it is ignored for normal
web navigation to avoid confusing the user.</p>
   <p>Values have the following meanings:</p>
   <dl>
    <dt><dfn class="css" data-dfn-for="orientation" data-dfn-type="value" data-export id="valdef-orientation-auto">auto<a class="self-link" href="#valdef-orientation-auto"></a></dfn>
    <dd> The UA automatically chooses the orientation based on the device’s
        normal mode of operation. The UA may choose to change the orientation
        of the presentation when the device is tilted. 
    <dt><dfn class="css" data-dfn-for="orientation" data-dfn-type="value" data-export id="valdef-orientation-portrait">portrait<a class="self-link" href="#valdef-orientation-portrait"></a></dfn>
    <dd> The document should be locked to portrait presentation. 
    <dt><dfn class="css" data-dfn-for="orientation" data-dfn-type="value" data-export id="valdef-orientation-landscape">landscape<a class="self-link" href="#valdef-orientation-landscape"></a></dfn>
    <dd> The document should be locked to landscape presentation. 
   </dl>
   <h2 class="heading settled" data-level="7" id="constraining"><span class="secno">7. </span><span class="content"> Constraining viewport descriptor values</span><a class="self-link" href="#constraining"></a></h2>
   <h3 class="heading settled" data-level="7.1" id="constraining-defs"><span class="secno">7.1. </span><span class="content"> Definitions</span><a class="self-link" href="#constraining-defs"></a></h3>
   <p>For the procedure below:</p>
   <p>Descriptors refer to the values resolved/constrained to at that point in
the procedure. They are initially resolved to their computed values.</p>
   <p><dfn data-dfn-type="dfn" data-noexport id="width"><code>width</code><a class="self-link" href="#width"></a></dfn> and <dfn data-dfn-type="dfn" data-noexport id="height"><code>height</code><a class="self-link" href="#height"></a></dfn> refer
to the resolved viewport size and not the shorthand descriptors. They
are both initially <a class="css" data-link-type="maybe" href="#valdef-viewport-length-auto" id="ref-for-valdef-viewport-length-auto">auto</a>.</p>
   <p><code>MIN/MAX</code> computations where one of the arguments is <a class="css" data-link-type="maybe" href="#valdef-zoom-auto" id="ref-for-valdef-zoom-auto⑤">auto</a> resolve to the other argument. For instance, <code>MIN(0.25, <a class="css" data-link-type="maybe" href="#valdef-zoom-auto" id="ref-for-valdef-zoom-auto⑥">auto</a>) = 0.25</code>, and <code>MAX(5, <a class="css" data-link-type="maybe" href="#valdef-zoom-auto" id="ref-for-valdef-zoom-auto⑦">auto</a>) = 5</code>.</p>
   <p><dfn data-dfn-type="dfn" data-noexport id="initial-width"><code>initial-width</code><a class="self-link" href="#initial-width"></a></dfn> is the width of the <span class="css">initial viewport</span> in pixels at zoom factor 1.0.</p>
   <p><dfn data-dfn-type="dfn" data-noexport id="initial-height"><code>initial-height</code><a class="self-link" href="#initial-height"></a></dfn> is the height of the <span class="css">initial viewport</span> in pixels at zoom factor 1.0.</p>
   <h3 class="heading settled" data-level="7.2" id="constraining-procedure"><span class="secno">7.2. </span><span class="content"> The procedure</span><a class="self-link" href="#constraining-procedure"></a></h3>
   <p>The used values are resolved from the computed values going through
the steps below.</p>
   <p>User agents are expected, but not required, to re-run this procedure
and re-layout the document, if necessary, in response to changes
in the user environment, for example if the device is tilted from
landscape to portrait mode or the window that forms the ''initial
viewport'' is resized.</p>
   <p>However, Media Queries and Device Adaption are <dfn data-dfn-type="dfn" data-lt="Specifications
whose evaluations are both affected by the same changes to the user
environment, and so always must be evaluated together in order to
ensure proper rendering." data-noexport id="specifications-whose-evaluations-are-both-affected-by-the-same-changes-to-the-user-environment-and-so-always-must-be-evaluated-together-in-order-to-ensure-proper-rendering">tethered specifications<a class="self-link" href="#specifications-whose-evaluations-are-both-affected-by-the-same-changes-to-the-user-environment-and-so-always-must-be-evaluated-together-in-order-to-ensure-proper-rendering"></a></dfn>. As a result,
UAs that also
support <a href="https://www.w3.org/TR/css3-mediaqueries/">Media Queries</a> must re-run this procedure and re-layout the document in all cases
where changes in the user environment would cause them to re-evaluate
Media Queries.</p>
   <h4 class="no-num no-toc heading settled" id="constraining-min-max-zoom"><span class="content"> Resolve <code data-lt="min-zoom!!resolved">min-zoom</code> and <code data-lt="max-zoom!!resolved">max-zoom</code> values</span><a class="self-link" href="#constraining-min-max-zoom"></a></h4>
   <ol>
    <li> If <code data-lt="min-zoom!!resolved">min-zoom</code> is not <a class="css" data-link-type="maybe" href="#valdef-zoom-auto" id="ref-for-valdef-zoom-auto⑧">auto</a> and <code data-lt="max-zoom!!resolved">max-zoom</code> is not <span class="css" id="ref-for-valdef-zoom-auto⑨">auto</span>, set <code>max-zoom = MAX(min-zoom,
        max-zoom)</code> 
   </ol>
   <h4 class="no-num no-toc heading settled" id="constraining-zoom"><span class="content"> Constrain <code data-lt="zoom!!resolved">zoom</code> value to
the <code>[min-zoom, max-zoom]</code> range</span><a class="self-link" href="#constraining-zoom"></a></h4>
   <ol id="ol2">
    <li> If <code data-lt="zoom!!resolved">zoom</code> is not <a class="css" data-link-type="maybe" href="#valdef-zoom-auto" id="ref-for-valdef-zoom-auto①⓪">auto</a>,
        set <code>zoom = MAX(min-zoom, MIN(max-zoom,
        zoom))</code> 
   </ol>
   <h4 class="no-num no-toc heading settled" id="resolve-px"><span class="content"> Resolve non-<a class="css" data-link-type="maybe" href="#valdef-viewport-length-auto" id="ref-for-valdef-viewport-length-auto①">auto</a> lengths to pixel lengths</span><a class="self-link" href="#resolve-px"></a></h4>
   <ol id="ol3">
    <li> Resolve absolute lengths and percentages to pixel values for the <a class="property" data-link-type="propdesc">min-width</a>, <span class="property">max-width</span>, <span class="property">min-height</span>, and <span class="property">max-height</span> descriptors. 
   </ol>
   <h4 class="no-num no-toc heading settled" id="resolve-initial-width-height"><span class="content"> Resolve initial <code data-lt="width!!resolved">width</code> and <code data-lt="height!!resolved">height</code> from min/max
descriptors</span><a class="self-link" href="#resolve-initial-width-height"></a></h4>
   <ol id="ol4">
    <li> If <code data-lt="min-width!!resolved">min-width</code> or <code data-lt="max-width!!resolved">max-width</code> is not <a class="css" data-link-type="maybe" href="#valdef-viewport-length-auto" id="ref-for-valdef-viewport-length-auto②">auto</a>, set <code>width = MAX(min-width, MIN(max-width,
        initial-width))</code> 
    <li> If <code data-lt="min-height!!resolved">min-height</code> or <code data-lt="max-height!!resolved">max-height</code> is not <a class="css" data-link-type="maybe" href="#valdef-viewport-length-auto" id="ref-for-valdef-viewport-length-auto③">auto</a>, set <code>height = MAX(min-height, MIN(max-height,
        initial-height))</code> 
   </ol>
   <h4 class="no-num no-toc heading settled" id="resolve-width"><span class="content"> Resolve <code data-lt="width!!resolved">width</code> value</span><a class="self-link" href="#resolve-width"></a></h4>
   <ol id="ol6">
    <li> If <code data-lt="width!!resolved">width</code> and <code data-lt="height!!resolved">height</code> are both <a class="css" data-link-type="maybe" href="#valdef-viewport-length-auto" id="ref-for-valdef-viewport-length-auto④">auto</a>, set <code>width = initial-width</code> 
    <li> Otherwise, if <code data-lt="width!!resolved">width</code> is <a class="css" data-link-type="maybe" href="#valdef-viewport-length-auto" id="ref-for-valdef-viewport-length-auto⑤">auto</a>, set <code>width = height * (initial-width /
        initial-height)</code>, or <code>width = initial-width</code> if <code class="index" data-lt="height!!initial">initial-height</code> is 0. 
   </ol>
   <h4 class="no-num no-toc heading settled" id="resolve-height"><span class="content"> Resolve <code data-lt="height!!resolved">height</code> value</span><a class="self-link" href="#resolve-height"></a></h4>
   <ol id="ol8">
    <li> If <code data-lt="height!!resolved">height</code> is <a class="css" data-link-type="maybe" href="#valdef-viewport-length-auto" id="ref-for-valdef-viewport-length-auto⑥">auto</a>,
        set <code>height = width * (initial-height /
        initial-width)</code>, or <code>height = initial-height</code> if <code class="index" data-lt="width!!initial">initial-width</code> is 0. 
   </ol>
   <h2 class="heading settled" data-level="8" id="media-queries"><span class="secno">8. </span><span class="content"> Media Queries</span><a class="self-link" href="#media-queries"></a></h2>
   <p>For several media features, the size of the initial containing block and
the orientation of the device affects the result of a media query
evaluation, which means that the effect of <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport②③">@viewport</a> rules on
media queries needs extra attention.</p>
   <p>From the Media Queries specification <a data-link-type="biblio" href="#biblio-mediaq">[MEDIAQ]</a>:</p>
   <blockquote>
    <p> “To avoid circular dependencies, it is never necessary
        to apply the style sheet in order to evaluate expressions. For example,
        the aspect ratio of a printed document may be influenced by a style sheet,
        but expressions involving <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-device-aspect-ratio" id="ref-for-descdef-media-device-aspect-ratio">device-aspect-ratio</a> will be based
        on the default aspect ratio of the user agent.” </p>
   </blockquote>
   <p>The UA must however cascade <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport②④">@viewport</a> rules separately with the <span class="css">initial viewport</span> size used for evaluating media feature
expressions and other values that depend on the viewport size to avoid
circular dependencies, but use the actual viewport size when cascading all other rules.</p>
   <p>Procedure for applying CSS rules:</p>
   <ol>
    <li> Cascade all <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport②⑤">@viewport</a> rules using the <span class="css">initial viewport</span> size for values and evaluations which rely on viewport size 
    <li> Compute the <span class="css">actual viewport</span> from the cascaded viewport
        descriptors 
    <li> Cascade all other rules using the <span class="css">actual viewport</span> size 
   </ol>
   <p class="note" role="note"> The rationale for using the viewport descriptors obtained from applying
    the <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport②⑥">@viewport</a> rules for evaluating media queries for style
    rules, is that media queries should match the <span class="css">actual viewport</span> that the document will be laid out in and not the initial or the
    one specified in the UA stylesheet. Consider the example below
    given that the UA stylesheet has a viewport width of 980px, but an <span class="css">initial viewport</span> width of 320px. The author has made separate
    styles to make the document look good for initial containing block
    widths above or below 400px. The <span class="css">actual viewport</span> used will be
    320px wide, and in order to match the styles with the ''actual
    viewport'' width, the viewport resulting from applying the <span class="css" id="ref-for-at-ruledef-viewport②⑦">@viewport</span> rules should be used to evaluate the media queries. </p>
   <div class="example" id="example-b47882d5">
    <a class="self-link" href="#example-b47882d5"></a> Given an initial viewport width of 320px and a UA stylesheet viewport
    width of 980px, the first media query will not match, but the second will. 
<pre>@viewport {
    width: auto;
}

@media screen and (min-width: 400px) {
    div { color: red; }
}

@media screen and (max-width: 400px) {
    div { color: green; }
}
</pre>
   </div>
   <p>Another example:</p>
   <div class="example" id="example-52d3ef3d">
    <a class="self-link" href="#example-52d3ef3d"></a> The media query below should match because the <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport②⑧">@viewport</a> rule
    is applied before the media query is evaluated. 
<pre>@media screen and (width: 397px) {
    div { color: green; }
}

@viewport {
    width: 397px;
}
</pre>
   </div>
   <p>Below is an example where an <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport②⑨">@viewport</a> rule relies on a media
query affected by the viewport descriptors.</p>
   <div class="example" id="example-cd649410">
    <a class="self-link" href="#example-cd649410"></a> The green color should be applied to a div because the <span class="css">initial viewport</span> width is used to evaluate the media query
    for the second <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport③⓪">@viewport</a> rule, but the <span class="css">actual viewport</span> is used for evaluating the media query when applying style rules. 
<pre>@viewport {
    width: 397px;
}

@media screen and (width: 397px) {
    @viewport {
        width: 500px;
    }
}

@media screen and (width: 397px) {
    div { color: green; }
}
</pre>
   </div>
   <p>It is recommended that authors do not write <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport③①">@viewport</a> rules that
rely on media queries whose evaluation is affected by viewport
descriptors. Is is also recommended that the <span class="css" id="ref-for-at-ruledef-viewport③②">@viewport</span> rule(s) is
placed as early in the document as possible to avoid unnecessary
re-evaluation of media queries or reflows.</p>
   <h2 class="heading settled" data-level="9" id="cssom"><span class="secno">9. </span><span class="content"> CSSOM</span><a class="self-link" href="#cssom"></a></h2>
   <p>The <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport③③">@viewport</a> rule is exposed to the CSSOM through a new CSSRule
interface.</p>
   <h3 class="heading settled" data-level="9.1" id="css-rule-interface"><span class="secno">9.1. </span><span class="content"> Interface <code>CSSRule</code></span><a class="self-link" href="#css-rule-interface"></a></h3>
   <p>The following rule type is added to the <code>CSSRule</code> interface. It provides identification for the new viewport rule.</p>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://drafts.csswg.org/cssom-1/#cssrule" id="ref-for-cssrule"><c- g>CSSRule</c-></a> {
    <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short" id="ref-for-idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <dfn class="idl-code" data-dfn-for="CSSRule" data-dfn-type="const" data-export id="dom-cssrule-viewport_rule"><code><c- g>VIEWPORT_RULE</c-></code><a class="self-link" href="#dom-cssrule-viewport_rule"></a></dfn> = 15;
};
</pre>
   <h3 class="heading settled" data-level="9.2" id="css-viewport-rule-interface"><span class="secno">9.2. </span><span class="content"> Interface <code>CSSViewportRule</code></span><a class="self-link" href="#css-viewport-rule-interface"></a></h3>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="cssviewportrule"><code>CSSViewportRule</code></dfn> interface represents the
style rule for an <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport③④">@viewport</a> rule.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="#cssviewportrule" id="ref-for-cssviewportrule"><c- g>CSSViewportRule</c-></a> : <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssrule" id="ref-for-cssrule①"><c- n>CSSRule</c-></a> {
    <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssstyledeclaration" id="ref-for-cssstyledeclaration"><c- n>CSSStyleDeclaration</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleDeclaration" href="#dom-cssviewportrule-style" id="ref-for-dom-cssviewportrule-style"><c- g>style</c-></a>;
};
</pre>
   <dl>
    <dt><dfn class="dfn-paneled idl-code" data-dfn-for="CSSViewportRule" data-dfn-type="attribute" data-export id="dom-cssviewportrule-style"><code>style</code></dfn> <span> of type <a data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssstyledeclaration" id="ref-for-cssstyledeclaration①">CSSStyleDeclaration</a>, readonly</span>
    <dd> This attribute represents the viewport descriptors associated
        with this <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport③⑤">@viewport</a> rule. 
   </dl>
   <h2 class="heading settled" data-level="10" id="viewport-meta"><span class="secno">10. </span><span class="content"> Viewport <code class="html">&lt;META></code> element</span><a class="self-link" href="#viewport-meta"></a></h2>
   <p><em>This section is not normative.</em></p>
   <p>This section describes a mapping from the content attribute of the
viewport <code class="html">&lt;META></code> element, first
implemented by Apple in the iPhone Safari browser, to the descriptors
of the <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport③⑥">@viewport</a> rule described in this
specification.</p>
   <p>In order to match the Safari implementation, the following parsing
algorithm and translation rules rely on the UA stylesheet below. See the
section on <a href="#ua-stylesheet">UA stylesheets</a> for an elaborate
description.</p>
<pre>@viewport {
    width: extend-to-zoom 980px;
    min-zoom: 0.25;
    max-zoom: 5;
}
</pre>
   <p class="note" role="note"> Note that these values might not fit well with all UAs. For
    instance, with a min-zoom of 0.25 you will be able to fit the whole width
    of the document inside the window for widths up to 1280px on a 320px wide
    device like the original iPhone, but only 960px if you have a 240px
    display (all widths being given in CSS pixel units). </p>
   <h3 class="heading settled" data-level="10.1" id="meta-properties"><span class="secno">10.1. </span><span class="content"> Properties</span><a class="self-link" href="#meta-properties"></a></h3>
   <p>The recognized properties in the viewport <code class="html">&lt;META></code> element are:</p>
   <ul>
    <li><code class="index" data-lt="width!!viewport META">width</code>
    <li><code class="index" data-lt="height!!viewport META">height</code>
    <li><code class="index">initial-scale</code>
    <li><code class="index">minimum-scale</code>
    <li><code class="index">maximum-scale</code>
    <li><code class="index">user-scalable</code>
   </ul>
   <h3 class="heading settled" data-level="10.2" id="parsing-algorithm"><span class="secno">10.2. </span><span class="content"> Parsing algorithm</span><a class="self-link" href="#parsing-algorithm"></a></h3>
   <p>Below is an algorithm for parsing the <code class="html">content</code> attribute of the <code class="html">&lt;META></code> tag produced
from testing Safari on the iPhone. <span class="note"> The testing was
done on an iPod touch running iPhone OS 4. The UA string of the
browser: <code>"Mozilla/5.0 (iPod; U; CPU iPhone OS 4_0 like Mac OS X;
en-us) AppleWebKit/532.9 (KHTML, like Gecko) Version/4.0.5
Mobile/8A293 Safari/6531.22.7"</code>.</span> The pseudo code notation
used is based on the notation used in <a data-link-type="biblio" href="#biblio-algorithms">[Algorithms]</a>.</p>
   <p>The whitespace class contains the following characters (ascii):</p>
   <ul>
    <li>Horizontal tab (0x09)
    <li>Line feed (0x0a)
    <li>Carriage return (0x0d)
    <li>Space (0x20)
   </ul>
   <p>The recognized separator between property/value pairs is comma for the
Safari implementation. Some implementations have supported both commas
and semicolons. Because of that, existing content use semicolons instead
of commas. Authors should be using comma in order to ensure content works
as expected in all UAs, but implementors may add support for both to ensure
interoperability for existing content.</p>
   <p>The separator class contains the following characters (ascii), with
comma as the preferred separator and semicolon as optional:</p>
   <ul>
    <li>Comma (0x2c)
    <li>Semicolon (0x3b)
   </ul>
<pre id="algorithm"><span class="method"><span class="method-name">Parse-Content</span>(<span class="variable">S</span>)</span>
<span class="statement"><span class="variable">i</span> ← 1</span>
<span class="statement"><span class="keyword">while</span> <span class="variable">i</span> ≤ <span class="op">length</span>[<span class="variable">S</span>]</span>
<span class="statement">    <span class="keyword">do</span> <span class="keyword">while</span> <span class="variable">i</span> ≤ <span class="op">length</span>[<span class="variable">S</span>] and <span class="variable">S</span>[<span class="variable">i</span>] in [whitespace, separator, '=']</span>
<span class="statement">        <span class="keyword">do</span> <span class="variable">i</span> ← <span class="variable">i</span> + 1</span>
<span class="statement">    <span class="keyword">if</span> <span class="variable">i</span> ≤ <span class="op">length</span>[<span class="variable">S</span>]</span>
<span class="statement">        <span class="keyword">then</span> <span class="variable">i</span> ← <span class="method-name">Parse-Property</span>(<span class="variable">S</span>, <span class="variable">i</span>)</span>

<span class="method"><span class="method-name">Parse-Property</span>(<span class="variable">S</span>, <span class="variable">i</span>)</span>
<span class="statement"><span class="variable">start</span> ← <span class="variable">i</span></span>
<span class="statement"><span class="keyword">while</span> <span class="variable">i</span> ≤ <span class="op">length</span>[<span class="variable">S</span>] and <span class="variable">S</span>[<span class="variable">i</span>] <span class="keyword">not</span> in [whitespace, separator, '=']</span>
<span class="statement">    <span class="keyword">do</span> <span class="variable">i</span> ← <span class="variable">i</span> + 1</span>
<span class="statement"><span class="keyword">if</span> <span class="variable">i</span> > <span class="op">length</span>[<span class="variable">S</span>] or <span class="variable">S</span>[<span class="variable">i</span>] in [separator]</span>
<span class="statement">    <span class="keyword">then</span> <span class="keyword">return</span> <span class="variable">i</span></span>
<span class="statement"><span class="variable">property-name</span> ← <span class="variable">S</span>[<span class="variable">start</span> .. (<span class="variable">i</span> - 1)]</span>
<span class="statement"><span class="keyword">while</span> <span class="variable">i</span> ≤ <span class="op">length</span>[<span class="variable">S</span>] and <span class="variable">S</span>[<span class="variable">i</span>] <span class="keyword">not</span> in [separator, '=']</span>
<span class="statement">    <span class="keyword">do</span> <span class="variable">i</span> ← <span class="variable">i</span> + 1</span>
<span class="statement"><span class="keyword">if</span> <span class="variable">i</span> > <span class="op">length</span>[<span class="variable">S</span>] or <span class="variable">S</span>[<span class="variable">i</span>] in [separator]</span>
<span class="statement">    <span class="keyword">then</span> <span class="keyword">return</span> <span class="variable">i</span></span>
<span class="statement"><span class="keyword">while</span> <span class="variable">i</span> ≤ <span class="op">length</span>[<span class="variable">S</span>] and <span class="variable">S</span>[<span class="variable">i</span>] in [whitespace, '=']</span>
<span class="statement">    <span class="keyword">do</span> <span class="variable">i</span> ← <span class="variable">i</span> + 1</span>
<span class="statement"><span class="keyword">if</span> <span class="variable">i</span> > <span class="op">length</span>[<span class="variable">S</span>] or <span class="variable">S</span>[<span class="variable">i</span>] in [separator]</span>
<span class="statement">    <span class="keyword">then</span> <span class="keyword">return</span> <span class="variable">i</span></span>
<span class="statement"><span class="variable">start</span> ← <span class="variable">i</span></span>
<span class="statement"><span class="keyword">while</span> <span class="variable">i</span> ≤ <span class="op">length</span>[<span class="variable">S</span>] and <span class="variable">S</span>[<span class="variable">i</span>] <span class="keyword">not</span> in [whitespace, separator, '=']</span>
<span class="statement">    <span class="keyword">do</span> <span class="variable">i</span> ← <span class="variable">i</span> + 1</span>
<span class="statement"><span class="variable">property-value</span> ← <span class="variable">S</span>[<span class="variable">start</span> .. (<span class="variable">i</span> - 1)]</span>
<span class="statement"><span class="method-name">Set-Property</span>(<span class="variable">property-name</span>, <span class="variable">property-value</span>)</span>
<span class="statement"><span class="keyword">return</span> <span class="variable">i</span></span>
</pre>
   <p><span class="method-name">Set-Property</span> matches the <a href="#meta-properties">listed property names</a> case-insensitively.
The <code class="variable">property-value</code> strings are interpreted
as follows:</p>
   <ol>
    <li> If a prefix of <code class="variable">property-value</code> can be converted to a number using <code>strtod</code>, the
        value will be that number. The remainder of the string is
        ignored. 
    <li> If the value can not be converted to a number as described above,
        the whole <code class="variable">property-value</code> string
        will be matched with the following strings
        case-insensitively: <code class="index">yes</code>, <code class="index">no</code>, <code class="index" data-lt="device-width!!viewport META">device-width</code>, <code class="index" data-lt="device-height!!viewport META">device-height</code> 
    <li> If the string did not match any of the known strings, the
        value is unknown. 
   </ol>
   <h3 class="heading settled" data-level="10.3" id="extend-to-zoom"><span class="secno">10.3. </span><span class="content"><span class="css">extend-to-zoom</span></span><a class="self-link" href="#extend-to-zoom"></a></h3>
   <p>In order to be able to implement the functionality from <code class="html">&lt;META></code> viewport where the viewport width
or height is extended to fill the viewing area at a given zoom level,
we introduce a UA internal value to the list of <a class="production css" data-link-type="type" href="#typedef-viewport-length" id="ref-for-typedef-viewport-length①⓪">&lt;viewport-length></a> values called <span class="css">extend-to-zoom</span>. It will be used in width and height
declarations in the translation outlined in the section below.</p>
   <p>This new value is necessary in order to implement the mapping for two
reasons. First, whether resolving the width/height needs to extend the
pixel length to the visible width/height for a given zoom factor depends
on the current initial width/height. <code class="html">&lt;meta name="viewport" content="width=400, initial-scale=1"></code> yields a width of 400px for an initial-width of 320px, and 640px for an
initial width of 640px. This can not be expressed as normative min/max
descriptors that would constrain correctly when the initial width changes
like for an orientation change.</p>
   <p>Secondly, the extended width/height also relies on cascading viewport
properties from different sources, including <a class="property" data-link-type="propdesc" href="#descdef-viewport-min-zoom" id="ref-for-descdef-viewport-min-zoom①">min-zoom</a> and <a class="property" data-link-type="propdesc" href="#descdef-viewport-max-zoom" id="ref-for-descdef-viewport-max-zoom①">max-zoom</a> from the UA stylesheet. For instance, if the UA stylesheet
has <code>max-zoom: 5</code>, and the initial width is 320px, <code class="html">&lt;meta name="viewport" content="width=10"></code> will resolve to 64px.</p>
   <h4 class="no-num no-toc heading settled" id="resolve-extend-to-zoom"><span class="content"> Resolving '<code class="css" data-lt="extend-to-zoom">extend-to-zoom</code>'</span><a class="self-link" href="#resolve-extend-to-zoom"></a></h4>
   <p>The '<code class="css" data-lt="extend-to-zoom">extend-to-zoom</code>'
value is resolved to pixel or auto lengths as part of <a href="#resolve-px">step 3</a> of the <a href="#constraining-procedure">constraining procedure</a>. Since this
is a <em>non-normative</em> descriptor value, the resolution is described
here. Note that max-descriptors need to be resolved to pixel lengths <em>before</em> min-descriptors when
'<code class="css" data-lt="extend-to-zoom">extend-to-zoom</code>'
is a valid value.</p>
   <p>Let <code>extend-zoom = MIN(zoom, max-zoom)</code></p>
   <p>For non-<a class="css" data-link-type="maybe" href="#valdef-zoom-auto" id="ref-for-valdef-zoom-auto①①">auto</a> <code>extend-zoom</code>, let:</p>
<pre>extend-width = initial-width / extend-zoom
extend-height = initial-height / extend-zoom
</pre>
   <p>Then, resolve for <span class="css">extend-to-zoom</span> as follows:</p>
   <ul>
    <li>
     If <code>extend-zoom</code> is <a class="css" data-link-type="maybe" href="#valdef-zoom-auto" id="ref-for-valdef-zoom-auto①②">auto</a>: 
     <ol>
      <li> If <code data-lt="max-width!!resolved">max-width</code> is
                '<code class="css">extend-to-zoom</code>', set <code>max-width = <a class="css" data-link-type="maybe" href="#valdef-viewport-length-auto" id="ref-for-valdef-viewport-length-auto⑦">auto</a></code> 
      <li> If <code data-lt="max-height!!resolved">max-height</code> is
                '<code class="css">extend-to-zoom</code>', set <code>max-height = <a class="css" data-link-type="maybe" href="#valdef-viewport-length-auto" id="ref-for-valdef-viewport-length-auto⑧">auto</a></code> 
      <li> If <code data-lt="min-width!!resolved">min-width</code> is
                '<code class="css">extend-to-zoom</code>', set <code>min-width = max-width</code> 
      <li> If <code data-lt="min-height!!resolved">min-height</code> is
                '<code class="css">extend-to-zoom</code>', set <code>min-height = max-height</code> 
     </ol>
    <li>
      If <code>extend-zoom</code> is non-<a class="css" data-link-type="maybe" href="#valdef-zoom-auto" id="ref-for-valdef-zoom-auto①③">auto</a>: 
     <ol>
      <li> If <code data-lt="max-width!!resolved">max-width</code> is
                '<code class="css">extend-to-zoom</code>', set <code>max-width = extend-width</code> 
      <li> If <code data-lt="max-height!!resolved">max-height</code> is
                '<code class="css">extend-to-zoom</code>', set <code>max-height = extend-height</code> 
      <li> If <code data-lt="min-width!!resolved">min-width</code> is
                '<code class="css">extend-to-zoom</code>', set <code>min-width = MAX(extend-width, max-width)</code> 
      <li> If <code data-lt="min-height!!resolved">min-height</code> is
                '<code class="css">extend-to-zoom</code>', set <code>min-height = MAX(extend-height, max-height)</code> 
     </ol>
   </ul>
   <h3 class="heading settled" data-level="10.4" id="translate-meta-to-at-viewport"><span class="secno">10.4. </span><span class="content"> Translation into <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport③⑦">@viewport</a> descriptors</span><a class="self-link" href="#translate-meta-to-at-viewport"></a></h3>
   <p>The Viewport <code class="html">&lt;META></code> element is placed
in the cascade as if it was a <code class="html">&lt;STYLE></code> element,
in the exact same place in the dom, that only contains a single <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport③⑧">@viewport</a> rule.</p>
   <p>Each of the property/value pair from the parsing in the
previous section are translated, and added to that single at-rule
as follows:</p>
   <h4 class="no-num no-toc heading settled" id="unknown-properties"><span class="content"> Unknown properties</span><a class="self-link" href="#unknown-properties"></a></h4>
   <p>Unknown properties are dropped.</p>
   <h4 class="no-num no-toc heading settled" id="width-and-height-properties"><span class="content"> The <code class="index" data-lt="width!!viewport META">width</code> and <code class="index" data-lt="height!!viewport META">height</code> properties</span><a class="self-link" href="#width-and-height-properties"></a></h4>
   <p>The <code class="index" data-lt="width!!viewport META">width</code> and <code class="index" data-lt="height!!viewport META">height</code> viewport <code class="html">&lt;META></code> properties are
translated into <a class="property" data-link-type="propdesc">width</a> and <span class="property">height</span> descriptors, setting the <span class="property">min-width</span>/<span class="property">min-height</span> value to <span class="css">extend-to-zoom</span> and the <span class="property">max-width</span>/<span class="property">max-height</span> value to the  length from the
viewport <code class="html">&lt;META></code> property as follows:</p>
   <ol>
    <li> Non-negative number values are translated to pixel lengths, clamped to
        the range: <code>[1px, 10000px]</code> 
    <li> Negative number values are dropped 
    <li> <code class="index" data-lt="device-width!!viewport META">device-width</code> and <code class="index" data-lt="device-height!!viewport META">device-height</code> translate to 100vw and 100vh respectively 
    <li> Other keywords and unknown values translate to 1px 
   </ol>
   <p class="note" role="note"> Some existing UA implementations use device dimensions in CSS
    pixels, and some use the window dimensions (CSS pixels) for device-width /
    device-height. Above, we translate to 100vw / 100vh which are the window
    dimensions. The rationale is that the device dimensions would not be what
    the author intended for UAs where the window is resizable or does not fill
    the screen of the device. </p>
   <div class="example" id="example-b13db30e">
    <a class="self-link" href="#example-b13db30e"></a> 
    <p>This <code class="html">&lt;META></code> element:</p>
<pre>&lt;meta name="viewport" content="width=500, height=600">
</pre>
    <p>translates into:</p>
<pre>@viewport {
    width: extend-to-zoom 500px;
    height: extend-to-zoom 600px;
}
</pre>
   </div>
   <p>For a viewport <code class="html">&lt;META></code> element that
translates into an <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport③⑨">@viewport</a> rule with a non-<a class="css" data-link-type="maybe" href="#valdef-zoom-auto" id="ref-for-valdef-zoom-auto①④">auto</a> <a class="property" data-link-type="propdesc" href="#descdef-viewport-zoom" id="ref-for-descdef-viewport-zoom⑧">zoom</a> declaration and no <a class="property" data-link-type="propdesc">width</a> declaration:</p>
   <ul>
    <li>
      If it adds a '<code class="descriptor">height</code>'
        descriptor, add: 
<pre>width: auto;</pre>
    <li>
      Otherwise, add: 
<pre>width: extend-to-zoom;</pre>
   </ul>
   <p>to the <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport④⓪">@viewport</a> rule.</p>
   <div class="example" id="example-d496fc24">
    <a class="self-link" href="#example-d496fc24"></a> This <code class="html">&lt;META></code> element: 
<pre>&lt;meta name="viewport" content="initial-scale=1.0">
</pre>
    <p>translates into:</p>
<pre>@viewport {
    zoom: 1.0;
    width: extend-to-zoom;
}
</pre>
   </div>
   <div class="example" id="example-0a56d4e9">
    <a class="self-link" href="#example-0a56d4e9"></a> This <code class="html">&lt;META></code> element: 
<pre>&lt;meta name="viewport" content="initial-scale=2.0,
height=device-width">
</pre>
    <p>translates into:</p>
<pre>@viewport {
    zoom: 2.0;
    width: auto;
    height: extend-to-zoom 100%;
}
</pre>
   </div>
   <h4 class="no-num no-toc heading settled" id="min-scale-max-scale"><span class="content"> The <code class="index">initial-scale</code>, <code class="index">minimum-scale</code>, and <code class="index">maximum-scale</code> properties</span><a class="self-link" href="#min-scale-max-scale"></a></h4>
   <p>The properties are translated into
'<code class="descriptor" data-lt="zoom!!descriptor">zoom</code>',
'<code class="descriptor">min-zoom</code>',
and '<code class="descriptor">max-zoom</code>'
respectively with the following translations of values.</p>
   <ol>
    <li> Non-negative number values are translated to &lt;number> values,
        clamped to the range <code>[0.1, 10]</code> 
    <li> Negative number values are dropped 
    <li> <code class="index">yes</code> is translated to 1 
    <li> <code class="index" data-lt="device-width!!viewport META">device-width</code> and <code class="index" data-lt="device-height!!viewport META">device-height</code> are translated to 10 
    <li> <code class="index">no</code> and unknown values are
        translated to 0.1 
   </ol>
   <p>For a viewport <code class="html">&lt;META></code> element that translates
into an <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport④①">@viewport</a> rule with no <a class="property" data-link-type="propdesc" href="#descdef-viewport-max-zoom" id="ref-for-descdef-viewport-max-zoom②">max-zoom</a> declaration and a
non-auto <a class="property" data-link-type="propdesc" href="#descdef-viewport-min-zoom" id="ref-for-descdef-viewport-min-zoom②">min-zoom</a> value that is larger than the <span class="property" id="ref-for-descdef-viewport-max-zoom③">max-zoom</span> value of
the UA stylesheet, the <span class="property" id="ref-for-descdef-viewport-min-zoom③">min-zoom</span> declaration value is clamped to the
UA stylesheet <span class="property" id="ref-for-descdef-viewport-max-zoom④">max-zoom</span> value.</p>
   <h4 class="no-num no-toc heading settled" id="user-scalable"><span class="content"> The <code class="index">user-scalable</code> property</span><a class="self-link" href="#user-scalable"></a></h4>
   <p>The <code class="index">user-scalable</code> property is translated into <a class="property" data-link-type="propdesc" href="#descdef-viewport-user-zoom" id="ref-for-descdef-viewport-user-zoom②">user-zoom</a> with the following value translations.</p>
   <ol>
    <li> <code class="index">yes</code> and <code class="index">no</code> are
        translated into <a class="css" data-link-type="maybe" href="#valdef-user-zoom-zoom" id="ref-for-valdef-user-zoom-zoom">zoom</a> and <a class="css" data-link-type="maybe" href="#valdef-user-zoom-fixed" id="ref-for-valdef-user-zoom-fixed">fixed</a> respectively. 
    <li> Numbers ≥ 1, numbers ≤ -1, <code class="index" data-lt="device-width!!viewport META">device-width</code> and <code class="index" data-lt="device-height!!viewport
        META">device-height</code> are mapped to <a class="css" data-link-type="maybe" href="#valdef-user-zoom-zoom" id="ref-for-valdef-user-zoom-zoom①">zoom</a> 
    <li> Numbers in the range <code>&lt;-1, 1></code>, and unknown values,
        are mapped to <a class="css" data-link-type="maybe" href="#valdef-user-zoom-fixed" id="ref-for-valdef-user-zoom-fixed①">fixed</a> 
   </ol>
   <div class="example" id="example-c4345210">
    <a class="self-link" href="#example-c4345210"></a> This <code class="html">&lt;META></code> element: 
<pre>&lt;meta name="viewport" content="width=480, initial-scale=2.0, user-scalable=1">
</pre>
    <p>will translate into this <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport④②">@viewport</a> block:</p>
<pre>@viewport {
    width: 480px;
    zoom: 2.0;
    user-zoom: zoom;
}
</pre>
   </div>
   <h2 class="heading settled" data-level="11" id="handling-auto-zoom"><span class="secno">11. </span><span class="content"> Handling <a class="css" data-link-type="maybe" href="#valdef-zoom-auto" id="ref-for-valdef-zoom-auto①⑤">auto</a> for <a class="property" data-link-type="propdesc" href="#descdef-viewport-zoom" id="ref-for-descdef-viewport-zoom⑨">zoom</a></span><a class="self-link" href="#handling-auto-zoom"></a></h2>
   <p><em>This section is not normative.</em></p>
   <p>This section presents one way of picking an actual value for the <a class="property" data-link-type="propdesc" href="#descdef-viewport-zoom" id="ref-for-descdef-viewport-zoom①⓪">zoom</a> descriptor when the used value is <a class="css" data-link-type="maybe" href="#valdef-zoom-auto" id="ref-for-valdef-zoom-auto①⑥">auto</a>.</p>
   <p>Given an <span class="css">initial viewport</span> with size <code>(initial-width,
initial-height)</code>, and a finite region within the <a href="https://www.w3.org/TR/CSS21/intro.html#canvas">canvas</a> where the formatting structure is rendered <code>(rendered-width,
rendered-height)</code>. That region is at least as large as the <span class="css">actual viewport</span>.</p>
   <p>Then, if the used value of <a class="property" data-link-type="propdesc" href="#descdef-viewport-zoom" id="ref-for-descdef-viewport-zoom①①">zoom</a> is <a class="css" data-link-type="maybe" href="#valdef-zoom-auto" id="ref-for-valdef-zoom-auto①⑦">auto</a>, let the actual zoom factor be:</p>
<pre>zoom = MAX(initial-width / rendered-width, initial-height / rendered-height)
</pre>
   <p>The actual zoom factor should also be further limited by the
[min-zoom, max-zoom] range.</p>
   <h2 class="heading settled" data-level="12" id="ua-stylesheet"><span class="secno">12. </span><span class="content"> UA stylesheets</span><a class="self-link" href="#ua-stylesheet"></a></h2>
   <p><em>This section is informative</em></p>
   <p>Traditional user agents, used mostly on desktop and laptop computers, can
easily be resized to fit most websites inside the initial viewport without
breaking the layout. Using the recommendations below, sites not adding any <a class="css" data-link-type="maybe" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport④③">@viewport</a> rules themselves will continue to look and function like
they always have.</p>
   <h3 class="heading settled" data-level="12.1" id="large-screen-ua"><span class="secno">12.1. </span><span class="content"> Large screen UA styles</span><a class="self-link" href="#large-screen-ua"></a></h3>
   <p>If a user agent has an initial viewport size large enough to fit common documents without breaking the layout,
or which can easily to resized to do so,
the recommendation is to have <em>no</em> UA styles.
That means that it will have all descriptors initially set to <a class="css" data-link-type="maybe" href="#valdef-viewport-length-auto" id="ref-for-valdef-viewport-length-auto⑨">auto</a>,
and behave as it would have without support for viewport descriptors.</p>
   <p>If a user agent supports changing orientation,
and the landscape mode’s size fits common documents as described above
but the portrait mode’s size does not,
it is recommended to set a minimum layout width
equal to that of the width in landscape mode.</p>
   <div class="example" id="example-7788ad47">
    <a class="self-link" href="#example-7788ad47"></a> 
<pre>@viewport {
    min-width: 1024px;
}
</pre>
   </div>
   <h3 class="heading settled" data-level="12.2" id="small-screen-ua"><span class="secno">12.2. </span><span class="content"> Small screen UA styles</span><a class="self-link" href="#small-screen-ua"></a></h3>
   <p>For smaller screen UAs, the UA could set the minimum viewport width to
typically used as an initial viewport width of a traditional user
agent (as described above).</p>
   <div class="example" id="example-f450a176">
    <a class="self-link" href="#example-f450a176"></a> 
<pre>@viewport {
    min-width: 980px;
}
</pre>
   </div>
   <p>It is recommended that limitations in zooming capabilities are not
reflected in the UA styles but rather only affect the used values for
zoom. The min-zoom/max-zoom UA styles mentioned in
the <a href="#viewport-meta">Viewport META section</a> are there to
give an accurate description of how the Safari browser behaves, not as
part of a recommended UA stylesheet.</p>
   <h2 class="no-num heading settled" id="changes"><span class="content">Appendix A. Changes</span><a class="self-link" href="#changes"></a></h2>
   <p>This appendix is <em>informative</em>.</p>
   <p>This appendix describes changes from the <a href="https://www.w3.org/TR/2011/WD-css-device-adapt-20110915/">15 September 2011 First Public Working Draft</a>.</p>
   <ul>
    <li>Made various editorial improvements and clarifications. 
    <li>Added <a href="#cssom">OM Interfaces</a>. 
    <li>Added semi-colon as separator in meta viewport. 
    <li>Created <a href="#ua-stylesheet">UA stylesheets section</a>. 
    <li>Added recommendation for when to respect orientation property. 
    <li>Dropped support for the resolution descriptor. 
    <li>Decouple width/height and zoom, introducing <span class="css">extend-to-zoom</span> value for meta viewport translation. 
    <li>Made normative rules about interaction of @viewport and @media. 
    <li>Allow 0 for <a class="production css" data-link-type="type" href="#typedef-viewport-length" id="ref-for-typedef-viewport-length①①">&lt;viewport-length></a> and <a class="property" data-link-type="propdesc" href="#descdef-viewport-zoom" id="ref-for-descdef-viewport-zoom①②">zoom</a> values 
    <li>Removed support for device-width/height. 
    <li>Apply @viewport to top level document only. 
    <li>Extend <a data-link-type="biblio" href="#biblio-css3-conditional">[CSS3-CONDITIONAL]</a> rather than CSS21 for nesting in @media. 
   </ul>
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
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="descdef-viewport-height">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@viewport/height" title="The height CSS descriptor is a shorthand descriptor for setting both min-height and max-height of the viewport. By providing one viewport length value will set both, the minimum height and the maximum height, to the value provided.">@viewport/height</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox no"><span>Firefox</span><span>None</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>29+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>16+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>None</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>29+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>2.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>16+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="descdef-viewport-max-height">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@viewport/max-height" title="The max-height CSS descriptor specifies the maximum height of the viewport of a document defined via the @viewport at-rule.">@viewport/max-height</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox no"><span>Firefox</span><span>None</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>29+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>16+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>None</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>29+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>2.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>16+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="descdef-viewport-max-width">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@viewport/max-width" title="The max-width CSS descriptor specifies the maximum width of the viewport of a document defined via the @viewport at-rule.">@viewport/max-width</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox no"><span>Firefox</span><span>None</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>29+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>16+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>None</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>29+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>2.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>16+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="max-zoom-desc">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@viewport/max-zoom" title="The max-zoom CSS descriptor sets the maximum zoom factor of a document defined by the @viewport at-rule. The browser will not zoom in any further than this, whether automatically or at the user&apos;s request.">@viewport/max-zoom</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox no"><span>Firefox</span><span>None</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>29+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>16+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>None</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>29+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>2.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>16+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="descdef-viewport-min-height">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@viewport/min-height" title="The min-height CSS descriptor specifies the minimum height of the viewport of a document defined via the @viewport at-rule.">@viewport/min-height</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox no"><span>Firefox</span><span>None</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>29+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>16+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>None</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>29+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>2.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>16+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="descdef-viewport-min-width">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@viewport/min-width" title="The min-width CSS descriptor specifies the minimum width of the viewport of a document defined via @viewport.">@viewport/min-width</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox no"><span>Firefox</span><span>None</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>29+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>16+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>None</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>29+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>2.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>16+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@viewport/width" title="The width CSS descriptor is shorthand for setting both the min-width and the max-width descriptors of the viewport. By providing one viewport length value, that value will determine both the min-width and the max-width to the value provided.">@viewport/width</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox no"><span>Firefox</span><span>None</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>29+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>16+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>None</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>29+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>2.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>16+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="min-zoom-desc">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@viewport/min-zoom" title="The min-zoom CSS descriptor sets the minimum zoom factor of a document defined by the @viewport at-rule. The browser will not zoom out any further than this, whether automatically or at the user&apos;s request.">@viewport/min-zoom</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox no"><span>Firefox</span><span>None</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>29+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>16+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>None</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>29+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>2.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>16+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="orientation-desc">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@viewport/orientation" title="The orientation CSS descriptor controls the orientation of a document defined by @viewport.">@viewport/orientation</a></p>
    <p class="less-than-two-engines-text">In no current engines.</p>
    <div class="support">
     <span class="firefox no"><span>Firefox</span><span>None</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>None</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="user-zoom-desc">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@viewport/user-zoom" title="The user-zoom CSS descriptor controls whether or not the user can change the zoom factor of a document defined by @viewport.">@viewport/user-zoom</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox no"><span>Firefox</span><span>None</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>29+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>16+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>None</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>29+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>2.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>16+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="zoom-desc">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@viewport/zoom" title="The zoom CSS descriptor sets the initial zoom factor of a document defined by the @viewport at-rule.">@viewport/zoom</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox no"><span>Firefox</span><span>None</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>29+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>16+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>None</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>61+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>8.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>16+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="atviewport-rule">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/@viewport" title="The @viewport CSS at-rule lets you configure the viewport through which the document is viewed. It&apos;s primarily used for mobile devices, but is also used by desktop browsers that support features like &quot;snap to edge&quot; (such as Microsoft Edge).">@viewport</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox no"><span>Firefox</span><span>None</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span title="Requires setting a user preference or runtime flag.">🔰 29+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>16+</span></span><span class="edge_blink yes"><span>Edge</span><span title="Requires setting a user preference or runtime flag.">🔰 79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>None</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>29+</span></span><span class="webview_android yes"><span>Android WebView</span><span>4.4+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>2.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>16+</span></span>
    </div>
   </div>
  </aside>
  <h2 class="no-num no-ref heading settled" id="index"><span class="content">Index</span><a class="self-link" href="#index"></a></h2>
  <h3 class="no-num no-ref heading settled" id="index-defined-here"><span class="content">Terms defined by this specification</span><a class="self-link" href="#index-defined-here"></a></h3>
  <ul class="index">
   <li><a href="#actual-viewport">actual viewport</a><span>, in §4</span>
   <li>
    auto
    <ul>
     <li><a href="#valdef-orientation-auto">value for orientation</a><span>, in §6.9</span>
     <li><a href="#valdef-viewport-length-auto">value for viewport-length</a><span>, in §6.1</span>
     <li><a href="#valdef-zoom-auto">value for zoom</a><span>, in §6.5</span>
    </ul>
   <li><a href="#cssviewportrule">CSSViewportRule</a><span>, in §9.2</span>
   <li><a href="#valdef-user-zoom-fixed">fixed</a><span>, in §6.8</span>
   <li>
    height
    <ul>
     <li><a href="#height">definition of</a><span>, in §7.1</span>
     <li><a href="#descdef-viewport-height">descriptor for @viewport</a><span>, in §6.4</span>
    </ul>
   <li><a href="#initial-height">initial-height</a><span>, in §7.1</span>
   <li><a href="#initial-viewport">initial viewport</a><span>, in §4</span>
   <li><a href="#initial-width">initial-width</a><span>, in §7.1</span>
   <li><a href="#valdef-orientation-landscape">landscape</a><span>, in §6.9</span>
   <li><a href="#valdef-viewport-length-length">&lt;length></a><span>, in §6.1</span>
   <li><a href="#descdef-viewport-max-height">max-height</a><span>, in §6.3</span>
   <li><a href="#descdef-viewport-max-width">max-width</a><span>, in §6.1</span>
   <li><a href="#descdef-viewport-max-zoom">max-zoom</a><span>, in §6.7</span>
   <li><a href="#descdef-viewport-min-height">min-height</a><span>, in §6.3</span>
   <li><a href="#descdef-viewport-min-width">min-width</a><span>, in §6.1</span>
   <li><a href="#descdef-viewport-min-zoom">min-zoom</a><span>, in §6.6</span>
   <li><a href="#descdef-viewport-orientation">orientation</a><span>, in §6.9</span>
   <li><a href="#valdef-viewport-length-percentage">&lt;percentage></a><span>, in §6.1</span>
   <li><a href="#valdef-orientation-portrait">portrait</a><span>, in §6.9</span>
   <li><a href="#specifications-whose-evaluations-are-both-affected-by-the-same-changes-to-the-user-environment-and-so-always-must-be-evaluated-together-in-order-to-ensure-proper-rendering">Specifications whose evaluations are both affected by the same changes to the user environment, and so always must be evaluated together in order to ensure proper rendering.</a><span>, in §7.2</span>
   <li><a href="#dom-cssviewportrule-style">style</a><span>, in §9.2</span>
   <li><a href="#descdef-viewport-user-zoom">user-zoom</a><span>, in §6.8</span>
   <li><a href="#at-ruledef-viewport">@viewport</a><span>, in §5</span>
   <li><a href="#typedef-viewport-length">&lt;viewport-length></a><span>, in §6.1</span>
   <li><a href="#dom-cssrule-viewport_rule">VIEWPORT_RULE</a><span>, in §9.1</span>
   <li>
    width
    <ul>
     <li><a href="#width">definition of</a><span>, in §7.1</span>
     <li><a href="#descdef-viewport-width">descriptor for @viewport</a><span>, in §6.2</span>
    </ul>
   <li>
    zoom
    <ul>
     <li><a href="#descdef-viewport-zoom">descriptor for @viewport</a><span>, in §6.5</span>
     <li><a href="#valdef-user-zoom-zoom">value for user-zoom</a><span>, in §6.8</span>
    </ul>
  </ul>
  <aside class="dfn-panel" data-for="term-for-valdef-all-inherit">
   <a href="https://drafts.csswg.org/css-cascade-4/#valdef-all-inherit">https://drafts.csswg.org/css-cascade-4/#valdef-all-inherit</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-all-inherit">5. 
The @viewport rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-font-size">
   <a href="https://drafts.csswg.org/css-fonts-3/#propdef-font-size">https://drafts.csswg.org/css-fonts-3/#propdef-font-size</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-font-size">6. 
Viewport descriptors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-at-ruledef-page">
   <a href="https://drafts.csswg.org/css-page-3/#at-ruledef-page">https://drafts.csswg.org/css-page-3/#at-ruledef-page</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-at-ruledef-page">4. 
The viewport</a> <a href="#ref-for-at-ruledef-page①">(2)</a>
    <li><a href="#ref-for-at-ruledef-page②">5. 
The @viewport rule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-vh">
   <a href="https://drafts.csswg.org/css-values-4/#vh">https://drafts.csswg.org/css-values-4/#vh</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-vh">6. 
Viewport descriptors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-vmax">
   <a href="https://drafts.csswg.org/css-values-4/#vmax">https://drafts.csswg.org/css-values-4/#vmax</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-vmax">6. 
Viewport descriptors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-vmin">
   <a href="https://drafts.csswg.org/css-values-4/#vmin">https://drafts.csswg.org/css-values-4/#vmin</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-vmin">6. 
Viewport descriptors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-vw">
   <a href="https://drafts.csswg.org/css-values-4/#vw">https://drafts.csswg.org/css-values-4/#vw</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-vw">6. 
Viewport descriptors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-mult-num-range">
   <a href="https://drafts.csswg.org/css-values-4/#mult-num-range">https://drafts.csswg.org/css-values-4/#mult-num-range</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mult-num-range">6.2. 
The width shorthand descriptor</a>
    <li><a href="#ref-for-mult-num-range①">6.4. 
The height shorthand descriptor</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-comb-one">
   <a href="https://drafts.csswg.org/css-values-4/#comb-one">https://drafts.csswg.org/css-values-4/#comb-one</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-comb-one">6.1. 
The min-width and max-width descriptors</a> <a href="#ref-for-comb-one①">(2)</a>
    <li><a href="#ref-for-comb-one②">6.5. 
The zoom descriptor</a> <a href="#ref-for-comb-one③">(2)</a>
    <li><a href="#ref-for-comb-one④">6.6. 
The min-zoom descriptor</a> <a href="#ref-for-comb-one⑤">(2)</a>
    <li><a href="#ref-for-comb-one⑥">6.7. 
The max-zoom descriptor</a> <a href="#ref-for-comb-one⑦">(2)</a>
    <li><a href="#ref-for-comb-one⑧">6.8. 
The user-zoom descriptor</a>
    <li><a href="#ref-for-comb-one⑨">6.9. 
The orientation descriptor</a> <a href="#ref-for-comb-one①⓪">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-direction">
   <a href="https://drafts.csswg.org/css-writing-modes-3/#propdef-direction">https://drafts.csswg.org/css-writing-modes-3/#propdef-direction</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-direction">4. 
The viewport</a> <a href="#ref-for-propdef-direction①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-at-ruledef-media">
   <a href="https://drafts.csswg.org/css-conditional-3/#at-ruledef-media">https://drafts.csswg.org/css-conditional-3/#at-ruledef-media</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-at-ruledef-media">5.1. 
Syntax</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-at-ruledef-supports">
   <a href="https://drafts.csswg.org/css-conditional-3/#at-ruledef-supports">https://drafts.csswg.org/css-conditional-3/#at-ruledef-supports</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-at-ruledef-supports">5.1. 
Syntax</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-conditional-group-rules">
   <a href="https://www.w3.org/TR/css3-conditional/#conditional-group-rules">https://www.w3.org/TR/css3-conditional/#conditional-group-rules</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-conditional-group-rules">5.1. 
Syntax</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-nested_statement">
   <a href="https://www.w3.org/TR/css3-conditional/#nested_statement">https://www.w3.org/TR/css3-conditional/#nested_statement</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-nested_statement">5.1. 
Syntax</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-length-value">
   <a href="https://drafts.csswg.org/css-values-3/#length-value">https://drafts.csswg.org/css-values-3/#length-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-length-value">6.1. 
The min-width and max-width descriptors</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-number-value">
   <a href="https://drafts.csswg.org/css-values-3/#number-value">https://drafts.csswg.org/css-values-3/#number-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-number-value">6.5. 
The zoom descriptor</a> <a href="#ref-for-number-value①">(2)</a>
    <li><a href="#ref-for-number-value②">6.6. 
The min-zoom descriptor</a> <a href="#ref-for-number-value③">(2)</a>
    <li><a href="#ref-for-number-value④">6.7. 
The max-zoom descriptor</a> <a href="#ref-for-number-value⑤">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-percentage-value">
   <a href="https://drafts.csswg.org/css-values-3/#percentage-value">https://drafts.csswg.org/css-values-3/#percentage-value</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-percentage-value">6.1. 
The min-width and max-width descriptors</a>
    <li><a href="#ref-for-percentage-value①">6.5. 
The zoom descriptor</a> <a href="#ref-for-percentage-value②">(2)</a>
    <li><a href="#ref-for-percentage-value③">6.6. 
The min-zoom descriptor</a> <a href="#ref-for-percentage-value④">(2)</a>
    <li><a href="#ref-for-percentage-value⑤">6.7. 
The max-zoom descriptor</a> <a href="#ref-for-percentage-value⑥">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssrule">
   <a href="https://drafts.csswg.org/cssom-1/#cssrule">https://drafts.csswg.org/cssom-1/#cssrule</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssrule">9.1. 
Interface CSSRule</a>
    <li><a href="#ref-for-cssrule①">9.2. 
Interface CSSViewportRule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssstyledeclaration">
   <a href="https://drafts.csswg.org/cssom-1/#cssstyledeclaration">https://drafts.csswg.org/cssom-1/#cssstyledeclaration</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssstyledeclaration">9.2. 
Interface CSSViewportRule</a> <a href="#ref-for-cssstyledeclaration①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-descdef-media-device-aspect-ratio">
   <a href="https://drafts.csswg.org/mediaqueries-4/#descdef-media-device-aspect-ratio">https://drafts.csswg.org/mediaqueries-4/#descdef-media-device-aspect-ratio</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-media-device-aspect-ratio">8. 
Media Queries</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-Exposed">
   <a href="https://heycam.github.io/webidl/#Exposed">https://heycam.github.io/webidl/#Exposed</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Exposed">9.2. 
Interface CSSViewportRule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-unsigned-short">
   <a href="https://heycam.github.io/webidl/#idl-unsigned-short">https://heycam.github.io/webidl/#idl-unsigned-short</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-unsigned-short">9.1. 
Interface CSSRule</a>
   </ul>
  </aside>
  <h3 class="no-num no-ref heading settled" id="index-defined-elsewhere"><span class="content">Terms defined by reference</span><a class="self-link" href="#index-defined-elsewhere"></a></h3>
  <ul class="index">
   <li>
    <a data-link-type="biblio">[css-cascade-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-valdef-all-inherit" style="color:initial">inherit</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-fonts-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-font-size" style="color:initial">font-size</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-page-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-at-ruledef-page" style="color:initial">@page</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-values-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-vh" style="color:initial">vh</span>
     <li><span class="dfn-paneled" id="term-for-vmax" style="color:initial">vmax</span>
     <li><span class="dfn-paneled" id="term-for-vmin" style="color:initial">vmin</span>
     <li><span class="dfn-paneled" id="term-for-vw" style="color:initial">vw</span>
     <li><span class="dfn-paneled" id="term-for-mult-num-range" style="color:initial">{a,b}</span>
     <li><span class="dfn-paneled" id="term-for-comb-one" style="color:initial">|</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-writing-modes-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-direction" style="color:initial">direction</span>
    </ul>
   <li>
    <a data-link-type="biblio">[CSS3-CONDITIONAL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-at-ruledef-media" style="color:initial">@media</span>
     <li><span class="dfn-paneled" id="term-for-at-ruledef-supports" style="color:initial">@supports</span>
     <li><span class="dfn-paneled" id="term-for-conditional-group-rules" style="color:initial">conditional group rules</span>
     <li><span class="dfn-paneled" id="term-for-nested_statement" style="color:initial">nested_statement</span>
    </ul>
   <li>
    <a data-link-type="biblio">[CSS3VAL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-length-value" style="color:initial">&lt;length></span>
     <li><span class="dfn-paneled" id="term-for-number-value" style="color:initial">&lt;number></span>
     <li><span class="dfn-paneled" id="term-for-percentage-value" style="color:initial">&lt;percentage></span>
    </ul>
   <li>
    <a data-link-type="biblio">[cssom-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-cssrule" style="color:initial">CSSRule</span>
     <li><span class="dfn-paneled" id="term-for-cssstyledeclaration" style="color:initial">CSSStyleDeclaration</span>
    </ul>
   <li>
    <a data-link-type="biblio">[MEDIAQ]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-descdef-media-device-aspect-ratio" style="color:initial">device-aspect-ratio</span>
    </ul>
   <li>
    <a data-link-type="biblio">[WebIDL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-Exposed" style="color:initial">Exposed</span>
     <li><span class="dfn-paneled" id="term-for-idl-unsigned-short" style="color:initial">unsigned short</span>
    </ul>
  </ul>
  <h2 class="no-num no-ref heading settled" id="references"><span class="content">References</span><a class="self-link" href="#references"></a></h2>
  <h3 class="no-num no-ref heading settled" id="normative"><span class="content">Normative References</span><a class="self-link" href="#normative"></a></h3>
  <dl>
   <dt id="biblio-css-cascade-4">[CSS-CASCADE-4]
   <dd>Elika Etemad; Tab Atkins Jr.. <a href="https://www.w3.org/TR/css-cascade-4/">CSS Cascading and Inheritance Level 4</a>. 28 August 2018. CR. URL: <a href="https://www.w3.org/TR/css-cascade-4/">https://www.w3.org/TR/css-cascade-4/</a>
   <dt id="biblio-css-fonts-3">[CSS-FONTS-3]
   <dd>John Daggett; Myles Maxfield; Chris Lilley. <a href="https://www.w3.org/TR/css-fonts-3/">CSS Fonts Module Level 3</a>. 20 September 2018. REC. URL: <a href="https://www.w3.org/TR/css-fonts-3/">https://www.w3.org/TR/css-fonts-3/</a>
   <dt id="biblio-css-page-3">[CSS-PAGE-3]
   <dd>Elika Etemad; Simon Sapin. <a href="https://www.w3.org/TR/css-page-3/">CSS Paged Media Module Level 3</a>. 18 October 2018. WD. URL: <a href="https://www.w3.org/TR/css-page-3/">https://www.w3.org/TR/css-page-3/</a>
   <dt id="biblio-css-values-4">[CSS-VALUES-4]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-values-4/">CSS Values and Units Module Level 4</a>. 31 January 2019. WD. URL: <a href="https://www.w3.org/TR/css-values-4/">https://www.w3.org/TR/css-values-4/</a>
   <dt id="biblio-css-writing-modes-3">[CSS-WRITING-MODES-3]
   <dd>Elika Etemad; Koji Ishii. <a href="https://www.w3.org/TR/css-writing-modes-3/">CSS Writing Modes Level 3</a>. 10 December 2019. REC. URL: <a href="https://www.w3.org/TR/css-writing-modes-3/">https://www.w3.org/TR/css-writing-modes-3/</a>
   <dt id="biblio-css21">[CSS21]
   <dd>Bert Bos; et al. <a href="https://www.w3.org/TR/CSS2/">Cascading Style Sheets Level 2 Revision 1 (CSS 2.1) Specification</a>. 7 June 2011. REC. URL: <a href="https://www.w3.org/TR/CSS2/">https://www.w3.org/TR/CSS2/</a>
   <dt id="biblio-css3-conditional">[CSS3-CONDITIONAL]
   <dd>David Baron. <a href="https://www.w3.org/TR/css3-conditional/">CSS Conditional Rules Module Level 3</a>. 4 April 2013. CR. URL: <a href="https://www.w3.org/TR/css3-conditional/">https://www.w3.org/TR/css3-conditional/</a>
   <dt id="biblio-css3syn">[CSS3SYN]
   <dd>Tab Atkins Jr.; Simon Sapin. <a href="https://www.w3.org/TR/css-syntax-3/">CSS Syntax Module Level 3</a>. 16 July 2019. CR. URL: <a href="https://www.w3.org/TR/css-syntax-3/">https://www.w3.org/TR/css-syntax-3/</a>
   <dt id="biblio-css3val">[CSS3VAL]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-values-3/">CSS Values and Units Module Level 3</a>. 6 June 2019. CR. URL: <a href="https://www.w3.org/TR/css-values-3/">https://www.w3.org/TR/css-values-3/</a>
   <dt id="biblio-cssom-1">[CSSOM-1]
   <dd>Simon Pieters; Glenn Adams. <a href="https://www.w3.org/TR/cssom-1/">CSS Object Model (CSSOM)</a>. 17 March 2016. WD. URL: <a href="https://www.w3.org/TR/cssom-1/">https://www.w3.org/TR/cssom-1/</a>
   <dt id="biblio-mediaq">[MEDIAQ]
   <dd>Florian Rivoal; Tab Atkins Jr.. <a href="https://www.w3.org/TR/mediaqueries-4/">Media Queries Level 4</a>. 5 September 2017. CR. URL: <a href="https://www.w3.org/TR/mediaqueries-4/">https://www.w3.org/TR/mediaqueries-4/</a>
   <dt id="biblio-rfc2119">[RFC2119]
   <dd>S. Bradner. <a href="https://tools.ietf.org/html/rfc2119">Key words for use in RFCs to Indicate Requirement Levels</a>. March 1997. Best Current Practice. URL: <a href="https://tools.ietf.org/html/rfc2119">https://tools.ietf.org/html/rfc2119</a>
   <dt id="biblio-webidl">[WebIDL]
   <dd>Boris Zbarsky. <a href="https://heycam.github.io/webidl/">Web IDL</a>. 15 December 2016. ED. URL: <a href="https://heycam.github.io/webidl/">https://heycam.github.io/webidl/</a>
  </dl>
  <h3 class="no-num no-ref heading settled" id="informative"><span class="content">Informative References</span><a class="self-link" href="#informative"></a></h3>
  <dl>
   <dt id="biblio-algorithms">[Algorithms]
   <dd>Thomas H. Cormen; et al. Introduction to Algorithms, Second Edition, MIT Press. 
  </dl>
  <h2 class="no-num no-ref heading settled" id="property-index"><span class="content">Property Index</span><a class="self-link" href="#property-index"></a></h2>
  <p>No properties defined.</p>
  <h3 class="no-num no-ref heading settled" id="viewport-descriptor-table"><span class="content"><a class="css" data-link-type="at-rule" href="#at-ruledef-viewport" id="ref-for-at-ruledef-viewport④④">@viewport</a> Descriptors</span><a class="self-link" href="#viewport-descriptor-table"></a></h3>
  <div class="big-element-wrapper">
   <table class="index">
    <thead>
     <tr>
      <th scope="col">Name
      <th scope="col">Value
      <th scope="col">Initial
      <th scope="col">Computed value
      <th scope="col">Percentages
    <tbody>
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-viewport-height" id="ref-for-descdef-viewport-height">height</a>
      <td>&lt;viewport-length>{1,2}
      <td>See individual descriptors
      <td>See individual descriptors
      <td>See individual descriptors
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-viewport-max-height" id="ref-for-descdef-viewport-max-height">max-height</a>
      <td>&lt;viewport-length>
      <td>auto
      <td>auto, an absolute length, or a percentage as specified
      <td>Refer to the height of the initial viewport
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-viewport-max-width" id="ref-for-descdef-viewport-max-width">max-width</a>
      <td>&lt;viewport-length>
      <td>auto
      <td>auto, an absolute length, or a percentage as specified
      <td>Refer to the width of the initial viewport
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-viewport-max-zoom" id="ref-for-descdef-viewport-max-zoom⑤">max-zoom</a>
      <td>auto | &lt;number> | &lt;percentage>
      <td>auto
      <td>auto, or a non-negative number or percentage as specified
      <td>The zoom factor itself
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-viewport-min-height" id="ref-for-descdef-viewport-min-height">min-height</a>
      <td>&lt;viewport-length>
      <td>auto
      <td>auto, an absolute length, or a percentage as specified
      <td>Refer to the height of the initial viewport
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-viewport-min-width" id="ref-for-descdef-viewport-min-width">min-width</a>
      <td>&lt;viewport-length>
      <td>auto
      <td>auto, an absolute length, or a percentage as specified
      <td>Refer to the width of the initial viewport
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-viewport-min-zoom" id="ref-for-descdef-viewport-min-zoom④">min-zoom</a>
      <td>auto | &lt;number> | &lt;percentage>
      <td>auto
      <td>auto, or a non-negative number or percentage as specified
      <td>The zoom factor itself
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-viewport-orientation" id="ref-for-descdef-viewport-orientation①">orientation</a>
      <td>auto | portrait | landscape
      <td>auto
      <td>as specified
      <td>N/A
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-viewport-user-zoom" id="ref-for-descdef-viewport-user-zoom③">user-zoom</a>
      <td>zoom | fixed
      <td>zoom
      <td>as specified
      <td>N/A
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-viewport-width" id="ref-for-descdef-viewport-width">width</a>
      <td>&lt;viewport-length>{1,2}
      <td>See individual descriptors
      <td>See individual descriptors
      <td>See individual descriptors
     <tr>
      <th scope="row"><a class="css" data-link-type="descriptor" href="#descdef-viewport-zoom" id="ref-for-descdef-viewport-zoom①③">zoom</a>
      <td>auto | &lt;number> | &lt;percentage>
      <td>auto
      <td>auto, or a non-negative number or percentage as specified
      <td>The zoom factor itself
   </table>
  </div>
  <h2 class="no-num no-ref heading settled" id="idl-index"><span class="content">IDL Index</span><a class="self-link" href="#idl-index"></a></h2>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://drafts.csswg.org/cssom-1/#cssrule"><c- g>CSSRule</c-></a> {
    <c- b>const</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-short"><c- b>unsigned</c-> <c- b>short</c-></a> <a href="#dom-cssrule-viewport_rule"><code><c- g>VIEWPORT_RULE</c-></code></a> = 15;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="#cssviewportrule"><c- g>CSSViewportRule</c-></a> : <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssrule"><c- n>CSSRule</c-></a> {
    <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssstyledeclaration"><c- n>CSSStyleDeclaration</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSStyleDeclaration" href="#dom-cssviewportrule-style"><c- g>style</c-></a>;
};

</pre>
  <h2 class="no-num no-ref heading settled" id="issues-index"><span class="content">Issues Index</span><a class="self-link" href="#issues-index"></a></h2>
  <div style="counter-reset:issue">
   <div class="issue"> This specification is written from an implementation-centric point of view,
making it arguably difficult to read.
Significant editorial work may be needed
to make it more understandable to different audiences.
It also should clarify which viewport is referred to by various js APIs.
See <a href="http://www.quirksmode.org/blog/archives/2015/09/a_new_device_ad.html">this blog post by ppk</a> for a good discussion of these issues.<a href="#issue-6c09d247"> ↵ </a></div>
   <div class="issue"> Various issues about this specification and related specifications
are listed in <a href="https://www.w3.org/Graphics/SVG/WG/wiki/Proposals/Investigation_of_APIs_for_Level_of_detail#The_issues_on_existing_APIs">this report</a>.<a href="#issue-212a8da7"> ↵ </a></div>
   <div class="issue">"dbaron: The question is, what does this do on the desktop
browser? (And what’s a desktop browser)". Need to say that a "desktop"
browser typically have no UA styles, as opposed to the <a href="#ua-stylesheet">UA stylesheet</a> outlined for current mobile
behaviour, and that no UA styles for <a class="css" data-link-type="maybe" href="#at-ruledef-viewport">@viewport</a> will give "desktop"
behaviour per default (actual viewport is initial viewport).<a href="#issue-3cd9f731"> ↵ </a></div>
   <div class="issue">min- and max- functionality can be achieved with media queries, should these be removed?<a href="#issue-081c4ec9"> ↵ </a></div>
   <div class="issue">The user-agent stylesheets recommended in the informative section don’t adequately represent current implementation behaviors.  Should there be a more explicit mechanism for switching between UA default behavior and requesting the CSS pixel?<a href="#issue-7fbbd2b2"> ↵ </a></div>
  </div>
  <aside class="dfn-panel" data-for="at-ruledef-viewport">
   <b><a href="#at-ruledef-viewport">#at-ruledef-viewport</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-at-ruledef-viewport">4. 
The viewport</a> <a href="#ref-for-at-ruledef-viewport①">(2)</a>
    <li><a href="#ref-for-at-ruledef-viewport②">5. 
The @viewport rule</a> <a href="#ref-for-at-ruledef-viewport③">(2)</a> <a href="#ref-for-at-ruledef-viewport④">(3)</a> <a href="#ref-for-at-ruledef-viewport⑤">(4)</a> <a href="#ref-for-at-ruledef-viewport⑥">(5)</a> <a href="#ref-for-at-ruledef-viewport⑦">(6)</a> <a href="#ref-for-at-ruledef-viewport⑧">(7)</a>
    <li><a href="#ref-for-at-ruledef-viewport⑨">5.1. 
Syntax</a> <a href="#ref-for-at-ruledef-viewport①⓪">(2)</a>
    <li><a href="#ref-for-at-ruledef-viewport①①">6. 
Viewport descriptors</a>
    <li><a href="#ref-for-at-ruledef-viewport①②">6.1. 
The min-width and max-width descriptors</a> <a href="#ref-for-at-ruledef-viewport①③">(2)</a>
    <li><a href="#ref-for-at-ruledef-viewport①④">6.2. 
The width shorthand descriptor</a>
    <li><a href="#ref-for-at-ruledef-viewport①⑤">6.3. 
The min-height and max-height descriptors</a> <a href="#ref-for-at-ruledef-viewport①⑥">(2)</a>
    <li><a href="#ref-for-at-ruledef-viewport①⑦">6.4. 
The height shorthand descriptor</a>
    <li><a href="#ref-for-at-ruledef-viewport①⑧">6.5. 
The zoom descriptor</a>
    <li><a href="#ref-for-at-ruledef-viewport①⑨">6.6. 
The min-zoom descriptor</a>
    <li><a href="#ref-for-at-ruledef-viewport②⓪">6.7. 
The max-zoom descriptor</a>
    <li><a href="#ref-for-at-ruledef-viewport②①">6.8. 
The user-zoom descriptor</a>
    <li><a href="#ref-for-at-ruledef-viewport②②">6.9. 
The orientation descriptor</a>
    <li><a href="#ref-for-at-ruledef-viewport②③">8. 
Media Queries</a> <a href="#ref-for-at-ruledef-viewport②④">(2)</a> <a href="#ref-for-at-ruledef-viewport②⑤">(3)</a> <a href="#ref-for-at-ruledef-viewport②⑥">(4)</a> <a href="#ref-for-at-ruledef-viewport②⑦">(5)</a> <a href="#ref-for-at-ruledef-viewport②⑧">(6)</a> <a href="#ref-for-at-ruledef-viewport②⑨">(7)</a> <a href="#ref-for-at-ruledef-viewport③⓪">(8)</a> <a href="#ref-for-at-ruledef-viewport③①">(9)</a> <a href="#ref-for-at-ruledef-viewport③②">(10)</a>
    <li><a href="#ref-for-at-ruledef-viewport③③">9. 
CSSOM</a>
    <li><a href="#ref-for-at-ruledef-viewport③④">9.2. 
Interface CSSViewportRule</a> <a href="#ref-for-at-ruledef-viewport③⑤">(2)</a>
    <li><a href="#ref-for-at-ruledef-viewport③⑥">10. 
Viewport &lt;META> element</a>
    <li><a href="#ref-for-at-ruledef-viewport③⑦">10.4. 
Translation into @viewport descriptors</a> <a href="#ref-for-at-ruledef-viewport③⑧">(2)</a>
    <li><a href="#ref-for-at-ruledef-viewport③⑨"> The width
and height
properties</a> <a href="#ref-for-at-ruledef-viewport④⓪">(2)</a>
    <li><a href="#ref-for-at-ruledef-viewport④①"> The initial-scale, minimum-scale, and maximum-scale properties</a>
    <li><a href="#ref-for-at-ruledef-viewport④②"> The user-scalable property</a>
    <li><a href="#ref-for-at-ruledef-viewport④③">12. 
UA stylesheets</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedef-viewport-length">
   <b><a href="#typedef-viewport-length">#typedef-viewport-length</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedef-viewport-length">6.1. 
The min-width and max-width descriptors</a> <a href="#ref-for-typedef-viewport-length①">(2)</a>
    <li><a href="#ref-for-typedef-viewport-length②">6.2. 
The width shorthand descriptor</a> <a href="#ref-for-typedef-viewport-length③">(2)</a> <a href="#ref-for-typedef-viewport-length④">(3)</a>
    <li><a href="#ref-for-typedef-viewport-length⑤">6.3. 
The min-height and max-height descriptors</a> <a href="#ref-for-typedef-viewport-length⑥">(2)</a>
    <li><a href="#ref-for-typedef-viewport-length⑦">6.4. 
The height shorthand descriptor</a> <a href="#ref-for-typedef-viewport-length⑧">(2)</a> <a href="#ref-for-typedef-viewport-length⑨">(3)</a>
    <li><a href="#ref-for-typedef-viewport-length①⓪">10.3. extend-to-zoom</a>
    <li><a href="#ref-for-typedef-viewport-length①①">Appendix A. Changes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-viewport-length-auto">
   <b><a href="#valdef-viewport-length-auto">#valdef-viewport-length-auto</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-viewport-length-auto">7.1. 
Definitions</a>
    <li><a href="#ref-for-valdef-viewport-length-auto①"> Resolve non-auto lengths to pixel lengths</a>
    <li><a href="#ref-for-valdef-viewport-length-auto②"> Resolve initial width
and height from min/max
descriptors</a> <a href="#ref-for-valdef-viewport-length-auto③">(2)</a>
    <li><a href="#ref-for-valdef-viewport-length-auto④"> Resolve width value</a> <a href="#ref-for-valdef-viewport-length-auto⑤">(2)</a>
    <li><a href="#ref-for-valdef-viewport-length-auto⑥"> Resolve height value</a>
    <li><a href="#ref-for-valdef-viewport-length-auto⑦"> Resolving 'extend-to-zoom'</a> <a href="#ref-for-valdef-viewport-length-auto⑧">(2)</a>
    <li><a href="#ref-for-valdef-viewport-length-auto⑨">12.1. 
Large screen UA styles</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="descdef-viewport-zoom">
   <b><a href="#descdef-viewport-zoom">#descdef-viewport-zoom</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-viewport-zoom">6.5. 
The zoom descriptor</a> <a href="#ref-for-descdef-viewport-zoom①">(2)</a>
    <li><a href="#ref-for-descdef-viewport-zoom②">6.6. 
The min-zoom descriptor</a> <a href="#ref-for-descdef-viewport-zoom③">(2)</a> <a href="#ref-for-descdef-viewport-zoom④">(3)</a>
    <li><a href="#ref-for-descdef-viewport-zoom⑤">6.7. 
The max-zoom descriptor</a> <a href="#ref-for-descdef-viewport-zoom⑥">(2)</a> <a href="#ref-for-descdef-viewport-zoom⑦">(3)</a>
    <li><a href="#ref-for-descdef-viewport-zoom⑧"> The width
and height
properties</a>
    <li><a href="#ref-for-descdef-viewport-zoom⑨">11. 
Handling auto for zoom</a> <a href="#ref-for-descdef-viewport-zoom①⓪">(2)</a> <a href="#ref-for-descdef-viewport-zoom①①">(3)</a>
    <li><a href="#ref-for-descdef-viewport-zoom①②">Appendix A. Changes</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-zoom-auto">
   <b><a href="#valdef-zoom-auto">#valdef-zoom-auto</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-zoom-auto">6.5. 
The zoom descriptor</a>
    <li><a href="#ref-for-valdef-zoom-auto①">6.6. 
The min-zoom descriptor</a> <a href="#ref-for-valdef-zoom-auto②">(2)</a>
    <li><a href="#ref-for-valdef-zoom-auto③">6.7. 
The max-zoom descriptor</a> <a href="#ref-for-valdef-zoom-auto④">(2)</a>
    <li><a href="#ref-for-valdef-zoom-auto⑤">7.1. 
Definitions</a> <a href="#ref-for-valdef-zoom-auto⑥">(2)</a> <a href="#ref-for-valdef-zoom-auto⑦">(3)</a>
    <li><a href="#ref-for-valdef-zoom-auto⑧"> Resolve min-zoom
and max-zoom values</a> <a href="#ref-for-valdef-zoom-auto⑨">(2)</a>
    <li><a href="#ref-for-valdef-zoom-auto①⓪"> Constrain zoom value to
the [min-zoom, max-zoom] range</a>
    <li><a href="#ref-for-valdef-zoom-auto①①"> Resolving 'extend-to-zoom'</a> <a href="#ref-for-valdef-zoom-auto①②">(2)</a> <a href="#ref-for-valdef-zoom-auto①③">(3)</a>
    <li><a href="#ref-for-valdef-zoom-auto①④"> The width
and height
properties</a>
    <li><a href="#ref-for-valdef-zoom-auto①⑤">11. 
Handling auto for zoom</a> <a href="#ref-for-valdef-zoom-auto①⑥">(2)</a> <a href="#ref-for-valdef-zoom-auto①⑦">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="descdef-viewport-min-zoom">
   <b><a href="#descdef-viewport-min-zoom">#descdef-viewport-min-zoom</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-viewport-min-zoom">6.6. 
The min-zoom descriptor</a>
    <li><a href="#ref-for-descdef-viewport-min-zoom①">10.3. extend-to-zoom</a>
    <li><a href="#ref-for-descdef-viewport-min-zoom②"> The initial-scale, minimum-scale, and maximum-scale properties</a> <a href="#ref-for-descdef-viewport-min-zoom③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="descdef-viewport-max-zoom">
   <b><a href="#descdef-viewport-max-zoom">#descdef-viewport-max-zoom</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-viewport-max-zoom">6.7. 
The max-zoom descriptor</a>
    <li><a href="#ref-for-descdef-viewport-max-zoom①">10.3. extend-to-zoom</a>
    <li><a href="#ref-for-descdef-viewport-max-zoom②"> The initial-scale, minimum-scale, and maximum-scale properties</a> <a href="#ref-for-descdef-viewport-max-zoom③">(2)</a> <a href="#ref-for-descdef-viewport-max-zoom④">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="descdef-viewport-user-zoom">
   <b><a href="#descdef-viewport-user-zoom">#descdef-viewport-user-zoom</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-viewport-user-zoom">6.7. 
The max-zoom descriptor</a>
    <li><a href="#ref-for-descdef-viewport-user-zoom①">6.8. 
The user-zoom descriptor</a>
    <li><a href="#ref-for-descdef-viewport-user-zoom②"> The user-scalable property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-user-zoom-zoom">
   <b><a href="#valdef-user-zoom-zoom">#valdef-user-zoom-zoom</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-user-zoom-zoom"> The user-scalable property</a> <a href="#ref-for-valdef-user-zoom-zoom①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-user-zoom-fixed">
   <b><a href="#valdef-user-zoom-fixed">#valdef-user-zoom-fixed</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-user-zoom-fixed"> The user-scalable property</a> <a href="#ref-for-valdef-user-zoom-fixed①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="descdef-viewport-orientation">
   <b><a href="#descdef-viewport-orientation">#descdef-viewport-orientation</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-descdef-viewport-orientation">6.9. 
The orientation descriptor</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="cssviewportrule">
   <b><a href="#cssviewportrule">#cssviewportrule</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssviewportrule">9.2. 
Interface CSSViewportRule</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-cssviewportrule-style">
   <b><a href="#dom-cssviewportrule-style">#dom-cssviewportrule-style</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-cssviewportrule-style">9.2. 
Interface CSSViewportRule</a>
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
            </script><a class='link-error' href='/bikeshed/css-device-adapt/' id='generator' title='Bikeshed Link Errors'><svg height='24' viewbox='0 0 100 100' width='24'><g stroke="blue" stroke-width="6" fill="none"><path fill="blue" stroke="none" d="M 5 95 L 5 35 L 50 10 L 50 95"/><path d="M 1 37 L 54 8"/><path fill="blue" stroke="none" d="M 1 40 v -6 l 60 -32 v 6 z" /><circle cx="75" cy="79" r="15" /><circle fill="blue" stroke="none" cx="75" cy="79" r="4" /><path d="M 75 79 L 65 49 L 55 49" /><path d="M 67 55 L 48 69" /></g></svg></a>