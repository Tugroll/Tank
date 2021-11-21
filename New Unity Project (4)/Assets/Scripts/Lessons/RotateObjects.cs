using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class RotateObjects : MonoBehaviour
    {
        // Start is called before the first frame update
        
        [SerializeField] private Rotatesettings _rotatesetting;

        private void Update()
        {
            transform.Rotate(Vector3.up, _rotatesetting.Speed * Time.deltaTime);
        }
    }
}