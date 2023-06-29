using UnityEngine;
using Xprees.Events.ScriptableObjects.Base;

namespace Xprees.Events.ScriptableObjects.Primitive
{
    [CreateAssetMenu(menuName = "Events/Primitive/Int Event", fileName = "IntEvent")]
    public class IntEventChannelSO : EventChannelBaseSO<int>
    {
    }
}