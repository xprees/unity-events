using UnityEngine;
using UnityEngine.Events;
using Xprees.Core;
using Xprees.EventLogging.ScriptableObjects;
using Xprees.Events.ScriptableObjects.EventLogging;
using Xprees.Variables.Reference.Primitive;

namespace Xprees.Events.ScriptableObjects.Base
{
    [CreateAssetMenu(menuName = "Events/Void Event", fileName = "VoidEvent", order = -1)]
    public class VoidEventChannelSO : DescriptionBaseSO
    {
        public UnityAction onEventRaised;

        public void RaiseEvent()
        {
            if (enableEventLogging) LogData();
            onEventRaised?.Invoke();
        }

        #region Event Logging

        [Header("Event Logging")]
        public bool enableEventLogging = false;

        public EventLoggingEventChannel addLogEvent;

        [Tooltip("Required. Use unique name for each event.")]
        public StringReference eventName;

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

    }
}