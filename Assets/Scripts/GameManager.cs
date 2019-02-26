using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    // Use this for initialization

    private int intScore;

	void Start () {
        Time.timeScale = 1.0f;
    }

    private void Update()
    {
        intScore = (int) Score.scoreCount;
    }

	private void FixedUpdate () {
        if (intScore % 100 == 0 && intScore != 0 && Time.timeScale <= 2)
        {
            Time.timeScale += 0.02f;    
            Debug.Log(Time.timeScale);
            //Debug.Log(intScore);
        }
	}
}
