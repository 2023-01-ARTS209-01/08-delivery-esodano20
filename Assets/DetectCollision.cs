 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // instance variales for the class

    private bool hasPackage = false;

    SpriteRenderer spriteRenderer;
    [SerializeField]  Color hasPackageColor;
    [SerializeField]  Color doesNotHavePackageColor;
  
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("We hit something!!! - " + collision.gameObject.name);

        if(collision.gameObject.CompareTag("Obsticle"))
        {
            Debug.Log("We hit something!!!");
    
        }
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        //Debug.Log("We went through a TRIGGER!!! - " + trigger.gameObject.name);

        if(trigger.gameObject.CompareTag("BoostPad"))
        {
            Debug.Log("Hit a boost pad wooo!!!");


        }

        if(trigger.gameObject.CompareTag("Package") && !hasPackage)
        {
            Debug.Log(">>>> Picked up packege!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(trigger.gameObject, 0.5f);
        }

        if(trigger.gameObject.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("<<<< Delivered the package!");
            spriteRenderer.color = doesNotHavePackageColor;
            hasPackage = false;
        }
    }
}   
    

