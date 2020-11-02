using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipscript : MonoBehaviour
{
    // Start is called before the first frame update
    checkGravityCollision child1;
    CheckGravityLeftAndRight child2;

    public PlayerPlatformerScript player;
    bool onlyOnce = true;
    
    bool onlyOnce2 = true;

    bool leftAndrightMode = false;
    bool upAndDownMode = false;
    float timer = 0;
    void Start()
    {
        child1 = GetComponentInChildren<checkGravityCollision>();
        child2 = GetComponentInChildren<CheckGravityLeftAndRight>();
    }

    // Update is called once per frame
    void Update()
    {
        

        //Updates the time
        if(timer > 0 && (child1.isActivated || child2.isActivated))
        {
            timer -= Time.deltaTime;
        }
        else{

            if(child1.isActivated && onlyOnce)
            {

                transform.Rotate(0,180,180,Space.World);
                player.transform.Rotate(0,180,180,Space.World);
                onlyOnce = false;
                Debug.Log("Entering Gravity Zone");


            }
            if(!child1.isActivated && !onlyOnce)
            {

                Debug.Log("Exiting Gravity Zone");
                transform.Rotate(0,180,180,Space.World);
                player.transform.Rotate(0,180,180,Space.World);
                onlyOnce = true;
            

            }

            if(child2.isActivated && onlyOnce2)
            {


                transform.Rotate(0,180,90,Space.World);
                player.transform.Rotate(0,180,90,Space.World);

                onlyOnce2 = false;
                Debug.Log("Entering Gravity Zone");

            }
            if(!child2.isActivated && !onlyOnce2)
            {

                Debug.Log("Exiting Gravity Zone");
                transform.Rotate(0,180,90,Space.World);
                onlyOnce2 = true;
                player.transform.Rotate(0,180,90,Space.World);
                
            }
        }

        // player.transform.position = new Vector3(player.transform.position.x,player.transform.position.y,13049);



        
    }
}
