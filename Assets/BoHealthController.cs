using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoHealthController : MonoBehaviour
{
    public int maxHealth = 30;
    public int currentHealth;
    public BoHealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            TakeDamage(5);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
