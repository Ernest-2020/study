using System;
using UnityEngine;
namespace Asteroids
{
    public abstract class PlayerBase : MonoBehaviour
    {
        public float Hp = 100;
        public float Speed = 10f;

        public abstract void Move(float x, float y, float z);
        public abstract void Shooting();
        
    }
}


