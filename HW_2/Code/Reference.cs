using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Asteroid
{
    public sealed class Reference
    {
        private PlayerShip _playerShip;


        public PlayerShip PlayerShip
        {
            get
            {
                if (_playerShip == null)
                {
                    var gameObject = Resources.Load<PlayerShip>("Player");
                    _playerShip = Object.Instantiate(gameObject);
                }

                return _playerShip;
            }
        }
    }
}
