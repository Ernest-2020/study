using UnityEngine;
using System;
namespace Asteroids
{
    [Serializable]
    public sealed class Gamecontroller : MonoBehaviour
    {
        public PlayerType PlayerType = PlayerType.Quad;
        private Reference _reference;
        private ListExecuteObject _interactiveObject;
        private InputController _inputController;
       


        private void Awake()
        {

            _interactiveObject = new ListExecuteObject();

            _reference = new Reference();


            
            PlayerBase player = null;
            if (PlayerType == PlayerType.Quad)
            {
                player = _reference.PlayerShip;
            }


            if (Application.platform == RuntimePlatform.WindowsEditor)
            {
                _inputController = new InputController(player);
                _interactiveObject.AddExecuteObject(_inputController);
            }
        }

        private void Update()
        {
            for (var i = 0; i < _interactiveObject.Length; i++)
            {
                var interactiveObject = _interactiveObject[i];

                if (interactiveObject == null)
                {
                    continue;
                }
                interactiveObject.Execute();
            }

        }
    }
}
