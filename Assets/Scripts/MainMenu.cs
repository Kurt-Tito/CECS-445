using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //for loading scene 

public class MainMenu : MonoBehaviour {

	public void playButton()
    {
        /* Loads the "Game" Scene */
        Debug.Log("Play Button Pressed"); //debug
        SceneManager.LoadScene("Game");
    }

    public void settingsButton()
    {
        /* Insert Settings Code Here */
        Debug.Log("Play Settings Pressed");
    }

    public void exitButton()
    {
        /* Closes the application */
        Debug.Log("Quit Button Pressed"); //debug
        Application.Quit();
    }
}
