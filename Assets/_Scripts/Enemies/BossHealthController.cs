using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealthController : MonoBehaviour
{
    public BossHealth bh;

    public void GotShot()
    {

        bh.LowerHealth();

    }

}
