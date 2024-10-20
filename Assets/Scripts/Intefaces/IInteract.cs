using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA_AKD
{
    public interface IInteract
    {
        string InteractionText { get; }
        void Interact();
    }
}
