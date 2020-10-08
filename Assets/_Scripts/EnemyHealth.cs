using Pathfinding;
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
    public SpriteRenderer spriteRenderer;
    public GameObject zombieSprite;
    public AIDestinationSetter AiDestination1;
    public AIDestinationSetter AiDestination2;

    // Start is called before the first frame update
    void Start()
    {

        spriteRenderer.sprite = EnemyFullHealth[enemyhealthbar];
    }

    public void LowerHealth()
    {
        //Removes 1 health from the zombie and turns on the health sprite
        enemyhealthbar--;
        spriteRenderer.enabled = true;

        //Checks if the zombie has health left, if not it destroys the zombie
        if (enemyhealthbar >= 1)
        {
            spriteRenderer.sprite = EnemyFullHealth[enemyhealthbar];
        }
        else
        {

            Destroy(zombieSprite);
            spriteRenderer.enabled = false;
            Zombie.GetComponentInChildren<CuredZombie>().CuredZ();
            Zombie.GetComponentInChildren<CuredHuman>().CuredH();
            AiDestination1.enabled = false;
            AiDestination2.enabled = true;

        }

    }

}
