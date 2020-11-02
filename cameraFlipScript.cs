//Simple script that rotates the whole camera, not neccessary but nice to have
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFlipScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            GetComponent<Camera>().projectionMatrix = GetComponent<Camera>().projectionMatrix * Matrix4x4.Scale(new Vector3(1, -1, 1));
        }
    }
}
