using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorTrigger4 : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("trigger3");
        SceneManager.LoadScene("Hallway_RH");
    }
}
