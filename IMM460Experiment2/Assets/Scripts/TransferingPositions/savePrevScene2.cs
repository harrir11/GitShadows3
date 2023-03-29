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
        Debug.Log ("-----------SAVEPREVSCENE2----------------");
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("currentSceneIndex (from savePrevScene):" + currentSceneIndex);

        staticLastSceneIndex = currentSceneIndex; 
        Debug.Log("staticLastSceneIndex (from savePrevScene):" + staticLastSceneIndex);
        
        PlayerPrefs.SetInt("LastSceneIndex", currentSceneIndex);
        Debug.Log("PlayerPrefs.SetInt(LastSceneIndex):" + currentSceneIndex);
        Debug.Log ("----------------------------------------");
    }
}
