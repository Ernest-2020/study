using UnityEngine;
namespace Asteroids
{
    public class PlayerShip : PlayerBase
    {
        private Rigidbody _rigidbody;
        [SerializeField] private Rigidbody _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
        public override void Move(float x, float y, float z)
        {
            _rigidbody.AddForce(new Vector3(x, y, z) * Speed);
        }
        public override void Shooting()
        {
            var temAmmunition = Instantiate(_bullet, _barrel.position, _barrel.rotation);
            temAmmunition.AddForce(_barrel.up * _force);
        }
        

    }
}
    


