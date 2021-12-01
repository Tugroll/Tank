using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory {
    [CreateAssetMenu(menuName = "TopDownShooter/Inventory/ Player Inventory Canon Data")]
    public class InventoryCanonData : PlayerAbstractInventoryData
    {
        // Start is called before the first frame update
        public override void CreatintoInventory(PlayerInventory _targetPlayerInventory)
        {
            var Instantiated = InstantiatePrefabintoParent(_targetPlayerInventory.parent);
            Debug.Log("This is Player Canon ItemData");
        }
    }
}