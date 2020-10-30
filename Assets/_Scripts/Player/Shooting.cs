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
    public NERFcounter nERFCounterScript;
    public GameObject hitPointParticle;
    public GameObject nERFHitPointParticle;
    public Transform lunchLassSprite;
    public float shootingCooldown;
    public float grenadeCooldown;

    // Update is called once per frame
    void Update()
    {

        shootingCooldown = shootingCooldown - Time.deltaTime;
        grenadeCooldown = grenadeCooldown - Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Mouse0) && shootingCooldown <= 0f)
        {

            ammoCounterScript.AmmoCheck();

        }

        if (Input.GetKeyDown(KeyCode.Mouse1) && grenadeCooldown <= 0f)
        {
            nERFCounterScript.AmmoCheck();
            //grenadeCooldown = 2f;
            //Instantiate(nERFHitPointParticle, capsuleTransform.position, lunchLassSprite.rotation);
        }
    }

    public void Shoot()
    {
        //Creates a new Vector2 using the the first components x and y transforms
        shotOrigin = new Vector2(capsuleTransform.position.x, capsuleTransform.position.y);
        RaycastHit2D hit = Physics2D.Linecast(shotOrigin, shootingDirection.position);
        Debug.DrawLine(shotOrigin, shootingDirection.position, Color.green, 20f);

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
            }
   
            if (hit.collider.tag == "Boss")
            {
                bossHealth = hit.collider.gameObject.GetComponentInChildren<BossHealthController>();
                bossHealth.GotShot();
            }
        }
    }
    public void NERFShoot()
    {
        shotOrigin = new Vector2(capsuleTransform.position.x, capsuleTransform.position.y);
        RaycastHit2D hit = Physics2D.Linecast(shotOrigin, shootingDirection.position);
        Debug.DrawLine(shotOrigin, hit.point, Color.red, 20f);

        if (hit.collider != null)
        {
            Vector3 hitPoint = new Vector3(hit.point.x, hit.point.y, 0f);

            float nERFhitPointParticles = Random.Range(2, 6);
            for (int i = 0; i < nERFhitPointParticles; i++)
            {
                Instantiate(nERFHitPointParticle, hitPoint, Quaternion.identity);
            }

            if (hit.collider.tag == "Enemy")
            {
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
