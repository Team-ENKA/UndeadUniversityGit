using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDetection : MonoBehaviour
{

    public GameObject Door;
    public OpenLockedDoor openLockedDoor;

    // Update is called once per frame
    void Update()
    {
        
        

    }

    private void OnTriggerStay2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Door")
        {

            Debug.Log("ye1");
            Door = collision.gameObject;
            openLockedDoor = Door.GetComponent<OpenLockedDoor>();

        }

    }

    public void ActivateDoor()
    {

        openLockedDoor.OpenLDoor();

    }

}
