using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathParticle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Vector2 deathParticleForce = new Vector2(Random.Range(-700f, 701f), Random.Range(-700f, 701f));

        Destroy(gameObject, Random.Range(2f, 4f));
        gameObject.GetComponent<Rigidbody2D>().AddForce(deathParticleForce, ForceMode2D.Impulse);

    }

}
