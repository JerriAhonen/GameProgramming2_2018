using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    public class PlayerUnit : Unit
    {
        public const string HorizontalAxis = "Horizontal";
        public const string VerticalAxis = "Vertical";

        public float moveSpeed;
        public float turnSpeed;
        
        public TransformMover transformMover;

        private void Start()
        {
            transformMover.Init(moveSpeed, turnSpeed);
            Init();
        }

        public Vector3 GetInputVector()
        {
            float horizontalInput = Input.GetAxis(HorizontalAxis);
            float verticalInput = Input.GetAxis(VerticalAxis);

            return new Vector3(horizontalInput, 0, verticalInput);
        }

        protected override void Update()
        {
            transformMover.Move(GetInputVector());
        }

    }
}
