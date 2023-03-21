using UnityEngine;
using UnityEngine.SceneManagement;

public class placement : MonoBehaviour {

    public string previousSceneName;
    public Vector3 position;
    public GameObject player;

    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("player");
        SceneManager.sceneLoaded += OnSceneLoaded;
        
    }

    // This method is called when a new scene is loaded
    void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        if (scene.name == previousSceneName) {
            player.transform.position = position;
        }
    }
}




