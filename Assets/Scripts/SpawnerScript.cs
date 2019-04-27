using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

    public GameObject floor_var1, floor_var2, floor_var3;
    public GameObject bird;

    private float next_spawn_time;
    private float next_bird_spawn_time;
    private float time;

	// Use this for initialization
	void Start () {
        next_spawn_time = 1.35f;
        next_bird_spawn_time = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {

        time = Time.timeSinceLevelLoad;

        if (time > next_spawn_time)
        {
            if (GameManager.globalTimeScale >= 1.1)
            {
                spawnBird();
                spawnFloor();
            }
            else
            {
                spawnFloor();
            }

            next_spawn_time += 4.5f;
        }
	}

    public void spawnFloor()
    {
        int roll = Random.Range(1, 4);

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
                Debug.Log("Could not load fgloor object");
                break;
        }

        //Instantiate(floor_var1, transform.position, Quaternion.identity);
    }

    public void spawnBird()
    {
        Instantiate(bird, new Vector3(transform.position.x, 2), Quaternion.identity);
    }
}
