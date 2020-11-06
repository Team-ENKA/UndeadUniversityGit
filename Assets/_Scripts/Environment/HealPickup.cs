using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPickup : MonoBehaviour
{
    public BoHealthController health;
    public BoHealthBar healthBar;
    public HealBoxAmount healBoxAmount;
    public int healAmount;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && health.currentHealth < 30)
        {
            healBoxAmount.Heal();
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player" && health.currentHealth == 30)
        {
            healBoxAmount.AddHealBox();
            Destroy(gameObject);
        }
    }

}
