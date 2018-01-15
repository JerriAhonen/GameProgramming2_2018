using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    public class TransformMover : MonoBehaviour, IMover
    {
        private float _moveSpeed;
        private float _turnSpeed;

        public void Init(float moveSpeed, float turnSpeed)
        {
            _moveSpeed = moveSpeed;
            _turnSpeed = turnSpeed;
        }

        public void Move(Vector3 movementVector)
        {

            transform.Translate(0,0,movementVector.z * _moveSpeed * Time.deltaTime);
            transform.Rotate(0, movementVector.x * _turnSpeed * Time.deltaTime, 0 );
        }
    }
}
