using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Window : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D mainLight;
    public UnityEngine.Rendering.Universal.Light2D rayLight;
    private float targetIntensity = .40f;
    private bool curtainIsOpen = false;
    public Transform curtainTransform;
    private float curtainX;

    // Update is called once per frame
    private void Start()
    {
        curtainX = curtainTransform.position.x;
    }
    void Update()
    {
        if(Input.GetKeyDown("space")) {
            curtainIsOpen = true;
        }
        if(curtainIsOpen){
            changeRayIntensity();
        }
    }

    void changeRayIntensity(){
        //intensity goes from 0 - 1
        float currentIntensity = rayLight.intensity;
        if(currentIntensity < targetIntensity){
            rayLight.intensity += 0.001f;

            //this is what actually changes the curtain's x value
            curtainX += .00625f;
            //this vector 3 is creating a vector 3 with the adjusted curtain x, and 
            //were just filling y and z with the current values since those arent changing
            Vector3 newCurtainPosition = new Vector3(curtainX, curtainTransform.position.y, curtainTransform.position.y);
            curtainTransform.position = newCurtainPosition;
        }
        else{
            curtainIsOpen = false;
        }

    }
}
