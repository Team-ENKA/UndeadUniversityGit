using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTipToggle : MonoBehaviour
{

    public GameObject itemWithText;
    public float textVisible = 0f;

    // Update is called once per frame
    void Update()
    {

        textVisible = textVisible - Time.deltaTime;

        if(textVisible >=0f)
            itemWithText.GetComponent<MeshRenderer>().enabled = true;
        else
            itemWithText.GetComponent<MeshRenderer>().enabled = false;

    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if(collision.tag == "Player")
        {

            textVisible = 1f;

        }

    }

}
