using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shooting : MonoBehaviour
{

    public Transform shootingDirection;
    public EnemyHealthController enemyHealth;
    public ZombieInfectionController zombieInfection;
    public ZombieDamageController zombieDamage;
    public GameObject hitPointParticle;
    public GameObject shootingParticle;
    public GameObject nERFHitPointParticle;
    public GameObject Rocket;
    public Transform lunchLassSprite;
    public GameObject Bo;
    public Transform BoTransform;
    public Transform BoSpriteTransform;
    public Transform fireworksLaunchPoint;
    public NERFcounter NERFcounter;
    public float shootingCooldown;
    public float grenadeCooldown;
    public float fireRate;
    public float grenadeRate;
    public int layerMask = 1 << 13;
    public int layerMask2 = 1 << 2;

    private void Start()
    {

        layerMask = ~(layerMask | layerMask2);
        Bo = GameObject.FindGameObjectWithTag("Player");
        BoTransform = Bo.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {

        shootingCooldown = shootingCooldown - Time.deltaTime;
        grenadeCooldown = grenadeCooldown - Time.deltaTime;

        if (Input.GetKey(KeyCode.Mouse0) && shootingCooldown <= 0f)
        {

            Shoot();
            shootingCooldown = fireRate;

        }

        if (Input.GetKey(KeyCode.Mouse1) && shootingCooldown <= 0f)
        {

            NERFcounter.AmmoCheck();
            shootingCooldown = fireRate;

        }

        if (Input.GetKey(KeyCode.F) && grenadeCooldown <= 0f)
        {

            FireWorks();
            grenadeCooldown = grenadeRate;

        }
    }

    public void Shoot()
    {

        //Creates a new Vector2 using the the first components x and y transforms
        RaycastHit2D hit = Physics2D.Linecast(BoTransform.position, shootingDirection.position, layerMask);
        Debug.DrawLine(BoTransform.position, shootingDirection.position, Color.green, 20f);

        float shootingParticles = Random.Range(2, 4);

        for (int i = 0; i < shootingParticles; i++)
        {

            Instantiate(shootingParticle, fireworksLaunchPoint.position, Quaternion.identity);

        }

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

                if (Input.GetKeyDown(KeyCode.Mouse0))
                {

                    zombieInfection = hit.collider.gameObject.GetComponentInChildren<ZombieInfectionController>();
                    zombieInfection.GotShot();

                }

            }

        }

    }

    public void FireWorks()
    {

        Instantiate(Rocket, fireworksLaunchPoint.position, BoSpriteTransform.rotation);

    }

    public void NERFShoot()
    {
        RaycastHit2D hit = Physics2D.Linecast(BoTransform.position, shootingDirection.position, layerMask);
        Debug.DrawLine(BoTransform.position, shootingDirection.position, Color.green, 20f);

        if (hit.collider != null)
        {
            Vector3 hitPoint = new Vector3(hit.point.x, hit.point.y, 0f);

            Instantiate(nERFHitPointParticle, hitPoint, Quaternion.identity);

            if (hit.collider.tag == "Enemy")
            {

                if (Input.GetKeyDown(KeyCode.Mouse1))
                {

                    zombieInfection = hit.collider.gameObject.GetComponentInChildren<ZombieInfectionController>();
                    zombieInfection.GotGrenaded();

                }

            }

        }

    }

}
