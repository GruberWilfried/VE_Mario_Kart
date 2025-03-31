using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Formel : MonoBehaviour
{
    public GameObject x;
    // Start is called before the first frame update
    void Start()
    {
        string spam = Gruber("Mustermann");
        GameObject clone = Instantiate(x);
        BoxCollider box = gameObject.AddComponent<BoxCollider>();
        transform.position = new Vector3(Random.Range(0f,10f),0,0);

        bool z = Input.GetKeyDown("space");
    }


    public float NameDerFunktion(float a, float b)
    {
       return a* b;
    }

    public string Gruber(string name)
    {
        return name +name + name + name;
    }
}
