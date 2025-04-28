using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarShooter : MonoBehaviour
{
    public float shootForce = 2000;
    public KeyCode shootKey;
    public GameObject projectile;
    public Transform spawnPos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(shootKey))
        {
            GameObject inst = Instantiate(projectile,spawnPos.position, spawnPos.rotation);
            inst.GetComponent<Rigidbody>().AddRelativeForce(0,0, shootForce);

        }
    }
}
