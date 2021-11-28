using UnityEngine;
using TopDownShooter.Shoot;
using System.Collections;
using System.Collections.Generic;

using TopDownShooter.PlayerInput;

namespace TopDownShooter.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraSettings _camera;
        [SerializeField] private Transform _target;
        [SerializeField] private Transform _cameraTransform;

        public shManagment _shooting;




       

        private void Update()
        {
            CamRot();
            CamPos();
            _shooting.Fire();



        }

        private void CamRot()
        {
            _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation, Quaternion.LookRotation(_target.position - _cameraTransform.position), Time.deltaTime * _camera.RotationLerpSpeed);
        }
        private void CamPos()
        {
            _cameraTransform.position = Vector3.Lerp(_cameraTransform.position, _target.position + _camera.Positionoffset, _camera.PositionLerpSpeed * Time.deltaTime);
        }
    }
}