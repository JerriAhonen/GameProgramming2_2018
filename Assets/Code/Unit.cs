using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    //Luokasta ei voi luoda olioita, vaan pakko periyttää alempia luokkia.
    public abstract class Unit : MonoBehaviour
    {
        private IMover _mover;

        public Weapon Weapon
        {
            get;
            protected set;
        }

        public virtual void Init()
        {
            //_mover = GetComponent<IMover>();
            //if(_mover == null)
            //{
            //    Debug.Log("Mover component not found");
            //}

            Weapon = GetComponentInChildren<Weapon>();
            if(Weapon != null)
            {
                Weapon.Init(this);
            }
        }

        public virtual void Clear()
        {

        }

        //An abstract method has to be defined in a non-abstract child class.
        protected abstract void Update();
    }
}
