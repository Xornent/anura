/* 浏览器公开接口列表
============================================
    SUPPORTED CANDIDATE WEB APPLICATION     
               INTERFACES LIST
--------------------------------------------
          A

[Unabled] Ambient Light Events
          
          B

          Background Tasks
[Unabled] Battery API
          Beacon
[Unabled] Bluetooth API
          Broadcast Channel API

          C

          CSS Counter Styles
          CSS Font Loading API
        * CSSOM
          Canvas API
          Channel Messaging API
        * Console API
          Credential Management API

          D

        * DOM                               [1] 开始实现工作: 2020.04.03

          E

        * Encoding API
          Encrypted Media Extensions

          F

        * Fetch API
          File System API
          Frame Timing API
        * Fullscreen API

          G

[Unabled] Gamepad API
          Geolocation API

          H

          HTML Drag and Drop API
          High Resolution Time
          History API

          I

[Unabled] Image Capture API
        * IndexedDB
          Intersection Observer API

          L

          Long Tasks API

          M
          
          Media Capabilities API
[Unabled] Media Capture and Streams
          Media Session API
          Media Source Extensions
[Unabled] MediaStream Recording

          N

          Navigation Timing
          Network Information API

          P

          Page Visibility API
          Payment Request API
          Performance API
          Performance Timeline API
          Permissions API
[Unabled] Pointer Events
[Unabled] Pointer Lock API
[Unabled] Proximity Events
          Push API

          R

          Resize Observer API
          Resource Timing API

          S

          Server Sent Events
        * Service Workers API
        * Storage
          Storage Access API
          Streams

          T

[Unabled] Touch Events

          V

[Unabled] Vibration API

          W

        * Web Animations
          Web Audio API
          Web Authentication API
        * Web Crypto API
        * Web Notifications
          Web Storage API
          Web Workers API
        * WebGL
[Unabled] WebRTC
[Unabled] WebVR API
        * WebVTT
[Unabled] WebXR Device API
          Websockets API

============================================
*/

using System.Collections.Generic;

namespace Anura.Objects {
    /// <summary>
    /// 这个类代表 .NET 对象模型对 JS 对象的翻译. 
    /// 每一个允许在网页 JavaScript 类型都应继承此类
    /// 
    /// + 本实现需严格遵循 WHATWG ( 和 W3C ) 的定义标准
    /// </summary>
    public interface IPrototypeObjectModel {
        void Configure ();
        JavaScript.Native.Object.ObjectInstance PrototypeObject { get; set; }
    }

    public class Initialization {
        public static void CreateConstructors (JavaScript.Engine engine) {
            // Namespace Extensions:
            Extensions.__Anura__Constructor Anura = Extensions.__Anura__Constructor.Create__Anura__Constructor (engine);

            // Storing:
            ExtensionWebAPIs.Add ((0, Anura));
        }

        public static void Configure (JavaScript.Engine engine) {
            foreach (var item in ExtensionWebAPIs) {
                switch (item.config) {
                    case 0:
                        IPrototypeObjectModel constr = item.obj as IPrototypeObjectModel;
                        constr.Configure ();
                        (constr.PrototypeObject as IPrototypeObjectModel).Configure ();
                        break;
                }
            }
        }

        public static void RegisterGlobalObjects (JavaScript.Native.Object.ObjectInstance inst) {
            inst.FastAddProperty ("__Anura__", ExtensionWebAPIs[0].obj as JavaScript.Native.Function.FunctionInstance, true, false, true);
        }

        public static List < (int config, IPrototypeObjectModel obj) > ExtensionWebAPIs = new List < (int config, IPrototypeObjectModel obj) > ();
    }
}