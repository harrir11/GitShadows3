//Rebecca Harris
//April 2nd, 2023
//Script is attached to: bedroom_origin door
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorTrigger_fin : MonoBehaviour
{
    public static int currentSceneIndex;
    private bool triggerOn;
    void Update() {
        if(Input.GetKeyDown(KeyCode.E) && triggerOn) {
            Debug.Log("BEDROOM TO HALLWAY DOOR");
            currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("LastSceneIndexDoor", currentSceneIndex);
            Debug.Log("LastSceneIndexDoor: " + currentSceneIndex);
            SceneManager.LoadScene("Hallway_RH");
        }
    }


    private void OnTriggerEnter2D ( Collider2D other )
    {
        triggerOn = true;
    }

    private void OnTriggerExit2D ( Collider2D other )
    {
        triggerOn = false;
    }

}
