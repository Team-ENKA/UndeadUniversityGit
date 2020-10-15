using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHurt : MonoBehaviour
{

    public float playerInvincibility;
    public pcHealthController ph ;

    void OnCollisionStay2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy" && playerInvincibility <= 0)
        {

            ph.LowerHealth();
            playerInvincibility = 3;

        }

    }

    // Update is called once per frame
    void Update()
    {

        playerInvincibility = playerInvincibility - Time.deltaTime;

    }
}
