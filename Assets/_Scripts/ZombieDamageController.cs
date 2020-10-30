using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Pathfinding;

public class ZombieDamageController : MonoBehaviour
{
    public int maxHealth = 30;
    public int currentHealth;
    public ZombieDamageBar ZombieDamageBar;

    public GameObject Zombie_AI;
    public Transform Zombie_transform;
    public float playerInvincibility;

    public float deathEffectParticles;
    public GameObject deathParticle;
    public GameObject cured_sprite;

    public void GotShot()
    {
        TakeDamage(2);
        Debug.Log("Anything");
    }

     void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && playerInvincibility <= 0)
        {
            //healthBar.LowerHealth();
            playerInvincibility = 1;
            TakeDamage(2);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        ZombieDamageBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        playerInvincibility = playerInvincibility - Time.deltaTime;
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        ZombieDamageBar.SetHealth(currentHealth);

        if (currentHealth == 0)
        {
            for (int i = 0; i < deathEffectParticles; i++)
                Instantiate(deathParticle, transform.position, Quaternion.identity);
            Destroy(Zombie_AI);
            Instantiate(cured_sprite, Zombie_transform);
            //GetComponent<Student_Cured_Image_midground>().Cured;

        }
    }
}
