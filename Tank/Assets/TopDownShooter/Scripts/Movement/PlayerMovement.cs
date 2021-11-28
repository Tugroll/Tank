using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.PlayerInput;


namespace TopDownShooter.PlayerMovement
{

    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private InputData _�nputData;
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private Transform _targetBody;
        [SerializeField] private PlayerSettings _playerSettings;

        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position +(_rigidbody.transform.forward* _�nputData.Vertical* _playerSettings.Verticalspeed));
            _targetBody.Rotate(0, _�nputData.Horizontal * _playerSettings.Horizontalspeed, 0, Space.Self);
            

        }

    }
}