using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explotion : MonoBehaviour
{

    public Rigidbody2D RB;
    public GameObject explosionPS;
    public Transform t;

    private void Start()
    {

        t = GetComponent<Transform>();
        RB.AddTorque(Random.Range(-2, 2));

    }

    private void Update()
    {

        RB.AddRelativeForce(Vector2.down * Time.deltaTime * 6000f);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag != "Player")
        {

            GameObject EPS = Instantiate(explosionPS, transform.position, Quaternion.identity);
            Destroy(EPS, 6);
            Destroy(gameObject);

        }

    }

}
