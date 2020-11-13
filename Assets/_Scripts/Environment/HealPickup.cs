using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPickup : MonoBehaviour
{
    public BoHealthController health;
    public BoHealthBar healthBar;
    public HealBoxAmount healBoxAmount;
    public GameObject Canvas;
    public GameObject LunchLass;
    public int healAmount;

    private void Start()
    {

        Canvas = GameObject.FindGameObjectWithTag("Canvas");
        LunchLass = GameObject.FindGameObjectWithTag("Player");
        healBoxAmount = Canvas.GetComponentInChildren<HealBoxAmount>();
        health = LunchLass.GetComponentInChildren<BoHealthController>();
        healthBar = LunchLass.GetComponentInChildren<BoHealthBar>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            healBoxAmount.AddHealBox();
            Destroy(gameObject);
        }
    }

}
