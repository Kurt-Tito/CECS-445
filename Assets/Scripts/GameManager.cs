using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    // Use this for initialization

    private int intScore;
    public static float globalTimeScale;
    public GameObject pauseMenu;

    private float saveTime;
    public GameObject bgm, sfx;

    void Start () {
        Time.timeScale = 1.0f;
        bgm = GameObject.Find("BGM");
        sfx = GameObject.Find("SFX");
    }

    private void Update()
    {
        intScore = (int) Score.scoreCount;
        

    }

    public void cancelButton()
    {
        pauseMenu.gameObject.SetActive(false);
        Time.timeScale = saveTime;
    }

    public void confirmButton()
    {
        SceneManager.LoadScene("MainMenu");
        Destroy(bgm);
        Destroy(sfx);
    }

	private void FixedUpdate () {
        if (intScore % 100 == 0 && intScore != 0 && Time.timeScale <= 2)
        {
            Time.timeScale += 0.02f;    
            Debug.Log(Time.timeScale);
            //Debug.Log(intScore);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            pauseMenu.gameObject.SetActive(true);
            saveTime = Time.timeScale;
            Time.timeScale = 0;
        }

        globalTimeScale = Time.timeScale;
        Debug.Log("Global Time Scale: " + globalTimeScale);
	}

}
