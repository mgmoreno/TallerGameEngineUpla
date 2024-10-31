using UnityEngine;
using UnityEngine.Events;

namespace upla.gameengine
{
    public class OnCollision2DCallbacks : BaseCollisionCallbacks
    {
        [Header("Callbacks")]
        [SerializeField] private UnityEvent onEnter;
        [SerializeField] private UnityEvent onStay;
        [SerializeField] private UnityEvent onExit;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (base.IsValidTarget(collision.gameObject))
            {
                onEnter?.Invoke();
            }
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            if (base.IsValidTarget(collision.gameObject))
            {
                onStay?.Invoke();
            }
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            if (base.IsValidTarget(collision.gameObject))
            {
                onExit?.Invoke();
            }
        }
    }
}