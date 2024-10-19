using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA_AKD
{
    public class RaycastInteractionHandler : IInteractionHandler
    {
        public void HandleInteraction()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                IPickable pickable = hit.collider.GetComponent<IPickable>();
                pickable?.OnPick();
            }
        }
    }
}
