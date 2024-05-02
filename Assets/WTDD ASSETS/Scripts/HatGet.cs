using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatGet : MonoBehaviour

{

    public Transform hattuAnkkuri;


      private void OnTriggerEnter(Collider other)
    {
        hattumanager.instance.AddHat(this);
    }

}
