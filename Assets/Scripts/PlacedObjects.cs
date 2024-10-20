using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TA_AKD
{
    public class PlacedObjects : MonoBehaviour
    {
        public PickableInfo Pickable {  get; set; }

        private int objectCount = 0;

        [SerializeField] private Image objectImage;
        [SerializeField] private TMP_Text objectCountText;

        public void Init()
        {
            objectImage.sprite = Pickable?.pickableSprite;
        }

        public void Add()
        {
            objectCount++;
            objectCountText.text = objectCount.ToString();
        }
    }
}
