using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScriptLinearIndicator : MonoBehaviour
{
    //This script is an example on how to use the linear indicator asset

    public LinearIndicator linearIndicator;
    public LinearIndicator linearIndicator2, linearIndicator3, linearIndicator4, linearIndicator5, linearIndicator6;

    public float minValue, maxValue;
    public float currentValue;

    void Start()
    {
        //Setup the linear indicator by code or do it in inspector
        linearIndicator.SetupIndicator(minValue,maxValue);
        linearIndicator2.SetupIndicator(minValue, maxValue);
        linearIndicator3.SetupIndicator(minValue, maxValue);
        linearIndicator4.SetupIndicator(minValue, maxValue);
        linearIndicator5.SetupIndicator(minValue, maxValue);
        linearIndicator6.SetupIndicator(minValue, maxValue);


        //linearIndicator.SetOrientation(LinearIndicator.Orientation.Horizontal);
        //linearIndicator.reverse = false;
        linearIndicator.SetValue(currentValue);
        linearIndicator2.SetValue(currentValue);
        linearIndicator3.SetValue(currentValue);
        linearIndicator4.SetValue(currentValue);
        linearIndicator5.SetValue(currentValue);
        linearIndicator6.SetValue(currentValue);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            currentValue += 50*Time.deltaTime;
            currentValue = Mathf.Clamp(currentValue, minValue, maxValue);


            linearIndicator.SetValue(currentValue);//Use the function SetValue to give the indicator the value to display
            linearIndicator2.SetValue(currentValue);
            linearIndicator3.SetValue(currentValue);
            linearIndicator4.SetValue(currentValue);
            linearIndicator5.SetValue(currentValue);
            linearIndicator6.SetValue(currentValue);


        }
        if (Input.GetKey(KeyCode.A))
        {
            currentValue -= 50 * Time.deltaTime;
            currentValue = Mathf.Clamp(currentValue, minValue, maxValue);


            linearIndicator.SetValue(currentValue);
            linearIndicator2.SetValue(currentValue);
            linearIndicator3.SetValue(currentValue);
            linearIndicator4.SetValue(currentValue);
            linearIndicator5.SetValue(currentValue);
            linearIndicator6.SetValue(currentValue);

        }
    }
}
