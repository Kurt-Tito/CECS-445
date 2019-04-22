using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    private Rigidbody2D player;
    private Vector3 direction = new Vector3(0.0f, 1.0f, 0.0f);
    private float force = 40.0f;
    public static int playerLives = 3;
    private Score score;
    private Restart start;
    //private int jumpCount = 0;

    //private bool isGrounded = false;

    // Use this for initialization
    void Start () {
        player = GetComponent<Rigidbody2D>();
        score = FindObjectOfType<Score>();
        start = FindObjectOfType<Restart>();
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

        Restart();
    }

    void Restart()
    {
        if (playerLives == 0)
        {
            start.msg = false;
            score.scoreInc = false;
            if (Input.GetKeyDown(KeyCode.Return))
            {
                playerLives = 3;
                Score.scoreCount = 0;
                score.scoreInc = true;
                start.msg = true;

                /*
                foreach (GameObject o in Object.FindObjectsOfType<GameObject>())
                {
                    Destroy(o);
                }
                */

                SceneManager.LoadScene("Game");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "obstacle")
        {
            Debug.Log("player hit");
            if (playerLives > 0)
            {
                playerLives--;
            }
          
        }
        if (col.gameObject.tag == "Fall")
        {
            playerLives = 0;
        }
        if (playerLives == 0)
        {
            Time.timeScale = 0.0f;
        }
    }
}
