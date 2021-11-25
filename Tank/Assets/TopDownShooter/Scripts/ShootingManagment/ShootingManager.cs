using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace TopDownShooter.Shooting
{
    public class ShootingManager : MonoBehaviour
    {
       
        public void Shoot(Vector3 from, Vector3 Direction)
        {
            RaycastHit hit;
            Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity);
            //Debug.DrawLine(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.black);
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);

            var saglýk = hit.collider.GetComponent<Stat>();

            if (saglýk != null)
            {
                saglýk.damage(20);
            }

        }
 

    }
}