using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityZoneParentController : MonoBehaviour
{
    public float gravityModifier = 0;
    public PlayerPlatformerScript player;
    public Component[] gravityZones;
    public bool activated;

    // Start is called before the first frame update
    void Start()
    {
        gravityZones = GetComponentsInChildren<GravityZoneParentClass>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GravityZoneParentClass zone in gravityZones)
        {
            if(zone.isTriggerParent == true)
            {
                activated = true;
            }

        }

        if(activated == true)
        {
        Debug.Log("The gravity modifier is " + gravityModifier);
        player.gravityModifier = gravityModifier;
        }
        else
        {
            player.gravityModifier = 1.0f;
        }


        activated = false;
    }
}
