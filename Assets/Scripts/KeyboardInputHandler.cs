using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA_AKD
{
    public class KeyboardInputHandler : IInputHandler
    {
        public bool IsPickKeyPressed()
        {
            return Input.GetKeyDown(KeyCode.E);
        }

        public Vector3 GetMovementInput()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            return new Vector3(horizontal, 0, vertical);
        }
    }
}
