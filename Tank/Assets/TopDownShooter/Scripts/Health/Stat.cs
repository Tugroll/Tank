using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    // Start is called before the first frame update
    private float health = 100;

    public void damage(float dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            Debug.Log("Hasar var");
            
        }
    }
}
