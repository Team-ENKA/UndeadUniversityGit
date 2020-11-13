using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnParticle : MonoBehaviour
{

    public GameObject particle;
    private GameObject meleeATK;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("i"))
        {

            meleeATK = Instantiate(particle, transform.position, Quaternion.identity);
            Destroy(meleeATK, 0.5f);
            meleeATK.transform.Rotate(new Vector3(meleeATK.transform.rotation.x, meleeATK.transform.rotation.y, meleeATK.transform.rotation.z + 4000 * Time.deltaTime));

        }


    }
}
