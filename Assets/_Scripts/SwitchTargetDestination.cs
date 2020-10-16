using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTargetDestination : MonoBehaviour
{

    public AIDestinationSetter infectedDestination;
    public AIDestinationSetter curedDestination;
    public Patrol patrolPoints;

    public void SwitchTarget()
    {

        infectedDestination.enabled = false;
        curedDestination.enabled = true;

    }

}
