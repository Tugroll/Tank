using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerInput
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputData _inputdata;
        private void Update()
        {
            _inputdata.Horizontal = Input.GetAxis("Horizontal");
            _inputdata.Vertical = Input.GetAxis("Vertical");
            _inputdata.Jump = Input.GetAxis("Jump");
        }
    }
}