using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        /* Insert Collision Code */
        if (col.gameObject.tag == "bullet")
        {
            Destroy(gameObject);
            Debug.Log("BULLET HIT BIRD");
        }
    }
}
