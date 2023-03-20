using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorTrigger7: MonoBehaviour
{
    private bool triggerOn;
    void Update() {
        if(Input.GetKeyDown(KeyCode.E) && triggerOn) {
            SceneManager.LoadScene("Bathroom_RH");
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
