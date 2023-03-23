using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_pickup : MonoBehaviour
{
    private bool pickUpAllowed;
    public GameObject obj;

    // Update is called once per frame
    void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.C))
            PickUp(obj);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);

        pickUpAllowed = true;
        obj = col.gameObject;
        //return obj;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("exit");

        pickUpAllowed = false;
    }

    private void PickUp(GameObject obj){
        Destroy(obj);
    }

}
