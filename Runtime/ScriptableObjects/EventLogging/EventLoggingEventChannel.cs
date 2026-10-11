#if XPREES_EVENT_LOGGING || OG_ANALYTICS_V1
using UnityEngine;
using Xprees.Events.ScriptableObjects.Base;
using Xprees.EventLogging.ScriptableObjects;
#endif

namespace Xprees.Events.ScriptableObjects.EventLogging
{
#if XPREES_EVENT_LOGGING || OG_ANALYTICS_V1
    [CreateAssetMenu(menuName = "Events/EventLogging/EventLogging Event", fileName = "EventLoggingEvent")]
    public class EventLoggingEventChannel : EventChannelBaseSO<EventSO>
    {
    }

#endif
}