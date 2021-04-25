using Asteroids.Object_Pool;
using UnityEngine;
namespace Asteroids
{
    public sealed class Gamecontroller : MonoBehaviour
    {
        public PlayerType PlayerType = PlayerType.Capsule;
        private Reference _reference;
        private ListExecuteObject _interactiveObject;
        private InputController _inputController;
        
        
        private void Awake()
        {

            _interactiveObject = new ListExecuteObject();

            _reference = new Reference();


            
            PlayerBase player = null;
            if (PlayerType == PlayerType.Capsule)
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
