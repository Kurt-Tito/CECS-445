using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    Material material;
    Vector2 move;

    public int xVelocity, yVelocity;
    private void Awake()
    {
        material = GetComponent<Renderer>().material;        
    }
    // Start is called before the first frame update
    void Start()
    {
        move = new Vector2(xVelocity, yVelocity);
    }

    // Update is called once per frame
    void Update()
    {
        material.mainTextureOffset += (move * Time.deltaTime) / 15;
    }
}
