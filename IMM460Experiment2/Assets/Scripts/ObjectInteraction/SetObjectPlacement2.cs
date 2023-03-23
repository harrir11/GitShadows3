using UnityEngine;
using UnityEngine.SceneManagement;

public class SetObjectPlacement2 : MonoBehaviour {

    public string previousSceneName;
    public Vector3 position;
    public GameObject player;

    // Use this for initialization
    void Start () {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // This method is called when a new scene is loaded
    void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        if (scene.name == previousSceneName) {
            transform.position = position;
        }
    }
}

