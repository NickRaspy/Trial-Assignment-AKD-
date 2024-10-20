using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA_AKD
{
    public class RaycastInteractionHandler : IInteractionHandler
    {
        public void HandleInteraction() => GetInteractable()?.Interact();

        public string ShowInteractionText() 
        {
            return GetInteractable()?.InteractionText;
        }

        private IInteract GetInteractable()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit, 2f))
            {
                if (hit.collider.TryGetComponent<IInteract>(out var interactable)) 
                    return interactable;
            }
            return null;
        }
    }
}
