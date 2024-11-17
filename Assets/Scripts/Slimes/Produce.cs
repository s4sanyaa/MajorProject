using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Produce : MonoBehaviour
{
    [SerializeField] private string prefType, favFood;
    [SerializeField] private GameObject resource;

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Food"))
        {
            if (other.gameObject.GetComponent<Food>().type == prefType)
            {
                Instantiate(resource, transform.position, transform.rotation);
                if (other.gameObject.GetComponent<Food>().name == favFood)
                {
                    Instantiate(resource, transform.position, transform.rotation);
                    
                }
                
            }
            Destroy(other.gameObject);
        }
        
    }
}
