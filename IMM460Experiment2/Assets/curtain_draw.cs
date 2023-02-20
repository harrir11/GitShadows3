using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curtain_draw : MonoBehaviour
{
    //public GameObject curtain;
    // Start is called before the first frame update
    void Start()
    {
        //curtain = GameObject.Find("curtain");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("j")) {
            Destroy(gameObject);
        }
    }
}
