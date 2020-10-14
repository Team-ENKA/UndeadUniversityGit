using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiBacGrenade : MonoBehaviour
{

    public float fuse = 3;
    public GameObject grenadeParticles;

    // Start is called before the first frame update
    void Start()
    {

        Destroy(gameObject, 3.02f);

        Vector2 antiBacGrenadeForce = new Vector2(0, -200);
        gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(antiBacGrenadeForce, ForceMode2D.Impulse);

    }

    // Update is called once per frame
    void Update()
    {

        fuse = fuse - Time.deltaTime;
        if (fuse <= 0)
            for (int i = 0; i < 25; i++)
                Instantiate(grenadeParticles, transform.position, Quaternion.identity);

    }
}
