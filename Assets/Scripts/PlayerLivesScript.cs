using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLivesScript : MonoBehaviour
{
    public Text playerLivesText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerLivesText.text = "Lives: " + PlayerScript.playerLives.ToString();
    }
}
