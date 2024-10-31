using UnityEngine;
using UnityEngine.Events;

namespace upla.gameengine
{
    public class OnTrigger2DCallbacks : BaseCollisionCallbacks
    {
        [Header("Callbacks")]
        [SerializeField] private UnityEvent onEnter;
        [SerializeField] private UnityEvent onStay;
        [SerializeField] private UnityEvent onExit;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (base.IsValidTarget(other.gameObject))
            {
                onEnter?.Invoke();
            }
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            if (base.IsValidTarget(other.gameObject))
            {
                onStay?.Invoke();
            }

        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (base.IsValidTarget(other.gameObject))
            {
                onExit?.Invoke();
            }
        }
    }
}