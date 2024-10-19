using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA_AKD
{
    [RequireComponent(typeof(MeshRenderer))]
    public class Maskable3DObject : MonoBehaviour
    {
        [SerializeField] private int RQ = 2000;
/*        void Awake()
        {
            GetComponent<MeshRenderer>().material.renderQueue = 2000;
        }*/
        private void Update()
        {
            GetComponent<MeshRenderer>().material.renderQueue = RQ;
        }
    }
}
