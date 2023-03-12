using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Controller : MonoBehaviour
{
    float speed = 0;
    bool iisGameStart = false;
    Vector2 startPos;

    public float length;
    public int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        iisGameStart = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (iisGameStart)
        {
            if (speed <= 0.001f)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    startPos = Input.mousePosition;
                }

                if (Input.GetMouseButtonUp(0))
                {
                    Vector2 endPos = Input.mousePosition;
                    length = endPos.x - startPos.x;

                    speed = length / 1000.0f;

                    GetComponent<AudioSource>().Play();
                    i++;
                }
                if(i == 5)
                {
                    iisGameStart = false;
                }
            }
            transform.Translate(speed, 0, 0);
            speed *= 0.94f;
        }
            
        
        
    }
}
