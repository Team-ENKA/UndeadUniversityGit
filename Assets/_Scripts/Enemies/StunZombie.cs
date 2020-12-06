using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class StunZombie : MonoBehaviour
{

    public AIDestinationSetter destinationSetter;
    public PlayerDetection playerDetection;

    public void Stunned(float stunTime)
    {

        StartCoroutine(StunnedZombieTimer(stunTime));
        destinationSetter = gameObject.GetComponentInParent<AIDestinationSetter>();
        destinationSetter.enabled = false;
        playerDetection = gameObject.GetComponentInParent<PlayerDetection>();
        playerDetection.enabled = false;

    }

    IEnumerator StunnedZombieTimer(float time)
    {

        yield return new WaitForSeconds(time);

        destinationSetter.enabled = true;
        playerDetection.enabled = true;
        Destroy(gameObject.GetComponent<StunZombie>());

    }

}
