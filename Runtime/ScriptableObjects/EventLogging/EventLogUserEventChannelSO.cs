using UnityEngine;
using Xprees.EventLogging.Api.Model;
using Xprees.Events.ScriptableObjects.Base;

namespace Xprees.Events.ScriptableObjects.EventLogging
{
    [CreateAssetMenu(menuName = "Events/EventLogging/EventLogging User Event", fileName = "EventLoggingUserEvent")]
    public class EventLogUserEventChannelSO : EventChannelBaseSO<User>
    {
    }
}