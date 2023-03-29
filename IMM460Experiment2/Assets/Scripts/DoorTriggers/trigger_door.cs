using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger_door : MonoBehaviour
{
    public static int currentSceneIndex;
    private bool triggerOn;
    void Update() {
        if(Input.GetKeyDown(KeyCode.E) && triggerOn) {
            Debug.Log("HALLWAY TO KITCHEN DOOR");
            currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("LastSceneIndexDoor", currentSceneIndex);
            Debug.Log("LastSceneIndexDoor: " + currentSceneIndex);
            SceneManager.LoadScene("Kitchen_RH");
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
