using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLockedDoor : MonoBehaviour
{

    public float IsOpen = 0f;
    public float IsLocked = 1f;
    public float Cooldown = 0f;
    public Transform doorTransform;

    public KeyAmount KA;
    public GameObject Canvas;

    private void Update()
    {

        Cooldown = Cooldown - Time.deltaTime;
        Canvas = GameObject.FindGameObjectWithTag("Canvas");
        KA = Canvas.GetComponentInChildren<KeyAmount>();

    }

    //When the player touches the trigger and is pressing e at the same time, this activates a method in the KeyAmount script which checks for any keys
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (Input.GetKey("e") && collision.gameObject.tag == "Player")
        {

            if (Cooldown <= 0f)
            {

                if (IsLocked == 1f)
                {

                    KA.LockedDoorCheck();

                }
                
                if (IsLocked == 0f)
                {

                    if (IsOpen == 0f && Cooldown <= 0f)
                    {

                        float rotateDoorTo = doorTransform.rotation.eulerAngles.z - 90f;

                        transform.rotation = Quaternion.Euler(0, 0, rotateDoorTo);
                        IsOpen = 1f;
                        Cooldown = 0.2f;

                    }

                    if (IsOpen == 1f && Cooldown <= 0f)
                    {

                        float rotateDoorTo = doorTransform.rotation.eulerAngles.z + 90f;

                        transform.rotation = Quaternion.Euler(0, 0, rotateDoorTo);
                        IsOpen = 0f;
                        Cooldown = 0.2f;

                    }

                }

            }

        }

    }

    //When the keycheck is positive in the KeyAmount script, it will activate this method which destroys the door
    public void OpenLDoor()
    {
        
        float rotateDoorTo = doorTransform.rotation.eulerAngles.z - 90f;
        transform.rotation = Quaternion.Euler(0, 0, rotateDoorTo);
        IsOpen = 1f;
        IsLocked = 0f;
        Cooldown = 0.2f;

    }

}
