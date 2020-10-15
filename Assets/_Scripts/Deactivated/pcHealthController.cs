using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pcHealthController : MonoBehaviour
{
    public Sprite[] FullHealth;
    private int healthbar = 2;
    public GameObject LunchLass;
    public int deathEffectParticles;
    public GameObject deathParticle;

    // Start is called before the first frame update
    void Start()
    {

        transform.GetComponent<SpriteRenderer>().sprite = FullHealth[healthbar];

    }

    private void Update()
    {

        if (Input.GetKey("o"))
            for (int j = 0; j < healthbar;)
                LowerHealth();

    }

    public void LowerHealth()
    {

        healthbar--;

        if (healthbar >= 1)
        {

            transform.GetComponent<SpriteRenderer>().sprite = FullHealth[healthbar];

        }
        else
        {

            for (int i = 0; i < deathEffectParticles; i++)
                Instantiate(deathParticle, transform.position, Quaternion.identity);
            Destroy(LunchLass);


        }

    }

}