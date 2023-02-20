using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Window : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D mainLight;
    public UnityEngine.Rendering.Universal.Light2D rayLight;
    private float targetIntensity = .20f;
    private bool curtainIsOpen = false;

    // Update is called once per frame
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
        }
        else{
            curtainIsOpen = false;
        }

    }
}
