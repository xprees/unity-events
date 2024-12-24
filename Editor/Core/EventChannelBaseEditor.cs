using UnityEditor;
using Xprees.Events.ScriptableObjects.Base;

namespace Xprees.Events.Editor.Core
{
    [CustomEditor(typeof(EventChannelBaseSO<>), true)]
    public class EventChannelBaseEditor : UnityEditor.Editor
    {

    }
}