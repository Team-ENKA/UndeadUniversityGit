using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealBoxAmount : MonoBehaviour
{
    public int healBoxes = 0;
    public Text Text;
    public HealPickup heal;
    public BoHealthController health;
    public BoHealthBar healthBar;

    void Start()
    {


        //Gets the text component
        Text = GetComponent<Text>();

    }

    public void Heal()
    {
        health.currentHealth += 30;
        healthBar.SetHealth(health.currentHealth);
    }

    void Update()
    {

        //Display amount of healboxes
        Text.text = ("Heals: " + healBoxes);


        //When the player has a healbox, less than 30 health and presses H or G; restore health
        if (healBoxes != 0 && health.currentHealth < 30 && Input.GetKeyDown(KeyCode.H) || Input.GetKeyDown(KeyCode.J))
        {

            Heal();
            healBoxes -= 1;

        }

    }

    //Adds a healbox when walking over healbox, and player has full health
    public void AddHealBox()
    {
        healBoxes += 1;
    }


}
