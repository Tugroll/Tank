using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "TopDownShooter/Inventory/ Player Inventory Body Data")]
    public class PlayerInventoryBodyItemData : PlayerAbstractInventoryData
    {
        public override void CreatintoInventory(PlayerInventory _targetPlayerInventory)
        {
            var Instantiated = InstantiatePrefabintoParent(_targetPlayerInventory.parent);

            Debug.Log("This is Body Item Data");
        }
    }
}