using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour {

    public GameObject floor;

	void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Floor"))
        {
            //destroy object
            Destroy(col.gameObject);
            Instantiate(floor, new Vector3(24, -5, 3), Quaternion.identity);
        }
    }
}
