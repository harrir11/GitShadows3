using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
void Awake()
{
    DontDestroyOnLoad(transform.gameObject);
}

}
