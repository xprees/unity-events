using UnityEngine;
using UnityEngine.Events;
using Xprees.Events.ScriptableObjects.Base;

namespace Xprees.Events.Listeners.Base
{
    public class EventListenerBase<T> : MonoBehaviour
    {
        public EventChannelBaseSO<T> gameEvent;

        public UnityEvent<T> onEventRaised;

        private void OnEnable()
        {
            if (gameEvent != null) gameEvent.onEventRaised += Respond;
        }

        private void OnDisable()
        {
            if (gameEvent != null) gameEvent.onEventRaised -= Respond;
        }

        protected virtual void Respond(T value) => onEventRaised?.Invoke(value);
    }

    public class EventListenerBase<T1, T2> : MonoBehaviour
    {
        public EventChannelBaseSO<T1, T2> gameEvent;

        public UnityEvent<T1, T2> onEventRaised;

        private void OnEnable()
        {
            if (gameEvent != null) gameEvent.onEventRaised += Respond;
        }

        private void OnDisable()
        {
            if (gameEvent != null) gameEvent.onEventRaised -= Respond;
        }

        protected virtual void Respond(T1 firstValue, T2 secondValue) => onEventRaised?.Invoke(firstValue, secondValue);
    }

    public class EventListenerBase<T1, T2, T3> : MonoBehaviour
    {
        public EventChannelBaseSO<T1, T2, T3> gameEvent;

        public UnityEvent<T1, T2, T3> onEventRaised;

        private void OnEnable()
        {
            if (gameEvent != null) gameEvent.onEventRaised += Respond;
        }

        private void OnDisable()
        {
            if (gameEvent != null) gameEvent.onEventRaised -= Respond;
        }

        protected virtual void Respond(T1 firstValue, T2 secondValue, T3 thirdValue) =>
            onEventRaised?.Invoke(firstValue, secondValue, thirdValue);
    }
}