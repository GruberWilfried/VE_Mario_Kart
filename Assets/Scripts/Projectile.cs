using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<CarController>() != null)
        {
            CarController car = collision.gameObject.GetComponent<CarController>();
            car.health -= 1;
            if (car.health == 0)
            {
                Destroy(collision.gameObject);
            }
            
        }

    }
}
