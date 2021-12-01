using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    public class PlayerInventory : MonoBehaviour
    {
        [SerializeField] private PlayerAbstractInventoryData[] _itemData;
        public Transform parent;
            
        private void Start()
        {
            InitializeInventory(_itemData);
        }

        public void InitializeInventory(PlayerAbstractInventoryData[] itemdata)
        {
            for (int i = 0; i < itemdata.Length; i++)
            {
                itemdata[i].CreatintoInventory(this);
            }
            
        }
    }
}