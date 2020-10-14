using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTargetDestination : MonoBehaviour
{

    public AIDestinationSetter targetDestination1;
    public AIDestinationSetter targetDestination2;
    public Patrol patrolPoints;

    public void SwitchTarget()
    {

        targetDestination1.enabled = false;
        patrolPoints.enabled = true;

    }

}
