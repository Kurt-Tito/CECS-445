using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

    public GameObject floor_var1, floor_var2, floor_var3;
    private float next_spawn_time;

	// Use this for initialization
	void Start () {
        next_spawn_time = 1.35f;
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Time.time > next_spawn_time)
        {
            spawnFloor();
            next_spawn_time += 4.5f;
        }
	}

    public void spawnFloor()
    {
        int roll = Random.Range(1, 3);

        switch (roll)
        {
            case 1:
                Instantiate(floor_var1, transform.position, Quaternion.identity);
                break;
            case 2:
                Instantiate(floor_var2, transform.position, Quaternion.identity);
                break;
            case 3:
                Instantiate(floor_var3, transform.position, Quaternion.identity);
                break;
            default:
                Debug.Log("Could not load floor object");
                break;
        }

        //Instantiate(floor_var1, transform.position, Quaternion.identity);
    }
}
