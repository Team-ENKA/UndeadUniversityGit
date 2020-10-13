using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{

    public Sprite[] EnemyFullHealth;
    private int enemyhealthbar = 8;
    public GameObject Zombie;
    public CuredZombie CuredZ;
    public CuredHuman CuredH;
    public Follower FollowScript;
    public SpriteRenderer SpriteRenderer;

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

            Destroy(Zombie.GetComponentInChildren<Collider2D>());
            SpriteRenderer.enabled = false;
            Zombie.GetComponentInChildren<CuredZombie>().CuredZ();
            Zombie.GetComponentInChildren<CuredHuman>().CuredH();
            Zombie.GetComponent<Follower>().enabled = false;

        }

    }

}
