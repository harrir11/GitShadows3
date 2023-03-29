using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class readPrevScene2 : MonoBehaviour
{
    public GameObject player;
    //public GameObject brick;
    public Transform spawnPoint;
    public Transform spawnPoint2;
    public int room_counter;
   // public savePrevScene2 savePrevScene;

    private void Start()
    {
        player = GameObject.FindWithTag("player");
        //brick = GameObject.FindWithTag("brick");
        
        if (player != null) {
        int lastSceneIndex = PlayerPrefs.GetInt("LastSceneIndex", 0);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        Debug.Log ("-----------READPREVSCENE2----------------");

        Debug.Log("lastSceneIndex (from playerPrefs): " + lastSceneIndex);
        Debug.Log("currentSceneIndex: " + currentSceneIndex);

        Debug.Log("staticLastSceneIndex (from static var in savePrevScene2):" + savePrevScene2.staticLastSceneIndex);

        Debug.Log ("----------------------------------------");

        //Debug.Log("HALLWAY TO BEDROOM");

            if(lastSceneIndex == 1 && currentSceneIndex == 8) {
                Debug.Log("HALLWAY TO BEDROOM");
                //player.transform.position = new Vector3(2.4f,-2.70000005f,0.150000006f);
                player.transform.position = spawnPoint.position;
                //brick.transform.position = new Vector3(2.4f,-2.70000005f,0.150000006f);
            } else if(lastSceneIndex == 4 && currentSceneIndex == 8) {
                Debug.Log("BASEMENT TO BEDROOM");

                Debug.Log("spawnPoint2 position " + spawnPoint2.position);
                Debug.Log("player.transform.position " + player.transform.position);

                player.transform.position = spawnPoint2.position;
            }
        } else {
            Debug.Log("player is null?");
        }  

    }


}


