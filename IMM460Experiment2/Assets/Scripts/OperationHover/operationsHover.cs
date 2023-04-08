//MATTHEW STOKES
//RESOURCES USED: 
// https://youtu.be/0jTPKz3ga4w

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

        MAIN CAMERA DOES NOT EXIST WHEN IT CHANGES SCENES
        TURN MOUSE CURSOR INTO PREFAB AND PLACE IT INTO EVERY SCENE
        AS TO ADJUST TO THE CAMERA OF EVERY SCENE
    */
    private Transform cursorPos;
    private SpriteRenderer mouseDisplay;
    [SerializeField] private Camera mainCamera;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);//carries gameobject on scene change
        //Cursor.lockState = CursorLockMode.Locked;
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
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        cursorPos.position = mouseWorldPosition;
        //Vector3 mousePos = Input.mousePosition;
        //cursorPos.position = mousePos;
    }

    void OnTriggerEnter2D(Collider2D col){
        Collider2D tag = col.GetComponent<Collider2D>();
        //If mouse is over a door, should turn green
        if(tag.CompareTag("portal")){
            mouseDisplay.color = Color.green;
        }
        //If mouse is over an interactable, should turn blue
        if (tag.CompareTag("interactable")){
            mouseDisplay.color = Color.blue;
        }
        //If mouse is over a collectible, should turn red
        if (tag.CompareTag("collectible")){
            mouseDisplay.color = Color.red; 
        }
    }

    void OnTriggerExit2D(Collider2D col){
        //if mouse exits collider, should turn back to normal color
        mouseDisplay.color = Color.white; 
    }
}