using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA_AKD
{
    public class PlayerInteraction : MonoBehaviour
    {
        [SerializeField] private float speed = 5f;

        private IInputHandler _inputHandler;
        private IInteractionHandler _interactionHandler;
        private IMovementHandler _movementHandler;

        private void Awake()
        {
            _inputHandler = new KeyboardInputHandler();
            _interactionHandler = new RaycastInteractionHandler();
            _movementHandler = new MovementHandler(transform, speed);
        }

        private void Update()
        {
            if (_inputHandler.IsPickKeyPressed())
            {
                _interactionHandler.HandleInteraction();
            }

            Vector3 movementInput = _inputHandler.GetMovementInput();
            if (movementInput != Vector3.zero)
            {
                _movementHandler.Move(movementInput);
            }
        }
    }
}
