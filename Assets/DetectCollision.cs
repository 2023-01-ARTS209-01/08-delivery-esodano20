using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("We hit something!!! - " + collision.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        Debug.Log("We went through a TRIGGER!!! - " + trigger.gameObject.name);
    }
}

