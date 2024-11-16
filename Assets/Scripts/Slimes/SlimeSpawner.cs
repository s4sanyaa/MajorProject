using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SlimeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] slimes;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject slime in slimes)
            {
                int randomIndex = Random.Range(10, 15);
                for (int i = 0; i < randomIndex; i++)
                {
                    Instantiate(slime, transform.position, Quaternion.identity, transform);
                    
                }
                
            }

            GetComponent<BoxCollider>().size *= 5;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (Transform child in transform)
            {
                Destroy(child.gameObject);
            }

            GetComponent<BoxCollider>().size /= 5;
        }
    }
}
