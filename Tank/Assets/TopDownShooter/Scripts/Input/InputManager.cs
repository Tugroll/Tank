using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerInput
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputData _inputdata;
        [SerializeField] private InputData _inputRotationdata;
         private Vector3 _lastMousepos;
        private void Update()
        {
            _inputdata.Horizontal = Input.GetAxis("Horizontal");
            _inputdata.Vertical = Input.GetAxis("Vertical");


            _inputRotationdata.Horizontal = (Input.mousePosition.x - _lastMousepos.x);
            _lastMousepos = Input.mousePosition;
            

        }
        
    }
}