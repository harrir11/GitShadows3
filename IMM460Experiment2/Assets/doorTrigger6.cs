using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorTrigger6 : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("trigger");
        SceneManager.LoadScene("Bedroom_Shadow_Sprite_RH");
    }
}
