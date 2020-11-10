﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntibacSledge : MonoBehaviour
{

    public GameObject attack;
    private GameObject meleeATK;
    public float meleeATKCooldown;
    public bool sledgeCraft;

    // Update is called once per frame
    public void Update()
    {

        meleeATKCooldown = meleeATKCooldown - Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && sledgeCraft==true)
        {

            meleeATK = Instantiate(attack, transform.position, transform.rotation);
            meleeATKCooldown = 0.18f;
            Destroy(meleeATK, 0.18f);

        }

        if (meleeATKCooldown >= 0)
            meleeATK.transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z + 600 * Time.deltaTime));

    }
}
