using UnityEngine;

public class playerSpawnPointManager : MonoBehaviour
{
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("player");
        if (player != null)
        {
            player.transform.position = transform.position;
        }
    }
}

