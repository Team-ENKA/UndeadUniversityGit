using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ZombieInfectionController : MonoBehaviour
{
    public int maxHealth = 30;
    public int currentHealth;
    public ZombieDamageBar ZombieDamageBar;
    //public GameObject Damagebar;

    public GameObject Zombie_AI;
    public GameObject Infectionbar;
    public float playerInvincibility;

    public float deathEffectParticles;
    public GameObject deathParticle;

    public CuredZombie CuredZ;
    public GameObject Zombie_sprite;
    private SpriteRenderer Sprite;

    public SwitchTargetDestination switchTargetDestination;

    public void GotShot()
    {
        TakeDamage(4);
        //currentHealth += 2;
        Debug.Log("Anything.");
    }


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        ZombieDamageBar.SetMaxHealth(maxHealth);

        Sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInvincibility > 0)
        {
            playerInvincibility = playerInvincibility - Time.deltaTime;

        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        ZombieDamageBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Destroy(Infectionbar);
            ZeroInfection();

            for (int i = 0; i < deathEffectParticles; i++)
                Instantiate(deathParticle, transform.position, Quaternion.identity);

            //       Destroy(Zombie_sprite);

        }
    }
    void ZeroInfection()
    {
        
       Zombie_AI.GetComponentInChildren<CuredHuman>().CuredH();
        switchTargetDestination.SwitchTarget();
            //Destroy(Zombie_sprite);
        Debug.Log("Infection Reached 0");

        
    }   
}