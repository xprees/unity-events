using UnityEngine;
using Xprees.Events.ScriptableObjects.Base;

namespace Xprees.Events.ScriptableObjects.Unity
{
    [CreateAssetMenu(menuName = "Events/Unity/Transform Event", fileName = "TransformEvent")]
    public class TransformEventChannelSO : EventChannelBaseSO<Transform>
    {
    }
}