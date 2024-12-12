using UnityEngine;
using Xprees.Events.Listeners.Base;

namespace Xprees.Events.Editor.Core
{
    public abstract class EventListenerEditorBase<T> : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            DrawInvokeEventButton(Application.isPlaying);
        }

        private void DrawInvokeEventButton(bool enabled)
        {
            var prevState = GUI.enabled;
            GUI.enabled = enabled;

            var listener = target as EventListenerBase<T>;
            if (!listener) return;

            if (GUILayout.Button("Invoke Event with test data"))
            {
                listener.onEventRaised?.Invoke(GetTestData());
            }

            GUI.enabled = prevState;
        }

        protected virtual T GetTestData() => default;
    }

}