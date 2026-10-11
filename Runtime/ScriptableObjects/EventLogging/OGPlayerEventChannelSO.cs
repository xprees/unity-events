#if OG_ANALYTICS_V1
using UnityEngine;
using Xprees.Events.ScriptableObjects.Base;
using Xprees.EventLogging.Api.OpenGameAnalytics.V1.Model;
#endif

namespace Xprees.Events.ScriptableObjects.EventLogging
{
#if OG_ANALYTICS_V1
    /// Sets the player (id + name) used by the event logger (Open Game Analytics v1).
    [CreateAssetMenu(menuName = "Events/EventLogging/EventLogging Player Event", fileName = "EventLoggingPlayerEvent")]
    public class OGPlayerEventChannelSO : EventChannelBaseSO<OGPlayer>
    {
    }
#endif
}