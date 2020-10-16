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
    public GameObject Damagebar;

    public GameObject Zombie_AI;
    public GameObject Infectionbar;
    public float playerInvincibility;

    public float deathEffectParticles;
    public GameObject deathParticle;

    public CuredZombie CuredZ;
    public Sprite Zombie_sprite;
    private SpriteRenderer Sprite;

    public void GotShot()
    {
        //TakeDamage(2);
        currentHealth += 2;
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
        playerInvincibility = playerInvincibility - Time.deltaTime;
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        ZombieDamageBar.SetHealth(currentHealth);

        if (currentHealth == 0)
        {
            Destroy(Infectionbar);
            ZeroInfection();

            /*if (currentHealth == 0)
            {
                for (int i = 0; i < deathEffectParticles; i++)
                    Instantiate(deathParticle, transform.position, Quaternion.identity);
                Destroy(Zombie);
            }*/
        }

    void ZeroInfection()
    {
        if (currentHealth == maxHealth)
        {
            Destroy(Zombie_sprite);
            Zombie_AI.GetComponentInChildren<CuredZombie>().CuredZ();
                Zombie_AI.GetComponentInChildren<CuredHuman>().CuredH();
        }
    }
        

}
}
