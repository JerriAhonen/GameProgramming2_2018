using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    public static class ExtensionMethods
    {
        public static TComponent GetOrAddComponent<TComponent>(this GameObject gameObject)
        where TComponent : Component
        {
            TComponent component = gameObject.GetComponent<TComponent>();
            if(component == null)
            {
                component = gameObject.AddComponent<TComponent>();
            }

            return component;
        }

        public static TComponent GetComponentInInactiveParents<TComponent>(this GameObject gameObject, bool includeInactive = true)
            where TComponent : Component
        {
            TComponent component = gameObject.GetComponentInParent<TComponent>();
            if (component == null)
            {
                //component = gameObject.GetComponentInParent<TComponent>(true);
                //component = gameObject.GetComponentInChildren<TComponent>(true);

                TComponent[] tcomponentList = gameObject.GetComponentsInParent<TComponent>(includeInactive);
                foreach (var item in tcomponentList)
                {
                    component = item;
                }

            }

            return component;
        }

        public static TComponent GetComponentInHierarcy<TComponent>(this GameObject gameObject, bool includeInactive = false)
            where TComponent : Component
        {
            TComponent component = gameObject.GetComponent<TComponent>();
            if (component == null)
            {
                component = gameObject.GetComponentInInactiveParents<TComponent>(includeInactive);
                if (component == null)
                {
                    component = gameObject.GetComponentInChildren<TComponent>(includeInactive);
                }
            }

            return component;
        }
    }

}
