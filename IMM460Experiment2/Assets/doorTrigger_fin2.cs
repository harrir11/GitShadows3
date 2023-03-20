using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorTrigger_fin2 : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("trigger2");
        //testing push
        SceneManager.LoadScene("Bedroom_Shadow_Sprite_RH");
    }
}
