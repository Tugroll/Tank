using UnityEngine;

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

        






        private void Update()
        {
            //    CamPos();
            //    //CamRot();

            //    _shooting.Fire();



            //}

            //private void CamRot()
            //{
            //    _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation, Quaternion.LookRotation(_target.forward), Time.deltaTime * _camera.RotationLerpSpeed);
            //}
            //private void CamPos()
            //{
            //    _cameraTransform.position = Vector3.Lerp(_cameraTransform.position, _target.position + _camera.Positionoffset, _camera.PositionLerpSpeed * Time.deltaTime);
            //
        }
    }
}