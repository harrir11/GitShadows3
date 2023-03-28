using UnityEngine.SceneManagement;
using UnityEngine;

public class savePrevScene2: MonoBehaviour
{
    public static int currentSceneIndex;
    public static int staticLastSceneIndex;
    
    void OnDestroy()
    {
        //room_counter++;
        //Debug.Log(room_counter);
        // Save the build index of the current scene
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("curr scene from save prev Scene:" + currentSceneIndex);
        staticLastSceneIndex = currentSceneIndex; 
        Debug.Log("last scene from save prev Scene:" + staticLastSceneIndex);
        //PlayerPrefs.SetInt("LastSceneIndex", currentSceneIndex);
    }
}
