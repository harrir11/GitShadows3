using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private GameObject dinosaurButton;


public bool dinoSelected = false;

void Awake()
{
    DontDestroyOnLoad(transform.gameObject);
}

public void objSelected(){
    //if (Selection.activeGameObject != null) {
        dinoSelected = true;
        Debug.Log("dino selected");
    //} else {
        //dinoSelected = false;
        //Debug.Log("dino not selected");
    //}

}

public void targetSelected(){
    if(dinoSelected) {
        Debug.Log("MATCH!");
        //dinosaurButton = GameObject.Find("DinosaurButton");
        
        //Destroy(dinosaurButton);
    }
}

}
