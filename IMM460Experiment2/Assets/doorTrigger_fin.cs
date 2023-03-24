using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorTrigger_fin : MonoBehaviour
{
    private bool triggerOn;
    public int defaultPositionIndex = 0;
    public int previousSceneIndex;
    //public GameObject player;

    public List<Vector3> previousScenePositions = new List<Vector3>();

    void Start()
        {
            //player = GameObject.FindWithTag("player");

            previousScenePositions.Add(new Vector3(0, 0, 0)); // add elements dynamically
            // ...
            previousScenePositions.Add(new Vector3(2.8f,-2.70000005f,0.150000006f));
            previousScenePositions.Add(new Vector3(2.5f,-2.70000005f,0.150000006f));
            previousScenePositions.Add(new Vector3(2.5f,-2.70000005f,0.150000006f));
            previousScenePositions.Add(new Vector3(2.5f,-2.70000005f,0.150000006f));
            previousScenePositions.Add(new Vector3(2.5f,-2.70000005f,0.150000006f));
            previousScenePositions.Add(new Vector3(2.5f,-2.70000005f,0.150000006f));
            previousScenePositions.Add(new Vector3(2.5f,-2.70000005f,0.150000006f));
            previousScenePositions.Add(new Vector3(2.5f,-2.70000005f,0.150000006f));
            
            // Get the index of the previous scene
            previousSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
            //print("buildIndex " + SceneManager.GetActiveScene().buildIndex);
            //print("previousSceneIndex: " + previousSceneIndex);
            
            // Set the player's position to the previous scene's position if available,
            // otherwise use the default position
            if (previousSceneIndex >= 0 && previousSceneIndex < previousScenePositions.Count)
            {
                transform.position = previousScenePositions[previousSceneIndex];
                
            }
            else if (defaultPositionIndex >= 0 && defaultPositionIndex < previousScenePositions.Count)
            {
                transform.position = previousScenePositions[defaultPositionIndex];
            }
            else
            {
                Debug.LogError("No valid positions defined for player!");
            }
    }


    // public Vector3[] previousScenePositions = new Vector3[8];
    // //public List<Vector3> previousScenePositions = new List<Vector3>();
    // public int defaultPositionIndex = 0;

    // void Start()
    // {
    //     previousScenePositions[7] = new Vector3(2.5f,-2.70000005f,0.150000006f);
    //     // Get the index of the previous scene
    //     int previousSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
    //     print("previousSceneIndex: " + previousSceneIndex);
        
    //     // Set the player's position to the previous scene's position if available,
    //     // otherwise use the default position
    //     if (previousSceneIndex >= 0 && previousSceneIndex < previousScenePositions.Length)
    //     {
    //         transform.position = previousScenePositions[previousSceneIndex];
            
    //     }
    //     else if (defaultPositionIndex >= 0 && defaultPositionIndex < previousScenePositions.Length)
    //     {
    //         transform.position = previousScenePositions[defaultPositionIndex];
    //     }
    //     else
    //     {
    //         Debug.LogError("No valid positions defined for player!");
    //     }
    // }

    void Update() {
        if(Input.GetKeyDown(KeyCode.E) && triggerOn) {
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
