using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFollowPlayer : MonoBehaviour
{
    public Transform player; 

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = player.position - transform.position;

            direction.y = 0;

            Quaternion targetRotation = Quaternion.LookRotation(-direction);

            transform.rotation = targetRotation;
        }
    }
}
