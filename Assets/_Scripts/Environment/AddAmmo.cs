using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAmmo : MonoBehaviour
{

    public AmmoCounter ammoCounter;

    void OnTriggerStay2D(Collider2D collision)
    {

        if (Input.GetKey("e") && collision.gameObject.tag == "Player")
        {

                Destroy(gameObject);
                ammoCounter.AddMag();

            }

    }

}
