using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPoint : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        Vector2 deathParticleForce = new Vector2(Random.Range(-25f, 26f), Random.Range(-25f, 26f));

        Destroy(gameObject, Random.Range(4f, 6f));
        gameObject.GetComponent<Rigidbody2D>().AddForce(deathParticleForce, ForceMode2D.Impulse);

    }

}
