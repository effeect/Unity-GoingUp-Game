using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityZoneParentClass : MonoBehaviour
{
    public bool isTriggerParent;
    public float floatGravityModifier;
    public GravityZoneParentController parent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isTriggerParent)
        {
            Debug.Log("Changing Gravity");
            parent.gravityModifier = floatGravityModifier;
        }
        
    }
}
