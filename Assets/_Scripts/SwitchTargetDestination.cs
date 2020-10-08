﻿using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTargetDestination : MonoBehaviour
{

    public AIDestinationSetter targetDestination1;
    public AIDestinationSetter targetDestination2;

    public void SwitchTarget()
    {

        targetDestination1.enabled = false;
        targetDestination2.enabled = true;

    }

}