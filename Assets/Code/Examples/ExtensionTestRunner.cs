using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    public class ExtensionTestRunner : MonoBehaviour
    {

        public ExtensionTest test;
        // Use this for initialization
        void Start()
        {
            test.Run();
        }
    }
}

