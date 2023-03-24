using UnityEngine.SceneManagement;
using UnityEngine;

public class savingPrevScene: MonoBehaviour
{
    private void OnDestroy()
    {
        // Save the build index of the current scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("LastSceneIndex", currentSceneIndex);
    }
}

