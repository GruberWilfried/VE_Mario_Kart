using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedModifier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Wird automatisch von Unity aufgerufen
    // Wenn ein GameObjekt mit einem Collider mit meinem eigenen GameObjekt kollidiert

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Kollision hat stattgefunden! " + collision.gameObject);
        collision.gameObject.GetComponent<CarController>().speed *= 2;
        Destroy(gameObject);

    }
}
