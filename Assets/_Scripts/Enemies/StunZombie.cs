using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class StunZombie : MonoBehaviour
{

    public AIDestinationSetter destinationSetter;

    public void Stunned(float stunTime)
    {

        StartCoroutine(StunnedZombieTimer(stunTime));
        destinationSetter.enabled = false;

    }

    IEnumerator StunnedZombieTimer(float time)
    {

        yield return new WaitForSeconds(time);

        destinationSetter.enabled = true;
        Destroy(gameObject.GetComponent<StunZombie>());

    }

}
