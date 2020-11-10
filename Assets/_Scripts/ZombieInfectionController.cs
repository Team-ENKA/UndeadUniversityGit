using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ZombieInfectionController : MonoBehaviour
{
    public int maxHealth = 30;
    public int currentHealth;
    public float deathEffectParticles;

    public ZombieDamageBar ZombieDamageBar;
    public GameObject deathParticle;
    public GameObject Zombie_AI;
    public GameObject Infectionbar;
    public GameObject Zombie_sprite;
    public AIDestinationSetter switchTargetDestination;

    public void GotGrenaded()
    {

        TakeDamage(16);
        Debug.Log("Grenaded");

    }

    public void GotShot()
    {

        TakeDamage(4);
        Debug.Log("Shot");

    }

    void Start()
    {

        currentHealth = maxHealth;
        ZombieDamageBar.SetMaxHealth(maxHealth);

    }

    void TakeDamage(int damage)
    {

        currentHealth -= damage;
        ZombieDamageBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
            ZeroInfection();

    }

    void ZeroInfection()
    {
        
        Zombie_AI.GetComponentInChildren<CuredHuman>().CuredH();
        switchTargetDestination.ChangeTarget();
        for (int i = 0; i < deathEffectParticles; i++)
            Instantiate(deathParticle, transform.position, Quaternion.identity);
        Destroy(Zombie_sprite);
        
    }   
}