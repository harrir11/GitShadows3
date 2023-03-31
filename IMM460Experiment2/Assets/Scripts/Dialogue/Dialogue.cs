//RESOURCES USED
// https://youtu.be/8oTYabhj248 

//MATTHEW STOKES

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public int repeatableIndex; //choose which of the last lines in the dialouge you wish to repeat.  If the value is 2, last two lines will be repeated
    
    private bool buttonPressed = false; // to control decisions based on whether the dialogue button has been clicked or not
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if(buttonPressed == true)
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }

        buttonPressed = false; // in order to reset variable after button press
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            //gameObject.SetActive(false); 
            //if at end of dialogue chain, delete text and reset text loop
            textComponent.text = string.Empty;

            //sets index equal to the beginning of the repeatable lines
            index = (lines.Length- repeatableIndex);
            StartCoroutine(TypeLine());
        }
    }

    public void ButtonPressed() // RESPONDS TO BUTTON PRESS
    {
        buttonPressed = true;
        Debug.Log("It work :)");
    }
}
