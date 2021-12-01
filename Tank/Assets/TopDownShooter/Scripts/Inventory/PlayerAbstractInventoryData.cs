using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    public enum InventoryItemDataType { Canon, Body }
    [CreateAssetMenu(menuName = "TopDownShooter/Inventory/ Player Inventory Canon Data")]
    public abstract class PlayerAbstractInventoryData : ScriptableObject
    {
        [SerializeField] protected string _itemID;
        [SerializeField] protected InventoryItemDataType _ýnventoryItemDataType;
        [SerializeField] protected GameObject _prefab;

        public abstract void CreatintoInventory(PlayerInventory _targetPlayerInventory);

        protected GameObject InstantiatePrefabintoParent(Transform Parent)
        {
            Instantiate(_prefab, Parent);

            return _prefab;
        }
    }
}