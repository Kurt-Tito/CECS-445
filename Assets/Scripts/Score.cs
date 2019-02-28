using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;
    public static float scoreCount;
    public float highscoreCount;
    public float points;
    public bool scoreInc;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (scoreInc)
        {
            scoreCount += points * Time.deltaTime;
        }
        if (scoreCount > highscoreCount)
        {
            highscoreCount = scoreCount;
        }
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        highscoreText.text = "High Score: " + Mathf.Round(highscoreCount);

    }
}
