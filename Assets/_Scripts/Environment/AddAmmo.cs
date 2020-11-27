using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddAmmo : MonoBehaviour
{

    public AmmoCounter ammoCounter;
    public GameObject Canvas;

    private void Start()
    {

        Canvas = GameObject.FindGameObjectWithTag("Canvas");
        ammoCounter = Canvas.GetComponentInChildren<AmmoCounter>();

    }

    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

                Destroy(gameObject);
                ammoCounter.AddMag();

            }

    }

}
