using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieActivator : MonoBehaviour
{
    public GameObject zombieGroup;
    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            zombieGroup.SetActive(true);
        }

    }
}
