using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Asteroids
{
    internal sealed class tesst : InteractiveObject
    {
        private Rigidbody RbAsteroid;
        [SerializeField] private float AsteroidSpeed;
       
        public override void Execute()
        {
            if (!IsInteractable) { return; }
            RbAsteroid.AddForce(new Vector3(0, 0, -10) * AsteroidSpeed);
            Debug.Log("1");
        }

        protected override void Interaction()
        {
            Debug.Log("2");
        }
        void Awake()
        {
            RbAsteroid = GetComponent<Rigidbody>();
        }
    }
}
