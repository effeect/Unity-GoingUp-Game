using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityZoneScript : MonoBehaviour
{
    public bool isTriggered;
    public PlayerPlatformerScript player;

    public GravityZoneParentClass parentClass;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {

        
    }

    //Trigger Functions
    void OnTriggerEnter2D (Collider2D bc)
     {
        if (bc.gameObject.tag == "Player") 
         {
            parentClass.isTriggerParent = true;
         }
     }

    void OnTriggerExit2D(Collider2D bc)
    {
        if (bc.gameObject.tag == "Player")
        {
            parentClass.isTriggerParent = false;
        } 
    }

}

