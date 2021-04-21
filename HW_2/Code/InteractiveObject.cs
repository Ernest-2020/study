using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Asteroid
{
    public abstract class InteractiveObject : MonoBehaviour, IExecute
    {
        private bool _isInteractable;

        protected abstract void Interaction();
        public abstract void Execute();

        private void Start()
        {
            IsInteractable = true;
        }
        protected bool IsInteractable
        {
            get { return _isInteractable; }
            private set
            {
                _isInteractable = value;
                GetComponent<Collider>().enabled = _isInteractable;
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
    }
}
