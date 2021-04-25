using UnityEngine;
using static UnityEngine.Random;
namespace Asteroids
{
    public abstract class InteractiveObject : MonoBehaviour, IExecute
    {
        
        protected Color _color;

        private bool _isInteractable;
        protected bool IsInteractable
        {
            get { return _isInteractable; }
            private set
            {
                _isInteractable = value;

                
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!IsInteractable || !other.CompareTag("Player"))
            {
                return;
            }
            Interaction();
            IsInteractable = false;
        }

        protected abstract void Interaction();
        public abstract void Execute();

        private void Start()
        {
            IsInteractable = true;
            _color = ColorHSV();
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = _color;
            }
        }
    }

}


