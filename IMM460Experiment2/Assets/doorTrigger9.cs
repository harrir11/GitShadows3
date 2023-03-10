using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorTrigger9 : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("trigger");
        SceneManager.LoadScene("Kitchen_RH");
    }
}
