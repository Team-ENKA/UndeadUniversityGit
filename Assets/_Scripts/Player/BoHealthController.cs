using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class BoHealthController : MonoBehaviour
{
    public int maxHealth = 30;
    public int currentHealth;
    public BoHealthBar healthBar;

    public GameObject LunchLass;
    public float playerInvincibility;

    public float deathEffectParticles;
    public GameObject deathParticle;
    public int AmountToHeal;

    public HealBoxAmount HealBoxAmount;

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && playerInvincibility <= 0)
        {
            //healthBar.LowerHealth();
            playerInvincibility = 1;
            TakeDamage(5);
        }
    }
    
    /*void OnCollisionStay2D(Collider2D collision)
    {
        if (gameObject.collision.tag == "Enemy")
        {
            TakeDamage(5);
        }
    }*/

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        playerInvincibility = playerInvincibility - Time.deltaTime;
        healthBar.SetHealth(currentHealth);
        if (Input.GetKeyDown(KeyCode.H) && HealBoxAmount.healBoxes > 0)
        {
            currentHealth = 30;
            HealBoxAmount.healBoxes--;
        }
    }
    public void Heal(int HealAmount)
    {
        AmountToHeal = HealAmount;
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        
        if (currentHealth == 0)
        {
            for (int i = 0; i < deathEffectParticles; i++)
                Instantiate(deathParticle, transform.position, Quaternion.identity);
            Destroy(LunchLass);
        }
    }
}
