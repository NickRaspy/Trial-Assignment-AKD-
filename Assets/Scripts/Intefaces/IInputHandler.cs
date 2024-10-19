using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA_AKD
{
    public interface IInputHandler
    {
        bool IsPickKeyPressed();
        Vector3 GetMovementInput();
    }
}
