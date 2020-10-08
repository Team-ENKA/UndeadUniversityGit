using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public Sprite[] EnemyFullHealth;
    private int enemyhealthbar = 4;
    public GameObject Zombie;
    public CuredZombie CuredZ;
    public CuredHuman CuredH;
    public SpriteRenderer SpriteRenderer;
    public GameObject zombieSprite;

    // Start is called before the first frame update
    void Start()
    {

        transform.GetComponent<SpriteRenderer>().sprite = EnemyFullHealth[enemyhealthbar];
        SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();

    }

    public void LowerHealth()
    {
        //Removes 1 health from the zombie and turns on the health sprite
        enemyhealthbar--;
        SpriteRenderer.enabled = true;

        //Checks if the zombie has health left, if not it destroys the zombie
        if (enemyhealthbar >= 1)
        {
            transform.GetComponent<SpriteRenderer>().sprite = EnemyFullHealth[enemyhealthbar];
        }
        else
        {

            Destroy(zombieSprite);
            SpriteRenderer.enabled = false;
            Zombie.GetComponentInChildren<CuredZombie>().CuredZ();
            Zombie.GetComponentInChildren<CuredHuman>().CuredH();

        }

    }

}
