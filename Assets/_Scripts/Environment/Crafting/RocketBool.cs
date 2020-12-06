using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBool : MonoBehaviour
{
    public bool isActive = true;


    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            Destroy(gameObject);
            isActive = false;
            Debug.Log("Rocket picked up");
        }

    }
}
