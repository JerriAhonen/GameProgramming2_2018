using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    public class ExtensionTest : MonoBehaviour
    {
        public Collider collider;

        public bool includeInactive;

        public void Run()
        {
            collider = gameObject.GetComponentInHierarcy<Collider>(includeInactive);
        }
    }
}


