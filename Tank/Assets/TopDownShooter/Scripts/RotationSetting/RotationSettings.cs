using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerControls
{
    [CreateAssetMenu(menuName = "TopDownShooter/Settings/TowerRotation Settings")]
    public class RotationSettings : ScriptableObject
    {
        public float towerRotSpeed = 0.5f;
    }
}