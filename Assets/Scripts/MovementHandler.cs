using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA_AKD
{
    public class MovementHandler : IMovementHandler
    {
        private readonly Transform _transform;
        private readonly float _speed;

        public MovementHandler(Transform transform, float speed)
        {
            _transform = transform;
            _speed = speed;
        }

        public void Move(Vector3 direction)
        {
            _transform.Translate(_speed * Time.deltaTime * direction);
        }
    }
}
