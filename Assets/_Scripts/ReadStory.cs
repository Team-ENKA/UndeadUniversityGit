using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReadStory : MonoBehaviour
{
    public MeshRenderer textToShow;

    void OnTriggerStay2D(Collider2D collision)
    {

        if (Input.GetKey("e") && collision.gameObject.tag == "Player")
        {
            textToShow.enabled = true;

        }

    }

}
