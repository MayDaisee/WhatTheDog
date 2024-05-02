using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sike : MonoBehaviour
{
    public GameObject doggo;
    public GameObject newTarget;
    public GameObject oldTarget;
    private NewNavMesh newnavmesh;
    private Collider tigger;

    void Start()
    {
        newnavmesh = doggo.GetComponent<NewNavMesh>();
        tigger = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider other)
    {
        newnavmesh.target = newTarget;
    }


    private void OnTriggerExit(Collider other)
    {
        newnavmesh.target = oldTarget;
        tigger.enabled = false;
        
    }

   
}


