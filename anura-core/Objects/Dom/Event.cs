using System;
using System.Collections;
using System.Collections.Generic;
using Anura;
using Anura.Developer;
using Anura.Html;
using Anura.JavaScript;
using Anura.JavaScript.Native;
using Anura.Objects.Attributes;
using Anura.Styles;

namespace Anura.Objects.Dom {

    /// <summary>
    /// Throughout the web platform events are dispatched to objects to signal an occurrence, 
    /// such as network activity or user interaction. These objects implement the EventTarget 
    /// interface and can therefore add event listeners to observe events by calling addEventListener():
    /// ``` js
    /// obj.addEventListener("load", imgFetched)
    /// function imgFetched(ev) {
    ///     // success.
    /// }
    /// ```
    /// Event listeners can be removed by utilizing the removeEventListener() method, passing the same arguments.
    /// 
    /// Events are objects too and implement the Event interface (or a derived interface). In the example
    /// above ev is the event. ev is passed as an argument to the event listener’s callback (typically a
    ///  JavaScript Function as shown above). Event listeners key off the event’s type attribute value 
    /// ("load" in the above example). The event’s target attribute value returns the object to which the 
    /// event was dispatched (obj above).
    ///
    /// Although events are typically dispatched by the user agent as the result of user interaction or the 
    /// completion of some task, applications can dispatch events themselves by using what are commonly known 
    /// as synthetic events:
    /// </summary>
    public partial class Event {

        /// <summary>
        /// An event has an associated target (a potential event target). 
        /// Unless stated otherwise it is null.    
        /// </summary>
        private EventTarget target = null;

        /// <summary>
        /// An event has an associated relatedTarget (a potential event target). 
        /// Unless stated otherwise it is null.
        /// </summary>
        private EventTarget relatedTarget = null;

        /// <summary>
        /// An event has an associated touch target list (a list of zero 
        /// or more potential event targets). Unless stated otherwise it is the empty list.
        /// </summary>
        private List<EventTarget> touchTargetList = new List<EventTarget> ();

        /// <summary>
        /// An event has an associated path. A path is a list of structs. 
        /// Each struct consists of an invocation target (an EventTarget object), 
        /// an invocation-target-in-shadow-tree (a boolean), a shadow-adjusted target 
        /// (a potential event target), a relatedTarget (a potential event target), 
        /// a touch target list (a list of potential event targets), a root-of-closed-tree 
        /// (a boolean), and a slot-in-closed-tree (a boolean). A path is initially the empty list.
        /// </summary>
        private List < (EventTarget invocationTarget,
                bool invocationTargetInShadowTree,
                EventTarget shadowAdjustedTarget,
                EventTarget relatedTarget,
                List<EventTarget> touchTargetList,
                bool rootOfClosedTree,
                bool slotInClosedTree) > associatedPath =
            new List < (EventTarget invocationTarget,
                bool invocationTargetInShadowTree,
                EventTarget shadowAdjustedTarget,
                EventTarget relatedTarget,
                List<EventTarget> touchTargetList,
                bool rootOfClosedTree,
                bool slotInClosedTree) > ();

        /// <summary>
        /// The type attribute must return the value it was initialized to. 
        /// When an event is created the attribute must be initialized to the empty string.
        /// </summary>
        [ApiName ("type")]
        public string Type { get; private set; } = "";

        /// <summary>
        /// The target attribute’s getter, when invoked, must return this’s target.
        /// </summary>
        [ApiName ("target")]
        public EventTarget Target => target;

        /// <summary>
        /// The srcElement attribute’s getter, when invoked, must return this’s target.
        /// </summary>
        [ApiName ("srcElement")]
        [CapabilityObsolete ("")]
        public EventTarget SourceElement => target;

        /// <summary>
        /// The currentTarget attribute must return the value it was initialized to.
        /// When an event is created the attribute must be initialized to null.
        /// </summary>
        [ApiName ("currentTarget")]
        public EventTarget CurrentTarget { get; private set; } = null;

        [ApiName ("composePath")]
        public List<EventTarget> ComposePath () {
            var composedPath = new List<EventTarget> ();
            if (associatedPath.Count == 0) return composedPath;
            composedPath.Add (CurrentTarget);
            int currentTargetId = 0;
            int currentTargetHiddenSubTreeLevel = 0;
            int id = associatedPath.Count - 1;
            while (id >= 0) {
                if (associatedPath[id].rootOfClosedTree)
                    currentTargetHiddenSubTreeLevel++;
                if (associatedPath[id].invocationTarget == this.CurrentTarget) {
                    currentTargetId = id;
                    break;
                }
                if (associatedPath[id].slotInClosedTree)
                    currentTargetHiddenSubTreeLevel--;
                id--;
            }
            int currentHiddenLevel = currentTargetHiddenSubTreeLevel;
            int maxHiddenLevel = currentTargetHiddenSubTreeLevel;
            id = currentTargetId - 1;
            while (id >= 0) {
                if (associatedPath[id].rootOfClosedTree)
                    currentHiddenLevel++;
                if (currentHiddenLevel <= maxHiddenLevel)
                    composedPath.Insert (0, associatedPath[id].invocationTarget);
                if (associatedPath[id].slotInClosedTree) {
                    currentHiddenLevel--;
                    if (currentHiddenLevel < maxHiddenLevel)
                        maxHiddenLevel = currentHiddenLevel;
                }
                id--;
            }
            currentHiddenLevel = currentTargetHiddenSubTreeLevel;
            maxHiddenLevel = currentTargetHiddenSubTreeLevel;
            id = currentTargetId + 1;
            while (id < associatedPath.Count) {
                if (associatedPath[id].slotInClosedTree)
                    currentHiddenLevel++;
                if (currentHiddenLevel <= maxHiddenLevel)
                    composedPath.Add (associatedPath[id].invocationTarget);
                if (associatedPath[id].rootOfClosedTree) {
                    currentHiddenLevel--;
                    if (currentHiddenLevel < maxHiddenLevel)
                        maxHiddenLevel = currentHiddenLevel;
                    id++;
                }
            }
            return composedPath;
        }

        /// <summary>
        /// The eventPhase attribute must return the value it was initialized to, 
        /// which must be one of the following:
        /// Initially the attribute must be initialized to NONE.
        /// </summary>
        [ApiName ("eventPhase")]
        public EventPhase Phase = EventPhase.None;
        
        private Nullable<bool> flagStopPropagation = null;
        private Nullable<bool> flagStopImmediatePropagation = null;
        private Nullable<bool> flagCanceled = null;
        private Nullable<bool> flagInPassiveListener = null;
        private Nullable<bool> flagComposed = null;
        private Nullable<bool> flagInitialized = null;
        private Nullable<bool> flagDispatch = null;
        
        /// <summary>
        /// The stopPropagation() method, when invoked, must set this’s stop propagation flag.
        /// </summary>
        [ApiName("stopPropagation")]
        public void StopPropagation (){
            flagStopPropagation = true;
        }
        
        /// <summary>
        /// The cancelBubble attribute’s getter, when invoked, 
        /// must return true if this’s stop propagation flag is set, and false otherwise.
        /// The cancelBubble attribute’s setter, when invoked, must set this’s stop propagation 
        /// flag if the given value is true, and do nothing otherwise.
        /// </summary>
        [ApiName("cancelBubble")]
        public bool CancelBubble {
            get {
                if(flagStopPropagation != null) return true;
                else return false;
            }
            set {
                if(value == true)
                    flagStopPropagation = true;
            }
        }
        
        /// <summary>
        /// The stopImmediatePropagation() method, when invoked, 
        /// must set this’s stop propagation flag and this’s stop immediate propagation flag.
        /// </summary>
        [ApiName("stopImmediatePropagation")]
        public void StopImmediatePropagation (){
            flagStopPropagation = true;
            flagStopImmediatePropagation = true;
        }
    }

    /// <summary>
    /// The eventPhase attribute must return the value it was initialized to, 
    /// which must be one of the following:
    /// </summary>
    public enum EventPhase {

        /// <summary>
        /// Events not currently dispatched are in this phase.
        /// </summary>
        None = 0,

        /// <summary>
        /// When an event is dispatched to an object that participates
        /// in a tree it will be in this phase before it reaches its target.
        /// </summary>
        Capturing = 1,

        /// <summary>
        /// When an event is dispatched it will be in this phase on its target.
        /// </summary>
        AtTarget = 2,

        /// <summary>
        /// When an event is dispatched to an object that participates in a tree 
        /// it will be in this phase after it reaches its target.
        /// </summary>
        Bubbling = 3
    }
}