//Script serving Gravity changing effects
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class changeGravityModifier : MonoBehaviour
{
    public bool isTriggered;
    public PlayerPlatformerScript player;
    checkGravityCollision parent;
    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent.GetComponent<checkGravityCollision>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Trigger Functions
    void OnTriggerEnter2D (Collider2D bc)
     {
        if (bc.gameObject.tag == "Player") 
         {
             Debug.Log("Player has hit collision trigger, sending trigger info");
            parent.isActivated = !parent.isActivated;
         }
     }

    void OnTriggerExit2D(Collider2D bc)
    {
        // if (bc.gameObject.tag == "Player")
        // {
        //     isTriggered = false;
        // } 
        // if(isTriggered)
        // {
        //     parent.isActivated = true;
        // }
        // if(!isTriggered)
        // {
        //     parent.isActivated = false;
        // }
    }

}
