using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restartti : MonoBehaviour
{
    
    public void doRestart()
    {
        print("klikkist�");
        SceneManager.LoadScene("WTDD");
    }
}
