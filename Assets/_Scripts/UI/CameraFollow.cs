using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform PT;

    // Update is called once per frame
    void Update()
    {

        //Uses the players (PT) transform position to move the camera
        transform.position = new Vector3(PT.position.x, PT.position.y, -10f);
        

    }
}
