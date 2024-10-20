using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TA_AKD
{
    public class MovementHandler : IMovementHandler
    {
        private readonly Transform _transform;
        private readonly Transform _cameraTransform;
        private readonly float _speed;

        public MovementHandler(Transform transform, Transform cameraTransform, float speed)
        {
            _transform = transform;
            _cameraTransform = cameraTransform;
            _speed = speed;
        }

        public void Move(Vector3 direction)
        {
            _transform.Translate(_speed * Time.deltaTime * direction);
        }
        public void Rotate(Vector2 rotation)
        {
            _transform.Rotate(Vector3.up, rotation.x);
            _cameraTransform.Rotate(Vector3.right, -rotation.y);
        }
    }
}
