using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.PlayerInput;


namespace TopDownShooter.PlayerMovement
{

    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private InputData _ýnputData;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private Transform _targetBody;
        [SerializeField] private PlayerSettings _playerSettings;

        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position +(_rigidbody.transform.forward* _ýnputData.Vertical* _playerSettings.Verticalspeed));
            _targetBody.Rotate(0, _ýnputData.Horizontal * _playerSettings.Horizontalspeed, 0, Space.Self);
            

        }

    }
}