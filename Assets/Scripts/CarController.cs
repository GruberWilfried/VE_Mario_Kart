using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // Vorgehensweise 2: (Herr Grubers Empfehlungen)
    public Rigidbody manualRb;
    public float speed = 20;
    public float rotateSpeed = 3;
    public int health;
    public KeyCode forwardKey;
    public KeyCode backKey;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode jumpkey;

    public Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        // Vorgehensweise 1: (Übers GameObject)
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.mass = 2f;

        // Vorgehensweise 2: (Herr Grubers Empfehlungen)
        manualRb.mass = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(forwardKey)) // "W"
        {
            manualRb.AddRelativeForce(0,0,speed);
        }

        if (Input.GetKey(backKey)) // "S"
        {
            manualRb.AddRelativeForce(0, 0,-speed);
        }

        // Rotate
        if (Input.GetKey(leftKey)) 
        {
            transform.Rotate(0,-rotateSpeed,0);
        }

        if (Input.GetKey(rightKey)) 
        {
            transform.Rotate(0, rotateSpeed, 0);
        }

        if (Input.GetKeyDown(jumpkey))
        {
            manualRb.AddRelativeForce(0,Random.Range(300f,600f),0);
        }
    }

    public void Test()
    {
        
        Debug.Log("Test");
    }
}
