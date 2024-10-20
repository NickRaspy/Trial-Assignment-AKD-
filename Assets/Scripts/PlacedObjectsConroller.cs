using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace TA_AKD
{
    public class PlacedObjectsConroller : MonoBehaviour
    {
        [SerializeField] private PlacedObjects placedObjectPrefab;
        [SerializeField] private List<PlacedObjects> placedObjectsList = new();

        public void AddObject(PickableInfo pickable)
        {
            PlacedObjects placedObjects = placedObjectsList.Find(x => x.Pickable.pickableName == pickable.pickableName);
            if (placedObjects == null)
            {
                placedObjects = Instantiate(placedObjectPrefab, transform);
                placedObjects.Pickable = pickable;
                placedObjects.Init();
                placedObjectsList.Add(placedObjects);
            }

            placedObjects.Add();
        }
    }
}
