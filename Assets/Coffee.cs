using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffee : MonoBehaviour
{
    public Movement Movement;



    void OnTriggerStay2D(Collider2D collision)
    {

        if (Input.GetKey("e") && collision.gameObject.tag == "Player")
        {

            Destroy(gameObject);
            Movement.CoffeeBoost();

        }

    }

}
