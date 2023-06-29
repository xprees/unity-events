using UnityEngine;
using Xprees.Events.ScriptableObjects.Base;

namespace Xprees.Events.ScriptableObjects.Unity
{
    [CreateAssetMenu(menuName = "Events/Unity/Sprite Event", fileName = "SpriteEventChannelSO")]
    public class SpriteEventChannelSO : EventChannelBaseSO<Sprite>
    {
    }
}