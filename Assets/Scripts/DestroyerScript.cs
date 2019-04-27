using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour {

    //public GameObject floor;

	void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Floor"))
        {
            //destroy object
            Destroy(col.gameObject);
        }

        if (col.CompareTag("bullet"))
            Destroy(col.gameObject);
    }
}
