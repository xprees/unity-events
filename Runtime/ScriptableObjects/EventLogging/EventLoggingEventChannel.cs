using UnityEngine;
using Xprees.EventLogging.ScriptableObjects;
using Xprees.Events.ScriptableObjects.Base;

namespace Xprees.Events.ScriptableObjects.EventLogging
{
    [CreateAssetMenu(menuName = "Events/EventLogging/EventLogging Event", fileName = "EventLoggingEvent")]
    public class EventLoggingEventChannel : EventChannelBaseSO<EventSO>
    {
    }
}