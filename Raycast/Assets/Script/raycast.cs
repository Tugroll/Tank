using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float Horizontal;
    [SerializeField] private float Vertical;
    [SerializeField] private GameObject Mermi;
    [SerializeField] private GameObject Firepoint;
    [SerializeField] private GameObject Mermiizi;
    
     

    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        
        transform.Translate(new Vector3(Horizontal,0f, Vertical) * 10 * Time.deltaTime);



        //int layermask = 1 << 6;
        //layermask = ~layermask;

        //RaycastHit hit;
        //if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity,layermask))
        //{
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        //}
        //else
        //{
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
        //}
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Instantiate(Mermi, Firepoint.transform.position, Firepoint.transform.rotation);
            
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                if (hit.rigidbody != null)
                {

                    hit.transform.gameObject.GetComponent<düþman>().darbe(20);
                    Instantiate(Mermiizi, hit.point, Quaternion.identity);
                    
                }
            }

            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            }
        }
    }
}
