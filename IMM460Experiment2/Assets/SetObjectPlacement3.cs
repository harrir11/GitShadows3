using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SetObjectPlacement3 : MonoBehaviour
{
    public Vector3[] previousScenePositions;
    public int defaultPositionIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
                // Get the index of the previous scene
        int previousSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;

        // Set the player's position to the previous scene's position if available,
        // otherwise use the default position
        if (previousSceneIndex >= 0 && previousSceneIndex < previousScenePositions.Length)
        {
            transform.position = previousScenePositions[previousSceneIndex];
        }
        else if (defaultPositionIndex >= 0 && defaultPositionIndex < previousScenePositions.Length)
        {
            transform.position = previousScenePositions[defaultPositionIndex];
        }
        else
        {
            Debug.LogError("No valid positions defined for player!");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
