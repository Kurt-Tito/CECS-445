using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfxScript : MonoBehaviour
{
    public GameObject player;
    public AudioSource jump;
    public AudioSource shoot;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        //player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player");

        if (Input.GetKey(KeyCode.Space) && player.activeInHierarchy)
            jump.Play();

        if (Input.GetKey(KeyCode.Return) && player.activeInHierarchy)
            shoot.Play();
    }
}
