using UnityEngine;
namespace Asteroid
{
    public sealed class InputController : IExecute
    {
        private readonly PlayerBase PlBase;

        public InputController(PlayerBase player)
        {
            PlBase = player;
        }
        public void Execute()
        {
            PlBase.Move(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            if (Input.GetButtonDown("Fire1"))
            {
                PlBase.Shooting();
            }
        }
    }
}
