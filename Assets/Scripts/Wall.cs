using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float scaleX = Mathf.Cos(Time.time) * 0.5f + 1;
        float scaleY = Mathf.Sin(Time.time) * 0.5f + 1;
        rend.material.mainTextureScale = new Vector2(scaleX, scaleY);

        
    }
}
