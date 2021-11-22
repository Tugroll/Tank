using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class ControllRigidbody : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private RigidbodySettings _settings;
        

        private void Update()
        {
            bool kontroll = Input.GetKeyDown(KeyCode.Space);
            if (kontroll)
            {
                _rigidbody.AddForce(_settings.Jumpforce,ForceMode.Impulse);    
            }
        }

    }
}