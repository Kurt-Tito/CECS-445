using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    private Rigidbody2D player;
    private Vector3 direction = new Vector3(0.0f, 1.0f, 0.0f);
    private float force = 40.0f;
    public static int playerLives = 3;
    //private int jumpCount = 0;

    //private bool isGrounded = false;

	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Space) && (player.velocity.y > -0.2 && player.velocity.y < 0.2)) //checks to maker sure player is grounded before pressing jump
        {
            Debug.Log("JUMPED");
            player.AddForce(direction * force, ForceMode2D.Impulse);
            //player.transform.position += direction;
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "obstacle")
        {
            Debug.Log("player hit");

            if (playerLives > 0)
                playerLives--;
        }
    }
}
