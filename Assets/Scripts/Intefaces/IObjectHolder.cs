using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA_AKD
{
    public interface IObjectHolder
    {
        PickableInfo PickableInfo { get; set; }
        void SetObject(bool isNull);
    }
}
