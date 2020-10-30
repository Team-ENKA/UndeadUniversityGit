using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class OnHitMelee : MonoBehaviour
{

    public ZombieDamageController die;
    public GameObject deathParticle;
    public int deathEffectParticles;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        for (int i = 0; i < deathEffectParticles; i++)
            Instantiate(deathParticle, transform.position, Quaternion.identity);
        die = collision.GetComponentInChildren<ZombieDamageController>();
        die.GotShot();
    }

}
