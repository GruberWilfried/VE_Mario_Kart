using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public float multiplier;


    private void OnTriggerEnter(Collider other)
    {
        other.transform.localScale *= multiplier;
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.localScale /= multiplier;
    }
}
