#if XPREES_EVENT_LOGGING
using System;
using UnityEngine;
using Xprees.Events.ScriptableObjects.Base;
using Xprees.EventLogging.Api.Legacy.Model;
#endif

namespace Xprees.Events.ScriptableObjects.EventLogging
{
#if XPREES_EVENT_LOGGING
#pragma warning disable CS0618 // legacy User model is obsolete on purpose, this channel is the obsolete bridge
    [Obsolete("Legacy CF-Bucket user. Use OGPlayerEventChannelSO (Open Game Analytics v1) instead.")]
    [CreateAssetMenu(menuName = "Events/EventLogging/EventLogging User Event (Legacy)", fileName = "EventLoggingUserEvent")]
    public class EventLogUserEventChannelSO : EventChannelBaseSO<User>
    {
    }
#pragma warning restore CS0618
#endif
}