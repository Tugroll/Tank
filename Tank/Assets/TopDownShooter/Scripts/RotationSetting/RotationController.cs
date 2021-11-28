using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerInput;
using UnityEngine;

namespace TopDownShooter.PlayerControls
{
    public class RotationController : MonoBehaviour
    {
        [SerializeField] InputData _inputdata;
        [SerializeField] Transform _towerTransform;
        [SerializeField] RotationSettings Lerpspeed;

        private void Update()
        {
            _towerTransform.Rotate(0, _inputdata.Horizontal * Lerpspeed.towerRotSpeed, 0, Space.Self);
        }

    }
}