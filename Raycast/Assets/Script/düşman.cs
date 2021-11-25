using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class düşman : MonoBehaviour
{
    // Start is called before the first frame update
    int saglık;
    void Start()
    {
        saglık = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void darbe( int darbekuvveti)
    {
        if(saglık <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            saglık -= darbekuvveti;
        }
    }
}
