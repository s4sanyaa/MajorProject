using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateAI : MonoBehaviour
{
    public float chaseDistance;
    private GameObject player;
    public GameObject mainSlime;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // void Idle()
    // {
      //  LookAtCamera();
    //     mainSlime.GetComponent<SlimeAI>().CancelGoNextDestination();
    //     ChangeStateTo(SlimeState.Idle);
    // }
    public void ChangeStateTo(SlimeState state)
    {
        if (mainSlime == null) return;    
        if (state == mainSlime.GetComponent<SlimeAI>().currentState) return;

        mainSlime.GetComponent<SlimeAI>().currentState = state ;
    }
    // void LookAtCamera()
    // {
    //  //   mainSlime.transform.rotation = Quaternion.Euler(new Vector3(mainSlime.transform.rotation.x, cam.transform.rotation.y, mainSlime.transform.rotation.z));   
    // }

    private void Update()
    {
        if (Vector3.Distance(mainSlime.transform.position, player.transform.position) < chaseDistance) 
            ChangeStateTo(SlimeState.Chase);
        else
        {
            ChangeStateTo(SlimeState.Idle);
        }
    }
    
    
}

