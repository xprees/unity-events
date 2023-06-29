using UnityEngine;
using Xprees.Events.ScriptableObjects.Base;

namespace Xprees.Events.ScriptableObjects.Primitive
{
    [CreateAssetMenu(menuName = "Events/Primitive/Bool Event", fileName = "BoolEvent")]
    public class BoolEventChannelSO : EventChannelBaseSO<bool>
    {
        protected override string GetEventData(bool value) => value.ToString();
    }
}