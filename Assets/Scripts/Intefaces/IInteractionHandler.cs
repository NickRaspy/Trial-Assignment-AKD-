using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA_AKD
{
    public interface IInteractionHandler
    {
        string ShowInteractionText();
        void HandleInteraction();
    }
}
