<!doctype html><html lang="en">
 <head>
  <meta content="text/html; charset=utf-8" http-equiv="Content-Type">
  <title>CSSOM View Module</title>
  <meta content="width=device-width, initial-scale=1, shrink-to-fit=no" name="viewport">
  <meta content="revising" name="csswg-work-status">
  <meta content="ED" name="w3c-status">
  <meta content="The APIs introduced by this specification provide authors with a way to inspect and manipulate the visual view of a document. This includes getting the position of element layout boxes, obtaining the width of the viewport through script, and also scrolling an element." name="abstract">
  <link href="../default.css" rel="stylesheet" type="text/css">
  <link href="../csslogo.ico" rel="shortcut icon" type="image/x-icon">
<style>
  body {
    background: url("https://www.w3.org/StyleSheets/TR/logo-ED") top left no-repeat;
  }
  </style>
  <meta content="Bikeshed version d4d56a96, updated Fri Apr 10 11:10:34 2020 -0700" name="generator">
  <link href="https://www.w3.org/TR/cssom-view-1/" rel="canonical">
<script defer src="https://test.csswg.org/harness/annotate.js#!cssom-view-1_dev/cssom-view-1" type="text/javascript"></script>
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
<style>/* style-caniuse-panel */

            .caniuse-status { font: 1em sans-serif; width: 9em; padding: 0.3em; position: absolute; z-index: 8; top: auto; right: 0.3em; background: #EEE; color: black; box-shadow: 0 0 3px #999; overflow: hidden; border-collapse: initial; border-spacing: initial; }
            .caniuse-status.wrapped { width: 1em; height: 1em; }
            .caniuse-status.wrapped > :not(input) { display: none; }
            .caniuse-status > input { position: absolute; right: 0; top: 0; width: 1em; height: 1em; border: none; background: transparent; padding: 0; margin: 0; }
            .caniuse-status > p { font-size: 0.6em; margin: 0; padding: 0; }
            .caniuse-status > p + p { padding-top: 0.5em; }
            .caniuse-status > .support { display: block; }
            .caniuse-status > .support > span { padding: 0.2em 0; display: block; display: table; }
            .caniuse-status > .support > span.partial { color: #666666; filter: grayscale(50%); }
            .caniuse-status > .support > span.no { color: #CCCCCC; filter: grayscale(100%); }
            .canisue-status > .support > span.no::before { opacity: 0.5; }
            .caniuse-status > .support > span:first-of-type { padding-top: 0.5em; }
            .caniuse-status > .support > span > span { padding: 0 0.5em; display: table-cell; vertical-align: top; }
            .caniuse-status > .support > span > span:first-child { width: 100%; }
            .caniuse-status > .support > span > span:last-child { width: 100%; white-space: pre; padding: 0; }
            .caniuse-status > .support > span::before { content: ' '; display: table-cell; min-width: 1.5em; height: 1.5em; background: no-repeat center center; background-size: contain; text-align: right; font-size: 0.75em; font-weight: bold; }
            .caniuse-status > .support > .and_chr::before { background-image: url(https://resources.whatwg.org/browser-logos/chrome.svg); }
            .caniuse-status > .support > .and_ff::before { background-image: url(https://resources.whatwg.org/browser-logos/firefox.png); }
            .caniuse-status > .support > .and_uc::before { background-image: url(https://resources.whatwg.org/browser-logos/uc.png); } /* UC Browser for Android */
            .caniuse-status > .support > .android::before { background-image: url(https://resources.whatwg.org/browser-logos/android.svg); }
            .caniuse-status > .support > .bb::before { background-image: url(https://resources.whatwg.org/browser-logos/bb.jpg); } /* Blackberry Browser */
            .caniuse-status > .support > .chrome::before { background-image: url(https://resources.whatwg.org/browser-logos/chrome.svg); }
            .caniuse-status > .support > .edge::before { background-image: url(https://resources.whatwg.org/browser-logos/edge.svg); }
            .caniuse-status > .support > .firefox::before { background-image: url(https://resources.whatwg.org/browser-logos/firefox.png); }
            .caniuse-status > .support > .ie::before { background-image: url(https://resources.whatwg.org/browser-logos/ie.png); }
            .caniuse-status > .support > .ie_mob::before { background-image: url(https://resources.whatwg.org/browser-logos/ie-mobile.svg); }
            .caniuse-status > .support > .ios_saf::before { background-image: url(https://resources.whatwg.org/browser-logos/safari-ios.svg); }
            .caniuse-status > .support > .op_mini::before { background-image: url(https://resources.whatwg.org/browser-logos/opera-mini.png); }
            .caniuse-status > .support > .op_mob::before { background-image: url(https://resources.whatwg.org/browser-logos/opera.svg); }
            .caniuse-status > .support > .opera::before { background-image: url(https://resources.whatwg.org/browser-logos/opera.svg); }
            .caniuse-status > .support > .safari::before { background-image: url(https://resources.whatwg.org/browser-logos/safari.png); }
            .caniuse-status > .support > .samsung::before { background-image: url(https://resources.whatwg.org/browser-logos/samsung.svg); }
            .caniuse-status > .caniuse { text-align: right; font-style: italic; }
            @media (max-width: 767px) {
                .caniuse-status.wrapped { width: 9em; height: auto; }
                .caniuse-status:not(.wrapped) { width: 1em; height: 1em; }
                .caniuse-status.wrapped > :not(input) { display: block; }
                .caniuse-status:not(.wrapped) > :not(input) { display: none; }
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
 <script nonce='rSkR7SH6p3l+43qf41ZWla9XviOsMPEk/4edf4v21gg=' type='text/javascript'><!--
Stream=function(uri,params,callback){this.xhr=new XMLHttpRequest();this.callback=callback;this.persist=false;if(!params){params={};}var loginKey=system.getCookie('loginkey');if(loginKey){params['loginkey']=loginKey;}params['stream']=++this.gStreamId;this.uri=(params ?uri+'?'+system.encodeParams(params):uri);var stream=this;this.xhr.onreadystatechange=function(){if((200==stream.xhr.status)&&((3==stream.xhr.readyState)||(4==stream.xhr.readyState))){var message=stream.xhr.responseText.substring(stream.processed);if(-1!=message.indexOf("\uEE00\uEEFF\uEE00")){var messages=message.split("\uEE00\uEEFF\uEE00");for(var index=0;index<(messages.length-1);index++){message=messages[index];stream.processed+=(message.length+3);try{response=JSON.parse(message.trim());}catch(err){console.log("stream parse error: "+message.trim());console.log(err);continue;}stream.callback(response.message,response.data);}}if(4==stream.xhr.readyState){if(stream.persist&&(!stream.closed)){setTimeout(function(){if(!stream.closed){stream.connect();}},10);}stream.closed=true;}}};this.connect();return this;};Stream.prototype={gStreamId:Math.floor(Math.random()*0xFFFFFFFF),connect:function(){this.processed=0;this.closed=false;this.xhr.open('GET',this.uri,true);this.xhr.setRequestHeader('Accept','application/json');this.xhr.send();},close:function(){this.closed=true;if((4!=this.xhr.readyState)&&(0!=this.xhr.readyState)){this.xhr.abort();}},setTimeout:function(callback,timeoutMS){this.xhr.timeout=timeoutMS;var stream=this;this.xhr.ontimeout=function(){stream.closed=true;callback(stream);};},};
// --></script><script nonce='rSkR7SH6p3l+43qf41ZWla9XviOsMPEk/4edf4v21gg=' type='text/javascript'><!--
var gDraftAPIURI="https:\/\/drafts.csswg.org\/api\/drafts\/";var gCookiePrefix="drafts_";var gRepo="csswg";var gDate=false;var gBranch=null;var gHead=null;var gRepoPath="cssom-view-1\/Overview.bs";if(!Array.indexOf){Array.prototype.indexOf=function(obj){for(var index=0;index<this.length;index++){if(this[index]==obj){return index;}}return-1;}}if(!Date.now){Date.now=function(){return new Date().getTime();}}try{if(1!=Node.ELEMENT_NODE){throw true;}}catch(exc){var Node={ELEMENT_NODE:1,ATTRIBUTE_NODE:2,TEXT_NODE:3};}var system={getCookie:function(name){var cookies=document.cookie.split(';');name+='=';var prefixedName=gCookiePrefix+name;for(var index=0;index<cookies.length;index++){cookie=cookies[index].trim();if(prefixedName==cookie.substring(0,prefixedName.length)){return unescape(cookie.substring(prefixedName.length));}if(name==cookie.substring(0,name.length)){return unescape(cookie.substring(name.length));}}return null;},encodeParams:function(params,arrayName){var paramString='';for(param in params){if(params.hasOwnProperty(param)){if(paramString){paramString+='&';}var name=param;if(arrayName){name=arrayName+'['+param+']';}if(Array.isArray(params[param])){for(var index=0;index<params[param].length;index++){paramString+=name+'[]='+params[param][index];}}else if('object'==typeof(params[param])){paramString+=this.encodeParams(params[param],param);}else if('boolean'==typeof(params[param])){paramString+=name+'='+(params[param]+0);}else{paramString+=name+'='+encodeURIComponent(params[param]);}}}return paramString;},addLoadEvent:function(onLoad){try{var oldOnLoad=window.onload;if('function'!=typeof(window.onload)){window.onload=onLoad;}else{window.onload=function(){if(oldOnLoad){oldOnLoad();}onLoad();}}}catch(err){}}};var updateCount=0;var maxStreamListenTime=5*60*1000;var minStreamListenTime=10*1000;var streamInterval=20*60*1000;var streamListenTime=maxStreamListenTime;var streamStartTime=0;function updateBikeshed(message,data){var bikeshedIcon=document.getElementById('bikeshed');if(bikeshedIcon){bikeshedIcon.setAttribute('class',data.status);switch(data.status){case'pending':case'generating':bikeshedIcon.setAttribute('title','Bikeshed Pending');break;case'success':bikeshedIcon.setAttribute('title','Bikeshed Succeeded');break;case'warning':bikeshedIcon.setAttribute('title','Bikeshed Warnings');break;case'fatal':bikeshedIcon.setAttribute('title','Bikeshed Errors');break;case'previous':case'error':bikeshedIcon.setAttribute('title','Bikeshed Failed');break;}}updateCount++;if((1<updateCount)||(gDate&&(data.date!=gDate))){streamListenTime=maxStreamListenTime;gUpdateStream.setTimeout(streamTimeout,(Date.now()-streamStartTime)+streamListenTime);if((gDate<data.date)&&(('committed'==data.status)||('success'==data.status)||('warning'==data.status))){window.location.reload();}}gDate=data.date;}function streamTimeout(stream){streamListenTime=minStreamListenTime;setTimeout(function(){startStream();},streamInterval);}function startStream(){updateCount=0;streamStartTime=Date.now();gUpdateStream=new Stream(gDraftAPIURI,{'repo':gRepo,'date':gDate,'branch':gBranch,'head':gHead,'path':gRepoPath},updateBikeshed);gUpdateStream.persist=true;gUpdateStream.setTimeout(streamTimeout,streamListenTime);}function setupPage(){var bikeshedIcon=document.getElementById('bikeshed');if(bikeshedIcon){bikeshedIcon.onclick=function(domEvent){if(domEvent.shiftKey){var url=bikeshedIcon.getAttribute('href').replace('/bikeshed/','/static/')+window.location.hash;window.location.href=url;if(domEvent){(domEvent.preventDefault)?domEvent.preventDefault():domEvent.returnValue=false;}}};}startStream();}system.addLoadEvent(setupPage);
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
   <h1 class="p-name no-ref" id="title">CSSOM View Module</h1>
   <h2 class="no-num no-toc no-ref heading settled" id="subtitle"><span class="content">Editor’s Draft, <time class="dt-updated" datetime="2020-02-20">20 February 2020</time></span></h2>
   <details>
    <summary>Specification Metadata</summary>
    <div data-fill-with="spec-metadata">
     <dl>
      <dt>This version:
      <dd><a class="u-url" href="https://drafts.csswg.org/cssom-view/">https://drafts.csswg.org/cssom-view/</a>
      <dt>Latest published version:
      <dd><a href="https://www.w3.org/TR/cssom-view-1/">https://www.w3.org/TR/cssom-view-1/</a>
      <dt>Previous Versions:
      <dd><a href="https://www.w3.org/TR/2016/WD-cssom-view-1-20160317/" rel="prev">https://www.w3.org/TR/2016/WD-cssom-view-1-20160317/</a>
      <dd><a href="https://www.w3.org/TR/2013/WD-cssom-view-20131217/" rel="prev">https://www.w3.org/TR/2013/WD-cssom-view-20131217/</a>
      <dd><a href="https://www.w3.org/TR/2011/WD-cssom-view-20110804/" rel="prev">https://www.w3.org/TR/2011/WD-cssom-view-20110804/</a>
      <dd><a href="https://www.w3.org/TR/2009/WD-cssom-view-20090804/" rel="prev">https://www.w3.org/TR/2009/WD-cssom-view-20090804/</a>
      <dd><a href="https://www.w3.org/TR/2008/WD-cssom-view-20080222/" rel="prev">https://www.w3.org/TR/2008/WD-cssom-view-20080222/</a>
      <dd><a href="https://www.w3.org/TR/2000/REC-DOM-Level-2-Style-20001113/" rel="prev">https://www.w3.org/TR/2000/REC-DOM-Level-2-Style-20001113/</a>
      <dt>Test Suite:
      <dd><a href="http://test.csswg.org/suites/cssom-view-1_dev/nightly-unstable/">http://test.csswg.org/suites/cssom-view-1_dev/nightly-unstable/</a>
      <dt>Issue Tracking:
      <dd><a href="#issues-index">Inline In Spec</a>
      <dd><a href="https://github.com/w3c/csswg-drafts/labels/cssom-view-1">GitHub Issues</a>
      <dt class="editor">Editor:
      <dd class="editor p-author h-card vcard" data-editor-id="44066"><a class="p-name fn u-email email" href="mailto:simon.fraser@apple.com">Simon Fraser</a> (<a class="p-org org" href="http://www.apple.com/">Apple Inc</a>)
      <dt class="editor">Former Editors:
      <dd class="editor p-author h-card vcard"><a class="p-name fn u-email email" href="mailto:simonp@opera.com">Simon Pieters</a> (<a class="p-org org" href="http://www.opera.com">Opera Software AS</a>)
      <dd class="editor p-author h-card vcard"><a class="p-name fn u-url url" href="http://www.w3.org/wiki/User:Gadams">Glenn Adams</a> (<a class="p-org org" href="http://www.cox.com">Cox Communications, Inc.</a>) <a class="u-email email" href="mailto:glenn.adams@cos.com">glenn.adams@cos.com</a>
      <dd class="editor p-author h-card vcard"><a class="p-name fn u-url url" href="https://annevankesteren.nl/">Anne van Kesteren</a> (<a class="p-org org" href="http://www.opera.com">Opera Software ASA</a>) <a class="u-email email" href="mailto:annevk@annevk.nl">annevk@annevk.nl</a>
      <dt>Suggest an Edit for this Spec:
      <dd><a href="https://github.com/w3c/csswg-drafts/blob/master/cssom-view-1/Overview.bs">GitHub Editor</a>
      <dt>Legacy issues list:
      <dd><a href="https://www.w3.org/Bugs/Public/buglist.cgi?product=CSS&amp;component=CSSOM%20View&amp;resolution=---">Bugzilla</a>
     </dl>
    </div>
   </details>
   <div data-fill-with="warning"></div>
   <p class="copyright" data-fill-with="copyright"><a href="https://www.w3.org/Consortium/Legal/ipr-notice#Copyright">Copyright</a> © 2020 <a href="https://www.w3.org/"><abbr title="World Wide Web Consortium">W3C</abbr></a><sup>®</sup> (<a href="https://www.csail.mit.edu/"><abbr title="Massachusetts Institute of Technology">MIT</abbr></a>, <a href="https://www.ercim.eu/"><abbr title="European Research Consortium for Informatics and Mathematics">ERCIM</abbr></a>, <a href="https://www.keio.ac.jp/">Keio</a>, <a href="https://ev.buaa.edu.cn/">Beihang</a>). W3C <a href="https://www.w3.org/Consortium/Legal/ipr-notice#Legal_Disclaimer">liability</a>, <a href="https://www.w3.org/Consortium/Legal/ipr-notice#W3C_Trademarks">trademark</a> and <a href="https://www.w3.org/Consortium/Legal/2015/copyright-software-and-document">permissive document license</a> rules apply. </p>
   <hr title="Separator for header">
  </div>
  <div class="p-summary" data-fill-with="abstract">
   <h2 class="no-num no-toc no-ref heading settled" id="abstract"><span class="content">Abstract</span></h2>
   <p>The APIs introduced by this specification provide authors with a way to inspect and manipulate the visual view of a document. This includes getting the position of element layout boxes, obtaining the width of the viewport through script, and also scrolling an element.</p>
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
	When filing an issue, please put the text “cssom-view” in the title,
	preferably like this:
	“[cssom-view] <i data-lt>…summary of comment…</i>”.
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
    <li><a href="#background"><span class="secno">1</span> <span class="content">Background</span></a>
    <li>
     <a href="#terminology"><span class="secno">2</span> <span class="content">Terminology</span></a>
     <ol class="toc">
      <li><a href="#css-pixels"><span class="secno">2.1</span> <span class="content">CSS pixels</span></a>
      <li><a href="#zooming"><span class="secno">2.2</span> <span class="content">Zooming</span></a>
      <li><a href="#web-exposed-screen-information"><span class="secno">2.3</span> <span class="content">Web-exposed screen information</span></a>
     </ol>
    <li>
     <a href="#common-infrastructure"><span class="secno">3</span> <span class="content">Common Infrastructure</span></a>
     <ol class="toc">
      <li><a href="#scrolling"><span class="secno">3.1</span> <span class="content">Scrolling</span></a>
      <li><a href="#webidl-values"><span class="secno">3.2</span> <span class="content">WebIDL values</span></a>
     </ol>
    <li>
     <a href="#extensions-to-the-window-interface"><span class="secno">4</span> <span class="content">Extensions to the <code class="idl"><span>Window</span></code> Interface</span></a>
     <ol class="toc">
      <li><a href="#the-features-argument-to-the-open()-method"><span class="secno">4.1</span> <span class="content">The <var>features</var> argument to the <code class="idl"><span>open()</span></code> method</span></a>
      <li>
       <a href="#the-mediaquerylist-interface"><span class="secno">4.2</span> <span class="content">The <code class="idl"><span>MediaQueryList</span></code> Interface</span></a>
       <ol class="toc">
        <li><a href="#mediaquerylist-event-summary"><span class="secno">4.2.1</span> <span class="content">Event summary</span></a>
       </ol>
      <li><a href="#the-screen-interface"><span class="secno">4.3</span> <span class="content">The <code class="idl"><span>Screen</span></code> Interface</span></a>
     </ol>
    <li>
     <a href="#extensions-to-the-document-interface"><span class="secno">5</span> <span class="content">Extensions to the <code class="idl"><span>Document</span></code> Interface</span></a>
     <ol class="toc">
      <li><a href="#the-caretposition-interface"><span class="secno">5.1</span> <span class="content">The <code class="idl"><span>CaretPosition</span></code> Interface</span></a>
     </ol>
    <li>
     <a href="#extension-to-the-element-interface"><span class="secno">6</span> <span class="content">Extensions to the <code class="idl"><span>Element</span></code> Interface</span></a>
     <ol class="toc">
      <li><a href="#element-scrolling-members"><span class="secno">6.1</span> <span class="content"><code class="idl"><span>Element</span></code> Scrolling Members</span></a>
     </ol>
    <li><a href="#extensions-to-the-htmlelement-interface"><span class="secno">7</span> <span class="content">Extensions to the <code class="idl"><span>HTMLElement</span></code> Interface</span></a>
    <li><a href="#extensions-to-the-htmlimageelement-interface"><span class="secno">8</span> <span class="content">Extensions to the <code class="idl"><span>HTMLImageElement</span></code> Interface</span></a>
    <li><a href="#extensions-to-the-range-interface"><span class="secno">9</span> <span class="content">Extensions to the <code class="idl"><span>Range</span></code> Interface</span></a>
    <li><a href="#extensions-to-the-mouseevent-interface"><span class="secno">10</span> <span class="content">Extensions to the <code class="idl"><span>MouseEvent</span></code> Interface</span></a>
    <li>
     <a href="#geometry"><span class="secno">11</span> <span class="content">Geometry</span></a>
     <ol class="toc">
      <li><a href="#the-geometryutils-interface"><span class="secno">11.1</span> <span class="content">The <code class="idl"><span>GeometryUtils</span></code> Interface</span></a>
     </ol>
    <li>
     <a href="#events"><span class="secno">12</span> <span class="content">Events</span></a>
     <ol class="toc">
      <li><a href="#resizing-viewports"><span class="secno">12.1</span> <span class="content">Resizing viewports</span></a>
      <li><a href="#scrolling-events"><span class="secno">12.2</span> <span class="content">Scrolling</span></a>
      <li><a href="#event-summary"><span class="secno">12.3</span> <span class="content">Event summary</span></a>
     </ol>
    <li>
     <a href="#css-properties"><span class="secno">13</span> <span class="content">CSS properties</span></a>
     <ol class="toc">
      <li><a href="#smooth-scrolling"><span class="secno">13.1</span> <span class="content">Smooth Scrolling: The <span class="property">scroll-behavior</span> Property</span></a>
     </ol>
    <li>
     <a href="#change-history"><span class="secno"></span> <span class="content">Change History</span></a>
     <ol class="toc">
      <li><a href="#changes-from-2020-01-31"><span class="secno"></span> <span class="content">Changes From 31 January 2020</span></a>
      <li><a href="#changes-from-2013-12-17"><span class="secno"></span> <span class="content">Changes From 17 December 2013 To 31 January 2020</span></a>
      <li><a href="#changes-from-2011-08-04"><span class="secno"></span> <span class="content">Changes From 4 August 2011 To 17 December 2013</span></a>
     </ol>
    <li><a href="#acks"><span class="secno"></span> <span class="content">Acknowledgments</span></a>
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
    <li><a href="#issues-index"><span class="secno"></span> <span class="content">Issues Index</span></a>
   </ol>
  </nav>
  <main>
<script async data-file-issue-url="https://github.com/w3c/csswg-drafts/issues/new?title=%5Bcssom-view%5D%20" src="https://resources.whatwg.org/file-issue.js"></script>
   <h2 class="heading settled" data-level="1" id="background"><span class="secno">1. </span><span class="content">Background</span><a class="self-link" href="#background"></a></h2>
   <p>Many of the features defined in this specification have been supported
by browsers for a long period of time. The goal of this specification is
to define these features in such a way that they can be implemented by all
browsers in an interoperable manner. The specification also defines a
couple of new features that will hopefully be useful to authors. (If they
are not you can bug us!)</p>
   <h2 class="heading settled" data-level="2" id="terminology"><span class="secno">2. </span><span class="content">Terminology</span><a class="self-link" href="#terminology"></a></h2>
   <p>Terminology used in this specification is from
DOM,
CSSOM and
HTML. <a data-link-type="biblio" href="#biblio-dom">[DOM]</a> <a data-link-type="biblio" href="#biblio-cssom">[CSSOM]</a> <a data-link-type="biblio" href="#biblio-html">[HTML]</a></p>
   <p><dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="the-html-body-element">The HTML <code>body</code> element</dfn> is the first <code>body</code> <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#html-elements" id="ref-for-html-elements">HTML element</a> child of the root <span id="ref-for-html-elements①">HTML element</span> <code>html</code>.</p>
   <p><dfn data-dfn-type="dfn" data-noexport id="content-edge">Content edge<a class="self-link" href="#content-edge"></a></dfn>, <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="padding-edge">padding edge</dfn>, <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="border-edge">border edge</dfn>, <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="margin-edge">margin edge</dfn>, and <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="viewport">viewport</dfn> are defined by CSS.</p>
   <p>Elements and <a data-link-type="dfn" href="#viewport" id="ref-for-viewport">viewports</a> have an associated <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="scrolling-box">scrolling box</dfn> if has a scrolling mechanism or it overflows
its content area and the used value of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-overflow-3/#propdef-overflow-x" id="ref-for-propdef-overflow-x">overflow-x</a> or <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-overflow-3/#propdef-overflow-y" id="ref-for-propdef-overflow-y">overflow-y</a> property is <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-overflow-3/#valdef-overflow-hidden" id="ref-for-valdef-overflow-hidden">hidden</a>. <a data-link-type="biblio" href="#biblio-css3-box">[CSS3-BOX]</a></p>
   <p>An element <var>body</var> (which will be <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element">the HTML <code>body</code> element</a>) is <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="potentially-scrollable">potentially scrollable</dfn> if all of the following conditions are true:</p>
   <ul>
    <li data-md>
     <p><var>body</var> has an associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box">CSS layout box</a>.</p>
    <li data-md>
     <p><var>body</var>’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#parent-element" id="ref-for-parent-element">parent element</a>’s computed value of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-overflow-3/#propdef-overflow-x" id="ref-for-propdef-overflow-x①">overflow-x</a> or <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-overflow-3/#propdef-overflow-y" id="ref-for-propdef-overflow-y①">overflow-y</a> properties is neither <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-overflow-3/#valdef-overflow-visible" id="ref-for-valdef-overflow-visible">visible</a> nor <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-overflow-3/#valdef-overflow-clip" id="ref-for-valdef-overflow-clip">clip</a>.</p>
    <li data-md>
     <p><var>body</var>’s computed value of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-overflow-3/#propdef-overflow-x" id="ref-for-propdef-overflow-x②">overflow-x</a> or <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-overflow-3/#propdef-overflow-y" id="ref-for-propdef-overflow-y②">overflow-y</a> properties is neither <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-overflow-3/#valdef-overflow-visible" id="ref-for-valdef-overflow-visible①">visible</a> nor <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-overflow-3/#valdef-overflow-clip" id="ref-for-valdef-overflow-clip①">clip</a>.</p>
   </ul>
   <p class="note" role="note"><span>Note:</span> A <code><a data-link-type="element" href="https://html.spec.whatwg.org/multipage/sections.html#the-body-element" id="ref-for-the-body-element">body</a></code> element that is <a data-link-type="dfn" href="#potentially-scrollable" id="ref-for-potentially-scrollable">potentially scrollable</a> might not have a <a data-link-type="dfn" href="#scrolling-box" id="ref-for-scrolling-box">scrolling box</a>.
For instance, it could have a used value of <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-overflow-3/#propdef-overflow" id="ref-for-propdef-overflow">overflow</a> being <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-overflow-3/#valdef-overflow-auto" id="ref-for-valdef-overflow-auto">auto</a> but not have its content overflowing its content area.</p>
   <p>A <a data-link-type="dfn" href="#scrolling-box" id="ref-for-scrolling-box①">scrolling box</a> of a <a data-link-type="dfn" href="#viewport" id="ref-for-viewport①">viewport</a> or element has two <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="overflow-directions">overflow directions</dfn>, which are the <a data-link-type="dfn" href="https://drafts.csswg.org/css-writing-modes-4/#block-end" id="ref-for-block-end">block-end</a> and <a data-link-type="dfn" href="https://drafts.csswg.org/css-writing-modes-4/#inline-end" id="ref-for-inline-end">inline-end</a> directions for that viewport or element.</p>
   <p>The term <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="scrolling-area">scrolling area</dfn> refers to a box of a <a data-link-type="dfn" href="#viewport" id="ref-for-viewport②">viewport</a> or an element that has the following edges, depending on the <span id="ref-for-viewport③">viewport’s</span> or element’s <a data-link-type="dfn" href="#scrolling-box" id="ref-for-scrolling-box②">scrolling box’s</a> <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions">overflow directions</a>.</p>
   <table class="complex data">
    <thead>
     <tr>
      <th>If the <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions①">overflow directions</a> are… 
      <th>For a <a data-link-type="dfn" href="#viewport" id="ref-for-viewport④">viewport</a> 
      <th>For an element 
    <tbody>
     <tr>
      <td>rightward and downward 
      <td class="long">
       <dl>
        <dt>top edge 
        <dd>The top edge of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block">initial containing block</a>. 
        <dt>right edge 
        <dd>The right-most edge of the right edge of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block①">initial containing block</a> and the right <a data-link-type="dfn" href="#margin-edge" id="ref-for-margin-edge">margin edge</a> of all of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑤">viewport’s</a> descendants' boxes. 
        <dt>bottom edge 
        <dd>The bottom-most edge of the bottom edge of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block②">initial containing block</a> and the
     bottom <a data-link-type="dfn" href="#margin-edge" id="ref-for-margin-edge①">margin edge</a> of all of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑥">viewport’s</a> descendants' boxes. 
        <dt>left edge 
        <dd>The left edge of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block③">initial containing block</a>. 
       </dl>
      <td class="long">
       <dl>
        <dt>top edge 
        <dd>The element’s top <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge">padding edge</a>. 
        <dt>right edge 
        <dd>The right-most edge of the element’s right <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge①">padding edge</a> and the right <a data-link-type="dfn" href="#margin-edge" id="ref-for-margin-edge②">margin
     edge</a> of all of the element’s descendants' boxes,
     excluding boxes that have an ancestor of the element as their containing block. 
        <dt>bottom edge 
        <dd>The bottom-most edge of the element’s bottom <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge②">padding edge</a> and the bottom <a data-link-type="dfn" href="#margin-edge" id="ref-for-margin-edge③">margin
     edge</a> of all of the element’s descendants'
     boxes, excluding boxes that have an ancestor of the element as their containing block. 
        <dt>left edge 
        <dd>The element’s left <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge③">padding edge</a>. 
       </dl>
     <tr>
      <td>leftward and downward 
      <td class="long">
       <dl>
        <dt>top edge 
        <dd>The top edge of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block④">initial containing block</a>. 
        <dt>right edge 
        <dd>The right edge of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block⑤">initial containing block</a>. 
        <dt>bottom edge 
        <dd>The bottom-most edge of the bottom edge of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block⑥">initial containing block</a> and the
     bottom <a data-link-type="dfn" href="#margin-edge" id="ref-for-margin-edge④">margin edge</a> of all of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑦">viewport’s</a> descendants' boxes. 
        <dt>left edge 
        <dd>The left-most edge of the left edge of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block⑦">initial containing block</a> and the left <a data-link-type="dfn" href="#margin-edge" id="ref-for-margin-edge⑤">margin edge</a> of all of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑧">viewport’s</a> descendants' boxes. 
       </dl>
      <td class="long">
       <dl>
        <dt>top edge 
        <dd>The element’s top <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge④">padding edge</a>. 
        <dt>right edge 
        <dd>The element’s right <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge⑤">padding edge</a>. 
        <dt>bottom edge 
        <dd>The bottom-most edge of the element’s bottom <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge⑥">padding edge</a> and the bottom <a data-link-type="dfn" href="#margin-edge" id="ref-for-margin-edge⑥">margin
     edge</a> of all of the element’s descendants' boxes, excluding boxes that have an ancestor of
     the element as their containing block. 
        <dt>left edge 
        <dd>The left-most edge of the element’s left <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge⑦">padding edge</a> and the left <a data-link-type="dfn" href="#margin-edge" id="ref-for-margin-edge⑦">margin
     edge</a> of all of the element’s descendants' boxes, excluding boxes that have an ancestor of
     the element as their containing block. 
       </dl>
     <tr>
      <td>leftward and upward 
      <td class="long">
       <dl>
        <dt>top edge 
        <dd>The top-most edge of the top edge of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block⑧">initial containing block</a> and the top <a data-link-type="dfn" href="#margin-edge" id="ref-for-margin-edge⑧">margin edge</a> of all of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑨">viewport’s</a> descendants' boxes. 
        <dt>right edge 
        <dd>The right edge of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block⑨">initial containing block</a>. 
        <dt>bottom edge 
        <dd>The bottom edge of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block①⓪">initial containing block</a>. 
        <dt>left edge 
        <dd>The left-most edge of the left edge of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block①①">initial containing block</a> and the left <a data-link-type="dfn" href="#margin-edge" id="ref-for-margin-edge⑨">margin edge</a> of all of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport①⓪">viewport’s</a> descendants' boxes. 
       </dl>
      <td class="long">
       <dl>
        <dt>top edge 
        <dd>The top-most edge of the element’s top <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge⑧">padding edge</a> and the top <a data-link-type="dfn" href="#margin-edge" id="ref-for-margin-edge①⓪">margin edge</a> of all of the element’s descendants' boxes, excluding boxes that have an ancestor of the
     element as their containing block. 
        <dt>right edge 
        <dd>The element’s right <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge⑨">padding edge</a>. 
        <dt>bottom edge 
        <dd>The element’s bottom <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge①⓪">padding edge</a>. 
        <dt>left edge 
        <dd>The left-most edge of the element’s left <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge①①">padding edge</a> and the left <a data-link-type="dfn" href="#margin-edge" id="ref-for-margin-edge①①">margin
     edge</a> of all of the element’s descendants' boxes, excluding boxes that have an ancestor of
     the element as their containing block. 
       </dl>
     <tr>
      <td>rightward and upward 
      <td class="long">
       <dl>
        <dt>top edge 
        <dd>The top-most edge of the top edge of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block①②">initial containing block</a> and the top <a data-link-type="dfn" href="#margin-edge" id="ref-for-margin-edge①②">margin edge</a> of all of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport①①">viewport’s</a> descendants' boxes. 
        <dt>right edge 
        <dd>The right-most edge of the right edge of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block①③">initial containing block</a> and the right <a data-link-type="dfn" href="#margin-edge" id="ref-for-margin-edge①③">margin edge</a> of all of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport①②">viewport’s</a> descendants' boxes. 
        <dt>bottom edge 
        <dd>The bottom edge of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block①④">initial containing block</a>. 
        <dt>left edge 
        <dd>The left edge of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block①⑤">initial containing block</a>. 
       </dl>
      <td class="long">
       <dl>
        <dt>top edge 
        <dd>The top-most edge of the element’s top <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge①②">padding edge</a> and the top <a data-link-type="dfn" href="#margin-edge" id="ref-for-margin-edge①④">margin edge</a> of all of the element’s descendants' boxes, excluding boxes that have an ancestor of the
     element as their containing block. 
        <dt>right edge 
        <dd>The right-most edge of the element’s right <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge①③">padding edge</a> and the right <a data-link-type="dfn" href="#margin-edge" id="ref-for-margin-edge①⑤">margin
     edge</a> of all of the element’s descendants' boxes, excluding boxes that have an ancestor of
     the element as their containing block. 
        <dt>bottom edge 
        <dd>The element’s bottom <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge①④">padding edge</a>. 
        <dt>left edge 
        <dd>The element’s left <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge①⑤">padding edge</a>. 
       </dl>
   </table>
   <p>The <dfn data-dfn-type="dfn" data-lt="scrolling area origin" data-noexport id="scrolling-area-origin">origin<a class="self-link" href="#scrolling-area-origin"></a></dfn> of a <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area">scrolling area</a> is
the origin of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block①⑥">initial containing block</a> if the <span id="ref-for-scrolling-area①">scrolling area</span> is a <a data-link-type="dfn" href="#viewport" id="ref-for-viewport①③">viewport</a>,
and otherwise the top left padding edge of the element when the element has its default scroll position.
The x-coordinate increases rightwards, and the y-coordinate increases downwards.</p>
   <p>The <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="beginning-edges">beginning edges</dfn> of a particular set of edges of a box or element are the following edges:</p>
   <dl class="switch">
    <dt>If the <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions②">overflow directions</a> are rightward and downward 
    <dd>The top and left edges. 
    <dt>If the <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions③">overflow directions</a> are leftward and downward 
    <dd>The top and right edges. 
    <dt>If the <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions④">overflow directions</a> are leftward and upward 
    <dd>The bottom and right edges. 
    <dt>If the <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions⑤">overflow directions</a> are rightward and upward 
    <dd>The bottom and left edges. 
   </dl>
   <p>The <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="ending-edges">ending edges</dfn> of a particular set of edges of a box or element are the following edges:</p>
   <dl class="switch">
    <dt>If the <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions⑥">overflow directions</a> are rightward and downward 
    <dd>The bottom and right edges. 
    <dt>If the <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions⑦">overflow directions</a> are leftward and downward 
    <dd>The bottom and left edges. 
    <dt>If the <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions⑧">overflow directions</a> are leftward and upward 
    <dd>The top and left edges. 
    <dt>If the <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions⑨">overflow directions</a> are rightward and upward 
    <dd>The top and right edges. 
   </dl>
   <p>The term <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="css-layout-box">CSS layout box</dfn> refers to the same term in CSS. For the purpose
of the requirements in this specification, elements that have a computed value of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-display-3/#propdef-display" id="ref-for-propdef-display">display</a> property that is <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-display-3/#valdef-display-table-column" id="ref-for-valdef-display-table-column">table-column</a> or <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-display-3/#valdef-display-table-column-group" id="ref-for-valdef-display-table-column-group">table-column-group</a> must be considered to have an associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box①">CSS layout box</a> (the column or column group, respectively).</p>
   <p>The term <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="svg-layout-box">SVG layout box</dfn> refers to the same term in SVG.</p>
   <p class="issue" id="issue-167dc25d"><a class="self-link" href="#issue-167dc25d"></a>The terms <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box②">CSS layout box</a> and <a data-link-type="dfn" href="#svg-layout-box" id="ref-for-svg-layout-box">SVG layout box</a> are not currently defined by CSS or SVG. </p>
   <p>The term <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="layout-box">layout box</dfn> refers to either a <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box③">CSS layout box</a> or an <a data-link-type="dfn" href="#svg-layout-box" id="ref-for-svg-layout-box①">SVG layout box</a>.</p>
   <p>The term <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="transforms">transforms</dfn> refers to SVG transforms and CSS transforms. <a data-link-type="biblio" href="#biblio-svg11">[SVG11]</a> <a data-link-type="biblio" href="#biblio-css-transforms-1">[CSS-TRANSFORMS-1]</a></p>
   <p>When a method or an attribute is said to call another method or attribute, the user agent must invoke its internal API for that attribute or method so that
e.g. the author can’t change the behavior by overriding attributes or methods with custom properties or functions in ECMAScript.</p>
   <p>Unless otherwise stated, string comparisons are done in a <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive" id="ref-for-case-sensitive">case-sensitive</a> manner.</p>
   <h3 class="heading settled" data-level="2.1" id="css-pixels"><span class="secno">2.1. </span><span class="content">CSS pixels</span><a class="self-link" href="#css-pixels"></a></h3>
   <p>All coordinates and dimensions for the APIs defined in this
specification are in <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px">CSS pixels</a>, unless otherwise specified. <a data-link-type="biblio" href="#biblio-css-values">[CSS-VALUES]</a></p>
   <p class="note" role="note"><span>Note:</span> This does not apply to e.g. <code class="idl"><a data-link-type="idl" href="#dom-window-matchmedia" id="ref-for-dom-window-matchmedia">matchMedia()</a></code> as the units are explicitly given there.</p>
   <h3 class="heading settled" data-level="2.2" id="zooming"><span class="secno">2.2. </span><span class="content">Zooming</span><a class="self-link" href="#zooming"></a></h3>
   <p>There are two kinds of zoom, <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="page-zoom">page zoom</dfn> which affects the size of the initial viewport, and <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="pinch-zoom">pinch zoom</dfn> which acts like
a magnifying glass and does not affect the initial viewport or actual viewport. <a data-link-type="biblio" href="#biblio-css-device-adapt">[CSS-DEVICE-ADAPT]</a></p>
   <h3 class="heading settled" data-level="2.3" id="web-exposed-screen-information"><span class="secno">2.3. </span><span class="content">Web-exposed screen information</span><a class="self-link" href="#web-exposed-screen-information"></a></h3>
   <p>User agents may choose to hide information about the screen of the output device, in order to
protect the user’s privacy. In order to do so in a consistent manner across APIs, this specification
defines the following terms, each having a width and a height, the origin being the top left
corner, and the x- and y-coordinates increase rightwards and downwards, respectively.</p>
   <p>The <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="web-exposed-screen-area">Web-exposed screen area</dfn> is one of the following:</p>
   <ul>
    <li data-md>
     <p>The area of the output device, in <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px①">CSS pixels</a>.</p>
    <li data-md>
     <p>The area of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport①④">viewport</a>, in <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px②">CSS pixels</a>.</p>
   </ul>
   <p>The <dfn class="dfn-paneled" data-dfn-type="dfn" data-export id="web-exposed-available-screen-area">Web-exposed available screen area</dfn> is one of the following:</p>
   <ul>
    <li data-md>
     <p>The available area of the rendering surface of the output device, in <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px③">CSS pixels</a>.</p>
    <li data-md>
     <p>The area of the output device, in <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px④">CSS pixels</a>.</p>
    <li data-md>
     <p>The area of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport①⑤">viewport</a>, in <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px⑤">CSS pixels</a>.</p>
   </ul>
   <h2 class="heading settled" data-level="3" id="common-infrastructure"><span class="secno">3. </span><span class="content">Common Infrastructure</span><a class="self-link" href="#common-infrastructure"></a></h2>
   <p>This specification depends on the WHATWG Infra standard. <a data-link-type="biblio" href="#biblio-infra">[INFRA]</a></p>
   <h3 class="heading settled" data-level="3.1" id="scrolling"><span class="secno">3.1. </span><span class="content">Scrolling</span><a class="self-link" href="#scrolling"></a></h3>
   <p>When a user agent is to <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="perform-a-scroll">perform a scroll</dfn> of a <a data-link-type="dfn" href="#scrolling-box" id="ref-for-scrolling-box③">scrolling box</a> <var>box</var>,
to a given position <var>position</var>,
an associated element <var>element</var> and optionally a scroll behavior <var>behavior</var> (which is "<code>auto</code>" if omitted),
the following steps must be run:</p>
   <ol>
    <li><a data-link-type="dfn" href="#smooth-scroll-aborted" id="ref-for-smooth-scroll-aborted">Abort</a> any ongoing <a data-link-type="dfn" href="#concept-smooth-scroll" id="ref-for-concept-smooth-scroll">smooth scroll</a> for <var>box</var>. 
    <li>
     If the user agent honors the <a class="property" data-link-type="propdesc" href="#propdef-scroll-behavior" id="ref-for-propdef-scroll-behavior">scroll-behavior</a> property and one of the following are true: 
     <ul>
      <li><var>behavior</var> is "<code>auto</code>" and <var>element</var> is not null and its computed value of the <a class="property" data-link-type="propdesc" href="#propdef-scroll-behavior" id="ref-for-propdef-scroll-behavior①">scroll-behavior</a> property is <a class="css" data-link-type="maybe" href="#valdef-scroll-behavior-smooth" id="ref-for-valdef-scroll-behavior-smooth">smooth</a> 
      <li><var>behavior</var> is <code>smooth</code> 
     </ul>
      ...then perform a <a data-link-type="dfn" href="#concept-smooth-scroll" id="ref-for-concept-smooth-scroll①">smooth scroll</a> of <var>box</var> to <var>position</var>.
  Otherwise, perform an <a data-link-type="dfn" href="#concept-instant-scroll" id="ref-for-concept-instant-scroll">instant scroll</a> of <var>box</var> to <var>position</var>. 
   </ol>
   <p>When a user agent is to perform a <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-smooth-scroll">smooth scroll</dfn> of a <a data-link-type="dfn" href="#scrolling-box" id="ref-for-scrolling-box④">scrolling box</a> <var>box</var> to <var>position</var>,
it must update the scroll position of <var>box</var> in a user-agent-defined fashion over a user-agent-defined amount of time. When the scroll is <dfn data-dfn-type="dfn" data-lt="smooth scroll completed" data-noexport id="smooth-scroll-completed">completed<a class="self-link" href="#smooth-scroll-completed"></a></dfn>, the scroll position of <var>box</var> must be <var>position</var>. The scroll can also
be <dfn class="dfn-paneled" data-dfn-type="dfn" data-lt="smooth scroll aborted" data-noexport id="smooth-scroll-aborted">aborted</dfn>, either by an algorithm or by the user.</p>
   <p>When a user agent is to perform an <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="concept-instant-scroll">instant scroll</dfn> of a <a data-link-type="dfn" href="#scrolling-box" id="ref-for-scrolling-box⑤">scrolling box</a> <var>box</var> to <var>position</var>, it must update the scroll position of <var>box</var> to <var>position</var>.</p>
   <p>To <dfn data-dfn-type="dfn" data-noexport id="scroll-to-the-beginning-of-the-document">scroll to the beginning of the document<a class="self-link" href="#scroll-to-the-beginning-of-the-document"></a></dfn> for a document <var>document</var>, follow these steps:</p>
   <ol>
    <li>Let <var>viewport</var> be the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport①⑥">viewport</a> that is associated with <var>document</var>. 
    <li>Let <var>position</var> be the the scroll position <var>viewport</var> would have by aligning the <a data-link-type="dfn" href="#beginning-edges" id="ref-for-beginning-edges">beginning edges</a> of the <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area②">scrolling area</a> with the <span id="ref-for-beginning-edges①">beginning edges</span> of <var>viewport</var>. 
    <li>If <var>position</var> is the same as <var>viewport</var>’s current scroll position, and <var>viewport</var> does not have an ongoing <a data-link-type="dfn" href="#concept-smooth-scroll" id="ref-for-concept-smooth-scroll②">smooth scroll</a>, abort these steps. 
    <li><a data-link-type="dfn" href="#perform-a-scroll" id="ref-for-perform-a-scroll">Perform a scroll</a> of <var>viewport</var> to <var>position</var>,
 and <var>document</var>’s root element as the associated element, if there is one, or null otherwise. 
   </ol>
   <p class="note" role="note"><span>Note:</span> This algorithm is used when navigating to the <code>#top</code> fragment identifier, as defined in HTML. <a data-link-type="biblio" href="#biblio-html">[HTML]</a></p>
   <h3 class="heading settled" data-level="3.2" id="webidl-values"><span class="secno">3.2. </span><span class="content">WebIDL values</span><a class="self-link" href="#webidl-values"></a></h3>
   <p>When asked to <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="normalize-non-finite-values">normalize non-finite values</dfn> for a value <var>x</var>,
if <var>x</var> is one of the three special floating point literal values
(<code>Infinity</code>, <code>-Infinity</code> or <code>NaN</code>),
then <var>x</var> must be changed to the value <code>0</code>. <a data-link-type="biblio" href="#biblio-webidl">[WEBIDL]</a></p>
   <h2 class="heading settled" data-level="4" id="extensions-to-the-window-interface"><span class="secno">4. </span><span class="content">Extensions to the <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window">Window</a></code> Interface</span><a class="self-link" href="#extensions-to-the-window-interface"></a></h2>
<pre class="idl highlight def"><c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="enumdef-scrollbehavior"><code><c- g>ScrollBehavior</c-></code></dfn> { <dfn class="idl-code" data-dfn-for="ScrollBehavior" data-dfn-type="enum-value" data-export id="dom-scrollbehavior-auto"><code><c- s>"auto"</c-></code><a class="self-link" href="#dom-scrollbehavior-auto"></a></dfn>, <dfn class="idl-code" data-dfn-for="ScrollBehavior" data-dfn-type="enum-value" data-export id="dom-scrollbehavior-smooth"><code><c- s>"smooth"</c-></code><a class="self-link" href="#dom-scrollbehavior-smooth"></a></dfn> };

<c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-scrolloptions"><code><c- g>ScrollOptions</c-></code></dfn> {
    <a class="n" data-link-type="idl-name" href="#enumdef-scrollbehavior" id="ref-for-enumdef-scrollbehavior"><c- n>ScrollBehavior</c-></a> <dfn class="dfn-paneled idl-code" data-default="&quot;auto&quot;" data-dfn-for="ScrollOptions" data-dfn-type="dict-member" data-export data-type="ScrollBehavior " id="dom-scrolloptions-behavior"><code><c- g>behavior</c-></code></dfn> = "auto";
};
<c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-scrolltooptions"><code><c- g>ScrollToOptions</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#dictdef-scrolloptions" id="ref-for-dictdef-scrolloptions"><c- n>ScrollOptions</c-></a> {
    <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double" id="ref-for-idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="ScrollToOptions" data-dfn-type="dict-member" data-export data-type="unrestricted double " id="dom-scrolltooptions-left"><code><c- g>left</c-></code></dfn>;
    <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double" id="ref-for-idl-unrestricted-double①"><c- b>unrestricted</c-> <c- b>double</c-></a> <dfn class="dfn-paneled idl-code" data-dfn-for="ScrollToOptions" data-dfn-type="dict-member" data-export data-type="unrestricted double " id="dom-scrolltooptions-top"><code><c- g>top</c-></code></dfn>;
};

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window①"><c- g>Window</c-></a> {
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject"><c- g>NewObject</c-></a>] <a class="n" data-link-type="idl-name" href="#mediaquerylist" id="ref-for-mediaquerylist"><c- n>MediaQueryList</c-></a> <a class="idl-code" data-link-type="method" href="#dom-window-matchmedia" id="ref-for-dom-window-matchmedia①"><c- g>matchMedia</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="Window/matchMedia(query)" data-dfn-type="argument" data-export id="dom-window-matchmedia-query-query"><code><c- g>query</c-></code><a class="self-link" href="#dom-window-matchmedia-query-query"></a></dfn>);
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject" id="ref-for-SameObject"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable" id="ref-for-Replaceable"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#screen" id="ref-for-screen"><c- n>Screen</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="Screen" href="#dom-window-screen" id="ref-for-dom-window-screen"><c- g>screen</c-></a>;

    // browsing context
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-moveto" id="ref-for-dom-window-moveto"><c- g>moveTo</c-></a>(<a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long"><c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="Window/moveTo(x, y)" data-dfn-type="argument" data-export id="dom-window-moveto-x-y-x"><code><c- g>x</c-></code><a class="self-link" href="#dom-window-moveto-x-y-x"></a></dfn>, <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long①"><c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="Window/moveTo(x, y)" data-dfn-type="argument" data-export id="dom-window-moveto-x-y-y"><code><c- g>y</c-></code><a class="self-link" href="#dom-window-moveto-x-y-y"></a></dfn>);
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-moveby" id="ref-for-dom-window-moveby"><c- g>moveBy</c-></a>(<a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long②"><c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="Window/moveBy(x, y)" data-dfn-type="argument" data-export id="dom-window-moveby-x-y-x"><code><c- g>x</c-></code><a class="self-link" href="#dom-window-moveby-x-y-x"></a></dfn>, <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long③"><c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="Window/moveBy(x, y)" data-dfn-type="argument" data-export id="dom-window-moveby-x-y-y"><code><c- g>y</c-></code><a class="self-link" href="#dom-window-moveby-x-y-y"></a></dfn>);
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-resizeto" id="ref-for-dom-window-resizeto"><c- g>resizeTo</c-></a>(<a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long④"><c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="Window/resizeTo(width, height)" data-dfn-type="argument" data-export id="dom-window-resizeto-width-height-width"><code><c- g>width</c-></code><a class="self-link" href="#dom-window-resizeto-width-height-width"></a></dfn>, <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long⑤"><c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="Window/resizeTo(width, height)" data-dfn-type="argument" data-export id="dom-window-resizeto-width-height-height"><code><c- g>height</c-></code><a class="self-link" href="#dom-window-resizeto-width-height-height"></a></dfn>);
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-resizeby" id="ref-for-dom-window-resizeby"><c- g>resizeBy</c-></a>(<a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long⑥"><c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="Window/resizeBy(x, y)" data-dfn-type="argument" data-export id="dom-window-resizeby-x-y-x"><code><c- g>x</c-></code><a class="self-link" href="#dom-window-resizeby-x-y-x"></a></dfn>, <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long⑦"><c- b>long</c-></a> <dfn class="idl-code" data-dfn-for="Window/resizeBy(x, y)" data-dfn-type="argument" data-export id="dom-window-resizeby-x-y-y"><code><c- g>y</c-></code><a class="self-link" href="#dom-window-resizeby-x-y-y"></a></dfn>);

    // viewport
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable" id="ref-for-Replaceable①"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long⑧"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-window-innerwidth" id="ref-for-dom-window-innerwidth"><c- g>innerWidth</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable" id="ref-for-Replaceable②"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long⑨"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-window-innerheight" id="ref-for-dom-window-innerheight"><c- g>innerHeight</c-></a>;

    // viewport scrolling
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable" id="ref-for-Replaceable③"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-window-scrollx" id="ref-for-dom-window-scrollx"><c- g>scrollX</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable" id="ref-for-Replaceable④"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double①"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-window-pagexoffset" id="ref-for-dom-window-pagexoffset"><c- g>pageXOffset</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable" id="ref-for-Replaceable⑤"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double②"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-window-scrolly" id="ref-for-dom-window-scrolly"><c- g>scrollY</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable" id="ref-for-Replaceable⑥"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double③"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-window-pageyoffset" id="ref-for-dom-window-pageyoffset"><c- g>pageYOffset</c-></a>;
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-scroll" id="ref-for-dom-window-scroll"><c- g>scroll</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-scrolltooptions" id="ref-for-dictdef-scrolltooptions"><c- n>ScrollToOptions</c-></a> <dfn class="idl-code" data-dfn-for="Window/scroll(options), Window/scroll()" data-dfn-type="argument" data-export id="dom-window-scroll-options-options"><code><c- g>options</c-></code><a class="self-link" href="#dom-window-scroll-options-options"></a></dfn> = {});
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-scroll" id="ref-for-dom-window-scroll①"><c- g>scroll</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double" id="ref-for-idl-unrestricted-double②"><c- b>unrestricted</c-> <c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Window/scroll(x, y)" data-dfn-type="argument" data-export id="dom-window-scroll-x-y-x"><code><c- g>x</c-></code><a class="self-link" href="#dom-window-scroll-x-y-x"></a></dfn>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double" id="ref-for-idl-unrestricted-double③"><c- b>unrestricted</c-> <c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Window/scroll(x, y)" data-dfn-type="argument" data-export id="dom-window-scroll-x-y-y"><code><c- g>y</c-></code><a class="self-link" href="#dom-window-scroll-x-y-y"></a></dfn>);
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-scrollto" id="ref-for-dom-window-scrollto"><c- g>scrollTo</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-scrolltooptions" id="ref-for-dictdef-scrolltooptions①"><c- n>ScrollToOptions</c-></a> <dfn class="idl-code" data-dfn-for="Window/scrollTo(options), Window/scrollTo()" data-dfn-type="argument" data-export id="dom-window-scrollto-options-options"><code><c- g>options</c-></code><a class="self-link" href="#dom-window-scrollto-options-options"></a></dfn> = {});
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-scrollto" id="ref-for-dom-window-scrollto①"><c- g>scrollTo</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double" id="ref-for-idl-unrestricted-double④"><c- b>unrestricted</c-> <c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Window/scrollTo(x, y)" data-dfn-type="argument" data-export id="dom-window-scrollto-x-y-x"><code><c- g>x</c-></code><a class="self-link" href="#dom-window-scrollto-x-y-x"></a></dfn>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double" id="ref-for-idl-unrestricted-double⑤"><c- b>unrestricted</c-> <c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Window/scrollTo(x, y)" data-dfn-type="argument" data-export id="dom-window-scrollto-x-y-y"><code><c- g>y</c-></code><a class="self-link" href="#dom-window-scrollto-x-y-y"></a></dfn>);
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-scrollby" id="ref-for-dom-window-scrollby"><c- g>scrollBy</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-scrolltooptions" id="ref-for-dictdef-scrolltooptions②"><c- n>ScrollToOptions</c-></a> <dfn class="idl-code" data-dfn-for="Window/scrollBy(options), Window/scrollBy()" data-dfn-type="argument" data-export id="dom-window-scrollby-options-options"><code><c- g>options</c-></code><a class="self-link" href="#dom-window-scrollby-options-options"></a></dfn> = {});
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-scrollby" id="ref-for-dom-window-scrollby①"><c- g>scrollBy</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double" id="ref-for-idl-unrestricted-double⑥"><c- b>unrestricted</c-> <c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Window/scrollBy(x, y)" data-dfn-type="argument" data-export id="dom-window-scrollby-x-y-x"><code><c- g>x</c-></code><a class="self-link" href="#dom-window-scrollby-x-y-x"></a></dfn>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double" id="ref-for-idl-unrestricted-double⑦"><c- b>unrestricted</c-> <c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Window/scrollBy(x, y)" data-dfn-type="argument" data-export id="dom-window-scrollby-x-y-y"><code><c- g>y</c-></code><a class="self-link" href="#dom-window-scrollby-x-y-y"></a></dfn>);

    // client
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable" id="ref-for-Replaceable⑦"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long①⓪"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-window-screenx" id="ref-for-dom-window-screenx"><c- g>screenX</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable" id="ref-for-Replaceable⑧"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long①①"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-window-screenleft" id="ref-for-dom-window-screenleft"><c- g>screenLeft</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable" id="ref-for-Replaceable⑨"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long①②"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-window-screeny" id="ref-for-dom-window-screeny"><c- g>screenY</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable" id="ref-for-Replaceable①⓪"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long①③"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-window-screentop" id="ref-for-dom-window-screentop"><c- g>screenTop</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable" id="ref-for-Replaceable①①"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long①④"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-window-outerwidth" id="ref-for-dom-window-outerwidth"><c- g>outerWidth</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable" id="ref-for-Replaceable①②"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long①⑤"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-window-outerheight" id="ref-for-dom-window-outerheight"><c- g>outerHeight</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable" id="ref-for-Replaceable①③"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double④"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-window-devicepixelratio" id="ref-for-dom-window-devicepixelratio"><c- g>devicePixelRatio</c-></a>;
};
</pre>
   <p>When the <dfn class="caniuse-paneled dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="method" data-export id="dom-window-matchmedia"><code>matchMedia(<var>query</var>)</code></dfn> method is invoked these steps must be run:</p>
   <ol>
    <li>Let <var>parsed media query list</var> be the result of <a data-link-type="dfn" href="https://drafts.csswg.org/cssom/#parse-a-media-query-list" id="ref-for-parse-a-media-query-list">parsing</a> <var>query</var>. 
    <li>Return a new <code class="idl"><a data-link-type="idl" href="#mediaquerylist" id="ref-for-mediaquerylist①">MediaQueryList</a></code> object,
 with the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object">context object’s</a> <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#concept-document-window" id="ref-for-concept-document-window">associated <code>Document</code></a> as the <a data-link-type="dfn" href="#mediaquerylist-document" id="ref-for-mediaquerylist-document">document</a>,
 with <var>parsed media query list</var> as its associated <a data-link-type="dfn" href="#media-query-list" id="ref-for-media-query-list">media query list</a>. 
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="attribute" data-export id="dom-window-screen"><code>screen</code></dfn> attribute must return the <code class="idl"><a data-link-type="idl" href="#screen" id="ref-for-screen①">Screen</a></code> object
associated with the <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window②">Window</a></code> object.</p>
   <p class="note" role="note"><span>Note:</span> Accessing <code class="idl"><a data-link-type="idl" href="#dom-window-screen" id="ref-for-dom-window-screen①">screen</a></code> through a <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/browsers.html#windowproxy" id="ref-for-windowproxy">WindowProxy</a></code> object might yield different
results when the <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document">Document</a></code> is navigated.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="method" data-export id="dom-window-moveto"><code>moveTo(<var>x</var>, <var>y</var>)</code></dfn> method must follow these steps:</p>
   <ol>
    <li data-md>
     <p>Optionally, terminate these steps.</p>
    <li data-md>
     <p>Let <var>target</var> be the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#browsing-context" id="ref-for-browsing-context">browsing context</a> of the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object①">context object</a>.</p>
    <li data-md>
     <p>Let <var>source</var> be the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#responsible-browsing-context" id="ref-for-responsible-browsing-context">responsible browsing context</a> of the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#incumbent-settings-object" id="ref-for-incumbent-settings-object">incumbent settings object</a>.</p>
    <li data-md>
     <p>If <var>source</var> is not <a data-link-type="dfn" href="#allowed-to-resize-and-move" id="ref-for-allowed-to-resize-and-move">allowed to resize and move</a> <var>target</var>, terminate these steps.</p>
    <li data-md>
     <p>Optionally, clamp <var>x</var> and <var>y</var> in a user-agent-defined manner so that the window does not move outside the available space.</p>
    <li data-md>
     <p>Move <var>target</var>’s window such that the window’s top left corner is at coordinates (<var>x</var>, <var>y</var>) relative to the top left corner of the output device, measured in <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px⑥">CSS pixels</a> of <var>target</var>. The positive axes are rightward and downward.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="method" data-export id="dom-window-moveby"><code>moveBy(<var>x</var>, <var>y</var>)</code></dfn> method must follow these steps:</p>
   <ol>
    <li data-md>
     <p>Optionally, terminate these steps.</p>
    <li data-md>
     <p>Let <var>target</var> be the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#browsing-context" id="ref-for-browsing-context①">browsing context</a> of the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object②">context object</a>.</p>
    <li data-md>
     <p>Let <var>source</var> be the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#responsible-browsing-context" id="ref-for-responsible-browsing-context①">responsible browsing context</a> of the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#incumbent-settings-object" id="ref-for-incumbent-settings-object①">incumbent settings object</a>.</p>
    <li data-md>
     <p>If <var>source</var> is not <a data-link-type="dfn" href="#allowed-to-resize-and-move" id="ref-for-allowed-to-resize-and-move①">allowed to resize and move</a> <var>target</var>, terminate these steps.</p>
    <li data-md>
     <p>Optionally, clamp <var>x</var> and <var>y</var> in a user-agent-defined manner so that the window does not move outside the available space.</p>
    <li data-md>
     <p>Move <var>target</var>’s window <var>x</var> <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px⑦">CSS pixels</a> of <var>target</var> rightward and <var>y</var> <span id="ref-for-px⑧">CSS pixels</span> of <var>target</var> downward.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="method" data-export id="dom-window-resizeto"><code>resizeTo(<var>width</var>, <var>height</var>)</code></dfn> method must follow these steps:</p>
   <ol>
    <li data-md>
     <p>Optionally, terminate these steps.</p>
    <li data-md>
     <p>Let <var>target</var> be the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#browsing-context" id="ref-for-browsing-context②">browsing context</a> of the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object③">context object</a>.</p>
    <li data-md>
     <p>Let <var>source</var> be the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#responsible-browsing-context" id="ref-for-responsible-browsing-context②">responsible browsing context</a> of the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#incumbent-settings-object" id="ref-for-incumbent-settings-object②">incumbent settings object</a>.</p>
    <li data-md>
     <p>If <var>source</var> is not <a data-link-type="dfn" href="#allowed-to-resize-and-move" id="ref-for-allowed-to-resize-and-move②">allowed to resize and move</a> <var>target</var>, terminate these steps.</p>
    <li data-md>
     <p>Optionally, clamp <var>width</var> and <var>height</var> in a user-agent-defined manner so that the window does not get too small or bigger than the available space.</p>
    <li data-md>
     <p>Resize <var>target</var>’s window by moving its right and bottom edges such that the distance between the left and right edges of the viewport are <var>width</var> <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px⑨">CSS pixels</a> of <var>target</var> and the distance between the top and bottom edges of the viewport are <var>height</var> <span id="ref-for-px①⓪">CSS pixels</span> of <var>target</var>.</p>
    <li data-md>
     <p>Optionally, move <var>target</var>’s window in a user-agent-defined manner so that it does not grow outside the available space.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="method" data-export id="dom-window-resizeby"><code>resizeBy(<var>x</var>, <var>y</var>)</code></dfn> method must follow these steps:</p>
   <ol>
    <li data-md>
     <p>Optionally, terminate these steps.</p>
    <li data-md>
     <p>Let <var>target</var> be the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#browsing-context" id="ref-for-browsing-context③">browsing context</a> of the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object④">context object</a>.</p>
    <li data-md>
     <p>Let <var>source</var> be the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#responsible-browsing-context" id="ref-for-responsible-browsing-context③">responsible browsing context</a> of the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#incumbent-settings-object" id="ref-for-incumbent-settings-object③">incumbent settings object</a>.</p>
    <li data-md>
     <p>If <var>source</var> is not <a data-link-type="dfn" href="#allowed-to-resize-and-move" id="ref-for-allowed-to-resize-and-move③">allowed to resize and move</a> <var>target</var>, terminate these steps.</p>
    <li data-md>
     <p>Optionally, clamp <var>x</var> and <var>y</var> in a user-agent-defined manner so that the window does not get too small or bigger than the available space.</p>
    <li data-md>
     <p>Resize <var>target</var>’s window by moving its right edge <var>x</var> <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px①①">CSS pixels</a> of <var>target</var> rightward and its bottom edge <var>y</var> <span id="ref-for-px①②">CSS pixels</span> of <var>target</var> downward.</p>
    <li data-md>
     <p>Optionally, move <var>target</var>’s window in a user-agent-defined manner so that it does not grow outside the available space.</p>
   </ol>
   <p>A <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#browsing-context" id="ref-for-browsing-context④">browsing context</a> <var>A</var> is <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="allowed-to-resize-and-move">allowed to resize and move</dfn> a <span id="ref-for-browsing-context⑤">browsing context</span> <var>B</var> if all the following conditions are met:</p>
   <ul>
    <li data-md>
     <p><var>B</var> is an <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#auxiliary-browsing-context" id="ref-for-auxiliary-browsing-context">auxiliary browsing context</a> that was created by a script (as opposed to by an action of the user).</p>
    <li data-md>
     <p><var>A</var> is <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#familiar-with" id="ref-for-familiar-with">familiar with</a> <var>B</var>.</p>
   </ul>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="attribute" data-export id="dom-window-innerwidth"><code>innerWidth</code></dfn> attribute must return the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport①⑦">viewport</a> width including the size of a rendered
scroll bar (if any), or zero if there is no <span id="ref-for-viewport①⑧">viewport</span>.</p>
   <div class="example" id="example-daa56a22">
    <a class="self-link" href="#example-daa56a22"></a> The following snippet shows how to obtain the width of the viewport: 
<pre>var viewportWidth = innerWidth</pre>
   </div>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="attribute" data-export id="dom-window-innerheight"><code>innerHeight</code></dfn> attribute must return the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport①⑨">viewport</a> height including the size of a rendered
scroll bar (if any), or zero if there is no <span id="ref-for-viewport②⓪">viewport</span>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="attribute" data-export id="dom-window-scrollx"><code>scrollX</code></dfn> attribute attribute must return the x-coordinate,
relative to the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block①⑦">initial containing block</a> origin,
of the left of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport②①">viewport</a>,
or zero if there is no <span id="ref-for-viewport②②">viewport</span>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="attribute" data-export id="dom-window-pagexoffset"><code>pageXOffset</code></dfn> attribute must return the value returned by the <code class="idl"><a data-link-type="idl" href="#dom-window-scrollx" id="ref-for-dom-window-scrollx①">scrollX</a></code> attribute.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="attribute" data-export id="dom-window-scrolly"><code>scrollY</code></dfn> attribute attribute must return the y-coordinate,
relative to the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block①⑧">initial containing block</a> origin,
of the top of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport②③">viewport</a>,
or zero if there is no <span id="ref-for-viewport②④">viewport</span>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="attribute" data-export id="dom-window-pageyoffset"><code>pageYOffset</code></dfn> attribute must return the value returned by the <code class="idl"><a data-link-type="idl" href="#dom-window-scrolly" id="ref-for-dom-window-scrolly①">scrollY</a></code> attribute.</p>
   <p>When the <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="method" data-export data-lt="scroll(x, y)|scroll(options)|scroll()" id="dom-window-scroll"><code>scroll()</code></dfn> method is invoked these
steps must be run:</p>
   <ol>
    <li data-md>
     <p>If invoked with one argument, follow these substeps:</p>
     <ol>
      <li data-md>
       <p>Let <var>options</var> be the argument.</p>
      <li data-md>
       <p>Let <var>x</var> be the value of the <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-left" id="ref-for-dom-scrolltooptions-left">left</a></code> dictionary member of <var>options</var>, if present,
or the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport②⑤">viewport’s</a> current scroll position on the x axis otherwise.</p>
      <li data-md>
       <p>Let <var>y</var> be the value of the <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-top" id="ref-for-dom-scrolltooptions-top">top</a></code> dictionary member of <var>options</var>, if present,
or the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport②⑥">viewport’s</a> current scroll position on the y axis otherwise.</p>
     </ol>
    <li data-md>
     <p>If invoked with two arguments, follow these substeps:</p>
     <ol>
      <li data-md>
       <p>Let <var>options</var> be null <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-convert-ecmascript-to-idl-value" id="ref-for-dfn-convert-ecmascript-to-idl-value">converted</a> to a <code class="idl"><a data-link-type="idl" href="#dictdef-scrolltooptions" id="ref-for-dictdef-scrolltooptions③">ScrollToOptions</a></code> dictionary. <a data-link-type="biblio" href="#biblio-webidl">[WEBIDL]</a></p>
      <li data-md>
       <p>Let <var>x</var> and <var>y</var> be the arguments, respectively.</p>
     </ol>
    <li data-md>
     <p><a data-link-type="dfn" href="#normalize-non-finite-values" id="ref-for-normalize-non-finite-values">Normalize non-finite values</a> for <var>x</var> and <var>y</var>.</p>
    <li data-md>
     <p>If there is no <a data-link-type="dfn" href="#viewport" id="ref-for-viewport②⑦">viewport</a>, abort these steps.</p>
    <li data-md>
     <p>Let <var>viewport width</var> be the width of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport②⑧">viewport</a> excluding the width of the scroll bar, if any.</p>
    <li data-md>
     <p>Let <var>viewport height</var> be the height of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport②⑨">viewport</a> excluding the height of the scroll bar, if any.</p>
    <li data-md>
     <dl class="switch">
      <dt>If the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport③⓪">viewport</a> has rightward <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions①⓪">overflow direction</a> 
      <dd>Let <var>x</var> be max(0, min(<var>x</var>, <a data-link-type="dfn" href="#viewport" id="ref-for-viewport③①">viewport</a> <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area③">scrolling area</a> width - <var>viewport width</var>)). 
      <dt>If the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport③②">viewport</a> has leftward <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions①①">overflow direction</a> 
      <dd>Let <var>x</var> be min(0, max(<var>x</var>, <var>viewport width</var> - <a data-link-type="dfn" href="#viewport" id="ref-for-viewport③③">viewport</a> <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area④">scrolling area</a> width)). 
     </dl>
    <li data-md>
     <dl class="switch">
      <dt>If the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport③④">viewport</a> has downward <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions①②">overflow direction</a> 
      <dd>Let <var>y</var> be max(0, min(<var>y</var>, <a data-link-type="dfn" href="#viewport" id="ref-for-viewport③⑤">viewport</a> <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area⑤">scrolling area</a> height - <var>viewport height</var>)). 
      <dt>If the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport③⑥">viewport</a> has upward <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions①③">overflow direction</a> 
      <dd>Let <var>y</var> be min(0, max(<var>y</var>, <var>viewport height</var> - <a data-link-type="dfn" href="#viewport" id="ref-for-viewport③⑦">viewport</a> <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area⑥">scrolling area</a> height)). 
     </dl>
    <li data-md>
     <p>Let <var>position</var> be the scroll position the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport③⑧">viewport</a> would have
by aligning the x-coordinate <var>x</var> of the <span id="ref-for-viewport③⑨">viewport</span> <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area⑦">scrolling area</a> with the left of the <span id="ref-for-viewport④⓪">viewport</span> and aligning the y-coordinate <var>y</var> of the <span id="ref-for-viewport④①">viewport</span> <span id="ref-for-scrolling-area⑧">scrolling area</span> with the top of the <span id="ref-for-viewport④②">viewport</span>.</p>
    <li data-md>
     <p>If <var>position</var> is the same as the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport④③">viewport’s</a> current scroll position,
and the <span id="ref-for-viewport④④">viewport</span> does not have an ongoing <a data-link-type="dfn" href="#concept-smooth-scroll" id="ref-for-concept-smooth-scroll③">smooth scroll</a>, abort these steps.</p>
    <li data-md>
     <p>Let <var>document</var> be the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport④⑤">viewport’s</a> associated <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document①">Document</a></code>.</p>
    <li data-md>
     <p><a data-link-type="dfn" href="#perform-a-scroll" id="ref-for-perform-a-scroll①">Perform a scroll</a> of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport④⑥">viewport</a> to <var>position</var>, <var>document</var>’s root element as the associated element, if there is one, or null otherwise,
and the scroll behavior being the value of the <code class="idl"><a data-link-type="idl" href="#dom-scrolloptions-behavior" id="ref-for-dom-scrolloptions-behavior">behavior</a></code> dictionary member of <var>options</var>.</p>
   </ol>
   <p>When the <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="method" data-export data-lt="scrollTo(x, y)|scrollTo(options)|scrollTo()" id="dom-window-scrollto"><code>scrollTo()</code></dfn> method is invoked, the
user agent must act as if the <code class="idl"><a data-link-type="idl" href="#dom-window-scroll" id="ref-for-dom-window-scroll②">scroll()</a></code> method was invoked with the same arguments.</p>
   <p>When the <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="method" data-export data-lt="scrollBy(x, y)|scrollBy(options)|scrollBy()" id="dom-window-scrollby"><code>scrollBy()</code></dfn> method is invoked, the
user agent must run these steps:</p>
   <ol>
    <li data-md>
     <p>If invoked with two arguments, follow these substeps:</p>
     <ol>
      <li data-md>
       <p>Let <var>options</var> be null <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-convert-ecmascript-to-idl-value" id="ref-for-dfn-convert-ecmascript-to-idl-value①">converted</a> to a <code class="idl"><a data-link-type="idl" href="#dictdef-scrolltooptions" id="ref-for-dictdef-scrolltooptions④">ScrollToOptions</a></code> dictionary. <a data-link-type="biblio" href="#biblio-webidl">[WEBIDL]</a></p>
      <li data-md>
       <p>Let <var>x</var> and <var>y</var> be the arguments, respectively.</p>
      <li data-md>
       <p>Let the <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-left" id="ref-for-dom-scrolltooptions-left①">left</a></code> dictionary member of <var>options</var> have the value <var>x</var>.</p>
      <li data-md>
       <p>Let the <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-top" id="ref-for-dom-scrolltooptions-top①">top</a></code> dictionary member of <var>options</var> have the value <var>y</var>.</p>
     </ol>
    <li data-md>
     <p><a data-link-type="dfn" href="#normalize-non-finite-values" id="ref-for-normalize-non-finite-values①">Normalize non-finite values</a> for the <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-left" id="ref-for-dom-scrolltooptions-left②">left</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-top" id="ref-for-dom-scrolltooptions-top②">top</a></code> dictionary members of <var>options</var>.</p>
    <li data-md>
     <p>Add the value of <code class="idl"><a data-link-type="idl" href="#dom-window-scrollx" id="ref-for-dom-window-scrollx②">scrollX</a></code> to the <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-left" id="ref-for-dom-scrolltooptions-left③">left</a></code> dictionary member.</p>
    <li data-md>
     <p>Add the value of <code class="idl"><a data-link-type="idl" href="#dom-window-scrolly" id="ref-for-dom-window-scrolly②">scrollY</a></code> to the <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-top" id="ref-for-dom-scrolltooptions-top③">top</a></code> dictionary member.</p>
    <li data-md>
     <p>Act as if the <code class="idl"><a data-link-type="idl" href="#dom-window-scroll" id="ref-for-dom-window-scroll③">scroll()</a></code> method was invoked with <var>options</var> as the only argument.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="attribute" data-export id="dom-window-screenx"><code>screenX</code></dfn> and <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="attribute" data-export id="dom-window-screenleft"><code>screenLeft</code></dfn> attributes must return the x-coordinate,
relative to the origin of the <a data-link-type="dfn" href="#web-exposed-screen-area" id="ref-for-web-exposed-screen-area">Web-exposed screen area</a>, of the left of
the client window as number of <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px①③">CSS pixels</a>, or zero if there is no such
thing.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="attribute" data-export id="dom-window-screeny"><code>screenY</code></dfn> and <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="attribute" data-export id="dom-window-screentop"><code>screenTop</code></dfn> attributes must return the y-coordinate,
relative to the origin of the screen of the <a data-link-type="dfn" href="#web-exposed-screen-area" id="ref-for-web-exposed-screen-area①">Web-exposed screen area</a>, of the top of
the client window as number of <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px①④">CSS pixels</a>, or zero if there is no such
thing.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="attribute" data-export id="dom-window-outerwidth"><code>outerWidth</code></dfn> attribute must return the width of the
client window. If there is no client window this
attribute must return zero.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="attribute" data-export id="dom-window-outerheight"><code>outerHeight</code></dfn> attribute must return the height of the
client window. If there is no client window this
attribute must return zero.</p>
   <p>The <dfn class="caniuse-paneled dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="attribute" data-export id="dom-window-devicepixelratio"><code>devicePixelRatio</code></dfn> attribute must return the result of the following <dfn data-dfn-type="dfn" data-export id="determine-the-device-pixel-ratio">determine the device pixel ratio<a class="self-link" href="#determine-the-device-pixel-ratio"></a></dfn> algorithm:</p>
   <ol>
    <li data-md>
     <p>If there is no output device, return 1 and abort these steps.</p>
    <li data-md>
     <p>Let <var>CSS pixel size</var> be the size of a <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px①⑤">CSS pixel</a> at the current <a data-link-type="dfn" href="#page-zoom" id="ref-for-page-zoom">page zoom</a> scale factor and at a <a data-link-type="dfn" href="#pinch-zoom" id="ref-for-pinch-zoom">pinch zoom</a> scale factor of 1.0.</p>
    <li data-md>
     <p>Let <var>device pixel size</var> be the vertical size of a device pixel of the output device.</p>
    <li data-md>
     <p>Return the result of dividing <var>CSS pixel size</var> by <var>device pixel size</var>.</p>
   </ol>
   <h3 class="heading settled" data-level="4.1" id="the-features-argument-to-the-open()-method"><span class="secno">4.1. </span><span class="content">The <var>features</var> argument to the <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#dom-open" id="ref-for-dom-open">open()</a></code> method</span><a class="self-link" href="#the-features-argument-to-the-open()-method"></a></h3>
   <p>HTML defines the <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#dom-open" id="ref-for-dom-open①">open()</a></code> method. This section defines behavior for position and size given
in the <var>features</var> argument. <a data-link-type="biblio" href="#biblio-html">[HTML]</a></p>
   <p>To <dfn data-dfn-type="dfn" data-export id="set-up-browsing-context-features">set up browsing context features<a class="self-link" href="#set-up-browsing-context-features"></a></dfn> for a browsing context <var>target</var> given a <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#ordered-map" id="ref-for-ordered-map">map</a> <var>tokenizedFeatures</var>:</p>
   <ol>
    <li data-md>
     <p>Let <var>x</var> be null.</p>
    <li data-md>
     <p>Let <var>y</var> be null.</p>
    <li data-md>
     <p>Let <var>width</var> be null.</p>
    <li data-md>
     <p>Let <var>height</var> be null.</p>
    <li data-md>
     <p>If <var>tokenizedFeatures</var>["<a data-link-type="dfn" href="#supported-open-feature-name-left" id="ref-for-supported-open-feature-name-left">left</a>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists">exists</a>:</p>
     <ol>
      <li data-md>
       <p>Set <var>x</var> to the result of invoking the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#rules-for-parsing-integers" id="ref-for-rules-for-parsing-integers">rules for parsing integers</a> on <var>tokenizedFeatures</var>["<a data-link-type="dfn" href="#supported-open-feature-name-left" id="ref-for-supported-open-feature-name-left①">left</a>"].</p>
      <li data-md>
       <p>If <var>x</var> is an error, set <var>x</var> to 0.</p>
      <li data-md>
       <p>Optionally, clamp <var>x</var> in a user-agent-defined manner so that the window does not
move outside the <a data-link-type="dfn" href="#web-exposed-available-screen-area" id="ref-for-web-exposed-available-screen-area">Web-exposed available screen area</a>.</p>
      <li data-md>
       <p>Optionally, move <var>target</var>’s window such that the window’s left edge is at the
horizontal coordinate <var>x</var> relative to the left edge of the <a data-link-type="dfn" href="#web-exposed-screen-area" id="ref-for-web-exposed-screen-area②">Web-exposed screen
area</a>, measured in <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px①⑥">CSS pixels</a> of <var>target</var>. The positive axis is rightward.</p>
     </ol>
    <li data-md>
     <p>If <var>tokenizedFeatures</var>["<a data-link-type="dfn" href="#supported-open-feature-name-top" id="ref-for-supported-open-feature-name-top">top</a>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists①">exists</a>:</p>
     <ol>
      <li data-md>
       <p>Set <var>y</var> to the result of invoking the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#rules-for-parsing-integers" id="ref-for-rules-for-parsing-integers①">rules for parsing integers</a> on <var>tokenizedFeatures</var>["<a data-link-type="dfn" href="#supported-open-feature-name-top" id="ref-for-supported-open-feature-name-top①">top</a>"].</p>
      <li data-md>
       <p>If <var>y</var> is an error, set <var>y</var> to 0.</p>
      <li data-md>
       <p>Optionally, clamp <var>y</var> in a user-agent-defined manner so that the window does not
move outside the <a data-link-type="dfn" href="#web-exposed-available-screen-area" id="ref-for-web-exposed-available-screen-area①">Web-exposed available screen area</a>.</p>
      <li data-md>
       <p>Optionally, move <var>target</var>’s window such that the window’s top edge is at the
vertical coordinate <var>y</var> relative to the top edge of the <a data-link-type="dfn" href="#web-exposed-screen-area" id="ref-for-web-exposed-screen-area③">Web-exposed screen
area</a>, measured in <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px①⑦">CSS pixels</a> of <var>target</var>. The positive axis is downward.</p>
     </ol>
    <li data-md>
     <p>If <var>tokenizedFeatures</var>["<a data-link-type="dfn" href="#supported-open-feature-name-width" id="ref-for-supported-open-feature-name-width">width</a>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists②">exists</a>:</p>
     <ol>
      <li data-md>
       <p>Set <var>width</var> to the result of invoking the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#rules-for-parsing-integers" id="ref-for-rules-for-parsing-integers②">rules for parsing integers</a> on <var>tokenizedFeatures</var>["<a data-link-type="dfn" href="#supported-open-feature-name-width" id="ref-for-supported-open-feature-name-width①">width</a>"].</p>
      <li data-md>
       <p>If <var>width</var> is an error, set <var>width</var> to 0.</p>
      <li data-md>
       <p>If <var>width</var> is not 0:</p>
       <ol>
        <li data-md>
         <p>Optionally, clamp <var>width</var> in a user-agent-defined manner so that the window does
not get too small or bigger than the <a data-link-type="dfn" href="#web-exposed-available-screen-area" id="ref-for-web-exposed-available-screen-area②">Web-exposed available screen area</a>.</p>
        <li data-md>
         <p>Optionally, size <var>target</var>’s window by moving its right edge such that the
distance between the left and right edges of the viewport are <var>width</var> <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px①⑧">CSS pixels</a> of <var>target</var>.</p>
        <li data-md>
         <p>Optionally, move <var>target</var>’s window in a user-agent-defined manner so that it
does not grow outside the <a data-link-type="dfn" href="#web-exposed-available-screen-area" id="ref-for-web-exposed-available-screen-area③">Web-exposed available screen area</a>.</p>
       </ol>
     </ol>
    <li data-md>
     <p>If <var>tokenizedFeatures</var>["<a data-link-type="dfn" href="#supported-open-feature-name-height" id="ref-for-supported-open-feature-name-height">height</a>"] <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#map-exists" id="ref-for-map-exists③">exists</a>:</p>
     <ol>
      <li data-md>
       <p>Set <var>height</var> to the result of invoking the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#rules-for-parsing-integers" id="ref-for-rules-for-parsing-integers③">rules for parsing integers</a> on <var>tokenizedFeatures</var>["<a data-link-type="dfn" href="#supported-open-feature-name-height" id="ref-for-supported-open-feature-name-height①">height</a>"].</p>
      <li data-md>
       <p>If <var>height</var> is an error, set <var>height</var> to 0.</p>
      <li data-md>
       <p>If <var>height</var> is not 0:</p>
       <ol>
        <li data-md>
         <p>Optionally, clamp <var>height</var> in a user-agent-defined manner so that the window
does not get too small or bigger than the <a data-link-type="dfn" href="#web-exposed-available-screen-area" id="ref-for-web-exposed-available-screen-area④">Web-exposed available screen area</a>.</p>
        <li data-md>
         <p>Optionally, size <var>target</var>’s window by moving its bottom edge such that the
distance between the top and bottom edges of the viewport are <var>height</var> <a class="css" data-link-type="value" href="https://drafts.csswg.org/css-values-4/#px" id="ref-for-px①⑨">CSS pixels</a> of <var>target</var>.</p>
        <li data-md>
         <p>Optionally, move <var>target</var>’s window in a user-agent-defined manner so that it
does not grow outside the <a data-link-type="dfn" href="#web-exposed-available-screen-area" id="ref-for-web-exposed-available-screen-area⑤">Web-exposed available screen area</a>.</p>
       </ol>
     </ol>
   </ol>
   <p>A <dfn data-dfn-type="dfn" data-export id="supported-open-feature-name">supported <code>open()</code> feature name<a class="self-link" href="#supported-open-feature-name"></a></dfn> is one of the following:</p>
   <dl>
    <dt><dfn class="dfn-paneled" data-dfn-for="supported open() feature name" data-dfn-type="dfn" data-export id="supported-open-feature-name-width">width</dfn> 
    <dd>The width of the viewport. 
    <dt><dfn class="dfn-paneled" data-dfn-for="supported open() feature name" data-dfn-type="dfn" data-export id="supported-open-feature-name-height">height</dfn> 
    <dd>The height of the viewport. 
    <dt><dfn class="dfn-paneled" data-dfn-for="supported open() feature name" data-dfn-type="dfn" data-export id="supported-open-feature-name-left">left</dfn> 
    <dd>The left position of the window. 
    <dt><dfn class="dfn-paneled" data-dfn-for="supported open() feature name" data-dfn-type="dfn" data-export id="supported-open-feature-name-top">top</dfn> 
    <dd>The top position of the window. 
   </dl>
   <h3 class="heading settled" data-level="4.2" id="the-mediaquerylist-interface"><span class="secno">4.2. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#mediaquerylist" id="ref-for-mediaquerylist②">MediaQueryList</a></code> Interface</span><a class="self-link" href="#the-mediaquerylist-interface"></a></h3>
   <p>This section integrates with the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-agent-event-loop" id="ref-for-concept-agent-event-loop">event loop</a> defined in HTML. <a data-link-type="biblio" href="#biblio-html">[HTML]</a></p>
   <p>A <code class="idl"><a data-link-type="idl" href="#mediaquerylist" id="ref-for-mediaquerylist③">MediaQueryList</a></code> object has an associated <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="media-query-list">media query list</dfn> and an associated <dfn class="dfn-paneled" data-dfn-for="MediaQueryList" data-dfn-type="dfn" data-noexport id="mediaquerylist-document">document</dfn> set on creation.</p>
   <p>A <code class="idl"><a data-link-type="idl" href="#mediaquerylist" id="ref-for-mediaquerylist④">MediaQueryList</a></code> object has an associated <dfn class="dfn-paneled" data-dfn-for="MediaQueryList" data-dfn-type="dfn" data-noexport id="mediaquerylist-media">media</dfn> which is the <a data-link-type="dfn" href="https://drafts.csswg.org/cssom/#serialize-a-media-query-list" id="ref-for-serialize-a-media-query-list">serialized</a> form of the associated <a data-link-type="dfn" href="#media-query-list" id="ref-for-media-query-list①">media query list</a>.</p>
   <p>A <code class="idl"><a data-link-type="idl" href="#mediaquerylist" id="ref-for-mediaquerylist⑤">MediaQueryList</a></code> object has an associated <dfn class="dfn-paneled" data-dfn-for="MediaQueryList" data-dfn-type="dfn" data-noexport id="mediaquerylist-matches-state">matches state</dfn> which is
true if the associated <a data-link-type="dfn" href="#media-query-list" id="ref-for-media-query-list②">media query list</a> matches the state of the <a data-link-type="dfn" href="#mediaquerylist-document" id="ref-for-mediaquerylist-document①">document</a>, and false otherwise.</p>
   <p>When asked to <dfn data-dfn-type="dfn" data-noexport id="evaluate-media-queries-and-report-changes">evaluate media queries and report changes<a class="self-link" href="#evaluate-media-queries-and-report-changes"></a></dfn> for a <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document②">Document</a></code> <var>doc</var>, run these steps:</p>
   <ol>
    <li>
     <p>For each <code class="idl"><a data-link-type="idl" href="#mediaquerylist" id="ref-for-mediaquerylist⑥">MediaQueryList</a></code> object <var>target</var> that has <var>doc</var> as its <a data-link-type="dfn" href="#mediaquerylist-document" id="ref-for-mediaquerylist-document②">document</a>,
  in the order they were created, oldest first, run these substeps:</p>
     <ol>
      <li>If <var>target</var>’s <a data-link-type="dfn" href="#mediaquerylist-matches-state" id="ref-for-mediaquerylist-matches-state">matches state</a> has changed since the last time these steps were run, <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-event-fire" id="ref-for-concept-event-fire">fire an event</a> at <var>target</var> using the <code class="idl"><a data-link-type="idl" href="#mediaquerylistevent" id="ref-for-mediaquerylistevent">MediaQueryListEvent</a></code> constructor,
   with its <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#dom-event-type" id="ref-for-dom-event-type">type</a></code> attribute initialized to <a class="idl-code" data-link-type="event" href="#eventdef-mediaquerylist-change" id="ref-for-eventdef-mediaquerylist-change">change</a>,
   its <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#dom-event-istrusted" id="ref-for-dom-event-istrusted">isTrusted</a></code> attribute initialized to true,
   its <code class="idl"><a data-link-type="idl" href="#dom-mediaquerylist-media" id="ref-for-dom-mediaquerylist-media">media</a></code> attribute initialized to <var>target</var>’s <a data-link-type="dfn" href="#mediaquerylist-media" id="ref-for-mediaquerylist-media">media</a>,
   and its <code class="idl"><a data-link-type="idl" href="#dom-mediaquerylistevent-matches" id="ref-for-dom-mediaquerylistevent-matches">matches</a></code> attribute initialized to <var>target</var>’s <span id="ref-for-mediaquerylist-matches-state①">matches state</span>. 
     </ol>
   </ol>
   <div class="example" id="example-5ecb609e">
    <a class="self-link" href="#example-5ecb609e"></a> A simple piece of code that detects changes in the orientation of the viewport can be written as follows: 
<pre class="highlight"><c- a>function</c-> handleOrientationChange<c- p>(</c->event<c- p>)</c-> <c- p>{</c->
    <c- k>if</c-><c- p>(</c->event<c- p>.</c->matches<c- p>)</c-> <c- c1>// landscape</c->
        …
    <c- k>else</c->
        …
<c- p>}</c->
<c- a>var</c-> mql <c- o>=</c-> matchMedia<c- p>(</c-><c- u>"(orientation:landscape)"</c-><c- p>);</c->
mql<c- p>.</c->onchange <c- o>=</c-> handleOrientationChange<c- p>;</c->
</pre>
   </div>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="mediaquerylist"><code><c- g>MediaQueryList</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#eventtarget" id="ref-for-eventtarget"><c- n>EventTarget</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring①"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#dom-mediaquerylist-media" id="ref-for-dom-mediaquerylist-media①"><c- g>media</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-mediaquerylist-matches" id="ref-for-dom-mediaquerylist-matches"><c- g>matches</c-></a>;
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-mediaquerylist-addlistener" id="ref-for-dom-mediaquerylist-addlistener"><c- g>addListener</c-></a>(<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#callbackdef-eventlistener" id="ref-for-callbackdef-eventlistener"><c- n>EventListener</c-></a>? <dfn class="idl-code" data-dfn-for="MediaQueryList/addListener(callback)" data-dfn-type="argument" data-export id="dom-mediaquerylist-addlistener-callback-callback"><code><c- g>callback</c-></code><a class="self-link" href="#dom-mediaquerylist-addlistener-callback-callback"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-mediaquerylist-removelistener" id="ref-for-dom-mediaquerylist-removelistener"><c- g>removeListener</c-></a>(<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#callbackdef-eventlistener" id="ref-for-callbackdef-eventlistener①"><c- n>EventListener</c-></a>? <dfn class="idl-code" data-dfn-for="MediaQueryList/removeListener(callback)" data-dfn-type="argument" data-export id="dom-mediaquerylist-removelistener-callback-callback"><code><c- g>callback</c-></code><a class="self-link" href="#dom-mediaquerylist-removelistener-callback-callback"></a></dfn>);
           <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler" id="ref-for-eventhandler"><c- n>EventHandler</c-></a> <a class="idl-code" data-link-type="attribute" data-type="EventHandler" href="#dom-mediaquerylist-onchange" id="ref-for-dom-mediaquerylist-onchange"><c- g>onchange</c-></a>;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaQueryList" data-dfn-type="attribute" data-export id="dom-mediaquerylist-media"><code>media</code></dfn> attribute must return
the associated <a data-link-type="dfn" href="#mediaquerylist-media" id="ref-for-mediaquerylist-media①">media</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaQueryList" data-dfn-type="attribute" data-export id="dom-mediaquerylist-matches"><code>matches</code></dfn> attribute must return
the associated <a data-link-type="dfn" href="#mediaquerylist-matches-state" id="ref-for-mediaquerylist-matches-state②">matches state</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaQueryList" data-dfn-type="method" data-export id="dom-mediaquerylist-addlistener"><code>addListener(<var>callback</var>)</code></dfn> method,
when invoked, must run these steps:</p>
   <ol>
    <li data-md>
     <p><a data-link-type="dfn" href="https://dom.spec.whatwg.org/#add-an-event-listener" id="ref-for-add-an-event-listener">Add an event listener</a> with the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object⑤">context object</a> and an <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-event-listener" id="ref-for-concept-event-listener">event listener</a> whose <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#event-listener-type" id="ref-for-event-listener-type">type</a> is <code>change</code>,
and <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#event-listener-callback" id="ref-for-event-listener-callback">callback</a> is <var>callback</var>.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaQueryList" data-dfn-type="method" data-export id="dom-mediaquerylist-removelistener"><code>removeListener(<var>callback</var>)</code></dfn> method,
when invoked, must run these steps:</p>
   <ol>
    <li data-md>
     <p>If the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#context-object" id="ref-for-context-object⑥">context object</a>’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#eventtarget-event-listener-list" id="ref-for-eventtarget-event-listener-list">event listener list</a> <a data-link-type="dfn" href="https://infra.spec.whatwg.org/#list-contain" id="ref-for-list-contain">contains</a> an <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-event-listener" id="ref-for-concept-event-listener①">event listener</a> whose <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#event-listener-type" id="ref-for-event-listener-type①">type</a> is <code>change</code>, <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#event-listener-callback" id="ref-for-event-listener-callback①">callback</a> is <var>callback</var>,
and <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#event-listener-capture" id="ref-for-event-listener-capture">capture</a> is false,
then <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#remove-an-event-listener" id="ref-for-remove-an-event-listener">remove an event listener</a> with
the <span id="ref-for-context-object⑦">context object</span> and that <span id="ref-for-concept-event-listener②">event listener</span>.</p>
   </ol>
   <p class="note" role="note"><span>Note:</span> This specification initially had a custom callback mechanism with <code class="idl"><a data-link-type="idl" href="#dom-mediaquerylist-addlistener" id="ref-for-dom-mediaquerylist-addlistener①">addListener()</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-mediaquerylist-removelistener" id="ref-for-dom-mediaquerylist-removelistener①">removeListener()</a></code>, and the callback was invoked with the associated media query list as argument.
Now the normal event mechanism is used instead.
For backwards compatibility, the <code class="idl"><a data-link-type="idl" href="#dom-mediaquerylist-addlistener" id="ref-for-dom-mediaquerylist-addlistener②">addListener()</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-mediaquerylist-removelistener" id="ref-for-dom-mediaquerylist-removelistener②">removeListener()</a></code> methods
are basically aliases for <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#dom-eventtarget-addeventlistener" id="ref-for-dom-eventtarget-addeventlistener">addEventListener()</a></code> and <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#dom-eventtarget-removeeventlistener" id="ref-for-dom-eventtarget-removeeventlistener">removeEventListener()</a></code>, respectively,
and the <code>change</code> event masquerades as a <code class="idl"><a data-link-type="idl" href="#mediaquerylist" id="ref-for-mediaquerylist⑦">MediaQueryList</a></code>.</p>
   <p>The following are the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handlers" id="ref-for-event-handlers">event handlers</a> (and their corresponding <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-event-type" id="ref-for-event-handler-event-type">event handler event types</a>) that must be supported,
as <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-idl-attributes" id="ref-for-event-handler-idl-attributes">event handler IDL attributes</a>, by all objects implementing the <code class="idl"><a data-link-type="idl" href="#mediaquerylist" id="ref-for-mediaquerylist⑧">MediaQueryList</a></code> interface:</p>
   <table class="complex data">
    <thead>
     <tr>
      <th><a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handlers" id="ref-for-event-handlers①">Event handler</a> 
      <th><a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#event-handler-event-type" id="ref-for-event-handler-event-type①">Event handler event type</a> 
    <tbody>
     <tr>
      <td><dfn class="dfn-paneled idl-code" data-dfn-for="MediaQueryList" data-dfn-type="attribute" data-export id="dom-mediaquerylist-onchange"><code>onchange</code></dfn> 
      <td><a class="idl-code" data-link-type="event" href="#eventdef-mediaquerylist-change" id="ref-for-eventdef-mediaquerylist-change①">change</a> 
   </table>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed①"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="mediaquerylistevent"><code><c- g>MediaQueryListEvent</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#event" id="ref-for-event"><c- n>Event</c-></a> {
  <dfn class="idl-code" data-dfn-for="MediaQueryListEvent" data-dfn-type="constructor" data-export data-lt="MediaQueryListEvent(type, eventInitDict)|constructor(type, eventInitDict)|MediaQueryListEvent(type)|constructor(type)" id="dom-mediaquerylistevent-mediaquerylistevent"><code><c- g>constructor</c-></code><a class="self-link" href="#dom-mediaquerylistevent-mediaquerylistevent"></a></dfn>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring②"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-dfn-for="MediaQueryListEvent/MediaQueryListEvent(type, eventInitDict), MediaQueryListEvent/constructor(type, eventInitDict), MediaQueryListEvent/MediaQueryListEvent(type), MediaQueryListEvent/constructor(type)" data-dfn-type="argument" data-export id="dom-mediaquerylistevent-mediaquerylistevent-type-eventinitdict-type"><code><c- g>type</c-></code><a class="self-link" href="#dom-mediaquerylistevent-mediaquerylistevent-type-eventinitdict-type"></a></dfn>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-mediaquerylisteventinit" id="ref-for-dictdef-mediaquerylisteventinit"><c- n>MediaQueryListEventInit</c-></a> <dfn class="idl-code" data-dfn-for="MediaQueryListEvent/MediaQueryListEvent(type, eventInitDict), MediaQueryListEvent/constructor(type, eventInitDict), MediaQueryListEvent/MediaQueryListEvent(type), MediaQueryListEvent/constructor(type)" data-dfn-type="argument" data-export id="dom-mediaquerylistevent-mediaquerylistevent-type-eventinitdict-eventinitdict"><code><c- g>eventInitDict</c-></code><a class="self-link" href="#dom-mediaquerylistevent-mediaquerylistevent-type-eventinitdict-eventinitdict"></a></dfn> = {});
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring③"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#dom-mediaquerylistevent-media" id="ref-for-dom-mediaquerylistevent-media"><c- g>media</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean①"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-mediaquerylistevent-matches" id="ref-for-dom-mediaquerylistevent-matches①"><c- g>matches</c-></a>;
};

<c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-mediaquerylisteventinit"><code><c- g>MediaQueryListEventInit</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#dictdef-eventinit" id="ref-for-dictdef-eventinit"><c- n>EventInit</c-></a> {
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring" id="ref-for-cssomstring④"><c- n>CSSOMString</c-></a> <dfn class="idl-code" data-default="&quot;&quot;" data-dfn-for="MediaQueryListEventInit" data-dfn-type="dict-member" data-export data-type="CSSOMString " id="dom-mediaquerylisteventinit-media"><code><c- g>media</c-></code><a class="self-link" href="#dom-mediaquerylisteventinit-media"></a></dfn> = "";
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean②"><c- b>boolean</c-></a> <dfn class="idl-code" data-default="false" data-dfn-for="MediaQueryListEventInit" data-dfn-type="dict-member" data-export data-type="boolean " id="dom-mediaquerylisteventinit-matches"><code><c- g>matches</c-></code><a class="self-link" href="#dom-mediaquerylisteventinit-matches"></a></dfn> = <c- b>false</c->;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaQueryListEvent" data-dfn-type="attribute" data-export id="dom-mediaquerylistevent-media"><code>media</code></dfn> attribute must return the value it was initialized to.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MediaQueryListEvent" data-dfn-type="attribute" data-export id="dom-mediaquerylistevent-matches"><code>matches</code></dfn> attribute must return the value it was initialized to.</p>
   <h4 class="heading settled" data-level="4.2.1" id="mediaquerylist-event-summary"><span class="secno">4.2.1. </span><span class="content">Event summary</span><a class="self-link" href="#mediaquerylist-event-summary"></a></h4>
   <p><i>This section is non-normative.</i></p>
   <table class="complex data">
    <thead>
     <tr>
      <th>Event 
      <th>Interface 
      <th>Interesting targets 
      <th>Description 
    <tbody>
     <tr>
      <td><dfn class="dfn-paneled idl-code" data-dfn-for="MediaQueryList" data-dfn-type="event" data-export id="eventdef-mediaquerylist-change"><code>change</code></dfn> 
      <td><code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#event" id="ref-for-event①">Event</a></code> 
      <td><code class="idl"><a data-link-type="idl" href="#mediaquerylist" id="ref-for-mediaquerylist⑨">MediaQueryList</a></code> 
      <td>Fired at the <code class="idl"><a data-link-type="idl" href="#mediaquerylist" id="ref-for-mediaquerylist①⓪">MediaQueryList</a></code> when the <a data-link-type="dfn" href="#mediaquerylist-matches-state" id="ref-for-mediaquerylist-matches-state③">matches state</a> changes. 
   </table>
   <h3 class="heading settled" data-level="4.3" id="the-screen-interface"><span class="secno">4.3. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#screen" id="ref-for-screen②">Screen</a></code> Interface</span><a class="self-link" href="#the-screen-interface"></a></h3>
   <p>As its name suggests, the <code class="idl"><a data-link-type="idl" href="#screen" id="ref-for-screen③">Screen</a></code> interface represents information about the screen of the output device.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed②"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="screen"><code><c- g>Screen</c-></code></dfn> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long①⑥"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-screen-availwidth" id="ref-for-dom-screen-availwidth"><c- g>availWidth</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long①⑦"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-screen-availheight" id="ref-for-dom-screen-availheight"><c- g>availHeight</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long①⑧"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-screen-width" id="ref-for-dom-screen-width"><c- g>width</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long①⑨"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-screen-height" id="ref-for-dom-screen-height"><c- g>height</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned long" href="#dom-screen-colordepth" id="ref-for-dom-screen-colordepth"><c- g>colorDepth</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long①"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned long" href="#dom-screen-pixeldepth" id="ref-for-dom-screen-pixeldepth"><c- g>pixelDepth</c-></a>;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Screen" data-dfn-type="attribute" data-export id="dom-screen-availwidth"><code>availWidth</code></dfn> attribute must return the width of the <a data-link-type="dfn" href="#web-exposed-available-screen-area" id="ref-for-web-exposed-available-screen-area⑥">Web-exposed
available screen area</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Screen" data-dfn-type="attribute" data-export id="dom-screen-availheight"><code>availHeight</code></dfn> attribute must return the height of the <a data-link-type="dfn" href="#web-exposed-available-screen-area" id="ref-for-web-exposed-available-screen-area⑦">Web-exposed available screen area</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Screen" data-dfn-type="attribute" data-export id="dom-screen-width"><code>width</code></dfn> attribute must return the width of the <a data-link-type="dfn" href="#web-exposed-screen-area" id="ref-for-web-exposed-screen-area④">Web-exposed
screen area</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Screen" data-dfn-type="attribute" data-export id="dom-screen-height"><code>height</code></dfn> attribute must return the height of the <a data-link-type="dfn" href="#web-exposed-screen-area" id="ref-for-web-exposed-screen-area⑤">Web-exposed
screen area</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Screen" data-dfn-type="attribute" data-export id="dom-screen-colordepth"><code>colorDepth</code></dfn> and <dfn class="dfn-paneled idl-code" data-dfn-for="Screen" data-dfn-type="attribute" data-export id="dom-screen-pixeldepth"><code>pixelDepth</code></dfn> attributes should return the number of bits
allocated to colors for a pixel in the output device, excluding the alpha
channel. If the user agent is not able to return the number of bits used by the
output device, it should return the closest estimation such as, for example, the
number of bits used by the frame buffer sent to the display or any internal
representation that would be the closest to the value the output device would
use. The user agent must return a value for these attributes at least equal to
the value of <a data-link-type="dfn" href="https://drafts.csswg.org/mediaqueries-4/#mf-colors" id="ref-for-mf-colors">color media query</a> multiplied by three. If the different
color components are not represented with the same number of bits, the returned
value may be greater than three times <span id="ref-for-mf-colors①">color media query</span>. If the user
agent does not know the color depth or does not want to return it for privacy
considerations, it should return 24.</p>
   <p class="note" role="note"><span>Note:</span> The <code class="idl"><a data-link-type="idl" href="#dom-screen-colordepth" id="ref-for-dom-screen-colordepth①">colorDepth</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-screen-pixeldepth" id="ref-for-dom-screen-pixeldepth①">pixelDepth</a></code> attributes return the same value for
compatibility reasons.</p>
   <p class="note" role="note"><span>Note:</span> Some non-conforming implementations are known to return 32 instead of 24.</p>
   <div class="example" id="example-bab41bd9">
    <a class="self-link" href="#example-bab41bd9"></a> <code>colorDepth</code> can be used in the context of selecting SDR/HDR in
  addition with other information. For example, combined with color gamut. 
<pre class="highlight"><c- k>if</c-> <c- p>(</c->screen<c- p>.</c->colorDepth <c- o>>=</c-> <c- mi>48</c->   <c- o>&amp;&amp;</c-> window<c- p>.</c->matchMedia<c- p>(</c-><c- t>'(color-gamut: p3)'</c-><c- p>).</c->matches <c- o>&amp;&amp;</c->
    <c- d>/* other checks */</c-><c- p>)</c-> <c- p>{</c->
  <c- c1>// Use HDR content.</c->
<c- p>}</c-> <c- k>else</c-> <c- p>{</c->
  <c- c1>// Use SDR content.</c->
<c- p>}</c->
</pre>
   </div>
   <h2 class="heading settled" data-level="5" id="extensions-to-the-document-interface"><span class="secno">5. </span><span class="content">Extensions to the <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document③">Document</a></code> Interface</span><a class="self-link" href="#extensions-to-the-document-interface"></a></h2>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://dom.spec.whatwg.org/#document" id="ref-for-document④"><c- g>Document</c-></a> {
  <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element" id="ref-for-element"><c- n>Element</c-></a>? <a class="idl-code" data-link-type="method" href="#dom-document-elementfrompoint" id="ref-for-dom-document-elementfrompoint"><c- g>elementFromPoint</c-></a>(<a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double⑤"><c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Document/elementFromPoint(x, y)" data-dfn-type="argument" data-export id="dom-document-elementfrompoint-x-y-x"><code><c- g>x</c-></code><a class="self-link" href="#dom-document-elementfrompoint-x-y-x"></a></dfn>, <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double⑥"><c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Document/elementFromPoint(x, y)" data-dfn-type="argument" data-export id="dom-document-elementfrompoint-x-y-y"><code><c- g>y</c-></code><a class="self-link" href="#dom-document-elementfrompoint-x-y-y"></a></dfn>);
  <c- b>sequence</c->&lt;<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element" id="ref-for-element①"><c- n>Element</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-document-elementsfrompoint" id="ref-for-dom-document-elementsfrompoint"><c- g>elementsFromPoint</c-></a>(<a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double⑦"><c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Document/elementsFromPoint(x, y)" data-dfn-type="argument" data-export id="dom-document-elementsfrompoint-x-y-x"><code><c- g>x</c-></code><a class="self-link" href="#dom-document-elementsfrompoint-x-y-x"></a></dfn>, <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double⑧"><c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Document/elementsFromPoint(x, y)" data-dfn-type="argument" data-export id="dom-document-elementsfrompoint-x-y-y"><code><c- g>y</c-></code><a class="self-link" href="#dom-document-elementsfrompoint-x-y-y"></a></dfn>);
  <a class="n" data-link-type="idl-name" href="#caretposition" id="ref-for-caretposition"><c- n>CaretPosition</c-></a>? <a class="idl-code" data-link-type="method" href="#dom-document-caretpositionfrompoint" id="ref-for-dom-document-caretpositionfrompoint"><c- g>caretPositionFromPoint</c-></a>(<a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double⑨"><c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Document/caretPositionFromPoint(x, y)" data-dfn-type="argument" data-export id="dom-document-caretpositionfrompoint-x-y-x"><code><c- g>x</c-></code><a class="self-link" href="#dom-document-caretpositionfrompoint-x-y-x"></a></dfn>, <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double①⓪"><c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Document/caretPositionFromPoint(x, y)" data-dfn-type="argument" data-export id="dom-document-caretpositionfrompoint-x-y-y"><code><c- g>y</c-></code><a class="self-link" href="#dom-document-caretpositionfrompoint-x-y-y"></a></dfn>);
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element" id="ref-for-element②"><c- n>Element</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="Element?" href="#dom-document-scrollingelement" id="ref-for-dom-document-scrollingelement"><c- g>scrollingElement</c-></a>;
};
</pre>
   <p>The <dfn class="caniuse-paneled dfn-paneled idl-code" data-dfn-for="Document" data-dfn-type="method" data-export id="dom-document-elementfrompoint"><code>elementFromPoint(<var>x</var>, <var>y</var>)</code></dfn> method must follow these steps:</p>
   <ol>
    <li data-md>
     <p>If either argument is negative, <var>x</var> is greater than the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport④⑦">viewport</a> width excluding the size of a rendered scroll bar (if any), or <var>y</var> is greater than the <span id="ref-for-viewport④⑧">viewport</span> height excluding the size of a rendered scroll bar (if any), or there is no <span id="ref-for-viewport④⑨">viewport</span> associated with the document, return null and terminate these steps.</p>
    <li data-md>
     <p>If there is a <a data-link-type="dfn" href="#layout-box" id="ref-for-layout-box">layout box</a> in the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑤⓪">viewport</a> that would be a target for hit testing at coordinates <var>x</var>,<var>y</var>,
when applying the <a data-link-type="dfn" href="#transforms" id="ref-for-transforms">transforms</a> that apply to the descendants of the <span id="ref-for-viewport⑤①">viewport</span>, return the associated element and terminate these steps.</p>
    <li data-md>
     <p>If the document has a root element, return the root element and terminate these steps.</p>
    <li data-md>
     <p>Return null.</p>
   </ol>
   <p class="note" role="note"><span>Note:</span> The <code class="idl"><a data-link-type="idl" href="#dom-document-elementfrompoint" id="ref-for-dom-document-elementfrompoint①">elementFromPoint()</a></code> method does not necessarily return the top-most painted element. For
instance, an element can be excluded from being a target for hit testing by using the <a class="property" data-link-type="propdesc" href="https://svgwg.org/svg2-draft/interact.html#PointerEventsProperty" id="ref-for-PointerEventsProperty">pointer-events</a> CSS property.</p>
   <p> The <dfn class="dfn-paneled idl-code" data-dfn-for="Document" data-dfn-type="method" data-export id="dom-document-elementsfrompoint"><code>elementsFromPoint(<var>x</var>, <var>y</var>)</code></dfn> method must follow these steps: </p>
   <ol>
    <li data-md>
     <p>Let <var>sequence</var> be a new empty sequence.</p>
    <li data-md>
     <p>If either argument is negative, <var>x</var> is greater than the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑤②">viewport</a> width excluding the size of a rendered scroll bar (if any), or <var>y</var> is greater than the <span id="ref-for-viewport⑤③">viewport</span> height excluding the size of a rendered scroll bar (if any), or there is no <span id="ref-for-viewport⑤④">viewport</span> associated with the document, return <var>sequence</var> and terminate these steps.</p>
    <li data-md>
     <p>For each <a data-link-type="dfn" href="#layout-box" id="ref-for-layout-box①">layout box</a> in the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑤⑤">viewport</a>, in paint order, starting with the topmost box, that would be a target for hit testing at
coordinates <var>x</var>,<var>y</var> even if nothing would be overlapping it, when applying the <a data-link-type="dfn" href="#transforms" id="ref-for-transforms①">transforms</a> that apply to the descendants of the <span id="ref-for-viewport⑤⑥">viewport</span>, append the associated element to <var>sequence</var>.</p>
    <li data-md>
     <p>If the document has a root element, and the last item in <var>sequence</var> is not the root element, append the root element to <var>sequence</var>.</p>
    <li data-md>
     <p>Return <var>sequence</var>.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Document" data-dfn-type="method" data-export id="dom-document-caretpositionfrompoint"><code>caretPositionFromPoint(<var>x</var>, <var>y</var>)</code></dfn> method must return the
result of running these steps:</p>
   <ol>
    <li data-md>
     <p>If there is no <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑤⑦">viewport</a> associated with the document, return null.</p>
    <li data-md>
     <p>If either argument is negative, <var>x</var> is greater
than the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑤⑧">viewport</a> width excluding the size of a rendered
scroll bar (if any), <var>y</var> is greater than the <span id="ref-for-viewport⑤⑨">viewport</span> height excluding the size of a rendered scroll bar
(if any) return null.</p>
    <li data-md>
     <p>If at the coordinates <var>x</var>,<var>y</var> in the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑥⓪">viewport</a> no text insertion point indicator would have
been inserted when applying the <a data-link-type="dfn" href="#transforms" id="ref-for-transforms②">transforms</a> that apply to the descendants of the <span id="ref-for-viewport⑥①">viewport</span>, return null.</p>
    <li data-md>
     <p>If at the coordinates <var>x</var>,<var>y</var> in the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑥②">viewport</a> a text insertion point indicator would have
been inserted in a text entry widget which is also a replaced element, when applying the <a data-link-type="dfn" href="#transforms" id="ref-for-transforms③">transforms</a> that apply to the descendants of the <span id="ref-for-viewport⑥③">viewport</span>, return a <a data-link-type="dfn" href="#caret-position" id="ref-for-caret-position">caret position</a> with its properties set as follows:</p>
     <dl>
      <dt><a data-link-type="dfn" href="#caret-node" id="ref-for-caret-node">caret node</a> 
      <dd>The node corresponding to the text entry widget. 
      <dt><a data-link-type="dfn" href="#caret-offset" id="ref-for-caret-offset">caret offset</a> 
      <dd>The amount of 16-bit units to the left of where the
    text insertion point indicator would have inserted. 
      <dt><a data-link-type="dfn" href="#caret-range" id="ref-for-caret-range">caret range</a> 
      <dd>null 
     </dl>
    <li data-md>
     <p>Otherwise, return a <a data-link-type="dfn" href="#caret-position" id="ref-for-caret-position①">caret position</a> where the <a data-link-type="dfn" href="#caret-range" id="ref-for-caret-range①">caret range</a> is a collapsed <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#range" id="ref-for-range">Range</a></code> object for the position
where the text insertion point indicator would have been inserted when applying the <a data-link-type="dfn" href="#transforms" id="ref-for-transforms④">transforms</a> that apply to the descendants of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑥④">viewport</a>, and the other properties are set as follows:</p>
     <dl>
      <dt><a data-link-type="dfn" href="#caret-node" id="ref-for-caret-node①">caret node</a> 
      <dd>The <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#dom-range-startcontainer" id="ref-for-dom-range-startcontainer">startContainer</a></code> of the <a data-link-type="dfn" href="#caret-range" id="ref-for-caret-range②">caret range</a>. 
      <dt><a data-link-type="dfn" href="#caret-offset" id="ref-for-caret-offset①">caret offset</a> 
      <dd>The <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#dom-range-startoffset" id="ref-for-dom-range-startoffset">startOffset</a></code> of
        the <a data-link-type="dfn" href="#caret-range" id="ref-for-caret-range③">caret range</a>. 
     </dl>
   </ol>
   <p class="note" role="note"><span>Note:</span> The specifics of hit testing are out of scope of this
specification and therefore the exact details of <code class="idl"><a data-link-type="idl" href="#dom-document-elementfrompoint" id="ref-for-dom-document-elementfrompoint②">elementFromPoint()</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-document-caretpositionfrompoint" id="ref-for-dom-document-caretpositionfrompoint①">caretPositionFromPoint()</a></code> are therefore too. Hit testing will hopefully be defined in a future
revision of CSS or HTML.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Document" data-dfn-type="attribute" data-export id="dom-document-scrollingelement"><code>scrollingElement</code></dfn> attribute, on getting, must run these steps: </p>
   <ol>
    <li data-md>
     <p>If the <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document⑤">Document</a></code> is in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks">quirks mode</a>, follow these substeps:</p>
     <ol>
      <li data-md>
       <p>If <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element①">the HTML <code>body</code> element</a> exists, and it is not <a data-link-type="dfn" href="#potentially-scrollable" id="ref-for-potentially-scrollable①">potentially scrollable</a>, return <span id="ref-for-the-html-body-element②">the HTML <code>body</code> element</span> and abort these steps.</p>
      <li data-md>
       <p>Return null and abort these steps.</p>
     </ol>
    <li data-md>
     <p>If there is a root element, return the root element and abort these steps.</p>
    <li data-md>
     <p>Return null.</p>
   </ol>
   <p class="note" role="note"><span>Note:</span> For non-conforming user agents that always use the <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks①">quirks mode</a> behavior for <code class="idl"><a data-link-type="idl" href="#dom-element-scrolltop" id="ref-for-dom-element-scrolltop">scrollTop</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-element-scrollleft" id="ref-for-dom-element-scrollleft">scrollLeft</a></code>, the <code class="idl"><a data-link-type="idl" href="#dom-document-scrollingelement" id="ref-for-dom-document-scrollingelement①">scrollingElement</a></code> attribute is expected to also always return <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element③">the HTML <code>body</code> element</a> (or null if it does not exist).
This API exists so that Web developers can use it to get the right element to use for scrolling APIs,
without making assumptions about a particular user agent’s behavior
or having to invoke a scroll to see which element scrolls the viewport.</p>
   <p class="note" role="note"><span>Note:</span> <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element④">The HTML <code>body</code> element</a> is different from HTML’s <code>document.body</code> in that the latter can return a <code>frameset</code> element.</p>
   <h3 class="heading settled" data-level="5.1" id="the-caretposition-interface"><span class="secno">5.1. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#caretposition" id="ref-for-caretposition①">CaretPosition</a></code> Interface</span><a class="self-link" href="#the-caretposition-interface"></a></h3>
   <p>A <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="caret-position">caret position</dfn> gives the position of a text insertion point indicator. It always has an associated <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="caret-node">caret node</dfn>, <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="caret-offset">caret offset</dfn>, and <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="caret-range">caret range</dfn>. It is represented by a <code class="idl"><a data-link-type="idl" href="#caretposition" id="ref-for-caretposition②">CaretPosition</a></code> object.</p>
<pre class="idl highlight def">[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed" id="ref-for-Exposed③"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="caretposition"><code><c- g>CaretPosition</c-></code></dfn> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#node" id="ref-for-node"><c- n>Node</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="Node" href="#dom-caretposition-offsetnode" id="ref-for-dom-caretposition-offsetnode"><c- g>offsetNode</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long" id="ref-for-idl-unsigned-long②"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned long" href="#dom-caretposition-offset" id="ref-for-dom-caretposition-offset"><c- g>offset</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject①"><c- g>NewObject</c-></a>] <a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect"><c- n>DOMRect</c-></a>? <a class="idl-code" data-link-type="method" href="#dom-caretposition-getclientrect" id="ref-for-dom-caretposition-getclientrect"><c- g>getClientRect</c-></a>();
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CaretPosition" data-dfn-type="attribute" data-export id="dom-caretposition-offsetnode"><code>offsetNode</code></dfn> attribute must return the <a data-link-type="dfn" href="#caret-node" id="ref-for-caret-node②">caret node</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CaretPosition" data-dfn-type="attribute" data-export id="dom-caretposition-offset"><code>offset</code></dfn> attribute must return the <a data-link-type="dfn" href="#caret-offset" id="ref-for-caret-offset②">caret offset</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="CaretPosition" data-dfn-type="method" data-export id="dom-caretposition-getclientrect"><code>getClientRect()</code></dfn> method must follow these steps,
aborting on the first step that returns a value:</p>
   <ol>
    <li data-md>
     <p>If <a data-link-type="dfn" href="#caret-range" id="ref-for-caret-range④">caret range</a> is not null:</p>
     <ol>
      <li data-md>
       <p>Let <var>list</var> be the result of invoking the <code class="idl"><a data-link-type="idl" href="#dom-range-getclientrects" id="ref-for-dom-range-getclientrects">getClientRects()</a></code> method on the range.</p>
      <li data-md>
       <p>If <var>list</var> is empty, return null.</p>
      <li data-md>
       <p>Return the <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect①">DOMRect</a></code> object in <var>list</var> at index 0.</p>
     </ol>
    <li data-md>
     <p>If <a data-link-type="dfn" href="#caret-node" id="ref-for-caret-node③">caret node</a> is a text entry widget that is a replaced element,
and that is in the document,
return a <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect②">DOMRect</a></code> object for the caret in the widget
as represented by the <a data-link-type="dfn" href="#caret-offset" id="ref-for-caret-offset③">caret offset</a> value.
The <a data-link-type="dfn" href="#transforms" id="ref-for-transforms⑤">transforms</a> that apply to the element and its ancestors are applied.</p>
    <li data-md>
     <p>Return null.</p>
   </ol>
   <p class="note" role="note"><span>Note:</span> This <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect③">DOMRect</a></code> object is not <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#live" id="ref-for-live">live</a>.</p>
   <h2 class="heading settled" data-level="6" id="extension-to-the-element-interface"><span class="secno">6. </span><span class="content">Extensions to the <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#element" id="ref-for-element③">Element</a></code> Interface</span><a class="self-link" href="#extension-to-the-element-interface"></a></h2>
<pre class="idl highlight def"><c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="enumdef-scrolllogicalposition"><code><c- g>ScrollLogicalPosition</c-></code></dfn> { <dfn class="idl-code" data-dfn-for="ScrollLogicalPosition" data-dfn-type="enum-value" data-export id="dom-scrolllogicalposition-start"><code><c- s>"start"</c-></code><a class="self-link" href="#dom-scrolllogicalposition-start"></a></dfn>, <dfn class="idl-code" data-dfn-for="ScrollLogicalPosition" data-dfn-type="enum-value" data-export id="dom-scrolllogicalposition-center"><code><c- s>"center"</c-></code><a class="self-link" href="#dom-scrolllogicalposition-center"></a></dfn>, <dfn class="idl-code" data-dfn-for="ScrollLogicalPosition" data-dfn-type="enum-value" data-export id="dom-scrolllogicalposition-end"><code><c- s>"end"</c-></code><a class="self-link" href="#dom-scrolllogicalposition-end"></a></dfn>, <dfn class="idl-code" data-dfn-for="ScrollLogicalPosition" data-dfn-type="enum-value" data-export id="dom-scrolllogicalposition-nearest"><code><c- s>"nearest"</c-></code><a class="self-link" href="#dom-scrolllogicalposition-nearest"></a></dfn> };
<c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-scrollintoviewoptions"><code><c- g>ScrollIntoViewOptions</c-></code></dfn> : <a class="n" data-link-type="idl-name" href="#dictdef-scrolloptions" id="ref-for-dictdef-scrolloptions①"><c- n>ScrollOptions</c-></a> {
  <a class="n" data-link-type="idl-name" href="#enumdef-scrolllogicalposition" id="ref-for-enumdef-scrolllogicalposition"><c- n>ScrollLogicalPosition</c-></a> <dfn class="dfn-paneled idl-code" data-default="&quot;start&quot;" data-dfn-for="ScrollIntoViewOptions" data-dfn-type="dict-member" data-export data-type="ScrollLogicalPosition " id="dom-scrollintoviewoptions-block"><code><c- g>block</c-></code></dfn> = "start";
  <a class="n" data-link-type="idl-name" href="#enumdef-scrolllogicalposition" id="ref-for-enumdef-scrolllogicalposition①"><c- n>ScrollLogicalPosition</c-></a> <dfn class="dfn-paneled idl-code" data-default="&quot;nearest&quot;" data-dfn-for="ScrollIntoViewOptions" data-dfn-type="dict-member" data-export data-type="ScrollLogicalPosition " id="dom-scrollintoviewoptions-inline"><code><c- g>inline</c-></code></dfn> = "nearest";
};

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://dom.spec.whatwg.org/#element" id="ref-for-element④"><c- g>Element</c-></a> {
  <a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domrectlist" id="ref-for-domrectlist"><c- n>DOMRectList</c-></a> <a class="idl-code" data-link-type="method" href="#dom-element-getclientrects" id="ref-for-dom-element-getclientrects"><c- g>getClientRects</c-></a>();
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject②"><c- g>NewObject</c-></a>] <a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect④"><c- n>DOMRect</c-></a> <a class="idl-code" data-link-type="method" href="#dom-element-getboundingclientrect" id="ref-for-dom-element-getboundingclientrect"><c- g>getBoundingClientRect</c-></a>();
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-element-scrollintoview" id="ref-for-dom-element-scrollintoview"><c- g>scrollIntoView</c-></a>(<c- b>optional</c-> (<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean" id="ref-for-idl-boolean③"><c- b>boolean</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="#dictdef-scrollintoviewoptions" id="ref-for-dictdef-scrollintoviewoptions"><c- n>ScrollIntoViewOptions</c-></a>) <dfn class="idl-code" data-dfn-for="Element/scrollIntoView(arg), Element/scrollIntoView()" data-dfn-type="argument" data-export id="dom-element-scrollintoview-arg-arg"><code><c- g>arg</c-></code><a class="self-link" href="#dom-element-scrollintoview-arg-arg"></a></dfn> = {});
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-element-scroll" id="ref-for-dom-element-scroll"><c- g>scroll</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-scrolltooptions" id="ref-for-dictdef-scrolltooptions⑤"><c- n>ScrollToOptions</c-></a> <dfn class="idl-code" data-dfn-for="Element/scroll(options), Element/scroll()" data-dfn-type="argument" data-export id="dom-element-scroll-options-options"><code><c- g>options</c-></code><a class="self-link" href="#dom-element-scroll-options-options"></a></dfn> = {});
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-element-scroll" id="ref-for-dom-element-scroll①"><c- g>scroll</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double" id="ref-for-idl-unrestricted-double⑧"><c- b>unrestricted</c-> <c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Element/scroll(x, y)" data-dfn-type="argument" data-export id="dom-element-scroll-x-y-x"><code><c- g>x</c-></code><a class="self-link" href="#dom-element-scroll-x-y-x"></a></dfn>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double" id="ref-for-idl-unrestricted-double⑨"><c- b>unrestricted</c-> <c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Element/scroll(x, y)" data-dfn-type="argument" data-export id="dom-element-scroll-x-y-y"><code><c- g>y</c-></code><a class="self-link" href="#dom-element-scroll-x-y-y"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-element-scrollto" id="ref-for-dom-element-scrollto"><c- g>scrollTo</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-scrolltooptions" id="ref-for-dictdef-scrolltooptions⑥"><c- n>ScrollToOptions</c-></a> <dfn class="idl-code" data-dfn-for="Element/scrollTo(options), Element/scrollTo()" data-dfn-type="argument" data-export id="dom-element-scrollto-options-options"><code><c- g>options</c-></code><a class="self-link" href="#dom-element-scrollto-options-options"></a></dfn> = {});
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-element-scrollto" id="ref-for-dom-element-scrollto①"><c- g>scrollTo</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double" id="ref-for-idl-unrestricted-double①⓪"><c- b>unrestricted</c-> <c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Element/scrollTo(x, y)" data-dfn-type="argument" data-export id="dom-element-scrollto-x-y-x"><code><c- g>x</c-></code><a class="self-link" href="#dom-element-scrollto-x-y-x"></a></dfn>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double" id="ref-for-idl-unrestricted-double①①"><c- b>unrestricted</c-> <c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Element/scrollTo(x, y)" data-dfn-type="argument" data-export id="dom-element-scrollto-x-y-y"><code><c- g>y</c-></code><a class="self-link" href="#dom-element-scrollto-x-y-y"></a></dfn>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-element-scrollby" id="ref-for-dom-element-scrollby"><c- g>scrollBy</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-scrolltooptions" id="ref-for-dictdef-scrolltooptions⑦"><c- n>ScrollToOptions</c-></a> <dfn class="idl-code" data-dfn-for="Element/scrollBy(options), Element/scrollBy()" data-dfn-type="argument" data-export id="dom-element-scrollby-options-options"><code><c- g>options</c-></code><a class="self-link" href="#dom-element-scrollby-options-options"></a></dfn> = {});
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-element-scrollby" id="ref-for-dom-element-scrollby①"><c- g>scrollBy</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double" id="ref-for-idl-unrestricted-double①②"><c- b>unrestricted</c-> <c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Element/scrollBy(x, y)" data-dfn-type="argument" data-export id="dom-element-scrollby-x-y-x"><code><c- g>x</c-></code><a class="self-link" href="#dom-element-scrollby-x-y-x"></a></dfn>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double" id="ref-for-idl-unrestricted-double①③"><c- b>unrestricted</c-> <c- b>double</c-></a> <dfn class="idl-code" data-dfn-for="Element/scrollBy(x, y)" data-dfn-type="argument" data-export id="dom-element-scrollby-x-y-y"><code><c- g>y</c-></code><a class="self-link" href="#dom-element-scrollby-x-y-y"></a></dfn>);
  <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double" id="ref-for-idl-unrestricted-double①④"><c- b>unrestricted</c-> <c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-type="unrestricted double" href="#dom-element-scrolltop" id="ref-for-dom-element-scrolltop①"><c- g>scrollTop</c-></a>;
  <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double" id="ref-for-idl-unrestricted-double①⑤"><c- b>unrestricted</c-> <c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-type="unrestricted double" href="#dom-element-scrollleft" id="ref-for-dom-element-scrollleft①"><c- g>scrollLeft</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long②⓪"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-element-scrollwidth" id="ref-for-dom-element-scrollwidth"><c- g>scrollWidth</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long②①"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-element-scrollheight" id="ref-for-dom-element-scrollheight"><c- g>scrollHeight</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long②②"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-element-clienttop" id="ref-for-dom-element-clienttop"><c- g>clientTop</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long②③"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-element-clientleft" id="ref-for-dom-element-clientleft"><c- g>clientLeft</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long②④"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-element-clientwidth" id="ref-for-dom-element-clientwidth"><c- g>clientWidth</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long②⑤"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-element-clientheight" id="ref-for-dom-element-clientheight"><c- g>clientHeight</c-></a>;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Element" data-dfn-type="method" data-export id="dom-element-getclientrects"><code>getClientRects()</code></dfn> method, when invoked, must return the result of the following algorithm:</p>
   <ol>
    <li data-md>
     <p>If the element on which it was invoked does not have an associated <a data-link-type="dfn" href="#layout-box" id="ref-for-layout-box②">layout box</a> return an empty <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrectlist" id="ref-for-domrectlist①">DOMRectList</a></code> object and stop this algorithm.</p>
    <li data-md>
     <p>If the element has an associated <a data-link-type="dfn" href="#svg-layout-box" id="ref-for-svg-layout-box②">SVG layout box</a> return a <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrectlist" id="ref-for-domrectlist②">DOMRectList</a></code> object containing a single <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect⑤">DOMRect</a></code> object that describes the bounding box of the element as defined by the SVG specification, applying the <a data-link-type="dfn" href="#transforms" id="ref-for-transforms⑥">transforms</a> that apply to the element and its ancestors.</p>
    <li data-md>
     <p>Return a <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrectlist" id="ref-for-domrectlist③">DOMRectList</a></code> object containing <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect⑥">DOMRect</a></code> objects in content order, one for each <a data-link-type="dfn" href="https://drafts.csswg.org/css-break-4/#box-fragment" id="ref-for-box-fragment">box fragment</a>, describing its border area (including those with a height or width of zero) with the following constraints:</p>
     <ul>
      <li data-md>
       <p>Apply the <a data-link-type="dfn" href="#transforms" id="ref-for-transforms⑦">transforms</a> that apply to the element and its ancestors.</p>
      <li data-md>
       <p>If the element on which the method was invoked has a computed value for the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-display-3/#propdef-display" id="ref-for-propdef-display①">display</a> property of <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-display-3/#valdef-display-table" id="ref-for-valdef-display-table">table</a> or <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-display-3/#valdef-display-inline-table" id="ref-for-valdef-display-inline-table">inline-table</a> include both the table box and the caption box, if any, but not the anonymous container box.</p>
      <li data-md>
       <p>Replace each <a data-link-type="dfn" href="https://www.w3.org/TR/CSS21/visuren.html#anonymous-block-level" id="ref-for-anonymous-block-level">anonymous block box</a> with its child box(es) and repeat this until no anonymous block boxes are left in the final list.</p>
     </ul>
   </ol>
   <p class="note" role="note"><span>Note:</span> The <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect⑦">DOMRect</a></code> objects returned by <code class="idl"><a data-link-type="idl" href="#dom-element-getclientrects" id="ref-for-dom-element-getclientrects①">getClientRects()</a></code> are not <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#live" id="ref-for-live①">live</a>.</p>
   <p>The <dfn class="caniuse-paneled dfn-paneled idl-code" data-dfn-for="Element" data-dfn-type="method" data-export id="dom-element-getboundingclientrect"><code>getBoundingClientRect()</code></dfn> method, when invoked, must return the result of the following
algorithm:</p>
   <ol>
    <li data-md>
     <p>Let <var>list</var> be the result of invoking <code class="idl"><a data-link-type="idl" href="#dom-element-getclientrects" id="ref-for-dom-element-getclientrects②">getClientRects()</a></code> on the same element this method was invoked on.</p>
    <li data-md>
     <p>If the <var>list</var> is empty return a <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect⑧">DOMRect</a></code> object
whose <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#dom-domrect-x" id="ref-for-dom-domrect-x">x</a></code>, <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#dom-domrect-y" id="ref-for-dom-domrect-y">y</a></code>, <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#dom-domrect-width" id="ref-for-dom-domrect-width">width</a></code> and <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#dom-domrect-height" id="ref-for-dom-domrect-height">height</a></code> members are zero.</p>
    <li data-md>
     <p>If all rectangles in <var>list</var> have zero width or height, return the first rectangle in <var>list</var>.</p>
    <li data-md>
     <p>Otherwise, return a <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect⑨">DOMRect</a></code> object describing the smallest rectangle that includes all
of the rectangles in <var>list</var> of which the height or width is not zero.</p>
   </ol>
   <p class="note" role="note"><span>Note:</span> The <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect①⓪">DOMRect</a></code> object returned by <code class="idl"><a data-link-type="idl" href="#dom-element-getboundingclientrect" id="ref-for-dom-element-getboundingclientrect①">getBoundingClientRect()</a></code> is not <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#live" id="ref-for-live②">live</a>.</p>
   <div class="example" id="example-1ac22791">
    <a class="self-link" href="#example-1ac22791"></a> The following snippet gets the dimensions of the first <code>div</code> element in a document: 
<pre class="highlight"><c- a>var</c-> example <c- o>=</c-> document<c- p>.</c->getElementsByTagName<c- p>(</c-><c- u>"div"</c-><c- p>)[</c-><c- mi>0</c-><c- p>].</c->getBoundingClientRect<c- p>();</c->
<c- a>var</c-> exampleWidth <c- o>=</c-> example<c- p>.</c->width<c- p>;</c->
<c- a>var</c-> exampleHeight <c- o>=</c-> example<c- p>.</c->height<c- p>;</c->
</pre>
   </div>
   <p>The <dfn class="caniuse-paneled dfn-paneled idl-code" data-dfn-for="Element" data-dfn-type="method" data-export data-lt="scrollIntoView(arg)|scrollIntoView()" id="dom-element-scrollintoview"><code>scrollIntoView(<var>arg</var>)</code></dfn> method must run these steps:</p>
   <ol>
    <li data-md>
     <p>Let <var>behavior</var> be "<code>auto</code>".</p>
    <li data-md>
     <p>Let <var>block</var> be "<code>start</code>".</p>
    <li data-md>
     <p>Let <var>inline</var> be "<code>nearest</code>".</p>
    <li data-md>
     <p>If <var>arg</var> is a <code class="idl"><a data-link-type="idl" href="#dictdef-scrollintoviewoptions" id="ref-for-dictdef-scrollintoviewoptions①">ScrollIntoViewOptions</a></code> dictionary, then:</p>
     <ol>
      <li data-md>
       <p>Set <var>behavior</var> to the <code class="idl"><a data-link-type="idl" href="#dom-scrolloptions-behavior" id="ref-for-dom-scrolloptions-behavior①">behavior</a></code> dictionary member of <var>options</var>.</p>
      <li data-md>
       <p>Set <var>block</var> to the <code class="idl"><a data-link-type="idl" href="#dom-scrollintoviewoptions-block" id="ref-for-dom-scrollintoviewoptions-block">block</a></code> dictionary member of <var>options</var>.</p>
      <li data-md>
       <p>Set <var>inline</var> to the <code class="idl"><a data-link-type="idl" href="#dom-scrollintoviewoptions-inline" id="ref-for-dom-scrollintoviewoptions-inline">inline</a></code> dictionary member of <var>options</var>.</p>
     </ol>
    <li data-md>
     <p>Otherwise, if <var>arg</var> is false, then set <var>block</var> to "<code>end</code>".</p>
    <li data-md>
     <p>If the element does not have any associated <a data-link-type="dfn" href="#layout-box" id="ref-for-layout-box③">layout box</a>, then return.</p>
    <li data-md>
     <p><a data-link-type="dfn" href="#scroll-an-element-into-view" id="ref-for-scroll-an-element-into-view">Scroll the element into view</a> with <var>behavior</var>, <var>block</var>, and <var>inline</var>.</p>
    <li data-md>
     <p>Optionally perform some other action that brings the element to the user’s attention.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Element" data-dfn-type="method" data-export data-lt="scroll(x, y)|scroll(options)|scroll()" id="dom-element-scroll"><code>scroll()</code></dfn> method must run these steps:</p>
   <ol>
    <li data-md>
     <p>If invoked with one argument, follow these substeps:</p>
     <ol>
      <li data-md>
       <p>Let <var>options</var> be the argument.</p>
      <li data-md>
       <p><a data-link-type="dfn" href="#normalize-non-finite-values" id="ref-for-normalize-non-finite-values②">Normalize non-finite values</a> for <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-left" id="ref-for-dom-scrolltooptions-left④">left</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-top" id="ref-for-dom-scrolltooptions-top④">top</a></code> dictionary members of <var>options</var>, if present.</p>
      <li data-md>
       <p>Let <var>x</var> be the value of the <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-left" id="ref-for-dom-scrolltooptions-left⑤">left</a></code> dictionary member of <var>options</var>, if present, or the element’s current scroll position on the x axis otherwise.</p>
      <li data-md>
       <p>Let <var>y</var> be the value of the <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-top" id="ref-for-dom-scrolltooptions-top⑤">top</a></code> dictionary member of <var>options</var>, if present, or the element’s current scroll position on the y axis otherwise.</p>
     </ol>
    <li data-md>
     <p>If invoked with two arguments, follow these substeps:</p>
     <ol>
      <li data-md>
       <p>Let <var>options</var> be null <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-convert-ecmascript-to-idl-value" id="ref-for-dfn-convert-ecmascript-to-idl-value②">converted</a> to a <code class="idl"><a data-link-type="idl" href="#dictdef-scrolltooptions" id="ref-for-dictdef-scrolltooptions⑧">ScrollToOptions</a></code> dictionary. <a data-link-type="biblio" href="#biblio-webidl">[WEBIDL]</a></p>
      <li data-md>
       <p>Let <var>x</var> and <var>y</var> be the arguments, respectively.</p>
      <li data-md>
       <p><a data-link-type="dfn" href="#normalize-non-finite-values" id="ref-for-normalize-non-finite-values③">Normalize non-finite values</a> for <var>x</var> and <var>y</var>.</p>
      <li data-md>
       <p>Let the <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-left" id="ref-for-dom-scrolltooptions-left⑥">left</a></code> dictionary member of <var>options</var> have the value <var>x</var>.</p>
      <li data-md>
       <p>Let the <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-top" id="ref-for-dom-scrolltooptions-top⑥">top</a></code> dictionary member of <var>options</var> have the value <var>y</var>.</p>
     </ol>
    <li data-md>
     <p>Let <var>document</var> be the element’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document">node document</a>.</p>
    <li data-md>
     <p>If <var>document</var> is not the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#active-document" id="ref-for-active-document">active document</a>, terminate these steps.</p>
    <li data-md>
     <p>Let <var>window</var> be the value of <var>document</var>’s <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#dom-document-defaultview" id="ref-for-dom-document-defaultview">defaultView</a></code> attribute.</p>
    <li data-md>
     <p>If <var>window</var> is null, terminate these steps.</p>
    <li data-md>
     <p>If the element is the root element and <var>document</var> is in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks②">quirks mode</a>, terminate these steps.</p>
    <li data-md>
     <p>If the element is the root element invoke <code class="idl"><a data-link-type="idl" href="#dom-window-scroll" id="ref-for-dom-window-scroll④">scroll()</a></code> on <var>window</var> with <code class="idl"><a data-link-type="idl" href="#dom-window-scrollx" id="ref-for-dom-window-scrollx③">scrollX</a></code> on <var>window</var> as first argument and <var>y</var> as second argument,
and terminate these steps.</p>
    <li data-md>
     <p>If the element is <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element⑤">the HTML <code>body</code> element</a>, <var>document</var> is in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks③">quirks mode</a>,
and the element is not <a data-link-type="dfn" href="#potentially-scrollable" id="ref-for-potentially-scrollable②">potentially scrollable</a>,
invoke <code class="idl"><a data-link-type="idl" href="#dom-window-scroll" id="ref-for-dom-window-scroll⑤">scroll()</a></code> on <var>window</var> with <var>options</var> as the only argument,
and terminate these steps.</p>
    <li data-md>
     <p>If the element does not have any associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box④">CSS layout box</a>,
the element has no associated <a data-link-type="dfn" href="#scrolling-box" id="ref-for-scrolling-box⑥">scrolling box</a>,
or the element has no overflow,
terminate these steps.</p>
    <li data-md>
     <p><a data-link-type="dfn" href="#scroll-an-element" id="ref-for-scroll-an-element">Scroll the element</a> to <var>x</var>,<var>y</var>,
with the scroll behavior being the value of the <code class="idl"><a data-link-type="idl" href="#dom-scrolloptions-behavior" id="ref-for-dom-scrolloptions-behavior②">behavior</a></code> dictionary member of <var>options</var>.</p>
   </ol>
   <p>When the <dfn class="dfn-paneled idl-code" data-dfn-for="Element" data-dfn-type="method" data-export data-lt="scrollTo(x, y)|scrollTo(options)|scrollTo()" id="dom-element-scrollto"><code>scrollTo()</code></dfn> method is invoked, the
user agent must act as if the <code class="idl"><a data-link-type="idl" href="#dom-element-scroll" id="ref-for-dom-element-scroll②">scroll()</a></code> method was invoked with the same arguments.</p>
   <p>When the <dfn class="dfn-paneled idl-code" data-dfn-for="Element" data-dfn-type="method" data-export data-lt="scrollBy(x, y)|scrollBy(options)|scrollBy()" id="dom-element-scrollby"><code>scrollBy()</code></dfn> method is invoked, the
user agent must run these steps:</p>
   <ol>
    <li data-md>
     <p>If invoked with one argument, follow these substeps:</p>
     <ol>
      <li data-md>
       <p>Let <var>options</var> be the argument.</p>
      <li data-md>
       <p><a data-link-type="dfn" href="#normalize-non-finite-values" id="ref-for-normalize-non-finite-values④">Normalize non-finite values</a> for <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-left" id="ref-for-dom-scrolltooptions-left⑦">left</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-top" id="ref-for-dom-scrolltooptions-top⑦">top</a></code> dictionary members of <var>options</var>, if present.</p>
     </ol>
    <li data-md>
     <p>If invoked with two arguments, follow these substeps:</p>
     <ol>
      <li data-md>
       <p>Let <var>options</var> be null <a data-link-type="dfn" href="http://heycam.github.io/webidl/#dfn-convert-ecmascript-to-idl-value" id="ref-for-dfn-convert-ecmascript-to-idl-value③">converted</a> to a <code class="idl"><a data-link-type="idl" href="#dictdef-scrolltooptions" id="ref-for-dictdef-scrolltooptions⑨">ScrollToOptions</a></code> dictionary. <a data-link-type="biblio" href="#biblio-webidl">[WEBIDL]</a></p>
      <li data-md>
       <p>Let <var>x</var> and <var>y</var> be the arguments, respectively.</p>
      <li data-md>
       <p><a data-link-type="dfn" href="#normalize-non-finite-values" id="ref-for-normalize-non-finite-values⑤">Normalize non-finite values</a> for <var>x</var> and <var>y</var>.</p>
      <li data-md>
       <p>Let the <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-left" id="ref-for-dom-scrolltooptions-left⑧">left</a></code> dictionary member of <var>options</var> have the value <var>x</var>.</p>
      <li data-md>
       <p>Let the <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-top" id="ref-for-dom-scrolltooptions-top⑧">top</a></code> dictionary member of <var>options</var> have the value <var>y</var>.</p>
     </ol>
    <li data-md>
     <p>Add the value of <code class="idl"><a data-link-type="idl" href="#dom-element-scrollleft" id="ref-for-dom-element-scrollleft②">scrollLeft</a></code> to the <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-left" id="ref-for-dom-scrolltooptions-left⑨">left</a></code> dictionary member.</p>
    <li data-md>
     <p>Add the value of <code class="idl"><a data-link-type="idl" href="#dom-element-scrolltop" id="ref-for-dom-element-scrolltop②">scrollTop</a></code> to the <code class="idl"><a data-link-type="idl" href="#dom-scrolltooptions-top" id="ref-for-dom-scrolltooptions-top⑨">top</a></code> dictionary member.</p>
    <li data-md>
     <p>Act as if the <code class="idl"><a data-link-type="idl" href="#dom-element-scroll" id="ref-for-dom-element-scroll③">scroll()</a></code> method was invoked with <var>options</var> as the only argument.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Element" data-dfn-type="attribute" data-export id="dom-element-scrolltop"><code>scrollTop</code></dfn> attribute, on getting, must return the result of running these steps:</p>
   <ol>
    <li data-md>
     <p>Let <var>document</var> be the element’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document①">node document</a>.</p>
    <li data-md>
     <p>If <var>document</var> is not the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#active-document" id="ref-for-active-document①">active document</a>, return zero and terminate these steps.</p>
    <li data-md>
     <p>Let <var>window</var> be the value of <var>document</var>’s <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#dom-document-defaultview" id="ref-for-dom-document-defaultview①">defaultView</a></code> attribute.</p>
    <li data-md>
     <p>If <var>window</var> is null, return zero and terminate these steps.</p>
    <li data-md>
     <p>If the element is the root element and <var>document</var> is in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks④">quirks mode</a>, return zero and terminate these steps.</p>
    <li data-md>
     <p>If the element is the root element return the value of <code class="idl"><a data-link-type="idl" href="#dom-window-scrolly" id="ref-for-dom-window-scrolly③">scrollY</a></code> on <var>window</var>.</p>
    <li data-md>
     <p>If the element is <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element⑥">the HTML <code>body</code> element</a>, <var>document</var> is in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks⑤">quirks mode</a>, and the element is not <a data-link-type="dfn" href="#potentially-scrollable" id="ref-for-potentially-scrollable③">potentially scrollable</a>, return the value of <code class="idl"><a data-link-type="idl" href="#dom-window-scrolly" id="ref-for-dom-window-scrolly④">scrollY</a></code> on <var>window</var>.</p>
    <li data-md>
     <p>If the element does not have any associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box⑤">CSS layout box</a>, return zero and terminate these steps.</p>
    <li data-md>
     <p>Return the y-coordinate of the <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area⑨">scrolling area</a> at the alignment point with the top of the <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge①⑥">padding edge</a> of the element.</p>
   </ol>
   <p>When setting the <code class="idl"><a data-link-type="idl" href="#dom-element-scrolltop" id="ref-for-dom-element-scrolltop③">scrollTop</a></code> attribute these steps must be run:</p>
   <ol>
    <li data-md>
     <p>Let <var>y</var> be the given value.</p>
    <li data-md>
     <p><a data-link-type="dfn" href="#normalize-non-finite-values" id="ref-for-normalize-non-finite-values⑥">Normalize non-finite values</a> for <var>y</var>.</p>
    <li data-md>
     <p>Let <var>document</var> be the element’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document②">node document</a>.</p>
    <li data-md>
     <p>If <var>document</var> is not the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#active-document" id="ref-for-active-document②">active document</a>, terminate these steps.</p>
    <li data-md>
     <p>Let <var>window</var> be the value of <var>document</var>’s <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#dom-document-defaultview" id="ref-for-dom-document-defaultview②">defaultView</a></code> attribute.</p>
    <li data-md>
     <p>If <var>window</var> is null, terminate these steps.</p>
    <li data-md>
     <p>If the element is the root element and <var>document</var> is in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks⑥">quirks mode</a>, terminate these steps.</p>
    <li data-md>
     <p>If the element is the root element invoke <code class="idl"><a data-link-type="idl" href="#dom-window-scroll" id="ref-for-dom-window-scroll⑥">scroll()</a></code> on <var>window</var> with <code class="idl"><a data-link-type="idl" href="#dom-window-scrollx" id="ref-for-dom-window-scrollx④">scrollX</a></code> on <var>window</var> as first argument and <var>y</var> as second argument, and terminate these steps.</p>
    <li data-md>
     <p>If the element is <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element⑦">the HTML <code>body</code> element</a>, <var>document</var> is in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks⑦">quirks mode</a>, and the element is not <a data-link-type="dfn" href="#potentially-scrollable" id="ref-for-potentially-scrollable④">potentially scrollable</a>, invoke <code class="idl"><a data-link-type="idl" href="#dom-window-scroll" id="ref-for-dom-window-scroll⑦">scroll()</a></code> on <var>window</var> with <code class="idl"><a data-link-type="idl" href="#dom-window-scrollx" id="ref-for-dom-window-scrollx⑤">scrollX</a></code> as first argument and <var>y</var> as second argument, and terminate these steps.</p>
    <li data-md>
     <p>If the element does not have any associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box⑥">CSS layout box</a>, the element has no associated <a data-link-type="dfn" href="#scrolling-box" id="ref-for-scrolling-box⑦">scrolling box</a>, or the element has no overflow, terminate these steps.</p>
    <li data-md>
     <p><a data-link-type="dfn" href="#scroll-an-element" id="ref-for-scroll-an-element①">Scroll the element</a> to <code class="idl"><a data-link-type="idl" href="#dom-element-scrollleft" id="ref-for-dom-element-scrollleft③">scrollLeft</a></code>,<var>y</var>, with the scroll behavior being "<code>auto</code>".</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Element" data-dfn-type="attribute" data-export id="dom-element-scrollleft"><code>scrollLeft</code></dfn> attribute, on getting, must return the result of running these steps:</p>
   <ol>
    <li data-md>
     <p>Let <var>document</var> be the element’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document③">node document</a>.</p>
    <li data-md>
     <p>If <var>document</var> is not the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#active-document" id="ref-for-active-document③">active document</a>, return zero and terminate these steps.</p>
    <li data-md>
     <p>Let <var>window</var> be the value of <var>document</var>’s <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#dom-document-defaultview" id="ref-for-dom-document-defaultview③">defaultView</a></code> attribute.</p>
    <li data-md>
     <p>If <var>window</var> is null, return zero and terminate these steps.</p>
    <li data-md>
     <p>If the element is the root element and <var>document</var> is in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks⑧">quirks mode</a>, return zero and terminate these steps.</p>
    <li data-md>
     <p>If the element is the root element return the value of <code class="idl"><a data-link-type="idl" href="#dom-window-scrollx" id="ref-for-dom-window-scrollx⑥">scrollX</a></code> on <var>window</var>.</p>
    <li data-md>
     <p>If the element is <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element⑧">the HTML <code>body</code> element</a>, <var>document</var> is in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks⑨">quirks mode</a>, and the element is not <a data-link-type="dfn" href="#potentially-scrollable" id="ref-for-potentially-scrollable⑤">potentially scrollable</a>, return the value of <code class="idl"><a data-link-type="idl" href="#dom-window-scrollx" id="ref-for-dom-window-scrollx⑦">scrollX</a></code> on <var>window</var>.</p>
    <li data-md>
     <p>If the element does not have any associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box⑦">CSS layout box</a>, return zero and terminate these steps.</p>
    <li data-md>
     <p>Return the x-coordinate of the <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area①⓪">scrolling area</a> at the alignment point with the left of the <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge①⑦">padding edge</a> of the element.</p>
   </ol>
   <p>When setting the <code class="idl"><a data-link-type="idl" href="#dom-element-scrollleft" id="ref-for-dom-element-scrollleft④">scrollLeft</a></code> attribute these steps must be run:</p>
   <ol>
    <li data-md>
     <p>Let <var>x</var> be the given value.</p>
    <li data-md>
     <p><a data-link-type="dfn" href="#normalize-non-finite-values" id="ref-for-normalize-non-finite-values⑦">Normalize non-finite values</a> for <var>x</var>.</p>
    <li data-md>
     <p>Let <var>document</var> be the element’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document④">node document</a>.</p>
    <li data-md>
     <p>If <var>document</var> is not the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#active-document" id="ref-for-active-document④">active document</a>, terminate these steps.</p>
    <li data-md>
     <p>Let <var>window</var> be the value of <var>document</var>’s <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#dom-document-defaultview" id="ref-for-dom-document-defaultview④">defaultView</a></code> attribute.</p>
    <li data-md>
     <p>If <var>window</var> is null, terminate these steps.</p>
    <li data-md>
     <p>If the element is the root element and <var>document</var> is in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks①⓪">quirks mode</a>, terminate these steps.</p>
    <li data-md>
     <p>If the element is the root element invoke <code class="idl"><a data-link-type="idl" href="#dom-window-scroll" id="ref-for-dom-window-scroll⑧">scroll()</a></code> on <var>window</var> with <var>x</var> as first argument and <code class="idl"><a data-link-type="idl" href="#dom-window-scrolly" id="ref-for-dom-window-scrolly⑤">scrollY</a></code> on <var>window</var> as second argument, and terminate these steps.</p>
    <li data-md>
     <p>If the element is <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element⑨">the HTML <code>body</code> element</a>, <var>document</var> is in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks①①">quirks mode</a>, and the element is not <a data-link-type="dfn" href="#potentially-scrollable" id="ref-for-potentially-scrollable⑥">potentially scrollable</a>, invoke <code class="idl"><a data-link-type="idl" href="#dom-window-scroll" id="ref-for-dom-window-scroll⑨">scroll()</a></code> on <var>window</var> with <var>x</var> as first argument and <code class="idl"><a data-link-type="idl" href="#dom-window-scrolly" id="ref-for-dom-window-scrolly⑥">scrollY</a></code> on <var>window</var> as second argument, and terminate these steps.</p>
    <li data-md>
     <p>If the element does not have any associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box⑧">CSS layout box</a>, the element has no associated <a data-link-type="dfn" href="#scrolling-box" id="ref-for-scrolling-box⑧">scrolling box</a>, or the element has no overflow, terminate these steps.</p>
    <li data-md>
     <p><a data-link-type="dfn" href="#scroll-an-element" id="ref-for-scroll-an-element②">Scroll the element</a> to <var>x</var>,<code class="idl"><a data-link-type="idl" href="#dom-element-scrolltop" id="ref-for-dom-element-scrolltop④">scrollTop</a></code>, with the scroll behavior being "<code>auto</code>".</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Element" data-dfn-type="attribute" data-export id="dom-element-scrollwidth"><code>scrollWidth</code></dfn> attribute must return the result of running these steps:</p>
   <ol>
    <li data-md>
     <p>Let <var>document</var> be the element’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document⑤">node document</a>.</p>
    <li data-md>
     <p>If <var>document</var> is not the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#active-document" id="ref-for-active-document⑤">active document</a>, return zero and terminate these steps.</p>
    <li data-md>
     <p>Let <var>viewport width</var> be the width of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑥⑤">viewport</a> excluding the width of the scroll bar, if any, or zero if there is no <span id="ref-for-viewport⑥⑥">viewport</span>.</p>
    <li data-md>
     <p>If the element is the root element and <var>document</var> is not in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks①②">quirks mode</a> return max(<a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑥⑦">viewport</a> <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area①①">scrolling area</a> width, <var>viewport width</var>).</p>
    <li data-md>
     <p>If the element is <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element①⓪">the HTML <code>body</code> element</a>, <var>document</var> is in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks①③">quirks mode</a> and the element is not <a data-link-type="dfn" href="#potentially-scrollable" id="ref-for-potentially-scrollable⑦">potentially scrollable</a>, return max(<a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑥⑧">viewport</a> <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area①②">scrolling area</a> width, <var>viewport width</var>).</p>
    <li data-md>
     <p>If the element does not have any associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box⑨">CSS layout box</a> return zero and terminate these steps.</p>
    <li data-md>
     <p>Return the width of the element’s <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area①③">scrolling area</a>.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Element" data-dfn-type="attribute" data-export id="dom-element-scrollheight"><code>scrollHeight</code></dfn> attribute must return the result of running these steps:</p>
   <ol>
    <li data-md>
     <p>Let <var>document</var> be the element’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document⑥">node document</a>.</p>
    <li data-md>
     <p>If <var>document</var> is not the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#active-document" id="ref-for-active-document⑥">active document</a>, return zero and terminate these steps.</p>
    <li data-md>
     <p>Let <var>viewport height</var> be the height of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑥⑨">viewport</a> excluding the height of the scroll bar, if any, or zero if there is no <span id="ref-for-viewport⑦⓪">viewport</span>.</p>
    <li data-md>
     <p>If the element is the root element and <var>document</var> is not in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks①④">quirks mode</a> return max(<a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑦①">viewport</a> <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area①④">scrolling area</a> height, <var>viewport height</var>).</p>
    <li data-md>
     <p>If the element is <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element①①">the HTML <code>body</code> element</a>, <var>document</var> is in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks①⑤">quirks mode</a> and the element is not <a data-link-type="dfn" href="#potentially-scrollable" id="ref-for-potentially-scrollable⑧">potentially scrollable</a>, return max(<a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑦②">viewport</a> <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area①⑤">scrolling area</a> height, <var>viewport height</var>).</p>
    <li data-md>
     <p>If the element does not have any associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box①⓪">CSS layout box</a> return zero and terminate these steps.</p>
    <li data-md>
     <p>Return the height of the element’s <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area①⑥">scrolling area</a>.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Element" data-dfn-type="attribute" data-export id="dom-element-clienttop"><code>clientTop</code></dfn> attribute must run these steps:</p>
   <ol>
    <li data-md>
     <p>If the element has no associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box①①">CSS layout box</a> or if the <span id="ref-for-css-layout-box①②">CSS layout box</span> is inline, return zero.</p>
    <li data-md>
     <p>Return the computed value of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-backgrounds-3/#propdef-border-top-width" id="ref-for-propdef-border-top-width">border-top-width</a> property plus the height of any scrollbar rendered between the top <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge①⑧">padding edge</a> and the top <a data-link-type="dfn" href="#border-edge" id="ref-for-border-edge">border edge</a>, ignoring any <a data-link-type="dfn" href="#transforms" id="ref-for-transforms⑧">transforms</a> that apply to the element and its ancestors.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Element" data-dfn-type="attribute" data-export id="dom-element-clientleft"><code>clientLeft</code></dfn> attribute must run these steps:</p>
   <ol>
    <li data-md>
     <p>If the element has no associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box①③">CSS layout box</a> or if the <span id="ref-for-css-layout-box①④">CSS layout box</span> is inline, return zero.</p>
    <li data-md>
     <p>Return the computed value of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-backgrounds-3/#propdef-border-left-width" id="ref-for-propdef-border-left-width">border-left-width</a> property plus the width of any scrollbar rendered between the left <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge①⑨">padding edge</a> and the left <a data-link-type="dfn" href="#border-edge" id="ref-for-border-edge①">border edge</a>, ignoring any <a data-link-type="dfn" href="#transforms" id="ref-for-transforms⑨">transforms</a> that apply to the element and its ancestors.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Element" data-dfn-type="attribute" data-export id="dom-element-clientwidth"><code>clientWidth</code></dfn> attribute must run these steps:</p>
   <ol>
    <li data-md>
     <p>If the element has no associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box①⑤">CSS layout box</a> or if the <span id="ref-for-css-layout-box①⑥">CSS layout box</span> is inline, return zero.</p>
    <li data-md>
     <p>If the element is the root element and the element’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document⑦">node document</a> is not in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks①⑥">quirks mode</a>, or if the element is <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element①②">the HTML <code>body</code> element</a> and the element’s <span id="ref-for-concept-node-document⑧">node document</span> <em>is</em> in <span id="ref-for-concept-document-quirks①⑦">quirks mode</span>, return the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑦③">viewport</a> width excluding the size of a rendered scroll bar (if any).</p>
    <li data-md>
     <p>Return the width of the <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge②⓪">padding edge</a> excluding the width of any rendered scrollbar between the <span id="ref-for-padding-edge②①">padding edge</span> and the <a data-link-type="dfn" href="#border-edge" id="ref-for-border-edge②">border edge</a>, ignoring any <a data-link-type="dfn" href="#transforms" id="ref-for-transforms①⓪">transforms</a> that apply to the element and its ancestors.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Element" data-dfn-type="attribute" data-export id="dom-element-clientheight"><code>clientHeight</code></dfn> attribute must run these steps:</p>
   <ol>
    <li data-md>
     <p>If the element has no associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box①⑦">CSS layout box</a> or if the <span id="ref-for-css-layout-box①⑧">CSS layout box</span> is inline, return zero.</p>
    <li data-md>
     <p>If the element is the root element and the element’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document⑨">node document</a> is not in <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-document-quirks" id="ref-for-concept-document-quirks①⑧">quirks mode</a>, or if the element is <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element①③">the HTML <code>body</code> element</a> and the element’s <span id="ref-for-concept-node-document①⓪">node document</span> <em>is</em> in <span id="ref-for-concept-document-quirks①⑨">quirks mode</span>, return the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑦④">viewport</a> height excluding the size of a rendered scroll bar (if any).</p>
    <li data-md>
     <p>Return the height of the <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge②②">padding edge</a> excluding the height of any rendered scrollbar between the <span id="ref-for-padding-edge②③">padding edge</span> and the <a data-link-type="dfn" href="#border-edge" id="ref-for-border-edge③">border edge</a>, ignoring any <a data-link-type="dfn" href="#transforms" id="ref-for-transforms①①">transforms</a> that apply to the element and its ancestors.</p>
   </ol>
   <h3 class="heading settled" data-level="6.1" id="element-scrolling-members"><span class="secno">6.1. </span><span class="content"><code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#element" id="ref-for-element⑤">Element</a></code> Scrolling Members</span><a class="self-link" href="#element-scrolling-members"></a></h3>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="scroll-an-element-into-view">scroll an element into view</dfn> <var>element</var>,
with a scroll behavior <var>behavior</var>,
a block flow direction position <var>block</var>,
and an inline base direction position <var>inline</var>,
means to run these steps for each ancestor element or <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑦⑤">viewport</a> that establishes
a <a data-link-type="dfn" href="#scrolling-box" id="ref-for-scrolling-box⑨">scrolling box</a> <var>scrolling box</var>, in order of innermost to outermost <span id="ref-for-scrolling-box①⓪">scrolling box</span>:</p>
   <ol>
    <li data-md>
     <p>If the <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document⑥">Document</a></code> associated with <var>element</var> is not <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/browsers.html#same-origin" id="ref-for-same-origin">same origin</a> with the <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document⑦">Document</a></code> associated with the element or <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑦⑥">viewport</a> associated with <var>box</var>, terminate these steps.</p>
    <li data-md>
     <p>Let <var>element bounding border box</var> be the box that the return value of invoking <code class="idl"><a data-link-type="idl" href="#dom-element-getboundingclientrect" id="ref-for-dom-element-getboundingclientrect②">getBoundingClientRect()</a></code> on <var>element</var> represents.</p>
    <li data-md>
     <p>Let <var>scrolling box edge A</var> be the <a data-link-type="dfn" href="#beginning-edges" id="ref-for-beginning-edges②">beginning edge</a> in the <a data-link-type="dfn" href="https://drafts.csswg.org/css-writing-modes-4/#block-flow-direction" id="ref-for-block-flow-direction">block flow direction</a> of <var>scrolling box</var>, and let <var>element edge A</var> be <var>element bounding border box</var>’s edge on the same physical side as that of <var>scrolling box edge A</var>.</p>
    <li data-md>
     <p>Let <var>scrolling box edge B</var> be the <a data-link-type="dfn" href="#ending-edges" id="ref-for-ending-edges">ending edge</a> in the <a data-link-type="dfn" href="https://drafts.csswg.org/css-writing-modes-4/#block-flow-direction" id="ref-for-block-flow-direction①">block flow direction</a> of <var>scrolling box</var>, and let <var>element edge B</var> be <var>element bounding border box</var>’s edge on the same physical side as that of <var>scrolling box edge B</var>.</p>
    <li data-md>
     <p>Let <var>scrolling box edge C</var> be the <a data-link-type="dfn" href="#beginning-edges" id="ref-for-beginning-edges③">beginning edge</a> in the <a data-link-type="dfn" href="https://drafts.csswg.org/css-writing-modes-4/#inline-base-direction" id="ref-for-inline-base-direction">inline base direction</a> of <var>scrolling box</var>, and let <var>element edge C</var> be <var>element bounding border box</var>’s edge on the same physical side as that of <var>scrolling box edge C</var>.</p>
    <li data-md>
     <p>Let <var>scrolling box edge D</var> be the <a data-link-type="dfn" href="#ending-edges" id="ref-for-ending-edges①">ending edge</a> in the <a data-link-type="dfn" href="https://drafts.csswg.org/css-writing-modes-4/#inline-base-direction" id="ref-for-inline-base-direction①">inline base direction</a> of <var>scrolling box</var>, and let <var>element edge D</var> be <var>element bounding border box</var>’s edge on the same physical side as that of <var>scrolling box edge D</var>.</p>
    <li data-md>
     <p>Let <var>element height</var> be the distance between <var>element edge A</var> and <var>element edge B</var>.</p>
    <li data-md>
     <p>Let <var>scrolling box height</var> be the distance between <var>scrolling box edge A</var> and <var>scrolling box edge B</var>.</p>
    <li data-md>
     <p>Let <var>element width</var> be the distance between <var>element edge C</var> and <var>element edge D</var>.</p>
    <li data-md>
     <p>Let <var>scrolling box width</var> be the distance between <var>scrolling box edge C</var> and <var>scrolling box edge D</var>.</p>
    <li data-md>
     <p>Let <var>position</var> be the scroll position <var>scrolling box</var> would have by following these steps:</p>
     <ol>
      <li data-md>
       <p>If <var>block</var> is "<code>start</code>", then align <var>element edge A</var> with <var>scrolling box edge A</var>.</p>
      <li data-md>
       <p>Otherwise, if <var>block</var> is "<code>end</code>", then align <var>element edge B</var> with <var>scrolling box edge B</var>.</p>
      <li data-md>
       <p>Otherwise, if <var>block</var> is "<code>center</code>", then align the center of <var>element bounding border box</var> with the center of <var>scrolling box</var> in <var>scrolling box</var>’s <a data-link-type="dfn" href="https://drafts.csswg.org/css-writing-modes-4/#block-flow-direction" id="ref-for-block-flow-direction②">block flow direction</a>.</p>
      <li data-md>
       <p>Otherwise, <var>block</var> is "<code>nearest</code>":</p>
       <dl class="switch">
        <dt>If <var>element edge A</var> and <var>element edge B</var> are both outside <var>scrolling box edge A</var> and <var>scrolling box edge B</var> 
        <dd>Do nothing. 
        <dt>If <var>element edge A</var> is outside <var>scrolling box edge A</var> and <var>element height</var> is less than <var>scrolling box height</var> 
        <dt>If <var>element edge B</var> is outside <var>scrolling box edge B</var> and <var>element height</var> is greater than <var>scrolling box height</var> 
        <dd>Align <var>element edge A</var> with <var>scrolling box edge A</var>. 
        <dt>If <var>element edge A</var> is outside <var>scrolling box edge A</var> and <var>element height</var> is greater than <var>scrolling box height</var> 
        <dt>If <var>element edge B</var> is outside <var>scrolling box edge B</var> and <var>element height</var> is less than <var>scrolling box height</var> 
        <dd>Align <var>element edge B</var> with <var>scrolling box edge B</var>. 
       </dl>
      <li data-md>
       <p>If <var>inline</var> is "<code>start</code>", then align <var>element edge C</var> with <var>scrolling box edge C</var>.</p>
      <li data-md>
       <p>Otherwise, if <var>inline</var> is "<code>end</code>", then align <var>element edge D</var> with <var>scrolling box edge D</var>.</p>
      <li data-md>
       <p>Otherwise, if <var>inline</var> is "<code>center</code>", then align the center of <var>element bounding border box</var> with the center of <var>scrolling box</var> in <var>scrolling box</var>’s <a data-link-type="dfn" href="https://drafts.csswg.org/css-writing-modes-4/#inline-base-direction" id="ref-for-inline-base-direction②">inline base direction</a>.</p>
      <li data-md>
       <p>Otherwise, <var>inline</var> is "<code>nearest</code>":</p>
       <dl class="switch">
        <dt>If <var>element edge C</var> and <var>element edge D</var> are both outside <var>scrolling box edge C</var> and <var>scrolling box edge D</var> 
        <dd>Do nothing. 
        <dt>If <var>element edge C</var> is outside <var>scrolling box edge C</var> and <var>element width</var> is less than <var>scrolling box width</var> 
        <dt>If <var>element edge D</var> is outside <var>scrolling box edge D</var> and <var>element width</var> is greater than <var>scrolling box width</var> 
        <dd>Align <var>element edge C</var> with <var>scrolling box edge C</var>. 
        <dt>If <var>element edge C</var> is outside <var>scrolling box edge C</var> and <var>element width</var> is greater than <var>scrolling box width</var> 
        <dt>If <var>element edge D</var> is outside <var>scrolling box edge D</var> and <var>element width</var> is less than <var>scrolling box width</var> 
        <dd>Align <var>element edge D</var> with <var>scrolling box edge D</var>. 
       </dl>
     </ol>
    <li data-md>
     <p>If <var>position</var> is the same as <var>scrolling box</var>’s current scroll position, and <var>scrolling box</var> does not have an ongoing <a data-link-type="dfn" href="#concept-smooth-scroll" id="ref-for-concept-smooth-scroll④">smooth scroll</a>, then return.</p>
    <li data-md>
     <dl class="switch">
      <dt>If <var>scrolling box</var> is associated with an element 
      <dd> Let <var>associated element</var> be the element. 
      <dt>If <var>scrolling box</var> is associated with a <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑦⑦">viewport</a> 
      <dd> Let <var>document</var> be the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑦⑧">viewport’s</a> associated <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document⑧">Document</a></code>.
        Let <var>associated element</var> be <var>document</var>’s root element, if there is one, or null otherwise. 
     </dl>
    <li data-md>
     <p><a data-link-type="dfn" href="#perform-a-scroll" id="ref-for-perform-a-scroll②">Perform a scroll</a> of <var>scrolling box</var> to <var>position</var>, <var>associated element</var> as the associated element and <var>behavior</var> as the scroll behavior.</p>
   </ol>
   <p>To <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="scroll-an-element">scroll an element</dfn> <var>element</var> to <var>x</var>,<var>y</var> optionally with a scroll behavior <var>behavior</var> (which is "<code>auto</code>" if omitted) means to:</p>
   <ol>
    <li data-md>
     <p>Let <var>box</var> be <var>element</var>’s associated <a data-link-type="dfn" href="#scrolling-box" id="ref-for-scrolling-box①①">scrolling box</a>.</p>
    <li data-md>
     <dl class="switch">
      <dt>If <var>box</var> has rightward <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions①④">overflow direction</a> 
      <dd>Let <var>x</var> be max(0, min(<var>x</var>, <var>element</var> <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area①⑦">scrolling area</a> width - <var>element</var> <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge②④">padding edge</a> width)). 
      <dt>If <var>box</var> has leftward <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions①⑤">overflow direction</a> 
      <dd>Let <var>x</var> be min(0, max(<var>x</var>, <var>element</var> <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge②⑤">padding edge</a> width - <var>element</var> <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area①⑧">scrolling area</a> width)). 
     </dl>
    <li data-md>
     <dl class="switch">
      <dt>If <var>box</var> has downward <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions①⑥">overflow direction</a> 
      <dd>Let <var>y</var> be max(0, min(<var>y</var>, <var>element</var> <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area①⑨">scrolling area</a> height - <var>element</var> <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge②⑥">padding edge</a> height)). 
      <dt>If <var>box</var> has upward <a data-link-type="dfn" href="#overflow-directions" id="ref-for-overflow-directions①⑦">overflow direction</a> 
      <dd>Let <var>y</var> be min(0, max(<var>y</var>, <var>element</var> <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge②⑦">padding edge</a> height - <var>element</var> <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area②⓪">scrolling area</a> height)). 
     </dl>
    <li data-md>
     <p>Let <var>position</var> be the scroll position <var>box</var> would have by aligning <a data-link-type="dfn" href="#scrolling-area" id="ref-for-scrolling-area②①">scrolling area</a> x-coordinate <var>x</var> with the left of <var>box</var> and aligning <span id="ref-for-scrolling-area②②">scrolling area</span> y-coordinate <var>y</var> with the top of <var>box</var>.</p>
    <li data-md>
     <p>If <var>position</var> is the same as <var>box</var>’s current scroll position, and <var>box</var> does not have an ongoing <a data-link-type="dfn" href="#concept-smooth-scroll" id="ref-for-concept-smooth-scroll⑤">smooth scroll</a>, abort these steps.</p>
    <li data-md>
     <p><a data-link-type="dfn" href="#perform-a-scroll" id="ref-for-perform-a-scroll③">Perform a scroll</a> of <var>box</var> to <var>position</var>, <var>element</var> as the associated element and <var>behavior</var> as the scroll behavior.</p>
   </ol>
   <h2 class="heading settled" data-level="7" id="extensions-to-the-htmlelement-interface"><span class="secno">7. </span><span class="content">Extensions to the <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/dom.html#htmlelement" id="ref-for-htmlelement">HTMLElement</a></code> Interface</span><a class="self-link" href="#extensions-to-the-htmlelement-interface"></a></h2>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/dom.html#htmlelement" id="ref-for-htmlelement①"><c- g>HTMLElement</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element" id="ref-for-element⑥"><c- n>Element</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="Element?" href="#dom-htmlelement-offsetparent" id="ref-for-dom-htmlelement-offsetparent"><c- g>offsetParent</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long②⑥"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-htmlelement-offsettop" id="ref-for-dom-htmlelement-offsettop"><c- g>offsetTop</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long②⑦"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-htmlelement-offsetleft" id="ref-for-dom-htmlelement-offsetleft"><c- g>offsetLeft</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long②⑧"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-htmlelement-offsetwidth" id="ref-for-dom-htmlelement-offsetwidth"><c- g>offsetWidth</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long②⑨"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-htmlelement-offsetheight" id="ref-for-dom-htmlelement-offsetheight"><c- g>offsetHeight</c-></a>;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="HTMLElement" data-dfn-type="attribute" data-export id="dom-htmlelement-offsetparent"><code>offsetParent</code></dfn> attribute must return the result of running these steps:</p>
   <ol>
    <li data-md>
     <p>If any of the following holds true return null and terminate this algorithm:</p>
     <ul>
      <li data-md>
       <p>The element does not have an associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box①⑨">CSS layout box</a>.</p>
      <li data-md>
       <p>The element is the root element.</p>
      <li data-md>
       <p>The element is <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element①④">the HTML <code>body</code> element</a>.</p>
      <li data-md>
       <p>The element’s computed value of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-position-3/#propdef-position" id="ref-for-propdef-position">position</a> property is <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-position-3/#valdef-position-fixed" id="ref-for-valdef-position-fixed">fixed</a>.</p>
     </ul>
    <li data-md>
     <p>Let <var>ancestor</var> be the parent of the element in the <a data-link-type="dfn" href="https://drafts.csswg.org/css-scoping-1/#flat-tree" id="ref-for-flat-tree">flat tree</a> and repeat these substeps:</p>
     <ol>
      <li data-md>
       <p>If <var>ancestor</var> is <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-closed-shadow-hidden" id="ref-for-concept-closed-shadow-hidden">closed-shadow-hidden</a> from the element and its computed value of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-position-3/#propdef-position" id="ref-for-propdef-position①">position</a> property is <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-position-3/#valdef-position-fixed" id="ref-for-valdef-position-fixed①">fixed</a>, terminate this algorithm and return null.</p>
      <li data-md>
       <p>If <var>ancestor</var> is not <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-closed-shadow-hidden" id="ref-for-concept-closed-shadow-hidden①">closed-shadow-hidden</a> from the element and satisfies at least one of the following, terminate this algorithm and return <var>ancestor</var>.</p>
       <ul>
        <li data-md>
         <p>The element is a containing block of absolutely-positioned descendants (regardless of whether there are any absolutely-positioned descendants).</p>
        <li data-md>
         <p>It is <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element①⑤">the HTML <code>body</code> element</a>.</p>
        <li data-md>
         <p>The computed value of the <a class="property" data-link-type="propdesc" href="https://drafts.csswg.org/css-position-3/#propdef-position" id="ref-for-propdef-position②">position</a> property of the element is <a class="css" data-link-type="maybe" href="https://drafts.csswg.org/css-position-3/#valdef-position-static" id="ref-for-valdef-position-static">static</a> and the ancestor is one of the following <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#html-elements" id="ref-for-html-elements②">HTML elements</a>: <code>td</code>, <code>th</code>, or <code>table</code>.</p>
       </ul>
      <li data-md>
       <p>If there is no more parent of <var>ancestor</var> in the <a data-link-type="dfn" href="https://drafts.csswg.org/css-scoping-1/#flat-tree" id="ref-for-flat-tree①">flat tree</a>, terminate this algorithm and return null.</p>
      <li data-md>
       <p>Let <var>ancestor</var> be the parent of <var>ancestor</var> in the <a data-link-type="dfn" href="https://drafts.csswg.org/css-scoping-1/#flat-tree" id="ref-for-flat-tree②">flat tree</a>.</p>
     </ol>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="HTMLElement" data-dfn-type="attribute" data-export id="dom-htmlelement-offsettop"><code>offsetTop</code></dfn> attribute must return the result of running these steps:</p>
   <ol>
    <li data-md>
     <p>If the element is <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element①⑥">the HTML <code>body</code> element</a> or does not have any associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box②⓪">CSS layout box</a> return zero and terminate this algorithm.</p>
    <li data-md>
     <p>If the <code class="idl"><a data-link-type="idl" href="#dom-htmlelement-offsetparent" id="ref-for-dom-htmlelement-offsetparent①">offsetParent</a></code> of the element is null return the y-coordinate of the top <a data-link-type="dfn" href="#border-edge" id="ref-for-border-edge④">border edge</a> of the first <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box②①">CSS layout box</a> associated with the element, relative to the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block①⑨">initial containing block</a> origin, ignoring any <a data-link-type="dfn" href="#transforms" id="ref-for-transforms①②">transforms</a> that apply to the element and its ancestors, and terminate this algorithm.</p>
    <li data-md>
     <p>Return the result of subtracting the y-coordinate of the top <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge②⑧">padding edge</a> of the first <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box②②">CSS layout box</a> associated with the <code class="idl"><a data-link-type="idl" href="#dom-htmlelement-offsetparent" id="ref-for-dom-htmlelement-offsetparent②">offsetParent</a></code> of the element
from the y-coordinate of the top <a data-link-type="dfn" href="#border-edge" id="ref-for-border-edge⑤">border edge</a> of the first <span id="ref-for-css-layout-box②③">CSS layout box</span> associated with the element,
relative to the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block②⓪">initial containing block</a> origin,
ignoring any <a data-link-type="dfn" href="#transforms" id="ref-for-transforms①③">transforms</a> that apply to the element and its ancestors.</p>
     <p class="note" role="note"><span>Note:</span> An inline element that consists of multiple line boxes will only have its first <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box②④">CSS layout box</a> considered.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="HTMLElement" data-dfn-type="attribute" data-export id="dom-htmlelement-offsetleft"><code>offsetLeft</code></dfn> attribute must return the result of running these steps:</p>
   <ol>
    <li data-md>
     <p>If the element is <a data-link-type="dfn" href="#the-html-body-element" id="ref-for-the-html-body-element①⑦">the HTML <code>body</code> element</a> or does not have any associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box②⑤">CSS layout box</a> return zero and terminate this algorithm.</p>
    <li data-md>
     <p>If the <code class="idl"><a data-link-type="idl" href="#dom-htmlelement-offsetparent" id="ref-for-dom-htmlelement-offsetparent③">offsetParent</a></code> of the element is null return the x-coordinate of the left <a data-link-type="dfn" href="#border-edge" id="ref-for-border-edge⑥">border edge</a> of the first <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box②⑥">CSS layout box</a> associated with the element, relative to the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block②①">initial containing block</a> origin, ignoring any <a data-link-type="dfn" href="#transforms" id="ref-for-transforms①④">transforms</a> that apply to the element and its ancestors, and terminate this algorithm.</p>
    <li data-md>
     <p>Return the result of subtracting the x-coordinate of the left <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge②⑨">padding edge</a> of the first <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box②⑦">CSS layout box</a> associated with the <code class="idl"><a data-link-type="idl" href="#dom-htmlelement-offsetparent" id="ref-for-dom-htmlelement-offsetparent④">offsetParent</a></code> of the element from the x-coordinate of the left <a data-link-type="dfn" href="#border-edge" id="ref-for-border-edge⑦">border edge</a> of the first <span id="ref-for-css-layout-box②⑧">CSS layout box</span> associated with the element, relative to the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block②②">initial containing block</a> origin, ignoring any <a data-link-type="dfn" href="#transforms" id="ref-for-transforms①⑤">transforms</a> that apply to the element and its ancestors.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="HTMLElement" data-dfn-type="attribute" data-export id="dom-htmlelement-offsetwidth"><code>offsetWidth</code></dfn> attribute must return the result of running these steps:</p>
   <ol>
    <li data-md>
     <p>If the element does not have any associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box②⑨">CSS layout box</a> return zero and terminate this algorithm.</p>
    <li data-md>
     <p>Return the <a data-link-type="dfn" href="#border-edge" id="ref-for-border-edge⑧">border edge</a> width of the first <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box③⓪">CSS layout box</a> associated with the element, ignoring any <a data-link-type="dfn" href="#transforms" id="ref-for-transforms①⑥">transforms</a> that apply to the element and its ancestors.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="HTMLElement" data-dfn-type="attribute" data-export id="dom-htmlelement-offsetheight"><code>offsetHeight</code></dfn> attribute must return the result of running these steps:</p>
   <ol>
    <li data-md>
     <p>If the element does not have any associated <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box③①">CSS layout box</a> return zero and terminate this algorithm.</p>
    <li data-md>
     <p>Return the <a data-link-type="dfn" href="#border-edge" id="ref-for-border-edge⑨">border edge</a> height of the first <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box③②">CSS layout box</a> associated with the element, ignoring any <a data-link-type="dfn" href="#transforms" id="ref-for-transforms①⑦">transforms</a> that apply to the element and its ancestors.</p>
   </ol>
   <h2 class="heading settled" data-level="8" id="extensions-to-the-htmlimageelement-interface"><span class="secno">8. </span><span class="content">Extensions to the <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/embedded-content.html#htmlimageelement" id="ref-for-htmlimageelement">HTMLImageElement</a></code> Interface</span><a class="self-link" href="#extensions-to-the-htmlimageelement-interface"></a></h2>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/embedded-content.html#htmlimageelement" id="ref-for-htmlimageelement①"><c- g>HTMLImageElement</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long③⓪"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-htmlimageelement-x" id="ref-for-dom-htmlimageelement-x"><c- g>x</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long③①"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-htmlimageelement-y" id="ref-for-dom-htmlimageelement-y"><c- g>y</c-></a>;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="HTMLImageElement" data-dfn-type="attribute" data-export id="dom-htmlimageelement-x"><code>x</code></dfn> attribute, on getting, must return the x-coordinate of the left <a data-link-type="dfn" href="#border-edge" id="ref-for-border-edge①⓪">border edge</a> of the
first <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box③③">CSS layout box</a> associated with the element, relative to the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block②③">initial containing block</a> origin, ignoring any <a data-link-type="dfn" href="#transforms" id="ref-for-transforms①⑧">transforms</a> that apply to the element and its ancestors, or zero if there is no <span id="ref-for-css-layout-box③④">CSS layout box</span>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="HTMLImageElement" data-dfn-type="attribute" data-export id="dom-htmlimageelement-y"><code>y</code></dfn> attribute, on getting, must return the y-coordinate of the top <a data-link-type="dfn" href="#border-edge" id="ref-for-border-edge①①">border edge</a> of the
first <a data-link-type="dfn" href="#css-layout-box" id="ref-for-css-layout-box③⑤">CSS layout box</a> associated with the element, relative to the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block②④">initial containing block</a> origin, ignoring any <a data-link-type="dfn" href="#transforms" id="ref-for-transforms①⑨">transforms</a> that apply to the element and its ancestors, or zero if there is no <span id="ref-for-css-layout-box③⑥">CSS layout box</span>.</p>
   <h2 class="heading settled" data-level="9" id="extensions-to-the-range-interface"><span class="secno">9. </span><span class="content">Extensions to the <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#range" id="ref-for-range①">Range</a></code> Interface</span><a class="self-link" href="#extensions-to-the-range-interface"></a></h2>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://dom.spec.whatwg.org/#range" id="ref-for-range②"><c- g>Range</c-></a> {
  <a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domrectlist" id="ref-for-domrectlist④"><c- n>DOMRectList</c-></a> <a class="idl-code" data-link-type="method" href="#dom-range-getclientrects" id="ref-for-dom-range-getclientrects①"><c- g>getClientRects</c-></a>();
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject" id="ref-for-NewObject③"><c- g>NewObject</c-></a>] <a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect①①"><c- n>DOMRect</c-></a> <a class="idl-code" data-link-type="method" href="#dom-range-getboundingclientrect" id="ref-for-dom-range-getboundingclientrect"><c- g>getBoundingClientRect</c-></a>();
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Range" data-dfn-type="method" data-export id="dom-range-getclientrects"><code>getClientRects()</code></dfn> method, when invoked, must return an empty <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrectlist" id="ref-for-domrectlist⑤">DOMRectList</a></code> object if the range is not in the document and otherwise a <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrectlist" id="ref-for-domrectlist⑥">DOMRectList</a></code> object
containing a list of <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect①②">DOMRect</a></code> objects in content order that matches the following constraints:</p>
   <ul>
    <li data-md>
     <p>For each element selected by the range, whose parent is not selected by the range, include the border areas returned by invoking <code class="idl"><a data-link-type="idl" href="#dom-element-getclientrects" id="ref-for-dom-element-getclientrects③">getClientRects()</a></code> on the element.</p>
    <li data-md>
     <p>For each <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#text" id="ref-for-text">Text</a></code> node selected or partially selected by the range (including when the
boundary-points are identical), include a <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect①③">DOMRect</a></code> object (for the part that is selected, not
the whole line box). The bounds of these <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect①④">DOMRect</a></code> objects are computed using font metrics;
thus, for horizontal writing, the vertical dimension of each box is determined by the font
ascent and descent, and the horizontal dimension by the text advance width. If the range covers
a partial <a data-link-type="dfn" href="https://drafts.csswg.org/css-text-3/#typographic-character-unit" id="ref-for-typographic-character-unit">typographic character unit</a> (e.g. half a surrogate pair or part of
a grapheme cluster), the full <span id="ref-for-typographic-character-unit①">typographic character unit</span> must be included
for the purpose of computing the bounds of the relevant <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect①⑤">DOMRect</a></code>. <a data-link-type="biblio" href="#biblio-css-text-3">[CSS-TEXT-3]</a> The <a data-link-type="dfn" href="#transforms" id="ref-for-transforms②⓪">transforms</a> that apply to the ancestors are applied.</p>
   </ul>
   <p class="note" role="note"><span>Note:</span> The <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect①⑥">DOMRect</a></code> objects returned by <code class="idl"><a data-link-type="idl" href="#dom-range-getclientrects" id="ref-for-dom-range-getclientrects②">getClientRects()</a></code> are not <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#live" id="ref-for-live③">live</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="Range" data-dfn-type="method" data-export id="dom-range-getboundingclientrect"><code>getBoundingClientRect()</code></dfn> method, when invoked, must return the result of the following
algorithm:</p>
   <ol>
    <li data-md>
     <p>Let <var>list</var> be the result of invoking <code class="idl"><a data-link-type="idl" href="#dom-range-getclientrects" id="ref-for-dom-range-getclientrects③">getClientRects()</a></code> on the same range this method was invoked on.</p>
    <li data-md>
     <p>If <var>list</var> is empty return a <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect①⑦">DOMRect</a></code> object whose <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#dom-domrect-x" id="ref-for-dom-domrect-x①">x</a></code>, <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#dom-domrect-y" id="ref-for-dom-domrect-y①">y</a></code>, <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#dom-domrect-width" id="ref-for-dom-domrect-width①">width</a></code> and <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#dom-domrect-height" id="ref-for-dom-domrect-height①">height</a></code> members are zero.</p>
    <li data-md>
     <p>If all rectangles in <var>list</var> have zero width or height, return the first rectangle in <var>list</var>.</p>
    <li data-md>
     <p>Otherwise, return a <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect①⑧">DOMRect</a></code> object describing the smallest rectangle that includes all
of the rectangles in <var>list</var> of which the height or width is not zero.</p>
   </ol>
   <p class="note" role="note"><span>Note:</span> The <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect①⑨">DOMRect</a></code> object returned by <code class="idl"><a data-link-type="idl" href="#dom-range-getboundingclientrect" id="ref-for-dom-range-getboundingclientrect①">getBoundingClientRect()</a></code> is not <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/infrastructure.html#live" id="ref-for-live④">live</a>.</p>
   <h2 class="heading settled" data-level="10" id="extensions-to-the-mouseevent-interface"><span class="secno">10. </span><span class="content">Extensions to the <code class="idl"><a data-link-type="idl" href="https://www.w3.org/TR/DOM-Level-3-Events/#interface-MouseEvent" id="ref-for-interface-MouseEvent">MouseEvent</a></code> Interface</span><a class="self-link" href="#extensions-to-the-mouseevent-interface"></a></h2>
   <p class="issue" id="issue-6025106e"><a class="self-link" href="#issue-6025106e"></a> The object IDL fragment redefines some members. Can we resolve this somehow?</p>
<pre class="idl highlight def"><c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://www.w3.org/TR/DOM-Level-3-Events/#interface-MouseEvent" id="ref-for-interface-MouseEvent①"><c- g>MouseEvent</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double①①"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-screenx" id="ref-for-dom-mouseevent-screenx"><c- g>screenX</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double①②"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-screeny" id="ref-for-dom-mouseevent-screeny"><c- g>screenY</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double①③"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-pagex" id="ref-for-dom-mouseevent-pagex"><c- g>pageX</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double①④"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-pagey" id="ref-for-dom-mouseevent-pagey"><c- g>pageY</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double①⑤"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-clientx" id="ref-for-dom-mouseevent-clientx"><c- g>clientX</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double①⑥"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-clienty" id="ref-for-dom-mouseevent-clienty"><c- g>clientY</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double①⑦"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-x" id="ref-for-dom-mouseevent-x"><c- g>x</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double①⑧"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-y" id="ref-for-dom-mouseevent-y"><c- g>y</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double①⑨"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-offsetx" id="ref-for-dom-mouseevent-offsetx"><c- g>offsetX</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double②⓪"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-offsety" id="ref-for-dom-mouseevent-offsety"><c- g>offsetY</c-></a>;
};

<c- b>partial</c-> <c- b>dictionary</c-> <a class="idl-code" data-link-type="dictionary" href="https://www.w3.org/TR/uievents/#dictdef-mouseeventinit" id="ref-for-dictdef-mouseeventinit"><c- g>MouseEventInit</c-></a> {
  <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double②①"><c- b>double</c-></a> <dfn class="idl-code" data-default="0.0" data-dfn-for="MouseEventInit" data-dfn-type="dict-member" data-export data-type="double " id="dom-mouseeventinit-screenx"><code><c- g>screenX</c-></code><a class="self-link" href="#dom-mouseeventinit-screenx"></a></dfn> = 0.0;
  <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double②②"><c- b>double</c-></a> <dfn class="idl-code" data-default="0.0" data-dfn-for="MouseEventInit" data-dfn-type="dict-member" data-export data-type="double " id="dom-mouseeventinit-screeny"><code><c- g>screenY</c-></code><a class="self-link" href="#dom-mouseeventinit-screeny"></a></dfn> = 0.0;
  <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double②③"><c- b>double</c-></a> <dfn class="idl-code" data-default="0.0" data-dfn-for="MouseEventInit" data-dfn-type="dict-member" data-export data-type="double " id="dom-mouseeventinit-clientx"><code><c- g>clientX</c-></code><a class="self-link" href="#dom-mouseeventinit-clientx"></a></dfn> = 0.0;
  <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double②④"><c- b>double</c-></a> <dfn class="idl-code" data-default="0.0" data-dfn-for="MouseEventInit" data-dfn-type="dict-member" data-export data-type="double " id="dom-mouseeventinit-clienty"><code><c- g>clientY</c-></code><a class="self-link" href="#dom-mouseeventinit-clienty"></a></dfn> = 0.0;
};
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MouseEvent" data-dfn-type="attribute" data-export id="dom-mouseevent-screenx"><code>screenX</code></dfn> attribute must return the x-coordinate of
the position where the event occurred relative to the origin of the <a data-link-type="dfn" href="#web-exposed-screen-area" id="ref-for-web-exposed-screen-area⑥">Web-exposed screen area</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MouseEvent" data-dfn-type="attribute" data-export id="dom-mouseevent-screeny"><code>screenY</code></dfn> attribute must return the y-coordinate of
the position where the event occurred relative to the origin of the <a data-link-type="dfn" href="#web-exposed-screen-area" id="ref-for-web-exposed-screen-area⑦">Web-exposed screen area</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MouseEvent" data-dfn-type="attribute" data-export id="dom-mouseevent-pagex"><code>pageX</code></dfn> attribute must follow these steps:</p>
   <ol>
    <li data-md>
     <p>If the event’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#dispatch-flag" id="ref-for-dispatch-flag">dispatch flag</a> is set, return the horizontal coordinate of the position where the event occurred relative to the origin of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block②⑤">initial containing block</a> and terminate these steps.</p>
    <li data-md>
     <p>Let <var>offset</var> be the value of the <code class="idl"><a data-link-type="idl" href="#dom-window-scrollx" id="ref-for-dom-window-scrollx⑧">scrollX</a></code> attribute of the event’s associated <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window③">Window</a></code> object, if there is one, or zero otherwise.</p>
    <li data-md>
     <p>Return the sum of <var>offset</var> and the value of the event’s <code class="idl"><a data-link-type="idl" href="#dom-mouseevent-clientx" id="ref-for-dom-mouseevent-clientx①">clientX</a></code> attribute.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MouseEvent" data-dfn-type="attribute" data-export id="dom-mouseevent-pagey"><code>pageY</code></dfn> attribute must follow these steps:</p>
   <ol>
    <li data-md>
     <p>If the event’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#dispatch-flag" id="ref-for-dispatch-flag①">dispatch flag</a> is set, return the vertical coordinate of the position where the event occurred relative to the origin of the <a data-link-type="dfn" href="https://drafts.csswg.org/css-display-3/#initial-containing-block" id="ref-for-initial-containing-block②⑥">initial containing block</a> and terminate these steps.</p>
    <li data-md>
     <p>Let <var>offset</var> be the value of the <code class="idl"><a data-link-type="idl" href="#dom-window-scrolly" id="ref-for-dom-window-scrolly⑦">scrollY</a></code> attribute of the event’s associated <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window④">Window</a></code> object, if there is one, or zero otherwise.</p>
    <li data-md>
     <p>Return the sum of <var>offset</var> and the value of the event’s <code class="idl"><a data-link-type="idl" href="#dom-mouseevent-clienty" id="ref-for-dom-mouseevent-clienty①">clientY</a></code> attribute.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MouseEvent" data-dfn-type="attribute" data-export id="dom-mouseevent-clientx"><code>clientX</code></dfn> attribute must return the x-coordinate of
the position where the event occurred relative to the origin of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑦⑨">viewport</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MouseEvent" data-dfn-type="attribute" data-export id="dom-mouseevent-clienty"><code>clientY</code></dfn> attribute must return the y-coordinate of
the position where the event occurred relative to the origin of the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑧⓪">viewport</a>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MouseEvent" data-dfn-type="attribute" data-export id="dom-mouseevent-x"><code>x</code></dfn> attribute must return the value of <code class="idl"><a data-link-type="idl" href="#dom-mouseevent-clientx" id="ref-for-dom-mouseevent-clientx②">clientX</a></code>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MouseEvent" data-dfn-type="attribute" data-export id="dom-mouseevent-y"><code>y</code></dfn> attribute must return the value of <code class="idl"><a data-link-type="idl" href="#dom-mouseevent-clienty" id="ref-for-dom-mouseevent-clienty②">clientY</a></code>.</p>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MouseEvent" data-dfn-type="attribute" data-export id="dom-mouseevent-offsetx"><code>offsetX</code></dfn> attribute must follow these steps:</p>
   <ol>
    <li data-md>
     <p>If the event’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#dispatch-flag" id="ref-for-dispatch-flag②">dispatch flag</a> is set, return the x-coordinate of the position where the event occurred relative to the origin of the <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge③⓪">padding edge</a> of the target node, ignoring the <a data-link-type="dfn" href="#transforms" id="ref-for-transforms②①">transforms</a> that apply to the element and its ancestors, and terminate these steps.</p>
    <li data-md>
     <p>Return the value of the event’s <code class="idl"><a data-link-type="idl" href="#dom-mouseevent-pagex" id="ref-for-dom-mouseevent-pagex①">pageX</a></code> attribute.</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="MouseEvent" data-dfn-type="attribute" data-export id="dom-mouseevent-offsety"><code>offsetY</code></dfn> attribute must follow these steps:</p>
   <ol>
    <li data-md>
     <p>If the event’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#dispatch-flag" id="ref-for-dispatch-flag③">dispatch flag</a> is set, return the y-coordinate of the position where the event occurred relative to the origin of the <a data-link-type="dfn" href="#padding-edge" id="ref-for-padding-edge③①">padding edge</a> of the target node, ignoring the <a data-link-type="dfn" href="#transforms" id="ref-for-transforms②②">transforms</a> that apply to the element and its ancestors, and terminate these steps.</p>
    <li data-md>
     <p>Return the value of the event’s <code class="idl"><a data-link-type="idl" href="#dom-mouseevent-pagey" id="ref-for-dom-mouseevent-pagey①">pageY</a></code> attribute.</p>
   </ol>
   <h2 class="heading settled" data-level="11" id="geometry"><span class="secno">11. </span><span class="content">Geometry</span><a class="self-link" href="#geometry"></a></h2>
   <h3 class="atrisk heading settled" data-level="11.1" id="the-geometryutils-interface"><span class="secno">11.1. </span><span class="content">The <code class="idl"><a data-link-type="idl" href="#geometryutils" id="ref-for-geometryutils">GeometryUtils</a></code> Interface</span><a class="self-link" href="#the-geometryutils-interface"></a></h3>
<pre class="idl highlight def"><c- b>enum</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="enum" data-export id="enumdef-cssboxtype"><code><c- g>CSSBoxType</c-></code></dfn> { <dfn class="idl-code" data-dfn-for="CSSBoxType" data-dfn-type="enum-value" data-export id="dom-cssboxtype-margin"><code><c- s>"margin"</c-></code><a class="self-link" href="#dom-cssboxtype-margin"></a></dfn>, <dfn class="idl-code" data-dfn-for="CSSBoxType" data-dfn-type="enum-value" data-export id="dom-cssboxtype-border"><code><c- s>"border"</c-></code><a class="self-link" href="#dom-cssboxtype-border"></a></dfn>, <dfn class="idl-code" data-dfn-for="CSSBoxType" data-dfn-type="enum-value" data-export id="dom-cssboxtype-padding"><code><c- s>"padding"</c-></code><a class="self-link" href="#dom-cssboxtype-padding"></a></dfn>, <dfn class="idl-code" data-dfn-for="CSSBoxType" data-dfn-type="enum-value" data-export id="dom-cssboxtype-content"><code><c- s>"content"</c-></code><a class="self-link" href="#dom-cssboxtype-content"></a></dfn> };
<c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-boxquadoptions"><code><c- g>BoxQuadOptions</c-></code></dfn> {
  <a class="n" data-link-type="idl-name" href="#enumdef-cssboxtype" id="ref-for-enumdef-cssboxtype"><c- n>CSSBoxType</c-></a> <dfn class="idl-code" data-default="&quot;border&quot;" data-dfn-for="BoxQuadOptions" data-dfn-type="dict-member" data-export data-type="CSSBoxType " id="dom-boxquadoptions-box"><code><c- g>box</c-></code><a class="self-link" href="#dom-boxquadoptions-box"></a></dfn> = "border";
  <a class="n" data-link-type="idl-name" href="#typedefdef-geometrynode" id="ref-for-typedefdef-geometrynode"><c- n>GeometryNode</c-></a> <dfn class="idl-code" data-dfn-for="BoxQuadOptions" data-dfn-type="dict-member" data-export data-type="GeometryNode " id="dom-boxquadoptions-relativeto"><code><c- g>relativeTo</c-></code><a class="self-link" href="#dom-boxquadoptions-relativeto"></a></dfn>; // XXX default document (i.e. viewport)
};

<c- b>dictionary</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="dictionary" data-export id="dictdef-convertcoordinateoptions"><code><c- g>ConvertCoordinateOptions</c-></code></dfn> {
  <a class="n" data-link-type="idl-name" href="#enumdef-cssboxtype" id="ref-for-enumdef-cssboxtype①"><c- n>CSSBoxType</c-></a> <dfn class="idl-code" data-default="&quot;border&quot;" data-dfn-for="ConvertCoordinateOptions" data-dfn-type="dict-member" data-export data-type="CSSBoxType " id="dom-convertcoordinateoptions-frombox"><code><c- g>fromBox</c-></code><a class="self-link" href="#dom-convertcoordinateoptions-frombox"></a></dfn> = "border";
  <a class="n" data-link-type="idl-name" href="#enumdef-cssboxtype" id="ref-for-enumdef-cssboxtype②"><c- n>CSSBoxType</c-></a> <dfn class="idl-code" data-default="&quot;border&quot;" data-dfn-for="ConvertCoordinateOptions" data-dfn-type="dict-member" data-export data-type="CSSBoxType " id="dom-convertcoordinateoptions-tobox"><code><c- g>toBox</c-></code><a class="self-link" href="#dom-convertcoordinateoptions-tobox"></a></dfn> = "border";
};

<c- b>interface</c-> <c- b>mixin</c-> <dfn class="dfn-paneled idl-code" data-dfn-type="interface" data-export id="geometryutils"><code><c- g>GeometryUtils</c-></code></dfn> {
  <c- b>sequence</c->&lt;<a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domquad" id="ref-for-domquad"><c- n>DOMQuad</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-geometryutils-getboxquads" id="ref-for-dom-geometryutils-getboxquads"><c- g>getBoxQuads</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-boxquadoptions" id="ref-for-dictdef-boxquadoptions"><c- n>BoxQuadOptions</c-></a> <dfn class="idl-code" data-dfn-for="GeometryUtils/getBoxQuads(options), GeometryUtils/getBoxQuads()" data-dfn-type="argument" data-export id="dom-geometryutils-getboxquads-options-options"><code><c- g>options</c-></code><a class="self-link" href="#dom-geometryutils-getboxquads-options-options"></a></dfn> = {});
  <a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domquad" id="ref-for-domquad①"><c- n>DOMQuad</c-></a> <a class="idl-code" data-link-type="method" href="#dom-geometryutils-convertquadfromnode" id="ref-for-dom-geometryutils-convertquadfromnode"><c- g>convertQuadFromNode</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#dictdef-domquadinit" id="ref-for-dictdef-domquadinit"><c- n>DOMQuadInit</c-></a> <dfn class="idl-code" data-dfn-for="GeometryUtils/convertQuadFromNode(quad, from, options), GeometryUtils/convertQuadFromNode(quad, from)" data-dfn-type="argument" data-export id="dom-geometryutils-convertquadfromnode-quad-from-options-quad"><code><c- g>quad</c-></code><a class="self-link" href="#dom-geometryutils-convertquadfromnode-quad-from-options-quad"></a></dfn>, <a class="n" data-link-type="idl-name" href="#typedefdef-geometrynode" id="ref-for-typedefdef-geometrynode①"><c- n>GeometryNode</c-></a> <dfn class="idl-code" data-dfn-for="GeometryUtils/convertQuadFromNode(quad, from, options), GeometryUtils/convertQuadFromNode(quad, from)" data-dfn-type="argument" data-export id="dom-geometryutils-convertquadfromnode-quad-from-options-from"><code><c- g>from</c-></code><a class="self-link" href="#dom-geometryutils-convertquadfromnode-quad-from-options-from"></a></dfn>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-convertcoordinateoptions" id="ref-for-dictdef-convertcoordinateoptions"><c- n>ConvertCoordinateOptions</c-></a> <dfn class="idl-code" data-dfn-for="GeometryUtils/convertQuadFromNode(quad, from, options), GeometryUtils/convertQuadFromNode(quad, from)" data-dfn-type="argument" data-export id="dom-geometryutils-convertquadfromnode-quad-from-options-options"><code><c- g>options</c-></code><a class="self-link" href="#dom-geometryutils-convertquadfromnode-quad-from-options-options"></a></dfn> = {});
  <a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domquad" id="ref-for-domquad②"><c- n>DOMQuad</c-></a> <a class="idl-code" data-link-type="method" href="#dom-geometryutils-convertrectfromnode" id="ref-for-dom-geometryutils-convertrectfromnode"><c- g>convertRectFromNode</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domrectreadonly" id="ref-for-domrectreadonly"><c- n>DOMRectReadOnly</c-></a> <dfn class="idl-code" data-dfn-for="GeometryUtils/convertRectFromNode(rect, from, options), GeometryUtils/convertRectFromNode(rect, from)" data-dfn-type="argument" data-export id="dom-geometryutils-convertrectfromnode-rect-from-options-rect"><code><c- g>rect</c-></code><a class="self-link" href="#dom-geometryutils-convertrectfromnode-rect-from-options-rect"></a></dfn>, <a class="n" data-link-type="idl-name" href="#typedefdef-geometrynode" id="ref-for-typedefdef-geometrynode②"><c- n>GeometryNode</c-></a> <dfn class="idl-code" data-dfn-for="GeometryUtils/convertRectFromNode(rect, from, options), GeometryUtils/convertRectFromNode(rect, from)" data-dfn-type="argument" data-export id="dom-geometryutils-convertrectfromnode-rect-from-options-from"><code><c- g>from</c-></code><a class="self-link" href="#dom-geometryutils-convertrectfromnode-rect-from-options-from"></a></dfn>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-convertcoordinateoptions" id="ref-for-dictdef-convertcoordinateoptions①"><c- n>ConvertCoordinateOptions</c-></a> <dfn class="idl-code" data-dfn-for="GeometryUtils/convertRectFromNode(rect, from, options), GeometryUtils/convertRectFromNode(rect, from)" data-dfn-type="argument" data-export id="dom-geometryutils-convertrectfromnode-rect-from-options-options"><code><c- g>options</c-></code><a class="self-link" href="#dom-geometryutils-convertrectfromnode-rect-from-options-options"></a></dfn> = {});
  <a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#dompoint" id="ref-for-dompoint"><c- n>DOMPoint</c-></a> <a class="idl-code" data-link-type="method" href="#dom-geometryutils-convertpointfromnode" id="ref-for-dom-geometryutils-convertpointfromnode"><c- g>convertPointFromNode</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#dictdef-dompointinit" id="ref-for-dictdef-dompointinit"><c- n>DOMPointInit</c-></a> <dfn class="idl-code" data-dfn-for="GeometryUtils/convertPointFromNode(point, from, options), GeometryUtils/convertPointFromNode(point, from)" data-dfn-type="argument" data-export id="dom-geometryutils-convertpointfromnode-point-from-options-point"><code><c- g>point</c-></code><a class="self-link" href="#dom-geometryutils-convertpointfromnode-point-from-options-point"></a></dfn>, <a class="n" data-link-type="idl-name" href="#typedefdef-geometrynode" id="ref-for-typedefdef-geometrynode③"><c- n>GeometryNode</c-></a> <dfn class="idl-code" data-dfn-for="GeometryUtils/convertPointFromNode(point, from, options), GeometryUtils/convertPointFromNode(point, from)" data-dfn-type="argument" data-export id="dom-geometryutils-convertpointfromnode-point-from-options-from"><code><c- g>from</c-></code><a class="self-link" href="#dom-geometryutils-convertpointfromnode-point-from-options-from"></a></dfn>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-convertcoordinateoptions" id="ref-for-dictdef-convertcoordinateoptions②"><c- n>ConvertCoordinateOptions</c-></a> <dfn class="idl-code" data-dfn-for="GeometryUtils/convertPointFromNode(point, from, options), GeometryUtils/convertPointFromNode(point, from)" data-dfn-type="argument" data-export id="dom-geometryutils-convertpointfromnode-point-from-options-options"><code><c- g>options</c-></code><a class="self-link" href="#dom-geometryutils-convertpointfromnode-point-from-options-options"></a></dfn> = {}); // XXX z,w turns into 0
};

<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#text" id="ref-for-text①"><c- n>Text</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#geometryutils" id="ref-for-geometryutils①"><c- n>GeometryUtils</c-></a>; // like Range
<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element" id="ref-for-element⑦"><c- n>Element</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#geometryutils" id="ref-for-geometryutils②"><c- n>GeometryUtils</c-></a>;
<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/css-pseudo-4/#csspseudoelement" id="ref-for-csspseudoelement"><c- n>CSSPseudoElement</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#geometryutils" id="ref-for-geometryutils③"><c- n>GeometryUtils</c-></a>;
<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#document" id="ref-for-document⑨"><c- n>Document</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#geometryutils" id="ref-for-geometryutils④"><c- n>GeometryUtils</c-></a>;

<c- b>typedef</c-> (<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#text" id="ref-for-text②"><c- n>Text</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element" id="ref-for-element⑧"><c- n>Element</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/css-pseudo-4/#csspseudoelement" id="ref-for-csspseudoelement①"><c- n>CSSPseudoElement</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#document" id="ref-for-document①⓪"><c- n>Document</c-></a>) <dfn class="dfn-paneled idl-code" data-dfn-type="typedef" data-export id="typedefdef-geometrynode"><code><c- g>GeometryNode</c-></code></dfn>;
</pre>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="GeometryUtils" data-dfn-type="method" data-export data-lt="getBoxQuads(options)|getBoxQuads()" id="dom-geometryutils-getboxquads"><code>getBoxQuads(<var>options</var>)</code></dfn> method must run the following steps:</p>
   <ol>
    <li class="issue" id="issue-33d3f260">
     <a class="self-link" href="#issue-33d3f260"></a> DOM order 
     <p>p1 = top left even in RTL</p>
     <p>scale to 0 means divide by zero, return 0x0</p>
     <p>cross-frames not allowed, throw WrongDocumentError?</p>
     <p>points are flattened (3d transform), z=0. like getClientRect</p>
     <p>test block in inline</p>
     <p>pseudo-elements before/after are children of the element</p>
     <p>viewport boxes are all the same</p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="GeometryUtils" data-dfn-type="method" data-export data-lt="convertQuadFromNode(quad, from, options)|convertQuadFromNode(quad, from)" id="dom-geometryutils-convertquadfromnode"><code>convertQuadFromNode(<var>quad</var>, <var>from</var>, <var>options</var>)</code></dfn> method
must run the following steps:</p>
   <ol>
    <li>
     <p class="issue" id="issue-2f43b42f"><a class="self-link" href="#issue-2f43b42f"></a>... </p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="GeometryUtils" data-dfn-type="method" data-export data-lt="convertRectFromNode(rect, from, options)|convertRectFromNode(rect, from)" id="dom-geometryutils-convertrectfromnode"><code>convertRectFromNode(<var>rect</var>, <var>from</var>, <var>options</var>)</code></dfn> method
must run the following steps:</p>
   <ol>
    <li>
     <p class="issue" id="issue-2f43b42f①"><a class="self-link" href="#issue-2f43b42f①"></a>... </p>
   </ol>
   <p>The <dfn class="dfn-paneled idl-code" data-dfn-for="GeometryUtils" data-dfn-type="method" data-export data-lt="convertPointFromNode(point, from, options)|convertPointFromNode(point, from)" id="dom-geometryutils-convertpointfromnode"><code>convertPointFromNode(<var>point</var>, <var>from</var>, <var>options</var>)</code></dfn> method must run the following steps:</p>
   <ol>
    <li>
     <p class="issue" id="issue-2f43b42f②"><a class="self-link" href="#issue-2f43b42f②"></a>... </p>
   </ol>
   <h2 class="heading settled" data-level="12" id="events"><span class="secno">12. </span><span class="content">Events</span><a class="self-link" href="#events"></a></h2>
   <h3 class="heading settled" data-level="12.1" id="resizing-viewports"><span class="secno">12.1. </span><span class="content">Resizing viewports</span><a class="self-link" href="#resizing-viewports"></a></h3>
   <p>This section integrates with the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-agent-event-loop" id="ref-for-concept-agent-event-loop①">event loop</a> defined in HTML. <a data-link-type="biblio" href="#biblio-html">[HTML]</a></p>
   <p>When asked to <dfn data-dfn-type="dfn" data-noexport id="run-the-resize-steps">run the resize steps<a class="self-link" href="#run-the-resize-steps"></a></dfn> for a <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document①①">Document</a></code> <var>doc</var>, run these steps:</p>
   <ol>
    <li data-md>
     <p>If <var>doc</var>’s <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑧①">viewport</a> has had its width or height changed
(e.g. as a result of the user resizing the browser window,
or changing the <span>page zoom</span> scale factor,
or an <code>iframe</code> element’s dimensions are changed)
since the last time these steps were run, <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-event-fire" id="ref-for-concept-event-fire①">fire an event</a> named <a class="idl-code" data-link-type="event" href="#eventdef-window-resize" id="ref-for-eventdef-window-resize">resize</a> at the <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window⑤">Window</a></code> object associated with <var>doc</var>.</p>
   </ol>
   <h3 class="heading settled" data-level="12.2" id="scrolling-events"><span class="secno">12.2. </span><span class="content">Scrolling</span><a class="self-link" href="#scrolling-events"></a></h3>
   <p>This section integrates with the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-agent-event-loop" id="ref-for-concept-agent-event-loop②">event loop</a> defined in HTML. <a data-link-type="biblio" href="#biblio-html">[HTML]</a></p>
   <p>Each <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document①②">Document</a></code> has an associated list of <dfn class="dfn-paneled" data-dfn-type="dfn" data-noexport id="pending-scroll-event-targets">pending scroll event targets</dfn>, initially empty.</p>
   <p>Whenever a <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑧②">viewport</a> gets scrolled (whether in response to user interaction or by an API), the user agent must run these steps:</p>
   <ol>
    <li data-md>
     <p>Let <var>doc</var> be the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑧③">viewport’s</a> associated <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document①③">Document</a></code>.</p>
    <li data-md>
     <p>If <var>doc</var> is already in <var>doc</var>’s <a data-link-type="dfn" href="#pending-scroll-event-targets" id="ref-for-pending-scroll-event-targets">pending scroll event targets</a>, abort these steps.</p>
    <li data-md>
     <p>Append <var>doc</var> to <var>doc</var>’s <a data-link-type="dfn" href="#pending-scroll-event-targets" id="ref-for-pending-scroll-event-targets①">pending scroll event targets</a>.</p>
   </ol>
   <p>Whenever an element gets scrolled (whether in response to user interaction or by an API), the user agent must run these steps:</p>
   <ol>
    <li data-md>
     <p>Let <var>doc</var> be the element’s <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-node-document" id="ref-for-concept-node-document①①">node document</a>.</p>
    <li data-md>
     <p>If the element is already in <var>doc</var>’s <a data-link-type="dfn" href="#pending-scroll-event-targets" id="ref-for-pending-scroll-event-targets②">pending scroll event targets</a>, abort these steps.</p>
    <li data-md>
     <p>Append the element to <var>doc</var>’s <a data-link-type="dfn" href="#pending-scroll-event-targets" id="ref-for-pending-scroll-event-targets③">pending scroll event targets</a>.</p>
   </ol>
   <p>When asked to <dfn data-dfn-type="dfn" data-noexport id="run-the-scroll-steps">run the scroll steps<a class="self-link" href="#run-the-scroll-steps"></a></dfn> for a <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document①④">Document</a></code> <var>doc</var>, run these steps:</p>
   <ol>
    <li data-md>
     <p>For each item <var>target</var> in <var>doc</var>’s <a data-link-type="dfn" href="#pending-scroll-event-targets" id="ref-for-pending-scroll-event-targets④">pending scroll event targets</a>,
in the order they were added to the list, run these substeps:</p>
     <ol>
      <li data-md>
       <p>If <var>target</var> is a <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document①⑤">Document</a></code>, <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-event-fire" id="ref-for-concept-event-fire②">fire an event</a> named <a class="idl-code" data-link-type="event" href="#eventdef-document-scroll" id="ref-for-eventdef-document-scroll">scroll</a> that bubbles at <var>target</var>.</p>
      <li data-md>
       <p>Otherwise, <a data-link-type="dfn" href="https://dom.spec.whatwg.org/#concept-event-fire" id="ref-for-concept-event-fire③">fire an event</a> named <a class="idl-code" data-link-type="event" href="#eventdef-document-scroll" id="ref-for-eventdef-document-scroll①">scroll</a> at <var>target</var>.</p>
     </ol>
    <li data-md>
     <p>Empty <var>doc</var>’s <a data-link-type="dfn" href="#pending-scroll-event-targets" id="ref-for-pending-scroll-event-targets⑤">pending scroll event targets</a>.</p>
   </ol>
   <h3 class="heading settled" data-level="12.3" id="event-summary"><span class="secno">12.3. </span><span class="content">Event summary</span><a class="self-link" href="#event-summary"></a></h3>
   <p><i>This section is non-normative.</i></p>
   <table class="complex data">
    <thead>
     <tr>
      <th>Event 
      <th>Interface 
      <th>Interesting targets 
      <th>Description 
    <tbody>
     <tr>
      <td><dfn class="dfn-paneled idl-code" data-dfn-for="Window" data-dfn-type="event" data-export id="eventdef-window-resize"><code>resize</code></dfn> 
      <td><code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#event" id="ref-for-event②">Event</a></code> 
      <td><code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window⑥">Window</a></code> 
      <td>Fired at the <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window⑦">Window</a></code> when the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑧④">viewport</a> is resized. 
     <tr>
      <td><dfn class="dfn-paneled idl-code" data-dfn-for="Document, Element" data-dfn-type="event" data-export id="eventdef-document-scroll"><code>scroll</code></dfn> 
      <td><code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#event" id="ref-for-event③">Event</a></code> 
      <td><code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document①⑥">Document</a></code>, elements 
      <td>Fired at the <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document①⑦">Document</a></code> or element when the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑧⑤">viewport</a> or element is scrolled, respectively. 
   </table>
   <h2 class="heading settled" data-level="13" id="css-properties"><span class="secno">13. </span><span class="content">CSS properties</span><a class="self-link" href="#css-properties"></a></h2>
   <p class="issue" id="issue-e12d69d6"><a class="self-link" href="#issue-e12d69d6"></a> The features in this section should be moved to some other specification.</p>
   <h3 class="heading settled caniuse-paneled" data-level="13.1" id="smooth-scrolling"><span class="secno">13.1. </span><span class="content">Smooth Scrolling: The <a class="property" data-link-type="propdesc" href="#propdef-scroll-behavior" id="ref-for-propdef-scroll-behavior②">scroll-behavior</a> Property</span><a class="self-link" href="#smooth-scrolling"></a></h3>
   <table class="def propdef" data-link-for-hint="scroll-behavior">
    <tbody>
     <tr>
      <th>Name:
      <td><dfn class="dfn-paneled css" data-dfn-type="property" data-export id="propdef-scroll-behavior">scroll-behavior</dfn>
     <tr class="value">
      <th><a href="https://drafts.csswg.org/css-values/#value-defs">Value:</a>
      <td class="prod">auto <a data-link-type="grammar" href="https://drafts.csswg.org/css-values-4/#comb-one" id="ref-for-comb-one">|</a> smooth
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#initial-values">Initial:</a>
      <td>auto
     <tr>
      <th>Applies to:
      <td><a data-link-type="dfn" href="#scrolling-box" id="ref-for-scrolling-box①②">scrolling boxes</a>
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#inherited-property">Inherited:</a>
      <td>no
     <tr>
      <th><a href="https://drafts.csswg.org/css-values/#percentages">Percentages:</a>
      <td>n/a
     <tr>
      <th><a href="https://drafts.csswg.org/css-cascade/#computed">Computed value:</a>
      <td>specified value
     <tr>
      <th>Canonical order:
      <td>per grammar
     <tr>
      <th><a href="https://drafts.csswg.org/web-animations/#animation-type">Animatable:</a>
      <td>no
   </table>
   <p>The <a class="property" data-link-type="propdesc" href="#propdef-scroll-behavior" id="ref-for-propdef-scroll-behavior③">scroll-behavior</a> property specifies the scrolling behavior for a <a data-link-type="dfn" href="#scrolling-box" id="ref-for-scrolling-box①③">scrolling box</a>,
when scrolling happens due to navigation or CSSOM scrolling APIs.
Any other scrolls, e.g. those that are performed by the user, are not affected by this property.
When this property is specified on the root element, it applies to the <a data-link-type="dfn" href="#viewport" id="ref-for-viewport⑧⑥">viewport</a> instead.</p>
   <p class="note" role="note">The <a class="property" data-link-type="propdesc" href="#propdef-scroll-behavior" id="ref-for-propdef-scroll-behavior④">scroll-behavior</a> property of the HTML <code>body</code> element is <em>not</em> propagated to the viewport. </p>
   <dl>
    <dt><dfn class="dfn-paneled css" data-dfn-for="scroll-behavior" data-dfn-type="value" data-export id="valdef-scroll-behavior-auto">auto</dfn> 
    <dd>The <a data-link-type="dfn" href="#scrolling-box" id="ref-for-scrolling-box①④">scrolling box</a> is scrolled in an instant fashion. 
    <dt><dfn class="dfn-paneled css" data-dfn-for="scroll-behavior" data-dfn-type="value" data-export id="valdef-scroll-behavior-smooth">smooth</dfn> 
    <dd>The <a data-link-type="dfn" href="#scrolling-box" id="ref-for-scrolling-box①⑤">scrolling box</a> is scrolled in a smooth fashion using a user-agent-defined timing function over a user-agent-defined period of time. User
 agents should follow platform conventions, if any. 
   </dl>
   <p>User agents may ignore this property.</p>
   <h2 class="no-num heading settled" id="change-history"><span class="content">Change History</span><a class="self-link" href="#change-history"></a></h2>
   <p>This section documents some of the changes between publications of this specification. This section is not exhaustive. Bug fixes and editorial changes are
generally not listed.</p>
   <h3 class="no-num heading settled" id="changes-from-2020-01-31"><span class="content">Changes From 31 January 2020</span><a class="self-link" href="#changes-from-2020-01-31"></a></h3>
   <ul>
    <li data-md>
     <p>Added Simon Fraser as editor</p>
    <li data-md>
     <p>Renamed the arguments to <code class="idl"><a data-link-type="idl" href="#dom-window-resizeto" id="ref-for-dom-window-resizeto①">resizeTo()</a></code> to be <var>width</var> and <var>height</var> (<a href="https://github.com/w3c/csswg-drafts/issues/4727">4727</a>)</p>
   </ul>
   <h3 class="no-num heading settled" id="changes-from-2013-12-17"><span class="content">Changes From 17 December 2013 To 31 January 2020</span><a class="self-link" href="#changes-from-2013-12-17"></a></h3>
   <ul>
    <li data-md>
     <p>The <code class="idl"><a data-link-type="idl" href="#dom-element-scrollintoview" id="ref-for-dom-element-scrollintoview①">scrollIntoView()</a></code> method on <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#element" id="ref-for-element⑨">Element</a></code> was changed and extended.</p>
    <li data-md>
     <p>The <code class="idl"><a data-link-type="idl" href="#dom-element-scrolltop" id="ref-for-dom-element-scrolltop⑤">scrollTop</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-element-scrollleft" id="ref-for-dom-element-scrollleft⑤">scrollLeft</a></code> IDL attributes on <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#element" id="ref-for-element①⓪">Element</a></code> changed to no
longer take an object; the <code class="idl"><a data-link-type="idl" href="#dom-element-scroll" id="ref-for-dom-element-scroll④">scroll()</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-element-scrollto" id="ref-for-dom-element-scrollto②">scrollTo()</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-element-scrollby" id="ref-for-dom-element-scrollby②">scrollBy()</a></code> methods were added instead.</p>
    <li data-md>
     <p>The <code class="idl"><a data-link-type="idl" href="#dom-element-scrollwidth" id="ref-for-dom-element-scrollwidth①">scrollWidth</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-element-scrollheight" id="ref-for-dom-element-scrollheight①">scrollHeight</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-element-clienttop" id="ref-for-dom-element-clienttop①">clientTop</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-element-clientleft" id="ref-for-dom-element-clientleft①">clientLeft</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-element-clientwidth" id="ref-for-dom-element-clientwidth①">clientWidth</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-element-clientheight" id="ref-for-dom-element-clientheight①">clientHeight</a></code> IDL attributes on <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#element" id="ref-for-element①①">Element</a></code> were changed back to return integers.</p>
    <li data-md>
     <p>The <code>DOMRectList</code> interface was removed.</p>
    <li data-md>
     <p>The <code class="idl"><a data-link-type="idl" href="#dom-document-scrollingelement" id="ref-for-dom-document-scrollingelement②">scrollingElement</a></code> IDL attribute on <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#document" id="ref-for-document①⑧">Document</a></code> was added.</p>
    <li data-md>
     <p>Some readonly attributes on <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window⑧">Window</a></code> were annotated with <code>[Replaceable]</code> IDL extended
attribute.</p>
    <li data-md>
     <p><code class="idl"><a data-link-type="idl" href="#mediaquerylist" id="ref-for-mediaquerylist①①">MediaQueryList</a></code>, <a class="idl-code" data-link-type="event" href="#eventdef-document-scroll" id="ref-for-eventdef-document-scroll②">scroll</a> event and <a class="idl-code" data-link-type="event" href="#eventdef-window-resize" id="ref-for-eventdef-window-resize①">resize</a> event are integrated with
the <a data-link-type="dfn" href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-agent-event-loop" id="ref-for-concept-agent-event-loop③">event loop</a> in HTML so they are synchronized with animation frames.</p>
    <li data-md>
     <p>The <code>instant</code> value of <a class="property" data-link-type="propdesc" href="#propdef-scroll-behavior" id="ref-for-propdef-scroll-behavior⑤">scroll-behavior</a> was renamed to <a class="css" data-link-type="maybe" href="#valdef-scroll-behavior-auto" id="ref-for-valdef-scroll-behavior-auto">auto</a>.</p>
    <li data-md>
     <p>The origin of <code class="idl"><a data-link-type="idl" href="#dom-element-scrollleft" id="ref-for-dom-element-scrollleft⑥">scrollLeft</a></code> on <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#element" id="ref-for-element①②">Element</a></code> was changed (for RTL).</p>
    <li data-md>
     <p>The <code class="idl"><a data-link-type="idl" href="#dom-element-scrollintoview" id="ref-for-dom-element-scrollintoview②">scrollIntoView()</a></code> method on <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#element" id="ref-for-element①③">Element</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-window-scroll" id="ref-for-dom-window-scroll①⓪">scroll()</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-window-scrollto" id="ref-for-dom-window-scrollto②">scrollTo()</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-window-scrollby" id="ref-for-dom-window-scrollby②">scrollBy()</a></code> methods on <code class="idl"><a data-link-type="idl" href="https://html.spec.whatwg.org/multipage/window-object.html#window" id="ref-for-window⑨">Window</a></code> take the relevant
dictionary as the first argument.</p>
    <li data-md>
     <p>The <code class="idl"><a data-link-type="idl" href="#mediaquerylist" id="ref-for-mediaquerylist①②">MediaQueryList</a></code> interface was changed to use regular event API and define <code class="idl"><a data-link-type="idl" href="#dom-mediaquerylist-addlistener" id="ref-for-dom-mediaquerylist-addlistener③">addListener()</a></code> in terms of that.</p>
   </ul>
   <h3 class="no-num heading settled" id="changes-from-2011-08-04"><span class="content">Changes From 4 August 2011 To 17 December 2013</span><a class="self-link" href="#changes-from-2011-08-04"></a></h3>
   <ul>
    <li data-md>
     <p>The specification now handles right-to-left and vertical writing modes.</p>
    <li data-md>
     <p>The specification is now aware of <a data-link-type="dfn" href="#page-zoom" id="ref-for-page-zoom①">page zoom</a> and <a data-link-type="dfn" href="#pinch-zoom" id="ref-for-pinch-zoom①">pinch zoom</a>.</p>
    <li data-md>
     <p>The <a class="property" data-link-type="propdesc" href="#propdef-scroll-behavior" id="ref-for-propdef-scroll-behavior⑥">scroll-behavior</a> CSS property is introduced and scrolling APIs are extended with a mechanism to control smooth scrolling.</p>
    <li data-md>
     <p>The <code class="idl"><a data-link-type="idl" href="#dom-window-moveto" id="ref-for-dom-window-moveto①">moveTo()</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-window-moveby" id="ref-for-dom-window-moveby①">moveBy()</a></code>, <code class="idl"><a data-link-type="idl" href="#dom-window-resizeto" id="ref-for-dom-window-resizeto②">resizeTo()</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-window-resizeby" id="ref-for-dom-window-resizeby①">resizeBy()</a></code> methods are now defined.</p>
    <li data-md>
     <p><code class="idl"><a data-link-type="idl" href="#dom-window-innerwidth" id="ref-for-dom-window-innerwidth①">innerWidth</a></code> et al now use the WebIDL type <code class="idl"><a data-link-type="idl" href="http://heycam.github.io/webidl/#idl-double" id="ref-for-idl-double②⑤">double</a></code> instead of <code class="idl"><a data-link-type="idl" href="http://heycam.github.io/webidl/#idl-long" id="ref-for-idl-long③②">long</a></code>.</p>
    <li data-md>
     <p><code class="idl"><a data-link-type="idl" href="#dom-window-devicepixelratio" id="ref-for-dom-window-devicepixelratio①">devicePixelRatio</a></code> is now defined.</p>
    <li data-md>
     <p>The <code>features</code> argument to <a class="idl-code" data-link-type="method" href="https://html.spec.whatwg.org/multipage/window-object.html#dom-open" id="ref-for-dom-open②">window.open()</a> is now defined.</p>
    <li data-md>
     <p>The <code class="idl"><a data-link-type="idl" href="#dom-screen-colordepth" id="ref-for-dom-screen-colordepth②">colorDepth</a></code> and <code class="idl"><a data-link-type="idl" href="#dom-screen-pixeldepth" id="ref-for-dom-screen-pixeldepth②">pixelDepth</a></code> attributes of <code class="idl"><a data-link-type="idl" href="#screen" id="ref-for-screen④">Screen</a></code> now always return 24.</p>
    <li data-md>
     <p>The <code class="idl"><a data-link-type="idl" href="#dom-document-elementsfrompoint" id="ref-for-dom-document-elementsfrompoint①">elementsFromPoint()</a></code> method of <code class="idl"><a data-link-type="idl" href="https://dom.spec.whatwg.org/#element" id="ref-for-element①④">Element</a></code> is introduced.</p>
    <li data-md>
     <p>The specification is now aware of <a data-link-type="dfn" href="#transforms" id="ref-for-transforms②③">transforms</a>.</p>
    <li data-md>
     <p>Some geometry utility APIs are introduced but are not yet specified.</p>
    <li data-md>
     <p><code>ClientRect</code> has been renamed to <code class="idl"><a data-link-type="idl" href="https://drafts.fxtf.org/geometry-1/#domrect" id="ref-for-domrect②⓪">DOMRect</a></code> and has moved to the Geometry specification. <a data-link-type="biblio" href="#biblio-geometry-1">[GEOMETRY-1]</a></p>
    <li data-md>
     <p>The specification now defines when the <code>resize</code> and <code>scroll</code> events fire.</p>
   </ul>
   <h2 class="no-num heading settled" id="acks"><span class="content">Acknowledgments</span><a class="self-link" href="#acks"></a></h2>
   <p>The editors would like to thank
Alan Stearns,
Alexey Feldgendler,
Antonio Gomes,
Björn Höhrmann,
Boris Zbarsky,
Chris Rebert,
Corey Farwell,
Dan Bates,
David Vest,
Elliott Sprehn,
Garrett Smith,
Henrik Andersson,
Hallvord R. M. Steen,
Kang-Hao Lu,
Koji Ishii,
Leif Arne Storset,
Luiz Agostini,
Maciej Stachowiak,
Michael Dyck,
Mike Wilson,
Morten Stenshorne,
Olli Pettay,
Pavel Curtis,
Peter-Paul Koch,
Rachel Kmetz,
Rick Byers,
Robert O’Callahan,
Sam Weinig,
Scott Johnson,
Sebastian Zartner,
Stewart Brodie,
Sylvain Galineau,
Tab Atkins,
Tarquin Wilton-Jones,
Thomas Moore,
Thomas Shinnick,
and
Xiaomei Ji
for their contributions to this document.</p>
   <p>Special thanks to the Microsoft employees who first implemented many of
the features specified in this draft, which were first widely deployed by
the Windows Internet Explorer browser.</p>
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
  <aside class="caniuse-status" data-deco data-dfn-id="dom-window-matchmedia">
   <input class="caniuse-panel-btn" type="button" value="⋰">
   <p class="support"><b>Support:</b><span class="android yes"><span>Android Browser</span><span>3+</span></span><span class="baidu yes"><span>Baidu Browser</span><span>7.12+</span></span><span class="bb yes"><span>Blackberry Browser</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>9+</span></span><span class="and_chr yes"><span>Chrome for Android</span><span>80+</span></span><span class="edge yes"><span>Edge</span><span>12+</span></span><span class="firefox yes"><span>Firefox</span><span>6+</span></span><span class="and_ff yes"><span>Firefox for Android</span><span>68+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span><span class="ie_mob yes"><span>IE Mobile</span><span>10+</span></span><span class="kaios yes"><span>KaiOS Browser</span><span>2.5+</span></span><span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="op_mini yes"><span>Opera Mini</span><span>All</span></span><span class="op_mob yes"><span>Opera Mobile</span><span>12.1+</span></span><span class="and_qq yes"><span>QQ Browser</span><span>1.2+</span></span><span class="safari yes"><span>Safari</span><span>5.1+</span></span><span class="samsung yes"><span>Samsung Internet</span><span>4+</span></span><span class="and_uc yes"><span>UC Browser for Android</span><span>12.12+</span></span><span class="ios_saf yes"><span>iOS Safari</span><span>5.0+</span></span></p>
   <p class="caniuse">Source: <a href="https://caniuse.com/#feat=matchmedia">caniuse.com</a> as of 2020-04-13</p>
  </aside>
  <aside class="caniuse-status" data-deco data-dfn-id="dom-window-devicepixelratio">
   <input class="caniuse-panel-btn" type="button" value="⋰">
   <p class="support"><b>Support:</b><span class="android yes"><span>Android Browser</span><span>2.1+</span></span><span class="baidu yes"><span>Baidu Browser</span><span>7.12+</span></span><span class="bb yes"><span>Blackberry Browser</span><span>7+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><span class="and_chr yes"><span>Chrome for Android</span><span>80+</span></span><span class="edge yes"><span>Edge</span><span>12+</span></span><span class="firefox yes"><span>Firefox</span><span>18+</span></span><span class="and_ff yes"><span>Firefox for Android</span><span>68+</span></span><span class="ie yes"><span>IE</span><span>11+</span></span><span class="ie_mob yes"><span>IE Mobile</span><span>11+</span></span><span class="kaios yes"><span>KaiOS Browser</span><span>2.5+</span></span><span class="opera yes"><span>Opera</span><span>11.6+</span></span><span class="op_mini yes"><span>Opera Mini</span><span>All</span></span><span class="op_mob yes"><span>Opera Mobile</span><span>12+</span></span><span class="and_qq yes"><span>QQ Browser</span><span>1.2+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="samsung yes"><span>Samsung Internet</span><span>4+</span></span><span class="and_uc yes"><span>UC Browser for Android</span><span>12.12+</span></span><span class="ios_saf yes"><span>iOS Safari</span><span>3.2+</span></span></p>
   <p class="caniuse">Source: <a href="https://caniuse.com/#feat=devicepixelratio">caniuse.com</a> as of 2020-04-13</p>
  </aside>
  <aside class="caniuse-status" data-deco data-dfn-id="dom-document-elementfrompoint">
   <input class="caniuse-panel-btn" type="button" value="⋰">
   <p class="support"><b>Support:</b><span class="android yes"><span>Android Browser</span><span>2.3+</span></span><span class="baidu yes"><span>Baidu Browser</span><span>7.12+</span></span><span class="bb yes"><span>Blackberry Browser</span><span>7+</span></span><span class="chrome yes"><span>Chrome</span><span>15+</span></span><span class="and_chr yes"><span>Chrome for Android</span><span>80+</span></span><span class="edge yes"><span>Edge</span><span>12+</span></span><span class="firefox yes"><span>Firefox</span><span>3+</span></span><span class="and_ff yes"><span>Firefox for Android</span><span>68+</span></span><span class="ie yes"><span>IE</span><span>6+</span></span><span class="ie_mob yes"><span>IE Mobile</span><span>10+</span></span><span class="kaios yes"><span>KaiOS Browser</span><span>2.5+</span></span><span class="opera yes"><span>Opera</span><span>11+</span></span><span class="op_mini yes"><span>Opera Mini</span><span>All</span></span><span class="op_mob yes"><span>Opera Mobile</span><span>12+</span></span><span class="and_qq yes"><span>QQ Browser</span><span>1.2+</span></span><span class="safari yes"><span>Safari</span><span>5+</span></span><span class="samsung yes"><span>Samsung Internet</span><span>4+</span></span><span class="and_uc yes"><span>UC Browser for Android</span><span>12.12+</span></span><span class="ios_saf yes"><span>iOS Safari</span><span>4.0+</span></span></p>
   <p class="caniuse">Source: <a href="https://caniuse.com/#feat=element-from-point">caniuse.com</a> as of 2020-04-13</p>
  </aside>
  <aside class="caniuse-status" data-deco data-dfn-id="dom-element-getboundingclientrect">
   <input class="caniuse-panel-btn" type="button" value="⋰">
   <p class="support"><b>Support:</b><span class="android yes"><span>Android Browser</span><span>2.3+</span></span><span class="baidu yes"><span>Baidu Browser</span><span>7.12+</span></span><span class="bb yes"><span>Blackberry Browser</span><span>7+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span><span class="and_chr yes"><span>Chrome for Android</span><span>80+</span></span><span class="edge yes"><span>Edge</span><span>12+</span></span><span class="firefox yes"><span>Firefox</span><span>12+</span></span><span class="and_ff yes"><span>Firefox for Android</span><span>68+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span><span class="ie_mob yes"><span>IE Mobile</span><span>10+</span></span><span class="kaios yes"><span>KaiOS Browser</span><span>2.5+</span></span><span class="opera yes"><span>Opera</span><span>10.6+</span></span><span class="op_mini yes"><span>Opera Mini</span><span>All</span></span><span class="op_mob yes"><span>Opera Mobile</span><span>11+</span></span><span class="and_qq yes"><span>QQ Browser</span><span>1.2+</span></span><span class="safari yes"><span>Safari</span><span>4+</span></span><span class="samsung yes"><span>Samsung Internet</span><span>4+</span></span><span class="and_uc yes"><span>UC Browser for Android</span><span>12.12+</span></span><span class="ios_saf yes"><span>iOS Safari</span><span>4.0+</span></span></p>
   <p class="caniuse">Source: <a href="https://caniuse.com/#feat=getboundingclientrect">caniuse.com</a> as of 2020-04-13</p>
  </aside>
  <aside class="caniuse-status" data-deco data-dfn-id="dom-element-scrollintoview">
   <input class="caniuse-panel-btn" type="button" value="⋰">
   <p class="support"><b>Support:</b><span class="android partial"><span><span>Android Browser (limited)</span></span><span>2.3+</span></span><span class="baidu partial"><span><span>Baidu Browser (limited)</span></span><span>7.12+</span></span><span class="bb partial"><span><span>Blackberry Browser (limited)</span></span><span>7+</span></span><span class="chrome yes"><span>Chrome</span><span>61+</span></span><span class="and_chr yes"><span>Chrome for Android</span><span>80+</span></span><span class="edge yes"><span>Edge</span><span>79+</span></span><span class="firefox yes"><span>Firefox</span><span>36+</span></span><span class="and_ff yes"><span>Firefox for Android</span><span>68+</span></span><span class="ie partial"><span><span>IE (limited)</span></span><span>8+</span></span><span class="ie_mob partial"><span><span>IE Mobile (limited)</span></span><span>10+</span></span><span class="kaios yes"><span>KaiOS Browser</span><span>2.5+</span></span><span class="opera yes"><span>Opera</span><span>48+</span></span><span class="op_mini no"><span>Opera Mini</span><span>None</span></span><span class="op_mob partial"><span><span>Opera Mobile (limited)</span></span><span>10+</span></span><span class="and_qq partial"><span><span>QQ Browser (limited)</span></span><span>1.2+</span></span><span class="safari partial"><span><span>Safari (limited)</span></span><span>5.1+</span></span><span class="samsung partial"><span><span>Samsung Internet (limited)</span></span><span>4+</span></span><span class="and_uc partial"><span><span>UC Browser for Android (limited)</span></span><span>12.12+</span></span><span class="ios_saf partial"><span><span>iOS Safari (limited)</span></span><span>5.0+</span></span></p>
   <p class="caniuse">Source: <a href="https://caniuse.com/#feat=scrollintoview">caniuse.com</a> as of 2020-04-13</p>
  </aside>
  <aside class="caniuse-status" data-deco data-dfn-id="smooth-scrolling">
   <input class="caniuse-panel-btn" type="button" value="⋰">
   <p class="support"><b>Support:</b><span class="android yes"><span>Android Browser</span><span>80+</span></span><span class="baidu no"><span>Baidu Browser</span><span>None</span></span><span class="bb no"><span>Blackberry Browser</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>61+</span></span><span class="and_chr yes"><span>Chrome for Android</span><span>80+</span></span><span class="edge yes"><span>Edge</span><span>79+</span></span><span class="firefox yes"><span>Firefox</span><span>36+</span></span><span class="and_ff yes"><span>Firefox for Android</span><span>68+</span></span><span class="ie no"><span>IE</span><span>None</span></span><span class="ie_mob no"><span>IE Mobile</span><span>None</span></span><span class="kaios no"><span>KaiOS Browser</span><span>None</span></span><span class="opera yes"><span>Opera</span><span>48+</span></span><span class="op_mini no"><span>Opera Mini</span><span>None</span></span><span class="op_mob no"><span>Opera Mobile</span><span>None</span></span><span class="and_qq no"><span>QQ Browser</span><span>None</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="samsung yes"><span>Samsung Internet</span><span>8.2+</span></span><span class="and_uc yes"><span>UC Browser for Android</span><span>12.12+</span></span><span class="ios_saf no"><span>iOS Safari</span><span>None</span></span></p>
   <p class="caniuse">Source: <a href="https://caniuse.com/#feat=css-scroll-behavior">caniuse.com</a> as of 2020-04-13</p>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="caret-position">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/CaretPosition" title="The CaretPosition interface represents the caret position, an indicator for the text insertion point. You can get a CaretPosition using the document.caretPositionFromPoint method.">CaretPosition</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>20+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>20+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-document-scrollingelement">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Document/scrollingElement" title="The scrollingElement read-only property of the Document interface returns a reference to the Element that scrolls the document. In standards mode, this is the root element of the document, document.documentElement.">Document/scrollingElement</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>48+</span></span><span class="safari yes"><span>Safari</span><span>9+</span></span><span class="chrome yes"><span>Chrome</span><span>44+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>31+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>9+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>44+</span></span><span class="webview_android yes"><span>Android WebView</span><span>44+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>32+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="extensions-to-the-document-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Document" title="The Document interface represents any web page loaded in the browser and serves as an entry point into the web page&apos;s content, which is the DOM tree.">Document</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>3+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>4+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-document-caretpositionfrompoint">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/DocumentOrShadowRoot/caretPositionFromPoint" title="The caretPositionFromPoint() property of the DocumentOrShadowRoot interface returns a CaretPosition object, containing the DOM node, along with the caret and caret&apos;s character offset within that node.">DocumentOrShadowRoot/caretPositionFromPoint</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>20+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome no"><span>Chrome</span><span>None</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>None</span></span><span class="edge_blink no"><span>Edge</span><span>None</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>20+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>None</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>None</span></span><span class="opera_android no"><span>Opera Mobile</span><span>None</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-document-elementsfrompoint">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/DocumentOrShadowRoot/elementsFromPoint" title="The elementsFromPoint() property of the DocumentOrShadowRoot interface returns an array of all elements at the specified coordinates (relative to the viewport).">DocumentOrShadowRoot/elementsFromPoint</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>63+</span></span><span class="safari yes"><span>Safari</span><span>12+</span></span><span class="chrome yes"><span>Chrome</span><span>53+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>40+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>63+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>12+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>53+</span></span><span class="webview_android yes"><span>Android WebView</span><span>53+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>6.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>41+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-element-clientheight">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Element/clientHeight" title="The Element.clientHeight read-only property is zero for elements with no CSS or inline layout boxes; otherwise, it&apos;s the inner height of an element in pixels. It includes padding but excludes borders, margins, and horizontal scrollbars (if present).">Element/clientHeight</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>8+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>6+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>6+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-element-clientleft">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Element/clientLeft" title="The width of the left border of an element in pixels. It includes the width of the vertical scrollbar if the text direction of the element is right–to–left and if there is an overflow causing a left vertical scrollbar to be rendered. clientLeft does not include the left margin or the left padding. clientLeft is read-only.">Element/clientLeft</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-element-clienttop">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Element/clientTop" title="The width of the top border of an element in pixels. It is a read-only, integer property of element.">Element/clientTop</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-element-clientwidth">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Element/clientWidth" title="The Element.clientWidth property is zero for inline elements and elements with no CSS; otherwise, it&apos;s the inner width of an element in pixels. It includes padding but excludes borders, margins, and vertical scrollbars (if present).">Element/clientWidth</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>8+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>6+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>6+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-element-getboundingclientrect">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Element/getBoundingClientRect" title="The Element.getBoundingClientRect() method returns the size of an element and its position relative to the viewport.">Element/getBoundingClientRect</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>3+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>2+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>9.5+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>4+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>4+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-element-getclientrects">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Element/getClientRects" title="The getClientRects() method of the Element interface returns a collection of DOMRect objects that indicate the bounding rectangles for each CSS border box in a client.">Element/getClientRects</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>3+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>2+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>9.5+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>8+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>6+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-element-scroll-options-options">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Element/scroll" title="The scroll() method of the Element interface scrolls the element to a particular set of coordinates inside a given element.">Element/scroll</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>36+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>32+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>36+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>32+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-element-scrollby-options-options">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Element/scrollBy" title="The scrollBy() method of the Element interface scrolls an element by the given amount.">Element/scrollBy</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>32+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>32+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-element-scrollheight">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Element/scrollHeight" title="The Element.scrollHeight read-only property is a measurement of the height of an element&apos;s content, including content not visible on the screen due to overflow.">Element/scrollHeight</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>21+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>4+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>8+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>5+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>21+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>6+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-element-scrollintoview">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Element/scrollIntoView" title="The Element interface&apos;s scrollIntoView() method scrolls the element&apos;s parent container such that the element on which scrollIntoView() is called is visible to the user">Element/scrollIntoView</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>29+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>38+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie yes"><span>IE</span><span>8+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>5+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>29+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>2.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>41+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-element-scrollleft">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Element/scrollLeft" title="The Element.scrollLeft property gets or sets the number of pixels that an element&apos;s content is scrolled from its left edge.">Element/scrollLeft</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>8+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>8+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>6+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-element-scrollto-options-options">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Element/scrollTo" title="The scrollTo() method of the Element interface scrolls to a particular set of coordinates inside a given element.">Element/scrollTo</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>36+</span></span><span class="safari yes"><span>Safari</span><span>10+</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>32+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>36+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>32+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-element-scrolltop">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Element/scrollTop" title="The Element.scrollTop property gets or sets the number of pixels that an element&apos;s content is scrolled vertically.">Element/scrollTop</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>8+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>8+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>6+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>43+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-element-scrollwidth">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Element/scrollWidth" title="The Element.scrollWidth read-only property is a measurement of the width of an element&apos;s content, including content not visible on the screen due to overflow.">Element/scrollWidth</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>43+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>5+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>43+</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="extension-to-the-element-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Element" title="Element is the most general base class from which all element objects (i.e. objects that represent elements) in a Document inherit. It only has methods and properties common to all kinds of elements. More specific classes inherit from Element.">Element</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>8+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>4+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-geometryutils-interface">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/GeometryUtils" title="The GeometryUtils interface provides different utility function to retrieve geometry information about DOM nodes.">GeometryUtils</a></p>
    <p class="less-than-two-engines-text">In no current engines.</p>
    <div class="support">
     <span class="firefox no"><span>Firefox</span><span>None</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome no"><span>Chrome</span><span>?</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink no"><span>Edge</span><span>?</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>?</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>None</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>?</span></span><span class="webview_android no"><span>Android WebView</span><span>?</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>?</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-htmlelement-offsetheight">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLElement/offsetHeight" title="The HTMLElement.offsetHeight read-only property returns the height of an element, including vertical padding and borders, as an integer.">HTMLElement/offsetHeight</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>8+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>8+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-htmlelement-offsetleft">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLElement/offsetLeft" title="The HTMLElement.offsetLeft read-only property returns the number of pixels that the upper left corner of the current element is offset to the left within the HTMLElement.offsetParent node.">HTMLElement/offsetLeft</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>8+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>8+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-htmlelement-offsetparent">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLElement/offsetParent" title="The HTMLElement.offsetParent read-only property returns a reference to the element which is the closest (nearest in the containment hierarchy) positioned ancestor element. If there is no positioned ancestor element, the nearest ancestor td, th, table will be returned, or the body if there are no ancestor table elements either.">HTMLElement/offsetParent</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>8+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>8+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-htmlelement-offsettop">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLElement/offsetTop" title="The HTMLElement.offsetTop read-only property returns the distance of the current element relative to the top of the offsetParent node.">HTMLElement/offsetTop</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>8+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>8+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-htmlelement-offsetwidth">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLElement/offsetWidth" title="The HTMLElement.offsetWidth read-only property returns the layout width of an element as an integer.">HTMLElement/offsetWidth</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>8+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>8+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="extensions-to-the-htmlelement-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLElement" title="The HTMLElement interface represents any HTML element. Some elements directly implement this interface, while others implement it via an interface that inherits it.">HTMLElement</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>8+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>8+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-htmlimageelement-x">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLImageElement/x" title="The read-only HTMLImageElement property x indicates the x-coordinate of the  <img> element&apos;s left border edge relative to the root element&apos;s origin.">HTMLImageElement/x</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>14+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>14+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-htmlimageelement-y">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLImageElement/y" title="The read-only HTMLImageElement property y indicates the y-coordinate of the <img> element&apos;s top border edge relative to the root element&apos;s origin.">HTMLImageElement/y</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>14+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>14+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="extensions-to-the-htmlimageelement-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/HTMLImageElement" title="The HTMLImageElement interface represents an HTML <img> element, providing the properties and methods used to manipulate image elements.">HTMLImageElement</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>8+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>8+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mediaquerylist-addlistener">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MediaQueryList/addListener" title="The addListener() method of the MediaQueryList interface adds a listener to the MediaQueryListener that will run a custom callback function in response to the media query status changing.">MediaQueryList/addListener</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>6+</span></span><span class="safari yes"><span>Safari</span><span>5.1+</span></span><span class="chrome yes"><span>Chrome</span><span>9+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>5+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mediaquerylist-matches">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MediaQueryList/matches" title="The matches read-only property of the MediaQueryList interface is a Boolean that returns true if the document currently matches the media query list, or false if not.">MediaQueryList/matches</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>6+</span></span><span class="safari yes"><span>Safari</span><span>5.1+</span></span><span class="chrome yes"><span>Chrome</span><span>9+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>5+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mediaquerylist-media">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MediaQueryList/media" title="The media read-only property of the MediaQueryList interface is a DOMString representing a serialized media query.">MediaQueryList/media</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>6+</span></span><span class="safari yes"><span>Safari</span><span>5.1+</span></span><span class="chrome yes"><span>Chrome</span><span>9+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>5+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mediaquerylist-onchange">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MediaQueryList/onchange" title="The onchange property of the MediaQueryList interface is an event handler property representing a function that is invoked when the change event fires, i.e when the status of media query support changes. The event object is a MediaQueryListEvent instance, which is recognised as a MediaListQuery instance in older browsers, for backwards compatibility purposes.">MediaQueryList/onchange</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>55+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>55+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mediaquerylist-removelistener">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MediaQueryList/removeListener" title="The removeListener() method of the MediaQueryList interface removes a listener from the MediaQueryListener.">MediaQueryList/removeListener</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>6+</span></span><span class="safari yes"><span>Safari</span><span>5.1+</span></span><span class="chrome yes"><span>Chrome</span><span>9+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>5+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-mediaquerylist-interface">
   <button class="mdn-anno-btn"><b class="less-than-two-engines-flag" title="This feature is in less than two current engines.">⚠</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MediaQueryList" title="A MediaQueryList object stores information on a media query applied to a document, with support for both immediate and event-driven matching against the state of the document.">MediaQueryList</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>6+</span></span><span class="safari yes"><span>Safari</span><span>5.1+</span></span><span class="chrome yes"><span>Chrome</span><span>9+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>5+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MediaQueryListListener" title="A MediaQueryList object maintains a list of media queries on a Document, and handles sending notifications to listeners when the media queries on the document change.">MediaQueryListListener</a></p>
    <p class="less-than-two-engines-text">In only one current engine.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>6+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome no"><span>Chrome</span><span>?</span></span>
     <hr>
     <span class="opera no"><span>Opera</span><span>?</span></span><span class="edge_blink no"><span>Edge</span><span>?</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android no"><span>Firefox for Android</span><span>?</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android no"><span>Chrome for Android</span><span>?</span></span><span class="webview_android no"><span>Android WebView</span><span>?</span></span><span class="samsunginternet_android no"><span>Samsung Internet</span><span>?</span></span><span class="opera_android no"><span>Opera Mobile</span><span>?</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mediaquerylistevent-mediaquerylistevent">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MediaQueryListEvent/MediaQueryListEvent" title="The MediaQueryListEvent constructor creates a new MediaQueryListEvent instance.">MediaQueryListEvent/MediaQueryListEvent</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>55+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>55+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mediaquerylistevent-matches">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MediaQueryListEvent/matches" title="The matches read-only property of the MediaQueryListEvent interface is a Boolean that returns true if the document currently matches the media query list, or false if not.">MediaQueryListEvent/matches</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>55+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>55+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mediaquerylistevent-media">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MediaQueryListEvent/media" title="The media read-only property of the MediaQueryListEvent interface is a DOMString representing a serialized media query.">MediaQueryListEvent/media</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>55+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>55+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="mediaquerylistevent">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MediaQueryListEvent" title="The MediaQueryListEvent object stores information on the changes that have happened to a MediaQueryList object — instances are available as the event object on a function referenced by a MediaQueryList.onchange property or MediaQueryList.addListener() call.">MediaQueryListEvent</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>55+</span></span><span class="safari no"><span>Safari</span><span>?</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>55+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>?</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android no"><span>Android WebView</span><span>None</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="extensions-to-the-mouseevent-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MouseEvent/MouseEvent" title="The MouseEvent() constructor creates a new MouseEvent.">MouseEvent/MouseEvent</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>11+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>47+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>14+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>47+</span></span><span class="webview_android yes"><span>Android WebView</span><span>47+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MouseEvent" title="The MouseEvent interface represents events that occur due to the user interacting with a pointing device (such as a mouse). Common events using this interface include click, dblclick, mouseup, mousedown.">MouseEvent</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>10.6+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>2+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>11+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MouseEvent" title="The MouseEvent interface represents events that occur due to the user interacting with a pointing device (such as a mouse). Common events using this interface include click, dblclick, mouseup, mousedown.">MouseEvent</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>10.6+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>2+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>11+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/PointerEvent/pointerType" title="The pointerType read-only property of the PointerEvent interface indicates the device type (mouse, pen, or touch) that caused a given pointer event.">PointerEvent/pointerType</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>59+</span></span><span class="safari yes"><span>Safari</span><span>13+</span></span><span class="chrome yes"><span>Chrome</span><span>55+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>42+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>11</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span title="Requires setting a user preference or runtime flag.">🔰 41+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>13+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>55+</span></span><span class="webview_android yes"><span>Android WebView</span><span>55+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>6.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>42+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mouseevent-clientx">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MouseEvent/clientX" title="The clientX read-only property of the MouseEvent interface provides the horizontal coordinate within the application&apos;s client area at which the event occurred (as opposed to the coordinate within the page).">MouseEvent/clientX</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3.1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>10.6+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>2+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>11+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mouseevent-clienty">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MouseEvent/clientY" title="The clientY read-only property of the MouseEvent interface provides the vertical coordinate within the application&apos;s client area at which the event occurred (as opposed to the coordinate within the page).">MouseEvent/clientY</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mouseevent-offsetx">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MouseEvent/offsetX" title="The offsetX read-only property of the MouseEvent interface provides the offset in the X coordinate of the mouse pointer between that event and the padding edge of the target node.">MouseEvent/offsetX</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>39+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>43+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mouseevent-offsety">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MouseEvent/offsetY" title="The offsetY read-only property of the MouseEvent interface provides the offset in the Y coordinate of the mouse pointer between that event and the padding edge of the target node.">MouseEvent/offsetY</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>39+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>43+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mouseevent-pagex">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MouseEvent/pageX" title="The pageX read-only property of the MouseEvent interface returns the X (horizontal) coordinate (in pixels) at which the mouse was clicked, relative to the left edge of the entire document.">MouseEvent/pageX</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mouseevent-pagey">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MouseEvent/pageY" title="The pageY read-only property of the MouseEvent interface returns the Y (vertical) coordinate in pixels of the event relative to the whole document. This property takes into account any vertical scrolling of the page.">MouseEvent/pageY</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mouseevent-screenx">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MouseEvent/screenX" title="The screenX read-only property of the MouseEvent interface provides the horizontal coordinate (offset) of the mouse pointer in global (screen) coordinates.">MouseEvent/screenX</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mouseevent-screeny">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MouseEvent/screenY" title="The screenY read-only property of the MouseEvent interface provides the vertical coordinate (offset) of the mouse pointer in global (screen) coordinates.">MouseEvent/screenY</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mouseevent-x">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MouseEvent/x" title="The MouseEvent.x property is an alias for the MouseEvent.clientX property.">MouseEvent/x</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>53+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>53+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-mouseevent-y">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/MouseEvent/y" title="The MouseEvent.y property is an alias for the MouseEvent.clientY property.">MouseEvent/y</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>53+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>53+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-range-getboundingclientrect">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Range/getBoundingClientRect" title="The Range.getBoundingClientRect() method returns a DOMRect object that bounds the contents of the range; this is a rectangle enclosing the union of the bounding rectangles for all the elements in the range.">Range/getBoundingClientRect</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>4+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>15+</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>14+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-range-getclientrects">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Range/getClientRects" title="The Range.getClientRects() method returns a list of DOMRect objects representing the area of the screen occupied by the range. This is created by aggregating the results of calls to Element.getClientRects() for all the elements in the range.">Range/getClientRects</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>4+</span></span><span class="safari yes"><span>Safari</span><span>5+</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>15+</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>14+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="extensions-to-the-range-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Range" title="The Range interface represents a fragment of a document that can contain nodes and parts of text nodes.">Range</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>4+</span></span><span class="safari yes"><span>Safari</span><span>1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-screen-availheight">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Screen/availHeight" title="The read-only Screen interface&apos;s availHeight property returns the height, in CSS pixels, of the space available for Web content on the screen. Since Screen is exposed on the Window interface&apos;s window.screen property, you access availHeight using window.screen.availHeight.">Screen/availHeight</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>40+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>40+</span></span><span class="webview_android yes"><span>Android WebView</span><span>40+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-screen-availwidth">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Screen/availWidth" title="The Screen.availWidth property returns the amount of horizontal space (in pixels) available to the window.">Screen/availWidth</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-screen-colordepth">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Screen/colorDepth" title="The Screen.colorDepth read-only property returns the color depth of the screen. Per the CSSOM, some implementations return 24 for compatibility reasons. See the browser compatibility section for those that don&apos;t.">Screen/colorDepth</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>40+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>40+</span></span><span class="webview_android yes"><span>Android WebView</span><span>40+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-screen-height">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Screen/height" title="The Screen.height read-only property returns the height of the screen in pixels.">Screen/height</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-screen-pixeldepth">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Screen/pixelDepth" title="Returns the bit depth of the screen. Per the CSSOM, some implementations return 24 for compatibility reasons. See the browser compatibility section for those that don&apos;t.">Screen/pixelDepth</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>40+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-screen-width">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Screen/width" title="Returns the width of the screen.">Screen/width</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>6+</span></span><span class="chrome yes"><span>Chrome</span><span>40+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>40+</span></span><span class="webview_android yes"><span>Android WebView</span><span>40+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>4.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-screen-interface">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Screen" title="The Screen interface represents a screen, usually the one on which the current window is being rendered, and is obtained using window.screen.">Screen</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>Yes</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dictdef-scrolloptions">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/ScrollToOptions/behavior" title="An enum, the value of which can be one of the following:">ScrollToOptions/behavior</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>32+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>32+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-scrolltooptions-left">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/ScrollToOptions/left" title="A double.">ScrollToOptions/left</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>32+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>32+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-scrolltooptions-top">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/ScrollToOptions/top" title="A double.">ScrollToOptions/top</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>32+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>32+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dictdef-scrolltooptions">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/ScrollToOptions" title="The ScrollToOptions dictionary of the CSSOM View spec contains properties specifying where an element should be scrolled to, and whether the scrolling should be smooth.">ScrollToOptions</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>45+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>32+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>45+</span></span><span class="webview_android yes"><span>Android WebView</span><span>45+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>5.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>32+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-devicepixelratio">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/devicePixelRatio" title="The devicePixelRatio of Window interface returns the ratio of the resolution in physical pixels to the resolution in CSS pixels for the current display device.">Window/devicePixelRatio</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>18+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>11.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>11</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>18+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>11.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-innerheight">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/innerHeight" title="The read-only innerHeight property of the Window interface returns the interior height of the window in pixels, including the height of the horizontal scroll bar, if present.">Window/innerHeight</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-innerwidth">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/innerWidth" title="The read-only Window property innerWidth returns the interior width of the window in pixels. This includes the width of the vertical scroll bar, if one is present.">Window/innerWidth</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-matchmedia">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/matchMedia" title="The Window interface&apos;s matchMedia() method returns a new MediaQueryList object representing the parsed results of the specified media query string. The returned MediaQueryList can then be used to determine if the Document matches the media query, or to monitor a document to detect when it matches or stops matching the media query.">Window/matchMedia</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>6+</span></span><span class="safari yes"><span>Safari</span><span>5.1+</span></span><span class="chrome yes"><span>Chrome</span><span>9+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>12.1+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>10+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>6+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>5+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>37+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>12.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-moveby">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/moveBy" title="The moveBy() method of the Window interface moves the current window by a specified amount.">Window/moveBy</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-moveto">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/moveTo" title="The moveTo() method of the Window interface moves the current window to the specified coordinates.">Window/moveTo</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="the-features-argument-to-the-open()-method">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/open" title="The Window interface&apos;s open() method loads the specified resource into the new or existing browsing context (window, <iframe> or tab) with the specified name. If the name doesn&apos;t exist, then a new browsing context is opened in a new tab or a new window, and the specified resource is loaded into it.">Window/open</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>3+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>4+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-outerheight">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/outerHeight" title="The Window.outerHeight read-only property returns the height in pixels of the whole browser window, including any sidebar, window chrome, and window-resizing borders/handles.">Window/outerHeight</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>3+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-outerwidth">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/outerWidth" title="Window.outerWidth read-only property returns the width of the outside of the browser window. It represents the width of the whole browser window including sidebar (if expanded), window chrome and window resizing borders/handles.">Window/outerWidth</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>3+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>9+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>3+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-pagexoffset">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/pageXOffset" title="The read-only Window property pageXOffset is an alias for scrollX.">Window/pageXOffset</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-pageyoffset">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/pageYOffset" title="The read-only Window property pageYOffset is an alias for scrollY; as such, it returns the number of pixels the document is currently scrolled along the vertical axis (that is, up or down) with a value of 0.0, indicating that the top edge of the Document is currently aligned with the top edge of the window&apos;s content area.">Window/pageYOffset</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>3+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>9+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="resizing-viewports">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/resize_event" title="The resize event fires when the document view (window) has been resized.">Window/resize_event</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1.1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>7+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>4+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-resizeby">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/resizeBy" title="The Window.resizeBy() method resizes the current window by a specified amount.">Window/resizeBy</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-resizeto">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/resizeTo" title="The Window.resizeTo() method dynamically resizes the window.">Window/resizeTo</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-screen">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/screen" title="The Window property screen returns a reference to the screen object associated with the window. The screen object, implementing the Screen interface, is a special object for inspecting properties of the screen on which the current window is being rendered.">Window/screen</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie no"><span>IE</span><span>?</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-screenx">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/screenLeft" title="The Window.screenLeft read-only property returns the horizontal distance, in CSS pixels, from the left border of the user&apos;s browser viewport to the left side of the screen.">Window/screenLeft</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>64+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>Yes</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>64+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/screenX" title="The Window.screenX read-only property returns the horizontal distance, in CSS pixels, of the left border of the user&apos;s browser viewport to the left side of the screen.">Window/screenX</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>Yes</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-screeny">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/screenTop" title="The Window.screenTop read-only property returns the vertical distance, in CSS pixels, from the top border of the user&apos;s browser viewport to the top side of the screen.">Window/screenTop</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>64+</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>Yes</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>64+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/screenY" title="The Window.screenY read-only property returns the vertical distance, in CSS pixels, of the top border of the user&apos;s browser viewport to the top edge of the screen.">Window/screenY</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>Yes</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-scroll">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/scroll" title="The Window.scroll() method scrolls the window to a particular place in the document.">Window/scroll</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>3+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>4+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/scrollTo" title="Window.scrollTo() scrolls to a particular set of coordinates in the document.">Window/scrollTo</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>4+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>12+</span></span><span class="ie yes"><span>IE</span><span>4+</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-scrollby">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/scrollBy" title="The Window.scrollBy() method scrolls the document in the window by the given amount.">Window/scrollBy</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>3+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-scrollx">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/scrollX" title="The read-only scrollX property of the Window interface returns the number of pixels that the document is currently scrolled horizontally. This value is subpixel precise in modern browsers, meaning that it isn&apos;t necessarily a whole number. You can get the number of pixels the document is scrolled vertically from the scrollY property.">Window/scrollX</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>Yes</span></span><span class="safari yes"><span>Safari</span><span>Yes</span></span><span class="chrome yes"><span>Chrome</span><span>Yes</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>Yes</span></span><span class="edge_blink yes"><span>Edge</span><span>Yes</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>Yes</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>Yes</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>Yes</span></span><span class="webview_android yes"><span>Android WebView</span><span>Yes</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>Yes</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>Yes</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="dom-window-scrolly">
   <button class="mdn-anno-btn"><b class="all-engines-flag" title="This feature is in all current engines.">✔</b><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/API/Window/scrollY" title="The read-only scrollY property of the Window interface returns the number of pixels that the document is currently scrolled vertically.">Window/scrollY</a></p>
    <p class="all-engines-text">In all current engines.</p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>1+</span></span><span class="safari yes"><span>Safari</span><span>1+</span></span><span class="chrome yes"><span>Chrome</span><span>1+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>9.6+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge yes"><span>Edge (Legacy)</span><span>18</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>4+</span></span><span class="safari_ios yes"><span>iOS Safari</span><span>1+</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>18+</span></span><span class="webview_android yes"><span>Android WebView</span><span>1+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>1.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>10.1+</span></span>
    </div>
   </div>
  </aside>
  <aside class="mdn-anno wrapped" data-deco data-mdn-for="propdef-scroll-behavior">
   <button class="mdn-anno-btn"><span>MDN</span></button>
   <div class="feature">
    <p><a href="https://developer.mozilla.org/en-US/docs/Web/CSS/scroll-behavior" title="The scroll-behavior CSS property sets the behavior for a scrolling box when scrolling is triggered by the navigation or CSSOM scrolling APIs.">scroll-behavior</a></p>
    <div class="support">
     <span class="firefox yes"><span>Firefox</span><span>36+</span></span><span class="safari no"><span>Safari</span><span>None</span></span><span class="chrome yes"><span>Chrome</span><span>61+</span></span>
     <hr>
     <span class="opera yes"><span>Opera</span><span>48+</span></span><span class="edge_blink yes"><span>Edge</span><span>79+</span></span>
     <hr>
     <span class="edge no"><span>Edge (Legacy)</span><span>None</span></span><span class="ie no"><span>IE</span><span>None</span></span>
     <hr>
     <span class="firefox_android yes"><span>Firefox for Android</span><span>36+</span></span><span class="safari_ios no"><span>iOS Safari</span><span>None</span></span><span class="chrome_android yes"><span>Chrome for Android</span><span>61+</span></span><span class="webview_android yes"><span>Android WebView</span><span>61+</span></span><span class="samsunginternet_android yes"><span>Samsung Internet</span><span>8.0+</span></span><span class="opera_android yes"><span>Opera Mobile</span><span>45+</span></span>
    </div>
   </div>
  </aside>
  <h2 class="no-num no-ref heading settled" id="index"><span class="content">Index</span><a class="self-link" href="#index"></a></h2>
  <h3 class="no-num no-ref heading settled" id="index-defined-here"><span class="content">Terms defined by this specification</span><a class="self-link" href="#index-defined-here"></a></h3>
  <ul class="index">
   <li><a href="#dom-mediaquerylist-addlistener">addListener(callback)</a><span>, in §4.2</span>
   <li><a href="#allowed-to-resize-and-move">allowed to resize and move</a><span>, in §4</span>
   <li><a href="#dom-scrollbehavior-auto">"auto"</a><span>, in §4</span>
   <li><a href="#valdef-scroll-behavior-auto">auto</a><span>, in §13.1</span>
   <li><a href="#dom-screen-availheight">availHeight</a><span>, in §4.3</span>
   <li><a href="#dom-screen-availwidth">availWidth</a><span>, in §4.3</span>
   <li><a href="#beginning-edges">beginning edges</a><span>, in §2</span>
   <li><a href="#dom-scrolloptions-behavior">behavior</a><span>, in §4</span>
   <li><a href="#dom-scrollintoviewoptions-block">block</a><span>, in §6</span>
   <li><a href="#dom-cssboxtype-border">"border"</a><span>, in §11.1</span>
   <li><a href="#border-edge">border edge</a><span>, in §2</span>
   <li><a href="#dom-boxquadoptions-box">box</a><span>, in §11.1</span>
   <li><a href="#dictdef-boxquadoptions">BoxQuadOptions</a><span>, in §11.1</span>
   <li><a href="#caret-node">caret node</a><span>, in §5.1</span>
   <li><a href="#caret-offset">caret offset</a><span>, in §5.1</span>
   <li><a href="#caret-position">caret position</a><span>, in §5.1</span>
   <li><a href="#caretposition">CaretPosition</a><span>, in §5.1</span>
   <li><a href="#dom-document-caretpositionfrompoint">caretPositionFromPoint(x, y)</a><span>, in §5</span>
   <li><a href="#caret-range">caret range</a><span>, in §5.1</span>
   <li><a href="#dom-scrolllogicalposition-center">"center"</a><span>, in §6</span>
   <li><a href="#eventdef-mediaquerylist-change">change</a><span>, in §4.2.1</span>
   <li><a href="#dom-element-clientheight">clientHeight</a><span>, in §6</span>
   <li><a href="#dom-element-clientleft">clientLeft</a><span>, in §6</span>
   <li><a href="#dom-element-clienttop">clientTop</a><span>, in §6</span>
   <li><a href="#dom-element-clientwidth">clientWidth</a><span>, in §6</span>
   <li>
    clientX
    <ul>
     <li><a href="#dom-mouseevent-clientx">attribute for MouseEvent</a><span>, in §10</span>
     <li><a href="#dom-mouseeventinit-clientx">dict-member for MouseEventInit</a><span>, in §10</span>
    </ul>
   <li>
    clientY
    <ul>
     <li><a href="#dom-mouseevent-clienty">attribute for MouseEvent</a><span>, in §10</span>
     <li><a href="#dom-mouseeventinit-clienty">dict-member for MouseEventInit</a><span>, in §10</span>
    </ul>
   <li><a href="#dom-screen-colordepth">colorDepth</a><span>, in §4.3</span>
   <li><a href="#dom-mediaquerylistevent-mediaquerylistevent">constructor(type)</a><span>, in §4.2</span>
   <li><a href="#dom-mediaquerylistevent-mediaquerylistevent">constructor(type, eventInitDict)</a><span>, in §4.2</span>
   <li><a href="#dom-cssboxtype-content">"content"</a><span>, in §11.1</span>
   <li><a href="#content-edge">Content edge</a><span>, in §2</span>
   <li><a href="#dictdef-convertcoordinateoptions">ConvertCoordinateOptions</a><span>, in §11.1</span>
   <li><a href="#dom-geometryutils-convertpointfromnode">convertPointFromNode(point, from)</a><span>, in §11.1</span>
   <li><a href="#dom-geometryutils-convertpointfromnode">convertPointFromNode(point, from, options)</a><span>, in §11.1</span>
   <li><a href="#dom-geometryutils-convertquadfromnode">convertQuadFromNode(quad, from)</a><span>, in §11.1</span>
   <li><a href="#dom-geometryutils-convertquadfromnode">convertQuadFromNode(quad, from, options)</a><span>, in §11.1</span>
   <li><a href="#dom-geometryutils-convertrectfromnode">convertRectFromNode(rect, from)</a><span>, in §11.1</span>
   <li><a href="#dom-geometryutils-convertrectfromnode">convertRectFromNode(rect, from, options)</a><span>, in §11.1</span>
   <li><a href="#enumdef-cssboxtype">CSSBoxType</a><span>, in §11.1</span>
   <li><a href="#css-layout-box">CSS layout box</a><span>, in §2</span>
   <li><a href="#determine-the-device-pixel-ratio">determine the device pixel ratio</a><span>, in §4</span>
   <li><a href="#dom-window-devicepixelratio">devicePixelRatio</a><span>, in §4</span>
   <li><a href="#mediaquerylist-document">document</a><span>, in §4.2</span>
   <li><a href="#dom-document-elementfrompoint">elementFromPoint(x, y)</a><span>, in §5</span>
   <li><a href="#dom-document-elementsfrompoint">elementsFromPoint(x, y)</a><span>, in §5</span>
   <li><a href="#dom-scrolllogicalposition-end">"end"</a><span>, in §6</span>
   <li><a href="#ending-edges">ending edges</a><span>, in §2</span>
   <li><a href="#evaluate-media-queries-and-report-changes">evaluate media queries and report changes</a><span>, in §4.2</span>
   <li><a href="#dom-convertcoordinateoptions-frombox">fromBox</a><span>, in §11.1</span>
   <li><a href="#typedefdef-geometrynode">GeometryNode</a><span>, in §11.1</span>
   <li><a href="#geometryutils">GeometryUtils</a><span>, in §11.1</span>
   <li>
    getBoundingClientRect()
    <ul>
     <li><a href="#dom-element-getboundingclientrect">method for Element</a><span>, in §6</span>
     <li><a href="#dom-range-getboundingclientrect">method for Range</a><span>, in §9</span>
    </ul>
   <li><a href="#dom-geometryutils-getboxquads">getBoxQuads()</a><span>, in §11.1</span>
   <li><a href="#dom-geometryutils-getboxquads">getBoxQuads(options)</a><span>, in §11.1</span>
   <li><a href="#dom-caretposition-getclientrect">getClientRect()</a><span>, in §5.1</span>
   <li>
    getClientRects()
    <ul>
     <li><a href="#dom-element-getclientrects">method for Element</a><span>, in §6</span>
     <li><a href="#dom-range-getclientrects">method for Range</a><span>, in §9</span>
    </ul>
   <li>
    height
    <ul>
     <li><a href="#dom-screen-height">attribute for Screen</a><span>, in §4.3</span>
     <li><a href="#supported-open-feature-name-height">dfn for supported open() feature name</a><span>, in §4.1</span>
    </ul>
   <li><a href="#dom-scrollintoviewoptions-inline">inline</a><span>, in §6</span>
   <li><a href="#dom-window-innerheight">innerHeight</a><span>, in §4</span>
   <li><a href="#dom-window-innerwidth">innerWidth</a><span>, in §4</span>
   <li><a href="#concept-instant-scroll">instant scroll</a><span>, in §3.1</span>
   <li><a href="#layout-box">layout box</a><span>, in §2</span>
   <li>
    left
    <ul>
     <li><a href="#supported-open-feature-name-left">dfn for supported open() feature name</a><span>, in §4.1</span>
     <li><a href="#dom-scrolltooptions-left">dict-member for ScrollToOptions</a><span>, in §4</span>
    </ul>
   <li><a href="#dom-cssboxtype-margin">"margin"</a><span>, in §11.1</span>
   <li><a href="#margin-edge">margin edge</a><span>, in §2</span>
   <li>
    matches
    <ul>
     <li><a href="#dom-mediaquerylist-matches">attribute for MediaQueryList</a><span>, in §4.2</span>
     <li><a href="#dom-mediaquerylistevent-matches">attribute for MediaQueryListEvent</a><span>, in §4.2</span>
     <li><a href="#dom-mediaquerylisteventinit-matches">dict-member for MediaQueryListEventInit</a><span>, in §4.2</span>
    </ul>
   <li><a href="#mediaquerylist-matches-state">matches state</a><span>, in §4.2</span>
   <li><a href="#dom-window-matchmedia">matchMedia(query)</a><span>, in §4</span>
   <li>
    media
    <ul>
     <li><a href="#dom-mediaquerylist-media">attribute for MediaQueryList</a><span>, in §4.2</span>
     <li><a href="#dom-mediaquerylistevent-media">attribute for MediaQueryListEvent</a><span>, in §4.2</span>
     <li><a href="#mediaquerylist-media">dfn for MediaQueryList</a><span>, in §4.2</span>
     <li><a href="#dom-mediaquerylisteventinit-media">dict-member for MediaQueryListEventInit</a><span>, in §4.2</span>
    </ul>
   <li><a href="#media-query-list">media query list</a><span>, in §4.2</span>
   <li><a href="#mediaquerylist">MediaQueryList</a><span>, in §4.2</span>
   <li><a href="#mediaquerylistevent">MediaQueryListEvent</a><span>, in §4.2</span>
   <li><a href="#dictdef-mediaquerylisteventinit">MediaQueryListEventInit</a><span>, in §4.2</span>
   <li><a href="#dom-mediaquerylistevent-mediaquerylistevent">MediaQueryListEvent(type)</a><span>, in §4.2</span>
   <li><a href="#dom-mediaquerylistevent-mediaquerylistevent">MediaQueryListEvent(type, eventInitDict)</a><span>, in §4.2</span>
   <li><a href="#dom-window-moveby">moveBy(x, y)</a><span>, in §4</span>
   <li><a href="#dom-window-moveto">moveTo(x, y)</a><span>, in §4</span>
   <li><a href="#dom-scrolllogicalposition-nearest">"nearest"</a><span>, in §6</span>
   <li><a href="#normalize-non-finite-values">normalize non-finite values</a><span>, in §3.2</span>
   <li><a href="#dom-caretposition-offset">offset</a><span>, in §5.1</span>
   <li><a href="#dom-htmlelement-offsetheight">offsetHeight</a><span>, in §7</span>
   <li><a href="#dom-htmlelement-offsetleft">offsetLeft</a><span>, in §7</span>
   <li><a href="#dom-caretposition-offsetnode">offsetNode</a><span>, in §5.1</span>
   <li><a href="#dom-htmlelement-offsetparent">offsetParent</a><span>, in §7</span>
   <li><a href="#dom-htmlelement-offsettop">offsetTop</a><span>, in §7</span>
   <li><a href="#dom-htmlelement-offsetwidth">offsetWidth</a><span>, in §7</span>
   <li><a href="#dom-mouseevent-offsetx">offsetX</a><span>, in §10</span>
   <li><a href="#dom-mouseevent-offsety">offsetY</a><span>, in §10</span>
   <li><a href="#dom-mediaquerylist-onchange">onchange</a><span>, in §4.2</span>
   <li><a href="#dom-window-outerheight">outerHeight</a><span>, in §4</span>
   <li><a href="#dom-window-outerwidth">outerWidth</a><span>, in §4</span>
   <li><a href="#overflow-directions">overflow directions</a><span>, in §2</span>
   <li><a href="#dom-cssboxtype-padding">"padding"</a><span>, in §11.1</span>
   <li><a href="#padding-edge">padding edge</a><span>, in §2</span>
   <li><a href="#dom-mouseevent-pagex">pageX</a><span>, in §10</span>
   <li><a href="#dom-window-pagexoffset">pageXOffset</a><span>, in §4</span>
   <li><a href="#dom-mouseevent-pagey">pageY</a><span>, in §10</span>
   <li><a href="#dom-window-pageyoffset">pageYOffset</a><span>, in §4</span>
   <li><a href="#page-zoom">page zoom</a><span>, in §2.2</span>
   <li><a href="#pending-scroll-event-targets">pending scroll event targets</a><span>, in §12.2</span>
   <li><a href="#perform-a-scroll">perform a scroll</a><span>, in §3.1</span>
   <li><a href="#pinch-zoom">pinch zoom</a><span>, in §2.2</span>
   <li><a href="#dom-screen-pixeldepth">pixelDepth</a><span>, in §4.3</span>
   <li><a href="#potentially-scrollable">potentially scrollable</a><span>, in §2</span>
   <li><a href="#dom-boxquadoptions-relativeto">relativeTo</a><span>, in §11.1</span>
   <li><a href="#dom-mediaquerylist-removelistener">removeListener(callback)</a><span>, in §4.2</span>
   <li><a href="#eventdef-window-resize">resize</a><span>, in §12.3</span>
   <li><a href="#dom-window-resizeby">resizeBy(x, y)</a><span>, in §4</span>
   <li><a href="#dom-window-resizeto">resizeTo(width, height)</a><span>, in §4</span>
   <li><a href="#run-the-resize-steps">run the resize steps</a><span>, in §12.1</span>
   <li><a href="#run-the-scroll-steps">run the scroll steps</a><span>, in §12.2</span>
   <li><a href="#screen">Screen</a><span>, in §4.3</span>
   <li><a href="#dom-window-screen">screen</a><span>, in §4</span>
   <li><a href="#dom-window-screenleft">screenLeft</a><span>, in §4</span>
   <li><a href="#dom-window-screentop">screenTop</a><span>, in §4</span>
   <li>
    screenX
    <ul>
     <li><a href="#dom-mouseevent-screenx">attribute for MouseEvent</a><span>, in §10</span>
     <li><a href="#dom-window-screenx">attribute for Window</a><span>, in §4</span>
     <li><a href="#dom-mouseeventinit-screenx">dict-member for MouseEventInit</a><span>, in §10</span>
    </ul>
   <li>
    screenY
    <ul>
     <li><a href="#dom-mouseevent-screeny">attribute for MouseEvent</a><span>, in §10</span>
     <li><a href="#dom-window-screeny">attribute for Window</a><span>, in §4</span>
     <li><a href="#dom-mouseeventinit-screeny">dict-member for MouseEventInit</a><span>, in §10</span>
    </ul>
   <li><a href="#eventdef-document-scroll">scroll</a><span>, in §12.3</span>
   <li>
    scroll()
    <ul>
     <li><a href="#dom-element-scroll">method for Element</a><span>, in §6</span>
     <li><a href="#dom-window-scroll">method for Window</a><span>, in §4</span>
    </ul>
   <li><a href="#scroll-an-element">scroll an element</a><span>, in §6.1</span>
   <li><a href="#scroll-an-element-into-view">scroll an element into view</a><span>, in §6.1</span>
   <li><a href="#propdef-scroll-behavior">scroll-behavior</a><span>, in §13.1</span>
   <li><a href="#enumdef-scrollbehavior">ScrollBehavior</a><span>, in §4</span>
   <li>
    scrollBy()
    <ul>
     <li><a href="#dom-element-scrollby">method for Element</a><span>, in §6</span>
     <li><a href="#dom-window-scrollby">method for Window</a><span>, in §4</span>
    </ul>
   <li>
    scrollBy(options)
    <ul>
     <li><a href="#dom-element-scrollby">method for Element</a><span>, in §6</span>
     <li><a href="#dom-window-scrollby">method for Window</a><span>, in §4</span>
    </ul>
   <li>
    scrollBy(x, y)
    <ul>
     <li><a href="#dom-element-scrollby">method for Element</a><span>, in §6</span>
     <li><a href="#dom-window-scrollby">method for Window</a><span>, in §4</span>
    </ul>
   <li><a href="#dom-element-scrollheight">scrollHeight</a><span>, in §6</span>
   <li><a href="#scrolling-area">scrolling area</a><span>, in §2</span>
   <li><a href="#scrolling-area-origin">scrolling area origin</a><span>, in §2</span>
   <li><a href="#scrolling-box">scrolling box</a><span>, in §2</span>
   <li><a href="#dom-document-scrollingelement">scrollingElement</a><span>, in §5</span>
   <li><a href="#dom-element-scrollintoview">scrollIntoView()</a><span>, in §6</span>
   <li><a href="#dom-element-scrollintoview">scrollIntoView(arg)</a><span>, in §6</span>
   <li><a href="#dictdef-scrollintoviewoptions">ScrollIntoViewOptions</a><span>, in §6</span>
   <li><a href="#dom-element-scrollleft">scrollLeft</a><span>, in §6</span>
   <li><a href="#enumdef-scrolllogicalposition">ScrollLogicalPosition</a><span>, in §6</span>
   <li>
    scroll(options)
    <ul>
     <li><a href="#dom-element-scroll">method for Element</a><span>, in §6</span>
     <li><a href="#dom-window-scroll">method for Window</a><span>, in §4</span>
    </ul>
   <li><a href="#dictdef-scrolloptions">ScrollOptions</a><span>, in §4</span>
   <li>
    scrollTo()
    <ul>
     <li><a href="#dom-element-scrollto">method for Element</a><span>, in §6</span>
     <li><a href="#dom-window-scrollto">method for Window</a><span>, in §4</span>
    </ul>
   <li>
    scrollTo(options)
    <ul>
     <li><a href="#dom-element-scrollto">method for Element</a><span>, in §6</span>
     <li><a href="#dom-window-scrollto">method for Window</a><span>, in §4</span>
    </ul>
   <li><a href="#dictdef-scrolltooptions">ScrollToOptions</a><span>, in §4</span>
   <li><a href="#dom-element-scrolltop">scrollTop</a><span>, in §6</span>
   <li><a href="#scroll-to-the-beginning-of-the-document">scroll to the beginning of the document</a><span>, in §3.1</span>
   <li>
    scrollTo(x, y)
    <ul>
     <li><a href="#dom-element-scrollto">method for Element</a><span>, in §6</span>
     <li><a href="#dom-window-scrollto">method for Window</a><span>, in §4</span>
    </ul>
   <li><a href="#dom-element-scrollwidth">scrollWidth</a><span>, in §6</span>
   <li><a href="#dom-window-scrollx">scrollX</a><span>, in §4</span>
   <li>
    scroll(x, y)
    <ul>
     <li><a href="#dom-element-scroll">method for Element</a><span>, in §6</span>
     <li><a href="#dom-window-scroll">method for Window</a><span>, in §4</span>
    </ul>
   <li><a href="#dom-window-scrolly">scrollY</a><span>, in §4</span>
   <li><a href="#set-up-browsing-context-features">set up browsing context features</a><span>, in §4.1</span>
   <li><a href="#dom-scrollbehavior-smooth">"smooth"</a><span>, in §4</span>
   <li><a href="#valdef-scroll-behavior-smooth">smooth</a><span>, in §13.1</span>
   <li><a href="#concept-smooth-scroll">smooth scroll</a><span>, in §3.1</span>
   <li><a href="#smooth-scroll-aborted">smooth scroll aborted</a><span>, in §3.1</span>
   <li><a href="#smooth-scroll-completed">smooth scroll completed</a><span>, in §3.1</span>
   <li><a href="#dom-scrolllogicalposition-start">"start"</a><span>, in §6</span>
   <li><a href="#supported-open-feature-name">supported open() feature name</a><span>, in §4.1</span>
   <li><a href="#svg-layout-box">SVG layout box</a><span>, in §2</span>
   <li><a href="#the-html-body-element">The HTML body element</a><span>, in §2</span>
   <li><a href="#dom-convertcoordinateoptions-tobox">toBox</a><span>, in §11.1</span>
   <li>
    top
    <ul>
     <li><a href="#supported-open-feature-name-top">dfn for supported open() feature name</a><span>, in §4.1</span>
     <li><a href="#dom-scrolltooptions-top">dict-member for ScrollToOptions</a><span>, in §4</span>
    </ul>
   <li><a href="#transforms">transforms</a><span>, in §2</span>
   <li><a href="#viewport">viewport</a><span>, in §2</span>
   <li><a href="#web-exposed-available-screen-area">Web-exposed available screen area</a><span>, in §2.3</span>
   <li><a href="#web-exposed-screen-area">Web-exposed screen area</a><span>, in §2.3</span>
   <li>
    width
    <ul>
     <li><a href="#dom-screen-width">attribute for Screen</a><span>, in §4.3</span>
     <li><a href="#supported-open-feature-name-width">dfn for supported open() feature name</a><span>, in §4.1</span>
    </ul>
   <li>
    x
    <ul>
     <li><a href="#dom-htmlimageelement-x">attribute for HTMLImageElement</a><span>, in §8</span>
     <li><a href="#dom-mouseevent-x">attribute for MouseEvent</a><span>, in §10</span>
    </ul>
   <li>
    y
    <ul>
     <li><a href="#dom-htmlimageelement-y">attribute for HTMLImageElement</a><span>, in §8</span>
     <li><a href="#dom-mouseevent-y">attribute for MouseEvent</a><span>, in §10</span>
    </ul>
  </ul>
  <aside class="dfn-panel" data-for="term-for-propdef-border-left-width">
   <a href="https://drafts.csswg.org/css-backgrounds-3/#propdef-border-left-width">https://drafts.csswg.org/css-backgrounds-3/#propdef-border-left-width</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-border-left-width">6. Extensions to the Element Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-border-top-width">
   <a href="https://drafts.csswg.org/css-backgrounds-3/#propdef-border-top-width">https://drafts.csswg.org/css-backgrounds-3/#propdef-border-top-width</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-border-top-width">6. Extensions to the Element Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-box-fragment">
   <a href="https://drafts.csswg.org/css-break-4/#box-fragment">https://drafts.csswg.org/css-break-4/#box-fragment</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-box-fragment">6. Extensions to the Element Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-display">
   <a href="https://drafts.csswg.org/css-display-3/#propdef-display">https://drafts.csswg.org/css-display-3/#propdef-display</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-display">2. Terminology</a>
    <li><a href="#ref-for-propdef-display①">6. Extensions to the Element Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-initial-containing-block">
   <a href="https://drafts.csswg.org/css-display-3/#initial-containing-block">https://drafts.csswg.org/css-display-3/#initial-containing-block</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-initial-containing-block">2. Terminology</a> <a href="#ref-for-initial-containing-block①">(2)</a> <a href="#ref-for-initial-containing-block②">(3)</a> <a href="#ref-for-initial-containing-block③">(4)</a> <a href="#ref-for-initial-containing-block④">(5)</a> <a href="#ref-for-initial-containing-block⑤">(6)</a> <a href="#ref-for-initial-containing-block⑥">(7)</a> <a href="#ref-for-initial-containing-block⑦">(8)</a> <a href="#ref-for-initial-containing-block⑧">(9)</a> <a href="#ref-for-initial-containing-block⑨">(10)</a> <a href="#ref-for-initial-containing-block①⓪">(11)</a> <a href="#ref-for-initial-containing-block①①">(12)</a> <a href="#ref-for-initial-containing-block①②">(13)</a> <a href="#ref-for-initial-containing-block①③">(14)</a> <a href="#ref-for-initial-containing-block①④">(15)</a> <a href="#ref-for-initial-containing-block①⑤">(16)</a> <a href="#ref-for-initial-containing-block①⑥">(17)</a>
    <li><a href="#ref-for-initial-containing-block①⑦">4. Extensions to the Window Interface</a> <a href="#ref-for-initial-containing-block①⑧">(2)</a>
    <li><a href="#ref-for-initial-containing-block①⑨">7. Extensions to the HTMLElement Interface</a> <a href="#ref-for-initial-containing-block②⓪">(2)</a> <a href="#ref-for-initial-containing-block②①">(3)</a> <a href="#ref-for-initial-containing-block②②">(4)</a>
    <li><a href="#ref-for-initial-containing-block②③">8. Extensions to the HTMLImageElement Interface</a> <a href="#ref-for-initial-containing-block②④">(2)</a>
    <li><a href="#ref-for-initial-containing-block②⑤">10. Extensions to the MouseEvent Interface</a> <a href="#ref-for-initial-containing-block②⑥">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-display-inline-table">
   <a href="https://drafts.csswg.org/css-display-3/#valdef-display-inline-table">https://drafts.csswg.org/css-display-3/#valdef-display-inline-table</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-display-inline-table">6. Extensions to the Element Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-display-table">
   <a href="https://drafts.csswg.org/css-display-3/#valdef-display-table">https://drafts.csswg.org/css-display-3/#valdef-display-table</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-display-table">6. Extensions to the Element Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-display-table-column">
   <a href="https://drafts.csswg.org/css-display-3/#valdef-display-table-column">https://drafts.csswg.org/css-display-3/#valdef-display-table-column</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-display-table-column">2. Terminology</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-display-table-column-group">
   <a href="https://drafts.csswg.org/css-display-3/#valdef-display-table-column-group">https://drafts.csswg.org/css-display-3/#valdef-display-table-column-group</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-display-table-column-group">2. Terminology</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-overflow-auto">
   <a href="https://drafts.csswg.org/css-overflow-3/#valdef-overflow-auto">https://drafts.csswg.org/css-overflow-3/#valdef-overflow-auto</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-overflow-auto">2. Terminology</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-overflow-clip">
   <a href="https://drafts.csswg.org/css-overflow-3/#valdef-overflow-clip">https://drafts.csswg.org/css-overflow-3/#valdef-overflow-clip</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-overflow-clip">2. Terminology</a> <a href="#ref-for-valdef-overflow-clip①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-overflow-hidden">
   <a href="https://drafts.csswg.org/css-overflow-3/#valdef-overflow-hidden">https://drafts.csswg.org/css-overflow-3/#valdef-overflow-hidden</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-overflow-hidden">2. Terminology</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-overflow">
   <a href="https://drafts.csswg.org/css-overflow-3/#propdef-overflow">https://drafts.csswg.org/css-overflow-3/#propdef-overflow</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-overflow">2. Terminology</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-overflow-x">
   <a href="https://drafts.csswg.org/css-overflow-3/#propdef-overflow-x">https://drafts.csswg.org/css-overflow-3/#propdef-overflow-x</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-overflow-x">2. Terminology</a> <a href="#ref-for-propdef-overflow-x①">(2)</a> <a href="#ref-for-propdef-overflow-x②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-overflow-y">
   <a href="https://drafts.csswg.org/css-overflow-3/#propdef-overflow-y">https://drafts.csswg.org/css-overflow-3/#propdef-overflow-y</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-overflow-y">2. Terminology</a> <a href="#ref-for-propdef-overflow-y①">(2)</a> <a href="#ref-for-propdef-overflow-y②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-overflow-visible">
   <a href="https://drafts.csswg.org/css-overflow-3/#valdef-overflow-visible">https://drafts.csswg.org/css-overflow-3/#valdef-overflow-visible</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-overflow-visible">2. Terminology</a> <a href="#ref-for-valdef-overflow-visible①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-position-fixed">
   <a href="https://drafts.csswg.org/css-position-3/#valdef-position-fixed">https://drafts.csswg.org/css-position-3/#valdef-position-fixed</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-position-fixed">7. Extensions to the HTMLElement Interface</a> <a href="#ref-for-valdef-position-fixed①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-propdef-position">
   <a href="https://drafts.csswg.org/css-position-3/#propdef-position">https://drafts.csswg.org/css-position-3/#propdef-position</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-position">7. Extensions to the HTMLElement Interface</a> <a href="#ref-for-propdef-position①">(2)</a> <a href="#ref-for-propdef-position②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-valdef-position-static">
   <a href="https://drafts.csswg.org/css-position-3/#valdef-position-static">https://drafts.csswg.org/css-position-3/#valdef-position-static</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-position-static">7. Extensions to the HTMLElement Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-csspseudoelement">
   <a href="https://drafts.csswg.org/css-pseudo-4/#csspseudoelement">https://drafts.csswg.org/css-pseudo-4/#csspseudoelement</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-csspseudoelement">11.1. The GeometryUtils Interface</a> <a href="#ref-for-csspseudoelement①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-flat-tree">
   <a href="https://drafts.csswg.org/css-scoping-1/#flat-tree">https://drafts.csswg.org/css-scoping-1/#flat-tree</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-flat-tree">7. Extensions to the HTMLElement Interface</a> <a href="#ref-for-flat-tree①">(2)</a> <a href="#ref-for-flat-tree②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-typographic-character-unit">
   <a href="https://drafts.csswg.org/css-text-3/#typographic-character-unit">https://drafts.csswg.org/css-text-3/#typographic-character-unit</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typographic-character-unit">9. Extensions to the Range Interface</a> <a href="#ref-for-typographic-character-unit①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-px">
   <a href="https://drafts.csswg.org/css-values-4/#px">https://drafts.csswg.org/css-values-4/#px</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-px">2.1. CSS pixels</a>
    <li><a href="#ref-for-px①">2.3. Web-exposed screen information</a> <a href="#ref-for-px②">(2)</a> <a href="#ref-for-px③">(3)</a> <a href="#ref-for-px④">(4)</a> <a href="#ref-for-px⑤">(5)</a>
    <li><a href="#ref-for-px⑥">4. Extensions to the Window Interface</a> <a href="#ref-for-px⑦">(2)</a> <a href="#ref-for-px⑧">(3)</a> <a href="#ref-for-px⑨">(4)</a> <a href="#ref-for-px①⓪">(5)</a> <a href="#ref-for-px①①">(6)</a> <a href="#ref-for-px①②">(7)</a> <a href="#ref-for-px①③">(8)</a> <a href="#ref-for-px①④">(9)</a> <a href="#ref-for-px①⑤">(10)</a>
    <li><a href="#ref-for-px①⑥">4.1. The features argument to the open() method</a> <a href="#ref-for-px①⑦">(2)</a> <a href="#ref-for-px①⑧">(3)</a> <a href="#ref-for-px①⑨">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-comb-one">
   <a href="https://drafts.csswg.org/css-values-4/#comb-one">https://drafts.csswg.org/css-values-4/#comb-one</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-comb-one">13.1. Smooth Scrolling: The scroll-behavior Property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-block-flow-direction">
   <a href="https://drafts.csswg.org/css-writing-modes-4/#block-flow-direction">https://drafts.csswg.org/css-writing-modes-4/#block-flow-direction</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-block-flow-direction">6.1. Element Scrolling Members</a> <a href="#ref-for-block-flow-direction①">(2)</a> <a href="#ref-for-block-flow-direction②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-block-end">
   <a href="https://drafts.csswg.org/css-writing-modes-4/#block-end">https://drafts.csswg.org/css-writing-modes-4/#block-end</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-block-end">2. Terminology</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-inline-base-direction">
   <a href="https://drafts.csswg.org/css-writing-modes-4/#inline-base-direction">https://drafts.csswg.org/css-writing-modes-4/#inline-base-direction</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-inline-base-direction">6.1. Element Scrolling Members</a> <a href="#ref-for-inline-base-direction①">(2)</a> <a href="#ref-for-inline-base-direction②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-inline-end">
   <a href="https://drafts.csswg.org/css-writing-modes-4/#inline-end">https://drafts.csswg.org/css-writing-modes-4/#inline-end</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-inline-end">2. Terminology</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-cssomstring">
   <a href="https://drafts.csswg.org/cssom-1/#cssomstring">https://drafts.csswg.org/cssom-1/#cssomstring</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-cssomstring">4. Extensions to the Window Interface</a>
    <li><a href="#ref-for-cssomstring①">4.2. The MediaQueryList Interface</a> <a href="#ref-for-cssomstring②">(2)</a> <a href="#ref-for-cssomstring③">(3)</a> <a href="#ref-for-cssomstring④">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-document">
   <a href="https://dom.spec.whatwg.org/#document">https://dom.spec.whatwg.org/#document</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-document">4. Extensions to the Window Interface</a> <a href="#ref-for-document①">(2)</a>
    <li><a href="#ref-for-document②">4.2. The MediaQueryList Interface</a>
    <li><a href="#ref-for-document③">5. Extensions to the Document Interface</a> <a href="#ref-for-document④">(2)</a> <a href="#ref-for-document⑤">(3)</a>
    <li><a href="#ref-for-document⑥">6.1. Element Scrolling Members</a> <a href="#ref-for-document⑦">(2)</a> <a href="#ref-for-document⑧">(3)</a>
    <li><a href="#ref-for-document⑨">11.1. The GeometryUtils Interface</a> <a href="#ref-for-document①⓪">(2)</a>
    <li><a href="#ref-for-document①①">12.1. Resizing viewports</a>
    <li><a href="#ref-for-document①②">12.2. Scrolling</a> <a href="#ref-for-document①③">(2)</a> <a href="#ref-for-document①④">(3)</a> <a href="#ref-for-document①⑤">(4)</a>
    <li><a href="#ref-for-document①⑥">12.3. Event summary</a> <a href="#ref-for-document①⑦">(2)</a>
    <li><a href="#ref-for-document①⑧">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-element">
   <a href="https://dom.spec.whatwg.org/#element">https://dom.spec.whatwg.org/#element</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-element">5. Extensions to the Document Interface</a> <a href="#ref-for-element①">(2)</a> <a href="#ref-for-element②">(3)</a>
    <li><a href="#ref-for-element③">6. Extensions to the Element Interface</a> <a href="#ref-for-element④">(2)</a>
    <li><a href="#ref-for-element⑤">6.1. Element Scrolling Members</a>
    <li><a href="#ref-for-element⑥">7. Extensions to the HTMLElement Interface</a>
    <li><a href="#ref-for-element⑦">11.1. The GeometryUtils Interface</a> <a href="#ref-for-element⑧">(2)</a>
    <li><a href="#ref-for-element⑨">Changes From 17 December 2013 To 31 January 2020</a> <a href="#ref-for-element①⓪">(2)</a> <a href="#ref-for-element①①">(3)</a> <a href="#ref-for-element①②">(4)</a> <a href="#ref-for-element①③">(5)</a>
    <li><a href="#ref-for-element①④">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event">
   <a href="https://dom.spec.whatwg.org/#event">https://dom.spec.whatwg.org/#event</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event">4.2. The MediaQueryList Interface</a>
    <li><a href="#ref-for-event①">4.2.1. Event summary</a>
    <li><a href="#ref-for-event②">12.3. Event summary</a> <a href="#ref-for-event③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dictdef-eventinit">
   <a href="https://dom.spec.whatwg.org/#dictdef-eventinit">https://dom.spec.whatwg.org/#dictdef-eventinit</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-eventinit">4.2. The MediaQueryList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-callbackdef-eventlistener">
   <a href="https://dom.spec.whatwg.org/#callbackdef-eventlistener">https://dom.spec.whatwg.org/#callbackdef-eventlistener</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-callbackdef-eventlistener">4.2. The MediaQueryList Interface</a> <a href="#ref-for-callbackdef-eventlistener①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-eventtarget">
   <a href="https://dom.spec.whatwg.org/#eventtarget">https://dom.spec.whatwg.org/#eventtarget</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventtarget">4.2. The MediaQueryList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-node">
   <a href="https://dom.spec.whatwg.org/#node">https://dom.spec.whatwg.org/#node</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-node">5.1. The CaretPosition Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-range">
   <a href="https://dom.spec.whatwg.org/#range">https://dom.spec.whatwg.org/#range</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-range">5. Extensions to the Document Interface</a>
    <li><a href="#ref-for-range①">9. Extensions to the Range Interface</a> <a href="#ref-for-range②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-text">
   <a href="https://dom.spec.whatwg.org/#text">https://dom.spec.whatwg.org/#text</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-text">9. Extensions to the Range Interface</a>
    <li><a href="#ref-for-text①">11.1. The GeometryUtils Interface</a> <a href="#ref-for-text②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-add-an-event-listener">
   <a href="https://dom.spec.whatwg.org/#add-an-event-listener">https://dom.spec.whatwg.org/#add-an-event-listener</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-add-an-event-listener">4.2. The MediaQueryList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-eventtarget-addeventlistener">
   <a href="https://dom.spec.whatwg.org/#dom-eventtarget-addeventlistener">https://dom.spec.whatwg.org/#dom-eventtarget-addeventlistener</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-eventtarget-addeventlistener">4.2. The MediaQueryList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event-listener-callback">
   <a href="https://dom.spec.whatwg.org/#event-listener-callback">https://dom.spec.whatwg.org/#event-listener-callback</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event-listener-callback">4.2. The MediaQueryList Interface</a> <a href="#ref-for-event-listener-callback①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event-listener-capture">
   <a href="https://dom.spec.whatwg.org/#event-listener-capture">https://dom.spec.whatwg.org/#event-listener-capture</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event-listener-capture">4.2. The MediaQueryList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-closed-shadow-hidden">
   <a href="https://dom.spec.whatwg.org/#concept-closed-shadow-hidden">https://dom.spec.whatwg.org/#concept-closed-shadow-hidden</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-closed-shadow-hidden">7. Extensions to the HTMLElement Interface</a> <a href="#ref-for-concept-closed-shadow-hidden①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-context-object">
   <a href="https://dom.spec.whatwg.org/#context-object">https://dom.spec.whatwg.org/#context-object</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-context-object">4. Extensions to the Window Interface</a> <a href="#ref-for-context-object①">(2)</a> <a href="#ref-for-context-object②">(3)</a> <a href="#ref-for-context-object③">(4)</a> <a href="#ref-for-context-object④">(5)</a>
    <li><a href="#ref-for-context-object⑤">4.2. The MediaQueryList Interface</a> <a href="#ref-for-context-object⑥">(2)</a> <a href="#ref-for-context-object⑦">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-event-listener">
   <a href="https://dom.spec.whatwg.org/#concept-event-listener">https://dom.spec.whatwg.org/#concept-event-listener</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-event-listener">4.2. The MediaQueryList Interface</a> <a href="#ref-for-concept-event-listener①">(2)</a> <a href="#ref-for-concept-event-listener②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-eventtarget-event-listener-list">
   <a href="https://dom.spec.whatwg.org/#eventtarget-event-listener-list">https://dom.spec.whatwg.org/#eventtarget-event-listener-list</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventtarget-event-listener-list">4.2. The MediaQueryList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-parent-element">
   <a href="https://dom.spec.whatwg.org/#parent-element">https://dom.spec.whatwg.org/#parent-element</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-parent-element">2. Terminology</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-remove-an-event-listener">
   <a href="https://dom.spec.whatwg.org/#remove-an-event-listener">https://dom.spec.whatwg.org/#remove-an-event-listener</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-remove-an-event-listener">4.2. The MediaQueryList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-eventtarget-removeeventlistener">
   <a href="https://dom.spec.whatwg.org/#dom-eventtarget-removeeventlistener">https://dom.spec.whatwg.org/#dom-eventtarget-removeeventlistener</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-eventtarget-removeeventlistener">4.2. The MediaQueryList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-event-listener-type">
   <a href="https://dom.spec.whatwg.org/#event-listener-type">https://dom.spec.whatwg.org/#event-listener-type</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-event-listener-type">4.2. The MediaQueryList Interface</a> <a href="#ref-for-event-listener-type①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dompoint">
   <a href="https://drafts.fxtf.org/geometry-1/#dompoint">https://drafts.fxtf.org/geometry-1/#dompoint</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dompoint">11.1. The GeometryUtils Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dictdef-dompointinit">
   <a href="https://drafts.fxtf.org/geometry-1/#dictdef-dompointinit">https://drafts.fxtf.org/geometry-1/#dictdef-dompointinit</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-dompointinit">11.1. The GeometryUtils Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-domquad">
   <a href="https://drafts.fxtf.org/geometry-1/#domquad">https://drafts.fxtf.org/geometry-1/#domquad</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-domquad">11.1. The GeometryUtils Interface</a> <a href="#ref-for-domquad①">(2)</a> <a href="#ref-for-domquad②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dictdef-domquadinit">
   <a href="https://drafts.fxtf.org/geometry-1/#dictdef-domquadinit">https://drafts.fxtf.org/geometry-1/#dictdef-domquadinit</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-domquadinit">11.1. The GeometryUtils Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-domrect">
   <a href="https://drafts.fxtf.org/geometry-1/#domrect">https://drafts.fxtf.org/geometry-1/#domrect</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-domrect">5.1. The CaretPosition Interface</a> <a href="#ref-for-domrect①">(2)</a> <a href="#ref-for-domrect②">(3)</a> <a href="#ref-for-domrect③">(4)</a>
    <li><a href="#ref-for-domrect④">6. Extensions to the Element Interface</a> <a href="#ref-for-domrect⑤">(2)</a> <a href="#ref-for-domrect⑥">(3)</a> <a href="#ref-for-domrect⑦">(4)</a> <a href="#ref-for-domrect⑧">(5)</a> <a href="#ref-for-domrect⑨">(6)</a> <a href="#ref-for-domrect①⓪">(7)</a>
    <li><a href="#ref-for-domrect①①">9. Extensions to the Range Interface</a> <a href="#ref-for-domrect①②">(2)</a> <a href="#ref-for-domrect①③">(3)</a> <a href="#ref-for-domrect①④">(4)</a> <a href="#ref-for-domrect①⑤">(5)</a> <a href="#ref-for-domrect①⑥">(6)</a> <a href="#ref-for-domrect①⑦">(7)</a> <a href="#ref-for-domrect①⑧">(8)</a> <a href="#ref-for-domrect①⑨">(9)</a>
    <li><a href="#ref-for-domrect②⓪">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-domrectlist">
   <a href="https://drafts.fxtf.org/geometry-1/#domrectlist">https://drafts.fxtf.org/geometry-1/#domrectlist</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-domrectlist">6. Extensions to the Element Interface</a> <a href="#ref-for-domrectlist①">(2)</a> <a href="#ref-for-domrectlist②">(3)</a> <a href="#ref-for-domrectlist③">(4)</a>
    <li><a href="#ref-for-domrectlist④">9. Extensions to the Range Interface</a> <a href="#ref-for-domrectlist⑤">(2)</a> <a href="#ref-for-domrectlist⑥">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-domrectreadonly">
   <a href="https://drafts.fxtf.org/geometry-1/#domrectreadonly">https://drafts.fxtf.org/geometry-1/#domrectreadonly</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-domrectreadonly">11.1. The GeometryUtils Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-domrect-height">
   <a href="https://drafts.fxtf.org/geometry-1/#dom-domrect-height">https://drafts.fxtf.org/geometry-1/#dom-domrect-height</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-domrect-height">6. Extensions to the Element Interface</a>
    <li><a href="#ref-for-dom-domrect-height①">9. Extensions to the Range Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-domrect-width">
   <a href="https://drafts.fxtf.org/geometry-1/#dom-domrect-width">https://drafts.fxtf.org/geometry-1/#dom-domrect-width</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-domrect-width">6. Extensions to the Element Interface</a>
    <li><a href="#ref-for-dom-domrect-width①">9. Extensions to the Range Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-domrect-x">
   <a href="https://drafts.fxtf.org/geometry-1/#dom-domrect-x">https://drafts.fxtf.org/geometry-1/#dom-domrect-x</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-domrect-x">6. Extensions to the Element Interface</a>
    <li><a href="#ref-for-dom-domrect-x①">9. Extensions to the Range Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-domrect-y">
   <a href="https://drafts.fxtf.org/geometry-1/#dom-domrect-y">https://drafts.fxtf.org/geometry-1/#dom-domrect-y</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-domrect-y">6. Extensions to the Element Interface</a>
    <li><a href="#ref-for-dom-domrect-y①">9. Extensions to the Range Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-eventhandler">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler">https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventhandler">4.2. The MediaQueryList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-htmlelement">
   <a href="https://html.spec.whatwg.org/multipage/dom.html#htmlelement">https://html.spec.whatwg.org/multipage/dom.html#htmlelement</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-htmlelement">7. Extensions to the HTMLElement Interface</a> <a href="#ref-for-htmlelement①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-htmlimageelement">
   <a href="https://html.spec.whatwg.org/multipage/embedded-content.html#htmlimageelement">https://html.spec.whatwg.org/multipage/embedded-content.html#htmlimageelement</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-htmlimageelement">8. Extensions to the HTMLImageElement Interface</a> <a href="#ref-for-htmlimageelement①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-window">
   <a href="https://html.spec.whatwg.org/multipage/window-object.html#window">https://html.spec.whatwg.org/multipage/window-object.html#window</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-window">4. Extensions to the Window Interface</a> <a href="#ref-for-window①">(2)</a> <a href="#ref-for-window②">(3)</a>
    <li><a href="#ref-for-window③">10. Extensions to the MouseEvent Interface</a> <a href="#ref-for-window④">(2)</a>
    <li><a href="#ref-for-window⑤">12.1. Resizing viewports</a>
    <li><a href="#ref-for-window⑥">12.3. Event summary</a> <a href="#ref-for-window⑦">(2)</a>
    <li><a href="#ref-for-window⑧">Changes From 17 December 2013 To 31 January 2020</a> <a href="#ref-for-window⑨">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-the-body-element">
   <a href="https://html.spec.whatwg.org/multipage/sections.html#the-body-element">https://html.spec.whatwg.org/multipage/sections.html#the-body-element</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-the-body-element">2. Terminology</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-case-sensitive">
   <a href="https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive">https://html.spec.whatwg.org/multipage/infrastructure.html#case-sensitive</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-case-sensitive">2. Terminology</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-document-defaultview">
   <a href="https://html.spec.whatwg.org/multipage/window-object.html#dom-document-defaultview">https://html.spec.whatwg.org/multipage/window-object.html#dom-document-defaultview</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-document-defaultview">6. Extensions to the Element Interface</a> <a href="#ref-for-dom-document-defaultview①">(2)</a> <a href="#ref-for-dom-document-defaultview②">(3)</a> <a href="#ref-for-dom-document-defaultview③">(4)</a> <a href="#ref-for-dom-document-defaultview④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-concept-agent-event-loop">
   <a href="https://html.spec.whatwg.org/multipage/webappapis.html#concept-agent-event-loop">https://html.spec.whatwg.org/multipage/webappapis.html#concept-agent-event-loop</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-agent-event-loop">4.2. The MediaQueryList Interface</a>
    <li><a href="#ref-for-concept-agent-event-loop①">12.1. Resizing viewports</a>
    <li><a href="#ref-for-concept-agent-event-loop②">12.2. Scrolling</a>
    <li><a href="#ref-for-concept-agent-event-loop③">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-live">
   <a href="https://html.spec.whatwg.org/multipage/infrastructure.html#live">https://html.spec.whatwg.org/multipage/infrastructure.html#live</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-live">5.1. The CaretPosition Interface</a>
    <li><a href="#ref-for-live①">6. Extensions to the Element Interface</a> <a href="#ref-for-live②">(2)</a>
    <li><a href="#ref-for-live③">9. Extensions to the Range Interface</a> <a href="#ref-for-live④">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dom-open">
   <a href="https://html.spec.whatwg.org/multipage/window-object.html#dom-open">https://html.spec.whatwg.org/multipage/window-object.html#dom-open</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-open">4.1. The features argument to the open() method</a> <a href="#ref-for-dom-open①">(2)</a>
    <li><a href="#ref-for-dom-open②">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-list-contain">
   <a href="https://infra.spec.whatwg.org/#list-contain">https://infra.spec.whatwg.org/#list-contain</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-list-contain">4.2. The MediaQueryList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-map-exists">
   <a href="https://infra.spec.whatwg.org/#map-exists">https://infra.spec.whatwg.org/#map-exists</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-map-exists">4.1. The features argument to the open() method</a> <a href="#ref-for-map-exists①">(2)</a> <a href="#ref-for-map-exists②">(3)</a> <a href="#ref-for-map-exists③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-ordered-map">
   <a href="https://infra.spec.whatwg.org/#ordered-map">https://infra.spec.whatwg.org/#ordered-map</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ordered-map">4.1. The features argument to the open() method</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-PointerEventsProperty">
   <a href="https://svgwg.org/svg2-draft/interact.html#PointerEventsProperty">https://svgwg.org/svg2-draft/interact.html#PointerEventsProperty</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-PointerEventsProperty">5. Extensions to the Document Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-dictdef-mouseeventinit">
   <a href="https://www.w3.org/TR/uievents/#dictdef-mouseeventinit">https://www.w3.org/TR/uievents/#dictdef-mouseeventinit</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-mouseeventinit">10. Extensions to the MouseEvent Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-Exposed">
   <a href="https://heycam.github.io/webidl/#Exposed">https://heycam.github.io/webidl/#Exposed</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Exposed">4.2. The MediaQueryList Interface</a> <a href="#ref-for-Exposed①">(2)</a>
    <li><a href="#ref-for-Exposed②">4.3. The Screen Interface</a>
    <li><a href="#ref-for-Exposed③">5.1. The CaretPosition Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-NewObject">
   <a href="https://heycam.github.io/webidl/#NewObject">https://heycam.github.io/webidl/#NewObject</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-NewObject">4. Extensions to the Window Interface</a>
    <li><a href="#ref-for-NewObject①">5.1. The CaretPosition Interface</a>
    <li><a href="#ref-for-NewObject②">6. Extensions to the Element Interface</a>
    <li><a href="#ref-for-NewObject③">9. Extensions to the Range Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-Replaceable">
   <a href="https://heycam.github.io/webidl/#Replaceable">https://heycam.github.io/webidl/#Replaceable</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-Replaceable">4. Extensions to the Window Interface</a> <a href="#ref-for-Replaceable①">(2)</a> <a href="#ref-for-Replaceable②">(3)</a> <a href="#ref-for-Replaceable③">(4)</a> <a href="#ref-for-Replaceable④">(5)</a> <a href="#ref-for-Replaceable⑤">(6)</a> <a href="#ref-for-Replaceable⑥">(7)</a> <a href="#ref-for-Replaceable⑦">(8)</a> <a href="#ref-for-Replaceable⑧">(9)</a> <a href="#ref-for-Replaceable⑨">(10)</a> <a href="#ref-for-Replaceable①⓪">(11)</a> <a href="#ref-for-Replaceable①①">(12)</a> <a href="#ref-for-Replaceable①②">(13)</a> <a href="#ref-for-Replaceable①③">(14)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-SameObject">
   <a href="https://heycam.github.io/webidl/#SameObject">https://heycam.github.io/webidl/#SameObject</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-SameObject">4. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-boolean">
   <a href="https://heycam.github.io/webidl/#idl-boolean">https://heycam.github.io/webidl/#idl-boolean</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-boolean">4.2. The MediaQueryList Interface</a> <a href="#ref-for-idl-boolean①">(2)</a> <a href="#ref-for-idl-boolean②">(3)</a>
    <li><a href="#ref-for-idl-boolean③">6. Extensions to the Element Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-unrestricted-double">
   <a href="https://heycam.github.io/webidl/#idl-unrestricted-double">https://heycam.github.io/webidl/#idl-unrestricted-double</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-unrestricted-double">4. Extensions to the Window Interface</a> <a href="#ref-for-idl-unrestricted-double①">(2)</a> <a href="#ref-for-idl-unrestricted-double②">(3)</a> <a href="#ref-for-idl-unrestricted-double③">(4)</a> <a href="#ref-for-idl-unrestricted-double④">(5)</a> <a href="#ref-for-idl-unrestricted-double⑤">(6)</a> <a href="#ref-for-idl-unrestricted-double⑥">(7)</a> <a href="#ref-for-idl-unrestricted-double⑦">(8)</a>
    <li><a href="#ref-for-idl-unrestricted-double⑧">6. Extensions to the Element Interface</a> <a href="#ref-for-idl-unrestricted-double⑨">(2)</a> <a href="#ref-for-idl-unrestricted-double①⓪">(3)</a> <a href="#ref-for-idl-unrestricted-double①①">(4)</a> <a href="#ref-for-idl-unrestricted-double①②">(5)</a> <a href="#ref-for-idl-unrestricted-double①③">(6)</a> <a href="#ref-for-idl-unrestricted-double①④">(7)</a> <a href="#ref-for-idl-unrestricted-double①⑤">(8)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="term-for-idl-unsigned-long">
   <a href="https://heycam.github.io/webidl/#idl-unsigned-long">https://heycam.github.io/webidl/#idl-unsigned-long</a><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-idl-unsigned-long">4.3. The Screen Interface</a> <a href="#ref-for-idl-unsigned-long①">(2)</a>
    <li><a href="#ref-for-idl-unsigned-long②">5.1. The CaretPosition Interface</a>
   </ul>
  </aside>
  <h3 class="no-num no-ref heading settled" id="index-defined-elsewhere"><span class="content">Terms defined by reference</span><a class="self-link" href="#index-defined-elsewhere"></a></h3>
  <ul class="index">
   <li>
    <a data-link-type="biblio">[css-backgrounds-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-border-left-width" style="color:initial">border-left-width</span>
     <li><span class="dfn-paneled" id="term-for-propdef-border-top-width" style="color:initial">border-top-width</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-break-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-box-fragment" style="color:initial">box fragment</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-display-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-propdef-display" style="color:initial">display</span>
     <li><span class="dfn-paneled" id="term-for-initial-containing-block" style="color:initial">initial containing block</span>
     <li><span class="dfn-paneled" id="term-for-valdef-display-inline-table" style="color:initial">inline-table</span>
     <li><span class="dfn-paneled" id="term-for-valdef-display-table" style="color:initial">table</span>
     <li><span class="dfn-paneled" id="term-for-valdef-display-table-column" style="color:initial">table-column</span>
     <li><span class="dfn-paneled" id="term-for-valdef-display-table-column-group" style="color:initial">table-column-group</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-overflow-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-valdef-overflow-auto" style="color:initial">auto</span>
     <li><span class="dfn-paneled" id="term-for-valdef-overflow-clip" style="color:initial">clip</span>
     <li><span class="dfn-paneled" id="term-for-valdef-overflow-hidden" style="color:initial">hidden</span>
     <li><span class="dfn-paneled" id="term-for-propdef-overflow" style="color:initial">overflow</span>
     <li><span class="dfn-paneled" id="term-for-propdef-overflow-x" style="color:initial">overflow-x</span>
     <li><span class="dfn-paneled" id="term-for-propdef-overflow-y" style="color:initial">overflow-y</span>
     <li><span class="dfn-paneled" id="term-for-valdef-overflow-visible" style="color:initial">visible</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-position-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-valdef-position-fixed" style="color:initial">fixed</span>
     <li><span class="dfn-paneled" id="term-for-propdef-position" style="color:initial">position</span>
     <li><span class="dfn-paneled" id="term-for-valdef-position-static" style="color:initial">static</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-pseudo-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-csspseudoelement" style="color:initial">CSSPseudoElement</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-scoping-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-flat-tree" style="color:initial">flat tree</span>
    </ul>
   <li>
    <a data-link-type="biblio">[CSS-TEXT-3]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-typographic-character-unit" style="color:initial">typographic character unit</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-values-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-px" style="color:initial">px</span>
     <li><span class="dfn-paneled" id="term-for-comb-one" style="color:initial">|</span>
    </ul>
   <li>
    <a data-link-type="biblio">[css-writing-modes-4]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-block-flow-direction" style="color:initial">block flow direction</span>
     <li><span class="dfn-paneled" id="term-for-block-end" style="color:initial">block-end</span>
     <li><span class="dfn-paneled" id="term-for-inline-base-direction" style="color:initial">inline base direction</span>
     <li><span class="dfn-paneled" id="term-for-inline-end" style="color:initial">inline-end</span>
    </ul>
   <li>
    <a data-link-type="biblio">[CSSOM]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-cssomstring" style="color:initial">CSSOMString</span>
    </ul>
   <li>
    <a data-link-type="biblio">[DOM]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-document" style="color:initial">Document</span>
     <li><span class="dfn-paneled" id="term-for-element" style="color:initial">Element</span>
     <li><span class="dfn-paneled" id="term-for-event" style="color:initial">Event</span>
     <li><span class="dfn-paneled" id="term-for-dictdef-eventinit" style="color:initial">EventInit</span>
     <li><span class="dfn-paneled" id="term-for-callbackdef-eventlistener" style="color:initial">EventListener</span>
     <li><span class="dfn-paneled" id="term-for-eventtarget" style="color:initial">EventTarget</span>
     <li><span class="dfn-paneled" id="term-for-node" style="color:initial">Node</span>
     <li><span class="dfn-paneled" id="term-for-range" style="color:initial">Range</span>
     <li><span class="dfn-paneled" id="term-for-text" style="color:initial">Text</span>
     <li><span class="dfn-paneled" id="term-for-add-an-event-listener" style="color:initial">add an event listener</span>
     <li><span class="dfn-paneled" id="term-for-dom-eventtarget-addeventlistener" style="color:initial">addEventListener(type, callback)</span>
     <li><span class="dfn-paneled" id="term-for-event-listener-callback" style="color:initial">callback</span>
     <li><span class="dfn-paneled" id="term-for-event-listener-capture" style="color:initial">capture</span>
     <li><span class="dfn-paneled" id="term-for-concept-closed-shadow-hidden" style="color:initial">closed-shadow-hidden</span>
     <li><span class="dfn-paneled" id="term-for-context-object" style="color:initial">context object</span>
     <li><span class="dfn-paneled" id="term-for-concept-event-listener" style="color:initial">event listener</span>
     <li><span class="dfn-paneled" id="term-for-eventtarget-event-listener-list" style="color:initial">event listener list</span>
     <li><span class="dfn-paneled" id="term-for-parent-element" style="color:initial">parent element</span>
     <li><span class="dfn-paneled" id="term-for-remove-an-event-listener" style="color:initial">remove an event listener</span>
     <li><span class="dfn-paneled" id="term-for-dom-eventtarget-removeeventlistener" style="color:initial">removeEventListener(type, callback)</span>
     <li><span class="dfn-paneled" id="term-for-event-listener-type" style="color:initial">type</span>
    </ul>
   <li>
    <a data-link-type="biblio">[GEOMETRY-1]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-dompoint" style="color:initial">DOMPoint</span>
     <li><span class="dfn-paneled" id="term-for-dictdef-dompointinit" style="color:initial">DOMPointInit</span>
     <li><span class="dfn-paneled" id="term-for-domquad" style="color:initial">DOMQuad</span>
     <li><span class="dfn-paneled" id="term-for-dictdef-domquadinit" style="color:initial">DOMQuadInit</span>
     <li><span class="dfn-paneled" id="term-for-domrect" style="color:initial">DOMRect</span>
     <li><span class="dfn-paneled" id="term-for-domrectlist" style="color:initial">DOMRectList</span>
     <li><span class="dfn-paneled" id="term-for-domrectreadonly" style="color:initial">DOMRectReadOnly</span>
     <li><span class="dfn-paneled" id="term-for-dom-domrect-height" style="color:initial">height</span>
     <li><span class="dfn-paneled" id="term-for-dom-domrect-width" style="color:initial">width</span>
     <li><span class="dfn-paneled" id="term-for-dom-domrect-x" style="color:initial">x</span>
     <li><span class="dfn-paneled" id="term-for-dom-domrect-y" style="color:initial">y</span>
    </ul>
   <li>
    <a data-link-type="biblio">[HTML]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-eventhandler" style="color:initial">EventHandler</span>
     <li><span class="dfn-paneled" id="term-for-htmlelement" style="color:initial">HTMLElement</span>
     <li><span class="dfn-paneled" id="term-for-htmlimageelement" style="color:initial">HTMLImageElement</span>
     <li><span class="dfn-paneled" id="term-for-window" style="color:initial">Window</span>
     <li><span class="dfn-paneled" id="term-for-the-body-element" style="color:initial">body</span>
     <li><span class="dfn-paneled" id="term-for-case-sensitive" style="color:initial">case-sensitive</span>
     <li><span class="dfn-paneled" id="term-for-dom-document-defaultview" style="color:initial">defaultView</span>
     <li><span class="dfn-paneled" id="term-for-concept-agent-event-loop" style="color:initial">event loop</span>
     <li><span class="dfn-paneled" id="term-for-live" style="color:initial">live</span>
     <li><span class="dfn-paneled" id="term-for-dom-open" style="color:initial">open()</span>
    </ul>
   <li>
    <a data-link-type="biblio">[INFRA]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-list-contain" style="color:initial">contain</span>
     <li><span class="dfn-paneled" id="term-for-map-exists" style="color:initial">exist</span>
     <li><span class="dfn-paneled" id="term-for-ordered-map" style="color:initial">map</span>
    </ul>
   <li>
    <a data-link-type="biblio">[SVG2]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-PointerEventsProperty" style="color:initial">pointer-events</span>
    </ul>
   <li>
    <a data-link-type="biblio">[uievents]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-dictdef-mouseeventinit" style="color:initial">MouseEventInit</span>
    </ul>
   <li>
    <a data-link-type="biblio">[WEBIDL]</a> defines the following terms:
    <ul>
     <li><span class="dfn-paneled" id="term-for-Exposed" style="color:initial">Exposed</span>
     <li><span class="dfn-paneled" id="term-for-NewObject" style="color:initial">NewObject</span>
     <li><span class="dfn-paneled" id="term-for-Replaceable" style="color:initial">Replaceable</span>
     <li><span class="dfn-paneled" id="term-for-SameObject" style="color:initial">SameObject</span>
     <li><span class="dfn-paneled" id="term-for-idl-boolean" style="color:initial">boolean</span>
     <li><span class="dfn-paneled" id="term-for-idl-unrestricted-double" style="color:initial">unrestricted double</span>
     <li><span class="dfn-paneled" id="term-for-idl-unsigned-long" style="color:initial">unsigned long</span>
    </ul>
  </ul>
  <h2 class="no-num no-ref heading settled" id="references"><span class="content">References</span><a class="self-link" href="#references"></a></h2>
  <h3 class="no-num no-ref heading settled" id="normative"><span class="content">Normative References</span><a class="self-link" href="#normative"></a></h3>
  <dl>
   <dt id="biblio-css-backgrounds-3">[CSS-BACKGROUNDS-3]
   <dd>Bert Bos; Elika Etemad; Brad Kemper. <a href="https://www.w3.org/TR/css-backgrounds-3/">CSS Backgrounds and Borders Module Level 3</a>. 17 October 2017. CR. URL: <a href="https://www.w3.org/TR/css-backgrounds-3/">https://www.w3.org/TR/css-backgrounds-3/</a>
   <dt id="biblio-css-break-4">[CSS-BREAK-4]
   <dd>Rossen Atanassov; Elika Etemad. <a href="https://www.w3.org/TR/css-break-4/">CSS Fragmentation Module Level 4</a>. 18 December 2018. WD. URL: <a href="https://www.w3.org/TR/css-break-4/">https://www.w3.org/TR/css-break-4/</a>
   <dt id="biblio-css-device-adapt">[CSS-DEVICE-ADAPT]
   <dd>Rune Lillesveen; Florian Rivoal; Matt Rakow. <a href="https://www.w3.org/TR/css-device-adapt-1/">CSS Device Adaptation Module Level 1</a>. 29 March 2016. WD. URL: <a href="https://www.w3.org/TR/css-device-adapt-1/">https://www.w3.org/TR/css-device-adapt-1/</a>
   <dt id="biblio-css-display-3">[CSS-DISPLAY-3]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-display-3/">CSS Display Module Level 3</a>. 11 July 2019. CR. URL: <a href="https://www.w3.org/TR/css-display-3/">https://www.w3.org/TR/css-display-3/</a>
   <dt id="biblio-css-overflow-3">[CSS-OVERFLOW-3]
   <dd>David Baron; Elika Etemad; Florian Rivoal. <a href="https://www.w3.org/TR/css-overflow-3/">CSS Overflow Module Level 3</a>. 31 July 2018. WD. URL: <a href="https://www.w3.org/TR/css-overflow-3/">https://www.w3.org/TR/css-overflow-3/</a>
   <dt id="biblio-css-position-3">[CSS-POSITION-3]
   <dd>Rossen Atanassov; Arron Eicholz. <a href="https://www.w3.org/TR/css-position-3/">CSS Positioned Layout Module Level 3</a>. 17 May 2016. WD. URL: <a href="https://www.w3.org/TR/css-position-3/">https://www.w3.org/TR/css-position-3/</a>
   <dt id="biblio-css-pseudo-4">[CSS-PSEUDO-4]
   <dd>Daniel Glazman; Elika Etemad; Alan Stearns. <a href="https://www.w3.org/TR/css-pseudo-4/">CSS Pseudo-Elements Module Level 4</a>. 25 February 2019. WD. URL: <a href="https://www.w3.org/TR/css-pseudo-4/">https://www.w3.org/TR/css-pseudo-4/</a>
   <dt id="biblio-css-scoping-1">[CSS-SCOPING-1]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-scoping-1/">CSS Scoping Module Level 1</a>. 3 April 2014. WD. URL: <a href="https://www.w3.org/TR/css-scoping-1/">https://www.w3.org/TR/css-scoping-1/</a>
   <dt id="biblio-css-text-3">[CSS-TEXT-3]
   <dd>Elika Etemad; Koji Ishii; Florian Rivoal. <a href="https://www.w3.org/TR/css-text-3/">CSS Text Module Level 3</a>. 13 November 2019. WD. URL: <a href="https://www.w3.org/TR/css-text-3/">https://www.w3.org/TR/css-text-3/</a>
   <dt id="biblio-css-transforms-1">[CSS-TRANSFORMS-1]
   <dd>Simon Fraser; et al. <a href="https://www.w3.org/TR/css-transforms-1/">CSS Transforms Module Level 1</a>. 14 February 2019. CR. URL: <a href="https://www.w3.org/TR/css-transforms-1/">https://www.w3.org/TR/css-transforms-1/</a>
   <dt id="biblio-css-values">[CSS-VALUES]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-values-3/">CSS Values and Units Module Level 3</a>. 6 June 2019. CR. URL: <a href="https://www.w3.org/TR/css-values-3/">https://www.w3.org/TR/css-values-3/</a>
   <dt id="biblio-css-values-4">[CSS-VALUES-4]
   <dd>Tab Atkins Jr.; Elika Etemad. <a href="https://www.w3.org/TR/css-values-4/">CSS Values and Units Module Level 4</a>. 31 January 2019. WD. URL: <a href="https://www.w3.org/TR/css-values-4/">https://www.w3.org/TR/css-values-4/</a>
   <dt id="biblio-css-writing-modes-4">[CSS-WRITING-MODES-4]
   <dd>Elika Etemad; Koji Ishii. <a href="https://www.w3.org/TR/css-writing-modes-4/">CSS Writing Modes Level 4</a>. 30 July 2019. CR. URL: <a href="https://www.w3.org/TR/css-writing-modes-4/">https://www.w3.org/TR/css-writing-modes-4/</a>
   <dt id="biblio-css3-box">[CSS3-BOX]
   <dd>Elika Etemad. <a href="https://www.w3.org/TR/css-box-3/">CSS Box Model Module Level 3</a>. 18 December 2018. WD. URL: <a href="https://www.w3.org/TR/css-box-3/">https://www.w3.org/TR/css-box-3/</a>
   <dt id="biblio-cssom">[CSSOM]
   <dd>Simon Pieters; Glenn Adams. <a href="https://www.w3.org/TR/cssom-1/">CSS Object Model (CSSOM)</a>. 17 March 2016. WD. URL: <a href="https://www.w3.org/TR/cssom-1/">https://www.w3.org/TR/cssom-1/</a>
   <dt id="biblio-dom">[DOM]
   <dd>Anne van Kesteren. <a href="https://dom.spec.whatwg.org/">DOM Standard</a>. Living Standard. URL: <a href="https://dom.spec.whatwg.org/">https://dom.spec.whatwg.org/</a>
   <dt id="biblio-geometry-1">[GEOMETRY-1]
   <dd>Simon Pieters; Chris Harrelson. <a href="https://www.w3.org/TR/geometry-1/">Geometry Interfaces Module Level 1</a>. 4 December 2018. CR. URL: <a href="https://www.w3.org/TR/geometry-1/">https://www.w3.org/TR/geometry-1/</a>
   <dt id="biblio-html">[HTML]
   <dd>Anne van Kesteren; et al. <a href="https://html.spec.whatwg.org/multipage/">HTML Standard</a>. Living Standard. URL: <a href="https://html.spec.whatwg.org/multipage/">https://html.spec.whatwg.org/multipage/</a>
   <dt id="biblio-infra">[INFRA]
   <dd>Anne van Kesteren; Domenic Denicola. <a href="https://infra.spec.whatwg.org/">Infra Standard</a>. Living Standard. URL: <a href="https://infra.spec.whatwg.org/">https://infra.spec.whatwg.org/</a>
   <dt id="biblio-rfc2119">[RFC2119]
   <dd>S. Bradner. <a href="https://tools.ietf.org/html/rfc2119">Key words for use in RFCs to Indicate Requirement Levels</a>. March 1997. Best Current Practice. URL: <a href="https://tools.ietf.org/html/rfc2119">https://tools.ietf.org/html/rfc2119</a>
   <dt id="biblio-svg11">[SVG11]
   <dd>Erik Dahlström; et al. <a href="https://www.w3.org/TR/SVG11/">Scalable Vector Graphics (SVG) 1.1 (Second Edition)</a>. 16 August 2011. REC. URL: <a href="https://www.w3.org/TR/SVG11/">https://www.w3.org/TR/SVG11/</a>
   <dt id="biblio-uievents">[UIEVENTS]
   <dd>Gary Kacmarcik; Travis Leithead; Doug Schepers. <a href="https://www.w3.org/TR/uievents/">UI Events</a>. 30 May 2019. WD. URL: <a href="https://www.w3.org/TR/uievents/">https://www.w3.org/TR/uievents/</a>
   <dt id="biblio-webidl">[WEBIDL]
   <dd>Boris Zbarsky. <a href="https://heycam.github.io/webidl/">Web IDL</a>. 15 December 2016. ED. URL: <a href="https://heycam.github.io/webidl/">https://heycam.github.io/webidl/</a>
  </dl>
  <h3 class="no-num no-ref heading settled" id="informative"><span class="content">Informative References</span><a class="self-link" href="#informative"></a></h3>
  <dl>
   <dt id="biblio-svg2">[SVG2]
   <dd>Amelia Bellamy-Royds; et al. <a href="https://www.w3.org/TR/SVG2/">Scalable Vector Graphics (SVG) 2</a>. 4 October 2018. CR. URL: <a href="https://www.w3.org/TR/SVG2/">https://www.w3.org/TR/SVG2/</a>
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
      <th scope="col">Canonical order
      <th scope="col">Com­puted value
    <tbody>
     <tr>
      <th scope="row"><a class="css" data-link-type="property" href="#propdef-scroll-behavior" id="ref-for-propdef-scroll-behavior⑦">scroll-behavior</a>
      <td>auto | smooth
      <td>auto
      <td>scrolling boxes
      <td>no
      <td>n/a
      <td>no
      <td>per grammar
      <td>specified value
   </table>
  </div>
  <h2 class="no-num no-ref heading settled" id="idl-index"><span class="content">IDL Index</span><a class="self-link" href="#idl-index"></a></h2>
<pre class="idl highlight def"><c- b>enum</c-> <a href="#enumdef-scrollbehavior"><code><c- g>ScrollBehavior</c-></code></a> { <a href="#dom-scrollbehavior-auto"><code><c- s>"auto"</c-></code></a>, <a href="#dom-scrollbehavior-smooth"><code><c- s>"smooth"</c-></code></a> };

<c- b>dictionary</c-> <a href="#dictdef-scrolloptions"><code><c- g>ScrollOptions</c-></code></a> {
    <a class="n" data-link-type="idl-name" href="#enumdef-scrollbehavior"><c- n>ScrollBehavior</c-></a> <a data-default="&quot;auto&quot;" data-type="ScrollBehavior " href="#dom-scrolloptions-behavior"><code><c- g>behavior</c-></code></a> = "auto";
};
<c- b>dictionary</c-> <a href="#dictdef-scrolltooptions"><code><c- g>ScrollToOptions</c-></code></a> : <a class="n" data-link-type="idl-name" href="#dictdef-scrolloptions"><c- n>ScrollOptions</c-></a> {
    <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <a data-type="unrestricted double " href="#dom-scrolltooptions-left"><code><c- g>left</c-></code></a>;
    <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <a data-type="unrestricted double " href="#dom-scrolltooptions-top"><code><c- g>top</c-></code></a>;
};

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/window-object.html#window"><c- g>Window</c-></a> {
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject"><c- g>NewObject</c-></a>] <a class="n" data-link-type="idl-name" href="#mediaquerylist"><c- n>MediaQueryList</c-></a> <a class="idl-code" data-link-type="method" href="#dom-window-matchmedia"><c- g>matchMedia</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-window-matchmedia-query-query"><code><c- g>query</c-></code></a>);
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#SameObject"><c- g>SameObject</c-></a>, <a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="#screen"><c- n>Screen</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="Screen" href="#dom-window-screen"><c- g>screen</c-></a>;

    // browsing context
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-moveto"><c- g>moveTo</c-></a>(<a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a href="#dom-window-moveto-x-y-x"><code><c- g>x</c-></code></a>, <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a href="#dom-window-moveto-x-y-y"><code><c- g>y</c-></code></a>);
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-moveby"><c- g>moveBy</c-></a>(<a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a href="#dom-window-moveby-x-y-x"><code><c- g>x</c-></code></a>, <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a href="#dom-window-moveby-x-y-y"><code><c- g>y</c-></code></a>);
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-resizeto"><c- g>resizeTo</c-></a>(<a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a href="#dom-window-resizeto-width-height-width"><code><c- g>width</c-></code></a>, <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a href="#dom-window-resizeto-width-height-height"><code><c- g>height</c-></code></a>);
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-resizeby"><c- g>resizeBy</c-></a>(<a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a href="#dom-window-resizeby-x-y-x"><code><c- g>x</c-></code></a>, <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a href="#dom-window-resizeby-x-y-y"><code><c- g>y</c-></code></a>);

    // viewport
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-window-innerwidth"><c- g>innerWidth</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-window-innerheight"><c- g>innerHeight</c-></a>;

    // viewport scrolling
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-window-scrollx"><c- g>scrollX</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-window-pagexoffset"><c- g>pageXOffset</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-window-scrolly"><c- g>scrollY</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-window-pageyoffset"><c- g>pageYOffset</c-></a>;
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-scroll"><c- g>scroll</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-scrolltooptions"><c- n>ScrollToOptions</c-></a> <a href="#dom-window-scroll-options-options"><code><c- g>options</c-></code></a> = {});
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-scroll"><c- g>scroll</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <a href="#dom-window-scroll-x-y-x"><code><c- g>x</c-></code></a>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <a href="#dom-window-scroll-x-y-y"><code><c- g>y</c-></code></a>);
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-scrollto"><c- g>scrollTo</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-scrolltooptions"><c- n>ScrollToOptions</c-></a> <a href="#dom-window-scrollto-options-options"><code><c- g>options</c-></code></a> = {});
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-scrollto"><c- g>scrollTo</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <a href="#dom-window-scrollto-x-y-x"><code><c- g>x</c-></code></a>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <a href="#dom-window-scrollto-x-y-y"><code><c- g>y</c-></code></a>);
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-scrollby"><c- g>scrollBy</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-scrolltooptions"><c- n>ScrollToOptions</c-></a> <a href="#dom-window-scrollby-options-options"><code><c- g>options</c-></code></a> = {});
    <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-window-scrollby"><c- g>scrollBy</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <a href="#dom-window-scrollby-x-y-x"><code><c- g>x</c-></code></a>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <a href="#dom-window-scrollby-x-y-y"><code><c- g>y</c-></code></a>);

    // client
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-window-screenx"><c- g>screenX</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-window-screenleft"><c- g>screenLeft</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-window-screeny"><c- g>screenY</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-window-screentop"><c- g>screenTop</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-window-outerwidth"><c- g>outerWidth</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-window-outerheight"><c- g>outerHeight</c-></a>;
    [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Replaceable"><c- g>Replaceable</c-></a>] <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-window-devicepixelratio"><c- g>devicePixelRatio</c-></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#mediaquerylist"><code><c- g>MediaQueryList</c-></code></a> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#eventtarget"><c- n>EventTarget</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#dom-mediaquerylist-media"><c- g>media</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-mediaquerylist-matches"><c- g>matches</c-></a>;
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-mediaquerylist-addlistener"><c- g>addListener</c-></a>(<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#callbackdef-eventlistener"><c- n>EventListener</c-></a>? <a href="#dom-mediaquerylist-addlistener-callback-callback"><code><c- g>callback</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-mediaquerylist-removelistener"><c- g>removeListener</c-></a>(<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#callbackdef-eventlistener"><c- n>EventListener</c-></a>? <a href="#dom-mediaquerylist-removelistener-callback-callback"><code><c- g>callback</c-></code></a>);
           <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://html.spec.whatwg.org/multipage/webappapis.html#eventhandler"><c- n>EventHandler</c-></a> <a class="idl-code" data-link-type="attribute" data-type="EventHandler" href="#dom-mediaquerylist-onchange"><c- g>onchange</c-></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#mediaquerylistevent"><code><c- g>MediaQueryListEvent</c-></code></a> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#event"><c- n>Event</c-></a> {
  <a href="#dom-mediaquerylistevent-mediaquerylistevent"><code><c- g>constructor</c-></code></a>(<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a href="#dom-mediaquerylistevent-mediaquerylistevent-type-eventinitdict-type"><code><c- g>type</c-></code></a>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-mediaquerylisteventinit"><c- n>MediaQueryListEventInit</c-></a> <a href="#dom-mediaquerylistevent-mediaquerylistevent-type-eventinitdict-eventinitdict"><code><c- g>eventInitDict</c-></code></a> = {});
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="CSSOMString" href="#dom-mediaquerylistevent-media"><c- g>media</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="boolean" href="#dom-mediaquerylistevent-matches"><c- g>matches</c-></a>;
};

<c- b>dictionary</c-> <a href="#dictdef-mediaquerylisteventinit"><code><c- g>MediaQueryListEventInit</c-></code></a> : <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#dictdef-eventinit"><c- n>EventInit</c-></a> {
  <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/cssom-1/#cssomstring"><c- n>CSSOMString</c-></a> <a data-default="&quot;&quot;" data-type="CSSOMString " href="#dom-mediaquerylisteventinit-media"><code><c- g>media</c-></code></a> = "";
  <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <a data-default="false" data-type="boolean " href="#dom-mediaquerylisteventinit-matches"><code><c- g>matches</c-></code></a> = <c- b>false</c->;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#screen"><code><c- g>Screen</c-></code></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-screen-availwidth"><c- g>availWidth</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-screen-availheight"><c- g>availHeight</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-screen-width"><c- g>width</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-screen-height"><c- g>height</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned long" href="#dom-screen-colordepth"><c- g>colorDepth</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned long" href="#dom-screen-pixeldepth"><c- g>pixelDepth</c-></a>;
};

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://dom.spec.whatwg.org/#document"><c- g>Document</c-></a> {
  <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element"><c- n>Element</c-></a>? <a class="idl-code" data-link-type="method" href="#dom-document-elementfrompoint"><c- g>elementFromPoint</c-></a>(<a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a href="#dom-document-elementfrompoint-x-y-x"><code><c- g>x</c-></code></a>, <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a href="#dom-document-elementfrompoint-x-y-y"><code><c- g>y</c-></code></a>);
  <c- b>sequence</c->&lt;<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element"><c- n>Element</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-document-elementsfrompoint"><c- g>elementsFromPoint</c-></a>(<a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a href="#dom-document-elementsfrompoint-x-y-x"><code><c- g>x</c-></code></a>, <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a href="#dom-document-elementsfrompoint-x-y-y"><code><c- g>y</c-></code></a>);
  <a class="n" data-link-type="idl-name" href="#caretposition"><c- n>CaretPosition</c-></a>? <a class="idl-code" data-link-type="method" href="#dom-document-caretpositionfrompoint"><c- g>caretPositionFromPoint</c-></a>(<a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a href="#dom-document-caretpositionfrompoint-x-y-x"><code><c- g>x</c-></code></a>, <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a href="#dom-document-caretpositionfrompoint-x-y-y"><code><c- g>y</c-></code></a>);
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element"><c- n>Element</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="Element?" href="#dom-document-scrollingelement"><c- g>scrollingElement</c-></a>;
};

[<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#Exposed"><c- g>Exposed</c-></a>=<c- n>Window</c->]
<c- b>interface</c-> <a href="#caretposition"><code><c- g>CaretPosition</c-></code></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#node"><c- n>Node</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="Node" href="#dom-caretposition-offsetnode"><c- g>offsetNode</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unsigned-long"><c- b>unsigned</c-> <c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="unsigned long" href="#dom-caretposition-offset"><c- g>offset</c-></a>;
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject"><c- g>NewObject</c-></a>] <a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domrect"><c- n>DOMRect</c-></a>? <a class="idl-code" data-link-type="method" href="#dom-caretposition-getclientrect"><c- g>getClientRect</c-></a>();
};

<c- b>enum</c-> <a href="#enumdef-scrolllogicalposition"><code><c- g>ScrollLogicalPosition</c-></code></a> { <a href="#dom-scrolllogicalposition-start"><code><c- s>"start"</c-></code></a>, <a href="#dom-scrolllogicalposition-center"><code><c- s>"center"</c-></code></a>, <a href="#dom-scrolllogicalposition-end"><code><c- s>"end"</c-></code></a>, <a href="#dom-scrolllogicalposition-nearest"><code><c- s>"nearest"</c-></code></a> };
<c- b>dictionary</c-> <a href="#dictdef-scrollintoviewoptions"><code><c- g>ScrollIntoViewOptions</c-></code></a> : <a class="n" data-link-type="idl-name" href="#dictdef-scrolloptions"><c- n>ScrollOptions</c-></a> {
  <a class="n" data-link-type="idl-name" href="#enumdef-scrolllogicalposition"><c- n>ScrollLogicalPosition</c-></a> <a data-default="&quot;start&quot;" data-type="ScrollLogicalPosition " href="#dom-scrollintoviewoptions-block"><code><c- g>block</c-></code></a> = "start";
  <a class="n" data-link-type="idl-name" href="#enumdef-scrolllogicalposition"><c- n>ScrollLogicalPosition</c-></a> <a data-default="&quot;nearest&quot;" data-type="ScrollLogicalPosition " href="#dom-scrollintoviewoptions-inline"><code><c- g>inline</c-></code></a> = "nearest";
};

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://dom.spec.whatwg.org/#element"><c- g>Element</c-></a> {
  <a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domrectlist"><c- n>DOMRectList</c-></a> <a class="idl-code" data-link-type="method" href="#dom-element-getclientrects"><c- g>getClientRects</c-></a>();
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject"><c- g>NewObject</c-></a>] <a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domrect"><c- n>DOMRect</c-></a> <a class="idl-code" data-link-type="method" href="#dom-element-getboundingclientrect"><c- g>getBoundingClientRect</c-></a>();
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-element-scrollintoview"><c- g>scrollIntoView</c-></a>(<c- b>optional</c-> (<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-boolean"><c- b>boolean</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="#dictdef-scrollintoviewoptions"><c- n>ScrollIntoViewOptions</c-></a>) <a href="#dom-element-scrollintoview-arg-arg"><code><c- g>arg</c-></code></a> = {});
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-element-scroll"><c- g>scroll</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-scrolltooptions"><c- n>ScrollToOptions</c-></a> <a href="#dom-element-scroll-options-options"><code><c- g>options</c-></code></a> = {});
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-element-scroll"><c- g>scroll</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <a href="#dom-element-scroll-x-y-x"><code><c- g>x</c-></code></a>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <a href="#dom-element-scroll-x-y-y"><code><c- g>y</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-element-scrollto"><c- g>scrollTo</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-scrolltooptions"><c- n>ScrollToOptions</c-></a> <a href="#dom-element-scrollto-options-options"><code><c- g>options</c-></code></a> = {});
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-element-scrollto"><c- g>scrollTo</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <a href="#dom-element-scrollto-x-y-x"><code><c- g>x</c-></code></a>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <a href="#dom-element-scrollto-x-y-y"><code><c- g>y</c-></code></a>);
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-element-scrollby"><c- g>scrollBy</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-scrolltooptions"><c- n>ScrollToOptions</c-></a> <a href="#dom-element-scrollby-options-options"><code><c- g>options</c-></code></a> = {});
  <c- b>void</c-> <a class="idl-code" data-link-type="method" href="#dom-element-scrollby"><c- g>scrollBy</c-></a>(<a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <a href="#dom-element-scrollby-x-y-x"><code><c- g>x</c-></code></a>, <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <a href="#dom-element-scrollby-x-y-y"><code><c- g>y</c-></code></a>);
  <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-type="unrestricted double" href="#dom-element-scrolltop"><c- g>scrollTop</c-></a>;
  <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="https://heycam.github.io/webidl/#idl-unrestricted-double"><c- b>unrestricted</c-> <c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-type="unrestricted double" href="#dom-element-scrollleft"><c- g>scrollLeft</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-element-scrollwidth"><c- g>scrollWidth</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-element-scrollheight"><c- g>scrollHeight</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-element-clienttop"><c- g>clientTop</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-element-clientleft"><c- g>clientLeft</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-element-clientwidth"><c- g>clientWidth</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-element-clientheight"><c- g>clientHeight</c-></a>;
};

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/dom.html#htmlelement"><c- g>HTMLElement</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element"><c- n>Element</c-></a>? <a class="idl-code" data-link-type="attribute" data-readonly data-type="Element?" href="#dom-htmlelement-offsetparent"><c- g>offsetParent</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-htmlelement-offsettop"><c- g>offsetTop</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-htmlelement-offsetleft"><c- g>offsetLeft</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-htmlelement-offsetwidth"><c- g>offsetWidth</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-htmlelement-offsetheight"><c- g>offsetHeight</c-></a>;
};

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://html.spec.whatwg.org/multipage/embedded-content.html#htmlimageelement"><c- g>HTMLImageElement</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-htmlimageelement-x"><c- g>x</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-long"><c- b>long</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="long" href="#dom-htmlimageelement-y"><c- g>y</c-></a>;
};

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://dom.spec.whatwg.org/#range"><c- g>Range</c-></a> {
  <a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domrectlist"><c- n>DOMRectList</c-></a> <a class="idl-code" data-link-type="method" href="#dom-range-getclientrects"><c- g>getClientRects</c-></a>();
  [<a class="idl-code" data-link-type="extended-attribute" href="https://heycam.github.io/webidl/#NewObject"><c- g>NewObject</c-></a>] <a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domrect"><c- n>DOMRect</c-></a> <a class="idl-code" data-link-type="method" href="#dom-range-getboundingclientrect"><c- g>getBoundingClientRect</c-></a>();
};

<c- b>partial</c-> <c- b>interface</c-> <a class="idl-code" data-link-type="interface" href="https://www.w3.org/TR/DOM-Level-3-Events/#interface-MouseEvent"><c- g>MouseEvent</c-></a> {
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-screenx"><c- g>screenX</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-screeny"><c- g>screenY</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-pagex"><c- g>pageX</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-pagey"><c- g>pageY</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-clientx"><c- g>clientX</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-clienty"><c- g>clientY</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-x"><c- g>x</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-y"><c- g>y</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-offsetx"><c- g>offsetX</c-></a>;
  <c- b>readonly</c-> <c- b>attribute</c-> <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a class="idl-code" data-link-type="attribute" data-readonly data-type="double" href="#dom-mouseevent-offsety"><c- g>offsetY</c-></a>;
};

<c- b>partial</c-> <c- b>dictionary</c-> <a class="idl-code" data-link-type="dictionary" href="https://www.w3.org/TR/uievents/#dictdef-mouseeventinit"><c- g>MouseEventInit</c-></a> {
  <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a data-default="0.0" data-type="double " href="#dom-mouseeventinit-screenx"><code><c- g>screenX</c-></code></a> = 0.0;
  <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a data-default="0.0" data-type="double " href="#dom-mouseeventinit-screeny"><code><c- g>screenY</c-></code></a> = 0.0;
  <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a data-default="0.0" data-type="double " href="#dom-mouseeventinit-clientx"><code><c- g>clientX</c-></code></a> = 0.0;
  <a class="idl-code" data-link-type="interface" href="http://heycam.github.io/webidl/#idl-double"><c- b>double</c-></a> <a data-default="0.0" data-type="double " href="#dom-mouseeventinit-clienty"><code><c- g>clientY</c-></code></a> = 0.0;
};

<c- b>enum</c-> <a href="#enumdef-cssboxtype"><code><c- g>CSSBoxType</c-></code></a> { <a href="#dom-cssboxtype-margin"><code><c- s>"margin"</c-></code></a>, <a href="#dom-cssboxtype-border"><code><c- s>"border"</c-></code></a>, <a href="#dom-cssboxtype-padding"><code><c- s>"padding"</c-></code></a>, <a href="#dom-cssboxtype-content"><code><c- s>"content"</c-></code></a> };
<c- b>dictionary</c-> <a href="#dictdef-boxquadoptions"><code><c- g>BoxQuadOptions</c-></code></a> {
  <a class="n" data-link-type="idl-name" href="#enumdef-cssboxtype"><c- n>CSSBoxType</c-></a> <a data-default="&quot;border&quot;" data-type="CSSBoxType " href="#dom-boxquadoptions-box"><code><c- g>box</c-></code></a> = "border";
  <a class="n" data-link-type="idl-name" href="#typedefdef-geometrynode"><c- n>GeometryNode</c-></a> <a data-type="GeometryNode " href="#dom-boxquadoptions-relativeto"><code><c- g>relativeTo</c-></code></a>; // XXX default document (i.e. viewport)
};

<c- b>dictionary</c-> <a href="#dictdef-convertcoordinateoptions"><code><c- g>ConvertCoordinateOptions</c-></code></a> {
  <a class="n" data-link-type="idl-name" href="#enumdef-cssboxtype"><c- n>CSSBoxType</c-></a> <a data-default="&quot;border&quot;" data-type="CSSBoxType " href="#dom-convertcoordinateoptions-frombox"><code><c- g>fromBox</c-></code></a> = "border";
  <a class="n" data-link-type="idl-name" href="#enumdef-cssboxtype"><c- n>CSSBoxType</c-></a> <a data-default="&quot;border&quot;" data-type="CSSBoxType " href="#dom-convertcoordinateoptions-tobox"><code><c- g>toBox</c-></code></a> = "border";
};

<c- b>interface</c-> <c- b>mixin</c-> <a href="#geometryutils"><code><c- g>GeometryUtils</c-></code></a> {
  <c- b>sequence</c->&lt;<a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domquad"><c- n>DOMQuad</c-></a>> <a class="idl-code" data-link-type="method" href="#dom-geometryutils-getboxquads"><c- g>getBoxQuads</c-></a>(<c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-boxquadoptions"><c- n>BoxQuadOptions</c-></a> <a href="#dom-geometryutils-getboxquads-options-options"><code><c- g>options</c-></code></a> = {});
  <a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domquad"><c- n>DOMQuad</c-></a> <a class="idl-code" data-link-type="method" href="#dom-geometryutils-convertquadfromnode"><c- g>convertQuadFromNode</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#dictdef-domquadinit"><c- n>DOMQuadInit</c-></a> <a href="#dom-geometryutils-convertquadfromnode-quad-from-options-quad"><code><c- g>quad</c-></code></a>, <a class="n" data-link-type="idl-name" href="#typedefdef-geometrynode"><c- n>GeometryNode</c-></a> <a href="#dom-geometryutils-convertquadfromnode-quad-from-options-from"><code><c- g>from</c-></code></a>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-convertcoordinateoptions"><c- n>ConvertCoordinateOptions</c-></a> <a href="#dom-geometryutils-convertquadfromnode-quad-from-options-options"><code><c- g>options</c-></code></a> = {});
  <a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domquad"><c- n>DOMQuad</c-></a> <a class="idl-code" data-link-type="method" href="#dom-geometryutils-convertrectfromnode"><c- g>convertRectFromNode</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#domrectreadonly"><c- n>DOMRectReadOnly</c-></a> <a href="#dom-geometryutils-convertrectfromnode-rect-from-options-rect"><code><c- g>rect</c-></code></a>, <a class="n" data-link-type="idl-name" href="#typedefdef-geometrynode"><c- n>GeometryNode</c-></a> <a href="#dom-geometryutils-convertrectfromnode-rect-from-options-from"><code><c- g>from</c-></code></a>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-convertcoordinateoptions"><c- n>ConvertCoordinateOptions</c-></a> <a href="#dom-geometryutils-convertrectfromnode-rect-from-options-options"><code><c- g>options</c-></code></a> = {});
  <a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#dompoint"><c- n>DOMPoint</c-></a> <a class="idl-code" data-link-type="method" href="#dom-geometryutils-convertpointfromnode"><c- g>convertPointFromNode</c-></a>(<a class="n" data-link-type="idl-name" href="https://drafts.fxtf.org/geometry-1/#dictdef-dompointinit"><c- n>DOMPointInit</c-></a> <a href="#dom-geometryutils-convertpointfromnode-point-from-options-point"><code><c- g>point</c-></code></a>, <a class="n" data-link-type="idl-name" href="#typedefdef-geometrynode"><c- n>GeometryNode</c-></a> <a href="#dom-geometryutils-convertpointfromnode-point-from-options-from"><code><c- g>from</c-></code></a>, <c- b>optional</c-> <a class="n" data-link-type="idl-name" href="#dictdef-convertcoordinateoptions"><c- n>ConvertCoordinateOptions</c-></a> <a href="#dom-geometryutils-convertpointfromnode-point-from-options-options"><code><c- g>options</c-></code></a> = {}); // XXX z,w turns into 0
};

<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#text"><c- n>Text</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#geometryutils"><c- n>GeometryUtils</c-></a>; // like Range
<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element"><c- n>Element</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#geometryutils"><c- n>GeometryUtils</c-></a>;
<a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/css-pseudo-4/#csspseudoelement"><c- n>CSSPseudoElement</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#geometryutils"><c- n>GeometryUtils</c-></a>;
<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#document"><c- n>Document</c-></a> <c- b>includes</c-> <a class="n" data-link-type="idl-name" href="#geometryutils"><c- n>GeometryUtils</c-></a>;

<c- b>typedef</c-> (<a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#text"><c- n>Text</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#element"><c- n>Element</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://drafts.csswg.org/css-pseudo-4/#csspseudoelement"><c- n>CSSPseudoElement</c-></a> <c- b>or</c-> <a class="n" data-link-type="idl-name" href="https://dom.spec.whatwg.org/#document"><c- n>Document</c-></a>) <a href="#typedefdef-geometrynode"><code><c- g>GeometryNode</c-></code></a>;

</pre>
  <h2 class="no-num no-ref heading settled" id="issues-index"><span class="content">Issues Index</span><a class="self-link" href="#issues-index"></a></h2>
  <div style="counter-reset:issue">
   <div class="issue">The terms <a data-link-type="dfn" href="#css-layout-box">CSS layout box</a> and <a data-link-type="dfn" href="#svg-layout-box">SVG layout box</a> are not currently defined by CSS or SVG. <a href="#issue-167dc25d"> ↵ </a></div>
   <div class="issue"> The object IDL fragment redefines some members. Can we resolve this somehow?<a href="#issue-6025106e"> ↵ </a></div>
   <div class="issue">
     DOM order 
    <p>p1 = top left even in RTL</p>
    <p>scale to 0 means divide by zero, return 0x0</p>
    <p>cross-frames not allowed, throw WrongDocumentError?</p>
    <p>points are flattened (3d transform), z=0. like getClientRect</p>
    <p>test block in inline</p>
    <p>pseudo-elements before/after are children of the element</p>
    <p>viewport boxes are all the same</p>
     <a href="#issue-33d3f260"> ↵ </a>
   </div>
   <div class="issue">... <a href="#issue-2f43b42f"> ↵ </a></div>
   <div class="issue">... <a href="#issue-2f43b42f①"> ↵ </a></div>
   <div class="issue">... <a href="#issue-2f43b42f②"> ↵ </a></div>
   <div class="issue"> The features in this section should be moved to some other specification.<a href="#issue-e12d69d6"> ↵ </a></div>
  </div>
  <aside class="dfn-panel" data-for="the-html-body-element">
   <b><a href="#the-html-body-element">#the-html-body-element</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-the-html-body-element">2. Terminology</a>
    <li><a href="#ref-for-the-html-body-element①">5. Extensions to the Document Interface</a> <a href="#ref-for-the-html-body-element②">(2)</a> <a href="#ref-for-the-html-body-element③">(3)</a> <a href="#ref-for-the-html-body-element④">(4)</a>
    <li><a href="#ref-for-the-html-body-element⑤">6. Extensions to the Element Interface</a> <a href="#ref-for-the-html-body-element⑥">(2)</a> <a href="#ref-for-the-html-body-element⑦">(3)</a> <a href="#ref-for-the-html-body-element⑧">(4)</a> <a href="#ref-for-the-html-body-element⑨">(5)</a> <a href="#ref-for-the-html-body-element①⓪">(6)</a> <a href="#ref-for-the-html-body-element①①">(7)</a> <a href="#ref-for-the-html-body-element①②">(8)</a> <a href="#ref-for-the-html-body-element①③">(9)</a>
    <li><a href="#ref-for-the-html-body-element①④">7. Extensions to the HTMLElement Interface</a> <a href="#ref-for-the-html-body-element①⑤">(2)</a> <a href="#ref-for-the-html-body-element①⑥">(3)</a> <a href="#ref-for-the-html-body-element①⑦">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="padding-edge">
   <b><a href="#padding-edge">#padding-edge</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-padding-edge">2. Terminology</a> <a href="#ref-for-padding-edge①">(2)</a> <a href="#ref-for-padding-edge②">(3)</a> <a href="#ref-for-padding-edge③">(4)</a> <a href="#ref-for-padding-edge④">(5)</a> <a href="#ref-for-padding-edge⑤">(6)</a> <a href="#ref-for-padding-edge⑥">(7)</a> <a href="#ref-for-padding-edge⑦">(8)</a> <a href="#ref-for-padding-edge⑧">(9)</a> <a href="#ref-for-padding-edge⑨">(10)</a> <a href="#ref-for-padding-edge①⓪">(11)</a> <a href="#ref-for-padding-edge①①">(12)</a> <a href="#ref-for-padding-edge①②">(13)</a> <a href="#ref-for-padding-edge①③">(14)</a> <a href="#ref-for-padding-edge①④">(15)</a> <a href="#ref-for-padding-edge①⑤">(16)</a>
    <li><a href="#ref-for-padding-edge①⑥">6. Extensions to the Element Interface</a> <a href="#ref-for-padding-edge①⑦">(2)</a> <a href="#ref-for-padding-edge①⑧">(3)</a> <a href="#ref-for-padding-edge①⑨">(4)</a> <a href="#ref-for-padding-edge②⓪">(5)</a> <a href="#ref-for-padding-edge②①">(6)</a> <a href="#ref-for-padding-edge②②">(7)</a> <a href="#ref-for-padding-edge②③">(8)</a>
    <li><a href="#ref-for-padding-edge②④">6.1. Element Scrolling Members</a> <a href="#ref-for-padding-edge②⑤">(2)</a> <a href="#ref-for-padding-edge②⑥">(3)</a> <a href="#ref-for-padding-edge②⑦">(4)</a>
    <li><a href="#ref-for-padding-edge②⑧">7. Extensions to the HTMLElement Interface</a> <a href="#ref-for-padding-edge②⑨">(2)</a>
    <li><a href="#ref-for-padding-edge③⓪">10. Extensions to the MouseEvent Interface</a> <a href="#ref-for-padding-edge③①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="border-edge">
   <b><a href="#border-edge">#border-edge</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-border-edge">6. Extensions to the Element Interface</a> <a href="#ref-for-border-edge①">(2)</a> <a href="#ref-for-border-edge②">(3)</a> <a href="#ref-for-border-edge③">(4)</a>
    <li><a href="#ref-for-border-edge④">7. Extensions to the HTMLElement Interface</a> <a href="#ref-for-border-edge⑤">(2)</a> <a href="#ref-for-border-edge⑥">(3)</a> <a href="#ref-for-border-edge⑦">(4)</a> <a href="#ref-for-border-edge⑧">(5)</a> <a href="#ref-for-border-edge⑨">(6)</a>
    <li><a href="#ref-for-border-edge①⓪">8. Extensions to the HTMLImageElement Interface</a> <a href="#ref-for-border-edge①①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="margin-edge">
   <b><a href="#margin-edge">#margin-edge</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-margin-edge">2. Terminology</a> <a href="#ref-for-margin-edge①">(2)</a> <a href="#ref-for-margin-edge②">(3)</a> <a href="#ref-for-margin-edge③">(4)</a> <a href="#ref-for-margin-edge④">(5)</a> <a href="#ref-for-margin-edge⑤">(6)</a> <a href="#ref-for-margin-edge⑥">(7)</a> <a href="#ref-for-margin-edge⑦">(8)</a> <a href="#ref-for-margin-edge⑧">(9)</a> <a href="#ref-for-margin-edge⑨">(10)</a> <a href="#ref-for-margin-edge①⓪">(11)</a> <a href="#ref-for-margin-edge①①">(12)</a> <a href="#ref-for-margin-edge①②">(13)</a> <a href="#ref-for-margin-edge①③">(14)</a> <a href="#ref-for-margin-edge①④">(15)</a> <a href="#ref-for-margin-edge①⑤">(16)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="viewport">
   <b><a href="#viewport">#viewport</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-viewport">2. Terminology</a> <a href="#ref-for-viewport①">(2)</a> <a href="#ref-for-viewport②">(3)</a> <a href="#ref-for-viewport③">(4)</a> <a href="#ref-for-viewport④">(5)</a> <a href="#ref-for-viewport⑤">(6)</a> <a href="#ref-for-viewport⑥">(7)</a> <a href="#ref-for-viewport⑦">(8)</a> <a href="#ref-for-viewport⑧">(9)</a> <a href="#ref-for-viewport⑨">(10)</a> <a href="#ref-for-viewport①⓪">(11)</a> <a href="#ref-for-viewport①①">(12)</a> <a href="#ref-for-viewport①②">(13)</a> <a href="#ref-for-viewport①③">(14)</a>
    <li><a href="#ref-for-viewport①④">2.3. Web-exposed screen information</a> <a href="#ref-for-viewport①⑤">(2)</a>
    <li><a href="#ref-for-viewport①⑥">3.1. Scrolling</a>
    <li><a href="#ref-for-viewport①⑦">4. Extensions to the Window Interface</a> <a href="#ref-for-viewport①⑧">(2)</a> <a href="#ref-for-viewport①⑨">(3)</a> <a href="#ref-for-viewport②⓪">(4)</a> <a href="#ref-for-viewport②①">(5)</a> <a href="#ref-for-viewport②②">(6)</a> <a href="#ref-for-viewport②③">(7)</a> <a href="#ref-for-viewport②④">(8)</a> <a href="#ref-for-viewport②⑤">(9)</a> <a href="#ref-for-viewport②⑥">(10)</a> <a href="#ref-for-viewport②⑦">(11)</a> <a href="#ref-for-viewport②⑧">(12)</a> <a href="#ref-for-viewport②⑨">(13)</a> <a href="#ref-for-viewport③⓪">(14)</a> <a href="#ref-for-viewport③①">(15)</a> <a href="#ref-for-viewport③②">(16)</a> <a href="#ref-for-viewport③③">(17)</a> <a href="#ref-for-viewport③④">(18)</a> <a href="#ref-for-viewport③⑤">(19)</a> <a href="#ref-for-viewport③⑥">(20)</a> <a href="#ref-for-viewport③⑦">(21)</a> <a href="#ref-for-viewport③⑧">(22)</a> <a href="#ref-for-viewport③⑨">(23)</a> <a href="#ref-for-viewport④⓪">(24)</a> <a href="#ref-for-viewport④①">(25)</a> <a href="#ref-for-viewport④②">(26)</a> <a href="#ref-for-viewport④③">(27)</a> <a href="#ref-for-viewport④④">(28)</a> <a href="#ref-for-viewport④⑤">(29)</a> <a href="#ref-for-viewport④⑥">(30)</a>
    <li><a href="#ref-for-viewport④⑦">5. Extensions to the Document Interface</a> <a href="#ref-for-viewport④⑧">(2)</a> <a href="#ref-for-viewport④⑨">(3)</a> <a href="#ref-for-viewport⑤⓪">(4)</a> <a href="#ref-for-viewport⑤①">(5)</a> <a href="#ref-for-viewport⑤②">(6)</a> <a href="#ref-for-viewport⑤③">(7)</a> <a href="#ref-for-viewport⑤④">(8)</a> <a href="#ref-for-viewport⑤⑤">(9)</a> <a href="#ref-for-viewport⑤⑥">(10)</a> <a href="#ref-for-viewport⑤⑦">(11)</a> <a href="#ref-for-viewport⑤⑧">(12)</a> <a href="#ref-for-viewport⑤⑨">(13)</a> <a href="#ref-for-viewport⑥⓪">(14)</a> <a href="#ref-for-viewport⑥①">(15)</a> <a href="#ref-for-viewport⑥②">(16)</a> <a href="#ref-for-viewport⑥③">(17)</a> <a href="#ref-for-viewport⑥④">(18)</a>
    <li><a href="#ref-for-viewport⑥⑤">6. Extensions to the Element Interface</a> <a href="#ref-for-viewport⑥⑥">(2)</a> <a href="#ref-for-viewport⑥⑦">(3)</a> <a href="#ref-for-viewport⑥⑧">(4)</a> <a href="#ref-for-viewport⑥⑨">(5)</a> <a href="#ref-for-viewport⑦⓪">(6)</a> <a href="#ref-for-viewport⑦①">(7)</a> <a href="#ref-for-viewport⑦②">(8)</a> <a href="#ref-for-viewport⑦③">(9)</a> <a href="#ref-for-viewport⑦④">(10)</a>
    <li><a href="#ref-for-viewport⑦⑤">6.1. Element Scrolling Members</a> <a href="#ref-for-viewport⑦⑥">(2)</a> <a href="#ref-for-viewport⑦⑦">(3)</a> <a href="#ref-for-viewport⑦⑧">(4)</a>
    <li><a href="#ref-for-viewport⑦⑨">10. Extensions to the MouseEvent Interface</a> <a href="#ref-for-viewport⑧⓪">(2)</a>
    <li><a href="#ref-for-viewport⑧①">12.1. Resizing viewports</a>
    <li><a href="#ref-for-viewport⑧②">12.2. Scrolling</a> <a href="#ref-for-viewport⑧③">(2)</a>
    <li><a href="#ref-for-viewport⑧④">12.3. Event summary</a> <a href="#ref-for-viewport⑧⑤">(2)</a>
    <li><a href="#ref-for-viewport⑧⑥">13.1. Smooth Scrolling: The scroll-behavior Property</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="scrolling-box">
   <b><a href="#scrolling-box">#scrolling-box</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-scrolling-box">2. Terminology</a> <a href="#ref-for-scrolling-box①">(2)</a> <a href="#ref-for-scrolling-box②">(3)</a>
    <li><a href="#ref-for-scrolling-box③">3.1. Scrolling</a> <a href="#ref-for-scrolling-box④">(2)</a> <a href="#ref-for-scrolling-box⑤">(3)</a>
    <li><a href="#ref-for-scrolling-box⑥">6. Extensions to the Element Interface</a> <a href="#ref-for-scrolling-box⑦">(2)</a> <a href="#ref-for-scrolling-box⑧">(3)</a>
    <li><a href="#ref-for-scrolling-box⑨">6.1. Element Scrolling Members</a> <a href="#ref-for-scrolling-box①⓪">(2)</a> <a href="#ref-for-scrolling-box①①">(3)</a>
    <li><a href="#ref-for-scrolling-box①②">13.1. Smooth Scrolling: The scroll-behavior Property</a> <a href="#ref-for-scrolling-box①③">(2)</a> <a href="#ref-for-scrolling-box①④">(3)</a> <a href="#ref-for-scrolling-box①⑤">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="potentially-scrollable">
   <b><a href="#potentially-scrollable">#potentially-scrollable</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-potentially-scrollable">2. Terminology</a>
    <li><a href="#ref-for-potentially-scrollable①">5. Extensions to the Document Interface</a>
    <li><a href="#ref-for-potentially-scrollable②">6. Extensions to the Element Interface</a> <a href="#ref-for-potentially-scrollable③">(2)</a> <a href="#ref-for-potentially-scrollable④">(3)</a> <a href="#ref-for-potentially-scrollable⑤">(4)</a> <a href="#ref-for-potentially-scrollable⑥">(5)</a> <a href="#ref-for-potentially-scrollable⑦">(6)</a> <a href="#ref-for-potentially-scrollable⑧">(7)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="overflow-directions">
   <b><a href="#overflow-directions">#overflow-directions</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-overflow-directions">2. Terminology</a> <a href="#ref-for-overflow-directions①">(2)</a> <a href="#ref-for-overflow-directions②">(3)</a> <a href="#ref-for-overflow-directions③">(4)</a> <a href="#ref-for-overflow-directions④">(5)</a> <a href="#ref-for-overflow-directions⑤">(6)</a> <a href="#ref-for-overflow-directions⑥">(7)</a> <a href="#ref-for-overflow-directions⑦">(8)</a> <a href="#ref-for-overflow-directions⑧">(9)</a> <a href="#ref-for-overflow-directions⑨">(10)</a>
    <li><a href="#ref-for-overflow-directions①⓪">4. Extensions to the Window Interface</a> <a href="#ref-for-overflow-directions①①">(2)</a> <a href="#ref-for-overflow-directions①②">(3)</a> <a href="#ref-for-overflow-directions①③">(4)</a>
    <li><a href="#ref-for-overflow-directions①④">6.1. Element Scrolling Members</a> <a href="#ref-for-overflow-directions①⑤">(2)</a> <a href="#ref-for-overflow-directions①⑥">(3)</a> <a href="#ref-for-overflow-directions①⑦">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="scrolling-area">
   <b><a href="#scrolling-area">#scrolling-area</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-scrolling-area">2. Terminology</a> <a href="#ref-for-scrolling-area①">(2)</a>
    <li><a href="#ref-for-scrolling-area②">3.1. Scrolling</a>
    <li><a href="#ref-for-scrolling-area③">4. Extensions to the Window Interface</a> <a href="#ref-for-scrolling-area④">(2)</a> <a href="#ref-for-scrolling-area⑤">(3)</a> <a href="#ref-for-scrolling-area⑥">(4)</a> <a href="#ref-for-scrolling-area⑦">(5)</a> <a href="#ref-for-scrolling-area⑧">(6)</a>
    <li><a href="#ref-for-scrolling-area⑨">6. Extensions to the Element Interface</a> <a href="#ref-for-scrolling-area①⓪">(2)</a> <a href="#ref-for-scrolling-area①①">(3)</a> <a href="#ref-for-scrolling-area①②">(4)</a> <a href="#ref-for-scrolling-area①③">(5)</a> <a href="#ref-for-scrolling-area①④">(6)</a> <a href="#ref-for-scrolling-area①⑤">(7)</a> <a href="#ref-for-scrolling-area①⑥">(8)</a>
    <li><a href="#ref-for-scrolling-area①⑦">6.1. Element Scrolling Members</a> <a href="#ref-for-scrolling-area①⑧">(2)</a> <a href="#ref-for-scrolling-area①⑨">(3)</a> <a href="#ref-for-scrolling-area②⓪">(4)</a> <a href="#ref-for-scrolling-area②①">(5)</a> <a href="#ref-for-scrolling-area②②">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="beginning-edges">
   <b><a href="#beginning-edges">#beginning-edges</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-beginning-edges">3.1. Scrolling</a> <a href="#ref-for-beginning-edges①">(2)</a>
    <li><a href="#ref-for-beginning-edges②">6.1. Element Scrolling Members</a> <a href="#ref-for-beginning-edges③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="ending-edges">
   <b><a href="#ending-edges">#ending-edges</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-ending-edges">6.1. Element Scrolling Members</a> <a href="#ref-for-ending-edges①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="css-layout-box">
   <b><a href="#css-layout-box">#css-layout-box</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-css-layout-box">2. Terminology</a> <a href="#ref-for-css-layout-box①">(2)</a> <a href="#ref-for-css-layout-box②">(3)</a> <a href="#ref-for-css-layout-box③">(4)</a>
    <li><a href="#ref-for-css-layout-box④">6. Extensions to the Element Interface</a> <a href="#ref-for-css-layout-box⑤">(2)</a> <a href="#ref-for-css-layout-box⑥">(3)</a> <a href="#ref-for-css-layout-box⑦">(4)</a> <a href="#ref-for-css-layout-box⑧">(5)</a> <a href="#ref-for-css-layout-box⑨">(6)</a> <a href="#ref-for-css-layout-box①⓪">(7)</a> <a href="#ref-for-css-layout-box①①">(8)</a> <a href="#ref-for-css-layout-box①②">(9)</a> <a href="#ref-for-css-layout-box①③">(10)</a> <a href="#ref-for-css-layout-box①④">(11)</a> <a href="#ref-for-css-layout-box①⑤">(12)</a> <a href="#ref-for-css-layout-box①⑥">(13)</a> <a href="#ref-for-css-layout-box①⑦">(14)</a> <a href="#ref-for-css-layout-box①⑧">(15)</a>
    <li><a href="#ref-for-css-layout-box①⑨">7. Extensions to the HTMLElement Interface</a> <a href="#ref-for-css-layout-box②⓪">(2)</a> <a href="#ref-for-css-layout-box②①">(3)</a> <a href="#ref-for-css-layout-box②②">(4)</a> <a href="#ref-for-css-layout-box②③">(5)</a> <a href="#ref-for-css-layout-box②④">(6)</a> <a href="#ref-for-css-layout-box②⑤">(7)</a> <a href="#ref-for-css-layout-box②⑥">(8)</a> <a href="#ref-for-css-layout-box②⑦">(9)</a> <a href="#ref-for-css-layout-box②⑧">(10)</a> <a href="#ref-for-css-layout-box②⑨">(11)</a> <a href="#ref-for-css-layout-box③⓪">(12)</a> <a href="#ref-for-css-layout-box③①">(13)</a> <a href="#ref-for-css-layout-box③②">(14)</a>
    <li><a href="#ref-for-css-layout-box③③">8. Extensions to the HTMLImageElement Interface</a> <a href="#ref-for-css-layout-box③④">(2)</a> <a href="#ref-for-css-layout-box③⑤">(3)</a> <a href="#ref-for-css-layout-box③⑥">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="svg-layout-box">
   <b><a href="#svg-layout-box">#svg-layout-box</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-svg-layout-box">2. Terminology</a> <a href="#ref-for-svg-layout-box①">(2)</a>
    <li><a href="#ref-for-svg-layout-box②">6. Extensions to the Element Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="layout-box">
   <b><a href="#layout-box">#layout-box</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-layout-box">5. Extensions to the Document Interface</a> <a href="#ref-for-layout-box①">(2)</a>
    <li><a href="#ref-for-layout-box②">6. Extensions to the Element Interface</a> <a href="#ref-for-layout-box③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="transforms">
   <b><a href="#transforms">#transforms</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-transforms">5. Extensions to the Document Interface</a> <a href="#ref-for-transforms①">(2)</a> <a href="#ref-for-transforms②">(3)</a> <a href="#ref-for-transforms③">(4)</a> <a href="#ref-for-transforms④">(5)</a>
    <li><a href="#ref-for-transforms⑤">5.1. The CaretPosition Interface</a>
    <li><a href="#ref-for-transforms⑥">6. Extensions to the Element Interface</a> <a href="#ref-for-transforms⑦">(2)</a> <a href="#ref-for-transforms⑧">(3)</a> <a href="#ref-for-transforms⑨">(4)</a> <a href="#ref-for-transforms①⓪">(5)</a> <a href="#ref-for-transforms①①">(6)</a>
    <li><a href="#ref-for-transforms①②">7. Extensions to the HTMLElement Interface</a> <a href="#ref-for-transforms①③">(2)</a> <a href="#ref-for-transforms①④">(3)</a> <a href="#ref-for-transforms①⑤">(4)</a> <a href="#ref-for-transforms①⑥">(5)</a> <a href="#ref-for-transforms①⑦">(6)</a>
    <li><a href="#ref-for-transforms①⑧">8. Extensions to the HTMLImageElement Interface</a> <a href="#ref-for-transforms①⑨">(2)</a>
    <li><a href="#ref-for-transforms②⓪">9. Extensions to the Range Interface</a>
    <li><a href="#ref-for-transforms②①">10. Extensions to the MouseEvent Interface</a> <a href="#ref-for-transforms②②">(2)</a>
    <li><a href="#ref-for-transforms②③">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="page-zoom">
   <b><a href="#page-zoom">#page-zoom</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-page-zoom">4. Extensions to the Window Interface</a>
    <li><a href="#ref-for-page-zoom①">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="pinch-zoom">
   <b><a href="#pinch-zoom">#pinch-zoom</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-pinch-zoom">4. Extensions to the Window Interface</a>
    <li><a href="#ref-for-pinch-zoom①">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="web-exposed-screen-area">
   <b><a href="#web-exposed-screen-area">#web-exposed-screen-area</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-web-exposed-screen-area">4. Extensions to the Window Interface</a> <a href="#ref-for-web-exposed-screen-area①">(2)</a>
    <li><a href="#ref-for-web-exposed-screen-area②">4.1. The features argument to the open() method</a> <a href="#ref-for-web-exposed-screen-area③">(2)</a>
    <li><a href="#ref-for-web-exposed-screen-area④">4.3. The Screen Interface</a> <a href="#ref-for-web-exposed-screen-area⑤">(2)</a>
    <li><a href="#ref-for-web-exposed-screen-area⑥">10. Extensions to the MouseEvent Interface</a> <a href="#ref-for-web-exposed-screen-area⑦">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="web-exposed-available-screen-area">
   <b><a href="#web-exposed-available-screen-area">#web-exposed-available-screen-area</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-web-exposed-available-screen-area">4.1. The features argument to the open() method</a> <a href="#ref-for-web-exposed-available-screen-area①">(2)</a> <a href="#ref-for-web-exposed-available-screen-area②">(3)</a> <a href="#ref-for-web-exposed-available-screen-area③">(4)</a> <a href="#ref-for-web-exposed-available-screen-area④">(5)</a> <a href="#ref-for-web-exposed-available-screen-area⑤">(6)</a>
    <li><a href="#ref-for-web-exposed-available-screen-area⑥">4.3. The Screen Interface</a> <a href="#ref-for-web-exposed-available-screen-area⑦">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="perform-a-scroll">
   <b><a href="#perform-a-scroll">#perform-a-scroll</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-perform-a-scroll">3.1. Scrolling</a>
    <li><a href="#ref-for-perform-a-scroll①">4. Extensions to the Window Interface</a>
    <li><a href="#ref-for-perform-a-scroll②">6.1. Element Scrolling Members</a> <a href="#ref-for-perform-a-scroll③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-smooth-scroll">
   <b><a href="#concept-smooth-scroll">#concept-smooth-scroll</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-smooth-scroll">3.1. Scrolling</a> <a href="#ref-for-concept-smooth-scroll①">(2)</a> <a href="#ref-for-concept-smooth-scroll②">(3)</a>
    <li><a href="#ref-for-concept-smooth-scroll③">4. Extensions to the Window Interface</a>
    <li><a href="#ref-for-concept-smooth-scroll④">6.1. Element Scrolling Members</a> <a href="#ref-for-concept-smooth-scroll⑤">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="smooth-scroll-aborted">
   <b><a href="#smooth-scroll-aborted">#smooth-scroll-aborted</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-smooth-scroll-aborted">3.1. Scrolling</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="concept-instant-scroll">
   <b><a href="#concept-instant-scroll">#concept-instant-scroll</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-concept-instant-scroll">3.1. Scrolling</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="normalize-non-finite-values">
   <b><a href="#normalize-non-finite-values">#normalize-non-finite-values</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-normalize-non-finite-values">4. Extensions to the Window Interface</a> <a href="#ref-for-normalize-non-finite-values①">(2)</a>
    <li><a href="#ref-for-normalize-non-finite-values②">6. Extensions to the Element Interface</a> <a href="#ref-for-normalize-non-finite-values③">(2)</a> <a href="#ref-for-normalize-non-finite-values④">(3)</a> <a href="#ref-for-normalize-non-finite-values⑤">(4)</a> <a href="#ref-for-normalize-non-finite-values⑥">(5)</a> <a href="#ref-for-normalize-non-finite-values⑦">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="enumdef-scrollbehavior">
   <b><a href="#enumdef-scrollbehavior">#enumdef-scrollbehavior</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-enumdef-scrollbehavior">4. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-scrolloptions">
   <b><a href="#dictdef-scrolloptions">#dictdef-scrolloptions</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-scrolloptions">4. Extensions to the Window Interface</a>
    <li><a href="#ref-for-dictdef-scrolloptions①">6. Extensions to the Element Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-scrolloptions-behavior">
   <b><a href="#dom-scrolloptions-behavior">#dom-scrolloptions-behavior</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-scrolloptions-behavior">4. Extensions to the Window Interface</a>
    <li><a href="#ref-for-dom-scrolloptions-behavior①">6. Extensions to the Element Interface</a> <a href="#ref-for-dom-scrolloptions-behavior②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-scrolltooptions">
   <b><a href="#dictdef-scrolltooptions">#dictdef-scrolltooptions</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-scrolltooptions">4. Extensions to the Window Interface</a> <a href="#ref-for-dictdef-scrolltooptions①">(2)</a> <a href="#ref-for-dictdef-scrolltooptions②">(3)</a> <a href="#ref-for-dictdef-scrolltooptions③">(4)</a> <a href="#ref-for-dictdef-scrolltooptions④">(5)</a>
    <li><a href="#ref-for-dictdef-scrolltooptions⑤">6. Extensions to the Element Interface</a> <a href="#ref-for-dictdef-scrolltooptions⑥">(2)</a> <a href="#ref-for-dictdef-scrolltooptions⑦">(3)</a> <a href="#ref-for-dictdef-scrolltooptions⑧">(4)</a> <a href="#ref-for-dictdef-scrolltooptions⑨">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-scrolltooptions-left">
   <b><a href="#dom-scrolltooptions-left">#dom-scrolltooptions-left</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-scrolltooptions-left">4. Extensions to the Window Interface</a> <a href="#ref-for-dom-scrolltooptions-left①">(2)</a> <a href="#ref-for-dom-scrolltooptions-left②">(3)</a> <a href="#ref-for-dom-scrolltooptions-left③">(4)</a>
    <li><a href="#ref-for-dom-scrolltooptions-left④">6. Extensions to the Element Interface</a> <a href="#ref-for-dom-scrolltooptions-left⑤">(2)</a> <a href="#ref-for-dom-scrolltooptions-left⑥">(3)</a> <a href="#ref-for-dom-scrolltooptions-left⑦">(4)</a> <a href="#ref-for-dom-scrolltooptions-left⑧">(5)</a> <a href="#ref-for-dom-scrolltooptions-left⑨">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-scrolltooptions-top">
   <b><a href="#dom-scrolltooptions-top">#dom-scrolltooptions-top</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-scrolltooptions-top">4. Extensions to the Window Interface</a> <a href="#ref-for-dom-scrolltooptions-top①">(2)</a> <a href="#ref-for-dom-scrolltooptions-top②">(3)</a> <a href="#ref-for-dom-scrolltooptions-top③">(4)</a>
    <li><a href="#ref-for-dom-scrolltooptions-top④">6. Extensions to the Element Interface</a> <a href="#ref-for-dom-scrolltooptions-top⑤">(2)</a> <a href="#ref-for-dom-scrolltooptions-top⑥">(3)</a> <a href="#ref-for-dom-scrolltooptions-top⑦">(4)</a> <a href="#ref-for-dom-scrolltooptions-top⑧">(5)</a> <a href="#ref-for-dom-scrolltooptions-top⑨">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-matchmedia">
   <b><a href="#dom-window-matchmedia">#dom-window-matchmedia</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-matchmedia">2.1. CSS pixels</a>
    <li><a href="#ref-for-dom-window-matchmedia①">4. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-screen">
   <b><a href="#dom-window-screen">#dom-window-screen</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-screen">4. Extensions to the Window Interface</a> <a href="#ref-for-dom-window-screen①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-moveto">
   <b><a href="#dom-window-moveto">#dom-window-moveto</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-moveto">4. Extensions to the Window Interface</a>
    <li><a href="#ref-for-dom-window-moveto①">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-moveby">
   <b><a href="#dom-window-moveby">#dom-window-moveby</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-moveby">4. Extensions to the Window Interface</a>
    <li><a href="#ref-for-dom-window-moveby①">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-resizeto">
   <b><a href="#dom-window-resizeto">#dom-window-resizeto</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-resizeto">4. Extensions to the Window Interface</a>
    <li><a href="#ref-for-dom-window-resizeto①">Changes From 31 January 2020</a>
    <li><a href="#ref-for-dom-window-resizeto②">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-resizeby">
   <b><a href="#dom-window-resizeby">#dom-window-resizeby</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-resizeby">4. Extensions to the Window Interface</a>
    <li><a href="#ref-for-dom-window-resizeby①">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="allowed-to-resize-and-move">
   <b><a href="#allowed-to-resize-and-move">#allowed-to-resize-and-move</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-allowed-to-resize-and-move">4. Extensions to the Window Interface</a> <a href="#ref-for-allowed-to-resize-and-move①">(2)</a> <a href="#ref-for-allowed-to-resize-and-move②">(3)</a> <a href="#ref-for-allowed-to-resize-and-move③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-innerwidth">
   <b><a href="#dom-window-innerwidth">#dom-window-innerwidth</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-innerwidth">4. Extensions to the Window Interface</a>
    <li><a href="#ref-for-dom-window-innerwidth①">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-innerheight">
   <b><a href="#dom-window-innerheight">#dom-window-innerheight</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-innerheight">4. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-scrollx">
   <b><a href="#dom-window-scrollx">#dom-window-scrollx</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-scrollx">4. Extensions to the Window Interface</a> <a href="#ref-for-dom-window-scrollx①">(2)</a> <a href="#ref-for-dom-window-scrollx②">(3)</a>
    <li><a href="#ref-for-dom-window-scrollx③">6. Extensions to the Element Interface</a> <a href="#ref-for-dom-window-scrollx④">(2)</a> <a href="#ref-for-dom-window-scrollx⑤">(3)</a> <a href="#ref-for-dom-window-scrollx⑥">(4)</a> <a href="#ref-for-dom-window-scrollx⑦">(5)</a>
    <li><a href="#ref-for-dom-window-scrollx⑧">10. Extensions to the MouseEvent Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-pagexoffset">
   <b><a href="#dom-window-pagexoffset">#dom-window-pagexoffset</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-pagexoffset">4. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-scrolly">
   <b><a href="#dom-window-scrolly">#dom-window-scrolly</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-scrolly">4. Extensions to the Window Interface</a> <a href="#ref-for-dom-window-scrolly①">(2)</a> <a href="#ref-for-dom-window-scrolly②">(3)</a>
    <li><a href="#ref-for-dom-window-scrolly③">6. Extensions to the Element Interface</a> <a href="#ref-for-dom-window-scrolly④">(2)</a> <a href="#ref-for-dom-window-scrolly⑤">(3)</a> <a href="#ref-for-dom-window-scrolly⑥">(4)</a>
    <li><a href="#ref-for-dom-window-scrolly⑦">10. Extensions to the MouseEvent Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-pageyoffset">
   <b><a href="#dom-window-pageyoffset">#dom-window-pageyoffset</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-pageyoffset">4. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-scroll">
   <b><a href="#dom-window-scroll">#dom-window-scroll</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-scroll">4. Extensions to the Window Interface</a> <a href="#ref-for-dom-window-scroll①">(2)</a> <a href="#ref-for-dom-window-scroll②">(3)</a> <a href="#ref-for-dom-window-scroll③">(4)</a>
    <li><a href="#ref-for-dom-window-scroll④">6. Extensions to the Element Interface</a> <a href="#ref-for-dom-window-scroll⑤">(2)</a> <a href="#ref-for-dom-window-scroll⑥">(3)</a> <a href="#ref-for-dom-window-scroll⑦">(4)</a> <a href="#ref-for-dom-window-scroll⑧">(5)</a> <a href="#ref-for-dom-window-scroll⑨">(6)</a>
    <li><a href="#ref-for-dom-window-scroll①⓪">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-scrollto">
   <b><a href="#dom-window-scrollto">#dom-window-scrollto</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-scrollto">4. Extensions to the Window Interface</a> <a href="#ref-for-dom-window-scrollto①">(2)</a>
    <li><a href="#ref-for-dom-window-scrollto②">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-scrollby">
   <b><a href="#dom-window-scrollby">#dom-window-scrollby</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-scrollby">4. Extensions to the Window Interface</a> <a href="#ref-for-dom-window-scrollby①">(2)</a>
    <li><a href="#ref-for-dom-window-scrollby②">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-screenx">
   <b><a href="#dom-window-screenx">#dom-window-screenx</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-screenx">4. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-screenleft">
   <b><a href="#dom-window-screenleft">#dom-window-screenleft</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-screenleft">4. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-screeny">
   <b><a href="#dom-window-screeny">#dom-window-screeny</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-screeny">4. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-screentop">
   <b><a href="#dom-window-screentop">#dom-window-screentop</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-screentop">4. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-outerwidth">
   <b><a href="#dom-window-outerwidth">#dom-window-outerwidth</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-outerwidth">4. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-outerheight">
   <b><a href="#dom-window-outerheight">#dom-window-outerheight</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-outerheight">4. Extensions to the Window Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-window-devicepixelratio">
   <b><a href="#dom-window-devicepixelratio">#dom-window-devicepixelratio</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-window-devicepixelratio">4. Extensions to the Window Interface</a>
    <li><a href="#ref-for-dom-window-devicepixelratio①">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="supported-open-feature-name-width">
   <b><a href="#supported-open-feature-name-width">#supported-open-feature-name-width</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-supported-open-feature-name-width">4.1. The features argument to the open() method</a> <a href="#ref-for-supported-open-feature-name-width①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="supported-open-feature-name-height">
   <b><a href="#supported-open-feature-name-height">#supported-open-feature-name-height</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-supported-open-feature-name-height">4.1. The features argument to the open() method</a> <a href="#ref-for-supported-open-feature-name-height①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="supported-open-feature-name-left">
   <b><a href="#supported-open-feature-name-left">#supported-open-feature-name-left</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-supported-open-feature-name-left">4.1. The features argument to the open() method</a> <a href="#ref-for-supported-open-feature-name-left①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="supported-open-feature-name-top">
   <b><a href="#supported-open-feature-name-top">#supported-open-feature-name-top</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-supported-open-feature-name-top">4.1. The features argument to the open() method</a> <a href="#ref-for-supported-open-feature-name-top①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="media-query-list">
   <b><a href="#media-query-list">#media-query-list</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-media-query-list">4. Extensions to the Window Interface</a>
    <li><a href="#ref-for-media-query-list①">4.2. The MediaQueryList Interface</a> <a href="#ref-for-media-query-list②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="mediaquerylist-document">
   <b><a href="#mediaquerylist-document">#mediaquerylist-document</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediaquerylist-document">4. Extensions to the Window Interface</a>
    <li><a href="#ref-for-mediaquerylist-document①">4.2. The MediaQueryList Interface</a> <a href="#ref-for-mediaquerylist-document②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="mediaquerylist-media">
   <b><a href="#mediaquerylist-media">#mediaquerylist-media</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediaquerylist-media">4.2. The MediaQueryList Interface</a> <a href="#ref-for-mediaquerylist-media①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="mediaquerylist-matches-state">
   <b><a href="#mediaquerylist-matches-state">#mediaquerylist-matches-state</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediaquerylist-matches-state">4.2. The MediaQueryList Interface</a> <a href="#ref-for-mediaquerylist-matches-state①">(2)</a> <a href="#ref-for-mediaquerylist-matches-state②">(3)</a>
    <li><a href="#ref-for-mediaquerylist-matches-state③">4.2.1. Event summary</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="mediaquerylist">
   <b><a href="#mediaquerylist">#mediaquerylist</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediaquerylist">4. Extensions to the Window Interface</a> <a href="#ref-for-mediaquerylist①">(2)</a>
    <li><a href="#ref-for-mediaquerylist②">4.2. The MediaQueryList Interface</a> <a href="#ref-for-mediaquerylist③">(2)</a> <a href="#ref-for-mediaquerylist④">(3)</a> <a href="#ref-for-mediaquerylist⑤">(4)</a> <a href="#ref-for-mediaquerylist⑥">(5)</a> <a href="#ref-for-mediaquerylist⑦">(6)</a> <a href="#ref-for-mediaquerylist⑧">(7)</a>
    <li><a href="#ref-for-mediaquerylist⑨">4.2.1. Event summary</a> <a href="#ref-for-mediaquerylist①⓪">(2)</a>
    <li><a href="#ref-for-mediaquerylist①①">Changes From 17 December 2013 To 31 January 2020</a> <a href="#ref-for-mediaquerylist①②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediaquerylist-media">
   <b><a href="#dom-mediaquerylist-media">#dom-mediaquerylist-media</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediaquerylist-media">4.2. The MediaQueryList Interface</a> <a href="#ref-for-dom-mediaquerylist-media①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediaquerylist-matches">
   <b><a href="#dom-mediaquerylist-matches">#dom-mediaquerylist-matches</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediaquerylist-matches">4.2. The MediaQueryList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediaquerylist-addlistener">
   <b><a href="#dom-mediaquerylist-addlistener">#dom-mediaquerylist-addlistener</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediaquerylist-addlistener">4.2. The MediaQueryList Interface</a> <a href="#ref-for-dom-mediaquerylist-addlistener①">(2)</a> <a href="#ref-for-dom-mediaquerylist-addlistener②">(3)</a>
    <li><a href="#ref-for-dom-mediaquerylist-addlistener③">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediaquerylist-removelistener">
   <b><a href="#dom-mediaquerylist-removelistener">#dom-mediaquerylist-removelistener</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediaquerylist-removelistener">4.2. The MediaQueryList Interface</a> <a href="#ref-for-dom-mediaquerylist-removelistener①">(2)</a> <a href="#ref-for-dom-mediaquerylist-removelistener②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediaquerylist-onchange">
   <b><a href="#dom-mediaquerylist-onchange">#dom-mediaquerylist-onchange</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediaquerylist-onchange">4.2. The MediaQueryList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="mediaquerylistevent">
   <b><a href="#mediaquerylistevent">#mediaquerylistevent</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-mediaquerylistevent">4.2. The MediaQueryList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-mediaquerylisteventinit">
   <b><a href="#dictdef-mediaquerylisteventinit">#dictdef-mediaquerylisteventinit</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-mediaquerylisteventinit">4.2. The MediaQueryList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediaquerylistevent-media">
   <b><a href="#dom-mediaquerylistevent-media">#dom-mediaquerylistevent-media</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediaquerylistevent-media">4.2. The MediaQueryList Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mediaquerylistevent-matches">
   <b><a href="#dom-mediaquerylistevent-matches">#dom-mediaquerylistevent-matches</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mediaquerylistevent-matches">4.2. The MediaQueryList Interface</a> <a href="#ref-for-dom-mediaquerylistevent-matches①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="eventdef-mediaquerylist-change">
   <b><a href="#eventdef-mediaquerylist-change">#eventdef-mediaquerylist-change</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventdef-mediaquerylist-change">4.2. The MediaQueryList Interface</a> <a href="#ref-for-eventdef-mediaquerylist-change①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="screen">
   <b><a href="#screen">#screen</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-screen">4. Extensions to the Window Interface</a> <a href="#ref-for-screen①">(2)</a>
    <li><a href="#ref-for-screen②">4.3. The Screen Interface</a> <a href="#ref-for-screen③">(2)</a>
    <li><a href="#ref-for-screen④">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-screen-availwidth">
   <b><a href="#dom-screen-availwidth">#dom-screen-availwidth</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-screen-availwidth">4.3. The Screen Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-screen-availheight">
   <b><a href="#dom-screen-availheight">#dom-screen-availheight</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-screen-availheight">4.3. The Screen Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-screen-width">
   <b><a href="#dom-screen-width">#dom-screen-width</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-screen-width">4.3. The Screen Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-screen-height">
   <b><a href="#dom-screen-height">#dom-screen-height</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-screen-height">4.3. The Screen Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-screen-colordepth">
   <b><a href="#dom-screen-colordepth">#dom-screen-colordepth</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-screen-colordepth">4.3. The Screen Interface</a> <a href="#ref-for-dom-screen-colordepth①">(2)</a>
    <li><a href="#ref-for-dom-screen-colordepth②">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-screen-pixeldepth">
   <b><a href="#dom-screen-pixeldepth">#dom-screen-pixeldepth</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-screen-pixeldepth">4.3. The Screen Interface</a> <a href="#ref-for-dom-screen-pixeldepth①">(2)</a>
    <li><a href="#ref-for-dom-screen-pixeldepth②">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-document-elementfrompoint">
   <b><a href="#dom-document-elementfrompoint">#dom-document-elementfrompoint</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-document-elementfrompoint">5. Extensions to the Document Interface</a> <a href="#ref-for-dom-document-elementfrompoint①">(2)</a> <a href="#ref-for-dom-document-elementfrompoint②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-document-elementsfrompoint">
   <b><a href="#dom-document-elementsfrompoint">#dom-document-elementsfrompoint</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-document-elementsfrompoint">5. Extensions to the Document Interface</a>
    <li><a href="#ref-for-dom-document-elementsfrompoint①">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-document-caretpositionfrompoint">
   <b><a href="#dom-document-caretpositionfrompoint">#dom-document-caretpositionfrompoint</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-document-caretpositionfrompoint">5. Extensions to the Document Interface</a> <a href="#ref-for-dom-document-caretpositionfrompoint①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-document-scrollingelement">
   <b><a href="#dom-document-scrollingelement">#dom-document-scrollingelement</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-document-scrollingelement">5. Extensions to the Document Interface</a> <a href="#ref-for-dom-document-scrollingelement①">(2)</a>
    <li><a href="#ref-for-dom-document-scrollingelement②">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="caret-position">
   <b><a href="#caret-position">#caret-position</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-caret-position">5. Extensions to the Document Interface</a> <a href="#ref-for-caret-position①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="caret-node">
   <b><a href="#caret-node">#caret-node</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-caret-node">5. Extensions to the Document Interface</a> <a href="#ref-for-caret-node①">(2)</a>
    <li><a href="#ref-for-caret-node②">5.1. The CaretPosition Interface</a> <a href="#ref-for-caret-node③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="caret-offset">
   <b><a href="#caret-offset">#caret-offset</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-caret-offset">5. Extensions to the Document Interface</a> <a href="#ref-for-caret-offset①">(2)</a>
    <li><a href="#ref-for-caret-offset②">5.1. The CaretPosition Interface</a> <a href="#ref-for-caret-offset③">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="caret-range">
   <b><a href="#caret-range">#caret-range</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-caret-range">5. Extensions to the Document Interface</a> <a href="#ref-for-caret-range①">(2)</a> <a href="#ref-for-caret-range②">(3)</a> <a href="#ref-for-caret-range③">(4)</a>
    <li><a href="#ref-for-caret-range④">5.1. The CaretPosition Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="caretposition">
   <b><a href="#caretposition">#caretposition</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-caretposition">5. Extensions to the Document Interface</a>
    <li><a href="#ref-for-caretposition①">5.1. The CaretPosition Interface</a> <a href="#ref-for-caretposition②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-caretposition-offsetnode">
   <b><a href="#dom-caretposition-offsetnode">#dom-caretposition-offsetnode</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-caretposition-offsetnode">5.1. The CaretPosition Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-caretposition-offset">
   <b><a href="#dom-caretposition-offset">#dom-caretposition-offset</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-caretposition-offset">5.1. The CaretPosition Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-caretposition-getclientrect">
   <b><a href="#dom-caretposition-getclientrect">#dom-caretposition-getclientrect</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-caretposition-getclientrect">5.1. The CaretPosition Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="enumdef-scrolllogicalposition">
   <b><a href="#enumdef-scrolllogicalposition">#enumdef-scrolllogicalposition</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-enumdef-scrolllogicalposition">6. Extensions to the Element Interface</a> <a href="#ref-for-enumdef-scrolllogicalposition①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-scrollintoviewoptions">
   <b><a href="#dictdef-scrollintoviewoptions">#dictdef-scrollintoviewoptions</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-scrollintoviewoptions">6. Extensions to the Element Interface</a> <a href="#ref-for-dictdef-scrollintoviewoptions①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-scrollintoviewoptions-block">
   <b><a href="#dom-scrollintoviewoptions-block">#dom-scrollintoviewoptions-block</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-scrollintoviewoptions-block">6. Extensions to the Element Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-scrollintoviewoptions-inline">
   <b><a href="#dom-scrollintoviewoptions-inline">#dom-scrollintoviewoptions-inline</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-scrollintoviewoptions-inline">6. Extensions to the Element Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-element-getclientrects">
   <b><a href="#dom-element-getclientrects">#dom-element-getclientrects</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-element-getclientrects">6. Extensions to the Element Interface</a> <a href="#ref-for-dom-element-getclientrects①">(2)</a> <a href="#ref-for-dom-element-getclientrects②">(3)</a>
    <li><a href="#ref-for-dom-element-getclientrects③">9. Extensions to the Range Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-element-getboundingclientrect">
   <b><a href="#dom-element-getboundingclientrect">#dom-element-getboundingclientrect</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-element-getboundingclientrect">6. Extensions to the Element Interface</a> <a href="#ref-for-dom-element-getboundingclientrect①">(2)</a>
    <li><a href="#ref-for-dom-element-getboundingclientrect②">6.1. Element Scrolling Members</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-element-scrollintoview">
   <b><a href="#dom-element-scrollintoview">#dom-element-scrollintoview</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-element-scrollintoview">6. Extensions to the Element Interface</a>
    <li><a href="#ref-for-dom-element-scrollintoview①">Changes From 17 December 2013 To 31 January 2020</a> <a href="#ref-for-dom-element-scrollintoview②">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-element-scroll">
   <b><a href="#dom-element-scroll">#dom-element-scroll</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-element-scroll">6. Extensions to the Element Interface</a> <a href="#ref-for-dom-element-scroll①">(2)</a> <a href="#ref-for-dom-element-scroll②">(3)</a> <a href="#ref-for-dom-element-scroll③">(4)</a>
    <li><a href="#ref-for-dom-element-scroll④">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-element-scrollto">
   <b><a href="#dom-element-scrollto">#dom-element-scrollto</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-element-scrollto">6. Extensions to the Element Interface</a> <a href="#ref-for-dom-element-scrollto①">(2)</a>
    <li><a href="#ref-for-dom-element-scrollto②">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-element-scrollby">
   <b><a href="#dom-element-scrollby">#dom-element-scrollby</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-element-scrollby">6. Extensions to the Element Interface</a> <a href="#ref-for-dom-element-scrollby①">(2)</a>
    <li><a href="#ref-for-dom-element-scrollby②">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-element-scrolltop">
   <b><a href="#dom-element-scrolltop">#dom-element-scrolltop</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-element-scrolltop">5. Extensions to the Document Interface</a>
    <li><a href="#ref-for-dom-element-scrolltop①">6. Extensions to the Element Interface</a> <a href="#ref-for-dom-element-scrolltop②">(2)</a> <a href="#ref-for-dom-element-scrolltop③">(3)</a> <a href="#ref-for-dom-element-scrolltop④">(4)</a>
    <li><a href="#ref-for-dom-element-scrolltop⑤">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-element-scrollleft">
   <b><a href="#dom-element-scrollleft">#dom-element-scrollleft</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-element-scrollleft">5. Extensions to the Document Interface</a>
    <li><a href="#ref-for-dom-element-scrollleft①">6. Extensions to the Element Interface</a> <a href="#ref-for-dom-element-scrollleft②">(2)</a> <a href="#ref-for-dom-element-scrollleft③">(3)</a> <a href="#ref-for-dom-element-scrollleft④">(4)</a>
    <li><a href="#ref-for-dom-element-scrollleft⑤">Changes From 17 December 2013 To 31 January 2020</a> <a href="#ref-for-dom-element-scrollleft⑥">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-element-scrollwidth">
   <b><a href="#dom-element-scrollwidth">#dom-element-scrollwidth</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-element-scrollwidth">6. Extensions to the Element Interface</a>
    <li><a href="#ref-for-dom-element-scrollwidth①">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-element-scrollheight">
   <b><a href="#dom-element-scrollheight">#dom-element-scrollheight</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-element-scrollheight">6. Extensions to the Element Interface</a>
    <li><a href="#ref-for-dom-element-scrollheight①">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-element-clienttop">
   <b><a href="#dom-element-clienttop">#dom-element-clienttop</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-element-clienttop">6. Extensions to the Element Interface</a>
    <li><a href="#ref-for-dom-element-clienttop①">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-element-clientleft">
   <b><a href="#dom-element-clientleft">#dom-element-clientleft</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-element-clientleft">6. Extensions to the Element Interface</a>
    <li><a href="#ref-for-dom-element-clientleft①">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-element-clientwidth">
   <b><a href="#dom-element-clientwidth">#dom-element-clientwidth</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-element-clientwidth">6. Extensions to the Element Interface</a>
    <li><a href="#ref-for-dom-element-clientwidth①">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-element-clientheight">
   <b><a href="#dom-element-clientheight">#dom-element-clientheight</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-element-clientheight">6. Extensions to the Element Interface</a>
    <li><a href="#ref-for-dom-element-clientheight①">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="scroll-an-element-into-view">
   <b><a href="#scroll-an-element-into-view">#scroll-an-element-into-view</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-scroll-an-element-into-view">6. Extensions to the Element Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="scroll-an-element">
   <b><a href="#scroll-an-element">#scroll-an-element</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-scroll-an-element">6. Extensions to the Element Interface</a> <a href="#ref-for-scroll-an-element①">(2)</a> <a href="#ref-for-scroll-an-element②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-htmlelement-offsetparent">
   <b><a href="#dom-htmlelement-offsetparent">#dom-htmlelement-offsetparent</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-htmlelement-offsetparent">7. Extensions to the HTMLElement Interface</a> <a href="#ref-for-dom-htmlelement-offsetparent①">(2)</a> <a href="#ref-for-dom-htmlelement-offsetparent②">(3)</a> <a href="#ref-for-dom-htmlelement-offsetparent③">(4)</a> <a href="#ref-for-dom-htmlelement-offsetparent④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-htmlelement-offsettop">
   <b><a href="#dom-htmlelement-offsettop">#dom-htmlelement-offsettop</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-htmlelement-offsettop">7. Extensions to the HTMLElement Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-htmlelement-offsetleft">
   <b><a href="#dom-htmlelement-offsetleft">#dom-htmlelement-offsetleft</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-htmlelement-offsetleft">7. Extensions to the HTMLElement Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-htmlelement-offsetwidth">
   <b><a href="#dom-htmlelement-offsetwidth">#dom-htmlelement-offsetwidth</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-htmlelement-offsetwidth">7. Extensions to the HTMLElement Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-htmlelement-offsetheight">
   <b><a href="#dom-htmlelement-offsetheight">#dom-htmlelement-offsetheight</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-htmlelement-offsetheight">7. Extensions to the HTMLElement Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-htmlimageelement-x">
   <b><a href="#dom-htmlimageelement-x">#dom-htmlimageelement-x</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-htmlimageelement-x">8. Extensions to the HTMLImageElement Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-htmlimageelement-y">
   <b><a href="#dom-htmlimageelement-y">#dom-htmlimageelement-y</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-htmlimageelement-y">8. Extensions to the HTMLImageElement Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-range-getclientrects">
   <b><a href="#dom-range-getclientrects">#dom-range-getclientrects</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-range-getclientrects">5.1. The CaretPosition Interface</a>
    <li><a href="#ref-for-dom-range-getclientrects①">9. Extensions to the Range Interface</a> <a href="#ref-for-dom-range-getclientrects②">(2)</a> <a href="#ref-for-dom-range-getclientrects③">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-range-getboundingclientrect">
   <b><a href="#dom-range-getboundingclientrect">#dom-range-getboundingclientrect</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-range-getboundingclientrect">9. Extensions to the Range Interface</a> <a href="#ref-for-dom-range-getboundingclientrect①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mouseevent-screenx">
   <b><a href="#dom-mouseevent-screenx">#dom-mouseevent-screenx</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mouseevent-screenx">10. Extensions to the MouseEvent Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mouseevent-screeny">
   <b><a href="#dom-mouseevent-screeny">#dom-mouseevent-screeny</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mouseevent-screeny">10. Extensions to the MouseEvent Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mouseevent-pagex">
   <b><a href="#dom-mouseevent-pagex">#dom-mouseevent-pagex</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mouseevent-pagex">10. Extensions to the MouseEvent Interface</a> <a href="#ref-for-dom-mouseevent-pagex①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mouseevent-pagey">
   <b><a href="#dom-mouseevent-pagey">#dom-mouseevent-pagey</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mouseevent-pagey">10. Extensions to the MouseEvent Interface</a> <a href="#ref-for-dom-mouseevent-pagey①">(2)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mouseevent-clientx">
   <b><a href="#dom-mouseevent-clientx">#dom-mouseevent-clientx</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mouseevent-clientx">10. Extensions to the MouseEvent Interface</a> <a href="#ref-for-dom-mouseevent-clientx①">(2)</a> <a href="#ref-for-dom-mouseevent-clientx②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mouseevent-clienty">
   <b><a href="#dom-mouseevent-clienty">#dom-mouseevent-clienty</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mouseevent-clienty">10. Extensions to the MouseEvent Interface</a> <a href="#ref-for-dom-mouseevent-clienty①">(2)</a> <a href="#ref-for-dom-mouseevent-clienty②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mouseevent-x">
   <b><a href="#dom-mouseevent-x">#dom-mouseevent-x</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mouseevent-x">10. Extensions to the MouseEvent Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mouseevent-y">
   <b><a href="#dom-mouseevent-y">#dom-mouseevent-y</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mouseevent-y">10. Extensions to the MouseEvent Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mouseevent-offsetx">
   <b><a href="#dom-mouseevent-offsetx">#dom-mouseevent-offsetx</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mouseevent-offsetx">10. Extensions to the MouseEvent Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-mouseevent-offsety">
   <b><a href="#dom-mouseevent-offsety">#dom-mouseevent-offsety</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-mouseevent-offsety">10. Extensions to the MouseEvent Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="enumdef-cssboxtype">
   <b><a href="#enumdef-cssboxtype">#enumdef-cssboxtype</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-enumdef-cssboxtype">11.1. The GeometryUtils Interface</a> <a href="#ref-for-enumdef-cssboxtype①">(2)</a> <a href="#ref-for-enumdef-cssboxtype②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-boxquadoptions">
   <b><a href="#dictdef-boxquadoptions">#dictdef-boxquadoptions</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-boxquadoptions">11.1. The GeometryUtils Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dictdef-convertcoordinateoptions">
   <b><a href="#dictdef-convertcoordinateoptions">#dictdef-convertcoordinateoptions</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dictdef-convertcoordinateoptions">11.1. The GeometryUtils Interface</a> <a href="#ref-for-dictdef-convertcoordinateoptions①">(2)</a> <a href="#ref-for-dictdef-convertcoordinateoptions②">(3)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="geometryutils">
   <b><a href="#geometryutils">#geometryutils</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-geometryutils">11.1. The GeometryUtils Interface</a> <a href="#ref-for-geometryutils①">(2)</a> <a href="#ref-for-geometryutils②">(3)</a> <a href="#ref-for-geometryutils③">(4)</a> <a href="#ref-for-geometryutils④">(5)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="typedefdef-geometrynode">
   <b><a href="#typedefdef-geometrynode">#typedefdef-geometrynode</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-typedefdef-geometrynode">11.1. The GeometryUtils Interface</a> <a href="#ref-for-typedefdef-geometrynode①">(2)</a> <a href="#ref-for-typedefdef-geometrynode②">(3)</a> <a href="#ref-for-typedefdef-geometrynode③">(4)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-geometryutils-getboxquads">
   <b><a href="#dom-geometryutils-getboxquads">#dom-geometryutils-getboxquads</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-geometryutils-getboxquads">11.1. The GeometryUtils Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-geometryutils-convertquadfromnode">
   <b><a href="#dom-geometryutils-convertquadfromnode">#dom-geometryutils-convertquadfromnode</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-geometryutils-convertquadfromnode">11.1. The GeometryUtils Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-geometryutils-convertrectfromnode">
   <b><a href="#dom-geometryutils-convertrectfromnode">#dom-geometryutils-convertrectfromnode</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-geometryutils-convertrectfromnode">11.1. The GeometryUtils Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="dom-geometryutils-convertpointfromnode">
   <b><a href="#dom-geometryutils-convertpointfromnode">#dom-geometryutils-convertpointfromnode</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-dom-geometryutils-convertpointfromnode">11.1. The GeometryUtils Interface</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="pending-scroll-event-targets">
   <b><a href="#pending-scroll-event-targets">#pending-scroll-event-targets</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-pending-scroll-event-targets">12.2. Scrolling</a> <a href="#ref-for-pending-scroll-event-targets①">(2)</a> <a href="#ref-for-pending-scroll-event-targets②">(3)</a> <a href="#ref-for-pending-scroll-event-targets③">(4)</a> <a href="#ref-for-pending-scroll-event-targets④">(5)</a> <a href="#ref-for-pending-scroll-event-targets⑤">(6)</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="eventdef-window-resize">
   <b><a href="#eventdef-window-resize">#eventdef-window-resize</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventdef-window-resize">12.1. Resizing viewports</a>
    <li><a href="#ref-for-eventdef-window-resize①">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="eventdef-document-scroll">
   <b><a href="#eventdef-document-scroll">#eventdef-document-scroll</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-eventdef-document-scroll">12.2. Scrolling</a> <a href="#ref-for-eventdef-document-scroll①">(2)</a>
    <li><a href="#ref-for-eventdef-document-scroll②">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="propdef-scroll-behavior">
   <b><a href="#propdef-scroll-behavior">#propdef-scroll-behavior</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-propdef-scroll-behavior">3.1. Scrolling</a> <a href="#ref-for-propdef-scroll-behavior①">(2)</a>
    <li><a href="#ref-for-propdef-scroll-behavior②">13.1. Smooth Scrolling: The scroll-behavior Property</a> <a href="#ref-for-propdef-scroll-behavior③">(2)</a> <a href="#ref-for-propdef-scroll-behavior④">(3)</a>
    <li><a href="#ref-for-propdef-scroll-behavior⑤">Changes From 17 December 2013 To 31 January 2020</a>
    <li><a href="#ref-for-propdef-scroll-behavior⑥">Changes From 4 August 2011 To 17 December 2013</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-scroll-behavior-auto">
   <b><a href="#valdef-scroll-behavior-auto">#valdef-scroll-behavior-auto</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-scroll-behavior-auto">Changes From 17 December 2013 To 31 January 2020</a>
   </ul>
  </aside>
  <aside class="dfn-panel" data-for="valdef-scroll-behavior-smooth">
   <b><a href="#valdef-scroll-behavior-smooth">#valdef-scroll-behavior-smooth</a></b><b>Referenced in:</b>
   <ul>
    <li><a href="#ref-for-valdef-scroll-behavior-smooth">3.1. Scrolling</a>
   </ul>
  </aside>
<script>/* script-caniuse-panel */

            window.addEventListener("load", function(){
                var panels = [].slice.call(document.querySelectorAll(".caniuse-status"));
                for(var i = 0; i < panels.length; i++) {
                    var panel = panels[i];
                    var dfn = document.querySelector("#" + panel.getAttribute("data-dfn-id"));
                    var rect = dfn.getBoundingClientRect();
                    panel.style.top = (window.scrollY + rect.top) + "px";
                }
            });
            document.body.addEventListener("click", function(e) {
                if(e.target.classList.contains("caniuse-panel-btn")) {
                    e.target.parentNode.classList.toggle("wrapped");
                }
            });</script>
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
            </script><a class='link-error' href='/bikeshed/cssom-view/' id='generator' title='Bikeshed Link Errors'><svg height='24' viewbox='0 0 100 100' width='24'><g stroke="blue" stroke-width="6" fill="none"><path fill="blue" stroke="none" d="M 5 95 L 5 35 L 50 10 L 50 95"/><path d="M 1 37 L 54 8"/><path fill="blue" stroke="none" d="M 1 40 v -6 l 60 -32 v 6 z" /><circle cx="75" cy="79" r="15" /><circle fill="blue" stroke="none" cx="75" cy="79" r="4" /><path d="M 75 79 L 65 49 L 55 49" /><path d="M 67 55 L 48 69" /></g></svg></a>