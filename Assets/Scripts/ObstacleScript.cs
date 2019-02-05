using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
	   	
	}
	
	// Update is called once per frame
	private void Update ()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        /* Insert Collision Code */
    }
}
