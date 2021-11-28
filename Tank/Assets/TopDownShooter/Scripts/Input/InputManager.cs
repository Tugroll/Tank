using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerInput
{
    public class InputManager : MonoBehaviour
    {
       
        [SerializeField] private InputData[] _dataarray;
        
        
        private void Update()
        {


            
            for (int i = 0; i < _dataarray.Length; i++)
            {
                _dataarray[i].processinput();
            }


            
            
            

        }
        
    }
}