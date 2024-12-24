using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using Xprees.Events.ScriptableObjects.Base;

namespace Xprees.Events.Listeners.Base
{
    public class VoidEventListener : MonoBehaviour
    {
        public VoidEventChannelSO voidGameEvent;

        public UnityEvent onEventRaised;

        private void OnEnable()
        {
            if (voidGameEvent == null) return;

            voidGameEvent.onEventRaised += Respond;
        }

        private void OnDisable()
        {
            if (voidGameEvent == null) return;

            voidGameEvent.onEventRaised -= Respond;
        }

        [Button("Invoke Event", EButtonEnableMode.Playmode)]
        public void Respond() => onEventRaised?.Invoke();
    }
}