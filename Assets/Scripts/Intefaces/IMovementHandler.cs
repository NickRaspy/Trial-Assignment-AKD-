using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA_AKD
{
    public interface IMovementHandler
    {
        void Move(Vector3 direction);
        void Rotate(Vector2 rotation);
    }
}
