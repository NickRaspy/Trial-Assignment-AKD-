using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TA_AKD
{
    public class Pickable : Interactable
    {
        public PickableInfo pickableInfo;

        public override void Interact()
        {
            if (ObjectHolder.objectHolderInstance.Pickable != null) return;

            ObjectHolder.objectHolderInstance.Pickable = pickableInfo;

            Destroy(gameObject);
        }
    }
}