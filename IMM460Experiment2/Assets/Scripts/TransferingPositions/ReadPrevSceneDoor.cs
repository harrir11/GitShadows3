//Rebecca Harris
//April 2nd, 2023
//Script is attached to: placementScript object in every scene

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadPrevSceneDoor : MonoBehaviour
{
    public GameObject player;
    public Transform spawnPoint;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;
    public Transform spawnPoint5;
    public Transform spawnPoint6;
    public Transform spawnPoint7;
    public Transform spawnPoint8;
    public Transform spawnPoint9;
    public Transform spawnPoint10;
    public Transform spawnPoint11;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        Debug.Log("ReadPrevSceneDoor");
        int lastSceneIndexDoor = PlayerPrefs.GetInt("LastSceneIndexDoor", 0);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        Debug.Log("lastSceneIndexDoor (from playerPrefs): " + lastSceneIndexDoor);
        Debug.Log("currentSceneIndex: " + currentSceneIndex);

        if(lastSceneIndexDoor == 1 && currentSceneIndex == 10) {
                Debug.Log("HALLWAY TO BEDROOM");
                //player.transform.position = new Vector3(2.4f,-2.70000005f,0.150000006f);
                player.transform.position = spawnPoint.position;
                //brick.transform.position = new Vector3(2.4f,-2.70000005f,0.150000006f);
        } else if(lastSceneIndexDoor == 4 && currentSceneIndex == 10) {
                Debug.Log("BASEMENT TO BEDROOM");

                Debug.Log("spawnPoint2 position " + spawnPoint2.position);
                Debug.Log("player.transform.position " + player.transform.position);

                player.transform.position = spawnPoint2.position;
        } else if(lastSceneIndexDoor == 2 || lastSceneIndexDoor == 8 || lastSceneIndexDoor == 9 && currentSceneIndex == 1) {
                Debug.Log("BEDROOM TO HALLWAY");

                Debug.Log("spawnPoint3 position " + spawnPoint3.position);
                Debug.Log("player.transform.position " + player.transform.position);

                player.transform.position = spawnPoint3.position;
        } else if(lastSceneIndexDoor == 5 && currentSceneIndex == 1) {
                Debug.Log("BATHROOM TO HALLWAY");

                Debug.Log("spawnPoint4 position " + spawnPoint4.position);
                Debug.Log("player.transform.position " + player.transform.position);

                player.transform.position = spawnPoint4.position;
        } else if(lastSceneIndexDoor == 3 && currentSceneIndex == 1) {
                Debug.Log("KITCHEN TO HALLWAY");

                Debug.Log("spawnPoint5 position " + spawnPoint5.position);
                Debug.Log("player.transform.position " + player.transform.position);

                player.transform.position = spawnPoint5.position;
        } else if(lastSceneIndexDoor == 3 && currentSceneIndex == 4) {
                Debug.Log("KITCHEN TO BASEMENT");

                Debug.Log("spawnPoint6 position " + spawnPoint6.position);
                Debug.Log("player.transform.position " + player.transform.position);

                player.transform.position = spawnPoint6.position;
        } else if(lastSceneIndexDoor == 8 && currentSceneIndex == 4) {
                Debug.Log("BEDROOM TO BASEMENT");

                Debug.Log("spawnPoint7 position " + spawnPoint7.position);
                Debug.Log("player.transform.position " + player.transform.position);

                player.transform.position = spawnPoint7.position;
        }  else if(lastSceneIndexDoor == 1 && currentSceneIndex == 3) {
                Debug.Log("HALLWAY TO KITCHEN");

                Debug.Log("spawnPoint8 position " + spawnPoint8.position);
                Debug.Log("player.transform.position " + player.transform.position);

                player.transform.position = spawnPoint8.position;
        }  else if(lastSceneIndexDoor == 4 && currentSceneIndex == 3) {
                Debug.Log("BASEMENT TO KITCHEN");

                Debug.Log("spawnPoint9 position " + spawnPoint9.position);
                Debug.Log("player.transform.position " + player.transform.position);

                player.transform.position = spawnPoint9.position;
        } else if(currentSceneIndex == 5) {
                Debug.Log("BASEMENT TO KITCHEN");

                Debug.Log("spawnPoint10 position " + spawnPoint10.position);
                Debug.Log("player.transform.position " + player.transform.position);

                player.transform.position = spawnPoint10.position;
        } else if(currentSceneIndex == 2) {
                Debug.Log("BASEMENT TO KITCHEN");

                Debug.Log("spawnPoint11 position " + spawnPoint11.position);
                Debug.Log("player.transform.position " + player.transform.position);

                player.transform.position = spawnPoint11.position;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
