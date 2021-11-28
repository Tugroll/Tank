using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Shoot
{
    public class shManagment : MonoBehaviour
    {
        public void Fire()
        {
            RaycastHit hit;
            Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity);
            //Debug.DrawLine(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.black);
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);

            hit.collider.GetComponent<Stat>()
                .damage(20);

             

        }



    }
}
