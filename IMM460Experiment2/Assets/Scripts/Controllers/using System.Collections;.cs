using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorTrigger : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.gameObject.tag == "player") {
            Debug.Log("triggered");
            SceneManager.LoadScene("Bedroom_Shadow_Sprite_RH");
        }
    }
}
