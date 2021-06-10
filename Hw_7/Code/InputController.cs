using UnityEngine;

namespace Asteroids
{
    
    internal sealed class InputController : IExecute
    {
        private readonly PlayerBase PlBase;


        public InputController(PlayerBase player)
        {
            PlBase = player;

        }
        public void Execute()
        {
            PlBase.Move(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));

            if (Input.GetButtonDown("Fire1"))
            {
                PlBase.Shooting();
            }
        }
    }
}