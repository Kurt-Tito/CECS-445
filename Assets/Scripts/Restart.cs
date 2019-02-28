using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public Text restart;
    public string message;
    public bool msg;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (msg ==false)
        {
            restart.text = message;
        }
    }
}
