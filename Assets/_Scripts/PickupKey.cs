using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupKey : MonoBehaviour
{

    public KeyAmount Keys;
    public GameObject Canvas;

    private void Start()
    {

        Canvas = GameObject.FindGameObjectWithTag("Canvas");
        Keys = Canvas.GetComponentInChildren<KeyAmount>();

    }

    //Activates the AddKey method in the KeyAmount script and destroys the key whenever the player is touching the keys trigger and is pressing e
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            Keys.AddKey();
            Destroy(gameObject);

        }

    }
}
