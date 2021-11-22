using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Camera
{
    [CreateAssetMenu(menuName = "TopDownShooter/Settings/ Camera Settings")]
    public class CameraSettings : ScriptableObject
    {
        [SerializeField] private float _rotationLerpSpeed = 1;
        public float RotationLerpSpeed { get { return _rotationLerpSpeed; } }

        [SerializeField] private float _positionLerpSpeed = 1;
        public float PositionLerpSpeed { get { return _positionLerpSpeed; }  }

        [SerializeField] private Vector3 _positionOffset;

        public Vector3 Positionoffset { get { return _positionOffset; } }
    }
}