using BNG;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class NewNavMesh : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    public GameObject target;
    public GameObject cmere;
    public bool leashtrigger { get; set; }


    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        //transform.LookAt(navMeshAgent.destination, transform.position); //////Didnt need this ayo

        if (leashtrigger == true)
        {
            navMeshAgent.destination = cmere.transform.position;
         

        }

        else
        {
            navMeshAgent.destination = target.transform.position;
            
        }

    }
}
