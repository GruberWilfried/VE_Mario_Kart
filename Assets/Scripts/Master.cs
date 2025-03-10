using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Master : MonoBehaviour
{
    public VideoPlayer vp;
    public GameObject test;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VideoPlayer>().isLooping = true;
        vp.isLooping = true;

        test.SetActive(false); // Per Funktion
        test.active = true;    // Per Variable 
    }

}
