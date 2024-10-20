using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA_AKD
{
    public abstract class Interactable : MonoBehaviour, IInteract
    {
        [SerializeField] private string interactionText;

        public string InteractionText => interactionText;

        public abstract void Interact();
    }
}