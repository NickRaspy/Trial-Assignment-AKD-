using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA_AKD
{
    public class Truck : Interactable
    {
        [SerializeField] private PlacedObjectsConroller placedObjectsConroller;

        public override void Interact()
        {
            if (ObjectHolder.objectHolderInstance.Pickable == null) return;

            placedObjectsConroller.AddObject(ObjectHolder.objectHolderInstance.Pickable);

            ObjectHolder.objectHolderInstance.Pickable = null;
        }
    }
}
