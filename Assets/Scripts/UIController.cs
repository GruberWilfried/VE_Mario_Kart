using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public CarController player1;
    public CarController player2;

    public Text p1ui;
    public Text p2ui;

    private void Update()
    {
        //GameObject.FindObjectsOfType<CarController>();
        p1ui.text = "Player 1:" + player1.health;
        p2ui.text = "Player 2:" + player2.health;
    }
}
