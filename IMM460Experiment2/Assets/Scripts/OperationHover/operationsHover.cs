using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class operationsHover : MonoBehaviour
{
    /*
        Change mouse cursor depending on what it is hovering over
        FOR NOW IT WILL ONLY CHANGE COLOR
        RED: COLLECTIBLE ITEM
        GREEN: PORTAL, DOOR, TRAPDOOR
        BLUE: INTERACTABLE

        CIRCLE SHOULD MOVE WITH MOUSE POSITION

        CURSOR GOES OFF SCREEN
        NEED TO FIND SOME WAY TO KEEP IT LOCKED IN SCREEN
        ADJUST SENSITIVITY
        https://docs.unity3d.com/ScriptReference/Cursor-lockState.html
        LOOK INTO THIS MORE?
    */
    private Transform cursorPos;
    private SpriteRenderer mouseDisplay;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);//carries gameobject on scene change
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Start is called before the first frame update
    void Start()
    {
        cursorPos = GetComponent<Transform>(); //gets transform
        mouseDisplay = GetComponent<SpriteRenderer>(); //gets sprite renderer component
    }

    // Update is called once per frame
    void Update()
    {   
        Vector3 mousePos = Input.mousePosition;
        cursorPos.position = mousePos;
    }
}
