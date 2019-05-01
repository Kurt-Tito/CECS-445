using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //for loading scene 

public class MainMenu : MonoBehaviour {

    public GameObject tutorialPanel;
    public GameObject settingsPanel;
    public GameObject menuPanel;

	public void playButton()
    {
        /* Loads the "Game" Scene */
        Debug.Log("Play Button Pressed"); //debug
        SceneManager.LoadScene("Game");
    }

    public void tutorialButton()
    {
        tutorialPanel.gameObject.SetActive(true);
        menuPanel.gameObject.SetActive(false);
    }

    public void settingsButton()
    {
        /* Insert Settings Code Here */
        Debug.Log("Play Settings Pressed");
        menuPanel.gameObject.SetActive(false);
        settingsPanel.gameObject.SetActive(true);
    }

    public void exitButton()
    {
        /* Closes the application */
        Debug.Log("Quit Button Pressed"); //debug
        Application.Quit();
    }

    public void okayButton()
    {
        if (tutorialPanel.activeInHierarchy)
        {
            tutorialPanel.gameObject.SetActive(false);
            menuPanel.gameObject.SetActive(true);
        }
        else
        {
            settingsPanel.gameObject.SetActive(false);
            menuPanel.gameObject.SetActive(true);
        }
    }
}
