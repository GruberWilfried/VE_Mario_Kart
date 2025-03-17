using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTypes : MonoBehaviour
{
    // Value Type
    public int myValue;
    public int newValue;
    public float floatValue;
    public string stringValue; // Formal gesehen ein Reference Type verhält sicher aber wie ein value Type
    public bool boolValue;
    public Vector3 vec;
    public Quaternion quat;
    public Color col;


    // Reference Type
    public GameObject a;
    public GameObject b;

    public Rigidbody rb;
    public MeshRenderer mr;
    public AudioSource s;
    public Transform t;
    public AudioClip clip;
    public Material mat;
    public MeshCollider coll;
    public Mesh mesh;
    public SpriteRenderer rend;
    public Renderer rend1;
    public VariableTypes var;
    // ...............

    private void Start()
    {
        // Value type
        myValue = 13;
        newValue = myValue;
        myValue = 24;
        //newValue = ???; // hat den Wert 13

        string u = "test";
        string v = u;
        u = "new test";
        //v = ???? // hat den Wert "test"

        // Reference Type
        a.name = "Gruber";
        b = a;
        a.name = "Neuer Gruber";
        //b.name = ???; // b.name hat den Wert "Neuer Gruber"
    }
}
