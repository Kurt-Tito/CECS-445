using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioToggleScript : MonoBehaviour
{
    public AudioSource bgm;
    //public AudioSource sfx;
    public GameObject sfx;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggletBGMon()
    {
        bgm.mute = false;
    }

    public void ToggletBGMoff()
    {
        bgm.mute = true;
    }

    public void ToggleSFXon()
    {
        sfx.gameObject.SetActive(true);
    }

    public void ToggleSFXoff()
    {
        sfx.gameObject.SetActive(false);
    }
}
