using UnityEngine;
using System;
namespace Asteroids
{
  
    public class PlayerShip : PlayerBase
    {
        private Rigidbody2D _rigidbody;
        [SerializeField] private GameObject _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        [SerializeField] private Sprite _sprite;
        private void Start()
        {   
            _rigidbody = GetComponent<Rigidbody2D>();
        }
        public override void Move(float x, float y)
        {
            _rigidbody.AddForce(new Vector2(x, y) * Speed);
        }
        public override void Shooting()
        {
            var gameObjectBuilder = new GameObjectBuilder();
            GameObject player = gameObjectBuilder.Visual.Name("Roman").Sprite(_sprite).Physics.Rigidbody2D(5,0)
                .BoxCollider2D(false);
            player.transform.position = _barrel.position;
            player.GetComponent<Rigidbody2D>().AddForce(_barrel.up * _force); 
        }
    }
}