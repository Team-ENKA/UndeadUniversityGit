using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntibacSledge : MonoBehaviour
{

    public GameObject attack;
    private GameObject meleeATK;
    public float meleeATKCooldown;
    public bool sledgeCraft;
    public GameObject pS;
    public PlaySound playSound;

    private void Start()
    {

        pS = GameObject.FindGameObjectWithTag("PlayerSFX");
        playSound = pS.GetComponent<PlaySound>();

    }

    // Update is called once per frame
    public void Update()
    {

        meleeATKCooldown = meleeATKCooldown - Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && meleeATKCooldown <= 0f && sledgeCraft == true)

        {

            meleeATK = Instantiate(attack, transform.position, transform.rotation);
            meleeATKCooldown = 0.18f;
            Destroy(meleeATK, 0.18f);
            playSound.AntibacSledgeSwing();

        }

        if (meleeATKCooldown >= 0)
            meleeATK.transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z + 600 * Time.deltaTime));

    }
}
