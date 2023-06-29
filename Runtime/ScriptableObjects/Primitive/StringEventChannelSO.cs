using UnityEngine;
using Xprees.Events.ScriptableObjects.Base;

namespace Xprees.Events.ScriptableObjects.Primitive
{
    [CreateAssetMenu(menuName = "Events/Primitive/String Event", fileName = "StringEvent")]
    public class StringEventChannelSO : EventChannelBaseSO<string>
    {
        public bool logContentAsEventData = false;

        protected override string GetEventData(string value) => logContentAsEventData ? value : null;
    }
}