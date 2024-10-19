using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TA_AKD
{
    public class Pickable : MonoBehaviour, IPickable
    {
        public void OnPick()
        {
            Destroy(gameObject);
        }
    }
}