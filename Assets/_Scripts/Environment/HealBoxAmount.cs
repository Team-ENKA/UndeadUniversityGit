using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealBoxAmount : MonoBehaviour
{
    public int healBoxes = 0;
    public Text Text;
    public HealPickup heal;

    void Start()
    {

        //Gets the text component
        Text = GetComponent<Text>();

    }

    void Update()
    {

        //Display amount of healboxes
        Text.text = ("Heals: " + healBoxes);

    }

    //Adds a healbox when walking over heal and health=30
    public void AddHealBox()
    {

        healBoxes += 1;

    }

    //When the player has a healbox, less than 30 health and presses H or G; restore health
    public void healButton()
    {

        if (healBoxes != 0 && health.currentHealth < 30 && Input.GetKeyDown(KeyCode.H) || Input.GetKeyDown(KeyCode.J))
        {

            heal.Heal();
            healBoxes -= 1;

        }

    }

}
