//MATTHEW STOKES
//RESOURCES USED: 
// https://youtu.be/0jTPKz3ga4w
// https://youtu.be/ELhg7ge2rIA

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
    [SerializeField] private Camera mainCamera; //place main camera
    
    //Below are mouse texture variables
    [SerializeField] private Texture2D mouseIdle;
    [SerializeField] private Texture2D mouseCollectible;
    [SerializeField] private Texture2D mousePortal;
    [SerializeField] private Texture2D mouseInteractable;
    private Vector2 cursorHotspot;


    void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);//carries gameobject on scene change
        //Cursor.lockState = CursorLockMode.Locked;
    }
    // Start is called before the first frame update
    void Start()
    {
        cursorPos = GetComponent<Transform>(); //gets transform
        mouseDisplay = GetComponent<SpriteRenderer>(); //gets sprite renderer component

        //Set Mouse Texture
        cursorHotspot = new Vector2(mouseIdle.width/2, mouseIdle.height/2);
        Cursor.SetCursor(mouseIdle, cursorHotspot, CursorMode.Auto);
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
        //If mouse is over a door, should turn into a Door Icon
        if(tag.CompareTag("portal")){
            //mouseDisplay.color = Color.green;
            cursorHotspot = new Vector2(mousePortal.width/2, mousePortal.height/2);
            Cursor.SetCursor(mousePortal, cursorHotspot, CursorMode.Auto);
        }
        //If mouse is over an interactable, should turn into a Magnifying Glass Icon
        if (tag.CompareTag("interactable")){
            //mouseDisplay.color = Color.blue;
            cursorHotspot = new Vector2(mouseInteractable.width/2, mouseInteractable.height/2);
            Cursor.SetCursor(mouseInteractable, cursorHotspot, CursorMode.Auto);
        }
        //If mouse is over a collectible, should turn a chest icon
        if (tag.CompareTag("collectible")){
            //mouseDisplay.color = Color.red; 
            cursorHotspot = new Vector2(mouseCollectible.width/2, mouseCollectible.height/2);
            Cursor.SetCursor(mouseCollectible, cursorHotspot, CursorMode.Auto);
        }
    }

    //just in case frame skips while hovering over object
    void OnTriggerStay2D(Collider2D col){
        Collider2D tag = col.GetComponent<Collider2D>();
        //If mouse is over a door, should turn into a Door Icon
        if(tag.CompareTag("portal")){
            //mouseDisplay.color = Color.green;
            cursorHotspot = new Vector2(mousePortal.width/2, mousePortal.height/2);
            Cursor.SetCursor(mousePortal, cursorHotspot, CursorMode.Auto);
        }
        //If mouse is over an interactable, should turn into a Magnifying Glass Icon
        if (tag.CompareTag("interactable")){
            //mouseDisplay.color = Color.blue;
            cursorHotspot = new Vector2(mouseInteractable.width/2, mouseInteractable.height/2);
            Cursor.SetCursor(mouseInteractable, cursorHotspot, CursorMode.Auto);
        }
        //If mouse is over a collectible, should turn a chest icon
        if (tag.CompareTag("collectible")){
            //mouseDisplay.color = Color.red; 
            cursorHotspot = new Vector2(mouseCollectible.width/2, mouseCollectible.height/2);
            Cursor.SetCursor(mouseCollectible, cursorHotspot, CursorMode.Auto);
        }
    }

    void OnTriggerExit2D(Collider2D col){
        //if mouse exits collider, should turn back to normal icon
        //mouseDisplay.color = Color.white; 
        cursorHotspot = new Vector2(mouseIdle.width/2, mouseIdle.height/2);
        Cursor.SetCursor(mouseIdle, cursorHotspot, CursorMode.Auto);
    }
}