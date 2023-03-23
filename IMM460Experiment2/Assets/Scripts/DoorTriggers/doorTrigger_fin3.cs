using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorTrigger_fin3 : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("trigger2");
        SceneManager.LoadScene("Bedroom_Shadow_Sprite_R");
    }
}
