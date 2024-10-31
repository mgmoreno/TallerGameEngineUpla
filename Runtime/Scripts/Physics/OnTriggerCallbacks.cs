using UnityEngine;
using UnityEngine.Events;

namespace upla.gameengine
{
    public class OnTriggerCallbacks : BaseCollisionCallbacks
    {
        [Header("Callbacks")]
        [SerializeField] private UnityEvent onEnter;
        [SerializeField] private UnityEvent onStay;
        [SerializeField] private UnityEvent onExit;

        private void OnTriggerEnter(Collider other)
        {
            if (base.IsValidTarget(other.gameObject))
            {
                onEnter?.Invoke();
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (base.IsValidTarget(other.gameObject))
            {
                onStay?.Invoke();
            }

        }

        private void OnTriggerExit(Collider other)
        {
            if (base.IsValidTarget(other.gameObject))
            {
                onExit?.Invoke();
            }
        }
    }
}