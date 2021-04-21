using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Asteroid
{
    public sealed class Damage : InteractiveObject
    {
        private float Hp = 100;

        protected override void Interaction()
        {
            if (Hp <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                Hp--;
            }
        }
         
        public override void Execute()
        {


        }
        

    }
}
