using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;
    public float scoreCount;
    public float highscoreCount;
    public float points;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreCount += points * Time.deltaTime;
        if (scoreCount > highscoreCount)
        {
            highscoreCount = scoreCount;
        }
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        highscoreText.text = "High Score: " + Mathf.Round(highscoreCount);

    }
}
