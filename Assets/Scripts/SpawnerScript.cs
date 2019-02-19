using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

    public GameObject floor;
    public float next_spawn_time;

	// Use this for initialization
	void Start () {
        next_spawn_time = 4.75f;
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Time.time > next_spawn_time)
        {
            spawnFloor();
            next_spawn_time += 4.75f;
        }
	}

    public void spawnFloor()
    {
        Instantiate(floor, transform.position, Quaternion.identity);
    }
}
