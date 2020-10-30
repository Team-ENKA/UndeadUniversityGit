using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnParticle : MonoBehaviour
{

    public GameObject attack;
    private GameObject meleeATK;
    public float meleeATKCooldown;

    // Update is called once per frame
    void Update()
    {

        meleeATKCooldown = meleeATKCooldown - Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {

            meleeATK = Instantiate(attack, transform.position, transform.rotation);
            meleeATKCooldown = 0.18f;
            Destroy(meleeATK, 0.18f);

        }

        if (meleeATKCooldown >= 0)
            meleeATK.transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z + 600 * Time.deltaTime));

    }
}
