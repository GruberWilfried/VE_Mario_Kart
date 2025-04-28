using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedModifier : MonoBehaviour
{
    public AudioClip mySound;
    public AudioSource myPlayer;

    // Wird automatisch von Unity aufgerufen
    // Wenn ein GameObjekt mit einem Collider mit meinem eigenen GameObjekt kollidiert

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Kollision hat stattgefunden! " + collision.gameObject);
        collision.gameObject.GetComponent<CarController>().speed *= 2;

        Destroy(gameObject);
        if (collision.gameObject.GetComponent<CarController>())
        {
            myPlayer.PlayOneShot(mySound);
        }
    }
}
