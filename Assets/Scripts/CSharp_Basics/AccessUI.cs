using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccessUI : MonoBehaviour
{
    public Button button;

    public Sprite mySprite;
    public Sprite mySprite2;
    public Sprite mySprite3;
    public Image myImage;


    void Start()
    {
        button.interactable = false;
        myImage.sprite = mySprite;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            myImage.sprite = mySprite;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            myImage.sprite = mySprite2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            myImage.sprite = mySprite3;
        }
    }
}
