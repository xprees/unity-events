using UnityEngine;
using Xprees.Events.Packages.cz.xprees.events.Editor.Core;

namespace Xprees.Events.Editor
{
    public class GameObjectListenerEditor : EventListenerEditorBase<GameObject>
    {
        protected override GameObject GetTestData() => serializedObject.targetObject as GameObject;
    }
}