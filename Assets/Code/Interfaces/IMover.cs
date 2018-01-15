using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    public interface IMover
    {
        /// <summary>
        /// Initialises the Mover
        /// </summary>
        /// <param name="moveSpeed"></param>
        /// <param name="turnSpeed"></param>
        void Init(float moveSpeed, float turnSpeed);

        /// <summary>
        /// Moves and turns the tank acording to the user's input.
        /// </summary>
        /// <param name="input"></param>
        void Move(Vector3 input);
    }
}
