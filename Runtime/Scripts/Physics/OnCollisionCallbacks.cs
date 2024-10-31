using UnityEngine;
using UnityEngine.Events;

namespace upla.gameengine
{
    public class OnCollisionCallbacks : BaseCollisionCallbacks
    {
        [Header("Callbacks")]
        [SerializeField] private UnityEvent onEnter;
        [SerializeField] private UnityEvent onStay;
        [SerializeField] private UnityEvent onExit;

        private void OnCollisionEnter(Collision collision)
        {
            if (base.IsValidTarget(collision.gameObject))
            {
                onEnter?.Invoke();
            }
        }

        private void OnCollisionStay(Collision collision)
        {
            if (base.IsValidTarget(collision.gameObject))
            {
                onStay?.Invoke();
            }
        }

        private void OnCollisionExit(Collision collision)
        {
            if (base.IsValidTarget(collision.gameObject))
            {
                onExit?.Invoke();
            }
        }
    }
}