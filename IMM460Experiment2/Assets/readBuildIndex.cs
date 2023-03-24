using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class readBuildIndex : MonoBehaviour
{
    public int currentSceneIndex;
    public List<int> previousScenePositions = new List<int>();
    int scenesLength = 0;
    // Start is called before the first frame update
    void Start()
    {
        // Get the build index of the current scene
        
        // int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // PlayerPrefs.SetInt("LastSceneIndex", currentSceneIndex);

        // Debug.Log("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        // Debug.Log("Current scene index: " + currentSceneIndex);
        

        // previousScenePositions.Add(currentSceneIndex);
        // scenesLength++;
        // Debug.Log("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        // Debug.Log("Current scene index: " + currentSceneIndex);
        // Debug.Log("previous scene positions length: " + scenesLength);
        // Debug.Log("scene position: " + previousScenePositions[scenesLength]);
        // Debug.Log("scene position - 1: " + previousScenePositions[scenesLength - 1]);
        // Debug.Log("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
