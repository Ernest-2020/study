using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Asteroids
{
    internal sealed class AsteroidMove : InteractiveObject
    {
        [SerializeField] private Rigidbody RbAsteroid;
        [SerializeField] private float AsteroidSpeed;

        private readonly PlayerShip PlShip;


        public AsteroidMove(PlayerShip player)
        {
            PlShip = player;

        }

        public override void Execute()
        {
            if (!IsInteractable) { return; }
            Move();
        }

        protected override void Interaction()
        {
            Destroy(gameObject);

        }
        private void Move()
        {
            RbAsteroid.AddForce(new Vector3(0, 0, -10) * AsteroidSpeed);
        }

        private void Update()
        {
            Move();
        }
        
    }





}

