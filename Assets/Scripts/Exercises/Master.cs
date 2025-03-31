using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
//using UnityEngine.UI;

public class Master : MonoBehaviour
{
    public VideoPlayer vp;
    public Light light;
    public GameObject go;
    public Camera cam;
    public Toggle t;
    public Text tx;
    public CarController car; // Von uns selbst geschriebene Klasse

    // Start is called before the first frame update
    void Start()
    {
        vp.isLooping = true;
        vp.playOnAwake = true;
        light.intensity = 0.5f;
        light.cookieSize = 10f;
        go.name = "Name!";
        go.active = true;
        //go.SetActive(true);
        cam.depth = 10f;
        t.interactable = true;
        tx.text = "Hello World";
        tx.fontSize = 34;
        car.speed = 12;
    }

}
