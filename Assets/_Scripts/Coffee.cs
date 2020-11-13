using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffee : MonoBehaviour
{
    public Movement Movement;
    public GameObject LunchLass;

    private void Start()
    {

        LunchLass = GameObject.FindGameObjectWithTag("Player");
        Movement = LunchLass.GetComponent<Movement>();

    }

    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            Movement.CoffeeBoost();
            Destroy(gameObject);

        }

    }

}
