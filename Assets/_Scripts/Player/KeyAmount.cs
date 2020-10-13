using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyAmount : MonoBehaviour
{

    public int Keys = 0;
    public Text Text;
    public DoorDetection hasKey;

    // Start is called before the first frame update
    void Start()
    {

        //Gets the text component
        Text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

        //Makes the text component display the amount of keys the player has
        Text.text = ("Keys: " + Keys);

    }

    //Adds a key whenever the AddKey method is invoked
    public void AddKey()
    {

        Keys += 1;

    }

    //This method is used when the player interacts with a locked door. If the player has a key, it will remove 1 key, and activate the method for the doors script
    public void LockedDoorCheck()
    {

        if (Keys >= 1)
        {

            hasKey.ActivateDoor();
            Keys--;

        }

    }

}
