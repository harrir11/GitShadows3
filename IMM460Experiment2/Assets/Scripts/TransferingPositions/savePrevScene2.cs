using UnityEngine.SceneManagement;
using UnityEngine;

public class savePrevScene2: MonoBehaviour
{
    private void OnDestroy()
    {
        // Save the build index of the current scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("LastSceneIndex", currentSceneIndex);
    }
}
