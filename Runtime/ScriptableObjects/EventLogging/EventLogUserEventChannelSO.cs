#if XPREES_EVENT_LOGGING
using UnityEngine;
using Xprees.Events.ScriptableObjects.Base;
using Xprees.EventLogging.Api.Model;
#endif

namespace Xprees.Events.ScriptableObjects.EventLogging
{
#if XPREES_EVENT_LOGGING
    [CreateAssetMenu(menuName = "Events/EventLogging/EventLogging User Event", fileName = "EventLoggingUserEvent")]
    public class EventLogUserEventChannelSO : EventChannelBaseSO<User>
    {
    }
#endif
}