using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;

    private void Start()
    {
        //player1.GetComponent<CarController>().speed = 34f;
        CarController car = player1.GetComponent<CarController>();
        car.speed = 34f;
        car.Test();

        CarController car2 = player2.GetComponent<CarController>();
        car2.speed = 234f;
        car2.Test();
    }

    private void Update()
    {
        //if (player1.transform.position.y > 
        //    player2.transform.position.y)
        //{

        //}
    }
}
