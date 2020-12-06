using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explotion : MonoBehaviour
{

    public Rigidbody2D RB;
    public GameObject explosionPS;
    public Transform t;
    CircleCollider2D circleCol;
    public new List<GameObject> zombies;

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

            if(!Element.GetComponent<StunZombie>())
                Element.AddComponent<StunZombie>().Stunned(8);

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject explosionParticleSystem = Instantiate(explosionPS, transform.position, Quaternion.identity);
        Destroy(explosionParticleSystem, 6);
        RB.isKinematic = true;
        RB.velocity = Vector2.zero;
        Destroy(gameObject.GetComponent<SpriteRenderer>());
        Destroy(gameObject, 1);
        circleCol = gameObject.AddComponent<CircleCollider2D>();
        circleCol.isTrigger = true;
        circleCol.radius = 20;
        circleCol.offset = Vector2.zero;

    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if(collision.gameObject.tag == ("Enemy"))
        {

            zombies.Add(collision.gameObject);

        }

    }

}
