using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace TA_AKD
{
    public class Player : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField] private float speed = 5f;
        [SerializeField] private Transform cameraTransform;

        [Header("UI")]
        [SerializeField] private TMP_Text interactionText;

        private IInputHandler _inputHandler;
        private IInteractionHandler _interactionHandler;
        private IMovementHandler _movementHandler;

        private void Awake()
        {
            _inputHandler = new InputHandler();
            _interactionHandler = new RaycastInteractionHandler();
            _movementHandler = new MovementHandler(transform, cameraTransform, speed);
        }

        private void Update()
        {
            interactionText.text = _interactionHandler.ShowInteractionText();

            if (_inputHandler.IsPickKeyPressed()) 
                _interactionHandler.HandleInteraction();

            Vector3 movementInput = _inputHandler.GetMovementInput();
            Vector2 rotationInput = _inputHandler.GetRotationInput();

            if (movementInput != Vector3.zero) 
                _movementHandler.Move(movementInput);
            if (rotationInput != Vector2.zero)
                _movementHandler.Rotate(rotationInput);
        }
    }
}
