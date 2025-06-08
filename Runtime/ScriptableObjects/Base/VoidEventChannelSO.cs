using UnityEngine;
using UnityEngine.Events;
using Xprees.Core;
#if XPREES_EVENT_LOGGING
using NaughtyAttributes;
using Xprees.Variables.Reference.Primitive;
using Xprees.EventLogging.ScriptableObjects;
using Xprees.Events.ScriptableObjects.EventLogging;
#endif

namespace Xprees.Events.ScriptableObjects.Base
{
    [CreateAssetMenu(menuName = "Events/Void Event", fileName = "VoidEvent", order = -1)]
    public class VoidEventChannelSO : DescriptionBaseSO
    {
        public UnityAction onEventRaised;

        public void RaiseEvent()
        {
#if XPREES_EVENT_LOGGING
            if (enableEventLogging) LogData();
#endif
            onEventRaised?.Invoke();
        }

#if XPREES_EVENT_LOGGING

        #region Event Logging

        [Header("Event Logging")]
        public bool enableEventLogging = false;

        [ShowIf(nameof(enableEventLogging))]
        public EventLoggingEventChannel addLogEvent;

        [ShowIf(nameof(enableEventLogging))]
        [Label("Event Name (Required)")]
        [Tooltip("Required. Use unique name for each event.")]
        public StringReference eventName;

        [ShowIf(nameof(enableEventLogging))]
        [Tooltip("Not required. Use to add additional data to the event.")]
        public StringReference eventData = null;

        protected void LogData()
        {
            if (addLogEvent == null) return;

            var eventLog = CreateInstance<EventSO>();
            eventLog.eventName = eventName.Value;
            eventLog.eventData = eventData;

            addLogEvent.RaiseEvent(eventLog);
        }

        #endregion

#endif

    }
}