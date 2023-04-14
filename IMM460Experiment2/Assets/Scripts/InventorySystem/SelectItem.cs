/* 
    Name: Connie Huang
    Last modified: 2023-04-14
    Tutorials followed: 
    - https://youtu.be/DLAIYSMYy2g
    - https://youtu.be/Ky-bzQFxV2U?t=272
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectItem : MonoBehaviour
{
    private int number;

    private void Start() {
        number = 0;
    }

    public void ButtonClicked()
    {
        number++;
        Debug.Log($"Button clicked: {number}");
    }
}
