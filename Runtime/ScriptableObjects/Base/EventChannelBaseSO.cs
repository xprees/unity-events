using UnityEngine.Events;
using Xprees.Core;
#if XPREES_EVENT_LOGGING
using NaughtyAttributes;
using UnityEngine;
using Xprees.Variables.Reference.Primitive;
using Xprees.EventLogging.ScriptableObjects;
using Xprees.Events.ScriptableObjects.EventLogging;
#endif

namespace Xprees.Events.ScriptableObjects.Base
{
    /// <summary>
    /// Base class for all events channels with one parameter that are used in the game.
    /// </summary>
    /// <typeparam name="T">Unity Serializable</typeparam>
    public class EventChannelBaseSO<T> : DescriptionBaseSO
    {
        public UnityAction<T> onEventRaised;

        public void RaiseEvent(T value)
        {
#if XPREES_EVENT_LOGGING
            if (enableEventLogging) LogData(value);
#endif
            onEventRaised?.Invoke(value);
        }


        #region Event Logging

#if XPREES_EVENT_LOGGING
        [Header("Event Logging")]
        public bool enableEventLogging = false;

        [ShowIf(nameof(enableEventLogging))]
        public EventLoggingEventChannel addLogEvent;

        [ShowIf(nameof(enableEventLogging))]
        [Label("Event Name (Required)")]
        [Tooltip("Required. Use unique name for each event.")]
        public StringReference eventName;

        protected void LogData(T value)
        {
            if (addLogEvent == null) return;

            var eventLog = CreateInstance<EventSO>();
            eventLog.eventName = eventName.Value;
            eventLog.eventData = GetEventData(value);

            addLogEvent.RaiseEvent(eventLog);
        }

#endif
        /// Allows to override the event data provided for logging. Provide specific data for your event.
        protected virtual string GetEventData(T value) => null;

        #endregion


    }

    /// <summary>
    /// Base class for all events channels with two parameters that are used in the game.
    /// </summary>
    /// <typeparam name="T1">Unity Serializable</typeparam>
    /// <typeparam name="T2">Unity Serializable</typeparam>
    public class EventChannelBaseSO<T1, T2> : DescriptionBaseSO
    {
        public UnityAction<T1, T2> onEventRaised;

        public void RaiseEvent(T1 firstValue, T2 secondValue)
        {
#if XPREES_EVENT_LOGGING
            if (enableEventLogging) LogData(firstValue, secondValue);
#endif
            onEventRaised?.Invoke(firstValue, secondValue);
        }

        #region Event Logging

#if XPREES_EVENT_LOGGING
        [Header("Event Logging")]
        public bool enableEventLogging = false;

        [ShowIf(nameof(enableEventLogging))]
        public EventLoggingEventChannel addLogEvent;

        [ShowIf(nameof(enableEventLogging))]
        [Label("Event Name (Required)")]
        [Tooltip("Required. Use unique name for each event.")]
        public StringReference eventName;

        protected void LogData(T1 firstValue, T2 secondValue)
        {
            if (addLogEvent == null) return;

            var eventLog = CreateInstance<EventSO>();
            eventLog.eventName = eventName.Value;
            eventLog.eventData = GetEventData(firstValue, secondValue);

            addLogEvent.RaiseEvent(eventLog);
        }
#endif

        /// Allows to override the event data provided for logging. Provide specific data for your event.
        protected virtual string GetEventData(T1 firstValue, T2 secondValue) => null;

        #endregion

    }

    /// <summary>
    /// Base class for all events channels with two parameters that are used in the game.
    /// </summary>
    /// <typeparam name="T1">Unity Serializable</typeparam>
    /// <typeparam name="T2">Unity Serializable</typeparam>
    /// <typeparam name="T3">Unity Serializable</typeparam>
    public class EventChannelBaseSO<T1, T2, T3> : DescriptionBaseSO
    {
        public UnityAction<T1, T2, T3> onEventRaised;

        public void RaiseEvent(T1 firstValue, T2 secondValue, T3 thirdValue)
        {
#if XPREES_EVENT_LOGGING
            if (enableEventLogging) LogData(firstValue, secondValue, thirdValue);
#endif
            onEventRaised?.Invoke(firstValue, secondValue, thirdValue);
        }

        #region Event Logging

#if XPREES_EVENT_LOGGING
        [Header("Event Logging")]
        public bool enableEventLogging = false;

        [ShowIf(nameof(enableEventLogging))]
        public EventLoggingEventChannel addLogEvent;

        [ShowIf(nameof(enableEventLogging))]
        [Label("Event Name (Required)")]
        [Tooltip("Required. Use unique name for each event.")]
        public StringReference eventName;

        protected void LogData(T1 firstValue, T2 secondValue, T3 thirdValue)
        {
            if (addLogEvent == null) return;

            var eventLog = CreateInstance<EventSO>();
            eventLog.eventName = eventName.Value;
            eventLog.eventData = GetEventData(firstValue, secondValue, thirdValue);

            addLogEvent.RaiseEvent(eventLog);
        }
#endif

        /// Allows to override the event data provided for logging. Provide specific data for your event.
        protected virtual string GetEventData(T1 firstValue, T2 secondValue, T3 thirdValue) => null;

        #endregion

    }
}