<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <title>
      The Screen Orientation API
    </title>
    <script src='https://www.w3.org/Tools/respec/respec-w3c-common' class=
    'remove'></script>
    <script class='remove'>
    var respecConfig = {
      specStatus: "ED",
      shortName: "screen-orientation",
      previousPublishDate: "2019-05-30",
      previousMaturity: "WD",
      editors: [
        {
          name: "Mounir Lamouri",
          company: "Google Inc.",
          w3cid: 45389,
        },
        {
          name: "Marcos Cáceres",
          company: "Mozilla",
          w3cid: 39125,
        },
        {
          name: "Johanna Herman",
          company: "Invited Expert",
          w3cid: 111724,
        }
      ],
      testSuiteURI:
        "https://w3c-test.org/screen-orientation/",
      github: "w3c/screen-orientation",
      wg: "Web Applications Working Group",
      wgURI: "https://www.w3.org/2019/webapps/",
      wgPatentURI: "https://www.w3.org/2004/01/pp-impl/114929/status",
      caniuse: "screen-orientation",
      xref: "web-platform",
    };
    </script>
  </head>
  <body>
    <section id='abstract'>
      <p>
        The <cite>Screen Orientation API</cite> provides the ability to read
        the screen orientation type and angle, to be informed when the screen
        orientation changes, and to lock the screen to a specific orientation.
      </p>
    </section>
    <section id='sotd'>
      <p>
        This document is a work in progress.
      </p>
    </section>
    <section class="informative">
      <h2>
        Introduction
      </h2>
      <p>
        For web applications, the <cite>Screen Orientation API</cite> exposes
        the type and angle of a device's current screen orientation, and can
        provide notification if the device's orientation changes. This allows
        web applications to programmatically adapt the user experience for many
        possible screen orientations (in concert with CSS). The API also allows
        locking the screen to a particular orientation. This is useful in
        applications such as computer games where users physically rotate the
        device but the screen orientation itself mustn't change.
      </p>
      <section>
        <h2>
          Goals
        </h2>
        <ul>
          <li>Allow a web application to have control over screen orientation
          where needed and without being intrusive to end users.
          </li>
          <li>Support a better user experience by providing developers with
          information on screen orientation changes so web applications can
          update correspondingly.
          </li>
        </ul>
      </section>
      <section class='informative'>
        <h2>
          Examples
        </h2>
        <section>
          <h2>
            Locking to a specific orientation and unlocking
          </h2>
          <p>
            In this example, clicking the "Lock" button makes a request to go
            into fullscreen and then lock the screen to the opposite
            orientation. Pressing the "Unlock" button unlocks the screen so it
            rotates if the user turns the device.
          </p>
          <p>
            The developer console logs the change in orientation type and
            angle.
          </p>
          <pre class='example html'>
            &lt;script&gt;
            function fullScreenCheck() {
              if (document.fullscreenElement) return;
              return document.documentElement.requestFullscreen();
            }

            function updateDetails(lockButton) {
              const buttonOrientation = getOppositeOrientation();
              lockButton.textContent = `Lock to ${buttonOrientation}`;
            }

            function getOppositeOrientation() {
              const { type } = screen.orientation;
              return type.startsWith("portrait") ? "landscape" : "portrait";
            }

            async function rotate(lockButton) {
              try {
                await fullScreenCheck();
              } catch (err) {
                console.error(err);
              }
              const newOrientation = getOppositeOrientation();
              await screen.orientation.lock(newOrientation);
              updateDetails(lockButton);
            }

            function show() {
              const { type, angle } = screen.orientation;
              console.log(`Orientation type is ${type} & angle is ${angle}.`);
            }

            screen.orientation.addEventListener("change", () =&gt; {
              show();
              updateDetails(document.getElementById("button"));
            });

            window.addEventListener("load", () =&gt; {
              show();
              updateDetails(document.getElementById("button"));
            });
            &lt;/script&gt;

            &lt;button onclick="rotate(this)" id="button"&gt;
              Lock
            &lt;/button&gt;
            &lt;button onclick="screen.orientation.unlock()"&gt;
              Unlock
            &lt;/button&gt;
          </pre>
        </section>
        <section>
          <h2>
            Locking the screen before calling a function
          </h2>
          <p>
            This example waits to go into fullscreen, then locks to landscape
            before calling `ready()`.
          </p>
          <pre class='example html'>
            &lt;script&gt;
            function ready() {
              const { type } = screen.orientation;
              console.log(`Fullscreen and locked to ${type}. Ready!`);
            }

            async function start() {
              await document.body.requestFullscreen();
              await screen.orientation.lock("landscape");
              ready();
            }
            &lt;/script&gt;
            &lt;button onclick="start()"&gt;
              Start
            &lt;/button&gt;
          </pre>
        </section>
        <section>
          <h2>
            Alerting the user if the API is not supported
          </h2>
          <p data-link-for="ScreenOrientation">
            In this example, if the <cite>Screen Orientation API</cite> is not
            supported, or the screen orientation {{lock()}} rejects, the user
            is alerted to rotate their screen manually to landscape.
          </p>
          <pre class='example html'>
            &lt;script&gt;
            function start() {
              /* Start application when in correct orientation */
            }
            async function rotate() {
              try {
                await screen.orientation.lock("landscape");
                start();
              } catch (err) {
                console.error(err);
              }
              const matchLandscape = matchMedia("(orientation: landscape)");
              if (matchLandscape.matches) return start();
              addEventListener("orientationchange", function listener() {
                matchLandscape.addListener(function mediaChange(e) {
                  if (!e.matches) return;
                  removeEventListener("orientationchange", listener);
                  matchLandscape.removeListener(mediaChange);
                  start();
                });
              });
              alert("To start, please rotate your screen to landscape.");
            }
            &lt;/script&gt;
            &lt;button onclick="start()"&gt;
              Start
            &lt;/button&gt;
          </pre>
        </section>
      </section>
    </section>
    <section data-dfn-for='Screen'>
      <h2>
        Extensions to the `Screen` interface
      </h2>
      <p>
        The [[[CSSOM-View]]] specification defines the <code><dfn data-cite=
        "CSSOM-View#screen">Screen</dfn></code> interface, which this
        specification extends:
      </p>
      <pre class='idl'>
          partial interface Screen {
            [SameObject] readonly attribute ScreenOrientation orientation;
          };
        </pre>
      <section>
        <h2>
          <dfn>orientation</dfn> attribute
        </h2>
        <p>
          The {{Screen.orientation}} attribute is an instance of
          {{ScreenOrientation}}. This attribute provides the current
          orientation, current angle and whether there was an onchange event.
          The <a>user agent</a> MUST run the <a>update the orientation
          information</a> algorithm steps to initialize the values and return
          the {{Screen.orientation}} attribute.
        </p>
      </section>
    </section>
    <section data-dfn-for='ScreenOrientation' data-link-for=
    'ScreenOrientation'>
      <h2>
        <dfn>ScreenOrientation</dfn> interface
      </h2>
      <pre class='idl' data-cite="DOM HTML">
          [Exposed=Window]
          interface ScreenOrientation : EventTarget {
            Promise&lt;void&gt; lock(OrientationLockType orientation);
            void unlock();
            readonly attribute OrientationType type;
            readonly attribute unsigned short angle;
            attribute EventHandler onchange;
          };

          enum OrientationLockType {
            "any",
            "natural",
            "landscape",
            "portrait",
            "portrait-primary",
            "portrait-secondary",
            "landscape-primary",
            "landscape-secondary"
          };

          enum OrientationType {
            "portrait-primary",
            "portrait-secondary",
            "landscape-primary",
            "landscape-secondary"
          };
      </pre>
      <p data-dfn-for="OrientationLockType">
        The <dfn>OrientationLockType</dfn> enum represents the screen
        orientations to which a screen can be locked: the "<dfn>any</dfn>" enum
        value represents the <a>any</a> orientation, the "<dfn>natural</dfn>"
        enum represents the <a>natural</a> orientation, the
        "<dfn>landscape</dfn>" enum represents the <a>landscape</a>
        orientation, the "<dfn>portrait</dfn>" enum represents the
        <a>portrait</a> orientation, the "<dfn>portrait-primary</dfn>" enum
        represents the <a>portrait-primary</a> orientation, the
        "<dfn>portrait-secondary</dfn>" enum represents the
        <a>portrait-secondary</a> orientation, the
        "<dfn>landscape-primary</dfn>" enum represents the
        <a>landscape-primary</a> orientation, and the
        "<dfn>landscape-secondary</dfn>" enum represents the
        <a>landscape-secondary</a> orientation.
      </p>
      <p data-dfn-for="OrientationType">
        The <dfn>OrientationType</dfn> enum represents the actual current
        screen orientation that the screen is in irrespective of which lock is
        applied: the "<dfn>portrait-primary</dfn>" enum represents the
        <a>portrait-primary</a> orientation, the
        "<dfn>portrait-secondary</dfn>" enum represents the
        <a>portrait-secondary</a> orientation, the
        "<dfn>landscape-primary</dfn>" enum represents the
        <a>landscape-primary</a> orientation, and the
        "<dfn>landscape-secondary</dfn>" enum represents the
        <a>landscape-secondary</a> orientation.
      </p>
      <section>
        <h2>
          <dfn>lock()</dfn> method: Lock screen to a specific orientation
        </h2>
        <p data-tests="lock-bad-argument.html, lock-basic.html">
          When the {{lock()}} method is invoked, the <a>user agent</a> MUST run
          the <a>apply an orientation lock</a> steps to the [=environment
          settings object / responsible document=] using |orientation|.
        </p>
      </section>
      <section>
        <h2>
          <dfn>unlock()</dfn> method: Unlock screen to default orientation
        </h2>
        <p>
          When the {{unlock()}} method is invoked, the <a>user agent</a> MUST
          run the steps to <a>lock the orientation</a> of the [=environment
          settings object / responsible document=] to its <a>default screen
          orientation</a>.
        </p>
        <p class='note' title="Why does unlock() not return a promise?">
          {{unlock()}} does not return a promise because it is equivalent to
          locking to the <a>default screen orientation</a> which might or might
          not be known by the <a>user agent</a>. Hence, the <a>user agent</a>
          can not predict what the new orientation is going to be and even if
          it is going to change at all.
        </p>
        <div class="issue" data-number="104"></div>
      </section>
      <section>
        <h2>
          <dfn>type</dfn> attribute: Get current orientation
        </h2>
        <p>
          When getting the {{type}} attribute, the <a>user agent</a> MUST
          return the [=environment settings object / responsible document=]'s
          <a>current orientation type</a>.
        </p>
      </section>
      <section>
        <h2>
          <dfn>angle</dfn> attribute: Get orientation angle
        </h2>
        <p>
          When getting the {{angle}} attribute, the <a>user agent</a> MUST
          return the [=environment settings object / responsible document=]'s
          <a>current orientation angle</a>.
        </p>
        <div class='note' title=
        "What does the value given for angle represent?">
          <p>
            {{angle}} represents how far the user has turned the device
            counterclockwise from the natural orientation. When the device is
            rotated 90° counterclockwise, the screen compensates by rotating
            90° clockwise, so {{angle}} returns `90`.
          </p>
          <p>
            The <a>screen orientation values table</a> shows how the angle
            changes depending on the how the device is rotated.
          </p>
          <p>
            The value returned by this property is always in the range 0-359.
            It never returns negative values.
          </p>
        </div>
      </section>
      <section>
        <h2>
          <dfn>onchange</dfn> attribute: Handle orientation changes
        </h2>
      </section>
      <p>
        The {{onchange}} attribute is an <a>event handler</a> whose
        corresponding <a>event handler event type</a> is `"change"`.
      </p>
    </section>
    <section>
      <h2>
        Extensions to the `Document` interface
      </h2>
      <section>
        <h2>
          Internal Slots
        </h2>
        <table class="simple">
          <thead>
            <tr>
              <th>
                Internal Slot
              </th>
              <th>
                Description
              </th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>
                <dfn>[[\orientationLock]]</dfn>
              </td>
              <td>
                The {{[[orientationLock]]}} represents a <a>document</a>'s
                <a>orientation lock</a> as an <a>ordered set</a> of
                {{OrientationType}}.
              </td>
            </tr>
            <tr>
              <td>
                <dfn>[[\defaultOrientation]]</dfn>
              </td>
              <td>
                An <a>ordered set</a> of orientations to which the screen
                orientation is locked when not explicitly locked by this API or
                any other means.
              </td>
            </tr>
            <tr>
              <td>
                <dfn>[[\orientationPendingPromise]]</dfn>
              </td>
              <td>
                Either `null` or a {{Promise}}. When assigned a {{Promise}},
                that promise represents a request to lock the screen to one of
                the supported orientations. The promise resolves after locking
                the orientation succeeds or rejects if locking fails.
              </td>
            </tr>
          </tbody>
        </table>
      </section>
    </section>
    <section>
      <h2>
        Concepts
      </h2>
      <p>
        The term <dfn data-lt="screen concept" data-lt-nodefault=
        "">screen</dfn> is equivalent to the screen of the output device
        associated to the {{Window}}, as per [[CSSOM-VIEW]].
      </p>
      <p>
        Algorithms defined in this specification assume that for each
        <a>document</a> there is an {{[[orientationPendingPromise]]}}.
      </p>
      <section>
        <h2>
          Screen orientation types and locks
        </h2>
        <p>
          <dfn>Landscape-primary</dfn> is an orientation where the screen width
          is greater than the screen height. If the device's natural
          orientation is landscape, then it is in landscape-primary when held
          in that position. If the device's natural orientation is portrait,
          the <a>user agent</a> sets landscape-primary from the two options as
          shown in the <a>screen orientation values table</a>.
        </p>
        <p>
          <dfn>Landscape-secondary</dfn> is an orientation where the screen
          width is greater than the screen height. If the device's natural
          orientation is landscape, it is in landscape-secondary when rotated
          180º from its natural orientation. If the device's natural
          orientation is portrait, the <a>user agent</a> sets
          landscape-secondary from the two options as shown in the <a>screen
          orientation values table</a>.
        </p>
        <p>
          <dfn>Portrait-primary</dfn> is an orientation where the screen width
          is less than or equal to the screen height. If the device's natural
          orientation is portrait, then it is in portrait-primary when held in
          that position. If the device's natural orientation is landscape, the
          <a>user agent</a> sets portrait-primary from the two options as shown
          in the <a>screen orientation values table</a>.
        </p>
        <p>
          <dfn>Portrait-secondary</dfn> is an orientation where the screen
          width is less than or equal to the screen height. If the device's
          natural orientation is portrait, then it is in portrait-secondary
          when rotated 180º from its natural position. If the device's natural
          orientation is landscape, the <a>user agent</a> sets
          portrait-secondary from the two options as shown in the <a>screen
          orientation values table</a>.
        </p>
        <p>
          <dfn>Portrait</dfn> is an orientation where the screen width is less
          than or equal to the screen height and depending on platform
          convention locking the screen to portrait can represent
          portrait-primary, portrait-secondary or both.
        </p>
        <p>
          <dfn>Landscape</dfn> is an orientation where the screen width is
          greater than the screen height and depending on platform convention
          locking the screen to landscape can represent landscape-primary,
          landscape-secondary or both.
        </p>
        <p>
          <dfn>Natural</dfn> is an orientation that refers to either
          portrait-primary or landscape-primary depending on the device's usual
          orientation. This orientation is usually provided by the underlying
          operating system.
        </p>
        <p>
          <dfn>Any</dfn> is an orientation that means the screen can be locked
          to any one of portrait-primary, portrait-secondary, landscape-primary
          and landscape-secondary.
        </p>
        <p>
          The <dfn data-export="">default screen orientation</dfn> is the set of
          orientations to which the screen is locked when there is no current
          <a>orientation lock</a>. This orientation is determined by the
          device's operating system, or the user agent (e.g., <a href=
          "#interaction-with-web-application-manifest"></a>), or controlled by
          the end-user.
        </p>
        <div class="issue" data-number="150"></div>
      </section>
      <section data-dfn-for='OrientationType' data-link-for="OrientationType">
        <h2>
          Reading the screen orientation
        </h2>
        <p>
          All <a>documents</a> have a <dfn>current orientation type</dfn> and a
          <dfn>current orientation angle</dfn>. Both of them SHOULD be
          initialized when the <a>document</a> is created, otherwise they MUST
          be initialized the first time they are accessed and before their
          value is read. The <a>user agent</a> MUST <a>update the orientation
          information</a> of the <a>document</a> to initialize them.
        </p>
        <p>
          For a given <a>document</a>, the <a>current orientation type</a> and
          the <a>current orientation angle</a> are strongly linked in the sense
          that for any given type, there will be a specific angle associated.
        </p>
        <p>
          One primary orientation will always be determined by the
          <a>natural</a> orientation of the device and this will then determine
          the secondary value of its related orientation.
        </p>
        <p>
          For example a device held in its natural <a>portrait</a> orientation
          would have a current orientation of <a>portrait-primary</a> and its
          <a>portrait-secondary</a> orientation would be its position when
          rotated 180°.
        </p>
        <p>
          The <a>user agent</a> can associate the other `*-primary` and
          `*-secondary` values at will. For example, it can be based on the
          device preferred angles, the user's preferred orientations or the
          current orientation when the application starts.
        </p>
        <p>
          The <a>screen orientation values table</a> presents the possible
          orientation types: <a>portrait-primary</a>,
          <a>portrait-secondary</a>, <a>landscape-primary</a> and
          <a>landscape-secondary</a>. The table shows the primary and secondary
          values that are determined by the device's <a>natural</a> orientation
          and the possibilities available to the <a>user agent</a> for setting
          the other primary and secondary orientation values.
        </p>
        <table class="simple">
          <caption>
            The <dfn>screen orientation values table</dfn>
          </caption>
          <thead>
            <tr>
              <th>
                Natural Orientation
              </th>
              <th>
                Primary Orientation 1
              </th>
              <th>
                Secondary Orientation 1
              </th>
              <th>
                Primary Orientation 2
              </th>
              <th>
                Secondary Orientation 2
              </th>
            </tr>
          </thead>
          <tbody data-link-for="ScreenOrientation">
            <tr>
              <td>
                <a>Portrait</a>
              </td>
              <td>
                <a>portrait-primary</a><br>
                {{angle}} `0`
              </td>
              <td>
                <a>portrait-secondary</a><br>
                {{angle}} `180`
              </td>
              <td>
                <a>landscape-primary</a><br>
                <a>User agent</a> to set at either {{angle}} `90` or {{angle}}
                `270`
              </td>
              <td>
                <a>landscape-secondary</a><br>
                Set at the angle not used for landscape-primary
              </td>
            </tr>
            <tr>
              <td>
                <a>Landscape</a>
              </td>
              <td>
                <a>landscape-primary</a><br>
                {{angle}} `0`
              </td>
              <td>
                <a>landscape-secondary</a><br>
                {{angle}} `180`
              </td>
              <td>
                <a>portrait-primary</a><br>
                <a>User agent</a> to set at either {{angle}} `90` or {{angle}}
                `270`
              </td>
              <td>
                <a>portrait-secondary</a><br>
                Set at the angle not used for portrait-primary
              </td>
            </tr>
          </tbody>
        </table>
        <p>
          Once the <a>user agent</a> has set the primary and secondary values
          from the options in the <a>screen orientation values table</a>, the
          <a>current orientation type</a> and the <a>current orientation
          angle</a> relation MUST be kept consistent for any given
          <a>document</a>.
        </p>
        <div class='practice'>
          <p class='practicedesc'>
            <span class='practicelab'>{{ScreenOrientation.angle}} and
            {{ScreenOrientation.type}} relationship</span> Never assume any
            cross-devices relationship between the screen orientation type and
            the screen orientation angle. Any assumption would be wrong given
            that a device might have `90` and `270` as the angles for
            `landscape` types but another device will have `0` and `180`,
            depending on its <a>natural</a> orientation. Instead, it is
            recommended to check during runtime the relationship between angle
            and type.
          </p>
        </div>
      </section>
      <section data-dfn-for='OrientationLockType'>
        <h2>
          Locking the screen orientation
        </h2>
        <p>
          The <a>user agent</a> MAY require a <a>document</a> and its
          associated [=Document/browsing context=] to meet one or more
          <dfn>pre-lock conditions</dfn> in order to lock the screen
          orientation. For example, a <a>user agent</a> might require a
          <a>document</a>'s <a>top-level browsing context</a> to be fullscreen
          (see <a href='#interaction-with-fullscreen-api'></a>) in order to
          allow an <a>orientation lock</a>.
        </p>
        <p>
          The <a>user agent</a> MAY reject all attempts to lock the screen
          orientation if the platform conventions do not expect applications to
          be able to change the screen orientation. For example, on most
          desktop platforms, applications can not change the screen
          orientation.
        </p>
        <p>
          If the <a>user agent</a> supports locking the screen orientation, it
          MUST allow the screen to be locked to all of the states of the
          {{OrientationLockType}} enum.
        </p>
        <p>
          The {{[[orientationLock]]}} internal slot represents the
          <a>document</a>'s <a>orientation lock</a>.
        </p>
        <p>
          An <dfn>orientation lock</dfn> is in place when the screen has
          successfully been locked to a specific orientation.
        </p>
        <section>
          <h2>
            Locking to the default orientation
          </h2>
          <p>
            From the perspective of a <a>document</a>, locking to the
            <a>default screen orientation</a> is equivalent to unlocking
            because it means that it no longer has a lock applied.
          </p>
          <p class="note" title="Who controls the default orientation?">
            This does not mean that the {{[[defaultOrientation]]}} will only
            contain the item <a>any</a>. The <a>default screen orientation</a>
            is likely device-specific and {{[[defaultOrientation]]}} could for
            example contain <a>portrait-primary</a> and/or
            <a>landscape-primary</a>. Alternatively, the user could restrict
            the default orientation to a specific orientation via some OS or
            browser level preference for accessibility reasons. The user agent
            can also set the default orientation e.g., <a href=
            "#interaction-with-web-application-manifest"></a>.
          </p>
        </section>
      </section>
    </section>
    <section>
      <h2>
        Interactions with other specifications
      </h2>
      <p>
        This section explains how this specification interacts with other
        related specifications of the platform.
      </p>
      <section>
        <h2>
          Interaction with Fullscreen API
        </h2>
        <p>
          As a <a>pre-lock condition</a>, a user agent MAY restrict locking the
          screen orientation exclusively to when the <a>top-level browsing
          context</a>'s <a>document</a>'s is full screen. When that <a>pre-lock
          condition</a> applies, whenever the <a>document</a>'s <a>fullscreen
          element</a> is empty and a screen <a>orientation lock</a> is applied,
          the <a>user agent</a> MUST <a>lock the orientation</a> of the
          <a>document</a> to the <a>document</a>'s <a>default screen
          orientation</a>.
        </p>
        <div class='issue'>
          This section could be improved if the [[FULLSCREEN]] specification
          had a hook for when the document is no longer fullscreen. See
          <a href='https://github.com/w3c/screen-orientation/issues/62'>issue
          62</a>.
        </div>
      </section>
      <section class='informative'>
        <h2>
          Interaction with Web Application Manifest
        </h2>
        <p>
          The [[[appmanifest]]] allows web applications to set the
          <a>document</a>'s <a>default screen orientation</a>.
        </p>
      </section>
      <section class='informative'>
        <h2>
          Interaction with CSS Device Adaptation
        </h2>
        <p>
          The [[[CSS-ADAPTATION]]] specification defines, independently of this
          document, a way to lock the screen orientation for a web page using
          CSS.
        </p>
      </section>
      <section class='informative'>
        <h2>
          Interaction with Web Content Accessibility Guidelines
        </h2>
        <p>
          The [[[WCAG21]]] includes a <a data-cite="WCAG21#orientation">Success
          Criterion related to screen orientation</a>.
        </p>
        <p>
          ​The intent of this Success Criterion is to ensure that all
          <a data-cite="WCAG21#dfn-essential">essential</a> content and
          functionality is available regardless of the display orientation
          (portrait or landscape). Some websites and applications automatically
          set the screen to a particular display orientation and expect that
          users will respond by rotating their device to match.
        </p>
        <p>
          However, some users may have their devices mounted in a fixed
          orientation (e.g. on the arm of a power wheelchair). Therefore,
          websites and applications need to support both orientations by making
          sure <a data-cite="WCAG21#dfn-essential">essential</a> content and
          functionality is available in each orientation. While the order of
          content and method of functionality may have differences the content
          and functionality must always be available. When a particular
          orientation is <a data-cite="WCAG21#dfn-essential">essential</a>, the
          user needs to be advised of the orientation requirements.​
        </p>
      </section>
    </section>
    <section>
      <h2>
        Algorithms
      </h2>
      <section data-link-for="OrientationType">
        <h2>
          Updating the orientation information
        </h2>
        <p data-tests="orientation-reading.html">
          The steps to <dfn>update the orientation information</dfn> of a
          <a>document</a> are as follows:
        </p>
        <ol class="algorithm">
          <li>If the screen width is greater than the screen height, set the
          <a>document</a>'s <a>current orientation type</a> to
          <a>landscape-primary</a> or <a>landscape-secondary</a>.
          </li>
          <li>Otherwise, if the screen width is less than or equal to the
          screen height, set the <a>document</a>'s <a>current orientation
          type</a> to <a>portrait-primary</a> or <a>portrait-secondary</a>.
          </li>
          <li data-tests="orientation-reading.html">Set the <a>document</a>'s
          <a>current orientation angle</a> to the clockwise angle in degrees
          between the orientation of the viewport as it is drawn and the
          <a>natural</a> orientation of the device (i.e., the top of the
          physical screen). This is the opposite of the physical rotation. In
          other words, if a device is turned 90 degrees on the right, the
          <a>current orientation angle</a> would be 270 degrees. The <a>screen
          orientation values table</a> gives the options for each orientation
          and possible associated angles.
          </li>
        </ol>
      </section>
      <section data-link-for="OrientationType">
        <h2>
          Apply an orientation lock
        </h2>
        <p class="algorithm">
          The steps to <dfn>apply an orientation lock</dfn> to a
          <a>document</a> using |orientation| are as follows:
        </p>
        <ol class="algorithm">
          <li>If the <a>user agent</a> does not support locking the screen
          orientation, return a promise rejected with a `"NotSupportedError"`
          {{DOMException}} and abort these steps.
          </li>
          <li data-tests="lock-sandboxed-iframe.html">If the <a>document</a>'s
          has the <a>sandboxed orientation lock browsing context flag</a> set,
          or <a>user agent</a> doesn't meet the <a>pre-lock conditions</a> to
          perform an orientation change, return a promise rejected with a
          `"SecurityError"` {{DOMException}} and abort these steps.
          </li>
          <li data-tests="lock-basic.html">Set |doc|'s
          {{[[orientationPendingPromise]]}} to a newly-created promise.
          </li>
          <li>Return |doc|'s {{[[orientationPendingPromise]]}} and <a>in
          parallel</a>:
            <ol>
              <li>Let |browsing contexts| be the <a>list of the descendant
              browsing contexts</a> of the <a>top-level browsing context</a>'s
              <a>document</a>.
              </li>
              <li>If one of the |browsing contexts|'s <a>document</a>'s
              {{[[orientationPendingPromise]]}} is not `null`:
                <ol>
                  <li>Let |doc| be the <a>document</a> which has a not `null`
                  {{[[orientationPendingPromise]]}}.
                  </li>
                  <li>Reject |doc|'s {{[[orientationPendingPromise]]}} with
                  `"AbortError"` {{DOMException}}.
                  </li>
                  <li>Set |doc|'s {{[[orientationPendingPromise]]}} to `null` .
                  </li>
                </ol>
              </li>
              <li data-tests="lock-basic.html">Let |orientations| be an empty
              <a>list</a>.
              </li>
              <li>Depending on |orientation| value, do the following:
                <dl>
                  <dt>
                    <a>portrait-primary</a> or <a>portrait-secondary</a> or
                    <a>landscape-primary</a> or <a>landscape-secondary</a>
                  </dt>
                  <dd>
                    Append |orientation| to |orientations|.
                  </dd>
                  <dt>
                    <a data-link-for='OrientationLockType'>landscape</a>
                  </dt>
                  <dd>
                    Depending on platform convention, append
                    `landscape-primary`, or `landscape-secondary`, or both to
                    |orientations|.
                  </dd>
                  <dt>
                    <a data-link-for='OrientationLockType'>portrait</a>
                  </dt>
                  <dd>
                    Depending on platform convention, append
                    `portrait-primary`, or `portrait-secondary`, or both to
                    |orientations|.
                  </dd>
                  <dt>
                    <a data-link-for='OrientationLockType'>natural</a>
                  </dt>
                  <dd>
                    Append `portrait-primary` or `landscape-primary` to
                    |orientations| such as the associated <a>current
                    orientation angle</a> is 0.
                  </dd>
                  <dt>
                    `any`
                  </dt>
                  <dd>
                    Append `portrait-primary`, `portrait-secondary`,
                    `landscape-primary` and `landscape-secondary` to
                    |orientations|.
                  </dd>
                </dl>
              </li>
              <li>
                <a>Lock the orientation</a> of the <a>document</a> to
                |orientations|.
              </li>
              <li>If locking the orientation did not result in a change of
              orientation, as part of the next <a>animation frame task</a>,
              resolve {{[[orientationPendingPromise]]}} with `undefined` and
              set {{[[orientationPendingPromise]]}} to `null`.
              </li>
            </ol>
          </li>
        </ol>
        <div class='note'>
          If locking the orientation results in an orientation change, the
          promise will be resolved when the orientation will change as
          described in the <a href="#Screen-orientation-change"></a> section.
        </div>
      </section>
      <section>
        <h2>
          Locking the orientation
        </h2>
        <p>
          The steps to <dfn>lock the orientation</dfn> to |orientation| are as
          follows.
        </p>
        <ol class="algorithm">
          <li class="algorithm" data-tests="lock-basic.html">Set the
          <a>document</a>'s {{[[orientationLock]]}} to |orientations|.
          </li>
          <li>If the <a>active orientation lock</a> is not the
          <a>document</a>'s {{[[orientationLock]]}}, abort these steps.
          </li>
          <li>If the <a>active orientation lock</a> value is equal to
          |orientations| value, abort these steps.
          </li>
          <li>If |orientations| contains only one value, run the following
          sub-steps:
            <ol>
              <li>Let |orientation| be the value contained in |orientations|.
              </li>
              <li>Change how the viewport is drawn so that the
              <a>document</a>'s <a>current orientation type</a> will be equal
              to |orientation|.
              </li>
              <li>After the change has happened, prevent the <a>document</a>'s
              <a>top-level browsing context</a>'s screen orientation from
              changing until those steps are run again.
              </li>
              <li>Abort these steps.
              </li>
            </ol>
          </li>
          <li>If the <a>document</a>'s <a>current orientation type</a> is not
          part of |orientations|, change how the viewport is drawn such as the
          <a>document</a>'s <a>current orientation type</a> will be equal to
          one of |orientations|' values.
          </li>
          <li>Otherwise, depending on platform conventions, change how the
          viewport is drawn in order to make it match another screen
          orientation type. However, it has to be part of |orientations|.
          </li>
          <li>Allow the user to change the screen orientation to any value part
          of |orientations| and only those values until those steps are run
          again. The method to define the current screen orientation has to
          match the platform conventions.
          </li>
        </ol>
      </section>
      <section>
        <h2>
          Determining the active orientation lock
        </h2>
        <p>
          The steps to determine the <dfn>active orientation lock</dfn> are as
          follows:
        </p>
        <ol class="algorithm">
          <li>If there is only one <a>top-level browsing context</a> with a <a>
            document</a> that is visible per [[PAGE-VISIBILITY]], the <a>active
            orientation lock</a> is the <a>document</a>'s
            {{[[orientationLock]]}}.
          </li>
          <li>Otherwise, if there are more than one <a>top-level browsing
          context</a> with a <a>document</a> that is visible per
          [[PAGE-VISIBILITY]] but only one of those <a>document</a>s is
          focused, the <a>active orientation lock</a> is the focused
          <a>document</a>'s {{[[orientationLock]]}}.
          </li>
          <li>Otherwise, the <a>active orientation lock</a> SHOULD be the
          latest focused <a>document</a>'s {{[[orientationLock]]}}, unless
          stated otherwise by the platform conventions.
          </li>
        </ol>
        <p>
          Whenever the <a>active orientation lock</a> changes, the <a>user
          agent</a> MUST run the steps to <a>lock the orientation</a> of the
          <a>document</a> to the <a>document</a>'s {{[[orientationLock]]}}.
        </p>
        <p>
          Whenever a <a>top-level browsing context</a> is <a>navigated</a>, the
          <a>user agent</a> MUST <a>lock the orientation</a> of the
          <a>document</a> to the <a>document</a>'s {{[[defaultOrientation]]}}.
        </p>
      </section>
      <section data-link-for='ScreenOrientation' id=
      "Screen-orientation-change">
        <h2>
          Screen orientation change
        </h2>
        <p data-tests="onchange-event.html">
          Whenever the viewport's angle changes, the <a>user agent</a> MUST run
          the following steps as part of the next <a>animation frame task</a>:
        </p>
        <ol class="algorithm">
          <li>Let |browsing contexts| be the <a>list of the descendant browsing
          contexts</a> of the <a>top-level browsing context</a>'s
          <a>document</a>.
          </li>
          <li>For each |context:browsing context| in |browsing contexts|, run
          the following sub-steps:
            <ol>
              <li>Let |doc| be the |context|'s <a>active document</a>.
              </li>
              <li>If |doc| is not visible per [[PAGE-VISIBILITY]], abort these
              steps.
              </li>
              <li>
                <a>Update the orientation information</a> of |doc|.
              </li>
              <li>If the orientation change was triggered by a user gesture
              such as the user turning the device, as opposed to a call to
              {{lock()}}, the <a>task</a> MUST be annotated with `process user
              orientation change` when running the next step.
              </li>
              <li>
                <a>Fire an event</a> named `change` at |doc|'s
                {{Screen.orientation}} object.
              </li>
              <li>If |doc|'s {{[[orientationPendingPromise]]}} is not `null`:
                <ol>
                  <li>Resolve |doc|'s {{[[orientationPendingPromise]]}} with
                  `undefined`.
                  </li>
                  <li>Set |doc|'s {{[[orientationPendingPromise]]}} to `null` .
                  </li>
                </ol>
              </li>
            </ol>
          </li>
        </ol>
        <p>
          Whenever a <a>document</a> becomes visible per [[PAGE-VISIBILITY]],
          in other words after the <a>now visible algorithm</a> is run, the
          <a>user agent</a> MUST run the following substeps as part of the next
          <a>animation frame task</a>:
        </p>
        <ol class="algorithm">
          <li>Let |type| and |angle| be respectively the <a>document</a>'s <a>
            current orientation type</a> and <a>current orientation angle</a>.
          </li>
          <li>
            <a>Update the orientation information</a> of the <a>document</a>.
          </li>
          <li>If |type| is different from the <a>document</a>'s <a>current
          orientation type</a> or |angle| from the <a>document</a>'s <a>current
          orientation angle</a>, run the following sub-steps:
            <ol>
              <li>If the orientation change was triggered by a user gesture
              such as the user turning the device, as opposed to a call to <a>
                lock()</a>, the <a>task</a> MUST be annotated with `process
                user orientation change` when running the next step.
              </li>
              <li>
                <a>Fire an event</a> named `change` at the <a>document</a>'s
                {{Screen.orientation}} object.
              </li>
              <li>If the <a>document</a>'s {{[[orientationPendingPromise]]}} is
              not `null`:
                <ol>
                  <li>Resolve the <a>document</a>'s
                  {{[[orientationPendingPromise]]}} with `undefined`.
                  </li>
                  <li>Set the <a>document</a>'s
                  {{[[orientationPendingPromise]]}} to `null`.
                  </li>
                </ol>
              </li>
            </ol>
          </li>
        </ol>
        <p>
          An algorithm is <dfn>triggered by a user generated orientation
          change</dfn> if the <a>task</a> in which the algorithm is running is
          annotated with `process user orientation change`.
        </p>
        <div class="note">
          <p>
            Developers need to be aware that a {{Screen.orientation}} object
            from a <a>document</a> that is not visible, as per
            [[PAGE-VISIBILITY]], will not receive an orientation change event.
            This is to prevent unnecessary changes to layout, etc. in the
            non-visible web application.
          </p>
        </div>
        <div class='issue'>
          This section could be improved if the [[PAGE-VISIBILITY]]
          specification had a hook for when the document becomes visible and
          hidden. <a href=
          'https://github.com/w3c/screen-orientation/issues/77'>issue 77</a>.
        </div>
      </section>
    </section>
    <section class='informative'>
      <h2>
        Privacy and Security Considerations
      </h2>
      <section>
        <h3>
          Access to aspects of a user’s local computing environment
        </h3>
        <p>
          The screen orientation type and angle of the device can be accessed
          with the API specified in this document, and can be a potential
          fingerprinting vector.
        </p>
        <p>
          The screen orientation type can already be known by using the screen
          width and height. In practice, the additional information provided
          with the API concerning the angle of the device and the primary or
          secondary screen orientation is unlikely to be used by any competent
          attack.
        </p>
      </section>
    </section>
    <section>
      <h2>
        Dependencies
      </h2>
      <p>
        The following concepts and interfaces are defined in [[HTML]]:
        <dfn data-cite=
        "HTML/browsers.html#list-of-the-descendant-browsing-contexts">list of
        the descendant browsing contexts</dfn>.
      </p>
      <p>
        The following is defined in [[PAGE-VISIBILITY]]: <dfn data-cite=
        "PAGE-VISIBILITY#dfn-now-visible-algorithm">now visible
        algorithm</dfn>.
      </p>
      <p>
        The following is used but not defined in [[FULLSCREEN]]: <dfn><a href=
        'https://github.com/whatwg/fullscreen/issues/16'>animation frame
        task</a></dfn>.
      </p>
      <div class='issue'>
        This should now be updated since the <a>animation frame task</a> issue
        is recently resolved and the timing is now defined.
      </div>
    </section>
    <section id='conformance'>
      <p>
        This specification defines conformance criteria that apply to a single
        product: the <dfn>user agent</dfn> that implements the interfaces that
        it contains.
      </p>
    </section>
    <section id="idl-index" class="appendix"></section>
    <section class='appendix'>
      <h2>
        Acknowledgments
      </h2>
      <p>
        Thanks Christophe Dumez, Anne van Kesteren, Chundong Wang, Fuqiao Xue,
        and Chaals McCathie Nevile for their useful comments.
      </p>
      <p>
        Special thanks to Chris Jones and Jonas Sicking for their contributions
        to the initial design of this API.
      </p>
    </section>
  </body>
</html>