using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class followPlayer : MonoBehaviour
{
    public CinemachineVirtualCamera vcam;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("player");
    
    }

    // Update is called once per frame
    void Update()
    {
        vcam.m_Follow = player.transform;
    }
}
