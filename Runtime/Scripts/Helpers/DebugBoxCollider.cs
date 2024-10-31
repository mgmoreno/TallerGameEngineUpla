using UnityEngine;

namespace upla.gameengine
{
    [RequireComponent(typeof(BoxCollider))]
    public class DebugBoxCollider : MonoBehaviour
    {
        private BoxCollider _collider;

        private readonly Color _colliderColor = new Color(0,1,0,.2f);
        private readonly Color _triggerColor = new Color(1, 0, 1, .2f);

        private void OnValidate()
        {
            _collider = GetComponent<BoxCollider>();
        }

        private void OnDrawGizmos()
        {
            if(!_collider) 
            {
                return;
            }

            Gizmos.color = _collider.isTrigger ? _triggerColor : _colliderColor;
            Gizmos.matrix = transform.localToWorldMatrix;
            Gizmos.DrawCube(Vector3.zero, _collider.size);
        }
    }
}