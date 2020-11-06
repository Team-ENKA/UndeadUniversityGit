using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NERFAddAmmo : MonoBehaviour
{
    public NERFcounter NERFCounter;
    public GameObject Canvas;

    private void Start()
    {

        Canvas = GameObject.FindGameObjectWithTag("Canvas");
        NERFCounter = Canvas.GetComponentInChildren<NERFcounter>();

    }

    void OnTriggerStay2D(Collider2D collision)
    {

        if (Input.GetKey("e") && collision.gameObject.tag == "Player")
        {

            Destroy(gameObject);
            NERFCounter.NERFAddMag();

        }

    }
}
