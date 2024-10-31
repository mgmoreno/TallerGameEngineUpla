using UnityEngine;

namespace upla.gameengine
{
    public abstract class BaseCollisionCallbacks : MonoBehaviour
    {
        [SerializeField] private LayerMask targetMask;
        [SerializeField] private string targetTag;

        protected bool IsValidTarget(GameObject gameObject)
        {
            return LayerMaskHelper.IsInLayerMask(targetMask, gameObject) || gameObject.tag.Equals(targetTag);
        }
    }
}