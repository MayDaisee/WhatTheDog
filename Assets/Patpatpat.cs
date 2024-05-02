using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patpatpat : MonoBehaviour
{
    public ParticleSystem particlesystem;

    private void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.tag == "patpat")
        {
            particlesystem.Play();
            print("hyvä koira");
        }
    }
}
