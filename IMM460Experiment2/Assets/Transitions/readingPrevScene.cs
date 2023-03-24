using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class readingPrevScene : MonoBehaviour
{
    public GameObject player;
    public GameObject brick;
    public Transform spawnPoint;

    private void Start()
    {
        player = GameObject.FindWithTag("player");
        brick = GameObject.FindWithTag("brick");
        
        if (player != null) {
        int lastSceneIndex = PlayerPrefs.GetInt("LastSceneIndex", 0);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        Debug.Log("lastSceneIndex" + lastSceneIndex);
        Debug.Log("currentSceneIndex" + currentSceneIndex);
        //Debug.Log("HALLWAY TO BEDROOM");

            if(lastSceneIndex == 1 && currentSceneIndex == 8) {
                Debug.Log("HALLWAY TO BEDROOM");
                //player.transform.position = new Vector3(2.4f,-2.70000005f,0.150000006f);
                player.transform.position = spawnPoint.position;
                //brick.transform.position = new Vector3(2.4f,-2.70000005f,0.150000006f);
            }
        } else {
            Debug.Log("player is null?");
        }  

    }


}

