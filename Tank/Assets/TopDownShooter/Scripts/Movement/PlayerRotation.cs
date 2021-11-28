using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerInput;
using UnityEngine;

namespace TopDownShooter.PlayerControls
{
    public class PlayerRotation : MonoBehaviour
    {
        [SerializeField] private InputData _inputdata;
        [SerializeField] private Transform _tower;
        [SerializeField] private RotationSettings _rotationsettings;

        private void Update()
        {
            _tower.Rotate(0f, _inputdata.Horizontal * _rotationsettings.towerRotSpeed, 0f, Space.Self);
        }

    }
}