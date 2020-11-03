using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBool : MonoBehaviour
{
    public bool isActive = true;

    
    void OnTriggerStay2D(Collider2D collision)
    {

        if (Input.GetKey("e") && collision.gameObject.tag == "Player")
        {

            Destroy(gameObject);
            isActive = false;
            Debug.Log("Tank picked up");

        }

    }
}
