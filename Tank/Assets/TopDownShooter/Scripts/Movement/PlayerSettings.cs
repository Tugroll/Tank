using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerMovement
{
    [CreateAssetMenu(menuName = "TopDownShooter/Settings/ PlayerMovement Settings")]
    public class PlayerSettings : ScriptableObject
    {
        public float Verticalspeed = 5;
        public float Horizontalspeed = 5;
        public float JumpSpeed = 3;
    }
}