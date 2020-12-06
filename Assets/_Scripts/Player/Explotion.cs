using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explotion : MonoBehaviour
{

    public Rigidbody2D RB;
    public GameObject explosionPS;
    public Transform t;
    CircleCollider2D circleCol;
    new List<GameObject> zombies;

    private void Start()
    {

        t = GetComponent<Transform>();
        RB.AddTorque(Random.Range(-2, 2));

    }

    private void Update()
    {

        RB.AddRelativeForce(Vector2.down * Time.deltaTime * 6000f);

        foreach(GameObject Element in zombies)
        {

            Element.AddComponent<StunZombie>().Stunned(4);

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag != "Player")
        {

            GameObject explosionParticleSystem = Instantiate(explosionPS, transform.position, Quaternion.identity);
            Destroy(explosionParticleSystem, 6);
            Destroy(gameObject);
            circleCol = gameObject.AddComponent<CircleCollider2D>();
            circleCol.isTrigger = true;
            circleCol.radius = 10;

        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if(collision.gameObject.tag == ("Enemy"))
        {

            zombies.Add(collision.gameObject);

        }

        if (zombies.Count >= 5)
        {

            Destroy(circleCol);

        }

    }

}
