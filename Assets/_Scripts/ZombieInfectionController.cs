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

    public GameObject Zombie;
    public GameObject Infectionbar;
    public float playerInvincibility;

    public float deathEffectParticles;
    public GameObject deathParticle;

    public CuredZombie CuredZ;
    public Sprite Zombie_sprite;
    private SpriteRenderer sprite;

    public void GotShot()
    {
        TakeDamage(2);
    }


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        ZombieDamageBar.SetMaxHealth(maxHealth);

        sprite = gameObject.GetComponent<SpriteRenderer>();
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

        /*if (currentHealth == 0)
        {
            for (int i = 0; i < deathEffectParticles; i++)
                Instantiate(deathParticle, transform.position, Quaternion.identity);
            Destroy(Zombie);
        }*/

        if (currentHealth == 0)
        {
            Destroy(Infectionbar);
        }

        /*if (currentHealth == maxHealth)
        {
            Destroy(Zombie_sprite);
        }*/

        /*void CuredZ()
        {
            sprite.enabled = false;
        }*/

        if (currentHealth == maxHealth)
        {
            Destroy(Zombie_sprite);
            Zombie.GetComponentInChildren<CuredZombie>().CuredZ();
            Zombie.GetComponentInChildren<CuredHuman>().CuredH();
        }
    }
}
