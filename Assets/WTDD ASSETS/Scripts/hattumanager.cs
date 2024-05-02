using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hattumanager : MonoBehaviour
{
    public static hattumanager instance;
    public Transform hattuSpot;
    public List<HatGet> hats;
    public GameObject nappi;

    void Awake()
    {
        instance = this;
        hats = new List<HatGet>();
    }

   public void AddHat(HatGet hat)
    {
        if (hats.Contains(hat)) return;
        hat.gameObject.transform.position = GetHatSpot().position;
        hat.gameObject.transform.rotation = GetHatSpot().rotation;
        hat.gameObject.transform.parent = hattuSpot;

        hats.Add(hat);
    }
    
    Transform GetHatSpot()
    {
        if (hats.Count > 0)
        {
            return hats[hats.Count - 1].hattuAnkkuri;
        }

        else
        {
            return hattuSpot;
        }
    }

    private void Update()
    {
        if (hats.Count == 10)
        {
            nappi.SetActive(true);
            print("all hats get");
        }
    }
}
