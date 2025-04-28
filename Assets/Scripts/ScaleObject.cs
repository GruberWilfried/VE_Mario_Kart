using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObject : MonoBehaviour
{
    private Transform colTransform;
    private MeshRenderer mr;

    private void OnCollisionEnter(Collision collision)
    {
        int randomNumber = Random.Range(0, 10);

        if (randomNumber < 5)
        {
            collision.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
        }
        else
        {
            collision.transform.localScale = new Vector3(2, 2f, 2f);
        }

        colTransform = collision.transform;
        Invoke("ResetSize",3f);
        gameObject.GetComponent<Collider>().enabled = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    public void ResetSize()
    {
        colTransform.localScale = new Vector3(1,1,1);
        Destroy(gameObject);
    }
}
