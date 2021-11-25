using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerInput;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] private InputData _inputdata;
    [SerializeField] private Transform _tower;

    private void Update()
    {
        _tower.Rotate(0f, _inputdata.Horizontal, 0f, Space.Self);
    }

}
