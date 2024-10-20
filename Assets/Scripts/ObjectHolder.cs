using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TA_AKD
{
    public class ObjectHolder : MonoBehaviour
    {
        public static ObjectHolder objectHolderInstance;
        private void Awake()
        {
            if (objectHolderInstance == null) objectHolderInstance = this;
            else Destroy(gameObject);
        }

        private PickableInfo pickable;

        public PickableInfo Pickable
        {
            get => pickable;
            set
            {
                pickable = value;
                pickableImage.sprite = value == null ? defaultImage : value.pickableSprite;
            }
        }

        [SerializeField] private Image pickableImage;
        [SerializeField] private Sprite defaultImage;
    }
}
