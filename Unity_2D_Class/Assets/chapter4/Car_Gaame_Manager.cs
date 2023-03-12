using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Car_Gaame_Manager : MonoBehaviour
{
    Car_Controller car_Controller;

    GameObject car;
    GameObject flag;
    GameObject distanceText;

    bool isGameStart = false;

    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distanceText = GameObject.Find("distance");

        car_Controller = car.GetComponent<Car_Controller>();
        isGameStart = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameStart)
        {
            float length = flag.transform.position.x - car.transform.position.x;
            if (length < 0)
            {
                distanceText.GetComponent<TMP_Text>().text = "Lose";
                isGameStart = false;
            }

            else if (length < 0.5f)
            {
                distanceText.GetComponent<TMP_Text>().text = "Win";
                isGameStart = false;

            }
            else
            {
                distanceText.GetComponent<TMP_Text>().text = "Distence :" + length.ToString("F2") + "m";
            }

            if (car_Controller.i == 5)
            {
                distanceText.GetComponent<TMP_Text>().text = "Lose";
                isGameStart = false;
            }

        }
        


    }
}
