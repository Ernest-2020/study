using System;
using UnityEngine;
namespace Asteroids
{
    
    public abstract class PlayerBase : MonoBehaviour
    {
        public float Speed;
        public abstract void Move(float x, float y);
        public abstract void Shooting();
    }
}
