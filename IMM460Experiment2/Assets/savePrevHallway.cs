using UnityEngine.SceneManagement;
using UnityEngine;

public class savePrevHallway: MonoBehaviour
{
    public static int currentSceneIndex;
    public static int staticLastSceneIndex;
    
    void OnDestroy()
    {
        //room_counter++;
        //Debug.Log(room_counter);
        // Save the build index of the current scene
        Debug.Log ("-----------savePrevHallway----------------");
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //Debug.Log("currentSceneIndex (from savePrevScene):" + currentSceneIndex);
        staticLastSceneIndex = currentSceneIndex; 
        Debug.Log("staticLastSceneIndex (from savePrevScene):" + staticLastSceneIndex);
        PlayerPrefs.SetInt("LastSceneIndex", currentSceneIndex);
        Debug.Log ("----------------------------------------");
    }
}

