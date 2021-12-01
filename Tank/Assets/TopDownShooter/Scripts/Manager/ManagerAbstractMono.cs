using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    public class ManagerAbstractMono : MonoBehaviour
    {
         [SerializeField]private AbstractBaseManager[] _abstractBaseManagers;
         private List<AbstractBaseManager> _abstratcbaselist;



        private void Start()
        {
            for (int i = 0; i < _abstractBaseManagers.Length; i++)
            {
                _abstratcbaselist = new List<AbstractBaseManager>();
                var instantiated = Instantiate(_abstractBaseManagers[i]);
                instantiated.Initialize();
                _abstratcbaselist.Add(instantiated);
            }
        }
        private void OnDestroy()
        {
            if(_abstratcbaselist != null)
            {
                for (int i = 0; i < _abstractBaseManagers.Length; i++)
                {
                    _abstractBaseManagers[i].Destroy();
                }

            }
            
        }
    }
}