using UnityEditor;
using UnityEngine;
using Xprees.Events.Listeners.Base;

namespace Xprees.Events.Editor.Core
{
    [CustomEditor(typeof(VoidEventListener))]
    public class VoidEventListenerEditor : UnityEditor.Editor
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

            var listener = (VoidEventListener) target;
            if (GUILayout.Button("Invoke Event"))
            {
                listener.onEventRaised?.Invoke();
            }

            GUI.enabled = prevState;
        }
    }
}