using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NERFAddAmmo : MonoBehaviour
{
    public NERFcounter NERFCounter;

    void OnTriggerStay2D(Collider2D collision)
    {

        if (Input.GetKey("e") && collision.gameObject.tag == "Player")
        {

            Destroy(gameObject);
            NERFCounter.NERFAddMag();

        }

    }
}
