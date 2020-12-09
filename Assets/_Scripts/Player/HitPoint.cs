using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPoint : MonoBehaviour
{

    public float maxTTD = 5f;
    public float minTTD = 3f;
    public float maxPForce = 3f;
    public float minPForce = -3f;

    // Start is called before the first frame update
    void Start()
    {

        Vector2 deathParticleForce = new Vector2(Random.Range(minPForce, maxPForce), Random.Range(minPForce, maxPForce));

        Destroy(gameObject, Random.Range(minTTD, maxTTD));
        gameObject.GetComponent<Rigidbody2D>().AddForce(deathParticleForce, ForceMode2D.Impulse);

    }

}
