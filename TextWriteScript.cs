using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/* To-Do list of Text Script

    World Position

    Diffirent Lines
*/

public class TextWriteScript : MonoBehaviour
{   
    public int stringNumber;
    public int stringNumber2;
    public int stringNumber3;

    public TextMeshProUGUI text;
    public string lines;
    public string lines2;
    public string lines3;
    public string lines4;
    private string textBox;
    private int waitTime;
    //Change this to modify the time it takes for text to display.
    public float waitLimit;
    public bool isTriggered;

    private AudioSource beepboopSound;
    
    void Start() {
        textBox = "";
        text.text = "";
        stringNumber = 0;
        stringNumber2 = 0;
        stringNumber3 = 0;

        beepboopSound = GetComponent<AudioSource>();

    }

    //Trigger Function
    void OnTriggerEnter2D (Collider2D bc)
     {
        if (bc.gameObject.tag == "Player") 
         {
            beepboopSound.Play();
            Debug.Log("Player has hit collision trigger, sending trigger info");
            isTriggered = true;
        }
    }

    void OnTriggerExit2D(Collider2D bc)
    {
        if (bc.gameObject.tag == "Player")

        {
            isTriggered = false;
        } 
    }

    void FixedUpdate(){
        if(isTriggered)
        {
            if(stringNumber < lines.Length)
            {
            textBox = lines.Substring(0,stringNumber);

                if(waitTime < waitLimit)
                {
                    waitTime++;

                }
                else
                {
                    stringNumber +=1;
                    text.text = textBox;
                    waitTime = 0;
                }
            }

            if(stringNumber - 1 == lines.Length - 1)
            {
                Debug.Log("triggered");
                textBox = lines2.Substring(0,stringNumber2);

                if(stringNumber2 < lines2.Length)
                {
                if(waitTime < waitLimit)
                {
                waitTime++;
                }
                else
                {
                stringNumber2 +=1;
                text.text = textBox;
                waitTime = 0;
                }
                }
            }

            if(stringNumber2 - 1 == lines2.Length -1)
            {
                Debug.Log("triggered");
                textBox = lines3.Substring(0,stringNumber3);

                if(stringNumber3 < lines3.Length)
                {
                    if(waitTime < waitLimit)
                    {
                    waitTime++;
                    }
                    else
                    {
                    stringNumber3 +=1;
                    text.text = textBox;
                    waitTime = 0;
                    }

                }
            }
            

        }
        else
        {
                if(stringNumber > 0)
                {
                 textBox = lines.Substring(0,stringNumber);
                if(waitTime < waitLimit)
                {
                    waitTime++;
                }
                else
                {
                    stringNumber--;
                    text.text = textBox;
                    waitTime = 0;
                }


            }
        }

    }
}
