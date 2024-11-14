using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class StateAI : MonoBehaviour
{
    public GameObject mainSlime;
    private GameObject player;
    
    [SerializeField] private float chaseDistance;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < chaseDistance)
        {
            ChangeStateTo(SlimeState.Chase);
        }
        else
        {
            Idle();
        }
    }
    private void Idle()
    {
        LookAtCamera();
        mainSlime.GetComponent<SlimeAI>().CancelGoNextDestination();
        ChangeStateTo(SlimeState.Idle);
    }
    public void ChangeStateTo(SlimeState state)
    {
        if (mainSlime == null) return;    
        if (state == mainSlime.GetComponent<SlimeAI>().currentState) return;
        mainSlime.GetComponent<SlimeAI>().currentState = state ;
    }
    private void LookAtCamera()
    {
        //mainSlime.transform.rotation = Quaternion.Euler(new Vector3(mainSlime.transform.rotation.x, cam.transform.rotation.y, mainSlime.transform.rotation.z));   
    }
}