using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "TopDownShooter/Inventory/ ScriptableShootManager")]
    public class Shootmanager : AbstractScriptableManager<Shootmanager>
    {
        public override void Initialize()
        {
            Debug.Log("ShootManagerActive");
        }
        public override void Destroy()
        {
            Debug.Log("ShootmanagerDestroy");
        }
    }
}