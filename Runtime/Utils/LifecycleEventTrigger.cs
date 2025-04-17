using UnityEngine;
using Xprees.Events.ScriptableObjects.Base;

namespace Xprees.Events.Utils
{
    public class LifecycleEventTrigger : MonoBehaviour
    {
        [Header("Broadcasting Events")]
        public VoidEventChannelSO onAwake;

        public VoidEventChannelSO onStart;
        public VoidEventChannelSO onEnable;
        public VoidEventChannelSO onDisable;
        public VoidEventChannelSO onDestroy;

        private void Awake() => onAwake?.RaiseEvent();

        private void Start() => onStart?.RaiseEvent();

        private void OnEnable() => onEnable?.RaiseEvent();

        private void OnDisable() => onDisable?.RaiseEvent();

        private void OnDestroy() => onDestroy?.RaiseEvent();

    }
}