<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01//EN" "http://www.w3.org/TR/html4/strict.dtd">
<!-- saved from url=(0042) -->
<html lang="en">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

<title>Geolocation API Specification 2nd Edition</title>

  <style type="text/css">
   dt, dfn { font-weight: bold; font-style: normal; }
   img.extra { float: right; }
   body ins, body del { display: block; }
   body * ins, body * del { display: inline; }
   pre, code { color: black; background: transparent; font-size: inherit; font-family: monospace; }
   pre strong { color: black; font: inherit; font-weight: bold; background: yellow; }
   pre em { font-weight: bolder; font-style: normal; }
   pre.idl :link, pre.idl :visited { color: inherit; background: transparent; }
   pre.idl { border: solid thin; background: #EEEEEE; color: black; padding: 0.5em; }
   table { border-collapse: collapse; border-style: hidden hidden none hidden; }
   table thead { border-bottom: solid; }
   table tbody th:first-child { border-left: solid; }
   table td, table th { border-left: solid; border-right: solid; border-bottom: solid thin; vertical-align: top; padding: 0.2em; }
   ul.toc dfn, h1 dfn, h2 dfn, h3 dfn, h4 dfn, h5 dfn, h6 dfn { font: inherit; }
   ul.toc li ul { margin-bottom: 0.75em; }
   ul.toc li ul li ul { margin-bottom: 0.25em; }
   var sub { vertical-align: bottom; font-size: smaller; position: relative; top: 0.1em; }
   @media screen { code { color: rgb(255, 69, 0); background: transparent; } }
   code :link, code :visited { color: inherit; background: transparent; }
   .example { display: block; color: #222222; background: #FCFCFC; border-left: double; margin-left: 1em; padding-left: 1em; }
   .issue, .big-issue { color: #E50000; background: white; border: solid red; padding: 0.5em; margin: 1em 0; }
   .issue > :first-child, .big-issue > :first-child { margin-top: 0; }
   p .big-issue { line-height: 3em; }
   .note { color: green; background: transparent; }
   .note { font-family: sans-serif; }
   p.note:before { content: 'Note: '; }
   .warning { color: red; background: transparent; }
   .warning:before { font-style: normal; }
   p.warning:before { content: '\26A0 Warning! '; }
   .note, .warning { font-weight: bolder; font-style: italic; padding: 0.5em 2em; }
   .copyright { margin: 0.25em 0; }
   img { max-width: 100%; }
   h4 + .element { margin-top: -2.5em; padding-top: 2em; }
   h4 + p + .element { margin-top: -5em; padding-top: 4em; }
   .element { background: #EEEEFF; color: black; margin: 0 0 1em -1em; padding: 0 1em 0.25em 0.75em; border-left: solid #9999FF 0.25em; }
   table.matrix, table.matrix td { border: none; text-align: right; }
   table.matrix { margin-left: 2em; }
  </style>
<link rel="stylesheet" type="text/css" href="https://www.w3.org/StyleSheets/TR/2016/W3C-REC.css">

 </head>

<body>
  <div class="head"> <!--begin-logo-->
   <p><a href="https://www.w3.org/"><img alt="W3C" height="48" src="https://www.w3.org/StyleSheets/TR/2016/logos/W3C" width="72"></a> <!--end-logo--></p>

<h1 id="title_heading">Geolocation API Specification 2nd Edition</h1>

   <h2 class="no-num no-toc" id="draft_date">W3C Recommendation 8 November 2016 (GitHub reference added 31 January 2018)</h2>

   <dl>
    <dt>This version:</dt>
    <dd><a href="https://www.w3.org/TR/2016/REC-geolocation-API-20161108/">https://www.w3.org/TR/2016/REC-geolocation-API-20161108/</a></dd>

    <dt>Latest version:</dt>
    <dd><a href="https://www.w3.org/TR/geolocation-API/">https://www.w3.org/TR/geolocation-API/</a></dd>

    <dt>Previous versions:</dt>
    <dd><a href="https://www.w3.org/TR/2015/PER-geolocation-API-20150528/">https://www.w3.org/TR/2015/PER-geolocation-API-20150528/</a></dd>
    <dd><a href="https://www.w3.org/TR/2013/REC-geolocation-API-20131024/">https://www.w3.org/TR/2013/REC-geolocation-API-20131024/</a></dd>

    <dt>Editor:</dt>
    <dd>Andrei Popescu, Google, Inc</dd>
   </dl>

<p>Please check the <a href="https://www.w3.org/2008/geolocation/geoapi-errata.html"><strong>errata</strong></a> for any errors or issues reported since publication.</p>

<p>See also <a href="https://www.w3.org/2003/03/Translations/byTechnology?technology=geolocation-API"> <strong>translations</strong></a>.</p>

<p class="copyright"><a href="https://www.w3.org/Consortium/Legal/ipr-notice#Copyright">Copyright</a> © 2016 <a href="https://www.w3.org/"><abbr title="World Wide Web Consortium">W3C</abbr></a><sup>®</sup> (<a href="https://www.csail.mit.edu/"><abbr title="Massachusetts Institute of Technology">MIT</abbr></a>, <a href="https://www.ercim.eu/"><abbr title="European Research Consortium for Informatics and Mathematics">ERCIM</abbr></a>, <a href="https://www.keio.ac.jp/">Keio</a>, <a href="http://ev.buaa.edu.cn/">Beihang</a>). W3C <a href="https://www.w3.org/Consortium/Legal/ipr-notice#Legal_Disclaimer">liability</a>, <a href="https://www.w3.org/Consortium/Legal/ipr-notice#W3C_Trademarks">trademark</a> and <a href="https://www.w3.org/Consortium/Legal/copyright-documents">document use</a> rules apply.</p>

   <hr>
  </div>

<h2 class="no-num no-toc" id="abstract">Abstract</h2>

<p>This specification defines an API that provides scripted access to
   geographical location information associated with the hosting device.</p>

<h2 class="no-num no-toc" id="status">Status of This Document</h2>

<p class="advisement">Status Update (January 2018): A reference to the GitHub repository was added on 31 January 2018 for comments.</p>
  <!-- intro boilerplate (required) -->

<p><em>This section describes the status of this document at the time of its publication. Other documents may supersede this document. A list of current W3C publications and the latest revision of this technical report can be found in the <a href="https://www.w3.org/TR/">W3C technical reports index</a> at https://www.w3.org/TR/.</em></p>

<p>
This document is an edited version of the 
<a href="http://www.w3.org/TR/2013/REC-geolocation-API-20131024/">
2013 Geolocation API Recommendation</a>, and
incorporates changes made against the 2013 Recommendation that resolve all
the <a href="http://www.w3.org/2008/geolocation/geoapi-errata.html#1st-edition">
errata</a>.

A <a href="diff.html">diff-marked version</a> of this document from
the previous Recommendation is also available for comparison purposes.

Please note that there is <a href="https://groups.google.com/forum/#!topic/mozilla.dev.platform/BvcsTpAqIsQ">an open issue regarding insecure contexts</a> which is not filed on the Errata yet.
</p>

<p>This document was published by
the <a href="https://www.w3.org/2008/geolocation/">Geolocation Working
Group</a> as a Recommendation.  If you wish to make comments regarding
this document, please use <a href="https://github.com/w3c/geolocation-api/issues">file a bug</a> on GitHub (or send them
to <a href="mailto:public-geolocation@w3.org">public-geolocation@w3.org</a> if you cannot use GitHub
(<a href="http://lists.w3.org/Archives/Public/public-geolocation/">archives</a>). All
comments are welcome.</p>

<p>
This document has been reviewed by W3C Members, by software
developers, and by other W3C groups and interested parties, and is
endorsed by the Director as a W3C Recommendation. It is a stable
document and may be used as reference material or cited from another
document. W3C's role in making the Recommendation is to draw attention
to the specification and to promote its widespread deployment. This
enhances the functionality and interoperability of the Web.
</p>

<p>
The group generated an <a href="http://www.w3.org/2008/geolocation/drafts/API/Implementation-Report.html">Implementation Report</a> which shows the exit criteria for the Candidate Recommendation have been met.

There were at least five User Agent implementations, and all the
features of the Geolocation API specification were implemented by two
or more User Agents.

Also there were at least two Websites that passed the Website Tests.
</p>

<p>This document was produced by a group operating under the
<a href="https://www.w3.org/Consortium/Patent-Policy-20040205/">5
February 2004 W3C Patent Policy</a>. W3C maintains a <a rel="disclosure" href="https://www.w3.org/2004/01/pp-impl/42891/status">public list of any
patent disclosures</a> made in connection with the deliverables of
the group; that page also includes instructions for disclosing a
patent. An individual who has actual knowledge of a patent which
the individual believes contains <a href="https://www.w3.org/Consortium/Patent-Policy-20040205/#def-essential">
Essential Claim(s)</a> must disclose the information in accordance
with <a href="https://www.w3.org/Consortium/Patent-Policy-20040205/#sec-Disclosure">
section 6 of the W3C Patent Policy</a>.</p>

<p>This document is governed by the <a id="w3c_process_revision" href="https://www.w3.org/2015/Process-20150901/">1 September 2015 W3C Process Document</a>. </p>

<nav id="toc">
  <h2 class="no-num no-toc" id="contents">Table of Contents</h2>
  <!--begin-toc-->

  <ol class="toc">
   <li><a href="#conformance"><span class="secno">1 </span>Conformance
    requirements</a>

   </li><li><a href="#introduction"><span class="secno">2 </span>Introduction</a>

   </li><li><a href="#scope"><span class="secno">3 </span>Scope</a>

   </li><li><a href="#security"><span class="secno">4 </span>Security and privacy
    considerations</a>
    <ul class="toc">
     <li><a href="#privacy_for_uas"><span class="secno">4.1 </span>Privacy
      considerations for implementers of the Geolocation API</a>

     </li><li><a href="#privacy_for_recipients"><span class="secno">4.2
      </span>Privacy considerations for recipients of location
      information</a>

     </li><li><a href="#implementation_considerations"><span class="secno">4.3
      </span>Additional implementation considerations</a>
    </li></ul>

   </li><li><a href="#api_description"><span class="secno">5 </span>API
    Description</a>
    <ul class="toc">
     <li><a href="#geolocation_interface"><span class="secno">5.1
      </span>Geolocation interface</a>

     </li><li><a href="#position_options_interface"><span class="secno">5.2
      </span>PositionOptions interface</a>

     </li><li><a href="#position_interface"><span class="secno">5.3 </span>Position
      interface</a>

     </li><li><a href="#coordinates_interface"><span class="secno">5.4
      </span>Coordinates interface</a>

     </li><li><a href="#position_error_interface"><span class="secno">5.5
      </span>PositionError interface</a>
    </li></ul>

   </li><li><a href="#usecases"><span class="secno">6 </span>Use-Cases and
    Requirements</a>
    <ul class="toc">
     <li><a href="#usecases_section"><span class="secno">6.1
      </span>Use-Cases</a>

     </li><li><a href="#requirements_section"><span class="secno">6.2
      </span>Requirements</a>
    </li></ul>

   </li><li class="no-num"><a href="#acknowledgments">Acknowledgments</a>

   </li><li class="no-num"><a href="#references">References</a>
  </li>
  </ol>
  <!--end-toc-->
</nav>

  <h2 id="conformance"><span class="secno">1 </span>Conformance requirements</h2>

  <p>All diagrams, examples, and notes in this specification are
   non-normative, as are all sections explicitly marked non-normative.
   Everything else in this specification is normative.

  </p><p>The key words "MUST", "MUST NOT", "REQUIRED", <!--"SHALL", "SHALL
  NOT",-->
   "SHOULD", "SHOULD NOT", "RECOMMENDED", "MAY", and "OPTIONAL" in the
   normative parts of this document are to be interpreted as described in
   RFC2119. For readability, these words do not appear in all uppercase
   letters in this specification. <a href="#ref-rfc2119">[RFC2119]</a></p>
  <!-- XXX but they should be
  marked up -->

  <p>Requirements phrased in the imperative as part of algorithms (such as
   "strip any leading space characters" or "return false and abort these
   steps") are to be interpreted with the meaning of the key word ("must",
   "should", "may", etc) used in introducing the algorithm.

  </p><p>Conformance requirements phrased as algorithms or specific steps may be
   implemented in any manner, so long as the end result is equivalent. (In
   particular, the algorithms defined in this specification are intended to
   be easy to follow, and not intended to be performant.)

  </p><p id="hardwareLimitations">User agents may impose implementation-specific
   limits on otherwise unconstrained inputs, e.g. to prevent denial of
   service attacks, to guard against running out of memory, or to work around
   platform-specific limitations.

 </p><p>Implementations that use ECMAScript to implement the APIs defined in
    this specification must implement them in a manner consistent with the
    ECMAScript Bindings defined in the Web IDL specification, as this
    specification uses that specification's terminology. <a href="#ref-webidl">[WEBIDL]</a></p>
 
  <h2 id="introduction"><span class="secno">2 </span>Introduction</h2>

  <p><em>This section is non-normative.</em>

  </p><p>The Geolocation API defines a high-level interface to location
   information associated only with the device hosting the implementation,
   such as latitude and longitude. The API itself is agnostic of the
   underlying location information sources. Common sources of location
   information include Global Positioning System (GPS) and location inferred
   from network signals such as IP address, RFID, WiFi and Bluetooth MAC
   addresses, and GSM/CDMA cell IDs, as well as user input. No guarantee is
   given that the API returns the device's actual location.

  </p><p>The API is designed to enable both "one-shot" position requests and
   repeated position updates, as well as the ability to explicitly query the
   cached positions. Location information is represented by latitude and
   longitude coordinates. The Geolocation API in this specification builds
   upon earlier work in the industry, including <a href="#ref-azaloc">[AZALOC]</a>, <a href="#ref-gears">[GEARSLOC]</a>,
   and <a href="#ref-locationaware">[LOCATIONAWARE]</a>.

  </p><p>The following code extracts illustrate how to obtain basic location
   information:

  </p><div class="example">
   <p> Example of a "one-shot" position request.</p>

   <pre>    function showMap(position) {
      // Show a map centered at (position.coords.latitude, position.coords.longitude).
    }

    // One-shot position request.
    navigator.geolocation.getCurrentPosition(showMap);
    </pre>
  </div>

  <div class="example">
   <p>Example of requesting repeated position updates.</p>

   <pre>    function scrollMap(position) {
      // Scrolls the map so that it is centered at (position.coords.latitude, position.coords.longitude).
    }

    // Request repeated updates.
    var watchId = navigator.geolocation.watchPosition(scrollMap);

    function buttonClickHandler() {
      // Cancel the updates when the user clicks a button.
      navigator.geolocation.clearWatch(watchId);
    }
    </pre>
  </div>

  <div class="example">
   <p>Example of requesting repeated position updates and handling errors.</p>

   <pre>    function scrollMap(position) {
      // Scrolls the map so that it is centered at (position.coords.latitude, position.coords.longitude).
    }

    function handleError(error) {
      // Update a div element with error.message.
    }

    // Request repeated updates.
    var watchId = navigator.geolocation.watchPosition(scrollMap, handleError);

    function buttonClickHandler() {
      // Cancel the updates when the user clicks a button.
      navigator.geolocation.clearWatch(watchId);
    }
    </pre>
  </div>

  <div class="example">
   <p>Example of requesting a potentially cached position.</p>

   <pre>    // Request a position. We accept positions whose age is not
    // greater than 10 minutes. If the user agent does not have a
    // fresh enough cached position object, it will automatically
    // acquire a new one.
    navigator.geolocation.getCurrentPosition(successCallback,
                                             errorCallback,
                                             {maximumAge:600000});

    function successCallback(position) {
      // By using the 'maximumAge' option above, the position
      // object is guaranteed to be at most 10 minutes old.
    }

    function errorCallback(error) {
      // Update a div element with error.message.
    }

    </pre>
  </div>

  <div class="example">
   <p>Forcing the user agent to return a fresh cached position.</p>

   <pre>    // Request a position. We only accept cached positions whose age is not
    // greater than 10 minutes. If the user agent does not have a fresh
    // enough cached position object, it will immediately invoke the error
    // callback.
    navigator.geolocation.getCurrentPosition(successCallback,
                                             errorCallback,
                                             {maximumAge:600000, timeout:0});

    function successCallback(position) {
      // By using the 'maximumAge' option above, the position
      // object is guaranteed to be at most 10 minutes old.
      // By using a 'timeout' of 0 milliseconds, if there is
      // no suitable cached position available, the user agent 
      // will asynchronously invoke the error callback with code
      // TIMEOUT and will not initiate a new position
      // acquisition process.
    }

    function errorCallback(error) {
      switch(error.code) {
        case error.TIMEOUT:
          // Quick fallback when no suitable cached position exists.
          doFallback();
          // Acquire a new position object.
          navigator.geolocation.getCurrentPosition(successCallback, errorCallback);
          break;
        case ... // treat the other error cases.
      };
    }

    function doFallback() {
      // No fresh enough cached position available.
      // Fallback to a default position.
    }
    </pre>
  </div>

  <div class="example">
   <p>Forcing the user agent to return any available cached position.</p>

   <pre>    // Request a position. We only accept cached positions, no matter what 
    // their age is. If the user agent does not have a cached position at
    // all, it will immediately invoke the error callback.
    navigator.geolocation.getCurrentPosition(successCallback,
                                             errorCallback,
                                             {maximumAge:Infinity, timeout:0});

    function successCallback(position) {
      // By setting the 'maximumAge' to Infinity, the position
      // object is guaranteed to be a cached one.
      // By using a 'timeout' of 0 milliseconds, if there is
      // no cached position available at all, the user agent 
      // will immediately invoke the error callback with code
      // TIMEOUT and will not initiate a new position
      // acquisition process.
      if (position.timestamp &lt; freshness_threshold &amp;&amp; 
          position.coords.accuracy &lt; accuracy_threshold) {
        // The position is relatively fresh and accurate.
      } else {
        // The position is quite old and/or inaccurate.
      }
    }

    function errorCallback(error) {
      switch(error.code) {
        case error.TIMEOUT:
          // Quick fallback when no cached position exists at all.
          doFallback();
          // Acquire a new position object.
          navigator.geolocation.getCurrentPosition(successCallback, errorCallback);
          break;
        case ... // treat the other error cases.
      };
    }

    function doFallback() {
      // No cached position available at all.
      // Fallback to a default position.
    }
    </pre>
  </div>

  <h2 id="scope"><span class="secno">3 </span>Scope</h2>

  <p><em>This section is non-normative.</em>

  </p><p>This specification is limited to providing a scripting API for
   retrieving geographic position information associated with a hosting
   device. The geographic position information is provided in terms of World
   Geodetic System coordinates <a href="#ref-wgs">[WGS84]</a>.

  </p><p>The scope of this specification does not include providing a markup
   language of any kind.

  </p><p>The scope of this specification does not include defining new URI
   schemes for building URIs that identify geographic locations.

  </p><h2 id="security"><span class="secno">4 </span>Security and privacy
   considerations</h2>

  <p>The API defined in this specification is used to retrieve the
   geographic location of a hosting device. In almost all cases, this
   information also discloses the location of the user of the device, thereby
   potentially compromising the user's privacy. A conforming implementation
   of this specification must provide a mechanism that protects the user's
   privacy and this mechanism should ensure that no location information is
   made available through this API without the user's express permission.

  </p><h3 id="privacy_for_uas"><span class="secno">4.1 </span>Privacy
   considerations for implementers of the Geolocation API</h3>

  <p>User agents must not send location information to Web sites without the
   express permission of the user. User agents must acquire permission
   through a user interface, unless they have prearranged trust relationships
   with users, as described below. The user interface must include the host
   component of the document's URI <a href="#ref-uri">[URI]</a>. Those
   permissions that are acquired through the user interface and that are
   preserved beyond the current browsing session (i.e. beyond the time when
   the browsing context <a href="#ref-context">[BROWSINGCONTEXT]</a> is
   navigated to another URL) must be revocable and user agents must respect
   revoked permissions.

  </p><p>Some user agents will have prearranged trust relationships that do not
   require such user interfaces. For example, while a Web browser will
   present a user interface when a Web site performs a geolocation request, a
   VOIP telephone may not present any user interface when using location
   information to perform an E911 function.

  </p><h3 id="privacy_for_recipients"><span id="privacy_for_" class="secno">4.2 </span>Privacy
   considerations for recipients of location information</h3>

  <p>Recipients must only request location information when necessary.
   Recipients must only use the location information for the task for which
   it was provided to them. Recipients must dispose of location information
   once that task is completed, unless expressly permitted to retain it by
   the user. Recipients must also take measures to protect this information
   against unauthorized access. If location information is stored, users
   should be allowed to update and delete this information.

  </p><p>The recipient of location information must not retransmit the location
   information without the user’s express permission. Care should be taken
   when retransmitting and use of encryption is encouraged.

  </p><p>Recipients must clearly and conspicuously disclose the fact that they
   are collecting location data, the purpose for the collection, how long the
   data is retained, how the data is secured, how the data is shared if it is
   shared, how users may access, update and delete the data, and any other
   choices that users have with respect to the data. This disclosure must
   include an explanation of any exceptions to the guidelines listed above.

  </p><h3 id="implementation_considerations"><span class="secno">4.3
   </span>Additional implementation considerations</h3>

  <p><em>This section is non-normative.</em>

  </p><p>Further to the requirements listed in the previous section, implementers
   of the Geolocation API are also advised to consider the following aspects
   that may negatively affect the privacy of their users: in certain cases,
   users may inadvertently grant permission to the user agent to disclose
   their location to Web sites. In other cases, the content hosted at a
   certain URL changes in such a way that the previously granted location
   permissions no longer apply as far as the user is concerned. Or the users
   might simply change their minds.

  </p><p>Predicting or preventing these situations is inherently difficult.
   Mitigation and in-depth defensive measures are an implementation
   responsibility and not prescribed by this specification. However, in
   designing these measures, implementers are advised to enable user
   awareness of location sharing, and to provide easy access to interfaces
   that enable revocation of permissions.

  </p><h2 id="api_description"><span class="secno">5 </span>API Description</h2>

  <h3 id="geolocation_interface"><span class="secno">5.1 </span>Geolocation
   interface</h3>

  <p>The <code><a href="#geolocation">Geolocation</a></code> object is
   used by scripts to programmatically determine the location information
   associated with the hosting device. The location information is acquired
   by applying a user-agent specific algorithm, creating a <code><a href="#position">Position</a></code> object, and populating that object
   with appropriate data accordingly.  

  </p><pre class="idl"> partial interface <dfn id="navi-geo">Navigator</dfn> {
   readonly attribute <a href="#geolocation">Geolocation</a> geolocation;
 };

  </pre>

  <p><br>

 </p><pre class="idl"> [NoInterfaceObject]
 interface <dfn id="geolocation">Geolocation</dfn> { 
   void <a href="#get-current-position">getCurrentPosition</a>(<a href="#position-callback">PositionCallback</a> successCallback,
                           optional <a href="#error-callback">PositionErrorCallback</a> errorCallback,
                           optional <a href="#position-options">PositionOptions</a> options);

   long <a href="#watch-position">watchPosition</a>(<a href="#position-callback">PositionCallback</a> successCallback,
                      optional <a href="#error-callback">PositionErrorCallback</a> errorCallback,
                      optional <a href="#position-options">PositionOptions</a> options);

   void <a href="#clear-watch">clearWatch</a>(long watchId);
 };

 callback <dfn id="position-callback">PositionCallback</dfn> = void (<a href="#position">Position</a> position);

 callback <dfn id="error-callback">PositionErrorCallback</dfn> = void (<a href="#position-error">PositionError</a> positionError);
 </pre>

  <p>The <dfn id="get-current-position"><code>getCurrentPosition()</code></dfn>
   method takes one, two or three arguments. When called, it must immediately
   return and then asynchronously attempt to obtain the current
   location of the device. If the attempt is successful,
   the <code>successCallback</code> must be invoked
   (i.e. the <code>handleEvent</code> operation must be called on the
   callback object) with a new <code>Position</code> object,
   reflecting the current location of the device. If the attempt
   fails, the <code>errorCallback</code> must be invoked with a
   new <code>PositionError</code> object, reflecting the reason for the failure.</p>

  <p>The implementation of the <code>getCurrentPosition</code> method
  must execute the following set of steps:</p>
  <ol>    
    <li> If a cached <code>Position</code> object, whose age is no greater
          than the value of the maximumAge variable, is available,
          invoke the <code>successCallback</code> with the
          cached <code>Position</code> object as a parameter and exit
          this set of steps.</li>
    <li> If the value of the timeout variable is 0, invoke
    the <code>errorCallback</code> (if present) with a
    new <code>PositionError</code> object whose <code>code</code>
    attribute is set to TIMEOUT and exit this set of steps.</li>
    <li>Start a location acquisition operation (e.g. by
          invoking a platform-specific API), possibly taking into
          account the value of the enableHighAccuracy variable (see
          the definition
          of <code><a href="#high-accuracy">enableHighAccuracy</a></code>
          for details).</li>
    <li>Start a timer that will fire after the number of milliseconds
              denoted by the value of the timeout variable. When the
              timer fires, cancel any ongoing location acquisition
              operations associated with this instance of the steps,
              invoke the <code>errorCallback</code> (if present)
              with a new <code>PositionError</code> object
              whose <code>code</code> attribute is set to TIMEOUT, and
              exit this set of steps.</li>
    <li>If the operation completes successfully before the timeout
    expires, cancel the pending timer, invoke
    the <code>successCallback</code> with a new <code>Position</code>
    object that reflects the result of the acquisition operation and
    exit this set of steps. </li>
    <li>If the operation fails before the timeout expires, cancel the
    pending timer and invoke the <code>errorCallback</code> (if
    present) with a new <code>PositionError</code> object
    whose <code>code</code> is set to POSITION_UNAVAILABLE.</li>
  </ol>

    <p>The <dfn id="watch-position"><code>watchPosition()</code></dfn>
   method takes one, two or three arguments. When called, it must immediately
   return a long value that uniquely identifies a <em>watch
   operation</em> and then asynchronously start the watch
   operation. This operation must first attempt to obtain the current location of the
   device. If the attempt is successful, the <code>successCallback</code> must be invoked
   (i.e. the <code>handleEvent</code> operation must be called on the
   callback object) with a new <code>Position</code> object,
   reflecting the current location of the device. If the attempt
   fails, the <code>errorCallback</code> must be invoked with a
   new <code>PositionError</code> object, reflecting the reason for 
   the failure. The watch operation then must continue
   to monitor the position of the device and invoke the appropriate
   callback every time this position changes. The watch operation
   must continue until
   the <code><a href="#clear-watch">clearWatch</a></code> method is
   called with the corresponding identifier.</p>

  <p>The implementation of the watch process must execute the
  following set of steps:</p>
  <ol>    
    <li> If a cached <code>Position</code> object, whose age is no greater
          than the value of the maximumAge variable, is available,
          invoke the <code>successCallback</code> with the
          cached <code>Position</code> object as a parameter.</li>
    <li>Register to receive system events that indicate that the
    position of the device may have changed (e.g. by listening or
    polling for changes in WiFi or cellular signals).</li>
    <li>Start a location acquisition operation (e.g. by
          invoking a platform-specific API), possibly taking into
          account the value of the enableHighAccuracy variable (see
          the definition
          of <code><a href="#high-accuracy">enableHighAccuracy</a></code>
          for details). </li>
    <li> Run the following acquisition steps:
      <ol>
        <li>If the timer is not already running, start a timer that will fire after the number of
        milliseconds denoted by the value of the timeout
        variable. When the timer fires, invoke
        the <code>errorCallback</code> (if present) with a
        new <code>PositionError</code> object whose <code>code</code>
        attribute is set to TIMEOUT and jump to step 6.</li>
        <li>If the location acquisition operation successfully yields
        a new position before the timeout expires, perform the
        following two steps:
          <ol>
            <li>Cancel the pending timer. Note that the timer must be
            restarted once this algorithm jumps back to the beginning of the
            acquisition steps.</li>
            <li>If the new position differs significantly from the
              previous position, invoke
              the <code>successCallback</code> with a
              new <code>Position</code> object that reflects the
              result of the acquisition operation.  This step may be
              subject to callback rate limitation
              (<a href="#rate-limit">see below</a>).</li>
          </ol>
        </li>
        <li>Else, if the location acquisition operation reports an
          error before the timeout expires, invoke the <code>errorCallback</code> (if present)
          with a new <code>PositionError</code> object
          whose <code>code</code> is set to POSITION_UNAVAILABLE. This
          step may be subject to callback rate limitation
          (<a href="#rate-limit">see below</a>).</li>
      </ol>
    </li>
    <li>Wait for a system event to be received. When such an event is
    received jump to the acquisition steps above.</li>
  </ol>

  <p id="rate-limit">In step 5.2.2 of the watch process,
  the <code>successCallback</code> is only invoked when a new position
  is obtained and this position differs significantly from the
  previously reported position. The definition of what constitutes a
  significant difference is left to the implementation. Furthermore,
  in steps 5.2.2 and 5.2.3, implementations may impose limitations on
  the frequency of callbacks so as to avoid inadvertently consuming a
  disproportionate amount of resources.</p>

  <p>For both <code>getCurrentPosition</code>
  and <code>watchPosition</code>, the implementation must never invoke
  the <code>successCallback</code> without having first obtained
  permission from the user to share location. Furthermore, the 
  implementation should always obtain the user's permission to share location before
  executing any of the <code>getCurrentPosition</code> or <code>watchPosition</code> steps
  described above. If the user grants permission, the
  appropriate callback must be invoked as described above. If the user
  denies permission, the <code>errorCallback</code> (if present)
  must be invoked with <code>code</code> PERMISSION_DENIED, irrespective of any
  other errors encountered in the above steps.
  The time that is spent obtaining the user permission must not be
  included in the period covered by the <code>timeout</code> attribute
  of the <code>PositionOptions</code>
  parameter. The <code>timeout</code> attribute must only apply to the
  location acquisition operation.</p>

  <p>The <dfn id="clear-watch"><code>clearWatch()</code></dfn> method
  takes one argument. When called, it must first check the value of
  the given <dfn id="watchId"><code>watchId</code></dfn> argument.
  If this value does not correspond to any previously started watch
  process, then the method must return immediately without taking any
  further action. Otherwise, the watch process identified by the
  <code>watchId</code> argument must be immediately stopped and no 
  further callbacks must be invoked.</p>

  <h3 id="position_options_interface"><span class="secno">5.2
   </span>PositionOptions interface</h3>

  <p>The <code><a href="#get-current-position">getCurrentPosition()</a></code> and <code><a href="#watch-position">watchPosition()</a></code> methods accept <code><a href="#position-options">PositionOptions</a></code> objects as their third
   argument.

  </p><p> In ECMAScript, <code><a href="#position-options">PositionOptions</a></code>
   objects are represented using regular native objects with optional
   properties named <code>enableHighAccuracy</code>, <code>timeout</code>
   and <code>maximumAge</code>.</p>

  <pre class="idl">  dictionary <dfn id="position-options">PositionOptions</dfn> {
    boolean <a href="#high-accuracy">enableHighAccuracy</a> = false;
    [Clamp] unsigned long <a href="#timeout">timeout</a> = 0xFFFFFFFF;
    [Clamp] unsigned long <a href="#max-age">maximumAge</a> = 0;
  };

  </pre>

  <p>In ECMAScript, the <code><a href="#high-accuracy">enableHighAccuracy</a></code>,
   <code><a href="#timeout_error">timeout</a></code> and <code><a href="#max-age">maximumAge</a></code> properties are all optional: when
   creating a PositionOptions object, the developer may specify any of these
   properties.  

  </p><p>The <dfn id="high-accuracy"><code>enableHighAccuracy</code></dfn>
   attribute provides a hint that the application would like to receive the
   best possible results. This may result in slower response times or
   increased power consumption. The user might also deny this capability, or
   the device might not be able to provide more accurate results than if the
   flag wasn't specified. The intended purpose of this attribute is to allow 
   applications to inform the implementation that they do not require high
   accuracy geolocation fixes and, therefore, the implementation can avoid
   using geolocation providers that consume a significant amount of power (e.g. GPS).
   This is especially useful for applications running on battery-powered devices,
   such as mobile phones.

  </p><p>The <dfn id="timeout"><code>timeout</code></dfn> attribute denotes
   the maximum length of time (expressed in milliseconds) that is
   allowed to pass from the call
   to <code><a href="#get-current-position">getCurrentPosition()</a></code>
   or <code><a href="#watch-position">watchPosition()</a></code> until
   the corresponding
   <code>successCallback</code> is invoked. If the implementation is unable
   to successfully acquire a new <code><a href="#position">Position</a></code> before the given timeout elapses, and
   no other errors have occurred in this interval, then the corresponding
   <code>errorCallback</code> must be invoked with
   a <code><a href="#position-error">PositionError</a></code> object
   whose <code><a href="#code">code</a></code> attribute is set
   to <a href="#timeout_error">TIMEOUT</a>. Note that the time that is
   spent obtaining the user permission is <em>not</em> included in the period
   covered by the <code>timeout</code>
   attribute. The <code>timeout</code> attribute only applies to the
   location acquisition operation.

  </p><p>In case of a <code><a href="#get-current-position">getCurrentPosition()</a></code> call, the
   <code>errorCallback</code> would be invoked at most once.

   In case of
   a <code><a href="#watch-position">watchPosition()</a></code>,
   the <code>errorCallback</code> could be invoked repeatedly: the
   first timeout is relative to the
   moment <code><a href="#watch-position">watchPosition()</a></code>
   was called or the moment the user's permission was obtained, if
   that was necessary. Subsequent timeouts are relative to the moment
   when the implementation determines that the position of the hosting
   device has changed and a new
   <code><a href="#position">Position</a></code> object must be acquired.  

  </p><p>The <dfn id="max-age"><code>maximumAge</code></dfn> attribute indicates
   that the application is willing to accept a cached position whose age is
   no greater than the specified time in milliseconds. If <code><a href="#max-age">maximumAge</a></code> is set to 0, the
   implementation must immediately attempt to acquire a new position object.
   Setting the <code><a href="#max-age">maximumAge</a></code> to Infinity
   must determine the implementation to return a cached position regardless of
   its age. If an implementation does not have a cached position available
   whose age is no greater than the specified <code><a href="#max-age">maximumAge</a></code>, then it must acquire a new position
   object. In case of a <code><a href="#watch-position">watchPosition()</a></code>, the <code><a href="#max-age">maximumAge</a></code> refers to the first position object
   returned by the implementation.</p>


  <h3 id="position_interface"><span class="secno">5.3 </span>Position interface</h3>

  <p>The <code><a href="#position">Position</a></code> interface is the
   container for the geolocation information returned by this API. This
   version of the specification allows one attribute of type <code><a href="#coordinates">Coordinates</a></code> and a 
   <code><a href="#timestamp">timestamp</a></code>. Future versions of the API
   may allow additional attributes that provide other information about this
   position (e.g. street addresses).

  </p><pre class="idl">  [NoInterfaceObject]
  interface <dfn id="position">Position</dfn> {
    readonly attribute <a href="#coordinates">Coordinates</a> <a href="#coords">coords</a>;
    readonly attribute DOMTimeStamp <a href="#timestamp">timestamp</a>;
  };
  </pre>

  <p>The <dfn id="coords"><code>coords</code></dfn> attribute contains a set of
   geographic coordinates together with their associated accuracy, as well as
   a set of other optional attributes such as altitude and speed.

  </p><p>The <dfn id="timestamp"><code>timestamp</code></dfn> attribute represents
   the time when the <code><a href="#position">Position</a></code> object was
   acquired and is represented as a DOMTimeStamp <a href="#ref-domtimestamp">[DOMTIMESTAMP]</a>.

  </p><h3 id="coordinates_interface"><span class="secno">5.4 </span>Coordinates
   interface</h3>

  <pre class="idl">  [NoInterfaceObject]
  interface <dfn id="coordinates">Coordinates</dfn> {
    readonly attribute double <a href="#lat">latitude</a>;
    readonly attribute double <a href="#lon">longitude</a>;
    readonly attribute double? <a href="#altitude">altitude</a>;
    readonly attribute double <a href="#accuracy">accuracy</a>;
    readonly attribute double? <a href="#altitude-accuracy">altitudeAccuracy</a>;
    readonly attribute double? <a href="#heading">heading</a>;
    readonly attribute double? <a href="#speed">speed</a>;
  };
  </pre>

  <p>The geographic coordinate reference system used by the attributes in
   this interface is the World Geodetic System (2d) <a href="#ref-wgs">[WGS84]</a>. No other reference system is supported.

  </p><p>The <dfn id="lat"><code>latitude</code></dfn> and <dfn id="lon"><code>longitude</code></dfn> attributes are geographic coordinates
   specified in decimal degrees.

  </p><p>The <dfn id="altitude"><code>altitude</code></dfn> attribute denotes the
   height of the position, specified in meters above the <a href="#ref-wgs">[WGS84]</a> ellipsoid. If the implementation cannot
   provide altitude information, the value of this attribute must be null.

  </p><p>The <dfn id="accuracy"><code>accuracy</code></dfn> attribute denotes the
   accuracy level of the latitude and longitude coordinates. It is specified
   in meters and must be supported by all implementations. The value of the accuracy
   attribute must be a non-negative real number.

  </p><p>The <dfn id="altitude-accuracy"><code>altitudeAccuracy</code></dfn>
   attribute is specified in meters. If the implementation cannot provide
   altitude information, the value of this attribute must be null. Otherwise,
   the value of the altitudeAccuracy attribute must be a non-negative real number.

  </p><p>The <code><a href="#accuracy">accuracy</a></code> and <code><a href="#altitude-accuracy">altitudeAccuracy</a></code> values returned by
   an implementation should correspond to a 95% confidence level.

  </p><p>The <dfn id="heading"><code>heading</code></dfn> attribute denotes the
   direction of travel of the hosting device and is specified in degrees,
   where 0° ≤ heading &lt; 360°, counting clockwise relative to the true north.
   If the implementation cannot provide heading information, the value of this
   attribute must be null. If the hosting device is stationary (i.e. the value
   of the <code>speed</code> attribute is 0), then the value of the heading
   attribute must be NaN.

  </p><p>The <dfn id="speed"><code>speed</code></dfn> attribute denotes the magnitude
   of the horizontal component of the hosting device's current velocity and is
   specified in meters per second.
   If the implementation cannot provide speed information, the value of this
   attribute must be null. Otherwise, the value of the speed attribute must be
   a non-negative real number.

  </p><h3 id="position_error_interface"><span class="secno">5.5
   </span>PositionError interface</h3>

  <pre class="idl">  [NoInterfaceObject]
  interface <dfn id="position-error">PositionError</dfn> {
    const unsigned short <a href="#permission_denied_error">PERMISSION_DENIED</a> = 1;
    const unsigned short <a href="#position_unavailable_error">POSITION_UNAVAILABLE</a> = 2;
    const unsigned short <a href="#timeout_error">TIMEOUT</a> = 3;
    readonly attribute unsigned short <a href="#code">code</a>;
    readonly attribute DOMString <a href="#message">message</a>;
  };
  </pre>

  <p>The <dfn id="code"><code>code</code></dfn> attribute must return the
   appropriate code from the following list:

  </p><dl>
   <dt><dfn id="permission_denied_error"><code>PERMISSION_DENIED</code></dfn>
    (numeric value 1)

   </dt><dd>The location acquisition process failed because the document
    does not have permission to use the Geolocation API.

   </dd><dt><dfn id="position_unavailable_error"><code>POSITION_UNAVAILABLE</code></dfn>
    (numeric value 2)

   </dt><dd>The position of the device could not be determined. For instance, one or more of the
    location providers used in the location acquisition process reported an
    internal error that caused the process to fail entirely.

   </dd><dt><dfn id="timeout_error"><code>TIMEOUT</code></dfn> (numeric value 3)

   </dt><dd>The length of time specified by the <code><a href="#timeout">timeout</a></code>
    property has elapsed before the implementation could successfully acquire a
    new <code><a href="#position">Position</a></code> object.
  </dd></dl>

  <p>The <dfn id="message"><code>message</code></dfn> attribute must return an
   error message describing the details of the error encountered. This
   attribute is primarily intended for debugging and developers should not
   use it directly in their application user interface.

  </p><h2 id="usecases"><span class="secno">6 </span>Use-Cases and Requirements</h2>

  <h3 id="usecases_section"><span class="secno">6.1 </span>Use-Cases</h3>

  <h4 id="usecase_find_poi"><span class="secno">6.1.1 </span>Find points of
   interest in the user's area</h4>

  <p>Someone visiting a foreign city could access a Web application that
   allows users to search or browse through a database of tourist
   attractions. Using the Geolocation API, the Web application has access to
   the user's approximate position and it is therefore able to rank the
   search results by proximity to the user's location.

  </p><h4 id="usecase_content_annotation"><span class="secno">6.1.2
   </span>Annotating content with location information</h4>

  <p> A group of friends is hiking through the Scottish highlands. Some of
   them write short notes and take pictures at various points throughout the
   journey and store them using a Web application that can work offline on
   their hand-held devices. Whenever they add new content, the application
   automatically tags it with location data from the Geolocation API (which,
   in turn, uses the on-board GPS device). Every time they reach a town or a
   village, and they are again within network coverage, the application
   automatically uploads their notes and pictures to a popular blogging Web
   site, which uses the geolocation data to construct links that point to a
   mapping service. Users who follow the group's trip can click on these
   links to see a satellite view of the area where the notes were written and
   the pictures were taken. Another example is a life blog where a user
   creates content (e.g. images, video, audio) that records her every day
   experiences. This content can be automatically annotated with information
   such as time, geographic position or even the user's emotional state at
   the time of the recording.

  </p><h4 id="usecase_show_position"><span class="secno">6.1.3 </span>Show the
   user's position on a map</h4>

  <p>A user finds herself in an unfamiliar city area. She wants to check her
   position so she uses her hand-held device to navigate to a Web-based
   mapping application that can pinpoint her exact location on the city map
   using the Geolocation API. She then asks the Web application to provide
   driving directions from her current position to her desired destination.

  </p><h4 id="usecase_turn_by_turn"><span class="secno">6.1.4 </span>Turn-by-turn
   route navigation</h4>

  <p>A mapping application can help the user navigate along a route by
   providing detailed turn-by-turn directions. The application does this by
   registering with the Geolocation API to receive repeated location updates
   of the user's position. These updates are delivered as soon as the
   implementing user agent determines that the position of the user has
   changed, which allows the application to anticipate any changes of
   direction that the user might need to do.

  </p><h4 id="usecase_poi_alert"><span class="secno">6.1.5 </span>Alerts when
   points of interest are in the user's vicinity</h4>

  <p>A tour-guide Web application can use the Geolocation API to monitor the
   user's position and trigger visual or audio notifications when interesting
   places are in the vicinity. An online task management system can trigger
   reminders when the user is in the proximity of landmarks that are
   associated with certain tasks.

  </p><h4 id="usecase_local_info"><span class="secno">6.1.6 </span>Up-to-date local
   information</h4>

  <p>A widget-like Web application that shows the weather or news that are
   relevant to the user's current area can use the Geolocation API to
   register for location updates. If the user's position changes, the widget
   can adapt the content accordingly.

  </p><h4 id="usecase_social_networking"><span class="secno">6.1.7
   </span>Location-tagged status updates in social networking applications</h4>

  <p>A social network application allows its users to automatically tag their
   status updates with location information. It does this by monitoring the
   user's position with the Geolocation API. Each user can control the
   granularity of the location information (e.g. city or neighborhood level)
   that is shared with the other users. Any user can also track his network
   of friends and get real-time updates about their current location.

  </p><h3 id="requirements_section"><span class="secno">6.2 </span>Requirements</h3>

  <h4 id="req_latlong"><span class="secno">6.2.1 </span>The Geolocation API
   must provide location data in terms of a pair of latitude and longitude
   coordinates.</h4>

  <h4 id="req_accuracy"><span class="secno">6.2.2 </span>The Geolocation API
   must provide information about the accuracy of the retrieved location
   data.</h4>

  <h4 id="req_oneshot"><span class="secno">6.2.3 </span>The Geolocation API
   must support "one-shot" position updates.</h4>

  <h4 id="req_updates"><span class="secno">6.2.4 </span>The Geolocation API
   must allow an application to register to receive updates when the position
   of the hosting device changes.</h4>

  <h4 id="req_last_known"><span class="secno">6.2.5 </span>The Geolocation API
   must allow an application to request a cached position whose age is no
   greater than a specified value.</h4>

  <h4 id="req_errors"><span class="secno">6.2.6 </span>The Geolocation API must
   provide a way for the application to receive updates about errors that may
   have occurred while obtaining a location fix.</h4>

  <h4 id="req_request_acuracy"><span class="secno">6.2.7 </span>The Geolocation
   API must allow an application to specify a desired accuracy level of the
   location information.</h4>

  <h4 id="req_source_agnostic"><span class="secno">6.2.8 </span>The Geolocation
   API must be agnostic to the underlying sources of location information.</h4>

  <h2 class="no-num" id="acknowledgments">Acknowledgments</h2>

  <p>Alec Berntson, Alissa Cooper, Steve Block, Greg Bolsinga, Lars Erik Bolstad, Aaron Boodman,
   Dave Burke, Chris Butler, Max Froumentin, Shyam Habarakada, Marcin
   Hanclik, Ian Hickson, Brad Lassey, Angel Machin, Cameron McCormack, Daniel
   Park, Stuart Parmenter, Olli Pettay, Chris Prince, Arun Ranganathan, Aza
   Raskin, Carl Reed, Thomas Roessler, Dirk Segers, Allan Thomson, Martin
   Thomson, Doug Turner, Erik Wilde, Matt Womer, Mohamed Zergaoui

  </p><h2 class="no-num" id="references">References</h2>

  <dl>
   <dt><a id="ref-azaloc">[AZALOC]</a>

   </dt><dd><em>(Non-normative)</em> <cite><a href="http://www.azarask.in/blog/post/geolocation-in-firefox-and-beyond/">Geolocation in Firefox and Beyond</a></cite>, Aza Raskin. See http://azarask.in/blog/post/geolocation-in-firefox-and-beyond

   </dd><dt><a id="ref-context">[BROWSINGCONTEXT]</a>

   </dt><dd><cite><a href="http://www.w3.org/TR/2014/REC-html5-20141028/browsers.html#windows"> The browsing context in HTML5</a></cite>, Ian Hickson, Robin Berjon, Steve Faulkner, Travis Leithead, Erika Doyle Navara, Theresa O'Connor, Silvia Pfeiffer, Editors.  World Wide Web Consortium.  See http://www.w3.org/TR/2014/REC-html5-20141028/browsers.html#windows

   </dd><dt><a id="ref-uri">[URI]</a>

   </dt><dd><cite><a href="http://www.ietf.org/rfc/rfc2396.txt">Uniform Resource Identifiers (URI): Generic Syntax</a></cite>, T. Berners-Lee, R. Fielding, L. Masinter, Editors. Internet Engineering Task Force. See http://www.ietf.org/rfc/rfc2396.txt

   </dd><dt><a id="ref-navigator">[NAVIGATOR]</a>

   </dt><dd><cite><a href="http://www.w3.org/TR/2014/REC-html5-20141028/webappapis.html#navigator">Navigator interface in HTML5</a></cite>, Ian Hickson, Robin Berjon, Steve Faulkner, Travis Leithead, Erika Doyle Navara, Theresa O'Connor, Silvia Pfeiffer, Editors.  World Wide Web Consortium.  See http://www.w3.org/TR/2014/REC-html5-20141028/webappapis.html#navigator

   </dd><dt><a id="ref-domtimestamp">[DOMTIMESTAMP]</a>

   </dt><dd><cite><a href="http://www.w3.org/TR/2012/CR-WebIDL-20120419/#common-DOMTimeStamp"> The DOMTimeStamp Type</a></cite>, Cameron McCormack, Editor. World Wide Web Consortium, 19 April 2012.  See http://www.w3.org/TR/2012/CR-WebIDL-20120419/#common-DOMTimeStamp

   </dd><dt><a id="ref-gears">[GEARSLOC]</a>

   </dt><dd><em>(Non-normative)</em> <cite><a href="http://code.google.com/apis/gears/api_geolocation.html">Gears Geolocation API</a></cite>. See http://code.google.com/apis/gears/api_geolocation.html [historical]

   </dd><dt><a id="ref-locationaware">[LOCATIONAWARE]</a>

   </dt><dd><em>(Non-normative)</em><cite> <a href="http://cdn.oreillystatic.com/en/assets/1/event/4/LocationAware_%20Standardizing%20a%20Geolocation%20API%20in%20the%20Browser%20Presentation.pdf">LocationAware.org</a></cite>. See http://cdn.oreillystatic.com/en/assets/1/event/4/LocationAware_%20Standardizing%20a%20Geolocation%20API%20in%20the%20Browser%20Presentation.pdf [historical]

   </dd><dt><a id="ref-rfc2119">[RFC2119]</a>

   </dt><dd><cite><a href="http://www.ietf.org/rfc/rfc2119.txt">Key words for use in RFCs to Indicate Requirement Levels</a></cite>, Scott Bradner.  Internet Engineering Task Force, March 1997. See http://www.ietf.org/rfc/rfc2119.txt
   
   </dd><dt><a id="ref-webidl">[WEBIDL]</a>

   </dt><dd><cite><a href="http://www.w3.org/TR/2012/CR-WebIDL-20120419/">web IDL</a></cite>, Cameron McCormack, Editor.  World Wide Web Consortium, 19 April 2012. See http://www.w3.org/TR/2012/CR-WebIDL-20120419/

   </dd><dt><a id="ref-wgs">[WGS84]</a>

   </dt><dd><cite><a href="http://earth-info.nga.mil/GandG/publications/tr8350.2/wgs84fin.pdf">National Imagery and Mapping Agency Technical Report 8350.2, Third Edition</a></cite>.  National Imagery and Mapping Agency, 3 January 2000.  See http://earth-info.nga.mil/GandG/publications/tr8350.2/wgs84fin.pdf
  </dd></dl>

<p role="navigation" id="back-to-top"><a href="#toc"><abbr title="Back to top">↑</abbr></a></p>
<script src="//www.w3.org/scripts/TR/2016/fixup.js"></script>
</body></html>