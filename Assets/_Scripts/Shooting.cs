using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shooting : MonoBehaviour
{

    public Transform capsuleTransform;
    public Transform shootingDirection;
    public Vector2 shotOrigin;
    public EnemyHealthController enemyHealth;
    public ZombieInfectionController zombieInfection;
    public ZombieDamageController zombieDamage;
    public BossHealthController bossHealth;
    public AmmoCounter ammoCounterScript;
    public GameObject hitPointParticle;
    public GameObject antiBacGrenade;
    public Transform lunchLassSprite;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            ammoCounterScript.AmmoCheck();

        if (Input.GetKeyDown(KeyCode.Mouse1))
            Instantiate(antiBacGrenade, capsuleTransform.position, lunchLassSprite.rotation);
    }

    public void Shoot()
    {
        //Creates a new Vector2 using the the first components x and y transforms
        shotOrigin = new Vector2(capsuleTransform.position.x, capsuleTransform.position.y);
        RaycastHit2D hit = Physics2D.Linecast(shotOrigin, shootingDirection.position);
        Debug.DrawLine(shotOrigin, hit.point, Color.green, 20f);

        //If the collider hits anything, it will check if it's a target. The collider hit belongs 
        //to an object tagged as target, it will use the EnemyHealthController to lower the targets health
        if (hit.collider != null)
        {
            Vector3 hitPoint = new Vector3(hit.point.x, hit.point.y, 0f);

            float hitPointParticles = Random.Range(2, 6);
            for (int i = 0; i < hitPointParticles; i++)
            {
                Instantiate(hitPointParticle, hitPoint, Quaternion.identity);
            }

            if (hit.collider.tag == "Enemy")
            {

                /*enemyHealth = hit.collider.gameObject.GetComponentInChildren<EnemyHealthController>();
                enemyHealth.GotShot();*/

                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    zombieInfection = hit.collider.gameObject.GetComponentInChildren<ZombieInfectionController>();
                    zombieInfection.GotShot();
                }
           
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    zombieDamage = hit.collider.gameObject.GetComponentInChildren<ZombieDamageController>();
                    zombieDamage.GotShot();
                }   
            }
   
            if (hit.collider.tag == "Boss")
            {
                bossHealth = hit.collider.gameObject.GetComponentInChildren<BossHealthController>();
                bossHealth.GotShot();
            }
        }
    }
}
