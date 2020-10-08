using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphUpdater : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if(collision.tag == "Player")
        {

            Bounds bounds = GetComponent<Collider2D>().bounds;
            AstarPath.active.UpdateGraphs(bounds);

        }

    }

}
